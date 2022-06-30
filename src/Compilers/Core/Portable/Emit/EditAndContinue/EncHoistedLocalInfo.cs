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
    internal struct EncHoistedLocalInfo : IEquatable<EncHoistedLocalInfo>
    {

public readonly LocalSlotDebugInfo SlotInfo;

public readonly Cci.ITypeReference Type;

public EncHoistedLocalInfo(bool ignored)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(761,628,817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,693,780);

SlotInfo = f_761_704_779(SynthesizedLocalKind.EmitterTemp, LocalDebugId.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,794,806);

Type = null;
DynAbs.Tracing.TraceSender.TraceExitConstructor(761,628,817);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(761,628,817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(761,628,817);
}
		}

public EncHoistedLocalInfo(LocalSlotDebugInfo slotInfo, Cci.ITypeReference type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(761,829,1042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,934,961);

f_761_934_960(type != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,975,1000);

this.SlotInfo = slotInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,1014,1031);

this.Type = type;
DynAbs.Tracing.TraceSender.TraceExitConstructor(761,829,1042);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(761,829,1042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(761,829,1042);
}
		}

public bool IsUnused
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(761,1099,1132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,1105,1130);

return this.Type == null;
DynAbs.Tracing.TraceSender.TraceExitMethod(761,1099,1132);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(761,1054,1143);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(761,1054,1143);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool Equals(EncHoistedLocalInfo other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(761,1155,1474);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,1225,1257);

f_761_1225_1256(this.Type != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,1271,1304);

f_761_1271_1303(other.Type != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,1320,1463);

return this.SlotInfo.Equals(other.SlotInfo)&&(DynAbs.Tracing.TraceSender.Expression_True(761, 1327, 1462)&&f_761_1387_1462(                   Cci.SymbolEquivalentEqualityComparer.Instance, this.Type, other.Type));
DynAbs.Tracing.TraceSender.TraceExitMethod(761,1155,1474);

int
f_761_1225_1256(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(761, 1225, 1256);
return 0;
}


int
f_761_1271_1303(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(761, 1271, 1303);
return 0;
}


bool
f_761_1387_1462(Microsoft.Cci.SymbolEquivalentEqualityComparer
this_param,Microsoft.Cci.ITypeReference
x,Microsoft.Cci.ITypeReference
y)
{
var return_v = this_param.Equals( (Microsoft.Cci.IReference)x, (Microsoft.Cci.IReference)y);
DynAbs.Tracing.TraceSender.TraceEndInvocation(761, 1387, 1462);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(761,1155,1474);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(761,1155,1474);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool Equals(object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(761,1486,1631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,1550,1620);

return obj is EncHoistedLocalInfo &&(DynAbs.Tracing.TraceSender.Expression_True(761, 1557, 1619)&&Equals(obj));
DynAbs.Tracing.TraceSender.TraceExitMethod(761,1486,1631);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(761,1486,1631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(761,1486,1631);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int GetHashCode()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(761,1643,1831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,1701,1820);

return f_761_1708_1819(f_761_1721_1789(Cci.SymbolEquivalentEqualityComparer.Instance, this.Type), this.SlotInfo.GetHashCode());
DynAbs.Tracing.TraceSender.TraceExitMethod(761,1643,1831);

int
f_761_1721_1789(Microsoft.Cci.SymbolEquivalentEqualityComparer
this_param,Microsoft.Cci.ITypeReference
obj)
{
var return_v = this_param.GetHashCode( (Microsoft.Cci.IReference)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(761, 1721, 1789);
return return_v;
}


int
f_761_1708_1819(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(761, 1708, 1819);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(761,1643,1831);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(761,1643,1831);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetDebuggerDisplay()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(761,1843,2190);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,1903,1988) || true) && (this.IsUnused)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(761,1903,1988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,1954,1973);

return "[invalid]";
DynAbs.Tracing.TraceSender.TraceExitCondition(761,1903,1988);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(761,2004,2179);

return f_761_2011_2178("[Id={0}, SynthesizedKind={1}, Type={2}]", this.SlotInfo.Id, this.SlotInfo.SynthesizedKind, this.Type);
DynAbs.Tracing.TraceSender.TraceExitMethod(761,1843,2190);

string
f_761_2011_2178(string
format,Microsoft.CodeAnalysis.CodeGen.LocalDebugId
arg0,Microsoft.CodeAnalysis.SynthesizedLocalKind
arg1,Microsoft.Cci.ITypeReference
arg2)
{
var return_v = string.Format( format, (object)arg0, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(761, 2011, 2178);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(761,1843,2190);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(761,1843,2190);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static EncHoistedLocalInfo(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(761,383,2197);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(761,383,2197);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(761,383,2197);
}

static Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
f_761_704_779(Microsoft.CodeAnalysis.SynthesizedLocalKind
synthesizedKind,Microsoft.CodeAnalysis.CodeGen.LocalDebugId
id)
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo( synthesizedKind, id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(761, 704, 779);
return return_v;
}


static int
f_761_934_960(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(761, 934, 960);
return 0;
}

    }
}
