// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    internal class DiagnosticBag
    {
        private ConcurrentQueue<Diagnostic>? _lazyBag;

        public bool IsEmptyWithoutResolution
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 1934, 2464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 2353, 2397);

                    ConcurrentQueue<Diagnostic>?
                    bag = _lazyBag
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 2415, 2449);

                    return bag == null || (DynAbs.Tracing.TraceSender.Expression_False(182, 2422, 2448) || f_182_2437_2448(bag));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(182, 1934, 2464);

                    bool
                    f_182_2437_2448(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                    this_param)
                    {
                        var return_v = this_param.IsEmpty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 2437, 2448);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 1873, 2475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 1873, 2475);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasAnyErrors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 3026, 3440);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 3077, 3167) || true) && (f_182_3081_3105())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 3077, 3167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 3139, 3152);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(182, 3077, 3167);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 3183, 3400);
                    foreach (Diagnostic diagnostic in f_182_3217_3220_I(f_182_3217_3220()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 3183, 3400);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 3254, 3385) || true) && (f_182_3258_3284(diagnostic) == DiagnosticSeverity.Error)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 3254, 3385);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 3354, 3366);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(182, 3254, 3385);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(182, 3183, 3400);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(182, 1, 218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(182, 1, 218);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 3416, 3429);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 3026, 3440);

                bool
                f_182_3081_3105()
                {
                    var return_v = IsEmptyWithoutResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 3081, 3105);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_3217_3220()
                {
                    var return_v = Bag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 3217, 3220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_182_3258_3284(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 3258, 3284);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_3217_3220_I(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 3217, 3220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 3026, 3440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 3026, 3440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasAnyResolvedErrors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 4008, 4730);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 4069, 4159) || true) && (f_182_4073_4097())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 4069, 4159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 4131, 4144);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(182, 4069, 4159);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 4175, 4690);
                    foreach (Diagnostic diagnostic in f_182_4209_4212_I(f_182_4209_4212()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 4175, 4690);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 4411, 4675) || true) && ((((DynAbs.Tracing.TraceSender.Conditional_F1(182, 4417, 4451) || (((diagnostic is DiagnosticWithInfo) && DynAbs.Tracing.TraceSender.Conditional_F2(182, 4454, 4498)) || DynAbs.Tracing.TraceSender.Conditional_F3(182, 4501, 4512))) ? f_182_4454_4498(((DiagnosticWithInfo)diagnostic)) : (bool?)null) != true) && (DynAbs.Tracing.TraceSender.Expression_True(182, 4415, 4602) && f_182_4548_4574(diagnostic) == DiagnosticSeverity.Error))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 4411, 4675);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 4644, 4656);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(182, 4411, 4675);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(182, 4175, 4690);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(182, 1, 516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(182, 1, 516);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 4706, 4719);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 4008, 4730);

                bool
                f_182_4073_4097()
                {
                    var return_v = IsEmptyWithoutResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 4073, 4097);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_4209_4212()
                {
                    var return_v = Bag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 4209, 4212);
                    return return_v;
                }


                bool
                f_182_4454_4498(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.HasLazyInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 4454, 4498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_182_4548_4574(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 4548, 4574);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_4209_4212_I(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 4209, 4212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 4008, 4730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 4008, 4730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Add(Diagnostic diag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 4831, 4974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 4888, 4931);

                ConcurrentQueue<Diagnostic>
                bag = f_182_4922_4930(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 4945, 4963);

                f_182_4945_4962(bag, diag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 4831, 4974);

                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_4922_4930(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.Bag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 4922, 4930);
                    return return_v;
                }


                int
                f_182_4945_4962(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 4945, 4962);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 4831, 4974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 4831, 4974);
            }
        }

        public void AddRange<T>(ImmutableArray<T> diagnostics) where T : Diagnostic
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 5083, 5469);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 5183, 5458) || true) && (f_182_5187_5216_M(!diagnostics.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 5183, 5458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 5250, 5293);

                    ConcurrentQueue<Diagnostic>
                    bag = f_182_5284_5292(this)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 5320, 5325);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 5311, 5443) || true) && (i < diagnostics.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 5351, 5354)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(182, 5311, 5443))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 5311, 5443);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 5396, 5424);

                            f_182_5396_5423(bag, diagnostics[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(182, 1, 133);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(182, 1, 133);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(182, 5183, 5458);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 5083, 5469);

                bool
                f_182_5187_5216_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 5187, 5216);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_5284_5292(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.Bag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 5284, 5292);
                    return return_v;
                }


                int
                f_182_5396_5423(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                this_param, T
                item)
                {
                    this_param.Enqueue((Microsoft.CodeAnalysis.Diagnostic)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 5396, 5423);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 5083, 5469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 5083, 5469);
            }
        }

        public void AddRange(IEnumerable<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 5578, 5794);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 5660, 5783);
                    foreach (Diagnostic diagnostic in f_182_5694_5705_I(diagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 5660, 5783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 5739, 5768);

                        f_182_5739_5767(f_182_5739_5747(this), diagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(182, 5660, 5783);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(182, 1, 124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(182, 1, 124);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 5578, 5794);

                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_5739_5747(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.Bag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 5739, 5747);
                    return return_v;
                }


                int
                f_182_5739_5767(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 5739, 5767);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_182_5694_5705_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 5694, 5705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 5578, 5794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 5578, 5794);
            }
        }

        public void AddRange(DiagnosticBag bag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 5904, 6079);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 5968, 6068) || true) && (f_182_5972_6001_M(!bag.IsEmptyWithoutResolution))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 5968, 6068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 6035, 6053);

                    f_182_6035_6052(this, f_182_6044_6051(bag));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(182, 5968, 6068);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 5904, 6079);

                bool
                f_182_5972_6001_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 5972, 6001);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_6044_6051(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.Bag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 6044, 6051);
                    return return_v;
                }


                int
                f_182_6035_6052(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 6035, 6052);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 5904, 6079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 5904, 6079);
            }
        }

        public void AddRangeAndFree(DiagnosticBag bag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 6211, 6332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 6282, 6296);

                f_182_6282_6295(this, bag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 6310, 6321);

                f_182_6310_6320(bag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 6211, 6332);

                int
                f_182_6282_6295(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 6282, 6295);
                    return 0;
                }


                int
                f_182_6310_6320(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 6310, 6320);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 6211, 6332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 6211, 6332);
            }
        }

        public ImmutableArray<TDiagnostic> ToReadOnlyAndFree<TDiagnostic>() where TDiagnostic : Diagnostic
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 6548, 6809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 6671, 6718);

                ConcurrentQueue<Diagnostic>?
                oldBag = _lazyBag
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 6732, 6739);

                f_182_6732_6738(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 6755, 6798);

                return f_182_6762_6797(oldBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 6548, 6809);

                int
                f_182_6732_6738(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 6732, 6738);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TDiagnostic>
                f_182_6762_6797(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>?
                oldBag)
                {
                    var return_v = ToReadOnlyCore<TDiagnostic>(oldBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 6762, 6797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 6548, 6809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 6548, 6809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<Diagnostic> ToReadOnlyAndFree()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 6821, 6949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 6899, 6938);

                return f_182_6906_6937(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 6821, 6949);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_182_6906_6937(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 6906, 6937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 6821, 6949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 6821, 6949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<TDiagnostic> ToReadOnly<TDiagnostic>() where TDiagnostic : Diagnostic
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 6961, 7192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 7077, 7124);

                ConcurrentQueue<Diagnostic>?
                oldBag = _lazyBag
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 7138, 7181);

                return f_182_7145_7180(oldBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 6961, 7192);

                System.Collections.Immutable.ImmutableArray<TDiagnostic>
                f_182_7145_7180(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>?
                oldBag)
                {
                    var return_v = ToReadOnlyCore<TDiagnostic>(oldBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 7145, 7180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 6961, 7192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 6961, 7192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<Diagnostic> ToReadOnly()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 7204, 7318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 7275, 7307);

                return f_182_7282_7306(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 7204, 7318);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_182_7282_7306(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnly<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 7282, 7306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 7204, 7318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 7204, 7318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<TDiagnostic> ToReadOnlyCore<TDiagnostic>(ConcurrentQueue<Diagnostic>? oldBag) where TDiagnostic : Diagnostic
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(182, 7330, 8219);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 7493, 7601) || true) && (oldBag == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 7493, 7601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 7545, 7586);

                    return ImmutableArray<TDiagnostic>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(182, 7493, 7601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 7617, 7693);

                ArrayBuilder<TDiagnostic>
                builder = f_182_7653_7692()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 7709, 8156);
                    foreach (TDiagnostic diagnostic in f_182_7744_7750_I(oldBag))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 7709, 8156);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 7859, 8141) || true) && (f_182_7863_7882(diagnostic) != InternalDiagnosticSeverity.Void)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 7859, 8141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 7959, 8031);

                            f_182_7959_8030(f_182_7972_7991(diagnostic) != InternalDiagnosticSeverity.Unknown);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 8098, 8122);

                            f_182_8098_8121(builder, diagnostic);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(182, 7859, 8141);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(182, 7709, 8156);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(182, 1, 448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(182, 1, 448);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 8172, 8208);

                return f_182_8179_8207(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(182, 7330, 8219);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TDiagnostic>
                f_182_7653_7692()
                {
                    var return_v = ArrayBuilder<TDiagnostic>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 7653, 7692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_182_7863_7882(TDiagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 7863, 7882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_182_7972_7991(TDiagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 7972, 7991);
                    return return_v;
                }


                int
                f_182_7959_8030(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 7959, 8030);
                    return 0;
                }


                int
                f_182_8098_8121(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TDiagnostic>
                this_param, TDiagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 8098, 8121);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_7744_7750_I(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 7744, 7750);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TDiagnostic>
                f_182_8179_8207(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TDiagnostic>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 8179, 8207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 7330, 8219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 7330, 8219);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<Diagnostic> AsEnumerable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 8465, 8992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 8535, 8578);

                ConcurrentQueue<Diagnostic>
                bag = f_182_8569_8577(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 8594, 8617);

                bool
                foundVoid = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 8633, 8883);
                    foreach (Diagnostic diagnostic in f_182_8667_8670_I(bag))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 8633, 8883);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 8704, 8868) || true) && (f_182_8708_8727(diagnostic) == InternalDiagnosticSeverity.Void)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 8704, 8868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 8804, 8821);

                            foundVoid = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(182, 8843, 8849);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(182, 8704, 8868);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(182, 8633, 8883);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(182, 1, 251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(182, 1, 251);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 8899, 8981);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(182, 8906, 8915) || ((foundVoid
                && DynAbs.Tracing.TraceSender.Conditional_F2(182, 8935, 8957)) || DynAbs.Tracing.TraceSender.Conditional_F3(182, 8977, 8980))) ? f_182_8935_8957(this) : bag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 8465, 8992);

                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_8569_8577(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.Bag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 8569, 8577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_182_8708_8727(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 8708, 8727);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_8667_8670_I(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 8667, 8670);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_182_8935_8957(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerableFiltered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 8935, 8957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 8465, 8992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 8465, 8992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<Diagnostic> AsEnumerableFiltered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 9181, 9644);

                var listYield = new List<Diagnostic>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 9260, 9633);
                    foreach (Diagnostic diagnostic in f_182_9294_9302_I(f_182_9294_9302(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 9260, 9633);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 9336, 9618) || true) && (f_182_9340_9359(diagnostic) != InternalDiagnosticSeverity.Void)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 9336, 9618);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 9436, 9508);

                            f_182_9436_9507(f_182_9449_9468(diagnostic) != InternalDiagnosticSeverity.Unknown);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 9575, 9599);

                            listYield.Add(diagnostic);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(182, 9336, 9618);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(182, 9260, 9633);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(182, 1, 374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(182, 1, 374);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 9181, 9644);

                return listYield;

                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_9294_9302(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.Bag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 9294, 9302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_182_9340_9359(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 9340, 9359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_182_9449_9468(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 9449, 9468);
                    return return_v;
                }


                int
                f_182_9436_9507(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 9436, 9507);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_9294_9302_I(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 9294, 9302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 9181, 9644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 9181, 9644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<Diagnostic> AsEnumerableWithoutResolution()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 9656, 9927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 9844, 9916);

                return _lazyBag ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>?>(182, 9851, 9915) ?? f_182_9863_9915());
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 9656, 9927);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_182_9863_9915()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 9863, 9915);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 9656, 9927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 9656, 9927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 9958, 9981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 9961, 9981);
                    return f_182_9961_9976_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyBag, 182, 9961, 9976)?.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(182, 9961, 9981) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(182, 9958, 9981);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 9958, 9981);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 9958, 9981);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 9994, 10561);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 10052, 10550) || true) && (f_182_10056_10085(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 10052, 10550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 10182, 10203);

                    return "<no errors>";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(182, 10052, 10550);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 10052, 10550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 10269, 10313);

                    StringBuilder
                    builder = f_182_10293_10312()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 10331, 10491);
                        foreach (Diagnostic diag in f_182_10359_10362_I(f_182_10359_10362()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 10331, 10491);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 10436, 10472);

                            f_182_10436_10471(builder, f_182_10455_10470(diag));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(182, 10331, 10491);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(182, 1, 161);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(182, 1, 161);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 10509, 10535);

                    return f_182_10516_10534(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(182, 10052, 10550);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 9994, 10561);

                bool
                f_182_10056_10085(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.IsEmptyWithoutResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 10056, 10085);
                    return return_v;
                }


                System.Text.StringBuilder
                f_182_10293_10312()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 10293, 10312);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_10359_10362()
                {
                    var return_v = Bag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 10359, 10362);
                    return return_v;
                }


                string
                f_182_10455_10470(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 10455, 10470);
                    return return_v;
                }


                System.Text.StringBuilder
                f_182_10436_10471(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 10436, 10471);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                f_182_10359_10362_I(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 10359, 10362);
                    return return_v;
                }


                string
                f_182_10516_10534(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 10516, 10534);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 9994, 10561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 9994, 10561);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConcurrentQueue<Diagnostic> Bag
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 11021, 11403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 11057, 11101);

                    ConcurrentQueue<Diagnostic>?
                    bag = _lazyBag
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 11119, 11206) || true) && (bag != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 11119, 11206);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 11176, 11187);

                        return bag;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(182, 11119, 11206);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 11226, 11297);

                    ConcurrentQueue<Diagnostic>
                    newBag = f_182_11263_11296()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 11315, 11388);

                    return f_182_11322_11377(ref _lazyBag, newBag, null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>?>(182, 11322, 11387) ?? newBag);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(182, 11021, 11403);

                    System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                    f_182_11263_11296()
                    {
                        var return_v = new System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 11263, 11296);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>?
                    f_182_11322_11377(ref System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>?
                    location1, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                    value, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 11322, 11377);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 10957, 11414);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 10957, 11414);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 11706, 11901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 11752, 11796);

                ConcurrentQueue<Diagnostic>?
                bag = _lazyBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 11810, 11890) || true) && (bag != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 11810, 11890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 11859, 11875);

                    _lazyBag = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(182, 11810, 11890);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 11706, 11901);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 11706, 11901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 11706, 11901);
            }
        }

        internal static DiagnosticBag GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(182, 11943, 12093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 12011, 12057);

                DiagnosticBag
                bag = f_182_12031_12056(s_poolInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 12071, 12082);

                return bag;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(182, 11943, 12093);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_182_12031_12056(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.DiagnosticBag>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 12031, 12056);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 11943, 12093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 11943, 12093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 12105, 12209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 12150, 12158);

                f_182_12150_12157(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 12172, 12198);

                f_182_12172_12197(s_poolInstance, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 12105, 12209);

                int
                f_182_12150_12157(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 12150, 12157);
                    return 0;
                }


                int
                f_182_12172_12197(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.DiagnosticBag>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 12172, 12197);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 12105, 12209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 12105, 12209);
            }
        }

        private static readonly ObjectPool<DiagnosticBag> s_poolInstance;

        private static ObjectPool<DiagnosticBag> CreatePool(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(182, 12314, 12481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 12400, 12470);

                return f_182_12407_12469(() => new DiagnosticBag(), size);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(182, 12314, 12481);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.DiagnosticBag>
                f_182_12407_12469(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.DiagnosticBag>.Factory
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.DiagnosticBag>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 12407, 12469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 12314, 12481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 12314, 12481);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal sealed class DebuggerProxy
        {
            private readonly DiagnosticBag _bag;

            public DebuggerProxy(DiagnosticBag bag)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(182, 12660, 12758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 12639, 12643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 12732, 12743);

                    _bag = bag;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(182, 12660, 12758);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 12660, 12758);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 12660, 12758);
                }
            }

            [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
            public object[] Diagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 12902, 13284);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 12946, 12999);

                        ConcurrentQueue<Diagnostic>?
                        lazyBag = _bag._lazyBag
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 13021, 13265) || true) && (lazyBag != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 13021, 13265);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 13090, 13115);

                            return f_182_13097_13114(lazyBag);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(182, 13021, 13265);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(182, 13021, 13265);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 13213, 13242);

                            return f_182_13220_13241();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(182, 13021, 13265);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(182, 12902, 13284);

                        Microsoft.CodeAnalysis.Diagnostic[]
                        f_182_13097_13114(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Diagnostic>
                        this_param)
                        {
                            var return_v = this_param.ToArray();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 13097, 13114);
                            return return_v;
                        }


                        object[]
                        f_182_13220_13241()
                        {
                            var return_v = Array.Empty<object>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 13220, 13241);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 12774, 13299);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 12774, 13299);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static DebuggerProxy()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(182, 12548, 13310);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(182, 12548, 13310);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 12548, 13310);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(182, 12548, 13310);
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(182, 13322, 13436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 13382, 13425);

                return "Count = " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((f_182_13403_13418_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyBag, 182, 13403, 13418)?.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(182, 13403, 13423) ?? 0))).ToString(), 182, 13402, 13424);
                DynAbs.Tracing.TraceSender.TraceExitMethod(182, 13322, 13436);

                int?
                f_182_13403_13418_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 13403, 13418);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(182, 13322, 13436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 13322, 13436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DiagnosticBag()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(182, 1135, 13463);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 1405, 1413);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(182, 1135, 13463);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 1135, 13463);
        }


        static DiagnosticBag()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(182, 1135, 13463);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(182, 12271, 12303);
            s_poolInstance = f_182_12288_12303(128); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(182, 1135, 13463);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(182, 1135, 13463);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(182, 1135, 13463);

        int?
        f_182_9961_9976_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(182, 9961, 9976);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.DiagnosticBag>
        f_182_12288_12303(int
        size)
        {
            var return_v = CreatePool(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(182, 12288, 12303);
            return return_v;
        }

    }
}
