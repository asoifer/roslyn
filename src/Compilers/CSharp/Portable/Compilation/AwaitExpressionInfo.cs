// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{

public struct AwaitExpressionInfo : IEquatable<AwaitExpressionInfo>
    {

public IMethodSymbol? GetAwaiterMethod {get; }

public IPropertySymbol? IsCompletedProperty {get; }

public IMethodSymbol? GetResultMethod {get; }

public bool IsDynamic {get; }

internal AwaitExpressionInfo(IMethodSymbol getAwaiter, IPropertySymbol isCompleted, IMethodSymbol getResult, bool isDynamic)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(10912,726,1042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10912,875,905);

GetAwaiterMethod = getAwaiter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10912,919,953);

IsCompletedProperty = isCompleted;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10912,967,995);

GetResultMethod = getResult;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10912,1009,1031);

IsDynamic = isDynamic;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10912,726,1042);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10912,726,1042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10912,726,1042);
}
		}

public override bool Equals(object? obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10912,1054,1197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10912,1119,1186);

return obj is AwaitExpressionInfo otherAwait &&(DynAbs.Tracing.TraceSender.Expression_True(10912, 1126, 1185)&&Equals(otherAwait));
DynAbs.Tracing.TraceSender.TraceExitMethod(10912,1054,1197);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10912,1054,1197);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10912,1054,1197);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool Equals(AwaitExpressionInfo other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10912,1209,1573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10912,1279,1562);

return f_10912_1286_1346(this.GetAwaiterMethod, other.GetAwaiterMethod)&&(DynAbs.Tracing.TraceSender.Expression_True(10912, 1286, 1433)&&f_10912_1367_1433(this.IsCompletedProperty, other.IsCompletedProperty))&&(DynAbs.Tracing.TraceSender.Expression_True(10912, 1286, 1512)&&f_10912_1454_1512(this.GetResultMethod, other.GetResultMethod))&&(DynAbs.Tracing.TraceSender.Expression_True(10912, 1286, 1561)&&IsDynamic == other.IsDynamic);
DynAbs.Tracing.TraceSender.TraceExitMethod(10912,1209,1573);

bool
f_10912_1286_1346(Microsoft.CodeAnalysis.IMethodSymbol?
objA,Microsoft.CodeAnalysis.IMethodSymbol?
objB)
{
var return_v = object.Equals( (object?)objA, (object?)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10912, 1286, 1346);
return return_v;
}


bool
f_10912_1367_1433(Microsoft.CodeAnalysis.IPropertySymbol?
objA,Microsoft.CodeAnalysis.IPropertySymbol?
objB)
{
var return_v = object.Equals( (object?)objA, (object?)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10912, 1367, 1433);
return return_v;
}


bool
f_10912_1454_1512(Microsoft.CodeAnalysis.IMethodSymbol?
objA,Microsoft.CodeAnalysis.IMethodSymbol?
objB)
{
var return_v = object.Equals( (object?)objA, (object?)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10912, 1454, 1512);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10912,1209,1573);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10912,1209,1573);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int GetHashCode()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10912,1585,1783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10912,1643,1772);

return f_10912_1650_1771(GetAwaiterMethod, f_10912_1681_1770(IsCompletedProperty, f_10912_1715_1769(GetResultMethod, f_10912_1745_1768(IsDynamic))));
DynAbs.Tracing.TraceSender.TraceExitMethod(10912,1585,1783);

int
f_10912_1745_1768(bool
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10912, 1745, 1768);
return return_v;
}


int
f_10912_1715_1769(Microsoft.CodeAnalysis.IMethodSymbol?
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10912, 1715, 1769);
return return_v;
}


int
f_10912_1681_1770(Microsoft.CodeAnalysis.IPropertySymbol?
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10912, 1681, 1770);
return return_v;
}


int
f_10912_1650_1771(Microsoft.CodeAnalysis.IMethodSymbol?
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10912, 1650, 1771);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10912,1585,1783);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10912,1585,1783);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static AwaitExpressionInfo(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10912,419,1790);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10912,419,1790);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10912,419,1790);
}
    }
}
