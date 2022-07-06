// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Roslyn.Test.Utilities
{
public sealed class TestAdditionalText : AdditionalText
{
private readonly SourceText _text;

public TestAdditionalText(string path, SourceText text)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25112,480,610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25112,462,467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25112,807,843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25112,560,572);

Path = path;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25112,586,599);

_text = text;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25112,480,610);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25112,480,610);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25112,480,610);
}
		}

public TestAdditionalText(string text = "", Encoding? encoding = null, string path = "dummy")
:this(f_25112_736_740_C(path) ,f_25112_742_772(text, encoding))
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25112,622,795);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25112,622,795);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25112,622,795);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25112,622,795);
}
		}

public override string Path {get; }

public override SourceText GetText(CancellationToken cancellationToken = default) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25112,937,945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25112,940,945);
return _text;DynAbs.Tracing.TraceSender.TraceExitMethod(25112,937,945);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25112,937,945);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25112,937,945);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static TestAdditionalText()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25112,362,953);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25112,362,953);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25112,362,953);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25112,362,953);

static Microsoft.CodeAnalysis.Text.StringText
f_25112_742_772(string
source,System.Text.Encoding?
encodingOpt)
{
var return_v = new Microsoft.CodeAnalysis.Text.StringText( source, encodingOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25112, 742, 772);
return return_v;
}


static string
f_25112_736_740_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25112, 622, 795);
return return_v;
}

}
}
