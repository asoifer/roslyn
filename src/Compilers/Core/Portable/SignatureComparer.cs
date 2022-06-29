// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.RuntimeMembers
{
    internal abstract class SignatureComparer<MethodSymbol, FieldSymbol, PropertySymbol, TypeSymbol, ParameterSymbol>
            where MethodSymbol : class
            where FieldSymbol : class
            where PropertySymbol : class
            where TypeSymbol : class
            where ParameterSymbol : class
    {        /// <summary>
             /// Returns true if signature matches signature of the field.
             /// Signature should be in format described in MemberDescriptor.
             /// </summary>
        public bool MatchFieldSignature(FieldSymbol field, ImmutableArray<byte> signature)
        {
            int position = 0;

            // get the type
            bool result = MatchType(GetFieldType(field), signature, ref position);

            Debug.Assert(!result || position == signature.Length);
            return result;
        }

        /// <summary>
        /// Returns true if signature matches signature of the property.
        /// Signature should be in format described in MemberDescriptor.
        /// </summary>
        public bool MatchPropertySignature(PropertySymbol property, ImmutableArray<byte> signature)
        {
            int position = 0;

            // Get the parameter count
            int paramCount = signature[position++];

            // Get all of the parameters.
            ImmutableArray<ParameterSymbol> parameters = GetParameters(property);

            if (paramCount != parameters.Length)
            {
                return false;
            }

            bool isByRef = IsByRef(signature, ref position);
            if (IsByRefProperty(property) != isByRef)
            {
                return false;
            }

            // get the property type
            if (!MatchType(GetPropertyType(property), signature, ref position))
            {
                return false;
            }

            // Match parameters
            foreach (ParameterSymbol parameter in parameters)
            {
                if (!MatchParameter(parameter, signature, ref position))
                {
                    return false;
                }
            }

            Debug.Assert(position == signature.Length);
            return true;
        }

        /// <summary>
        /// Returns true if signature matches signature of the method.
        /// Signature should be in format described in MemberDescriptor.
        /// </summary>
        public bool MatchMethodSignature(MethodSymbol method, ImmutableArray<byte> signature)
        {
            int position = 0;

            // Get the parameter count
            int paramCount = signature[position++];

            // Get all of the parameters.
            ImmutableArray<ParameterSymbol> parameters = GetParameters(method);

            if (paramCount != parameters.Length)
            {
                return false;
            }

            bool isByRef = IsByRef(signature, ref position);

            if (IsByRefMethod(method) != isByRef)
            {
                return false;
            }

            // get the return type
            if (!MatchType(GetReturnType(method), signature, ref position))
            {
                return false;
            }

            // Match parameters
            foreach (ParameterSymbol parameter in parameters)
            {
                if (!MatchParameter(parameter, signature, ref position))
                {
                    return false;
                }
            }

            Debug.Assert(position == signature.Length);
            return true;
        }

        private bool MatchParameter(ParameterSymbol parameter, ImmutableArray<byte> signature, ref int position)
        {
            bool isByRef = IsByRef(signature, ref position);

            if (IsByRefParam(parameter) != isByRef)
            {
                return false;
            }

            return MatchType(GetParamType(parameter), signature, ref position);
        }

        private static bool IsByRef(ImmutableArray<byte> signature, ref int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(30, 4611, 5022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4713, 4781);

                SignatureTypeCode
                typeCode = (SignatureTypeCode)signature[position]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4797, 5011) || true) && (typeCode == SignatureTypeCode.ByReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 4797, 5011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4876, 4887);

                    position++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4905, 4917);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 4797, 5011);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 4797, 5011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 4983, 4996);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 4797, 5011);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(30, 4611, 5022);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(30, 4611, 5022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 4611, 5022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }


        /// <summary>
        /// Does pretty much the same thing as MetadataDecoder.DecodeType only instead of 
        /// producing a type symbol it compares encoded type to the target.
        /// 
        /// Signature should be in format described in MemberDescriptor.
        /// </summary>
        private bool MatchType(TypeSymbol? type, ImmutableArray<byte> signature, ref int position)
        {
            if (type == null)
            {
                return false;
            }

            int paramPosition;

            // Get the type.
            SignatureTypeCode typeCode = (SignatureTypeCode)signature[position++];

            // Switch on the type.
            switch (typeCode)
            {
                case SignatureTypeCode.TypeHandle:
                    // Ecma-335 spec:
                    // 23.1.16 Element types used in signatures
                    // ...
                    // ELEMENT_TYPE_VALUETYPE 0x11 Followed by TypeDef or TypeRef token
                    // ELEMENT_TYPE_CLASS 0x12 Followed by TypeDef or TypeRef token
                    short expectedType = ReadTypeId(signature, ref position);
                    return MatchTypeToTypeId(type, expectedType);

                case SignatureTypeCode.Array:
                    if (!MatchType(GetMDArrayElementType(type), signature, ref position))
                    {
                        return false;
                    }

                    int countOfDimensions = signature[position++];

                    return MatchArrayRank(type, countOfDimensions);

                case SignatureTypeCode.SZArray:
                    return MatchType(GetSZArrayElementType(type), signature, ref position);

                case SignatureTypeCode.Pointer:
                    return MatchType(GetPointedToType(type), signature, ref position);

                case SignatureTypeCode.GenericTypeParameter:
                    paramPosition = signature[position++];
                    return IsGenericTypeParam(type, paramPosition);

                case SignatureTypeCode.GenericMethodParameter:
                    paramPosition = signature[position++];
                    return IsGenericMethodTypeParam(type, paramPosition);

                case SignatureTypeCode.GenericTypeInstance:
                    if (!MatchType(GetGenericTypeDefinition(type), signature, ref position))
                    {
                        return false;
                    }

                    int argumentCount = signature[position++];

                    for (int argumentIndex = 0; argumentIndex < argumentCount; argumentIndex++)
                    {
                        if (!MatchType(GetGenericTypeArgument(type, argumentIndex), signature, ref position))
                        {
                            return false;
                        }
                    }

                    return true;

                default:
                    throw ExceptionUtilities.UnexpectedValue(typeCode);
            }
        }

        private static short ReadTypeId(ImmutableArray<byte> signature, ref int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(30, 8347, 8762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 8453, 8491);

                var
                firstByte = signature[position++]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 8505, 8751) || true) && (firstByte == (byte)WellKnownType.ExtSentinel)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 8505, 8751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 8587, 8653);

                    return (short)(signature[position++] + WellKnownType.ExtSentinel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 8505, 8751);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(30, 8505, 8751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(30, 8719, 8736);

                    return firstByte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(30, 8505, 8751);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(30, 8347, 8762);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(30, 8347, 8762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 8347, 8762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract TypeSymbol? GetGenericTypeArgument(TypeSymbol type, int argumentIndex);

        protected abstract TypeSymbol? GetGenericTypeDefinition(TypeSymbol type);

        protected abstract bool IsGenericMethodTypeParam(TypeSymbol type, int paramPosition);

        protected abstract bool IsGenericTypeParam(TypeSymbol type, int paramPosition);

        protected abstract TypeSymbol? GetPointedToType(TypeSymbol type);

        protected abstract TypeSymbol? GetSZArrayElementType(TypeSymbol type);

        protected abstract bool MatchArrayRank(TypeSymbol type, int countOfDimensions);

        protected abstract TypeSymbol? GetMDArrayElementType(TypeSymbol type);

        protected abstract bool MatchTypeToTypeId(TypeSymbol type, int typeId);

        protected abstract TypeSymbol GetReturnType(MethodSymbol method);

        protected abstract ImmutableArray<ParameterSymbol> GetParameters(MethodSymbol method);

        protected abstract TypeSymbol GetPropertyType(PropertySymbol property);

        protected abstract ImmutableArray<ParameterSymbol> GetParameters(PropertySymbol property);

        protected abstract TypeSymbol GetParamType(ParameterSymbol parameter);

        protected abstract bool IsByRefParam(ParameterSymbol parameter);

        protected abstract bool IsByRefMethod(MethodSymbol method);

        protected abstract bool IsByRefProperty(PropertySymbol property);

        protected abstract TypeSymbol GetFieldType(FieldSymbol field);

        public SignatureComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(30, 548, 10986);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(30, 548, 10986);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 548, 10986);
        }


        static SignatureComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(30, 548, 10986);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(30, 548, 10986);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(30, 548, 10986);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(30, 548, 10986);
    }
}
