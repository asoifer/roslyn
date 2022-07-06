// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Roslyn.Test.Utilities
{
internal class TestAnalyzerReference : AnalyzerReference
{
private readonly string? _fullPath;

private readonly string? _display;

private readonly object? _id;

public TestAnalyzerReference(string? fullPath = null, string? display = null, object? id = null)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25114,548,757);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25114,443,452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25114,488,496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25114,532,535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25114,669,690);

_fullPath = fullPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25114,704,723);

_display = display;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25114,737,746);

_id = id;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25114,548,757);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25114,548,757);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25114,548,757);
}
		}

public override string Display {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25114,800,850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25114,803,850);
return _display ??(DynAbs.Tracing.TraceSender.Expression_Null<string?>(25114, 803, 850)??throw f_25114_821_850());DynAbs.Tracing.TraceSender.TraceExitMethod(25114,800,850);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25114,800,850);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25114,800,850);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string FullPath {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25114,893,944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25114,896,944);
return _fullPath ??(DynAbs.Tracing.TraceSender.Expression_Null<string?>(25114, 896, 944)??throw f_25114_915_944());DynAbs.Tracing.TraceSender.TraceExitMethod(25114,893,944);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25114,893,944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25114,893,944);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override object Id {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25114,981,1026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25114,984,1026);
return _id ??(DynAbs.Tracing.TraceSender.Expression_Null<object?>(25114, 984, 1026)??throw f_25114_997_1026());DynAbs.Tracing.TraceSender.TraceExitMethod(25114,981,1026);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25114,981,1026);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25114,981,1026);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override ImmutableArray<DiagnosticAnalyzer> GetAnalyzers(string language) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25114,1120,1158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25114,1123,1158);
throw f_25114_1129_1158();DynAbs.Tracing.TraceSender.TraceExitMethod(25114,1120,1158);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25114,1120,1158);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25114,1120,1158);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_25114_1129_1158()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25114, 1129, 1158);
return return_v;
}

		}

public override ImmutableArray<DiagnosticAnalyzer> GetAnalyzersForAllLanguages() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25114,1250,1288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25114,1253,1288);
throw f_25114_1259_1288();DynAbs.Tracing.TraceSender.TraceExitMethod(25114,1250,1288);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25114,1250,1288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25114,1250,1288);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_25114_1259_1288()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25114, 1259, 1288);
return return_v;
}

		}

static TestAnalyzerReference()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25114,345,1296);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25114,345,1296);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25114,345,1296);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25114,345,1296);

System.NotImplementedException
f_25114_821_850()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25114, 821, 850);
return return_v;
}


System.NotImplementedException
f_25114_915_944()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25114, 915, 944);
return return_v;
}


System.NotImplementedException
f_25114_997_1026()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25114, 997, 1026);
return return_v;
}

}
}
