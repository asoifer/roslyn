// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitTryStatement(BoundTryStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10529,468,1755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,560,622);

BoundBlock? 
tryBlock = (BoundBlock?)f_10529_596_621(this, f_10529_607_620(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,636,666);

f_10529_636_665(tryBlock is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,682,711);

var 
origSawAwait = _sawAwait
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,725,743);

_sawAwait = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,759,844);

var 
optimizing = f_10529_776_814(f_10529_776_796(_compilation))== OptimizationLevel.Release
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,858,1170);

ImmutableArray<BoundCatchBlock> 
catchBlocks =
(DynAbs.Tracing.TraceSender.Conditional_F1(10529, 1036, 1077)||((                // When optimizing and we have a try block without side-effects, we can discard the catch blocks.
                (optimizing &&(DynAbs.Tracing.TraceSender.Expression_True(10529, 1037, 1076)&&!f_10529_1052_1076(tryBlock))) &&DynAbs.Tracing.TraceSender.Conditional_F2(10529, 1080, 1117))||DynAbs.Tracing.TraceSender.Conditional_F3(10529, 1137, 1169)))?ImmutableArray<BoundCatchBlock>.Empty
:f_10529_1137_1169(this, f_10529_1152_1168(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,1184,1260);

BoundBlock? 
finallyBlockOpt = (BoundBlock?)f_10529_1227_1259(this, f_10529_1238_1258(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,1276,1317);

_sawAwaitInExceptionHandler |= _sawAwait;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,1331,1357);

_sawAwait |= origSawAwait;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,1373,1495) || true) && (optimizing &&(DynAbs.Tracing.TraceSender.Expression_True(10529, 1377, 1423)&&!f_10529_1392_1423(finallyBlockOpt)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,1373,1495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,1457,1480);

finallyBlockOpt = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,1373,1495);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,1511,1744);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10529, 1518, 1575)||(((catchBlocks.IsDefaultOrEmpty &&(DynAbs.Tracing.TraceSender.Expression_True(10529, 1519, 1574)&&finallyBlockOpt == null))
&&DynAbs.Tracing.TraceSender.Conditional_F2(10529, 1595, 1614))||DynAbs.Tracing.TraceSender.Conditional_F3(10529, 1634, 1743)))?(BoundNode)tryBlock
:(BoundNode)f_10529_1645_1743(node, tryBlock, catchBlocks, finallyBlockOpt, f_10529_1697_1717(node), f_10529_1719_1742(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10529,468,1755);

Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10529_607_620(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
this_param)
{
var return_v = this_param.TryBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 607, 620);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode?
f_10529_596_621(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundBlock
node)
{
var return_v = this_param.Visit( (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 596, 621);
return return_v;
}


int
f_10529_636_665(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 636, 665);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_10529_776_796(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 776, 796);
return return_v;
}


Microsoft.CodeAnalysis.OptimizationLevel
f_10529_776_814(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param)
{
var return_v = this_param.OptimizationLevel ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 776, 814);
return return_v;
}


bool
f_10529_1052_1076(Microsoft.CodeAnalysis.CSharp.BoundBlock
statement)
{
var return_v = HasSideEffects( (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 1052, 1076);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
f_10529_1152_1168(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
this_param)
{
var return_v = this_param.CatchBlocks;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 1152, 1168);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
f_10529_1137_1169(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 1137, 1169);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock?
f_10529_1238_1258(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
this_param)
{
var return_v = this_param.FinallyBlockOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 1238, 1258);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode?
f_10529_1227_1259(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundBlock?
node)
{
var return_v = this_param.Visit( (Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 1227, 1259);
return return_v;
}


bool
f_10529_1392_1423(Microsoft.CodeAnalysis.CSharp.BoundBlock?
statement)
{
var return_v = HasSideEffects( (Microsoft.CodeAnalysis.CSharp.BoundStatement?)statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 1392, 1423);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
f_10529_1697_1717(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
this_param)
{
var return_v = this_param.FinallyLabelOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 1697, 1717);
return return_v;
}


bool
f_10529_1719_1742(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
this_param)
{
var return_v = this_param.PreferFaultHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 1719, 1742);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTryStatement
f_10529_1645_1743(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
this_param,Microsoft.CodeAnalysis.CSharp.BoundBlock
tryBlock,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
catchBlocks,Microsoft.CodeAnalysis.CSharp.BoundBlock?
finallyBlockOpt,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
finallyLabelOpt,bool
preferFaultHandler)
{
var return_v = this_param.Update( tryBlock, catchBlocks, finallyBlockOpt, finallyLabelOpt, preferFaultHandler);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 1645, 1743);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10529,468,1755);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10529,468,1755);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool HasSideEffects([NotNullWhen(true)] BoundStatement? statement)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10529,2094,3312);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,2200,2236) || true) && (statement == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,2200,2236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,2223,2236);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,2200,2236);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,2250,3301);

switch (f_10529_2258_2272(statement))
            {

case BoundKind.NoOpStatement:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,2250,3301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,2357,2370);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,2250,3301);

case BoundKind.Block:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,2250,3301);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,2458,2492);

var 
block = (BoundBlock)statement
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,2518,2678);
foreach(var stmt in f_10529_2539_2555_I(f_10529_2539_2555(block)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,2518,2678);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,2613,2651) || true) && (f_10529_2617_2637(stmt))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,2613,2651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,2639,2651);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,2613,2651);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,2518,2678);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10529,1,161);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10529,1,161);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,2704,2717);

return false;
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,2250,3301);

case BoundKind.SequencePoint:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,2250,3301);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,2836,2881);

var 
sequence = (BoundSequencePoint)statement
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,2907,2952);

return f_10529_2914_2951(f_10529_2929_2950(sequence));
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,2250,3301);

case BoundKind.SequencePointWithSpan:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,2250,3301);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,3079,3132);

var 
sequence = (BoundSequencePointWithSpan)statement
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,3158,3203);

return f_10529_3165_3202(f_10529_3180_3201(sequence));
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,2250,3301);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,2250,3301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,3274,3286);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,2250,3301);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10529,2094,3312);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10529_2258_2272(Microsoft.CodeAnalysis.CSharp.BoundStatement
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 2258, 2272);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10529_2539_2555(Microsoft.CodeAnalysis.CSharp.BoundBlock
this_param)
{
var return_v = this_param.Statements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 2539, 2555);
return return_v;
}


bool
f_10529_2617_2637(Microsoft.CodeAnalysis.CSharp.BoundStatement
statement)
{
var return_v = HasSideEffects( statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 2617, 2637);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10529_2539_2555_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 2539, 2555);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10529_2929_2950(Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
this_param)
{
var return_v = this_param.StatementOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 2929, 2950);
return return_v;
}


bool
f_10529_2914_2951(Microsoft.CodeAnalysis.CSharp.BoundStatement?
statement)
{
var return_v = HasSideEffects( statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 2914, 2951);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10529_3180_3201(Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
this_param)
{
var return_v = this_param.StatementOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 3180, 3201);
return return_v;
}


bool
f_10529_3165_3202(Microsoft.CodeAnalysis.CSharp.BoundStatement?
statement)
{
var return_v = HasSideEffects( statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 3165, 3202);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10529,2094,3312);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10529,2094,3312);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode? VisitCatchBlock(BoundCatchBlock node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10529,3324,5002);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,3413,3531) || true) && (f_10529_3417_3440(node)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,3413,3531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,3482,3516);

return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(node),10529,3489,3515);
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,3413,3531);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,3547,3672) || true) && (f_10529_3551_3602_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10529_3551_3588(f_10529_3551_3574(node)), 10529, 3551, 3602)?.BooleanValue)== false)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,3547,3672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,3645,3657);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,3547,3672);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,3688,3789);

BoundExpression? 
rewrittenExceptionSourceOpt = (BoundExpression?)f_10529_3753_3788(this, f_10529_3764_3787(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,3803,3914);

BoundStatementList? 
rewrittenFilterPrologue = (BoundStatementList?)f_10529_3870_3913(this, f_10529_3881_3912(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,3928,4017);

BoundExpression? 
rewrittenFilter = (BoundExpression?)f_10529_3981_4016(this, f_10529_3992_4015(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,4031,4094);

BoundBlock? 
rewrittenBody = (BoundBlock?)f_10529_4072_4093(this, f_10529_4083_4092(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,4108,4143);

f_10529_4108_4142(rewrittenBody is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,4157,4235);

TypeSymbol? 
rewrittenExceptionTypeOpt = f_10529_4197_4234(this, f_10529_4212_4233(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,4459,4677) || true) && (rewrittenFilter != null &&(DynAbs.Tracing.TraceSender.Expression_True(10529, 4463, 4516)&&f_10529_4490_4516_M(!node.WasCompilerGenerated))&&(DynAbs.Tracing.TraceSender.Expression_True(10529, 4463, 4535)&&f_10529_4520_4535(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10529,4459,4677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,4569,4662);

rewrittenFilter = f_10529_4587_4661(_instrumenter, node, rewrittenFilter, _factory);
DynAbs.Tracing.TraceSender.TraceExitCondition(10529,4459,4677);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10529,4693,4991);

return f_10529_4700_4990(node, f_10529_4730_4741(node), rewrittenExceptionSourceOpt, rewrittenExceptionTypeOpt, rewrittenFilterPrologue, rewrittenFilter, rewrittenBody, f_10529_4958_4989(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10529,3324,5002);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10529_3417_3440(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
this_param)
{
var return_v = this_param.ExceptionFilterOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 3417, 3440);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10529_3551_3574(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
this_param)
{
var return_v = this_param.ExceptionFilterOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 3551, 3574);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10529_3551_3588(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 3551, 3588);
return return_v;
}


bool?
f_10529_3551_3602_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 3551, 3602);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10529_3764_3787(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
this_param)
{
var return_v = this_param.ExceptionSourceOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 3764, 3787);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode?
f_10529_3753_3788(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.Visit( (Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 3753, 3788);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatementList?
f_10529_3881_3912(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
this_param)
{
var return_v = this_param.ExceptionFilterPrologueOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 3881, 3912);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode?
f_10529_3870_3913(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatementList?
node)
{
var return_v = this_param.Visit( (Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 3870, 3913);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10529_3992_4015(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
this_param)
{
var return_v = this_param.ExceptionFilterOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 3992, 4015);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode?
f_10529_3981_4016(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.Visit( (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 3981, 4016);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10529_4083_4092(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 4083, 4092);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode?
f_10529_4072_4093(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundBlock
node)
{
var return_v = this_param.Visit( (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 4072, 4093);
return return_v;
}


int
f_10529_4108_4142(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 4108, 4142);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10529_4212_4233(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
this_param)
{
var return_v = this_param.ExceptionTypeOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 4212, 4233);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10529_4197_4234(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type)
{
var return_v = this_param.VisitType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 4197, 4234);
return return_v;
}


bool
f_10529_4490_4516_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 4490, 4516);
return return_v;
}


bool
f_10529_4520_4535(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 4520, 4535);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10529_4587_4661(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
original,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenFilter,Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
factory)
{
var return_v = this_param.InstrumentCatchClauseFilter( original, rewrittenFilter, factory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 4587, 4661);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10529_4730_4741(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 4730, 4741);
return return_v;
}


bool
f_10529_4958_4989(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
this_param)
{
var return_v = this_param.IsSynthesizedAsyncCatchAll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10529, 4958, 4989);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
f_10529_4700_4990(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,Microsoft.CodeAnalysis.CSharp.BoundExpression?
exceptionSourceOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
exceptionTypeOpt,Microsoft.CodeAnalysis.CSharp.BoundStatementList?
exceptionFilterPrologueOpt,Microsoft.CodeAnalysis.CSharp.BoundExpression?
exceptionFilterOpt,Microsoft.CodeAnalysis.CSharp.BoundBlock
body,bool
isSynthesizedAsyncCatchAll)
{
var return_v = this_param.Update( locals, exceptionSourceOpt, exceptionTypeOpt, exceptionFilterPrologueOpt, exceptionFilterOpt, body, isSynthesizedAsyncCatchAll);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10529, 4700, 4990);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10529,3324,5002);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10529,3324,5002);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
