// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal static class MetadataHelpers
    {
        public const char
        DotDelimiter = '.'
        ;

        public const string
        DotDelimiterString = "."
        ;

        public const char
        GenericTypeNameManglingChar = '`'
        ;

        private const string
        GenericTypeNameManglingString = "`"
        ;

        public const int
        MaxStringLengthForParamSize = 22
        ;

        public const int
        MaxStringLengthForIntToStringConversion = 22
        ;

        public const string
        SystemString = "System"
        ;

        public const char
        MangledNameRegionStartChar = '<'
        ;

        public const char
        MangledNameRegionEndChar = '>'
        ;

        internal struct AssemblyQualifiedTypeName
        {

            internal readonly string TopLevelType;

            internal readonly string[] NestedTypes;

            internal readonly AssemblyQualifiedTypeName[] TypeArguments;

            internal readonly int PointerCount;

            internal readonly int[] ArrayRanks;

            internal readonly string AssemblyName;

            internal AssemblyQualifiedTypeName(
                            string topLevelType,
                            string[] nestedTypes,
                            AssemblyQualifiedTypeName[] typeArguments,
                            int pointerCount,
                            int[] arrayRanks,
                            string assemblyName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(407, 1878, 2490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 2191, 2224);

                    this.TopLevelType = topLevelType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 2242, 2273);

                    this.NestedTypes = nestedTypes;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 2291, 2326);

                    this.TypeArguments = typeArguments;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 2344, 2377);

                    this.PointerCount = pointerCount;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 2395, 2424);

                    this.ArrayRanks = arrayRanks;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 2442, 2475);

                    this.AssemblyName = assemblyName;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(407, 1878, 2490);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 1878, 2490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 1878, 2490);
                }
            }
            static AssemblyQualifiedTypeName()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(407, 1308, 2501);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(407, 1308, 2501);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 1308, 2501);
            }
        }

        internal static AssemblyQualifiedTypeName DecodeTypeName(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 2513, 2704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 2604, 2647);

                var
                decoder = f_407_2618_2646(s)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 2661, 2693);

                return decoder.DecodeTypeName();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 2513, 2704);

                Microsoft.CodeAnalysis.MetadataHelpers.SerializedTypeDecoder
                f_407_2618_2646(string
                s)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataHelpers.SerializedTypeDecoder(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 2618, 2646);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 2513, 2704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 2513, 2704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct SerializedTypeDecoder
        {

            private static char[] s_typeNameDelimiters;

            private readonly string _input;

            private int _offset;

            internal SerializedTypeDecoder(string s)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(407, 3431, 3560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 3504, 3515);

                    _input = s;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 3533, 3545);

                    _offset = 0;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(407, 3431, 3560);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 3431, 3560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 3431, 3560);
                }
            }

            private void Advance()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(407, 3576, 3732);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 3631, 3717) || true) && (f_407_3635_3646_M(!EndOfInput))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 3631, 3717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 3688, 3698);

                        _offset++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 3631, 3717);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(407, 3576, 3732);

                    bool
                    f_407_3635_3646_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 3635, 3646);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 3576, 3732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 3576, 3732);
                }
            }

            private void AdvanceTo(int i)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(407, 3748, 3920);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 3810, 3905) || true) && (i <= f_407_3819_3832(_input))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 3810, 3905);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 3874, 3886);

                        _offset = i;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 3810, 3905);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(407, 3748, 3920);

                    int
                    f_407_3819_3832(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 3819, 3832);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 3748, 3920);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 3748, 3920);
                }
            }

            private bool EndOfInput
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(407, 3992, 4087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 4036, 4068);

                        return _offset >= f_407_4054_4067(_input);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(407, 3992, 4087);

                        int
                        f_407_4054_4067(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 4054, 4067);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 3936, 4102);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 3936, 4102);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private int Offset
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(407, 4169, 4247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 4213, 4228);

                        return _offset;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(407, 4169, 4247);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 4118, 4262);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 4118, 4262);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private char Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(407, 4331, 4417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 4375, 4398);

                        return f_407_4382_4397(_input, _offset);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(407, 4331, 4417);

                        char
                        f_407_4382_4397(string
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 4382, 4397);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 4278, 4432);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 4278, 4432);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            /// <summary>
            /// Decodes a type name.  A type name is a string which is terminated by the end of the string or one of the
            /// delimiters '+', ',', '[', ']'. '+' separates nested classes. '[' and ']'
            /// enclosed generic type arguments.  ',' separates types.
            /// </summary>
            internal AssemblyQualifiedTypeName DecodeTypeName(bool isTypeArgument = false, bool isTypeArgumentWithAssemblyName = false)
            {
                Debug.Assert(!isTypeArgumentWithAssemblyName || isTypeArgument);

                string topLevelType = null;
                ArrayBuilder<string> nestedTypesBuilder = null;
                AssemblyQualifiedTypeName[] typeArguments = null;
                int pointerCount = 0;
                ArrayBuilder<int> arrayRanksBuilder = null;
                string assemblyName = null;
                bool decodingTopLevelType = true;
                bool isGenericTypeName = false;

                var pooledStrBuilder = PooledStringBuilder.GetInstance();
                StringBuilder typeNameBuilder = pooledStrBuilder.Builder;

                while (!EndOfInput)
                {
                    int i = _input.IndexOfAny(s_typeNameDelimiters, _offset);
                    if (i >= 0)
                    {
                        char c = _input[i];

                        // Found name, which could be a generic name with arity.
                        // Generic type parameter count, if any, are handled in DecodeGenericName.
                        string decodedString = DecodeGenericName(i);
                        Debug.Assert(decodedString != null);

                        // Type name is generic if the decoded name of the top level type OR any of the outer types of a nested type had the '`' character.
                        isGenericTypeName = isGenericTypeName || decodedString.IndexOf(GenericTypeNameManglingChar) >= 0;
                        typeNameBuilder.Append(decodedString);

                        switch (c)
                        {
                            case '*':
                                if (arrayRanksBuilder != null)
                                {
                                    // Error case, array shape must be specified at the end of the type name.
                                    // Process as a regular character and continue.
                                    typeNameBuilder.Append(c);
                                }
                                else
                                {
                                    pointerCount++;
                                }

                                Advance();
                                break;

                            case '+':
                                if (arrayRanksBuilder != null || pointerCount > 0)
                                {
                                    // Error case, array shape must be specified at the end of the type name.
                                    // Process as a regular character and continue.
                                    typeNameBuilder.Append(c);
                                }
                                else
                                {
                                    // Type followed by nested type. Handle nested class separator and collect the nested types.
                                    HandleDecodedTypeName(typeNameBuilder.ToString(), decodingTopLevelType, ref topLevelType, ref nestedTypesBuilder);
                                    typeNameBuilder.Clear();
                                    decodingTopLevelType = false;
                                }

                                Advance();
                                break;

                            case '[':
                                // Is type followed by generic type arguments?
                                if (isGenericTypeName && typeArguments == null)
                                {
                                    Advance();
                                    if (arrayRanksBuilder != null || pointerCount > 0)
                                    {
                                        // Error case, array shape must be specified at the end of the type name.
                                        // Process as a regular character and continue.
                                        typeNameBuilder.Append(c);
                                    }
                                    else
                                    {
                                        // Decode type arguments.
                                        typeArguments = DecodeTypeArguments();
                                    }
                                }
                                else
                                {
                                    // Decode array shape.
                                    DecodeArrayShape(typeNameBuilder, ref arrayRanksBuilder);
                                }

                                break;

                            case ']':
                                if (isTypeArgument)
                                {
                                    // End of type arguments.  This occurs when the last type argument is a type in the
                                    // current assembly.
                                    goto ExitDecodeTypeName;
                                }
                                else
                                {
                                    // Error case, process as a regular character and continue.
                                    typeNameBuilder.Append(c);
                                    Advance();
                                    break;
                                }

                            case ',':
                                // A comma may separate a type name from its assembly name or a type argument from
                                // another type argument.
                                // If processing non-type argument or a type argument with assembly name,
                                // process the characters after the comma as an assembly name.
                                if (!isTypeArgument || isTypeArgumentWithAssemblyName)
                                {
                                    Advance();
                                    if (!EndOfInput && Char.IsWhiteSpace(Current))
                                    {
                                        Advance();
                                    }

                                    assemblyName = DecodeAssemblyName(isTypeArgumentWithAssemblyName);
                                }
                                goto ExitDecodeTypeName;

                            default:
                                throw ExceptionUtilities.UnexpectedValue(c);
                        }
                    }
                    else
                    {
                        typeNameBuilder.Append(DecodeGenericName(_input.Length));
                        goto ExitDecodeTypeName;
                    }
                }

ExitDecodeTypeName:
                HandleDecodedTypeName(typeNameBuilder.ToString(), decodingTopLevelType, ref topLevelType, ref nestedTypesBuilder);
                pooledStrBuilder.Free();

                return new AssemblyQualifiedTypeName(
                    topLevelType,
                    nestedTypesBuilder?.ToArrayAndFree(),
                    typeArguments,
                    pointerCount,
                    arrayRanksBuilder?.ToArrayAndFree(),
                    assemblyName);
            }

            private static void HandleDecodedTypeName(string decodedTypeName, bool decodingTopLevelType, ref string topLevelType, ref ArrayBuilder<string> nestedTypesBuilder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 12323, 13151);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 12518, 13136) || true) && (f_407_12522_12544(decodedTypeName) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 12518, 13136);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 12591, 13117) || true) && (decodingTopLevelType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 12591, 13117);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 12665, 12700);

                            f_407_12665_12699(topLevelType == null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 12726, 12757);

                            topLevelType = decodedTypeName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(407, 12591, 13117);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 12591, 13117);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 12855, 13026) || true) && (nestedTypesBuilder == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 12855, 13026);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 12943, 12999);

                                nestedTypesBuilder = f_407_12964_12998();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(407, 12855, 13026);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 13054, 13094);

                            f_407_13054_13093(
                                                    nestedTypesBuilder, decodedTypeName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(407, 12591, 13117);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 12518, 13136);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 12323, 13151);

                    int
                    f_407_12522_12544(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 12522, 12544);
                        return return_v;
                    }


                    int
                    f_407_12665_12699(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 12665, 12699);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    f_407_12964_12998()
                    {
                        var return_v = ArrayBuilder<string>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 12964, 12998);
                        return return_v;
                    }


                    int
                    f_407_13054_13093(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    this_param, string
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 13054, 13093);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 12323, 13151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 12323, 13151);
                }
            }

            private string DecodeGenericName(int i)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(407, 13330, 13940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 13402, 13479);

                    f_407_13402_13478(i == f_407_13420_13433(_input) || (DynAbs.Tracing.TraceSender.Expression_False(407, 13415, 13477) || f_407_13437_13477(s_typeNameDelimiters, f_407_13467_13476(_input, i))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 13499, 13524);

                    var
                    length = i - _offset
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 13542, 13638) || true) && (length == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 13542, 13638);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 13599, 13619);

                        return String.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 13542, 13638);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 13764, 13784);

                    int
                    start = _offset
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 13802, 13815);

                    AdvanceTo(i);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 13877, 13925);

                    return f_407_13884_13924(_input, start, _offset - start);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(407, 13330, 13940);

                    int
                    f_407_13420_13433(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 13420, 13433);
                        return return_v;
                    }


                    char
                    f_407_13467_13476(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 13467, 13476);
                        return return_v;
                    }


                    bool
                    f_407_13437_13477(char[]
                    list, char
                    item)
                    {
                        var return_v = list.Contains<char>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 13437, 13477);
                        return return_v;
                    }


                    int
                    f_407_13402_13478(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 13402, 13478);
                        return 0;
                    }


                    string
                    f_407_13884_13924(string
                    this_param, int
                    startIndex, int
                    length)
                    {
                        var return_v = this_param.Substring(startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 13884, 13924);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 13330, 13940);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 13330, 13940);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private AssemblyQualifiedTypeName[] DecodeTypeArguments()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(407, 13956, 15339);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 14046, 14133) || true) && (EndOfInput)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 14046, 14133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 14102, 14114);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 14046, 14133);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 14153, 14225);

                    var
                    typeBuilder = f_407_14171_14224()
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 14245, 15268) || true) && (f_407_14252_14263_M(!EndOfInput))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 14245, 15268);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 14305, 14343);

                            f_407_14305_14342(typeBuilder, DecodeTypeArgument());

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 14367, 15249) || true) && (f_407_14371_14382_M(!EndOfInput))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 14367, 15249);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 14432, 15226);

                                switch (Current)
                                {

                                    case ',':
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 14432, 15226);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 14611, 14621);

                                        Advance();

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 14655, 14819) || true) && (f_407_14659_14670_M(!EndOfInput) && (DynAbs.Tracing.TraceSender.Expression_True(407, 14659, 14700) && f_407_14674_14700(Current)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 14655, 14819);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 14774, 14784);

                                            Advance();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(407, 14655, 14819);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(407, 14853, 14859);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 14432, 15226);

                                    case ']':
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 14432, 15226);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 14992, 15002);

                                        Advance();
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 15036, 15072);

                                        return f_407_15043_15071(typeBuilder);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 14432, 15226);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 14432, 15226);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 15146, 15199);

                                        throw f_407_15152_15198(EndOfInput);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 14432, 15226);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(407, 14367, 15249);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(407, 14245, 15268);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(407, 14245, 15268);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(407, 14245, 15268);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 15288, 15324);

                    return f_407_15295_15323(typeBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(407, 13956, 15339);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName>
                    f_407_14171_14224()
                    {
                        var return_v = ArrayBuilder<AssemblyQualifiedTypeName>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 14171, 14224);
                        return return_v;
                    }


                    bool
                    f_407_14252_14263_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 14252, 14263);
                        return return_v;
                    }


                    int
                    f_407_14305_14342(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName>
                    this_param, Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 14305, 14342);
                        return 0;
                    }


                    bool
                    f_407_14371_14382_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 14371, 14382);
                        return return_v;
                    }


                    bool
                    f_407_14659_14670_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 14659, 14670);
                        return return_v;
                    }


                    bool
                    f_407_14674_14700(char
                    c)
                    {
                        var return_v = Char.IsWhiteSpace(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 14674, 14700);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName[]
                    f_407_15043_15071(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName>
                    this_param)
                    {
                        var return_v = this_param.ToArrayAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 15043, 15071);
                        return return_v;
                    }


                    System.Exception
                    f_407_15152_15198(bool
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 15152, 15198);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName[]
                    f_407_15295_15323(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName>
                    this_param)
                    {
                        var return_v = this_param.ToArrayAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 15295, 15323);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 13956, 15339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 13956, 15339);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private AssemblyQualifiedTypeName DecodeTypeArgument()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(407, 15355, 16089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 15442, 15486);

                    bool
                    isTypeArgumentWithAssemblyName = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 15504, 15653) || true) && (Current == '[')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 15504, 15653);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 15564, 15602);

                        isTypeArgumentWithAssemblyName = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 15624, 15634);

                        Advance();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 15504, 15653);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 15673, 15809);

                    AssemblyQualifiedTypeName
                    result = DecodeTypeName(isTypeArgument: true, isTypeArgumentWithAssemblyName: isTypeArgumentWithAssemblyName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 15829, 16040) || true) && (isTypeArgumentWithAssemblyName)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 15829, 16040);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 15905, 16021) || true) && (f_407_15909_15920_M(!EndOfInput) && (DynAbs.Tracing.TraceSender.Expression_True(407, 15909, 15938) && Current == ']'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 15905, 16021);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 15988, 15998);

                            Advance();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(407, 15905, 16021);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 15829, 16040);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16060, 16074);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(407, 15355, 16089);

                    bool
                    f_407_15909_15920_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 15909, 15920);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 15355, 16089);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 15355, 16089);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private string DecodeAssemblyName(bool isTypeArgumentWithAssemblyName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(407, 16105, 16838);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16208, 16295) || true) && (EndOfInput)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 16208, 16295);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16264, 16276);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 16208, 16295);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16315, 16321);

                    int
                    i
                    = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16339, 16689) || true) && (isTypeArgumentWithAssemblyName)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 16339, 16689);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16415, 16448);

                        i = f_407_16419_16447(_input, ']', _offset);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16470, 16570) || true) && (i < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 16470, 16570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16529, 16547);

                            i = f_407_16533_16546(_input);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(407, 16470, 16570);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 16339, 16689);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 16339, 16689);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16652, 16670);

                        i = f_407_16656_16669(_input);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 16339, 16689);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16709, 16762);

                    string
                    name = f_407_16723_16761(_input, _offset, i - _offset)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16780, 16793);

                    AdvanceTo(i);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 16811, 16823);

                    return name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(407, 16105, 16838);

                    int
                    f_407_16419_16447(string
                    this_param, char
                    value, int
                    startIndex)
                    {
                        var return_v = this_param.IndexOf(value, startIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 16419, 16447);
                        return return_v;
                    }


                    int
                    f_407_16533_16546(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 16533, 16546);
                        return return_v;
                    }


                    int
                    f_407_16656_16669(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 16656, 16669);
                        return return_v;
                    }


                    string
                    f_407_16723_16761(string
                    this_param, int
                    startIndex, int
                    length)
                    {
                        var return_v = this_param.Substring(startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 16723, 16761);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 16105, 16838);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 16105, 16838);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            /// <summary>
            /// Rank equal 0 is used to denote an SzArray, rank equal 1 denotes multi-dimensional array of rank 1.
            /// </summary>
            private void DecodeArrayShape(StringBuilder typeNameBuilder, ref ArrayBuilder<int> arrayRanksBuilder)
            {
                Debug.Assert(Current == '[');

                int start = _offset;
                int rank = 1;
                bool isMultiDimensionalIfRankOne = false;
                Advance();

                while (!EndOfInput)
                {
                    switch (Current)
                    {
                        case ',':
                            rank++;
                            Advance();
                            break;

                        case ']':
                            if (arrayRanksBuilder == null)
                            {
                                arrayRanksBuilder = ArrayBuilder<int>.GetInstance();
                            }

                            arrayRanksBuilder.Add(rank == 1 && !isMultiDimensionalIfRankOne ? 0 : rank);
                            Advance();
                            return;

                        case '*':
                            if (rank != 1)
                            {
                                goto default;
                            }

                            Advance();
                            if (Current != ']')
                            {
                                // Error case, process as regular characters
                                typeNameBuilder.Append(_input.Substring(start, _offset - start));
                                return;
                            }

                            isMultiDimensionalIfRankOne = true;
                            break;

                        default:
                            // Error case, process as regular characters
                            Advance();
                            typeNameBuilder.Append(_input.Substring(start, _offset - start));
                            return;
                    }
                }

                // Error case, process as regular characters
                typeNameBuilder.Append(_input.Substring(start, _offset - start));
            }
            static SerializedTypeDecoder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(407, 3193, 19204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 3285, 3335);
                // LAFHIS
                s_typeNameDelimiters = new char[] { '+', ',', '[', ']', '*' }; 
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(407, 3193, 19204);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 3193, 19204);
            }
        }

        private static readonly string[] s_aritySuffixesOneToNine;

        internal static string GetAritySuffix(int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 19345, 19618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 19418, 19442);

                f_407_19418_19441(arity > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 19456, 19607);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(407, 19463, 19475) || (((arity <= 9) && DynAbs.Tracing.TraceSender.Conditional_F2(407, 19478, 19513)) || DynAbs.Tracing.TraceSender.Conditional_F3(407, 19516, 19606))) ? s_aritySuffixesOneToNine[arity - 1] : f_407_19516_19606(GenericTypeNameManglingString, f_407_19561_19605(arity, f_407_19576_19604()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 19345, 19618);

                int
                f_407_19418_19441(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 19418, 19441);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_407_19576_19604()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 19576, 19604);
                    return return_v;
                }


                string
                f_407_19561_19605(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 19561, 19605);
                    return return_v;
                }


                string
                f_407_19516_19606(string
                str0, string
                str1)
                {
                    var return_v = string.Concat(str0, str1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 19516, 19606);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 19345, 19618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 19345, 19618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ComposeAritySuffixedMetadataName(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 19630, 19801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 19734, 19790);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(407, 19741, 19751) || ((arity == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(407, 19754, 19758)) || DynAbs.Tracing.TraceSender.Conditional_F3(407, 19761, 19789))) ? name : name + f_407_19768_19789(arity);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 19630, 19801);

                string
                f_407_19768_19789(int
                arity)
                {
                    var return_v = GetAritySuffix(arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 19768, 19789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 19630, 19801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 19630, 19801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int InferTypeArityFromMetadataName(string emittedTypeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 19813, 20031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 19912, 19931);

                int
                suffixStartsAt
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 19945, 20020);

                return f_407_19952_20019(emittedTypeName, out suffixStartsAt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 19813, 20031);

                short
                f_407_19952_20019(string
                emittedTypeName, out int
                suffixStartsAt)
                {
                    var return_v = InferTypeArityFromMetadataName(emittedTypeName, out suffixStartsAt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 19952, 20019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 19813, 20031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 19813, 20031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static short InferTypeArityFromMetadataName(string emittedTypeName, out int suffixStartsAt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 20043, 21656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 20167, 20239);

                f_407_20167_20238(emittedTypeName != null, "NULL actual name unexpected!!!");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 20253, 20304);

                int
                emittedTypeNameLength = f_407_20281_20303(emittedTypeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 20320, 20344);

                int
                indexOfManglingChar
                = default(int);
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 20363, 20406)
   , indexOfManglingChar = emittedTypeNameLength; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 20358, 20646) || true) && (indexOfManglingChar >= 1)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 20434, 20455)
   , indexOfManglingChar--, DynAbs.Tracing.TraceSender.TraceExitCondition(407, 20358, 20646))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 20358, 20646);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 20489, 20631) || true) && (f_407_20493_20533(emittedTypeName, indexOfManglingChar - 1) == GenericTypeNameManglingChar)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 20489, 20631);
                            DynAbs.Tracing.TraceSender.TraceBreak(407, 20606, 20612);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(407, 20489, 20631);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(407, 1, 289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(407, 1, 289);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 20662, 20948) || true) && (indexOfManglingChar < 2 || (DynAbs.Tracing.TraceSender.Expression_False(407, 20666, 20759) || (emittedTypeNameLength - indexOfManglingChar) == 0) || (DynAbs.Tracing.TraceSender.Expression_False(407, 20666, 20852) || emittedTypeNameLength - indexOfManglingChar > MaxStringLengthForParamSize))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 20662, 20948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 20886, 20906);

                    suffixStartsAt = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 20924, 20933);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 20662, 20948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21070, 21150);

                string
                stringRepresentingArity = f_407_21103_21149(emittedTypeName, indexOfManglingChar)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21166, 21176);

                int
                arity
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21190, 21316);

                bool
                nonNumericCharFound = !f_407_21218_21315(stringRepresentingArity, NumberStyles.None, f_407_21275_21303(), out arity)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21332, 21554) || true) && (nonNumericCharFound || (DynAbs.Tracing.TraceSender.Expression_False(407, 21336, 21368) || arity < 0) || (DynAbs.Tracing.TraceSender.Expression_False(407, 21336, 21394) || arity > short.MaxValue) || (DynAbs.Tracing.TraceSender.Expression_False(407, 21336, 21458) || stringRepresentingArity != f_407_21442_21458(arity)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 21332, 21554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21492, 21512);

                    suffixStartsAt = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21530, 21539);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 21332, 21554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21570, 21611);

                suffixStartsAt = indexOfManglingChar - 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21625, 21645);

                return (short)arity;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 20043, 21656);

                int
                f_407_20167_20238(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 20167, 20238);
                    return 0;
                }


                int
                f_407_20281_20303(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 20281, 20303);
                    return return_v;
                }


                char
                f_407_20493_20533(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 20493, 20533);
                    return return_v;
                }


                string
                f_407_21103_21149(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 21103, 21149);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_407_21275_21303()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 21275, 21303);
                    return return_v;
                }


                bool
                f_407_21218_21315(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out int
                result)
                {
                    var return_v = int.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 21218, 21315);
                    return return_v;
                }


                string
                f_407_21442_21458(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 21442, 21458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 20043, 21656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 20043, 21656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string InferTypeArityAndUnmangleMetadataName(string emittedTypeName, out short arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 21668, 22231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21794, 21813);

                int
                suffixStartsAt
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21827, 21903);

                arity = f_407_21835_21902(emittedTypeName, out suffixStartsAt);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21919, 22058) || true) && (arity == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 21919, 22058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 21967, 22002);

                    f_407_21967_22001(suffixStartsAt == -1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 22020, 22043);

                    return emittedTypeName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 21919, 22058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 22074, 22154);

                f_407_22074_22153(suffixStartsAt > 0 && (DynAbs.Tracing.TraceSender.Expression_True(407, 22087, 22152) && suffixStartsAt < f_407_22126_22148(emittedTypeName) - 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 22168, 22220);

                return f_407_22175_22219(emittedTypeName, 0, suffixStartsAt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 21668, 22231);

                short
                f_407_21835_21902(string
                emittedTypeName, out int
                suffixStartsAt)
                {
                    var return_v = InferTypeArityFromMetadataName(emittedTypeName, out suffixStartsAt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 21835, 21902);
                    return return_v;
                }


                int
                f_407_21967_22001(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 21967, 22001);
                    return 0;
                }


                int
                f_407_22126_22148(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 22126, 22148);
                    return return_v;
                }


                int
                f_407_22074_22153(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 22074, 22153);
                    return 0;
                }


                string
                f_407_22175_22219(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 22175, 22219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 21668, 22231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 21668, 22231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string UnmangleMetadataNameForArity(string emittedTypeName, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 22243, 22756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 22354, 22378);

                f_407_22354_22377(arity > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 22394, 22413);

                int
                suffixStartsAt
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 22427, 22706) || true) && (arity == f_407_22440_22507(emittedTypeName, out suffixStartsAt))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 22427, 22706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 22541, 22621);

                    f_407_22541_22620(suffixStartsAt > 0 && (DynAbs.Tracing.TraceSender.Expression_True(407, 22554, 22619) && suffixStartsAt < f_407_22593_22615(emittedTypeName) - 1));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 22639, 22691);

                    return f_407_22646_22690(emittedTypeName, 0, suffixStartsAt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 22427, 22706);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 22722, 22745);

                return emittedTypeName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 22243, 22756);

                int
                f_407_22354_22377(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 22354, 22377);
                    return 0;
                }


                short
                f_407_22440_22507(string
                emittedTypeName, out int
                suffixStartsAt)
                {
                    var return_v = InferTypeArityFromMetadataName(emittedTypeName, out suffixStartsAt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 22440, 22507);
                    return return_v;
                }


                int
                f_407_22593_22615(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 22593, 22615);
                    return return_v;
                }


                int
                f_407_22541_22620(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 22541, 22620);
                    return 0;
                }


                string
                f_407_22646_22690(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 22646, 22690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 22243, 22756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 22243, 22756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ImmutableArray<string> s_splitQualifiedNameSystem;

        internal static ImmutableArray<string> SplitQualifiedName(
                      string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 23010, 24622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23121, 23148);

                f_407_23121_23147(name != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23164, 23269) || true) && (f_407_23168_23179(name) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 23164, 23269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23218, 23254);

                    return ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 23164, 23269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23444, 23457);

                int
                dots = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23471, 23634);
                    foreach (char ch in f_407_23491_23495_I(name))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 23471, 23634);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23529, 23619) || true) && (ch == DotDelimiter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 23529, 23619);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23593, 23600);

                            dots++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(407, 23529, 23619);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(407, 23471, 23634);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(407, 1, 164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(407, 1, 164);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23650, 23799) || true) && (dots == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 23650, 23799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23697, 23784);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(407, 23704, 23724) || ((name == SystemString && DynAbs.Tracing.TraceSender.Conditional_F2(407, 23727, 23753)) || DynAbs.Tracing.TraceSender.Conditional_F3(407, 23756, 23783))) ? s_splitQualifiedNameSystem : f_407_23756_23783(name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 23650, 23799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23815, 23871);

                var
                result = f_407_23828_23870(dots + 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23887, 23901);

                int
                start = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23924, 23929);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23915, 24510) || true) && (dots > 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23941, 23944)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(407, 23915, 24510))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 23915, 24510);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 23978, 24495) || true) && (f_407_23982_23989(name, i) == DotDelimiter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 23978, 24495);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 24047, 24067);

                            int
                            len = i - start
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 24089, 24409) || true) && (len == 6 && (DynAbs.Tracing.TraceSender.Expression_True(407, 24093, 24115) && start == 0) && (DynAbs.Tracing.TraceSender.Expression_True(407, 24093, 24174) && f_407_24119_24174(name, SystemString, StringComparison.Ordinal)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 24089, 24409);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 24224, 24249);

                                f_407_24224_24248(result, SystemString);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(407, 24089, 24409);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 24089, 24409);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 24347, 24386);

                                f_407_24347_24385(result, f_407_24358_24384(name, start, len));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(407, 24089, 24409);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 24433, 24440);

                            dots--;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 24462, 24476);

                            start = i + 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(407, 23978, 24495);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(407, 1, 596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(407, 1, 596);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 24526, 24560);

                f_407_24526_24559(
                            result, f_407_24537_24558(name, start));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 24576, 24611);

                return f_407_24583_24610(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 23010, 24622);

                int
                f_407_23121_23147(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 23121, 23147);
                    return 0;
                }


                int
                f_407_23168_23179(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 23168, 23179);
                    return return_v;
                }


                string
                f_407_23491_23495_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 23491, 23495);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_407_23756_23783(string
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 23756, 23783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_407_23828_23870(int
                capacity)
                {
                    var return_v = ArrayBuilder<string>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 23828, 23870);
                    return return_v;
                }


                char
                f_407_23982_23989(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 23982, 23989);
                    return return_v;
                }


                bool
                f_407_24119_24174(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 24119, 24174);
                    return return_v;
                }


                int
                f_407_24224_24248(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 24224, 24248);
                    return 0;
                }


                string
                f_407_24358_24384(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 24358, 24384);
                    return return_v;
                }


                int
                f_407_24347_24385(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 24347, 24385);
                    return 0;
                }


                string
                f_407_24537_24558(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 24537, 24558);
                    return return_v;
                }


                int
                f_407_24526_24559(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 24526, 24559);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_407_24583_24610(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 24583, 24610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 23010, 24622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 23010, 24622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string SplitQualifiedName(
                    string pstrName,
                    out string qualifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 24634, 26581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 24766, 24797);

                f_407_24766_24796(pstrName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 25151, 25177);

                var
                angleBracketDepth = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 25191, 25210);

                var
                delimiter = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 25233, 25238);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 25224, 26039) || true) && (i < f_407_25244_25259(pstrName))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 25261, 25264)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(407, 25224, 26039))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 25224, 26039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 25298, 26024);

                        switch (f_407_25306_25317(pstrName, i))
                        {

                            case MangledNameRegionStartChar:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 25298, 26024);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 25417, 25437);

                                angleBracketDepth++;
                                DynAbs.Tracing.TraceSender.TraceBreak(407, 25463, 25469);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(407, 25298, 26024);

                            case MangledNameRegionEndChar:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 25298, 26024);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 25547, 25567);

                                angleBracketDepth--;
                                DynAbs.Tracing.TraceSender.TraceBreak(407, 25593, 25599);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(407, 25298, 26024);

                            case DotDelimiter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 25298, 26024);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 25815, 25973) || true) && (angleBracketDepth == 0 && (DynAbs.Tracing.TraceSender.Expression_True(407, 25819, 25874) && (i == 0 || (DynAbs.Tracing.TraceSender.Expression_False(407, 25846, 25873) || delimiter < i - 1))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 25815, 25973);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 25932, 25946);

                                    delimiter = i;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 25815, 25973);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(407, 25999, 26005);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(407, 25298, 26024);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(407, 1, 816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(407, 1, 816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26053, 26090);

                f_407_26053_26089(angleBracketDepth == 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26106, 26231) || true) && (delimiter < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 26106, 26231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26157, 26182);

                    qualifier = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26200, 26216);

                    return pstrName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 26106, 26231);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26247, 26513) || true) && (delimiter == 6 && (DynAbs.Tracing.TraceSender.Expression_True(407, 26251, 26328) && f_407_26269_26328(pstrName, SystemString, StringComparison.Ordinal)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 26247, 26513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26362, 26387);

                    qualifier = SystemString;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 26247, 26513);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 26247, 26513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26453, 26498);

                    qualifier = f_407_26465_26497(pstrName, 0, delimiter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 26247, 26513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26529, 26570);

                return f_407_26536_26569(pstrName, delimiter + 1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 24634, 26581);

                int
                f_407_24766_24796(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 24766, 24796);
                    return 0;
                }


                int
                f_407_25244_25259(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 25244, 25259);
                    return return_v;
                }


                char
                f_407_25306_25317(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 25306, 25317);
                    return return_v;
                }


                int
                f_407_26053_26089(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 26053, 26089);
                    return 0;
                }


                bool
                f_407_26269_26328(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 26269, 26328);
                    return return_v;
                }


                string
                f_407_26465_26497(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 26465, 26497);
                    return return_v;
                }


                string
                f_407_26536_26569(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 26536, 26569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 24634, 26581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 24634, 26581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string BuildQualifiedName(
                    string qualifier,
                    string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 26593, 26942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26717, 26744);

                f_407_26717_26743(name != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26760, 26903) || true) && (!f_407_26765_26796(qualifier))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 26760, 26903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26830, 26888);

                    return f_407_26837_26887(qualifier, DotDelimiterString, name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 26760, 26903);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 26919, 26931);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 26593, 26942);

                int
                f_407_26717_26743(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 26717, 26743);
                    return 0;
                }


                bool
                f_407_26765_26796(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 26765, 26796);
                    return return_v;
                }


                string
                f_407_26837_26887(string
                str0, string
                str1, string
                str2)
                {
                    var return_v = String.Concat(str0, str1, str2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 26837, 26887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 26593, 26942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 26593, 26942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Calculates information about types and namespaces immediately contained within a namespace.
        /// </summary>
        /// <param name="isGlobalNamespace">
        /// Is current namespace a global namespace?
        /// </param>
        /// <param name="namespaceNameLength">
        /// Length of the fully-qualified name of this namespace.
        /// </param>
        /// <param name="typesByNS">
        /// The sequence of groups of TypeDef row ids for types contained within the namespace, 
        /// recursively including those from nested namespaces. The row ids must be grouped by the 
        /// fully-qualified namespace name in case-sensitive manner. 
        /// Key of each IGrouping is a fully-qualified namespace name, which starts with the name of 
        /// this namespace. There could be multiple groups for each fully-qualified namespace name.
        /// 
        /// The groups must be sorted by the keys in a manner consistent with comparer passed in as
        /// nameComparer. Therefore, all types immediately contained within THIS namespace, if any, 
        /// must be in several IGrouping at the very beginning of the sequence.
        /// </param>
        /// <param name="nameComparer">
        /// Equality comparer to compare namespace names.
        /// </param>
        /// <param name="types">
        /// Output parameter, never null:
        /// A sequence of groups of TypeDef row ids for types immediately contained within this namespace.
        /// </param>
        /// <param name="namespaces">
        /// Output parameter, never null:
        /// A sequence with information about namespaces immediately contained within this namespace.
        /// For each pair:
        ///   Key - contains simple name of a child namespace.
        ///   Value - contains a sequence similar to the one passed to this function, but
        ///           calculated for the child namespace. 
        /// </param>
        /// <remarks></remarks>
        public static void GetInfoForImmediateNamespaceMembers(
            bool isGlobalNamespace,
            int namespaceNameLength,
            IEnumerable<IGrouping<string, TypeDefinitionHandle>> typesByNS,
            StringComparer nameComparer,
            out IEnumerable<IGrouping<string, TypeDefinitionHandle>> types,
            out IEnumerable<KeyValuePair<string, IEnumerable<IGrouping<string, TypeDefinitionHandle>>>> namespaces)
        {
            Debug.Assert(typesByNS != null);
            Debug.Assert(namespaceNameLength >= 0);
            Debug.Assert(!isGlobalNamespace || namespaceNameLength == 0);

            // A list of groups of TypeDef row ids for types immediately contained within this namespace.
            var nestedTypes = new List<IGrouping<string, TypeDefinitionHandle>>();

            // A list accumulating information about namespaces immediately contained within this namespace.
            // For each pair:
            //   Key - contains simple name of a child namespace.
            //   Value – contains a sequence similar to the one passed to this function, but
            //           calculated for the child namespace. 
            var nestedNamespaces = new List<KeyValuePair<string, IEnumerable<IGrouping<string, TypeDefinitionHandle>>>>();
            bool possiblyHavePairsWithDuplicateKey = false;

            var enumerator = typesByNS.GetEnumerator();

            using (enumerator)
            {
                if (enumerator.MoveNext())
                {
                    var pair = enumerator.Current;

                    // Simple name of the last encountered child namespace.
                    string lastChildNamespaceName = null;

                    // A list accumulating information about types within the last encountered child namespace.
                    // The list is similar to the sequence passed to this function.
                    List<IGrouping<string, TypeDefinitionHandle>> typesInLastChildNamespace = null;

                    // if there are any types in this namespace,
                    // they will be in the first several groups if their key length 
                    // is equal to namespaceNameLength.
                    while (pair.Key.Length == namespaceNameLength)
                    {
                        nestedTypes.Add(pair);

                        if (!enumerator.MoveNext())
                        {
                            goto DoneWithSequence;
                        }

                        pair = enumerator.Current;
                    }

                    // Account for the dot following THIS namespace name.
                    if (!isGlobalNamespace)
                    {
                        namespaceNameLength++;
                    }

                    do
                    {
                        pair = enumerator.Current;

                        string childNamespaceName = ExtractSimpleNameOfChildNamespace(namespaceNameLength, pair.Key);

                        int cmp = nameComparer.Compare(lastChildNamespaceName, childNamespaceName);
                        if (cmp == 0)
                        {
                            // We are still processing the same child namespace
                            typesInLastChildNamespace.Add(pair);
                        }
                        else
                        {
                            // This is a new child namespace
                            if (cmp > 0)
                            {
                                // The sort order is violated for child namespace names. Obfuscation is the likely reason for this. 
                                Debug.Assert((object)lastChildNamespaceName != null);
                                possiblyHavePairsWithDuplicateKey = true;
                            }

                            // Preserve information about previous child namespace.
                            if (typesInLastChildNamespace != null)
                            {
                                Debug.Assert(typesInLastChildNamespace.Count != 0);
                                nestedNamespaces.Add(
                                    new KeyValuePair<string, IEnumerable<IGrouping<string, TypeDefinitionHandle>>>(
                                        lastChildNamespaceName, typesInLastChildNamespace));
                            }

                            typesInLastChildNamespace = new List<IGrouping<string, TypeDefinitionHandle>>();
                            lastChildNamespaceName = childNamespaceName;
                            Debug.Assert((object)lastChildNamespaceName != null);

                            typesInLastChildNamespace.Add(pair);
                        }
                    }
                    while (enumerator.MoveNext());

                    // Preserve information about last child namespace.
                    if (typesInLastChildNamespace != null)
                    {
                        Debug.Assert(typesInLastChildNamespace.Count != 0);
                        nestedNamespaces.Add(
                            new KeyValuePair<string, IEnumerable<IGrouping<string, TypeDefinitionHandle>>>(
                                lastChildNamespaceName, typesInLastChildNamespace));
                    }

DoneWithSequence:
/*empty statement*/
                    ;
                }
            } // using

            types = nestedTypes;

            // Merge pairs with the same key
            if (possiblyHavePairsWithDuplicateKey)
            {
                var names = new Dictionary<string, int>(nestedNamespaces.Count, nameComparer);

                for (int i = nestedNamespaces.Count - 1; i >= 0; i--)
                {
                    names[nestedNamespaces[i].Key] = i;
                }

                if (names.Count != nestedNamespaces.Count) // nothing to merge otherwise
                {
                    for (int i = 1; i < nestedNamespaces.Count; i++)
                    {
                        var pair = nestedNamespaces[i];
                        int keyIndex = names[pair.Key];
                        if (keyIndex != i)
                        {
                            Debug.Assert(keyIndex < i);
                            var primaryPair = nestedNamespaces[keyIndex];
                            nestedNamespaces[keyIndex] = KeyValuePairUtil.Create(primaryPair.Key, primaryPair.Value.Concat(pair.Value));
                            nestedNamespaces[i] = default(KeyValuePair<string, IEnumerable<IGrouping<string, TypeDefinitionHandle>>>);
                        }
                    }

                    int removed = nestedNamespaces.RemoveAll(pair => (object)pair.Key == null);
                    Debug.Assert(removed > 0);
                }
            }

            namespaces = nestedNamespaces;

            Debug.Assert(types != null);
            Debug.Assert(namespaces != null);
        }

        private static string ExtractSimpleNameOfChildNamespace(
                    int parentNamespaceNameLength,
                    string fullName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 36738, 37250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 36893, 36954);

                int
                index = f_407_36905_36953(fullName, '.', parentNamespaceNameLength)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 36970, 37239) || true) && (index < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 36970, 37239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 37017, 37070);

                    return f_407_37024_37069(fullName, parentNamespaceNameLength);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 36970, 37239);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 36970, 37239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 37136, 37224);

                    return f_407_37143_37223(fullName, parentNamespaceNameLength, index - parentNamespaceNameLength);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 36970, 37239);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 36738, 37250);

                int
                f_407_36905_36953(string
                this_param, char
                value, int
                startIndex)
                {
                    var return_v = this_param.IndexOf(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 36905, 36953);
                    return return_v;
                }


                string
                f_407_37024_37069(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 37024, 37069);
                    return return_v;
                }


                string
                f_407_37143_37223(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 37143, 37223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 36738, 37250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 36738, 37250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidMetadataIdentifier(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 37433, 37618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 37516, 37607);

                return !f_407_37524_37549(str) && (DynAbs.Tracing.TraceSender.Expression_True(407, 37523, 37579) && f_407_37553_37579(str)) && (DynAbs.Tracing.TraceSender.Expression_True(407, 37523, 37606) && f_407_37583_37600(str, '\0') == -1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 37433, 37618);

                bool
                f_407_37524_37549(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 37524, 37549);
                    return return_v;
                }


                bool
                f_407_37553_37579(string
                str)
                {
                    var return_v = str.IsValidUnicodeString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 37553, 37579);
                    return return_v;
                }


                int
                f_407_37583_37600(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 37583, 37600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 37433, 37618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 37433, 37618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidUnicodeString(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 37748, 37886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 37826, 37875);

                return str == null || (DynAbs.Tracing.TraceSender.Expression_False(407, 37833, 37874) || f_407_37848_37874(str));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 37748, 37886);

                bool
                f_407_37848_37874(string
                str)
                {
                    var return_v = str.IsValidUnicodeString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 37848, 37874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 37748, 37886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 37748, 37886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidAssemblyOrModuleName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 37898, 38065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 37984, 38054);

                return f_407_37991_38045(name) == null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 37898, 38065);

                string
                f_407_37991_38045(string
                name)
                {
                    var return_v = GetAssemblyOrModuleNameErrorArgumentResourceName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 37991, 38045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 37898, 38065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 37898, 38065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void CheckAssemblyOrModuleName(string name, CommonMessageProvider messageProvider, int code, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 38077, 38628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 38237, 38325);

                string
                errorArgumentResourceId = f_407_38270_38324(name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 38339, 38617) || true) && (errorArgumentResourceId != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 38339, 38617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 38408, 38602);

                    f_407_38408_38601(diagnostics, f_407_38446_38600(messageProvider, code, f_407_38485_38498(), f_407_38525_38599(errorArgumentResourceId)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 38339, 38617);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 38077, 38628);

                string
                f_407_38270_38324(string
                name)
                {
                    var return_v = GetAssemblyOrModuleNameErrorArgumentResourceName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 38270, 38324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_407_38485_38498()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 38485, 38498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument
                f_407_38525_38599(string
                targetResourceId)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument(targetResourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 38525, 38599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_407_38446_38600(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 38446, 38600);
                    return return_v;
                }


                int
                f_407_38408_38601(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 38408, 38601);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 38077, 38628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 38077, 38628);
            }
        }

        internal static void CheckAssemblyOrModuleName(string name, CommonMessageProvider messageProvider, int code, ArrayBuilder<Diagnostic> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 38640, 39194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 38807, 38895);

                string
                errorArgumentResourceId = f_407_38840_38894(name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 38909, 39183) || true) && (errorArgumentResourceId != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 38909, 39183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 38978, 39168);

                    f_407_38978_39167(builder, f_407_39012_39166(messageProvider, code, f_407_39051_39064(), f_407_39091_39165(errorArgumentResourceId)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 38909, 39183);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 38640, 39194);

                string
                f_407_38840_38894(string
                name)
                {
                    var return_v = GetAssemblyOrModuleNameErrorArgumentResourceName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 38840, 38894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_407_39051_39064()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 39051, 39064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument
                f_407_39091_39165(string
                targetResourceId)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument(targetResourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 39091, 39165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_407_39012_39166(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 39012, 39166);
                    return return_v;
                }


                int
                f_407_38978_39167(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 38978, 39167);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 38640, 39194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 38640, 39194);
            }
        }

        private static string GetAssemblyOrModuleNameErrorArgumentResourceName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 39206, 40325);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 39314, 39433) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 39314, 39433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 39364, 39418);

                    return nameof(CodeAnalysisResources.NameCannotBeNull);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 39314, 39433);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 39625, 39749) || true) && (f_407_39629_39640(name) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 39625, 39749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 39679, 39734);

                    return nameof(CodeAnalysisResources.NameCannotBeEmpty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 39625, 39749);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 39975, 40121) || true) && (f_407_39979_40005(f_407_39997_40004(name, 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 39975, 40121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 40039, 40106);

                    return nameof(CodeAnalysisResources.NameCannotStartWithWhitespace);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 39975, 40121);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 40137, 40286) || true) && (!f_407_40142_40171(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(407, 40137, 40286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 40205, 40271);

                    return nameof(CodeAnalysisResources.NameContainsInvalidCharacter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(407, 40137, 40286);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 40302, 40314);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 39206, 40325);

                int
                f_407_39629_39640(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 39629, 39640);
                    return return_v;
                }


                char
                f_407_39997_40004(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 39997, 40004);
                    return return_v;
                }


                bool
                f_407_39979_40005(char
                c)
                {
                    var return_v = char.IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 39979, 40005);
                    return return_v;
                }


                bool
                f_407_40142_40171(string
                name)
                {
                    var return_v = IsValidMetadataFileName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 40142, 40171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 39206, 40325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 39206, 40325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidMetadataFileName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 41140, 41310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 41222, 41299);

                return f_407_41229_41263(name) && (DynAbs.Tracing.TraceSender.Expression_True(407, 41229, 41298) && f_407_41267_41298(name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 41140, 41310);

                bool
                f_407_41229_41263(string
                path)
                {
                    var return_v = FileNameUtilities.IsFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 41229, 41263);
                    return return_v;
                }


                bool
                f_407_41267_41298(string
                str)
                {
                    var return_v = IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 41267, 41298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 41140, 41310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 41140, 41310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool SplitNameEqualsFullyQualifiedName(string namespaceName, string typeName, string fullyQualified)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 41941, 42495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 42144, 42484);

                return f_407_42151_42172(fullyQualified) == f_407_42176_42196(namespaceName) + f_407_42199_42214(typeName) + 1 && (DynAbs.Tracing.TraceSender.Expression_True(407, 42151, 42310) && f_407_42242_42278(fullyQualified, f_407_42257_42277(namespaceName)) == MetadataHelpers.DotDelimiter) && (DynAbs.Tracing.TraceSender.Expression_True(407, 42151, 42400) && f_407_42334_42400(fullyQualified, namespaceName, StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(407, 42151, 42483) && f_407_42424_42483(fullyQualified, typeName, StringComparison.Ordinal));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 41941, 42495);

                int
                f_407_42151_42172(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 42151, 42172);
                    return return_v;
                }


                int
                f_407_42176_42196(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 42176, 42196);
                    return return_v;
                }


                int
                f_407_42199_42214(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 42199, 42214);
                    return return_v;
                }


                int
                f_407_42257_42277(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 42257, 42277);
                    return return_v;
                }


                char
                f_407_42242_42278(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(407, 42242, 42278);
                    return return_v;
                }


                bool
                f_407_42334_42400(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 42334, 42400);
                    return return_v;
                }


                bool
                f_407_42424_42483(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 42424, 42483);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 41941, 42495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 41941, 42495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidPublicKey(ImmutableArray<byte> bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(407, 42573, 42616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 42576, 42616);
                return f_407_42576_42616(bytes); DynAbs.Tracing.TraceSender.TraceExitMethod(407, 42573, 42616);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 42573, 42616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 42573, 42616);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_407_42576_42616(System.Collections.Immutable.ImmutableArray<byte>
            blob)
            {
                var return_v = CryptoBlobParser.IsValidPublicKey(blob);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 42576, 42616);
                return return_v;
            }

        }

        internal static string MangleForTypeNameIfNeeded(string moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(407, 42765, 43169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 42857, 42914);

                var
                pooledStrBuilder = f_407_42880_42913()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 42928, 42961);

                var
                s = pooledStrBuilder.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 42975, 42996);

                f_407_42975_42995(s, moduleName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 43010, 43031);

                f_407_43010_43030(s, "Q", "QQ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 43045, 43066);

                f_407_43045_43065(s, "_", "Q_");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 43080, 43100);

                f_407_43080_43099(s, '.', '_');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 43116, 43158);

                return f_407_43123_43157(pooledStrBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(407, 42765, 43169);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_407_42880_42913()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 42880, 42913);
                    return return_v;
                }


                System.Text.StringBuilder
                f_407_42975_42995(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 42975, 42995);
                    return return_v;
                }


                System.Text.StringBuilder
                f_407_43010_43030(System.Text.StringBuilder
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 43010, 43030);
                    return return_v;
                }


                System.Text.StringBuilder
                f_407_43045_43065(System.Text.StringBuilder
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 43045, 43065);
                    return return_v;
                }


                System.Text.StringBuilder
                f_407_43080_43099(System.Text.StringBuilder
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 43080, 43099);
                    return return_v;
                }


                string
                f_407_43123_43157(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 43123, 43157);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(407, 42765, 43169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 42765, 43169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MetadataHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(407, 603, 43176);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 675, 693);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 724, 748);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 777, 810);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 842, 877);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 905, 937);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 965, 1009);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 1040, 1063);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 1204, 1236);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 1265, 1295);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 19249, 19332);
            s_aritySuffixesOneToNine = new string[] { "`1", "`2", "`3", "`4", "`5", "`6", "`7", "`8", "`9" }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(407, 22933, 22997);
            s_splitQualifiedNameSystem = f_407_22962_22997(SystemString); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(407, 603, 43176);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(407, 603, 43176);
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_407_22962_22997(string
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(407, 22962, 22997);
            return return_v;
        }

    }
}
