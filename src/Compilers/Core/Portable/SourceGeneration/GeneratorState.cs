// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
namespace Microsoft.CodeAnalysis
{

    internal readonly struct GeneratorState
    {

        internal static GeneratorState Uninitialized;

        public GeneratorState(GeneratorInfo info)
        : this(f_553_814_818_C(info), ImmutableArray<GeneratedSyntaxTree>.Empty, ImmutableArray<GeneratedSyntaxTree>.Empty, ImmutableArray<Diagnostic>.Empty, syntaxReceiver: null, exception: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(553, 752, 1000);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(553, 752, 1000);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(553, 752, 1000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(553, 752, 1000);
            }
        }

        public GeneratorState(GeneratorInfo info, ImmutableArray<GeneratedSyntaxTree> postInitTrees)
        : this(f_553_1260_1264_C(info), postInitTrees, ImmutableArray<GeneratedSyntaxTree>.Empty, ImmutableArray<Diagnostic>.Empty, syntaxReceiver: null, exception: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(553, 1147, 1418);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(553, 1147, 1418);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(553, 1147, 1418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(553, 1147, 1418);
            }
        }

        public GeneratorState(GeneratorInfo info, Exception e, Diagnostic error)
        : this(f_553_1670_1674_C(info), ImmutableArray<GeneratedSyntaxTree>.Empty, ImmutableArray<GeneratedSyntaxTree>.Empty, f_553_1762_1790(error), syntaxReceiver: null, exception: e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(553, 1577, 1849);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(553, 1577, 1849);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(553, 1577, 1849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(553, 1577, 1849);
            }
        }

        public GeneratorState(GeneratorInfo info, ImmutableArray<GeneratedSyntaxTree> postInitTrees, ImmutableArray<GeneratedSyntaxTree> generatedTrees, ImmutableArray<Diagnostic> diagnostics)
        : this(f_553_2174_2178_C(info), postInitTrees, generatedTrees, diagnostics, syntaxReceiver: null, exception: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(553, 1969, 2284);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(553, 1969, 2284);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(553, 1969, 2284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(553, 1969, 2284);
            }
        }

        private GeneratorState(GeneratorInfo info, ImmutableArray<GeneratedSyntaxTree> postInitTrees, ImmutableArray<GeneratedSyntaxTree> generatedTrees, ImmutableArray<Diagnostic> diagnostics, ISyntaxContextReceiver? syntaxReceiver, Exception? exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(553, 2296, 2833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(553, 2568, 2603);

                this.PostInitTrees = postInitTrees;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(553, 2617, 2654);

                this.GeneratedTrees = generatedTrees;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(553, 2668, 2685);

                this.Info = info;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(553, 2699, 2730);

                this.Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(553, 2744, 2781);

                this.SyntaxReceiver = syntaxReceiver;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(553, 2795, 2822);

                this.Exception = exception;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(553, 2296, 2833);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(553, 2296, 2833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(553, 2296, 2833);
            }
        }

        internal ImmutableArray<GeneratedSyntaxTree> PostInitTrees { get; }

        internal ImmutableArray<GeneratedSyntaxTree> GeneratedTrees { get; }

        internal GeneratorInfo Info { get; }

        internal ISyntaxContextReceiver? SyntaxReceiver { get; }

        internal Exception? Exception { get; }

        internal ImmutableArray<Diagnostic> Diagnostics { get; }

        internal GeneratorState WithReceiver(ISyntaxContextReceiver syntaxReceiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(553, 3345, 3891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(553, 3445, 3482);

                f_553_3445_3481(this.Exception is null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(553, 3496, 3880);

                return f_553_3503_3879(this.Info, postInitTrees: this.PostInitTrees, generatedTrees: this.GeneratedTrees, diagnostics: this.Diagnostics, syntaxReceiver: syntaxReceiver, exception: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(553, 3345, 3891);

                int
                f_553_3445_3481(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(553, 3445, 3481);
                    return 0;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_553_3503_3879(Microsoft.CodeAnalysis.GeneratorInfo
                info, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                postInitTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                generatedTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.ISyntaxContextReceiver
                syntaxReceiver, System.Exception?
                exception)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorState(info, postInitTrees: postInitTrees, generatedTrees: generatedTrees, diagnostics: diagnostics, syntaxReceiver: syntaxReceiver, exception: exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(553, 3503, 3879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(553, 3345, 3891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(553, 3345, 3891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static GeneratorState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(553, 420, 3898);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(553, 605, 618);
            Uninitialized = default(GeneratorState); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(553, 420, 3898);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(553, 420, 3898);
        }

        static Microsoft.CodeAnalysis.GeneratorInfo
        f_553_814_818_C(Microsoft.CodeAnalysis.GeneratorInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(553, 752, 1000);
            return return_v;
        }


        static Microsoft.CodeAnalysis.GeneratorInfo
        f_553_1260_1264_C(Microsoft.CodeAnalysis.GeneratorInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(553, 1147, 1418);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        f_553_1762_1790(Microsoft.CodeAnalysis.Diagnostic
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(553, 1762, 1790);
            return return_v;
        }


        static Microsoft.CodeAnalysis.GeneratorInfo
        f_553_1670_1674_C(Microsoft.CodeAnalysis.GeneratorInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(553, 1577, 1849);
            return return_v;
        }


        static Microsoft.CodeAnalysis.GeneratorInfo
        f_553_2174_2178_C(Microsoft.CodeAnalysis.GeneratorInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(553, 1969, 2284);
            return return_v;
        }

    }
}
