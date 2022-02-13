// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode? VisitDeconstructionAssignmentOperator(BoundDeconstructionAssignmentOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,533,885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,666,689);

var 
right = f_10491_678_688(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,703,772);

f_10491_703_771(right.Conversion.Kind == ConversionKind.Deconstruction);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,788,874);

return f_10491_795_873(this, f_10491_817_826(node), f_10491_828_844(right), f_10491_846_859(right), f_10491_861_872(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,533,885);

Microsoft.CodeAnalysis.CSharp.BoundConversion
f_10491_678_688(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 678, 688);
return return_v;
}


int
f_10491_703_771(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 703, 771);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
f_10491_817_826(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 817, 826);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10491_828_844(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Conversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 828, 844);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_846_859(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 846, 859);
return return_v;
}


bool
f_10491_861_872(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
this_param)
{
var return_v = this_param.IsUsed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 861, 872);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_795_873(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
left,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,bool
isUsed)
{
var return_v = this_param.RewriteDeconstruction( left, conversion, right, isUsed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 795, 873);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,533,885);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,533,885);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? RewriteDeconstruction(BoundTupleExpression left, Conversion conversion, BoundExpression right, bool isUsed)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,1774,2723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,1931,1986);

var 
lhsTemps = f_10491_1946_1985()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,2000,2061);

var 
lhsEffects = f_10491_2017_2060()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,2075,2195);

ArrayBuilder<Binder.DeconstructionVariable> 
lhsTargets = f_10491_2132_2194(this, left, lhsTemps, lhsEffects)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,2209,2240);

f_10491_2209_2239(f_10491_2222_2231(left)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,2254,2352);

BoundExpression? 
result = f_10491_2280_2351(this, lhsTargets, conversion, f_10491_2326_2335(left), right, isUsed)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,2366,2436);

f_10491_2366_2435(lhsTargets);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,2450,2599) || true) && (result is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,2450,2599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,2502,2518);

f_10491_2502_2517(                lhsTemps);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,2536,2554);

f_10491_2536_2553(                lhsEffects);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,2572,2584);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,2450,2599);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,2615,2712);

return f_10491_2622_2711(_factory, f_10491_2640_2669(lhsTemps), f_10491_2671_2702(lhsEffects), result);
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,1774,2723);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10491_1946_1985()
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 1946, 1985);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_2017_2060()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 2017, 2060);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
f_10491_2132_2194(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
variables,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
effects)
{
var return_v = this_param.GetAssignmentTargetsAndSideEffects( variables, temps, effects);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 2132, 2194);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10491_2222_2231(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 2222, 2231);
return return_v;
}


int
f_10491_2209_2239(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 2209, 2239);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10491_2326_2335(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 2326, 2335);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_2280_2351(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
lhsTargets,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
leftType,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,bool
isUsed)
{
var return_v = this_param.RewriteDeconstruction( lhsTargets, conversion, leftType, right, isUsed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 2280, 2351);
return return_v;
}


int
f_10491_2366_2435(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
variables)
{
Binder.DeconstructionVariable.FreeDeconstructionVariables( variables);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 2366, 2435);
return 0;
}


int
f_10491_2502_2517(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 2502, 2517);
return 0;
}


int
f_10491_2536_2553(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 2536, 2553);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10491_2640_2669(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 2640, 2669);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_2671_2702(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 2671, 2702);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_2622_2711(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
result)
{
var return_v = this_param.Sequence( locals, sideEffects, result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 2622, 2711);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,1774,2723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,1774,2723);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? RewriteDeconstruction(
            ArrayBuilder<Binder.DeconstructionVariable> lhsTargets,
            Conversion conversion,
            TypeSymbol leftType,
            BoundExpression right,
            bool isUsed)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,2735,5026);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,3008,3740) || true) && (f_10491_3012_3022(right)== BoundKind.ConditionalOperator)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,3008,3740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,3089,3139);

var 
conditional = (BoundConditionalOperator)right
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,3157,3190);

f_10491_3157_3189(f_10491_3170_3188_M(!conditional.IsRef));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,3208,3725);

return f_10491_3215_3724(conditional, f_10491_3256_3273(conditional), f_10491_3296_3334(this, f_10491_3312_3333(conditional)), f_10491_3357_3451(this, lhsTargets, conversion, leftType, f_10491_3413_3436(conditional), isUsed: true)!, f_10491_3475_3569(this, lhsTargets, conversion, leftType, f_10491_3531_3554(conditional), isUsed: true)!, f_10491_3593_3618(conditional), leftType, wasTargetTyped: true, leftType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,3008,3740);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,3756,3808);

var 
temps = f_10491_3768_3807()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,3822,3876);

var 
effects = f_10491_3836_3875()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,3890,4020);

BoundExpression? 
returnValue = f_10491_3921_4019(this, lhsTargets, right, conversion, temps, effects, isUsed, inInit: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4034,4056);

f_10491_4034_4055(            effects);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4072,5015) || true) && (!isUsed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,4072,5015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4212,4246);

f_10491_4212_4245(returnValue is null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4264,4293);

var 
last = f_10491_4275_4292(effects)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4311,4578) || true) && (last is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,4311,4578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4369,4382);

f_10491_4369_4381(                    temps);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4404,4419);

f_10491_4404_4418(                    effects);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4547,4559);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,4311,4578);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4598,4687);

return f_10491_4605_4686(_factory, f_10491_4623_4649(temps), f_10491_4651_4679(effects), last);
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,4072,5015);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,4072,5015);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4753,4884) || true) && (f_10491_4757_4780_M(!returnValue!.HasErrors))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,4753,4884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4822,4865);

returnValue = f_10491_4836_4864(this, returnValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,4753,4884);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,4904,5000);

return f_10491_4911_4999(_factory, f_10491_4929_4955(temps), f_10491_4957_4985(effects), returnValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,4072,5015);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,2735,5026);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10491_3012_3022(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 3012, 3022);
return return_v;
}


bool
f_10491_3170_3188_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 3170, 3188);
return return_v;
}


int
f_10491_3157_3189(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 3157, 3189);
return 0;
}


bool
f_10491_3256_3273(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.IsRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 3256, 3273);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_3312_3333(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 3312, 3333);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_3296_3334(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 3296, 3334);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_3413_3436(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Consequence;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 3413, 3436);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_3357_3451(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
lhsTargets,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
leftType,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,bool
isUsed)
{
var return_v = this_param.RewriteDeconstruction( lhsTargets, conversion, leftType, right, isUsed: isUsed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 3357, 3451);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_3531_3554(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Alternative;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 3531, 3554);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_3475_3569(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
lhsTargets,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
leftType,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,bool
isUsed)
{
var return_v = this_param.RewriteDeconstruction( lhsTargets, conversion, leftType, right, isUsed: isUsed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 3475, 3569);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10491_3593_3618(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 3593, 3618);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
f_10491_3215_3724(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param,bool
isRef,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,Microsoft.CodeAnalysis.CSharp.BoundExpression
consequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
alternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
naturalTypeOpt,bool
wasTargetTyped,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( isRef, condition, consequence, alternative, constantValueOpt, naturalTypeOpt, wasTargetTyped: wasTargetTyped, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 3215, 3724);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10491_3768_3807()
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 3768, 3807);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LocalRewriter.DeconstructionSideEffects
f_10491_3836_3875()
{
var return_v = DeconstructionSideEffects.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 3836, 3875);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_3921_4019(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
leftTargets,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DeconstructionSideEffects
effects,bool
isUsed,bool
inInit)
{
var return_v = this_param.ApplyDeconstructionConversion( leftTargets, right, conversion, temps, effects, isUsed, inInit: inInit);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 3921, 4019);
return return_v;
}


int
f_10491_4034_4055(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DeconstructionSideEffects
this_param)
{
this_param.Consolidate();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4034, 4055);
return 0;
}


int
f_10491_4212_4245(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4212, 4245);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_4275_4292(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DeconstructionSideEffects
this_param)
{
var return_v = this_param.PopLast();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4275, 4292);
return return_v;
}


int
f_10491_4369_4381(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4369, 4381);
return 0;
}


int
f_10491_4404_4418(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DeconstructionSideEffects
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4404, 4418);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10491_4623_4649(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4623, 4649);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_4651_4679(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DeconstructionSideEffects
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4651, 4679);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_4605_4686(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
result)
{
var return_v = this_param.Sequence( locals, sideEffects, result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4605, 4686);
return return_v;
}


bool
f_10491_4757_4780_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 4757, 4780);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_4836_4864(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4836, 4864);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10491_4929_4955(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4929, 4955);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_4957_4985(Microsoft.CodeAnalysis.CSharp.LocalRewriter.DeconstructionSideEffects
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4957, 4985);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_4911_4999(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
result)
{
var return_v = this_param.Sequence( locals, sideEffects, result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 4911, 4999);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,2735,5026);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,2735,5026);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? ApplyDeconstructionConversion(
            ArrayBuilder<Binder.DeconstructionVariable> leftTargets,
            BoundExpression right,
            Conversion conversion,
            ArrayBuilder<LocalSymbol> temps,
            DeconstructionSideEffects effects,
            bool isUsed,
            bool inInit)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,5607,8792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,5975,6038);

f_10491_5975_6037(conversion.Kind == ConversionKind.Deconstruction);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,6052,6158);

ImmutableArray<BoundExpression> 
rightParts = f_10491_6097_6157(this, right, conversion, temps, effects, ref inInit)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,6174,6258);

ImmutableArray<Conversion> 
underlyingConversions = conversion.UnderlyingConversions
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,6272,6319);

f_10491_6272_6318(f_10491_6285_6317_M(!underlyingConversions.IsDefault));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,6333,6450);

f_10491_6333_6449(f_10491_6346_6363(leftTargets)== rightParts.Length &&(DynAbs.Tracing.TraceSender.Expression_True(10491, 6346, 6448)&&f_10491_6388_6405(leftTargets)== conversion.UnderlyingConversions.Length));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,6466,6557);

var 
builder = (DynAbs.Tracing.TraceSender.Conditional_F1(10491, 6480, 6486)||((isUsed &&DynAbs.Tracing.TraceSender.Conditional_F2(10491, 6489, 6549))||DynAbs.Tracing.TraceSender.Conditional_F3(10491, 6552, 6556)))?f_10491_6489_6549(f_10491_6531_6548(leftTargets)):null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,6580,6585);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,6571,8026) || true) && (i < f_10491_6591_6608(leftTargets))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,6610,6613)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10491,6571,8026))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,6571,8026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,6647,6675);

BoundExpression? 
resultPart
=default(BoundExpression?);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,6693,7898) || true) && (f_10491_6697_6711(leftTargets, i).NestedVariables is { } nested)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,6693,7898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,6783,6932);

resultPart = f_10491_6796_6931(this, nested, rightParts[i], underlyingConversions[i], temps, effects, isUsed, inInit);
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,6693,7898);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,6693,7898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,7014,7044);

var 
rightPart = rightParts[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,7066,7229) || true) && (inInit)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,7066,7229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,7126,7206);

rightPart = f_10491_7138_7205(this, rightPart, effects.init, temps);
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,7066,7229);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,7251,7303);

BoundExpression? 
leftTarget = f_10491_7281_7295(leftTargets, i).Single
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,7325,7367);

f_10491_7325_7366(leftTarget is { Type: { } });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,7391,7536);

resultPart = f_10491_7404_7535(this, rightPart, underlyingConversions[i], f_10491_7466_7481(leftTarget), temps, effects.conversions);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,7560,7879) || true) && (f_10491_7564_7579(leftTarget)!= BoundKind.DiscardExpression)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,7560,7879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,7660,7856);

f_10491_7660_7855(                        effects.assignments, f_10491_7684_7854(this, resultPart.Syntax, leftTarget, resultPart, f_10491_7750_7765(leftTarget), used: true, isChecked: false, isCompoundAssignment: false));
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,7560,7879);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,6693,7898);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,7916,7967);

f_10491_7916_7966(builder is null ||(DynAbs.Tracing.TraceSender.Expression_False(10491, 7929, 7965)||resultPart is { }));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,7985,8011);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(builder, 10491, 7985, 8010)?.Add(resultPart!),10491,7993,8010);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10491,1,1456);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10491,1,1456);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,8042,8781) || true) && (isUsed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,8042,8781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,8086,8445);

var 
tupleType = f_10491_8102_8444(locationOpt: null, elementTypesWithAnnotations: f_10491_8178_8241(builder!, e => TypeWithAnnotations.Create(e.Type)), elementLocations: default, elementNames: default, compilation: _compilation, shouldCheckConstraints: false, includeNullability: false, errorPositions: default)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,8465,8688);

return f_10491_8472_8687(right.Syntax, sourceTuple: null, wasTargetTyped: false, arguments: f_10491_8592_8621(builder!), argumentNamesOpt: default, inferredNamesOpt: default, tupleType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,8042,8781);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,8042,8781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,8754,8766);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,8042,8781);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,5607,8792);

int
f_10491_5975_6037(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 5975, 6037);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_6097_6157(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DeconstructionSideEffects
effects,ref bool
inInit)
{
var return_v = this_param.GetRightParts( right, conversion, temps, effects, ref inInit);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 6097, 6157);
return return_v;
}


bool
f_10491_6285_6317_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 6285, 6317);
return return_v;
}


int
f_10491_6272_6318(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 6272, 6318);
return 0;
}


int
f_10491_6346_6363(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 6346, 6363);
return return_v;
}


int
f_10491_6388_6405(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 6388, 6405);
return return_v;
}


int
f_10491_6333_6449(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 6333, 6449);
return 0;
}


int
f_10491_6531_6548(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 6531, 6548);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_6489_6549(int
capacity)
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 6489, 6549);
return return_v;
}


int
f_10491_6591_6608(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 6591, 6608);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
f_10491_6697_6711(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 6697, 6711);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_6796_6931(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
leftTargets,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,Microsoft.CodeAnalysis.CSharp.LocalRewriter.DeconstructionSideEffects
effects,bool
isUsed,bool
inInit)
{
var return_v = this_param.ApplyDeconstructionConversion( leftTargets, right, conversion, temps, effects, isUsed, inInit);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 6796, 6931);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_7138_7205(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
effects,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.EvaluateSideEffectingArgumentToTemp( arg, effects, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 7138, 7205);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
f_10491_7281_7295(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 7281, 7295);
return return_v;
}


int
f_10491_7325_7366(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 7325, 7366);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10491_7466_7481(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 7466, 7481);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_7404_7535(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
destinationType,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
effects)
{
var return_v = this_param.EvaluateConversionToTemp( expression, conversion, destinationType, temps, effects);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 7404, 7535);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10491_7564_7579(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 7564, 7579);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10491_7750_7765(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 7750, 7765);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_7684_7854(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
used,bool
isChecked,bool
isCompoundAssignment)
{
var return_v = this_param.MakeAssignmentOperator( syntax, rewrittenLeft, rewrittenRight, type, used: used, isChecked: isChecked, isCompoundAssignment: isCompoundAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 7684, 7854);
return return_v;
}


int
f_10491_7660_7855(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 7660, 7855);
return 0;
}


int
f_10491_7916_7966(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 7916, 7966);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
f_10491_8178_8241(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items,System.Func<Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
map)
{
var return_v = items.SelectAsArray<Microsoft.CodeAnalysis.CSharp.BoundExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>( map);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 8178, 8241);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10491_8102_8444(Microsoft.CodeAnalysis.Location?
locationOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
elementTypesWithAnnotations,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
elementLocations,System.Collections.Immutable.ImmutableArray<string?>
elementNames,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,bool
shouldCheckConstraints,bool
includeNullability,System.Collections.Immutable.ImmutableArray<bool>
errorPositions)
{
var return_v = NamedTypeSymbol.CreateTuple( locationOpt: locationOpt, elementTypesWithAnnotations: elementTypesWithAnnotations, elementLocations: elementLocations, elementNames: elementNames, compilation: compilation, shouldCheckConstraints: shouldCheckConstraints, includeNullability: includeNullability, errorPositions: errorPositions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 8102, 8444);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_8592_8621(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 8592, 8621);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
f_10491_8472_8687(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral?
sourceTuple,bool
wasTargetTyped,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<string?>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<bool>
inferredNamesOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral( syntax, sourceTuple: sourceTuple, wasTargetTyped: wasTargetTyped, arguments: arguments, argumentNamesOpt: argumentNamesOpt, inferredNamesOpt: inferredNamesOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 8472, 8687);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,5607,8792);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,5607,8792);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ImmutableArray<BoundExpression> GetRightParts(BoundExpression right, Conversion conversion,
            ArrayBuilder<LocalSymbol> temps, DeconstructionSideEffects effects, ref bool inInit)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,8804,10946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,9097,9152);

var 
deconstructionInfo = conversion.DeconstructionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,9166,9622) || true) && (f_10491_9170_9199_M(!deconstructionInfo.IsDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,9166,9622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,9233,9278);

f_10491_9233_9277(!f_10491_9247_9276(f_10491_9265_9275(right)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,9298,9453);

BoundExpression 
evaluationResult = f_10491_9333_9452(this, right, (DynAbs.Tracing.TraceSender.Conditional_F1(10491, 9397, 9403)||((                    inInit &&DynAbs.Tracing.TraceSender.Conditional_F2(10491, 9406, 9418))||DynAbs.Tracing.TraceSender.Conditional_F3(10491, 9421, 9444)))?effects.init :effects.deconstructions, temps)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,9473,9488);

inInit = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,9506,9607);

return f_10491_9513_9606(this, deconstructionInfo, evaluationResult, effects.deconstructions, temps);
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,9166,9622);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,9700,9829) || true) && (f_10491_9704_9733(f_10491_9722_9732(right)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,9700,9829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,9767,9814);

return f_10491_9774_9813(((BoundTupleExpression)right));
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,9700,9829);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,9960,10446) || true) && (f_10491_9964_9974(right)== BoundKind.Conversion)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,9960,10446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,10032,10077);

var 
tupleConversion = (BoundConversion)right
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,10095,10431) || true) && ((tupleConversion.Conversion.Kind == ConversionKind.ImplicitTupleLiteral ||(DynAbs.Tracing.TraceSender.Expression_False(10491, 10100, 10232)||tupleConversion.Conversion.Kind == ConversionKind.Identity))
&&(DynAbs.Tracing.TraceSender.Expression_True(10491, 10099, 10305)&&f_10491_10258_10305(f_10491_10276_10304(f_10491_10276_10299(tupleConversion)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,10095,10431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,10347,10412);

return f_10491_10354_10411(((BoundTupleExpression)f_10491_10377_10400(tupleConversion)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,10095,10431);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,9960,10446);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,10647,10679);

f_10491_10647_10678(f_10491_10660_10670(right)is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,10693,10882) || true) && (f_10491_10697_10719(f_10491_10697_10707(right)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,10693,10882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,10753,10768);

inInit = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,10786,10867);

return f_10491_10793_10866(this, f_10491_10811_10833(this, right), temps, effects.deconstructions);
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,10693,10882);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,10898,10935);

throw f_10491_10904_10934();
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,8804,10946);

bool
f_10491_9170_9199_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 9170, 9199);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10491_9265_9275(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 9265, 9275);
return return_v;
}


bool
f_10491_9247_9276(Microsoft.CodeAnalysis.CSharp.BoundKind
kind)
{
var return_v = IsTupleExpression( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 9247, 9276);
return return_v;
}


int
f_10491_9233_9277(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 9233, 9277);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_9333_9452(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
effects,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.EvaluateSideEffectingArgumentToTemp( arg, effects, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 9333, 9452);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_9513_9606(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.DeconstructMethodInfo
deconstruction,Microsoft.CodeAnalysis.CSharp.BoundExpression
target,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
effects,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.InvokeDeconstructMethod( deconstruction, target, effects, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 9513, 9606);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10491_9722_9732(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 9722, 9732);
return return_v;
}


bool
f_10491_9704_9733(Microsoft.CodeAnalysis.CSharp.BoundKind
kind)
{
var return_v = IsTupleExpression( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 9704, 9733);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_9774_9813(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 9774, 9813);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10491_9964_9974(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 9964, 9974);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_10276_10299(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 10276, 10299);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10491_10276_10304(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 10276, 10304);
return return_v;
}


bool
f_10491_10258_10305(Microsoft.CodeAnalysis.CSharp.BoundKind
kind)
{
var return_v = IsTupleExpression( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 10258, 10305);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_10377_10400(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 10377, 10400);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_10354_10411(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 10354, 10411);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10491_10660_10670(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 10660, 10670);
return return_v;
}


int
f_10491_10647_10678(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 10647, 10678);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10491_10697_10707(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 10697, 10707);
return return_v;
}


bool
f_10491_10697_10719(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsTupleType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 10697, 10719);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_10811_10833(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 10811, 10833);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_10793_10866(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
effects)
{
var return_v = this_param.AccessTupleFields( expression, temps, effects);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 10793, 10866);
return return_v;
}


System.Exception
f_10491_10904_10934()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 10904, 10934);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,8804,10946);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,8804,10946);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsTupleExpression(BoundKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10491,10958,11128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,11036,11117);

return kind == BoundKind.TupleLiteral ||(DynAbs.Tracing.TraceSender.Expression_False(10491, 11043, 11116)||kind == BoundKind.ConvertedTupleLiteral);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10491,10958,11128);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,10958,11128);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,10958,11128);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ImmutableArray<BoundExpression> AccessTupleFields(BoundExpression expression, ArrayBuilder<LocalSymbol> temps,
            ArrayBuilder<BoundExpression> effects)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,11262,12837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,11457,11494);

f_10491_11457_11493(f_10491_11470_11485(expression)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,11508,11550);

f_10491_11508_11549(f_10491_11521_11548(f_10491_11521_11536(expression)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,11564,11596);

var 
tupleType = f_10491_11580_11595(expression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,11610,11677);

var 
tupleElementTypes = f_10491_11634_11676(tupleType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,11693,11736);

var 
numElements = tupleElementTypes.Length
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,11823,11845);

BoundExpression 
tuple
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,11859,12347) || true) && (f_10491_11863_11938(expression, localsMayBeAssignedOrCaptured: true))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,11859,12347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,11972,12013);

BoundAssignmentOperator 
assignmentToTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12031,12110);

BoundLocal 
savedTuple = f_10491_12055_12109(_factory, expression, out assignmentToTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12128,12158);

f_10491_12128_12157(                effects, assignmentToTemp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12176,12210);

f_10491_12176_12209(                temps, f_10491_12186_12208(savedTuple));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12228,12247);

tuple = savedTuple;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,11859,12347);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,11859,12347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12313,12332);

tuple = expression;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,11859,12347);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12411,12448);

var 
fields = f_10491_12424_12447(tupleType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12462,12531);

var 
builder = f_10491_12476_12530(numElements)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12554,12559);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12545,12776) || true) && (i < numElements)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12578,12581)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10491,12545,12776))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,12545,12776);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12615,12718);

var 
fieldAccess = f_10491_12633_12717(this, tuple, expression.Syntax, fields[i])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12736,12761);

f_10491_12736_12760(                builder, fieldAccess);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10491,1,232);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10491,1,232);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,12790,12826);

return f_10491_12797_12825(builder);
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,11262,12837);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10491_11470_11485(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 11470, 11485);
return return_v;
}


int
f_10491_11457_11493(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 11457, 11493);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10491_11521_11536(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 11521, 11536);
return return_v;
}


bool
f_10491_11521_11548(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsTupleType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 11521, 11548);
return return_v;
}


int
f_10491_11508_11549(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 11508, 11549);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10491_11580_11595(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 11580, 11595);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
f_10491_11634_11676(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.TupleElementTypesWithAnnotations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 11634, 11676);
return return_v;
}


bool
f_10491_11863_11938(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression,bool
localsMayBeAssignedOrCaptured)
{
var return_v = CanChangeValueBetweenReads( expression, localsMayBeAssignedOrCaptured: localsMayBeAssignedOrCaptured);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 11863, 11938);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10491_12055_12109(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 12055, 12109);
return return_v;
}


int
f_10491_12128_12157(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 12128, 12157);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10491_12186_12208(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 12186, 12208);
return return_v;
}


int
f_10491_12176_12209(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 12176, 12209);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
f_10491_12424_12447(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.TupleElements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 12424, 12447);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_12476_12530(int
capacity)
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 12476, 12530);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_12633_12717(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
tuple,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
field)
{
var return_v = this_param.MakeTupleFieldAccessAndReportUseSiteDiagnostics( tuple, syntax, field);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 12633, 12717);
return return_v;
}


int
f_10491_12736_12760(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 12736, 12760);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_12797_12825(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 12797, 12825);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,11262,12837);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,11262,12837);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression EvaluateConversionToTemp(BoundExpression expression, Conversion conversion,
            TypeSymbol destinationType, ArrayBuilder<LocalSymbol> temps, ArrayBuilder<BoundExpression> effects)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,12849,13409);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,13086,13178) || true) && (conversion.IsIdentity)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,13086,13178);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,13145,13163);

return expression;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,13086,13178);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,13192,13309);

var 
evalConversion = f_10491_13213_13308(this, expression.Syntax, expression, conversion, destinationType, @checked: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,13323,13398);

return f_10491_13330_13397(this, evalConversion, effects, temps);
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,12849,13409);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_13213_13308(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax, rewrittenOperand, conversion, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 13213, 13308);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_13330_13397(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
effects,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.EvaluateSideEffectingArgumentToTemp( arg, effects, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 13330, 13397);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,12849,13409);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,12849,13409);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ImmutableArray<BoundExpression> InvokeDeconstructMethod(DeconstructMethodInfo deconstruction, BoundExpression target,
            ArrayBuilder<BoundExpression> effects, ArrayBuilder<LocalSymbol> temps)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,13421,14887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,13656,13723);

f_10491_13656_13722(this, deconstruction.InputPlaceholder, target);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,13739,13798);

var 
outputPlaceholders = deconstruction.OutputPlaceholders
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,13812,13897);

var 
outLocals = f_10491_13828_13896(outputPlaceholders.Length)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,13911,14509);
foreach(var outputPlaceholder in f_10491_13945_13963_I(outputPlaceholders) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,13911,14509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,13997,14149);

var 
localSymbol = f_10491_14015_14148(f_10491_14036_14060(_factory), TypeWithAnnotations.Create(f_10491_14089_14111(outputPlaceholder)), SynthesizedLocalKind.LoweringTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,14169,14332);

var 
localBound = new BoundLocal(target.Syntax, localSymbol, constantValueOpt: null, type: f_10491_14259_14281(outputPlaceholder))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,10491,14186,14331) }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,14352,14375);

f_10491_14352_14374(
                temps, localSymbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,14393,14450);

f_10491_14393_14449(this, outputPlaceholder, localBound);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,14468,14494);

f_10491_14468_14493(                outLocals, localBound);
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,13911,14509);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10491,1,599);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10491,1,599);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,14525,14581);

f_10491_14525_14580(
            effects, f_10491_14537_14579(this, deconstruction.Invocation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,14597,14659);

f_10491_14597_14658(this, deconstruction.InputPlaceholder);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,14673,14822);
foreach(var outputPlaceholder in f_10491_14707_14725_I(outputPlaceholders) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,14673,14822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,14759,14807);

f_10491_14759_14806(this, outputPlaceholder);
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,14673,14822);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10491,1,150);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10491,1,150);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,14838,14876);

return f_10491_14845_14875(outLocals);
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,13421,14887);

int
f_10491_13656_13722(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
placeholder,Microsoft.CodeAnalysis.CSharp.BoundExpression
value)
{
this_param.AddPlaceholderReplacement( (Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 13656, 13722);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_13828_13896(int
capacity)
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 13828, 13896);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10491_14036_14060(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentFunction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 14036, 14060);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10491_14089_14111(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 14089, 14111);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
f_10491_14015_14148(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
containingMethodOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
type,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal( containingMethodOpt, type, kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 14015, 14148);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10491_14259_14281(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 14259, 14281);
return return_v;
}


int
f_10491_14352_14374(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 14352, 14374);
return 0;
}


int
f_10491_14393_14449(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
placeholder,Microsoft.CodeAnalysis.CSharp.BoundLocal
value)
{
this_param.AddPlaceholderReplacement( (Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 14393, 14449);
return 0;
}


int
f_10491_14468_14493(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 14468, 14493);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
f_10491_13945_13963_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 13945, 13963);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_14537_14579(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 14537, 14579);
return return_v;
}


int
f_10491_14525_14580(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 14525, 14580);
return 0;
}


int
f_10491_14597_14658(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
placeholder)
{
this_param.RemovePlaceholderReplacement( (Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 14597, 14658);
return 0;
}


int
f_10491_14759_14806(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
placeholder)
{
this_param.RemovePlaceholderReplacement( (Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 14759, 14806);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
f_10491_14707_14725_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 14707, 14725);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_14845_14875(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 14845, 14875);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,13421,14887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,13421,14887);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression EvaluateSideEffectingArgumentToTemp(
            BoundExpression arg,
            ArrayBuilder<BoundExpression> effects,
            ArrayBuilder<LocalSymbol> temps)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,15463,16215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,15680,15718);

var 
loweredArg = f_10491_15697_15717(this, arg)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,15732,16204) || true) && (f_10491_15736_15855(loweredArg, localsMayBeAssignedOrCaptured: true, structThisCanChangeValueBetweenReads: true))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,15732,16204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,15889,15919);

BoundAssignmentOperator 
store
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,15937,15992);

var 
temp = f_10491_15948_15991(_factory, loweredArg, out store)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,16010,16038);

f_10491_16010_16037(                temps, f_10491_16020_16036(temp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,16056,16075);

f_10491_16056_16074(                effects, store);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,16093,16105);

return temp;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,15732,16204);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,15732,16204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,16171,16189);

return loweredArg;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,15732,16204);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,15463,16215);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10491_15697_15717(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 15697, 15717);
return return_v;
}


bool
f_10491_15736_15855(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression,bool
localsMayBeAssignedOrCaptured,bool
structThisCanChangeValueBetweenReads)
{
var return_v = CanChangeValueBetweenReads( expression, localsMayBeAssignedOrCaptured: localsMayBeAssignedOrCaptured, structThisCanChangeValueBetweenReads: structThisCanChangeValueBetweenReads);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 15736, 15855);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10491_15948_15991(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 15948, 15991);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10491_16020_16036(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 16020, 16036);
return return_v;
}


int
f_10491_16010_16037(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 16010, 16037);
return 0;
}


int
f_10491_16056_16074(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 16056, 16074);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,15463,16215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,15463,16215);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ArrayBuilder<Binder.DeconstructionVariable> GetAssignmentTargetsAndSideEffects(BoundTupleExpression variables, ArrayBuilder<LocalSymbol> temps, ArrayBuilder<BoundExpression> effects)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,16487,17974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,16702,16810);

var 
assignmentTargets = f_10491_16726_16809(variables.Arguments.Length)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,16826,17922);
foreach(var variable in f_10491_16851_16870_I(f_10491_16851_16870(variables)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,16826,17922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,16904,17907);

switch (f_10491_16912_16925(variable))
                {

case BoundKind.DiscardExpression:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,16904,17907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,17026,17110);

f_10491_17026_17109(                        assignmentTargets, f_10491_17048_17108(variable, variable.Syntax));
DynAbs.Tracing.TraceSender.TraceBreak(10491,17136,17142);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,16904,17907);

case BoundKind.TupleLiteral:
                    case BoundKind.ConvertedTupleLiteral:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,16904,17907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,17279,17322);

var 
tuple = (BoundTupleExpression)variable
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,17348,17478);

f_10491_17348_17477(                        assignmentTargets, f_10491_17370_17476(f_10491_17404_17461(this, tuple, temps, effects), tuple.Syntax));
DynAbs.Tracing.TraceSender.TraceBreak(10491,17504,17510);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,16904,17907);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,16904,17907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,17568,17603);

f_10491_17568_17602(f_10491_17581_17594(variable)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,17629,17750);

var 
temp = f_10491_17640_17749(this, variable, effects, temps, isDynamicAssignment: f_10491_17723_17748(f_10491_17723_17736(variable)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,17776,17856);

f_10491_17776_17855(                        assignmentTargets, f_10491_17798_17854(temp, variable.Syntax));
DynAbs.Tracing.TraceSender.TraceBreak(10491,17882,17888);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,16904,17907);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,16826,17922);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10491,1,1097);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10491,1,1097);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,17938,17963);

return assignmentTargets;
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,16487,17974);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
f_10491_16726_16809(int
capacity)
{
var return_v = ArrayBuilder<Binder.DeconstructionVariable>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 16726, 16809);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_16851_16870(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 16851, 16870);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10491_16912_16925(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 16912, 16925);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
f_10491_17048_17108(Microsoft.CodeAnalysis.CSharp.BoundExpression
variable,Microsoft.CodeAnalysis.SyntaxNode
syntax)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable( variable, syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 17048, 17108);
return return_v;
}


int
f_10491_17026_17109(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
this_param,Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 17026, 17109);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
f_10491_17404_17461(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
variables,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
effects)
{
var return_v = this_param.GetAssignmentTargetsAndSideEffects( variables, temps, effects);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 17404, 17461);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
f_10491_17370_17476(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
variables,Microsoft.CodeAnalysis.SyntaxNode
syntax)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable( variables, syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 17370, 17476);
return return_v;
}


int
f_10491_17348_17477(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
this_param,Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 17348, 17477);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10491_17581_17594(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 17581, 17594);
return return_v;
}


int
f_10491_17568_17602(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 17568, 17602);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10491_17723_17736(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 17723, 17736);
return return_v;
}


bool
f_10491_17723_17748(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsDynamic();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 17723, 17748);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_17640_17749(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
originalLHS,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,bool
isDynamicAssignment)
{
var return_v = this_param.TransformCompoundAssignmentLHS( originalLHS, stores, temps, isDynamicAssignment: isDynamicAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 17640, 17749);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
f_10491_17798_17854(Microsoft.CodeAnalysis.CSharp.BoundExpression
variable,Microsoft.CodeAnalysis.SyntaxNode
syntax)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable( variable, syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 17798, 17854);
return return_v;
}


int
f_10491_17776_17855(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
this_param,Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 17776, 17855);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_16851_16870_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 16851, 16870);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,16487,17974);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,16487,17974);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
private class DeconstructionSideEffects
{
internal ArrayBuilder<BoundExpression> init ;

internal ArrayBuilder<BoundExpression> deconstructions ;

internal ArrayBuilder<BoundExpression> conversions ;

internal ArrayBuilder<BoundExpression> assignments ;

internal static DeconstructionSideEffects GetInstance()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10491,18341,18852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18429,18474);

var 
result = f_10491_18442_18473()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18492,18550);

result.init = f_10491_18506_18549();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18568,18637);

result.deconstructions = f_10491_18593_18636();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18655,18720);

result.conversions = f_10491_18676_18719();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18738,18803);

result.assignments = f_10491_18759_18802();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18823,18837);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10491,18341,18852);

Microsoft.CodeAnalysis.CSharp.LocalRewriter.DeconstructionSideEffects
f_10491_18442_18473()
{
var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.DeconstructionSideEffects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 18442, 18473);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_18506_18549()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 18506, 18549);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_18593_18636()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 18593, 18636);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_18676_18719()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 18676, 18719);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_18759_18802()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 18759, 18802);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,18341,18852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,18341,18852);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Consolidate()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,18868,19181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18928,18959);

f_10491_18928_18958(                init, deconstructions);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18977,19004);

f_10491_18977_19003(                init, conversions);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,19022,19049);

f_10491_19022_19048(                init, assignments);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,19069,19092);

f_10491_19069_19091(
                deconstructions);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,19110,19129);

f_10491_19110_19128(                conversions);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,19147,19166);

f_10491_19147_19165(                assignments);
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,18868,19181);

int
f_10491_18928_18958(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 18928, 18958);
return 0;
}


int
f_10491_18977_19003(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 18977, 19003);
return 0;
}


int
f_10491_19022_19048(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 19022, 19048);
return 0;
}


int
f_10491_19069_19091(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 19069, 19091);
return 0;
}


int
f_10491_19110_19128(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 19110, 19128);
return 0;
}


int
f_10491_19147_19165(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 19147, 19165);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,18868,19181);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,18868,19181);
}
		}

internal BoundExpression? PopLast()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,19197,19481);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,19265,19357) || true) && (f_10491_19269_19279(init)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10491,19265,19357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,19326,19338);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10491,19265,19357);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,19377,19400);

var 
last = f_10491_19388_19399(init)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,19418,19436);

f_10491_19418_19435(                init);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,19454,19466);

return last;
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,19197,19481);

int
f_10491_19269_19279(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10491, 19269, 19279);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10491_19388_19399(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Last();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 19388, 19399);
return return_v;
}


int
f_10491_19418_19435(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.RemoveLast();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 19418, 19435);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,19197,19481);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,19197,19481);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal ImmutableArray<BoundExpression> ToImmutableAndFree()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,19555,19697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,19649,19682);

return f_10491_19656_19681(init);
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,19555,19697);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10491_19656_19681(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 19656, 19681);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,19555,19697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,19555,19697);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Free()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10491,19713,19793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,19766,19778);

f_10491_19766_19777(                init);
DynAbs.Tracing.TraceSender.TraceExitMethod(10491,19713,19793);

int
f_10491_19766_19777(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10491, 19766, 19777);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10491,19713,19793);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,19713,19793);
}
		}

public DeconstructionSideEffects()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(10491,17986,19804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18089,18101);
this.init = null!;DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18155,18178);
this.deconstructions = null!;DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18232,18251);
this.conversions = null!;DynAbs.Tracing.TraceSender.TraceSimpleStatement(10491,18305,18324);
this.assignments = null!;DynAbs.Tracing.TraceSender.TraceExitConstructor(10491,17986,19804);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,17986,19804);
}


static DeconstructionSideEffects()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10491,17986,19804);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10491,17986,19804);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10491,17986,19804);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10491,17986,19804);
}
}
}
