// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{

    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal struct BoundPatternBinding
    {

        public readonly BoundExpression VariableAccess;

        public readonly BoundDagTemp TempContainingValue;

        public BoundPatternBinding(BoundExpression variableAccess, BoundDagTemp tempContainingValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10571, 527, 753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10571, 644, 681);

                this.VariableAccess = variableAccess;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10571, 695, 742);

                this.TempContainingValue = tempContainingValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10571, 527, 753);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10571, 527, 753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10571, 527, 753);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10571, 763, 860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10571, 821, 849);

                return GetDebuggerDisplay();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10571, 763, 860);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10571, 763, 860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10571, 763, 860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10571, 870, 1037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10571, 931, 1026);

                return $"({f_10571_942_977(VariableAccess)} = {f_10571_982_1022(TempContainingValue)})";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10571, 870, 1037);

                string
                f_10571_942_977(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.GetDebuggerDisplay();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10571, 942, 977);
                    return return_v;
                }


                string
                f_10571_982_1022(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.GetDebuggerDisplay();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10571, 982, 1022);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10571, 870, 1037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10571, 870, 1037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static BoundPatternBinding()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10571, 306, 1044);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10571, 306, 1044);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10571, 306, 1044);
        }
    }
}
