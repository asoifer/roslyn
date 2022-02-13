// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CodeGen;


namespace Microsoft.CodeAnalysis.CSharp.Emit.NoPia
{
    internal sealed class EmbeddedField : EmbeddedTypesManager.CommonEmbeddedField
    {
        public EmbeddedField(EmbeddedType containingType, FieldSymbolAdapter underlyingField) : base(f_10944_785_799_C(containingType), underlyingField)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10944, 679, 839);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10944, 679, 839);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 679, 839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 679, 839);
            }
        }

        internal override EmbeddedTypesManager TypeManager
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 926, 1011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 962, 996);

                    return ContainingType.TypeManager;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 926, 1011);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 851, 1022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 851, 1022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 1034, 1261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 1167, 1250);

                return f_10944_1174_1249(f_10944_1174_1208(f_10944_1174_1189()), moduleBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 1034, 1261);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10944_1174_1189()
                {
                    var return_v = UnderlyingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1174, 1189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10944_1174_1208(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1174, 1208);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10944_1174_1249(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10944, 1174, 1249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 1034, 1261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 1034, 1261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override MetadataConstant GetCompileTimeValue(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 1273, 1442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 1374, 1431);

                return f_10944_1381_1430(f_10944_1381_1396(), context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 1273, 1442);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10944_1381_1396()
                {
                    var return_v = UnderlyingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1381, 1396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_10944_1381_1430(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetMetadataConstantValue(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10944, 1381, 1430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 1273, 1442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 1273, 1442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsCompileTimeConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 1524, 1636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 1560, 1621);

                    return f_10944_1567_1620(f_10944_1567_1601(f_10944_1567_1582()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 1524, 1636);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_1567_1582()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1567, 1582);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_1567_1601(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1567, 1601);
                        return return_v;
                    }


                    bool
                    f_10944_1567_1620(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataConstant;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1567, 1620);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 1454, 1647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 1454, 1647);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsNotSerialized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 1723, 1832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 1759, 1817);

                    return f_10944_1766_1816(f_10944_1766_1800(f_10944_1766_1781()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 1723, 1832);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_1766_1781()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1766, 1781);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_1766_1800(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1766, 1800);
                        return return_v;
                    }


                    bool
                    f_10944_1766_1816(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsNotSerialized;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1766, 1816);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 1659, 1843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 1659, 1843);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 1914, 2018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 1950, 2003);

                    return f_10944_1957_2002(f_10944_1957_1991(f_10944_1957_1972()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 1914, 2018);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_1957_1972()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1957, 1972);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_1957_1991(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1957, 1991);
                        return return_v;
                    }


                    bool
                    f_10944_1957_2002(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsReadOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 1957, 2002);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 1855, 2029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 1855, 2029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 2106, 2221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 2142, 2206);

                    return f_10944_2149_2205(f_10944_2149_2183(f_10944_2149_2164()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 2106, 2221);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_2149_2164()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2149, 2164);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_2149_2183(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2149, 2183);
                        return return_v;
                    }


                    bool
                    f_10944_2149_2205(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2149, 2205);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 2041, 2232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 2041, 2232);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 2306, 2414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 2342, 2399);

                    return f_10944_2349_2398(f_10944_2349_2383(f_10944_2349_2364()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 2306, 2414);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_2349_2364()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2349, 2364);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_2349_2383(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2349, 2383);
                        return return_v;
                    }


                    bool
                    f_10944_2349_2398(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2349, 2398);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 2244, 2425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 2244, 2425);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 2494, 2596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 2530, 2581);

                    return f_10944_2537_2580(f_10944_2537_2571(f_10944_2537_2552()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 2494, 2596);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_2537_2552()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2537, 2552);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_2537_2571(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2537, 2571);
                        return return_v;
                    }


                    bool
                    f_10944_2537_2580(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2537, 2580);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 2437, 2607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 2437, 2607);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 2690, 2806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 2726, 2791);

                    return f_10944_2733_2790(f_10944_2733_2767(f_10944_2733_2748()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 2690, 2806);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_2733_2748()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2733, 2748);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_2733_2767(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2733, 2767);
                        return return_v;
                    }


                    bool
                    f_10944_2733_2790(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMarshalledExplicitly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2733, 2790);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 2619, 2817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 2619, 2817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.IMarshallingInformation MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 2923, 3039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 2959, 3024);

                    return f_10944_2966_3023(f_10944_2966_3000(f_10944_2966_2981()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 2923, 3039);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_2966_2981()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2966, 2981);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_2966_3000(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2966, 3000);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10944_2966_3023(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 2966, 3023);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 2829, 3050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 2829, 3050);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<byte> MarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 3148, 3263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 3184, 3248);

                    return f_10944_3191_3247(f_10944_3191_3225(f_10944_3191_3206()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 3148, 3263);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_3191_3206()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 3191, 3206);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_3191_3225(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 3191, 3225);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10944_3191_3247(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 3191, 3247);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 3062, 3274);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 3062, 3274);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override int? TypeLayoutOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 3351, 3461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 3387, 3446);

                    return f_10944_3394_3445(f_10944_3394_3428(f_10944_3394_3409()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 3351, 3461);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_3394_3409()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 3394, 3409);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_3394_3428(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 3394, 3428);
                        return return_v;
                    }


                    int?
                    f_10944_3394_3445(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeLayoutOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 3394, 3445);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 3286, 3472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 3286, 3472);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.TypeMemberVisibility Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 3563, 3690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 3599, 3675);

                    return f_10944_3606_3674(f_10944_3639_3673(f_10944_3639_3654()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 3563, 3690);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_3639_3654()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 3639, 3654);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_3639_3673(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 3639, 3673);
                        return return_v;
                    }


                    Microsoft.Cci.TypeMemberVisibility
                    f_10944_3606_3674(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    symbol)
                    {
                        var return_v = PEModuleBuilder.MemberVisibility((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10944, 3606, 3674);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 3484, 3701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 3484, 3701);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10944, 3768, 3874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10944, 3804, 3859);

                    return f_10944_3811_3858(f_10944_3811_3845(f_10944_3811_3826()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10944, 3768, 3874);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    f_10944_3811_3826()
                    {
                        var return_v = UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 3811, 3826);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10944_3811_3845(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedFieldSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 3811, 3845);
                        return return_v;
                    }


                    string
                    f_10944_3811_3858(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10944, 3811, 3858);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10944, 3713, 3885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 3713, 3885);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static EmbeddedField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10944, 584, 3892);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10944, 584, 3892);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10944, 584, 3892);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10944, 584, 3892);

        static Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
        f_10944_785_799_C(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10944, 679, 839);
            return return_v;
        }

    }
}
