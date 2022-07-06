// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    internal class NullErrorLogger : ErrorLogger
    {
        internal static ErrorLogger Instance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25059, 407, 431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25059, 410, 431);
                    return f_25059_410_431(); DynAbs.Tracing.TraceSender.TraceExitMethod(25059, 407, 431);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25059, 407, 431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25059, 407, 431);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void LogDiagnostic(Diagnostic diagnostic, SuppressionInfo? suppressionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25059, 444, 557);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25059, 444, 557);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25059, 444, 557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25059, 444, 557);
            }
        }

        public NullErrorLogger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25059, 309, 564);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25059, 309, 564);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25059, 309, 564);
        }


        static NullErrorLogger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25059, 309, 564);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25059, 309, 564);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25059, 309, 564);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25059, 309, 564);

        static Microsoft.CodeAnalysis.Test.Utilities.NullErrorLogger
        f_25059_410_431()
        {
            var return_v = new Microsoft.CodeAnalysis.Test.Utilities.NullErrorLogger();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25059, 410, 431);
            return return_v;
        }

    }
}
