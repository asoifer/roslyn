// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
internal static class ReportDiagnosticExtensions
{
public static string ToAnalyzerConfigString(this ReportDiagnostic reportDiagnostic)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25078,362,871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25078,470,860);

return reportDiagnostic switch
            {
                ReportDiagnostic.Error when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(25078,533,566) && DynAbs.Tracing.TraceSender.Expression_True(25078,533,566))
=> "error",
                ReportDiagnostic.Warn when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(25078,585,619) && DynAbs.Tracing.TraceSender.Expression_True(25078,585,619))
=> "warning",
                ReportDiagnostic.Info when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(25078,638,675) && DynAbs.Tracing.TraceSender.Expression_True(25078,638,675))
=> "suggestion",
                ReportDiagnostic.Hidden when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(25078,694,729) && DynAbs.Tracing.TraceSender.Expression_True(25078,694,729))
=> "silent",
                ReportDiagnostic.Suppress when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(25078,748,783) && DynAbs.Tracing.TraceSender.Expression_True(25078,748,783))
=> "none",
                _ when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(25078,802,843) && DynAbs.Tracing.TraceSender.Expression_True(25078,802,843))
=> throw f_25078_813_843(),
            };
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25078,362,871);

System.Exception
f_25078_813_843()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25078, 813, 843);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25078,362,871);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25078,362,871);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ReportDiagnosticExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25078,297,878);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25078,297,878);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25078,297,878);
}

}
}
