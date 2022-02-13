// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct SingleLookupResult
    {

        internal readonly LookupResultKind Kind;

        internal readonly Symbol Symbol;

        internal readonly DiagnosticInfo Error;

        internal SingleLookupResult(LookupResultKind kind, Symbol symbol, DiagnosticInfo error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10368, 1048, 1256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10368, 1160, 1177);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10368, 1191, 1212);

                this.Symbol = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10368, 1226, 1245);

                this.Error = error;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10368, 1048, 1256);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10368, 1048, 1256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10368, 1048, 1256);
            }
        }
        static SingleLookupResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10368, 714, 1263);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10368, 714, 1263);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10368, 714, 1263);
        }
    }
}
