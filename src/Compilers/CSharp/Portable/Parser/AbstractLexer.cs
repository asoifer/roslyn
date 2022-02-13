// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
internal class AbstractLexer : IDisposable
{
internal readonly SlidingTextWindow TextWindow;

private List<SyntaxDiagnosticInfo> _errors;

protected AbstractLexer(SourceText text)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10016,757,879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,681,691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,737,744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,822,868);

this.TextWindow = f_10016_840_867(text);
DynAbs.Tracing.TraceSender.TraceExitConstructor(10016,757,879);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,757,879);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,757,879);
}
		}

public virtual void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,891,982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,945,971);

f_10016_945_970(            this.TextWindow);
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,891,982);

int
f_10016_945_970(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 945, 970);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,891,982);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,891,982);
}
		}

protected void Start()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,994,1100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1041,1060);

f_10016_1041_1059(            TextWindow);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1074,1089);

_errors = null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,994,1100);

int
f_10016_1041_1059(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.Start();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 1041, 1059);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,994,1100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,994,1100);
}
		}

protected bool HasErrors
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,1161,1192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1167,1190);

return _errors != null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,1161,1192);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,1112,1203);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,1112,1203);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected SyntaxDiagnosticInfo[] GetErrors(int leadingTriviaWidth)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,1215,2034);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1306,2023) || true) && (_errors != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10016,1306,2023);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1359,1930) || true) && (leadingTriviaWidth > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10016,1359,1930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1427,1479);

var 
array = new SyntaxDiagnosticInfo[f_10016_1464_1477(_errors)]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1510,1515);
                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1501,1767) || true) && (i < f_10016_1521_1534(_errors))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1536,1539)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10016,1501,1767))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10016,1501,1767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1671,1744);

array[i] = f_10016_1682_1743(f_10016_1682_1692(_errors, i), f_10016_1704_1714(_errors, i).Offset + leadingTriviaWidth);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10016,1,267);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10016,1,267);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1791,1804);

return array;
DynAbs.Tracing.TraceSender.TraceExitCondition(10016,1359,1930);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10016,1359,1930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1886,1911);

return f_10016_1893_1910(_errors);
DynAbs.Tracing.TraceSender.TraceExitCondition(10016,1359,1930);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10016,1306,2023);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10016,1306,2023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,1996,2008);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10016,1306,2023);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,1215,2034);

int
f_10016_1464_1477(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10016, 1464, 1477);
return return_v;
}


int
f_10016_1521_1534(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10016, 1521, 1534);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10016_1682_1692(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10016, 1682, 1692);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10016_1704_1714(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10016, 1704, 1714);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10016_1682_1743(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
this_param,int
offset)
{
var return_v = this_param.WithOffset( offset);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 1682, 1743);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
f_10016_1893_1910(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 1893, 1910);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,1215,2034);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,1215,2034);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected void AddError(int position, int width, ErrorCode code)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,2046,2199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,2135,2188);

f_10016_2135_2187(            this, f_10016_2149_2186(this, position, width, code));
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,2046,2199);

Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10016_2149_2186(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,int
position,int
width,Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = this_param.MakeError( position, width, code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2149, 2186);
return return_v;
}


int
f_10016_2135_2187(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
error)
{
this_param.AddError( error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2135, 2187);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,2046,2199);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,2046,2199);
}
		}

protected void AddError(int position, int width, ErrorCode code, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,2211,2392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,2322,2381);

f_10016_2322_2380(            this, f_10016_2336_2379(this, position, width, code, args));
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,2211,2392);

Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10016_2336_2379(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,int
position,int
width,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,params object[]
args)
{
var return_v = this_param.MakeError( position, width, code, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2336, 2379);
return return_v;
}


int
f_10016_2322_2380(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
error)
{
this_param.AddError( error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2322, 2380);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,2211,2392);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,2211,2392);
}
		}

protected void AddError(int position, int width, XmlParseErrorCode code, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,2404,2593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,2523,2582);

f_10016_2523_2581(            this, f_10016_2537_2580(this, position, width, code, args));
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,2404,2593);

Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
f_10016_2537_2580(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,int
position,int
width,Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
code,params object[]
args)
{
var return_v = this_param.MakeError( position, width, code, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2537, 2580);
return return_v;
}


int
f_10016_2523_2581(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
error)
{
this_param.AddError( (Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo)error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2523, 2581);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,2404,2593);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,2404,2593);
}
		}

protected void AddError(ErrorCode code)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,2605,2711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,2669,2700);

f_10016_2669_2699(            this, f_10016_2683_2698(code));
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,2605,2711);

Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10016_2683_2698(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = MakeError( code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2683, 2698);
return return_v;
}


int
f_10016_2669_2699(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
error)
{
this_param.AddError( error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2669, 2699);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,2605,2711);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,2605,2711);
}
		}

protected void AddError(ErrorCode code, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,2723,2857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,2809,2846);

f_10016_2809_2845(            this, f_10016_2823_2844(code, args));
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,2723,2857);

Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10016_2823_2844(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,params object[]
args)
{
var return_v = MakeError( code, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2823, 2844);
return return_v;
}


int
f_10016_2809_2845(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
error)
{
this_param.AddError( error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2809, 2845);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,2723,2857);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,2723,2857);
}
		}

protected void AddError(XmlParseErrorCode code)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,2869,2983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,2941,2972);

f_10016_2941_2971(            this, f_10016_2955_2970(code));
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,2869,2983);

Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
f_10016_2955_2970(Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
code)
{
var return_v = MakeError( code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2955, 2970);
return return_v;
}


int
f_10016_2941_2971(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
error)
{
this_param.AddError( (Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo)error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 2941, 2971);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,2869,2983);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,2869,2983);
}
		}

protected void AddError(XmlParseErrorCode code, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,2995,3137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,3089,3126);

f_10016_3089_3125(            this, f_10016_3103_3124(code, args));
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,2995,3137);

Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
f_10016_3103_3124(Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
code,params object[]
args)
{
var return_v = MakeError( code, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 3103, 3124);
return return_v;
}


int
f_10016_3089_3125(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
error)
{
this_param.AddError( (Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo)error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 3089, 3125);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,2995,3137);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,2995,3137);
}
		}

protected void AddError(SyntaxDiagnosticInfo error)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,3149,3465);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,3225,3454) || true) && (error != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10016,3225,3454);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,3276,3400) || true) && (_errors == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10016,3276,3400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,3337,3381);

_errors = f_10016_3347_3380(8);
DynAbs.Tracing.TraceSender.TraceExitCondition(10016,3276,3400);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,3420,3439);

f_10016_3420_3438(
                _errors, error);
DynAbs.Tracing.TraceSender.TraceExitCondition(10016,3225,3454);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,3149,3465);

System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo>
f_10016_3347_3380(int
capacity)
{
var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo>( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 3347, 3380);
return return_v;
}


int
f_10016_3420_3438(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo>
this_param,Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 3420, 3438);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,3149,3465);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,3149,3465);
}
		}

protected SyntaxDiagnosticInfo MakeError(int position, int width, ErrorCode code)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,3477,3712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,3583,3634);

int 
offset = f_10016_3596_3633(this, position)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,3648,3701);

return f_10016_3655_3700(offset, width, code);
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,3477,3712);

int
f_10016_3596_3633(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,int
position)
{
var return_v = this_param.GetLexemeOffsetFromPosition( position);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 3596, 3633);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10016_3655_3700(int
offset,int
width,Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo( offset, width, code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 3655, 3700);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,3477,3712);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,3477,3712);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected SyntaxDiagnosticInfo MakeError(int position, int width, ErrorCode code, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,3724,3987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,3852,3903);

int 
offset = f_10016_3865_3902(this, position)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,3917,3976);

return f_10016_3924_3975(offset, width, code, args);
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,3724,3987);

int
f_10016_3865_3902(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,int
position)
{
var return_v = this_param.GetLexemeOffsetFromPosition( position);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 3865, 3902);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10016_3924_3975(int
offset,int
width,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,params object[]
args)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo( offset, width, code, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 3924, 3975);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,3724,3987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,3724,3987);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected XmlSyntaxDiagnosticInfo MakeError(int position, int width, XmlParseErrorCode code, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,3999,4276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,4138,4189);

int 
offset = f_10016_4151_4188(this, position)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,4203,4265);

return f_10016_4210_4264(offset, width, code, args);
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,3999,4276);

int
f_10016_4151_4188(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AbstractLexer
this_param,int
position)
{
var return_v = this_param.GetLexemeOffsetFromPosition( position);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 4151, 4188);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
f_10016_4210_4264(int
offset,int
width,Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
code,params object[]
args)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo( offset, width, code, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 4210, 4264);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,3999,4276);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,3999,4276);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private int GetLexemeOffsetFromPosition(int position)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10016,4288,4482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,4366,4471);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10016, 4373, 4415)||((position >= f_10016_4385_4415(TextWindow)&&DynAbs.Tracing.TraceSender.Conditional_F2(10016, 4418, 4459))||DynAbs.Tracing.TraceSender.Conditional_F3(10016, 4462, 4470)))?position - f_10016_4429_4459(TextWindow):position;
DynAbs.Tracing.TraceSender.TraceExitMethod(10016,4288,4482);

int
f_10016_4385_4415(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.LexemeStartPosition ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10016, 4385, 4415);
return return_v;
}


int
f_10016_4429_4459(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.LexemeStartPosition ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10016, 4429, 4459);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,4288,4482);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,4288,4482);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected static SyntaxDiagnosticInfo MakeError(ErrorCode code)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10016,4494,4631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,4582,4620);

return f_10016_4589_4619(code);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10016,4494,4631);

Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10016_4589_4619(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo( code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 4589, 4619);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,4494,4631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,4494,4631);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected static SyntaxDiagnosticInfo MakeError(ErrorCode code, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10016,4643,4808);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,4753,4797);

return f_10016_4760_4796(code, args);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10016,4643,4808);

Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10016_4760_4796(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,params object[]
args)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo( code, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 4760, 4796);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,4643,4808);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,4643,4808);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected static XmlSyntaxDiagnosticInfo MakeError(XmlParseErrorCode code)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10016,4820,4977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,4919,4966);

return f_10016_4926_4965(0, 0, code);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10016,4820,4977);

Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
f_10016_4926_4965(int
offset,int
width,Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
code,params object[]
args)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo( offset, width, code, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 4926, 4965);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,4820,4977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,4820,4977);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected static XmlSyntaxDiagnosticInfo MakeError(XmlParseErrorCode code, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10016,4989,5174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10016,5110,5163);

return f_10016_5117_5162(0, 0, code, args);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10016,4989,5174);

Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
f_10016_5117_5162(int
offset,int
width,Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
code,params object[]
args)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo( offset, width, code, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 5117, 5162);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10016,4989,5174);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,4989,5174);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static AbstractLexer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10016,586,5181);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10016,586,5181);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10016,586,5181);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10016,586,5181);

Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
f_10016_840_867(Microsoft.CodeAnalysis.Text.SourceText
text)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10016, 840, 867);
return return_v;
}

}
}
