// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public sealed class SourceTextValueProvider<TValue>
    {
        internal AnalysisValueProvider<SourceText, TValue> CoreValueProvider { get; private set; }

        public SourceTextValueProvider(Func<SourceText, TValue> computeValue, IEqualityComparer<SourceText>? sourceTextComparer = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(268, 1265, 1559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(268, 578, 668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(268, 1417, 1548);

                CoreValueProvider = f_268_1437_1547<TValue>(computeValue, sourceTextComparer ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.Text.SourceText>?>(268, 1497, 1546) ?? SourceTextComparer.Instance));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(268, 1265, 1559);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(268, 1265, 1559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(268, 1265, 1559);
            }
        }

        static SourceTextValueProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(268, 510, 1566);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(268, 510, 1566);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(268, 510, 1566);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(268, 510, 1566);

        static Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.Text.SourceText, TValue>
        f_268_1437_1547<TValue>(System.Func<Microsoft.CodeAnalysis.Text.SourceText, TValue>
        computeValue, System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.Text.SourceText>
        keyComparer)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.Text.SourceText, TValue>(computeValue, keyComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(268, 1437, 1547);
            return return_v;
        }

    }
}
