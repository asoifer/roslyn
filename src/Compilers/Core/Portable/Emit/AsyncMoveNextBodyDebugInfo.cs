// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Emit
{
    internal sealed class AsyncMoveNextBodyDebugInfo : StateMachineMoveNextBodyDebugInfo
    {
        public readonly int CatchHandlerOffset;

        public readonly ImmutableArray<int> YieldOffsets;

        public readonly ImmutableArray<int> ResumeOffsets;

        public AsyncMoveNextBodyDebugInfo(
                    Cci.IMethodDefinition kickoffMethod,
                    int catchHandlerOffset,
                    ImmutableArray<int> yieldOffsets,
                    ImmutableArray<int> resumeOffsets)
        : base(f_285_1391_1404_C(kickoffMethod))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(285, 1154, 1746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(285, 764, 782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(285, 1430, 1468);

                f_285_1430_1467(f_285_1443_1466_M(!yieldOffsets.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(285, 1482, 1521);

                f_285_1482_1520(f_285_1495_1519_M(!resumeOffsets.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(285, 1535, 1593);

                f_285_1535_1592(yieldOffsets.Length == resumeOffsets.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(285, 1609, 1649);

                CatchHandlerOffset = catchHandlerOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(285, 1663, 1691);

                YieldOffsets = yieldOffsets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(285, 1705, 1735);

                ResumeOffsets = resumeOffsets;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(285, 1154, 1746);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(285, 1154, 1746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(285, 1154, 1746);
            }
        }

        static AsyncMoveNextBodyDebugInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(285, 548, 1753);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(285, 548, 1753);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(285, 548, 1753);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(285, 548, 1753);

        bool
        f_285_1443_1466_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(285, 1443, 1466);
            return return_v;
        }


        static int
        f_285_1430_1467(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(285, 1430, 1467);
            return 0;
        }


        bool
        f_285_1495_1519_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(285, 1495, 1519);
            return return_v;
        }


        static int
        f_285_1482_1520(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(285, 1482, 1520);
            return 0;
        }


        static int
        f_285_1535_1592(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(285, 1535, 1592);
            return 0;
        }


        static Microsoft.Cci.IMethodDefinition
        f_285_1391_1404_C(Microsoft.Cci.IMethodDefinition
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(285, 1154, 1746);
            return return_v;
        }

    }
}
