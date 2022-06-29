// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    public readonly struct TypeInfo : IEquatable<TypeInfo>
    {

        internal static readonly TypeInfo None;

        public ITypeSymbol? Type { get; }

        public NullabilityInfo Nullability { get; }

        public ITypeSymbol? ConvertedType { get; }

        public NullabilityInfo ConvertedNullability { get; }

        internal TypeInfo(ITypeSymbol? type, ITypeSymbol? convertedType, NullabilityInfo nullability, NullabilityInfo convertedNullability)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(170, 1765, 2371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(170, 1943, 2037);

                f_170_1943_2036(type is null || (DynAbs.Tracing.TraceSender.Expression_False(170, 1956, 2035) || f_170_1972_1995(type) == f_170_1999_2035(nullability.FlowState)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(170, 2051, 2172);

                f_170_2051_2171(convertedType is null || (DynAbs.Tracing.TraceSender.Expression_False(170, 2064, 2170) || f_170_2089_2121(convertedType) == f_170_2125_2170(convertedNullability.FlowState)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(170, 2186, 2203);

                this.Type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(170, 2217, 2248);

                this.Nullability = nullability;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(170, 2262, 2297);

                this.ConvertedType = convertedType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(170, 2311, 2360);

                this.ConvertedNullability = convertedNullability;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(170, 1765, 2371);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(170, 1765, 2371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(170, 1765, 2371);
            }
        }

        public bool Equals(TypeInfo other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(170, 2383, 2716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(170, 2442, 2705);

                return f_170_2449_2485(this.Type, other.Type) && (DynAbs.Tracing.TraceSender.Expression_True(170, 2449, 2560) && f_170_2506_2560(this.ConvertedType, other.ConvertedType)) && (DynAbs.Tracing.TraceSender.Expression_True(170, 2449, 2623) && this.Nullability.Equals(other.Nullability)) && (DynAbs.Tracing.TraceSender.Expression_True(170, 2449, 2704) && this.ConvertedNullability.Equals(other.ConvertedNullability));
                DynAbs.Tracing.TraceSender.TraceExitMethod(170, 2383, 2716);

                bool
                f_170_2449_2485(Microsoft.CodeAnalysis.ITypeSymbol?
                objA, Microsoft.CodeAnalysis.ITypeSymbol?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(170, 2449, 2485);
                    return return_v;
                }


                bool
                f_170_2506_2560(Microsoft.CodeAnalysis.ITypeSymbol?
                objA, Microsoft.CodeAnalysis.ITypeSymbol?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(170, 2506, 2560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(170, 2383, 2716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(170, 2383, 2716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(170, 2728, 2857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(170, 2793, 2846);

                return obj is TypeInfo && (DynAbs.Tracing.TraceSender.Expression_True(170, 2800, 2845) && this.Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(170, 2728, 2857);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(170, 2728, 2857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(170, 2728, 2857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(170, 2869, 3141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(170, 2927, 3130);

                return f_170_2934_3129(this.ConvertedType, f_170_2984_3128(this.Type, f_170_3025_3127(this.Nullability.GetHashCode(), this.ConvertedNullability.GetHashCode())));
                DynAbs.Tracing.TraceSender.TraceExitMethod(170, 2869, 3141);

                int
                f_170_3025_3127(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(170, 3025, 3127);
                    return return_v;
                }


                int
                f_170_2984_3128(Microsoft.CodeAnalysis.ITypeSymbol?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(170, 2984, 3128);
                    return return_v;
                }


                int
                f_170_2934_3129(Microsoft.CodeAnalysis.ITypeSymbol?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(170, 2934, 3129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(170, 2869, 3141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(170, 2869, 3141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static TypeInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(170, 318, 3148);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(170, 423, 528);
            None = f_170_430_528(type: null, convertedType: null, nullability: default, convertedNullability: default); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(170, 318, 3148);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(170, 318, 3148);
        }

        static Microsoft.CodeAnalysis.TypeInfo
        f_170_430_528(Microsoft.CodeAnalysis.ITypeSymbol?
        type, Microsoft.CodeAnalysis.ITypeSymbol?
        convertedType, Microsoft.CodeAnalysis.NullabilityInfo
        nullability, Microsoft.CodeAnalysis.NullabilityInfo
        convertedNullability)
        {
            var return_v = new Microsoft.CodeAnalysis.TypeInfo(type: type, convertedType: convertedType, nullability: nullability, convertedNullability: convertedNullability);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(170, 430, 528);
            return return_v;
        }


        static Microsoft.CodeAnalysis.NullableAnnotation
        f_170_1972_1995(Microsoft.CodeAnalysis.ITypeSymbol
        this_param)
        {
            var return_v = this_param.NullableAnnotation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(170, 1972, 1995);
            return return_v;
        }


        static Microsoft.CodeAnalysis.NullableAnnotation
        f_170_1999_2035(Microsoft.CodeAnalysis.NullableFlowState
        nullableFlowState)
        {
            var return_v = nullableFlowState.ToAnnotation();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(170, 1999, 2035);
            return return_v;
        }


        static int
        f_170_1943_2036(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(170, 1943, 2036);
            return 0;
        }


        static Microsoft.CodeAnalysis.NullableAnnotation
        f_170_2089_2121(Microsoft.CodeAnalysis.ITypeSymbol
        this_param)
        {
            var return_v = this_param.NullableAnnotation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(170, 2089, 2121);
            return return_v;
        }


        static Microsoft.CodeAnalysis.NullableAnnotation
        f_170_2125_2170(Microsoft.CodeAnalysis.NullableFlowState
        nullableFlowState)
        {
            var return_v = nullableFlowState.ToAnnotation();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(170, 2125, 2170);
            return return_v;
        }


        static int
        f_170_2051_2171(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(170, 2051, 2171);
            return 0;
        }

    }
}
