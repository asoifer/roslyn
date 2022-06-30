// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Text
{
    public abstract class SourceTextContainer
    {
        public abstract SourceText CurrentText { get; }

        /// <summary>
        /// Raised when the current text instance changes.
        /// </summary>
        public abstract event EventHandler<TextChangeEventArgs>
TextChanged
;

        public SourceTextContainer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(722, 433, 819);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(722, 433, 819);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(722, 433, 819);
        }


        static SourceTextContainer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(722, 433, 819);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(722, 433, 819);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(722, 433, 819);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(722, 433, 819);
    }
}
