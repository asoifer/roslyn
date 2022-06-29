// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{

    [DebuggerDisplay("{Path,nq}")]
    public struct CommandLineSourceFile
    {

        public CommandLineSourceFile(string path, bool isScript) : this(f_125_563_567_C(path), isScript, false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(125, 486, 598);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(125, 486, 598);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(125, 486, 598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(125, 486, 598);
            }
        }

        public CommandLineSourceFile(string path, bool isScript, bool isInputRedirected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(125, 610, 882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(125, 715, 757);

                f_125_715_756(!f_125_729_755(path));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(125, 773, 785);

                Path = path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(125, 799, 819);

                IsScript = isScript;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(125, 833, 871);

                IsInputRedirected = isInputRedirected;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(125, 610, 882);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(125, 610, 882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(125, 610, 882);
            }
        }

        public string Path { get; }

        public bool IsInputRedirected { get; }

        public bool IsScript { get; }
        static CommandLineSourceFile()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(125, 398, 1564);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(125, 398, 1564);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(125, 398, 1564);
        }

        static string
        f_125_563_567_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(125, 486, 598);
            return return_v;
        }


        static bool
        f_125_729_755(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 729, 755);
            return return_v;
        }


        static int
        f_125_715_756(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 715, 756);
            return 0;
        }

    }
}
