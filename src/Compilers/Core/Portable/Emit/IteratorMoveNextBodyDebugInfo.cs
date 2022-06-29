// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.Emit
{
    internal sealed class IteratorMoveNextBodyDebugInfo : StateMachineMoveNextBodyDebugInfo
    {
        public IteratorMoveNextBodyDebugInfo(Cci.IMethodDefinition kickoffMethod)
        : base(f_294_686_699_C(kickoffMethod))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(294, 592, 722);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(294, 592, 722);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(294, 592, 722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(294, 592, 722);
            }
        }

        static IteratorMoveNextBodyDebugInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(294, 488, 729);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(294, 488, 729);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(294, 488, 729);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(294, 488, 729);

        static Microsoft.Cci.IMethodDefinition
        f_294_686_699_C(Microsoft.Cci.IMethodDefinition
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(294, 592, 722);
            return return_v;
        }

    }
}
