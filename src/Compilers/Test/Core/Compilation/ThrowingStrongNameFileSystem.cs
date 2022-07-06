// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Roslyn.Test.Utilities
{
internal sealed class ThrowingStrongNameFileSystem : StrongNameFileSystem
{
internal static new readonly ThrowingStrongNameFileSystem Instance ;

internal override bool FileExists(string fullPath) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25066,673,699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25066,676,699);
throw f_25066_682_699();DynAbs.Tracing.TraceSender.TraceExitMethod(25066,673,699);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25066,673,699);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25066,673,699);
}
			throw new System.Exception("Slicer error: unreachable code");

System.IO.IOException
f_25066_682_699()
{
var return_v = new System.IO.IOException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25066, 682, 699);
return return_v;
}

		}

internal override byte[] ReadAllBytes(string fullPath) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25066,767,793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25066,770,793);
throw f_25066_776_793();DynAbs.Tracing.TraceSender.TraceExitMethod(25066,767,793);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25066,767,793);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25066,767,793);
}
			throw new System.Exception("Slicer error: unreachable code");

System.IO.IOException
f_25066_776_793()
{
var return_v = new System.IO.IOException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25066, 776, 793);
return return_v;
}

		}

public ThrowingStrongNameFileSystem()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25066,416,801);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25066,416,801);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25066,416,801);
}


static ThrowingStrongNameFileSystem()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25066,416,801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25066,564,609);
Instance = f_25066_575_609();DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25066,416,801);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25066,416,801);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25066,416,801);

static Roslyn.Test.Utilities.ThrowingStrongNameFileSystem
f_25066_575_609()
{
var return_v = new Roslyn.Test.Utilities.ThrowingStrongNameFileSystem();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25066, 575, 609);
return return_v;
}

}
}
