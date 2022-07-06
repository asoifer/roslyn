// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public abstract class TestDiagnosticAnalyzer<TLanguageKindEnum> : DiagnosticAnalyzer where TLanguageKindEnum : struct
    {
        protected static readonly ImmutableArray<SymbolKind> AllSymbolKinds;

        protected static readonly ImmutableArray<TLanguageKindEnum> AllSyntaxKinds;

        protected static readonly ImmutableArray<string> AllAnalyzerMemberNames;

        protected static readonly DiagnosticDescriptor DefaultDiagnostic;

        private static ImmutableArray<T> GetAllEnumValues<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25081, 1513, 1674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25081, 1592, 1663);

                return f_25081_1599_1662(f_25081_1626_1661(f_25081_1626_1651(typeof(T))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25081, 1513, 1674);

                System.Array
                f_25081_1626_1651(System.Type
                enumType)
                {
                    var return_v = Enum.GetValues(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25081, 1626, 1651);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_25081_1626_1661(System.Array
                source)
                {
                    var return_v = source.Cast<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25081, 1626, 1661);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_25081_1599_1662(System.Collections.Generic.IEnumerable<T>
                items)
                {
                    var return_v = ImmutableArray.CreateRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25081, 1599, 1662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25081, 1513, 1674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25081, 1513, 1674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract void OnAbstractMember(string abstractMemberName, SyntaxNode node = null, ISymbol symbol = null, [CallerMemberName] string callerName = null);

        protected virtual void OnOptions(AnalyzerOptions options, [CallerMemberName] string callerName = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25081, 1856, 1962);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25081, 1856, 1962);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25081, 1856, 1962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25081, 1856, 1962);
            }
        }

        public override void Initialize(AnalysisContext context)
        {
            OnAbstractMember("Initialize");

            context.RegisterCodeBlockStartAction<TLanguageKindEnum>(new NestedCodeBlockAnalyzer(this).Initialize);

            context.RegisterCompilationAction(this.AnalyzeCompilation);
            context.RegisterSemanticModelAction(this.AnalyzeSemanticModel);
            context.RegisterCodeBlockAction(this.AnalyzeCodeBlock);
            context.RegisterSymbolAction(this.AnalyzeSymbol, AllSymbolKinds.ToArray());
            context.RegisterSyntaxTreeAction(this.AnalyzeSyntaxTree);
            context.RegisterAdditionalFileAction(this.AnalyzeAdditionalFile);
            context.RegisterSyntaxNodeAction<TLanguageKindEnum>(this.AnalyzeNode, AllSyntaxKinds.ToArray());
        }

        private void AnalyzeCodeBlock(CodeBlockAnalysisContext context)
        {
            OnAbstractMember("CodeBlock", context.CodeBlock, context.OwningSymbol);
            OnOptions(context.Options);
        }

        private void AnalyzeCompilation(CompilationAnalysisContext context)
        {
            OnAbstractMember("Compilation");
            OnOptions(context.Options);
        }

        private void AnalyzeSemanticModel(SemanticModelAnalysisContext context)
        {
            OnAbstractMember("SemanticModel");
            OnOptions(context.Options);
        }

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25081, 3534, 3692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25081, 3570, 3611);

                    f_25081_3570_3610(this, "SupportedDiagnostics");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25081, 3629, 3677);

                    return f_25081_3636_3676(DefaultDiagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25081, 3534, 3692);

                    int
                    f_25081_3570_3610(Microsoft.CodeAnalysis.Test.Utilities.TestDiagnosticAnalyzer<TLanguageKindEnum>
                    this_param, string
                    abstractMemberName)
                    {
                        this_param.OnAbstractMember(abstractMemberName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25081, 3570, 3610);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_25081_3636_3676(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25081, 3636, 3676);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25081, 3436, 3703);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25081, 3436, 3703);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void AnalyzeSymbol(SymbolAnalysisContext context)
        {
            OnAbstractMember("Symbol", symbol: context.Symbol);
            OnOptions(context.Options);
        }

        private void AnalyzeSyntaxTree(SyntaxTreeAnalysisContext context)
        {
            OnAbstractMember("SyntaxTree");
            OnOptions(context.Options);
        }

        private void AnalyzeAdditionalFile(AdditionalFileAnalysisContext context)
        {
            OnAbstractMember("AdditionalFile");
            OnOptions(context.Options);
        }

        private void AnalyzeNode(SyntaxNodeAnalysisContext context)
        {
            OnAbstractMember("SyntaxNode", context.Node);
            OnOptions(context.Options);
        }
        private class NestedCodeBlockAnalyzer
        {
            private readonly TestDiagnosticAnalyzer<TLanguageKindEnum> _container;

            public NestedCodeBlockAnalyzer(TestDiagnosticAnalyzer<TLanguageKindEnum> container)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25081, 4635, 4789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25081, 4608, 4618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25081, 4751, 4774);

                    _container = container;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25081, 4635, 4789);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25081, 4635, 4789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25081, 4635, 4789);
                }
            }

            public void Initialize(CodeBlockStartAnalysisContext<TLanguageKindEnum> context)
            {
                _container.OnAbstractMember("CodeBlockStart", context.CodeBlock, context.OwningSymbol);
                context.RegisterCodeBlockEndAction(_container.AnalyzeCodeBlock);
                context.RegisterSyntaxNodeAction(_container.AnalyzeNode, TestDiagnosticAnalyzer<TLanguageKindEnum>.AllSyntaxKinds.ToArray());
            }

            static NestedCodeBlockAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25081, 4487, 5256);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25081, 4487, 5256);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25081, 4487, 5256);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25081, 4487, 5256);
        }

        public TestDiagnosticAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25081, 442, 5285);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25081, 442, 5285);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25081, 442, 5285);
        }


        static TestDiagnosticAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25081, 442, 5285);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25081, 629, 676);
            AllSymbolKinds = f_25081_646_676(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25081, 749, 803);
            AllSyntaxKinds = f_25081_766_803<TLanguageKindEnum>(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25081, 865, 1106);
            AllAnalyzerMemberNames = f_25081_890_1106(new string[] { "AnalyzeCodeBlock", "AnalyzeCompilation", "AnalyzeNode", "AnalyzeSemanticModel", "AnalyzeSymbol", "AnalyzeSyntaxTree", "AnalyzeAdditionalFile", "Initialize", "SupportedDiagnostics" }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25081, 1166, 1429);
            DefaultDiagnostic = f_25081_1270_1429("CA7777", "CA7777_AnalyzerTestDiagnostic", "I'm here for test purposes", "Test", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25081, 442, 5285);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25081, 442, 5285);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25081, 442, 5285);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
        f_25081_646_676()
        {
            var return_v = GetAllEnumValues<SymbolKind>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25081, 646, 676);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
        f_25081_766_803<TLanguageKindEnum>()
        {
            var return_v = GetAllEnumValues<TLanguageKindEnum>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25081, 766, 803);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_25081_890_1106(string[]
        items)
        {
            var return_v = items.ToImmutableArray<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25081, 890, 1106);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_25081_1270_1429(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25081, 1270, 1429);
            return return_v;
        }

    }
}
