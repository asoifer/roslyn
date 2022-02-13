// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitConditionalOperator(BoundConditionalOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10488,652,1702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,854,895);

f_10488_854_894(f_10488_867_885(node)== null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,911,968);

var 
rewrittenCondition = f_10488_936_967(this, f_10488_952_966(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,982,1043);

var 
rewrittenConsequence = f_10488_1009_1042(this, f_10488_1025_1041(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,1057,1118);

var 
rewrittenAlternative = f_10488_1084_1117(this, f_10488_1100_1116(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,1134,1398) || true) && (f_10488_1138_1170(rewrittenCondition)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10488,1134,1398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,1212,1383);

return f_10488_1219_1382(node, f_10488_1231_1241(node), rewrittenCondition, rewrittenConsequence, rewrittenAlternative, f_10488_1307_1328(node), f_10488_1330_1349(node), f_10488_1351_1370(node), f_10488_1372_1381(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10488,1134,1398);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,1414,1691);

return f_10488_1421_1690(node.Syntax, rewrittenCondition, rewrittenConsequence, rewrittenAlternative, f_10488_1611_1632(node), f_10488_1651_1660(node), f_10488_1679_1689(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10488,652,1702);

Microsoft.CodeAnalysis.ConstantValue?
f_10488_867_885(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 867, 885);
return return_v;
}


int
f_10488_854_894(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10488, 854, 894);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10488_952_966(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 952, 966);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10488_936_967(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10488, 936, 967);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10488_1025_1041(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Consequence;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 1025, 1041);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10488_1009_1042(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10488, 1009, 1042);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10488_1100_1116(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Alternative;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 1100, 1116);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10488_1084_1117(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10488, 1084, 1117);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10488_1138_1170(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 1138, 1170);
return return_v;
}


bool
f_10488_1231_1241(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.IsRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 1231, 1241);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10488_1307_1328(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.ConstantValueOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 1307, 1328);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10488_1330_1349(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.NaturalTypeOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 1330, 1349);
return return_v;
}


bool
f_10488_1351_1370(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.WasTargetTyped;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 1351, 1370);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10488_1372_1381(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 1372, 1381);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
f_10488_1219_1382(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param,bool
isRef,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,Microsoft.CodeAnalysis.CSharp.BoundExpression
consequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
alternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
naturalTypeOpt,bool
wasTargetTyped,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( isRef, condition, consequence, alternative, constantValueOpt, naturalTypeOpt, wasTargetTyped, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10488, 1219, 1382);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10488_1611_1632(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.ConstantValueOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 1611, 1632);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10488_1651_1660(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 1651, 1660);
return return_v;
}


bool
f_10488_1679_1689(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.IsRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 1679, 1689);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10488_1421_1690(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax, rewrittenCondition, rewrittenConsequence, rewrittenAlternative, constantValueOpt, rewrittenType, isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10488, 1421, 1690);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10488,652,1702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10488,652,1702);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static BoundExpression RewriteConditionalOperator(
            SyntaxNode syntax,
            BoundExpression rewrittenCondition,
            BoundExpression rewrittenConsequence,
            BoundExpression rewrittenAlternative,
            ConstantValue? constantValueOpt,
            TypeSymbol rewrittenType,
            bool isRef)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10488,1714,2900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,2090,2163);

ConstantValue? 
conditionConstantValue = f_10488_2130_2162(rewrittenCondition)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,2177,2889) || true) && (conditionConstantValue == f_10488_2207_2225())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10488,2177,2889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,2259,2287);

return rewrittenConsequence;
DynAbs.Tracing.TraceSender.TraceExitCondition(10488,2177,2889);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10488,2177,2889);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,2321,2889) || true) && (conditionConstantValue == f_10488_2351_2370())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10488,2321,2889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,2404,2432);

return rewrittenAlternative;
DynAbs.Tracing.TraceSender.TraceExitCondition(10488,2321,2889);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10488,2321,2889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10488,2498,2874);

return f_10488_2505_2873(syntax, isRef, rewrittenCondition, rewrittenConsequence, rewrittenAlternative, constantValueOpt, rewrittenType, wasTargetTyped: false, rewrittenType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10488,2321,2889);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10488,2177,2889);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10488,1714,2900);

Microsoft.CodeAnalysis.ConstantValue?
f_10488_2130_2162(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 2130, 2162);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10488_2207_2225()
{
var return_v = ConstantValue.True;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 2207, 2225);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10488_2351_2370()
{
var return_v = ConstantValue.False;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10488, 2351, 2370);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
f_10488_2505_2873(Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
isRef,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,Microsoft.CodeAnalysis.CSharp.BoundExpression
consequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
alternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
naturalTypeOpt,bool
wasTargetTyped,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator( syntax, isRef, condition, consequence, alternative, constantValueOpt, naturalTypeOpt, wasTargetTyped: wasTargetTyped, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10488, 2505, 2873);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10488,1714,2900);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10488,1714,2900);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
