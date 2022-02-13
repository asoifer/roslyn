// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitIsPatternExpression(BoundIsPatternExpression node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10507,498,4234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,604,634);

bool 
negated = f_10507_619_633(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,648,671);

BoundExpression 
result
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,687,2405) || true) && (f_10507_691_814(f_10507_716_741(f_10507_716_732(node)), whenTrueLabel: f_10507_758_776(node), whenFalseLabel: f_10507_794_813(node)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,687,2405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,946,1025);

var 
isPatternRewriter = f_10507_970_1024(node, this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,1043,1183);

result = f_10507_1052_1182(isPatternRewriter, node, whenTrueLabel: f_10507_1126_1144(node), whenFalseLabel: f_10507_1162_1181(node));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,1201,1226);

f_10507_1201_1225(                isPatternRewriter);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,687,2405);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,687,2405);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,1260,2405) || true) && (f_10507_1264_1387(f_10507_1289_1314(f_10507_1289_1305(node)), whenTrueLabel: f_10507_1331_1350(node), whenFalseLabel: f_10507_1368_1386(node)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,1260,2405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,1645,1664);

negated = !negated;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,1682,1761);

var 
isPatternRewriter = f_10507_1706_1760(node, this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,1779,1919);

result = f_10507_1788_1918(isPatternRewriter, node, whenTrueLabel: f_10507_1862_1881(node), whenFalseLabel: f_10507_1899_1917(node));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,1937,1962);

f_10507_1937_1961(                isPatternRewriter);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,1260,2405);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,1260,2405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,2187,2274);

var 
isPatternRewriter = f_10507_2211_2273(node.Syntax, this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,2292,2347);

result = f_10507_2301_2346(isPatternRewriter, node);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,2365,2390);

f_10507_2365_2389(                isPatternRewriter);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,1260,2405);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,687,2405);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,2421,2516) || true) && (negated)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,2421,2516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,2466,2501);

result = f_10507_2475_2500(this._factory, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,2421,2516);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,2530,2544);

return result;

static bool canProduceLinearSequence(
                BoundDecisionDagNode node,
                LabelSymbol whenTrueLabel,
                LabelSymbol whenFalseLabel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10507,2899,4223);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,3102,4208) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,3102,4208);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,3155,4189);

switch (node)
                    {

case BoundWhenDecisionDagNode w:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,3155,4189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,3279,3313);

f_10507_3279_3312(f_10507_3292_3303(w)is null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,3343,3361);

node = f_10507_3350_3360(w);
DynAbs.Tracing.TraceSender.TraceBreak(10507,3391,3397);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,3155,4189);

case BoundLeafDecisionDagNode n:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,3155,4189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,3485,3517);

return f_10507_3492_3499(n)== whenTrueLabel;
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,3155,4189);

case BoundEvaluationDecisionDagNode e:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,3155,4189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,3611,3625);

node = f_10507_3618_3624(e);
DynAbs.Tracing.TraceSender.TraceBreak(10507,3655,3661);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,3155,4189);

case BoundTestDecisionDagNode t:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,3155,4189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,3749,3809);

bool 
falseFail = f_10507_3766_3808(f_10507_3780_3791(t), whenFalseLabel)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,3839,3945) || true) && (falseFail == f_10507_3856_3897(f_10507_3870_3880(t), whenFalseLabel))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,3839,3945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,3932,3945);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,3839,3945);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,3975,4019);

node = (DynAbs.Tracing.TraceSender.Conditional_F1(10507, 3982, 3991)||((falseFail &&DynAbs.Tracing.TraceSender.Conditional_F2(10507, 3994, 4004))||DynAbs.Tracing.TraceSender.Conditional_F3(10507, 4007, 4018)))?f_10507_3994_4004(t):f_10507_4007_4018(t);
DynAbs.Tracing.TraceSender.TraceBreak(10507,4049,4055);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,3155,4189);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,3155,4189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,4119,4166);

throw f_10507_4125_4165(node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,3155,4189);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,3102,4208);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10507,3102,4208);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10507,3102,4208);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10507,2899,4223);

Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
f_10507_3292_3303(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
this_param)
{
var return_v = this_param.WhenFalse ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 3292, 3303);
return return_v;
}


int
f_10507_3279_3312(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 3279, 3312);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_3350_3360(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
this_param)
{
var return_v = this_param.WhenTrue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 3350, 3360);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_3492_3499(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
this_param)
{
var return_v = this_param.Label ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 3492, 3499);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_3618_3624(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
this_param)
{
var return_v = this_param.Next;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 3618, 3624);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_3780_3791(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
this_param)
{
var return_v = this_param.WhenFalse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 3780, 3791);
return return_v;
}


bool
f_10507_3766_3808(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
node,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenFalseLabel)
{
var return_v = IsFailureNode( node, whenFalseLabel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 3766, 3808);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_3870_3880(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
this_param)
{
var return_v = this_param.WhenTrue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 3870, 3880);
return return_v;
}


bool
f_10507_3856_3897(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
node,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenFalseLabel)
{
var return_v = IsFailureNode( node, whenFalseLabel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 3856, 3897);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_3994_4004(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
this_param)
{
var return_v = this_param.WhenTrue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 3994, 4004);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_4007_4018(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
this_param)
{
var return_v = this_param.WhenFalse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 4007, 4018);
return return_v;
}


System.Exception
f_10507_4125_4165(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 4125, 4165);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,2899,4223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,2899,4223);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(10507,498,4234);

bool
f_10507_619_633(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.IsNegated;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 619, 633);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
f_10507_716_732(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.DecisionDag;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 716, 732);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_716_741(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
this_param)
{
var return_v = this_param.RootNode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 716, 741);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_758_776(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.WhenTrueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 758, 776);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_794_813(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.WhenFalseLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 794, 813);
return return_v;
}


bool
f_10507_691_814(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
node,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenTrueLabel,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenFalseLabel)
{
var return_v = canProduceLinearSequence( node, whenTrueLabel: whenTrueLabel, whenFalseLabel: whenFalseLabel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 691, 814);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
f_10507_970_1024(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
node,Microsoft.CodeAnalysis.CSharp.LocalRewriter
localRewriter)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter( node, localRewriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 970, 1024);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_1126_1144(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.WhenTrueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 1126, 1144);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_1162_1181(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.WhenFalseLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 1162, 1181);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_1052_1182(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
isPatternExpression,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenTrueLabel,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenFalseLabel)
{
var return_v = this_param.LowerIsPatternAsLinearTestSequence( isPatternExpression, whenTrueLabel: whenTrueLabel, whenFalseLabel: whenFalseLabel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 1052, 1182);
return return_v;
}


int
f_10507_1201_1225(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 1201, 1225);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
f_10507_1289_1305(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.DecisionDag;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 1289, 1305);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_1289_1314(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
this_param)
{
var return_v = this_param.RootNode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 1289, 1314);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_1331_1350(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.WhenFalseLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 1331, 1350);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_1368_1386(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.WhenTrueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 1368, 1386);
return return_v;
}


bool
f_10507_1264_1387(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
node,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenTrueLabel,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenFalseLabel)
{
var return_v = canProduceLinearSequence( node, whenTrueLabel: whenTrueLabel, whenFalseLabel: whenFalseLabel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 1264, 1387);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
f_10507_1706_1760(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
node,Microsoft.CodeAnalysis.CSharp.LocalRewriter
localRewriter)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter( node, localRewriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 1706, 1760);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_1862_1881(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.WhenFalseLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 1862, 1881);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_1899_1917(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.WhenTrueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 1899, 1917);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_1788_1918(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
isPatternExpression,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenTrueLabel,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenFalseLabel)
{
var return_v = this_param.LowerIsPatternAsLinearTestSequence( isPatternExpression, whenTrueLabel: whenTrueLabel, whenFalseLabel: whenFalseLabel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 1788, 1918);
return return_v;
}


int
f_10507_1937_1961(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 1937, 1961);
return 0;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionGeneralLocalRewriter
f_10507_2211_2273(Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.CSharp.LocalRewriter
localRewriter)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionGeneralLocalRewriter( node, localRewriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 2211, 2273);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_2301_2346(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionGeneralLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
node)
{
var return_v = this_param.LowerGeneralIsPattern( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 2301, 2346);
return return_v;
}


int
f_10507_2365_2389(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionGeneralLocalRewriter
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 2365, 2389);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_2475_2500(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.Not( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 2475, 2500);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,498,4234);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,498,4234);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
private sealed class IsPatternExpressionGeneralLocalRewriter : DecisionDagRewriter
{
private readonly ArrayBuilder<BoundStatement> _statements ;

public IsPatternExpressionGeneralLocalRewriter(
                SyntaxNode node,
                LocalRewriter localRewriter) :base(f_10507_4863_4867_C(node) ,localRewriter,generateInstrumentation: false)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10507,4728,4945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,4655,4711);
this._statements = f_10507_4669_4711();DynAbs.Tracing.TraceSender.TraceExitConstructor(10507,4728,4945);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,4728,4945);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,4728,4945);
}
		}

protected override ArrayBuilder<BoundStatement> BuilderForSection(SyntaxNode section) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10507,5047,5061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,5050,5061);
return _statements;DynAbs.Tracing.TraceSender.TraceExitMethod(10507,5047,5061);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,5047,5061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,5047,5061);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public new void Free()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10507,5078,5197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,5133,5145);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(),10507,5133,5144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,5163,5182);

f_10507_5163_5181(                _statements);
DynAbs.Tracing.TraceSender.TraceExitMethod(10507,5078,5197);

int
f_10507_5163_5181(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 5163, 5181);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,5078,5197);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,5078,5197);
}
		}

internal BoundExpression LowerGeneralIsPattern(BoundIsPatternExpression node)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10507,5213,7198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,5323,5353);

_factory.Syntax = node.Syntax;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,5371,5434);

var 
resultBuilder = f_10507_5391_5433()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,5452,5522);

var 
inputExpression = f_10507_5474_5521(_localRewriter, f_10507_5505_5520(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,5540,5687);

BoundDecisionDag 
decisionDag = f_10507_5571_5686(this, f_10507_5630_5646(node), inputExpression, resultBuilder, out _)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,5751,5829);

ImmutableArray<BoundStatement> 
loweredDag = f_10507_5795_5828(this, decisionDag)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,5847,5893);

f_10507_5847_5892(                resultBuilder, f_10507_5865_5891(_factory, loweredDag));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,5911,5982);

f_10507_5911_5981(f_10507_5924_5933(node)is { SpecialType: SpecialType.System_Boolean });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6000,6116);

LocalSymbol 
resultTemp = f_10507_6025_6115(_factory, f_10507_6051_6060(node), node.Syntax, kind: SynthesizedLocalKind.LoweringTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6134,6224);

LabelSymbol 
afterIsPatternExpression = f_10507_6173_6223(_factory, "afterIsPatternExpression")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6242,6285);

LabelSymbol 
trueLabel = f_10507_6266_6284(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6303,6348);

LabelSymbol 
falseLabel = f_10507_6328_6347(node)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6366,6472) || true) && (f_10507_6370_6387(_statements)!= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,6366,6472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6415,6472);

f_10507_6415_6471(                    resultBuilder, f_10507_6433_6470(_factory, f_10507_6448_6469(_statements)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,6366,6472);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6490,6535);

f_10507_6490_6534(                resultBuilder, f_10507_6508_6533(_factory, trueLabel));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6553,6644);

f_10507_6553_6643(                resultBuilder, f_10507_6571_6642(_factory, f_10507_6591_6617(_factory, resultTemp), f_10507_6619_6641(_factory, true)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6662,6721);

f_10507_6662_6720(                resultBuilder, f_10507_6680_6719(_factory, afterIsPatternExpression));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6739,6785);

f_10507_6739_6784(                resultBuilder, f_10507_6757_6783(_factory, falseLabel));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6803,6895);

f_10507_6803_6894(                resultBuilder, f_10507_6821_6893(_factory, f_10507_6841_6867(_factory, resultTemp), f_10507_6869_6892(_factory, false)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6913,6973);

f_10507_6913_6972(                resultBuilder, f_10507_6931_6971(_factory, afterIsPatternExpression));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,6991,7028);

_localRewriter._needsSpilling = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,7046,7183);

return f_10507_7053_7182(_factory, f_10507_7076_7101(_tempAllocator).Add(resultTemp), f_10507_7119_7153(resultBuilder), f_10507_7155_7181(_factory, resultTemp));
DynAbs.Tracing.TraceSender.TraceExitMethod(10507,5213,7198);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10507_5391_5433()
{
var return_v = ArrayBuilder<BoundStatement>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 5391, 5433);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_5505_5520(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 5505, 5520);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10507_5474_5521(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 5474, 5521);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
f_10507_5630_5646(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.DecisionDag;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 5630, 5646);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
f_10507_5571_5686(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionGeneralLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
decisionDag,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredSwitchGoverningExpression,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
result,out Microsoft.CodeAnalysis.CSharp.BoundExpression
savedInputExpression)
{
var return_v = this_param.ShareTempsIfPossibleAndEvaluateInput( decisionDag, loweredSwitchGoverningExpression, result, out savedInputExpression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 5571, 5686);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10507_5795_5828(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionGeneralLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
decisionDag)
{
var return_v = this_param.LowerDecisionDagCore( decisionDag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 5795, 5828);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10507_5865_5891(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = this_param.Block( statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 5865, 5891);
return return_v;
}


int
f_10507_5847_5892(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundBlock
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 5847, 5892);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10507_5924_5933(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 5924, 5933);
return return_v;
}


int
f_10507_5911_5981(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 5911, 5981);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10507_6051_6060(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 6051, 6060);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10507_6025_6115(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( type, syntax, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6025, 6115);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10507_6173_6223(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,string
prefix)
{
var return_v = this_param.GenerateLabel( prefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6173, 6223);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_6266_6284(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.WhenTrueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 6266, 6284);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_6328_6347(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.WhenFalseLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 6328, 6347);
return return_v;
}


int
f_10507_6370_6387(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 6370, 6387);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement[]
f_10507_6448_6469(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6448, 6469);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10507_6433_6470(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = this_param.Block( statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6433, 6470);
return return_v;
}


int
f_10507_6415_6471(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundBlock
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6415, 6471);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10507_6508_6533(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
label)
{
var return_v = this_param.Label( label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6508, 6533);
return return_v;
}


int
f_10507_6490_6534(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6490, 6534);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10507_6591_6617(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6591, 6617);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10507_6619_6641(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,bool
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6619, 6641);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10507_6571_6642(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundLiteral
right)
{
var return_v = this_param.Assignment( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6571, 6642);
return return_v;
}


int
f_10507_6553_6643(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6553, 6643);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
f_10507_6680_6719(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
label)
{
var return_v = this_param.Goto( label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6680, 6719);
return return_v;
}


int
f_10507_6662_6720(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6662, 6720);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10507_6757_6783(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
label)
{
var return_v = this_param.Label( label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6757, 6783);
return return_v;
}


int
f_10507_6739_6784(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6739, 6784);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10507_6841_6867(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6841, 6867);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10507_6869_6892(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,bool
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6869, 6892);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10507_6821_6893(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundLiteral
right)
{
var return_v = this_param.Assignment( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6821, 6893);
return return_v;
}


int
f_10507_6803_6894(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6803, 6894);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10507_6931_6971(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
label)
{
var return_v = this_param.Label( label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6931, 6971);
return return_v;
}


int
f_10507_6913_6972(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 6913, 6972);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10507_7076_7101(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
this_param)
{
var return_v = this_param.AllTemps();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 7076, 7101);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10507_7119_7153(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 7119, 7153);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10507_7155_7181(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 7155, 7181);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSpillSequence
f_10507_7053_7182(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundLocal
result)
{
var return_v = this_param.SpillSequence( locals, sideEffects, (Microsoft.CodeAnalysis.CSharp.BoundExpression)result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 7053, 7182);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,5213,7198);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,5213,7198);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static IsPatternExpressionGeneralLocalRewriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10507,4502,7209);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10507,4502,7209);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,4502,7209);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10507,4502,7209);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10507_4669_4711()
{
var return_v = ArrayBuilder<BoundStatement>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 4669, 4711);
return return_v;
}


static Microsoft.CodeAnalysis.SyntaxNode
f_10507_4863_4867_C(Microsoft.CodeAnalysis.SyntaxNode
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10507, 4728, 4945);
return return_v;
}

}

private static bool IsFailureNode(BoundDecisionDagNode node, LabelSymbol whenFalseLabel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10507,7221,7505);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,7334,7409) || true) && (node is BoundWhenDecisionDagNode w)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,7334,7409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,7391,7409);

node = f_10507_7398_7408(w);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,7334,7409);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,7423,7494);

return node is BoundLeafDecisionDagNode l &&(DynAbs.Tracing.TraceSender.Expression_True(10507, 7430, 7493)&&f_10507_7468_7475(l)== whenFalseLabel);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10507,7221,7505);

Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_7398_7408(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
this_param)
{
var return_v = this_param.WhenTrue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 7398, 7408);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_7468_7475(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
this_param)
{
var return_v = this_param.Label ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 7468, 7475);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,7221,7505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,7221,7505);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
private sealed class IsPatternExpressionLinearLocalRewriter : PatternLocalRewriter
{
private readonly ArrayBuilder<BoundExpression> _sideEffectBuilder;

private readonly ArrayBuilder<BoundExpression> _conjunctBuilder;

public IsPatternExpressionLinearLocalRewriter(BoundIsPatternExpression node, LocalRewriter localRewriter)
:base(f_10507_8382_8393_C(node.Syntax) ,localRewriter,generateInstrumentation: false)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10507,8252,8635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,7804,7822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,8219,8235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,8474,8537);

_conjunctBuilder = f_10507_8493_8536();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,8555,8620);

_sideEffectBuilder = f_10507_8576_8619();
DynAbs.Tracing.TraceSender.TraceExitConstructor(10507,8252,8635);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,8252,8635);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,8252,8635);
}
		}

public new void Free()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10507,8651,8819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,8706,8730);

f_10507_8706_8729(                _conjunctBuilder);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,8748,8774);

f_10507_8748_8773(                _sideEffectBuilder);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,8792,8804);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(),10507,8792,8803);
DynAbs.Tracing.TraceSender.TraceExitMethod(10507,8651,8819);

int
f_10507_8706_8729(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 8706, 8729);
return 0;
}


int
f_10507_8748_8773(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 8748, 8773);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,8651,8819);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,8651,8819);
}
		}

private void AddConjunct(BoundExpression test)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10507,8835,9469);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,8993,9060) || true) && (f_10507_9007_9021(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10507_8997_9006(test), 10507, 8997, 9021))!= false)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,8993,9060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,9053,9060);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,8993,9060);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,9080,9146);

f_10507_9080_9145(f_10507_9093_9114(f_10507_9093_9102(test))== SpecialType.System_Boolean);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,9164,9407) || true) && (f_10507_9168_9192(_sideEffectBuilder)!= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,9164,9407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,9239,9339);

test = f_10507_9246_9338(_factory, ImmutableArray<LocalSymbol>.Empty, f_10507_9299_9331(_sideEffectBuilder), test);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,9361,9388);

f_10507_9361_9387(                    _sideEffectBuilder);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,9164,9407);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,9427,9454);

f_10507_9427_9453(
                _conjunctBuilder, test);
DynAbs.Tracing.TraceSender.TraceExitMethod(10507,8835,9469);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10507_8997_9006(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 8997, 9006);
return return_v;
}


bool?
f_10507_9007_9021(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type?.IsErrorType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 9007, 9021);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10507_9093_9102(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 9093, 9102);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10507_9093_9114(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 9093, 9114);
return return_v;
}


int
f_10507_9080_9145(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 9080, 9145);
return 0;
}


int
f_10507_9168_9192(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 9168, 9192);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10507_9299_9331(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 9299, 9331);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_9246_9338(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
result)
{
var return_v = this_param.Sequence( locals, sideEffects, result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 9246, 9338);
return return_v;
}


int
f_10507_9361_9387(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 9361, 9387);
return 0;
}


int
f_10507_9427_9453(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 9427, 9453);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,8835,9469);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,8835,9469);
}
		}

private void LowerOneTest(BoundDagTest test, bool invert = false)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10507,9629,10622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,9727,9757);

_factory.Syntax = test.Syntax;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,9775,10607);

switch (test)
                {

case BoundDagEvaluation eval:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,9775,10607);
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,9915,9954);

var 
sideEffect = f_10507_9932_9953(this, eval)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,9984,10019);

f_10507_9984_10018(                            _sideEffectBuilder, sideEffect);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,10049,10056);

return;
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,9775,10607);

case var _:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,9775,10607);
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,10173,10210);

var 
testExpression = f_10507_10194_10209(this, test)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,10240,10522) || true) && (testExpression != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,10240,10522);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,10332,10427) || true) && (invert)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,10332,10427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,10381,10427);

testExpression = f_10507_10398_10426(_factory, testExpression);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,10332,10427);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,10463,10491);

f_10507_10463_10490(this, testExpression);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,10240,10522);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,10554,10561);

return;
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,9775,10607);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(10507,9629,10622);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_9932_9953(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
evaluation)
{
var return_v = this_param.LowerEvaluation( evaluation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 9932, 9953);
return return_v;
}


int
f_10507_9984_10018(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 9984, 10018);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_10194_10209(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDagTest
test)
{
var return_v = this_param.LowerTest( test);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 10194, 10209);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_10398_10426(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.Not( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 10398, 10426);
return return_v;
}


int
f_10507_10463_10490(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
test)
{
this_param.AddConjunct( test);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 10463, 10490);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,9629,10622);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,9629,10622);
}
		}

public BoundExpression LowerIsPatternAsLinearTestSequence(
                BoundIsPatternExpression isPatternExpression, LabelSymbol whenTrueLabel, LabelSymbol whenFalseLabel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10507,10638,11636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,10847,10910);

BoundDecisionDag 
decisionDag = f_10507_10878_10909(isPatternExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,10928,11022);

BoundExpression 
loweredInput = f_10507_10959_11021(_localRewriter, f_10507_10990_11020(isPatternExpression))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,11370,11483);

decisionDag = f_10507_11384_11482(this, loweredInput, decisionDag, expr => _sideEffectBuilder.Add(expr), out _);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,11501,11533);

var 
node = f_10507_11512_11532(decisionDag)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,11551,11621);

return f_10507_11558_11620(this, node, whenTrueLabel, whenFalseLabel);
DynAbs.Tracing.TraceSender.TraceExitMethod(10507,10638,11636);

Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
f_10507_10878_10909(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.DecisionDag;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 10878, 10909);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_10990_11020(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 10990, 11020);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10507_10959_11021(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 10959, 11021);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
f_10507_11384_11482(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredInput,Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
decisionDag,System.Action<Microsoft.CodeAnalysis.CSharp.BoundExpression>
addCode,out Microsoft.CodeAnalysis.CSharp.BoundExpression
savedInputExpression)
{
var return_v = this_param.ShareTempsAndEvaluateInput( loweredInput, decisionDag, addCode, out savedInputExpression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 11384, 11482);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_11512_11532(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
this_param)
{
var return_v = this_param.RootNode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 11512, 11532);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_11558_11620(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
node,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenTrueLabel,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenFalseLabel)
{
var return_v = this_param.ProduceLinearTestSequence( node, whenTrueLabel, whenFalseLabel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 11558, 11620);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,10638,11636);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,10638,11636);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression ProduceLinearTestSequence(
                BoundDecisionDagNode node,
                LabelSymbol whenTrueLabel,
                LabelSymbol whenFalseLabel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10507,11828,16056);
Microsoft.CodeAnalysis.CSharp.BoundExpression sideEffect = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);
Microsoft.CodeAnalysis.CSharp.BoundExpression testExpression = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,12234,13808) || true) && (f_10507_12241_12250(node)!= BoundKind.LeafDecisionDagNode &&(DynAbs.Tracing.TraceSender.Expression_True(10507, 12241, 12329)&&f_10507_12287_12296(node)!= BoundKind.WhenDecisionDagNode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,12234,13808);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,12371,13789);

switch (node)
                    {

case BoundEvaluationDecisionDagNode evalNode:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,12371,13789);
                            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,12543,12577);

f_10507_12543_12576(this, f_10507_12556_12575(evalNode));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,12611,12632);

node = f_10507_12618_12631(evalNode);
                            }
DynAbs.Tracing.TraceSender.TraceBreak(10507,12693,12699);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,12371,13789);

case BoundTestDecisionDagNode testNode:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,12371,13789);
                            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,12829,13699) || true) && (f_10507_12833_12850(testNode)is BoundEvaluationDecisionDagNode e &&(DynAbs.Tracing.TraceSender.Expression_True(10507, 12833, 13049)&&f_10507_12927_13049(this, f_10507_12951_12964(testNode), f_10507_12966_12978(e), out sideEffect, out testExpression)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,12829,13699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,13123,13158);

f_10507_13123_13157(                                    _sideEffectBuilder, sideEffect);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,13196,13224);

f_10507_13196_13223(this, testExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,13262,13276);

node = f_10507_13269_13275(e);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,12829,13699);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,12829,13699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,13422,13489);

bool 
invertTest = f_10507_13440_13488(f_10507_13454_13471(testNode), whenFalseLabel)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,13527,13567);

f_10507_13527_13566(this, f_10507_13540_13553(testNode), invertTest);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,13605,13664);

node = (DynAbs.Tracing.TraceSender.Conditional_F1(10507, 13612, 13622)||((invertTest &&DynAbs.Tracing.TraceSender.Conditional_F2(10507, 13625, 13643))||DynAbs.Tracing.TraceSender.Conditional_F3(10507, 13646, 13663)))?f_10507_13625_13643(testNode):f_10507_13646_13663(testNode);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,12829,13699);
}
                            }
DynAbs.Tracing.TraceSender.TraceBreak(10507,13760,13766);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,12371,13789);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,12234,13808);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10507,12234,13808);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10507,12234,13808);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,13896,15168);

switch (node)
                {

case BoundLeafDecisionDagNode leafNode:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,13896,15168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,14015,14061);

f_10507_14015_14060(f_10507_14028_14042(leafNode)== whenTrueLabel);
DynAbs.Tracing.TraceSender.TraceBreak(10507,14087,14093);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,13896,15168);

case BoundWhenDecisionDagNode whenNode:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,13896,15168);
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,14213,14259);

f_10507_14213_14258(f_10507_14226_14249(whenNode)== null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,14289,14379);

f_10507_14289_14378(f_10507_14302_14319(whenNode)is BoundLeafDecisionDagNode d &&(DynAbs.Tracing.TraceSender.Expression_True(10507, 14302, 14377)&&f_10507_14353_14360(d)== whenTrueLabel));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,14409,14978);
foreach(BoundPatternBinding binding in f_10507_14449_14466_I(f_10507_14449_14466(whenNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,14409,14978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,14532,14610);

BoundExpression 
left = f_10507_14555_14609(_localRewriter, binding.VariableAccess)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,14644,14720);

BoundExpression 
right = f_10507_14668_14719(_tempAllocator, binding.TempContainingValue)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,14754,14947) || true) && (left != right)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,14754,14947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,14845,14912);

f_10507_14845_14911(                                    _sideEffectBuilder, f_10507_14868_14910(_factory, left, right));
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,14754,14947);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,14409,14978);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10507,1,570);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10507,1,570);
}                        }
DynAbs.Tracing.TraceSender.TraceBreak(10507,15033,15039);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,13896,15168);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,13896,15168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15097,15149);

throw f_10507_15103_15148(f_10507_15138_15147(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,13896,15168);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15188,15348) || true) && (f_10507_15192_15216(_sideEffectBuilder)> 0 ||(DynAbs.Tracing.TraceSender.Expression_False(10507, 15192, 15251)||f_10507_15224_15246(_conjunctBuilder)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,15188,15348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15293,15329);

f_10507_15293_15328(this, f_10507_15305_15327(_factory, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,15188,15348);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15368,15412);

f_10507_15368_15411(f_10507_15381_15405(_sideEffectBuilder)== 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15430,15461);

BoundExpression? 
result = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15479,15670);
foreach(BoundExpression conjunct in f_10507_15516_15532_I(_conjunctBuilder) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,15479,15670);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15574,15651);

result = (DynAbs.Tracing.TraceSender.Conditional_F1(10507, 15583, 15599)||(((result == null) &&DynAbs.Tracing.TraceSender.Conditional_F2(10507, 15602, 15610))||DynAbs.Tracing.TraceSender.Conditional_F3(10507, 15613, 15650)))?conjunct :f_10507_15613_15650(_factory, result, conjunct);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,15479,15670);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10507,1,192);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10507,1,192);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15690,15715);

f_10507_15690_15714(
                _conjunctBuilder);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15733,15762);

f_10507_15733_15761(result != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15780,15821);

var 
allTemps = f_10507_15795_15820(_tempAllocator)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15839,16007) || true) && (allTemps.Length > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10507,15839,16007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,15904,15988);

result = f_10507_15913_15987(_factory, allTemps, ImmutableArray<BoundExpression>.Empty, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10507,15839,16007);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10507,16027,16041);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10507,11828,16056);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10507_12241_12250(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 12241, 12250);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10507_12287_12296(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 12287, 12296);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
f_10507_12556_12575(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
this_param)
{
var return_v = this_param.Evaluation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 12556, 12575);
return return_v;
}


int
f_10507_12543_12576(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
test)
{
this_param.LowerOneTest( (Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 12543, 12576);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_12618_12631(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
this_param)
{
var return_v = this_param.Next;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 12618, 12631);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_12833_12850(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
this_param)
{
var return_v = this_param.WhenTrue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 12833, 12850);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDagTest
f_10507_12951_12964(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
this_param)
{
var return_v = this_param.Test;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 12951, 12964);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
f_10507_12966_12978(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
this_param)
{
var return_v = this_param.Evaluation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 12966, 12978);
return return_v;
}


bool
f_10507_12927_13049(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDagTest
test,Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
evaluation,out Microsoft.CodeAnalysis.CSharp.BoundExpression?
sideEffect,out Microsoft.CodeAnalysis.CSharp.BoundExpression?
testExpression)
{
var return_v = this_param.TryLowerTypeTestAndCast( test, evaluation, out sideEffect, out testExpression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 12927, 13049);
return return_v;
}


int
f_10507_13123_13157(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 13123, 13157);
return 0;
}


int
f_10507_13196_13223(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
test)
{
this_param.AddConjunct( test);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 13196, 13223);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_13269_13275(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
this_param)
{
var return_v = this_param.Next;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 13269, 13275);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_13454_13471(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
this_param)
{
var return_v = this_param.WhenTrue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 13454, 13471);
return return_v;
}


bool
f_10507_13440_13488(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
node,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
whenFalseLabel)
{
var return_v = IsFailureNode( node, whenFalseLabel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 13440, 13488);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDagTest
f_10507_13540_13553(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
this_param)
{
var return_v = this_param.Test;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 13540, 13553);
return return_v;
}


int
f_10507_13527_13566(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDagTest
test,bool
invert)
{
this_param.LowerOneTest( test, invert);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 13527, 13566);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_13625_13643(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
this_param)
{
var return_v = this_param.WhenFalse ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 13625, 13643);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_13646_13663(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
this_param)
{
var return_v = this_param.WhenTrue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 13646, 13663);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_14028_14042(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
this_param)
{
var return_v = this_param.Label ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 14028, 14042);
return return_v;
}


int
f_10507_14015_14060(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 14015, 14060);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10507_14226_14249(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
this_param)
{
var return_v = this_param.WhenExpression ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 14226, 14249);
return return_v;
}


int
f_10507_14213_14258(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 14213, 14258);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
f_10507_14302_14319(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
this_param)
{
var return_v = this_param.WhenTrue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 14302, 14319);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10507_14353_14360(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
this_param)
{
var return_v = this_param.Label ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 14353, 14360);
return return_v;
}


int
f_10507_14289_14378(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 14289, 14378);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
f_10507_14449_14466(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
this_param)
{
var return_v = this_param.Bindings;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 14449, 14466);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10507_14555_14609(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 14555, 14609);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_14668_14719(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
this_param,Microsoft.CodeAnalysis.CSharp.BoundDagTemp
dagTemp)
{
var return_v = this_param.GetTemp( dagTemp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 14668, 14719);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10507_14868_14910(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.AssignmentExpression( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 14868, 14910);
return return_v;
}


int
f_10507_14845_14911(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 14845, 14911);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
f_10507_14449_14466_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 14449, 14466);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10507_15138_15147(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 15138, 15147);
return return_v;
}


System.Exception
f_10507_15103_15148(Microsoft.CodeAnalysis.CSharp.BoundKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 15103, 15148);
return return_v;
}


int
f_10507_15192_15216(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 15192, 15216);
return return_v;
}


int
f_10507_15224_15246(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 15224, 15246);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10507_15305_15327(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,bool
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 15305, 15327);
return return_v;
}


int
f_10507_15293_15328(Microsoft.CodeAnalysis.CSharp.LocalRewriter.IsPatternExpressionLinearLocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
test)
{
this_param.AddConjunct( (Microsoft.CodeAnalysis.CSharp.BoundExpression)test);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 15293, 15328);
return 0;
}


int
f_10507_15381_15405(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10507, 15381, 15405);
return return_v;
}


int
f_10507_15368_15411(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 15368, 15411);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10507_15613_15650(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.LogicalAnd( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 15613, 15650);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10507_15516_15532_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 15516, 15532);
return return_v;
}


int
f_10507_15690_15714(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 15690, 15714);
return 0;
}


int
f_10507_15733_15761(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 15733, 15761);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10507_15795_15820(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
this_param)
{
var return_v = this_param.AllTemps();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 15795, 15820);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10507_15913_15987(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
result)
{
var return_v = this_param.Sequence( locals, sideEffects, result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 15913, 15987);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10507,11828,16056);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,11828,16056);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static IsPatternExpressionLinearLocalRewriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10507,7517,16067);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10507,7517,16067);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10507,7517,16067);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10507,7517,16067);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10507_8493_8536()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 8493, 8536);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10507_8576_8619()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10507, 8576, 8619);
return return_v;
}


static Microsoft.CodeAnalysis.SyntaxNode
f_10507_8382_8393_C(Microsoft.CodeAnalysis.SyntaxNode
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10507, 8252, 8635);
return return_v;
}

}
}
}
