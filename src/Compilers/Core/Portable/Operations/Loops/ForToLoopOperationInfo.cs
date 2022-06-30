// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Operations
{
internal class ForToLoopOperationUserDefinedInfo
{
public readonly IBinaryOperation Addition;

public readonly IBinaryOperation Subtraction;

public readonly IOperation LessThanOrEqual;

public readonly IOperation GreaterThanOrEqual;

public ForToLoopOperationUserDefinedInfo(IBinaryOperation addition, IBinaryOperation subtraction, IOperation lessThanOrEqual, IOperation greaterThanOrEqual)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(781,560,914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(781,375,383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(781,427,438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(781,476,491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(781,529,547);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(781,741,761);

Addition = addition;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(781,775,801);

Subtraction = subtraction;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(781,815,849);

LessThanOrEqual = lessThanOrEqual;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(781,863,903);

GreaterThanOrEqual = greaterThanOrEqual;
DynAbs.Tracing.TraceSender.TraceExitConstructor(781,560,914);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(781,560,914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(781,560,914);
}
		}

static ForToLoopOperationUserDefinedInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(781,277,921);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(781,277,921);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(781,277,921);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(781,277,921);
}
}
