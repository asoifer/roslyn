// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class CompilationUnitCompletedEvent : CompilationEvent
    {
        public CompilationUnitCompletedEvent(Compilation compilation, SyntaxTree compilationUnit) : base(f_248_445_456_C(compilation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(248, 348, 532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(248, 544, 586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(248, 482, 521);

                this.CompilationUnit = compilationUnit;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(248, 348, 532);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(248, 348, 532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(248, 348, 532);
            }
        }

        public SyntaxTree CompilationUnit { get; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(248, 598, 740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(248, 656, 729);

                return "CompilationUnitCompletedEvent(" + f_248_698_722(f_248_698_713()) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(248, 598, 740);

                Microsoft.CodeAnalysis.SyntaxTree
                f_248_698_713()
                {
                    var return_v = CompilationUnit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(248, 698, 713);
                    return return_v;
                }


                string
                f_248_698_722(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(248, 698, 722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(248, 598, 740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(248, 598, 740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompilationUnitCompletedEvent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(248, 261, 747);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(248, 261, 747);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(248, 261, 747);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(248, 261, 747);

        static Microsoft.CodeAnalysis.Compilation
        f_248_445_456_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(248, 348, 532);
            return return_v;
        }

    }
}
