// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class DocumentationCommentIDVisitor : CSharpSymbolVisitor<StringBuilder, object>
    {
        public static readonly DocumentationCommentIDVisitor Instance;

        private DocumentationCommentIDVisitor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10933, 578, 639);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10933, 578, 639);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10933, 578, 639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 578, 639);
            }
        }

        public override object DefaultVisit(Symbol symbol, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10933, 651, 874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 851, 863);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10933, 651, 874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10933, 651, 874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 651, 874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitNamespace(NamespaceSymbol symbol, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10933, 886, 1195);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 995, 1156) || true) && (f_10933_999_1024_M(!symbol.IsGlobalNamespace))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10933, 995, 1156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1058, 1079);

                    f_10933_1058_1078(builder, "N:");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1097, 1141);

                    f_10933_1097_1140(PartVisitor.Instance, symbol, builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10933, 995, 1156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1172, 1184);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10933, 886, 1195);

                bool
                f_10933_999_1024_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10933, 999, 1024);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10933_1058_1078(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 1058, 1078);
                    return return_v;
                }


                object
                f_10933_1097_1140(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, System.Text.StringBuilder
                argument)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 1097, 1140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10933, 886, 1195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 886, 1195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitMethod(MethodSymbol symbol, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10933, 1207, 1428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1310, 1331);

                f_10933_1310_1330(builder, "M:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1345, 1389);

                f_10933_1345_1388(PartVisitor.Instance, symbol, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1405, 1417);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10933, 1207, 1428);

                System.Text.StringBuilder
                f_10933_1310_1330(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 1310, 1330);
                    return return_v;
                }


                object
                f_10933_1345_1388(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, System.Text.StringBuilder
                argument)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 1345, 1388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10933, 1207, 1428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 1207, 1428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitField(FieldSymbol symbol, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10933, 1440, 1659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1541, 1562);

                f_10933_1541_1561(builder, "F:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1576, 1620);

                f_10933_1576_1619(PartVisitor.Instance, symbol, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1636, 1648);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10933, 1440, 1659);

                System.Text.StringBuilder
                f_10933_1541_1561(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 1541, 1561);
                    return return_v;
                }


                object
                f_10933_1576_1619(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, System.Text.StringBuilder
                argument)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 1576, 1619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10933, 1440, 1659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 1440, 1659);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitEvent(EventSymbol symbol, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10933, 1671, 1890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1772, 1793);

                f_10933_1772_1792(builder, "E:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1807, 1851);

                f_10933_1807_1850(PartVisitor.Instance, symbol, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 1867, 1879);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10933, 1671, 1890);

                System.Text.StringBuilder
                f_10933_1772_1792(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 1772, 1792);
                    return return_v;
                }


                object
                f_10933_1807_1850(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol, System.Text.StringBuilder
                argument)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 1807, 1850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10933, 1671, 1890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 1671, 1890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitProperty(PropertySymbol symbol, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10933, 1902, 2127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 2009, 2030);

                f_10933_2009_2029(builder, "P:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 2044, 2088);

                f_10933_2044_2087(PartVisitor.Instance, symbol, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 2104, 2116);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10933, 1902, 2127);

                System.Text.StringBuilder
                f_10933_2009_2029(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 2009, 2029);
                    return return_v;
                }


                object
                f_10933_2044_2087(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, System.Text.StringBuilder
                argument)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 2044, 2087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10933, 1902, 2127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 1902, 2127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitNamedType(NamedTypeSymbol symbol, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10933, 2139, 2366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 2248, 2269);

                f_10933_2248_2268(builder, "T:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 2283, 2327);

                f_10933_2283_2326(PartVisitor.Instance, symbol, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 2343, 2355);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10933, 2139, 2366);

                System.Text.StringBuilder
                f_10933_2248_2268(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 2248, 2268);
                    return return_v;
                }


                object
                f_10933_2283_2326(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, System.Text.StringBuilder
                argument)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 2283, 2326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10933, 2139, 2366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 2139, 2366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitDynamicType(DynamicTypeSymbol symbol, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10933, 2378, 2882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 2834, 2871);

                return f_10933_2841_2870(this, symbol, builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10933, 2378, 2882);

                object
                f_10933_2841_2870(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                symbol, System.Text.StringBuilder
                builder)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 2841, 2870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10933, 2378, 2882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 2378, 2882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitErrorType(ErrorTypeSymbol symbol, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10933, 2894, 3121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 3003, 3024);

                f_10933_3003_3023(builder, "!:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 3038, 3082);

                f_10933_3038_3081(PartVisitor.Instance, symbol, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 3098, 3110);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10933, 2894, 3121);

                System.Text.StringBuilder
                f_10933_3003_3023(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 3003, 3023);
                    return return_v;
                }


                object
                f_10933_3038_3081(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                symbol, System.Text.StringBuilder
                argument)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 3038, 3081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10933, 2894, 3121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 2894, 3121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitTypeParameter(TypeParameterSymbol symbol, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10933, 3133, 3352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 3250, 3271);

                f_10933_3250_3270(builder, "!:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 3285, 3313);

                f_10933_3285_3312(builder, f_10933_3300_3311(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 3329, 3341);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10933, 3133, 3352);

                System.Text.StringBuilder
                f_10933_3250_3270(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 3250, 3270);
                    return return_v;
                }


                string
                f_10933_3300_3311(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10933, 3300, 3311);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10933_3285_3312(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 3285, 3312);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10933, 3133, 3352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 3133, 3352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DocumentationCommentIDVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10933, 345, 3359);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10933, 519, 565);
            Instance = f_10933_530_565(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10933, 345, 3359);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10933, 345, 3359);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10933, 345, 3359);

        static Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor
        f_10933_530_565()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10933, 530, 565);
            return return_v;
        }

    }
}
