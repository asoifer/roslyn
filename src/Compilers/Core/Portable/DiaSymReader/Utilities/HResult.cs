// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.DiaSymReader
{
internal static class HResult
{
internal const int 
S_OK = 0
;

internal const int 
S_FALSE = 1
;

internal const int 
E_NOTIMPL = unchecked((int)0x80004001)
;

internal const int 
E_FAIL = unchecked((int)0x80004005)
;

internal const int 
E_INVALIDARG = unchecked((int)0x80070057)
;

internal const int 
E_UNEXPECTED = unchecked((int)0x8000FFFF)
;

static HResult()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(744,270,667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(744,335,343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(744,373,384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(744,414,452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(744,482,517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(744,547,588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(744,618,659);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(744,270,667);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(744,270,667);
}

}
}
