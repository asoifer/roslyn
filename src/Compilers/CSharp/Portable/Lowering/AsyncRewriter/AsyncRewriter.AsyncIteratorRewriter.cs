// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class AsyncRewriter : StateMachineRewriter
    {
        private sealed class AsyncIteratorRewriter : AsyncRewriter
        {
            private FieldSymbol _promiseOfValueOrEndField;

            private FieldSymbol _currentField;

            private FieldSymbol _disposeModeField;

            private FieldSymbol _combinedTokensField;

            private readonly bool _isEnumerable;

            internal AsyncIteratorRewriter(
                            BoundStatement body,
                            MethodSymbol method,
                            int methodOrdinal,
                            AsyncStateMachine stateMachineType,
                            VariableSlotAllocator slotAllocatorOpt,
                            TypeCompilationState compilationState,
                            DiagnosticBag diagnostics)
            : base(f_10448_1926_1930_C(body), method, methodOrdinal, stateMachineType, slotAllocatorOpt, compilationState, diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10448, 1548, 2416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 898, 923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 1011, 1024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 1095, 1112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 1283, 1303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 1518, 1531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 2054, 2178);

                    f_10448_2054_2177(!f_10448_2068_2176(method.IteratorElementTypeWithAnnotations.Type, null, TypeCompareKind.ConsiderEverything2));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 2198, 2283);

                    _isEnumerable = f_10448_2214_2282(method, f_10448_2254_2281(method));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 2301, 2401);

                    f_10448_2301_2400(_isEnumerable != f_10448_2331_2399(method, f_10448_2371_2398(method)));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10448, 1548, 2416);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 1548, 2416);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 1548, 2416);
                }
            }

            protected override void VerifyPresenceOfRequiredAPIs(DiagnosticBag bag)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 2432, 5647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 2536, 2575);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VerifyPresenceOfRequiredAPIs(bag), 10448, 2536, 2574);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 2595, 3254) || true) && (_isEnumerable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10448, 2595, 3254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 2654, 2764);

                        f_10448_2654_2763(this, WellKnownMember.System_Collections_Generic_IAsyncEnumerable_T__GetAsyncEnumerator, bag);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 2786, 2873);

                        f_10448_2786_2872(this, WellKnownMember.System_Threading_CancellationToken__Equals, bag);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 2895, 3005);

                        f_10448_2895_3004(this, WellKnownMember.System_Threading_CancellationTokenSource__CreateLinkedTokenSource, bag);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 3027, 3119);

                        f_10448_3027_3118(this, WellKnownMember.System_Threading_CancellationTokenSource__Token, bag);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 3141, 3235);

                        f_10448_3141_3234(this, WellKnownMember.System_Threading_CancellationTokenSource__Dispose, bag);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10448, 2595, 3254);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 3274, 3379);

                    f_10448_3274_3378(this, WellKnownMember.System_Collections_Generic_IAsyncEnumerator_T__MoveNextAsync, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 3397, 3500);

                    f_10448_3397_3499(this, WellKnownMember.System_Collections_Generic_IAsyncEnumerator_T__get_Current, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 3520, 3602);

                    f_10448_3520_3601(this, WellKnownMember.System_IAsyncDisposable__DisposeAsync, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 3620, 3719);

                    f_10448_3620_3718(this, WellKnownMember.System_Threading_Tasks_ValueTask_T__ctorSourceAndToken, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 3737, 3827);

                    f_10448_3737_3826(this, WellKnownMember.System_Threading_Tasks_ValueTask_T__ctorValue, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 3845, 3928);

                    f_10448_3845_3927(this, WellKnownMember.System_Threading_Tasks_ValueTask__ctor, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 3948, 4067);

                    f_10448_3948_4066(this, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__GetResult, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 4085, 4204);

                    f_10448_4085_4203(this, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__GetStatus, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 4222, 4343);

                    f_10448_4222_4342(this, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__get_Version, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 4361, 4482);

                    f_10448_4361_4481(this, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__OnCompleted, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 4500, 4615);

                    f_10448_4500_4614(this, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__Reset, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 4633, 4755);

                    f_10448_4633_4754(this, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__SetException, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 4773, 4892);

                    f_10448_4773_4891(this, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__SetResult, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 4912, 5017);

                    f_10448_4912_5016(this, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource_T__GetResult, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 5035, 5140);

                    f_10448_5035_5139(this, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource_T__GetStatus, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 5158, 5265);

                    f_10448_5158_5264(this, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource_T__OnCompleted, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 5285, 5388);

                    f_10448_5285_5387(this, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource__GetResult, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 5406, 5509);

                    f_10448_5406_5508(this, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource__GetStatus, bag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 5527, 5632);

                    f_10448_5527_5631(this, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource__OnCompleted, bag);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 2432, 5647);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_2654_2763(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 2654, 2763);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_2786_2872(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 2786, 2872);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_2895_3004(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 2895, 3004);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_3027_3118(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 3027, 3118);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_3141_3234(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 3141, 3234);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_3274_3378(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 3274, 3378);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_3397_3499(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 3397, 3499);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_3520_3601(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 3520, 3601);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_3620_3718(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 3620, 3718);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_3737_3826(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 3737, 3826);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_3845_3927(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 3845, 3927);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_3948_4066(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 3948, 4066);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_4085_4203(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 4085, 4203);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_4222_4342(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 4222, 4342);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_4361_4481(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 4361, 4481);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_4500_4614(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 4500, 4614);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_4633_4754(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 4633, 4754);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_4773_4891(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 4773, 4891);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_4912_5016(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 4912, 5016);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_5035_5139(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 5035, 5139);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_5158_5264(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 5158, 5264);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_5285_5387(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 5285, 5387);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_5406_5508(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 5406, 5508);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_5527_5631(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        var return_v = this_param.EnsureWellKnownMember(member, bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 5527, 5631);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 2432, 5647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 2432, 5647);
                }
            }

            protected override void GenerateMethodImplementations()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 5663, 6855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 5814, 5851);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GenerateMethodImplementations(), 10448, 5814, 5850);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 5871, 6050) || true) && (_isEnumerable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10448, 5871, 6050);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 5971, 6031);

                        f_10448_5971_6030(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10448, 5871, 6050);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 6107, 6162);

                    f_10448_6107_6161(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 6180, 6229);

                    f_10448_6180_6228(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 6292, 6347);

                    f_10448_6292_6346(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 6365, 6420);

                    f_10448_6365_6419(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 6438, 6495);

                    f_10448_6438_6494(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 6552, 6603);

                    f_10448_6552_6602(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 6621, 6672);

                    f_10448_6621_6671(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 6690, 6743);

                    f_10448_6690_6742(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 6800, 6840);

                    f_10448_6800_6839(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 5663, 6855);

                    int
                    f_10448_5971_6030(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        this_param.GenerateIAsyncEnumerableImplementation_GetAsyncEnumerator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 5971, 6030);
                        return 0;
                    }


                    int
                    f_10448_6107_6161(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        this_param.GenerateIAsyncEnumeratorImplementation_MoveNextAsync();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 6107, 6161);
                        return 0;
                    }


                    int
                    f_10448_6180_6228(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        this_param.GenerateIAsyncEnumeratorImplementation_Current();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 6180, 6228);
                        return 0;
                    }


                    int
                    f_10448_6292_6346(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        this_param.GenerateIValueTaskSourceBoolImplementation_GetResult();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 6292, 6346);
                        return 0;
                    }


                    int
                    f_10448_6365_6419(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        this_param.GenerateIValueTaskSourceBoolImplementation_GetStatus();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 6365, 6419);
                        return 0;
                    }


                    int
                    f_10448_6438_6494(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        this_param.GenerateIValueTaskSourceBoolImplementation_OnCompleted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 6438, 6494);
                        return 0;
                    }


                    int
                    f_10448_6552_6602(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        this_param.GenerateIValueTaskSourceImplementation_GetResult();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 6552, 6602);
                        return 0;
                    }


                    int
                    f_10448_6621_6671(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        this_param.GenerateIValueTaskSourceImplementation_GetStatus();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 6621, 6671);
                        return 0;
                    }


                    int
                    f_10448_6690_6742(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        this_param.GenerateIValueTaskSourceImplementation_OnCompleted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 6690, 6742);
                        return 0;
                    }


                    int
                    f_10448_6800_6839(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        this_param.GenerateIAsyncDisposable_DisposeAsync();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 6800, 6839);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 5663, 6855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 5663, 6855);
                }
            }

            protected override bool PreserveInitialParameterValuesAndThreadId
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 6954, 6970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 6957, 6970);
                        return _isEnumerable; DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 6954, 6970);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 6954, 6970);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 6954, 6970);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected override void GenerateControlFields()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 6987, 8802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 7210, 7239);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GenerateControlFields(), 10448, 7210, 7238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 7257, 7326);

                    NamedTypeSymbol
                    boolType = f_10448_7284_7325(F, SpecialType.System_Boolean)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 7437, 7724);

                    _promiseOfValueOrEndField = f_10448_7465_7723(F, f_10448_7507_7621(f_10448_7507_7601(F, WellKnownType.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T), boolType), f_10448_7644_7706(), isPublic: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 7889, 7972);

                    TypeSymbol
                    elementType = ((AsyncStateMachine)stateMachineType).IteratorElementType
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 8035, 8131);

                    _currentField = f_10448_8051_8130(F, elementType, f_10448_8084_8129());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 8201, 8294);

                    _disposeModeField = f_10448_8221_8293(F, boolType, f_10448_8251_8292());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 8314, 8787) || true) && (_isEnumerable && (DynAbs.Tracing.TraceSender.Expression_True(10448, 8318, 8424) && this.method.Parameters.Any(p => p.IsSourceParameterWithEnumeratorCancellationAttribute())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10448, 8314, 8787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 8542, 8768);

                        _combinedTokensField = f_10448_8565_8767(F, f_10448_8611_8682(F, WellKnownType.System_Threading_CancellationTokenSource), f_10448_8709_8766());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10448, 8314, 8787);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 6987, 8802);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_7284_7325(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 7284, 7325);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_7507_7601(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 7507, 7601);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_7507_7621(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 7507, 7621);
                        return return_v;
                    }


                    string
                    f_10448_7644_7706()
                    {
                        var return_v = GeneratedNames.MakeAsyncIteratorPromiseOfValueOrEndFieldName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 7644, 7706);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                    f_10448_7465_7723(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, string
                    name, bool
                    isPublic)
                    {
                        var return_v = this_param.StateMachineField((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, isPublic: isPublic);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 7465, 7723);
                        return return_v;
                    }


                    string
                    f_10448_8084_8129()
                    {
                        var return_v = GeneratedNames.MakeIteratorCurrentFieldName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 8084, 8129);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                    f_10448_8051_8130(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, string
                    name)
                    {
                        var return_v = this_param.StateMachineField(type, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 8051, 8130);
                        return return_v;
                    }


                    string
                    f_10448_8251_8292()
                    {
                        var return_v = GeneratedNames.MakeDisposeModeFieldName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 8251, 8292);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                    f_10448_8221_8293(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, string
                    name)
                    {
                        var return_v = this_param.StateMachineField((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 8221, 8293);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_8611_8682(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 8611, 8682);
                        return return_v;
                    }


                    string
                    f_10448_8709_8766()
                    {
                        var return_v = GeneratedNames.MakeAsyncIteratorCombinedTokensFieldName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 8709, 8766);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                    f_10448_8565_8767(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, string
                    name)
                    {
                        var return_v = this_param.StateMachineField((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 8565, 8767);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 6987, 8802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 6987, 8802);
                }
            }

            protected override void GenerateConstructor()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 8818, 10358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 9225, 9291);

                    f_10448_9225_9290(f_10448_9238_9266(stateMachineType) is IteratorConstructor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 9311, 9360);

                    F.CurrentFunction = f_10448_9331_9359(stateMachineType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 9378, 9439);

                    var
                    bodyBuilder = f_10448_9396_9438()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 9457, 9497);

                    f_10448_9457_9496(bodyBuilder, f_10448_9473_9495(F));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 9621, 9671);

                    f_10448_9621_9670(
                                    // this.builder = System.Runtime.CompilerServices.AsyncIteratorMethodBuilder.Create();
                                    bodyBuilder, f_10448_9637_9669(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 9691, 9796);

                    f_10448_9691_9795(
                                    bodyBuilder, f_10448_9707_9794(F, f_10448_9720_9747(F, stateField), f_10448_9749_9793(F, f_10448_9761_9789(f_10448_9761_9778(F))[0])));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 9839, 9883);

                    var
                    managedThreadId = f_10448_9861_9882(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 9901, 10181) || true) && (managedThreadId != null && (DynAbs.Tracing.TraceSender.Expression_True(10448, 9905, 9968) && (object)initialThreadIdField != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10448, 9901, 10181);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 10076, 10162);

                        f_10448_10076_10161(                    // this.initialThreadId = {managedThreadId};
                                            bodyBuilder, f_10448_10092_10160(F, f_10448_10105_10142(F, initialThreadIdField), managedThreadId));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10448, 9901, 10181);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 10203, 10231);

                    f_10448_10203_10230(

                                    bodyBuilder, f_10448_10219_10229(F));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 10249, 10306);

                    f_10448_10249_10305(F, f_10448_10263_10304(F, f_10448_10271_10303(bodyBuilder)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 10324, 10343);

                    bodyBuilder = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 8818, 10358);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_9238_9266(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                    this_param)
                    {
                        var return_v = this_param.Constructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 9238, 9266);
                        return return_v;
                    }


                    int
                    f_10448_9225_9290(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 9225, 9290);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_9331_9359(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                    this_param)
                    {
                        var return_v = this_param.Constructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 9331, 9359);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10448_9396_9438()
                    {
                        var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 9396, 9438);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10448_9473_9495(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.BaseInitialization();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 9473, 9495);
                        return return_v;
                    }


                    int
                    f_10448_9457_9496(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 9457, 9496);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_9637_9669(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        var return_v = this_param.GenerateCreateAndAssignBuilder();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 9637, 9669);
                        return return_v;
                    }


                    int
                    f_10448_9621_9670(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 9621, 9670);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_9720_9747(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 9720, 9747);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_9761_9778(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.CurrentFunction;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 9761, 9778);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_9761_9789(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 9761, 9789);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_9749_9793(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 9749, 9793);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_9707_9794(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    left, Microsoft.CodeAnalysis.CSharp.BoundParameter
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 9707, 9794);
                        return return_v;
                    }


                    int
                    f_10448_9691_9795(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 9691, 9795);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10448_9861_9882(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        var return_v = this_param.MakeCurrentThreadId();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 9861, 9882);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_10105_10142(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 10105, 10142);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_10092_10160(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 10092, 10160);
                        return return_v;
                    }


                    int
                    f_10448_10076_10161(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 10076, 10161);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_10219_10229(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Return();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 10219, 10229);
                        return return_v;
                    }


                    int
                    f_10448_10203_10230(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 10203, 10230);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10448_10271_10303(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 10271, 10303);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10448_10263_10304(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 10263, 10304);
                        return return_v;
                    }


                    int
                    f_10448_10249_10305(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 10249, 10305);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 8818, 10358);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 8818, 10358);
                }
            }

            private BoundExpressionStatement GenerateCreateAndAssignBuilder()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 10374, 10837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 10605, 10822);

                    return f_10448_10612_10821(F, f_10448_10647_10677(F, _builderField), f_10448_10700_10820(F, null, _asyncMethodBuilderMemberCollection.CreateBuilder));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 10374, 10837);

                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_10647_10677(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 10647, 10677);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10448_10700_10820(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.StaticCall(receiver, method, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 10700, 10820);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_10612_10821(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 10612, 10821);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 10374, 10837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 10374, 10837);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override void InitializeStateMachine(ArrayBuilder<BoundStatement> bodyBuilder, NamedTypeSymbol frameType, LocalSymbol stateMachineLocal)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 10853, 11490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 11115, 11244);

                    int
                    initialState = (DynAbs.Tracing.TraceSender.Conditional_F1(10448, 11134, 11147) || ((_isEnumerable && DynAbs.Tracing.TraceSender.Conditional_F2(10448, 11150, 11189)) || DynAbs.Tracing.TraceSender.Conditional_F3(10448, 11192, 11243))) ? StateMachineStates.FinishedStateMachine : StateMachineStates.InitialAsyncIteratorStateMachine
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 11262, 11475);

                    f_10448_11262_11474(bodyBuilder, f_10448_11300_11473(F, f_10448_11339_11365(F, stateMachineLocal), f_10448_11392_11472(F, f_10448_11398_11446(f_10448_11398_11426(stateMachineType), frameType), f_10448_11448_11471(F, initialState))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 10853, 11490);

                    Microsoft.CodeAnalysis.CSharp.BoundLocal
                    f_10448_11339_11365(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    local)
                    {
                        var return_v = this_param.Local(local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 11339, 11365);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_11398_11426(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                    this_param)
                    {
                        var return_v = this_param.Constructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 11398, 11426);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_11398_11446(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 11398, 11446);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10448_11448_11471(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 11448, 11471);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    f_10448_11392_11472(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.New(ctor, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 11392, 11472);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_11300_11473(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    left, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 11300, 11473);
                        return return_v;
                    }


                    int
                    f_10448_11262_11474(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 11262, 11474);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 10853, 11490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 10853, 11490);
                }
            }

            protected override BoundStatement InitializeParameterField(MethodSymbol getEnumeratorMethod, ParameterSymbol parameter, BoundExpression resultParameter, BoundExpression parameterProxy)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 11506, 15054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 11723, 11745);

                    BoundStatement
                    result
                    = default(BoundStatement);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 11763, 15005) || true) && (_combinedTokensField is object && (DynAbs.Tracing.TraceSender.Expression_True(10448, 11767, 11886) && f_10448_11822_11886(parameter)) && (DynAbs.Tracing.TraceSender.Expression_True(10448, 11767, 12050) && f_10448_11911_12050(f_10448_11911_11925(parameter), f_10448_11933_12013(f_10448_11933_11946(F), WellKnownType.System_Threading_CancellationToken), TypeCompareKind.ConsiderEverything)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10448, 11763, 15005);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 12853, 12932);

                        BoundParameter
                        tokenParameter = f_10448_12885_12931(F, f_10448_12897_12927(getEnumeratorMethod)[0])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 12954, 13028);

                        BoundFieldAccess
                        combinedTokens = f_10448_12988_13027(F, f_10448_12996_13004(F), _combinedTokensField)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 13050, 14670);

                        result = f_10448_13059_14669(F, f_10448_13159_13273(                        // if (this.parameterProxy.Equals(default))
                                                F, parameterProxy, WellKnownMember.System_Threading_CancellationToken__Equals, f_10448_13242_13272(F, f_10448_13252_13271(parameterProxy))), thenClause: f_10448_13366_13411(F, resultParameter, tokenParameter), elseClauseOpt: f_10448_13453_14668(F, f_10448_13589_13883(                            // else if (token.Equals(this.parameterProxy) || token.Equals(default))
                                                    F, f_10448_13635_13733(F, tokenParameter, WellKnownMember.System_Threading_CancellationToken__Equals, parameterProxy), f_10448_13768_13882(F, tokenParameter, WellKnownMember.System_Threading_CancellationToken__Equals, f_10448_13851_13881(F, f_10448_13861_13880(tokenParameter)))), thenClause: f_10448_13998_14043(F, resultParameter, parameterProxy), elseClauseOpt: f_10448_14089_14667(F, f_10448_14268_14425(                                // result.combinedTokens = CancellationTokenSource.CreateLinkedTokenSource(this.parameterProxy, token);
                                                        F, combinedTokens, f_10448_14297_14424(F, WellKnownMember.System_Threading_CancellationTokenSource__CreateLinkedTokenSource, parameterProxy, tokenParameter)), f_10448_14544_14666(                                // result.parameter = result.combinedTokens.Token;
                                                        F, resultParameter, f_10448_14574_14665(F, combinedTokens, WellKnownMember.System_Threading_CancellationTokenSource__Token)))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10448, 11763, 15005);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10448, 11763, 15005);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 14931, 14986);

                        result = f_10448_14940_14985(F, resultParameter, parameterProxy);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10448, 11763, 15005);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 15025, 15039);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 11506, 15054);

                    bool
                    f_10448_11822_11886(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    parameter)
                    {
                        var return_v = parameter.IsSourceParameterWithEnumeratorCancellationAttribute();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 11822, 11886);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_11911_11925(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 11911, 11925);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10448_11933_11946(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 11933, 11946);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_11933_12013(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    type)
                    {
                        var return_v = this_param.GetWellKnownType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 11933, 12013);
                        return return_v;
                    }


                    bool
                    f_10448_11911_12050(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    compareKind)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, compareKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 11911, 12050);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_12897_12927(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 12897, 12927);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_12885_12931(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 12885, 12931);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10448_12996_13004(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 12996, 13004);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_12988_13027(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 12988, 13027);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10448_13252_13271(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 13252, 13271);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10448_13242_13272(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    type)
                    {
                        var return_v = this_param.Default(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 13242, 13272);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_13159_13273(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    receiver, Microsoft.CodeAnalysis.WellKnownMember
                    method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg0)
                    {
                        var return_v = this_param.Call(receiver, method, arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 13159, 13273);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_13366_13411(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundParameter
                    right)
                    {
                        var return_v = this_param.Assignment(left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 13366, 13411);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_13635_13733(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                    receiver, Microsoft.CodeAnalysis.WellKnownMember
                    method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg0)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 13635, 13733);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_13861_13880(Microsoft.CodeAnalysis.CSharp.BoundParameter
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 13861, 13880);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10448_13851_13881(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = this_param.Default(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 13851, 13881);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_13768_13882(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                    receiver, Microsoft.CodeAnalysis.WellKnownMember
                    method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg0)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 13768, 13882);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    f_10448_13589_13883(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    left, Microsoft.CodeAnalysis.CSharp.BoundCall
                    right)
                    {
                        var return_v = this_param.LogicalOr((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 13589, 13883);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_13998_14043(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.Assignment(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 13998, 14043);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10448_14297_14424(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.StaticCall(method, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 14297, 14424);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_14268_14425(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 14268, 14425);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10448_14574_14665(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiverOpt, Microsoft.CodeAnalysis.WellKnownMember
                    member)
                    {
                        var return_v = this_param.Property((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, member);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 14574, 14665);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_14544_14666(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.Assignment(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 14544, 14666);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10448_14089_14667(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 14089, 14667);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10448_13453_14668(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    condition, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    thenClause, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    elseClauseOpt)
                    {
                        var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause, elseClauseOpt: (Microsoft.CodeAnalysis.CSharp.BoundStatement)elseClauseOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 13453, 14668);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10448_13059_14669(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    condition, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    thenClause, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    elseClauseOpt)
                    {
                        var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause, elseClauseOpt: elseClauseOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 13059, 14669);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_14940_14985(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.Assignment(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 14940, 14985);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 11506, 15054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 11506, 15054);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override BoundStatement GenerateStateMachineCreation(LocalSymbol stateMachineVariable, NamedTypeSymbol frameType, IReadOnlyDictionary<Symbol, CapturedSymbolReplacement> proxies)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 15070, 15687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 15290, 15351);

                    var
                    bodyBuilder = f_10448_15308_15350()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 15371, 15444);

                    f_10448_15371_15443(
                                    bodyBuilder, f_10448_15387_15442(this, stateMachineVariable, proxies));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 15498, 15603);

                    f_10448_15498_15602(
                                    // return local;
                                    bodyBuilder, f_10448_15536_15601(F, f_10448_15571_15600(F, stateMachineVariable)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 15623, 15672);

                    return f_10448_15630_15671(F, f_10448_15638_15670(bodyBuilder));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 15070, 15687);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10448_15308_15350()
                    {
                        var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 15308, 15350);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10448_15387_15442(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    stateMachineVariable, System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                    proxies)
                    {
                        var return_v = this_param.GenerateParameterStorage(stateMachineVariable, proxies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 15387, 15442);
                        return return_v;
                    }


                    int
                    f_10448_15371_15443(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 15371, 15443);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLocal
                    f_10448_15571_15600(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    local)
                    {
                        var return_v = this_param.Local(local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 15571, 15600);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_15536_15601(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    expression)
                    {
                        var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 15536, 15601);
                        return return_v;
                    }


                    int
                    f_10448_15498_15602(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 15498, 15602);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10448_15638_15670(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 15638, 15670);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10448_15630_15671(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 15630, 15671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 15070, 15687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 15070, 15687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "Standard naming convention for generating 'IAsyncEnumerator.MoveNextAsync'")]
            private void GenerateIAsyncEnumeratorImplementation_MoveNextAsync()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 15834, 21002);
                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement callReset = default(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement);
                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol instSymbol = default(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol);
                    Microsoft.CodeAnalysis.CSharp.BoundStatement instAssignment = default(Microsoft.CodeAnalysis.CSharp.BoundStatement);
                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement startCall = default(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement);
                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol promise_get_Version = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 16811, 17009);

                    NamedTypeSymbol
                    IAsyncEnumeratorOfElementType =
                    f_10448_16880_17008(f_10448_16880_16956(F, WellKnownType.System_Collections_Generic_IAsyncEnumerator_T), f_10448_16989_17007(_currentField))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 17029, 17246);

                    MethodSymbol
                    IAsyncEnumerableOfElementType_MoveNextAsync = f_10448_17088_17245(f_10448_17088_17183(F, WellKnownMember.System_Collections_Generic_IAsyncEnumerator_T__MoveNextAsync), IAsyncEnumeratorOfElementType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 17266, 17332);

                    var
                    promiseType = (NamedTypeSymbol)f_10448_17301_17331(_promiseOfValueOrEndField)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 17352, 17539);

                    MethodSymbol
                    promise_GetStatus = f_10448_17385_17538(f_10448_17385_17494(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__GetStatus), promiseType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 17559, 17746);

                    MethodSymbol
                    promise_GetResult = f_10448_17592_17745(f_10448_17592_17701(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__GetResult), promiseType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 17766, 17868);

                    var
                    moveNextAsyncReturnType = (NamedTypeSymbol)f_10448_17813_17867(IAsyncEnumerableOfElementType_MoveNextAsync)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 17888, 18061);

                    MethodSymbol
                    valueTaskT_ctorValue = f_10448_17924_18060(f_10448_17924_18004(F, WellKnownMember.System_Threading_Tasks_ValueTask_T__ctorValue), moveNextAsyncReturnType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 18081, 18258);

                    MethodSymbol
                    valueTaskT_ctor = f_10448_18112_18257(f_10448_18112_18201(F, WellKnownMember.System_Threading_Tasks_ValueTask_T__ctorSourceAndToken), moveNextAsyncReturnType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 18375, 18477);

                    f_10448_18375_18476(this, IAsyncEnumerableOfElementType_MoveNextAsync, hasMethodBodyDependency: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 18497, 18789);

                    f_10448_18497_18788(this, out callReset, out instSymbol, out instAssignment, out startCall, out promise_get_Version);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 18809, 19154);

                    BoundStatement
                    ifFinished = f_10448_18837_19153(F, f_10448_18942_19033(                    // if (state == StateMachineStates.FinishedStateMachine)
                                        F, f_10448_18953_18980(F, stateField), f_10448_18982_19032(F, StateMachineStates.FinishedStateMachine)), thenClause: f_10448_19108_19152(F, f_10448_19117_19151(F, moveNextAsyncReturnType)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 19236, 19316);

                    var
                    versionSymbol = f_10448_19256_19315(F, f_10448_19275_19314(F, SpecialType.System_Int16))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 19334, 19376);

                    var
                    versionLocal = f_10448_19353_19375(F, versionSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 19394, 19514);

                    var
                    versionInit = f_10448_19412_19513(F, versionLocal, f_10448_19439_19512(F, f_10448_19446_19490(F, f_10448_19454_19462(F), _promiseOfValueOrEndField), promise_get_Version))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 19534, 20098);

                    var
                    ifPromiseReady = f_10448_19555_20097(F, f_10448_19684_19846(                    // if (_valueOrEndPromise.GetStatus(version) == ValueTaskSourceStatus.Succeeded)
                                        F, f_10448_19721_19806(F, f_10448_19728_19772(F, f_10448_19736_19744(F), _promiseOfValueOrEndField), promise_GetStatus, versionLocal), f_10448_19833_19845(F, 1)), thenClause: f_10448_19972_20096(F, f_10448_19981_20095(F, valueTaskT_ctorValue, f_10448_20009_20094(F, f_10448_20016_20060(F, f_10448_20024_20032(F), _promiseOfValueOrEndField), promise_GetResult, versionLocal))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 20468, 20547);

                    var
                    returnStatement = f_10448_20490_20546(F, f_10448_20499_20545(F, valueTaskT_ctor, f_10448_20522_20530(F), versionLocal))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 20567, 20987);

                    f_10448_20567_20986(
                                    F, f_10448_20581_20985(F, f_10448_20611_20659(instSymbol, versionSymbol), ifFinished, callReset, instAssignment, startCall, versionInit, ifPromiseReady, returnStatement));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 15834, 21002);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_16880_16956(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 16880, 16956);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_16989_17007(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 16989, 17007);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_16880_17008(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 16880, 17008);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_17088_17183(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 17088, 17183);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_17088_17245(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 17088, 17245);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_17301_17331(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 17301, 17331);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_17385_17494(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 17385, 17494);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_17385_17538(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 17385, 17538);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_17592_17701(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 17592, 17701);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_17592_17745(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 17592, 17745);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_17813_17867(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 17813, 17867);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_17924_18004(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 17924, 18004);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_17924_18060(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 17924, 18060);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_18112_18201(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 18112, 18201);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_18112_18257(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 18112, 18257);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                    f_10448_18375_18476(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodToImplement, bool
                    hasMethodBodyDependency)
                    {
                        var return_v = this_param.OpenMethodImplementation(methodToImplement, hasMethodBodyDependency: hasMethodBodyDependency);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 18375, 18476);
                        return return_v;
                    }


                    int
                    f_10448_18497_18788(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, out Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    callReset, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    instSymbol, out Microsoft.CodeAnalysis.CSharp.BoundStatement
                    instAssignment, out Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    startCall, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    promise_get_Version)
                    {
                        this_param.GetPartsForStartingMachine(out callReset, out instSymbol, out instAssignment, out startCall, out promise_get_Version);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 18497, 18788);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_18953_18980(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 18953, 18980);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10448_18982_19032(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 18982, 19032);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    f_10448_18942_19033(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    right)
                    {
                        var return_v = this_param.IntEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 18942, 19033);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10448_19117_19151(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = this_param.Default((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19117, 19151);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_19108_19152(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression)
                    {
                        var return_v = this_param.Return(expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19108, 19152);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10448_18837_19153(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    condition, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    thenClause)
                    {
                        var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 18837, 19153);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_19275_19314(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19275, 19314);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10448_19256_19315(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19256, 19315);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLocal
                    f_10448_19353_19375(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    local)
                    {
                        var return_v = this_param.Local(local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19353, 19375);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10448_19454_19462(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19454, 19462);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_19446_19490(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19446, 19490);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_19439_19512(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19439, 19512);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_19412_19513(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    left, Microsoft.CodeAnalysis.CSharp.BoundCall
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19412, 19513);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10448_19736_19744(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19736, 19744);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_19728_19772(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19728, 19772);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_19721_19806(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    arg0)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19721, 19806);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10448_19833_19845(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19833, 19845);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    f_10448_19684_19846(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    right)
                    {
                        var return_v = this_param.IntEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19684, 19846);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10448_20024_20032(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 20024, 20032);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_20016_20060(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 20016, 20060);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_20009_20094(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    arg0)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 20009, 20094);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    f_10448_19981_20095(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.New(ctor, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19981, 20095);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_19972_20096(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    expression)
                    {
                        var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19972, 20096);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10448_19555_20097(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    condition, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    thenClause)
                    {
                        var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 19555, 20097);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10448_20522_20530(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 20522, 20530);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    f_10448_20499_20545(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.New(ctor, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 20499, 20545);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_20490_20546(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    expression)
                    {
                        var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 20490, 20546);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10448_20611_20659(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item1, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item2)
                    {
                        var return_v = ImmutableArray.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 20611, 20659);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10448_20581_20985(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(locals, statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 20581, 20985);
                        return return_v;
                    }


                    int
                    f_10448_20567_20986(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 20567, 20986);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 15834, 21002);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 15834, 21002);
                }
            }

            private void GetPartsForStartingMachine(out BoundExpressionStatement callReset, out LocalSymbol instSymbol, out BoundStatement instAssignment,
                            out BoundExpressionStatement startCall, out MethodSymbol promise_get_Version)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 21165, 23249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 21724, 21799);

                    BoundFieldAccess
                    promiseField = f_10448_21756_21798(F, _promiseOfValueOrEndField)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 21817, 22059);

                    var
                    resetMethod = (MethodSymbol)f_10448_21849_22058(f_10448_21849_21972(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__Reset, isOptional: true), f_10448_22027_22057(_promiseOfValueOrEndField))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 22079, 22148);

                    callReset = f_10448_22091_22147(F, f_10448_22113_22146(F, promiseField, resetMethod));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 22214, 22295);

                    f_10448_22214_22294(!_asyncMethodBuilderMemberCollection.CheckGenericMethodConstraints);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 22313, 22415);

                    MethodSymbol
                    startMethod = f_10448_22340_22414(_asyncMethodBuilderMemberCollection.Start, this.stateMachineType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 22433, 22488);

                    instSymbol = f_10448_22446_22487(F, this.stateMachineType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 22545, 22581);

                    var
                    instLocal = f_10448_22561_22580(F, instSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 22599, 22650);

                    instAssignment = f_10448_22616_22649(F, instLocal, f_10448_22640_22648(F));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 22716, 22952);

                    startCall = f_10448_22728_22951(F, f_10448_22772_22950(F, f_10448_22805_22835(F, _builderField), startMethod, f_10448_22900_22949(instLocal)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 23020, 23234);

                    promise_get_Version = f_10448_23042_23233(f_10448_23042_23153(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__get_Version), f_10448_23202_23232(_promiseOfValueOrEndField));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 21165, 23249);

                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_21756_21798(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 21756, 21798);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10448_21849_21972(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm, bool
                    isOptional)
                    {
                        var return_v = this_param.WellKnownMethod(wm, isOptional: isOptional);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 21849, 21972);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_22027_22057(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 22027, 22057);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_21849_22058(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    s, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newOwner)
                    {
                        var return_v = s.SymbolAsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 21849, 22058);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_22113_22146(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22113, 22146);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_22091_22147(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    expr)
                    {
                        var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22091, 22147);
                        return return_v;
                    }


                    int
                    f_10448_22214_22294(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22214, 22294);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_22340_22414(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22340, 22414);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10448_22446_22487(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                    type)
                    {
                        var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22446, 22487);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLocal
                    f_10448_22561_22580(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    local)
                    {
                        var return_v = this_param.Local(local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22561, 22580);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10448_22640_22648(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22640, 22648);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_22616_22649(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    left, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22616, 22649);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_22805_22835(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22805, 22835);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10448_22900_22949(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    item)
                    {
                        var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22900, 22949);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_22772_22950(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    args)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22772, 22950);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_22728_22951(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    expr)
                    {
                        var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 22728, 22951);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_23042_23153(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 23042, 23153);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_23202_23232(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 23202, 23232);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_23042_23233(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 23042, 23233);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 21165, 23249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 21165, 23249);
                }
            }

            [SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "Standard naming convention for generating 'IAsyncDisposable.DisposeAsync'")]
            private void GenerateIAsyncDisposable_DisposeAsync()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 23512, 26930);
                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement callReset = default(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement);
                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol instSymbol = default(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol);
                    Microsoft.CodeAnalysis.CSharp.BoundStatement instAssignment = default(Microsoft.CodeAnalysis.CSharp.BoundStatement);
                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement startCall = default(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement);
                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol promise_get_Version = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 24428, 24546);

                    MethodSymbol
                    IAsyncDisposable_DisposeAsync = f_10448_24473_24545(F, WellKnownMember.System_IAsyncDisposable__DisposeAsync)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 24663, 24751);

                    f_10448_24663_24750(this, IAsyncDisposable_DisposeAsync, hasMethodBodyDependency: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 24771, 24836);

                    TypeSymbol
                    returnType = f_10448_24795_24835(IAsyncDisposable_DisposeAsync)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 24856, 25148);

                    f_10448_24856_25147(this, out callReset, out instSymbol, out instAssignment, out startCall, out promise_get_Version);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 25168, 25593);

                    BoundStatement
                    ifInvalidState = f_10448_25200_25592(F, f_10448_25316_25422(                    // if (state >= StateMachineStates.NotStartedStateMachine /* -1 */)
                                        F, f_10448_25340_25367(F, stateField), f_10448_25369_25421(F, StateMachineStates.NotStartedStateMachine)), thenClause: f_10448_25516_25591(F, f_10448_25524_25590(F, f_10448_25530_25589(F, WellKnownType.System_NotSupportedException))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 25613, 25945);

                    BoundStatement
                    ifFinished = f_10448_25641_25944(F, f_10448_25746_25837(                    // if (state == StateMachineStates.FinishedStateMachine)
                                        F, f_10448_25757_25784(F, stateField), f_10448_25786_25836(F, StateMachineStates.FinishedStateMachine)), thenClause: f_10448_25912_25943(F, f_10448_25921_25942(F, returnType)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 25965, 26180);

                    MethodSymbol
                    valueTask_ctor =
                    f_10448_26016_26179(f_10448_26016_26089(F, WellKnownMember.System_Threading_Tasks_ValueTask__ctor), f_10448_26138_26178(IAsyncDisposable_DisposeAsync))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 26276, 26413);

                    var
                    returnStatement = f_10448_26298_26412(F, f_10448_26307_26411(F, valueTask_ctor, f_10448_26329_26337(F), f_10448_26339_26410(F, f_10448_26346_26388(F, _promiseOfValueOrEndField), promise_get_Version)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 26433, 26915);

                    f_10448_26433_26914(
                                    F, f_10448_26447_26913(F, f_10448_26477_26510(instSymbol), ifInvalidState, ifFinished, f_10448_26603_26668(F, f_10448_26616_26650(F, _disposeModeField), f_10448_26652_26667(F, true)), callReset, instAssignment, startCall, returnStatement));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 23512, 26930);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_24473_24545(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 24473, 24545);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                    f_10448_24663_24750(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodToImplement, bool
                    hasMethodBodyDependency)
                    {
                        var return_v = this_param.OpenMethodImplementation(methodToImplement, hasMethodBodyDependency: hasMethodBodyDependency);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 24663, 24750);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_24795_24835(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 24795, 24835);
                        return return_v;
                    }


                    int
                    f_10448_24856_25147(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, out Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    callReset, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    instSymbol, out Microsoft.CodeAnalysis.CSharp.BoundStatement
                    instAssignment, out Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    startCall, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    promise_get_Version)
                    {
                        this_param.GetPartsForStartingMachine(out callReset, out instSymbol, out instAssignment, out startCall, out promise_get_Version);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 24856, 25147);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_25340_25367(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25340, 25367);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10448_25369_25421(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25369, 25421);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    f_10448_25316_25422(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    right)
                    {
                        var return_v = this_param.IntGreaterThanOrEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25316, 25422);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_25530_25589(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25530, 25589);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    f_10448_25524_25590(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.New(type, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25524, 25590);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                    f_10448_25516_25591(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    e)
                    {
                        var return_v = this_param.Throw((Microsoft.CodeAnalysis.CSharp.BoundExpression)e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25516, 25591);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10448_25200_25592(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    condition, Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                    thenClause)
                    {
                        var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25200, 25592);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_25757_25784(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25757, 25784);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10448_25786_25836(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25786, 25836);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    f_10448_25746_25837(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    right)
                    {
                        var return_v = this_param.IntEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25746, 25837);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10448_25921_25942(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = this_param.Default(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25921, 25942);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_25912_25943(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression)
                    {
                        var return_v = this_param.Return(expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25912, 25943);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10448_25641_25944(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    condition, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    thenClause)
                    {
                        var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause: (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 25641, 25944);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_26016_26089(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26016, 26089);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_26138_26178(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 26138, 26178);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_26016_26179(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26016, 26179);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10448_26329_26337(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26329, 26337);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_26346_26388(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26346, 26388);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_26339_26410(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26339, 26410);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    f_10448_26307_26411(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.New(ctor, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26307, 26411);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_26298_26412(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    expression)
                    {
                        var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26298, 26412);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10448_26477_26510(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26477, 26510);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_26616_26650(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26616, 26650);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10448_26652_26667(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, bool
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26652, 26667);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_26603_26668(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26603, 26668);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10448_26447_26913(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(locals, statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26447, 26913);
                        return return_v;
                    }


                    int
                    f_10448_26433_26914(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 26433, 26914);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 23512, 26930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 23512, 26930);
                }
            }

            private void GenerateIAsyncEnumeratorImplementation_Current()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 27050, 27898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 27256, 27454);

                    NamedTypeSymbol
                    IAsyncEnumeratorOfElementType =
                    f_10448_27325_27453(f_10448_27325_27401(F, WellKnownType.System_Collections_Generic_IAsyncEnumerator_T), f_10448_27434_27452(_currentField))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 27474, 27708);

                    MethodSymbol
                    IAsyncEnumerableOfElementType_get_Current =
                    f_10448_27552_27707(f_10448_27552_27645(F, WellKnownMember.System_Collections_Generic_IAsyncEnumerator_T__get_Current), IAsyncEnumeratorOfElementType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 27728, 27798);

                    f_10448_27728_27797(this, IAsyncEnumerableOfElementType_get_Current);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 27818, 27883);

                    f_10448_27818_27882(
                                    F, f_10448_27832_27881(F, f_10448_27840_27880(F, f_10448_27849_27879(F, _currentField))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 27050, 27898);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_27325_27401(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 27325, 27401);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_27434_27452(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 27434, 27452);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_27325_27453(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 27325, 27453);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_27552_27645(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 27552, 27645);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_27552_27707(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 27552, 27707);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_27728_27797(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    getterToImplement)
                    {
                        var return_v = this_param.OpenPropertyImplementation(getterToImplement);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 27728, 27797);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_27849_27879(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 27849, 27879);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_27840_27880(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    expression)
                    {
                        var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 27840, 27880);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10448_27832_27881(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 27832, 27881);
                        return return_v;
                    }


                    int
                    f_10448_27818_27882(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 27818, 27882);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 27050, 27898);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 27050, 27898);
                }
            }

            private void GenerateIValueTaskSourceBoolImplementation_GetResult()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 27914, 29397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 28185, 28403);

                    NamedTypeSymbol
                    IValueTaskSourceOfBool =
                    f_10448_28247_28402(f_10448_28247_28327(F, WellKnownType.System_Threading_Tasks_Sources_IValueTaskSource_T), f_10448_28360_28401(F, SpecialType.System_Boolean))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 28423, 28643);

                    MethodSymbol
                    IValueTaskSourceOfBool_GetResult =
                    f_10448_28492_28642(f_10448_28492_28587(F, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource_T__GetResult), IValueTaskSourceOfBool)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 28663, 28907);

                    MethodSymbol
                    promise_GetResult =
                    f_10448_28717_28906(f_10448_28717_28826(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__GetResult), f_10448_28875_28905(_promiseOfValueOrEndField))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 29024, 29115);

                    f_10448_29024_29114(this, IValueTaskSourceOfBool_GetResult, hasMethodBodyDependency: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 29204, 29382);

                    f_10448_29204_29381(
                                    // return this._valueOrEndPromise.GetResult(token);
                                    F, f_10448_29218_29380(F, f_10448_29249_29379(F, f_10448_29256_29298(F, _promiseOfValueOrEndField), promise_GetResult, f_10448_29319_29378(F, f_10448_29331_29374(IValueTaskSourceOfBool_GetResult)[0]))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 27914, 29397);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_28247_28327(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 28247, 28327);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_28360_28401(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 28360, 28401);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_28247_28402(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 28247, 28402);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_28492_28587(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 28492, 28587);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_28492_28642(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 28492, 28642);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_28717_28826(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 28717, 28826);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_28875_28905(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 28875, 28905);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_28717_28906(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 28717, 28906);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                    f_10448_29024_29114(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodToImplement, bool
                    hasMethodBodyDependency)
                    {
                        var return_v = this_param.OpenMethodImplementation(methodToImplement, hasMethodBodyDependency: hasMethodBodyDependency);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 29024, 29114);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_29256_29298(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 29256, 29298);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_29331_29374(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 29331, 29374);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_29319_29378(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 29319, 29378);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_29249_29379(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.BoundParameter
                    arg0)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 29249, 29379);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_29218_29380(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    expression)
                    {
                        var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 29218, 29380);
                        return return_v;
                    }


                    int
                    f_10448_29204_29381(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 29204, 29381);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 27914, 29397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 27914, 29397);
                }
            }

            private void GenerateIValueTaskSourceBoolImplementation_GetStatus()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 29413, 30918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 29706, 29924);

                    NamedTypeSymbol
                    IValueTaskSourceOfBool =
                    f_10448_29768_29923(f_10448_29768_29848(F, WellKnownType.System_Threading_Tasks_Sources_IValueTaskSource_T), f_10448_29881_29922(F, SpecialType.System_Boolean))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 29944, 30164);

                    MethodSymbol
                    IValueTaskSourceOfBool_GetStatus =
                    f_10448_30013_30163(f_10448_30013_30108(F, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource_T__GetStatus), IValueTaskSourceOfBool)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 30184, 30428);

                    MethodSymbol
                    promise_GetStatus =
                    f_10448_30238_30427(f_10448_30238_30347(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__GetStatus), f_10448_30396_30426(_promiseOfValueOrEndField))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 30545, 30636);

                    f_10448_30545_30635(this, IValueTaskSourceOfBool_GetStatus, hasMethodBodyDependency: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 30725, 30903);

                    f_10448_30725_30902(
                                    // return this._valueOrEndPromise.GetStatus(token);
                                    F, f_10448_30739_30901(F, f_10448_30770_30900(F, f_10448_30777_30819(F, _promiseOfValueOrEndField), promise_GetStatus, f_10448_30840_30899(F, f_10448_30852_30895(IValueTaskSourceOfBool_GetStatus)[0]))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 29413, 30918);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_29768_29848(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 29768, 29848);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_29881_29922(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 29881, 29922);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_29768_29923(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 29768, 29923);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_30013_30108(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 30013, 30108);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_30013_30163(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 30013, 30163);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_30238_30347(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 30238, 30347);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_30396_30426(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 30396, 30426);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_30238_30427(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 30238, 30427);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                    f_10448_30545_30635(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodToImplement, bool
                    hasMethodBodyDependency)
                    {
                        var return_v = this_param.OpenMethodImplementation(methodToImplement, hasMethodBodyDependency: hasMethodBodyDependency);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 30545, 30635);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_30777_30819(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 30777, 30819);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_30852_30895(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 30852, 30895);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_30840_30899(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 30840, 30899);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_30770_30900(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.BoundParameter
                    arg0)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 30770, 30900);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_30739_30901(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    expression)
                    {
                        var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 30739, 30901);
                        return return_v;
                    }


                    int
                    f_10448_30725_30902(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 30725, 30902);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 29413, 30918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 29413, 30918);
                }
            }

            private void GenerateIValueTaskSourceBoolImplementation_OnCompleted()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 30934, 32997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 31347, 31565);

                    NamedTypeSymbol
                    IValueTaskSourceOfBool =
                    f_10448_31409_31564(f_10448_31409_31489(F, WellKnownType.System_Threading_Tasks_Sources_IValueTaskSource_T), f_10448_31522_31563(F, SpecialType.System_Boolean))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 31585, 31809);

                    MethodSymbol
                    IValueTaskSourceOfBool_OnCompleted =
                    f_10448_31656_31808(f_10448_31656_31753(F, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource_T__OnCompleted), IValueTaskSourceOfBool)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 31829, 32077);

                    MethodSymbol
                    promise_OnCompleted =
                    f_10448_31885_32076(f_10448_31885_31996(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__OnCompleted), f_10448_32045_32075(_promiseOfValueOrEndField))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 32194, 32287);

                    f_10448_32194_32286(this, IValueTaskSourceOfBool_OnCompleted, hasMethodBodyDependency: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 32307, 32971);

                    f_10448_32307_32970(
                                    F, f_10448_32321_32969(F, f_10448_32447_32935(                    // this._valueOrEndPromise.OnCompleted(continuation, state, token, flags);
                                        F, f_10448_32495_32934(F, f_10448_32502_32544(F, _promiseOfValueOrEndField), promise_OnCompleted, f_10448_32596_32657(F, f_10448_32608_32653(IValueTaskSourceOfBool_OnCompleted)[0]), f_10448_32688_32749(F, f_10448_32700_32745(IValueTaskSourceOfBool_OnCompleted)[1]), f_10448_32780_32841(F, f_10448_32792_32837(IValueTaskSourceOfBool_OnCompleted)[2]), f_10448_32872_32933(F, f_10448_32884_32929(IValueTaskSourceOfBool_OnCompleted)[3]))), f_10448_32958_32968(F)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 30934, 32997);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_31409_31489(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 31409, 31489);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_31522_31563(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 31522, 31563);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_31409_31564(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 31409, 31564);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_31656_31753(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 31656, 31753);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_31656_31808(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 31656, 31808);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_31885_31996(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 31885, 31996);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_32045_32075(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 32045, 32075);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_31885_32076(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 31885, 32076);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                    f_10448_32194_32286(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodToImplement, bool
                    hasMethodBodyDependency)
                    {
                        var return_v = this_param.OpenMethodImplementation(methodToImplement, hasMethodBodyDependency: hasMethodBodyDependency);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 32194, 32286);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_32502_32544(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 32502, 32544);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_32608_32653(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 32608, 32653);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_32596_32657(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 32596, 32657);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_32700_32745(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 32700, 32745);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_32688_32749(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 32688, 32749);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_32792_32837(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 32792, 32837);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_32780_32841(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 32780, 32841);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_32884_32929(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 32884, 32929);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_32872_32933(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 32872, 32933);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_32495_32934(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 32495, 32934);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_32447_32935(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    expr)
                    {
                        var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 32447, 32935);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_32958_32968(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Return();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 32958, 32968);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10448_32321_32969(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 32321, 32969);
                        return return_v;
                    }


                    int
                    f_10448_32307_32970(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 32307, 32970);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 30934, 32997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 30934, 32997);
                }
            }

            private void GenerateIValueTaskSourceImplementation_GetResult()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 33013, 34284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 33301, 33458);

                    MethodSymbol
                    IValueTaskSource_GetResult =
                    f_10448_33364_33457(F, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource__GetResult)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 33478, 33722);

                    MethodSymbol
                    promise_GetResult =
                    f_10448_33532_33721(f_10448_33532_33641(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__GetResult), f_10448_33690_33720(_promiseOfValueOrEndField))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 33839, 33924);

                    f_10448_33839_33923(this, IValueTaskSource_GetResult, hasMethodBodyDependency: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 33944, 34269);

                    f_10448_33944_34268(
                                    F, f_10448_33958_34267(F, f_10448_34054_34201(                    // this._valueOrEndPromise.GetResult(token);
                                        F, f_10448_34076_34200(F, f_10448_34083_34125(F, _promiseOfValueOrEndField), promise_GetResult, f_10448_34146_34199(F, f_10448_34158_34195(IValueTaskSource_GetResult)[0]))), f_10448_34256_34266(                    // return;
                                        F)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 33013, 34284);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_33364_33457(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 33364, 33457);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_33532_33641(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 33532, 33641);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_33690_33720(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 33690, 33720);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_33532_33721(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 33532, 33721);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                    f_10448_33839_33923(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodToImplement, bool
                    hasMethodBodyDependency)
                    {
                        var return_v = this_param.OpenMethodImplementation(methodToImplement, hasMethodBodyDependency: hasMethodBodyDependency);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 33839, 33923);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_34083_34125(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 34083, 34125);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_34158_34195(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 34158, 34195);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_34146_34199(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 34146, 34199);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_34076_34200(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.BoundParameter
                    arg0)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 34076, 34200);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_34054_34201(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    expr)
                    {
                        var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 34054, 34201);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_34256_34266(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Return();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 34256, 34266);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10448_33958_34267(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 33958, 34267);
                        return return_v;
                    }


                    int
                    f_10448_33944_34268(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 33944, 34268);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 33013, 34284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 33013, 34284);
                }
            }

            private void GenerateIValueTaskSourceImplementation_GetStatus()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 34444, 35626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 34727, 34884);

                    MethodSymbol
                    IValueTaskSource_GetStatus =
                    f_10448_34790_34883(F, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource__GetStatus)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 34904, 35148);

                    MethodSymbol
                    promise_GetStatus =
                    f_10448_34958_35147(f_10448_34958_35067(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__GetStatus), f_10448_35116_35146(_promiseOfValueOrEndField))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 35265, 35350);

                    f_10448_35265_35349(this, IValueTaskSource_GetStatus, hasMethodBodyDependency: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 35439, 35611);

                    f_10448_35439_35610(
                                    // return this._valueOrEndPromise.GetStatus(token);
                                    F, f_10448_35453_35609(F, f_10448_35484_35608(F, f_10448_35491_35533(F, _promiseOfValueOrEndField), promise_GetStatus, f_10448_35554_35607(F, f_10448_35566_35603(IValueTaskSource_GetStatus)[0]))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 34444, 35626);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_34790_34883(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 34790, 34883);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_34958_35067(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 34958, 35067);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_35116_35146(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 35116, 35146);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_34958_35147(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 34958, 35147);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                    f_10448_35265_35349(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodToImplement, bool
                    hasMethodBodyDependency)
                    {
                        var return_v = this_param.OpenMethodImplementation(methodToImplement, hasMethodBodyDependency: hasMethodBodyDependency);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 35265, 35349);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_35491_35533(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 35491, 35533);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_35566_35603(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 35566, 35603);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_35554_35607(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 35554, 35607);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_35484_35608(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.BoundParameter
                    arg0)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 35484, 35608);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_35453_35609(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    expression)
                    {
                        var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 35453, 35609);
                        return return_v;
                    }


                    int
                    f_10448_35439_35610(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 35439, 35610);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 34444, 35626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 34444, 35626);
                }
            }

            private void GenerateIValueTaskSourceImplementation_OnCompleted()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 35786, 37487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 36189, 36329);

                    MethodSymbol
                    IValueTaskSource_OnCompleted = f_10448_36233_36328(F, WellKnownMember.System_Threading_Tasks_Sources_IValueTaskSource__OnCompleted)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 36349, 36597);

                    MethodSymbol
                    promise_OnCompleted =
                    f_10448_36405_36596(f_10448_36405_36516(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__OnCompleted), f_10448_36565_36595(_promiseOfValueOrEndField))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 36714, 36801);

                    f_10448_36714_36800(this, IValueTaskSource_OnCompleted, hasMethodBodyDependency: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 36821, 37461);

                    f_10448_36821_37460(
                                    F, f_10448_36835_37459(F, f_10448_36961_37425(                    // this._valueOrEndPromise.OnCompleted(continuation, state, token, flags);
                                        F, f_10448_37009_37424(F, f_10448_37016_37058(F, _promiseOfValueOrEndField), promise_OnCompleted, f_10448_37110_37165(F, f_10448_37122_37161(IValueTaskSource_OnCompleted)[0]), f_10448_37196_37251(F, f_10448_37208_37247(IValueTaskSource_OnCompleted)[1]), f_10448_37282_37337(F, f_10448_37294_37333(IValueTaskSource_OnCompleted)[2]), f_10448_37368_37423(F, f_10448_37380_37419(IValueTaskSource_OnCompleted)[3]))), f_10448_37448_37458(F)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 35786, 37487);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_36233_36328(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 36233, 36328);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_36405_36516(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 36405, 36516);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_36565_36595(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 36565, 36595);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_36405_36596(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 36405, 36596);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                    f_10448_36714_36800(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodToImplement, bool
                    hasMethodBodyDependency)
                    {
                        var return_v = this_param.OpenMethodImplementation(methodToImplement, hasMethodBodyDependency: hasMethodBodyDependency);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 36714, 36800);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_37016_37058(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 37016, 37058);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_37122_37161(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 37122, 37161);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_37110_37165(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 37110, 37165);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_37208_37247(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 37208, 37247);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_37196_37251(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 37196, 37251);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_37294_37333(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 37294, 37333);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_37282_37337(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 37282, 37337);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10448_37380_37419(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 37380, 37419);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10448_37368_37423(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 37368, 37423);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10448_37009_37424(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 37009, 37424);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_36961_37425(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    expr)
                    {
                        var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 36961, 37425);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10448_37448_37458(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Return();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 37448, 37458);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10448_36835_37459(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 36835, 37459);
                        return return_v;
                    }


                    int
                    f_10448_36821_37460(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 36821, 37460);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 35786, 37487);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 35786, 37487);
                }
            }

            private void GenerateIAsyncEnumerableImplementation_GetAsyncEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 37616, 38437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 37721, 37919);

                    NamedTypeSymbol
                    IAsyncEnumerableOfElementType =
                    f_10448_37790_37918(f_10448_37790_37866(F, WellKnownType.System_Collections_Generic_IAsyncEnumerable_T), f_10448_37899_37917(_currentField))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 37939, 38182);

                    MethodSymbol
                    IAsyncEnumerableOfElementType_GetEnumerator =
                    f_10448_38019_38181(f_10448_38019_38119(F, WellKnownMember.System_Collections_Generic_IAsyncEnumerable_T__GetAsyncEnumerator), IAsyncEnumerableOfElementType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 38202, 38241);

                    BoundExpression
                    managedThreadId = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 38259, 38422);

                    f_10448_38259_38421(this, IAsyncEnumerableOfElementType_GetEnumerator, ref managedThreadId, initialState: StateMachineStates.InitialAsyncIteratorStateMachine);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 37616, 38437);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_37790_37866(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 37790, 37866);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_37899_37917(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 37899, 37917);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10448_37790_37918(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 37790, 37918);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_38019_38119(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 38019, 38119);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10448_38019_38181(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 38019, 38181);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                    f_10448_38259_38421(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    getEnumeratorMethod, ref Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    managedThreadId, int
                    initialState)
                    {
                        var return_v = this_param.GenerateIteratorGetEnumerator(getEnumeratorMethod, ref managedThreadId, initialState: initialState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 38259, 38421);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 37616, 38437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 37616, 38437);
                }
            }

            protected override void GenerateResetInstance(ArrayBuilder<BoundStatement> builder, int initialState)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 38453, 39323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 38788, 38945);

                    f_10448_38788_38944(                // this.state = {initialState};
                                                        // this.builder = System.Runtime.CompilerServices.AsyncIteratorMethodBuilder.Create();
                                                        // this.disposeMode = false;

                                    builder, f_10448_38875_38943(                    // this.state = {initialState};
                                        F, f_10448_38888_38917(F, f_10448_38896_38904(F), stateField), f_10448_38919_38942(F, initialState)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 38965, 39141);

                    f_10448_38965_39140(
                                    builder, f_10448_39107_39139(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 39161, 39308);

                    f_10448_39161_39307(
                                    builder, f_10448_39240_39306(                    // disposeMode = false;
                                        F, f_10448_39253_39287(F, _disposeModeField), f_10448_39289_39305(F, false)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 38453, 39323);

                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10448_38896_38904(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 38896, 38904);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_38888_38917(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 38888, 38917);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10448_38919_38942(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 38919, 38942);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_38875_38943(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 38875, 38943);
                        return return_v;
                    }


                    int
                    f_10448_38788_38944(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 38788, 38944);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_39107_39139(Microsoft.CodeAnalysis.CSharp.AsyncRewriter.AsyncIteratorRewriter
                    this_param)
                    {
                        var return_v = this_param.GenerateCreateAndAssignBuilder();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 39107, 39139);
                        return return_v;
                    }


                    int
                    f_10448_38965_39140(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 38965, 39140);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10448_39253_39287(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.InstanceField(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 39253, 39287);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10448_39289_39305(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, bool
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 39289, 39305);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10448_39240_39306(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 39240, 39306);
                        return return_v;
                    }


                    int
                    f_10448_39161_39307(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 39161, 39307);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 38453, 39323);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 38453, 39323);
                }
            }

            protected override void GenerateMoveNext(SynthesizedImplementationMethod moveNextMethod)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10448, 39339, 41268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 39460, 39619);

                    MethodSymbol
                    setResultMethod = f_10448_39491_39618(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__SetResult, isOptional: true)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 39637, 39836) || true) && (setResultMethod is { })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10448, 39637, 39836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 39705, 39817);

                        setResultMethod = (MethodSymbol)f_10448_39737_39816(setResultMethod, f_10448_39785_39815(_promiseOfValueOrEndField));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10448, 39637, 39836);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 39856, 40021);

                    MethodSymbol
                    setExceptionMethod = f_10448_39890_40020(F, WellKnownMember.System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__SetException, isOptional: true)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 40039, 40247) || true) && (setExceptionMethod is { })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10448, 40039, 40247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 40110, 40228);

                        setExceptionMethod = (MethodSymbol)f_10448_40145_40227(setExceptionMethod, f_10448_40196_40226(_promiseOfValueOrEndField));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10448, 40039, 40247);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 40267, 41185);

                    var
                    rewriter = f_10448_40282_41184(method: method, methodOrdinal: _methodOrdinal, asyncMethodBuilderMemberCollection: _asyncMethodBuilderMemberCollection, asyncIteratorInfo: f_10448_40552_40693(_promiseOfValueOrEndField, _combinedTokensField, _currentField, _disposeModeField, setResultMethod, setExceptionMethod), F: F, state: stateField, builder: _builderField, hoistedVariables: hoistedVariables, nonReusableLocalProxies: nonReusableLocalProxies, synthesizedLocalOrdinals: synthesizedLocalOrdinals, slotAllocatorOpt: slotAllocatorOpt, nextFreeHoistedLocalSlot: nextFreeHoistedLocalSlot, diagnostics: diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10448, 41205, 41253);

                    f_10448_41205_41252(
                                    rewriter, body, moveNextMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10448, 39339, 41268);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10448_39491_39618(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm, bool
                    isOptional)
                    {
                        var return_v = this_param.WellKnownMethod(wm, isOptional: isOptional);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 39491, 39618);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_39785_39815(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 39785, 39815);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_39737_39816(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    s, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newOwner)
                    {
                        var return_v = s.SymbolAsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 39737, 39816);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10448_39890_40020(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm, bool
                    isOptional)
                    {
                        var return_v = this_param.WellKnownMethod(wm, isOptional: isOptional);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 39890, 40020);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10448_40196_40226(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 40196, 40226);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10448_40145_40227(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    s, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newOwner)
                    {
                        var return_v = s.SymbolAsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 40145, 40227);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo
                    f_10448_40552_40693(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    promiseOfValueOrEndField, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    combinedTokensField, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    currentField, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    disposeModeField, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    setResultMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    setExceptionMethod)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo(promiseOfValueOrEndField, combinedTokensField, currentField, disposeModeField, setResultMethod, setExceptionMethod);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 40552, 40693);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                    f_10448_40282_41184(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, int
                    methodOrdinal, Microsoft.CodeAnalysis.CSharp.AsyncMethodBuilderMemberCollection
                    asyncMethodBuilderMemberCollection, Microsoft.CodeAnalysis.CSharp.AsyncIteratorInfo
                    asyncIteratorInfo, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
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
                        var return_v = new Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter(method: method, methodOrdinal: methodOrdinal, asyncMethodBuilderMemberCollection: asyncMethodBuilderMemberCollection, asyncIteratorInfo: asyncIteratorInfo, F: F, state: state, builder: builder, hoistedVariables: (Roslyn.Utilities.IReadOnlySet<Microsoft.CodeAnalysis.CSharp.Symbol>)hoistedVariables, nonReusableLocalProxies: nonReusableLocalProxies, synthesizedLocalOrdinals: synthesizedLocalOrdinals, slotAllocatorOpt: slotAllocatorOpt, nextFreeHoistedLocalSlot: nextFreeHoistedLocalSlot, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 40282, 41184);
                        return return_v;
                    }


                    int
                    f_10448_41205_41252(Microsoft.CodeAnalysis.CSharp.AsyncIteratorMethodToStateMachineRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    body, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                    moveNextMethod)
                    {
                        this_param.GenerateMoveNext(body, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)moveNextMethod);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 41205, 41252);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10448, 39339, 41268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 39339, 41268);
                }
            }

            static AsyncIteratorRewriter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10448, 795, 41279);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10448, 795, 41279);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 795, 41279);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10448, 795, 41279);

            bool
            f_10448_2068_2176(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            right, Microsoft.CodeAnalysis.TypeCompareKind
            comparison)
            {
                var return_v = TypeSymbol.Equals(left, right, comparison);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 2068, 2176);
                return return_v;
            }


            int
            f_10448_2054_2177(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 2054, 2177);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            f_10448_2254_2281(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.DeclaringCompilation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 2254, 2281);
                return return_v;
            }


            bool
            f_10448_2214_2282(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            method, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            compilation)
            {
                var return_v = method.IsAsyncReturningIAsyncEnumerable(compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 2214, 2282);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            f_10448_2371_2398(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.DeclaringCompilation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10448, 2371, 2398);
                return return_v;
            }


            bool
            f_10448_2331_2399(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            method, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            compilation)
            {
                var return_v = method.IsAsyncReturningIAsyncEnumerator(compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 2331, 2399);
                return return_v;
            }


            int
            f_10448_2301_2400(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10448, 2301, 2400);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.BoundStatement
            f_10448_1926_1930_C(Microsoft.CodeAnalysis.CSharp.BoundStatement
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10448, 1548, 2416);
                return return_v;
            }

        }

        static AsyncRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10448, 568, 41286);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10448, 568, 41286);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10448, 568, 41286);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10448, 568, 41286);
    }
}
