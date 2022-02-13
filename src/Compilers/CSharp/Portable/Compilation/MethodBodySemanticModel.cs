// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class MethodBodySemanticModel : MemberSemanticModel
    {
        internal readonly struct InitialState
        {

            internal readonly CSharpSyntaxNode Syntax;

            internal readonly BoundNode? Body;

            internal readonly ExecutableCodeBinder? Binder;

            internal readonly NullableWalker.SnapshotManager? SnapshotManager;

            internal readonly ImmutableDictionary<Symbol, Symbol>? RemappedSymbols;

            internal InitialState(
                            CSharpSyntaxNode syntax,
                            BoundNode? bodyOpt = null,
                            ExecutableCodeBinder? binder = null,
                            NullableWalker.SnapshotManager? snapshotManager = null,
                            ImmutableDictionary<Symbol, Symbol>? remappedSymbols = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10926, 1261, 1809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 1607, 1623);

                    Syntax = syntax;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 1641, 1656);

                    Body = bodyOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 1674, 1690);

                    Binder = binder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 1708, 1742);

                    SnapshotManager = snapshotManager;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 1760, 1794);

                    RemappedSymbols = remappedSymbols;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10926, 1261, 1809);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 1261, 1809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 1261, 1809);
                }
            }
            static InitialState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10926, 867, 1820);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10926, 867, 1820);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 867, 1820);
            }
        }

        private MethodBodySemanticModel(
                    MethodSymbol owner,
                    Binder rootBinder,
                    CSharpSyntaxNode syntax,
                    SyntaxTreeSemanticModel containingSemanticModelOpt = null,
                    SyntaxTreeSemanticModel parentSemanticModelOpt = null,
                    NullableWalker.SnapshotManager snapshotManagerOpt = null,
                    ImmutableDictionary<Symbol, Symbol> parentRemappedSymbolsOpt = null,
                    int speculatedPosition = 0)
        : base(f_10926_2341_2347_C(syntax), owner, rootBinder, containingSemanticModelOpt, parentSemanticModelOpt, snapshotManagerOpt, parentRemappedSymbolsOpt, speculatedPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10926, 1851, 2911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 2510, 2546);

                f_10926_2510_2545((object)owner != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 2560, 2606);

                f_10926_2560_2605(f_10926_2573_2583(owner) == SymbolKind.Method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 2620, 2649);

                f_10926_2620_2648(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 2663, 2740);

                f_10926_2663_2739(parentRemappedSymbolsOpt is null || (DynAbs.Tracing.TraceSender.Expression_False(10926, 2676, 2738) || f_10926_2712_2738()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 2754, 2900);

                f_10926_2754_2899((f_10926_2768_2781(syntax) == SyntaxKind.CompilationUnit) == (f_10926_2817_2844_M(!IsSpeculativeSemanticModel) && (DynAbs.Tracing.TraceSender.Expression_True(10926, 2817, 2897) && owner is SynthesizedSimpleProgramEntryPointSymbol)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10926, 1851, 2911);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 1851, 2911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 1851, 2911);
            }
        }

        internal static MethodBodySemanticModel Create(SyntaxTreeSemanticModel containingSemanticModel, MethodSymbol owner, InitialState initialState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10926, 3023, 3648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 3190, 3236);

                f_10926_3190_3235(containingSemanticModel != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 3250, 3365);

                var
                result = f_10926_3263_3364(owner, initialState.Binder, initialState.Syntax, containingSemanticModel)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 3381, 3607) || true) && (initialState.Body != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 3381, 3607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 3444, 3592);

                    f_10926_3444_3591(result, initialState.Syntax, initialState.Body, initialState.SnapshotManager, initialState.RemappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 3381, 3607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 3623, 3637);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10926, 3023, 3648);

                int
                f_10926_3190_3235(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 3190, 3235);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10926_3263_3364(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder?
                rootBinder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                containingSemanticModelOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel(owner, (Microsoft.CodeAnalysis.CSharp.Binder?)rootBinder, syntax, containingSemanticModelOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 3263, 3364);
                    return return_v;
                }


                int
                f_10926_3444_3591(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundNode
                bound, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager?
                manager, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                remappedSymbols)
                {
                    this_param.UnguardedAddBoundTreeForStandaloneSyntax((Microsoft.CodeAnalysis.SyntaxNode)syntax, bound, manager, remappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 3444, 3591);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 3023, 3648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 3023, 3648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundNode Bind(Binder binder, CSharpSyntaxNode node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 3660, 5230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 3782, 5159);

                switch (f_10926_3790_3801(node))
                {

                    case SyntaxKind.ArrowExpressionClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 3782, 5159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 3895, 3983);

                        return f_10926_3902_3982(binder, node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 3782, 5159);

                    case SyntaxKind.BaseConstructorInitializer:
                    case SyntaxKind.ThisConstructorInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 3782, 5159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 4129, 4219);

                        return f_10926_4136_4218(binder, node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 3782, 5159);

                    case SyntaxKind.PrimaryConstructorBaseType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 3782, 5159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 4304, 4398);

                        return f_10926_4311_4397(binder, node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 3782, 5159);

                    case SyntaxKind.MethodDeclaration:
                    case SyntaxKind.ConversionOperatorDeclaration:
                    case SyntaxKind.OperatorDeclaration:
                    case SyntaxKind.ConstructorDeclaration:
                    case SyntaxKind.DestructorDeclaration:
                    case SyntaxKind.GetAccessorDeclaration:
                    case SyntaxKind.SetAccessorDeclaration:
                    case SyntaxKind.InitAccessorDeclaration:
                    case SyntaxKind.AddAccessorDeclaration:
                    case SyntaxKind.RemoveAccessorDeclaration:
                    case SyntaxKind.CompilationUnit:
                    case SyntaxKind.RecordDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 3782, 5159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 5096, 5144);

                        return f_10926_5103_5143(binder, node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 3782, 5159);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 5175, 5219);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Bind(binder, node, diagnostics), 10926, 5182, 5218);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 3660, 5230);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10926_3790_3801(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 3790, 3801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10926_3902_3982(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                expressionBody, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindExpressionBodyAsBlock((Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax)expressionBody, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 3902, 3982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10926_4136_4218(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                initializer, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindConstructorInitializer((Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax)initializer, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 4136, 4218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10926_4311_4397(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                initializer, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindConstructorInitializer((Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax)initializer, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 4311, 4397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10926_5103_5143(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindMethodBody(syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 5103, 5143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 3660, 5230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 3660, 5230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MethodBodySemanticModel CreateSpeculative(
                    SyntaxTreeSemanticModel parentSemanticModel,
                    MethodSymbol owner,
                    StatementSyntax syntax,
                    Binder rootBinder,
                    NullableWalker.SnapshotManager snapshotManagerOpt,
                    ImmutableDictionary<Symbol, Symbol> parentRemappedSymbolsOpt,
                    int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10926, 5405, 6263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 5814, 5856);

                f_10926_5814_5855(parentSemanticModel != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 5870, 5899);

                f_10926_5870_5898(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 5913, 5946);

                f_10926_5913_5945(rootBinder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 5960, 6007);

                f_10926_5960_6006(f_10926_5973_6005(rootBinder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 6023, 6252);

                return f_10926_6030_6251(owner, rootBinder, syntax, parentSemanticModelOpt: parentSemanticModel, snapshotManagerOpt: snapshotManagerOpt, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt, speculatedPosition: position);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10926, 5405, 6263);

                int
                f_10926_5814_5855(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 5814, 5855);
                    return 0;
                }


                int
                f_10926_5870_5898(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 5870, 5898);
                    return 0;
                }


                int
                f_10926_5913_5945(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 5913, 5945);
                    return 0;
                }


                bool
                f_10926_5973_6005(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsSemanticModelBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 5973, 6005);
                    return return_v;
                }


                int
                f_10926_5960_6006(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 5960, 6006);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10926_6030_6251(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModelOpt, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                snapshotManagerOpt, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                parentRemappedSymbolsOpt, int
                speculatedPosition)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel(owner, rootBinder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, parentSemanticModelOpt: parentSemanticModelOpt, snapshotManagerOpt: snapshotManagerOpt, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt, speculatedPosition: speculatedPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 6030, 6251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 5405, 6263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 5405, 6263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MethodBodySemanticModel CreateSpeculative(SyntaxTreeSemanticModel parentSemanticModel, MethodSymbol owner, ArrowExpressionClauseSyntax syntax, Binder rootBinder, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10926, 6443, 7016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 6659, 6701);

                f_10926_6659_6700(parentSemanticModel != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 6715, 6744);

                f_10926_6715_6743(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 6758, 6791);

                f_10926_6758_6790(rootBinder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 6805, 6852);

                f_10926_6805_6851(f_10926_6818_6850(rootBinder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 6868, 7005);

                return f_10926_6875_7004(owner, rootBinder, syntax, parentSemanticModelOpt: parentSemanticModel, speculatedPosition: position);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10926, 6443, 7016);

                int
                f_10926_6659_6700(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 6659, 6700);
                    return 0;
                }


                int
                f_10926_6715_6743(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 6715, 6743);
                    return 0;
                }


                int
                f_10926_6758_6790(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 6758, 6790);
                    return 0;
                }


                bool
                f_10926_6818_6850(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsSemanticModelBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 6818, 6850);
                    return return_v;
                }


                int
                f_10926_6805_6851(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 6805, 6851);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10926_6875_7004(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModelOpt, int
                speculatedPosition)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel(owner, rootBinder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, parentSemanticModelOpt: parentSemanticModelOpt, speculatedPosition: speculatedPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 6875, 7004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 6443, 7016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 6443, 7016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MethodBodySemanticModel CreateSpeculative(SyntaxTreeSemanticModel parentSemanticModel, MethodSymbol owner, ConstructorInitializerSyntax syntax, Binder rootBinder, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10926, 7203, 7777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 7420, 7462);

                f_10926_7420_7461(parentSemanticModel != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 7476, 7505);

                f_10926_7476_7504(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 7519, 7552);

                f_10926_7519_7551(rootBinder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 7566, 7613);

                f_10926_7566_7612(f_10926_7579_7611(rootBinder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 7629, 7766);

                return f_10926_7636_7765(owner, rootBinder, syntax, parentSemanticModelOpt: parentSemanticModel, speculatedPosition: position);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10926, 7203, 7777);

                int
                f_10926_7420_7461(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 7420, 7461);
                    return 0;
                }


                int
                f_10926_7476_7504(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 7476, 7504);
                    return 0;
                }


                int
                f_10926_7519_7551(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 7519, 7551);
                    return 0;
                }


                bool
                f_10926_7579_7611(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsSemanticModelBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 7579, 7611);
                    return return_v;
                }


                int
                f_10926_7566_7612(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 7566, 7612);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10926_7636_7765(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModelOpt, int
                speculatedPosition)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel(owner, rootBinder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, parentSemanticModelOpt: parentSemanticModelOpt, speculatedPosition: speculatedPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 7636, 7765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 7203, 7777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 7203, 7777);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MethodBodySemanticModel CreateSpeculative(SyntaxTreeSemanticModel parentSemanticModel, MethodSymbol owner, PrimaryConstructorBaseTypeSyntax syntax, Binder rootBinder, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10926, 7964, 8542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 8185, 8227);

                f_10926_8185_8226(parentSemanticModel != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 8241, 8270);

                f_10926_8241_8269(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 8284, 8317);

                f_10926_8284_8316(rootBinder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 8331, 8378);

                f_10926_8331_8377(f_10926_8344_8376(rootBinder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 8394, 8531);

                return f_10926_8401_8530(owner, rootBinder, syntax, parentSemanticModelOpt: parentSemanticModel, speculatedPosition: position);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10926, 7964, 8542);

                int
                f_10926_8185_8226(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 8185, 8226);
                    return 0;
                }


                int
                f_10926_8241_8269(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 8241, 8269);
                    return 0;
                }


                int
                f_10926_8284_8316(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 8284, 8316);
                    return 0;
                }


                bool
                f_10926_8344_8376(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsSemanticModelBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 8344, 8376);
                    return return_v;
                }


                int
                f_10926_8331_8377(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 8331, 8377);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10926_8401_8530(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModelOpt, int
                speculatedPosition)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel(owner, rootBinder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, parentSemanticModelOpt: parentSemanticModelOpt, speculatedPosition: speculatedPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 8401, 8530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 7964, 8542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 7964, 8542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetSpeculativeSemanticModelForMethodBodyCore(SyntaxTreeSemanticModel parentModel, int position, BaseMethodDeclarationSyntax method, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 8554, 9010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 8893, 8999);

                return f_10926_8900_8998(this, parentModel, position, f_10926_8964_8975(method), out speculativeModel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 8554, 9010);

                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10926_8964_8975(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 8964, 8975);
                    return return_v;
                }


                bool
                f_10926_8900_8998(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                body, out Microsoft.CodeAnalysis.SemanticModel
                speculativeModel)
                {
                    var return_v = this_param.GetSpeculativeSemanticModelForMethodBody(parentModel, position, body, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 8900, 8998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 8554, 9010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 8554, 9010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool GetSpeculativeSemanticModelForMethodBody(SyntaxTreeSemanticModel parentModel, int position, BlockSyntax body, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 9022, 10489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 9205, 9249);

                position = f_10926_9216_9248(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 9265, 9316);

                var
                methodSymbol = (MethodSymbol)f_10926_9298_9315(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 9391, 9423);

                Binder
                binder = this.RootBinder
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 9439, 9711);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 9474, 9618) || true) && (binder is ExecutableCodeBinder)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 9474, 9618);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 9550, 9571);

                                binder = f_10926_9559_9570(binder);
                                DynAbs.Tracing.TraceSender.TraceBreak(10926, 9593, 9599);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 9474, 9618);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 9638, 9659);

                            binder = f_10926_9647_9658(binder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 9439, 9711);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 9439, 9711) || true) && (binder != null)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10926, 9439, 9711);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10926, 9439, 9711);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 9727, 9756);

                f_10926_9727_9755(binder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 9772, 9877);

                Binder
                executablebinder = f_10926_9798_9876(f_10926_9828_9838(), position, binder ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Binder>(10926, 9850, 9875) ?? this.RootBinder))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 9891, 9973);

                executablebinder = f_10926_9910_9972(body, methodSymbol, executablebinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 9987, 10089);

                var
                blockBinder = f_10926_10005_10088(f_10926_10005_10037(executablebinder, body), f_10926_10058_10087(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 10301, 10452);

                speculativeModel = f_10926_10320_10451(parentModel, methodSymbol, body, blockBinder, snapshotManagerOpt: null, parentRemappedSymbolsOpt: null, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 10466, 10478);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 9022, 10489);

                int
                f_10926_9216_9248(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 9216, 9248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10926_9298_9315(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 9298, 9315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10926_9559_9570(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 9559, 9570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10926_9647_9658(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 9647, 9658);
                    return return_v;
                }


                int
                f_10926_9727_9755(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 9727, 9755);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10926_9828_9838()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 9828, 9838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.WithNullableContextBinder
                f_10926_9798_9876(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, int
                position, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.WithNullableContextBinder(syntaxTree, position, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 9798, 9876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10926_9910_9972(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                root, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 9910, 9972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10926_10005_10037(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 10005, 10037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFlags
                f_10926_10058_10087(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param)
                {
                    var return_v = this_param.GetSemanticModelBinderFlags();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 10058, 10087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10926_10005_10088(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 10005, 10088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10926_10320_10451(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModel, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                snapshotManagerOpt, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                parentRemappedSymbolsOpt, int
                position)
                {
                    var return_v = CreateSpeculative(parentSemanticModel, owner, (Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax)syntax, rootBinder, snapshotManagerOpt: snapshotManagerOpt, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 10320, 10451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 9022, 10489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 9022, 10489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetSpeculativeSemanticModelForMethodBodyCore(SyntaxTreeSemanticModel parentModel, int position, AccessorDeclarationSyntax accessor, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 10501, 10838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 10719, 10827);

                return f_10926_10726_10826(this, parentModel, position, f_10926_10790_10803(accessor), out speculativeModel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 10501, 10838);

                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10926_10790_10803(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 10790, 10803);
                    return return_v;
                }


                bool
                f_10926_10726_10826(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                body, out Microsoft.CodeAnalysis.SemanticModel
                speculativeModel)
                {
                    var return_v = this_param.GetSpeculativeSemanticModelForMethodBody(parentModel, position, body, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 10726, 10826);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 10501, 10838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 10501, 10838);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, StatementSyntax statement, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 10850, 11708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11046, 11090);

                position = f_10926_11057_11089(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11106, 11153);

                var
                binder = f_10926_11119_11152(this, position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11167, 11289) || true) && (binder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 11167, 11289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11219, 11243);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11261, 11274);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 11167, 11289);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11305, 11356);

                var
                methodSymbol = (MethodSymbol)f_10926_11338_11355(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11370, 11439);

                binder = f_10926_11379_11438(f_10926_11409_11419(), position, binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11453, 11520);

                binder = f_10926_11462_11519(statement, methodSymbol, binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11534, 11671);

                speculativeModel = f_10926_11553_11670(parentModel, methodSymbol, statement, binder, f_10926_11617_11637(this), f_10926_11639_11659(this), position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11685, 11697);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 10850, 11708);

                int
                f_10926_11057_11089(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 11057, 11089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10926_11119_11152(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 11119, 11152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10926_11338_11355(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 11338, 11355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10926_11409_11419()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 11409, 11419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.WithNullableContextBinder
                f_10926_11379_11438(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, int
                position, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.WithNullableContextBinder(syntaxTree, position, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 11379, 11438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10926_11462_11519(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                root, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 11462, 11519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                f_10926_11617_11637(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param)
                {
                    var return_v = this_param.GetSnapshotManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 11617, 11637);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10926_11639_11659(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param)
                {
                    var return_v = this_param.GetRemappedSymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 11639, 11659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10926_11553_11670(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModel, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                snapshotManagerOpt, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                parentRemappedSymbolsOpt, int
                position)
                {
                    var return_v = CreateSpeculative(parentSemanticModel, owner, syntax, rootBinder, snapshotManagerOpt, parentRemappedSymbolsOpt, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 11553, 11670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 10850, 11708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 10850, 11708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, ArrowExpressionClauseSyntax expressionBody, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 11720, 12563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11933, 11977);

                position = f_10926_11944_11976(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 11993, 12040);

                var
                binder = f_10926_12006_12039(this, position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 12054, 12176) || true) && (binder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 12054, 12176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 12106, 12130);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 12148, 12161);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 12054, 12176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 12192, 12243);

                var
                methodSymbol = (MethodSymbol)f_10926_12225_12242(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 12257, 12326);

                binder = f_10926_12266_12325(f_10926_12296_12306(), position, binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 12340, 12412);

                binder = f_10926_12349_12411(expressionBody, methodSymbol, binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 12428, 12526);

                speculativeModel = f_10926_12447_12525(parentModel, methodSymbol, expressionBody, binder, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 12540, 12552);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 11720, 12563);

                int
                f_10926_11944_11976(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 11944, 11976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10926_12006_12039(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 12006, 12039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10926_12225_12242(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 12225, 12242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10926_12296_12306()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 12296, 12306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.WithNullableContextBinder
                f_10926_12266_12325(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, int
                position, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.WithNullableContextBinder(syntaxTree, position, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 12266, 12325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10926_12349_12411(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                root, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 12349, 12411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10926_12447_12525(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModel, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, int
                position)
                {
                    var return_v = CreateSpeculative(parentSemanticModel, owner, syntax, rootBinder, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 12447, 12525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 11720, 12563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 11720, 12563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, ConstructorInitializerSyntax constructorInitializer, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 12575, 13953);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 12820, 13875) || true) && (f_10926_12824_12836() is MethodSymbol methodSymbol && (DynAbs.Tracing.TraceSender.Expression_True(10926, 12824, 12918) && f_10926_12869_12892(methodSymbol) == MethodKind.Constructor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 12820, 13875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 12952, 12995);

                    var
                    temp = f_10926_12963_12987(f_10926_12963_12967(), position).Parent
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 13013, 13860) || true) && (temp is not null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 13013, 13860);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 13075, 13167);

                        var
                        temp2 = f_10926_13087_13166(f_10926_13087_13149(f_10926_13087_13110(temp)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 13189, 13841) || true) && (temp2 is not null && (DynAbs.Tracing.TraceSender.Expression_True(10926, 13193, 13234) && f_10926_13214_13226(temp2) == f_10926_13230_13234()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 13189, 13841);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 13285, 13332);

                            var
                            binder = f_10926_13298_13331(this, position)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 13358, 13818) || true) && (binder != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 13358, 13818);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 13434, 13503);

                                binder = f_10926_13443_13502(f_10926_13473_13483(), position, binder);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 13533, 13613);

                                binder = f_10926_13542_13612(constructorInitializer, methodSymbol, binder);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 13643, 13749);

                                speculativeModel = f_10926_13662_13748(parentModel, methodSymbol, constructorInitializer, binder, position);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 13779, 13791);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 13358, 13818);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 13189, 13841);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 13013, 13860);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 12820, 13875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 13891, 13915);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 13929, 13942);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 12575, 13953);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10926_12824_12836()
                {
                    var return_v = MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 12824, 12836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10926_12869_12892(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 12869, 12892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10926_12963_12967()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 12963, 12967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10926_12963_12987(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindToken(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 12963, 12987);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10926_13087_13110(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.AncestorsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 13087, 13110);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax>
                f_10926_13087_13149(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 13087, 13149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                f_10926_13087_13166(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax>
                source)
                {
                    var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 13087, 13166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10926_13214_13226(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 13214, 13226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10926_13230_13234()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 13230, 13234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10926_13298_13331(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 13298, 13331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10926_13473_13483()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 13473, 13483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.WithNullableContextBinder
                f_10926_13443_13502(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, int
                position, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.WithNullableContextBinder(syntaxTree, position, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 13443, 13502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10926_13542_13612(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                root, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 13542, 13612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10926_13662_13748(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModel, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, int
                position)
                {
                    var return_v = CreateSpeculative(parentSemanticModel, owner, syntax, rootBinder, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 13662, 13748);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 12575, 13953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 12575, 13953);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, PrimaryConstructorBaseTypeSyntax constructorInitializer, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 13965, 15222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 14214, 14270);

                var
                temp = f_10926_14225_14237() as SynthesizedRecordConstructor
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 14284, 15144) || true) && (temp is not null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 14284, 15144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 14338, 14382);

                    var
                    temp2 = f_10926_14350_14374(f_10926_14350_14354(), position).Parent
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 14400, 15129) || true) && (temp2 is not null && (DynAbs.Tracing.TraceSender.Expression_True(10926, 14404, 14578) && f_10926_14447_14531(f_10926_14447_14514(f_10926_14447_14471(temp2))) == f_10926_14535_14578(f_10926_14535_14551(temp))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 14400, 15129);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 14621, 14668);

                        var
                        binder = f_10926_14634_14667(this, position)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 14690, 15110) || true) && (binder != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10926, 14690, 15110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 14758, 14827);

                            binder = f_10926_14767_14826(f_10926_14797_14807(), position, binder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 14853, 14925);

                            binder = f_10926_14862_14924(constructorInitializer, temp, binder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 14951, 15049);

                            speculativeModel = f_10926_14970_15048(parentModel, temp, constructorInitializer, binder, position);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 15075, 15087);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 14690, 15110);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 14400, 15129);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10926, 14284, 15144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 15160, 15184);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 15198, 15211);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 13965, 15222);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10926_14225_14237()
                {
                    var return_v = MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 14225, 14237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10926_14350_14354()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 14350, 14354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10926_14350_14374(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindToken(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 14350, 14374);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10926_14447_14471(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.AncestorsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 14447, 14471);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax>
                f_10926_14447_14514(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 14447, 14514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                f_10926_14447_14531(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax>
                source)
                {
                    var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 14447, 14531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                f_10926_14535_14551(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 14535, 14551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax?
                f_10926_14535_14578(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.PrimaryConstructorBaseType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 14535, 14578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10926_14634_14667(Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 14634, 14667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10926_14797_14807()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 14797, 14807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.WithNullableContextBinder
                f_10926_14767_14826(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, int
                position, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.WithNullableContextBinder(syntaxTree, position, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 14767, 14826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10926_14862_14924(Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                root, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 14862, 14924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10926_14970_15048(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModel, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, int
                position)
                {
                    var return_v = CreateSpeculative(parentSemanticModel, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)owner, syntax, rootBinder, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 14970, 15048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 13965, 15222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 13965, 15222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, EqualsValueClauseSyntax initializer, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 15234, 15502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 15440, 15464);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 15478, 15491);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 15234, 15502);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 15234, 15502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 15234, 15502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BoundNode RewriteNullableBoundNodesWithSnapshots(
                    BoundNode boundRoot,
                    Binder binder,
                    DiagnosticBag diagnostics,
                    bool createSnapshots,
                    out NullableWalker.SnapshotManager snapshotManager,
                    ref ImmutableDictionary<Symbol, Symbol> remappedSymbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 15514, 16183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 15879, 15976);

                var
                afterInitializersState = f_10926_15908_15975(f_10926_15949_15960(), f_10926_15962_15974())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 15990, 16172);

                return f_10926_15997_16171(f_10926_16030_16041(), f_10926_16043_16055(), boundRoot, binder, afterInitializersState, diagnostics, createSnapshots, out snapshotManager, ref remappedSymbols);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 15514, 16183);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10926_15949_15960()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 15949, 15960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10926_15962_15974()
                {
                    var return_v = MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 15962, 15974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
                f_10926_15908_15975(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = NullableWalker.GetAfterInitializersState(compilation, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 15908, 15975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10926_16030_16041()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 16030, 16041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10926_16043_16055()
                {
                    var return_v = MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 16043, 16055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10926_15997_16171(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
                initialState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                createSnapshots, out Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                snapshotManager, ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                remappedSymbols)
                {
                    var return_v = NullableWalker.AnalyzeAndRewrite(compilation, symbol, node, binder, initialState, diagnostics, createSnapshots, out snapshotManager, ref remappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 15997, 16171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 15514, 16183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 15514, 16183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void AnalyzeBoundNodeNullability(BoundNode boundRoot, Binder binder, DiagnosticBag diagnostics, bool createSnapshots)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 16195, 16480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 16356, 16469);

                f_10926_16356_16468(f_10926_16393_16404(), f_10926_16406_16418(), boundRoot, binder, diagnostics, createSnapshots);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 16195, 16480);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10926_16393_16404()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 16393, 16404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10926_16406_16418()
                {
                    var return_v = MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 16406, 16418);
                    return return_v;
                }


                int
                f_10926_16356_16468(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                createSnapshots)
                {
                    NullableWalker.AnalyzeWithoutRewrite(compilation, symbol, node, binder, diagnostics, createSnapshots);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 16356, 16468);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 16195, 16480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 16195, 16480);
            }
        }

        protected override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10926, 16492, 16654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10926, 16568, 16643);

                return f_10926_16575_16642(f_10926_16575_16586(), f_10926_16629_16641());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10926, 16492, 16654);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10926_16575_16586()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 16575, 16586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10926_16629_16641()
                {
                    var return_v = MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 16629, 16641);
                    return return_v;
                }


                bool
                f_10926_16575_16642(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                method)
                {
                    var return_v = this_param.IsNullableAnalysisEnabledIn((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 16575, 16642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10926, 16492, 16654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 16492, 16654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodBodySemanticModel()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10926, 454, 16661);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10926, 454, 16661);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10926, 454, 16661);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10926, 454, 16661);

        int
        f_10926_2510_2545(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 2510, 2545);
            return 0;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10926_2573_2583(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 2573, 2583);
            return return_v;
        }


        int
        f_10926_2560_2605(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 2560, 2605);
            return 0;
        }


        int
        f_10926_2620_2648(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 2620, 2648);
            return 0;
        }


        bool
        f_10926_2712_2738()
        {
            var return_v = IsSpeculativeSemanticModel;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 2712, 2738);
            return return_v;
        }


        int
        f_10926_2663_2739(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 2663, 2739);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10926_2768_2781(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.Kind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 2768, 2781);
            return return_v;
        }


        bool
        f_10926_2817_2844_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10926, 2817, 2844);
            return return_v;
        }


        int
        f_10926_2754_2899(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10926, 2754, 2899);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        f_10926_2341_2347_C(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10926, 1851, 2911);
            return return_v;
        }

    }
}
