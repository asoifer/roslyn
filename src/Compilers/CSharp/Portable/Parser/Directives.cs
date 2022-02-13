// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{

[DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal struct Directive
    {

private readonly DirectiveTriviaSyntax _node;

internal Directive(DirectiveTriviaSyntax node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(10022,652,747);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,723,736);

_node = node;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10022,652,747);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,652,747);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,652,747);
}
		}

public SyntaxKind Kind
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,806,875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,842,860);

return f_10022_849_859(_node);
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,806,875);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10022_849_859(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 849, 859);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,759,886);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,759,886);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool IncrementallyEquivalent(Directive other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,898,1982);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,975,1064) || true) && (this.Kind != other.Kind)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,975,1064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,1036,1049);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,975,1064);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,1080,1110);

bool 
isActive = this.IsActive
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,1124,1160);

bool 
otherIsActive = other.IsActive
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,1235,1327) || true) && (!isActive &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 1239, 1266)&&!otherIsActive))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,1235,1327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,1300,1312);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,1235,1327);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,1343,1434) || true) && (isActive != otherIsActive)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,1343,1434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,1406,1419);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,1343,1434);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,1450,1971);

switch (this.Kind)
            {

case SyntaxKind.DefineDirectiveTrivia:
                case SyntaxKind.UndefDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,1450,1971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,1616,1669);

return this.GetIdentifier()== other.GetIdentifier();
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,1450,1971);

case SyntaxKind.IfDirectiveTrivia:
                case SyntaxKind.ElifDirectiveTrivia:
                case SyntaxKind.ElseDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,1450,1971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,1851,1896);

return this.BranchTaken == other.BranchTaken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,1450,1971);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,1450,1971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,1944,1956);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,1450,1971);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,898,1982);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,898,1982);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,898,1982);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetDebuggerDisplay()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,2084,2336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,2145,2236);

var 
writer = f_10022_2158_2235(f_10022_2185_2234())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,2250,2286);

f_10022_2250_2285(            _node, writer, false, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,2300,2325);

return f_10022_2307_2324(writer);
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,2084,2336);

System.Globalization.CultureInfo
f_10022_2185_2234()
{
var return_v = System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 2185, 2234);
return return_v;
}


System.IO.StringWriter
f_10022_2158_2235(System.Globalization.CultureInfo
formatProvider)
{
var return_v = new System.IO.StringWriter( (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 2158, 2235);
return return_v;
}


int
f_10022_2250_2285(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
this_param,System.IO.StringWriter
writer,bool
leading,bool
trailing)
{
this_param.WriteTo( (System.IO.TextWriter)writer, leading, trailing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 2250, 2285);
return 0;
}


string
f_10022_2307_2324(System.IO.StringWriter
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 2307, 2324);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,2084,2336);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,2084,2336);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetIdentifier()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,2348,2796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,2404,2785);

switch (f_10022_2412_2422(_node))
            {

case SyntaxKind.DefineDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,2404,2785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,2516,2575);

return f_10022_2523_2574(f_10022_2523_2564(((DefineDirectiveTriviaSyntax)_node)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,2404,2785);

case SyntaxKind.UndefDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,2404,2785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,2652,2710);

return f_10022_2659_2709(f_10022_2659_2699(((UndefDirectiveTriviaSyntax)_node)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,2404,2785);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,2404,2785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,2758,2770);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,2404,2785);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,2348,2796);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10022_2412_2422(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 2412, 2422);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10022_2523_2564(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DefineDirectiveTriviaSyntax
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 2523, 2564);
return return_v;
}


string
f_10022_2523_2574(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.ValueText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 2523, 2574);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10022_2659_2699(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.UndefDirectiveTriviaSyntax
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 2659, 2699);
return return_v;
}


string
f_10022_2659_2709(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
this_param)
{
var return_v = this_param.ValueText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 2659, 2709);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,2348,2796);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,2348,2796);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool IsActive
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,2855,2885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,2861,2883);

return f_10022_2868_2882(_node);
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,2855,2885);

bool
f_10022_2868_2882(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
this_param)
{
var return_v = this_param.IsActive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 2868, 2882);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,2808,2896);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,2808,2896);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool BranchTaken
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,2958,3227);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,2994,3050);

var 
branching = _node as BranchingDirectiveTriviaSyntax
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,3068,3179) || true) && (branching != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,3068,3179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,3131,3160);

return f_10022_3138_3159(branching);
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,3068,3179);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,3199,3212);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,2958,3227);

bool
f_10022_3138_3159(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BranchingDirectiveTriviaSyntax
this_param)
{
var return_v = this_param.BranchTaken;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 3138, 3159);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,2908,3238);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,2908,3238);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}
static Directive(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10022,500,3245);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10022,500,3245);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,500,3245);
}
    }

    internal enum DefineState
    {
        Defined,
        Undefined,
        Unspecified
    }

[DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal struct DirectiveStack
    {

public static readonly DirectiveStack Empty ;

public static readonly DirectiveStack Null ;

private readonly ConsList<Directive> _directives;

private DirectiveStack(ConsList<Directive> directives)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(10022,3704,3819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,3783,3808);

_directives = directives;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10022,3704,3819);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,3704,3819);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,3704,3819);
}
		}

public bool IsNull
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,3874,3952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,3910,3937);

return _directives == null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,3874,3952);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,3831,3963);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,3831,3963);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool IsEmpty
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,4019,4118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,4055,4103);

return _directives == ConsList<Directive>.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,4019,4118);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,3975,4129);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,3975,4129);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public DefineState IsDefined(string id)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,4141,5657);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,4214,4235);
            for (var 
current = _directives
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,4205,5599) || true) && (current != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 4237, 4269)&&f_10022_4256_4269(current)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,4271,4293)
,current = f_10022_4281_4293(current),DynAbs.Tracing.TraceSender.TraceExitCondition(10022,4205,5599))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,4205,5599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,4327,5584);

switch (current.Head.Kind)
                {

case SyntaxKind.DefineDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,4327,5584);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,4458,4608) || true) && (current.Head.GetIdentifier()== id)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,4458,4608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,4554,4581);

return DefineState.Defined;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,4458,4608);
}
DynAbs.Tracing.TraceSender.TraceBreak(10022,4636,4642);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,4327,5584);

case SyntaxKind.UndefDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,4327,5584);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,4727,4879) || true) && (current.Head.GetIdentifier()== id)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,4727,4879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,4823,4852);

return DefineState.Undefined;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,4727,4879);
}
DynAbs.Tracing.TraceSender.TraceBreak(10022,4907,4913);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,4327,5584);

case SyntaxKind.ElifDirectiveTrivia:
                    case SyntaxKind.ElseDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,4327,5584);
try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,5141,5531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,5200,5223);

current = f_10022_5210_5222(current);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,5255,5420) || true) && (current == null ||(DynAbs.Tracing.TraceSender.Expression_False(10022, 5259, 5292)||!f_10022_5279_5292(current)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,5255,5420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,5358,5389);

return DefineState.Unspecified;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,5255,5420);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,5141,5531);
}
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,5141,5531) || true) && (current.Head.Kind != SyntaxKind.IfDirectiveTrivia)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10022,5141,5531);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10022,5141,5531);
}DynAbs.Tracing.TraceSender.TraceBreak(10022,5559,5565);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,4327,5584);
                }
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10022,1,1395);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10022,1,1395);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,5615,5646);

return DefineState.Unspecified;
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,4141,5657);

bool
f_10022_4256_4269(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 4256, 4269);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_4281_4293(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 4281, 4293);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_5210_5222(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 5210, 5222);
return return_v;
}


bool
f_10022_5279_5292(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 5279, 5292);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,4141,5657);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,4141,5657);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool PreviousBranchTaken()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,5750,6236);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,5817,5838);
            for (var 
current = _directives
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,5808,6196) || true) && (current != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 5840, 5872)&&f_10022_5859_5872(current)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,5874,5896)
,current = f_10022_5884_5896(current),DynAbs.Tracing.TraceSender.TraceExitCondition(10022,5808,6196))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,5808,6196);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,5930,6181) || true) && (current.Head.BranchTaken)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,5930,6181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,6000,6012);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,5930,6181);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,5930,6181);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,6054,6181) || true) && (current.Head.Kind == SyntaxKind.IfDirectiveTrivia)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,6054,6181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,6149,6162);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,6054,6181);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,5930,6181);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10022,1,389);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10022,1,389);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,6212,6225);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,5750,6236);

bool
f_10022_5859_5872(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 5859, 5872);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_5884_5896(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 5884, 5896);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,5750,6236);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,5750,6236);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool HasUnfinishedIf()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,6248,6469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,6302,6356);

var 
prev = GetPreviousIfElifElseOrRegion(_directives)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,6370,6458);

return prev != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 6377, 6403)&&f_10022_6393_6403(prev))&&(DynAbs.Tracing.TraceSender.Expression_True(10022, 6377, 6457)&&prev.Head.Kind != SyntaxKind.RegionDirectiveTrivia);
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,6248,6469);

bool
f_10022_6393_6403(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 6393, 6403);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,6248,6469);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,6248,6469);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool HasPreviousIfOrElif()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,6481,6756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,6539,6593);

var 
prev = GetPreviousIfElifElseOrRegion(_directives)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,6607,6745);

return prev != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 6614, 6640)&&f_10022_6630_6640(prev))&&(DynAbs.Tracing.TraceSender.Expression_True(10022, 6614, 6744)&&(prev.Head.Kind == SyntaxKind.IfDirectiveTrivia ||(DynAbs.Tracing.TraceSender.Expression_False(10022, 6645, 6743)||prev.Head.Kind == SyntaxKind.ElifDirectiveTrivia)));
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,6481,6756);

bool
f_10022_6630_6640(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 6630, 6640);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,6481,6756);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,6481,6756);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool HasUnfinishedRegion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,6768,6993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,6826,6880);

var 
prev = GetPreviousIfElifElseOrRegion(_directives)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,6894,6982);

return prev != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 6901, 6927)&&f_10022_6917_6927(prev))&&(DynAbs.Tracing.TraceSender.Expression_True(10022, 6901, 6981)&&prev.Head.Kind == SyntaxKind.RegionDirectiveTrivia);
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,6768,6993);

bool
f_10022_6917_6927(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 6917, 6927);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,6768,6993);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,6768,6993);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public DirectiveStack Add(Directive directive)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,7005,8222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,7076,8211);

switch (directive.Kind)
            {

case SyntaxKind.EndIfDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,7076,8211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,7191,7231);

var 
prevIf = GetPreviousIf(_directives)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,7253,7427) || true) && (prevIf == null ||(DynAbs.Tracing.TraceSender.Expression_False(10022, 7257, 7288)||!f_10022_7276_7288(prevIf)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,7253,7427);

goto default;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,7253,7427);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,7451,7460);

bool 
tmp
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,7482,7542);

return f_10022_7489_7541(CompleteIf(_directives,out tmp));
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,7076,8211);

case SyntaxKind.EndRegionDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,7076,8211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,7623,7671);

var 
prevRegion = GetPreviousRegion(_directives)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,7693,7879) || true) && (prevRegion == null ||(DynAbs.Tracing.TraceSender.Expression_False(10022, 7697, 7736)||!f_10022_7720_7736(prevRegion)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,7693,7879);

goto default;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,7693,7879);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,7903,7958);

return f_10022_7910_7957(CompleteRegion(_directives));
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,7076,8211);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,7076,8211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,8071,8196);

return f_10022_8078_8195(f_10022_8097_8194(directive, (DynAbs.Tracing.TraceSender.Conditional_F1(10022, 8132, 8151)||((_directives != null &&DynAbs.Tracing.TraceSender.Conditional_F2(10022, 8154, 8165))||DynAbs.Tracing.TraceSender.Conditional_F3(10022, 8168, 8193)))?_directives :ConsList<Directive>.Empty));
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,7076,8211);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,7005,8222);

bool
f_10022_7276_7288(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 7276, 7288);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
f_10022_7489_7541(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
directives)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack( directives);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 7489, 7541);
return return_v;
}


bool
f_10022_7720_7736(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 7720, 7736);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
f_10022_7910_7957(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
directives)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack( directives);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 7910, 7957);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_8097_8194(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive
head,Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
tail)
{
var return_v = new Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>( head, tail);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 8097, 8194);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
f_10022_8078_8195(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
directives)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack( directives);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 8078, 8195);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,7005,8222);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,7005,8222);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ConsList<Directive> CompleteIf(ConsList<Directive> stack, out bool include)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10022,8336,9667);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,8542,8653) || true) && (!f_10022_8547_8558(stack))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,8542,8653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,8592,8607);

include = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,8625,8638);

return stack;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,8542,8653);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,8910,9079) || true) && (stack.Head.Kind == SyntaxKind.IfDirectiveTrivia)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,8910,9079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,8995,9028);

include = stack.Head.BranchTaken;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,9046,9064);

return f_10022_9053_9063(stack);
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,8910,9079);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,9095,9146);

var 
newStack = CompleteIf(f_10022_9121_9131(stack),out include)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,9160,9624);

switch (stack.Head.Kind)
            {

case SyntaxKind.ElifDirectiveTrivia:
                case SyntaxKind.ElseDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,9160,9624);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,9329,9362);

include = stack.Head.BranchTaken;
DynAbs.Tracing.TraceSender.TraceBreak(10022,9384,9390);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,9160,9624);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,9160,9624);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,9438,9579) || true) && (include)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,9438,9579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,9499,9556);

newStack = f_10022_9510_9555(f_10022_9534_9544(stack), newStack);
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,9438,9579);
}
DynAbs.Tracing.TraceSender.TraceBreak(10022,9603,9609);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,9160,9624);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,9640,9656);

return newStack;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10022,8336,9667);

bool
f_10022_8547_8558(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 8547, 8558);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_9053_9063(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 9053, 9063);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_9121_9131(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 9121, 9131);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive
f_10022_9534_9544(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Head;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 9534, 9544);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_9510_9555(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive
head,Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
tail)
{
var return_v = new Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>( head, tail);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 9510, 9555);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,8336,9667);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,8336,9667);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ConsList<Directive> CompleteRegion(ConsList<Directive> stack)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10022,9755,10333);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,9947,10025) || true) && (!f_10022_9952_9963(stack))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,9947,10025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,9997,10010);

return stack;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,9947,10025);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10041,10163) || true) && (stack.Head.Kind == SyntaxKind.RegionDirectiveTrivia)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,10041,10163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10130,10148);

return f_10022_10137_10147(stack);
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,10041,10163);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10179,10221);

var 
newStack = CompleteRegion(f_10022_10209_10219(stack))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10235,10292);

newStack = f_10022_10246_10291(f_10022_10270_10280(stack), newStack);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10306,10322);

return newStack;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10022,9755,10333);

bool
f_10022_9952_9963(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 9952, 9963);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_10137_10147(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 10137, 10147);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_10209_10219(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 10209, 10219);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive
f_10022_10270_10280(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Head;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 10270, 10280);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_10246_10291(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive
head,Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
tail)
{
var return_v = new Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>( head, tail);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 10246, 10291);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,9755,10333);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,9755,10333);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ConsList<Directive> GetPreviousIf(ConsList<Directive> directives)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10022,10345,10823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10450,10475);

var 
current = directives
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10489,10781) || true) && (current != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 10496, 10528)&&f_10022_10515_10528(current)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,10489,10781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10562,10723);

switch (current.Head.Kind)
                {

case SyntaxKind.IfDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,10562,10723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10689,10704);

return current;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,10562,10723);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10743,10766);

current = f_10022_10753_10765(current);
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,10489,10781);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10022,10489,10781);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10022,10489,10781);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10797,10812);

return current;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10022,10345,10823);

bool
f_10022_10515_10528(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 10515, 10528);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_10753_10765(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 10753, 10765);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,10345,10823);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,10345,10823);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ConsList<Directive> GetPreviousIfElifElseOrRegion(ConsList<Directive> directives)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10022,10835,11505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10956,10981);

var 
current = directives
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,10995,11463) || true) && (current != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 11002, 11034)&&f_10022_11021_11034(current)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,10995,11463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,11068,11405);

switch (current.Head.Kind)
                {

case SyntaxKind.IfDirectiveTrivia:
                    case SyntaxKind.ElifDirectiveTrivia:
                    case SyntaxKind.ElseDirectiveTrivia:
                    case SyntaxKind.RegionDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,11068,11405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,11371,11386);

return current;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,11068,11405);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,11425,11448);

current = f_10022_11435_11447(current);
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,10995,11463);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10022,10995,11463);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10022,10995,11463);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,11479,11494);

return current;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10022,10835,11505);

bool
f_10022_11021_11034(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 11021, 11034);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_11435_11447(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 11435, 11447);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,10835,11505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,10835,11505);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ConsList<Directive> GetPreviousRegion(ConsList<Directive> directives)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10022,11517,11875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,11626,11651);

var 
current = directives
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,11665,11833) || true) && (current != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 11672, 11704)&&f_10022_11691_11704(current))&&(DynAbs.Tracing.TraceSender.Expression_True(10022, 11672, 11761)&&current.Head.Kind != SyntaxKind.RegionDirectiveTrivia))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,11665,11833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,11795,11818);

current = f_10022_11805_11817(current);
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,11665,11833);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10022,11665,11833);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10022,11665,11833);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,11849,11864);

return current;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10022,11517,11875);

bool
f_10022_11691_11704(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 11691, 11704);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_11805_11817(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 11805, 11817);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,11517,11875);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,11517,11875);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetDebuggerDisplay()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,11887,12341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,11947,11976);

var 
sb = f_10022_11956_11975()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,11999,12020);
            for (var 
current = _directives
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,11990,12293) || true) && (current != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 12022, 12054)&&f_10022_12041_12054(current)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12056,12078)
,current = f_10022_12066_12078(current),DynAbs.Tracing.TraceSender.TraceExitCondition(10022,11990,12293))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,11990,12293);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12112,12210) || true) && (f_10022_12116_12125(sb)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,12112,12210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12171,12191);

f_10022_12171_12190(                    sb, 0, " | ");
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,12112,12210);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12230,12278);

f_10022_12230_12277(
                sb, 0, current.Head.GetDebuggerDisplay());
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10022,1,304);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10022,1,304);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12309,12330);

return f_10022_12316_12329(sb);
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,11887,12341);

System.Text.StringBuilder
f_10022_11956_11975()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 11956, 11975);
return return_v;
}


bool
f_10022_12041_12054(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 12041, 12054);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_12066_12078(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 12066, 12078);
return return_v;
}


int
f_10022_12116_12125(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 12116, 12125);
return return_v;
}


System.Text.StringBuilder
f_10022_12171_12190(System.Text.StringBuilder
this_param,int
index,string
value)
{
var return_v = this_param.Insert( index, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 12171, 12190);
return return_v;
}


System.Text.StringBuilder
f_10022_12230_12277(System.Text.StringBuilder
this_param,int
index,string
value)
{
var return_v = this_param.Insert( index, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 12230, 12277);
return return_v;
}


string
f_10022_12316_12329(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 12316, 12329);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,11887,12341);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,11887,12341);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool IncrementallyEquivalent(DirectiveStack other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10022,12353,13223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12435,12487);

var 
mine = SkipInsignificantDirectives(_directives)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12501,12561);

var 
theirs = SkipInsignificantDirectives(other._directives)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12575,12620);

bool 
mineHasAny = mine != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 12593, 12619)&&f_10022_12609_12619(mine))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12634,12685);

bool 
theirsHasAny = theirs != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 12654, 12684)&&f_10022_12672_12684(theirs))
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12699,13162) || true) && (mineHasAny &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 12706, 12732)&&theirsHasAny))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,12699,13162);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12766,12891) || true) && (!mine.Head.IncrementallyEquivalent(f_10022_12805_12816(theirs)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,12766,12891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12859,12872);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,12766,12891);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12911,12957);

mine = SkipInsignificantDirectives(f_10022_12946_12955(mine));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,12975,13025);

theirs = SkipInsignificantDirectives(f_10022_13012_13023(theirs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,13043,13083);

mineHasAny = mine != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 13056, 13082)&&f_10022_13072_13082(mine));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,13101,13147);

theirsHasAny = theirs != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 13116, 13146)&&f_10022_13134_13146(theirs));
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,12699,13162);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10022,12699,13162);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10022,12699,13162);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,13178,13212);

return mineHasAny == theirsHasAny;
DynAbs.Tracing.TraceSender.TraceExitMethod(10022,12353,13223);

bool
f_10022_12609_12619(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 12609, 12619);
return return_v;
}


bool
f_10022_12672_12684(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 12672, 12684);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive
f_10022_12805_12816(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>?
this_param)
{
var return_v = this_param.Head;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 12805, 12816);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_12946_12955(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 12946, 12955);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_13012_13023(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 13012, 13023);
return return_v;
}


bool
f_10022_13072_13082(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 13072, 13082);
return return_v;
}


bool
f_10022_13134_13146(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 13134, 13146);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,12353,13223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,12353,13223);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ConsList<Directive> SkipInsignificantDirectives(ConsList<Directive> directives)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10022,13235,14107);
try {            for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,13354,14062) || true) && (directives != null &&(DynAbs.Tracing.TraceSender.Expression_True(10022, 13361, 13399)&&f_10022_13383_13399(directives)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,13401,13429)
,directives = f_10022_13414_13429(directives),DynAbs.Tracing.TraceSender.TraceExitCondition(10022,13354,14062))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,13354,14062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,13463,14047);

switch (directives.Head.Kind)
                {

case SyntaxKind.IfDirectiveTrivia:
                    case SyntaxKind.ElifDirectiveTrivia:
                    case SyntaxKind.ElseDirectiveTrivia:
                    case SyntaxKind.EndIfDirectiveTrivia:
                    case SyntaxKind.DefineDirectiveTrivia:
                    case SyntaxKind.UndefDirectiveTrivia:
                    case SyntaxKind.RegionDirectiveTrivia:
                    case SyntaxKind.EndRegionDirectiveTrivia:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10022,13463,14047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,14010,14028);

return directives;
DynAbs.Tracing.TraceSender.TraceExitCondition(10022,13463,14047);
                }
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10022,1,709);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10022,1,709);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,14078,14096);

return directives;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10022,13235,14107);

bool
f_10022_13383_13399(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 13383, 13399);
return return_v;
}


Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
f_10022_13414_13429(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
this_param)
{
var return_v = this_param.Tail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10022, 13414, 13429);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10022,13235,14107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,13235,14107);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static DirectiveStack(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10022,3359,14114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,3497,3550);
Empty = f_10022_3505_3550(ConsList<Directive>.Empty);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10022,3599,3630);
Null = f_10022_3606_3630(null);DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10022,3359,14114);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10022,3359,14114);
}

static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
f_10022_3505_3550(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
directives)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack( directives);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 3505, 3550);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
f_10022_3606_3630(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive>
directives)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack( directives);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10022, 3606, 3630);
return return_v;
}

    }
}
