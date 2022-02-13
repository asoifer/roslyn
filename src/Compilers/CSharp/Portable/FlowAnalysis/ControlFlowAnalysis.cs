// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class CSharpControlFlowAnalysis : ControlFlowAnalysis
    {
        private readonly RegionAnalysisContext _context;

        private ImmutableArray<SyntaxNode> _entryPoints;

        private ImmutableArray<SyntaxNode> _exitPoints;

        private object _regionStartPointIsReachable;

        private object _regionEndPointIsReachable;

        private bool? _succeeded;

        internal CSharpControlFlowAnalysis(RegionAnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10884, 1274, 1394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 1146, 1174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 1200, 1226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 1251, 1261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 1364, 1383);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10884, 1274, 1394);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10884, 1274, 1394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10884, 1274, 1394);
            }
        }

        public override ImmutableArray<SyntaxNode> EntryPoints
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10884, 1618, 2226);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 1654, 2171) || true) && (_entryPoints == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10884, 1654, 2171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 1720, 1750);

                        _succeeded = !_context.Failed;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 1772, 2061);

                        var
                        result = (DynAbs.Tracing.TraceSender.Conditional_F1(10884, 1785, 1800) || ((_context.Failed && DynAbs.Tracing.TraceSender.Conditional_F2(10884, 1803, 1835)) || DynAbs.Tracing.TraceSender.Conditional_F3(10884, 1867, 2060))) ? ImmutableArray<SyntaxNode>.Empty : f_10884_1867_2060((f_10884_1893_2040(_context.Compilation, _context.Member, _context.BoundNode, _context.FirstInRegion, _context.LastInRegion, out _succeeded)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 2083, 2152);

                        f_10884_2083_2151(ref _entryPoints, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10884, 1654, 2171);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 2191, 2211);

                    return _entryPoints;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10884, 1618, 2226);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax>
                    f_10884_1893_2040(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                    member, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node, Microsoft.CodeAnalysis.CSharp.BoundNode
                    firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                    lastInRegion, out bool?
                    succeeded)
                    {
                        var return_v = EntryPointsWalker.Analyze(compilation, member, node, firstInRegion, lastInRegion, out succeeded);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10884, 1893, 2040);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                    f_10884_1867_2060(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax>
                    items)
                    {
                        var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10884, 1867, 2060);
                        return return_v;
                    }


                    bool
                    f_10884_2083_2151(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10884, 2083, 2151);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10884, 1539, 2237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10884, 1539, 2237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxNode> ExitPoints
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10884, 2475, 3026);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 2511, 2972) || true) && (_exitPoints == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10884, 2511, 2972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 2576, 2863);

                        var
                        result = (DynAbs.Tracing.TraceSender.Conditional_F1(10884, 2589, 2598) || ((f_10884_2589_2598() && DynAbs.Tracing.TraceSender.Conditional_F2(10884, 2626, 2802)) || DynAbs.Tracing.TraceSender.Conditional_F3(10884, 2830, 2862))) ? f_10884_2626_2802((f_10884_2652_2782(_context.Compilation, _context.Member, _context.BoundNode, _context.FirstInRegion, _context.LastInRegion))) : ImmutableArray<SyntaxNode>.Empty
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 2885, 2953);

                        f_10884_2885_2952(ref _exitPoints, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10884, 2511, 2972);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 2992, 3011);

                    return _exitPoints;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10884, 2475, 3026);

                    bool
                    f_10884_2589_2598()
                    {
                        var return_v = Succeeded;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10884, 2589, 2598);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                    f_10884_2652_2782(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                    member, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node, Microsoft.CodeAnalysis.CSharp.BoundNode
                    firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                    lastInRegion)
                    {
                        var return_v = ExitPointsWalker.Analyze(compilation, member, node, firstInRegion, lastInRegion);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10884, 2652, 2782);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                    f_10884_2626_2802(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                    items)
                    {
                        var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10884, 2626, 2802);
                        return return_v;
                    }


                    bool
                    f_10884_2885_2952(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10884, 2885, 2952);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10884, 2397, 3037);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10884, 2397, 3037);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool EndPointIsReachable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10884, 3457, 3689);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 3493, 3614) || true) && (_regionEndPointIsReachable == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10884, 3493, 3614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 3573, 3595);

                        f_10884_3573_3594(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10884, 3493, 3614);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 3634, 3674);

                    return (bool)_regionEndPointIsReachable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10884, 3457, 3689);

                    int
                    f_10884_3573_3594(Microsoft.CodeAnalysis.CSharp.CSharpControlFlowAnalysis
                    this_param)
                    {
                        this_param.ComputeReachability();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10884, 3573, 3594);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10884, 3250, 3700);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10884, 3250, 3700);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool StartPointIsReachable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10884, 3921, 4157);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 3957, 4080) || true) && (_regionStartPointIsReachable == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10884, 3957, 4080);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 4039, 4061);

                        f_10884_4039_4060(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10884, 3957, 4080);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 4100, 4142);

                    return (bool)_regionStartPointIsReachable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10884, 3921, 4157);

                    int
                    f_10884_4039_4060(Microsoft.CodeAnalysis.CSharp.CSharpControlFlowAnalysis
                    this_param)
                    {
                        this_param.ComputeReachability();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10884, 4039, 4060);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10884, 3712, 4168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10884, 3712, 4168);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void ComputeReachability()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10884, 4180, 4845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 4239, 4277);

                bool
                startIsReachable
                = default(bool),
                endIsReachable
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 4291, 4638) || true) && (f_10884_4295_4304())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10884, 4291, 4638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 4338, 4516);

                    f_10884_4338_4515(_context.Compilation, _context.Member, _context.BoundNode, _context.FirstInRegion, _context.LastInRegion, out startIsReachable, out endIsReachable);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10884, 4291, 4638);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10884, 4291, 4638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 4582, 4623);

                    startIsReachable = endIsReachable = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10884, 4291, 4638);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 4652, 4734);

                f_10884_4652_4733(ref _regionEndPointIsReachable, endIsReachable, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 4748, 4834);

                f_10884_4748_4833(ref _regionStartPointIsReachable, startIsReachable, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10884, 4180, 4845);

                bool
                f_10884_4295_4304()
                {
                    var return_v = Succeeded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10884, 4295, 4304);
                    return return_v;
                }


                int
                f_10884_4338_4515(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion, out bool
                startPointIsReachable, out bool
                endPointIsReachable)
                {
                    RegionReachableWalker.Analyze(compilation, member, node, firstInRegion, lastInRegion, out startPointIsReachable, out endPointIsReachable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10884, 4338, 4515);
                    return 0;
                }


                object?
                f_10884_4652_4733(ref object
                location1, bool
                value, object?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, (object)value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10884, 4652, 4733);
                    return return_v;
                }


                object?
                f_10884_4748_4833(ref object
                location1, bool
                value, object?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, (object)value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10884, 4748, 4833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10884, 4180, 4845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10884, 4180, 4845);
            }
        }

        public override ImmutableArray<SyntaxNode> ReturnStatements
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10884, 5275, 5444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 5311, 5429);

                    return f_10884_5318_5328().WhereAsArray(s => s.IsKind(SyntaxKind.ReturnStatement) || s.IsKind(SyntaxKind.YieldBreakStatement));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10884, 5275, 5444);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                    f_10884_5318_5328()
                    {
                        var return_v = ExitPoints;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10884, 5318, 5328);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10884, 5041, 5455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10884, 5041, 5455);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool Succeeded
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10884, 5806, 6012);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 5842, 5953) || true) && (_succeeded == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10884, 5842, 5953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 5906, 5934);

                        var
                        discarded = f_10884_5922_5933()
                        ;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10884, 5842, 5953);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10884, 5973, 5997);

                    return f_10884_5980_5996(_succeeded);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10884, 5806, 6012);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                    f_10884_5922_5933()
                    {
                        var return_v = EntryPoints;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10884, 5922, 5933);
                        return return_v;
                    }


                    bool
                    f_10884_5980_5996(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10884, 5980, 5996);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10884, 5744, 6023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10884, 5744, 6023);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static CSharpControlFlowAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10884, 877, 6030);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10884, 877, 6030);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10884, 877, 6030);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10884, 877, 6030);
    }
}
