// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public partial class NodeInfo
{public class FieldInfo
{
private readonly string _propertyName;

private readonly Type _fieldType;

private readonly object _value;

public string PropertyName
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25132,734,818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25132,778,799);

return _propertyName;
DynAbs.Tracing.TraceSender.TraceExitMethod(25132,734,818);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25132,675,833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25132,675,833);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public Type FieldType
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25132,903,984);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25132,947,965);

return _fieldType;
DynAbs.Tracing.TraceSender.TraceExitMethod(25132,903,984);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25132,849,999);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25132,849,999);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public object Value
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25132,1067,1144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25132,1111,1125);

return _value;
DynAbs.Tracing.TraceSender.TraceExitMethod(25132,1067,1144);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25132,1015,1159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25132,1015,1159);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public FieldInfo(string propertyName, Type fieldType, object value)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25132,1175,1393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25132,555,568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25132,605,615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25132,654,660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25132,1275,1304);

_propertyName = propertyName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25132,1322,1345);

_fieldType = fieldType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25132,1363,1378);

_value = value;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25132,1175,1393);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25132,1175,1393);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25132,1175,1393);
}
		}

static FieldInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25132,484,1404);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25132,484,1404);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25132,484,1404);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25132,484,1404);
}
}
}
