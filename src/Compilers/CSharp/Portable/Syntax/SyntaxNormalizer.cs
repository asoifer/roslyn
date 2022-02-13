// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
internal class SyntaxNormalizer : CSharpSyntaxRewriter
{
private readonly TextSpan _consideredSpan;

private readonly int _initialDepth;

private readonly string _indentWhitespace;

private readonly bool _useElasticTrivia;

private readonly SyntaxTrivia _eolTrivia;

private bool _isInStructuredTrivia;

private SyntaxToken _previousToken;

private bool _afterLineBreak;

private bool _afterIndentation;

private ArrayBuilder<SyntaxTrivia>? _indentations;

private SyntaxNormalizer(TextSpan consideredSpan, int initialDepth, string indentWhitespace, string eolWhitespace, bool useElasticTrivia)
:base(visitIntoStructuredTrivia: f_10810_1447_1478_C(true) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10810,1289,1863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,688,701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,736,753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,786,803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,880,901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,974,989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,1013,1030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,1263,1276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,1504,1537);

_consideredSpan = consideredSpan;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,1551,1580);

_initialDepth = initialDepth;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,1594,1631);

_indentWhitespace = indentWhitespace;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,1645,1682);

_useElasticTrivia = useElasticTrivia;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,1696,1815);

_eolTrivia = (DynAbs.Tracing.TraceSender.Conditional_F1(10810, 1709, 1725)||((useElasticTrivia &&DynAbs.Tracing.TraceSender.Conditional_F2(10810, 1728, 1773))||DynAbs.Tracing.TraceSender.Conditional_F3(10810, 1776, 1814)))?f_10810_1728_1773(eolWhitespace):f_10810_1776_1814(eolWhitespace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,1829,1852);

_afterLineBreak = true;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10810,1289,1863);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,1289,1863);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,1289,1863);
}
		}

internal static TNode Normalize<TNode>(TNode node, string indentWhitespace, string eolWhitespace, bool useElasticTrivia = false)
            where TNode : SyntaxNode
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,1875,2325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,2066,2197);

var 
normalizer = f_10810_2083_2196<TNode>(f_10810_2104_2117<TNode>(node), f_10810_2119_2144<TNode>(node), indentWhitespace, eolWhitespace, useElasticTrivia)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,2211,2254);

var 
result = (TNode)f_10810_2231_2253<TNode>(normalizer, node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,2268,2286);

f_10810_2268_2285<TNode>(            normalizer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,2300,2314);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,1875,2325);

Microsoft.CodeAnalysis.Text.TextSpan
f_10810_2104_2117<TNode>(TNode
this_param)            where TNode : SyntaxNode

{
var return_v = this_param.FullSpan;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 2104, 2117);
return return_v;
}


int
f_10810_2119_2144<TNode>(TNode
node)            where TNode : SyntaxNode

{
var return_v = GetDeclarationDepth( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 2119, 2144);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
f_10810_2083_2196<TNode>(Microsoft.CodeAnalysis.Text.TextSpan
consideredSpan,int
initialDepth,string
indentWhitespace,string
eolWhitespace,bool
useElasticTrivia)            where TNode : SyntaxNode

{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer( consideredSpan, initialDepth, indentWhitespace, eolWhitespace, useElasticTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 2083, 2196);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_10810_2231_2253<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param,TNode
node)            where TNode : SyntaxNode

{
var return_v = this_param.Visit( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 2231, 2253);
return return_v;
}


int
f_10810_2268_2285<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param)            where TNode : SyntaxNode

{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 2268, 2285);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,1875,2325);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,1875,2325);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static SyntaxToken Normalize(SyntaxToken token, string indentWhitespace, string eolWhitespace, bool useElasticTrivia = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,2337,2756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,2496,2629);

var 
normalizer = f_10810_2513_2628(token.FullSpan, f_10810_2550_2576(token), indentWhitespace, eolWhitespace, useElasticTrivia)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,2643,2685);

var 
result = f_10810_2656_2684(normalizer, token)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,2699,2717);

f_10810_2699_2716(            normalizer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,2731,2745);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,2337,2756);

int
f_10810_2550_2576(Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = GetDeclarationDepth( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 2550, 2576);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
f_10810_2513_2628(Microsoft.CodeAnalysis.Text.TextSpan
consideredSpan,int
initialDepth,string
indentWhitespace,string
eolWhitespace,bool
useElasticTrivia)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer( consideredSpan, initialDepth, indentWhitespace, eolWhitespace, useElasticTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 2513, 2628);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10810_2656_2684(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param,Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = this_param.VisitToken( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 2656, 2684);
return return_v;
}


int
f_10810_2699_2716(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 2699, 2716);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,2337,2756);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,2337,2756);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static SyntaxTriviaList Normalize(SyntaxTriviaList trivia, string indentWhitespace, string eolWhitespace, bool useElasticTrivia = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,2768,3468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,2938,3079);

var 
normalizer = f_10810_2955_3078(trivia.FullSpan, f_10810_2993_3026(trivia.Token), indentWhitespace, eolWhitespace, useElasticTrivia)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,3093,3397);

var 
result = f_10810_3106_3396(normalizer, trivia, f_10810_3174_3233(trivia.ElementAt(0).Token), isTrailing: false, indentAfterLineBreak: false, mustHaveSeparator: false, lineBreaksAfter: 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,3411,3429);

f_10810_3411_3428(            normalizer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,3443,3457);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,2768,3468);

int
f_10810_2993_3026(Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = GetDeclarationDepth( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 2993, 3026);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
f_10810_2955_3078(Microsoft.CodeAnalysis.Text.TextSpan
consideredSpan,int
initialDepth,string
indentWhitespace,string
eolWhitespace,bool
useElasticTrivia)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer( consideredSpan, initialDepth, indentWhitespace, eolWhitespace, useElasticTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 2955, 3078);
return return_v;
}


int
f_10810_3174_3233(Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = GetDeclarationDepth( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 3174, 3233);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTriviaList
f_10810_3106_3396(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param,Microsoft.CodeAnalysis.SyntaxTriviaList
triviaList,int
depth,bool
isTrailing,bool
indentAfterLineBreak,bool
mustHaveSeparator,int
lineBreaksAfter)
{
var return_v = this_param.RewriteTrivia( triviaList, depth, isTrailing: isTrailing, indentAfterLineBreak: indentAfterLineBreak, mustHaveSeparator: mustHaveSeparator, lineBreaksAfter: lineBreaksAfter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 3106, 3396);
return return_v;
}


int
f_10810_3411_3428(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 3411, 3428);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,2768,3468);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,2768,3468);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void Free()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10810,3480,3630);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,3524,3619) || true) && (_indentations != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,3524,3619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,3583,3604);

f_10810_3583_3603(                _indentations);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,3524,3619);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10810,3480,3630);

int
f_10810_3583_3603(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 3583, 3603);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,3480,3630);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,3480,3630);
}
		}

public override SyntaxToken VisitToken(SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10810,3642,5175);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,3724,3866) || true) && (token.Kind()== SyntaxKind.None ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 3728, 3804)||(token.IsMissing &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 3764, 3803)&&token.FullWidth == 0))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,3724,3866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,3838,3851);

return token;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,3724,3866);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,3918,3933);

var 
tk = token
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,3953,3992);

var 
depth = f_10810_3965_3991(token)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,4012,4329);

tk = tk.WithLeadingTrivia(f_10810_4038_4327(this, token.LeadingTrivia, depth, isTrailing: false, indentAfterLineBreak: f_10810_4206_4238(token), mustHaveSeparator: false, lineBreaksAfter: 0));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,4349,4398);

var 
nextToken = f_10810_4365_4397(this, token)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,4418,4455);

_afterLineBreak = f_10810_4436_4454(token);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,4473,4499);

_afterIndentation = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,4519,4575);

var 
lineBreaksAfter = f_10810_4541_4574(this, token, nextToken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,4593,4652);

var 
needsSeparatorAfter = f_10810_4619_4651(token, nextToken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,4670,4989);

tk = tk.WithTrailingTrivia(f_10810_4697_4987(this, token.TrailingTrivia, depth, isTrailing: true, indentAfterLineBreak: false, mustHaveSeparator: needsSeparatorAfter, lineBreaksAfter: lineBreaksAfter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,5009,5019);

return tk;
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(10810,5048,5164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,5126,5149);

_previousToken = token;
DynAbs.Tracing.TraceSender.TraceExitFinally(10810,5048,5164);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10810,3642,5175);

int
f_10810_3965_3991(Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = GetDeclarationDepth( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 3965, 3991);
return return_v;
}


bool
f_10810_4206_4238(Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = NeedsIndentAfterLineBreak( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 4206, 4238);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTriviaList
f_10810_4038_4327(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param,Microsoft.CodeAnalysis.SyntaxTriviaList
triviaList,int
depth,bool
isTrailing,bool
indentAfterLineBreak,bool
mustHaveSeparator,int
lineBreaksAfter)
{
var return_v = this_param.RewriteTrivia( triviaList, depth, isTrailing: isTrailing, indentAfterLineBreak: indentAfterLineBreak, mustHaveSeparator: mustHaveSeparator, lineBreaksAfter: lineBreaksAfter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 4038, 4327);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10810_4365_4397(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param,Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = this_param.GetNextRelevantToken( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 4365, 4397);
return return_v;
}


bool
f_10810_4436_4454(Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = IsLineBreak( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 4436, 4454);
return return_v;
}


int
f_10810_4541_4574(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param,Microsoft.CodeAnalysis.SyntaxToken
currentToken,Microsoft.CodeAnalysis.SyntaxToken
nextToken)
{
var return_v = this_param.LineBreaksAfter( currentToken, nextToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 4541, 4574);
return return_v;
}


bool
f_10810_4619_4651(Microsoft.CodeAnalysis.SyntaxToken
token,Microsoft.CodeAnalysis.SyntaxToken
next)
{
var return_v = NeedsSeparator( token, next);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 4619, 4651);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTriviaList
f_10810_4697_4987(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param,Microsoft.CodeAnalysis.SyntaxTriviaList
triviaList,int
depth,bool
isTrailing,bool
indentAfterLineBreak,bool
mustHaveSeparator,int
lineBreaksAfter)
{
var return_v = this_param.RewriteTrivia( triviaList, depth, isTrailing: isTrailing, indentAfterLineBreak: indentAfterLineBreak, mustHaveSeparator: mustHaveSeparator, lineBreaksAfter: lineBreaksAfter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 4697, 4987);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,3642,5175);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,3642,5175);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SyntaxToken GetNextRelevantToken(SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10810,5187,5799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,5365,5564);

var 
nextToken = token.GetNextToken(                t => SyntaxToken.NonZeroWidth(t) || t.Kind() == SyntaxKind.EndOfDirectiveToken,                t => t.Kind() == SyntaxKind.SkippedTokensTrivia)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,5580,5788) || true) && (_consideredSpan.Contains(nextToken.FullSpan))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,5580,5788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,5662,5679);

return nextToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,5580,5788);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,5580,5788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,5745,5773);

return default(SyntaxToken);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,5580,5788);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10810,5187,5799);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,5187,5799);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,5187,5799);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SyntaxTrivia GetIndentation(int count)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10810,5811,6700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,5882,5925);

count = f_10810_5890_5924(count - _initialDepth, 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,5941,5966);

int 
capacity = count + 1
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,5980,6224) || true) && (_indentations == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,5980,6224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,6039,6104);

_indentations = f_10810_6055_6103(capacity);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,5980,6224);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,5980,6224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,6170,6209);

f_10810_6170_6208(                _indentations, capacity);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,5980,6224);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,6306,6329);

            // grow indentation collection if necessary
            for (int 
i = f_10810_6310_6329(_indentations)
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,6297,6645) || true) && (i <= count)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,6343,6346)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10810,6297,6645))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,6297,6645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,6380,6502);

string 
text = (DynAbs.Tracing.TraceSender.Conditional_F1(10810, 6394, 6400)||((i == 0
&&DynAbs.Tracing.TraceSender.Conditional_F2(10810, 6424, 6426))||DynAbs.Tracing.TraceSender.Conditional_F3(10810, 6450, 6501)))?""
:_indentations[i - 1].ToString()+ _indentWhitespace
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,6520,6630);

f_10810_6520_6629(                _indentations, (DynAbs.Tracing.TraceSender.Conditional_F1(10810, 6538, 6555)||((_useElasticTrivia &&DynAbs.Tracing.TraceSender.Conditional_F2(10810, 6558, 6595))||DynAbs.Tracing.TraceSender.Conditional_F3(10810, 6598, 6628)))?f_10810_6558_6595(text):f_10810_6598_6628(text));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10810,1,349);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10810,1,349);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,6661,6689);

return f_10810_6668_6688(_indentations, count);
DynAbs.Tracing.TraceSender.TraceExitMethod(10810,5811,6700);

int
f_10810_5890_5924(int
val1,int
val2)
{
var return_v = Math.Max( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 5890, 5924);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
f_10810_6055_6103(int
capacity)
{
var return_v = ArrayBuilder<SyntaxTrivia>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 6055, 6103);
return return_v;
}


int
f_10810_6170_6208(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,int
capacity)
{
this_param.EnsureCapacity( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 6170, 6208);
return 0;
}


int
f_10810_6310_6329(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 6310, 6329);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_6558_6595(string
text)
{
var return_v = SyntaxFactory.ElasticWhitespace( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 6558, 6595);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_6598_6628(string
text)
{
var return_v = SyntaxFactory.Whitespace( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 6598, 6628);
return return_v;
}


int
f_10810_6520_6629(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 6520, 6629);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_6668_6688(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 6668, 6688);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,5811,6700);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,5811,6700);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool NeedsIndentAfterLineBreak(SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,6712,6860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,6801,6849);

return !token.IsKind(SyntaxKind.EndOfFileToken);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,6712,6860);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,6712,6860);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,6712,6860);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private int LineBreaksAfter(SyntaxToken currentToken, SyntaxToken nextToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10810,6872,11285);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,6973,7086) || true) && (currentToken.IsKind(SyntaxKind.EndOfDirectiveToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,6973,7086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,7062,7071);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,6973,7086);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,7102,7199) || true) && (nextToken.Kind()== SyntaxKind.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7102,7199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,7175,7184);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7102,7199);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,7304,7387) || true) && (_isInStructuredTrivia)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7304,7387);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,7363,7372);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7304,7387);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,7403,7602) || true) && (nextToken.IsKind(SyntaxKind.CloseBraceToken)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 7407, 7544)&&f_10810_7472_7544(f_10810_7516_7543_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(currentToken.Parent, 10810, 7516, 7543)?.Parent))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7403,7602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,7578,7587);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7403,7602);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,7618,9533);

switch (currentToken.Kind())
            {

case SyntaxKind.None:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7618,9533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,7722,7731);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7618,9533);

case SyntaxKind.OpenBraceToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7618,9533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,7804,7861);

return f_10810_7811_7860(currentToken, nextToken);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7618,9533);

case SyntaxKind.FinallyKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7618,9533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,7934,7943);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7618,9533);

case SyntaxKind.CloseBraceToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7618,9533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,8017,8075);

return f_10810_8024_8074(currentToken, nextToken);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7618,9533);

case SyntaxKind.CloseParenToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7618,9533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,8332,8581);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10810, 8339, 8572)||(((((currentToken.Parent is StatementSyntax) &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 8341, 8424)&&nextToken.Parent != currentToken.Parent))
||(DynAbs.Tracing.TraceSender.Expression_False(10810, 8340, 8499)||nextToken.Kind()== SyntaxKind.OpenBraceToken
)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 8340, 8571)||nextToken.Kind()== SyntaxKind.WhereKeyword)) &&DynAbs.Tracing.TraceSender.Conditional_F2(10810, 8575, 8576))||DynAbs.Tracing.TraceSender.Conditional_F3(10810, 8579, 8580)))?1 :0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7618,9533);

case SyntaxKind.CloseBracketToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7618,9533);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,8657,8837) || true) && (currentToken.Parent is AttributeListSyntax &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 8661, 8755)&&!(f_10810_8709_8735(currentToken.Parent)is ParameterSyntax)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,8657,8837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,8805,8814);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,8657,8837);
}
DynAbs.Tracing.TraceSender.TraceBreak(10810,8859,8865);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7618,9533);

case SyntaxKind.SemicolonToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7618,9533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,8938,8995);

return f_10810_8945_8994(currentToken, nextToken);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7618,9533);

case SyntaxKind.CommaToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7618,9533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,9064,9124);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10810, 9071, 9115)||((currentToken.Parent is EnumDeclarationSyntax &&DynAbs.Tracing.TraceSender.Conditional_F2(10810, 9118, 9119))||DynAbs.Tracing.TraceSender.Conditional_F3(10810, 9122, 9123)))?1 :0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7618,9533);

case SyntaxKind.ElseKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7618,9533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,9192,9248);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10810, 9199, 9239)||((nextToken.Kind()!= SyntaxKind.IfKeyword &&DynAbs.Tracing.TraceSender.Conditional_F2(10810, 9242, 9243))||DynAbs.Tracing.TraceSender.Conditional_F3(10810, 9246, 9247)))?1 :0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7618,9533);

case SyntaxKind.ColonToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,7618,9533);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,9315,9490) || true) && (currentToken.Parent is LabeledStatementSyntax ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 9319, 9408)||currentToken.Parent is SwitchLabelSyntax))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,9315,9490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,9458,9467);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,9315,9490);
}
DynAbs.Tracing.TraceSender.TraceBreak(10810,9512,9518);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,7618,9533);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,9549,10510) || true) && ((nextToken.IsKind(SyntaxKind.FromKeyword)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 9554, 9644)&&f_10810_9598_9644(nextToken.Parent, SyntaxKind.FromClause))) ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 9553, 9756)||                (nextToken.IsKind(SyntaxKind.LetKeyword)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 9667, 9755)&&f_10810_9710_9755(nextToken.Parent, SyntaxKind.LetClause))) )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 9553, 9871)||                (nextToken.IsKind(SyntaxKind.WhereKeyword)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 9778, 9870)&&f_10810_9823_9870(nextToken.Parent, SyntaxKind.WhereClause))) )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 9553, 9984)||                (nextToken.IsKind(SyntaxKind.JoinKeyword)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 9893, 9983)&&f_10810_9937_9983(nextToken.Parent, SyntaxKind.JoinClause))) )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 9553, 10101)||                (nextToken.IsKind(SyntaxKind.JoinKeyword)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 10006, 10100)&&f_10810_10050_10100(nextToken.Parent, SyntaxKind.JoinIntoClause))) )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 9553, 10220)||                (nextToken.IsKind(SyntaxKind.OrderByKeyword)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 10123, 10219)&&f_10810_10170_10219(nextToken.Parent, SyntaxKind.OrderByClause))) )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 9553, 10337)||                (nextToken.IsKind(SyntaxKind.SelectKeyword)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 10242, 10336)&&f_10810_10288_10336(nextToken.Parent, SyntaxKind.SelectClause))) )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 9553, 10452)||                (nextToken.IsKind(SyntaxKind.GroupKeyword)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 10359, 10451)&&f_10810_10404_10451(nextToken.Parent, SyntaxKind.GroupClause)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,9549,10510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,10486,10495);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,9549,10510);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,10526,11249);

switch (nextToken.Kind())
            {

case SyntaxKind.OpenBraceToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,10526,11249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,10637,10681);

return f_10810_10644_10680(nextToken);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,10526,11249);

case SyntaxKind.CloseBraceToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,10526,11249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,10753,10798);

return f_10810_10760_10797(nextToken);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,10526,11249);

case SyntaxKind.ElseKeyword:
                case SyntaxKind.FinallyKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,10526,11249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,10915,10924);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,10526,11249);

case SyntaxKind.OpenBracketToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,10526,11249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,10997,11103);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10810, 11004, 11094)||(((nextToken.Parent is AttributeListSyntax &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 11005, 11093)&&!(f_10810_11050_11073(nextToken.Parent)is ParameterSyntax))) &&DynAbs.Tracing.TraceSender.Conditional_F2(10810, 11097, 11098))||DynAbs.Tracing.TraceSender.Conditional_F3(10810, 11101, 11102)))?1 :0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,10526,11249);

case SyntaxKind.WhereKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,10526,11249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,11172,11234);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10810, 11179, 11225)||((currentToken.Parent is TypeParameterListSyntax &&DynAbs.Tracing.TraceSender.Conditional_F2(10810, 11228, 11229))||DynAbs.Tracing.TraceSender.Conditional_F3(10810, 11232, 11233)))?1 :0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,10526,11249);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,11265,11274);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(10810,6872,11285);

Microsoft.CodeAnalysis.SyntaxNode?
f_10810_7516_7543_M(Microsoft.CodeAnalysis.SyntaxNode?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 7516, 7543);
return return_v;
}


bool
f_10810_7472_7544(Microsoft.CodeAnalysis.SyntaxNode?
node)
{
var return_v = IsAccessorListWithoutAccessorsWithBlockBody( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 7472, 7544);
return return_v;
}


int
f_10810_7811_7860(Microsoft.CodeAnalysis.SyntaxToken
currentToken,Microsoft.CodeAnalysis.SyntaxToken
nextToken)
{
var return_v = LineBreaksAfterOpenBrace( currentToken, nextToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 7811, 7860);
return return_v;
}


int
f_10810_8024_8074(Microsoft.CodeAnalysis.SyntaxToken
currentToken,Microsoft.CodeAnalysis.SyntaxToken
nextToken)
{
var return_v = LineBreaksAfterCloseBrace( currentToken, nextToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 8024, 8074);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_10810_8709_8735(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 8709, 8735);
return return_v;
}


int
f_10810_8945_8994(Microsoft.CodeAnalysis.SyntaxToken
currentToken,Microsoft.CodeAnalysis.SyntaxToken
nextToken)
{
var return_v = LineBreaksAfterSemicolon( currentToken, nextToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 8945, 8994);
return return_v;
}


bool
f_10810_9598_9644(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 9598, 9644);
return return_v;
}


bool
f_10810_9710_9755(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 9710, 9755);
return return_v;
}


bool
f_10810_9823_9870(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 9823, 9870);
return return_v;
}


bool
f_10810_9937_9983(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 9937, 9983);
return return_v;
}


bool
f_10810_10050_10100(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 10050, 10100);
return return_v;
}


bool
f_10810_10170_10219(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 10170, 10219);
return return_v;
}


bool
f_10810_10288_10336(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 10288, 10336);
return return_v;
}


bool
f_10810_10404_10451(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 10404, 10451);
return return_v;
}


int
f_10810_10644_10680(Microsoft.CodeAnalysis.SyntaxToken
openBraceToken)
{
var return_v = LineBreaksBeforeOpenBrace( openBraceToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 10644, 10680);
return return_v;
}


int
f_10810_10760_10797(Microsoft.CodeAnalysis.SyntaxToken
closeBraceToken)
{
var return_v = LineBreaksBeforeCloseBrace( closeBraceToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 10760, 10797);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_10810_11050_11073(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 11050, 11073);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,6872,11285);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,6872,11285);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsAccessorListWithoutAccessorsWithBlockBody(SyntaxNode? node)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10810,11392,11502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,11395,11502);
return node is AccessorListSyntax accessorList &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 11395, 11502)&&                accessorList.Accessors.All(a => a.Body == null));DynAbs.Tracing.TraceSender.TraceExitMethod(10810,11392,11502);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,11392,11502);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,11392,11502);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsAccessorListFollowedByInitializer([NotNullWhen(true)] SyntaxNode? node)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10810,11622,11783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,11625,11783);
return node is AccessorListSyntax accessorList &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 11625, 11734)&&f_10810_11685_11696(node)is PropertyDeclarationSyntax property )&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 11625, 11783)&&f_10810_11755_11775(property)!= null);DynAbs.Tracing.TraceSender.TraceExitMethod(10810,11622,11783);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,11622,11783);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,11622,11783);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.SyntaxNode?
f_10810_11685_11696(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 11685, 11696);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
f_10810_11755_11775(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
this_param)
{
var return_v = this_param.Initializer ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 11755, 11775);
return return_v;
}

		}

private static int LineBreaksBeforeOpenBrace(SyntaxToken openBraceToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,11796,12332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,11893,11956);

f_10810_11893_11955(openBraceToken.IsKind(SyntaxKind.OpenBraceToken));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,11970,12321) || true) && (f_10810_11974_12028(openBraceToken.Parent, SyntaxKind.Interpolation)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 11974, 12101)||                openBraceToken.Parent is InitializerExpressionSyntax )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 11974, 12188)||f_10810_12122_12188(openBraceToken.Parent)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,11970,12321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,12222,12231);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,11970,12321);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,11970,12321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,12297,12306);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,11970,12321);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,11796,12332);

int
f_10810_11893_11955(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 11893, 11955);
return 0;
}


bool
f_10810_11974_12028(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 11974, 12028);
return return_v;
}


bool
f_10810_12122_12188(Microsoft.CodeAnalysis.SyntaxNode?
node)
{
var return_v = IsAccessorListWithoutAccessorsWithBlockBody( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 12122, 12188);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,11796,12332);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,11796,12332);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int LineBreaksBeforeCloseBrace(SyntaxToken closeBraceToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,12344,12799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,12443,12508);

f_10810_12443_12507(closeBraceToken.IsKind(SyntaxKind.CloseBraceToken));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,12522,12788) || true) && (f_10810_12526_12581(closeBraceToken.Parent, SyntaxKind.Interpolation)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 12526, 12655)||                closeBraceToken.Parent is InitializerExpressionSyntax))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,12522,12788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,12689,12698);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,12522,12788);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,12522,12788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,12764,12773);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,12522,12788);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,12344,12799);

int
f_10810_12443_12507(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 12443, 12507);
return 0;
}


bool
f_10810_12526_12581(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 12526, 12581);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,12344,12799);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,12344,12799);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int LineBreaksAfterOpenBrace(SyntaxToken currentToken, SyntaxToken nextToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,12811,13284);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,12928,13273) || true) && (currentToken.Parent is InitializerExpressionSyntax ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 12932, 13055)||f_10810_13003_13055(                currentToken.Parent, SyntaxKind.Interpolation))||(DynAbs.Tracing.TraceSender.Expression_False(10810, 12932, 13140)||f_10810_13076_13140(currentToken.Parent)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,12928,13273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,13174,13183);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,12928,13273);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,12928,13273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,13249,13258);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,12928,13273);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,12811,13284);

bool
f_10810_13003_13055(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 13003, 13055);
return return_v;
}


bool
f_10810_13076_13140(Microsoft.CodeAnalysis.SyntaxNode?
node)
{
var return_v = IsAccessorListWithoutAccessorsWithBlockBody( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 13076, 13140);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,12811,13284);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,12811,13284);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int LineBreaksAfterCloseBrace(SyntaxToken currentToken, SyntaxToken nextToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,13296,14493);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,13414,13761) || true) && (currentToken.Parent is InitializerExpressionSyntax ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 13418, 13541)||f_10810_13489_13541(                currentToken.Parent, SyntaxKind.Interpolation))||(DynAbs.Tracing.TraceSender.Expression_False(10810, 13418, 13626)||f_10810_13562_13589_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(currentToken.Parent, 10810, 13562, 13589)?.Parent)is AnonymousFunctionExpressionSyntax )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 13418, 13703)||f_10810_13647_13703(currentToken.Parent)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,13414,13761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,13737,13746);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,13414,13761);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,13777,13805);

var 
kind = nextToken.Kind()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,13819,14482);

switch (kind)
            {

case SyntaxKind.EndOfFileToken:
                case SyntaxKind.CloseBraceToken:
                case SyntaxKind.CatchKeyword:
                case SyntaxKind.FinallyKeyword:
                case SyntaxKind.ElseKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,13819,14482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,14110,14119);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,13819,14482);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,13819,14482);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,14167,14467) || true) && (kind == SyntaxKind.WhileKeyword &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 14171, 14278)&&f_10810_14231_14278(                        nextToken.Parent, SyntaxKind.DoStatement)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,14167,14467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,14328,14337);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,14167,14467);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,14167,14467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,14435,14444);

return 2;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,14167,14467);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,13819,14482);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,13296,14493);

bool
f_10810_13489_13541(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 13489, 13541);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_10810_13562_13589_M(Microsoft.CodeAnalysis.SyntaxNode?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 13562, 13589);
return return_v;
}


bool
f_10810_13647_13703(Microsoft.CodeAnalysis.SyntaxNode?
node)
{
var return_v = IsAccessorListFollowedByInitializer( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 13647, 13703);
return return_v;
}


bool
f_10810_14231_14278(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 14231, 14278);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,13296,14493);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,13296,14493);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int LineBreaksAfterSemicolon(SyntaxToken currentToken, SyntaxToken nextToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,14505,15563);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,14622,15552) || true) && (f_10810_14626_14677(currentToken.Parent, SyntaxKind.ForStatement))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,14622,15552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,14711,14720);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,14622,15552);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,14622,15552);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,14754,15552) || true) && (nextToken.Kind()== SyntaxKind.CloseBraceToken)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,14754,15552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,14838,14847);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,14754,15552);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,14754,15552);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,14881,15552) || true) && (f_10810_14885_14938(currentToken.Parent, SyntaxKind.UsingDirective))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,14881,15552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,14972,15038);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10810, 14979, 15029)||((f_10810_14979_15029(nextToken.Parent, SyntaxKind.UsingDirective)&&DynAbs.Tracing.TraceSender.Conditional_F2(10810, 15032, 15033))||DynAbs.Tracing.TraceSender.Conditional_F3(10810, 15036, 15037)))?1 :2;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,14881,15552);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,14881,15552);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,15072,15552) || true) && (f_10810_15076_15135(currentToken.Parent, SyntaxKind.ExternAliasDirective))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,15072,15552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,15169,15241);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10810, 15176, 15232)||((f_10810_15176_15232(nextToken.Parent, SyntaxKind.ExternAliasDirective)&&DynAbs.Tracing.TraceSender.Conditional_F2(10810, 15235, 15236))||DynAbs.Tracing.TraceSender.Conditional_F3(10810, 15239, 15240)))?1 :2;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,15072,15552);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,15072,15552);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,15275,15552) || true) && (currentToken.Parent is AccessorDeclarationSyntax &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 15279, 15419)&&f_10810_15348_15419(f_10810_15392_15418(currentToken.Parent))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,15275,15552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,15453,15462);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,15275,15552);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,15275,15552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,15528,15537);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,15275,15552);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,15072,15552);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,14881,15552);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,14754,15552);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,14622,15552);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,14505,15563);

bool
f_10810_14626_14677(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 14626, 14677);
return return_v;
}


bool
f_10810_14885_14938(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 14885, 14938);
return return_v;
}


bool
f_10810_14979_15029(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 14979, 15029);
return return_v;
}


bool
f_10810_15076_15135(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 15076, 15135);
return return_v;
}


bool
f_10810_15176_15232(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 15176, 15232);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_10810_15392_15418(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 15392, 15418);
return return_v;
}


bool
f_10810_15348_15419(Microsoft.CodeAnalysis.SyntaxNode?
node)
{
var return_v = IsAccessorListWithoutAccessorsWithBlockBody( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 15348, 15419);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,14505,15563);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,14505,15563);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool NeedsSeparator(SyntaxToken token, SyntaxToken next)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,15575,21381);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,15671,15780) || true) && (token.Parent == null ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 15675, 15718)||next.Parent == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,15671,15780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,15752,15765);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,15671,15780);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,15796,16200) || true) && (f_10810_15800_15856(next.Parent)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 15800, 15940)||f_10810_15877_15940(f_10810_15921_15939(next.Parent))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,15796,16200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,16138,16185);

return !next.IsKind(SyntaxKind.SemicolonToken);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,15796,16200);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,16216,16341) || true) && (f_10810_16220_16248(token.Kind())||(DynAbs.Tracing.TraceSender.Expression_False(10810, 16220, 16279)||f_10810_16252_16279(next.Kind())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,16216,16341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,16313,16326);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,16216,16341);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,16357,16675) || true) && (next.Kind()== SyntaxKind.EndOfDirectiveToken)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,16357,16675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,16604,16660);

return f_10810_16611_16634(token.Kind())&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 16611, 16659)&&next.LeadingWidth > 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,16357,16675);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,16691,17163) || true) && ((token.Parent is AssignmentExpressionSyntax &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 16696, 16785)&&f_10810_16742_16785(token.Kind()))) ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 16695, 16896)||                (next.Parent is AssignmentExpressionSyntax &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 16808, 16895)&&f_10810_16853_16895(next.Kind()))) )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 16695, 17000)||                (token.Parent is BinaryExpressionSyntax &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 16918, 16999)&&f_10810_16960_16999(token.Kind()))) )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 16695, 17102)||                (next.Parent is BinaryExpressionSyntax &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 17022, 17101)&&f_10810_17063_17101(next.Kind())))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,16691,17163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,17136,17148);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,16691,17163);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,17179,17441) || true) && (token.IsKind(SyntaxKind.GreaterThanToken)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 17183, 17276)&&f_10810_17228_17276(token.Parent, SyntaxKind.TypeArgumentList)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,17179,17441);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,17310,17426) || true) && (!f_10810_17315_17353(next.Kind()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,17310,17426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,17395,17407);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,17310,17426);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,17179,17441);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,17457,17682) || true) && (token.IsKind(SyntaxKind.CommaToken)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 17461, 17552)&&                !next.IsKind(SyntaxKind.CommaToken))&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 17461, 17621)&&                !f_10810_17574_17621(token.Parent, SyntaxKind.EnumDeclaration)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,17457,17682);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,17655,17667);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,17457,17682);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,17698,17913) || true) && (token.Kind()== SyntaxKind.SemicolonToken
&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 17702, 17852)&&!(next.Kind()== SyntaxKind.SemicolonToken ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 17766, 17851)||next.Kind()== SyntaxKind.CloseParenToken))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,17698,17913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,17886,17898);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,17698,17913);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,17929,18215) || true) && (token.IsKind(SyntaxKind.QuestionToken)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 17933, 18077)&&(f_10810_17993_18046(token.Parent, SyntaxKind.ConditionalExpression)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 17993, 18076)||token.Parent is TypeSyntax))
)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 17933, 18154)&&!f_10810_18099_18154(f_10810_18099_18118(token.Parent), SyntaxKind.TypeArgumentList)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,17929,18215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,18188,18200);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,17929,18215);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,18231,18385) || true) && (token.IsKind(SyntaxKind.ColonToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,18231,18385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,18304,18370);

return !f_10810_18312_18369(token.Parent, SyntaxKind.InterpolationFormatClause);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,18231,18385);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,18401,18689) || true) && (next.IsKind(SyntaxKind.ColonToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,18401,18689);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,18473,18674) || true) && (f_10810_18477_18516(next.Parent, SyntaxKind.BaseList)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 18477, 18601)||f_10810_18541_18601(                    next.Parent, SyntaxKind.TypeParameterConstraintClause)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,18473,18674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,18643,18655);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,18473,18674);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,18401,18689);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,18705,18835) || true) && (token.IsKind(SyntaxKind.CloseBracketToken)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 18709, 18774)&&f_10810_18755_18774(next.Kind())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,18705,18835);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,18808,18820);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,18705,18835);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,18943,19124) || true) && (token.IsKind(SyntaxKind.CloseParenToken)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 18947, 19010)&&f_10810_18991_19010(next.Kind()))&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 18947, 19063)&&f_10810_19014_19055(token.Parent, SyntaxKind.TupleType)== true))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,18943,19124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,19097,19109);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,18943,19124);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,19140,19357) || true) && ((next.IsKind(SyntaxKind.QuestionToken)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 19145, 19220)||next.IsKind(SyntaxKind.ColonToken)))
&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19144, 19296)&&(f_10810_19243_19295(next.Parent, SyntaxKind.ConditionalExpression))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,19140,19357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,19330,19342);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,19140,19357);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,19373,19513) || true) && (token.IsKind(SyntaxKind.EqualsToken)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 19377, 19452)||next.IsKind(SyntaxKind.EqualsToken)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,19373,19513);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,19486,19498);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,19373,19513);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,19529,19691) || true) && (token.IsKind(SyntaxKind.EqualsGreaterThanToken)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 19533, 19630)||next.IsKind(SyntaxKind.EqualsGreaterThanToken)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,19529,19691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,19664,19676);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,19529,19691);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,19770,19908) || true) && (f_10810_19774_19809(token.Kind())&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19774, 19847)&&f_10810_19813_19847(next.Kind())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,19770,19908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,19881,19893);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,19770,19908);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,19924,20848) || true) && (f_10810_19928_19951(token.Kind()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,19924,20848);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,19985,20833) || true) && (!next.IsKind(SyntaxKind.ColonToken)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19989, 20082)&&                    !next.IsKind(SyntaxKind.DotToken))&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19989, 20145)&&                    !next.IsKind(SyntaxKind.QuestionToken))&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19989, 20209)&&                    !next.IsKind(SyntaxKind.SemicolonToken))&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19989, 20275)&&                    !next.IsKind(SyntaxKind.OpenBracketToken))&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19989, 20439)&&                    (!next.IsKind(SyntaxKind.OpenParenToken)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 20301, 20394)||f_10810_20344_20394(token.Kind()))||(DynAbs.Tracing.TraceSender.Expression_False(10810, 20301, 20438)||f_10810_20398_20438(next.Parent, SyntaxKind.TupleType))) )&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19989, 20504)&&                    !next.IsKind(SyntaxKind.CloseParenToken))&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19989, 20569)&&                    !next.IsKind(SyntaxKind.CloseBraceToken))&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19989, 20634)&&                    !next.IsKind(SyntaxKind.ColonColonToken))&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19989, 20700)&&                    !next.IsKind(SyntaxKind.GreaterThanToken))&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 19989, 20760)&&                    !next.IsKind(SyntaxKind.CommaToken)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,19985,20833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,20802,20814);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,19985,20833);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,19924,20848);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,20864,21341) || true) && (f_10810_20868_20888(token.Kind())&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 20868, 20911)&&f_10810_20892_20911(next.Kind())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,20864,21341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,20945,20957);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,20864,21341);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,20864,21341);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,20991,21341) || true) && (token.Width > 1 &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 20995, 21028)&&next.Width > 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,20991,21341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,21062,21100);

var 
tokenLastChar = f_10810_21082_21099(token.Text)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,21118,21156);

var 
nextFirstChar = f_10810_21138_21155(next.Text)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,21174,21326) || true) && (tokenLastChar == nextFirstChar &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 21178, 21253)&&f_10810_21212_21253(tokenLastChar)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,21174,21326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,21295,21307);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,21174,21326);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,20991,21341);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,20864,21341);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,21357,21370);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,15575,21381);

bool
f_10810_15800_15856(Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = IsAccessorListWithoutAccessorsWithBlockBody( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 15800, 15856);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_10810_15921_15939(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 15921, 15939);
return return_v;
}


bool
f_10810_15877_15940(Microsoft.CodeAnalysis.SyntaxNode?
node)
{
var return_v = IsAccessorListWithoutAccessorsWithBlockBody( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 15877, 15940);
return return_v;
}


bool
f_10810_16220_16248(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = IsXmlTextToken( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 16220, 16248);
return return_v;
}


bool
f_10810_16252_16279(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = IsXmlTextToken( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 16252, 16279);
return return_v;
}


bool
f_10810_16611_16634(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = IsKeyword( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 16611, 16634);
return return_v;
}


bool
f_10810_16742_16785(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = AssignmentTokenNeedsSeparator( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 16742, 16785);
return return_v;
}


bool
f_10810_16853_16895(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = AssignmentTokenNeedsSeparator( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 16853, 16895);
return return_v;
}


bool
f_10810_16960_16999(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = BinaryTokenNeedsSeparator( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 16960, 16999);
return return_v;
}


bool
f_10810_17063_17101(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = BinaryTokenNeedsSeparator( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 17063, 17101);
return return_v;
}


bool
f_10810_17228_17276(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 17228, 17276);
return return_v;
}


bool
f_10810_17315_17353(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.IsPunctuation( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 17315, 17353);
return return_v;
}


bool
f_10810_17574_17621(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 17574, 17621);
return return_v;
}


bool
f_10810_17993_18046(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 17993, 18046);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_10810_18099_18118(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 18099, 18118);
return return_v;
}


bool
f_10810_18099_18154(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 18099, 18154);
return return_v;
}


bool
f_10810_18312_18369(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 18312, 18369);
return return_v;
}


bool
f_10810_18477_18516(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 18477, 18516);
return return_v;
}


bool
f_10810_18541_18601(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 18541, 18601);
return return_v;
}


bool
f_10810_18755_18774(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = IsWord( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 18755, 18774);
return return_v;
}


bool
f_10810_18991_19010(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = IsWord( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 18991, 19010);
return return_v;
}


bool
f_10810_19014_19055(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 19014, 19055);
return return_v;
}


bool
f_10810_19243_19295(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 19243, 19295);
return return_v;
}


bool
f_10810_19774_19809(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.IsLiteral( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 19774, 19809);
return return_v;
}


bool
f_10810_19813_19847(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.IsLiteral( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 19813, 19847);
return return_v;
}


bool
f_10810_19928_19951(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = IsKeyword( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 19928, 19951);
return return_v;
}


bool
f_10810_20344_20394(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = KeywordNeedsSeparatorBeforeOpenParen( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 20344, 20394);
return return_v;
}


bool
f_10810_20398_20438(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 20398, 20438);
return return_v;
}


bool
f_10810_20868_20888(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = IsWord( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 20868, 20888);
return return_v;
}


bool
f_10810_20892_20911(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = IsWord( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 20892, 20911);
return return_v;
}


char
f_10810_21082_21099(string
arg)
{
var return_v = arg.Last();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 21082, 21099);
return return_v;
}


char
f_10810_21138_21155(string
arg)
{
var return_v = arg.First();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 21138, 21155);
return return_v;
}


bool
f_10810_21212_21253(char
c)
{
var return_v = TokenCharacterCanBeDoubled( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 21212, 21253);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,15575,21381);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,15575,21381);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool KeywordNeedsSeparatorBeforeOpenParen(SyntaxKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,21393,22071);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,21491,22060);

switch (kind)
            {

case SyntaxKind.TypeOfKeyword:
                case SyntaxKind.DefaultKeyword:
                case SyntaxKind.NewKeyword:
                case SyntaxKind.BaseKeyword:
                case SyntaxKind.ThisKeyword:
                case SyntaxKind.CheckedKeyword:
                case SyntaxKind.UncheckedKeyword:
                case SyntaxKind.SizeOfKeyword:
                case SyntaxKind.ArgListKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,21491,22060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,21972,21985);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,21491,22060);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,21491,22060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,22033,22045);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,21491,22060);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,21393,22071);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,21393,22071);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,21393,22071);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsXmlTextToken(SyntaxKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,22083,22423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,22159,22412);

switch (kind)
            {

case SyntaxKind.XmlTextLiteralNewLineToken:
                case SyntaxKind.XmlTextLiteralToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,22159,22412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,22324,22336);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,22159,22412);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,22159,22412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,22384,22397);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,22159,22412);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,22083,22423);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,22083,22423);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,22083,22423);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool BinaryTokenNeedsSeparator(SyntaxKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,22435,22822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,22522,22811);

switch (kind)
            {

case SyntaxKind.DotToken:
                case SyntaxKind.MinusGreaterThanToken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,22522,22811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,22671,22684);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,22522,22811);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,22522,22811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,22732,22796);

return f_10810_22739_22776(kind)!= SyntaxKind.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,22522,22811);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,22435,22822);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10810_22739_22776(Microsoft.CodeAnalysis.CSharp.SyntaxKind
token)
{
var return_v = SyntaxFacts.GetBinaryExpression( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 22739, 22776);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,22435,22822);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,22435,22822);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool AssignmentTokenNeedsSeparator(SyntaxKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,22834,23004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,22925,22993);

return f_10810_22932_22973(kind)!= SyntaxKind.None;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,22834,23004);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10810_22932_22973(Microsoft.CodeAnalysis.CSharp.SyntaxKind
token)
{
var return_v = SyntaxFacts.GetAssignmentExpression( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 22932, 22973);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,22834,23004);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,22834,23004);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SyntaxTriviaList RewriteTrivia(
            SyntaxTriviaList triviaList,
            int depth,
            bool isTrailing,
            bool indentAfterLineBreak,
            bool mustHaveSeparator,
            int lineBreaksAfter)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10810,23016,27788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,23287,23391);

ArrayBuilder<SyntaxTrivia> 
currentTriviaList = f_10810_23334_23390(triviaList.Count)
;
            try
            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,23441,26163);
foreach(var trivia in f_10810_23464_23474_I(triviaList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,23441,26163);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,23516,23764) || true) && (trivia.IsKind(SyntaxKind.WhitespaceTrivia)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 23520, 23632)||                        trivia.IsKind(SyntaxKind.EndOfLineTrivia))||(DynAbs.Tracing.TraceSender.Expression_False(10810, 23520, 23682)||                        trivia.FullWidth == 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,23516,23764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,23732,23741);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,23516,23764);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,23788,23992);

var 
needsSeparator =
                        (f_10810_23835_23858(currentTriviaList)> 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 23835, 23913)&&f_10810_23866_23913(f_10810_23888_23912(currentTriviaList)))) ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 23834, 23991)||                            (f_10810_23948_23971(currentTriviaList)== 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 23948, 23990)&&isTrailing)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,24016,24207);

var 
needsLineBreak = f_10810_24037_24077(trivia, isTrailing)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 24037, 24206)||(f_10810_24107_24130(currentTriviaList)> 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 24107, 24205)&&f_10810_24138_24205(f_10810_24160_24184(currentTriviaList), trivia, isTrailing))))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,24231,24481) || true) && (needsLineBreak &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 24235, 24269)&&!_afterLineBreak))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,24231,24481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,24319,24357);

f_10810_24319_24356(                        currentTriviaList, f_10810_24341_24355(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,24383,24406);

_afterLineBreak = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,24432,24458);

_afterIndentation = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,24231,24481);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,24505,25122) || true) && (_afterLineBreak)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,24505,25122);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,24574,24845) || true) && (!_afterIndentation &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 24578, 24633)&&f_10810_24600_24633(trivia)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,24574,24845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,24691,24763);

f_10810_24691_24762(                            currentTriviaList, f_10810_24713_24761(this, f_10810_24733_24760(trivia)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,24793,24818);

_afterIndentation = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,24574,24845);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,24505,25122);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,24505,25122);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,24895,25122) || true) && (needsSeparator)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,24895,25122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,24963,24997);

f_10810_24963_24996(                        currentTriviaList, f_10810_24985_24995(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,25023,25047);

_afterLineBreak = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,25073,25099);

_afterIndentation = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,24895,25122);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,24505,25122);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,25146,25760) || true) && (trivia.HasStructure)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,25146,25760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,25219,25263);

var 
tr = f_10810_25228_25262(this, trivia)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,25289,25315);

f_10810_25289_25314(                        currentTriviaList, tr);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,25146,25760);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,25146,25760);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,25365,25760) || true) && (trivia.IsKind(SyntaxKind.DocumentationCommentExteriorTrivia))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,25365,25760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,25558,25609);

f_10810_25558_25608(                        // recreate exterior to remove any leading whitespace
                        currentTriviaList, s_trimmedDocCommentExterior);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,25365,25760);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,25365,25760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,25707,25737);

f_10810_25707_25736(                        currentTriviaList, trivia);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,25365,25760);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,25146,25760);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,25784,26144) || true) && (f_10810_25788_25827(trivia, isTrailing)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 25788, 25932)&&(f_10810_25857_25880(currentTriviaList)== 0 ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 25857, 25931)||!f_10810_25890_25931(f_10810_25906_25930(currentTriviaList))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,25784,26144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,25982,26020);

f_10810_25982_26019(                        currentTriviaList, f_10810_26004_26018(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26046,26069);

_afterLineBreak = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26095,26121);

_afterIndentation = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,25784,26144);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,23441,26163);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10810,1,2723);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10810,1,2723);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26183,27214) || true) && (lineBreaksAfter > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,26183,27214);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26248,26440) || true) && (f_10810_26252_26275(currentTriviaList)> 0
&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 26252, 26349)&&f_10810_26308_26349(f_10810_26324_26348(currentTriviaList))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,26248,26440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26399,26417);

lineBreaksAfter--;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,26248,26440);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26473,26478);

                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26464,26716) || true) && (i < lineBreaksAfter)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26501,26504)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10810,26464,26716))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,26464,26716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26554,26592);

f_10810_26554_26591(                        currentTriviaList, f_10810_26576_26590(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26618,26641);

_afterLineBreak = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26667,26693);

_afterIndentation = false;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10810,1,253);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10810,1,253);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10810,26183,27214);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,26183,27214);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26758,27214) || true) && (indentAfterLineBreak &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 26762, 26801)&&_afterLineBreak )&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 26762, 26823)&&!_afterIndentation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,26758,27214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26865,26915);

f_10810_26865_26914(                    currentTriviaList, f_10810_26887_26913(this, depth));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,26937,26962);

_afterIndentation = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,26758,27214);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,26758,27214);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27004,27214) || true) && (mustHaveSeparator)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,27004,27214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27067,27101);

f_10810_27067_27100(                    currentTriviaList, f_10810_27089_27099(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27123,27147);

_afterLineBreak = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27169,27195);

_afterIndentation = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,27004,27214);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,26758,27214);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,26183,27214);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27234,27668) || true) && (f_10810_27238_27261(currentTriviaList)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,27234,27668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27308,27341);

return default(SyntaxTriviaList);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,27234,27668);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,27234,27668);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27383,27668) || true) && (f_10810_27387_27410(currentTriviaList)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,27383,27668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27457,27516);

return f_10810_27464_27515(f_10810_27489_27514(currentTriviaList));
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,27383,27668);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,27383,27668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27598,27649);

return f_10810_27605_27648(currentTriviaList);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,27383,27668);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,27234,27668);
}
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(10810,27697,27777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27737,27762);

f_10810_27737_27761(                currentTriviaList);
DynAbs.Tracing.TraceSender.TraceExitFinally(10810,27697,27777);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10810,23016,27788);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
f_10810_23334_23390(int
capacity)
{
var return_v = ArrayBuilder<SyntaxTrivia>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 23334, 23390);
return return_v;
}


int
f_10810_23835_23858(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 23835, 23858);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_23888_23912(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Last();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 23888, 23912);
return return_v;
}


bool
f_10810_23866_23913(Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = NeedsSeparatorBetween( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 23866, 23913);
return return_v;
}


int
f_10810_23948_23971(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 23948, 23971);
return return_v;
}


bool
f_10810_24037_24077(Microsoft.CodeAnalysis.SyntaxTrivia
trivia,bool
isTrailingTrivia)
{
var return_v = NeedsLineBreakBefore( trivia, isTrailingTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 24037, 24077);
return return_v;
}


int
f_10810_24107_24130(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 24107, 24130);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_24160_24184(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Last();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 24160, 24184);
return return_v;
}


bool
f_10810_24138_24205(Microsoft.CodeAnalysis.SyntaxTrivia
trivia,Microsoft.CodeAnalysis.SyntaxTrivia
next,bool
isTrailingTrivia)
{
var return_v = NeedsLineBreakBetween( trivia, next, isTrailingTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 24138, 24205);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_24341_24355(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param)
{
var return_v = this_param.GetEndOfLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 24341, 24355);
return return_v;
}


int
f_10810_24319_24356(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 24319, 24356);
return 0;
}


bool
f_10810_24600_24633(Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = NeedsIndentAfterLineBreak( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 24600, 24633);
return return_v;
}


int
f_10810_24733_24760(Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = GetDeclarationDepth( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 24733, 24760);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_24713_24761(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param,int
count)
{
var return_v = this_param.GetIndentation( count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 24713, 24761);
return return_v;
}


int
f_10810_24691_24762(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 24691, 24762);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_24985_24995(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param)
{
var return_v = this_param.GetSpace();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 24985, 24995);
return return_v;
}


int
f_10810_24963_24996(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 24963, 24996);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_25228_25262(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = this_param.VisitStructuredTrivia( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 25228, 25262);
return return_v;
}


int
f_10810_25289_25314(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 25289, 25314);
return 0;
}


int
f_10810_25558_25608(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 25558, 25608);
return 0;
}


int
f_10810_25707_25736(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 25707, 25736);
return 0;
}


bool
f_10810_25788_25827(Microsoft.CodeAnalysis.SyntaxTrivia
trivia,bool
isTrailingTrivia)
{
var return_v = NeedsLineBreakAfter( trivia, isTrailingTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 25788, 25827);
return return_v;
}


int
f_10810_25857_25880(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 25857, 25880);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_25906_25930(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Last();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 25906, 25930);
return return_v;
}


bool
f_10810_25890_25931(Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = EndsInLineBreak( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 25890, 25931);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_26004_26018(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param)
{
var return_v = this_param.GetEndOfLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 26004, 26018);
return return_v;
}


int
f_10810_25982_26019(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 25982, 26019);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTriviaList
f_10810_23464_23474_I(Microsoft.CodeAnalysis.SyntaxTriviaList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 23464, 23474);
return return_v;
}


int
f_10810_26252_26275(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 26252, 26275);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_26324_26348(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Last();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 26324, 26348);
return return_v;
}


bool
f_10810_26308_26349(Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = EndsInLineBreak( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 26308, 26349);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_26576_26590(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param)
{
var return_v = this_param.GetEndOfLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 26576, 26590);
return return_v;
}


int
f_10810_26554_26591(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 26554, 26591);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_26887_26913(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param,int
count)
{
var return_v = this_param.GetIndentation( count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 26887, 26913);
return return_v;
}


int
f_10810_26865_26914(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 26865, 26914);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_27089_27099(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param)
{
var return_v = this_param.GetSpace();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 27089, 27099);
return return_v;
}


int
f_10810_27067_27100(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 27067, 27100);
return 0;
}


int
f_10810_27238_27261(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 27238, 27261);
return return_v;
}


int
f_10810_27387_27410(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 27387, 27410);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_27489_27514(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
var return_v = this_param.First();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 27489, 27514);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTriviaList
f_10810_27464_27515(Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = SyntaxFactory.TriviaList( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 27464, 27515);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTriviaList
f_10810_27605_27648(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
trivias)
{
var return_v = SyntaxFactory.TriviaList( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>)trivias);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 27605, 27648);
return return_v;
}


int
f_10810_27737_27761(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTrivia>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 27737, 27761);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,23016,27788);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,23016,27788);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static readonly SyntaxTrivia s_trimmedDocCommentExterior ;

private SyntaxTrivia GetSpace()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10810,27929,28072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27985,28061);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10810, 27992, 28009)||((_useElasticTrivia &&DynAbs.Tracing.TraceSender.Conditional_F2(10810, 28012, 28038))||DynAbs.Tracing.TraceSender.Conditional_F3(10810, 28041, 28060)))?f_10810_28012_28038():f_10810_28041_28060();
DynAbs.Tracing.TraceSender.TraceExitMethod(10810,27929,28072);

Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_28012_28038()
{
var return_v = SyntaxFactory.ElasticSpace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 28012, 28038);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_28041_28060()
{
var return_v = SyntaxFactory.Space;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 28041, 28060);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,27929,28072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,27929,28072);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SyntaxTrivia GetEndOfLine()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10810,28084,28173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,28144,28162);

return _eolTrivia;
DynAbs.Tracing.TraceSender.TraceExitMethod(10810,28084,28173);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,28084,28173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,28084,28173);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SyntaxTrivia VisitStructuredTrivia(SyntaxTrivia trivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10810,28185,28694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,28273,28326);

bool 
oldIsInStructuredTrivia = _isInStructuredTrivia
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,28340,28369);

_isInStructuredTrivia = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,28385,28431);

SyntaxToken 
oldPreviousToken = _previousToken
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,28445,28483);

_previousToken = default(SyntaxToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,28499,28541);

SyntaxTrivia 
result = f_10810_28521_28540(this, trivia)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,28557,28605);

_isInStructuredTrivia = oldIsInStructuredTrivia;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,28619,28653);

_previousToken = oldPreviousToken;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,28669,28683);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10810,28185,28694);

Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_28521_28540(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNormalizer
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = this_param.VisitTrivia( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 28521, 28540);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,28185,28694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,28185,28694);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool NeedsSeparatorBetween(SyntaxTrivia trivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,28706,29157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,28793,29146);

switch (trivia.Kind())
            {

case SyntaxKind.None:
                case SyntaxKind.WhitespaceTrivia:
                case SyntaxKind.DocumentationCommentExteriorTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,28793,29146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,29011,29024);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,28793,29146);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,28793,29146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,29072,29131);

return !f_10810_29080_29130(trivia.Kind());
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,28793,29146);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,28706,29157);

bool
f_10810_29080_29130(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.IsPreprocessorDirective( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 29080, 29130);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,28706,29157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,28706,29157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool NeedsLineBreakBetween(SyntaxTrivia trivia, SyntaxTrivia next, bool isTrailingTrivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,29169,29427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,29298,29416);

return f_10810_29305_29350(trivia, isTrailingTrivia)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 29305, 29415)||f_10810_29371_29415(next, isTrailingTrivia));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,29169,29427);

bool
f_10810_29305_29350(Microsoft.CodeAnalysis.SyntaxTrivia
trivia,bool
isTrailingTrivia)
{
var return_v = NeedsLineBreakAfter( trivia, isTrailingTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 29305, 29350);
return return_v;
}


bool
f_10810_29371_29415(Microsoft.CodeAnalysis.SyntaxTrivia
trivia,bool
isTrailingTrivia)
{
var return_v = NeedsLineBreakBefore( trivia, isTrailingTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 29371, 29415);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,29169,29427);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,29169,29427);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool NeedsLineBreakBefore(SyntaxTrivia trivia, bool isTrailingTrivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,29439,29854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,29548,29573);

var 
kind = trivia.Kind()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,29587,29843);

switch (kind)
            {

case SyntaxKind.DocumentationCommentExteriorTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,29587,29843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,29706,29731);

return !isTrailingTrivia;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,29587,29843);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,29587,29843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,29779,29828);

return f_10810_29786_29827(kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,29587,29843);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,29439,29854);

bool
f_10810_29786_29827(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.IsPreprocessorDirective( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 29786, 29827);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,29439,29854);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,29439,29854);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool NeedsLineBreakAfter(SyntaxTrivia trivia, bool isTrailingTrivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,29866,30360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,29974,29999);

var 
kind = trivia.Kind()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,30013,30349);

switch (kind)
            {

case SyntaxKind.SingleLineCommentTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,30013,30349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,30121,30133);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,30013,30349);

case SyntaxKind.MultiLineCommentTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,30013,30349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,30212,30237);

return !isTrailingTrivia;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,30013,30349);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,30013,30349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,30285,30334);

return f_10810_30292_30333(kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,30013,30349);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,29866,30360);

bool
f_10810_30292_30333(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.IsPreprocessorDirective( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 30292, 30333);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,29866,30360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,29866,30360);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool NeedsIndentAfterLineBreak(SyntaxTrivia trivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,30372,30946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,30463,30935);

switch (trivia.Kind())
            {

case SyntaxKind.SingleLineCommentTrivia:
                case SyntaxKind.MultiLineCommentTrivia:
                case SyntaxKind.DocumentationCommentExteriorTrivia:
                case SyntaxKind.SingleLineDocumentationCommentTrivia:
                case SyntaxKind.MultiLineDocumentationCommentTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,30463,30935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,30847,30859);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,30463,30935);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,30463,30935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,30907,30920);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,30463,30935);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,30372,30946);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,30372,30946);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,30372,30946);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsLineBreak(SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,30958,31105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31033,31094);

return token.Kind()== SyntaxKind.XmlTextLiteralNewLineToken;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,30958,31105);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,30958,31105);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,30958,31105);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool EndsInLineBreak(SyntaxTrivia trivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,31117,32074);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31198,31306) || true) && (trivia.Kind()== SyntaxKind.EndOfLineTrivia)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,31198,31306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31279,31291);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,31198,31306);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31322,31591) || true) && (trivia.Kind()== SyntaxKind.PreprocessingMessageTrivia ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 31326, 31430)||trivia.Kind()== SyntaxKind.DisabledTextTrivia))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,31322,31591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31464,31497);

var 
text = trivia.ToFullString()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31515,31576);

return f_10810_31522_31533(text)> 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 31522, 31575)&&f_10810_31541_31575(f_10810_31563_31574(text)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,31322,31591);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31607,32034) || true) && (trivia.HasStructure)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,31607,32034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31664,31698);

var 
node = trivia.GetStructure()!
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31716,31756);

var 
trailing = f_10810_31731_31755(node)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31774,32019) || true) && (trailing.Count > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,31774,32019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31838,31878);

return f_10810_31845_31877(trailing.Last());
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,31774,32019);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,31774,32019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,31960,32000);

return f_10810_31967_31999(f_10810_31979_31998(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,31774,32019);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,31607,32034);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,32050,32063);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,31117,32074);

int
f_10810_31522_31533(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 31522, 31533);
return return_v;
}


char
f_10810_31563_31574(string
arg)
{
var return_v = arg.Last();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 31563, 31574);
return return_v;
}


bool
f_10810_31541_31575(char
ch)
{
var return_v = SyntaxFacts.IsNewLine( ch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 31541, 31575);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTriviaList
f_10810_31731_31755(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.GetTrailingTrivia();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 31731, 31755);
return return_v;
}


bool
f_10810_31845_31877(Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = EndsInLineBreak( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 31845, 31877);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10810_31979_31998(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.GetLastToken();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 31979, 31998);
return return_v;
}


bool
f_10810_31967_31999(Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = IsLineBreak( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 31967, 31999);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,31117,32074);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,31117,32074);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsWord(SyntaxKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,32086,32226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,32154,32215);

return kind == SyntaxKind.IdentifierToken ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 32161, 32214)||f_10810_32199_32214(kind));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,32086,32226);

bool
f_10810_32199_32214(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = IsKeyword( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 32199, 32214);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,32086,32226);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,32086,32226);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsKeyword(SyntaxKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,32238,32402);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,32309,32391);

return f_10810_32316_32347(kind)||(DynAbs.Tracing.TraceSender.Expression_False(10810, 32316, 32390)||f_10810_32351_32390(kind));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,32238,32402);

bool
f_10810_32316_32347(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.IsKeywordKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 32316, 32347);
return return_v;
}


bool
f_10810_32351_32390(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.IsPreprocessorKeyword( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 32351, 32390);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,32238,32402);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,32238,32402);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool TokenCharacterCanBeDoubled(char c)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,32414,32828);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,32493,32817);

switch (c)
            {

case '+':
                case '-':
                case '<':
                case ':':
                case '?':
                case '=':
                case '"':
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,32493,32817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,32729,32741);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,32493,32817);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,32493,32817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,32789,32802);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,32493,32817);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,32414,32828);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,32414,32828);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,32414,32828);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int GetDeclarationDepth(SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,32840,32974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,32922,32963);

return f_10810_32929_32962(token.Parent);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,32840,32974);

int
f_10810_32929_32962(Microsoft.CodeAnalysis.SyntaxNode?
node)
{
var return_v = GetDeclarationDepth( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 32929, 32962);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,32840,32974);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,32840,32974);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int GetDeclarationDepth(SyntaxTrivia trivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,32986,33263);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33070,33182) || true) && (f_10810_33074_33124(trivia.Kind()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,33070,33182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33158,33167);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,33070,33182);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33198,33252);

return f_10810_33205_33251(trivia.Token);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,32986,33263);

bool
f_10810_33074_33124(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.IsPreprocessorDirective( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 33074, 33124);
return return_v;
}


int
f_10810_33205_33251(Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = GetDeclarationDepth( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 33205, 33251);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,32986,33263);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,32986,33263);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int GetDeclarationDepth(SyntaxNode? node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10810,33275,35260);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33356,35224) || true) && (node != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,33356,35224);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33406,35209) || true) && (f_10810_33410_33433(node))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,33406,35209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33475,33528);

var 
tr = f_10810_33484_33527(((StructuredTriviaSyntax)node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33550,33581);

return f_10810_33557_33580(tr);
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,33406,35209);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,33406,35209);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33623,35209) || true) && (f_10810_33627_33638(node)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,33623,35209);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33688,33820) || true) && (f_10810_33692_33738(f_10810_33692_33703(node), SyntaxKind.CompilationUnit))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,33688,33820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33788,33797);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,33688,33820);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33844,33895);

int 
parentDepth = f_10810_33862_33894(f_10810_33882_33893(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,33919,34061) || true) && (f_10810_33923_33969(f_10810_33923_33934(node), SyntaxKind.GlobalStatement))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,33919,34061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,34019,34038);

return parentDepth;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,33919,34061);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,34085,34261) || true) && (f_10810_34089_34124(node, SyntaxKind.IfStatement)&&(DynAbs.Tracing.TraceSender.Expression_True(10810, 34089, 34169)&&f_10810_34128_34169(f_10810_34128_34139(node), SyntaxKind.ElseClause)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,34085,34261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,34219,34238);

return parentDepth;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,34085,34261);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,34285,34564) || true) && (f_10810_34289_34300(node)is BlockSyntax ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 34289, 34395)||                        (node is StatementSyntax &&(DynAbs.Tracing.TraceSender.Expression_True(10810, 34345, 34394)&&!(node is BlockSyntax)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,34285,34564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,34518,34541);

return parentDepth + 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,34285,34564);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,34588,35147) || true) && (node is MemberDeclarationSyntax ||(DynAbs.Tracing.TraceSender.Expression_False(10810, 34592, 34685)||                        node is AccessorDeclarationSyntax )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 34592, 34757)||                        node is TypeParameterConstraintClauseSyntax )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 34592, 34813)||                        node is SwitchSectionSyntax )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 34592, 34870)||                        node is UsingDirectiveSyntax )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 34592, 34933)||                        node is ExternAliasDirectiveSyntax )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 34592, 34991)||                        node is QueryExpressionSyntax )||(DynAbs.Tracing.TraceSender.Expression_False(10810, 34592, 35051)||                        node is QueryContinuationSyntax))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10810,34588,35147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,35101,35124);

return parentDepth + 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,34588,35147);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,35171,35190);

return parentDepth;
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,33623,35209);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,33406,35209);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10810,33356,35224);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,35240,35249);

return 0;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10810,33275,35260);

bool
f_10810_33410_33433(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.IsStructuredTrivia;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 33410, 33433);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_33484_33527(Microsoft.CodeAnalysis.CSharp.Syntax.StructuredTriviaSyntax
this_param)
{
var return_v = this_param.ParentTrivia;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 33484, 33527);
return return_v;
}


int
f_10810_33557_33580(Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = GetDeclarationDepth( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 33557, 33580);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_10810_33627_33638(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 33627, 33638);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10810_33692_33703(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 33692, 33703);
return return_v;
}


bool
f_10810_33692_33738(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 33692, 33738);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10810_33882_33893(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 33882, 33893);
return return_v;
}


int
f_10810_33862_33894(Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = GetDeclarationDepth( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 33862, 33894);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10810_33923_33934(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 33923, 33934);
return return_v;
}


bool
f_10810_33923_33969(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 33923, 33969);
return return_v;
}


bool
f_10810_34089_34124(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 34089, 34124);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10810_34128_34139(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 34128, 34139);
return return_v;
}


bool
f_10810_34128_34169(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 34128, 34169);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10810_34289_34300(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10810, 34289, 34300);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10810,33275,35260);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,33275,35260);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SyntaxNormalizer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10810,544,35267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10810,27837,27916);
s_trimmedDocCommentExterior = f_10810_27867_27916("///");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10810,544,35267);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10810,544,35267);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10810,544,35267);

Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_1728_1773(string
text)
{
var return_v = SyntaxFactory.ElasticEndOfLine( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 1728, 1773);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_1776_1814(string
text)
{
var return_v = SyntaxFactory.EndOfLine( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 1776, 1814);
return return_v;
}


static bool
f_10810_1447_1478_C(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10810, 1289, 1863);
return return_v;
}


static Microsoft.CodeAnalysis.SyntaxTrivia
f_10810_27867_27916(string
text)
{
var return_v = SyntaxFactory.DocumentationCommentExterior( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10810, 27867, 27916);
return return_v;
}

}
}
