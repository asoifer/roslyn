// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class ControlFlowPass : AbstractFlowPass<ControlFlowPass.LocalState, ControlFlowPass.LocalFunctionState>
    {
        private readonly PooledDictionary<LabelSymbol, BoundBlock> _labelsDefined;

        private readonly PooledHashSet<LabelSymbol> _labelsUsed;

        protected bool _convertInsufficientExecutionStackExceptionToCancelledByStackGuardException;

        private readonly ArrayBuilder<(LocalSymbol symbol, BoundBlock block)> _usingDeclarations;

        private BoundBlock _currentBlock;

        protected override void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 1257, 1444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 1312, 1334);

                f_10885_1312_1333(_labelsDefined);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 1348, 1367);

                f_10885_1348_1366(_labelsUsed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 1381, 1407);

                f_10885_1381_1406(_usingDeclarations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 1421, 1433);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 10885, 1421, 1432);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 1257, 1444);

                int
                f_10885_1312_1333(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 1312, 1333);
                    return 0;
                }


                int
                f_10885_1348_1366(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 1348, 1366);
                    return 0;
                }


                int
                f_10885_1381_1406(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol symbol, Microsoft.CodeAnalysis.CSharp.BoundBlock block)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 1381, 1406);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 1257, 1444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 1257, 1444);
            }
        }

        internal ControlFlowPass(CSharpCompilation compilation, Symbol member, BoundNode node)
        : base(f_10885_1563_1574_C(compilation), member, node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10885, 1456, 1611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 686, 758);
                this._labelsDefined = f_10885_703_758(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 813, 867);
                this._labelsUsed = f_10885_827_867(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 893, 976);
                this._convertInsufficientExecutionStackExceptionToCancelledByStackGuardException = false; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 1120, 1194);
                this._usingDeclarations = f_10885_1141_1194(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 1224, 1244);
                this._currentBlock = null; DynAbs.Tracing.TraceSender.TraceExitConstructor(10885, 1456, 1611);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 1456, 1611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 1456, 1611);
            }
        }

        internal ControlFlowPass(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion)
        : base(f_10885_1779_1790_C(compilation), member, node, firstInRegion, lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10885, 1623, 1856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 686, 758);
                this._labelsDefined = f_10885_703_758(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 813, 867);
                this._labelsUsed = f_10885_827_867(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 893, 976);
                this._convertInsufficientExecutionStackExceptionToCancelledByStackGuardException = false; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 1120, 1194);
                this._usingDeclarations = f_10885_1141_1194(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 1224, 1244);
                this._currentBlock = null; DynAbs.Tracing.TraceSender.TraceExitConstructor(10885, 1623, 1856);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 1623, 1856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 1623, 1856);
            }
        }

        internal struct LocalState : ILocalState
        {

            internal bool Alive;

            internal bool Reported;

            internal LocalState(bool live, bool reported)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10885, 2040, 2194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 2118, 2136);

                    this.Alive = live;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 2154, 2179);

                    this.Reported = reported;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10885, 2040, 2194);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 2040, 2194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 2040, 2194);
                }
            }

            public LocalState Clone()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 2368, 2453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 2426, 2438);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 2368, 2453);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 2368, 2453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 2368, 2453);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Reachable
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 2523, 2544);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 2529, 2542);

                        return Alive;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 2523, 2544);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 2469, 2559);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 2469, 2559);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            static LocalState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10885, 1868, 2570);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10885, 1868, 2570);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 1868, 2570);
            }
        }
        internal sealed class LocalFunctionState : AbstractLocalFunctionState
        {
            public LocalFunctionState(LocalState unreachableState)
            : base(f_10885_2755_2779_C(unreachableState.Clone()), unreachableState.Clone())
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10885, 2676, 2823);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10885, 2676, 2823);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 2676, 2823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 2676, 2823);
                }
            }

            static LocalFunctionState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10885, 2582, 2834);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10885, 2582, 2834);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 2582, 2834);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10885, 2582, 2834);

            static Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState
            f_10885_2755_2779_C(Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10885, 2676, 2823);
                return return_v;
            }

        }

        protected override LocalFunctionState CreateLocalFunctionState(LocalFunctionSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 2937, 2982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 2940, 2982);
                return f_10885_2940_2982(f_10885_2963_2981(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 2937, 2982);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 2937, 2982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 2937, 2982);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState
            f_10885_2963_2981(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
            this_param)
            {
                var return_v = this_param.UnreachableState();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 2963, 2981);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState
            f_10885_2940_2982(Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState
            unreachableState)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState(unreachableState);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 2940, 2982);
                return return_v;
            }

        }

        protected override bool Meet(ref LocalState self, ref LocalState other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 2995, 3306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3091, 3106);

                var
                old = self
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3120, 3146);

                self.Alive &= other.Alive;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3160, 3192);

                self.Reported &= other.Reported;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3206, 3250);

                f_10885_3206_3249(!self.Alive || (DynAbs.Tracing.TraceSender.Expression_False(10885, 3219, 3248) || !self.Reported));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3264, 3295);

                return self.Alive != old.Alive;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 2995, 3306);

                int
                f_10885_3206_3249(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 3206, 3249);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 2995, 3306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 2995, 3306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool Join(ref LocalState self, ref LocalState other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 3318, 3629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3414, 3429);

                var
                old = self
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3443, 3469);

                self.Alive |= other.Alive;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3483, 3515);

                self.Reported &= other.Reported;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3529, 3573);

                f_10885_3529_3572(!self.Alive || (DynAbs.Tracing.TraceSender.Expression_False(10885, 3542, 3571) || !self.Reported));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3587, 3618);

                return self.Alive != old.Alive;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 3318, 3629);

                int
                f_10885_3529_3572(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 3529, 3572);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 3318, 3629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 3318, 3629);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override string Dump(LocalState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 3641, 3797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3714, 3786);

                return "[alive: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (state.Alive).ToString(), 10885, 3734, 3745) + "; reported: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (state.Reported).ToString(), 10885, 3765, 3779) + "]";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 3641, 3797);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 3641, 3797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 3641, 3797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalState TopState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 3809, 3920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 3874, 3909);

                return f_10885_3881_3908(true, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 3809, 3920);

                Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState
                f_10885_3881_3908(bool
                live, bool
                reported)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState(live, reported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 3881, 3908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 3809, 3920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 3809, 3920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalState UnreachableState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 3932, 4066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 4005, 4055);

                return f_10885_4012_4054(false, this.State.Reported);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 3932, 4066);

                Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState
                f_10885_4012_4054(bool
                live, bool
                reported)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState(live, reported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 4012, 4054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 3932, 4066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 3932, 4066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalState LabelState(LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 4078, 4377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 4162, 4205);

                LocalState
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.LabelState(label), 10885, 4182, 4204)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 4314, 4338);

                result.Reported = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 4352, 4366);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 4078, 4377);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 4078, 4377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 4078, 4377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode Visit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 4389, 4822);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 4680, 4783) || true) && (!(node is BoundExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 4680, 4783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 4744, 4768);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10885, 4751, 4767);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 4680, 4783);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 4799, 4811);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 4389, 4822);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 4389, 4822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 4389, 4822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<PendingBranch> Scan(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 4834, 5347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 4932, 4957);

                f_10885_4932_4956(f_10885_4932_4948(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 5002, 5040);

                // LAFHIS
                //var result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Scan(ref badRegion), 10885, 5015, 5039);
                var result = base.Scan(ref badRegion);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 5015, 5039);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 5054, 5306);
                    foreach (var label in f_10885_5076_5095_I(f_10885_5076_5095(_labelsDefined)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 5054, 5306);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 5129, 5291) || true) && (!f_10885_5134_5161(_labelsUsed, label))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 5129, 5291);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 5203, 5272);

                            f_10885_5203_5271(f_10885_5203_5214(), ErrorCode.WRN_UnreferencedLabel, f_10885_5252_5267(label)[0]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 5129, 5291);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 5054, 5306);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10885, 1, 253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10885, 1, 253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 5322, 5336);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 4834, 5347);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10885_4932_4948(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 4932, 4948);
                    return return_v;
                }


                int
                f_10885_4932_4956(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 4932, 4956);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock>.KeyCollection
                f_10885_5076_5095(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 5076, 5095);
                    return return_v;
                }


                bool
                f_10885_5134_5161(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 5134, 5161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10885_5203_5214()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 5203, 5214);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10885_5252_5267(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 5252, 5267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10885_5203_5271(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 5203, 5271);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock>.KeyCollection
                f_10885_5076_5095_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 5076, 5095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 4834, 5347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 4834, 5347);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Analyze(CSharpCompilation compilation, Symbol member, BoundBlock block, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10885, 5559, 6477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 5701, 5762);

                var
                walker = f_10885_5714_5761(compilation, member, block)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 5778, 5940) || true) && (diagnostics != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 5778, 5940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 5835, 5925);

                    walker._convertInsufficientExecutionStackExceptionToCancelledByStackGuardException = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 5778, 5940);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 5992, 6015);

                    bool
                    badRegion = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 6033, 6089);

                    var
                    result = f_10885_6046_6088(walker, ref badRegion, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 6107, 6132);

                    f_10885_6107_6131(!badRegion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 6150, 6164);

                    return result;
                }
                catch (BoundTreeVisitor.CancelledByStackGuardException ex) when (diagnostics != null)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10885, 6193, 6383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 6311, 6338);

                    f_10885_6311_6337(ex, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 6356, 6368);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10885, 6193, 6383);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10885, 6397, 6466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 6437, 6451);

                    f_10885_6437_6450(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10885, 6397, 6466);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10885, 5559, 6477);

                Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                f_10885_5714_5761(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ControlFlowPass(compilation, member, (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 5714, 5761);
                    return return_v;
                }


                bool
                f_10885_6046_6088(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param, ref bool
                badRegion, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics)
                {
                    var return_v = this_param.Analyze(ref badRegion, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 6046, 6088);
                    return return_v;
                }


                int
                f_10885_6107_6131(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 6107, 6131);
                    return 0;
                }


                int
                f_10885_6311_6337(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddAnError(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 6311, 6337);
                    return 0;
                }


                int
                f_10885_6437_6450(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 6437, 6450);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 5559, 6477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 5559, 6477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool ConvertInsufficientExecutionStackExceptionToCancelledByStackGuardException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 6489, 6708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 6614, 6697);

                return _convertInsufficientExecutionStackExceptionToCancelledByStackGuardException;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 6489, 6708);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 6489, 6708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 6489, 6708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool Analyze(ref bool badRegion, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 6938, 7376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 7032, 7095);

                ImmutableArray<PendingBranch>
                returns = f_10885_7072_7094(this, ref badRegion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 7111, 7222) || true) && (diagnostics != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 7111, 7222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 7168, 7207);

                    f_10885_7168_7206(diagnostics, f_10885_7189_7205(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 7111, 7222);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 7346, 7365);

                return State.Alive;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 6938, 7376);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                f_10885_7072_7094(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 7072, 7094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10885_7189_7205(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 7189, 7205);
                    return return_v;
                }


                int
                f_10885_7168_7206(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 7168, 7206);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 6938, 7376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 6938, 7376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<PendingBranch> RemoveReturns()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 7388, 8840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 7477, 7511);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.RemoveReturns(), 10885, 7490, 7510)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 7525, 8801);
                    foreach (var pending in f_10885_7549_7555_I(result))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 7525, 8801);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 7589, 7685) || true) && (pending.Branch is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 7589, 7685);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 7657, 7666);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 7589, 7685);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 7705, 8786);

                        switch (f_10885_7713_7732(pending.Branch))
                        {

                            case BoundKind.GotoStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 7705, 8786);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 7860, 7887);

                                    var
                                    leave = pending.Branch
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 7917, 7976);

                                    var
                                    loc = f_10885_7927_7975(f_10885_7946_7974(leave.Syntax))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 8006, 8105);

                                    f_10885_8006_8104(f_10885_8006_8017(), ErrorCode.ERR_LabelNotFound, loc, f_10885_8056_8103(f_10885_8056_8098(((BoundGotoStatement)pending.Branch))));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10885, 8135, 8141);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 7705, 8786);

                            case BoundKind.BreakStatement:
                            case BoundKind.ContinueStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 7705, 8786);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 8332, 8359);

                                    var
                                    leave = pending.Branch
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 8389, 8448);

                                    var
                                    loc = f_10885_8399_8447(f_10885_8418_8446(leave.Syntax))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 8478, 8531);

                                    f_10885_8478_8530(f_10885_8478_8489(), ErrorCode.ERR_BadDelegateLeave, loc);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10885, 8561, 8567);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 7705, 8786);

                            case BoundKind.ReturnStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 7705, 8786);
                                DynAbs.Tracing.TraceSender.TraceBreak(10885, 8673, 8679);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 7705, 8786);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 7705, 8786);
                                DynAbs.Tracing.TraceSender.TraceBreak(10885, 8735, 8741);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 7705, 8786);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 7525, 8801);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10885, 1, 1277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10885, 1, 1277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 8815, 8829);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 7388, 8840);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10885_7713_7732(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 7713, 7732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10885_7946_7974(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 7946, 7974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10885_7927_7975(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 7927, 7975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10885_8006_8017()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 8006, 8017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10885_8056_8098(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 8056, 8098);
                    return return_v;
                }


                string
                f_10885_8056_8103(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 8056, 8103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10885_8006_8104(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 8006, 8104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10885_8418_8446(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 8418, 8446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10885_8399_8447(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 8399, 8447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10885_8478_8489()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 8478, 8489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10885_8478_8530(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 8478, 8530);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                f_10885_7549_7555_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 7549, 7555);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 7388, 8840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 7388, 8840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void VisitStatement(BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 8852, 9633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 8941, 9622);

                switch (f_10885_8949_8963(statement))
                {

                    case BoundKind.NoOpStatement:
                    case BoundKind.Block:
                    case BoundKind.ThrowStatement:
                    case BoundKind.LabeledStatement:
                    case BoundKind.LocalFunctionStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 8941, 9622);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 9241, 9272);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitStatement(statement), 10885, 9241, 9271);
                        DynAbs.Tracing.TraceSender.TraceBreak(10885, 9294, 9300);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 8941, 9622);

                    case BoundKind.StatementList:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 8941, 9622);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 9369, 9424);

                        // LAFHIS
                        //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitStatementList(statement), 10885, 9369, 9423);
                        base.VisitStatementList((BoundStatementList)statement);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 9369, 9423);
                        DynAbs.Tracing.TraceSender.TraceBreak(10885, 9446, 9452);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 8941, 9622);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 8941, 9622);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 9500, 9526);

                        f_10885_9500_9525(this, statement);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 9548, 9579);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitStatement(statement), 10885, 9548, 9578);
                        DynAbs.Tracing.TraceSender.TraceBreak(10885, 9601, 9607);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 8941, 9622);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 8852, 9633);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10885_8949_8963(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 8949, 8963);
                    return return_v;
                }


                int
                f_10885_9500_9525(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.CheckReachable(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 9500, 9525);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 8852, 9633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 8852, 9633);
            }
        }

        private void CheckReachable(BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 9645, 10143);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 9723, 10132) || true) && (!this.State.Alive && (DynAbs.Tracing.TraceSender.Expression_True(10885, 9727, 9785) && !this.State.Reported) && (DynAbs.Tracing.TraceSender.Expression_True(10885, 9727, 9837) && f_10885_9806_9837_M(!statement.WasCompilerGenerated)) && (DynAbs.Tracing.TraceSender.Expression_True(10885, 9727, 9891) && statement.Syntax.Span.Length != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 9723, 10132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 9925, 9975);

                    var
                    firstToken = f_10885_9942_9974(statement.Syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 9993, 10072);

                    f_10885_9993_10071(f_10885_9993_10004(), ErrorCode.WRN_UnreachableCode, f_10885_10040_10070(firstToken));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 10090, 10117);

                    this.State.Reported = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 9723, 10132);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 9645, 10143);

                bool
                f_10885_9806_9837_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 9806, 9837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10885_9942_9974(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 9942, 9974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10885_9993_10004()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 9993, 10004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10885_10040_10070(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 10040, 10070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10885_9993_10071(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 9993, 10071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 9645, 10143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 9645, 10143);
            }
        }

        protected override void VisitTryBlock(BoundStatement tryBlock, BoundTryStatement node, ref LocalState tryState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 10155, 10651);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 10291, 10442) || true) && (node.CatchBlocks.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 10291, 10442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 10353, 10402);

                    // LAFHIS
                    //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitTryBlock(tryBlock, node, ref tryState), 10885, 10353, 10401);
                    base.VisitTryBlock(tryBlock, node, ref tryState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 10353, 10401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 10420, 10427);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 10291, 10442);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 10458, 10489);

                var
                oldPending = f_10885_10475_10488(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 10550, 10599);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitTryBlock(tryBlock, node, ref tryState), 10885, 10550, 10598);
                base.VisitTryBlock(tryBlock, node, ref tryState);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 10550, 10598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 10613, 10640);

                f_10885_10613_10639(this, oldPending);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 10155, 10651);

                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                f_10885_10475_10488(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 10475, 10488);
                    return return_v;
                }


                int
                f_10885_10613_10639(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 10613, 10639);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 10155, 10651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 10155, 10651);
            }
        }

        protected override void VisitCatchBlock(BoundCatchBlock catchBlock, ref LocalState finallyState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 10663, 10981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 10784, 10815);

                var
                oldPending = f_10885_10801_10814(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 10878, 10929);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(catchBlock, ref finallyState), 10885, 10878, 10928);
                base.VisitCatchBlock(catchBlock, ref finallyState);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 10878, 10928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 10943, 10970);

                f_10885_10943_10969(this, oldPending);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 10663, 10981);

                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                f_10885_10801_10814(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 10801, 10814);
                    return return_v;
                }


                int
                f_10885_10943_10969(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 10943, 10969);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 10663, 10981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 10663, 10981);
            }
        }

        protected override void VisitFinallyBlock(BoundStatement finallyBlock, ref LocalState endState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 10993, 12220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 11113, 11145);

                var
                oldPending1 = f_10885_11131_11144(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 11210, 11242);

                var
                oldPending2 = f_10885_11228_11241(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 11308, 11359);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFinallyBlock(finallyBlock, ref endState), 10885, 11308, 11358);
                base.VisitFinallyBlock(finallyBlock, ref endState);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 11308, 11358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 11373, 11401);

                f_10885_11373_11400(this, oldPending2);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 11472, 12165);
                    foreach (var branch in f_10885_11495_11510_I(f_10885_11495_11510()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 11472, 12165);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 11544, 11580) || true) && (branch.Branch == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 11544, 11580);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 11571, 11580);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 11544, 11580);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 11621, 11693);

                        var
                        location = f_10885_11636_11692(f_10885_11655_11691(branch.Branch.Syntax))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 11711, 12150);

                        switch (f_10885_11719_11737(branch.Branch))
                        {

                            case BoundKind.YieldBreakStatement:
                            case BoundKind.YieldReturnStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 11711, 12150);
                                DynAbs.Tracing.TraceSender.TraceBreak(10885, 11980, 11986);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 11711, 12150);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 11711, 12150);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 12042, 12099);

                                f_10885_12042_12098(f_10885_12042_12053(), ErrorCode.ERR_BadFinallyLeave, location);
                                DynAbs.Tracing.TraceSender.TraceBreak(10885, 12125, 12131);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 11711, 12150);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 11472, 12165);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10885, 1, 694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10885, 1, 694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 12181, 12209);

                f_10885_12181_12208(this, oldPending1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 10993, 12220);

                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                f_10885_11131_11144(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 11131, 11144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                f_10885_11228_11241(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 11228, 11241);
                    return return_v;
                }


                int
                f_10885_11373_11400(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 11373, 11400);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                f_10885_11495_11510()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 11495, 11510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10885_11655_11691(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 11655, 11691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10885_11636_11692(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 11636, 11692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10885_11719_11737(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 11719, 11737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10885_12042_12053()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 12042, 12053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10885_12042_12098(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 12042, 12098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                f_10885_11495_11510_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 11495, 11510);
                    return return_v;
                }


                int
                f_10885_12181_12208(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 12181, 12208);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 10993, 12220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 10993, 12220);
            }
        }

        public sealed override bool AwaitUsingAndForeachAddsPendingBranch
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 12436, 12444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 12439, 12444);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 12436, 12444);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 12436, 12444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 12436, 12444);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void VisitLabel(BoundLabeledStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 12457, 12634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 12544, 12587);

                _labelsDefined[f_10885_12559_12569(node)] = _currentBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 12601, 12623);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLabel(node), 10885, 12601, 12622);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 12457, 12634);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10885_12559_12569(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 12559, 12569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 12457, 12634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 12457, 12634);
            }
        }

        public override BoundNode VisitLabeledStatement(BoundLabeledStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 12646, 12875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 12746, 12763);

                f_10885_12746_12762(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 12777, 12798);

                f_10885_12777_12797(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 12812, 12838);

                f_10885_12812_12837(this, f_10885_12827_12836(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 12852, 12864);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 12646, 12875);

                int
                f_10885_12746_12762(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                node)
                {
                    this_param.VisitLabel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 12746, 12762);
                    return 0;
                }


                int
                f_10885_12777_12797(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                statement)
                {
                    this_param.CheckReachable((Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 12777, 12797);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10885_12827_12836(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 12827, 12836);
                    return return_v;
                }


                int
                f_10885_12812_12837(Microsoft.CodeAnalysis.CSharp.ControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 12812, 12837);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 12646, 12875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 12646, 12875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitGotoStatement(BoundGotoStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 12887, 14388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 12981, 13009);

                f_10885_12981_13008(_labelsUsed, f_10885_12997_13007(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 13091, 13133);

                var
                sourceLocation = f_10885_13112_13132(node.Syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 13147, 13197);

                var
                sourceStart = sourceLocation.SourceSpan.Start
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 13211, 13270);

                var
                targetStart = f_10885_13229_13249(f_10885_13229_13239(node))[0].SourceSpan.Start
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 13286, 14324);
                    foreach (var usingDecl in f_10885_13312_13330_I(_usingDeclarations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 13286, 14324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 13364, 13428);

                        var
                        usingStart = f_10885_13381_13407(usingDecl.symbol)[0].SourceSpan.Start
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 13446, 14309) || true) && (sourceStart < usingStart && (DynAbs.Tracing.TraceSender.Expression_True(10885, 13450, 13502) && targetStart > usingStart))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 13446, 14309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 13585, 13660);

                            f_10885_13585_13659(f_10885_13585_13596(), ErrorCode.ERR_GoToForwardJumpOverUsingVar, sourceLocation);
                            DynAbs.Tracing.TraceSender.TraceBreak(10885, 13682, 13688);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 13446, 14309);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 13446, 14309);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 13730, 14309) || true) && (sourceStart > usingStart && (DynAbs.Tracing.TraceSender.Expression_True(10885, 13734, 13786) && targetStart < usingStart))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 13730, 14309);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 13907, 13960);

                                f_10885_13907_13959(f_10885_13920_13958(_labelsDefined, f_10885_13947_13957(node)));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 14060, 14290) || true) && (f_10885_14064_14090(_labelsDefined, f_10885_14079_14089(node)) == usingDecl.block)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 14060, 14290);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 14159, 14235);

                                    f_10885_14159_14234(f_10885_14159_14170(), ErrorCode.ERR_GoToBackwardJumpOverUsingVar, sourceLocation);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10885, 14261, 14267);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 14060, 14290);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 13730, 14309);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 13446, 14309);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 13286, 14324);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10885, 1, 1039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10885, 1, 1039);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 14340, 14377);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitGotoStatement(node), 10885, 14347, 14376);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 12887, 14388);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10885_12997_13007(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 12997, 13007);
                    return return_v;
                }


                bool
                f_10885_12981_13008(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 12981, 13008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10885_13112_13132(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 13112, 13132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10885_13229_13239(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 13229, 13239);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10885_13229_13249(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 13229, 13249);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10885_13381_13407(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 13381, 13407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10885_13585_13596()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 13585, 13596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10885_13585_13659(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 13585, 13659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10885_13947_13957(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 13947, 13957);
                    return return_v;
                }


                bool
                f_10885_13920_13958(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 13920, 13958);
                    return return_v;
                }


                int
                f_10885_13907_13959(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 13907, 13959);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10885_14079_14089(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 14079, 14089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10885_14064_14090(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 14064, 14090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10885_14159_14170()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 14159, 14170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10885_14159_14234(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 14159, 14234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol symbol, Microsoft.CodeAnalysis.CSharp.BoundBlock block)>
                f_10885_13312_13330_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol symbol, Microsoft.CodeAnalysis.CSharp.BoundBlock block)>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 13312, 13330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 12887, 14388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 12887, 14388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void VisitSwitchSection(BoundSwitchSection node, bool isLastSection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 14400, 14951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 14512, 14557);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSwitchSection(node, isLastSection), 10885, 14512, 14556);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 14633, 14940) || true) && (this.State.Alive)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 14633, 14940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 14687, 14732);

                    var
                    syntax = node.SwitchLabels.Last().Syntax
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 14750, 14925);

                    f_10885_14750_14924(f_10885_14750_14761(), (DynAbs.Tracing.TraceSender.Conditional_F1(10885, 14766, 14779) || ((isLastSection && DynAbs.Tracing.TraceSender.Conditional_F2(10885, 14782, 14809)) || DynAbs.Tracing.TraceSender.Conditional_F3(10885, 14812, 14843))) ? ErrorCode.ERR_SwitchFallOut : ErrorCode.ERR_SwitchFallThrough, f_10885_14878_14904(syntax), f_10885_14906_14923(syntax));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 14633, 14940);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 14400, 14951);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10885_14750_14761()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 14750, 14761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10885_14878_14904(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 14878, 14904);
                    return return_v;
                }


                string
                f_10885_14906_14923(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 14906, 14923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10885_14750_14924(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 14750, 14924);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 14400, 14951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 14400, 14951);
            }
        }

        public override BoundNode VisitBlock(BoundBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10885, 14963, 15574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 15041, 15073);

                var
                parentBlock = _currentBlock
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 15087, 15108);

                _currentBlock = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 15122, 15171);

                var
                initialUsingCount = f_10885_15146_15170(_usingDeclarations)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 15185, 15383);
                    foreach (var local in f_10885_15207_15218_I(f_10885_15207_15218(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 15185, 15383);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 15252, 15368) || true) && (f_10885_15256_15269(local))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10885, 15252, 15368);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 15311, 15349);

                            f_10885_15311_15348(_usingDeclarations, (local, node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 15252, 15368);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10885, 15185, 15383);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10885, 1, 199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10885, 1, 199);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 15399, 15434);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBlock(node), 10885, 15412, 15433)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 15450, 15493);

                f_10885_15450_15492(
                            _usingDeclarations, initialUsingCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 15507, 15535);

                _currentBlock = parentBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10885, 15549, 15563);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10885, 14963, 15574);

                int
                f_10885_15146_15170(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol symbol, Microsoft.CodeAnalysis.CSharp.BoundBlock block)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 15146, 15170);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10885_15207_15218(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 15207, 15218);
                    return return_v;
                }


                bool
                f_10885_15256_15269(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsUsing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10885, 15256, 15269);
                    return return_v;
                }


                int
                f_10885_15311_15348(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol symbol, Microsoft.CodeAnalysis.CSharp.BoundBlock block)>
                this_param, (Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol local, Microsoft.CodeAnalysis.CSharp.BoundBlock node)
                item)
                {
                    this_param.Add(((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol symbol, Microsoft.CodeAnalysis.CSharp.BoundBlock block))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 15311, 15348);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10885_15207_15218_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 15207, 15218);
                    return return_v;
                }


                int
                f_10885_15450_15492(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol symbol, Microsoft.CodeAnalysis.CSharp.BoundBlock block)>
                this_param, int
                limit)
                {
                    this_param.Clip(limit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 15450, 15492);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10885, 14963, 15574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 14963, 15574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ControlFlowPass()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10885, 497, 15581);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10885, 497, 15581);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10885, 497, 15581);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10885, 497, 15581);

        Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock>
        f_10885_703_758()
        {
            var return_v = PooledDictionary<LabelSymbol, BoundBlock>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 703, 758);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
        f_10885_827_867()
        {
            var return_v = PooledHashSet<LabelSymbol>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 827, 867);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock)>
        f_10885_1141_1194()
        {
            var return_v = ArrayBuilder<(LocalSymbol, BoundBlock)>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10885, 1141, 1194);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10885_1563_1574_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10885, 1456, 1611);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10885_1779_1790_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10885, 1623, 1856);
            return return_v;
        }

    }
}
