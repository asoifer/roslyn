// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    internal class UnsupportedSignatureContent
            : Exception
    {
        public UnsupportedSignatureContent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(419, 323, 400);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(419, 323, 400);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(419, 323, 400);
        }


        static UnsupportedSignatureContent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(419, 323, 400);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(419, 323, 400);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(419, 323, 400);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(419, 323, 400);
    }
}
