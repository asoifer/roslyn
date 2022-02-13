// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitPointerElementAccess(BoundPointerElementAccess node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10518,370,749);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,478,569);

BoundExpression 
rewrittenExpression = f_10518_516_568(this, f_10518_552_567(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,583,644);

BoundExpression 
rewrittenIndex = f_10518_616_643(this, f_10518_632_642(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,660,738);

return f_10518_667_737(this, node, rewrittenExpression, rewrittenIndex);
DynAbs.Tracing.TraceSender.TraceExitMethod(10518,370,749);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10518_552_567(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 552, 567);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10518_516_568(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver)
{
var return_v = this_param.LowerReceiverOfPointerElementAccess( receiver);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 516, 568);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10518_632_642(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
this_param)
{
var return_v = this_param.Index;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 632, 642);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10518_616_643(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 616, 643);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10518_667_737(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
node,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenExpression,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenIndex)
{
var return_v = this_param.RewritePointerElementAccess( node, rewrittenExpression, rewrittenIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 667, 737);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10518,370,749);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10518,370,749);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression LowerReceiverOfPointerElementAccess(BoundExpression receiver)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10518,761,1424);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,871,1364) || true) && (receiver is BoundFieldAccess fieldAccess &&(DynAbs.Tracing.TraceSender.Expression_True(10518, 875, 960)&&f_10518_919_960(f_10518_919_942(fieldAccess))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10518,871,1364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,994,1062);

var 
loweredFieldReceiver = f_10518_1021_1061(this, f_10518_1037_1060(fieldAccess))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,1080,1232);

fieldAccess = f_10518_1094_1231(fieldAccess, loweredFieldReceiver, f_10518_1135_1158(fieldAccess), f_10518_1160_1188(fieldAccess), f_10518_1190_1212(fieldAccess), f_10518_1214_1230(fieldAccess));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,1250,1349);

return f_10518_1257_1348(receiver.Syntax, fieldAccess, isManaged: true, f_10518_1331_1347(fieldAccess));
DynAbs.Tracing.TraceSender.TraceExitCondition(10518,871,1364);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,1380,1413);

return f_10518_1387_1412(this, receiver);
DynAbs.Tracing.TraceSender.TraceExitMethod(10518,761,1424);

Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_10518_919_942(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.FieldSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 919, 942);
return return_v;
}


bool
f_10518_919_960(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.IsFixedSizeBuffer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 919, 960);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10518_1037_1060(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 1037, 1060);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10518_1021_1061(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 1021, 1061);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_10518_1135_1158(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.FieldSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 1135, 1158);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10518_1160_1188(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.ConstantValueOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 1160, 1188);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10518_1190_1212(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 1190, 1212);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10518_1214_1230(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 1214, 1230);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
f_10518_1094_1231(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
fieldSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
typeSymbol)
{
var return_v = this_param.Update( receiver, fieldSymbol, constantValueOpt, resultKind, typeSymbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 1094, 1231);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10518_1331_1347(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 1331, 1347);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
f_10518_1257_1348(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
operand,bool
isManaged,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, isManaged: isManaged, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 1257, 1348);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10518_1387_1412(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 1387, 1412);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10518,761,1424);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10518,761,1424);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewritePointerElementAccess(BoundPointerElementAccess node, BoundExpression rewrittenExpression, BoundExpression rewrittenIndex)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10518,1436,3526);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,1654,1890) || true) && (f_10518_1658_1689(rewrittenIndex))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10518,1654,1890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,1723,1875);

return f_10518_1730_1874(node.Syntax, rewrittenExpression, f_10518_1864_1873(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10518,1654,1890);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,1906,1968);

BinaryOperatorKind 
additionKind = BinaryOperatorKind.Addition
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,1984,2030);

f_10518_1984_2029(f_10518_1997_2021(rewrittenExpression)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,2044,2085);

f_10518_2044_2084(f_10518_2057_2076(rewrittenIndex)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,2099,2917);

switch (f_10518_2107_2138(f_10518_2107_2126(rewrittenIndex)))
            {

case SpecialType.System_Int32:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10518,2099,2917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,2224,2281);

additionKind |= BinaryOperatorKind.PointerAndIntAddition;
DynAbs.Tracing.TraceSender.TraceBreak(10518,2303,2309);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10518,2099,2917);

case SpecialType.System_UInt32:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10518,2099,2917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,2380,2438);

additionKind |= BinaryOperatorKind.PointerAndUIntAddition;
DynAbs.Tracing.TraceSender.TraceBreak(10518,2460,2466);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10518,2099,2917);

case SpecialType.System_Int64:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10518,2099,2917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,2536,2594);

additionKind |= BinaryOperatorKind.PointerAndLongAddition;
DynAbs.Tracing.TraceSender.TraceBreak(10518,2616,2622);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10518,2099,2917);

case SpecialType.System_UInt64:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10518,2099,2917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,2693,2752);

additionKind |= BinaryOperatorKind.PointerAndULongAddition;
DynAbs.Tracing.TraceSender.TraceBreak(10518,2774,2780);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10518,2099,2917);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10518,2099,2917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,2828,2902);

throw f_10518_2834_2901(f_10518_2869_2900(f_10518_2869_2888(rewrittenIndex)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10518,2099,2917);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,2933,3041) || true) && (f_10518_2937_2949(node))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10518,2933,3041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,2983,3026);

additionKind |= BinaryOperatorKind.Checked;
DynAbs.Tracing.TraceSender.TraceExitCondition(10518,2933,3041);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10518,3057,3515);

return f_10518_3064_3514(node.Syntax, f_10518_3148_3448(this, node.Syntax, additionKind, rewrittenExpression, rewrittenIndex, f_10518_3337_3361(rewrittenExpression), method: null, isPointerElementAccess: true), f_10518_3504_3513(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10518,1436,3526);

bool
f_10518_1658_1689(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsDefaultValue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 1658, 1689);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10518_1864_1873(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 1864, 1873);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
f_10518_1730_1874(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator( syntax, operand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 1730, 1874);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10518_1997_2021(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 1997, 2021);
return return_v;
}


int
f_10518_1984_2029(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 1984, 2029);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10518_2057_2076(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 2057, 2076);
return return_v;
}


int
f_10518_2044_2084(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 2044, 2084);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10518_2107_2126(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 2107, 2126);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10518_2107_2138(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 2107, 2138);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10518_2869_2888(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 2869, 2888);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10518_2869_2900(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 2869, 2900);
return return_v;
}


System.Exception
f_10518_2834_2901(Microsoft.CodeAnalysis.SpecialType
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 2834, 2901);
return return_v;
}


bool
f_10518_2937_2949(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
this_param)
{
var return_v = this_param.Checked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 2937, 2949);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10518_3337_3361(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 3337, 3361);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10518_3148_3448(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,bool
isPointerElementAccess)
{
var return_v = this_param.MakeBinaryOperator( syntax, operatorKind, loweredLeft, loweredRight, type, method: method, isPointerElementAccess: isPointerElementAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 3148, 3448);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10518_3504_3513(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10518, 3504, 3513);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
f_10518_3064_3514(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator( syntax, operand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10518, 3064, 3514);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10518,1436,3526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10518,1436,3526);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
