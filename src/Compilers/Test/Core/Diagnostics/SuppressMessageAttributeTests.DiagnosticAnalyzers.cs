// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.UnitTests.Diagnostics
{
    public partial class SuppressMessageAttributeTests
    {
        protected const string
        TestDiagnosticCategory = "Test"
        ;

        protected const string
        TestDiagnosticMessageTemplate = "{0}"
        ;
        protected class WarningOnCompilationEndedAnalyzer : DiagnosticAnalyzer
        {
            public const string
            Id = "CompilationEnded"
            ;

            private static readonly DiagnosticDescriptor s_rule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 1155, 1255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 1199, 1236);

                        return f_25080_1206_1235(s_rule);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 1155, 1255);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                        f_25080_1206_1235(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item)
                        {
                            var return_v = ImmutableArray.Create(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 1206, 1235);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 1049, 1270);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 1049, 1270);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext analysisContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 1286, 1679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 1383, 1664);

                    f_25080_1383_1663(analysisContext, (context) =>
                            {
                                context.ReportDiagnostic(CodeAnalysis.Diagnostic.Create(s_rule, Location.None, messageArgs: Id));
                            });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 1286, 1679);

                    int
                    f_25080_1383_1663(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 1383, 1663);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 1286, 1679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 1286, 1679);
                }
            }

            public WarningOnCompilationEndedAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25080, 814, 1690);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25080, 814, 1690);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 814, 1690);
            }


            static WarningOnCompilationEndedAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25080, 814, 1690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 929, 952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 1012, 1032);
                s_rule = f_25080_1021_1032(Id); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25080, 814, 1690);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 814, 1690);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25080, 814, 1690);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25080_1021_1032(string
            id)
            {
                var return_v = GetRule(id);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 1021, 1032);
                return return_v;
            }

        }
        protected class WarningOnNamePrefixDeclarationAnalyzer : DiagnosticAnalyzer
        {
            public const string
            Id = "Declaration"
            ;

            private static readonly DiagnosticDescriptor s_rule;

            private readonly string _errorSymbolPrefix;

            public WarningOnNamePrefixDeclarationAnalyzer(string errorSymbolPrefix)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25080, 2102, 2260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 2067, 2085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 2206, 2245);

                    _errorSymbolPrefix = errorSymbolPrefix;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25080, 2102, 2260);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 2102, 2260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 2102, 2260);
                }
            }

            public override void Initialize(AnalysisContext analysisContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 2276, 3101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 2373, 3086);

                    f_25080_2373_3085(analysisContext, (context) =>
                            {
                                if (context.Symbol.Name.StartsWith(_errorSymbolPrefix, StringComparison.Ordinal))
                                {
                                    context.ReportDiagnostic(CodeAnalysis.Diagnostic.Create(s_rule, context.Symbol.Locations.First(), messageArgs: context.Symbol.Name));
                                }
                            }, SymbolKind.Event, SymbolKind.Field, SymbolKind.Method, SymbolKind.NamedType, SymbolKind.Namespace, SymbolKind.Property);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 2276, 3101);

                    int
                    f_25080_2373_3085(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 2373, 3085);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 2276, 3101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 2276, 3101);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 3223, 3323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 3267, 3304);

                        return f_25080_3274_3303(s_rule);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 3223, 3323);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                        f_25080_3274_3303(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item)
                        {
                            var return_v = ImmutableArray.Create(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 3274, 3303);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 3117, 3338);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 3117, 3338);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static WarningOnNamePrefixDeclarationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25080, 1808, 3349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 1928, 1946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 2006, 2026);
                s_rule = f_25080_2015_2026(Id); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25080, 1808, 3349);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 1808, 3349);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25080, 1808, 3349);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25080_2015_2026(string
            id)
            {
                var return_v = GetRule(id);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 2015, 2026);
                return return_v;
            }

        }
        protected class WarningOnTypeDeclarationAnalyzer : DiagnosticAnalyzer
        {
            public const string
            TypeId = "TypeDeclaration"
            ;

            private static readonly DiagnosticDescriptor s_rule;

            public override void Initialize(AnalysisContext analysisContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 3670, 4115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 3767, 4100);

                    f_25080_3767_4099(analysisContext, (context) =>
                            {
                                context.ReportDiagnostic(CodeAnalysis.Diagnostic.Create(s_rule, context.Symbol.Locations.First(), messageArgs: context.Symbol.Name));
                            }, SymbolKind.NamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 3670, 4115);

                    int
                    f_25080_3767_4099(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 3767, 4099);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 3670, 4115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 3670, 4115);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 4237, 4337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 4281, 4318);

                        return f_25080_4288_4317(s_rule);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 4237, 4337);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                        f_25080_4288_4317(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item)
                        {
                            var return_v = ImmutableArray.Create(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 4288, 4317);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 4131, 4352);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 4131, 4352);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public WarningOnTypeDeclarationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25080, 3429, 4363);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25080, 3429, 4363);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 3429, 4363);
            }


            static WarningOnTypeDeclarationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25080, 3429, 4363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 3543, 3569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 3629, 3653);
                s_rule = f_25080_3638_3653(TypeId); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25080, 3429, 4363);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 3429, 4363);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25080, 3429, 4363);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25080_3638_3653(string
            id)
            {
                var return_v = GetRule(id);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 3638, 3653);
                return return_v;
            }

        }
        protected class WarningOnCodeBodyAnalyzer : DiagnosticAnalyzer
        {
            public const string
            Id = "CodeBody"
            ;

            private static readonly DiagnosticDescriptor s_rule;

            private readonly string _language;

            public WarningOnCodeBodyAnalyzer(string language)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25080, 4760, 4878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 4734, 4743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 4842, 4863);

                    _language = language;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25080, 4760, 4878);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 4760, 4878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 4760, 4878);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 5000, 5100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 5044, 5081);

                        return f_25080_5051_5080(s_rule);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 5000, 5100);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                        f_25080_5051_5080(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item)
                        {
                            var return_v = ImmutableArray.Create(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 5051, 5080);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 4894, 5115);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 4894, 5115);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext analysisContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 5131, 5637);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 5228, 5622) || true) && (_language == LanguageNames.CSharp)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25080, 5228, 5622);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 5307, 5412);

                        f_25080_5307_5411(analysisContext, f_25080_5371_5399().Initialize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25080, 5228, 5622);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25080, 5228, 5622);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 5494, 5603);

                        f_25080_5494_5602(analysisContext, f_25080_5563_5590().Initialize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25080, 5228, 5622);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 5131, 5637);

                    Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCodeBodyAnalyzer.CSharpCodeBodyAnalyzer
                    f_25080_5371_5399()
                    {
                        var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCodeBodyAnalyzer.CSharpCodeBodyAnalyzer();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 5371, 5399);
                        return return_v;
                    }


                    int
                    f_25080_5307_5411(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<Microsoft.CodeAnalysis.CSharp.SyntaxKind>>
                    action)
                    {
                        this_param.RegisterCodeBlockStartAction<Microsoft.CodeAnalysis.CSharp.SyntaxKind>(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 5307, 5411);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCodeBodyAnalyzer.BasicCodeBodyAnalyzer
                    f_25080_5563_5590()
                    {
                        var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCodeBodyAnalyzer.BasicCodeBodyAnalyzer();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 5563, 5590);
                        return return_v;
                    }


                    int
                    f_25080_5494_5602(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<Microsoft.CodeAnalysis.VisualBasic.SyntaxKind>>
                    action)
                    {
                        this_param.RegisterCodeBlockStartAction<Microsoft.CodeAnalysis.VisualBasic.SyntaxKind>(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 5494, 5602);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 5131, 5637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 5131, 5637);
                }
            }
            protected class CSharpCodeBodyAnalyzer
            {
                public void Initialize(CodeBlockStartAnalysisContext<CSharp.SyntaxKind> analysisContext)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 5724, 6606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 5853, 6186);

                        f_25080_5853_6185(analysisContext, (context) =>
                                {
                                    context.ReportDiagnostic(CodeAnalysis.Diagnostic.Create(s_rule, context.OwningSymbol.Locations.First(), messageArgs: context.OwningSymbol.Name + ":end"));
                                });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 6210, 6587);

                        f_25080_6210_6586(
                                            analysisContext, (context) =>
                                                    {
                                                        context.ReportDiagnostic(CodeAnalysis.Diagnostic.Create(s_rule, context.Node.GetLocation(), messageArgs: context.Node.ToFullString()));
                                                    }, CSharp.SyntaxKind.InvocationExpression);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 5724, 6606);

                        int
                        f_25080_5853_6185(Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<Microsoft.CodeAnalysis.CSharp.SyntaxKind>
                        this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                        action)
                        {
                            this_param.RegisterCodeBlockEndAction(action);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 5853, 6185);
                            return 0;
                        }


                        int
                        f_25080_6210_6586(Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<Microsoft.CodeAnalysis.CSharp.SyntaxKind>
                        this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                        action, params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
                        syntaxKinds)
                        {
                            this_param.RegisterSyntaxNodeAction(action, syntaxKinds);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 6210, 6586);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 5724, 6606);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 5724, 6606);
                    }
                }

                public CSharpCodeBodyAnalyzer()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25080, 5653, 6621);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25080, 5653, 6621);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 5653, 6621);
                }


                static CSharpCodeBodyAnalyzer()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25080, 5653, 6621);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25080, 5653, 6621);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 5653, 6621);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25080, 5653, 6621);
            }
            protected class BasicCodeBodyAnalyzer
            {
                public void Initialize(CodeBlockStartAnalysisContext<VisualBasic.SyntaxKind> analysisContext)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 6707, 7599);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 6841, 7174);

                        f_25080_6841_7173(analysisContext, (context) =>
                                {
                                    context.ReportDiagnostic(CodeAnalysis.Diagnostic.Create(s_rule, context.OwningSymbol.Locations.First(), messageArgs: context.OwningSymbol.Name + ":end"));
                                });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 7198, 7580);

                        f_25080_7198_7579(
                                            analysisContext, (context) =>
                                                    {
                                                        context.ReportDiagnostic(CodeAnalysis.Diagnostic.Create(s_rule, context.Node.GetLocation(), messageArgs: context.Node.ToFullString()));
                                                    }, VisualBasic.SyntaxKind.InvocationExpression);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 6707, 7599);

                        int
                        f_25080_6841_7173(Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<Microsoft.CodeAnalysis.VisualBasic.SyntaxKind>
                        this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                        action)
                        {
                            this_param.RegisterCodeBlockEndAction(action);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 6841, 7173);
                            return 0;
                        }


                        int
                        f_25080_7198_7579(Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<Microsoft.CodeAnalysis.VisualBasic.SyntaxKind>
                        this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                        action, params Microsoft.CodeAnalysis.VisualBasic.SyntaxKind[]
                        syntaxKinds)
                        {
                            this_param.RegisterSyntaxNodeAction(action, syntaxKinds);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 7198, 7579);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 6707, 7599);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 6707, 7599);
                    }
                }

                public BasicCodeBodyAnalyzer()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25080, 6637, 7614);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25080, 6637, 7614);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 6637, 7614);
                }


                static BasicCodeBodyAnalyzer()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25080, 6637, 7614);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25080, 6637, 7614);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 6637, 7614);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25080, 6637, 7614);
            }

            static WarningOnCodeBodyAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25080, 4491, 7625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 4598, 4613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 4673, 4693);
                s_rule = f_25080_4682_4693(Id); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25080, 4491, 7625);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 4491, 7625);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25080, 4491, 7625);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25080_4682_4693(string
            id)
            {
                var return_v = GetRule(id);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 4682, 4693);
                return return_v;
            }

        }
        protected class WarningOnCommentAnalyzer : DiagnosticAnalyzer
        {
            public const string
            Id = "Comment"
            ;

            private static readonly DiagnosticDescriptor s_rule;

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 8033, 8133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 8077, 8114);

                        return f_25080_8084_8113(s_rule);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 8033, 8133);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                        f_25080_8084_8113(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item)
                        {
                            var return_v = ImmutableArray.Create(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 8084, 8113);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 7927, 8148);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 7927, 8148);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext analysisContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 8164, 9075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 8261, 9060);

                    f_25080_8261_9059(analysisContext, (context) =>
                            {
                                var comments = context.Tree.GetRoot().DescendantTrivia()
                                   .Where(t =>
                                       t.IsKind(SyntaxKind.SingleLineCommentTrivia) ||
                                       t.IsKind(SyntaxKind.MultiLineCommentTrivia) ||
                                       t.IsKind(VisualBasic.SyntaxKind.CommentTrivia));

                                foreach (var comment in comments)
                                {
                                    context.ReportDiagnostic(CodeAnalysis.Diagnostic.Create(s_rule, comment.GetLocation(), messageArgs: comment.ToFullString()));
                                }
                            });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 8164, 9075);

                    int
                    f_25080_8261_9059(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                    action)
                    {
                        this_param.RegisterSyntaxTreeAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 8261, 9059);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 8164, 9075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 8164, 9075);
                }
            }

            public WarningOnCommentAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25080, 7710, 9086);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25080, 7710, 9086);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 7710, 9086);
            }


            static WarningOnCommentAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25080, 7710, 9086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 7816, 7830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 7890, 7910);
                s_rule = f_25080_7899_7910(Id); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25080, 7710, 9086);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 7710, 9086);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25080, 7710, 9086);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25080_7899_7910(string
            id)
            {
                var return_v = GetRule(id);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 7899, 7910);
                return return_v;
            }

        }
        protected class WarningOnTokenAnalyzer : DiagnosticAnalyzer
        {
            public const string
            Id = "Token"
            ;

            private static readonly DiagnosticDescriptor s_rule;

            private readonly IList<TextSpan> _spans;

            public WarningOnTokenAnalyzer(IList<TextSpan> spans)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25080, 9455, 9570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 9432, 9438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 9540, 9555);

                    _spans = spans;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25080, 9455, 9570);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 9455, 9570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 9455, 9570);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 9692, 9792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 9736, 9773);

                        return f_25080_9743_9772(s_rule);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 9692, 9792);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                        f_25080_9743_9772(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item)
                        {
                            var return_v = ImmutableArray.Create(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 9743, 9772);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 9586, 9807);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 9586, 9807);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext analysisContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 9823, 10588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 9920, 10573);

                    f_25080_9920_10572(analysisContext, (context) =>
                            {
                                foreach (var nodeOrToken in context.Tree.GetRoot().DescendantNodesAndTokens())
                                {
                                    if (nodeOrToken.IsToken && _spans.Any(s => s.OverlapsWith(nodeOrToken.FullSpan)))
                                    {
                                        context.ReportDiagnostic(CodeAnalysis.Diagnostic.Create(s_rule, nodeOrToken.GetLocation(), messageArgs: nodeOrToken.ToString()));
                                    }
                                }
                            });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 9823, 10588);

                    int
                    f_25080_9920_10572(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                    action)
                    {
                        this_param.RegisterSyntaxTreeAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 9920, 10572);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 9823, 10588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 9823, 10588);
                }
            }

            static WarningOnTokenAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25080, 9188, 10599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 9292, 9304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 9364, 9384);
                s_rule = f_25080_9373_9384(Id); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25080, 9188, 10599);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 9188, 10599);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25080, 9188, 10599);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25080_9373_9384(string
            id)
            {
                var return_v = GetRule(id);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 9373, 9384);
                return return_v;
            }

        }
        protected class ThrowExceptionForEachNamedTypeAnalyzer : DiagnosticAnalyzer
        {
            public const string
            Id = "ThrowException"
            ;

            private static readonly DiagnosticDescriptor s_rule;

            private readonly ExceptionDispatchInfo _exceptionDispatchInfo;

            public ThrowExceptionForEachNamedTypeAnalyzer(ExceptionDispatchInfo exceptionDispatchInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25080, 10995, 11180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 10956, 10978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 11433, 11481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 11118, 11165);

                    _exceptionDispatchInfo = exceptionDispatchInfo;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25080, 10995, 11180);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 10995, 11180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 10995, 11180);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 11302, 11402);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 11346, 11383);

                        return f_25080_11353_11382(s_rule);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 11302, 11402);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                        f_25080_11353_11382(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        item)
                        {
                            var return_v = ImmutableArray.Create(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 11353, 11382);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 11196, 11417);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 11196, 11417);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public string AssemblyName { get; private set; }

            public override void Initialize(AnalysisContext analysisContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 11497, 11955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 11594, 11701);

                    f_25080_11594_11700(analysisContext, context => AssemblyName = context.Compilation.AssemblyName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 11721, 11940);

                    f_25080_11721_11939(
                                    analysisContext, (context) =>
                                        {
                                            _exceptionDispatchInfo.Throw();
                                        }, SymbolKind.NamedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 11497, 11955);

                    int
                    f_25080_11594_11700(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                    action)
                    {
                        this_param.RegisterCompilationStartAction(action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 11594, 11700);
                        return 0;
                    }


                    int
                    f_25080_11721_11939(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                    this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                    action, params Microsoft.CodeAnalysis.SymbolKind[]
                    symbolKinds)
                    {
                        this_param.RegisterSymbolAction(action, symbolKinds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 11721, 11939);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 11497, 11955);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 11497, 11955);
                }
            }

            static ThrowExceptionForEachNamedTypeAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25080, 10681, 11966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 10801, 10822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 10882, 10902);
                s_rule = f_25080_10891_10902(Id); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25080, 10681, 11966);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 10681, 11966);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25080, 10681, 11966);

            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_25080_10891_10902(string
            id)
            {
                var return_v = GetRule(id);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 10891, 10902);
                return return_v;
            }

        }
        protected class ThrowExceptionFromSupportedDiagnostics : DiagnosticAnalyzer
        {
            private readonly Exception _exception;

            public ThrowExceptionFromSupportedDiagnostics(Exception exception)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25080, 12132, 12269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 12105, 12115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 12231, 12254);

                    _exception = exception;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25080, 12132, 12269);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 12132, 12269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 12132, 12269);
                }
            }

            public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 12391, 12563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 12435, 12485);

                        f_25080_12435_12484(f_25080_12435_12476(_exception));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 12507, 12544);

                        throw f_25080_12513_12543();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 12391, 12563);

                        System.Runtime.ExceptionServices.ExceptionDispatchInfo
                        f_25080_12435_12476(System.Exception
                        source)
                        {
                            var return_v = ExceptionDispatchInfo.Capture(source);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 12435, 12476);
                            return return_v;
                        }


                        int
                        f_25080_12435_12484(System.Runtime.ExceptionServices.ExceptionDispatchInfo
                        this_param)
                        {
                            this_param.Throw();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 12435, 12484);
                            return 0;
                        }


                        System.Exception
                        f_25080_12513_12543()
                        {
                            var return_v = ExceptionUtilities.Unreachable;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25080, 12513, 12543);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 12285, 12578);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 12285, 12578);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void Initialize(AnalysisContext analysisContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25080, 12676, 12715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 12679, 12715);
                    throw f_25080_12685_12715(); DynAbs.Tracing.TraceSender.TraceExitMethod(25080, 12676, 12715);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 12676, 12715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 12676, 12715);
                }

                System.Exception
                f_25080_12685_12715()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25080, 12685, 12715);
                    return return_v;
                }

            }

            static ThrowExceptionFromSupportedDiagnostics()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25080, 11978, 12727);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25080, 11978, 12727);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 11978, 12727);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25080, 11978, 12727);
        }

        protected static DiagnosticDescriptor GetRule(string id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25080, 12739, 13083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080, 12820, 13072);

                return f_25080_12827_13071(id, id, TestDiagnosticMessageTemplate, TestDiagnosticCategory, DiagnosticSeverity.Warning, isEnabledByDefault: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25080, 12739, 13083);

                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_25080_12827_13071(string
                id, string
                title, string
                messageFormat, string
                category, Microsoft.CodeAnalysis.DiagnosticSeverity
                defaultSeverity, bool
                isEnabledByDefault, params string[]
                customTags)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25080, 12827, 13071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25080, 12739, 13083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25080, 12739, 13083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
