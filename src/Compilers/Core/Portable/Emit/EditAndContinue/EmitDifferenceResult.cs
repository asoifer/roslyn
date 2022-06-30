// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Emit
{
public sealed class EmitDifferenceResult : EmitResult
{
public EmitBaseline Baseline {get; }

internal EmitDifferenceResult(bool success, ImmutableArray<Diagnostic> diagnostics, EmitBaseline baseline) :base(f_760_539_546_C(success) ,diagnostics)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(760,412,616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(760,363,400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(760,585,605);

Baseline = baseline;
DynAbs.Tracing.TraceSender.TraceExitConstructor(760,412,616);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(760,412,616);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(760,412,616);
}
		}

static EmitDifferenceResult()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(760,293,623);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(760,293,623);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(760,293,623);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(760,293,623);

static bool
f_760_539_546_C(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(760, 412, 616);
return return_v;
}

}
}
