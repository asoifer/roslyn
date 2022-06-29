// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    public abstract class AdditionalText
    {
        public abstract string Path { get; }

        public abstract SourceText? GetText(CancellationToken cancellationToken = default);

        public AdditionalText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(206, 395, 858);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(206, 395, 858);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(206, 395, 858);
        }


        static AdditionalText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(206, 395, 858);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(206, 395, 858);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(206, 395, 858);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(206, 395, 858);
    }
}
