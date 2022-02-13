// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class StateMachineStates
    {
        internal const int
        FinishedStateMachine = -2
        ;

        internal const int
        NotStartedStateMachine = -1
        ;

        internal const int
        FirstUnusedState = 0
        ;

        internal const int
        InitialAsyncIteratorStateMachine = -3
        ;

        static StateMachineStates()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10543, 277, 698);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10543, 353, 378);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10543, 408, 435);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10543, 465, 485);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10543, 653, 690);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10543, 277, 698);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10543, 277, 698);
        }

    }
}
