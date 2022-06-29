// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class DynamicAnalysisMethodBodyData
    {
        public readonly ImmutableArray<SourceSpan> Spans;

        public DynamicAnalysisMethodBodyData(ImmutableArray<SourceSpan> spans)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(54, 452, 617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(54, 547, 578);

                f_54_547_577(f_54_560_576_M(!spans.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(54, 592, 606);

                Spans = spans;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(54, 452, 617);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(54, 452, 617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(54, 452, 617);
            }
        }

        static DynamicAnalysisMethodBodyData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(54, 323, 624);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(54, 323, 624);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(54, 323, 624);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(54, 323, 624);

        bool
        f_54_560_576_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(54, 560, 576);
            return return_v;
        }


        static int
        f_54_547_577(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(54, 547, 577);
            return 0;
        }

    }
}
