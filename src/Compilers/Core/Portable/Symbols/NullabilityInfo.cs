// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public readonly struct NullabilityInfo : IEquatable<NullabilityInfo>
    {

        public NullableAnnotation Annotation { get; }

        public NullableFlowState FlowState { get; }

        internal NullabilityInfo(NullableAnnotation annotation, NullableFlowState flowState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(636, 1166, 1346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(636, 1275, 1299);

                Annotation = annotation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(636, 1313, 1335);

                FlowState = flowState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(636, 1166, 1346);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(636, 1166, 1346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(636, 1166, 1346);
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(636, 1394, 1453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(636, 1397, 1453);
                return $"{{Annotation: {Annotation}, Flow State: {FlowState}}}"; DynAbs.Tracing.TraceSender.TraceExitMethod(636, 1394, 1453);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(636, 1394, 1453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(636, 1394, 1453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(636, 1509, 1570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(636, 1525, 1570);
                return other is NullabilityInfo info && (DynAbs.Tracing.TraceSender.Expression_True(636, 1525, 1570) && Equals(info)); DynAbs.Tracing.TraceSender.TraceExitMethod(636, 1509, 1570);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(636, 1509, 1570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(636, 1509, 1570);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(636, 1617, 1696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(636, 1633, 1696);
                return f_636_1633_1696(f_636_1646_1670(Annotation), f_636_1672_1695(FlowState)); DynAbs.Tracing.TraceSender.TraceExitMethod(636, 1617, 1696);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(636, 1617, 1696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(636, 1617, 1696);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_636_1646_1670(Microsoft.CodeAnalysis.NullableAnnotation
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(636, 1646, 1670);
                return return_v;
            }


            int
            f_636_1672_1695(Microsoft.CodeAnalysis.NullableFlowState
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(636, 1672, 1695);
                return return_v;
            }


            int
            f_636_1633_1696(int
            newKey, int
            currentKey)
            {
                var return_v = Hash.Combine(newKey, currentKey);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(636, 1633, 1696);
                return return_v;
            }

        }

        public bool Equals(NullabilityInfo other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(636, 1751, 1842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(636, 1767, 1842);
                return Annotation == other.Annotation && (DynAbs.Tracing.TraceSender.Expression_True(636, 1767, 1842) && FlowState == other.FlowState); DynAbs.Tracing.TraceSender.TraceExitMethod(636, 1751, 1842);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(636, 1751, 1842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(636, 1751, 1842);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static NullabilityInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(636, 318, 1850);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(636, 318, 1850);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(636, 318, 1850);
        }
    }
}
