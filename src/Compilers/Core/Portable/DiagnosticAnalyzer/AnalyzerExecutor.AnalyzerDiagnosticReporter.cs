// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class AnalyzerExecutor
    {
        private sealed class AnalyzerDiagnosticReporter
        {
            public readonly Action<Diagnostic> AddDiagnosticAction;

            private static readonly ObjectPool<AnalyzerDiagnosticReporter> s_objectPool;

            public static AnalyzerDiagnosticReporter GetInstance(
                            SourceOrAdditionalFile contextFile,
                            TextSpan? span,
                            Compilation compilation,
                            DiagnosticAnalyzer analyzer,
                            bool isSyntaxDiagnostic,
                            Action<Diagnostic>? addNonCategorizedDiagnostic,
                            Action<Diagnostic, DiagnosticAnalyzer, bool>? addCategorizedLocalDiagnostic,
                            Action<Diagnostic, DiagnosticAnalyzer>? addCategorizedNonLocalDiagnostic,
                            Func<Diagnostic, DiagnosticAnalyzer, Compilation, CancellationToken, bool> shouldSuppressGeneratedCodeDiagnostic,
                            CancellationToken cancellationToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(230, 1009, 2495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 1747, 1782);

                    var
                    item = f_230_1758_1781(s_objectPool)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 1800, 1832);

                    item._contextFile = contextFile;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 1850, 1868);

                    item._span = span;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 1886, 1918);

                    item._compilation = compilation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 1936, 1962);

                    item._analyzer = analyzer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 1980, 2026);

                    item._isSyntaxDiagnostic = isSyntaxDiagnostic;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2044, 2108);

                    item._addNonCategorizedDiagnostic = addNonCategorizedDiagnostic;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2126, 2194);

                    item._addCategorizedLocalDiagnostic = addCategorizedLocalDiagnostic;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2212, 2286);

                    item._addCategorizedNonLocalDiagnostic = addCategorizedNonLocalDiagnostic;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2304, 2388);

                    item._shouldSuppressGeneratedCodeDiagnostic = shouldSuppressGeneratedCodeDiagnostic;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2406, 2450);

                    item._cancellationToken = cancellationToken;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2468, 2480);

                    return item;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(230, 1009, 2495);

                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                    f_230_1758_1781(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 1758, 1781);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(230, 1009, 2495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(230, 1009, 2495);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(230, 2511, 3078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2562, 2583);

                    _contextFile = null!;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2601, 2614);

                    _span = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2632, 2653);

                    _compilation = null!;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2671, 2689);

                    _analyzer = null!;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2707, 2737);

                    _isSyntaxDiagnostic = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2755, 2792);

                    _addNonCategorizedDiagnostic = null!;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2810, 2849);

                    _addCategorizedLocalDiagnostic = null!;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2867, 2909);

                    _addCategorizedNonLocalDiagnostic = null!;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2927, 2974);

                    _shouldSuppressGeneratedCodeDiagnostic = null!;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 2992, 3021);

                    _cancellationToken = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 3039, 3063);

                    f_230_3039_3062(s_objectPool, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(230, 2511, 3078);

                    int
                    f_230_3039_3062(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter>
                    this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                    obj)
                    {
                        this_param.Free(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 3039, 3062);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(230, 2511, 3078);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(230, 2511, 3078);
                }
            }

            private SourceOrAdditionalFile? _contextFile;

            private TextSpan? _span;

            private Compilation _compilation;

            private DiagnosticAnalyzer _analyzer;

            private bool _isSyntaxDiagnostic;

            private Action<Diagnostic>? _addNonCategorizedDiagnostic;

            private Action<Diagnostic, DiagnosticAnalyzer, bool>? _addCategorizedLocalDiagnostic;

            private Action<Diagnostic, DiagnosticAnalyzer>? _addCategorizedNonLocalDiagnostic;

            private Func<Diagnostic, DiagnosticAnalyzer, Compilation, CancellationToken, bool> _shouldSuppressGeneratedCodeDiagnostic;

            private CancellationToken _cancellationToken;

            private AnalyzerDiagnosticReporter()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(230, 3904, 4024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 775, 794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 3126, 3138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 3171, 3176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 3211, 3223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 3265, 3274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 3302, 3321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 3364, 3392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 3461, 3491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 3554, 3587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 3685, 3723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 3973, 4009);

                    AddDiagnosticAction = AddDiagnostic;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(230, 3904, 4024);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(230, 3904, 4024);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(230, 3904, 4024);
                }
            }

            private void AddDiagnostic(Diagnostic diagnostic)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(230, 4070, 5947);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 4152, 4319) || true) && (f_230_4156_4251(this, diagnostic, _analyzer, _compilation, _cancellationToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(230, 4152, 4319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 4293, 4300);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(230, 4152, 4319);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 4339, 4585) || true) && (_addCategorizedLocalDiagnostic == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(230, 4339, 4585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 4423, 4474);

                        f_230_4423_4473(_addNonCategorizedDiagnostic != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 4496, 4537);

                        f_230_4496_4536(this, diagnostic);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 4559, 4566);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(230, 4339, 4585);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 4605, 4656);

                    f_230_4605_4655(_addNonCategorizedDiagnostic == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 4674, 4730);

                    f_230_4674_4729(_addCategorizedNonLocalDiagnostic != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 4750, 5162) || true) && (f_230_4754_4783(diagnostic) && (DynAbs.Tracing.TraceSender.Expression_True(230, 4754, 4887) && (f_230_4809_4824_M(!_span.HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(230, 4809, 4886) || _span.Value.IntersectsWith(f_230_4855_4885(f_230_4855_4874(diagnostic)))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(230, 4750, 5162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 4929, 5004);

                        f_230_4929_5003(this, diagnostic, _analyzer, _isSyntaxDiagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(230, 4750, 5162);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(230, 4750, 5162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 5086, 5143);

                        f_230_5086_5142(this, diagnostic, _analyzer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(230, 4750, 5162);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 5182, 5189);

                    return;

                    bool isLocalDiagnostic(Diagnostic diagnostic)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(230, 5209, 5932);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 5295, 5538) || true) && (f_230_5299_5329(f_230_5299_5318(diagnostic)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(230, 5295, 5538);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 5379, 5515);

                                return f_230_5386_5410_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_contextFile, 230, 5386, 5410)?.SourceTree) != null && (DynAbs.Tracing.TraceSender.Expression_True(230, 5386, 5514) && _contextFile.Value.SourceTree == f_230_5484_5514(f_230_5484_5503(diagnostic)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(230, 5295, 5538);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 5562, 5876) || true) && (f_230_5566_5594_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_contextFile, 230, 5566, 5594)?.AdditionalFile) != null && (DynAbs.Tracing.TraceSender.Expression_True(230, 5566, 5695) && f_230_5631_5650(diagnostic) is ExternalFileLocation externalFileLocation))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(230, 5562, 5876);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 5745, 5853);

                                return f_230_5752_5852(PathUtilities.Comparer, f_230_5782_5820(_contextFile.Value.AdditionalFile), f_230_5822_5851(externalFileLocation));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(230, 5562, 5876);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 5900, 5913);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(230, 5209, 5932);

                            Microsoft.CodeAnalysis.Location
                            f_230_5299_5318(Microsoft.CodeAnalysis.Diagnostic
                            this_param)
                            {
                                var return_v = this_param.Location;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 5299, 5318);
                                return return_v;
                            }


                            bool
                            f_230_5299_5329(Microsoft.CodeAnalysis.Location
                            this_param)
                            {
                                var return_v = this_param.IsInSource;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 5299, 5329);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.SyntaxTree?
                            f_230_5386_5410_M(Microsoft.CodeAnalysis.SyntaxTree?
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 5386, 5410);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Location
                            f_230_5484_5503(Microsoft.CodeAnalysis.Diagnostic
                            this_param)
                            {
                                var return_v = this_param.Location;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 5484, 5503);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.SyntaxTree
                            f_230_5484_5514(Microsoft.CodeAnalysis.Location
                            this_param)
                            {
                                var return_v = this_param.SourceTree;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 5484, 5514);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.AdditionalText?
                            f_230_5566_5594_M(Microsoft.CodeAnalysis.AdditionalText?
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 5566, 5594);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.Location
                            f_230_5631_5650(Microsoft.CodeAnalysis.Diagnostic
                            this_param)
                            {
                                var return_v = this_param.Location;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 5631, 5650);
                                return return_v;
                            }


                            string
                            f_230_5782_5820(Microsoft.CodeAnalysis.AdditionalText
                            this_param)
                            {
                                var return_v = this_param.Path;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 5782, 5820);
                                return return_v;
                            }


                            string
                            f_230_5822_5851(Microsoft.CodeAnalysis.ExternalFileLocation
                            this_param)
                            {
                                var return_v = this_param.FilePath;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 5822, 5851);
                                return return_v;
                            }


                            bool
                            f_230_5752_5852(System.Collections.Generic.IEqualityComparer<string>
                            this_param, string
                            x, string
                            y)
                            {
                                var return_v = this_param.Equals(x, y);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 5752, 5852);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(230, 5209, 5932);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(230, 5209, 5932);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(230, 4070, 5947);

                    bool
                    f_230_4156_4251(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    arg1, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    arg2, Microsoft.CodeAnalysis.Compilation
                    arg3, System.Threading.CancellationToken
                    arg4)
                    {
                        var return_v = this_param._shouldSuppressGeneratedCodeDiagnostic(arg1, arg2, arg3, arg4);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 4156, 4251);
                        return return_v;
                    }


                    int
                    f_230_4423_4473(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 4423, 4473);
                        return 0;
                    }


                    int
                    f_230_4496_4536(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    obj)
                    {
                        this_param._addNonCategorizedDiagnostic(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 4496, 4536);
                        return 0;
                    }


                    int
                    f_230_4605_4655(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 4605, 4655);
                        return 0;
                    }


                    int
                    f_230_4674_4729(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 4674, 4729);
                        return 0;
                    }


                    bool
                    f_230_4754_4783(Microsoft.CodeAnalysis.Diagnostic
                    diagnostic)
                    {
                        var return_v = isLocalDiagnostic(diagnostic);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 4754, 4783);
                        return return_v;
                    }


                    bool
                    f_230_4809_4824_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 4809, 4824);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_230_4855_4874(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 4855, 4874);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_230_4855_4885(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.SourceSpan;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(230, 4855, 4885);
                        return return_v;
                    }


                    int
                    f_230_4929_5003(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    arg1, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    arg2, bool
                    arg3)
                    {
                        this_param._addCategorizedLocalDiagnostic(arg1, arg2, arg3);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 4929, 5003);
                        return 0;
                    }


                    int
                    f_230_5086_5142(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    arg1, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    arg2)
                    {
                        this_param._addCategorizedNonLocalDiagnostic(arg1, arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 5086, 5142);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(230, 4070, 5947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(230, 4070, 5947);
                }
            }

            static AnalyzerDiagnosticReporter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(230, 668, 5958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(230, 874, 992);
                s_objectPool = f_230_906_992(() => new AnalyzerDiagnosticReporter(), 10); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(230, 668, 5958);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(230, 668, 5958);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(230, 668, 5958);

            static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter>
            f_230_906_992(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter>.Factory
            factory, int
            size)
            {
                var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter>(factory, size);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(230, 906, 992);
                return return_v;
            }

        }

        static AnalyzerExecutor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(230, 436, 5965);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 1363, 1394);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 1477, 1517);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 1550, 1596);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(230, 436, 5965);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(230, 436, 5965);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(230, 436, 5965);
    }
}
