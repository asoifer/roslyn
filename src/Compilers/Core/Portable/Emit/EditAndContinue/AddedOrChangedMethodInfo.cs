// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;

namespace Microsoft.CodeAnalysis.Emit
{

internal struct AddedOrChangedMethodInfo
    {

public readonly DebugId MethodId;

public readonly ImmutableArray<EncLocalInfo> Locals;

public readonly ImmutableArray<LambdaDebugInfo> LambdaDebugInfo;

public readonly ImmutableArray<ClosureDebugInfo> ClosureDebugInfo;

public readonly string StateMachineTypeNameOpt;

public readonly ImmutableArray<EncHoistedLocalInfo> StateMachineHoistedLocalSlotsOpt;

public readonly ImmutableArray<Cci.ITypeReference> StateMachineAwaiterSlotsOpt;

public AddedOrChangedMethodInfo(
            DebugId methodId,
            ImmutableArray<EncLocalInfo> locals,
            ImmutableArray<LambdaDebugInfo> lambdaDebugInfo,
            ImmutableArray<ClosureDebugInfo> closureDebugInfo,
            string stateMachineTypeNameOpt,
            ImmutableArray<EncHoistedLocalInfo> stateMachineHoistedLocalSlotsOpt,
            ImmutableArray<Cci.ITypeReference> stateMachineAwaiterSlotsOpt)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(756,1020,2441);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,1636,1675);

f_756_1636_1674(methodId.Generation >= 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,1748,1837);

f_756_1748_1836(stateMachineAwaiterSlotsOpt.IsDefault == (stateMachineTypeNameOpt == null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,1919,2013);

f_756_1919_2012(stateMachineHoistedLocalSlotsOpt.IsDefault ||(DynAbs.Tracing.TraceSender.Expression_False(756, 1932, 2011)||(stateMachineTypeNameOpt != null)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,2029,2054);

this.MethodId = methodId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,2068,2089);

this.Locals = locals;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,2103,2142);

this.LambdaDebugInfo = lambdaDebugInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,2156,2197);

this.ClosureDebugInfo = closureDebugInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,2211,2266);

this.StateMachineTypeNameOpt = stateMachineTypeNameOpt;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,2280,2353);

this.StateMachineHoistedLocalSlotsOpt = stateMachineHoistedLocalSlotsOpt;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,2367,2430);

this.StateMachineAwaiterSlotsOpt = stateMachineAwaiterSlotsOpt;
DynAbs.Tracing.TraceSender.TraceExitConstructor(756,1020,2441);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(756,1020,2441);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(756,1020,2441);
}
		}

public AddedOrChangedMethodInfo MapTypes(SymbolMatcher map)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(756,2453,3206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,2537,2615);

var 
mappedLocals = f_756_2556_2614(this.Locals, MapLocalInfo, map)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,2629,2826);

var 
mappedHoistedLocalSlots = (DynAbs.Tracing.TraceSender.Conditional_F1(756, 2659, 2701)||((StateMachineHoistedLocalSlotsOpt.IsDefault &&DynAbs.Tracing.TraceSender.Conditional_F2(756, 2704, 2736))||DynAbs.Tracing.TraceSender.Conditional_F3(756, 2739, 2825)))?StateMachineHoistedLocalSlotsOpt :f_756_2739_2825(StateMachineHoistedLocalSlotsOpt, MapHoistedLocalSlot, map)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,2840,3009);

var 
mappedAwaiterSlots = (DynAbs.Tracing.TraceSender.Conditional_F1(756, 2865, 2902)||((StateMachineAwaiterSlotsOpt.IsDefault &&DynAbs.Tracing.TraceSender.Conditional_F2(756, 2905, 2932))||DynAbs.Tracing.TraceSender.Conditional_F3(756, 2935, 3008)))?StateMachineAwaiterSlotsOpt :f_756_2935_3008(StateMachineAwaiterSlotsOpt, map.MapReference)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,3025,3195);

return f_756_3032_3194(this.MethodId, mappedLocals, LambdaDebugInfo, ClosureDebugInfo, StateMachineTypeNameOpt, mappedHoistedLocalSlots, mappedAwaiterSlots);
DynAbs.Tracing.TraceSender.TraceExitMethod(756,2453,3206);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
f_756_2556_2614(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
items,System.Func<Microsoft.CodeAnalysis.Emit.EncLocalInfo, Microsoft.CodeAnalysis.Emit.SymbolMatcher, Microsoft.CodeAnalysis.Emit.EncLocalInfo>
selector,Microsoft.CodeAnalysis.Emit.SymbolMatcher
arg)
{
var return_v = ImmutableArray.CreateRange( items, selector, arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 2556, 2614);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
f_756_2739_2825(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
items,System.Func<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo, Microsoft.CodeAnalysis.Emit.SymbolMatcher, Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
selector,Microsoft.CodeAnalysis.Emit.SymbolMatcher
arg)
{
var return_v = ImmutableArray.CreateRange( items, selector, arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 2739, 2825);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
f_756_2935_3008(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
items,System.Func<Microsoft.Cci.ITypeReference, Microsoft.Cci.ITypeReference>
selector)
{
var return_v = ImmutableArray.CreateRange( items, selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 2935, 3008);
return return_v;
}


Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo
f_756_3032_3194(Microsoft.CodeAnalysis.CodeGen.DebugId
methodId,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
lambdaDebugInfo,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
closureDebugInfo,string
stateMachineTypeNameOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
stateMachineHoistedLocalSlotsOpt,System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
stateMachineAwaiterSlotsOpt)
{
var return_v = new Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo( methodId, locals, lambdaDebugInfo, closureDebugInfo, stateMachineTypeNameOpt, stateMachineHoistedLocalSlotsOpt, stateMachineAwaiterSlotsOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 3032, 3194);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(756,2453,3206);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(756,2453,3206);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static EncLocalInfo MapLocalInfo(EncLocalInfo info, SymbolMatcher map)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(756,3218,3627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,3321,3351);

f_756_3321_3350(f_756_3334_3349_M(!info.IsDefault));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,3365,3498) || true) && (info.IsUnused)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(756,3365,3498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,3416,3453);

f_756_3416_3452(info.Signature != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,3471,3483);

return info;
DynAbs.Tracing.TraceSender.TraceExitCondition(756,3365,3498);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,3514,3616);

return f_756_3521_3615(info.SlotInfo, f_756_3553_3580(map, info.Type), info.Constraints, info.Signature);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(756,3218,3627);

bool
f_756_3334_3349_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(756, 3334, 3349);
return return_v;
}


int
f_756_3321_3350(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 3321, 3350);
return 0;
}


int
f_756_3416_3452(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 3416, 3452);
return 0;
}


Microsoft.Cci.ITypeReference
f_756_3553_3580(Microsoft.CodeAnalysis.Emit.SymbolMatcher
this_param,Microsoft.Cci.ITypeReference
reference)
{
var return_v = this_param.MapReference( reference);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 3553, 3580);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EncLocalInfo
f_756_3521_3615(Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
slotInfo,Microsoft.Cci.ITypeReference
type,Microsoft.CodeAnalysis.LocalSlotConstraints
constraints,byte[]
signature)
{
var return_v = new Microsoft.CodeAnalysis.Emit.EncLocalInfo( slotInfo, type, constraints, signature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 3521, 3615);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(756,3218,3627);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(756,3218,3627);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static EncHoistedLocalInfo MapHoistedLocalSlot(EncHoistedLocalInfo info, SymbolMatcher map)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(756,3639,3943);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,3763,3841) || true) && (info.IsUnused)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(756,3763,3841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,3814,3826);

return info;
DynAbs.Tracing.TraceSender.TraceExitCondition(756,3763,3841);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(756,3857,3932);

return f_756_3864_3931(info.SlotInfo, f_756_3903_3930(map, info.Type));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(756,3639,3943);

Microsoft.Cci.ITypeReference
f_756_3903_3930(Microsoft.CodeAnalysis.Emit.SymbolMatcher
this_param,Microsoft.Cci.ITypeReference
reference)
{
var return_v = this_param.MapReference( reference);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 3903, 3930);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo
f_756_3864_3931(Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
slotInfo,Microsoft.Cci.ITypeReference
type)
{
var return_v = new Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo( slotInfo, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 3864, 3931);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(756,3639,3943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(756,3639,3943);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static AddedOrChangedMethodInfo(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(756,380,3950);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(756,380,3950);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(756,380,3950);
}

static int
f_756_1636_1674(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 1636, 1674);
return 0;
}


static int
f_756_1748_1836(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 1748, 1836);
return 0;
}


static int
f_756_1919_2012(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(756, 1919, 2012);
return 0;
}

    }
}
