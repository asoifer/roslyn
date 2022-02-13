// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class DiagnosticInfoWithSymbols : DiagnosticInfo
    {
        internal readonly ImmutableArray<Symbol> Symbols;

        internal DiagnosticInfoWithSymbols(ErrorCode errorCode, object[] arguments, ImmutableArray<Symbol> symbols)
        : base(f_10608_607_638_C(CSharp.MessageProvider.Instance), (int)errorCode, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10608, 479, 725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10608, 691, 714);

                this.Symbols = symbols;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10608, 479, 725);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10608, 479, 725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10608, 479, 725);
            }
        }

        internal DiagnosticInfoWithSymbols(bool isWarningAsError, ErrorCode errorCode, object[] arguments, ImmutableArray<Symbol> symbols)
        : base(f_10608_888_919_C(CSharp.MessageProvider.Instance), isWarningAsError, (int)errorCode, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10608, 737, 1024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10608, 990, 1013);

                this.Symbols = symbols;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10608, 737, 1024);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10608, 737, 1024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10608, 737, 1024);
            }
        }

        static DiagnosticInfoWithSymbols()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10608, 316, 1031);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10608, 316, 1031);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10608, 316, 1031);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10608, 316, 1031);

        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_10608_607_638_C(Microsoft.CodeAnalysis.CommonMessageProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10608, 479, 725);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_10608_888_919_C(Microsoft.CodeAnalysis.CommonMessageProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10608, 737, 1024);
            return return_v;
        }

    }
}
