// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;
using System;

namespace Microsoft.CodeAnalysis.CSharp
{

public struct QueryClauseInfo : IEquatable<QueryClauseInfo>
    {

private readonly SymbolInfo _castInfo;

private readonly SymbolInfo _operationInfo;

internal QueryClauseInfo(SymbolInfo castInfo, SymbolInfo operationInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(10927,603,776);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10927,699,720);

_castInfo = castInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10927,734,765);

_operationInfo = operationInfo;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10927,603,776);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10927,603,776);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10927,603,776);
}
		}

public SymbolInfo CastInfo
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(10927,1369,1394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10927,1375,1392);

return _castInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(10927,1369,1394);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10927,1318,1405);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10927,1318,1405);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public SymbolInfo OperationInfo
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(10927,1910,1940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10927,1916,1938);

return _operationInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(10927,1910,1940);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10927,1854,1951);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10927,1854,1951);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool Equals(object? obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10927,1963,2101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10927,2028,2090);

return obj is QueryClauseInfo &&(DynAbs.Tracing.TraceSender.Expression_True(10927, 2035, 2089)&&Equals(obj));
DynAbs.Tracing.TraceSender.TraceExitMethod(10927,1963,2101);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10927,1963,2101);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10927,1963,2101);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool Equals(QueryClauseInfo other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10927,2113,2295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10927,2179,2284);

return _castInfo.Equals(other._castInfo)&&(DynAbs.Tracing.TraceSender.Expression_True(10927, 2186, 2283)&&_operationInfo.Equals(other._operationInfo));
DynAbs.Tracing.TraceSender.TraceExitMethod(10927,2113,2295);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10927,2113,2295);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10927,2113,2295);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int GetHashCode()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10927,2307,2455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10927,2365,2444);

return f_10927_2372_2443(this.CastInfo.GetHashCode(), _operationInfo.GetHashCode());
DynAbs.Tracing.TraceSender.TraceExitMethod(10927,2307,2455);

int
f_10927_2372_2443(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10927, 2372, 2443);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10927,2307,2455);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10927,2307,2455);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static QueryClauseInfo(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10927,424,2462);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10927,424,2462);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10927,424,2462);
}
    }
}
