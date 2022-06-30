// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Emit
{

[DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal struct EncLocalInfo : IEquatable<EncLocalInfo>
    {

public readonly LocalSlotDebugInfo SlotInfo;

public readonly Cci.ITypeReference Type;

public readonly LocalSlotConstraints Constraints;

public readonly byte[] Signature;

public readonly bool isUnused;

public EncLocalInfo(byte[] signature)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(763,756,1188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,818,850);

f_763_818_849(signature != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,864,899);

f_763_864_898(f_763_877_893(signature)> 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,915,1007);

this.SlotInfo = f_763_931_1006(SynthesizedLocalKind.EmitterTemp, LocalDebugId.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1021,1038);

this.Type = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1052,1101);

this.Constraints = default(LocalSlotConstraints);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1115,1142);

this.Signature = signature;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1156,1177);

this.isUnused = true;
DynAbs.Tracing.TraceSender.TraceExitConstructor(763,756,1188);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(763,756,1188);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(763,756,1188);
}
		}

public EncLocalInfo(LocalSlotDebugInfo slotInfo, Cci.ITypeReference type, LocalSlotConstraints constraints, byte[] signature)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(763,1200,1582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1350,1377);

f_763_1350_1376(type != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1393,1418);

this.SlotInfo = slotInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1432,1449);

this.Type = type;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1463,1494);

this.Constraints = constraints;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1508,1535);

this.Signature = signature;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1549,1571);

this.isUnused = false;
DynAbs.Tracing.TraceSender.TraceExitConstructor(763,1200,1582);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(763,1200,1582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(763,1200,1582);
}
		}

public bool IsDefault
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(763,1640,1699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1646,1697);

return this.Type == null &&(DynAbs.Tracing.TraceSender.Expression_True(763, 1653, 1696)&&this.Signature == null);
DynAbs.Tracing.TraceSender.TraceExitMethod(763,1640,1699);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(763,1594,1710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(763,1594,1710);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool IsUnused
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(763,1767,1791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1773,1789);

return isUnused;
DynAbs.Tracing.TraceSender.TraceExitMethod(763,1767,1791);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(763,1722,1802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(763,1722,1802);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool Equals(EncLocalInfo other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(763,1814,2242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1877,1909);

f_763_1877_1908(this.Type != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1923,1956);

f_763_1923_1955(other.Type != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,1972,2231);

return this.SlotInfo.Equals(other.SlotInfo)&&(DynAbs.Tracing.TraceSender.Expression_True(763, 1979, 2114)&&f_763_2039_2114(                   Cci.SymbolEquivalentEqualityComparer.Instance, this.Type, other.Type))&&(DynAbs.Tracing.TraceSender.Expression_True(763, 1979, 2175)&&                   this.Constraints == other.Constraints )&&(DynAbs.Tracing.TraceSender.Expression_True(763, 1979, 2230)&&                   this.isUnused == other.isUnused);
DynAbs.Tracing.TraceSender.TraceExitMethod(763,1814,2242);

int
f_763_1877_1908(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 1877, 1908);
return 0;
}


int
f_763_1923_1955(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 1923, 1955);
return 0;
}


bool
f_763_2039_2114(Microsoft.Cci.SymbolEquivalentEqualityComparer
this_param,Microsoft.Cci.ITypeReference
x,Microsoft.Cci.ITypeReference
y)
{
var return_v = this_param.Equals( (Microsoft.Cci.IReference)x, (Microsoft.Cci.IReference)y);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 2039, 2114);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(763,1814,2242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(763,1814,2242);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool Equals(object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(763,2254,2385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,2318,2374);

return obj is EncLocalInfo &&(DynAbs.Tracing.TraceSender.Expression_True(763, 2325, 2373)&&Equals(obj));
DynAbs.Tracing.TraceSender.TraceExitMethod(763,2254,2385);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(763,2254,2385);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(763,2254,2385);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int GetHashCode()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(763,2397,2771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,2455,2487);

f_763_2455_2486(this.Type != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,2503,2760);

return f_763_2510_2759(this.SlotInfo.GetHashCode(), f_763_2572_2758(f_763_2585_2653(Cci.SymbolEquivalentEqualityComparer.Instance, this.Type), f_763_2675_2757(this.Constraints, f_763_2731_2756(isUnused, 0))));
DynAbs.Tracing.TraceSender.TraceExitMethod(763,2397,2771);

int
f_763_2455_2486(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 2455, 2486);
return 0;
}


int
f_763_2585_2653(Microsoft.Cci.SymbolEquivalentEqualityComparer
this_param,Microsoft.Cci.ITypeReference
obj)
{
var return_v = this_param.GetHashCode( (Microsoft.Cci.IReference)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 2585, 2653);
return return_v;
}


int
f_763_2731_2756(bool
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 2731, 2756);
return return_v;
}


int
f_763_2675_2757(Microsoft.CodeAnalysis.LocalSlotConstraints
newKey,int
currentKey)
{
var return_v = Hash.Combine( (int)newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 2675, 2757);
return return_v;
}


int
f_763_2572_2758(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 2572, 2758);
return return_v;
}


int
f_763_2510_2759(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 2510, 2759);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(763,2397,2771);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(763,2397,2771);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetDebuggerDisplay()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(763,2783,3385);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,2843,2929) || true) && (this.IsDefault)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(763,2843,2929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,2895,2914);

return "[default]";
DynAbs.Tracing.TraceSender.TraceExitCondition(763,2843,2929);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,2945,3030) || true) && (this.isUnused)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(763,2945,3030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,2996,3015);

return "[invalid]";
DynAbs.Tracing.TraceSender.TraceExitCondition(763,2945,3030);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(763,3046,3374);

return f_763_3053_3373("[Id={0}, SynthesizedKind={1}, Type={2}, Constraints={3}, Sig={4}]", this.SlotInfo.Id, this.SlotInfo.SynthesizedKind, this.Type, this.Constraints, (DynAbs.Tracing.TraceSender.Conditional_F1(763, 3299, 3323)||((                (this.Signature != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(763, 3326, 3363))||DynAbs.Tracing.TraceSender.Conditional_F3(763, 3366, 3372)))?f_763_3326_3363(this.Signature):"null");
DynAbs.Tracing.TraceSender.TraceExitMethod(763,2783,3385);

string
f_763_3326_3363(byte[]
value)
{
var return_v = BitConverter.ToString( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 3326, 3363);
return return_v;
}


string
f_763_3053_3373(string
format,params object?[]
args)
{
var return_v = string.Format( format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 3053, 3373);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(763,2783,3385);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(763,2783,3385);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static EncLocalInfo(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(763,383,3392);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(763,383,3392);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(763,383,3392);
}

static int
f_763_818_849(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 818, 849);
return 0;
}


static int
f_763_877_893(byte[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(763, 877, 893);
return return_v;
}


static int
f_763_864_898(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 864, 898);
return 0;
}


static Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
f_763_931_1006(Microsoft.CodeAnalysis.SynthesizedLocalKind
synthesizedKind,Microsoft.CodeAnalysis.CodeGen.LocalDebugId
id)
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo( synthesizedKind, id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 931, 1006);
return return_v;
}


static int
f_763_1350_1376(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(763, 1350, 1376);
return 0;
}

    }
}
