// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.Text;
namespace Microsoft.CodeAnalysis
{
    public class GeneratorDriverRunResult
    {
        private ImmutableArray<Diagnostic> _lazyDiagnostics;

        private ImmutableArray<SyntaxTree> _lazyGeneratedTrees;

        internal GeneratorDriverRunResult(ImmutableArray<GeneratorRunResult> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(558, 741, 877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 843, 866);

                this.Results = results;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(558, 741, 877);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(558, 741, 877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(558, 741, 877);
            }
        }

        public ImmutableArray<GeneratorRunResult> Results { get; }

        public ImmutableArray<Diagnostic> Diagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(558, 1526, 1834);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 1562, 1777) || true) && (_lazyDiagnostics.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(558, 1562, 1777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 1634, 1758);

                        // LAFHIS
                        var temp = f_558_1699_1706();
                        f_558_1634_1757(ref _lazyDiagnostics, f_558_1699_1756(f_558_1699_1737(ref temp, r => r.Diagnostics)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(558, 1562, 1777);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 1795, 1819);

                    return _lazyDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(558, 1526, 1834);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorRunResult>
                    f_558_1699_1706()
                    {
                        var return_v = Results;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(558, 1699, 1706);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                    f_558_1699_1737(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorRunResult>
                    source, System.Func<Microsoft.CodeAnalysis.GeneratorRunResult, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>>
                    selector)
                    {
                        var return_v = source.SelectMany<Microsoft.CodeAnalysis.GeneratorRunResult, Microsoft.CodeAnalysis.Diagnostic>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(558, 1699, 1737);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_558_1699_1756(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                    items)
                    {
                        var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.Diagnostic>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(558, 1699, 1756);
                        return return_v;
                    }


                    bool
                    f_558_1634_1757(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(558, 1634, 1757);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(558, 1456, 1845);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(558, 1456, 1845);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<SyntaxTree> GeneratedTrees
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(558, 2358, 2706);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 2394, 2646) || true) && (_lazyGeneratedTrees.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(558, 2394, 2646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 2469, 2627);

                        // LAFHIS
                        var temp = f_558_2537_2544();
                        f_558_2469_2626(ref _lazyGeneratedTrees, f_558_2537_2625(f_558_2537_2606(ref temp, r => r.GeneratedSources.Select(g => g.SyntaxTree))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(558, 2394, 2646);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 2664, 2691);

                    return _lazyGeneratedTrees;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(558, 2358, 2706);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorRunResult>
                    f_558_2537_2544()
                    {
                        var return_v = Results;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(558, 2537, 2544);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    f_558_2537_2606(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorRunResult>
                    source, System.Func<Microsoft.CodeAnalysis.GeneratorRunResult, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>>
                    selector)
                    {
                        var return_v = source.SelectMany<Microsoft.CodeAnalysis.GeneratorRunResult, Microsoft.CodeAnalysis.SyntaxTree>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(558, 2537, 2606);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                    f_558_2537_2625(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    items)
                    {
                        var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(558, 2537, 2625);
                        return return_v;
                    }


                    bool
                    f_558_2469_2626(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(558, 2469, 2626);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(558, 2285, 2717);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(558, 2285, 2717);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static GeneratorDriverRunResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(558, 556, 2724);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(558, 556, 2724);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(558, 556, 2724);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(558, 556, 2724);
    }

    public readonly struct GeneratorRunResult
    {

        internal GeneratorRunResult(ISourceGenerator generator, ImmutableArray<GeneratedSourceResult> generatedSources, ImmutableArray<Diagnostic> diagnostics, Exception? exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(558, 2921, 3403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 3119, 3208);

                f_558_3119_3207(exception is null || (DynAbs.Tracing.TraceSender.Expression_False(558, 3132, 3206) || (generatedSources.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(558, 3154, 3205) && diagnostics.Length == 1))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 3224, 3251);

                this.Generator = generator;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 3265, 3306);

                this.GeneratedSources = generatedSources;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 3320, 3351);

                this.Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 3365, 3392);

                this.Exception = exception;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(558, 2921, 3403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(558, 2921, 3403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(558, 2921, 3403);
            }
        }

        public ISourceGenerator Generator { get; }

        public ImmutableArray<GeneratedSourceResult> GeneratedSources { get; }

        public ImmutableArray<Diagnostic> Diagnostics { get; }

        public Exception? Exception { get; }
        static GeneratorRunResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(558, 2863, 4844);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(558, 2863, 4844);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(558, 2863, 4844);
        }

        static int
        f_558_3119_3207(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(558, 3119, 3207);
            return 0;
        }

    }

    public readonly struct GeneratedSourceResult
    {

        internal GeneratedSourceResult(SyntaxTree tree, SourceText text, string hintName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(558, 5303, 5519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 5409, 5432);

                this.SyntaxTree = tree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 5446, 5469);

                this.SourceText = text;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(558, 5483, 5508);

                this.HintName = hintName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(558, 5303, 5519);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(558, 5303, 5519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(558, 5303, 5519);
            }
        }

        public SyntaxTree SyntaxTree { get; }

        public SourceText SourceText { get; }

        public string HintName { get; }
        static GeneratedSourceResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(558, 5242, 6113);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(558, 5242, 6113);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(558, 5242, 6113);
        }
    }
}
