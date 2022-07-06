// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Roslyn.Test.Utilities
{
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed class WorkItemAttribute : Attribute
{
public int Id
{            get;
}

public string Location
{            get;
}

public WorkItemAttribute(int id, string issueUri)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25053,1238,1365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25053,567,620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25053,632,694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25053,1312,1320);

Id = id;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25053,1334,1354);

Location = issueUri;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25053,1238,1365);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25053,1238,1365);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25053,1238,1365);
}
		}

static WorkItemAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25053,407,1372);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25053,407,1372);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25053,407,1372);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25053,407,1372);
}
}
