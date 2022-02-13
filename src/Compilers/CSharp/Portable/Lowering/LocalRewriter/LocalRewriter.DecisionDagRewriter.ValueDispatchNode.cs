// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
internal partial class LocalRewriter
{private abstract partial class DecisionDagRewriter
{private abstract class ValueDispatchNode
{
protected virtual int Height {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,826,830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,829,830);
return 1;DynAbs.Tracing.TraceSender.TraceExitMethod(10475,826,830);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,826,830);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,826,830);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected virtual int Weight {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,889,893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,892,893);
return 1;DynAbs.Tracing.TraceSender.TraceExitMethod(10475,889,893);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,889,893);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,889,893);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public readonly SyntaxNode Syntax;

public ValueDispatchNode(SyntaxNode syntax) 		{
			try
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(10475,974,1037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,947,953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,1021,1036);
Syntax = syntax;DynAbs.Tracing.TraceSender.TraceExitConstructor(10475,974,1037);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,974,1037);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,974,1037);
}
		}
internal sealed class SwitchDispatch : ValueDispatchNode
{
public readonly ImmutableArray<(ConstantValue value, LabelSymbol label)> Cases;

public readonly LabelSymbol Otherwise;

public SwitchDispatch(SyntaxNode syntax, ImmutableArray<(ConstantValue value, LabelSymbol label)> dispatches, LabelSymbol otherwise) :base(f_10475_1745_1751_C(syntax) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10475,1605,1901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,1573,1582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,1801,1825);

this.Cases = dispatches;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,1851,1878);

this.Otherwise = otherwise;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10475,1605,1901);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,1605,1901);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,1605,1901);
}
		}

public override string ToString() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,1957,2016);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,1960,2016);
return "[" + f_10475_1966_2010(",", Cases.Select(c => c.value))+ "]";DynAbs.Tracing.TraceSender.TraceExitMethod(10475,1957,2016);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,1957,2016);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,1957,2016);
}
			throw new System.Exception("Slicer error: unreachable code");

string
f_10475_1966_2010(string
separator,System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ConstantValue>
values)
{
var return_v = string.Join( separator, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 1966, 2010);
return return_v;
}

		}

static SwitchDispatch()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10475,1347,2036);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10475,1347,2036);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,1347,2036);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10475,1347,2036);

static Microsoft.CodeAnalysis.SyntaxNode
f_10475_1745_1751_C(Microsoft.CodeAnalysis.SyntaxNode
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10475, 1605, 1901);
return return_v;
}

}
internal sealed class LeafDispatchNode : ValueDispatchNode
{
public readonly LabelSymbol Label;

public LeafDispatchNode(SyntaxNode syntax, LabelSymbol Label) :base(f_10475_2439_2445_C(syntax) ) 		{
			try
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(10475,2370,2469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,2342,2347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,2450,2468);
this.Label = Label;DynAbs.Tracing.TraceSender.TraceExitConstructor(10475,2370,2469);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,2370,2469);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,2370,2469);
}
		}

public override string ToString() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,2525,2534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,2528,2534);
return "Leaf";DynAbs.Tracing.TraceSender.TraceExitMethod(10475,2525,2534);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,2525,2534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,2525,2534);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static LeafDispatchNode()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10475,2215,2554);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10475,2215,2554);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,2215,2554);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10475,2215,2554);
}
internal sealed class RelationalDispatch : ValueDispatchNode
{
private int _height;

private int _weight;

protected override int Height {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,3845,3855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,3848,3855);
return _height;DynAbs.Tracing.TraceSender.TraceExitMethod(10475,3845,3855);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,3845,3855);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,3845,3855);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override int Weight {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,3919,3929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,3922,3929);
return _weight;DynAbs.Tracing.TraceSender.TraceExitMethod(10475,3919,3929);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,3919,3929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,3919,3929);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public readonly ConstantValue Value;

public readonly BinaryOperatorKind Operator;

private ValueDispatchNode Left {get; set; }

private ValueDispatchNode Right {get; set; }

private RelationalDispatch(SyntaxNode syntax, ConstantValue value, BinaryOperatorKind op, ValueDispatchNode left, ValueDispatchNode right) :base(f_10475_4666_4672_C(syntax) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10475,4520,4928);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,3722,3729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,3775,3782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,3990,3995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,4053,4061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,4235,4279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,4453,4498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,4722,4759);

f_10475_4722_4758(f_10475_4735_4752(op)!= 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,4785,4804);

this.Value = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,4830,4849);

this.Operator = op;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,4875,4905);

f_10475_4875_4904(this, left, right);
DynAbs.Tracing.TraceSender.TraceExitConstructor(10475,4520,4928);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,4520,4928);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,4520,4928);
}
		}

public ValueDispatchNode WhenTrue {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,4984,5022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,4987,5022);
return (DynAbs.Tracing.TraceSender.Conditional_F1(10475, 4987, 5007)||((f_10475_4987_5007(Operator)&&DynAbs.Tracing.TraceSender.Conditional_F2(10475, 5010, 5015))||DynAbs.Tracing.TraceSender.Conditional_F3(10475, 5018, 5022)))?f_10475_5010_5015():f_10475_5018_5022();DynAbs.Tracing.TraceSender.TraceExitMethod(10475,4984,5022);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,4984,5022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,4984,5022);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public ValueDispatchNode WhenFalse {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,5080,5118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,5083,5118);
return (DynAbs.Tracing.TraceSender.Conditional_F1(10475, 5083, 5103)||((f_10475_5083_5103(Operator)&&DynAbs.Tracing.TraceSender.Conditional_F2(10475, 5106, 5110))||DynAbs.Tracing.TraceSender.Conditional_F3(10475, 5113, 5118)))?f_10475_5106_5110():f_10475_5113_5118();DynAbs.Tracing.TraceSender.TraceExitMethod(10475,5080,5118);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,5080,5118);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,5080,5118);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string ToString() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,5175,5254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,5178,5254);
return $"RelationalDispatch.{f_10475_5200_5206()}({f_10475_5209_5213()} {f_10475_5216_5235(Operator)} {Value} {f_10475_5246_5251()})";DynAbs.Tracing.TraceSender.TraceExitMethod(10475,5175,5254);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,5175,5254);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,5175,5254);
}
			throw new System.Exception("Slicer error: unreachable code");

int
f_10475_5200_5206()
{
var return_v = Height;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 5200, 5206);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_5209_5213()
{
var return_v = Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 5209, 5213);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10475_5216_5235(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 5216, 5235);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_5246_5251()
{
var return_v = Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 5246, 5251);
return return_v;
}

		}

private static bool IsReversed(BinaryOperatorKind op) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,5514,5639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,5517,5639);
return f_10475_5517_5530(op)switch { BinaryOperatorKind.GreaterThan when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,5540,5578) && DynAbs.Tracing.TraceSender.Expression_True(10475,5540,5578))
=> true, BinaryOperatorKind.GreaterThanOrEqual when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,5580,5625) && DynAbs.Tracing.TraceSender.Expression_True(10475,5580,5625))
=> true, _ when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,5627,5637) && DynAbs.Tracing.TraceSender.Expression_True(10475,5627,5637))
=> false };DynAbs.Tracing.TraceSender.TraceExitMethod(10475,5514,5639);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,5514,5639);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,5514,5639);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10475_5517_5530(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 5517, 5530);
return return_v;
}

		}

private RelationalDispatch WithLeftAndRight(ValueDispatchNode left, ValueDispatchNode right)
		{
			try
                    {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,5664,6577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6010,6030);

int 
l = f_10475_6018_6029(left)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6056,6077);

int 
r = f_10475_6064_6076(right)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6103,6138);

f_10475_6103_6137(f_10475_6116_6131(l - r)<= 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6166,6183);

this.Left = left;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6209,6228);

this.Right = right;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6254,6283);

_height = f_10475_6264_6278(l, r)+ 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6320,6361);

_weight = f_10475_6330_6341(left)+ f_10475_6344_6356(right)+ 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6462,6508);

f_10475_6462_6507(_height < 2 * f_10475_6489_6506(_weight));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6542,6554);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(10475,5664,6577);

int
f_10475_6018_6029(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 6018, 6029);
return return_v;
}


int
f_10475_6064_6076(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 6064, 6076);
return return_v;
}


int
f_10475_6116_6131(int
value)
{
var return_v = Math.Abs( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 6116, 6131);
return return_v;
}


int
f_10475_6103_6137(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 6103, 6137);
return 0;
}


int
f_10475_6264_6278(int
val1,int
val2)
{
var return_v = Math.Max( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 6264, 6278);
return return_v;
}


int
f_10475_6330_6341(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Weight ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 6330, 6341);
return return_v;
}


int
f_10475_6344_6356(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Weight ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 6344, 6356);
return return_v;
}


double
f_10475_6489_6506(int
d)
{
var return_v = Math.Log( (double)d);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 6489, 6506);
return return_v;
}


int
f_10475_6462_6507(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 6462, 6507);
return 0;
}

                    }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,5664,6577);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,5664,6577);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public RelationalDispatch WithTrueAndFalseChildren(ValueDispatchNode whenTrue, ValueDispatchNode whenFalse)
		{
			try
                    {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10475,6601,7225);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6757,6860) || true) && (whenTrue == f_10475_6773_6786(this)&&(DynAbs.Tracing.TraceSender.Expression_True(10475, 6761, 6817)&&whenFalse == f_10475_6803_6817(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10475,6757,6860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6848,6860);

return this;
DynAbs.Tracing.TraceSender.TraceExitCondition(10475,6757,6860);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6888,6942);

f_10475_6888_6941(f_10475_6901_6916(whenTrue)== f_10475_6920_6940(f_10475_6920_6933(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,6968,7024);

f_10475_6968_7023(f_10475_6981_6997(whenFalse)== f_10475_7001_7022(f_10475_7001_7015(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,7050,7139);

var (left, right) = (DynAbs.Tracing.TraceSender.Conditional_F1(10475, 7070, 7090)||((f_10475_7070_7090(Operator)&&DynAbs.Tracing.TraceSender.Conditional_F2(10475, 7093, 7114))||DynAbs.Tracing.TraceSender.Conditional_F3(10475, 7117, 7138)))?(whenFalse, whenTrue) :(whenTrue, whenFalse);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,7165,7202);

return f_10475_7172_7201(this, left, right);
DynAbs.Tracing.TraceSender.TraceExitMethod(10475,6601,7225);

Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_6773_6786(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.WhenTrue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 6773, 6786);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_6803_6817(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.WhenFalse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 6803, 6817);
return return_v;
}


int
f_10475_6901_6916(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 6901, 6916);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_6920_6933(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.WhenTrue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 6920, 6933);
return return_v;
}


int
f_10475_6920_6940(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 6920, 6940);
return return_v;
}


int
f_10475_6888_6941(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 6888, 6941);
return 0;
}


int
f_10475_6981_6997(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 6981, 6997);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_7001_7015(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.WhenFalse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 7001, 7015);
return return_v;
}


int
f_10475_7001_7022(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 7001, 7022);
return return_v;
}


int
f_10475_6968_7023(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 6968, 7023);
return 0;
}


bool
f_10475_7070_7090(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op)
{
var return_v = IsReversed( op);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 7070, 7090);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_7172_7201(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = this_param.WithLeftAndRight( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 7172, 7201);
return return_v;
}

                    }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,6601,7225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,6601,7225);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static ValueDispatchNode CreateBalanced(SyntaxNode syntax, ConstantValue value, BinaryOperatorKind op, ValueDispatchNode whenTrue, ValueDispatchNode whenFalse)
		{
			try
                    {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10475,7249,7767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,7564,7647);

var (left, right) = (DynAbs.Tracing.TraceSender.Conditional_F1(10475, 7584, 7598)||((f_10475_7584_7598(op)&&DynAbs.Tracing.TraceSender.Conditional_F2(10475, 7601, 7622))||DynAbs.Tracing.TraceSender.Conditional_F3(10475, 7625, 7646)))?(whenFalse, whenTrue) :(whenTrue, whenFalse);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,7673,7744);

return f_10475_7680_7743(syntax, value, op, left: left, right: right);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10475,7249,7767);

bool
f_10475_7584_7598(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op)
{
var return_v = IsReversed( op);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 7584, 7598);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_7680_7743(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
value,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = CreateBalancedCore( syntax, value, op, left: left, right: right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 7680, 7743);
return return_v;
}

                    }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,7249,7767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,7249,7767);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ValueDispatchNode CreateBalancedCore(SyntaxNode syntax, ConstantValue value, BinaryOperatorKind op, ValueDispatchNode left, ValueDispatchNode right)
		{
			try
                    {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10475,7791,14405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,8003,8040);

f_10475_8003_8039(f_10475_8016_8033(op)!= 0);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,8402,9193) || true) && (f_10475_8406_8417(left)> (f_10475_8421_8433(right)+ 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10475,8402,9193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,8496,8529);

var 
l = (RelationalDispatch)left
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,8559,8641);

var 
newRight = f_10475_8574_8640(syntax, value, op, left: f_10475_8618_8625(l), right: right)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,8671,8756);

(syntax, value, op, left, right) = (l.Syntax, l.Value, l.Operator, f_10475_8738_8744(l), newRight);
DynAbs.Tracing.TraceSender.TraceExitCondition(10475,8402,9193);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10475,8402,9193);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,8814,9193) || true) && (f_10475_8818_8830(right)> (f_10475_8834_8845(left)+ 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10475,8814,9193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,8908,8942);

var 
r = (RelationalDispatch)right
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,8972,9051);

var 
newLeft = f_10475_8986_9050(syntax, value, op, left: left, right: f_10475_9043_9049(r))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,9081,9166);

(syntax, value, op, left, right) = (r.Syntax, r.Value, r.Operator, newLeft, f_10475_9157_9164(r));
DynAbs.Tracing.TraceSender.TraceExitCondition(10475,8814,9193);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10475,8402,9193);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,9323,9379);

f_10475_9323_9378(f_10475_9336_9372(f_10475_9345_9356(left)- f_10475_9359_9371(right))<= 2);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,9550,14037) || true) && (f_10475_9554_9565(left)== f_10475_9569_9581(right)+ 2)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10475,9550,14037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,9643,9687);

var 
leftDispatch = (RelationalDispatch)left
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,9717,11750) || true) && (f_10475_9721_9745(f_10475_9721_9738(leftDispatch))== f_10475_9749_9761(right))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10475,9717,11750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,10314,10335);

var 
x = leftDispatch
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,10369,10384);

var 
A = f_10475_10377_10383(x)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,10418,10454);

var 
y = (RelationalDispatch)f_10475_10446_10453(x)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,10488,10503);

var 
B = f_10475_10496_10502(y)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,10537,10553);

var 
C = f_10475_10545_10552(y)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,10587,10601);

var 
D = right
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,10635,10736);

return f_10475_10642_10735(y, f_10475_10661_10685(x, A, B), f_10475_10687_10734(syntax, value, op, C, D));
DynAbs.Tracing.TraceSender.TraceExitCondition(10475,9717,11750);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10475,9717,11750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,10866,10922);

f_10475_10866_10921(f_10475_10879_10904(f_10475_10879_10897(leftDispatch))== f_10475_10908_10920(right));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,11439,11460);

var 
y = leftDispatch
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,11494,11509);

var 
x = f_10475_11502_11508(y)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,11543,11559);

var 
C = f_10475_11551_11558(y)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,11593,11607);

var 
D = right
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,11641,11719);

return f_10475_11648_11718(y, x, f_10475_11670_11717(syntax, value, op, C, D));
DynAbs.Tracing.TraceSender.TraceExitCondition(10475,9717,11750);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10475,9550,14037);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10475,9550,14037);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,11808,14037) || true) && (f_10475_11812_11824(right)== f_10475_11828_11839(left)+ 2)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10475,11808,14037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,11901,11947);

var 
rightDispatch = (RelationalDispatch)right
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,11977,14010) || true) && (f_10475_11981_12007(f_10475_11981_12000(rightDispatch))== f_10475_12011_12022(left))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10475,11977,14010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,12571,12584);

var 
A = left
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,12618,12640);

var 
z = rightDispatch
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,12674,12709);

var 
y = (RelationalDispatch)f_10475_12702_12708(z)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,12743,12758);

var 
B = f_10475_12751_12757(y)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,12792,12808);

var 
C = f_10475_12800_12807(y)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,12842,12858);

var 
D = f_10475_12850_12857(z)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,12892,12993);

return f_10475_12899_12992(y, f_10475_12918_12965(syntax, value, op, A, B), f_10475_12967_12991(z, C, D));
DynAbs.Tracing.TraceSender.TraceExitCondition(10475,11977,14010);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10475,11977,14010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,13123,13178);

f_10475_13123_13177(f_10475_13136_13161(f_10475_13136_13154(rightDispatch))== f_10475_13165_13176(left));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,13699,13712);

var 
A = left
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,13746,13768);

var 
y = rightDispatch
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,13802,13817);

var 
B = f_10475_13810_13816(y)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,13851,13867);

var 
z = f_10475_13859_13866(y)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,13901,13979);

return f_10475_13908_13978(y, f_10475_13927_13974(syntax, value, op, A, B), z);
DynAbs.Tracing.TraceSender.TraceExitCondition(10475,11977,14010);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10475,11808,14037);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10475,9550,14037);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,14226,14281);

f_10475_14226_14280(f_10475_14239_14275(f_10475_14248_14259(left)- f_10475_14262_14274(right))< 2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10475,14307,14382);

return f_10475_14314_14381(syntax, value, op, left: left, right: right);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10475,7791,14405);

Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10475_8016_8033(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 8016, 8033);
return return_v;
}


int
f_10475_8003_8039(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 8003, 8039);
return 0;
}


int
f_10475_8406_8417(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 8406, 8417);
return return_v;
}


int
f_10475_8421_8433(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 8421, 8433);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_8618_8625(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 8618, 8625);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_8574_8640(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
value,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = CreateBalancedCore( syntax, value, op, left: left, right: right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 8574, 8640);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_8738_8744(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 8738, 8744);
return return_v;
}


int
f_10475_8818_8830(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 8818, 8830);
return return_v;
}


int
f_10475_8834_8845(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 8834, 8845);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_9043_9049(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 9043, 9049);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_8986_9050(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
value,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = CreateBalancedCore( syntax, value, op, left: left, right: right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 8986, 9050);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_9157_9164(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 9157, 9164);
return return_v;
}


int
f_10475_9345_9356(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 9345, 9356);
return return_v;
}


int
f_10475_9359_9371(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 9359, 9371);
return return_v;
}


int
f_10475_9336_9372(int
value)
{
var return_v = Math.Abs( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 9336, 9372);
return return_v;
}


int
f_10475_9323_9378(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 9323, 9378);
return 0;
}


int
f_10475_9554_9565(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 9554, 9565);
return return_v;
}


int
f_10475_9569_9581(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 9569, 9581);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_9721_9738(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 9721, 9738);
return return_v;
}


int
f_10475_9721_9745(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 9721, 9745);
return return_v;
}


int
f_10475_9749_9761(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 9749, 9761);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_10377_10383(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 10377, 10383);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_10446_10453(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 10446, 10453);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_10496_10502(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 10496, 10502);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_10545_10552(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 10545, 10552);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_10661_10685(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = this_param.WithLeftAndRight( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 10661, 10685);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_10687_10734(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
value,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch( syntax, value, op, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 10687, 10734);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_10642_10735(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
right)
{
var return_v = this_param.WithLeftAndRight( (Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode)left, (Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode)right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 10642, 10735);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_10879_10897(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 10879, 10897);
return return_v;
}


int
f_10475_10879_10904(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 10879, 10904);
return return_v;
}


int
f_10475_10908_10920(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 10908, 10920);
return return_v;
}


int
f_10475_10866_10921(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 10866, 10921);
return 0;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_11502_11508(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 11502, 11508);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_11551_11558(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 11551, 11558);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_11670_11717(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
value,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch( syntax, value, op, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 11670, 11717);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_11648_11718(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
right)
{
var return_v = this_param.WithLeftAndRight( left, (Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode)right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 11648, 11718);
return return_v;
}


int
f_10475_11812_11824(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 11812, 11824);
return return_v;
}


int
f_10475_11828_11839(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 11828, 11839);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_11981_12000(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 11981, 12000);
return return_v;
}


int
f_10475_11981_12007(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 11981, 12007);
return return_v;
}


int
f_10475_12011_12022(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 12011, 12022);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_12702_12708(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 12702, 12708);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_12751_12757(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 12751, 12757);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_12800_12807(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 12800, 12807);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_12850_12857(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 12850, 12857);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_12918_12965(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
value,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch( syntax, value, op, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 12918, 12965);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_12967_12991(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = this_param.WithLeftAndRight( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 12967, 12991);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_12899_12992(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
right)
{
var return_v = this_param.WithLeftAndRight( (Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode)left, (Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode)right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 12899, 12992);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_13136_13154(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 13136, 13154);
return return_v;
}


int
f_10475_13136_13161(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 13136, 13161);
return return_v;
}


int
f_10475_13165_13176(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 13165, 13176);
return return_v;
}


int
f_10475_13123_13177(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 13123, 13177);
return 0;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_13810_13816(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 13810, 13816);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_13859_13866(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 13859, 13866);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_13927_13974(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
value,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch( syntax, value, op, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 13927, 13974);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_13908_13978(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = this_param.WithLeftAndRight( (Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 13908, 13978);
return return_v;
}


int
f_10475_14248_14259(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 14248, 14259);
return return_v;
}


int
f_10475_14262_14274(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
this_param)
{
var return_v = this_param.Height;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 14262, 14274);
return return_v;
}


int
f_10475_14239_14275(int
value)
{
var return_v = Math.Abs( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 14239, 14275);
return return_v;
}


int
f_10475_14226_14280(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 14226, 14280);
return 0;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_14314_14381(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
value,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch( syntax, value, op, left: left, right: right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 14314, 14381);
return return_v;
}

                    }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10475,7791,14405);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,7791,14405);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static RelationalDispatch()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10475,3609,14424);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10475,3609,14424);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,3609,14424);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10475,3609,14424);

Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10475_4735_4752(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 4735, 4752);
return return_v;
}


int
f_10475_4722_4758(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 4722, 4758);
return 0;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
f_10475_4875_4904(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode.RelationalDispatch
this_param,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
left,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
right)
{
var return_v = this_param.WithLeftAndRight( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 4875, 4904);
return return_v;
}


static Microsoft.CodeAnalysis.SyntaxNode
f_10475_4666_4672_C(Microsoft.CodeAnalysis.SyntaxNode
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10475, 4520, 4928);
return return_v;
}


bool
f_10475_4987_5007(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op)
{
var return_v = IsReversed( op);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 4987, 5007);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_5010_5015()
{
var return_v = Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 5010, 5015);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_5018_5022()
{
var return_v = Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 5018, 5022);
return return_v;
}


bool
f_10475_5083_5103(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
op)
{
var return_v = IsReversed( op);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10475, 5083, 5103);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_5106_5110()
{
var return_v = Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 5106, 5110);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DecisionDagRewriter.ValueDispatchNode
f_10475_5113_5118()
{
var return_v = Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10475, 5113, 5118);
return return_v;
}

}

static ValueDispatchNode()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10475,724,14439);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10475,724,14439);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10475,724,14439);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10475,724,14439);

static Microsoft.CodeAnalysis.SyntaxNode
f_10475_2439_2445_C(Microsoft.CodeAnalysis.SyntaxNode
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10475, 2370, 2469);
return return_v;
}

}
}
}
}
