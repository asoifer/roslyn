// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{

    public struct CaptureId : IEquatable<CaptureId>
    {

        internal CaptureId(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(445, 507, 586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(445, 561, 575);

                Value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(445, 507, 586);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(445, 507, 586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(445, 507, 586);
            }
        }

        internal int Value { get; }

        public bool Equals(CaptureId other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(445, 768, 791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(445, 771, 791);
                return Value == other.Value; DynAbs.Tracing.TraceSender.TraceExitMethod(445, 768, 791);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(445, 768, 791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(445, 768, 791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(445, 872, 917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(445, 875, 917);
                return obj is CaptureId && (DynAbs.Tracing.TraceSender.Expression_True(445, 875, 917) && Equals(obj)); DynAbs.Tracing.TraceSender.TraceExitMethod(445, 872, 917);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(445, 872, 917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(445, 872, 917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(445, 991, 1013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(445, 994, 1013);
                return f_445_994_1013(Value); DynAbs.Tracing.TraceSender.TraceExitMethod(445, 991, 1013);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(445, 991, 1013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(445, 991, 1013);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_445_994_1013(int
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(445, 994, 1013);
                return return_v;
            }

        }
        static CaptureId()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(445, 443, 1021);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(445, 443, 1021);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(445, 443, 1021);
        }
    }
}

