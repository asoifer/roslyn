// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Symbols;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Microsoft.CodeAnalysis
{
    internal sealed class MarshalPseudoCustomAttributeData : Cci.IMarshallingInformation
    {
        private UnmanagedType _marshalType;

        private int _marshalArrayElementType;

        private int _marshalArrayElementCount;

        private int _marshalParameterIndex;

        private object _marshalTypeNameOrSymbol;

        private string _marshalCookie;

        internal const int
        Invalid = -1
        ;

        private const UnmanagedType
        InvalidUnmanagedType = (UnmanagedType)Invalid
        ;

        private const Cci.VarEnum
        InvalidVariantType = (Cci.VarEnum)Invalid
        ;

        internal const int
        MaxMarshalInteger = 0x1fffffff
        ;

        public MarshalPseudoCustomAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(812, 1516, 1579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 658, 670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 693, 717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 790, 815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 912, 934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 1052, 1076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 1189, 1203);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(812, 1516, 1579);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 1516, 1579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 1516, 1579);
            }
        }

        internal void SetMarshalAsCustom(object typeSymbolOrName, string cookie)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 1591, 1854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 1688, 1747);

                _marshalType = Cci.Constants.UnmanagedType_CustomMarshaler;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 1761, 1805);

                _marshalTypeNameOrSymbol = typeSymbolOrName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 1819, 1843);

                _marshalCookie = cookie;
                DynAbs.Tracing.TraceSender.TraceExitMethod(812, 1591, 1854);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 1591, 1854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 1591, 1854);
            }
        }

        internal void SetMarshalAsComInterface(UnmanagedType unmanagedType, int? parameterIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 1866, 2199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 1979, 2078);

                f_812_1979_2077(parameterIndex == null || (DynAbs.Tracing.TraceSender.Expression_False(812, 1992, 2076) || parameterIndex >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(812, 2018, 2076) && parameterIndex <= MaxMarshalInteger)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 2094, 2123);

                _marshalType = unmanagedType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 2137, 2188);

                _marshalParameterIndex = parameterIndex ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(812, 2162, 2187) ?? Invalid);
                DynAbs.Tracing.TraceSender.TraceExitMethod(812, 1866, 2199);

                int
                f_812_1979_2077(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 1979, 2077);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 1866, 2199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 1866, 2199);
            }
        }

        internal void SetMarshalAsArray(UnmanagedType? elementType, int? elementCount, short? parameterIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 2211, 2782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 2337, 2430);

                f_812_2337_2429(elementCount == null || (DynAbs.Tracing.TraceSender.Expression_False(812, 2350, 2428) || elementCount >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(812, 2374, 2428) && elementCount <= MaxMarshalInteger)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 2444, 2504);

                f_812_2444_2503(parameterIndex == null || (DynAbs.Tracing.TraceSender.Expression_False(812, 2457, 2502) || parameterIndex >= 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 2520, 2557);

                _marshalType = UnmanagedType.LPArray;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 2571, 2640);

                _marshalArrayElementType = (int)(elementType ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Runtime.InteropServices.UnmanagedType?>(812, 2604, 2638) ?? (UnmanagedType)0x50));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 2654, 2706);

                _marshalArrayElementCount = elementCount ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(812, 2682, 2705) ?? Invalid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 2720, 2771);

                _marshalParameterIndex = parameterIndex ?? (DynAbs.Tracing.TraceSender.Expression_Null<short?>(812, 2745, 2770) ?? Invalid);
                DynAbs.Tracing.TraceSender.TraceExitMethod(812, 2211, 2782);

                int
                f_812_2337_2429(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 2337, 2429);
                    return 0;
                }


                int
                f_812_2444_2503(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 2444, 2503);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 2211, 2782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 2211, 2782);
            }
        }

        internal void SetMarshalAsFixedArray(UnmanagedType? elementType, int? elementCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 2794, 3321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 2902, 2995);

                f_812_2902_2994(elementCount == null || (DynAbs.Tracing.TraceSender.Expression_False(812, 2915, 2993) || elementCount >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(812, 2939, 2993) && elementCount <= MaxMarshalInteger)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 3009, 3104);

                f_812_3009_3103(elementType == null || (DynAbs.Tracing.TraceSender.Expression_False(812, 3022, 3102) || elementType >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(812, 3045, 3102) && (int)elementType <= MaxMarshalInteger)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 3120, 3160);

                _marshalType = UnmanagedType.ByValArray;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 3174, 3244);

                _marshalArrayElementType = (int)(elementType ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Runtime.InteropServices.UnmanagedType?>(812, 3207, 3242) ?? InvalidUnmanagedType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 3258, 3310);

                _marshalArrayElementCount = elementCount ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(812, 3286, 3309) ?? Invalid);
                DynAbs.Tracing.TraceSender.TraceExitMethod(812, 2794, 3321);

                int
                f_812_2902_2994(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 2902, 2994);
                    return 0;
                }


                int
                f_812_3009_3103(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 3009, 3103);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 2794, 3321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 2794, 3321);
            }
        }

        internal void SetMarshalAsSafeArray(Cci.VarEnum? elementType, ITypeSymbolInternal elementTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 3333, 3774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 3458, 3553);

                f_812_3458_3552(elementType == null || (DynAbs.Tracing.TraceSender.Expression_False(812, 3471, 3551) || elementType >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(812, 3494, 3551) && (int)elementType <= MaxMarshalInteger)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 3569, 3622);

                _marshalType = Cci.Constants.UnmanagedType_SafeArray;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 3636, 3704);

                _marshalArrayElementType = (int)(elementType ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.VarEnum?>(812, 3669, 3702) ?? InvalidVariantType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 3718, 3763);

                _marshalTypeNameOrSymbol = elementTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(812, 3333, 3774);

                int
                f_812_3458_3552(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 3458, 3552);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 3333, 3774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 3333, 3774);
            }
        }

        internal void SetMarshalAsFixedString(int elementCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 3786, 4056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 3866, 3935);

                f_812_3866_3934(elementCount >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(812, 3879, 3933) && elementCount <= MaxMarshalInteger));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 3951, 3990);

                _marshalType = UnmanagedType.ByValTStr;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 4004, 4045);

                _marshalArrayElementCount = elementCount;
                DynAbs.Tracing.TraceSender.TraceExitMethod(812, 3786, 4056);

                int
                f_812_3866_3934(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 3866, 3934);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 3786, 4056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 3786, 4056);
            }
        }

        internal void SetMarshalAsSimpleType(UnmanagedType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 4068, 4252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 4149, 4207);

                f_812_4149_4206(type >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(812, 4162, 4205) && (int)type <= MaxMarshalInteger));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 4221, 4241);

                _marshalType = type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(812, 4068, 4252);

                int
                f_812_4149_4206(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 4149, 4206);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 4068, 4252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 4068, 4252);
            }
        }

        public UnmanagedType UnmanagedType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 4345, 4373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 4351, 4371);

                    return _marshalType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(812, 4345, 4373);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 4286, 4384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 4286, 4384);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        int Cci.IMarshallingInformation.IidParameterIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 4470, 4788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 4506, 4723);

                    f_812_4506_4722(_marshalType == UnmanagedType.Interface || (DynAbs.Tracing.TraceSender.Expression_False(812, 4541, 4643) || _marshalType == UnmanagedType.IUnknown) || (DynAbs.Tracing.TraceSender.Expression_False(812, 4541, 4721) || _marshalType == Cci.Constants.UnmanagedType_IDispatch));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 4743, 4773);

                    return _marshalParameterIndex;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(812, 4470, 4788);

                    int
                    f_812_4506_4722(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 4506, 4722);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 4396, 4799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 4396, 4799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        object Cci.IMarshallingInformation.GetCustomMarshaller(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 4811, 5474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 4911, 4985);

                f_812_4911_4984(_marshalType == Cci.Constants.UnmanagedType_CustomMarshaler);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 4999, 5064);

                var
                typeSymbol = _marshalTypeNameOrSymbol as ITypeSymbolInternal
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 5078, 5463) || true) && (typeSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(812, 5078, 5463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 5134, 5247);

                    return f_812_5141_5246(((CommonPEModuleBuilder)context.Module), typeSymbol, context.SyntaxNodeOpt, context.Diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(812, 5078, 5463);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(812, 5078, 5463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 5313, 5398);

                    f_812_5313_5397(_marshalTypeNameOrSymbol == null || (DynAbs.Tracing.TraceSender.Expression_False(812, 5326, 5396) || _marshalTypeNameOrSymbol is string));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 5416, 5448);

                    return _marshalTypeNameOrSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(812, 5078, 5463);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(812, 4811, 5474);

                int
                f_812_4911_4984(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 4911, 4984);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_812_5141_5246(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(symbol, syntaxOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 5141, 5246);
                    return return_v;
                }


                int
                f_812_5313_5397(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 5313, 5397);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 4811, 5474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 4811, 5474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string Cci.IMarshallingInformation.CustomMarshallerRuntimeArgument
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 5577, 5742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 5613, 5687);

                    f_812_5613_5686(_marshalType == Cci.Constants.UnmanagedType_CustomMarshaler);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 5705, 5727);

                    return _marshalCookie;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(812, 5577, 5742);

                    int
                    f_812_5613_5686(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 5613, 5686);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 5486, 5753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 5486, 5753);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        int Cci.IMarshallingInformation.NumberOfElements
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 5838, 6136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 5874, 6070);

                    f_812_5874_6069(_marshalType == UnmanagedType.ByValTStr || (DynAbs.Tracing.TraceSender.Expression_False(812, 5887, 5967) || _marshalType == UnmanagedType.LPArray) || (DynAbs.Tracing.TraceSender.Expression_False(812, 5887, 6024) || _marshalType == Cci.Constants.UnmanagedType_SafeArray) || (DynAbs.Tracing.TraceSender.Expression_False(812, 5887, 6068) || _marshalType == UnmanagedType.ByValArray));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 6088, 6121);

                    return _marshalArrayElementCount;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(812, 5838, 6136);

                    int
                    f_812_5874_6069(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 5874, 6069);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 5765, 6147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 5765, 6147);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        short Cci.IMarshallingInformation.ParamIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 6228, 6430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 6264, 6360);

                    f_812_6264_6359(_marshalType == UnmanagedType.LPArray && (DynAbs.Tracing.TraceSender.Expression_True(812, 6277, 6358) && _marshalParameterIndex <= short.MaxValue));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 6378, 6415);

                    return (short)_marshalParameterIndex;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(812, 6228, 6430);

                    int
                    f_812_6264_6359(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 6264, 6359);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 6159, 6441);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 6159, 6441);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        UnmanagedType Cci.IMarshallingInformation.ElementType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 6531, 6743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 6567, 6663);

                    f_812_6567_6662(_marshalType == UnmanagedType.LPArray || (DynAbs.Tracing.TraceSender.Expression_False(812, 6580, 6661) || _marshalType == UnmanagedType.ByValArray));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 6681, 6728);

                    return (UnmanagedType)_marshalArrayElementType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(812, 6531, 6743);

                    int
                    f_812_6567_6662(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 6567, 6662);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 6453, 6754);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 6453, 6754);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.VarEnum Cci.IMarshallingInformation.SafeArrayElementSubtype
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 6854, 7036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 6890, 6958);

                    f_812_6890_6957(_marshalType == Cci.Constants.UnmanagedType_SafeArray);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 6976, 7021);

                    return (Cci.VarEnum)_marshalArrayElementType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(812, 6854, 7036);

                    int
                    f_812_6890_6957(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 6890, 6957);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 6766, 7047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 6766, 7047);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.IMarshallingInformation.GetSafeArrayElementUserDefinedSubtype(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 7059, 7545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 7189, 7257);

                f_812_7189_7256(_marshalType == Cci.Constants.UnmanagedType_SafeArray);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 7273, 7370) || true) && (_marshalTypeNameOrSymbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(812, 7273, 7370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 7343, 7355);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(812, 7273, 7370);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 7386, 7534);

                return f_812_7393_7533(((CommonPEModuleBuilder)context.Module), _marshalTypeNameOrSymbol, context.SyntaxNodeOpt, context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(812, 7059, 7545);

                int
                f_812_7189_7256(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 7189, 7256);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_812_7393_7533(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, object
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)symbol, syntaxOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 7393, 7533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 7059, 7545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 7059, 7545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MarshalPseudoCustomAttributeData WithTranslatedTypes<TTypeSymbol, TArg>(
                    Func<TTypeSymbol, TArg, TTypeSymbol> translator, TArg arg)
                    where TTypeSymbol : ITypeSymbolInternal
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 7822, 8641);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 8053, 8207) || true) && (_marshalType != Cci.Constants.UnmanagedType_SafeArray || (DynAbs.Tracing.TraceSender.Expression_False(812, 8057, 8146) || _marshalTypeNameOrSymbol == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(812, 8053, 8207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 8180, 8192);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(812, 8053, 8207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 8223, 8299);

                var
                translatedType = f_812_8244_8298(translator, _marshalTypeNameOrSymbol, arg)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 8313, 8436) || true) && ((object)translatedType == (object)_marshalTypeNameOrSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(812, 8313, 8436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 8409, 8421);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(812, 8313, 8436);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 8452, 8504);

                var
                result = f_812_8465_8503()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 8518, 8602);

                f_812_8518_8601(result, (Cci.VarEnum)_marshalArrayElementType, translatedType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 8616, 8630);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(812, 7822, 8641);

                TTypeSymbol
                f_812_8244_8298(System.Func<TTypeSymbol, TArg, TTypeSymbol>
                this_param, object
                arg1, TArg
                arg2)
                {
                    var return_v = this_param.Invoke((TTypeSymbol)arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 8244, 8298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                f_812_8465_8503()
                {
                    var return_v = new Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 8465, 8503);
                    return return_v;
                }


                int
                f_812_8518_8601(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                this_param, Microsoft.Cci.VarEnum
                elementType, TTypeSymbol
                elementTypeSymbol)
                {
                    this_param.SetMarshalAsSafeArray((Microsoft.Cci.VarEnum?)elementType, (Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)elementTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(812, 8518, 8601);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 7822, 8641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 7822, 8641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ITypeSymbolInternal TryGetSafeArrayElementUserDefinedSubtype()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(812, 8678, 8840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 8774, 8829);

                return _marshalTypeNameOrSymbol as ITypeSymbolInternal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(812, 8678, 8840);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(812, 8678, 8840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 8678, 8840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MarshalPseudoCustomAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(812, 535, 8847);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 1235, 1247);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 1286, 1331);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 1368, 1409);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(812, 1439, 1469);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(812, 535, 8847);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(812, 535, 8847);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(812, 535, 8847);
    }
}
