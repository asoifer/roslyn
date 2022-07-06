// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Reflection;
using Microsoft.CodeAnalysis;

namespace Roslyn.Test.Utilities
{
public class TestAnalyzerAssemblyLoader : IAnalyzerAssemblyLoader
{
public static readonly IAnalyzerAssemblyLoader LoadFromFile ;

public static readonly IAnalyzerAssemblyLoader LoadNotImplemented ;

private readonly Action<string>? _addDependencyLocation;

private readonly Func<string, Assembly>? _loadFromPath;

public TestAnalyzerAssemblyLoader(Action<string>? addDependencyLocation = null, Func<string, Assembly>? loadFromPath = null)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25113,837,1087);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25113,737,759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25113,811,824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25113,986,1033);

_addDependencyLocation = addDependencyLocation;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25113,1047,1076);

_loadFromPath = loadFromPath;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25113,837,1087);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25113,837,1087);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25113,837,1087);
}
		}

public void AddDependencyLocation(string fullPath)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25113,1163,1206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25113,1166,1206);
DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_addDependencyLocation, 25113, 1166, 1206)?.Invoke(fullPath),25113,1189,1206);DynAbs.Tracing.TraceSender.TraceExitMethod(25113,1163,1206);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25113,1163,1206);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25113,1163,1206);
}
		}

public Assembly LoadFromPath(string fullPath)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25113,1278,1360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25113,1281,1360);
return (DynAbs.Tracing.TraceSender.Conditional_F1(25113, 1281, 1304)||(((_loadFromPath != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(25113, 1307, 1330))||DynAbs.Tracing.TraceSender.Conditional_F3(25113, 1333, 1360)))?f_25113_1307_1330(this, fullPath):f_25113_1333_1360(fullPath);DynAbs.Tracing.TraceSender.TraceExitMethod(25113,1278,1360);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25113,1278,1360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25113,1278,1360);
}
			throw new System.Exception("Slicer error: unreachable code");

System.Reflection.Assembly
f_25113_1307_1330(Roslyn.Test.Utilities.TestAnalyzerAssemblyLoader
this_param,string
arg)
{
var return_v = this_param._loadFromPath( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25113, 1307, 1330);
return return_v;
}


System.Reflection.Assembly
f_25113_1333_1360(string
assemblyFile)
{
var return_v = Assembly.LoadFrom( assemblyFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25113, 1333, 1360);
return return_v;
}

		}

static TestAnalyzerAssemblyLoader()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25113,322,1368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25113,451,511);
LoadFromFile = f_25113_479_511();DynAbs.Tracing.TraceSender.TraceSimpleStatement(25113,571,691);
LoadNotImplemented = f_25113_605_691(loadFromPath: _ => throw new NotImplementedException());DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25113,322,1368);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25113,322,1368);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25113,322,1368);

static Roslyn.Test.Utilities.TestAnalyzerAssemblyLoader
f_25113_479_511()
{
var return_v = new Roslyn.Test.Utilities.TestAnalyzerAssemblyLoader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25113, 479, 511);
return return_v;
}


static Roslyn.Test.Utilities.TestAnalyzerAssemblyLoader
f_25113_605_691(System.Func<string, System.Reflection.Assembly>?
loadFromPath)
{
var return_v = new Roslyn.Test.Utilities.TestAnalyzerAssemblyLoader( loadFromPath: loadFromPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25113, 605, 691);
return return_v;
}

}
}
