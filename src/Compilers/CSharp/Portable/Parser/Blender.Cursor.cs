// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{

internal partial struct Blender
    {

private struct Cursor
        {

public readonly SyntaxNodeOrToken CurrentNodeOrToken;

private readonly int _indexInParent;

private Cursor(SyntaxNodeOrToken node, int indexInParent)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(10029,1265,1450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,1355,1386);

this.CurrentNodeOrToken = node;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,1404,1435);

_indexInParent = indexInParent;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10029,1265,1450);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10029,1265,1450);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10029,1265,1450);
}
		}

public static Cursor FromRoot(CSharp.CSharpSyntaxNode node)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10029,1466,1615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,1558,1600);

return f_10029_1565_1599(node, indexInParent: 0);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10029,1466,1615);

Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor
f_10029_1565_1599(Microsoft.CodeAnalysis.SyntaxNode
node,int
indexInParent)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor( (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, indexInParent:indexInParent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 1565, 1599);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10029,1466,1615);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10029,1466,1615);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool IsFinished
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10029,1686,1919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,1730,1900);

return
                        this.CurrentNodeOrToken.Kind()== SyntaxKind.None ||(DynAbs.Tracing.TraceSender.Expression_False(10029, 1762, 1899)||                        this.CurrentNodeOrToken.Kind()== SyntaxKind.EndOfFileToken);
DynAbs.Tracing.TraceSender.TraceExitMethod(10029,1686,1919);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10029,1631,1934);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10029,1631,1934);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private static bool IsNonZeroWidthOrIsEndOfFile(SyntaxNodeOrToken token)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10029,1950,2143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,2055,2128);

return token.Kind()== SyntaxKind.EndOfFileToken ||(DynAbs.Tracing.TraceSender.Expression_False(10029, 2062, 2127)||token.FullWidth != 0);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10029,1950,2143);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10029,1950,2143);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10029,1950,2143);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Cursor MoveToNextSibling()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10029,2159,3187);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,2225,3129) || true) && (this.CurrentNodeOrToken.Parent != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,2225,3129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,2459,2527);

var 
siblings = f_10029_2474_2526(this.CurrentNodeOrToken.Parent)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,2558,2580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,2582,2600);
                    for (int 
i = _indexInParent + 1
, 
n = siblings.Count
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,2549,2892) || true) && (i < n)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,2609,2612)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10029,2549,2892))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,2549,2892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,2662,2688);

var 
sibling = siblings[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,2714,2869) || true) && (IsNonZeroWidthOrIsEndOfFile(sibling))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,2714,2869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,2812,2842);

return f_10029_2819_2841(sibling, i);
DynAbs.Tracing.TraceSender.TraceExitCondition(10029,2714,2869);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10029,1,344);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10029,1,344);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3068,3110);

return MoveToParent().MoveToNextSibling();
DynAbs.Tracing.TraceSender.TraceExitCondition(10029,2225,3129);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3149,3172);

return default(Cursor);
DynAbs.Tracing.TraceSender.TraceExitMethod(10029,2159,3187);

Microsoft.CodeAnalysis.ChildSyntaxList
f_10029_2474_2526(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.ChildNodesAndTokens();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 2474, 2526);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor
f_10029_2819_2841(Microsoft.CodeAnalysis.SyntaxNodeOrToken
node,int
indexInParent)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor( node, indexInParent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 2819, 2841);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10029,2159,3187);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10029,2159,3187);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Cursor MoveToParent()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10029,3203,3433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3265,3309);

var 
parent = this.CurrentNodeOrToken.Parent
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3327,3367);

var 
index = IndexOfNodeInParent(parent)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3385,3418);

return f_10029_3392_3417(parent, index);
DynAbs.Tracing.TraceSender.TraceExitMethod(10029,3203,3433);

Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor
f_10029_3392_3417(Microsoft.CodeAnalysis.SyntaxNode?
node,int
indexInParent)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor( (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, indexInParent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 3392, 3417);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10029,3203,3433);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10029,3203,3433);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int IndexOfNodeInParent(SyntaxNode node)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10029,3449,4180);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3537,3630) || true) && (f_10029_3541_3552(node)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,3537,3630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3602,3611);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10029,3537,3630);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3650,3699);

var 
children = f_10029_3665_3698(f_10029_3665_3676(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3717,3834);

var 
index = SyntaxNodeOrToken.GetFirstChildIndexSpanningPosition(children,f_10029_3792_3832(((CSharp.CSharpSyntaxNode)node)))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3861,3870);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3872,3890);
                for (int 
i = index
, 
n = children.Count
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3852,4108) || true) && (i < n)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3899,3902)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10029,3852,4108))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,3852,4108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3944,3968);

var 
child = children[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,3990,4089) || true) && (child == node)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,3990,4089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,4057,4066);

return i;
DynAbs.Tracing.TraceSender.TraceExitCondition(10029,3990,4089);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10029,1,257);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10029,1,257);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,4128,4165);

throw f_10029_4134_4164();
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10029,3449,4180);

Microsoft.CodeAnalysis.SyntaxNode?
f_10029_3541_3552(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10029, 3541, 3552);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10029_3665_3676(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10029, 3665, 3676);
return return_v;
}


Microsoft.CodeAnalysis.ChildSyntaxList
f_10029_3665_3698(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.ChildNodesAndTokens();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 3665, 3698);
return return_v;
}


int
f_10029_3792_3832(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10029, 3792, 3832);
return return_v;
}


System.Exception
f_10029_4134_4164()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10029, 4134, 4164);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10029,3449,4180);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10029,3449,4180);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Cursor MoveToFirstChild()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10029,4196,6502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,4261,4306);

f_10029_4261_4305(this.CurrentNodeOrToken.IsNode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,4775,4814);

var 
node = CurrentNodeOrToken.AsNode()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,5294,5697) || true) && (f_10029_5298_5309(node)== SyntaxKind.InterpolatedStringExpression)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,5294,5697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,5394,5490);

var 
greenToken = f_10029_5411_5489(f_10029_5478_5488(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,5512,5612);

var 
redToken = f_10029_5527_5611(f_10029_5556_5567(node), greenToken, f_10029_5581_5594(node), _indexInParent)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,5634,5678);

return f_10029_5641_5677(redToken, _indexInParent);
DynAbs.Tracing.TraceSender.TraceExitCondition(10029,5294,5697);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,5717,6034) || true) && (f_10029_5721_5735(node)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,5717,6034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,5781,5854);

var 
child = Microsoft.CodeAnalysis.ChildSyntaxList.ItemInternal(node,0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,5876,6015) || true) && (IsNonZeroWidthOrIsEndOfFile(child))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,5876,6015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,5964,5992);

return f_10029_5971_5991(child, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(10029,5876,6015);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10029,5717,6034);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6112,6126);

int 
index = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6144,6447);
foreach(var child in f_10029_6166_6211_I(this.CurrentNodeOrToken.ChildNodesAndTokens()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,6144,6447);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6253,6396) || true) && (IsNonZeroWidthOrIsEndOfFile(child))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,6253,6396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6341,6373);

return f_10029_6348_6372(child, index);
DynAbs.Tracing.TraceSender.TraceExitCondition(10029,6253,6396);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6420,6428);

index++;
DynAbs.Tracing.TraceSender.TraceExitCondition(10029,6144,6447);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10029,1,304);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10029,1,304);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6467,6487);

return f_10029_6474_6486();
DynAbs.Tracing.TraceSender.TraceExitMethod(10029,4196,6502);

int
f_10029_4261_4305(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 4261, 4305);
return 0;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10029_5298_5309(Microsoft.CodeAnalysis.SyntaxNode?
node)
{
var return_v = node.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 5298, 5309);
return return_v;
}


Microsoft.CodeAnalysis.GreenNode
f_10029_5478_5488(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Green;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10029, 5478, 5488);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10029_5411_5489(Microsoft.CodeAnalysis.GreenNode
interpolatedString)
{
var return_v = Lexer.RescanInterpolatedString( (Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax)interpolatedString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 5411, 5489);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_10029_5556_5567(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10029, 5556, 5567);
return return_v;
}


int
f_10029_5581_5594(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10029, 5581, 5594);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10029_5527_5611(Microsoft.CodeAnalysis.SyntaxNode?
parent,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
token,int
position,int
index)
{
var return_v = new Microsoft.CodeAnalysis.SyntaxToken( parent, (Microsoft.CodeAnalysis.GreenNode)token, position, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 5527, 5611);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor
f_10029_5641_5677(Microsoft.CodeAnalysis.SyntaxToken
node,int
indexInParent)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor( (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, indexInParent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 5641, 5677);
return return_v;
}


int
f_10029_5721_5735(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.SlotCount ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10029, 5721, 5735);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor
f_10029_5971_5991(Microsoft.CodeAnalysis.SyntaxNodeOrToken
node,int
indexInParent)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor( node, indexInParent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 5971, 5991);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor
f_10029_6348_6372(Microsoft.CodeAnalysis.SyntaxNodeOrToken
node,int
indexInParent)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor( node, indexInParent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 6348, 6372);
return return_v;
}


Microsoft.CodeAnalysis.ChildSyntaxList
f_10029_6166_6211_I(Microsoft.CodeAnalysis.ChildSyntaxList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 6166, 6211);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor
f_10029_6474_6486()
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 6474, 6486);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10029,4196,6502);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10029,4196,6502);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Cursor MoveToFirstToken()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10029,6518,7006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6583,6601);

var 
cursor = this
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6619,6957) || true) && (f_10029_6623_6641_M(!cursor.IsFinished))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,6619,6957);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6692,6724);
                    for (var 
node = cursor.CurrentNodeOrToken
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6683,6938) || true) && (node.Kind()!= SyntaxKind.None &&(DynAbs.Tracing.TraceSender.Expression_True(10029, 6726, 6796)&&!f_10029_6761_6796(node.Kind())))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6798,6830)
,node = cursor.CurrentNodeOrToken,DynAbs.Tracing.TraceSender.TraceExitCondition(10029,6683,6938))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10029,6683,6938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6880,6915);

cursor = cursor.MoveToFirstChild();
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10029,1,256);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10029,1,256);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10029,6619,6957);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10029,6977,6991);

return cursor;
DynAbs.Tracing.TraceSender.TraceExitMethod(10029,6518,7006);

bool
f_10029_6623_6641_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10029, 6623, 6641);
return return_v;
}


bool
f_10029_6761_6796(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.IsAnyToken( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10029, 6761, 6796);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10029,6518,7006);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10029,6518,7006);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static Cursor(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10029,1100,7017);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10029,1100,7017);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10029,1100,7017);
}
        }
    }
}
