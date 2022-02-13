// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class AsyncExceptionHandlerRewriter : BoundTreeRewriterWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
    {
        private readonly SyntheticBoundNodeFactory _F;

        private readonly DiagnosticBag _diagnostics;

        private readonly AwaitInFinallyAnalysis _analysis;

        private AwaitCatchFrame _currentAwaitCatchFrame;

        private AwaitFinallyFrame _currentAwaitFinallyFrame;

        private AsyncExceptionHandlerRewriter(
                    MethodSymbol containingMethod,
                    NamedTypeSymbol containingType,
                    SyntheticBoundNodeFactory factory,
                    DiagnosticBag diagnostics,
                    AwaitInFinallyAnalysis analysis)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10443, 1311, 1906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 1034, 1036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 1078, 1090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 1141, 1150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 1187, 1210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 1247, 1298);
                this._currentAwaitFinallyFrame = f_10443_1275_1298(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 1597, 1610);

                _F = factory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 1624, 1662);

                _F.CurrentFunction = containingMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 1676, 1819);

                f_10443_1676_1818(f_10443_1689_1817(f_10443_1707_1726(factory), (containingType ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(10443, 1729, 1778) ?? f_10443_1747_1778(containingMethod))), TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 1833, 1860);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 1874, 1895);

                _analysis = analysis;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10443, 1311, 1906);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 1311, 1906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 1311, 1906);
            }
        }

        public static BoundStatement Rewrite(
                    MethodSymbol containingSymbol,
                    NamedTypeSymbol containingType,
                    BoundStatement statement,
                    TypeCompilationState compilationState,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10443, 4301, 5402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 4583, 4622);

                f_10443_4583_4621(containingSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 4636, 4681);

                f_10443_4636_4680((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 4695, 4727);

                f_10443_4695_4726(statement != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 4741, 4780);

                f_10443_4741_4779(compilationState != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 4794, 4828);

                f_10443_4794_4827(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 4844, 4897);

                var
                analysis = f_10443_4859_4896(statement)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 4911, 5016) || true) && (!f_10443_4916_4950(analysis))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 4911, 5016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 4984, 5001);

                    return statement;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 4911, 5016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 5032, 5143);

                var
                factory = f_10443_5046_5142(containingSymbol, statement.Syntax, compilationState, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 5157, 5272);

                var
                rewriter = f_10443_5172_5271(containingSymbol, containingType, factory, diagnostics, analysis)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 5286, 5351);

                var
                loweredStatement = (BoundStatement)f_10443_5325_5350(rewriter, statement)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 5367, 5391);

                return loweredStatement;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10443, 4301, 5402);

                int
                f_10443_4583_4621(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 4583, 4621);
                    return 0;
                }


                int
                f_10443_4636_4680(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 4636, 4680);
                    return 0;
                }


                int
                f_10443_4695_4726(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 4695, 4726);
                    return 0;
                }


                int
                f_10443_4741_4779(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 4741, 4779);
                    return 0;
                }


                int
                f_10443_4794_4827(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 4794, 4827);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitInFinallyAnalysis
                f_10443_4859_4896(Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitInFinallyAnalysis(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 4859, 4896);
                    return return_v;
                }


                bool
                f_10443_4916_4950(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitInFinallyAnalysis
                this_param)
                {
                    var return_v = this_param.ContainsAwaitInHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 4916, 4950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10443_5046_5142(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory(topLevelMethod, node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 5046, 5142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                f_10443_5172_5271(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingMethod, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitInFinallyAnalysis
                analysis)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter(containingMethod, containingType, factory, diagnostics, analysis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 5172, 5271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_5325_5350(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 5325, 5350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 4301, 5402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 4301, 5402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTryStatement(BoundTryStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 5414, 10485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 5506, 5543);

                var
                tryStatementSyntax = node.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 5715, 6185);

                f_10443_5715_6184(f_10443_5746_5796(tryStatementSyntax, SyntaxKind.TryStatement) || (DynAbs.Tracing.TraceSender.Expression_False(10443, 5746, 5869) || f_10443_5817_5869(tryStatementSyntax, SyntaxKind.UsingStatement)) || (DynAbs.Tracing.TraceSender.Expression_False(10443, 5746, 5944) || f_10443_5890_5944(tryStatementSyntax, SyntaxKind.ForEachStatement)) || (DynAbs.Tracing.TraceSender.Expression_False(10443, 5746, 6027) || f_10443_5965_6027(tryStatementSyntax, SyntaxKind.ForEachVariableStatement)) || (DynAbs.Tracing.TraceSender.Expression_False(10443, 5746, 6111) || f_10443_6048_6111(tryStatementSyntax, SyntaxKind.LocalDeclarationStatement)) || (DynAbs.Tracing.TraceSender.Expression_False(10443, 5746, 6183) || f_10443_6132_6183(tryStatementSyntax, SyntaxKind.LockStatement)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6201, 6232);

                BoundStatement
                finalizedRegion
                = default(BoundStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6246, 6274);

                BoundBlock
                rewrittenFinally
                = default(BoundBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6290, 6356);

                var
                finallyContainsAwaits = f_10443_6318_6355(_analysis, node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6370, 7402) || true) && (!finallyContainsAwaits)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 6370, 7402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6430, 6477);

                    finalizedRegion = f_10443_6448_6476(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6495, 6559);

                    rewrittenFinally = (BoundBlock)f_10443_6526_6558(this, f_10443_6537_6557(node));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6579, 6691) || true) && (rewrittenFinally == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 6579, 6691);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6649, 6672);

                        return finalizedRegion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 6579, 6691);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6711, 6760);

                    var
                    asTry = finalizedRegion as BoundTryStatement
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6778, 7387) || true) && (asTry != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 6778, 7387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6926, 6970);

                        f_10443_6926_6969(f_10443_6939_6960(asTry) == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 6992, 7114);

                        return f_10443_6999_7113(asTry, f_10443_7012_7026(asTry), f_10443_7028_7045(asTry), rewrittenFinally, f_10443_7065_7086(asTry), f_10443_7088_7112(asTry));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 6778, 7387);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 6778, 7387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 7268, 7368);

                        return f_10443_7275_7367(_F, finalizedRegion, ImmutableArray<BoundCatchBlock>.Empty, rewrittenFinally);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 6778, 7387);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 6370, 7402);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 7498, 7526);

                var
                frame = f_10443_7510_7525(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 7540, 7587);

                finalizedRegion = f_10443_7558_7586(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 7601, 7670);

                rewrittenFinally = (BoundBlock)f_10443_7632_7669(this, f_10443_7648_7668(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 7684, 7695);

                f_10443_7684_7694(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 7711, 7773);

                var
                exceptionType = f_10443_7731_7772(_F, SpecialType.System_Object)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 7787, 7966);

                var
                pendingExceptionLocal = f_10443_7815_7965(f_10443_7836_7854(_F), TypeWithAnnotations.Create(exceptionType), SynthesizedLocalKind.TryAwaitPendingException, tryStatementSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 7980, 8032);

                var
                finallyLabel = f_10443_7999_8031(_F, "finallyLabel")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 8046, 8244);

                var
                pendingBranchVar = f_10443_8069_8243(f_10443_8090_8108(_F), TypeWithAnnotations.Create(f_10443_8137_8177(_F, SpecialType.System_Int32)), SynthesizedLocalKind.TryAwaitPendingBranch, tryStatementSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 8260, 8329);

                var
                catchAll = f_10443_8275_8328(_F, f_10443_8284_8315(_F, pendingExceptionLocal), f_10443_8317_8327(_F))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 8345, 8707);

                var
                catchAndPendException = f_10443_8373_8706(_F, f_10443_8398_8610(_F, finalizedRegion, f_10443_8467_8491(_F), f_10443_8514_8535(_F, finallyLabel), f_10443_8558_8609(this, frame, pendingBranchVar, finallyLabel)), f_10443_8629_8660(catchAll), finallyLabel: finallyLabel)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 8723, 9132);

                BoundBlock
                syntheticFinallyBlock = f_10443_8758_9131(_F, f_10443_8785_8809(_F), f_10443_8828_8850(_F, finallyLabel), rewrittenFinally, f_10443_8904_8928(_F), f_10443_8947_8985(this, pendingExceptionLocal), f_10443_9004_9130(this, frame, pendingBranchVar, pendingExceptionLocal))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 9148, 9204);

                BoundStatement
                syntheticFinally = syntheticFinallyBlock
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 9218, 9511) || true) && (f_10443_9222_9248(f_10443_9222_9240(_F)) && (DynAbs.Tracing.TraceSender.Expression_True(10443, 9222, 9281) && f_10443_9252_9281(f_10443_9252_9270(_F))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 9218, 9511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 9429, 9496);

                    syntheticFinally = f_10443_9448_9495(_F, syntheticFinallyBlock);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 9218, 9511);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 9527, 9580);

                var
                locals = f_10443_9540_9579()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 9594, 9654);

                var
                statements = f_10443_9611_9653()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 9670, 9711);

                f_10443_9670_9710(
                            statements, f_10443_9685_9709(_F));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 9727, 9761);

                f_10443_9727_9760(
                            locals, pendingExceptionLocal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 9775, 9878);

                f_10443_9775_9877(statements, f_10443_9790_9876(_F, f_10443_9804_9835(_F, pendingExceptionLocal), f_10443_9837_9875(_F, f_10443_9848_9874(pendingExceptionLocal))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 9892, 9921);

                f_10443_9892_9920(locals, pendingBranchVar);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 9935, 10028);

                f_10443_9935_10027(statements, f_10443_9950_10026(_F, f_10443_9964_9990(_F, pendingBranchVar), f_10443_9992_10025(_F, f_10443_10003_10024(pendingBranchVar))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10044, 10088);

                LocalSymbol
                returnLocal = frame.returnValue
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10102, 10198) || true) && (returnLocal != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 10102, 10198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10159, 10183);

                    f_10443_10159_10182(locals, returnLocal);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 10102, 10198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10214, 10252);

                f_10443_10214_10251(
                            statements, catchAndPendException);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10266, 10299);

                f_10443_10266_10298(statements, syntheticFinally);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10315, 10439);

                var
                completeTry = f_10443_10333_10438(_F, f_10443_10360_10387(locals), f_10443_10406_10437(statements))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10455, 10474);

                return completeTry;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 5414, 10485);

                bool
                f_10443_5746_5796(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 5746, 5796);
                    return return_v;
                }


                bool
                f_10443_5817_5869(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 5817, 5869);
                    return return_v;
                }


                bool
                f_10443_5890_5944(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 5890, 5944);
                    return return_v;
                }


                bool
                f_10443_5965_6027(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 5965, 6027);
                    return return_v;
                }


                bool
                f_10443_6048_6111(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 6048, 6111);
                    return return_v;
                }


                bool
                f_10443_6132_6183(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 6132, 6183);
                    return return_v;
                }


                int
                f_10443_5715_6184(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 5715, 6184);
                    return 0;
                }


                bool
                f_10443_6318_6355(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitInFinallyAnalysis
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                statement)
                {
                    var return_v = this_param.FinallyContainsAwaits(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 6318, 6355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_6448_6476(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                node)
                {
                    var return_v = this_param.RewriteFinalizedRegion(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 6448, 6476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10443_6537_6557(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 6537, 6557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_6526_6558(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 6526, 6558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10443_6939_6960(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 6939, 6960);
                    return return_v;
                }


                int
                f_10443_6926_6969(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 6926, 6969);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_7012_7026(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.TryBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 7012, 7026);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10443_7028_7045(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.CatchBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 7028, 7045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                f_10443_7065_7086(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyLabelOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 7065, 7086);
                    return return_v;
                }


                bool
                f_10443_7088_7112(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.PreferFaultHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 7088, 7112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                f_10443_6999_7113(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                catchBlocks, Microsoft.CodeAnalysis.CSharp.BoundBlock
                finallyBlockOpt, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                finallyLabelOpt, bool
                preferFaultHandler)
                {
                    var return_v = this_param.Update(tryBlock, catchBlocks, finallyBlockOpt, finallyLabelOpt, preferFaultHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 6999, 7113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_7275_7367(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                catchBlocks, Microsoft.CodeAnalysis.CSharp.BoundBlock
                finallyBlock)
                {
                    var return_v = this_param.Try((Microsoft.CodeAnalysis.CSharp.BoundBlock)tryBlock, catchBlocks, finallyBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 7275, 7367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                f_10443_7510_7525(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                statement)
                {
                    var return_v = this_param.PushFrame(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 7510, 7525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_7558_7586(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                node)
                {
                    var return_v = this_param.RewriteFinalizedRegion(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 7558, 7586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10443_7648_7668(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 7648, 7668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_7632_7669(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                node)
                {
                    var return_v = this_param.VisitBlock(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 7632, 7669);
                    return return_v;
                }


                int
                f_10443_7684_7694(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param)
                {
                    this_param.PopFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 7684, 7694);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10443_7731_7772(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 7731, 7772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10443_7836_7854(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 7836, 7854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                f_10443_7815_7965(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind, syntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 7815, 7965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10443_7999_8031(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 7999, 8031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10443_8090_8108(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 8090, 8108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10443_8137_8177(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8137, 8177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                f_10443_8069_8243(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind, syntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8069, 8243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_8284_8315(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8284, 8315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_8317_8327(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8317, 8327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10443_8275_8328(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                source, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block)
                {
                    var return_v = this_param.Catch((Microsoft.CodeAnalysis.CSharp.BoundExpression)source, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8275, 8328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_8467_8491(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8467, 8491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10443_8514_8535(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Goto((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8514, 8535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_8558_8609(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                frame, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                pendingBranchVar, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                finallyLabel)
                {
                    var return_v = this_param.PendBranches(frame, (Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)pendingBranchVar, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)finallyLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8558, 8609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_8398_8610(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8398, 8610);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10443_8629_8660(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8629, 8660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_8373_8706(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                catchBlocks, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                finallyLabel)
                {
                    var return_v = this_param.Try(tryBlock, catchBlocks, finallyLabel: (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)finallyLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8373, 8706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_8785_8809(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8785, 8809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10443_8828_8850(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8828, 8850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_8904_8928(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8904, 8928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_8947_8985(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                pendingExceptionLocal)
                {
                    var return_v = this_param.UnpendException((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)pendingExceptionLocal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8947, 8985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_9004_9130(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                frame, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                pendingBranchVar, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                pendingException)
                {
                    var return_v = this_param.UnpendBranches(frame, pendingBranchVar, pendingException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9004, 9130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_8758_9131(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 8758, 9131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10443_9222_9240(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 9222, 9240);
                    return return_v;
                }


                bool
                f_10443_9222_9248(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 9222, 9248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10443_9252_9270(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 9252, 9270);
                    return return_v;
                }


                bool
                f_10443_9252_9281(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsIterator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 9252, 9281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExtractedFinallyBlock
                f_10443_9448_9495(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                finallyBlock)
                {
                    var return_v = this_param.ExtractedFinallyBlock(finallyBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9448, 9495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10443_9540_9579()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9540, 9579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10443_9611_9653()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9611, 9653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_9685_9709(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9685, 9709);
                    return return_v;
                }


                int
                f_10443_9670_9710(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9670, 9710);
                    return 0;
                }


                int
                f_10443_9727_9760(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9727, 9760);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_9804_9835(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9804, 9835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10443_9848_9874(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 9848, 9874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_9837_9875(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Default(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9837, 9875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_9790_9876(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9790, 9876);
                    return return_v;
                }


                int
                f_10443_9775_9877(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9775, 9877);
                    return 0;
                }


                int
                f_10443_9892_9920(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9892, 9920);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_9964_9990(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9964, 9990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10443_10003_10024(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 10003, 10024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_9992_10025(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Default(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9992, 10025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_9950_10026(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9950, 10026);
                    return return_v;
                }


                int
                f_10443_9935_10027(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 9935, 10027);
                    return 0;
                }


                int
                f_10443_10159_10182(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 10159, 10182);
                    return 0;
                }


                int
                f_10443_10214_10251(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 10214, 10251);
                    return 0;
                }


                int
                f_10443_10266_10298(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 10266, 10298);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10443_10360_10387(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 10360, 10387);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10443_10406_10437(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 10406, 10437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_10333_10438(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 10333, 10438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 5414, 10485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 5414, 10485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundBlock PendBranches(
                    AwaitFinallyFrame frame,
                    LocalSymbol pendingBranchVar,
                    LabelSymbol finallyLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 10497, 11660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10674, 10738);

                var
                bodyStatements = f_10443_10695_10737()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10802, 10842);

                var
                proxiedLabels = frame.proxiedLabels
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10856, 10892);

                var
                proxyLabels = frame.proxyLabels
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10971, 10981);

                int
                i = 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 10995, 11362) || true) && (proxiedLabels != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 10995, 11362);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 11063, 11088);
                        for (int
        cnt = f_10443_11069_11088(proxiedLabels)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 11054, 11347) || true) && (i <= cnt)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 11100, 11103)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 11054, 11347))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 11054, 11347);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 11145, 11180);

                            var
                            proxied = f_10443_11159_11179(proxiedLabels, i - 1)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 11202, 11235);

                            var
                            proxy = f_10443_11214_11234(proxyLabels, proxied)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 11259, 11328);

                            f_10443_11259_11327(this, bodyStatements, proxy, i, pendingBranchVar, finallyLabel);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10443, 1, 294);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10443, 1, 294);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 10995, 11362);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 11378, 11419);

                var
                returnProxy = frame.returnProxyLabel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 11433, 11580) || true) && (returnProxy != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 11433, 11580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 11490, 11565);

                    f_10443_11490_11564(this, bodyStatements, returnProxy, i, pendingBranchVar, finallyLabel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 11433, 11580);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 11596, 11649);

                return f_10443_11603_11648(_F, f_10443_11612_11647(bodyStatements));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 10497, 11660);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10443_10695_10737()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 10695, 10737);
                    return return_v;
                }


                int
                f_10443_11069_11088(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 11069, 11088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10443_11159_11179(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 11159, 11179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10443_11214_11234(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 11214, 11234);
                    return return_v;
                }


                int
                f_10443_11259_11327(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                bodyStatements, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                proxy, int
                i, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                pendingBranchVar, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                finallyLabel)
                {
                    this_param.PendBranch(bodyStatements, proxy, i, pendingBranchVar, finallyLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 11259, 11327);
                    return 0;
                }


                int
                f_10443_11490_11564(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                bodyStatements, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                proxy, int
                i, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                pendingBranchVar, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                finallyLabel)
                {
                    this_param.PendBranch(bodyStatements, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)proxy, i, pendingBranchVar, finallyLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 11490, 11564);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10443_11612_11647(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 11612, 11647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_11603_11648(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 11603, 11648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 10497, 11660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 10497, 11660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void PendBranch(
                    ArrayBuilder<BoundStatement> bodyStatements,
                    LabelSymbol proxy,
                    int i,
                    LocalSymbol pendingBranchVar,
                    LabelSymbol finallyLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 11672, 12212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 11947, 11983);

                f_10443_11947_11982(            // branch lands here
                            bodyStatements, f_10443_11966_11981(_F, proxy));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12031, 12108);

                f_10443_12031_12107(
                            // pend the branch
                            bodyStatements, f_10443_12050_12106(_F, f_10443_12064_12090(_F, pendingBranchVar), f_10443_12092_12105(_F, i)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12159, 12201);

                f_10443_12159_12200(
                            // skip other proxies
                            bodyStatements, f_10443_12178_12199(_F, finallyLabel));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 11672, 12212);

                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10443_11966_11981(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Label(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 11966, 11981);
                    return return_v;
                }


                int
                f_10443_11947_11982(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 11947, 11982);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_12064_12090(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 12064, 12090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10443_12092_12105(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 12092, 12105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_12050_12106(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 12050, 12106);
                    return return_v;
                }


                int
                f_10443_12031_12107(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 12031, 12107);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10443_12178_12199(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 12178, 12199);
                    return return_v;
                }


                int
                f_10443_12159_12200(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 12159, 12200);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 11672, 12212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 11672, 12212);
            }
        }

        private BoundStatement UnpendBranches(
                    AwaitFinallyFrame frame,
                    SynthesizedLocal pendingBranchVar,
                    SynthesizedLocal pendingException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 12224, 14614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12421, 12450);

                var
                parent = frame.ParentOpt
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12514, 12554);

                var
                proxiedLabels = frame.proxiedLabels
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12633, 12643);

                int
                i = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12657, 12746);

                var
                cases = f_10443_12669_12745()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12762, 13185) || true) && (proxiedLabels != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 12762, 13185);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12830, 12855);
                        for (int
        cnt = f_10443_12836_12855(proxiedLabels)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12821, 13170) || true) && (i <= cnt)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12867, 12870)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 12821, 13170))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 12821, 13170);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12912, 12946);

                            var
                            target = f_10443_12925_12945(proxiedLabels, i - 1)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 12968, 13020);

                            var
                            parentProxy = f_10443_12986_13019(parent, target)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13042, 13104);

                            var
                            caseStatement = f_10443_13062_13103(_F, i, f_10443_13082_13102(_F, parentProxy))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13126, 13151);

                            f_10443_13126_13150(cases, caseStatement);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10443, 1, 350);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10443, 1, 350);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 12762, 13185);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13201, 14514) || true) && (frame.returnProxyLabel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 13201, 14514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13269, 13300);

                    BoundLocal
                    pendingValue = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13318, 13451) || true) && (frame.returnValue != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 13318, 13451);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13389, 13432);

                        pendingValue = f_10443_13404_13431(_F, frame.returnValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 13318, 13451);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13471, 13500);

                    SynthesizedLocal
                    returnValue
                    = default(SynthesizedLocal);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13518, 13546);

                    BoundStatement
                    unpendReturn
                    = default(BoundStatement);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13566, 13662);

                    var
                    returnLabel = f_10443_13584_13661(parent, f_10443_13611_13629(_F), pendingValue, out returnValue)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13682, 14382) || true) && (returnLabel == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 13682, 14382);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13747, 13826);

                        unpendReturn = f_10443_13762_13825(f_10443_13787_13796(_F), RefKind.None, pendingValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 13682, 14382);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 13682, 14382);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13908, 14363) || true) && (pendingValue == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 13908, 14363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 13982, 14018);

                            unpendReturn = f_10443_13997_14017(_F, returnLabel);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 13908, 14363);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 13908, 14363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 14116, 14340);

                            unpendReturn = f_10443_14131_14339(_F, f_10443_14170_14287(_F, f_10443_14218_14239(_F, returnValue), pendingValue), f_10443_14318_14338(_F, returnLabel));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 13908, 14363);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 13682, 14382);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 14402, 14456);

                    var
                    caseStatement = f_10443_14422_14455(_F, i, unpendReturn)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 14474, 14499);

                    f_10443_14474_14498(cases, caseStatement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 13201, 14514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 14530, 14603);

                return f_10443_14537_14602(_F, f_10443_14547_14573(_F, pendingBranchVar), f_10443_14575_14601(cases));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 12224, 14614);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                f_10443_12669_12745()
                {
                    var return_v = ArrayBuilder<SyntheticBoundNodeFactory.SyntheticSwitchSection>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 12669, 12745);
                    return return_v;
                }


                int
                f_10443_12836_12855(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 12836, 12855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10443_12925_12945(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 12925, 12945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10443_12986_13019(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.ProxyLabelIfNeeded(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 12986, 13019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10443_13082_13102(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 13082, 13102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection
                f_10443_13062_13103(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.SwitchSection(value, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 13062, 13103);
                    return return_v;
                }


                int
                f_10443_13126_13150(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                this_param, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 13126, 13150);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_13404_13431(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 13404, 13431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10443_13611_13629(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 13611, 13629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10443_13584_13661(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                containingMethod, Microsoft.CodeAnalysis.CSharp.BoundLocal?
                valueOpt, out Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                returnValue)
                {
                    var return_v = this_param.ProxyReturnIfNeeded(containingMethod, (Microsoft.CodeAnalysis.CSharp.BoundExpression?)valueOpt, out returnValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 13584, 13661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10443_13787_13796(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 13787, 13796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10443_13762_13825(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.BoundLocal?
                expressionOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundReturnStatement(syntax, refKind, (Microsoft.CodeAnalysis.CSharp.BoundExpression?)expressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 13762, 13825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10443_13997_14017(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 13997, 14017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_14218_14239(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14218, 14239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_14170_14287(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLocal
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14170, 14287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10443_14318_14338(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14318, 14338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_14131_14339(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14131, 14339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection
                f_10443_14422_14455(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.SwitchSection(value, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14422, 14455);
                    return return_v;
                }


                int
                f_10443_14474_14498(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                this_param, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14474, 14498);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_14547_14573(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14547, 14573);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                f_10443_14575_14601(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14575, 14601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_14537_14602(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                ex, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                sections)
                {
                    var return_v = this_param.Switch((Microsoft.CodeAnalysis.CSharp.BoundExpression)ex, sections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14537, 14602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 12224, 14614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 12224, 14614);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitGotoStatement(BoundGotoStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 14626, 15085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 14720, 14808);

                BoundExpression
                caseExpressionOpt = (BoundExpression)f_10443_14773_14807(this, f_10443_14784_14806(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 14822, 14902);

                BoundLabel
                labelExpressionOpt = (BoundLabel)f_10443_14866_14901(this, f_10443_14877_14900(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 14916, 14990);

                var
                proxyLabel = f_10443_14933_14989(_currentAwaitFinallyFrame, f_10443_14978_14988(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 15004, 15074);

                return f_10443_15011_15073(node, proxyLabel, caseExpressionOpt, labelExpressionOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 14626, 15085);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10443_14784_14806(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.CaseExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 14784, 14806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_14773_14807(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14773, 14807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabel?
                f_10443_14877_14900(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.LabelExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 14877, 14900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_14866_14901(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabel?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14866, 14901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10443_14978_14988(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 14978, 14988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10443_14933_14989(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.ProxyLabelIfNeeded(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 14933, 14989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10443_15011_15073(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                caseExpressionOpt, Microsoft.CodeAnalysis.CSharp.BoundLabel?
                labelExpressionOpt)
                {
                    var return_v = this_param.Update(label, caseExpressionOpt, labelExpressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 15011, 15073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 14626, 15085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 14626, 15085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalGoto(BoundConditionalGoto node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 15097, 15366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 15195, 15302);

                f_10443_15195_15301(f_10443_15208_15218(node) == f_10443_15222_15278(_currentAwaitFinallyFrame, f_10443_15267_15277(node)), "conditional leave?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 15316, 15355);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConditionalGoto(node), 10443, 15323, 15354);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 15097, 15366);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10443_15208_15218(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 15208, 15218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10443_15267_15277(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 15267, 15277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10443_15222_15278(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.ProxyLabelIfNeeded(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 15222, 15278);
                    return return_v;
                }


                int
                f_10443_15195_15301(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 15195, 15301);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 15097, 15366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 15097, 15366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitReturnStatement(BoundReturnStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 15378, 16320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 15476, 15505);

                SynthesizedLocal
                returnValue
                = default(SynthesizedLocal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 15519, 15692);

                var
                returnLabel = f_10443_15537_15691(_currentAwaitFinallyFrame, f_10443_15601_15619(_F), f_10443_15638_15656(node), out returnValue)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 15708, 15819) || true) && (returnLabel == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 15708, 15819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 15765, 15804);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitReturnStatement(node), 10443, 15772, 15803);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 15708, 15819);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 15835, 15902);

                var
                returnExpr = (BoundExpression)(f_10443_15870_15900(this, f_10443_15881_15899(node)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 15916, 16309) || true) && (returnExpr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 15916, 16309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 15972, 16200);

                    return f_10443_15979_16199(_F, f_10443_16014_16121(_F, f_10443_16058_16079(_F, returnValue), returnExpr), f_10443_16148_16198(_F, returnLabel));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 15916, 16309);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 15916, 16309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 16266, 16294);

                    return f_10443_16273_16293(_F, returnLabel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 15916, 16309);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 15378, 16320);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10443_15601_15619(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 15601, 15619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10443_15638_15656(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 15638, 15656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10443_15537_15691(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                containingMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                valueOpt, out Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                returnValue)
                {
                    var return_v = this_param.ProxyReturnIfNeeded(containingMethod, valueOpt, out returnValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 15537, 15691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10443_15881_15899(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 15881, 15899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_15870_15900(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 15870, 15900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_16058_16079(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16058, 16079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_16014_16121(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16014, 16121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10443_16148_16198(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16148, 16198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_15979_16199(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 15979, 16199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10443_16273_16293(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16273, 16293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 15378, 16320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 15378, 16320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement UnpendException(LocalSymbol pendingExceptionLocal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 16332, 17170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 16564, 16645);

                LocalSymbol
                obj = f_10443_16582_16644(_F, f_10443_16602_16643(_F, SpecialType.System_Object))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 16659, 16735);

                var
                objInit = f_10443_16673_16734(_F, f_10443_16687_16700(_F, obj), f_10443_16702_16733(_F, pendingExceptionLocal))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 16796, 16834);

                BoundStatement
                rethrow = f_10443_16821_16833(this, obj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 16850, 17159);

                return f_10443_16857_17158(_F, f_10443_16888_16927(obj), objInit, f_10443_16980_17157(_F, f_10443_17012_17122(_F, f_10443_17060_17073(_F, obj), f_10443_17104_17121(_F, f_10443_17112_17120(obj))), rethrow));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 16332, 17170);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10443_16602_16643(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16602, 16643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10443_16582_16644(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16582, 16644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_16687_16700(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16687, 16700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_16702_16733(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16702, 16733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_16673_16734(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLocal
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16673, 16734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_16821_16833(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                obj)
                {
                    var return_v = this_param.Rethrow(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16821, 16833);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10443_16888_16927(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<LocalSymbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16888, 16927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_17060_17073(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 17060, 17073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10443_17112_17120(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 17112, 17120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_17104_17121(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Null(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 17104, 17121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10443_17012_17122(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.ObjectNotEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 17012, 17122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_16980_17157(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause)
                {
                    var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16980, 17157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_16857_17158(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 16857, 17158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 16332, 17170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 16332, 17170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement Rethrow(LocalSymbol obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 17182, 18914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 17292, 17341);

                BoundStatement
                rethrow = f_10443_17317_17340(_F, f_10443_17326_17339(_F, obj))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 17357, 17510);

                var
                exceptionDispatchInfoCapture = f_10443_17392_17509(_F, WellKnownMember.System_Runtime_ExceptionServices_ExceptionDispatchInfo__Capture, isOptional: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 17524, 17673);

                var
                exceptionDispatchInfoThrow = f_10443_17557_17672(_F, WellKnownMember.System_Runtime_ExceptionServices_ExceptionDispatchInfo__Throw, isOptional: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 17830, 18872) || true) && (exceptionDispatchInfoCapture != null && (DynAbs.Tracing.TraceSender.Expression_True(10443, 17834, 17908) && exceptionDispatchInfoThrow != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 17830, 18872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 17942, 18021);

                    var
                    ex = f_10443_17951_18020(_F, f_10443_17971_18019(_F, WellKnownType.System_Exception))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 18039, 18158);

                    var
                    assignment = f_10443_18056_18157(_F, f_10443_18092_18104(_F, ex), f_10443_18127_18156(_F, f_10443_18133_18146(_F, obj), f_10443_18148_18155(ex)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 18214, 18857);

                    rethrow = f_10443_18224_18856(_F, f_10443_18255_18280(ex), assignment, f_10443_18336_18398(_F, f_10443_18342_18388(_F, f_10443_18357_18369(_F, ex), f_10443_18371_18387(_F, f_10443_18379_18386(ex))), rethrow), f_10443_18507_18855(                    // ExceptionDispatchInfo.Capture(pendingExceptionLocal).Throw();
                                        _F, f_10443_18556_18854(_F, f_10443_18594_18796(_F, f_10443_18642_18685(exceptionDispatchInfoCapture), exceptionDispatchInfoCapture, f_10443_18783_18795(_F, ex)), exceptionDispatchInfoThrow)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 17830, 18872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 18888, 18903);

                return rethrow;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 17182, 18914);

                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_17326_17339(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 17326, 17339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                f_10443_17317_17340(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                e)
                {
                    var return_v = this_param.Throw((Microsoft.CodeAnalysis.CSharp.BoundExpression)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 17317, 17340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10443_17392_17509(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, bool
                isOptional)
                {
                    var return_v = this_param.WellKnownMethod(wm, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 17392, 17509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10443_17557_17672(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, bool
                isOptional)
                {
                    var return_v = this_param.WellKnownMethod(wm, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 17557, 17672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10443_17971_18019(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 17971, 18019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10443_17951_18020(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 17951, 18020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_18092_18104(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18092, 18104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_18133_18146(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18133, 18146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10443_18148_18155(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 18148, 18155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                f_10443_18127_18156(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.As((Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18127, 18156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_18056_18157(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18056, 18157);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10443_18255_18280(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18255, 18280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_18357_18369(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18357, 18369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10443_18379_18386(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 18379, 18386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_18371_18387(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Null(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18371, 18387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10443_18342_18388(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.ObjectEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18342, 18388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_18336_18398(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause)
                {
                    var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18336, 18398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10443_18642_18685(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 18642, 18685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_18783_18795(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18783, 18795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_18594_18796(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.StaticCall((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18594, 18796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10443_18556_18854(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call(receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18556, 18854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_18507_18855(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18507, 18855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_18224_18856(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 18224, 18856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 17182, 18914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 17182, 18914);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement RewriteFinalizedRegion(BoundTryStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 19035, 21354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19129, 19191);

                var
                rewrittenTry = (BoundBlock)f_10443_19160_19190(this, f_10443_19176_19189(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19207, 19238);

                var
                catches = f_10443_19221_19237(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19252, 19349) || true) && (catches.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 19252, 19349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19314, 19334);

                    return rewrittenTry;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 19252, 19349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19365, 19415);

                var
                origAwaitCatchFrame = _currentAwaitCatchFrame
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19429, 19460);

                _currentAwaitCatchFrame = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19476, 19532);

                var
                rewrittenCatches = f_10443_19499_19531(this, f_10443_19514_19530(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19546, 19617);

                BoundStatement
                tryWithCatches = f_10443_19578_19616(_F, rewrittenTry, rewrittenCatches)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19633, 19686);

                var
                currentAwaitCatchFrame = _currentAwaitCatchFrame
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19700, 21243) || true) && (currentAwaitCatchFrame != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 19700, 21243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19768, 19815);

                    var
                    handledLabel = f_10443_19787_19814(_F, "handled")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19833, 19884);

                    var
                    handlersList = currentAwaitCatchFrame.handlers
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 19902, 20012);

                    var
                    handlers = f_10443_19917_20011(f_10443_19992_20010(handlersList))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 20039, 20044);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 20046, 20068);
                        for (int
        i = 0
        ,
        l = f_10443_20050_20068(handlersList)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 20030, 20339) || true) && (i < l)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 20077, 20080)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 20030, 20339))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 20030, 20339);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 20122, 20320);

                            f_10443_20122_20319(handlers, f_10443_20135_20318(_F, i + 1, f_10443_20210_20317(_F, f_10443_20249_20264(handlersList, i), f_10443_20295_20316(_F, handledLabel))));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10443, 1, 310);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10443, 1, 310);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 20359, 21228);

                    tryWithCatches = f_10443_20376_21227(_F, f_10443_20407_20576(currentAwaitCatchFrame.pendingCaughtException, currentAwaitCatchFrame.pendingCatch).
                                            AddRange(f_10443_20612_20653(currentAwaitCatchFrame)), f_10443_20677_20701(_F), f_10443_20724_20889(_F, f_10443_20764_20809(_F, currentAwaitCatchFrame.pendingCatch), f_10443_20836_20888(_F, f_10443_20847_20887(currentAwaitCatchFrame.pendingCatch))), tryWithCatches, f_10443_20949_20973(_F), f_10443_20996_21134(_F, f_10443_21032_21077(_F, currentAwaitCatchFrame.pendingCatch), f_10443_21104_21133(handlers)), f_10443_21157_21181(_F), f_10443_21204_21226(_F, handledLabel));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 19700, 21243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 21259, 21305);

                _currentAwaitCatchFrame = origAwaitCatchFrame;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 21321, 21343);

                return tryWithCatches;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 19035, 21354);

                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_19176_19189(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.TryBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 19176, 19189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_19160_19190(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.VisitBlock(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 19160, 19190);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10443_19221_19237(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.CatchBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 19221, 19237);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10443_19514_19530(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.CatchBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 19514, 19530);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10443_19499_19531(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 19499, 19531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_19578_19616(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                catchBlocks)
                {
                    var return_v = this_param.Try(tryBlock, catchBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 19578, 19616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10443_19787_19814(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 19787, 19814);
                    return return_v;
                }


                int
                f_10443_19992_20010(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.BoundBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 19992, 20010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                f_10443_19917_20011(int
                capacity)
                {
                    var return_v = ArrayBuilder<SyntheticBoundNodeFactory.SyntheticSwitchSection>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 19917, 20011);
                    return return_v;
                }


                int
                f_10443_20050_20068(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.BoundBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 20050, 20068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_20249_20264(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.BoundBlock>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 20249, 20264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10443_20295_20316(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Goto((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20295, 20316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_20210_20317(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20210, 20317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection
                f_10443_20135_20318(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.SwitchSection(value, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20135, 20318);
                    return return_v;
                }


                int
                f_10443_20122_20319(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                this_param, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20122, 20319);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10443_20407_20576(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                item2)
                {
                    var return_v = ImmutableArray.Create<LocalSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item1, (Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20407, 20576);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10443_20612_20653(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitCatchFrame
                this_param)
                {
                    var return_v = this_param.GetHoistedLocals();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20612, 20653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_20677_20701(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20677, 20701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_20764_20809(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20764, 20809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10443_20847_20887(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 20847, 20887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_20836_20888(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Default(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20836, 20888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_20724_20889(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20724, 20889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_20949_20973(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20949, 20973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_21032_21077(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 21032, 21077);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                f_10443_21104_21133(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 21104, 21133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_20996_21134(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                ex, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                sections)
                {
                    var return_v = this_param.Switch((Microsoft.CodeAnalysis.CSharp.BoundExpression)ex, sections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20996, 21134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_21157_21181(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 21157, 21181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10443_21204_21226(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 21204, 21226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_20376_21227(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 20376, 21227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 19035, 21354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 19035, 21354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCatchBlock(BoundCatchBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 21366, 26860);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 21454, 21811) || true) && (!f_10443_21459_21493(_analysis, node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 21454, 21811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 21527, 21584);

                    var
                    origCurrentAwaitCatchFrame = _currentAwaitCatchFrame
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 21602, 21633);

                    _currentAwaitCatchFrame = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 21653, 21693);

                    var
                    result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(node), 10443, 21666, 21692)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 21711, 21764);

                    _currentAwaitCatchFrame = origCurrentAwaitCatchFrame;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 21782, 21796);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 21454, 21811);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 21827, 21880);

                var
                currentAwaitCatchFrame = _currentAwaitCatchFrame
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 21894, 22231) || true) && (currentAwaitCatchFrame == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 21894, 22231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 21962, 22019);

                    f_10443_21962_22018(f_10443_21975_22017(node.Syntax, SyntaxKind.CatchClause));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 22037, 22101);

                    var
                    tryStatementSyntax = (TryStatementSyntax)f_10443_22082_22100(node.Syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 22121, 22216);

                    currentAwaitCatchFrame = _currentAwaitCatchFrame = f_10443_22172_22215(_F, tryStatementSyntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 21894, 22231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 22247, 22330);

                var
                catchType = f_10443_22263_22284(node) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10443, 22263, 22329) ?? f_10443_22288_22329(_F, SpecialType.System_Object))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 22344, 22391);

                var
                catchTemp = f_10443_22360_22390(_F, catchType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 22407, 22672);

                var
                storePending = f_10443_22426_22671(_F, f_10443_22476_22531(_F, currentAwaitCatchFrame.pendingCaughtException), f_10443_22558_22670(_F, f_10443_22569_22619(currentAwaitCatchFrame.pendingCaughtException), f_10443_22650_22669(_F, catchTemp)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 22688, 22888);

                var
                setPendingCatchNum = f_10443_22713_22887(_F, f_10443_22757_22802(_F, currentAwaitCatchFrame.pendingCatch), f_10443_22833_22886(_F, f_10443_22844_22881(currentAwaitCatchFrame.handlers) + 1))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 23069, 23098);

                BoundCatchBlock
                catchAndPend
                = default(BoundCatchBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 23112, 23154);

                ImmutableArray<LocalSymbol>
                handlerLocals
                = default(ImmutableArray<LocalSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 23170, 23226);

                var
                filterPrologueOpt = f_10443_23194_23225(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 23240, 23280);

                var
                filterOpt = f_10443_23256_23279(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 23294, 25952) || true) && (filterOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 23294, 25952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 23349, 23389);

                    f_10443_23349_23388(filterPrologueOpt is null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 23506, 24057);

                    catchAndPend = f_10443_23521_24056(node, f_10443_23555_23587(catchTemp), f_10443_23610_23629(_F, catchTemp), catchType, exceptionFilterPrologueOpt: filterPrologueOpt, exceptionFilterOpt: null, body: f_10443_23805_23973(_F, f_10443_23840_23864(_F), f_10443_23891_23927(_F, storePending), setPendingCatchNum), isSynthesizedAsyncCatchAll: f_10443_24024_24055(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 24152, 24180);

                    handlerLocals = f_10443_24168_24179(node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 23294, 25952);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 23294, 25952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 24246, 24296);

                    handlerLocals = ImmutableArray<LocalSymbol>.Empty;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 24467, 24606);
                        foreach (var local in f_10443_24489_24500_I(f_10443_24489_24500(node)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 24467, 24606);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 24542, 24587);

                            f_10443_24542_24586(currentAwaitCatchFrame, local, _F);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 24467, 24606);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10443, 1, 140);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10443, 1, 140);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 24727, 24767);

                    var
                    sourceOpt = f_10443_24743_24766(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 24785, 24859);

                    var
                    rewrittenPrologue = (BoundStatementList)f_10443_24829_24858(this, filterPrologueOpt)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 24877, 24938);

                    var
                    rewrittenFilter = (BoundExpression)f_10443_24916_24937(this, filterOpt)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 24956, 25424);

                    var
                    newFilter = (DynAbs.Tracing.TraceSender.Conditional_F1(10443, 24972, 24989) || ((sourceOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10443, 25025, 25146)) || DynAbs.Tracing.TraceSender.Conditional_F3(10443, 25182, 25423))) ? f_10443_25025_25146(_F, storePending, rewrittenFilter) : f_10443_25182_25423(_F, storePending, f_10443_25287_25368(this, f_10443_25322_25343(this, sourceOpt), currentAwaitCatchFrame), rewrittenFilter)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 25444, 25937);

                    catchAndPend = f_10443_25459_25936(node, f_10443_25493_25525(catchTemp), f_10443_25548_25567(_F, catchTemp), catchType, exceptionFilterPrologueOpt: rewrittenPrologue, exceptionFilterOpt: newFilter, body: f_10443_25748_25853(_F, f_10443_25783_25807(_F), setPendingCatchNum), isSynthesizedAsyncCatchAll: f_10443_25904_25935(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 23294, 25952);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 25968, 26035);

                var
                handlerStatements = f_10443_25992_26034()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 26051, 26099);

                f_10443_26051_26098(
                            handlerStatements, f_10443_26073_26097(_F));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 26115, 26520) || true) && (filterOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 26115, 26520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 26170, 26210);

                    var
                    sourceOpt = f_10443_26186_26209(node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 26228, 26505) || true) && (sourceOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 26228, 26505);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 26291, 26404);

                        BoundExpression
                        assignSource = f_10443_26322_26403(this, f_10443_26357_26378(this, sourceOpt), currentAwaitCatchFrame)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 26426, 26486);

                        f_10443_26426_26485(handlerStatements, f_10443_26448_26484(_F, assignSource));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 26228, 26505);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 26115, 26520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 26536, 26597);

                f_10443_26536_26596(
                            handlerStatements, f_10443_26574_26595(this, f_10443_26585_26594(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 26613, 26752);

                var
                handler = f_10443_26627_26751(_F, handlerLocals, f_10443_26694_26732(handlerStatements))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 26768, 26813);

                f_10443_26768_26812(
                            currentAwaitCatchFrame.handlers, handler);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 26829, 26849);

                return catchAndPend;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 21366, 26860);

                bool
                f_10443_21459_21493(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitInFinallyAnalysis
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                node)
                {
                    var return_v = this_param.CatchContainsAwait(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 21459, 21493);
                    return return_v;
                }


                bool
                f_10443_21975_22017(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 21975, 22017);
                    return return_v;
                }


                int
                f_10443_21962_22018(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 21962, 22018);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10443_22082_22100(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 22082, 22100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitCatchFrame
                f_10443_22172_22215(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax?
                tryStatementSyntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitCatchFrame(F, tryStatementSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 22172, 22215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10443_22263_22284(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 22263, 22284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10443_22288_22329(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 22288, 22329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10443_22360_22390(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 22360, 22390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_22476_22531(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 22476, 22531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10443_22569_22619(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 22569, 22619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_22650_22669(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 22650, 22669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_22558_22670(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg)
                {
                    var return_v = this_param.Convert(type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 22558, 22670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10443_22426_22671(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 22426, 22671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_22757_22802(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 22757, 22802);
                    return return_v;
                }


                int
                f_10443_22844_22881(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.BoundBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 22844, 22881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10443_22833_22886(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 22833, 22886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_22713_22887(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 22713, 22887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                f_10443_23194_23225(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterPrologueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 23194, 23225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10443_23256_23279(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 23256, 23279);
                    return return_v;
                }


                int
                f_10443_23349_23388(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 23349, 23388);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10443_23555_23587(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 23555, 23587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_23610_23629(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 23610, 23629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_23840_23864(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 23840, 23864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_23891_23927(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 23891, 23927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_23805_23973(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 23805, 23973);
                    return return_v;
                }


                bool
                f_10443_24024_24055(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.IsSynthesizedAsyncCatchAll;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 24024, 24055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10443_23521_24056(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundLocal
                exceptionSourceOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                exceptionTypeOpt, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                exceptionFilterPrologueOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                exceptionFilterOpt, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body, bool
                isSynthesizedAsyncCatchAll)
                {
                    var return_v = this_param.Update(locals, (Microsoft.CodeAnalysis.CSharp.BoundExpression)exceptionSourceOpt, exceptionTypeOpt, exceptionFilterPrologueOpt: exceptionFilterPrologueOpt, exceptionFilterOpt: exceptionFilterOpt, body: body, isSynthesizedAsyncCatchAll: isSynthesizedAsyncCatchAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 23521, 24056);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10443_24168_24179(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 24168, 24179);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10443_24489_24500(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 24489, 24500);
                    return return_v;
                }


                int
                f_10443_24542_24586(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitCatchFrame
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F)
                {
                    this_param.HoistLocal(local, F);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 24542, 24586);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10443_24489_24500_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 24489, 24500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10443_24743_24766(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 24743, 24766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_24829_24858(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 24829, 24858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_24916_24937(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 24916, 24937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_25025_25146(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                parts)
                {
                    var return_v = this_param.MakeSequence(parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 25025, 25146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_25322_25343(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 25322, 25343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_25287_25368(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode?
                rewrittenSource, Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitCatchFrame
                currentAwaitCatchFrame)
                {
                    var return_v = this_param.AssignCatchSource((Microsoft.CodeAnalysis.CSharp.BoundExpression?)rewrittenSource, currentAwaitCatchFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 25287, 25368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_25182_25423(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                parts)
                {
                    var return_v = this_param.MakeSequence(parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 25182, 25423);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10443_25493_25525(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 25493, 25525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_25548_25567(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 25548, 25567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_25783_25807(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 25783, 25807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_25748_25853(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 25748, 25853);
                    return return_v;
                }


                bool
                f_10443_25904_25935(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.IsSynthesizedAsyncCatchAll;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 25904, 25935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10443_25459_25936(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundLocal
                exceptionSourceOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                exceptionTypeOpt, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                exceptionFilterPrologueOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
                exceptionFilterOpt, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body, bool
                isSynthesizedAsyncCatchAll)
                {
                    var return_v = this_param.Update(locals, (Microsoft.CodeAnalysis.CSharp.BoundExpression)exceptionSourceOpt, exceptionTypeOpt, exceptionFilterPrologueOpt: exceptionFilterPrologueOpt, exceptionFilterOpt: exceptionFilterOpt, body: body, isSynthesizedAsyncCatchAll: isSynthesizedAsyncCatchAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 25459, 25936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10443_25992_26034()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 25992, 26034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_26073_26097(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.HiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 26073, 26097);
                    return return_v;
                }


                int
                f_10443_26051_26098(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 26051, 26098);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10443_26186_26209(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 26186, 26209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_26357_26378(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 26357, 26378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_26322_26403(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode?
                rewrittenSource, Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitCatchFrame
                currentAwaitCatchFrame)
                {
                    var return_v = this_param.AssignCatchSource((Microsoft.CodeAnalysis.CSharp.BoundExpression?)rewrittenSource, currentAwaitCatchFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 26322, 26403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10443_26448_26484(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.ExpressionStatement(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 26448, 26484);
                    return return_v;
                }


                int
                f_10443_26426_26485(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 26426, 26485);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_26585_26594(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 26585, 26594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10443_26574_26595(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 26574, 26595);
                    return return_v;
                }


                int
                f_10443_26536_26596(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode?
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement?)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 26536, 26596);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10443_26694_26732(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 26694, 26732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10443_26627_26751(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 26627, 26751);
                    return return_v;
                }


                int
                f_10443_26768_26812(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.BoundBlock>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 26768, 26812);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 21366, 26860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 21366, 26860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression AssignCatchSource(BoundExpression rewrittenSource, AwaitCatchFrame currentAwaitCatchFrame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 26872, 27572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 27011, 27047);

                BoundExpression
                assignSource = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 27061, 27525) || true) && (rewrittenSource != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 27061, 27525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 27205, 27510);

                    assignSource = f_10443_27220_27509(_F, rewrittenSource, f_10443_27336_27508(_F, f_10443_27389_27409(rewrittenSource), f_10443_27452_27507(_F, currentAwaitCatchFrame.pendingCaughtException)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 27061, 27525);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 27541, 27561);

                return assignSource;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 26872, 27572);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10443_27389_27409(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 27389, 27409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_27452_27507(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                local)
                {
                    var return_v = this_param.Local((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 27452, 27507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10443_27336_27508(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg)
                {
                    var return_v = this_param.Convert(type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 27336, 27508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10443_27220_27509(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.AssignmentExpression(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 27220, 27509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 26872, 27572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 26872, 27572);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocal(BoundLocal node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 27584, 28028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 27662, 27703);

                var
                catchFrame = _currentAwaitCatchFrame
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 27717, 27742);

                LocalSymbol
                hoistedLocal
                = default(LocalSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 27756, 27926) || true) && (catchFrame == null || (DynAbs.Tracing.TraceSender.Expression_False(10443, 27760, 27848) || !f_10443_27783_27848(catchFrame, f_10443_27813_27829(node), out hoistedLocal)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 27756, 27926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 27882, 27911);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocal(node), 10443, 27889, 27910);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 27756, 27926);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 27942, 28017);

                return f_10443_27949_28016(node, hoistedLocal, f_10443_27975_27996(node), f_10443_27998_28015(hoistedLocal));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 27584, 28028);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10443_27813_27829(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 27813, 27829);
                    return return_v;
                }


                bool
                f_10443_27783_27848(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitCatchFrame
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                originalLocal, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                hoistedLocal)
                {
                    var return_v = this_param.TryGetHoistedLocal(originalLocal, out hoistedLocal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 27783, 27848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10443_27975_27996(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 27975, 27996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10443_27998_28015(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 27998, 28015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10443_27949_28016(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(localSymbol, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 27949, 28016);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 27584, 28028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 27584, 28028);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitThrowStatement(BoundThrowStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 28040, 28378);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 28136, 28288) || true) && (f_10443_28140_28158(node) != null || (DynAbs.Tracing.TraceSender.Expression_False(10443, 28140, 28201) || _currentAwaitCatchFrame == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 28136, 28288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 28235, 28273);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitThrowStatement(node), 10443, 28242, 28272);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 28136, 28288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 28304, 28367);

                return f_10443_28311_28366(this, _currentAwaitCatchFrame.pendingCaughtException);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 28040, 28378);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10443_28140_28158(Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 28140, 28158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10443_28311_28366(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                obj)
                {
                    var return_v = this_param.Rethrow((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 28311, 28366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 28040, 28378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 28040, 28378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLambda(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 28390, 28910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 28470, 28515);

                var
                oldContainingSymbol = f_10443_28496_28514(_F)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 28529, 28582);

                var
                oldAwaitFinallyFrame = _currentAwaitFinallyFrame
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 28598, 28631);

                _F.CurrentFunction = f_10443_28619_28630(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 28645, 28697);

                _currentAwaitFinallyFrame = f_10443_28673_28696();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 28713, 28749);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLambda(node), 10443, 28726, 28748)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 28765, 28806);

                _F.CurrentFunction = oldContainingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 28820, 28869);

                _currentAwaitFinallyFrame = oldAwaitFinallyFrame;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 28885, 28899);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 28390, 28910);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10443_28496_28514(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 28496, 28514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10443_28619_28630(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 28619, 28630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                f_10443_28673_28696()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 28673, 28696);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 28390, 28910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 28390, 28910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocalFunctionStatement(BoundLocalFunctionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 28922, 29490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29034, 29079);

                var
                oldContainingSymbol = f_10443_29060_29078(_F)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29093, 29146);

                var
                oldAwaitFinallyFrame = _currentAwaitFinallyFrame
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29162, 29195);

                _F.CurrentFunction = f_10443_29183_29194(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29209, 29261);

                _currentAwaitFinallyFrame = f_10443_29237_29260();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29277, 29329);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocalFunctionStatement(node), 10443, 29290, 29328)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29345, 29386);

                _F.CurrentFunction = oldContainingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29400, 29449);

                _currentAwaitFinallyFrame = oldAwaitFinallyFrame;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29465, 29479);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 28922, 29490);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10443_29060_29078(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 29060, 29078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10443_29183_29194(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 29183, 29194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                f_10443_29237_29260()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 29237, 29260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 28922, 29490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 28922, 29490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AwaitFinallyFrame PushFrame(BoundTryStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 29502, 29811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29591, 29719);

                var
                newFrame = f_10443_29606_29718(_currentAwaitFinallyFrame, f_10443_29655_29682(_analysis, statement), (StatementSyntax)statement.Syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29733, 29770);

                _currentAwaitFinallyFrame = newFrame;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29784, 29800);

                return newFrame;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 29502, 29811);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10443_29655_29682(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitInFinallyAnalysis
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                statement)
                {
                    var return_v = this_param.Labels(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 29655, 29682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                f_10443_29606_29718(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                parent, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                labelsOpt, Microsoft.CodeAnalysis.SyntaxNode
                statementSyntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame(parent, labelsOpt, (Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax)statementSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 29606, 29718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 29502, 29811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 29502, 29811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void PopFrame()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 29823, 29980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29871, 29910);

                var
                result = _currentAwaitFinallyFrame
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 29924, 29969);

                _currentAwaitFinallyFrame = result.ParentOpt;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 29823, 29980);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 29823, 29980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 29823, 29980);
            }
        }
        private sealed class AwaitInFinallyAnalysis : LabelCollector
        {
            private Dictionary<BoundTryStatement, HashSet<LabelSymbol>> _labelsInInterestingTry;

            private HashSet<BoundCatchBlock> _awaitContainingCatches;

            private bool _seenAwait;

            public AwaitInFinallyAnalysis(BoundStatement body)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10443, 30800, 30952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 30607, 30630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 30680, 30703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 30773, 30783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 30883, 30902);

                    _seenAwait = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 30920, 30937);

                    f_10443_30920_30936(this, body);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10443, 30800, 30952);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 30800, 30952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 30800, 30952);
                }
            }

            public bool FinallyContainsAwaits(BoundTryStatement statement)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 31099, 31298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 31194, 31283);

                    return _labelsInInterestingTry != null && (DynAbs.Tracing.TraceSender.Expression_True(10443, 31201, 31282) && f_10443_31236_31282(_labelsInInterestingTry, statement));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 31099, 31298);

                    bool
                    f_10443_31236_31282(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundTryStatement, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 31236, 31282);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 31099, 31298);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 31099, 31298);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal bool CatchContainsAwait(BoundCatchBlock node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 31426, 31609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 31513, 31594);

                    return _awaitContainingCatches != null && (DynAbs.Tracing.TraceSender.Expression_True(10443, 31520, 31593) && f_10443_31555_31593(_awaitContainingCatches, node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 31426, 31609);

                    bool
                    f_10443_31555_31593(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 31555, 31593);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 31426, 31609);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 31426, 31609);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool ContainsAwaitInHandlers()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 31753, 31912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 31823, 31897);

                    return _labelsInInterestingTry != null || (DynAbs.Tracing.TraceSender.Expression_False(10443, 31830, 31896) || _awaitContainingCatches != null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 31753, 31912);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 31753, 31912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 31753, 31912);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal HashSet<LabelSymbol> Labels(BoundTryStatement statement)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 32122, 32277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32220, 32262);

                    return f_10443_32227_32261(_labelsInInterestingTry, statement);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 32122, 32277);

                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10443_32227_32261(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundTryStatement, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 32227, 32261);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 32122, 32277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 32122, 32277);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitTryStatement(BoundTryStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 32293, 33872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32393, 32429);

                    var
                    origLabels = this.currentLabels
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32447, 32473);

                    this.currentLabels = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32491, 32512);

                    f_10443_32491_32511(this, f_10443_32497_32510(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32530, 32558);

                    f_10443_32530_32557(this, f_10443_32540_32556(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32578, 32609);

                    var
                    origSeenAwait = _seenAwait
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32627, 32646);

                    _seenAwait = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32664, 32692);

                    f_10443_32664_32691(this, f_10443_32670_32690(node));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32712, 33767) || true) && (_seenAwait)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 32712, 33767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32829, 32882);

                        var
                        labelsInInterestingTry = _labelsInInterestingTry
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32904, 33120) || true) && (labelsInInterestingTry == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 32904, 33120);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 32988, 33097);

                            _labelsInInterestingTry = labelsInInterestingTry = f_10443_33039_33096();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 32904, 33120);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 33144, 33192);

                        f_10443_33144_33191(
                                            labelsInInterestingTry, node, currentLabels);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 33214, 33241);

                        currentLabels = origLabels;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 32712, 33767);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 32712, 33767);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 33465, 33748) || true) && (currentLabels == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 33465, 33748);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 33540, 33567);

                            currentLabels = origLabels;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 33465, 33748);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 33465, 33748);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 33617, 33748) || true) && (origLabels != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 33617, 33748);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 33689, 33725);

                                f_10443_33689_33724(currentLabels, origLabels);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 33617, 33748);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 33465, 33748);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 32712, 33767);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 33787, 33827);

                    _seenAwait = _seenAwait | origSeenAwait;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 33845, 33857);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 32293, 33872);

                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10443_32497_32510(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                    this_param)
                    {
                        var return_v = this_param.TryBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 32497, 32510);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10443_32491_32511(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitInFinallyAnalysis
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 32491, 32511);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                    f_10443_32540_32556(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                    this_param)
                    {
                        var return_v = this_param.CatchBlocks;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 32540, 32556);
                        return return_v;
                    }


                    int
                    f_10443_32530_32557(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitInFinallyAnalysis
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                    list)
                    {
                        this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 32530, 32557);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock?
                    f_10443_32670_32690(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                    this_param)
                    {
                        var return_v = this_param.FinallyBlockOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 32670, 32690);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10443_32664_32691(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitInFinallyAnalysis
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 32664, 32691);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundTryStatement, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                    f_10443_33039_33096()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundTryStatement, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 33039, 33096);
                        return return_v;
                    }


                    int
                    f_10443_33144_33191(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundTryStatement, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                    key, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>?
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 33144, 33191);
                        return 0;
                    }


                    int
                    f_10443_33689_33724(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    other)
                    {
                        this_param.UnionWith((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 33689, 33724);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 32293, 33872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 32293, 33872);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitCatchBlock(BoundCatchBlock node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 33888, 34624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 33984, 34015);

                    var
                    origSeenAwait = _seenAwait
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34033, 34052);

                    _seenAwait = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34072, 34112);

                    var
                    result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(node), 10443, 34085, 34111)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34132, 34529) || true) && (_seenAwait)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 34132, 34529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34188, 34241);

                        var
                        awaitContainingCatches = _awaitContainingCatches
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34263, 34452) || true) && (awaitContainingCatches == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 34263, 34452);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34347, 34429);

                            _awaitContainingCatches = awaitContainingCatches = f_10443_34398_34428();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 34263, 34452);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34476, 34510);

                        f_10443_34476_34509(
                                            _awaitContainingCatches, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 34132, 34529);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34549, 34577);

                    _seenAwait |= origSeenAwait;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34595, 34609);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 33888, 34624);

                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                    f_10443_34398_34428()
                    {
                        var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 34398, 34428);
                        return return_v;
                    }


                    bool
                    f_10443_34476_34509(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 34476, 34509);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 33888, 34624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 33888, 34624);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitAwaitExpression(BoundAwaitExpression node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 34640, 34836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34746, 34764);

                    _seenAwait = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34782, 34821);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAwaitExpression(node), 10443, 34789, 34820);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 34640, 34836);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 34640, 34836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 34640, 34836);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitLambda(BoundLambda node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 34852, 35295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34940, 34976);

                    var
                    origLabels = this.currentLabels
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 34994, 35025);

                    var
                    origSeenAwait = _seenAwait
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35045, 35071);

                    this.currentLabels = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35089, 35108);

                    _seenAwait = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35128, 35151);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLambda(node), 10443, 35128, 35150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35171, 35203);

                    this.currentLabels = origLabels;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35221, 35248);

                    _seenAwait = origSeenAwait;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35268, 35280);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 34852, 35295);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 34852, 35295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 34852, 35295);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitLocalFunctionStatement(BoundLocalFunctionStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 35311, 35802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35431, 35467);

                    var
                    origLabels = this.currentLabels
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35485, 35516);

                    var
                    origSeenAwait = _seenAwait
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35536, 35562);

                    this.currentLabels = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35580, 35599);

                    _seenAwait = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35619, 35658);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocalFunctionStatement(node), 10443, 35619, 35657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35678, 35710);

                    this.currentLabels = origLabels;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35728, 35755);

                    _seenAwait = origSeenAwait;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 35775, 35787);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 35311, 35802);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 35311, 35802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 35311, 35802);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AwaitInFinallyAnalysis()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10443, 30179, 35813);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10443, 30179, 35813);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 30179, 35813);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10443, 30179, 35813);

            Microsoft.CodeAnalysis.CSharp.BoundNode?
            f_10443_30920_30936(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitInFinallyAnalysis
            this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
            node)
            {
                var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 30920, 30936);
                return return_v;
            }

        }
        private sealed class AwaitFinallyFrame
        {
            public readonly AwaitFinallyFrame ParentOpt;

            public readonly HashSet<LabelSymbol> LabelsOpt;

            private readonly StatementSyntax _statementSyntaxOpt;

            public Dictionary<LabelSymbol, LabelSymbol> proxyLabels;

            public List<LabelSymbol> proxiedLabels;

            public GeneratedLabelSymbol returnProxyLabel;

            public SynthesizedLocal returnValue;

            public AwaitFinallyFrame()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10443, 37033, 37120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36059, 36068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36220, 36229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36357, 36376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36839, 36850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36892, 36905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36950, 36966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 37005, 37016);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10443, 37033, 37120);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 37033, 37120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 37033, 37120);
                }
            }

            public AwaitFinallyFrame(AwaitFinallyFrame parent, HashSet<LabelSymbol> labelsOpt, StatementSyntax statementSyntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10443, 37136, 38243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36059, 36068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36220, 36229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36357, 36376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36839, 36850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36892, 36905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 36950, 36966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 37005, 37016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 37284, 37313);

                    f_10443_37284_37312(parent != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 37331, 37369);

                    f_10443_37331_37368(statementSyntax != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 37389, 38083);

                    f_10443_37389_38082(f_10443_37402_37424(statementSyntax) == SyntaxKind.TryStatement || (DynAbs.Tracing.TraceSender.Expression_False(10443, 37402, 37596) || (f_10443_37477_37499(statementSyntax) == SyntaxKind.UsingStatement && (DynAbs.Tracing.TraceSender.Expression_True(10443, 37477, 37595) && f_10443_37532_37584(((UsingStatementSyntax)statementSyntax)) != default))) || (DynAbs.Tracing.TraceSender.Expression_False(10443, 37402, 37751) || (f_10443_37622_37644(statementSyntax) == SyntaxKind.ForEachStatement && (DynAbs.Tracing.TraceSender.Expression_True(10443, 37622, 37750) && f_10443_37679_37739(((CommonForEachStatementSyntax)statementSyntax)) != default))) || (DynAbs.Tracing.TraceSender.Expression_False(10443, 37402, 37914) || (f_10443_37777_37799(statementSyntax) == SyntaxKind.ForEachVariableStatement && (DynAbs.Tracing.TraceSender.Expression_True(10443, 37777, 37913) && f_10443_37842_37902(((CommonForEachStatementSyntax)statementSyntax)) != default))) || (DynAbs.Tracing.TraceSender.Expression_False(10443, 37402, 38081) || (f_10443_37940_37962(statementSyntax) == SyntaxKind.LocalDeclarationStatement && (DynAbs.Tracing.TraceSender.Expression_True(10443, 37940, 38080) && f_10443_38006_38069(((LocalDeclarationStatementSyntax)statementSyntax)) != default))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 38103, 38127);

                    this.ParentOpt = parent;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 38145, 38172);

                    this.LabelsOpt = labelsOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 38190, 38228);

                    _statementSyntaxOpt = statementSyntax;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10443, 37136, 38243);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 37136, 38243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 37136, 38243);
                }
            }

            public bool IsRoot()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 38259, 38357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 38312, 38342);

                    return this.ParentOpt == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 38259, 38357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 38259, 38357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 38259, 38357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LabelSymbol ProxyLabelIfNeeded(LabelSymbol label)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 38509, 39572);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 38691, 38834) || true) && (f_10443_38695_38708(this) || (DynAbs.Tracing.TraceSender.Expression_False(10443, 38695, 38760) || (LabelsOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10443, 38713, 38759) && f_10443_38734_38759(LabelsOpt, label)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 38691, 38834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 38802, 38815);

                        return label;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 38691, 38834);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 38854, 38889);

                    var
                    proxyLabels = this.proxyLabels
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 38907, 38946);

                    var
                    proxiedLabels = this.proxiedLabels
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 38964, 39207) || true) && (proxyLabels == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 38964, 39207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 39029, 39105);

                        this.proxyLabels = proxyLabels = f_10443_39062_39104();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 39127, 39188);

                        this.proxiedLabels = proxiedLabels = f_10443_39164_39187();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 38964, 39207);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 39227, 39245);

                    LabelSymbol
                    proxy
                    = default(LabelSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 39263, 39524) || true) && (!f_10443_39268_39309(proxyLabels, label, out proxy))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 39263, 39524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 39351, 39406);

                        proxy = f_10443_39359_39405("proxy" + f_10443_39394_39404(label));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 39428, 39458);

                        f_10443_39428_39457(proxyLabels, label, proxy);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 39480, 39505);

                        f_10443_39480_39504(proxiedLabels, label);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 39263, 39524);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 39544, 39557);

                    return proxy;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 38509, 39572);

                    bool
                    f_10443_38695_38708(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                    this_param)
                    {
                        var return_v = this_param.IsRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 38695, 38708);
                        return return_v;
                    }


                    bool
                    f_10443_38734_38759(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 38734, 38759);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10443_39062_39104()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 39062, 39104);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10443_39164_39187()
                    {
                        var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 39164, 39187);
                        return return_v;
                    }


                    bool
                    f_10443_39268_39309(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 39268, 39309);
                        return return_v;
                    }


                    string
                    f_10443_39394_39404(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 39394, 39404);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10443_39359_39405(string
                    name)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 39359, 39405);
                        return return_v;
                    }


                    int
                    f_10443_39428_39457(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 39428, 39457);
                        return 0;
                    }


                    int
                    f_10443_39480_39504(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 39480, 39504);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 38509, 39572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 38509, 39572);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LabelSymbol ProxyReturnIfNeeded(
                            MethodSymbol containingMethod,
                            BoundExpression valueOpt,
                            out SynthesizedLocal returnValue)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 39588, 40782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 39802, 39821);

                    returnValue = null;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 39899, 39989) || true) && (f_10443_39903_39916(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 39899, 39989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 39958, 39970);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 39899, 39989);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 40009, 40049);

                    var
                    returnProxy = this.returnProxyLabel
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 40067, 40229) || true) && (returnProxy == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 40067, 40229);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 40132, 40210);

                        this.returnProxyLabel = returnProxy = f_10443_40170_40209("returnProxy");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 40067, 40229);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 40249, 40728) || true) && (valueOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 40249, 40728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 40311, 40342);

                        returnValue = this.returnValue;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 40364, 40709) || true) && (returnValue == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 40364, 40709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 40437, 40479);

                            f_10443_40437_40478(_statementSyntaxOpt != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 40505, 40686);

                            this.returnValue = returnValue = f_10443_40538_40685(containingMethod, TypeWithAnnotations.Create(f_10443_40604_40617(valueOpt)), SynthesizedLocalKind.AsyncMethodReturnValue, _statementSyntaxOpt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 40364, 40709);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 40249, 40728);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 40748, 40767);

                    return returnProxy;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 39588, 40782);

                    bool
                    f_10443_39903_39916(Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
                    this_param)
                    {
                        var return_v = this_param.IsRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 39903, 39916);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10443_40170_40209(string
                    name)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 40170, 40209);
                        return return_v;
                    }


                    int
                    f_10443_40437_40478(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 40437, 40478);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10443_40604_40617(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 40604, 40617);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                    f_10443_40538_40685(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                    kind, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                    syntaxOpt)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind, (Microsoft.CodeAnalysis.SyntaxNode)syntaxOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 40538, 40685);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 39588, 40782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 39588, 40782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AwaitFinallyFrame()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10443, 35896, 40793);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10443, 35896, 40793);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 35896, 40793);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10443, 35896, 40793);

            int
            f_10443_37284_37312(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 37284, 37312);
                return 0;
            }


            int
            f_10443_37331_37368(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 37331, 37368);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10443_37402_37424(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            this_param)
            {
                var return_v = this_param.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 37402, 37424);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10443_37477_37499(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            this_param)
            {
                var return_v = this_param.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 37477, 37499);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10443_37532_37584(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
            this_param)
            {
                var return_v = this_param.AwaitKeyword;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 37532, 37584);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10443_37622_37644(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            this_param)
            {
                var return_v = this_param.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 37622, 37644);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10443_37679_37739(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
            this_param)
            {
                var return_v = this_param.AwaitKeyword;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 37679, 37739);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10443_37777_37799(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            this_param)
            {
                var return_v = this_param.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 37777, 37799);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10443_37842_37902(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
            this_param)
            {
                var return_v = this_param.AwaitKeyword;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 37842, 37902);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10443_37940_37962(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            this_param)
            {
                var return_v = this_param.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 37940, 37962);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10443_38006_38069(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
            this_param)
            {
                var return_v = this_param.AwaitKeyword;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 38006, 38069);
                return return_v;
            }


            int
            f_10443_37389_38082(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 37389, 38082);
                return 0;
            }

        }
        private sealed class AwaitCatchFrame
        {
            public readonly SynthesizedLocal pendingCaughtException;

            public readonly SynthesizedLocal pendingCatch;

            public readonly List<BoundBlock> handlers;

            private readonly Dictionary<LocalSymbol, LocalSymbol> _hoistedLocals;

            private readonly List<LocalSymbol> _orderedHoistedLocals;

            public AwaitCatchFrame(SyntheticBoundNodeFactory F, TryStatementSyntax tryStatementSyntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10443, 42075, 42839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 41083, 41105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 41261, 41273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 41472, 41480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 41973, 41987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 42037, 42058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 42198, 42411);

                    this.pendingCaughtException = f_10443_42228_42410(f_10443_42249_42266(F), TypeWithAnnotations.Create(f_10443_42295_42335(F, SpecialType.System_Object)), SynthesizedLocalKind.TryAwaitPendingCaughtException, tryStatementSyntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 42429, 42621);

                    this.pendingCatch = f_10443_42449_42620(f_10443_42470_42487(F), TypeWithAnnotations.Create(f_10443_42516_42555(F, SpecialType.System_Int32)), SynthesizedLocalKind.TryAwaitPendingCatch, tryStatementSyntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 42641, 42680);

                    this.handlers = f_10443_42657_42679();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 42698, 42758);

                    _hoistedLocals = f_10443_42715_42757();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 42776, 42824);

                    _orderedHoistedLocals = f_10443_42800_42823();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10443, 42075, 42839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 42075, 42839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 42075, 42839);
                }
            }

            public void HoistLocal(LocalSymbol local, SyntheticBoundNodeFactory F)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 42855, 44050);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 42958, 43269) || true) && (!f_10443_42963_43091(f_10443_42963_42982(_hoistedLocals), l => l.Name == local.Name && TypeSymbol.Equals(l.Type, local.Type, TypeCompareKind.ConsiderEverything2)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10443, 42958, 43269);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 43133, 43166);

                        f_10443_43133_43165(_hoistedLocals, local, local);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 43188, 43221);

                        f_10443_43188_43220(_orderedHoistedLocals, local);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 43243, 43250);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10443, 42958, 43269);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 43698, 43767);

                    f_10443_43698_43766(f_10443_43711_43765(f_10443_43711_43733(pendingCatch), SyntaxKind.TryStatement));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 43785, 43925);

                    var
                    newLocal = f_10443_43800_43924(F, f_10443_43819_43829(local), f_10443_43831_43853(pendingCatch), kind: SynthesizedLocalKind.ExceptionFilterAwaitHoistedExceptionLocal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 43945, 43981);

                    f_10443_43945_43980(
                                    _hoistedLocals, local, newLocal);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 43999, 44035);

                    f_10443_43999_44034(_orderedHoistedLocals, newLocal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 42855, 44050);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>.KeyCollection
                    f_10443_42963_42982(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param)
                    {
                        var return_v = this_param.Keys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 42963, 42982);
                        return return_v;
                    }


                    bool
                    f_10443_42963_43091(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>.KeyCollection
                    source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, bool>
                    predicate)
                    {
                        var return_v = source.Any<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 42963, 43091);
                        return return_v;
                    }


                    int
                    f_10443_43133_43165(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 43133, 43165);
                        return 0;
                    }


                    int
                    f_10443_43188_43220(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 43188, 43220);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10443_43711_43733(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                    this_param)
                    {
                        var return_v = this_param.SyntaxOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 43711, 43733);
                        return return_v;
                    }


                    bool
                    f_10443_43711_43765(Microsoft.CodeAnalysis.SyntaxNode
                    node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind)
                    {
                        var return_v = node.IsKind(kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 43711, 43765);
                        return return_v;
                    }


                    int
                    f_10443_43698_43766(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 43698, 43766);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10443_43819_43829(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 43819, 43829);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10443_43831_43853(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                    this_param)
                    {
                        var return_v = this_param.SyntaxOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 43831, 43853);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10443_43800_43924(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.SynthesizedLocalKind
                    kind)
                    {
                        var return_v = this_param.SynthesizedLocal(type, syntax, kind: kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 43800, 43924);
                        return return_v;
                    }


                    int
                    f_10443_43945_43980(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 43945, 43980);
                        return 0;
                    }


                    int
                    f_10443_43999_44034(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 43999, 44034);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 42855, 44050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 42855, 44050);
                }
            }

            public IEnumerable<LocalSymbol> GetHoistedLocals()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 44066, 44193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 44149, 44178);

                    return _orderedHoistedLocals;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 44066, 44193);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 44066, 44193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 44066, 44193);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryGetHoistedLocal(LocalSymbol originalLocal, out LocalSymbol hoistedLocal)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10443, 44209, 44411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10443, 44329, 44396);

                    return f_10443_44336_44395(_hoistedLocals, originalLocal, out hoistedLocal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10443, 44209, 44411);

                    bool
                    f_10443_44336_44395(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 44336, 44395);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10443, 44209, 44411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 44209, 44411);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AwaitCatchFrame()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10443, 40805, 44422);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10443, 40805, 44422);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 40805, 44422);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10443, 40805, 44422);

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
            f_10443_42249_42266(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            this_param)
            {
                var return_v = this_param.CurrentFunction;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 42249, 42266);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10443_42295_42335(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            this_param, Microsoft.CodeAnalysis.SpecialType
            st)
            {
                var return_v = this_param.SpecialType(st);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 42295, 42335);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
            f_10443_42228_42410(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
            containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, Microsoft.CodeAnalysis.SynthesizedLocalKind
            kind, Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
            syntaxOpt)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind, (Microsoft.CodeAnalysis.SyntaxNode)syntaxOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 42228, 42410);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
            f_10443_42470_42487(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            this_param)
            {
                var return_v = this_param.CurrentFunction;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 42470, 42487);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10443_42516_42555(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            this_param, Microsoft.CodeAnalysis.SpecialType
            st)
            {
                var return_v = this_param.SpecialType(st);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 42516, 42555);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
            f_10443_42449_42620(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
            containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, Microsoft.CodeAnalysis.SynthesizedLocalKind
            kind, Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
            syntaxOpt)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind, (Microsoft.CodeAnalysis.SyntaxNode)syntaxOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 42449, 42620);
                return return_v;
            }


            System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.BoundBlock>
            f_10443_42657_42679()
            {
                var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.BoundBlock>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 42657, 42679);
                return return_v;
            }


            System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
            f_10443_42715_42757()
            {
                var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 42715, 42757);
                return return_v;
            }


            System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
            f_10443_42800_42823()
            {
                var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 42800, 42823);
                return return_v;
            }

        }

        static AsyncExceptionHandlerRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10443, 848, 44429);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10443, 848, 44429);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10443, 848, 44429);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10443, 848, 44429);

        Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame
        f_10443_1275_1298()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncExceptionHandlerRewriter.AwaitFinallyFrame();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 1275, 1298);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        f_10443_1707_1726(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.CurrentType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 1707, 1726);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10443_1747_1778(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10443, 1747, 1778);
            return return_v;
        }


        bool
        f_10443_1689_1817(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        right, Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 1689, 1817);
            return return_v;
        }


        int
        f_10443_1676_1818(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10443, 1676, 1818);
            return 0;
        }

    }
}
