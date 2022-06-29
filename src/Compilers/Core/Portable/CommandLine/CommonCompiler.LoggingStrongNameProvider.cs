// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    internal abstract partial class CommonCompiler
    {
        internal sealed class LoggingStrongNameFileSystem : StrongNameFileSystem
        {
            private readonly TouchedFileLogger? _loggerOpt;

            public LoggingStrongNameFileSystem(TouchedFileLogger? logger, string? customTempPath)
            : base(f_131_621_635_C(customTempPath))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(131, 511, 704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(131, 484, 494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(131, 669, 689);

                    _loggerOpt = logger;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(131, 511, 704);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(131, 511, 704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(131, 511, 704);
                }
            }

            internal override bool FileExists(string? fullPath)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(131, 720, 983);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(131, 804, 915) || true) && (fullPath != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(131, 804, 915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(131, 866, 896);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_loggerOpt, 131, 866, 895)?.AddRead(fullPath), 131, 877, 895);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(131, 804, 915);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(131, 935, 968);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.FileExists(fullPath), 131, 942, 967);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(131, 720, 983);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(131, 720, 983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(131, 720, 983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override byte[] ReadAllBytes(string fullPath)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(131, 999, 1184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(131, 1086, 1116);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_loggerOpt, 131, 1086, 1115)?.AddRead(fullPath), 131, 1097, 1115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(131, 1134, 1169);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ReadAllBytes(fullPath), 131, 1141, 1168);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(131, 999, 1184);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(131, 999, 1184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(131, 999, 1184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static LoggingStrongNameFileSystem()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(131, 351, 1195);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(131, 351, 1195);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(131, 351, 1195);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(131, 351, 1195);

            static string?
            f_131_621_635_C(string?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(131, 511, 704);
                return return_v;
            }

        }
    }
}
