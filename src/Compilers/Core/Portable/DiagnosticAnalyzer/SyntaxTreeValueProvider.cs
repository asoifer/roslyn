// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public sealed class SyntaxTreeValueProvider<TValue>
    {
        internal AnalysisValueProvider<SyntaxTree, TValue> CoreValueProvider { get; private set; }

        public SyntaxTreeValueProvider(Func<SyntaxTree, TValue> computeValue, IEqualityComparer<SyntaxTree>? syntaxTreeComparer = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(275, 1222, 1516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(275, 542, 632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(275, 1374, 1505);

                CoreValueProvider = f_275_1394_1504<TValue>(computeValue, syntaxTreeComparer ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.SyntaxTree>?>(275, 1454, 1503) ?? SyntaxTreeComparer.Instance));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(275, 1222, 1516);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(275, 1222, 1516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(275, 1222, 1516);
            }
        }

        static SyntaxTreeValueProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(275, 474, 1523);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(275, 474, 1523);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(275, 474, 1523);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(275, 474, 1523);

        static Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.SyntaxTree, TValue>
        f_275_1394_1504<TValue>(System.Func<Microsoft.CodeAnalysis.SyntaxTree, TValue>
        computeValue, System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.SyntaxTree>
        keyComparer)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.SyntaxTree, TValue>(computeValue, keyComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(275, 1394, 1504);
            return return_v;
        }

    }
}
