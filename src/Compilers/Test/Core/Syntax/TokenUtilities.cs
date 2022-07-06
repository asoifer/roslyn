// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using CS = Microsoft.CodeAnalysis.CSharp;
using VB = Microsoft.CodeAnalysis.VisualBasic;

namespace Roslyn.Test.Utilities
{
public static class TokenUtilities
{
public static void AssertTokensEqual(
            string expected, string actual, string language)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25134,514,2617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,638,689);

var 
expectedTokens = f_25134_659_688(expected, language)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,703,750);

var 
actualTokens = f_25134_722_749(actual, language)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,764,825);

var 
max = f_25134_774_824(f_25134_783_803(expectedTokens), f_25134_805_823(actualTokens))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,848,853);
            for (var 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,839,2098) || true) && (i < max)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,864,867)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25134,839,2098))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,839,2098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,901,950);

var 
expectedToken = expectedTokens[i].ToString()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,968,1013);

var 
actualToken = actualTokens[i].ToString()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1031,2083) || true) && (!f_25134_1036_1077(expectedToken, actualToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,1031,2083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1119,1141);

string 
actualAll = ""
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1163,1187);

string 
expectedAll = ""
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1218,1227);
                    for (var 
j = i - 3
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1209,1934) || true) && (j <= i + 5)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1241,1244)
,j++,DynAbs.Tracing.TraceSender.TraceExitCondition(25134,1209,1934))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,1209,1934);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1294,1911) || true) && (j >= 0 &&(DynAbs.Tracing.TraceSender.Expression_True(25134, 1298, 1315)&&j < max))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,1294,1911);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1373,1884) || true) && (j == i)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,1373,1884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1449,1502);

actualAll += "^" + actualTokens[j].ToString()+ "^ ";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1536,1593);

expectedAll += "^" + expectedTokens[j].ToString()+ "^ ";
DynAbs.Tracing.TraceSender.TraceExitCondition(25134,1373,1884);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,1373,1884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1723,1769);

actualAll += actualTokens[j].ToString()+ " ";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1803,1853);

expectedAll += expectedTokens[j].ToString()+ " ";
DynAbs.Tracing.TraceSender.TraceExitCondition(25134,1373,1884);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25134,1294,1911);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25134,1,726);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25134,1,726);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,1958,2064);

f_25134_1958_2063($"Unexpected token.  Actual '{actualAll}' Expected '{expectedAll}'\r\nActual:\r\n{actual}");
DynAbs.Tracing.TraceSender.TraceExitCondition(25134,1031,2083);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25134,1,1260);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25134,1,1260);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,2114,2606) || true) && (f_25134_2118_2138(expectedTokens)!= f_25134_2142_2160(actualTokens))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,2114,2606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,2194,2275);

var 
expectedDisplay = f_25134_2216_2274(" ", f_25134_2233_2273(expectedTokens, t => t.ToString()))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,2293,2370);

var 
actualDisplay = f_25134_2313_2369(" ", f_25134_2330_2368(actualTokens, t => t.ToString()))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,2388,2591);

f_25134_2388_2590(@"Wrong token count. Expected '{0}', Actual '{1}', Expected Text: '{2}', Actual Text: '{3}'", f_25134_2517_2537(expectedTokens), f_25134_2539_2557(actualTokens), expectedDisplay, actualDisplay);
DynAbs.Tracing.TraceSender.TraceExitCondition(25134,2114,2606);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25134,514,2617);

System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_659_688(string
text,string
language)
{
var return_v = GetTokens( text, language);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 659, 688);
return return_v;
}


System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_722_749(string
text,string
language)
{
var return_v = GetTokens( text, language);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 722, 749);
return return_v;
}


int
f_25134_783_803(System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxToken>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25134, 783, 803);
return return_v;
}


int
f_25134_805_823(System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxToken>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25134, 805, 823);
return return_v;
}


int
f_25134_774_824(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 774, 824);
return return_v;
}


bool
f_25134_1036_1077(string
a,string
b)
{
var return_v = string.Equals( a, b);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 1036, 1077);
return return_v;
}


int
f_25134_1958_2063(string
message)
{
AssertEx.Fail( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 1958, 2063);
return 0;
}


int
f_25134_2118_2138(System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxToken>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25134, 2118, 2138);
return return_v;
}


int
f_25134_2142_2160(System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxToken>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25134, 2142, 2160);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_25134_2233_2273(System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxToken>
source,System.Func<Microsoft.CodeAnalysis.SyntaxToken, string>
selector)
{
var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxToken,string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 2233, 2273);
return return_v;
}


string
f_25134_2216_2274(string
separator,System.Collections.Generic.IEnumerable<string>
values)
{
var return_v = string.Join( separator, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 2216, 2274);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_25134_2330_2368(System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxToken>
source,System.Func<Microsoft.CodeAnalysis.SyntaxToken, string>
selector)
{
var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxToken,string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 2330, 2368);
return return_v;
}


string
f_25134_2313_2369(string
separator,System.Collections.Generic.IEnumerable<string>
values)
{
var return_v = string.Join( separator, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 2313, 2369);
return return_v;
}


int
f_25134_2517_2537(System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxToken>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25134, 2517, 2537);
return return_v;
}


int
f_25134_2539_2557(System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxToken>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25134, 2539, 2557);
return return_v;
}


int
f_25134_2388_2590(string
format,params object[]
args)
{
AssertEx.Fail( format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 2388, 2590);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25134,514,2617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25134,514,2617);
}
		}

private static bool SkipVisualBasicToken(SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25134,2629,2792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,2713,2781);

return token.RawKind == (int)VB.SyntaxKind.StatementTerminatorToken;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25134,2629,2792);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25134,2629,2792);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25134,2629,2792);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool SkipCSharpToken(SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25134,2804,2969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,2883,2958);

return token.RawKind == (int)CS.SyntaxKind.OmittedArraySizeExpressionToken;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25134,2804,2969);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25134,2804,2969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25134,2804,2969);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static IList<SyntaxToken> GetTokens(string text, string language)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25134,2981,3467);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,3078,3456) || true) && (language == LanguageNames.CSharp)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,3078,3456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,3148,3259);

return f_25134_3155_3258(f_25134_3155_3249(f_25134_3155_3217(f_25134_3155_3189(text), t => (SyntaxToken)t), t => !SkipCSharpToken(t)));
DynAbs.Tracing.TraceSender.TraceExitCondition(25134,3078,3456);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,3078,3456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,3325,3441);

return f_25134_3332_3440(f_25134_3332_3431(f_25134_3332_3394(f_25134_3332_3366(text), t => (SyntaxToken)t), t => !SkipVisualBasicToken(t)));
DynAbs.Tracing.TraceSender.TraceExitCondition(25134,3078,3456);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25134,2981,3467);

System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3155_3189(string
text)
{
var return_v = CS.SyntaxFactory.ParseTokens( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3155, 3189);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3155_3217(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
source,System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken>
selector)
{
var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxToken,Microsoft.CodeAnalysis.SyntaxToken>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3155, 3217);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3155_3249(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
source,System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
predicate)
{
var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxToken>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3155, 3249);
return return_v;
}


System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3155_3258(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
source)
{
var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxToken>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3155, 3258);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3332_3366(string
text)
{
var return_v = VB.SyntaxFactory.ParseTokens( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3332, 3366);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3332_3394(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
source,System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken>
selector)
{
var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxToken,Microsoft.CodeAnalysis.SyntaxToken>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3332, 3394);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3332_3431(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
source,System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
predicate)
{
var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxToken>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3332, 3431);
return return_v;
}


System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3332_3440(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
source)
{
var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxToken>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3332, 3440);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25134,2981,3467);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25134,2981,3467);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static IList<SyntaxToken> GetTokens(SyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25134,3479,3879);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,3563,3868) || true) && (f_25134_3567_3580(node)== LanguageNames.CSharp)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,3563,3868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,3638,3710);

return f_25134_3645_3709(f_25134_3645_3700(f_25134_3645_3668(node), t => !SkipCSharpToken(t)));
DynAbs.Tracing.TraceSender.TraceExitCondition(25134,3563,3868);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,3563,3868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,3776,3853);

return f_25134_3783_3852(f_25134_3783_3843(f_25134_3783_3806(node), t => !SkipVisualBasicToken(t)));
DynAbs.Tracing.TraceSender.TraceExitCondition(25134,3563,3868);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25134,3479,3879);

string
f_25134_3567_3580(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Language ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25134, 3567, 3580);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3645_3668(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantTokens();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3645, 3668);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3645_3700(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
source,System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
predicate)
{
var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxToken>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3645, 3700);
return return_v;
}


System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3645_3709(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
source)
{
var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxToken>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3645, 3709);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3783_3806(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantTokens();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3783, 3806);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3783_3843(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
source,System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
predicate)
{
var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxToken>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3783, 3843);
return return_v;
}


System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
f_25134_3783_3852(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
source)
{
var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxToken>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 3783, 3852);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25134,3479,3879);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25134,3479,3879);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static SyntaxNode GetSyntaxRoot(string expectedText, string language, ParseOptions options = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25134,3891,4390);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,4023,4379) || true) && (language == LanguageNames.CSharp)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,4023,4379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,4093,4193);

return f_25134_4100_4192(expectedText, options);
DynAbs.Tracing.TraceSender.TraceExitCondition(25134,4023,4379);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25134,4023,4379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25134,4259,4364);

return f_25134_4266_4363(expectedText, options);
DynAbs.Tracing.TraceSender.TraceExitCondition(25134,4023,4379);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25134,3891,4390);

Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
f_25134_4100_4192(string
text,Microsoft.CodeAnalysis.ParseOptions?
options)
{
var return_v = CS.SyntaxFactory.ParseCompilationUnit( text, options: (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 4100, 4192);
return return_v;
}


Microsoft.CodeAnalysis.VisualBasic.Syntax.CompilationUnitSyntax
f_25134_4266_4363(string
text,Microsoft.CodeAnalysis.ParseOptions?
options)
{
var return_v = VB.SyntaxFactory.ParseCompilationUnit( text, options: (Microsoft.CodeAnalysis.VisualBasic.VisualBasicParseOptions?)options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25134, 4266, 4363);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25134,3891,4390);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25134,3891,4390);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static TokenUtilities()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25134,463,4397);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25134,463,4397);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25134,463,4397);
}

}
}
