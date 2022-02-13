// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class AbstractFlowPass<TLocalState, TLocalFunctionState>
    {
        protected abstract TLocalState TopState();

        protected abstract TLocalState UnreachableState();

        protected virtual TLocalState ReachableBottomState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10878, 1772, 1782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10878, 1775, 1782);
                return default; DynAbs.Tracing.TraceSender.TraceExitMethod(10878, 1772, 1782);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10878, 1772, 1782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10878, 1772, 1782);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract bool Join(ref TLocalState self, ref TLocalState other);

        protected abstract bool Meet(ref TLocalState self, ref TLocalState other);

        internal interface ILocalState
        {

            TLocalState Clone();

            bool Reachable { get; }
        }
    }
}
