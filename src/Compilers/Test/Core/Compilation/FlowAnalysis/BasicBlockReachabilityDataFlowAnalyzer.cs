// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Threading;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
internal sealed class BasicBlockReachabilityDataFlowAnalyzer : DataFlowAnalyzer<bool>
{
private BitVector _visited ;

private BasicBlockReachabilityDataFlowAnalyzer() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25139,494,546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,457,483);
this._visited = BitVector.Empty;DynAbs.Tracing.TraceSender.TraceExitConstructor(25139,494,546);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25139,494,546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,494,546);
}
		}

public static BitVector Run(ControlFlowGraph controlFlowGraph)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25139,558,858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,645,705);

var 
analyzer = f_25139_660_704()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,719,808);

_ = f_25139_723_807(controlFlowGraph, analyzer, CancellationToken.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,822,847);

return analyzer._visited;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25139,558,858);

Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockReachabilityDataFlowAnalyzer
f_25139_660_704()
{
var return_v = new Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockReachabilityDataFlowAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25139, 660, 704);
return return_v;
}


bool
f_25139_723_807(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
controlFlowGraph,Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockReachabilityDataFlowAnalyzer
analyzer,System.Threading.CancellationToken
cancellationToken)
{
var return_v = CustomDataFlowAnalysis<bool>.Run( controlFlowGraph, (Microsoft.CodeAnalysis.FlowAnalysis.DataFlowAnalyzer<bool>)analyzer, cancellationToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25139, 723, 807);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25139,558,858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,558,858);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool AnalyzeUnreachableBlocks {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25139,1142,1150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,1145,1150);
return false;DynAbs.Tracing.TraceSender.TraceExitMethod(25139,1142,1150);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25139,1142,1150);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,1142,1150);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool AnalyzeBlock(BasicBlock basicBlock, CancellationToken cancellationToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25139,1163,1391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,1281,1354);

f_25139_1281_1353(this, basicBlock, isReachable: true, cancellationToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,1368,1380);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(25139,1163,1391);

int
f_25139_1281_1353(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockReachabilityDataFlowAnalyzer
this_param,Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
basicBlock,bool
isReachable,System.Threading.CancellationToken
cancellationToken)
{
this_param.SetCurrentAnalysisData( basicBlock, isReachable: isReachable, cancellationToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25139, 1281, 1353);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25139,1163,1391);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,1163,1391);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool AnalyzeNonConditionalBranch(BasicBlock basicBlock, bool currentIsReachable, CancellationToken cancellationToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25139,1403,1966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,1880,1913);

f_25139_1880_1912(currentIsReachable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,1929,1955);

return currentIsReachable;
DynAbs.Tracing.TraceSender.TraceExitMethod(25139,1403,1966);

int
f_25139_1880_1912(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25139, 1880, 1912);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25139,1403,1966);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,1403,1966);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override (bool fallThroughSuccessorData, bool conditionalSuccessorData) AnalyzeConditionalBranch(
            BasicBlock basicBlock,
            bool currentIsReachable,
            CancellationToken cancellationToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25139,1978,2706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,2598,2631);

f_25139_2598_2630(currentIsReachable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,2647,2695);

return (currentIsReachable, currentIsReachable);
DynAbs.Tracing.TraceSender.TraceExitMethod(25139,1978,2706);

int
f_25139_2598_2630(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25139, 2598, 2630);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25139,1978,2706);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,1978,2706);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void SetCurrentAnalysisData(BasicBlock basicBlock, bool isReachable, CancellationToken cancellationToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25139,2718,2918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,2864,2907);

_visited[f_25139_2873_2891(basicBlock)] = isReachable;
DynAbs.Tracing.TraceSender.TraceExitMethod(25139,2718,2918);

int
f_25139_2873_2891(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
this_param)
{
var return_v = this_param.Ordinal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25139, 2873, 2891);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25139,2718,2918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,2718,2918);
}
		}

public override bool GetCurrentAnalysisData(BasicBlock basicBlock) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25139,2997,3028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,3000,3028);
return _visited[f_25139_3009_3027(basicBlock)];DynAbs.Tracing.TraceSender.TraceExitMethod(25139,2997,3028);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25139,2997,3028);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,2997,3028);
}
			throw new System.Exception("Slicer error: unreachable code");

int
f_25139_3009_3027(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
this_param)
{
var return_v = this_param.Ordinal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25139, 3009, 3027);
return return_v;
}

		}

public override bool GetEmptyAnalysisData() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25139,3149,3157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,3152,3157);
return false;DynAbs.Tracing.TraceSender.TraceExitMethod(25139,3149,3157);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25139,3149,3157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,3149,3157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool Merge(bool predecessor1IsReachable, bool predecessor2IsReachable, CancellationToken cancellationToken)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25139,3401,3454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,3404,3454);
return predecessor1IsReachable ||(DynAbs.Tracing.TraceSender.Expression_False(25139, 3404, 3454)||predecessor2IsReachable);DynAbs.Tracing.TraceSender.TraceExitMethod(25139,3401,3454);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25139,3401,3454);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,3401,3454);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool IsEqual(bool isReachable1, bool isReachable2)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25139,3547,3578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25139,3550,3578);
return isReachable1 == isReachable2;DynAbs.Tracing.TraceSender.TraceExitMethod(25139,3547,3578);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25139,3547,3578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,3547,3578);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static BasicBlockReachabilityDataFlowAnalyzer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25139,337,3586);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25139,337,3586);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25139,337,3586);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25139,337,3586);
}
}
