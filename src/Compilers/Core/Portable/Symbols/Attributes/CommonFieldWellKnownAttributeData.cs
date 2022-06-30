// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
internal class CommonFieldWellKnownAttributeData : WellKnownAttributeData, IMarshalAsAttributeTarget
{
public CommonFieldWellKnownAttributeData()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(792,574,676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,738,745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,1400,1433);
this._constValue = f_792_1414_1433();DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,1900,1924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2401,2427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2934,2952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,641,665);

_offset = Uninitialized;
DynAbs.Tracing.TraceSender.TraceExitConstructor(792,574,676);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(792,574,676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,574,676);
}
		}

private int _offset;

private const int 
Uninitialized = -1
;

public void SetFieldOffset(int offset)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(792,848,1053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,911,941);

f_792_911_940(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,955,981);

f_792_955_980(offset >= 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,995,1012);

_offset = offset;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,1026,1042);

f_792_1026_1041(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(792,848,1053);

int
f_792_911_940(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 911, 940);
return 0;
}


int
f_792_955_980(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 955, 980);
return 0;
}


int
f_792_1026_1041(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 1026, 1041);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(792,848,1053);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,848,1053);
}
		}

public int? Offset
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(792,1108,1261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,1144,1173);

f_792_1144_1172(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,1191,1246);

return (DynAbs.Tracing.TraceSender.Conditional_F1(792, 1198, 1222)||((_offset != Uninitialized &&DynAbs.Tracing.TraceSender.Conditional_F2(792, 1225, 1232))||DynAbs.Tracing.TraceSender.Conditional_F3(792, 1235, 1245)))?_offset :(int?)null;
DynAbs.Tracing.TraceSender.TraceExitMethod(792,1108,1261);

int
f_792_1144_1172(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 1144, 1172);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(792,1065,1272);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,1065,1272);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private ConstantValue _constValue ;

public ConstantValue ConstValue
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(792,1502,1572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,1538,1557);

return _constValue;
DynAbs.Tracing.TraceSender.TraceExitMethod(792,1502,1572);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(792,1446,1817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,1446,1817);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(792,1586,1806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,1622,1652);

f_792_1622_1651(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,1670,1719);

f_792_1670_1718(_constValue == f_792_1698_1717());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,1737,1757);

_constValue = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,1775,1791);

f_792_1775_1790(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(792,1586,1806);

int
f_792_1622_1651(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 1622, 1651);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_792_1698_1717()
{
var return_v = ConstantValue.Unset;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(792, 1698, 1717);
return return_v;
}


int
f_792_1670_1718(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 1670, 1718);
return 0;
}


int
f_792_1775_1790(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 1775, 1790);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(792,1446,1817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,1446,1817);
}
		}}

private bool _hasSpecialNameAttribute;

public bool HasSpecialNameAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(792,1995,2125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2031,2060);

f_792_2031_2059(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2078,2110);

return _hasSpecialNameAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(792,1995,2125);

int
f_792_2031_2059(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 2031, 2059);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(792,1935,2316);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,1935,2316);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(792,2139,2305);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2175,2205);

f_792_2175_2204(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2223,2256);

_hasSpecialNameAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2274,2290);

f_792_2274_2289(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(792,2139,2305);

int
f_792_2175_2204(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 2175, 2204);
return 0;
}


int
f_792_2274_2289(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 2274, 2289);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(792,1935,2316);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,1935,2316);
}
		}}

private bool _hasNonSerializedAttribute;

public bool HasNonSerializedAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(792,2500,2632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2536,2565);

f_792_2536_2564(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2583,2617);

return _hasNonSerializedAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(792,2500,2632);

int
f_792_2536_2564(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 2536, 2564);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(792,2438,2825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,2438,2825);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(792,2646,2814);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2682,2712);

f_792_2682_2711(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2730,2765);

_hasNonSerializedAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,2783,2799);

f_792_2783_2798(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(792,2646,2814);

int
f_792_2682_2711(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 2682, 2711);
return 0;
}


int
f_792_2783_2798(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 2783, 2798);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(792,2438,2825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,2438,2825);
}
		}}

private MarshalPseudoCustomAttributeData _lazyMarshalAsData;

MarshalPseudoCustomAttributeData IMarshalAsAttributeTarget.GetOrCreateData()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(792,2965,3336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,3066,3096);

f_792_3066_3095(this, expected: false);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,3110,3283) || true) && (_lazyMarshalAsData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(792,3110,3283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,3174,3234);

_lazyMarshalAsData = f_792_3195_3233();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,3252,3268);

f_792_3252_3267(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(792,3110,3283);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,3299,3325);

return _lazyMarshalAsData;
DynAbs.Tracing.TraceSender.TraceExitMethod(792,2965,3336);

int
f_792_3066_3095(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 3066, 3095);
return 0;
}


Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
f_792_3195_3233()
{
var return_v = new Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 3195, 3233);
return return_v;
}


int
f_792_3252_3267(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 3252, 3267);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(792,2965,3336);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,2965,3336);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public MarshalPseudoCustomAttributeData MarshallingInformation
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(792,3579,3703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,3615,3644);

f_792_3615_3643(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,3662,3688);

return _lazyMarshalAsData;
DynAbs.Tracing.TraceSender.TraceExitMethod(792,3579,3703);

int
f_792_3615_3643(Microsoft.CodeAnalysis.CommonFieldWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(792, 3615, 3643);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(792,3492,3714);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,3492,3714);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static CommonFieldWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(792,457,3741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(792,817,835);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(792,457,3741);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(792,457,3741);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(792,457,3741);

Microsoft.CodeAnalysis.ConstantValue
f_792_1414_1433()
{
var return_v = ConstantValue.Unset;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(792, 1414, 1433);
return return_v;
}

}
}
