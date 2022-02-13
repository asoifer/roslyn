// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class CSharpDataFlowAnalysis : DataFlowAnalysis
    {
        private readonly RegionAnalysisContext _context;

        private ImmutableArray<ISymbol> _variablesDeclared;

        private HashSet<Symbol> _unassignedVariables;

        private ImmutableArray<ISymbol> _dataFlowsIn;

        private ImmutableArray<ISymbol> _dataFlowsOut;

        private ImmutableArray<ISymbol> _definitelyAssignedOnEntry;

        private ImmutableArray<ISymbol> _definitelyAssignedOnExit;

        private ImmutableArray<ISymbol> _alwaysAssigned;

        private ImmutableArray<ISymbol> _readInside;

        private ImmutableArray<ISymbol> _writtenInside;

        private ImmutableArray<ISymbol> _readOutside;

        private ImmutableArray<ISymbol> _writtenOutside;

        private ImmutableArray<ISymbol> _captured;

        private ImmutableArray<IMethodSymbol> _usedLocalFunctions;

        private ImmutableArray<ISymbol> _capturedInside;

        private ImmutableArray<ISymbol> _capturedOutside;

        private ImmutableArray<ISymbol> _unsafeAddressTaken;

        private HashSet<PrefixUnaryExpressionSyntax> _unassignedVariableAddressOfSyntaxes;

        private bool? _succeeded;

        internal CSharpDataFlowAnalysis(RegionAnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10886, 2228, 2345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 1239, 1259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 2144, 2180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 2205, 2215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 2315, 2334);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10886, 2228, 2345);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 2228, 2345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 2228, 2345);
            }
        }

        public override ImmutableArray<ISymbol> VariablesDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 3052, 3595);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 3088, 3534) || true) && (_variablesDeclared.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 3088, 3534);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 3162, 3418);

                        var
                        result = (DynAbs.Tracing.TraceSender.Conditional_F1(10886, 3175, 3184) || ((f_10886_3175_3184() && DynAbs.Tracing.TraceSender.Conditional_F2(10886, 3212, 3360)) || DynAbs.Tracing.TraceSender.Conditional_F3(10886, 3388, 3417))) ? f_10886_3212_3360(f_10886_3222_3359(_context.Compilation, _context.Member, _context.BoundNode, _context.FirstInRegion, _context.LastInRegion)) : ImmutableArray<ISymbol>.Empty
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 3440, 3515);

                        f_10886_3440_3514(ref _variablesDeclared, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 3088, 3534);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 3554, 3580);

                    return _variablesDeclared;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 3052, 3595);

                    bool
                    f_10886_3175_3184()
                    {
                        var return_v = Succeeded;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 3175, 3184);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10886_3222_3359(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                    member, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node, Microsoft.CodeAnalysis.CSharp.BoundNode
                    firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                    lastInRegion)
                    {
                        var return_v = VariablesDeclaredWalker.Analyze(compilation, member, node, firstInRegion, lastInRegion);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 3222, 3359);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_10886_3212_3360(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                    data)
                    {
                        var return_v = Normalize(data);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 3212, 3360);
                        return return_v;
                    }


                    bool
                    f_10886_3440_3514(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 3440, 3514);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 2710, 3606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 2710, 3606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private HashSet<Symbol> UnassignedVariables
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 3686, 4160);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 3722, 4097) || true) && (_unassignedVariables == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 3722, 4097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 3796, 3988);

                        var
                        result = (DynAbs.Tracing.TraceSender.Conditional_F1(10886, 3809, 3818) || ((f_10886_3809_3818() && DynAbs.Tracing.TraceSender.Conditional_F2(10886, 3846, 3938)) || DynAbs.Tracing.TraceSender.Conditional_F3(10886, 3966, 3987))) ? f_10886_3846_3938(_context.Compilation, _context.Member, _context.BoundNode) : f_10886_3966_3987()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 4010, 4078);

                        f_10886_4010_4077(ref _unassignedVariables, result, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 3722, 4097);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 4117, 4145);

                    return _unassignedVariables;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 3686, 4160);

                    bool
                    f_10886_3809_3818()
                    {
                        var return_v = Succeeded;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 3809, 3818);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10886_3846_3938(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                    member, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node)
                    {
                        var return_v = UnassignedVariablesWalker.Analyze(compilation, member, node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 3846, 3938);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10886_3966_3987()
                    {
                        var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 3966, 3987);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>?
                    f_10886_4010_4077(ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>?
                    location1, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    value, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 4010, 4077);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 3618, 4171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 3618, 4171);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ISymbol> DataFlowsIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 4432, 5058);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 4468, 5003) || true) && (_dataFlowsIn.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 4468, 5003);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 4536, 4566);

                        _succeeded = !_context.Failed;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 4588, 4893);

                        var
                        result = (DynAbs.Tracing.TraceSender.Conditional_F1(10886, 4601, 4616) || ((_context.Failed && DynAbs.Tracing.TraceSender.Conditional_F2(10886, 4619, 4648)) || DynAbs.Tracing.TraceSender.Conditional_F3(10886, 4676, 4892))) ? ImmutableArray<ISymbol>.Empty : f_10886_4676_4892(f_10886_4686_4891(_context.Compilation, _context.Member, _context.BoundNode, _context.FirstInRegion, _context.LastInRegion, f_10886_4818_4837(), f_10886_4839_4874(), out _succeeded))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 4915, 4984);

                        f_10886_4915_4983(ref _dataFlowsIn, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 4468, 5003);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 5023, 5043);

                    return _dataFlowsIn;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 4432, 5058);

                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10886_4818_4837()
                    {
                        var return_v = UnassignedVariables;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 4818, 4837);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
                    f_10886_4839_4874()
                    {
                        var return_v = UnassignedVariableAddressOfSyntaxes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 4839, 4874);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10886_4686_4891(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                    member, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node, Microsoft.CodeAnalysis.CSharp.BoundNode
                    firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                    lastInRegion, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    unassignedVariables, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
                    unassignedVariableAddressOfSyntaxes, out bool?
                    succeeded)
                    {
                        var return_v = DataFlowsInWalker.Analyze(compilation, member, node, firstInRegion, lastInRegion, unassignedVariables, unassignedVariableAddressOfSyntaxes, out succeeded);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 4686, 4891);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_10886_4676_4892(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    data)
                    {
                        var return_v = Normalize((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>)data);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 4676, 4892);
                        return return_v;
                    }


                    bool
                    f_10886_4915_4983(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 4915, 4983);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 4356, 5069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 4356, 5069);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ISymbol> DefinitelyAssignedOnEntry
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 5324, 5368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 5327, 5368);
                    return f_10886_5327_5360(this).onEntry; DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 5324, 5368);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 5324, 5368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 5324, 5368);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ISymbol> DefinitelyAssignedOnExit
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 5622, 5665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 5625, 5665);
                    return f_10886_5625_5658(this).onExit; DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 5622, 5665);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 5622, 5665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 5622, 5665);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private (ImmutableArray<ISymbol> onEntry, ImmutableArray<ISymbol> onExit) ComputeDefinitelyAssignedValues()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 5678, 6894);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 6036, 6804) || true) && (_definitelyAssignedOnExit.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 6036, 6804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 6109, 6157);

                    var
                    entryResult = ImmutableArray<ISymbol>.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 6175, 6222);

                    var
                    exitResult = ImmutableArray<ISymbol>.Empty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 6240, 6577) || true) && (f_10886_6244_6253())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 6240, 6577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 6295, 6454);

                        var (entry, exit) = f_10886_6315_6453(_context.Compilation, _context.Member, _context.BoundNode, _context.FirstInRegion, _context.LastInRegion);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 6476, 6507);

                        entryResult = f_10886_6490_6506(entry);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 6529, 6558);

                        exitResult = f_10886_6542_6557(exit);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 6240, 6577);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 6597, 6685);

                    f_10886_6597_6684(ref _definitelyAssignedOnEntry, entryResult);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 6703, 6789);

                    f_10886_6703_6788(ref _definitelyAssignedOnExit, exitResult);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 6036, 6804);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 6820, 6883);

                return (_definitelyAssignedOnEntry, _definitelyAssignedOnExit);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 5678, 6894);

                bool
                f_10886_6244_6253()
                {
                    var return_v = Succeeded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 6244, 6253);
                    return return_v;
                }


                (System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol> entry, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol> exit)
                f_10886_6315_6453(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion)
                {
                    var return_v = DefinitelyAssignedWalker.Analyze(compilation, member, node, firstInRegion, lastInRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 6315, 6453);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10886_6490_6506(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                data)
                {
                    var return_v = Normalize((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 6490, 6506);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10886_6542_6557(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                data)
                {
                    var return_v = Normalize((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 6542, 6557);
                    return return_v;
                }


                bool
                f_10886_6597_6684(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 6597, 6684);
                    return return_v;
                }


                bool
                f_10886_6703_6788(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 6703, 6788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 5678, 6894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 5678, 6894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<ISymbol> DataFlowsOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 7264, 7904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 7300, 7328);

                    var
                    discarded = f_10886_7316_7327()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 7382, 7848) || true) && (_dataFlowsOut.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 7382, 7848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 7451, 7737);

                        var
                        result = (DynAbs.Tracing.TraceSender.Conditional_F1(10886, 7464, 7473) || ((f_10886_7464_7473() && DynAbs.Tracing.TraceSender.Conditional_F2(10886, 7501, 7679)) || DynAbs.Tracing.TraceSender.Conditional_F3(10886, 7707, 7736))) ? f_10886_7501_7679(f_10886_7511_7678(_context.Compilation, _context.Member, _context.BoundNode, _context.FirstInRegion, _context.LastInRegion, f_10886_7644_7663(), _dataFlowsIn)) : ImmutableArray<ISymbol>.Empty
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 7759, 7829);

                        f_10886_7759_7828(ref _dataFlowsOut, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 7382, 7848);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 7868, 7889);

                    return _dataFlowsOut;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 7264, 7904);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_10886_7316_7327()
                    {
                        var return_v = DataFlowsIn;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 7316, 7327);
                        return return_v;
                    }


                    bool
                    f_10886_7464_7473()
                    {
                        var return_v = Succeeded;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 7464, 7473);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10886_7644_7663()
                    {
                        var return_v = UnassignedVariables;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 7644, 7663);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10886_7511_7678(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                    member, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node, Microsoft.CodeAnalysis.CSharp.BoundNode
                    firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                    lastInRegion, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    unassignedVariables, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    dataFlowsIn)
                    {
                        var return_v = DataFlowsOutWalker.Analyze(compilation, member, node, firstInRegion, lastInRegion, unassignedVariables, dataFlowsIn);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 7511, 7678);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_10886_7501_7679(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    data)
                    {
                        var return_v = Normalize((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>)data);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 7501, 7679);
                        return return_v;
                    }


                    bool
                    f_10886_7759_7828(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 7759, 7828);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 7187, 7915);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 7187, 7915);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ISymbol> AlwaysAssigned
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 8158, 8689);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 8194, 8631) || true) && (_alwaysAssigned.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 8194, 8631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 8265, 8518);

                        var
                        result = (DynAbs.Tracing.TraceSender.Conditional_F1(10886, 8278, 8287) || ((f_10886_8278_8287() && DynAbs.Tracing.TraceSender.Conditional_F2(10886, 8315, 8460)) || DynAbs.Tracing.TraceSender.Conditional_F3(10886, 8488, 8517))) ? f_10886_8315_8460(f_10886_8325_8459(_context.Compilation, _context.Member, _context.BoundNode, _context.FirstInRegion, _context.LastInRegion)) : ImmutableArray<ISymbol>.Empty
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 8540, 8612);

                        f_10886_8540_8611(ref _alwaysAssigned, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 8194, 8631);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 8651, 8674);

                    return _alwaysAssigned;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 8158, 8689);

                    bool
                    f_10886_8278_8287()
                    {
                        var return_v = Succeeded;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 8278, 8287);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10886_8325_8459(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                    member, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node, Microsoft.CodeAnalysis.CSharp.BoundNode
                    firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                    lastInRegion)
                    {
                        var return_v = AlwaysAssignedWalker.Analyze(compilation, member, node, firstInRegion, lastInRegion);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 8325, 8459);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_10886_8315_8460(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                    data)
                    {
                        var return_v = Normalize(data);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 8315, 8460);
                        return return_v;
                    }


                    bool
                    f_10886_8540_8611(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 8540, 8611);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 8079, 8700);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 8079, 8700);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ISymbol> ReadInside
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 8916, 9111);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 8952, 9057) || true) && (_readInside.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 8952, 9057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 9019, 9038);

                        f_10886_9019_9037(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 8952, 9057);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 9077, 9096);

                    return _readInside;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 8916, 9111);

                    int
                    f_10886_9019_9037(Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
                    this_param)
                    {
                        this_param.AnalyzeReadWrite();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 9019, 9037);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 8841, 9122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 8841, 9122);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ISymbol> WrittenInside
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 9340, 9541);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 9376, 9484) || true) && (_writtenInside.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 9376, 9484);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 9446, 9465);

                        f_10886_9446_9464(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 9376, 9484);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 9504, 9526);

                    return _writtenInside;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 9340, 9541);

                    int
                    f_10886_9446_9464(Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
                    this_param)
                    {
                        this_param.AnalyzeReadWrite();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 9446, 9464);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 9262, 9552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 9262, 9552);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ISymbol> ReadOutside
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 9770, 9967);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 9806, 9912) || true) && (_readOutside.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 9806, 9912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 9874, 9893);

                        f_10886_9874_9892(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 9806, 9912);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 9932, 9952);

                    return _readOutside;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 9770, 9967);

                    int
                    f_10886_9874_9892(Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
                    this_param)
                    {
                        this_param.AnalyzeReadWrite();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 9874, 9892);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 9694, 9978);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 9694, 9978);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ISymbol> WrittenOutside
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 10198, 10401);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 10234, 10343) || true) && (_writtenOutside.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 10234, 10343);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 10305, 10324);

                        f_10886_10305_10323(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 10234, 10343);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 10363, 10386);

                    return _writtenOutside;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 10198, 10401);

                    int
                    f_10886_10305_10323(Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
                    this_param)
                    {
                        this_param.AnalyzeReadWrite();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 10305, 10323);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 10119, 10412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 10119, 10412);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void AnalyzeReadWrite()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 10424, 12558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 10480, 10618);

                IEnumerable<Symbol>
                readInside
                = default(IEnumerable<Symbol>),
                writtenInside
                = default(IEnumerable<Symbol>),
                readOutside
                = default(IEnumerable<Symbol>),
                writtenOutside
                = default(IEnumerable<Symbol>),
                captured
                = default(IEnumerable<Symbol>),
                unsafeAddressTaken
                = default(IEnumerable<Symbol>),
                capturedInside
                = default(IEnumerable<Symbol>),
                capturedOutside
                = default(IEnumerable<Symbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 10632, 10677);

                IEnumerable<MethodSymbol>
                usedLocalFunctions
                = default(IEnumerable<MethodSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 10691, 11610) || true) && (f_10886_10695_10704())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 10691, 11610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 10738, 11303);

                    f_10886_10738_11302(_context.Compilation, _context.Member, _context.BoundNode, _context.FirstInRegion, _context.LastInRegion, f_10886_10868_10903(), readInside: out readInside, writtenInside: out writtenInside, readOutside: out readOutside, writtenOutside: out writtenOutside, captured: out captured, unsafeAddressTaken: out unsafeAddressTaken, capturedInside: out capturedInside, capturedOutside: out capturedOutside, usedLocalFunctions: out usedLocalFunctions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 10691, 11610);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 10691, 11610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 11369, 11523);

                    readInside = writtenInside = readOutside = writtenOutside = captured = unsafeAddressTaken = capturedInside = capturedOutside = f_10886_11496_11522();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 11541, 11595);

                    usedLocalFunctions = f_10886_11562_11594();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 10691, 11610);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 11626, 11709);

                f_10886_11626_11708(ref _readInside, f_10886_11686_11707(readInside));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 11723, 11812);

                f_10886_11723_11811(ref _writtenInside, f_10886_11786_11810(writtenInside));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 11826, 11911);

                f_10886_11826_11910(ref _readOutside, f_10886_11887_11909(readOutside));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 11925, 12016);

                f_10886_11925_12015(ref _writtenOutside, f_10886_11989_12014(writtenOutside));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 12030, 12109);

                f_10886_12030_12108(ref _captured, f_10886_12088_12107(captured));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 12123, 12214);

                f_10886_12123_12213(ref _capturedInside, f_10886_12187_12212(capturedInside));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 12228, 12321);

                f_10886_12228_12320(ref _capturedOutside, f_10886_12293_12319(capturedOutside));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 12335, 12434);

                f_10886_12335_12433(ref _unsafeAddressTaken, f_10886_12403_12432(unsafeAddressTaken));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 12448, 12547);

                f_10886_12448_12546(ref _usedLocalFunctions, f_10886_12516_12545(usedLocalFunctions));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 10424, 12558);

                bool
                f_10886_10695_10704()
                {
                    var return_v = Succeeded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 10695, 10704);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
                f_10886_10868_10903()
                {
                    var return_v = UnassignedVariableAddressOfSyntaxes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 10868, 10903);
                    return return_v;
                }


                int
                f_10886_10738_11302(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
                unassignedVariableAddressOfSyntaxes, out System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                readInside, out System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                writtenInside, out System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                readOutside, out System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                writtenOutside, out System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                captured, out System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                unsafeAddressTaken, out System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                capturedInside, out System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                capturedOutside, out System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                usedLocalFunctions)
                {
                    ReadWriteWalker.Analyze(compilation, member, node, firstInRegion, lastInRegion, unassignedVariableAddressOfSyntaxes, out readInside, out writtenInside, out readOutside, out writtenOutside, out captured, out unsafeAddressTaken, out capturedInside, out capturedOutside, out usedLocalFunctions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 10738, 11302);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10886_11496_11522()
                {
                    var return_v = Enumerable.Empty<Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 11496, 11522);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10886_11562_11594()
                {
                    var return_v = Enumerable.Empty<MethodSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 11562, 11594);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10886_11686_11707(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                data)
                {
                    var return_v = Normalize(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 11686, 11707);
                    return return_v;
                }


                bool
                f_10886_11626_11708(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 11626, 11708);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10886_11786_11810(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                data)
                {
                    var return_v = Normalize(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 11786, 11810);
                    return return_v;
                }


                bool
                f_10886_11723_11811(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 11723, 11811);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10886_11887_11909(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                data)
                {
                    var return_v = Normalize(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 11887, 11909);
                    return return_v;
                }


                bool
                f_10886_11826_11910(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 11826, 11910);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10886_11989_12014(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                data)
                {
                    var return_v = Normalize(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 11989, 12014);
                    return return_v;
                }


                bool
                f_10886_11925_12015(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 11925, 12015);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10886_12088_12107(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                data)
                {
                    var return_v = Normalize(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 12088, 12107);
                    return return_v;
                }


                bool
                f_10886_12030_12108(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 12030, 12108);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10886_12187_12212(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                data)
                {
                    var return_v = Normalize(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 12187, 12212);
                    return return_v;
                }


                bool
                f_10886_12123_12213(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 12123, 12213);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10886_12293_12319(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                data)
                {
                    var return_v = Normalize(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 12293, 12319);
                    return return_v;
                }


                bool
                f_10886_12228_12320(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 12228, 12320);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10886_12403_12432(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                data)
                {
                    var return_v = Normalize(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 12403, 12432);
                    return return_v;
                }


                bool
                f_10886_12335_12433(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 12335, 12433);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                f_10886_12516_12545(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                data)
                {
                    var return_v = Normalize(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 12516, 12545);
                    return return_v;
                }


                bool
                f_10886_12448_12546(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 12448, 12546);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 10424, 12558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 10424, 12558);
            }
        }

        public override ImmutableArray<ISymbol> Captured
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 12886, 13077);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 12922, 13025) || true) && (_captured.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 12922, 13025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 12987, 13006);

                        f_10886_12987_13005(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 12922, 13025);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 13045, 13062);

                    return _captured;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 12886, 13077);

                    int
                    f_10886_12987_13005(Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
                    this_param)
                    {
                        this_param.AnalyzeReadWrite();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 12987, 13005);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 12813, 13088);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 12813, 13088);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ISymbol> CapturedInside
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 13179, 13382);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 13215, 13324) || true) && (_capturedInside.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 13215, 13324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 13286, 13305);

                        f_10886_13286_13304(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 13215, 13324);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 13344, 13367);

                    return _capturedInside;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 13179, 13382);

                    int
                    f_10886_13286_13304(Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
                    this_param)
                    {
                        this_param.AnalyzeReadWrite();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 13286, 13304);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 13100, 13393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 13100, 13393);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ISymbol> CapturedOutside
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 13485, 13690);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 13521, 13631) || true) && (_capturedOutside.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 13521, 13631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 13593, 13612);

                        f_10886_13593_13611(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 13521, 13631);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 13651, 13675);

                    return _capturedOutside;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 13485, 13690);

                    int
                    f_10886_13593_13611(Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
                    this_param)
                    {
                        this_param.AnalyzeReadWrite();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 13593, 13611);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 13405, 13701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 13405, 13701);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ISymbol> UnsafeAddressTaken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 14175, 14386);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 14211, 14324) || true) && (_unsafeAddressTaken.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 14211, 14324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 14286, 14305);

                        f_10886_14286_14304(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 14211, 14324);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 14344, 14371);

                    return _unsafeAddressTaken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 14175, 14386);

                    int
                    f_10886_14286_14304(Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
                    this_param)
                    {
                        this_param.AnalyzeReadWrite();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 14286, 14304);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 14092, 14397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 14092, 14397);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<IMethodSymbol> UsedLocalFunctions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 14498, 14709);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 14534, 14647) || true) && (_usedLocalFunctions.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 14534, 14647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 14609, 14628);

                        f_10886_14609_14627(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 14534, 14647);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 14667, 14694);

                    return _usedLocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 14498, 14709);

                    int
                    f_10886_14609_14627(Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
                    this_param)
                    {
                        this_param.AnalyzeReadWrite();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 14609, 14627);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 14409, 14720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 14409, 14720);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private HashSet<PrefixUnaryExpressionSyntax> UnassignedVariableAddressOfSyntaxes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 14837, 15392);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 14873, 15313) || true) && (_unassignedVariableAddressOfSyntaxes == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 14873, 15313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 14963, 15188);

                        var
                        result = (DynAbs.Tracing.TraceSender.Conditional_F1(10886, 14976, 14985) || ((f_10886_14976_14985() && DynAbs.Tracing.TraceSender.Conditional_F2(10886, 15013, 15117)) || DynAbs.Tracing.TraceSender.Conditional_F3(10886, 15145, 15187))) ? f_10886_15013_15117(_context.Compilation, _context.Member, _context.BoundNode) : f_10886_15145_15187()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 15210, 15294);

                        f_10886_15210_15293(ref _unassignedVariableAddressOfSyntaxes, result, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 14873, 15313);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 15333, 15377);

                    return _unassignedVariableAddressOfSyntaxes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 14837, 15392);

                    bool
                    f_10886_14976_14985()
                    {
                        var return_v = Succeeded;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 14976, 14985);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
                    f_10886_15013_15117(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                    member, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node)
                    {
                        var return_v = UnassignedAddressTakenVariablesWalker.Analyze(compilation, member, node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 15013, 15117);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
                    f_10886_15145_15187()
                    {
                        var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 15145, 15187);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>?
                    f_10886_15210_15293(ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>?
                    location1, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
                    value, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 15210, 15293);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 14732, 15403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 14732, 15403);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10886, 15754, 15960);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 15790, 15901) || true) && (_succeeded == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10886, 15790, 15901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 15854, 15882);

                        var
                        discarded = f_10886_15870_15881()
                        ;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10886, 15790, 15901);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 15921, 15945);

                    return f_10886_15928_15944(_succeeded);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10886, 15754, 15960);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_10886_15870_15881()
                    {
                        var return_v = DataFlowsIn;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 15870, 15881);
                        return return_v;
                    }


                    bool
                    f_10886_15928_15944(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10886, 15928, 15944);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 15692, 15971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 15692, 15971);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static ImmutableArray<ISymbol> Normalize(IEnumerable<Symbol> data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10886, 15983, 16241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 16082, 16230);

                return f_10886_16089_16229(f_10886_16116_16228(f_10886_16116_16209(f_10886_16116_16156(data, s => s.CanBeReferencedByName), s => s, LexicalOrderSymbolComparer.Instance)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10886, 15983, 16241);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10886_16116_16156(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.CSharp.Symbol>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 16116, 16156);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10886_16116_16209(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                keySelector, Microsoft.CodeAnalysis.CSharp.LexicalOrderSymbolComparer
                comparer)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>(keySelector, (System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 16116, 16209);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol?>
                f_10886_16116_16228(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = symbols.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 16116, 16228);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol?>
                f_10886_16089_16229(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol?>
                items)
                {
                    var return_v = ImmutableArray.CreateRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 16089, 16229);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 15983, 16241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 15983, 16241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<IMethodSymbol> Normalize(IEnumerable<MethodSymbol> data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10886, 16253, 16537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10886, 16364, 16526);

                return f_10886_16371_16525(f_10886_16398_16524(f_10886_16398_16491(f_10886_16398_16438(data, s => s.CanBeReferencedByName), s => s, LexicalOrderSymbolComparer.Instance), p => p.GetPublicSymbol()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10886, 16253, 16537);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10886_16398_16438(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 16398, 16438);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10886_16398_16491(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                keySelector, Microsoft.CodeAnalysis.CSharp.LexicalOrderSymbolComparer
                comparer)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbol>(keySelector, (System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 16398, 16491);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IMethodSymbol>
                f_10886_16398_16524(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.IMethodSymbol>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.IMethodSymbol>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 16398, 16524);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                f_10886_16371_16525(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IMethodSymbol>
                items)
                {
                    var return_v = ImmutableArray.CreateRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 16371, 16525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10886, 16253, 16537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 16253, 16537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpDataFlowAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10886, 1021, 16544);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10886, 1021, 16544);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10886, 1021, 16544);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10886, 1021, 16544);

        (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol> onEntry, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol> onExit)
        f_10886_5327_5360(Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
        this_param)
        {
            var return_v = this_param.ComputeDefinitelyAssignedValues();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 5327, 5360);
            return return_v;
        }


        (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol> onEntry, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol> onExit)
        f_10886_5625_5658(Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
        this_param)
        {
            var return_v = this_param.ComputeDefinitelyAssignedValues();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10886, 5625, 5658);
            return return_v;
        }

    }
}
