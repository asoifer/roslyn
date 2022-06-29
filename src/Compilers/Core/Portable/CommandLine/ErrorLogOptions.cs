// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    public sealed class ErrorLogOptions
    {
        public string Path { get; }

        public SarifVersion SarifVersion { get; }

        public ErrorLogOptions(string path, SarifVersion sarifVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(135, 1076, 1369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(135, 566, 593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(135, 716, 757);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(135, 1163, 1288) || true) && (f_135_1167_1193(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(135, 1163, 1288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(135, 1227, 1273);

                    throw f_135_1233_1272(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(135, 1163, 1288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(135, 1304, 1316);

                Path = path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(135, 1330, 1358);

                SarifVersion = sarifVersion;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(135, 1076, 1369);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(135, 1076, 1369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(135, 1076, 1369);
            }
        }

        static ErrorLogOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(135, 417, 1376);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(135, 417, 1376);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(135, 417, 1376);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(135, 417, 1376);

        static bool
        f_135_1167_1193(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(135, 1167, 1193);
            return return_v;
        }


        static System.ArgumentNullException
        f_135_1233_1272(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(135, 1233, 1272);
            return return_v;
        }

    }
}
