// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.RuntimeMembers;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class LocalRewriter : BoundTreeRewriterWithStackGuard
    {
        private readonly CSharpCompilation _compilation;

        private readonly SyntheticBoundNodeFactory _factory;

        private readonly SynthesizedSubmissionFields _previousSubmissionFields;

        private readonly bool _allowOmissionOfConditionalCalls;

        private LoweredDynamicOperationFactory _dynamicFactory;

        private bool _sawLambdas;

        private int _availableLocalFunctionOrdinal;

        private bool _inExpressionLambda;

        private bool _sawAwait;

        private bool _sawAwaitInExceptionHandler;

        private bool _needsSpilling;

        private readonly DiagnosticBag _diagnostics;

        private Instrumenter _instrumenter;

        private readonly BoundStatement _rootStatement;

        private Dictionary<BoundValuePlaceholderBase, BoundExpression>? _placeholderReplacementMapDoNotUseDirectly;

        private LocalRewriter(
                    CSharpCompilation compilation,
                    MethodSymbol containingMethod,
                    int containingMethodOrdinal,
                    BoundStatement rootStatement,
                    NamedTypeSymbol? containingType,
                    SyntheticBoundNodeFactory factory,
                    SynthesizedSubmissionFields previousSubmissionFields,
                    bool allowOmissionOfConditionalCalls,
                    DiagnosticBag diagnostics,
                    Instrumenter instrumenter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10473, 1720, 3107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 892, 904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 958, 966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1022, 1047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1080, 1112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1162, 1177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1201, 1212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1235, 1265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1289, 1308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1334, 1343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1367, 1394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1418, 1432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1474, 1486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1518, 1531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1574, 1588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 1665, 1707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10487, 956, 987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10487, 1010, 1037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497, 9115, 9139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 2232, 2259);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 2273, 2292);

                _factory = factory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 2306, 2350);

                _factory.CurrentFunction = containingMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 2364, 2507);

                f_10473_2364_2506(f_10473_2377_2505(f_10473_2395_2414(factory), (containingType ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?>(10473, 2417, 2466) ?? f_10473_2435_2466(containingMethod))), TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 2521, 2608);

                _dynamicFactory = f_10473_2539_2607(factory, containingMethodOrdinal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 2622, 2675);

                _previousSubmissionFields = previousSubmissionFields;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 2689, 2756);

                _allowOmissionOfConditionalCalls = allowOmissionOfConditionalCalls;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 2770, 2797);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 2813, 2848);

                f_10473_2813_2847(instrumenter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 2949, 2998);

                _ = f_10473_2953_2997(instrumenter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 3022, 3051);

                _instrumenter = instrumenter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 3065, 3096);

                _rootStatement = rootStatement;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10473, 1720, 3107);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 1720, 3107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 1720, 3107);
            }
        }

        public static BoundStatement Rewrite(
                    CSharpCompilation compilation,
                    MethodSymbol method,
                    int methodOrdinal,
                    NamedTypeSymbol containingType,
                    BoundStatement statement,
                    TypeCompilationState compilationState,
                    SynthesizedSubmissionFields previousSubmissionFields,
                    bool allowOmissionOfConditionalCalls,
                    bool instrumentForDynamicAnalysis,
                    ref ImmutableArray<SourceSpan> dynamicAnalysisSpans,
                    DebugDocumentProvider debugDocumentProvider,
                    DiagnosticBag diagnostics,
                    out bool sawLambdas,
                    out bool sawLocalFunctions,
                    out bool sawAwaitInExceptionHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 3233, 6711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 3996, 4028);

                f_10473_3996_4027(statement != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 4042, 4081);

                f_10473_4042_4080(compilationState != null);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 4133, 4234);

                    var
                    factory = f_10473_4147_4233(method, statement.Syntax, compilationState, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 4252, 4454);

                    DynamicAnalysisInjector?
                    dynamicInstrumenter = (DynAbs.Tracing.TraceSender.Conditional_F1(10473, 4299, 4327) || ((instrumentForDynamicAnalysis && DynAbs.Tracing.TraceSender.Conditional_F2(10473, 4330, 4446)) || DynAbs.Tracing.TraceSender.Conditional_F3(10473, 4449, 4453))) ? f_10473_4330_4446(method, statement, factory, diagnostics, debugDocumentProvider, Instrumenter.NoOp) : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 4696, 5037);

                    var
                    localRewriter = f_10473_4716_5036(compilation, method, methodOrdinal, statement, containingType, factory, previousSubmissionFields, allowOmissionOfConditionalCalls, diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10473, 4933, 4960) || ((dynamicInstrumenter != null && DynAbs.Tracing.TraceSender.Conditional_F2(10473, 4963, 5005)) || DynAbs.Tracing.TraceSender.Conditional_F3(10473, 5008, 5035))) ? f_10473_4963_5005(dynamicInstrumenter) : DebugInfoInjector.Singleton)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 5057, 5088);

                    f_10473_5057_5087(
                                    statement);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 5106, 5169);

                    var
                    loweredStatement = f_10473_5129_5168(localRewriter, statement)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 5187, 5225);

                    f_10473_5187_5224(loweredStatement is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 5243, 5281);

                    f_10473_5243_5280(loweredStatement);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 5299, 5338);

                    sawLambdas = localRewriter._sawLambdas;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 5356, 5426);

                    sawLocalFunctions = localRewriter._availableLocalFunctionOrdinal != 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 5444, 5515);

                    sawAwaitInExceptionHandler = localRewriter._sawAwaitInExceptionHandler;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 5535, 6013) || true) && (localRewriter._needsSpilling && (DynAbs.Tracing.TraceSender.Expression_True(10473, 5539, 5598) && f_10473_5571_5598_M(!loweredStatement.HasErrors)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 5535, 6013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 5767, 5876);

                        var
                        spilledStatement = f_10473_5790_5875(loweredStatement, method, compilationState, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 5898, 5936);

                        f_10473_5898_5935(spilledStatement);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 5958, 5994);

                        loweredStatement = spilledStatement;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 5535, 6013);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 6033, 6189) || true) && (dynamicInstrumenter != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 6033, 6189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 6106, 6170);

                        dynamicAnalysisSpans = f_10473_6129_6169(dynamicInstrumenter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 6033, 6189);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 6218, 6269);

                    f_10473_6218_6268(loweredStatement);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 6295, 6319);

                    return loweredStatement;
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10473, 6348, 6700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 6441, 6472);

                    f_10473_6441_6471(diagnostics, f_10473_6457_6470(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 6490, 6558);

                    sawLambdas = sawLocalFunctions = sawAwaitInExceptionHandler = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 6576, 6685);

                    return f_10473_6583_6684(statement.Syntax, f_10473_6623_6666(statement), hasErrors: true);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10473, 6348, 6700);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 3233, 6711);

                int
                f_10473_3996_4027(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 3996, 4027);
                    return 0;
                }


                int
                f_10473_4042_4080(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 4042, 4080);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10473_4147_4233(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory(topLevelMethod, node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 4147, 4233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                f_10473_4330_4446(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundStatement
                methodBody, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                methodBodyFactory, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, Microsoft.CodeAnalysis.CSharp.Instrumenter
                previous)
                {
                    var return_v = DynamicAnalysisInjector.TryCreate(method, methodBody, methodBodyFactory, diagnostics, debugDocumentProvider, previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 4330, 4446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DebugInfoInjector
                f_10473_4963_5005(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                previous)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DebugInfoInjector((Microsoft.CodeAnalysis.CSharp.Instrumenter)previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 4963, 5005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalRewriter
                f_10473_4716_5036(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingMethod, int
                containingMethodOrdinal, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rootStatement, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                previousSubmissionFields, bool
                allowOmissionOfConditionalCalls, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DebugInfoInjector
                instrumenter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter(compilation, containingMethod, containingMethodOrdinal, rootStatement, containingType, factory, previousSubmissionFields, allowOmissionOfConditionalCalls, diagnostics, (Microsoft.CodeAnalysis.CSharp.Instrumenter)instrumenter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 4716, 5036);
                    return return_v;
                }


                int
                f_10473_5057_5087(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    this_param.CheckLocalsDefined();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 5057, 5087);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10473_5129_5168(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.VisitStatement(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 5129, 5168);
                    return return_v;
                }


                int
                f_10473_5187_5224(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 5187, 5224);
                    return 0;
                }


                int
                f_10473_5243_5280(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    this_param.CheckLocalsDefined();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 5243, 5280);
                    return 0;
                }


                bool
                f_10473_5571_5598_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 5571, 5598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10473_5790_5875(Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = SpillSequenceSpiller.Rewrite(body, method, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 5790, 5875);
                    return return_v;
                }


                int
                f_10473_5898_5935(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    this_param.CheckLocalsDefined();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 5898, 5935);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                f_10473_6129_6169(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param)
                {
                    var return_v = this_param.DynamicAnalysisSpans;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 6129, 6169);
                    return return_v;
                }


                int
                f_10473_6218_6268(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    LocalRewritingValidator.Validate((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 6218, 6268);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10473_6457_6470(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 6457, 6470);
                    return return_v;
                }


                int
                f_10473_6441_6471(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 6441, 6471);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10473_6623_6666(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create<BoundNode>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 6623, 6666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadStatement
                f_10473_6583_6684(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                childBoundNodes, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadStatement(syntax, childBoundNodes, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 6583, 6684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 3233, 6711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 3233, 6711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool Instrument
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 6771, 6850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 6807, 6835);

                    return !_inExpressionLambda;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 6771, 6850);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 6723, 6861);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 6723, 6861);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PEModuleBuilder? EmitModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 6933, 6991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 6939, 6989);

                    return f_10473_6946_6971(_factory).ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 6933, 6991);

                    Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    f_10473_6946_6971(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.CompilationState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 6946, 6971);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 6873, 7002);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 6873, 7002);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override BoundNode? Visit(BoundNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 7154, 7620);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 7228, 7305) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 7228, 7305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 7278, 7290);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 7228, 7305);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 7319, 7392);

                f_10473_7319_7391(f_10473_7332_7347_M(!node.HasErrors), "nodes with errors should not be lowered");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 7408, 7456);

                BoundExpression?
                expr = node as BoundExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 7470, 7568) || true) && (expr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 7470, 7568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 7520, 7553);

                    return f_10473_7527_7552(this, expr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 7470, 7568);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 7584, 7609);

                return f_10473_7591_7608(node, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 7154, 7620);

                bool
                f_10473_7332_7347_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 7332, 7347);
                    return return_v;
                }


                int
                f_10473_7319_7391(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 7319, 7391);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10473_7527_7552(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionImpl(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 7527, 7552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10473_7591_7608(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param, Microsoft.CodeAnalysis.CSharp.LocalRewriter
                visitor)
                {
                    var return_v = this_param.Accept((Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 7591, 7608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 7154, 7620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 7154, 7620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("node")]
        private BoundExpression? VisitExpression(BoundExpression? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 7632, 8051);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 7764, 7841) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 7764, 7841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 7814, 7826);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 7764, 7841);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 7855, 7928);

                f_10473_7855_7927(f_10473_7868_7883_M(!node.HasErrors), "nodes with errors should not be lowered");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 8006, 8040);

                return f_10473_8013_8038(this, node)!;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 7632, 8051);

                bool
                f_10473_7868_7883_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 7868, 7883);
                    return return_v;
                }


                int
                f_10473_7855_7927(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 7855, 7927);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10473_8013_8038(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionImpl(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 8013, 8038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 7632, 8051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 7632, 8051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement? VisitStatement(BoundStatement? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 8063, 8381);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 8148, 8225) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 8148, 8225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 8198, 8210);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 8148, 8225);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 8239, 8312);

                f_10473_8239_8311(f_10473_8252_8267_M(!node.HasErrors), "nodes with errors should not be lowered");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 8328, 8370);

                return (BoundStatement?)f_10473_8352_8369(node, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 8063, 8381);

                bool
                f_10473_8252_8267_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 8252, 8267);
                    return return_v;
                }


                int
                f_10473_8239_8311(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 8239, 8311);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10473_8352_8369(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param, Microsoft.CodeAnalysis.CSharp.LocalRewriter
                visitor)
                {
                    var return_v = this_param.Accept((Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 8352, 8369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 8063, 8381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 8063, 8381);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression? VisitExpressionImpl(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 8393, 10178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 8484, 8534);

                ConstantValue?
                constantValue = f_10473_8515_8533(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 8548, 8817) || true) && (constantValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 8548, 8817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 8607, 8636);

                    TypeSymbol?
                    type = f_10473_8626_8635(node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 8654, 8802) || true) && (f_10473_8663_8680(type) != true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 8654, 8802);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 8730, 8783);

                        return f_10473_8737_8782(this, node.Syntax, constantValue, type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 8654, 8802);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 8548, 8817);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 8833, 8883);

                var
                visited = f_10473_8847_8882(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 9379, 9708);

                f_10473_9379_9707(visited == null || (DynAbs.Tracing.TraceSender.Expression_False(10473, 9392, 9428) || f_10473_9411_9428(visited)) || (DynAbs.Tracing.TraceSender.Expression_False(10473, 9392, 9472) || f_10473_9432_9472(f_10473_9448_9460(visited), f_10473_9462_9471(node))) || (DynAbs.Tracing.TraceSender.Expression_False(10473, 9392, 9653) || f_10473_9497_9509(visited) is { } && (DynAbs.Tracing.TraceSender.Expression_True(10473, 9497, 9653) && f_10473_9520_9653(f_10473_9520_9532(visited), f_10473_9540_9549(node), TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes))) || (DynAbs.Tracing.TraceSender.Expression_False(10473, 9392, 9706) || f_10473_9678_9706(node)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 9724, 10136) || true) && (visited != null && (DynAbs.Tracing.TraceSender.Expression_True(10473, 9728, 9779) && visited != node) && (DynAbs.Tracing.TraceSender.Expression_True(10473, 9728, 9839) && f_10473_9800_9809(node) != BoundKind.ImplicitReceiver) && (DynAbs.Tracing.TraceSender.Expression_True(10473, 9728, 9917) && f_10473_9860_9869(node) != BoundKind.ObjectOrCollectionValuePlaceholder))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 9724, 10136);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 9951, 10121) || true) && (!f_10473_9956_9984(node) && (DynAbs.Tracing.TraceSender.Expression_True(10473, 9955, 10019) && f_10473_9988_10019(visited)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 9951, 10121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 10061, 10102);

                        visited = f_10473_10071_10101(visited);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 9951, 10121);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 9724, 10136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 10152, 10167);

                return visited;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 8393, 10178);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10473_8515_8533(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 8515, 8533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_8626_8635(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 8626, 8635);
                    return return_v;
                }


                bool?
                f_10473_8663_8680(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type?.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 8663, 8680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_8737_8782(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ConstantValue
                constantValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.MakeLiteral(syntax, constantValue, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 8737, 8782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_8847_8882(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithStackGuard(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 8847, 8882);
                    return return_v;
                }


                bool
                f_10473_9411_9428(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 9411, 9428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_9448_9460(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 9448, 9460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_9462_9471(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 9462, 9471);
                    return return_v;
                }


                bool
                f_10473_9432_9472(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 9432, 9472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_9497_9509(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 9497, 9509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10473_9520_9532(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 9520, 9532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_9540_9549(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 9540, 9549);
                    return return_v;
                }


                bool
                f_10473_9520_9653(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 9520, 9653);
                    return return_v;
                }


                bool
                f_10473_9678_9706(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = IsUnusedDeconstruction(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 9678, 9706);
                    return return_v;
                }


                int
                f_10473_9379_9707(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 9379, 9707);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10473_9800_9809(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 9800, 9809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10473_9860_9869(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 9860, 9869);
                    return return_v;
                }


                bool
                f_10473_9956_9984(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = CanBePassedByReference(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 9956, 9984);
                    return return_v;
                }


                bool
                f_10473_9988_10019(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = CanBePassedByReference(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 9988, 10019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_10071_10101(Microsoft.CodeAnalysis.CSharp.BoundExpression
                visited)
                {
                    var return_v = RefAccessMustMakeCopy(visited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 10071, 10101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 8393, 10178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 8393, 10178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression RefAccessMustMakeCopy(BoundExpression visited)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 10190, 10485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 10292, 10443);

                visited = f_10473_10302_10442(visited.Syntax, visited, type: f_10473_10429_10441(visited));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 10459, 10474);

                return visited;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 10190, 10485);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_10429_10441(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 10429, 10441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                f_10473_10302_10442(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPassByCopy(syntax, expression, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 10302, 10442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 10190, 10485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 10190, 10485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsUnusedDeconstruction(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 10497, 10717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 10586, 10706);

                return f_10473_10593_10602(node) == BoundKind.DeconstructionAssignmentOperator && (DynAbs.Tracing.TraceSender.Expression_True(10473, 10593, 10705) && f_10473_10652_10705_M(!((BoundDeconstructionAssignmentOperator)node).IsUsed));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 10497, 10717);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10473_10593_10602(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 10593, 10602);
                    return return_v;
                }


                bool
                f_10473_10652_10705_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 10652, 10705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 10497, 10717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 10497, 10717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLambda(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 10729, 11226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 10809, 10828);

                _sawLambdas = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 10842, 10879);

                f_10473_10842_10878(this, f_10473_10866_10877(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 10895, 10946);

                var
                oldContainingSymbol = f_10473_10921_10945(_factory)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 10996, 11035);

                    _factory.CurrentFunction = f_10473_11023_11034(node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 11053, 11084);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLambda(node), 10473, 11060, 11082)!;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10473, 11113, 11215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 11153, 11200);

                    _factory.CurrentFunction = oldContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10473, 11113, 11215);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 10729, 11226);

                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10473_10866_10877(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 10866, 10877);
                    return return_v;
                }


                int
                f_10473_10842_10878(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                symbol)
                {
                    this_param.CheckRefReadOnlySymbols((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 10842, 10878);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10473_10921_10945(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 10921, 10945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10473_11023_11034(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 11023, 11034);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 10729, 11226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 10729, 11226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocalFunctionStatement(BoundLocalFunctionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 11238, 14427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 11350, 11410);

                int
                localFunctionOrdinal = _availableLocalFunctionOrdinal++
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 11426, 11458);

                var
                localFunction = f_10473_11446_11457(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 11472, 11511);

                f_10473_11472_11510(this, localFunction);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 11527, 13109) || true) && (f_10473_11531_11556(_factory).ModuleBuilderOpt is { } moduleBuilder)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 11527, 13109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 11628, 11678);

                    var
                    typeParameters = f_10473_11649_11677(localFunction)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 11696, 11887) || true) && (typeParameters.Any(typeParameter => typeParameter.HasUnmanagedTypeConstraint))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 11696, 11887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 11819, 11868);

                        f_10473_11819_11867(moduleBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 11696, 11887);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 11907, 12217) || true) && (f_10473_11911_11982(localFunction, t => t.ContainsNativeInteger()) || (DynAbs.Tracing.TraceSender.Expression_False(10473, 11911, 12105) || typeParameters.Any(t => t.ConstraintTypesNoUseSiteDiagnostics.Any(t => t.ContainsNativeInteger()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 11907, 12217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 12147, 12198);

                        f_10473_12147_12197(moduleBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 11907, 12217);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 12237, 12822) || true) && (f_10473_12241_12322(f_10473_12241_12266(_factory).Compilation, localFunction))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 12237, 12822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 12364, 12548);

                        bool
                        constraintsNeedNullableAttribute = typeParameters.Any(typeParameter => ((SourceTypeParameterSymbolBase)typeParameter).ConstraintsNeedNullableAttribute())
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 12572, 12803) || true) && (constraintsNeedNullableAttribute || (DynAbs.Tracing.TraceSender.Expression_False(10473, 12576, 12684) || f_10473_12612_12684(localFunction, t => t.NeedsNullableAttribute())))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 12572, 12803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 12734, 12780);

                            f_10473_12734_12779(moduleBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 12572, 12803);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 12237, 12822);
                    }

                    bool
                    f_10473_12612_12684(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                    localFunction, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, bool>
                    predicate)
                    {
                        var return_v = hasReturnTypeOrParameter(localFunction, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 12612, 12684);
                        return return_v;
                    }

                    bool
                    f_10473_11911_11982(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                    localFunction, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, bool>
                    predicate)
                    {
                        var return_v = hasReturnTypeOrParameter(localFunction, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 11911, 11982);
                        return return_v;
                    }

                    static bool hasReturnTypeOrParameter(LocalFunctionSymbol localFunction, Func<TypeWithAnnotations, bool> predicate)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 12957, 13093);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 12981, 13093);
                            return f_10473_12981_13031(predicate, f_10473_12991_13030(localFunction)) || (DynAbs.Tracing.TraceSender.Expression_False(10473, 12981, 13093) || localFunction.ParameterTypesWithAnnotations.Any(predicate)); DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 12957, 13093);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 12957, 13093);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 12957, 13093);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 11527, 13109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 13125, 13176);

                var
                oldContainingSymbol = f_10473_13151_13175(_factory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 13190, 13226);

                var
                oldInstrumenter = _instrumenter
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 13240, 13280);

                var
                oldDynamicFactory = _dynamicFactory
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 13330, 13371);

                    _factory.CurrentFunction = localFunction;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 13389, 13566) || true) && (f_10473_13393_13441(localFunction))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 13389, 13566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 13483, 13547);

                        _instrumenter = f_10473_13499_13546(oldInstrumenter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 13389, 13566);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 13586, 14114) || true) && (f_10473_13590_13619(localFunction))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 13586, 14114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 13979, 14095);

                        _dynamicFactory = f_10473_13997_14094(_factory, f_10473_14042_14071(_dynamicFactory), localFunctionOrdinal);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 13586, 14114);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 14134, 14181);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocalFunctionStatement(node), 10473, 14141, 14179)!;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10473, 14210, 14416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 14250, 14297);

                    _factory.CurrentFunction = oldContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 14315, 14347);

                    _instrumenter = oldInstrumenter;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 14365, 14401);

                    _dynamicFactory = oldDynamicFactory;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10473, 14210, 14416);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 11238, 14427);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10473_11446_11457(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 11446, 11457);
                    return return_v;
                }


                int
                f_10473_11472_11510(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol)
                {
                    this_param.CheckRefReadOnlySymbols((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 11472, 11510);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10473_11531_11556(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 11531, 11556);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10473_11649_11677(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 11649, 11677);
                    return return_v;
                }


                int
                f_10473_11819_11867(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    this_param.EnsureIsUnmanagedAttributeExists();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 11819, 11867);
                    return 0;
                }


                


                int
                f_10473_12147_12197(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    this_param.EnsureNativeIntegerAttributeExists();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 12147, 12197);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10473_12241_12266(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 12241, 12266);
                    return return_v;
                }


                bool
                f_10473_12241_12322(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 12241, 12322);
                    return return_v;
                }



                int
                f_10473_12734_12779(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    this_param.EnsureNullableAttributeExists();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 12734, 12779);
                    return 0;
                }


                static Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10473_12991_13030(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 12991, 13030);
                    return return_v;
                }


                static bool
                f_10473_12981_13031(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 12981, 13031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10473_13151_13175(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 13151, 13175);
                    return return_v;
                }


                bool
                f_10473_13393_13441(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.IsDirectlyExcludedFromCodeCoverage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 13393, 13441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10473_13499_13546(Microsoft.CodeAnalysis.CSharp.Instrumenter
                instrumenter)
                {
                    var return_v = RemoveDynamicAnalysisInjectors(instrumenter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 13499, 13546);
                    return return_v;
                }


                bool
                f_10473_13590_13619(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 13590, 13619);
                    return return_v;
                }


                int
                f_10473_14042_14071(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param)
                {
                    var return_v = this_param.MethodOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 14042, 14071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                f_10473_13997_14094(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory, int
                methodOrdinal, int
                localFunctionOrdinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory(factory, methodOrdinal, localFunctionOrdinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 13997, 14094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 11238, 14427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 11238, 14427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Instrumenter RemoveDynamicAnalysisInjectors(Instrumenter instrumenter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 14439, 15908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 14549, 15897);

                switch (instrumenter)
                {

                    case DynamicAnalysisInjector { Previous: var previous }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 14549, 15897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 14681, 14729);

                        return f_10473_14688_14728(previous);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 14549, 15897);

                    case DebugInfoInjector { Previous: var previous } injector:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 14549, 15897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 14828, 14887);

                        var
                        newPrevious = f_10473_14846_14886(previous)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 14909, 15349) || true) && ((object)newPrevious == previous)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 14909, 15349);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 14994, 15010);

                            return injector;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 14909, 15349);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 14909, 15349);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 15060, 15349) || true) && ((object)newPrevious == Instrumenter.NoOp)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 15060, 15349);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 15154, 15189);

                                return DebugInfoInjector.Singleton;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 15060, 15349);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 15060, 15349);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 15287, 15326);

                                return f_10473_15294_15325(previous);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 15060, 15349);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 14909, 15349);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 14549, 15897);

                    case CompoundInstrumenter compound:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 14549, 15897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 15685, 15736);

                        throw f_10473_15691_15735(compound);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 14549, 15897);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 14549, 15897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 15784, 15840);

                        f_10473_15784_15839((object)instrumenter == Instrumenter.NoOp);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 15862, 15882);

                        return instrumenter;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 14549, 15897);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 14439, 15908);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10473_14688_14728(Microsoft.CodeAnalysis.CSharp.Instrumenter
                instrumenter)
                {
                    var return_v = RemoveDynamicAnalysisInjectors(instrumenter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 14688, 14728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10473_14846_14886(Microsoft.CodeAnalysis.CSharp.Instrumenter
                instrumenter)
                {
                    var return_v = RemoveDynamicAnalysisInjectors(instrumenter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 14846, 14886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DebugInfoInjector
                f_10473_15294_15325(Microsoft.CodeAnalysis.CSharp.Instrumenter
                previous)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DebugInfoInjector(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 15294, 15325);
                    return return_v;
                }


                System.Exception
                f_10473_15691_15735(Microsoft.CodeAnalysis.CSharp.CompoundInstrumenter
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 15691, 15735);
                    return return_v;
                }


                int
                f_10473_15784_15839(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 15784, 15839);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 14439, 15908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 14439, 15908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDefaultLiteral(BoundDefaultLiteral node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 15920, 16064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 16016, 16053);

                throw f_10473_16022_16052();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 15920, 16064);

                System.Exception
                f_10473_16022_16052()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 16022, 16052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 15920, 16064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 15920, 16064);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUnconvertedObjectCreationExpression(BoundUnconvertedObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 16076, 16262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 16214, 16251);

                throw f_10473_16220_16250();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 16076, 16262);

                System.Exception
                f_10473_16220_16250()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 16220, 16250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 16076, 16262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 16076, 16262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDeconstructValuePlaceholder(BoundDeconstructValuePlaceholder node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 16274, 16443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 16396, 16432);

                return f_10473_16403_16431(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 16274, 16443);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_16403_16431(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                placeholder)
                {
                    var return_v = this_param.PlaceholderReplacement((Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 16403, 16431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 16274, 16443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 16274, 16443);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitObjectOrCollectionValuePlaceholder(BoundObjectOrCollectionValuePlaceholder node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 16455, 16821);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 16591, 16760) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 16591, 16760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 16733, 16745);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 16591, 16760);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 16774, 16810);

                return f_10473_16781_16809(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 16455, 16821);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_16781_16809(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectOrCollectionValuePlaceholder
                placeholder)
                {
                    var return_v = this_param.PlaceholderReplacement((Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 16781, 16809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 16455, 16821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 16455, 16821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression PlaceholderReplacement(BoundValuePlaceholderBase placeholder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 17107, 17464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 17217, 17281);

                f_10473_17217_17280(_placeholderReplacementMapDoNotUseDirectly is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 17295, 17363);

                var
                value = f_10473_17307_17362(_placeholderReplacementMapDoNotUseDirectly, placeholder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 17377, 17426);

                f_10473_17377_17425(placeholder, value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 17440, 17453);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 17107, 17464);

                int
                f_10473_17217_17280(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 17217, 17280);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_17307_17362(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 17307, 17362);
                    return return_v;
                }


                int
                f_10473_17377_17425(Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase
                placeholder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    AssertPlaceholderReplacement(placeholder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 17377, 17425);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 17107, 17464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 17107, 17464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        private static void AssertPlaceholderReplacement(BoundValuePlaceholderBase placeholder, BoundExpression value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 17476, 17759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 17643, 17748);

                f_10473_17643_17747(f_10473_17656_17666(value) is { } && (DynAbs.Tracing.TraceSender.Expression_True(10473, 17656, 17746) && f_10473_17677_17746(f_10473_17677_17687(value), f_10473_17695_17711(placeholder), TypeCompareKind.AllIgnoreOptions)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 17476, 17759);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_17656_17666(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 17656, 17666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10473_17677_17687(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 17677, 17687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_17695_17711(Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 17695, 17711);
                    return return_v;
                }


                bool
                f_10473_17677_17746(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 17677, 17746);
                    return return_v;
                }


                int
                f_10473_17643_17747(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 17643, 17747);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 17476, 17759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 17476, 17759);
            }
        }

        private void AddPlaceholderReplacement(BoundValuePlaceholderBase placeholder, BoundExpression value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 18039, 18532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 18164, 18213);

                f_10473_18164_18212(placeholder, value);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 18229, 18438) || true) && (_placeholderReplacementMapDoNotUseDirectly is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 18229, 18438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 18317, 18423);

                    _placeholderReplacementMapDoNotUseDirectly = f_10473_18362_18422();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 18229, 18438);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 18454, 18521);

                f_10473_18454_18520(
                            _placeholderReplacementMapDoNotUseDirectly, placeholder, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 18039, 18532);

                int
                f_10473_18164_18212(Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase
                placeholder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    AssertPlaceholderReplacement(placeholder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 18164, 18212);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10473_18362_18422()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 18362, 18422);
                    return return_v;
                }


                int
                f_10473_18454_18520(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase
                key, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 18454, 18520);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 18039, 18532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 18039, 18532);
            }
        }

        private void RemovePlaceholderReplacement(BoundValuePlaceholderBase placeholder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 18740, 19097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 18845, 18878);

                f_10473_18845_18877(placeholder is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 18892, 18956);

                f_10473_18892_18955(_placeholderReplacementMapDoNotUseDirectly is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 18970, 19048);

                bool
                removed = f_10473_18985_19047(_placeholderReplacementMapDoNotUseDirectly, placeholder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 19064, 19086);

                f_10473_19064_19085(removed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 18740, 19097);

                int
                f_10473_18845_18877(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 18845, 18877);
                    return 0;
                }


                int
                f_10473_18892_18955(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 18892, 18955);
                    return 0;
                }


                bool
                f_10473_18985_19047(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 18985, 19047);
                    return return_v;
                }


                int
                f_10473_19064_19085(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 19064, 19085);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 18740, 19097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 18740, 19097);
            }
        }

        public sealed override BoundNode VisitOutDeconstructVarPendingInference(OutDeconstructVarPendingInference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 19109, 19421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 19373, 19410);

                throw f_10473_19379_19409();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 19109, 19421);

                System.Exception
                f_10473_19379_19409()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 19379, 19409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 19109, 19421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 19109, 19421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDeconstructionVariablePendingInference(DeconstructionVariablePendingInference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 19433, 19753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 19705, 19742);

                throw f_10473_19711_19741();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 19433, 19753);

                System.Exception
                f_10473_19711_19741()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 19711, 19741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 19433, 19753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 19433, 19753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBadExpression(BoundBadExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 19765, 20049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 20026, 20038);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 19765, 20049);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 19765, 20049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 19765, 20049);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression BadExpression(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 20061, 20282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 20152, 20183);

                f_10473_20152_20182(f_10473_20165_20174(node) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 20197, 20271);

                return f_10473_20204_20270(node.Syntax, f_10473_20231_20240(node), f_10473_20242_20269(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 20061, 20282);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_20165_20174(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 20165, 20174);
                    return return_v;
                }


                int
                f_10473_20152_20182(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 20152, 20182);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10473_20231_20240(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 20231, 20240);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10473_20242_20269(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 20242, 20269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_20204_20270(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                children)
                {
                    var return_v = BadExpression(syntax, resultType, children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 20204, 20270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 20061, 20282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 20061, 20282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression BadExpression(SyntaxNode syntax, TypeSymbol resultType, BoundExpression child)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 20294, 20510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 20428, 20499);

                return f_10473_20435_20498(syntax, resultType, f_10473_20469_20497(child));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 20294, 20510);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10473_20469_20497(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 20469, 20497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_20435_20498(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                children)
                {
                    var return_v = BadExpression(syntax, resultType, children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 20435, 20498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 20294, 20510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 20294, 20510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression BadExpression(SyntaxNode syntax, TypeSymbol resultType, BoundExpression child1, BoundExpression child2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 20522, 20772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 20681, 20761);

                return f_10473_20688_20760(syntax, resultType, f_10473_20722_20759(child1, child2));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 20522, 20772);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10473_20722_20759(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 20722, 20759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_20688_20760(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                children)
                {
                    var return_v = BadExpression(syntax, resultType, children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 20688, 20760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 20522, 20772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 20522, 20772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression BadExpression(SyntaxNode syntax, TypeSymbol resultType, ImmutableArray<BoundExpression> children)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 20784, 21073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 20937, 21062);

                return f_10473_20944_21061(syntax, LookupResultKind.NotReferencable, ImmutableArray<Symbol?>.Empty, children, resultType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 20784, 21073);

                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10473_20944_21061(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 20944, 21061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 20784, 21073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 20784, 21073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetWellKnownTypeMember<TSymbol>(SyntaxNode? syntax, WellKnownMember member, out TSymbol symbol, bool isOptional = false, Location? location = null) where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 21085, 21554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 21296, 21348);

                f_10473_21296_21347<TSymbol>((syntax != null) ^ (location != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 21364, 21508);

                symbol = (TSymbol)f_10473_21382_21507<TSymbol>(_compilation, member, _diagnostics, syntax: syntax, isOptional: isOptional, location: location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 21522, 21543);

                return symbol is { };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 21085, 21554);

                int
                f_10473_21296_21347<TSymbol>(bool
                condition) where TSymbol : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 21296, 21347);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10473_21382_21507<TSymbol>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode?
                syntax, bool
                isOptional, Microsoft.CodeAnalysis.Location?
                location) where TSymbol : Symbol

                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, diagnostics, syntax: syntax, isOptional: isOptional, location: location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 21382, 21507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 21085, 21554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 21085, 21554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodSymbol UnsafeGetSpecialTypeMethod(SyntaxNode syntax, SpecialMember specialMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 21969, 22185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 22089, 22174);

                return f_10473_22096_22173(syntax, specialMember, _compilation, _diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 21969, 22185);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10473_22096_22173(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SpecialMember
                specialMember, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = UnsafeGetSpecialTypeMethod(syntax, specialMember, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 22096, 22173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 21969, 22185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 21969, 22185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodSymbol UnsafeGetSpecialTypeMethod(SyntaxNode syntax, SpecialMember specialMember, CSharpCompilation compilation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 22634, 23557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 22819, 22839);

                MethodSymbol
                method
                = default(MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 22853, 23546) || true) && (f_10473_22857_22941(syntax, specialMember, compilation, diagnostics, out method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 22853, 23546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 22975, 22989);

                    return method;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 22853, 23546);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 22853, 23546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 23055, 23129);

                    MemberDescriptor
                    descriptor = f_10473_23085_23128(specialMember)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 23147, 23206);

                    SpecialType
                    type = (SpecialType)descriptor.DeclaringTypeId
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 23224, 23289);

                    TypeSymbol
                    container = f_10473_23247_23288(f_10473_23247_23267(compilation), type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 23307, 23450);

                    TypeSymbol
                    returnType = f_10473_23331_23449(compilation: compilation, name: descriptor.Name, errorInfo: null, arity: descriptor.Arity)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 23468, 23531);

                    return f_10473_23475_23530(container, returnType, "Missing");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 22853, 23546);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 22634, 23557);

                bool
                f_10473_22857_22941(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SpecialMember
                specialMember, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = TryGetSpecialTypeMethod(syntax, specialMember, compilation, diagnostics, out method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 22857, 22941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10473_23085_23128(Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = SpecialMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 23085, 23128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10473_23247_23267(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 23247, 23267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10473_23247_23288(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 23247, 23288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10473_23331_23449(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                name, Microsoft.CodeAnalysis.DiagnosticInfo?
                errorInfo, ushort
                arity)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(compilation: compilation, name: name, errorInfo: errorInfo, arity: (int)arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 23331, 23449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol
                f_10473_23475_23530(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol(containingType, returnType, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 23475, 23530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 22634, 23557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 22634, 23557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetSpecialTypeMethod(SyntaxNode syntax, SpecialMember specialMember, out MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 23569, 23808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 23703, 23797);

                return f_10473_23710_23796(syntax, specialMember, _compilation, _diagnostics, out method);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 23569, 23808);

                bool
                f_10473_23710_23796(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SpecialMember
                specialMember, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = TryGetSpecialTypeMethod(syntax, specialMember, compilation, diagnostics, out method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 23710, 23796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 23569, 23808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 23569, 23808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetSpecialTypeMethod(SyntaxNode syntax, SpecialMember specialMember, CSharpCompilation compilation, DiagnosticBag diagnostics, out MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 23820, 24129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 24019, 24118);

                return f_10473_24026_24117(compilation, specialMember, syntax, diagnostics, out method);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 23820, 24129);

                bool
                f_10473_24026_24117(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialMember
                specialMember, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = Binder.TryGetSpecialTypeMember(compilation, specialMember, syntax, diagnostics, out symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 24026, 24117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 23820, 24129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 23820, 24129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTypeOfOperator(BoundTypeOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 24141, 24893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 24237, 24282);

                f_10473_24237_24281(f_10473_24250_24272(node) is null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 24298, 24365);

                var
                sourceType = (BoundTypeExpression?)f_10473_24337_24364(this, f_10473_24348_24363(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 24379, 24411);

                f_10473_24379_24410(sourceType is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 24425, 24462);

                var
                type = f_10473_24436_24461(this, f_10473_24451_24460(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 24517, 24548);

                MethodSymbol
                getTypeFromHandle
                = default(MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 24562, 24810) || true) && (!f_10473_24567_24676(this, node.Syntax, WellKnownMember.System_Type__GetTypeFromHandle, out getTypeFromHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 24562, 24810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 24710, 24795);

                    return f_10473_24717_24794(node.Syntax, sourceType, null, type, hasErrors: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 24562, 24810);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 24826, 24882);

                return f_10473_24833_24881(node, sourceType, getTypeFromHandle, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 24141, 24893);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10473_24250_24272(Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                this_param)
                {
                    var return_v = this_param.GetTypeFromHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 24250, 24272);
                    return return_v;
                }


                int
                f_10473_24237_24281(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 24237, 24281);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10473_24348_24363(Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                this_param)
                {
                    var return_v = this_param.SourceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 24348, 24363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10473_24337_24364(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 24337, 24364);
                    return return_v;
                }


                int
                f_10473_24379_24410(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 24379, 24410);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10473_24451_24460(Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 24451, 24460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_24436_24461(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 24436, 24461);
                    return return_v;
                }


                bool
                f_10473_24567_24676(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.WellKnownMember
                member, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(syntax, member, out symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 24567, 24676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                f_10473_24717_24794(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                getTypeFromHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator(syntax, sourceType, getTypeFromHandle, type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 24717, 24794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                f_10473_24833_24881(Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                getTypeFromHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(sourceType, getTypeFromHandle, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 24833, 24881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 24141, 24893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 24141, 24893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRefTypeOperator(BoundRefTypeOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 24905, 25590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 25003, 25048);

                f_10473_25003_25047(f_10473_25016_25038(node) is null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 25064, 25113);

                var
                operand = f_10473_25078_25112(this, f_10473_25099_25111(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 25127, 25164);

                var
                type = f_10473_25138_25163(this, f_10473_25153_25162(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 25219, 25250);

                MethodSymbol
                getTypeFromHandle
                = default(MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 25264, 25510) || true) && (!f_10473_25269_25378(this, node.Syntax, WellKnownMember.System_Type__GetTypeFromHandle, out getTypeFromHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 25264, 25510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 25412, 25495);

                    return f_10473_25419_25494(node.Syntax, operand, null, type, hasErrors: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 25264, 25510);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 25526, 25579);

                return f_10473_25533_25578(node, operand, getTypeFromHandle, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 24905, 25590);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10473_25016_25038(Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator
                this_param)
                {
                    var return_v = this_param.GetTypeFromHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 25016, 25038);
                    return return_v;
                }


                int
                f_10473_25003_25047(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 25003, 25047);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_25099_25111(Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 25099, 25111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10473_25078_25112(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 25078, 25112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10473_25153_25162(Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 25153, 25162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_25138_25163(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 25138, 25163);
                    return return_v;
                }


                bool
                f_10473_25269_25378(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.WellKnownMember
                member, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(syntax, member, out symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 25269, 25378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator
                f_10473_25419_25494(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                getTypeFromHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator(syntax, operand, getTypeFromHandle, type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 25419, 25494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator
                f_10473_25533_25578(Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                getTypeFromHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand, getTypeFromHandle, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 25533, 25578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 24905, 25590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 24905, 25590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTypeOrInstanceInitializers(BoundTypeOrInstanceInitializers node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 25602, 29226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 25722, 25790);

                ImmutableArray<BoundStatement>
                originalStatements = f_10473_25774_25789(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 25804, 25887);

                var
                statements = f_10473_25821_25886(node.Statements.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 25901, 26922);
                    foreach (var initializer in f_10473_25929_25947_I(originalStatements))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 25901, 26922);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 25981, 26907) || true) && (f_10473_25985_26026(initializer))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 25981, 26907);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 26068, 26762) || true) && (f_10473_26072_26088(initializer) == BoundKind.Block)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 26068, 26762);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 26157, 26193);

                                var
                                block = (BoundBlock)initializer
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 26219, 26346);

                                var
                                statement = f_10473_26235_26345(this, block.Statements.Single(), suppressInstrumentation: true)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 26372, 26403);

                                f_10473_26372_26402(statement is { });
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 26429, 26528);

                                f_10473_26429_26527(statements, f_10473_26444_26526(block, f_10473_26457_26469(block), f_10473_26471_26491(block), f_10473_26493_26525(statement)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 26068, 26762);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 26068, 26762);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 26626, 26739);

                                f_10473_26626_26738(statements, f_10473_26641_26737(this, initializer, suppressInstrumentation: true));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 26068, 26762);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 25981, 26907);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 25981, 26907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 26844, 26888);

                            f_10473_26844_26887(statements, f_10473_26859_26886(this, initializer));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 25981, 26907);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 25901, 26922);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10473, 1, 1022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10473, 1, 1022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 26938, 26968);

                int
                optimizedInitializers = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 26982, 27066);

                bool
                optimize = f_10473_26998_27036(f_10473_26998_27018(_compilation)) == OptimizationLevel.Release
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27091, 27096);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27082, 27692) || true) && (i < f_10473_27102_27118(statements))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27120, 27123)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 27082, 27692))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 27082, 27692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27157, 27182);

                        var
                        stmt = f_10473_27168_27181(statements, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27200, 27677) || true) && (stmt == null || (DynAbs.Tracing.TraceSender.Expression_False(10473, 27204, 27323) || (optimize && (DynAbs.Tracing.TraceSender.Expression_True(10473, 27221, 27284) && f_10473_27233_27284(originalStatements[i])) && (DynAbs.Tracing.TraceSender.Expression_True(10473, 27221, 27322) && f_10473_27288_27322(stmt)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 27200, 27677);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27365, 27389);

                            optimizedInitializers++;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27411, 27658) || true) && (f_10473_27415_27449_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10473_27415_27439(_factory), 10473, 27415, 27449)?.IsStatic) == false)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 27411, 27658);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27614, 27635);

                                statements[i] = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 27411, 27658);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 27200, 27677);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10473, 1, 611);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10473, 1, 611);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27708, 27759);

                ImmutableArray<BoundStatement>
                rewrittenStatements
                = default(ImmutableArray<BoundStatement>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27775, 29119) || true) && (optimizedInitializers == f_10473_27804_27820(statements))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 27775, 29119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27897, 27956);

                    rewrittenStatements = ImmutableArray<BoundStatement>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 27974, 27992);

                    f_10473_27974_27991(statements);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 27775, 29119);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 27775, 29119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28110, 28128);

                    int
                    remaining = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28155, 28160);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28146, 28955) || true) && (i < f_10473_28166_28182(statements))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28184, 28187)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 28146, 28955))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 28146, 28955);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28229, 28271);

                            BoundStatement?
                            rewritten = f_10473_28257_28270(statements, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28295, 28936) || true) && (rewritten != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 28295, 28936);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28366, 28813) || true) && (f_10473_28370_28421(originalStatements[i]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 28366, 28813);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28479, 28527);

                                    BoundStatement
                                    original = originalStatements[i]
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28557, 28786) || true) && (f_10473_28561_28571() && (DynAbs.Tracing.TraceSender.Expression_True(10473, 28561, 28605) && f_10473_28575_28605_M(!original.WasCompilerGenerated)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 28557, 28786);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28671, 28755);

                                        rewritten = f_10473_28683_28754(_instrumenter, original, rewritten);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 28557, 28786);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 28366, 28813);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28841, 28875);

                                statements[remaining] = rewritten;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28901, 28913);

                                remaining++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 28295, 28936);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10473, 1, 810);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10473, 1, 810);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 28975, 29004);

                    statements.Count = remaining;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 29049, 29104);

                    rewrittenStatements = f_10473_29071_29102(statements)!;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 27775, 29119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 29135, 29215);

                return f_10473_29142_29214(node.Syntax, rewrittenStatements, f_10473_29199_29213(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 25602, 29226);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10473_25774_25789(Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 25774, 25789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                f_10473_25821_25886(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundStatement?>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 25821, 25886);
                    return return_v;
                }


                bool
                f_10473_25985_26026(Microsoft.CodeAnalysis.CSharp.BoundStatement
                initializer)
                {
                    var return_v = IsFieldOrPropertyInitializer(initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 25985, 26026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10473_26072_26088(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 26072, 26088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10473_26235_26345(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node, bool
                suppressInstrumentation)
                {
                    var return_v = this_param.RewriteExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement)node, suppressInstrumentation: suppressInstrumentation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 26235, 26345);
                    return return_v;
                }


                int
                f_10473_26372_26402(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 26372, 26402);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10473_26457_26469(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 26457, 26469);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10473_26471_26491(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 26471, 26491);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10473_26493_26525(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 26493, 26525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10473_26444_26526(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                localFunctions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Update(locals, localFunctions, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 26444, 26526);
                    return return_v;
                }


                int
                f_10473_26429_26527(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 26429, 26527);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10473_26641_26737(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node, bool
                suppressInstrumentation)
                {
                    var return_v = this_param.RewriteExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement)node, suppressInstrumentation: suppressInstrumentation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 26641, 26737);
                    return return_v;
                }


                int
                f_10473_26626_26738(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 26626, 26738);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10473_26859_26886(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.VisitStatement(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 26859, 26886);
                    return return_v;
                }


                int
                f_10473_26844_26887(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 26844, 26887);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10473_25929_25947_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 25929, 25947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10473_26998_27018(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 26998, 27018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_10473_26998_27036(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 26998, 27036);
                    return return_v;
                }


                int
                f_10473_27102_27118(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 27102, 27118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10473_27168_27181(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 27168, 27181);
                    return return_v;
                }


                bool
                f_10473_27233_27284(Microsoft.CodeAnalysis.CSharp.BoundStatement
                initializer)
                {
                    var return_v = IsFieldOrPropertyInitializer(initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 27233, 27284);
                    return return_v;
                }


                bool
                f_10473_27288_27322(Microsoft.CodeAnalysis.CSharp.BoundStatement
                initializer)
                {
                    var return_v = ShouldOptimizeOutInitializer(initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 27288, 27322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10473_27415_27439(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 27415, 27439);
                    return return_v;
                }


                bool?
                f_10473_27415_27449_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 27415, 27449);
                    return return_v;
                }


                int
                f_10473_27804_27820(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 27804, 27820);
                    return return_v;
                }


                int
                f_10473_27974_27991(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 27974, 27991);
                    return 0;
                }


                int
                f_10473_28166_28182(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 28166, 28182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10473_28257_28270(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 28257, 28270);
                    return return_v;
                }


                bool
                f_10473_28370_28421(Microsoft.CodeAnalysis.CSharp.BoundStatement
                initializer)
                {
                    var return_v = IsFieldOrPropertyInitializer(initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 28370, 28421);
                    return return_v;
                }


                bool
                f_10473_28561_28571()
                {
                    var return_v = Instrument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 28561, 28571);
                    return return_v;
                }


                bool
                f_10473_28575_28605_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 28575, 28605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10473_28683_28754(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentFieldOrPropertyInitializer(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 28683, 28754);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                f_10473_29071_29102(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 29071, 29102);
                    return return_v;
                }


                bool
                f_10473_29199_29213(Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 29199, 29213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10473_29142_29214(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStatementList(syntax, statements, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 29142, 29214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 25602, 29226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 25602, 29226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayAccess(BoundArrayAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 29238, 32191);
                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator arrayAssign = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 29680, 29793) || true) && (node.Indices.Length != 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 29680, 29793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 29742, 29778);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitArrayAccess(node), 10473, 29749, 29776)!;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 29680, 29793);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 29809, 29857);

                var
                indexType = f_10473_29825_29856(this, f_10473_29835_29855(f_10473_29835_29847(node)[0]))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 29871, 29888);

                var
                F = _factory
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 29904, 29925);

                BoundNode
                resultExpr
                = default(BoundNode);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 29939, 32148) || true) && (f_10473_29943_30118(indexType, f_10473_30007_30064(_compilation, WellKnownType.System_Index), TypeCompareKind.ConsiderEverything))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 29939, 32148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 30367, 30516);

                    var
                    arrayLocal = f_10473_30384_30515(F, f_10473_30420_30452(this, f_10473_30436_30451(node)), out arrayAssign)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 30536, 30706);

                    var
                    indexOffsetExpr = f_10473_30558_30705(this, f_10473_30613_30625(node)[0], f_10473_30651_30676(F, arrayLocal), out _)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 30726, 31032);

                    resultExpr = f_10473_30739_31031(F, f_10473_30772_30817(f_10473_30794_30816(arrayLocal)), f_10473_30840_30891(arrayAssign), f_10473_30914_31030(F, arrayLocal, f_10473_30991_31029(indexOffsetExpr)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 29939, 32148);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 29939, 32148);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 31066, 32148) || true) && (f_10473_31070_31245(indexType, f_10473_31134_31191(_compilation, WellKnownType.System_Range), TypeCompareKind.ConsiderEverything))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 31066, 32148);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 31423, 31490);

                        f_10473_31423_31489(f_10473_31436_31456(f_10473_31436_31451(node)) is { TypeKind: TypeKind.Array });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 31508, 31593);

                        var
                        elementType = f_10473_31526_31592(((ArrayTypeSymbol)f_10473_31544_31564(f_10473_31544_31559(node))))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 31613, 32025);

                        resultExpr = f_10473_31626_32024(F, receiver: null, f_10473_31692_31860(f_10473_31692_31788(F, WellKnownMember.System_Runtime_CompilerServices_RuntimeHelpers__GetSubArray_T), f_10473_31825_31859(elementType)), f_10473_31883_32023(f_10473_31931_31963(this, f_10473_31947_31962(node)), f_10473_31990_32022(this, f_10473_32006_32018(node)[0])));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 31066, 32148);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 31066, 32148);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 32091, 32133);

                        resultExpr = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitArrayAccess(node), 10473, 32104, 32131)!;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 31066, 32148);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 29939, 32148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 32162, 32180);

                return resultExpr;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 29238, 32191);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10473_29835_29847(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 29835, 29847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_29835_29855(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 29835, 29855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_29825_29856(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 29825, 29856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10473_30007_30064(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 30007, 30064);
                    return return_v;
                }


                bool
                f_10473_29943_30118(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 29943, 30118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_30436_30451(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 30436, 30451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10473_30420_30452(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 30420, 30452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10473_30384_30515(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                store)
                {
                    var return_v = this_param.StoreToTemp(argument, out store);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 30384, 30515);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10473_30613_30625(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 30613, 30625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                f_10473_30651_30676(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                array)
                {
                    var return_v = this_param.ArrayLength((Microsoft.CodeAnalysis.CSharp.BoundExpression)array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 30651, 30676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_30558_30705(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                unloweredExpr, Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                lengthAccess, out bool
                usedLength)
                {
                    var return_v = this_param.MakePatternIndexOffsetExpression(unloweredExpr, (Microsoft.CodeAnalysis.CSharp.BoundExpression)lengthAccess, out usedLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 30558, 30705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10473_30794_30816(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 30794, 30816);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10473_30772_30817(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 30772, 30817);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10473_30840_30891(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 30840, 30891);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10473_30991_31029(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 30991, 31029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                f_10473_30914_31030(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                array, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices)
                {
                    var return_v = this_param.ArrayAccess((Microsoft.CodeAnalysis.CSharp.BoundExpression)array, indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 30914, 31030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_30739_31031(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                result)
                {
                    var return_v = this_param.Sequence(locals, sideEffects, (Microsoft.CodeAnalysis.CSharp.BoundExpression)result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 30739, 31031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10473_31134_31191(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 31134, 31191);
                    return return_v;
                }


                bool
                f_10473_31070_31245(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 31070, 31245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_31436_31451(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 31436, 31451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10473_31436_31456(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 31436, 31456);
                    return return_v;
                }


                int
                f_10473_31423_31489(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 31423, 31489);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_31544_31559(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 31544, 31559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10473_31544_31564(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 31544, 31564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10473_31526_31592(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 31526, 31592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10473_31692_31788(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 31692, 31788);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10473_31825_31859(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 31825, 31859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10473_31692_31860(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 31692, 31860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_31947_31962(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 31947, 31962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10473_31931_31963(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 31931, 31963);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10473_32006_32018(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 32006, 32018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10473_31990_32022(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 31990, 32022);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10473_31883_32023(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 31883, 32023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10473_31626_32024(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.Call(receiver: receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 31626, 32024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 29238, 32191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 29238, 32191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsFieldOrPropertyInitializer(BoundStatement initializer)
        {
            var syntax = initializer.Syntax;

            if (syntax.IsKind(SyntaxKind.Parameter))
            {
                // This is an initialization of a generated property based on record parameter.
                return true;
            }

            if (syntax is ExpressionSyntax { Parent: { } parent } && parent.Kind() == SyntaxKind.EqualsValueClause) // Should be the initial value.
            {
                Debug.Assert(parent.Parent is { });
                switch (parent.Parent.Kind())
                {
                    case SyntaxKind.VariableDeclarator:
                    case SyntaxKind.PropertyDeclaration:

                        switch (initializer.Kind)
                        {
                            case BoundKind.Block:
                                var block = (BoundBlock)initializer;
                                if (block.Statements.Length == 1)
                                {
                                    initializer = (BoundStatement)block.Statements.First();
                                    if (initializer.Kind == BoundKind.ExpressionStatement)
                                    {
                                        goto case BoundKind.ExpressionStatement;
                                    }
                                }
                                break;

                            case BoundKind.ExpressionStatement:
                                return ((BoundExpressionStatement)initializer).Expression.Kind == BoundKind.AssignmentOperator;

                        }
                        break;
                }
            }

            return false;
        }

        private static bool ShouldOptimizeOutInitializer(BoundStatement initializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 34161, 35061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 34262, 34301);

                BoundStatement
                statement = initializer
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 34317, 34430) || true) && (f_10473_34321_34335(statement) != BoundKind.ExpressionStatement)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 34317, 34430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 34402, 34415);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 34317, 34430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 34446, 34560);

                BoundAssignmentOperator?
                assignment = f_10473_34484_34532(((BoundExpressionStatement)statement)) as BoundAssignmentOperator
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 34574, 34658) || true) && (assignment == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 34574, 34658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 34630, 34643);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 34574, 34658);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 34674, 34734);

                f_10473_34674_34733(f_10473_34687_34707(f_10473_34687_34702(assignment)) == BoundKind.FieldAccess);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 34750, 34813);

                var
                lhsField = f_10473_34765_34812(((BoundFieldAccess)f_10473_34784_34799(assignment)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 34827, 34953) || true) && (f_10473_34831_34849_M(!lhsField.IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10473, 34831, 34891) && f_10473_34853_34891(f_10473_34853_34876(lhsField))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 34827, 34953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 34925, 34938);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 34827, 34953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 34969, 35008);

                BoundExpression
                rhs = f_10473_34991_35007(assignment)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 35022, 35050);

                return f_10473_35029_35049(rhs);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 34161, 35061);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10473_34321_34335(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 34321, 34335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_34484_34532(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 34484, 34532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_34687_34702(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 34687, 34702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10473_34687_34707(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 34687, 34707);
                    return return_v;
                }


                int
                f_10473_34674_34733(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 34674, 34733);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_34784_34799(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 34784, 34799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10473_34765_34812(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 34765, 34812);
                    return return_v;
                }


                bool
                f_10473_34831_34849_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 34831, 34849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10473_34853_34876(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 34853, 34876);
                    return return_v;
                }


                bool
                f_10473_34853_34891(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 34853, 34891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_34991_35007(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 34991, 35007);
                    return return_v;
                }


                bool
                f_10473_35029_35049(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 35029, 35049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 34161, 35061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 34161, 35061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CanBePassedByReference(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 38175, 41465);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 38265, 38357) || true) && (f_10473_38269_38287(expr) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38265, 38357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 38329, 38342);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38265, 38357);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 38373, 41425);

                switch (f_10473_38381_38390(expr))
                {

                    case BoundKind.Parameter:
                    case BoundKind.Local:
                    case BoundKind.ArrayAccess:
                    case BoundKind.ThisReference:
                    case BoundKind.PointerIndirectionOperator:
                    case BoundKind.PointerElementAccess:
                    case BoundKind.RefValueOperator:
                    case BoundKind.PseudoVariable:
                    case BoundKind.DiscardExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38373, 41425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 38865, 38877);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38373, 41425);

                    case BoundKind.DeconstructValuePlaceholder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38373, 41425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39181, 39193);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38373, 41425);

                    case BoundKind.EventAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38373, 41425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39262, 39303);

                        var
                        eventAccess = (BoundEventAccess)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39325, 39662) || true) && (f_10473_39329_39356(eventAccess))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 39325, 39662);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39406, 39485) || true) && (f_10473_39410_39442(f_10473_39410_39433(eventAccess)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 39406, 39485);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39473, 39485);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 39406, 39485);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39513, 39558);

                            f_10473_39513_39557(f_10473_39526_39549(eventAccess) is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39584, 39639);

                            return f_10473_39591_39638(f_10473_39614_39637(eventAccess));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 39325, 39662);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39686, 39699);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38373, 41425);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38373, 41425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39768, 39809);

                        var
                        fieldAccess = (BoundFieldAccess)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39831, 40067) || true) && (f_10473_39835_39868_M(!f_10473_39836_39859(fieldAccess).IsStatic))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 39831, 40067);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39918, 39963);

                            f_10473_39918_39962(f_10473_39931_39954(fieldAccess) is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 39989, 40044);

                            return f_10473_39996_40043(f_10473_40019_40042(fieldAccess));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 39831, 40067);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 40091, 40103);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38373, 41425);

                    case BoundKind.Sequence:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38373, 41425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 40169, 40228);

                        return f_10473_40176_40227(f_10473_40199_40226(((BoundSequence)expr)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38373, 41425);

                    case BoundKind.AssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38373, 41425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 40304, 40349);

                        return f_10473_40311_40348(((BoundAssignmentOperator)expr));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38373, 41425);

                    case BoundKind.ConditionalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38373, 41425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 40426, 40472);

                        return f_10473_40433_40471(((BoundConditionalOperator)expr));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38373, 41425);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38373, 41425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 40534, 40590);

                        return f_10473_40541_40573(f_10473_40541_40565(((BoundCall)expr))) != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38373, 41425);

                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38373, 41425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 40662, 40736);

                        return f_10473_40669_40719(f_10473_40669_40711(((BoundPropertyAccess)expr))) != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38373, 41425);

                    case BoundKind.IndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38373, 41425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 40807, 40873);

                        return f_10473_40814_40856(f_10473_40814_40848(((BoundIndexerAccess)expr))) != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38373, 41425);

                    case BoundKind.IndexOrRangePatternIndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 38373, 41425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 40963, 41028);

                        var
                        patternIndexer = (BoundIndexOrRangePatternIndexerAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 41050, 41357);

                        var
                        refKind = f_10473_41064_41092(patternIndexer) switch
                        {
                            PropertySymbol p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 41148, 41177) && DynAbs.Tracing.TraceSender.Expression_True(10473, 41148, 41177))
=> f_10473_41168_41177(p),
                            MethodSymbol m when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 41204, 41231) && DynAbs.Tracing.TraceSender.Expression_True(10473, 41204, 41231))
=> f_10473_41222_41231(m),
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 41258, 41333) && DynAbs.Tracing.TraceSender.Expression_True(10473, 41258, 41333))
=> throw f_10473_41269_41333(f_10473_41304_41332(patternIndexer))
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 41379, 41410);

                        return refKind != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 38373, 41425);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 41441, 41454);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 38175, 41465);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10473_38269_38287(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 38269, 38287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10473_38381_38390(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 38381, 38390);
                    return return_v;
                }


                bool
                f_10473_39329_39356(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.IsUsableAsField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 39329, 39356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10473_39410_39433(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 39410, 39433);
                    return return_v;
                }


                bool
                f_10473_39410_39442(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 39410, 39442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10473_39526_39549(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 39526, 39549);
                    return return_v;
                }


                int
                f_10473_39513_39557(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 39513, 39557);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_39614_39637(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 39614, 39637);
                    return return_v;
                }


                bool
                f_10473_39591_39638(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = CanBePassedByReference(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 39591, 39638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10473_39836_39859(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 39836, 39859);
                    return return_v;
                }


                bool
                f_10473_39835_39868_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 39835, 39868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10473_39931_39954(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 39931, 39954);
                    return return_v;
                }


                int
                f_10473_39918_39962(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 39918, 39962);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_40019_40042(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 40019, 40042);
                    return return_v;
                }


                bool
                f_10473_39996_40043(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = CanBePassedByReference(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 39996, 40043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10473_40199_40226(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 40199, 40226);
                    return return_v;
                }


                bool
                f_10473_40176_40227(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = CanBePassedByReference(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 40176, 40227);
                    return return_v;
                }


                bool
                f_10473_40311_40348(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 40311, 40348);
                    return return_v;
                }


                bool
                f_10473_40433_40471(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 40433, 40471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10473_40541_40565(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 40541, 40565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10473_40541_40573(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 40541, 40573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10473_40669_40711(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 40669, 40711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10473_40669_40719(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 40669, 40719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10473_40814_40848(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 40814, 40848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10473_40814_40856(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 40814, 40856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10473_41064_41092(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 41064, 41092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10473_41168_41177(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 41168, 41177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10473_41222_41231(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 41222, 41231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10473_41304_41332(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 41304, 41332);
                    return return_v;
                }


                System.Exception
                f_10473_41269_41333(Microsoft.CodeAnalysis.CSharp.Symbol
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 41269, 41333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 38175, 41465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 38175, 41465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckRefReadOnlySymbols(MethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 41477, 41800);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 41559, 41789) || true) && (f_10473_41563_41590(symbol) || (DynAbs.Tracing.TraceSender.Expression_False(10473, 41563, 41662) || symbol.Parameters.Any(p => p.RefKind == RefKind.In)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10473, 41559, 41789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 41696, 41774);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10473_41696_41721(_factory).ModuleBuilderOpt, 10473, 41696, 41773).EnsureIsReadOnlyAttributeExists(), 10473, 41739, 41773);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10473, 41559, 41789);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 41477, 41800);

                bool
                f_10473_41563_41590(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsByRefReadonly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 41563, 41590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10473_41696_41721(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 41696, 41721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 41477, 41800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 41477, 41800);
            }
        }
        private sealed class LocalRewritingValidator : BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
        {
            public static void Validate(BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10473, 42234, 42632);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 42354, 42396);

                        f_10473_42354_42395(f_10473_42354_42383(), node);
                    }
                    catch (InsufficientExecutionStackException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10473, 42433, 42617);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10473, 42433, 42617);
                        // Intentionally ignored to let the overflow get caught in a more crucial visitor
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10473, 42234, 42632);

                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.LocalRewritingValidator
                    f_10473_42354_42383()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.LocalRewritingValidator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 42354, 42383);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10473_42354_42395(Microsoft.CodeAnalysis.CSharp.LocalRewriter.LocalRewritingValidator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node)
                    {
                        var return_v = this_param.Visit(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 42354, 42395);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 42234, 42632);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 42234, 42632);
                }
            }

            public override BoundNode? VisitDefaultLiteral(BoundDefaultLiteral node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 42648, 42809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 42753, 42764);

                    f_10473_42753_42763(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 42782, 42794);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 42648, 42809);

                    int
                    f_10473_42753_42763(Microsoft.CodeAnalysis.CSharp.LocalRewriter.LocalRewritingValidator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDefaultLiteral
                    node)
                    {
                        this_param.Fail((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 42753, 42763);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 42648, 42809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 42648, 42809);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitUsingStatement(BoundUsingStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 42825, 42986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 42930, 42941);

                    f_10473_42930_42940(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 42959, 42971);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 42825, 42986);

                    int
                    f_10473_42930_42940(Microsoft.CodeAnalysis.CSharp.LocalRewriter.LocalRewritingValidator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                    node)
                    {
                        this_param.Fail((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 42930, 42940);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 42825, 42986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 42825, 42986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitIfStatement(BoundIfStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 43002, 43157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 43101, 43112);

                    f_10473_43101_43111(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 43130, 43142);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 43002, 43157);

                    int
                    f_10473_43101_43111(Microsoft.CodeAnalysis.CSharp.LocalRewriter.LocalRewritingValidator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundIfStatement
                    node)
                    {
                        this_param.Fail((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 43101, 43111);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 43002, 43157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 43002, 43157);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitDeconstructionVariablePendingInference(DeconstructionVariablePendingInference node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 43173, 43377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 43321, 43332);

                    f_10473_43321_43331(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 43350, 43362);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 43173, 43377);

                    int
                    f_10473_43321_43331(Microsoft.CodeAnalysis.CSharp.LocalRewriter.LocalRewritingValidator
                    this_param, Microsoft.CodeAnalysis.CSharp.DeconstructionVariablePendingInference
                    node)
                    {
                        this_param.Fail((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 43321, 43331);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 43173, 43377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 43173, 43377);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitDeconstructValuePlaceholder(BoundDeconstructValuePlaceholder node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 43393, 43580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 43524, 43535);

                    f_10473_43524_43534(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 43553, 43565);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 43393, 43580);

                    int
                    f_10473_43524_43534(Microsoft.CodeAnalysis.CSharp.LocalRewriter.LocalRewritingValidator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                    node)
                    {
                        this_param.Fail((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 43524, 43534);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 43393, 43580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 43393, 43580);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitDisposableValuePlaceholder(BoundDisposableValuePlaceholder node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 43596, 43781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 43725, 43736);

                    f_10473_43725_43735(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 43754, 43766);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 43596, 43781);

                    int
                    f_10473_43725_43735(Microsoft.CodeAnalysis.CSharp.LocalRewriter.LocalRewritingValidator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDisposableValuePlaceholder
                    node)
                    {
                        this_param.Fail((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 43725, 43735);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 43596, 43781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 43596, 43781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void Fail(BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10473, 43797, 43974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10473, 43863, 43959);

                    f_10473_43863_43958(false, $"Bound nodes of kind {f_10473_43906_43915(node)} should not survive past local rewriting");
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10473, 43797, 43974);

                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10473_43906_43915(Microsoft.CodeAnalysis.CSharp.BoundNode
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 43906, 43915);
                        return return_v;
                    }


                    int
                    f_10473_43863_43958(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 43863, 43958);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10473, 43797, 43974);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 43797, 43974);
                }
            }

            public LocalRewritingValidator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10473, 41961, 43985);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10473, 41961, 43985);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 41961, 43985);
            }


            static LocalRewritingValidator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10473, 41961, 43985);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10473, 41961, 43985);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 41961, 43985);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10473, 41961, 43985);
        }

        static LocalRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10473, 763, 44000);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10473, 763, 44000);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10473, 763, 44000);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10473, 763, 44000);

        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        f_10473_2395_2414(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.CurrentType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 2395, 2414);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10473_2435_2466(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10473, 2435, 2466);
            return return_v;
        }


        bool
        f_10473_2377_2505(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        right, Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 2377, 2505);
            return return_v;
        }


        int
        f_10473_2364_2506(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 2364, 2506);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
        f_10473_2539_2607(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        factory, int
        methodOrdinal)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory(factory, methodOrdinal);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 2539, 2607);
            return return_v;
        }


        int
        f_10473_2813_2847(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 2813, 2847);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Instrumenter
        f_10473_2953_2997(Microsoft.CodeAnalysis.CSharp.Instrumenter
        instrumenter)
        {
            var return_v = RemoveDynamicAnalysisInjectors(instrumenter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10473, 2953, 2997);
            return return_v;
        }

    }
}
