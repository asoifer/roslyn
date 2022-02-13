// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
internal partial class LanguageParser
{
private string Substring(string s, int first, int last)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10033,1048,1363);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,1128,1217) || true) && (last >= f_10033_1140_1148(s))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,1128,1217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,1182,1202);

last = f_10033_1189_1197(s)- 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,1128,1217);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,1233,1260);

int 
len = last - first + 1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,1274,1352);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10033, 1281, 1310)||(((last > f_10033_1289_1297(s)||(DynAbs.Tracing.TraceSender.Expression_False(10033, 1282, 1309)||len <= 0)) &&DynAbs.Tracing.TraceSender.Conditional_F2(10033, 1313, 1325))||DynAbs.Tracing.TraceSender.Conditional_F3(10033, 1328, 1351)))?string.Empty :f_10033_1328_1351(s, first, len);
DynAbs.Tracing.TraceSender.TraceExitMethod(10033,1048,1363);

int
f_10033_1140_1148(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 1140, 1148);
return return_v;
}


int
f_10033_1189_1197(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 1189, 1197);
return return_v;
}


int
f_10033_1289_1297(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 1289, 1297);
return return_v;
}


string
f_10033_1328_1351(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 1328, 1351);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10033,1048,1363);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10033,1048,1363);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ExpressionSyntax ParseInterpolatedStringToken()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10033,1375,8309);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,2864,2900);

var 
originalToken = f_10033_2884_2899(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,2914,2957);

var 
originalText = f_10033_2933_2956(originalToken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,3007,3070);

f_10033_3007_3069(f_10033_3020_3035(originalText, 0)== '$' ||(DynAbs.Tracing.TraceSender.Expression_False(10033, 3020, 3068)||f_10033_3046_3061(originalText, 0)== '@'));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,3086,3168);

var 
isAltInterpolatedVerbatim = f_10033_3118_3137(originalText)> 2 &&(DynAbs.Tracing.TraceSender.Expression_True(10033, 3118, 3167)&&f_10033_3145_3160(originalText, 0)== '@')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,3188,3286);

var 
isVerbatim = isAltInterpolatedVerbatim ||(DynAbs.Tracing.TraceSender.Expression_False(10033, 3205, 3285)||(f_10033_3235_3254(originalText)> 2 &&(DynAbs.Tracing.TraceSender.Expression_True(10033, 3235, 3284)&&f_10033_3262_3277(originalText, 1)== '@')))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,3302,3373);

f_10033_3302_3372(f_10033_3315_3333(originalToken)== SyntaxKind.InterpolatedStringToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,3387,3456);

var 
interpolations = f_10033_3408_3455()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,3470,3504);

SyntaxDiagnosticInfo 
error = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,3518,3541);

bool 
closeQuoteMissing
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,3555,4048);
using(var 
tempLexer = f_10033_3578_3673(f_10033_3588_3622(originalText), f_10033_3624_3636(this), allowPreprocessorDirectives: false)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,3864,3900);

var 
info = default(Lexer.TokenInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,3918,4033);

f_10033_3918_4032(                tempLexer, interpolations, isVerbatim, ref info, ref error, out closeQuoteMissing);
DynAbs.Tracing.TraceSender.TraceExitUsing(10033,3555,4048);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,4129,4169);

var 
openQuoteIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(10033, 4150, 4160)||((isVerbatim &&DynAbs.Tracing.TraceSender.Conditional_F2(10033, 4163, 4164))||DynAbs.Tracing.TraceSender.Conditional_F3(10033, 4167, 4168)))?2 :1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,4183,4233);

f_10033_4183_4232(f_10033_4196_4224(originalText, openQuoteIndex)== '"');
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,4249,4426);

var 
openQuoteKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10033, 4269, 4279)||((isVerbatim
&&DynAbs.Tracing.TraceSender.Conditional_F2(10033, 4303, 4350))||DynAbs.Tracing.TraceSender.Conditional_F3(10033, 4386, 4425)))?SyntaxKind.InterpolatedVerbatimStringStartToken // $@ or @$
:SyntaxKind.InterpolatedStringStartToken
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,4447,4608);

var 
openQuoteText = (DynAbs.Tracing.TraceSender.Conditional_F1(10033, 4467, 4492)||((isAltInterpolatedVerbatim
&&DynAbs.Tracing.TraceSender.Conditional_F2(10033, 4512, 4518))||DynAbs.Tracing.TraceSender.Conditional_F3(10033, 4538, 4607)))?"@$\""
:(DynAbs.Tracing.TraceSender.Conditional_F1(10033, 4538, 4548)||((isVerbatim
&&DynAbs.Tracing.TraceSender.Conditional_F2(10033, 4572, 4578))||DynAbs.Tracing.TraceSender.Conditional_F3(10033, 4602, 4607)))?"$@\""
:"$\""
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,4622,4753);

var 
openQuote = f_10033_4638_4752(f_10033_4658_4690(originalToken), openQuoteKind, openQuoteText, openQuoteText, trailing: null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,4769,4948) || true) && (isAltInterpolatedVerbatim)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,4769,4948);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,4832,4933);

openQuote = f_10033_4844_4932(this, openQuote, MessageID.IDS_FeatureAltInterpolatedVerbatimStrings);
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,4769,4948);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,5040,5128);

var 
closeQuoteIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(10033, 5062, 5079)||((closeQuoteMissing &&DynAbs.Tracing.TraceSender.Conditional_F2(10033, 5082, 5101))||DynAbs.Tracing.TraceSender.Conditional_F3(10033, 5104, 5127)))?f_10033_5082_5101(originalText):f_10033_5104_5123(originalText)- 1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,5142,5214);

f_10033_5142_5213(closeQuoteMissing ||(DynAbs.Tracing.TraceSender.Expression_False(10033, 5155, 5212)||f_10033_5176_5205(originalText, closeQuoteIndex)== '"'));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,5228,5526);

var 
closeQuote = (DynAbs.Tracing.TraceSender.Conditional_F1(10033, 5245, 5262)||((closeQuoteMissing
&&DynAbs.Tracing.TraceSender.Conditional_F2(10033, 5282, 5406))||DynAbs.Tracing.TraceSender.Conditional_F3(10033, 5426, 5525)))?f_10033_5282_5406(f_10033_5282_5347(SyntaxKind.InterpolatedStringEndToken), f_10033_5372_5405(originalToken)):f_10033_5426_5525(null, SyntaxKind.InterpolatedStringEndToken, f_10033_5491_5524(originalToken))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,5540,5604);

var 
builder = f_10033_5554_5603(_pool)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,5620,7768) || true) && (f_10033_5624_5644(interpolations)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,5620,7768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,5974,6050);

var 
text = f_10033_5985_6049(this, originalText, openQuoteIndex + 1, closeQuoteIndex - 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,6068,6319) || true) && (f_10033_6072_6083(text)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,6068,6319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,6129,6221);

var 
token = f_10033_6141_6220(this, text, text, isVerbatim, SyntaxKind.InterpolatedStringTextToken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,6243,6300);

builder.Add(f_10033_6255_6298(token));
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,6068,6319);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,5620,7768);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,5620,7768);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,6394,6399);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,6385,7253) || true) && (i < f_10033_6405_6425(interpolations))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,6427,6430)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10033,6385,7253))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,6385,7253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,6472,6510);

var 
interpolation = f_10033_6492_6509(interpolations, i)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,6607,6761);

var 
text = f_10033_6618_6760(this, originalText, (DynAbs.Tracing.TraceSender.Conditional_F1(10033, 6642, 6650)||(((i == 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(10033, 6653, 6673))||DynAbs.Tracing.TraceSender.Conditional_F3(10033, 6676, 6722)))?(openQuoteIndex + 1) :(interpolations[i - 1].CloseBracePosition + 1), interpolation.OpenBracePosition - 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,6783,7050) || true) && (f_10033_6787_6798(text)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,6783,7050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,6852,6944);

var 
token = f_10033_6864_6943(this, text, text, isVerbatim, SyntaxKind.InterpolatedStringTextToken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,6970,7027);

builder.Add(f_10033_6982_7025(token));
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,6783,7050);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,7119,7192);

var 
interp = f_10033_7132_7191(this, originalText, interpolation, isVerbatim)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,7214,7234);

builder.Add(interp);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10033,1,869);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10033,1,869);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,7347,7472);

var 
lastText = f_10033_7362_7471(this, originalText, interpolations[f_10033_7401_7421(interpolations)- 1].CloseBracePosition + 1, closeQuoteIndex - 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,7490,7753) || true) && (f_10033_7494_7509(lastText)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,7490,7753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,7555,7655);

var 
token = f_10033_7567_7654(this, lastText, lastText, isVerbatim, SyntaxKind.InterpolatedStringTextToken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,7677,7734);

builder.Add(f_10033_7689_7732(token));
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,7490,7753);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,5620,7768);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,7784,7806);

f_10033_7784_7805(
            interpolations);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,7820,7908);

var 
result = f_10033_7833_7907(openQuote, builder, closeQuote)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,7922,7942);

f_10033_7922_7941(            _pool, builder);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,7956,8076) || true) && (error != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,7956,8076);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,8007,8061);

result = f_10033_8016_8060(result, new[] { error });
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,7956,8076);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,8092,8160);

f_10033_8092_8159(f_10033_8105_8133(originalToken)== f_10033_8137_8158(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,8216,8298);

return f_10033_8223_8297(this, result, MessageID.IDS_FeatureInterpolatedStrings);
DynAbs.Tracing.TraceSender.TraceExitMethod(10033,1375,8309);

Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_2884_2899(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param)
{
var return_v = this_param.EatToken();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 2884, 2899);
return return_v;
}


string
f_10033_2933_2956(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.ValueText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 2933, 2956);
return return_v;
}


char
f_10033_3020_3035(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 3020, 3035);
return return_v;
}


char
f_10033_3046_3061(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 3046, 3061);
return return_v;
}


int
f_10033_3007_3069(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 3007, 3069);
return 0;
}


int
f_10033_3118_3137(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 3118, 3137);
return return_v;
}


char
f_10033_3145_3160(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 3145, 3160);
return return_v;
}


int
f_10033_3235_3254(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 3235, 3254);
return return_v;
}


char
f_10033_3262_3277(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 3262, 3277);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10033_3315_3333(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 3315, 3333);
return return_v;
}


int
f_10033_3302_3372(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 3302, 3372);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation>
f_10033_3408_3455()
{
var return_v = ArrayBuilder<Lexer.Interpolation>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 3408, 3455);
return return_v;
}


Microsoft.CodeAnalysis.Text.SourceText
f_10033_3588_3622(string
text)
{
var return_v = Text.SourceText.From( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 3588, 3622);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_10033_3624_3636(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 3624, 3636);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
f_10033_3578_3673(Microsoft.CodeAnalysis.Text.SourceText
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options,bool
allowPreprocessorDirectives)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer( text, options, allowPreprocessorDirectives:allowPreprocessorDirectives);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 3578, 3673);
return return_v;
}


int
f_10033_3918_4032(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation>
interpolations,bool
isVerbatim,ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
info,ref Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo?
error,out bool
closeQuoteMissing)
{
this_param.ScanInterpolatedStringLiteralTop( interpolations, isVerbatim, ref info, ref error, out closeQuoteMissing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 3918, 4032);
return 0;
}


char
f_10033_4196_4224(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 4196, 4224);
return return_v;
}


int
f_10033_4183_4232(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 4183, 4232);
return 0;
}


Microsoft.CodeAnalysis.GreenNode
f_10033_4658_4690(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.GetLeadingTrivia();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 4658, 4690);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_4638_4752(Microsoft.CodeAnalysis.GreenNode
leading,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind,string
text,string
valueText,Microsoft.CodeAnalysis.GreenNode
trailing)
{
var return_v = SyntaxFactory.Token( leading, kind, text, valueText, trailing:trailing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 4638, 4752);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_4844_4932(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
node,Microsoft.CodeAnalysis.CSharp.MessageID
feature)
{
var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>( node, feature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 4844, 4932);
return return_v;
}


int
f_10033_5082_5101(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 5082, 5101);
return return_v;
}


int
f_10033_5104_5123(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 5104, 5123);
return return_v;
}


char
f_10033_5176_5205(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 5176, 5205);
return return_v;
}


int
f_10033_5142_5213(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 5142, 5213);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_5282_5347(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFactory.MissingToken( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 5282, 5347);
return return_v;
}


Microsoft.CodeAnalysis.GreenNode
f_10033_5372_5405(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.GetTrailingTrivia();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 5372, 5405);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_5282_5406(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param,Microsoft.CodeAnalysis.GreenNode
trivia)
{
var return_v = this_param.TokenWithTrailingTrivia( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 5282, 5406);
return return_v;
}


Microsoft.CodeAnalysis.GreenNode
f_10033_5491_5524(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.GetTrailingTrivia();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 5491, 5524);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_5426_5525(Microsoft.CodeAnalysis.GreenNode
leading,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind,Microsoft.CodeAnalysis.GreenNode
trailing)
{
var return_v = SyntaxFactory.Token( leading, kind, trailing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 5426, 5525);
return return_v;
}


Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringContentSyntax>
f_10033_5554_5603(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
this_param)
{
var return_v = this_param.Allocate<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringContentSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 5554, 5603);
return return_v;
}


int
f_10033_5624_5644(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 5624, 5644);
return return_v;
}


string
f_10033_5985_6049(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,string
s,int
first,int
last)
{
var return_v = this_param.Substring( s, first, last);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 5985, 6049);
return return_v;
}


int
f_10033_6072_6083(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 6072, 6083);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_6141_6220(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,string
text,string
bodyText,bool
isVerbatim,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = this_param.MakeStringToken( text, bodyText, isVerbatim, kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 6141, 6220);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringTextSyntax
f_10033_6255_6298(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
textToken)
{
var return_v = SyntaxFactory.InterpolatedStringText( textToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 6255, 6298);
return return_v;
}


int
f_10033_6405_6425(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 6405, 6425);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation
f_10033_6492_6509(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 6492, 6509);
return return_v;
}


string
f_10033_6618_6760(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,string
s,int
first,int
last)
{
var return_v = this_param.Substring( s, first, last);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 6618, 6760);
return return_v;
}


int
f_10033_6787_6798(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 6787, 6798);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_6864_6943(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,string
text,string
bodyText,bool
isVerbatim,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = this_param.MakeStringToken( text, bodyText, isVerbatim, kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 6864, 6943);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringTextSyntax
f_10033_6982_7025(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
textToken)
{
var return_v = SyntaxFactory.InterpolatedStringText( textToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 6982, 7025);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolationSyntax
f_10033_7132_7191(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,string
text,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation
interpolation,bool
isVerbatim)
{
var return_v = this_param.ParseInterpolation( text, interpolation, isVerbatim);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 7132, 7191);
return return_v;
}


int
f_10033_7401_7421(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 7401, 7421);
return return_v;
}


string
f_10033_7362_7471(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,string
s,int
first,int
last)
{
var return_v = this_param.Substring( s, first, last);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 7362, 7471);
return return_v;
}


int
f_10033_7494_7509(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 7494, 7509);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_7567_7654(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,string
text,string
bodyText,bool
isVerbatim,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = this_param.MakeStringToken( text, bodyText, isVerbatim, kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 7567, 7654);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringTextSyntax
f_10033_7689_7732(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
textToken)
{
var return_v = SyntaxFactory.InterpolatedStringText( textToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 7689, 7732);
return return_v;
}


int
f_10033_7784_7805(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 7784, 7805);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax
f_10033_7833_7907(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
stringStartToken,Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringContentSyntax>
contents,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
stringEndToken)
{
var return_v = SyntaxFactory.InterpolatedStringExpression( stringStartToken, (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringContentSyntax>)contents, stringEndToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 7833, 7907);
return return_v;
}


int
f_10033_7922_7941(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
this_param,Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringContentSyntax>
item)
{
this_param.Free( (Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 7922, 7941);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax
f_10033_8016_8060(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax
node,Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
diagnostics)
{
var return_v = node.WithDiagnosticsGreen<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax>( (Microsoft.CodeAnalysis.DiagnosticInfo[])diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 8016, 8060);
return return_v;
}


string
f_10033_8105_8133(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.ToFullString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 8105, 8133);
return return_v;
}


string
f_10033_8137_8158(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax
this_param)
{
var return_v = this_param.ToFullString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 8137, 8158);
return return_v;
}


int
f_10033_8092_8159(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 8092, 8159);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax
f_10033_8223_8297(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax
node,Microsoft.CodeAnalysis.CSharp.MessageID
feature)
{
var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax>( node, feature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 8223, 8297);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10033,1375,8309);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10033,1375,8309);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private InterpolationSyntax ParseInterpolation(string text, Lexer.Interpolation interpolation, bool isVerbatim)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10033,8321,11235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,8457,8484);

SyntaxToken 
openBraceToken
=default(SyntaxToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,8498,8526);

ExpressionSyntax 
expression
=default(ExpressionSyntax);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,8540,8592);

InterpolationAlignmentClauseSyntax 
alignment = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,8606,8652);

InterpolationFormatClauseSyntax 
format = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,8666,8861);

var 
closeBraceToken = (DynAbs.Tracing.TraceSender.Conditional_F1(10033, 8688, 8719)||((interpolation.CloseBraceMissing
&&DynAbs.Tracing.TraceSender.Conditional_F2(10033, 8739, 8793))||DynAbs.Tracing.TraceSender.Conditional_F3(10033, 8813, 8860)))?f_10033_8739_8793(SyntaxKind.CloseBraceToken):f_10033_8813_8860(SyntaxKind.CloseBraceToken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,8877,9040);

var 
parsedText = f_10033_8894_9039(this, text, interpolation.OpenBracePosition, (DynAbs.Tracing.TraceSender.Conditional_F1(10033, 8943, 8965)||((interpolation.HasColon &&DynAbs.Tracing.TraceSender.Conditional_F2(10033, 8968, 8999))||DynAbs.Tracing.TraceSender.Conditional_F3(10033, 9002, 9038)))?interpolation.ColonPosition - 1 :interpolation.CloseBracePosition - 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,9054,10903);
using(var 
tempLexer = f_10033_9077_9224(f_10033_9087_9119(parsedText), f_10033_9121_9133(this), allowPreprocessorDirectives: false, interpolationFollowedByColon: interpolation.HasColon)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,9378,10888);
using(var 
tempParser = f_10033_9402_9443(tempLexer, null, null)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,9485,9515);

SyntaxToken 
commaToken = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,9537,9581);

ExpressionSyntax 
alignmentExpression = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,9603,9715);

f_10033_9603_9714(                    tempParser, out openBraceToken, out expression, out commaToken, out alignmentExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,9737,9929) || true) && (alignmentExpression != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,9737,9929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,9818,9906);

alignment = f_10033_9830_9905(commaToken, alignmentExpression);
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,9737,9929);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,9953,10014);

var 
extraTrivia = f_10033_9971_10013(f_10033_9971_9994(tempParser))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,10036,10869) || true) && (interpolation.HasColon)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,10036,10869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,10112,10208);

var 
colonToken = f_10033_10129_10207(f_10033_10129_10171(SyntaxKind.ColonToken), extraTrivia)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,10234,10333);

var 
formatText = f_10033_10251_10332(this, text, interpolation.ColonPosition + 1, interpolation.FormatEndPosition)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,10359,10470);

var 
formatString = f_10033_10378_10469(this, formatText, formatText, isVerbatim, SyntaxKind.InterpolatedStringTextToken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,10496,10571);

format = f_10033_10505_10570(colonToken, formatString);
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,10036,10869);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,10036,10869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,10776,10846);

closeBraceToken = f_10033_10794_10845(closeBraceToken, extraTrivia);
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,10036,10869);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(10033,9378,10888);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(10033,9054,10903);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,10919,11024);

var 
result = f_10033_10932_11023(openBraceToken, expression, alignment, format, closeBraceToken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,11038,11154);

f_10033_11038_11153(f_10033_11051_11127(this, text, interpolation.OpenBracePosition, interpolation.LastPosition)== f_10033_11131_11152(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,11210,11224);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10033,8321,11235);

Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_8739_8793(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFactory.MissingToken( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 8739, 8793);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_8813_8860(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFactory.Token( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 8813, 8860);
return return_v;
}


string
f_10033_8894_9039(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,string
s,int
first,int
last)
{
var return_v = this_param.Substring( s, first, last);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 8894, 9039);
return return_v;
}


Microsoft.CodeAnalysis.Text.SourceText
f_10033_9087_9119(string
text)
{
var return_v = Text.SourceText.From( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 9087, 9119);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_10033_9121_9133(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 9121, 9133);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
f_10033_9077_9224(Microsoft.CodeAnalysis.Text.SourceText
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options,bool
allowPreprocessorDirectives,bool
interpolationFollowedByColon)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer( text, options, allowPreprocessorDirectives:allowPreprocessorDirectives, interpolationFollowedByColon:interpolationFollowedByColon);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 9077, 9224);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
f_10033_9402_9443(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
lexer,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
oldTree,System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChangeRange>
changes)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser( lexer, oldTree, changes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 9402, 9443);
return return_v;
}


int
f_10033_9603_9714(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
openBraceToken,out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
expr,out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
commaToken,out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
alignmentExpression)
{
this_param.ParseInterpolationStart( out openBraceToken, out expr, out commaToken, out alignmentExpression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 9603, 9714);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolationAlignmentClauseSyntax
f_10033_9830_9905(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
commaToken,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
value)
{
var return_v = SyntaxFactory.InterpolationAlignmentClause( commaToken, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 9830, 9905);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_9971_9994(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param)
{
var return_v = this_param.CurrentToken;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 9971, 9994);
return return_v;
}


Microsoft.CodeAnalysis.GreenNode
f_10033_9971_10013(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.GetLeadingTrivia();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 9971, 10013);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_10129_10171(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFactory.Token( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 10129, 10171);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_10129_10207(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param,Microsoft.CodeAnalysis.GreenNode
trivia)
{
var return_v = this_param.TokenWithLeadingTrivia( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 10129, 10207);
return return_v;
}


string
f_10033_10251_10332(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,string
s,int
first,int
last)
{
var return_v = this_param.Substring( s, first, last);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 10251, 10332);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_10378_10469(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,string
text,string
bodyText,bool
isVerbatim,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = this_param.MakeStringToken( text, bodyText, isVerbatim, kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 10378, 10469);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolationFormatClauseSyntax
f_10033_10505_10570(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
colonToken,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
formatStringToken)
{
var return_v = SyntaxFactory.InterpolationFormatClause( colonToken, formatStringToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 10505, 10570);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_10794_10845(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param,Microsoft.CodeAnalysis.GreenNode
trivia)
{
var return_v = this_param.TokenWithLeadingTrivia( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 10794, 10845);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolationSyntax
f_10033_10932_11023(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
openBraceToken,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolationAlignmentClauseSyntax?
alignmentClause,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolationFormatClauseSyntax?
formatClause,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
closeBraceToken)
{
var return_v = SyntaxFactory.Interpolation( openBraceToken, expression, alignmentClause, formatClause, closeBraceToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 10932, 11023);
return return_v;
}


string
f_10033_11051_11127(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,string
s,int
first,int
last)
{
var return_v = this_param.Substring( s, first, last);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 11051, 11127);
return return_v;
}


string
f_10033_11131_11152(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolationSyntax
this_param)
{
var return_v = this_param.ToFullString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 11131, 11152);
return return_v;
}


int
f_10033_11038_11153(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 11038, 11153);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10033,8321,11235);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10033,8321,11235);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SyntaxToken MakeStringToken(string text, string bodyText, bool isVerbatim, SyntaxKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10033,11856,12767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,11980,12019);

var 
prefix = (DynAbs.Tracing.TraceSender.Conditional_F1(10033, 11993, 12003)||((isVerbatim &&DynAbs.Tracing.TraceSender.Conditional_F2(10033, 12006, 12011))||DynAbs.Tracing.TraceSender.Conditional_F3(10033, 12014, 12018)))?"@\"" :"\""
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,12033,12075);

var 
fakeString = prefix + bodyText + "\""
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,12089,12756);
using(var 
tempLexer = f_10033_12112_12205(f_10033_12122_12154(fakeString), f_10033_12156_12168(this), allowPreprocessorDirectives: false)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,12239,12273);

LexerMode 
mode = LexerMode.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,12291,12335);

SyntaxToken 
token = f_10033_12311_12334(tempLexer, ref mode)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,12353,12411);

f_10033_12353_12410(f_10033_12366_12376(token)== SyntaxKind.StringLiteralToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,12429,12505);

var 
result = f_10033_12442_12504(null, text, kind, f_10033_12482_12497(token), null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,12523,12707) || true) && (f_10033_12527_12552(token))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,12523,12707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,12594,12688);

result = f_10033_12603_12687(result, f_10033_12631_12686(f_10033_12647_12669(token), f_10033_12671_12685_M(-prefix.Length)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,12523,12707);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,12727,12741);

return result;
DynAbs.Tracing.TraceSender.TraceExitUsing(10033,12089,12756);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10033,11856,12767);

Microsoft.CodeAnalysis.Text.SourceText
f_10033_12122_12154(string
text)
{
var return_v = Text.SourceText.From( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 12122, 12154);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_10033_12156_12168(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 12156, 12168);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
f_10033_12112_12205(Microsoft.CodeAnalysis.Text.SourceText
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options,bool
allowPreprocessorDirectives)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer( text, options, allowPreprocessorDirectives:allowPreprocessorDirectives);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 12112, 12205);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_12311_12334(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
this_param,ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
mode)
{
var return_v = this_param.Lex( ref mode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 12311, 12334);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10033_12366_12376(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 12366, 12376);
return return_v;
}


int
f_10033_12353_12410(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 12353, 12410);
return 0;
}


string
f_10033_12482_12497(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.ValueText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 12482, 12497);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_12442_12504(Microsoft.CodeAnalysis.GreenNode
leading,string
text,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind,string
value,Microsoft.CodeAnalysis.GreenNode
trailing)
{
var return_v = SyntaxFactory.Literal( leading, text, kind, value, trailing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 12442, 12504);
return return_v;
}


bool
f_10033_12527_12552(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.ContainsDiagnostics;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 12527, 12552);
return return_v;
}


Microsoft.CodeAnalysis.DiagnosticInfo[]
f_10033_12647_12669(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.GetDiagnostics();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 12647, 12669);
return return_v;
}


int
f_10033_12671_12685_M(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 12671, 12685);
return return_v;
}


Microsoft.CodeAnalysis.DiagnosticInfo[]
f_10033_12631_12686(Microsoft.CodeAnalysis.DiagnosticInfo[]
infos,int
offset)
{
var return_v = MoveDiagnostics( infos, offset);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 12631, 12686);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_12603_12687(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
node,Microsoft.CodeAnalysis.DiagnosticInfo[]
diagnostics)
{
var return_v = node.WithDiagnosticsGreen<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>( diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 12603, 12687);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10033,11856,12767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10033,11856,12767);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static DiagnosticInfo[] MoveDiagnostics(DiagnosticInfo[] infos, int offset)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10033,12779,13204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,12887,12944);

var 
builder = f_10033_12901_12943()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,12958,13145);
foreach(var info in f_10033_12979_12984_I(infos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,12958,13145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,13018,13056);

var 
sd = info as SyntaxDiagnosticInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,13074,13130);

f_10033_13074_13129(                builder, f_10033_13089_13120(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sd, 10033, 13086, 13120), sd.Offset + offset)??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo?>(10033, 13086, 13128)??info));
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,12958,13145);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10033,1,188);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10033,1,188);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,13161,13193);

return f_10033_13168_13192(builder);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10033,12779,13204);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
f_10033_12901_12943()
{
var return_v = ArrayBuilder<DiagnosticInfo>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 12901, 12943);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo?
f_10033_13089_13120(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
this_param,int
offset)
{
var return_v = this_param?.WithOffset( offset);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 13089, 13120);
return return_v;
}


int
f_10033_13074_13129(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
this_param,Microsoft.CodeAnalysis.DiagnosticInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 13074, 13129);
return 0;
}


Microsoft.CodeAnalysis.DiagnosticInfo[]
f_10033_12979_12984_I(Microsoft.CodeAnalysis.DiagnosticInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 12979, 12984);
return return_v;
}


Microsoft.CodeAnalysis.DiagnosticInfo[]
f_10033_13168_13192(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
this_param)
{
var return_v = this_param.ToArrayAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 13168, 13192);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10033,12779,13204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10033,12779,13204);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void ParseInterpolationStart(out SyntaxToken openBraceToken, out ExpressionSyntax expr, out SyntaxToken commaToken, out ExpressionSyntax alignmentExpression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10033,13216,13963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,13406,13464);

openBraceToken = f_10033_13423_13463(this, SyntaxKind.OpenBraceToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,13478,13512);

expr = f_10033_13485_13511(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,13526,13952) || true) && (f_10033_13530_13552(f_10033_13530_13547(this))== SyntaxKind.CommaToken)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,13526,13952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,13611,13661);

commaToken = f_10033_13624_13660(this, SyntaxKind.CommaToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,13679,13753);

alignmentExpression = f_10033_13701_13752(this, f_10033_13725_13751(this));
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,13526,13952);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10033,13526,13952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,13819,13837);

commaToken = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,13855,13882);

alignmentExpression = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10033,13900,13937);

expr = f_10033_13907_13936(this, expr);
DynAbs.Tracing.TraceSender.TraceExitCondition(10033,13526,13952);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10033,13216,13963);

Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_13423_13463(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = this_param.EatToken( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 13423, 13463);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
f_10033_13485_13511(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param)
{
var return_v = this_param.ParseExpressionCore();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 13485, 13511);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_13530_13547(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param)
{
var return_v = this_param.CurrentToken;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 13530, 13547);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10033_13530_13552(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10033, 13530, 13552);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10033_13624_13660(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = this_param.EatToken( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 13624, 13660);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
f_10033_13725_13751(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param)
{
var return_v = this_param.ParseExpressionCore();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 13725, 13751);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
f_10033_13701_13752(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
node)
{
var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 13701, 13752);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
f_10033_13907_13936(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
node)
{
var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10033, 13907, 13936);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10033,13216,13963);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10033,13216,13963);
}
		}
}
}
