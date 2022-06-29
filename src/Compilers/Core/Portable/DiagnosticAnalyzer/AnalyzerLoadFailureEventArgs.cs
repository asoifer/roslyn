// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public sealed class AnalyzerLoadFailureEventArgs : EventArgs
    {
        public enum FailureErrorCode
        {
            None = 0,
            UnableToLoadAnalyzer = 1,
            UnableToCreateAnalyzer = 2,
            NoAnalyzers = 3,
            ReferencesFramework = 4
        }

        public string? TypeName { get; }

        public string Message { get; }

        public FailureErrorCode ErrorCode { get; }

        public Exception? Exception { get; }

        public AnalyzerLoadFailureEventArgs(FailureErrorCode errorCode, string message, Exception? exceptionOpt = null, string? typeNameOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(234, 1205, 1855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 743, 775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 862, 892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 976, 1018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 1157, 1193);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 1369, 1565) || true) && (errorCode <= FailureErrorCode.None || (DynAbs.Tracing.TraceSender.Expression_False(234, 1373, 1459) || errorCode > FailureErrorCode.ReferencesFramework))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(234, 1369, 1565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 1493, 1550);

                    throw f_234_1499_1549(nameof(errorCode));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(234, 1369, 1565);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 1581, 1698) || true) && (message == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(234, 1581, 1698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 1634, 1683);

                    throw f_234_1640_1682(nameof(message));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(234, 1581, 1698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 1714, 1736);

                ErrorCode = errorCode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 1750, 1768);

                Message = message;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 1782, 1805);

                TypeName = typeNameOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(234, 1819, 1844);

                Exception = exceptionOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(234, 1205, 1855);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(234, 1205, 1855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(234, 1205, 1855);
            }
        }

        static AnalyzerLoadFailureEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(234, 278, 1862);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(234, 278, 1862);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(234, 278, 1862);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(234, 278, 1862);

        static System.ArgumentOutOfRangeException
        f_234_1499_1549(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(234, 1499, 1549);
            return return_v;
        }


        static System.ArgumentNullException
        f_234_1640_1682(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(234, 1640, 1682);
            return return_v;
        }

    }
}
