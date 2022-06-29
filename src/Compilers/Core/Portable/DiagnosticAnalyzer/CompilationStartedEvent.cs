// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class CompilationStartedEvent : CompilationEvent
    {
        public ImmutableArray<AdditionalText> AdditionalFiles { get; }

        private CompilationStartedEvent(Compilation compilation, ImmutableArray<AdditionalText> additionalFiles)
        : base(f_247_685_696_C(compilation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(247, 560, 767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(247, 722, 756);

                AdditionalFiles = additionalFiles;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(247, 560, 767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(247, 560, 767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(247, 560, 767);
            }
        }

        public CompilationStartedEvent(Compilation compilation)
        : this(f_247_855_866_C(compilation), ImmutableArray<AdditionalText>.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(247, 779, 927);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(247, 779, 927);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(247, 779, 927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(247, 779, 927);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(247, 939, 1041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(247, 997, 1030);

                return "CompilationStartedEvent";
                DynAbs.Tracing.TraceSender.TraceExitMethod(247, 939, 1041);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(247, 939, 1041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(247, 939, 1041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationStartedEvent WithAdditionalFiles(ImmutableArray<AdditionalText> additionalFiles)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(247, 1165, 1225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(247, 1168, 1225);
                return f_247_1168_1225(f_247_1196_1207(), additionalFiles); DynAbs.Tracing.TraceSender.TraceExitMethod(247, 1165, 1225);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(247, 1165, 1225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(247, 1165, 1225);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Compilation
            f_247_1196_1207()
            {
                var return_v = Compilation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(247, 1196, 1207);
                return return_v;
            }


            Microsoft.CodeAnalysis.Diagnostics.CompilationStartedEvent
            f_247_1168_1225(Microsoft.CodeAnalysis.Compilation
            compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
            additionalFiles)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationStartedEvent(compilation, additionalFiles);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(247, 1168, 1225);
                return return_v;
            }

        }

        static CompilationStartedEvent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(247, 405, 1233);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(247, 405, 1233);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(247, 405, 1233);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(247, 405, 1233);

        static Microsoft.CodeAnalysis.Compilation
        f_247_685_696_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(247, 560, 767);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_247_855_866_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(247, 779, 927);
            return return_v;
        }

    }
}
