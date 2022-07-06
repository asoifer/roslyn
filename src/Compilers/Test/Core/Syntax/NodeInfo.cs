// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public partial class NodeInfo
{
private readonly string _className;

private readonly FieldInfo[] _fieldInfos;

private static readonly FieldInfo[] s_emptyFieldInfos ;

public string ClassName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25131,754,823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25131,790,808);

return _className;
DynAbs.Tracing.TraceSender.TraceExitMethod(25131,754,823);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25131,706,834);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25131,706,834);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public FieldInfo[] FieldInfos
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25131,900,1161);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25131,936,1146) || true) && (_fieldInfos == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25131,936,1146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25131,1001,1026);

return s_emptyFieldInfos;
DynAbs.Tracing.TraceSender.TraceExitCondition(25131,936,1146);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25131,936,1146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25131,1108,1127);

return _fieldInfos;
DynAbs.Tracing.TraceSender.TraceExitCondition(25131,936,1146);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25131,900,1161);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25131,846,1172);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25131,846,1172);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public NodeInfo(string className, FieldInfo[] fieldInfos)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25131,1184,1339);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25131,562,572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25131,612,623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25131,1266,1289);

_className = className;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25131,1303,1328);

_fieldInfos = fieldInfos;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25131,1184,1339);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25131,1184,1339);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25131,1184,1339);
}
		}

static NodeInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25131,492,1346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25131,670,693);
s_emptyFieldInfos = new FieldInfo[]{ };DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25131,492,1346);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25131,492,1346);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25131,492,1346);
}
}
