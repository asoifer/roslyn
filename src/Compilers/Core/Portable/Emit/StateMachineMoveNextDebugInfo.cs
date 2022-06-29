// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Emit
{
    internal abstract class StateMachineMoveNextBodyDebugInfo
    {
        public readonly Cci.IMethodDefinition KickoffMethod;

        public StateMachineMoveNextBodyDebugInfo(Cci.IMethodDefinition kickoffMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(298, 687, 880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(298, 661, 674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(298, 789, 825);

                f_298_789_824(kickoffMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(298, 839, 869);

                KickoffMethod = kickoffMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(298, 687, 880);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(298, 687, 880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(298, 687, 880);
            }
        }

        static StateMachineMoveNextBodyDebugInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(298, 428, 887);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(298, 428, 887);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(298, 428, 887);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(298, 428, 887);

        static int
        f_298_789_824(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(298, 789, 824);
            return 0;
        }

    }
}
