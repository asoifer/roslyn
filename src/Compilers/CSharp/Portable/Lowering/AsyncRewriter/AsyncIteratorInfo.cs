// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class AsyncIteratorInfo
    {
        internal FieldSymbol PromiseOfValueOrEndField { get; }

        internal FieldSymbol CombinedTokensField { get; }

        internal FieldSymbol CurrentField { get; }

        internal FieldSymbol DisposeModeField { get; }

        internal MethodSymbol SetResultMethod { get; }

        internal MethodSymbol SetExceptionMethod { get; }

        public AsyncIteratorInfo(FieldSymbol promiseOfValueOrEndField, FieldSymbol combinedTokensField, FieldSymbol currentField, FieldSymbol disposeModeField,
                    MethodSymbol setResultMethod, MethodSymbol setExceptionMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10444, 1385, 1950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 588, 642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 741, 790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 847, 889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 958, 1004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 1134, 1180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 1324, 1373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 1637, 1689);

                PromiseOfValueOrEndField = promiseOfValueOrEndField;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 1703, 1745);

                CombinedTokensField = combinedTokensField;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 1759, 1787);

                CurrentField = currentField;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 1801, 1837);

                DisposeModeField = disposeModeField;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 1851, 1885);

                SetResultMethod = setResultMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10444, 1899, 1939);

                SetExceptionMethod = setExceptionMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10444, 1385, 1950);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10444, 1385, 1950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10444, 1385, 1950);
            }
        }

        static AsyncIteratorInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10444, 429, 1957);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10444, 429, 1957);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10444, 429, 1957);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10444, 429, 1957);
    }
}
