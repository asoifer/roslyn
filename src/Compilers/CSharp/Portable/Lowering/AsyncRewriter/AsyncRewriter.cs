// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class AsyncRewriter : StateMachineRewriter
    {
        private readonly AsyncMethodBuilderMemberCollection _asyncMethodBuilderMemberCollection;

        private readonly bool _constructedSuccessfully;

        private readonly int _methodOrdinal;

        private FieldSymbol _builderField;

        private AsyncRewriter(
                    BoundStatement body,
                    MethodSymbol method,
                    int methodOrdinal,
                    AsyncStateMachine stateMachineType,
                    VariableSlotAllocator slotAllocatorOpt,
                    TypeCompilationState compilationState,
                    DiagnosticBag diagnostics)
        : base(f_10449_1143_1147_C(body), method, stateMachineType, slotAllocatorOpt, compilationState, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10449, 806, 1459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 677, 701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 733, 747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 780, 793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 1248, 1403);

                _constructedSuccessfully = AsyncMethodBuilderMemberCollection.TryCreate(F, method, f_10449_1331_1360(this.stateMachineType), out _asyncMethodBuilderMemberCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 1417, 1448);

                _methodOrdinal = methodOrdinal;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10449, 806, 1459);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 806, 1459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 806, 1459);
            }
        }

        internal static BoundStatement Rewrite(
                    BoundStatement bodyWithAwaitLifted,
                    MethodSymbol method,
                    int methodOrdinal,
                    VariableSlotAllocator slotAllocatorOpt,
                    TypeCompilationState compilationState,
                    DiagnosticBag diagnostics,
                    out AsyncStateMachine stateMachineType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10449, 1582, 4369);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 1959, 2096) || true) && (f_10449_1963_1978_M(!method.IsAsync))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10449, 1959, 2096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 2012, 2036);

                    stateMachineType = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 2054, 2081);

                    return bodyWithAwaitLifted;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10449, 1959, 2096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 2112, 2172);

                CSharpCompilation
                compilation = f_10449_2144_2171(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 2186, 2349);

                bool
                isAsyncEnumerableOrEnumerator = f_10449_2223_2275(method, compilation) || (DynAbs.Tracing.TraceSender.Expression_False(10449, 2223, 2348) || f_10449_2296_2348(method, compilation))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 2363, 2858) || true) && (isAsyncEnumerableOrEnumerator && (DynAbs.Tracing.TraceSender.Expression_True(10449, 2367, 2418) && f_10449_2400_2418_M(!method.IsIterator)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10449, 2363, 2858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 2452, 2522);

                    bool
                    containsAwait = f_10449_2473_2521(bodyWithAwaitLifted)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 2540, 2754);

                    f_10449_2540_2753(diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10449, 2556, 2569) || ((containsAwait && DynAbs.Tracing.TraceSender.Conditional_F2(10449, 2572, 2619)) || DynAbs.Tracing.TraceSender.Conditional_F3(10449, 2622, 2676))) ? ErrorCode.ERR_PossibleAsyncIteratorWithoutYield : ErrorCode.ERR_PossibleAsyncIteratorWithoutYieldOrAwait, f_10449_2699_2715(method)[0], f_10449_2720_2752(method));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 2774, 2798);

                    stateMachineType = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 2816, 2843);

                    return bodyWithAwaitLifted;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10449, 2363, 2858);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 3085, 3217);

                var
                typeKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10449, 3100, 3181) || (((f_10449_3101_3159(f_10449_3101_3137(compilationState.Compilation)) || (DynAbs.Tracing.TraceSender.Expression_False(10449, 3101, 3180) || f_10449_3163_3180(method))) && DynAbs.Tracing.TraceSender.Conditional_F2(10449, 3184, 3198)) || DynAbs.Tracing.TraceSender.Conditional_F3(10449, 3201, 3216))) ? TypeKind.Class : TypeKind.Struct
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 3233, 3343);

                stateMachineType = f_10449_3252_3342(slotAllocatorOpt, compilationState, method, methodOrdinal, typeKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 3357, 3454);

                f_10449_3357_3453(compilationState.ModuleBuilderOpt.CompilationState, method, stateMachineType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 3470, 3829);

                AsyncRewriter
                rewriter = (DynAbs.Tracing.TraceSender.Conditional_F1(10449, 3495, 3524) || ((isAsyncEnumerableOrEnumerator
                && DynAbs.Tracing.TraceSender.Conditional_F2(10449, 3544, 3680)) || DynAbs.Tracing.TraceSender.Conditional_F3(10449, 3700, 3828))) ? f_10449_3544_3680(bodyWithAwaitLifted, method, methodOrdinal, stateMachineType, slotAllocatorOpt, compilationState, diagnostics) : f_10449_3700_3828(bodyWithAwaitLifted, method, methodOrdinal, stateMachineType, slotAllocatorOpt, compilationState, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 3845, 3965) || true) && (!f_10449_3850_3889(rewriter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10449, 3845, 3965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 3923, 3950);

                    return bodyWithAwaitLifted;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10449, 3845, 3965);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 4017, 4043);

                    return f_10449_4024_4042(rewriter);
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10449, 4072, 4358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 4165, 4196);

                    f_10449_4165_4195(diagnostics, f_10449_4181_4194(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 4214, 4343);

                    return f_10449_4221_4342(bodyWithAwaitLifted.Syntax, f_10449_4271_4324(bodyWithAwaitLifted), hasErrors: true);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10449, 4072, 4358);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10449, 1582, 4369);

                bool
                f_10449_1963_1978_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 1963, 1978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10449_2144_2171(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 2144, 2171);
                    return return_v;
                }


                bool
                f_10449_2223_2275(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = method.IsAsyncReturningIAsyncEnumerable(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 2223, 2275);
                    return return_v;
                }


                bool
                f_10449_2296_2348(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = method.IsAsyncReturningIAsyncEnumerator(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 2296, 2348);
                    return return_v;
                }


                bool
                f_10449_2400_2418_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 2400, 2418);
                    return return_v;
                }


                bool
                f_10449_2473_2521(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = AwaitDetector.ContainsAwait((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 2473, 2521);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10449_2699_2715(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 2699, 2715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10449_2720_2752(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 2720, 2752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10449_2540_2753(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 2540, 2753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10449_3101_3137(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 3101, 3137);
                    return return_v;
                }


                bool
                f_10449_3101_3159(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.EnableEditAndContinue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 3101, 3159);
                    return return_v;
                }


                bool
                f_10449_3163_3180(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsIterator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 3163, 3180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AsyncStateMachine
                f_10449_3252_3342(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                variableAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                asyncMethod, int
                asyncMethodOrdinal, Microsoft.CodeAnalysis.TypeKind
                typeKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncStateMachine(variableAllocatorOpt, compilationState, asyncMethod, asyncMethodOrdinal, typeKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 3252, 3342);
                    return return_v;
                }


                int
                f_10449_3357_3453(Microsoft.CodeAnalysis.CSharp.ModuleCompilationState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.AsyncStateMachine
                stateMachineClass)
                {
                    this_param.SetStateMachineType(method, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)stateMachineClass);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 3357, 3453);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                f_10449_3544_3680(Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.AsyncStateMachine
                stateMachineType, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter(body, method, methodOrdinal, stateMachineType, slotAllocatorOpt, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 3544, 3680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AsyncRewriter
                f_10449_3700_3828(Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.AsyncStateMachine
                stateMachineType, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncRewriter(body, method, methodOrdinal, stateMachineType, slotAllocatorOpt, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 3700, 3828);
                    return return_v;
                }


                bool
                f_10449_3850_3889(Microsoft.CodeAnalysis.CSharp.AsyncRewriter
                this_param)
                {
                    var return_v = this_param.VerifyPresenceOfRequiredAPIs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 3850, 3889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10449_4024_4042(Microsoft.CodeAnalysis.CSharp.AsyncRewriter
                this_param)
                {
                    var return_v = this_param.Rewrite();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 4024, 4042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10449_4181_4194(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 4181, 4194);
                    return return_v;
                }


                int
                f_10449_4165_4195(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 4165, 4195);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10449_4271_4324(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create<BoundNode>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 4271, 4324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadStatement
                f_10449_4221_4342(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                childBoundNodes, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadStatement(syntax, childBoundNodes, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 4221, 4342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 1582, 4369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 1582, 4369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool VerifyPresenceOfRequiredAPIs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10449, 4508, 4928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 4578, 4626);

                DiagnosticBag
                bag = f_10449_4598_4625()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 4642, 4676);

                f_10449_4642_4675(this, bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 4692, 4728);

                bool
                hasErrors = f_10449_4709_4727(bag)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 4742, 4830) || true) && (hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10449, 4742, 4830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 4789, 4815);

                    f_10449_4789_4814(diagnostics, bag);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10449, 4742, 4830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 4846, 4857);

                f_10449_4846_4856(
                            bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 4871, 4917);

                return !hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10449, 4878, 4916) && _constructedSuccessfully);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10449, 4508, 4928);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10449_4598_4625()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 4598, 4625);
                    return return_v;
                }


                int
                f_10449_4642_4675(Microsoft.CodeAnalysis.CSharp.AsyncRewriter
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.VerifyPresenceOfRequiredAPIs(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 4642, 4675);
                    return 0;
                }


                bool
                f_10449_4709_4727(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 4709, 4727);
                    return return_v;
                }


                int
                f_10449_4789_4814(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 4789, 4814);
                    return 0;
                }


                int
                f_10449_4846_4856(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 4846, 4856);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 4508, 4928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 4508, 4928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void VerifyPresenceOfRequiredAPIs(DiagnosticBag bag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10449, 4940, 5275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 5035, 5139);

                f_10449_5035_5138(this, WellKnownMember.System_Runtime_CompilerServices_IAsyncStateMachine_MoveNext, bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 5153, 5264);

                f_10449_5153_5263(this, WellKnownMember.System_Runtime_CompilerServices_IAsyncStateMachine_SetStateMachine, bag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10449, 4940, 5275);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10449_5035_5138(Microsoft.CodeAnalysis.CSharp.AsyncRewriter
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    var return_v = this_param.EnsureWellKnownMember(member, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 5035, 5138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10449_5153_5263(Microsoft.CodeAnalysis.CSharp.AsyncRewriter
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    var return_v = this_param.EnsureWellKnownMember(member, bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 5153, 5263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 4940, 5275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 4940, 5275);
            }
        }

        private Symbol EnsureWellKnownMember(WellKnownMember member, DiagnosticBag bag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10449, 5287, 5489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 5391, 5478);

                return f_10449_5398_5477(f_10449_5428_5441(F), member, bag, f_10449_5456_5476(body.Syntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10449, 5287, 5489);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10449_5428_5441(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 5428, 5441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10449_5456_5476(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 5456, 5476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10449_5398_5477(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 5398, 5477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 5287, 5489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 5287, 5489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool PreserveInitialParameterValuesAndThreadId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10449, 5580, 5588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 5583, 5588);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10449, 5580, 5588);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 5580, 5588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 5580, 5588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void GenerateControlFields()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10449, 5601, 6074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 5764, 5908);

                this.stateField = f_10449_5782_5907(F, f_10449_5802_5841(F, SpecialType.System_Int32), f_10449_5843_5890(), isPublic: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 5922, 6063);

                _builderField = f_10449_5938_6062(F, _asyncMethodBuilderMemberCollection.BuilderType, f_10449_6007_6045(), isPublic: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10449, 5601, 6074);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10449_5802_5841(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 5802, 5841);
                    return return_v;
                }


                string
                f_10449_5843_5890()
                {
                    var return_v = GeneratedNames.MakeStateMachineStateFieldName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 5843, 5890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10449_5782_5907(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, bool
                isPublic)
                {
                    var return_v = this_param.StateMachineField((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, isPublic: isPublic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 5782, 5907);
                    return return_v;
                }


                string
                f_10449_6007_6045()
                {
                    var return_v = GeneratedNames.AsyncBuilderFieldName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 6007, 6045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10449_5938_6062(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, bool
                isPublic)
                {
                    var return_v = this_param.StateMachineField((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, isPublic: isPublic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 5938, 6062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 5601, 6074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 5601, 6074);
            }
        }

        protected override void GenerateMethodImplementations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10449, 6086, 8015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 6166, 6295);

                var
                IAsyncStateMachine_MoveNext = f_10449_6200_6294(F, WellKnownMember.System_Runtime_CompilerServices_IAsyncStateMachine_MoveNext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 6309, 6452);

                var
                IAsyncStateMachine_SetStateMachine = f_10449_6350_6451(F, WellKnownMember.System_Runtime_CompilerServices_IAsyncStateMachine_SetStateMachine)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 6520, 6603);

                var
                moveNextMethod = f_10449_6541_6602(this, IAsyncStateMachine_MoveNext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 6619, 6652);

                f_10449_6619_6651(this, moveNextMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 6727, 6891);

                f_10449_6727_6890(this, IAsyncStateMachine_SetStateMachine, "SetStateMachine", hasMethodBodyDependency: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 7263, 7938) || true) && (f_10449_7267_7289(f_10449_7267_7280(F)) == TypeKind.Class)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10449, 7263, 7938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 7341, 7367);

                    f_10449_7341_7366(F, f_10449_7355_7365(F));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10449, 7263, 7938);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10449, 7263, 7938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 7433, 7923);

                    f_10449_7433_7922(F, f_10449_7531_7921(                    // this.builderField.SetStateMachine(sm)
                                        F, f_10449_7565_7883(F, f_10449_7617_7882(F, f_10449_7658_7690(F, f_10449_7666_7674(F), _builderField), _asyncMethodBuilderMemberCollection.SetStateMachine, new BoundExpression[] { f_10449_7835_7879(F, f_10449_7847_7875(f_10449_7847_7864(F))[0]) })), f_10449_7910_7920(F)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10449, 7263, 7938);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 7982, 8004);

                f_10449_7982_8003(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10449, 6086, 8015);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10449_6200_6294(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 6200, 6294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10449_6350_6451(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 6350, 6451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                f_10449_6541_6602(Microsoft.CodeAnalysis.CSharp.AsyncRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodToImplement)
                {
                    var return_v = this_param.OpenMoveNextMethodImplementation(methodToImplement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 6541, 6602);
                    return return_v;
                }


                int
                f_10449_6619_6651(Microsoft.CodeAnalysis.CSharp.AsyncRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                moveNextMethod)
                {
                    this_param.GenerateMoveNext(moveNextMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 6619, 6651);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                f_10449_6727_6890(Microsoft.CodeAnalysis.CSharp.AsyncRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodToImplement, string
                methodName, bool
                hasMethodBodyDependency)
                {
                    var return_v = this_param.OpenMethodImplementation(methodToImplement, methodName, hasMethodBodyDependency: hasMethodBodyDependency);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 6727, 6890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10449_7267_7280(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 7267, 7280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10449_7267_7289(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 7267, 7289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10449_7355_7365(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 7355, 7365);
                    return return_v;
                }


                int
                f_10449_7341_7366(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 7341, 7366);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10449_7666_7674(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 7666, 7674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10449_7658_7690(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 7658, 7690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10449_7847_7864(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 7847, 7864);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10449_7847_7875(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 7847, 7875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10449_7835_7879(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 7835, 7879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10449_7617_7882(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 7617, 7882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10449_7565_7883(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 7565, 7883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10449_7910_7920(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 7910, 7920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10449_7531_7921(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 7531, 7921);
                    return return_v;
                }


                int
                f_10449_7433_7922(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 7433, 7922);
                    return 0;
                }


                int
                f_10449_7982_8003(Microsoft.CodeAnalysis.CSharp.AsyncRewriter
                this_param)
                {
                    this_param.GenerateConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 7982, 8003);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 6086, 8015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 6086, 8015);
            }
        }

        protected virtual void GenerateConstructor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10449, 8027, 8352);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 8096, 8341) || true) && (f_10449_8100_8125(stateMachineType) == TypeKind.Class)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10449, 8096, 8341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 8177, 8226);

                    F.CurrentFunction = f_10449_8197_8225(stateMachineType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 8244, 8326);

                    f_10449_8244_8325(F, f_10449_8258_8324(F, f_10449_8266_8323(f_10449_8288_8310(F), f_10449_8312_8322(F))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10449, 8096, 8341);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10449, 8027, 8352);

                Microsoft.CodeAnalysis.TypeKind
                f_10449_8100_8125(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 8100, 8125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10449_8197_8225(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 8197, 8225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10449_8288_8310(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.BaseInitialization();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 8288, 8310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10449_8312_8322(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 8312, 8322);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10449_8266_8323(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item1, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 8266, 8323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10449_8258_8324(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 8258, 8324);
                    return return_v;
                }


                int
                f_10449_8244_8325(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 8244, 8325);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 8027, 8352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 8027, 8352);
            }
        }

        protected override void InitializeStateMachine(ArrayBuilder<BoundStatement> bodyBuilder, NamedTypeSymbol frameType, LocalSymbol stateMachineLocal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10449, 8364, 8864);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 8535, 8853) || true) && (f_10449_8539_8557(frameType) == TypeKind.Class)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10449, 8535, 8853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 8665, 8838);

                    f_10449_8665_8837(                // local = new {state machine type}();
                                    bodyBuilder, f_10449_8703_8836(F, f_10449_8742_8768(F, stateMachineLocal), f_10449_8795_8835(F, f_10449_8801_8831(frameType)[0])));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10449, 8535, 8853);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10449, 8364, 8864);

                Microsoft.CodeAnalysis.TypeKind
                f_10449_8539_8557(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 8539, 8557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10449_8742_8768(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 8742, 8768);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10449_8801_8831(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 8801, 8831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10449_8795_8835(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.New(ctor, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 8795, 8835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10449_8703_8836(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 8703, 8836);
                    return return_v;
                }


                int
                f_10449_8665_8837(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 8665, 8837);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 8364, 8864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 8364, 8864);
            }
        }

        protected override BoundStatement GenerateStateMachineCreation(LocalSymbol stateMachineVariable, NamedTypeSymbol frameType, IReadOnlyDictionary<Symbol, CapturedSymbolReplacement> proxies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10449, 8876, 11921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 9489, 9570);

                AsyncMethodBuilderMemberCollection
                methodScopeAsyncMethodBuilderMemberCollection
                = default(AsyncMethodBuilderMemberCollection);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 9584, 9839) || true) && (!AsyncMethodBuilderMemberCollection.TryCreate(F, method, null, out methodScopeAsyncMethodBuilderMemberCollection))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10449, 9584, 9839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 9735, 9824);

                    return f_10449_9742_9823(f_10449_9764_9772(F), ImmutableArray<BoundNode>.Empty, hasErrors: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10449, 9584, 9839);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 9855, 9916);

                var
                bodyBuilder = f_10449_9873_9915()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 10040, 10338);

                f_10449_10040_10337(
                            // local.$builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder<typeArgs>.Create();
                            bodyBuilder, f_10449_10074_10336(F, f_10449_10109_10182(F, f_10449_10117_10146(F, stateMachineVariable), f_10449_10148_10181(_builderField, frameType)), f_10449_10205_10335(F, null, methodScopeAsyncMethodBuilderMemberCollection.CreateBuilder)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 10354, 10427);

                f_10449_10354_10426(
                            bodyBuilder, f_10449_10370_10425(this, stateMachineVariable, proxies));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 10502, 10719);

                f_10449_10502_10718(
                            // local.$stateField = NotStartedStateMachine
                            bodyBuilder, f_10449_10536_10717(F, f_10449_10571_10641(F, f_10449_10579_10608(F, stateMachineVariable), f_10449_10610_10640(stateField, frameType)), f_10449_10664_10716(F, StateMachineStates.NotStartedStateMachine)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 10849, 10940);

                var
                startMethod = f_10449_10867_10939(methodScopeAsyncMethodBuilderMemberCollection.Start, frameType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 10954, 11176) || true) && (methodScopeAsyncMethodBuilderMemberCollection.CheckGenericMethodConstraints)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10449, 10954, 11176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 11067, 11161);

                    f_10449_11067_11160(startMethod, f_10449_11096_11121(f_10449_11096_11109(F)), f_10449_11123_11131(F), f_10449_11133_11146(F), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10449, 10954, 11176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 11190, 11512);

                f_10449_11190_11511(bodyBuilder, f_10449_11224_11510(F, f_10449_11268_11509(F, f_10449_11301_11374(F, f_10449_11309_11338(F, stateMachineVariable), f_10449_11340_11373(_builderField, frameType)), startMethod, f_10449_11439_11508(f_10449_11478_11507(F, stateMachineVariable)))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 11528, 11845);

                f_10449_11528_11844(
                            bodyBuilder, (DynAbs.Tracing.TraceSender.Conditional_F1(10449, 11544, 11573) || ((f_10449_11544_11573(method) && DynAbs.Tracing.TraceSender.Conditional_F2(10449, 11593, 11603)) || DynAbs.Tracing.TraceSender.Conditional_F3(10449, 11623, 11843))) ? f_10449_11593_11603(F) : f_10449_11623_11843(F, f_10449_11654_11842(F, f_10449_11691_11764(F, f_10449_11699_11728(F, stateMachineVariable), f_10449_11730_11763(_builderField, frameType)), methodScopeAsyncMethodBuilderMemberCollection.Task)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 11861, 11910);

                return f_10449_11868_11909(F, f_10449_11876_11908(bodyBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10449, 8876, 11921);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10449_9764_9772(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 9764, 9772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadStatement
                f_10449_9742_9823(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                childBoundNodes, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadStatement(syntax, childBoundNodes, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 9742, 9823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10449_9873_9915()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 9873, 9915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10449_10117_10146(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10117, 10146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10449_10148_10181(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10148, 10181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10449_10109_10182(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10109, 10182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10449_10205_10335(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.StaticCall(receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10205, 10335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10449_10074_10336(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10074, 10336);
                    return return_v;
                }


                int
                f_10449_10040_10337(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10040, 10337);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10449_10370_10425(Microsoft.CodeAnalysis.CSharp.AsyncRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                stateMachineVariable, System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                proxies)
                {
                    var return_v = this_param.GenerateParameterStorage(stateMachineVariable, proxies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10370, 10425);
                    return return_v;
                }


                int
                f_10449_10354_10426(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10354, 10426);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10449_10579_10608(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10579, 10608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10449_10610_10640(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10610, 10640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10449_10571_10641(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10571, 10641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10449_10664_10716(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10664, 10716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10449_10536_10717(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10536, 10717);
                    return return_v;
                }


                int
                f_10449_10502_10718(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10502, 10718);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10449_10867_10939(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 10867, 10939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10449_11096_11109(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 11096, 11109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10449_11096_11121(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 11096, 11121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10449_11123_11131(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 11123, 11131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10449_11133_11146(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 11133, 11146);
                    return return_v;
                }


                bool
                f_10449_11067_11160(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = method.CheckConstraints((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, syntaxNode, currentCompilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11067, 11160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10449_11309_11338(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11309, 11338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10449_11340_11373(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11340, 11373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10449_11301_11374(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11301, 11374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10449_11478_11507(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11478, 11507);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10449_11439_11508(Microsoft.CodeAnalysis.CSharp.BoundLocal
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11439, 11508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10449_11268_11509(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11268, 11509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10449_11224_11510(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11224, 11510);
                    return return_v;
                }


                int
                f_10449_11190_11511(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11190, 11511);
                    return 0;
                }


                bool
                f_10449_11544_11573(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsAsyncReturningVoid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11544, 11573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10449_11593_11603(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11593, 11603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10449_11699_11728(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11699, 11728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10449_11730_11763(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11730, 11763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10449_11691_11764(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11691, 11764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10449_11654_11842(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = this_param.Property((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11654, 11842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10449_11623_11843(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Return(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11623, 11843);
                    return return_v;
                }


                int
                f_10449_11528_11844(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11528, 11844);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10449_11876_11908(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11876, 11908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10449_11868_11909(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 11868, 11909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 8876, 11921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 8876, 11921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void GenerateMoveNext(SynthesizedImplementationMethod moveNextMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10449, 11933, 12799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 12045, 12724);

                var
                rewriter = f_10449_12060_12723(method: method, methodOrdinal: _methodOrdinal, asyncMethodBuilderMemberCollection: _asyncMethodBuilderMemberCollection, F: F, state: stateField, builder: _builderField, hoistedVariables: hoistedVariables, nonReusableLocalProxies: nonReusableLocalProxies, synthesizedLocalOrdinals: synthesizedLocalOrdinals, slotAllocatorOpt: slotAllocatorOpt, nextFreeHoistedLocalSlot: nextFreeHoistedLocalSlot, diagnostics: diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 12740, 12788);

                f_10449_12740_12787(
                            rewriter, body, moveNextMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10449, 11933, 12799);

                Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                f_10449_12060_12723(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.AsyncMethodBuilderMemberCollection
                asyncMethodBuilderMemberCollection, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                state, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                builder, Microsoft.CodeAnalysis.Collections.IOrderedReadOnlySet<Microsoft.CodeAnalysis.CSharp.Symbol>
                hoistedVariables, System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                nonReusableLocalProxies, Microsoft.CodeAnalysis.CodeGen.SynthesizedLocalOrdinalsDispenser
                synthesizedLocalOrdinals, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, int
                nextFreeHoistedLocalSlot, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter(method: method, methodOrdinal: methodOrdinal, asyncMethodBuilderMemberCollection: asyncMethodBuilderMemberCollection, F: F, state: state, builder: builder, hoistedVariables: (Roslyn.Utilities.IReadOnlySet<Microsoft.CodeAnalysis.CSharp.Symbol>)hoistedVariables, nonReusableLocalProxies: nonReusableLocalProxies, synthesizedLocalOrdinals: synthesizedLocalOrdinals, slotAllocatorOpt: slotAllocatorOpt, nextFreeHoistedLocalSlot: nextFreeHoistedLocalSlot, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 12060, 12723);
                    return return_v;
                }


                int
                f_10449_12740_12787(Microsoft.CodeAnalysis.CSharp.AsyncMethodToStateMachineRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                moveNextMethod)
                {
                    this_param.GenerateMoveNext(body, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)moveNextMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 12740, 12787);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 11933, 12799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 11933, 12799);
            }
        }
        private class AwaitDetector : BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
        {
            private bool _sawAwait;

            public static bool ContainsAwait(BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10449, 13113, 13327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 13194, 13229);

                    var
                    detector = f_10449_13209_13228()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 13247, 13268);

                    f_10449_13247_13267(detector, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 13286, 13312);

                    return detector._sawAwait;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10449, 13113, 13327);

                    Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AwaitDetector
                    f_10449_13209_13228()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AwaitDetector();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 13209, 13228);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10449_13247_13267(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AwaitDetector
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node)
                    {
                        var return_v = this_param.Visit(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10449, 13247, 13267);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 13113, 13327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 13113, 13327);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitAwaitExpression(BoundAwaitExpression node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10449, 13343, 13511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 13449, 13466);

                    _sawAwait = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 13484, 13496);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10449, 13343, 13511);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10449, 13343, 13511);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 13343, 13511);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AwaitDetector()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10449, 12949, 13522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10449, 13087, 13096);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10449, 12949, 13522);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 12949, 13522);
            }


            static AwaitDetector()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10449, 12949, 13522);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10449, 12949, 13522);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10449, 12949, 13522);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10449, 12949, 13522);
        }

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10449_1331_1360(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
        this_param)
        {
            var return_v = this_param.TypeMap;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10449, 1331, 1360);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.BoundStatement
        f_10449_1143_1147_C(Microsoft.CodeAnalysis.CSharp.BoundStatement
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10449, 806, 1459);
            return return_v;
        }

    }
}
