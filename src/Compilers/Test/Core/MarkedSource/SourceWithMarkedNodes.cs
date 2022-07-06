// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Xunit;

namespace Roslyn.Test.Utilities
{
internal sealed partial class SourceWithMarkedNodes
{
public readonly string Source;

public readonly string Input;

public readonly SyntaxTree Tree;

public readonly ImmutableArray<MarkedSpan> MarkedSpans;

public readonly ImmutableArray<ValueTuple<TextSpan, int, int>> SpansAndKindsAndIds;

public SourceWithMarkedNodes(string markedSource, Func<string, SyntaxTree> parser, Func<string, int> getSyntaxKind, bool removeTags = false)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25099,1706,2260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,721,727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,869,874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,912,916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,1871,1944);

Source = (DynAbs.Tracing.TraceSender.Conditional_F1(25099, 1880, 1890)||((removeTags &&DynAbs.Tracing.TraceSender.Conditional_F2(25099, 1893, 1917))||DynAbs.Tracing.TraceSender.Conditional_F3(25099, 1920, 1943)))?f_25099_1893_1917(markedSource):f_25099_1920_1943(markedSource);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,1958,1979);

Input = markedSource;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,1993,2015);

Tree = f_25099_2000_2014(parser, Source);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,2031,2123);

MarkedSpans = f_25099_2045_2122(f_25099_2072_2121(markedSource, 0, getSyntaxKind));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,2137,2249);

SpansAndKindsAndIds = f_25099_2159_2248(MarkedSpans.Select(s => (s.MarkedSyntax, s.SyntaxKind, s.Id)));
DynAbs.Tracing.TraceSender.TraceExitConstructor(25099,1706,2260);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25099,1706,2260);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25099,1706,2260);
}
		}

private static IEnumerable<MarkedSpan> GetSpansRecursive(string markedSource, int offset, Func<string, int> getSyntaxKind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25099,2272,3578);

var listYield= new List<MarkedSpan>();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,2419,3567);
foreach(var match in f_25099_2441_2493_I(f_25099_2441_2493(f_25099_2441_2478(s_markerPattern, markedSource))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25099,2419,3567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,2527,2565);

var 
tagName = f_25099_2541_2564(f_25099_2541_2553(match), "TagName")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,2583,2631);

var 
markedSyntax = f_25099_2602_2630(f_25099_2602_2614(match), "MarkedSyntax")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,2649,2702);

var 
syntaxKindOpt = f_25099_2669_2701(f_25099_2669_2695(f_25099_2669_2681(match), "SyntaxKind"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,2720,2757);

var 
idOpt = f_25099_2732_2756(f_25099_2732_2750(f_25099_2732_2744(match), "Id"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,2775,2835);

var 
id = (DynAbs.Tracing.TraceSender.Conditional_F1(25099, 2784, 2811)||((f_25099_2784_2811(idOpt)&&DynAbs.Tracing.TraceSender.Conditional_F2(25099, 2814, 2815))||DynAbs.Tracing.TraceSender.Conditional_F3(25099, 2818, 2834)))?0 :f_25099_2818_2834(idOpt)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,2853,2902);

var 
parentIdOpt = f_25099_2871_2901(f_25099_2871_2895(f_25099_2871_2883(match), "ParentId"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,2920,2998);

var 
parentId = (DynAbs.Tracing.TraceSender.Conditional_F1(25099, 2935, 2968)||((f_25099_2935_2968(parentIdOpt)&&DynAbs.Tracing.TraceSender.Conditional_F2(25099, 2971, 2972))||DynAbs.Tracing.TraceSender.Conditional_F3(25099, 2975, 2997)))?0 :f_25099_2975_2997(parentIdOpt)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,3016,3104);

var 
parsedKind = (DynAbs.Tracing.TraceSender.Conditional_F1(25099, 3033, 3068)||((f_25099_3033_3068(syntaxKindOpt)&&DynAbs.Tracing.TraceSender.Conditional_F2(25099, 3071, 3072))||DynAbs.Tracing.TraceSender.Conditional_F3(25099, 3075, 3103)))?0 :f_25099_3075_3103(getSyntaxKind, syntaxKindOpt)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,3122,3171);

int 
absoluteOffset = offset + f_25099_3152_3170(markedSyntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,3191,3352);

listYield.Add(f_25099_3204_3351(f_25099_3219_3268(absoluteOffset, f_25099_3248_3267(markedSyntax)), f_25099_3270_3309(f_25099_3283_3294(match), f_25099_3296_3308(match)), f_25099_3311_3324(tagName), parsedKind, id, parentId));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,3372,3552);
foreach(var nestedSpan in f_25099_3399_3467_I(f_25099_3399_3467(f_25099_3417_3435(markedSyntax), absoluteOffset, getSyntaxKind)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25099,3372,3552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,3509,3533);

listYield.Add(nestedSpan);
DynAbs.Tracing.TraceSender.TraceExitCondition(25099,3372,3552);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25099,1,181);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25099,1,181);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25099,2419,3567);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25099,1,1149);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25099,1,1149);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25099,2272,3578);

return listYield;

System.Text.RegularExpressions.MatchCollection
f_25099_2441_2478(System.Text.RegularExpressions.Regex
this_param,string
input)
{
var return_v = this_param.Matches( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 2441, 2478);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>
f_25099_2441_2493(System.Text.RegularExpressions.MatchCollection
collection)
{
var return_v = collection.ToEnumerable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 2441, 2493);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_25099_2541_2553(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2541, 2553);
return return_v;
}


System.Text.RegularExpressions.Group
f_25099_2541_2564(System.Text.RegularExpressions.GroupCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2541, 2564);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_25099_2602_2614(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2602, 2614);
return return_v;
}


System.Text.RegularExpressions.Group
f_25099_2602_2630(System.Text.RegularExpressions.GroupCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2602, 2630);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_25099_2669_2681(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2669, 2681);
return return_v;
}


System.Text.RegularExpressions.Group
f_25099_2669_2695(System.Text.RegularExpressions.GroupCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2669, 2695);
return return_v;
}


string
f_25099_2669_2701(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2669, 2701);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_25099_2732_2744(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2732, 2744);
return return_v;
}


System.Text.RegularExpressions.Group
f_25099_2732_2750(System.Text.RegularExpressions.GroupCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2732, 2750);
return return_v;
}


string
f_25099_2732_2756(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2732, 2756);
return return_v;
}


bool
f_25099_2784_2811(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 2784, 2811);
return return_v;
}


int
f_25099_2818_2834(string
s)
{
var return_v = int.Parse( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 2818, 2834);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_25099_2871_2883(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2871, 2883);
return return_v;
}


System.Text.RegularExpressions.Group
f_25099_2871_2895(System.Text.RegularExpressions.GroupCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2871, 2895);
return return_v;
}


string
f_25099_2871_2901(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 2871, 2901);
return return_v;
}


bool
f_25099_2935_2968(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 2935, 2968);
return return_v;
}


int
f_25099_2975_2997(string
s)
{
var return_v = int.Parse( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 2975, 2997);
return return_v;
}


bool
f_25099_3033_3068(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 3033, 3068);
return return_v;
}


int
f_25099_3075_3103(System.Func<string, int>
this_param,string
arg)
{
var return_v = this_param.Invoke( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 3075, 3103);
return return_v;
}


int
f_25099_3152_3170(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Index;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 3152, 3170);
return return_v;
}


int
f_25099_3248_3267(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 3248, 3267);
return return_v;
}


Microsoft.CodeAnalysis.Text.TextSpan
f_25099_3219_3268(int
start,int
length)
{
var return_v = new Microsoft.CodeAnalysis.Text.TextSpan( start, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 3219, 3268);
return return_v;
}


int
f_25099_3283_3294(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Index;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 3283, 3294);
return return_v;
}


int
f_25099_3296_3308(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 3296, 3308);
return return_v;
}


Microsoft.CodeAnalysis.Text.TextSpan
f_25099_3270_3309(int
start,int
length)
{
var return_v = new Microsoft.CodeAnalysis.Text.TextSpan( start, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 3270, 3309);
return return_v;
}


string
f_25099_3311_3324(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 3311, 3324);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes.MarkedSpan
f_25099_3204_3351(Microsoft.CodeAnalysis.Text.TextSpan
markedSyntax,Microsoft.CodeAnalysis.Text.TextSpan
matchedSpan,string
tagName,int
syntaxKind,int
id,int
parentId)
{
var return_v = new Roslyn.Test.Utilities.SourceWithMarkedNodes.MarkedSpan( markedSyntax, matchedSpan, tagName, syntaxKind, id, parentId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 3204, 3351);
return return_v;
}


string
f_25099_3417_3435(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25099, 3417, 3435);
return return_v;
}


System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.SourceWithMarkedNodes.MarkedSpan>
f_25099_3399_3467(string
markedSource,int
offset,System.Func<string, int>
getSyntaxKind)
{
var return_v = GetSpansRecursive( markedSource, offset, getSyntaxKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 3399, 3467);
return return_v;
}


System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.SourceWithMarkedNodes.MarkedSpan>
f_25099_3399_3467_I(System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.SourceWithMarkedNodes.MarkedSpan>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 3399, 3467);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>
f_25099_2441_2493_I(System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 2441, 2493);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25099,2272,3578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25099,2272,3578);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string RemoveTags(string source)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25099,3590,3708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,3663,3697);

return f_25099_3670_3696(s_tags, source, "");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25099,3590,3708);

string
f_25099_3670_3696(System.Text.RegularExpressions.Regex
this_param,string
input,string
replacement)
{
var return_v = this_param.Replace( input, replacement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 3670, 3696);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25099,3590,3708);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25099,3590,3708);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string ClearTags(string source)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25099,3720,3865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,3792,3854);

return f_25099_3799_3853(s_tags, source, m => new string(' ', m.Length));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25099,3720,3865);

string
f_25099_3799_3853(System.Text.RegularExpressions.Regex
this_param,string
input,System.Text.RegularExpressions.MatchEvaluator
evaluator)
{
var return_v = this_param.Replace( input, evaluator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 3799, 3853);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25099,3720,3865);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25099,3720,3865);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static readonly Regex s_tags ;

private static readonly Regex s_markerPattern ;

public ImmutableDictionary<SyntaxNode, int> MapSyntaxNodesToMarks()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25099,5382,5876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,5474,5500);

var 
root = f_25099_5485_5499(Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,5514,5581);

var 
builder = f_25099_5528_5580()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,5604,5609);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,5595,5810) || true) && (i < SpansAndKindsAndIds.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,5643,5646)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25099,5595,5810))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25099,5595,5810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,5680,5729);

var 
node = f_25099_5691_5728(this, root, SpansAndKindsAndIds[i])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,5747,5795);

f_25099_5747_5794(                builder, node, SpansAndKindsAndIds[i].Item3);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25099,1,216);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25099,1,216);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,5826,5865);

return f_25099_5833_5864(builder);
DynAbs.Tracing.TraceSender.TraceExitMethod(25099,5382,5876);

Microsoft.CodeAnalysis.SyntaxNode
f_25099_5485_5499(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 5485, 5499);
return return_v;
}


System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxNode, int>.Builder
f_25099_5528_5580()
{
var return_v = ImmutableDictionary.CreateBuilder<SyntaxNode, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 5528, 5580);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_25099_5691_5728(Roslyn.Test.Utilities.SourceWithMarkedNodes
this_param,Microsoft.CodeAnalysis.SyntaxNode
root,(Microsoft.CodeAnalysis.Text.TextSpan, int, int)
spanAndKindAndId)
{
var return_v = this_param.GetNode( root, spanAndKindAndId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 5691, 5728);
return return_v;
}


int
f_25099_5747_5794(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxNode, int>.Builder
this_param,Microsoft.CodeAnalysis.SyntaxNode
key,int
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 5747, 5794);
return 0;
}


System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxNode, int>
f_25099_5833_5864(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxNode, int>.Builder
builder)
{
var return_v = builder.ToImmutableDictionary<Microsoft.CodeAnalysis.SyntaxNode,int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 5833, 5864);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25099,5382,5876);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25099,5382,5876);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SyntaxNode GetNode(SyntaxNode root, ValueTuple<TextSpan, int, int> spanAndKindAndId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25099,5888,6386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6005,6084);

var 
node = f_25099_6016_6083(root, spanAndKindAndId.Item1, getInnermostNodeForTie: true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6098,6190) || true) && (spanAndKindAndId.Item2 == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25099,6098,6190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6163,6175);

return node;
DynAbs.Tracing.TraceSender.TraceExitCondition(25099,6098,6190);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6206,6302);

var 
nodeOfKind = f_25099_6223_6301(node, n => n.RawKind == spanAndKindAndId.Item2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6316,6343);

f_25099_6316_6342(nodeOfKind);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6357,6375);

return nodeOfKind;
DynAbs.Tracing.TraceSender.TraceExitMethod(25099,5888,6386);

Microsoft.CodeAnalysis.SyntaxNode
f_25099_6016_6083(Microsoft.CodeAnalysis.SyntaxNode
this_param,Microsoft.CodeAnalysis.Text.TextSpan
span,bool
getInnermostNodeForTie)
{
var return_v = this_param.FindNode( span, getInnermostNodeForTie: getInnermostNodeForTie);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 6016, 6083);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_25099_6223_6301(Microsoft.CodeAnalysis.SyntaxNode
this_param,System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
predicate)
{
var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.SyntaxNode>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 6223, 6301);
return return_v;
}


int
f_25099_6316_6342(Microsoft.CodeAnalysis.SyntaxNode?
@object)
{
Assert.NotNull( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 6316, 6342);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25099,5888,6386);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25099,5888,6386);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public ImmutableDictionary<int, SyntaxNode> MapMarksToSyntaxNodes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25099,6398,6858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6490,6516);

var 
root = f_25099_6501_6515(Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6530,6597);

var 
builder = f_25099_6544_6596()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6620,6625);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6611,6792) || true) && (i < SpansAndKindsAndIds.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6659,6662)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25099,6611,6792))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25099,6611,6792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6696,6777);

f_25099_6696_6776(                builder, SpansAndKindsAndIds[i].Item3, f_25099_6738_6775(this, root, SpansAndKindsAndIds[i]));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25099,1,182);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25099,1,182);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,6808,6847);

return f_25099_6815_6846(builder);
DynAbs.Tracing.TraceSender.TraceExitMethod(25099,6398,6858);

Microsoft.CodeAnalysis.SyntaxNode
f_25099_6501_6515(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 6501, 6515);
return return_v;
}


System.Collections.Immutable.ImmutableDictionary<int, Microsoft.CodeAnalysis.SyntaxNode>.Builder
f_25099_6544_6596()
{
var return_v = ImmutableDictionary.CreateBuilder<int, SyntaxNode>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 6544, 6596);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_25099_6738_6775(Roslyn.Test.Utilities.SourceWithMarkedNodes
this_param,Microsoft.CodeAnalysis.SyntaxNode
root,(Microsoft.CodeAnalysis.Text.TextSpan, int, int)
spanAndKindAndId)
{
var return_v = this_param.GetNode( root, spanAndKindAndId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 6738, 6775);
return return_v;
}


int
f_25099_6696_6776(System.Collections.Immutable.ImmutableDictionary<int, Microsoft.CodeAnalysis.SyntaxNode>.Builder
this_param,int
key,Microsoft.CodeAnalysis.SyntaxNode
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 6696, 6776);
return 0;
}


System.Collections.Immutable.ImmutableDictionary<int, Microsoft.CodeAnalysis.SyntaxNode>
f_25099_6815_6846(System.Collections.Immutable.ImmutableDictionary<int, Microsoft.CodeAnalysis.SyntaxNode>.Builder
builder)
{
var return_v = builder.ToImmutableDictionary<int,Microsoft.CodeAnalysis.SyntaxNode>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 6815, 6846);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25099,6398,6858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25099,6398,6858);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static Func<SyntaxNode, SyntaxNode> GetSyntaxMap(SourceWithMarkedNodes source0, SourceWithMarkedNodes source1)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25099,6870,7575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,7012,7055);

var 
map0 = f_25099_7023_7054(source0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,7069,7112);

var 
map1 = f_25099_7080_7111(source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,7188,7564);

return new Func<SyntaxNode, SyntaxNode>(node1 =>
            {
                if (map1.TryGetValue(node1, out var mark) && map0.TryGetValue(mark, out var result))
                {
                    return result;
                }

#if DUMP
                Console.WriteLine($"? {node1.RawKind} [[{node1}]]");
#endif
                return null;
            });
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25099,6870,7575);

System.Collections.Immutable.ImmutableDictionary<int, Microsoft.CodeAnalysis.SyntaxNode>
f_25099_7023_7054(Roslyn.Test.Utilities.SourceWithMarkedNodes
this_param)
{
var return_v = this_param.MapMarksToSyntaxNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 7023, 7054);
return return_v;
}


System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxNode, int>
f_25099_7080_7111(Roslyn.Test.Utilities.SourceWithMarkedNodes
this_param)
{
var return_v = this_param.MapSyntaxNodesToMarks();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 7080, 7111);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25099,6870,7575);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25099,6870,7575);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SourceWithMarkedNodes()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25099,498,7582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,3907,4056);
s_tags = f_25099_3916_4056(@"[<][/]?[NMCL][:]?[:\.A-Za-z0-9]*[>]", RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline);DynAbs.Tracing.TraceSender.TraceSimpleStatement(25099,4099,5369);
s_markerPattern = f_25099_4117_5369(@"[<]                                # Open tag
              (?<TagName>[NMCL])                 # The actual tag name can be any of these letters

              (                                  # Start a group so that everything after the tag can be optional
                [:]                              # A colon
                (?<Id>[0-9]+)                    # The first number after the colon is the Id
                ([.](?<ParentId>[0-9]+))?        # Digits after a decimal point are the parent Id
                ([:](?<SyntaxKind>[A-Za-z]+))?   # A second colon separates the syntax kind
              )?                                 # Close the group for the things after the tag name
              [>]                                # Close tag

              (                                  # Start a group so that the closing tag is optional
                (?<MarkedSyntax>.*)              # This matches the source within the tags
                [<][/][NMCL][:]?(\k<Id>)* [>]    # The closing tag with its optional Id
              )?                                 # End of the group for the closing tag", RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline);DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25099,498,7582);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25099,498,7582);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25099,498,7582);

static string
f_25099_1893_1917(string
source)
{
var return_v = RemoveTags( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 1893, 1917);
return return_v;
}


static string
f_25099_1920_1943(string
source)
{
var return_v = ClearTags( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 1920, 1943);
return return_v;
}


static Microsoft.CodeAnalysis.SyntaxTree
f_25099_2000_2014(System.Func<string, Microsoft.CodeAnalysis.SyntaxTree>
this_param,string
arg)
{
var return_v = this_param.Invoke( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 2000, 2014);
return return_v;
}


static System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.SourceWithMarkedNodes.MarkedSpan>
f_25099_2072_2121(string
markedSource,int
offset,System.Func<string, int>
getSyntaxKind)
{
var return_v = GetSpansRecursive( markedSource, offset, getSyntaxKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 2072, 2121);
return return_v;
}


static System.Collections.Immutable.ImmutableArray<Roslyn.Test.Utilities.SourceWithMarkedNodes.MarkedSpan>
f_25099_2045_2122(System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.SourceWithMarkedNodes.MarkedSpan>
items)
{
var return_v = ImmutableArray.CreateRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 2045, 2122);
return return_v;
}


static System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Text.TextSpan MarkedSyntax, int SyntaxKind, int Id)>
f_25099_2159_2248(System.Collections.Generic.IEnumerable<(Microsoft.CodeAnalysis.Text.TextSpan MarkedSyntax, int SyntaxKind, int Id)>
items)
{
var return_v = ImmutableArray.CreateRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 2159, 2248);
return return_v;
}


static System.Text.RegularExpressions.Regex
f_25099_3916_4056(string
pattern,System.Text.RegularExpressions.RegexOptions
options)
{
var return_v = new System.Text.RegularExpressions.Regex( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 3916, 4056);
return return_v;
}


static System.Text.RegularExpressions.Regex
f_25099_4117_5369(string
pattern,System.Text.RegularExpressions.RegexOptions
options)
{
var return_v = new System.Text.RegularExpressions.Regex( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25099, 4117, 5369);
return return_v;
}

}
}
