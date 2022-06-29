// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    internal abstract partial class CommonCompiler
    {
        internal sealed class LoggingXmlFileResolver : XmlFileResolver
        {
            private readonly TouchedFileLogger? _logger;

            public LoggingXmlFileResolver(string? baseDirectory, TouchedFileLogger? logger)
            : base(f_132_563_576_C(baseDirectory))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(132, 459, 642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(132, 435, 442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(132, 610, 627);

                    _logger = logger;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(132, 459, 642);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(132, 459, 642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(132, 459, 642);
                }
            }

            protected override bool FileExists(string? fullPath)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(132, 658, 919);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(132, 743, 851) || true) && (fullPath != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(132, 743, 851);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(132, 805, 832);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_logger, 132, 805, 831)?.AddRead(fullPath), 132, 813, 831);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(132, 743, 851);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(132, 871, 904);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.FileExists(fullPath), 132, 878, 903);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(132, 658, 919);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(132, 658, 919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(132, 658, 919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static LoggingXmlFileResolver()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(132, 312, 930);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(132, 312, 930);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(132, 312, 930);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(132, 312, 930);

            static string?
            f_132_563_576_C(string?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(132, 459, 642);
                return return_v;
            }

        }
    }
}
