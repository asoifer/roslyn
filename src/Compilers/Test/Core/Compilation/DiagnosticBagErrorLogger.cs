// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
internal sealed class DiagnosticBagErrorLogger : ErrorLogger
{
internal readonly DiagnosticBag Diagnostics;

internal DiagnosticBagErrorLogger(DiagnosticBag diagnostics)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25057,442,564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25057,418,429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25057,527,553);

Diagnostics = diagnostics;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25057,442,564);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25057,442,564);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25057,442,564);
}
		}

public override void LogDiagnostic(Diagnostic diagnostic, SuppressionInfo? suppressionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25057,576,731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25057,692,720);

f_25057_692_719(            Diagnostics, diagnostic);
DynAbs.Tracing.TraceSender.TraceExitMethod(25057,576,731);

int
f_25057_692_719(Microsoft.CodeAnalysis.DiagnosticBag
this_param,Microsoft.CodeAnalysis.Diagnostic
diag)
{
this_param.Add( diag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25057, 692, 719);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25057,576,731);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25057,576,731);
}
		}

static DiagnosticBagErrorLogger()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25057,309,738);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25057,309,738);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25057,309,738);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25057,309,738);
}
}
