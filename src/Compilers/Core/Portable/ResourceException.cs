// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    internal sealed class ResourceException : Exception
    {
        internal ResourceException(string? name, Exception? inner = null)
        : base(f_29_420_424_C(name), inner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(29, 334, 454);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(29, 334, 454);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(29, 334, 454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(29, 334, 454);
            }
        }

        static ResourceException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(29, 266, 461);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(29, 266, 461);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(29, 266, 461);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(29, 266, 461);

        static string?
        f_29_420_424_C(string?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(29, 334, 454);
            return return_v;
        }

    }
}
