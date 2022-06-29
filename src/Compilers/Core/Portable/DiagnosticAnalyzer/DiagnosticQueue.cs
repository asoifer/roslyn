// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal abstract class DiagnosticQueue
    {
        public abstract bool TryComplete();

        public abstract bool TryDequeue([NotNullWhen(returnValue: true)] out Diagnostic? d);

        public abstract void Enqueue(Diagnostic diagnostic);

        public abstract void EnqueueLocal(Diagnostic diagnostic, DiagnosticAnalyzer analyzer, bool isSyntaxDiagnostic);

        public abstract void EnqueueNonLocal(Diagnostic diagnostic, DiagnosticAnalyzer analyzer);

        public abstract ImmutableArray<Diagnostic> DequeueLocalSyntaxDiagnostics(DiagnosticAnalyzer analyzer);

        public abstract ImmutableArray<Diagnostic> DequeueLocalSemanticDiagnostics(DiagnosticAnalyzer analyzer);

        public abstract ImmutableArray<Diagnostic> DequeueNonLocalDiagnostics(DiagnosticAnalyzer analyzer);

        public static DiagnosticQueue Create(bool categorized = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(262, 1433, 1632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 1520, 1621);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(262, 1527, 1538) || ((categorized && DynAbs.Tracing.TraceSender.Conditional_F2(262, 1541, 1590)) || DynAbs.Tracing.TraceSender.Conditional_F3(262, 1593, 1620))) ? (DiagnosticQueue)f_262_1558_1590() : f_262_1593_1620();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(262, 1433, 1632);

                Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.CategorizedDiagnosticQueue
                f_262_1558_1590()
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.CategorizedDiagnosticQueue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 1558, 1590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue
                f_262_1593_1620()
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 1593, 1620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 1433, 1632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 1433, 1632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class SimpleDiagnosticQueue : DiagnosticQueue
        {
            private readonly AsyncQueue<Diagnostic> _queue;

            public SimpleDiagnosticQueue()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(262, 1949, 2065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 1926, 1932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 2012, 2050);

                    _queue = f_262_2021_2049();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(262, 1949, 2065);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 1949, 2065);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 1949, 2065);
                }
            }

            public SimpleDiagnosticQueue(Diagnostic diagnostic)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(262, 2081, 2263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 1926, 1932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 2165, 2203);

                    _queue = f_262_2174_2202();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 2221, 2248);

                    f_262_2221_2247(_queue, diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(262, 2081, 2263);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 2081, 2263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 2081, 2263);
                }
            }

            public override void Enqueue(Diagnostic diagnostic)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 2279, 2405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 2363, 2390);

                    f_262_2363_2389(_queue, diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 2279, 2405);

                    int
                    f_262_2363_2389(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostic>
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    value)
                    {
                        this_param.Enqueue(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 2363, 2389);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 2279, 2405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 2279, 2405);
                }
            }

            public override void EnqueueLocal(Diagnostic diagnostic, DiagnosticAnalyzer analyzer, bool isSyntaxDiagnostic)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 2421, 2606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 2564, 2591);

                    f_262_2564_2590(_queue, diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 2421, 2606);

                    int
                    f_262_2564_2590(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostic>
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    value)
                    {
                        this_param.Enqueue(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 2564, 2590);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 2421, 2606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 2421, 2606);
                }
            }

            public override void EnqueueNonLocal(Diagnostic diagnostic, DiagnosticAnalyzer analyzer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 2622, 2785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 2743, 2770);

                    f_262_2743_2769(_queue, diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 2622, 2785);

                    int
                    f_262_2743_2769(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostic>
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    value)
                    {
                        this_param.Enqueue(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 2743, 2769);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 2622, 2785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 2622, 2785);
                }
            }

            public override ImmutableArray<Diagnostic> DequeueLocalSemanticDiagnostics(DiagnosticAnalyzer analyzer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 2801, 2988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 2937, 2973);

                    throw f_262_2943_2972();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 2801, 2988);

                    System.NotImplementedException
                    f_262_2943_2972()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 2943, 2972);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 2801, 2988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 2801, 2988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<Diagnostic> DequeueLocalSyntaxDiagnostics(DiagnosticAnalyzer analyzer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 3004, 3189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 3138, 3174);

                    throw f_262_3144_3173();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 3004, 3189);

                    System.NotImplementedException
                    f_262_3144_3173()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 3144, 3173);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 3004, 3189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 3004, 3189);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<Diagnostic> DequeueNonLocalDiagnostics(DiagnosticAnalyzer analyzer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 3205, 3387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 3336, 3372);

                    throw f_262_3342_3371();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 3205, 3387);

                    System.NotImplementedException
                    f_262_3342_3371()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 3342, 3371);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 3205, 3387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 3205, 3387);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool TryComplete()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 3403, 3513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 3470, 3498);

                    return f_262_3477_3497(_queue);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 3403, 3513);

                    bool
                    f_262_3477_3497(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostic>
                    this_param)
                    {
                        var return_v = this_param.TryComplete();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 3477, 3497);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 3403, 3513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 3403, 3513);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool TryDequeue([NotNullWhen(returnValue: true)] out Diagnostic? d)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 3529, 3692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 3645, 3677);

                    return f_262_3652_3676(_queue, out d);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 3529, 3692);

                    bool
                    f_262_3652_3676(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostic>
                    this_param, out Microsoft.CodeAnalysis.Diagnostic?
                    d)
                    {
                        var return_v = this_param.TryDequeue(out d);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 3652, 3676);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 3529, 3692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 3529, 3692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SimpleDiagnosticQueue()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(262, 1801, 3703);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(262, 1801, 3703);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 1801, 3703);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(262, 1801, 3703);

            static Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostic>
            f_262_2021_2049()
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostic>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 2021, 2049);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostic>
            f_262_2174_2202()
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostic>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 2174, 2202);
                return return_v;
            }


            static int
            f_262_2221_2247(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostic>
            this_param, Microsoft.CodeAnalysis.Diagnostic
            value)
            {
                this_param.Enqueue(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 2221, 2247);
                return 0;
            }

        }
        private sealed class CategorizedDiagnosticQueue : DiagnosticQueue
        {
            private readonly object _gate;

            private Dictionary<DiagnosticAnalyzer, SimpleDiagnosticQueue>? _lazyLocalSemanticDiagnostics;

            private Dictionary<DiagnosticAnalyzer, SimpleDiagnosticQueue>? _lazyLocalSyntaxDiagnostics;

            private Dictionary<DiagnosticAnalyzer, SimpleDiagnosticQueue>? _lazyNonLocalDiagnostics;

            public override void Enqueue(Diagnostic diagnostic)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 4401, 4538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 4485, 4523);

                    throw f_262_4491_4522();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 4401, 4538);

                    System.InvalidOperationException
                    f_262_4491_4522()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 4491, 4522);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 4401, 4538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 4401, 4538);
                }
            }

            public override void EnqueueLocal(Diagnostic diagnostic, DiagnosticAnalyzer analyzer, bool isSyntaxDiagnostic)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 4554, 5154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 4697, 4820);

                    f_262_4697_4819(f_262_4710_4734(f_262_4710_4729(diagnostic)) == LocationKind.SourceFile || (DynAbs.Tracing.TraceSender.Expression_False(262, 4710, 4818) || f_262_4765_4789(f_262_4765_4784(diagnostic)) == LocationKind.ExternalFile));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 4838, 5139) || true) && (isSyntaxDiagnostic)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(262, 4838, 5139);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 4902, 4969);

                        f_262_4902_4968(this, ref _lazyLocalSyntaxDiagnostics, diagnostic, analyzer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(262, 4838, 5139);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(262, 4838, 5139);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 5051, 5120);

                        f_262_5051_5119(this, ref _lazyLocalSemanticDiagnostics, diagnostic, analyzer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(262, 4838, 5139);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 4554, 5154);

                    Microsoft.CodeAnalysis.Location
                    f_262_4710_4729(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(262, 4710, 4729);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocationKind
                    f_262_4710_4734(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(262, 4710, 4734);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_262_4765_4784(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(262, 4765, 4784);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocationKind
                    f_262_4765_4789(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(262, 4765, 4789);
                        return return_v;
                    }


                    int
                    f_262_4697_4819(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 4697, 4819);
                        return 0;
                    }


                    int
                    f_262_4902_4968(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.CategorizedDiagnosticQueue
                    this_param, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>?
                    lazyDiagnosticsMap, Microsoft.CodeAnalysis.Diagnostic
                    diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer)
                    {
                        this_param.EnqueueCore(ref lazyDiagnosticsMap, diagnostic, analyzer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 4902, 4968);
                        return 0;
                    }


                    int
                    f_262_5051_5119(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.CategorizedDiagnosticQueue
                    this_param, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>?
                    lazyDiagnosticsMap, Microsoft.CodeAnalysis.Diagnostic
                    diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer)
                    {
                        this_param.EnqueueCore(ref lazyDiagnosticsMap, diagnostic, analyzer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 5051, 5119);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 4554, 5154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 4554, 5154);
                }
            }

            public override void EnqueueNonLocal(Diagnostic diagnostic, DiagnosticAnalyzer analyzer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 5170, 5370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 5291, 5355);

                    f_262_5291_5354(this, ref _lazyNonLocalDiagnostics, diagnostic, analyzer);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 5170, 5370);

                    int
                    f_262_5291_5354(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.CategorizedDiagnosticQueue
                    this_param, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>?
                    lazyDiagnosticsMap, Microsoft.CodeAnalysis.Diagnostic
                    diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer)
                    {
                        this_param.EnqueueCore(ref lazyDiagnosticsMap, diagnostic, analyzer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 5291, 5354);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 5170, 5370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 5170, 5370);
                }
            }

            private void EnqueueCore(
                            [NotNull] ref Dictionary<DiagnosticAnalyzer, SimpleDiagnosticQueue>? lazyDiagnosticsMap,
                            Diagnostic diagnostic,
                            DiagnosticAnalyzer analyzer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 5386, 5889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 5642, 5647);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 5689, 5772);

                        lazyDiagnosticsMap ??= f_262_5712_5771();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 5794, 5855);

                        f_262_5794_5854(lazyDiagnosticsMap, diagnostic, analyzer);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 5386, 5889);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>
                    f_262_5712_5771()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 5712, 5771);
                        return return_v;
                    }


                    int
                    f_262_5794_5854(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>
                    diagnosticsMap, Microsoft.CodeAnalysis.Diagnostic
                    diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer)
                    {
                        EnqueueCore_NoLock(diagnosticsMap, diagnostic, analyzer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 5794, 5854);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 5386, 5889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 5386, 5889);
                }
            }

            private static void EnqueueCore_NoLock(Dictionary<DiagnosticAnalyzer, SimpleDiagnosticQueue> diagnosticsMap, Diagnostic diagnostic, DiagnosticAnalyzer analyzer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(262, 5905, 6402);
                    Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue queue = default(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 6098, 6387) || true) && (f_262_6102_6153(diagnosticsMap, analyzer, out queue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(262, 6098, 6387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 6195, 6221);

                        f_262_6195_6220(queue, diagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(262, 6098, 6387);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(262, 6098, 6387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 6303, 6368);

                        diagnosticsMap[analyzer] = f_262_6330_6367(diagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(262, 6098, 6387);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(262, 5905, 6402);

                    bool
                    f_262_6102_6153(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>
                    this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    key, out Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 6102, 6153);
                        return return_v;
                    }


                    int
                    f_262_6195_6220(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    diagnostic)
                    {
                        this_param.Enqueue(diagnostic);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 6195, 6220);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue
                    f_262_6330_6367(Microsoft.CodeAnalysis.Diagnostic
                    diagnostic)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue(diagnostic);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 6330, 6367);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 5905, 6402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 5905, 6402);
                }
            }

            public override bool TryComplete()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 6418, 6512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 6485, 6497);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 6418, 6512);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 6418, 6512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 6418, 6512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool TryDequeue([NotNullWhen(returnValue: true)] out Diagnostic? d)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 6528, 6763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 6650, 6655);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 6697, 6729);

                        return f_262_6704_6728(this, out d);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 6528, 6763);

                    bool
                    f_262_6704_6728(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.CategorizedDiagnosticQueue
                    this_param, out Microsoft.CodeAnalysis.Diagnostic?
                    d)
                    {
                        var return_v = this_param.TryDequeue_NoLock(out d);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 6704, 6728);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 6528, 6763);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 6528, 6763);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool TryDequeue_NoLock([NotNullWhen(returnValue: true)] out Diagnostic? d)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 6779, 7125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 6894, 7110);

                    return f_262_6901_6956(_lazyLocalSemanticDiagnostics, out d) || (DynAbs.Tracing.TraceSender.Expression_False(262, 6901, 7034) || f_262_6981_7034(_lazyLocalSyntaxDiagnostics, out d)) || (DynAbs.Tracing.TraceSender.Expression_False(262, 6901, 7109) || f_262_7059_7109(_lazyNonLocalDiagnostics, out d));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 6779, 7125);

                    bool
                    f_262_6901_6956(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>?
                    lazyDiagnosticsMap, out Microsoft.CodeAnalysis.Diagnostic?
                    d)
                    {
                        var return_v = TryDequeue_NoLock(lazyDiagnosticsMap, out d);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 6901, 6956);
                        return return_v;
                    }


                    bool
                    f_262_6981_7034(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>?
                    lazyDiagnosticsMap, out Microsoft.CodeAnalysis.Diagnostic?
                    d)
                    {
                        var return_v = TryDequeue_NoLock(lazyDiagnosticsMap, out d);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 6981, 7034);
                        return return_v;
                    }


                    bool
                    f_262_7059_7109(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>?
                    lazyDiagnosticsMap, out Microsoft.CodeAnalysis.Diagnostic?
                    d)
                    {
                        var return_v = TryDequeue_NoLock(lazyDiagnosticsMap, out d);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 7059, 7109);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 6779, 7125);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 6779, 7125);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool TryDequeue_NoLock(Dictionary<DiagnosticAnalyzer, SimpleDiagnosticQueue>? lazyDiagnosticsMap, [NotNullWhen(returnValue: true)] out Diagnostic? d)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(262, 7141, 7703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 7338, 7362);

                    Diagnostic?
                    diag = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 7380, 7628) || true) && (lazyDiagnosticsMap != null && (DynAbs.Tracing.TraceSender.Expression_True(262, 7384, 7475) && f_262_7414_7475(lazyDiagnosticsMap, kvp => kvp.Value.TryDequeue(out diag))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(262, 7380, 7628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 7517, 7544);

                        f_262_7517_7543(diag != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 7566, 7575);

                        d = diag;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 7597, 7609);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(262, 7380, 7628);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 7648, 7657);

                    d = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 7675, 7688);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(262, 7141, 7703);

                    bool
                    f_262_7414_7475(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>
                    source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>, bool>
                    predicate)
                    {
                        var return_v = source.Any<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 7414, 7475);
                        return return_v;
                    }


                    int
                    f_262_7517_7543(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 7517, 7543);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 7141, 7703);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 7141, 7703);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<Diagnostic> DequeueLocalSyntaxDiagnostics(DiagnosticAnalyzer analyzer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 7719, 7937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 7853, 7922);

                    return f_262_7860_7921(this, analyzer, _lazyLocalSyntaxDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 7719, 7937);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_262_7860_7921(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.CategorizedDiagnosticQueue
                    this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>?
                    lazyDiagnosticsMap)
                    {
                        var return_v = this_param.DequeueDiagnosticsCore(analyzer, lazyDiagnosticsMap);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 7860, 7921);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 7719, 7937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 7719, 7937);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<Diagnostic> DequeueLocalSemanticDiagnostics(DiagnosticAnalyzer analyzer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 7953, 8175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 8089, 8160);

                    return f_262_8096_8159(this, analyzer, _lazyLocalSemanticDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 7953, 8175);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_262_8096_8159(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.CategorizedDiagnosticQueue
                    this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>?
                    lazyDiagnosticsMap)
                    {
                        var return_v = this_param.DequeueDiagnosticsCore(analyzer, lazyDiagnosticsMap);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 8096, 8159);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 7953, 8175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 7953, 8175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<Diagnostic> DequeueNonLocalDiagnostics(DiagnosticAnalyzer analyzer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 8191, 8403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 8322, 8388);

                    return f_262_8329_8387(this, analyzer, _lazyNonLocalDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 8191, 8403);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_262_8329_8387(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.CategorizedDiagnosticQueue
                    this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>?
                    lazyDiagnosticsMap)
                    {
                        var return_v = this_param.DequeueDiagnosticsCore(analyzer, lazyDiagnosticsMap);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 8329, 8387);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 8191, 8403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 8191, 8403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ImmutableArray<Diagnostic> DequeueDiagnosticsCore(DiagnosticAnalyzer analyzer, Dictionary<DiagnosticAnalyzer, SimpleDiagnosticQueue>? lazyDiagnosticsMap)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 8419, 9074);
                    Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue? queue = default(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue?);
                    Microsoft.CodeAnalysis.Diagnostic? d = default(Microsoft.CodeAnalysis.Diagnostic?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 8613, 8999) || true) && (f_262_8617_8684(this, analyzer, lazyDiagnosticsMap, out queue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(262, 8613, 8999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 8726, 8783);

                        var
                        builder = f_262_8740_8782()
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 8805, 8927) || true) && (f_262_8812_8839(queue, out d))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(262, 8805, 8927);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 8889, 8904);

                                f_262_8889_8903(builder, d);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(262, 8805, 8927);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(262, 8805, 8927);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(262, 8805, 8927);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 8951, 8980);

                        return f_262_8958_8979(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(262, 8613, 8999);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 9019, 9059);

                    return ImmutableArray<Diagnostic>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 8419, 9074);

                    bool
                    f_262_8617_8684(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.CategorizedDiagnosticQueue
                    this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>?
                    diagnosticsMap, out Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue?
                    queue)
                    {
                        var return_v = this_param.TryGetDiagnosticsQueue(analyzer, diagnosticsMap, out queue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 8617, 8684);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                    f_262_8740_8782()
                    {
                        var return_v = ImmutableArray.CreateBuilder<Diagnostic>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 8740, 8782);
                        return return_v;
                    }


                    bool
                    f_262_8812_8839(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue
                    this_param, out Microsoft.CodeAnalysis.Diagnostic?
                    d)
                    {
                        var return_v = this_param.TryDequeue(out d);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 8812, 8839);
                        return return_v;
                    }


                    int
                    f_262_8889_8903(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 8889, 8903);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_262_8958_8979(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 8958, 8979);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 8419, 9074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 8419, 9074);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool TryGetDiagnosticsQueue(
                            DiagnosticAnalyzer analyzer,
                            Dictionary<DiagnosticAnalyzer, SimpleDiagnosticQueue>? diagnosticsMap,
                            [NotNullWhen(returnValue: true)] out SimpleDiagnosticQueue? queue)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(262, 9090, 9578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 9377, 9390);

                    queue = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 9416, 9421);

                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 9463, 9544);

                        return diagnosticsMap != null && (DynAbs.Tracing.TraceSender.Expression_True(262, 9470, 9543) && f_262_9496_9543(diagnosticsMap, analyzer, out queue));
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(262, 9090, 9578);

                    bool
                    f_262_9496_9543(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue>
                    this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    key, out Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue.SimpleDiagnosticQueue?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 9496, 9543);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(262, 9090, 9578);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 9090, 9578);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public CategorizedDiagnosticQueue()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(262, 3936, 9589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 4050, 4070);
                this._gate = f_262_4058_4070(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 4148, 4177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 4255, 4282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(262, 4360, 4384);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(262, 3936, 9589);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 3936, 9589);
            }


            static CategorizedDiagnosticQueue()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(262, 3936, 9589);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(262, 3936, 9589);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 3936, 9589);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(262, 3936, 9589);

            object
            f_262_4058_4070()
            {
                var return_v = new object();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(262, 4058, 4070);
                return return_v;
            }

        }

        public DiagnosticQueue()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(262, 558, 9596);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(262, 558, 9596);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 558, 9596);
        }


        static DiagnosticQueue()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(262, 558, 9596);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(262, 558, 9596);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(262, 558, 9596);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(262, 558, 9596);
    }
}
