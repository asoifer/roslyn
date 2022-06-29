// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Roslyn.Utilities
{
    internal static class CompilerPathUtilities
    {
        internal static void RequireAbsolutePath(string path, string argumentName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(299, 341, 771);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(299, 440, 551) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(299, 440, 551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(299, 490, 536);

                    throw f_299_496_535(argumentName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(299, 440, 551);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(299, 567, 760) || true) && (!f_299_572_602(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(299, 567, 760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(299, 636, 745);

                    throw f_299_642_744(f_299_664_729(), argumentName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(299, 567, 760);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(299, 341, 771);

                System.ArgumentNullException
                f_299_496_535(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(299, 496, 535);
                    return return_v;
                }


                static bool
                f_299_572_602(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(299, 572, 602);
                    return return_v;
                }


                string
                f_299_664_729()
                {
                    var return_v = Microsoft.CodeAnalysis.CodeAnalysisResources.AbsolutePathExpected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(299, 664, 729);
                    return return_v;
                }


                System.ArgumentException
                f_299_642_744(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(299, 642, 744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(299, 341, 771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(299, 341, 771);
            }
        }

        static CompilerPathUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(299, 281, 778);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(299, 281, 778);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(299, 281, 778);
        }

    }
}
