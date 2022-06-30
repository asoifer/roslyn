// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Microsoft.CodeAnalysis
{
    internal class InvalidRuleSetException : Exception
    {
        public InvalidRuleSetException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(536, 460, 496);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(536, 460, 496);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(536, 460, 496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(536, 460, 496);
            }
        }

        public InvalidRuleSetException(string message) : base(f_536_560_567_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(536, 506, 572);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(536, 506, 572);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(536, 506, 572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(536, 506, 572);
            }
        }

        public InvalidRuleSetException(string message, Exception inner) : base(f_536_653_660_C(message), inner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(536, 582, 672);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(536, 582, 672);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(536, 582, 672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(536, 582, 672);
            }
        }

        static InvalidRuleSetException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(536, 393, 679);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(536, 393, 679);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(536, 393, 679);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(536, 393, 679);

        static string
        f_536_560_567_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(536, 506, 572);
            return return_v;
        }


        static string
        f_536_653_660_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(536, 582, 672);
            return return_v;
        }

    }
}
