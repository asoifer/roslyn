// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
internal class CommonTypeWellKnownAttributeData : WellKnownAttributeData, ISecurityAttributeTarget
{
private bool _hasSpecialNameAttribute;

public bool HasSpecialNameAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,816,946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,852,881);

f_802_852_880(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,899,931);

return _hasSpecialNameAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,816,946);

int
f_802_852_880(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 852, 880);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,756,1137);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,756,1137);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,960,1126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,996,1026);

f_802_996_1025(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,1044,1077);

_hasSpecialNameAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,1095,1111);

f_802_1095_1110(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(802,960,1126);

int
f_802_996_1025(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 996, 1025);
return 0;
}


int
f_802_1095_1110(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 1095, 1110);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,756,1137);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,756,1137);
}
		}}

private bool _hasSerializableAttribute;

public bool HasSerializableAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,1318,1449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,1354,1383);

f_802_1354_1382(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,1401,1434);

return _hasSerializableAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,1318,1449);

int
f_802_1354_1382(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 1354, 1382);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,1257,1641);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,1257,1641);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,1463,1630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,1499,1529);

f_802_1499_1528(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,1547,1581);

_hasSerializableAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,1599,1615);

f_802_1599_1614(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(802,1463,1630);

int
f_802_1499_1528(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 1499, 1528);
return 0;
}


int
f_802_1599_1614(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 1599, 1614);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,1257,1641);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,1257,1641);
}
		}}

private bool _hasDefaultMemberAttribute;

public bool HasDefaultMemberAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,1825,1957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,1861,1890);

f_802_1861_1889(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,1908,1942);

return _hasDefaultMemberAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,1825,1957);

int
f_802_1861_1889(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 1861, 1889);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,1763,2150);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,1763,2150);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,1971,2139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,2007,2037);

f_802_2007_2036(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,2055,2090);

_hasDefaultMemberAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,2108,2124);

f_802_2108_2123(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(802,1971,2139);

int
f_802_2007_2036(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 2007, 2036);
return 0;
}


int
f_802_2108_2123(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 2108, 2123);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,1763,2150);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,1763,2150);
}
		}}

private bool _hasSuppressUnmanagedCodeSecurityAttribute;

public bool HasSuppressUnmanagedCodeSecurityAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,2382,2530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,2418,2447);

f_802_2418_2446(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,2465,2515);

return _hasSuppressUnmanagedCodeSecurityAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,2382,2530);

int
f_802_2418_2446(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 2418, 2446);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,2304,2739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,2304,2739);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,2544,2728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,2580,2610);

f_802_2580_2609(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,2628,2679);

_hasSuppressUnmanagedCodeSecurityAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,2697,2713);

f_802_2697_2712(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(802,2544,2728);

int
f_802_2580_2609(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 2580, 2609);
return 0;
}


int
f_802_2697_2712(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 2697, 2712);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,2304,2739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,2304,2739);
}
		}}

private SecurityWellKnownAttributeData _lazySecurityAttributeData;

SecurityWellKnownAttributeData ISecurityAttributeTarget.GetOrCreateData()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,2886,3278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,2984,3014);

f_802_2984_3013(this, expected: false);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,3030,3217) || true) && (_lazySecurityAttributeData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(802,3030,3217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,3102,3168);

_lazySecurityAttributeData = f_802_3131_3167();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,3186,3202);

f_802_3186_3201(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(802,3030,3217);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,3233,3267);

return _lazySecurityAttributeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,2886,3278);

int
f_802_2984_3013(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 2984, 3013);
return 0;
}


Microsoft.CodeAnalysis.SecurityWellKnownAttributeData
f_802_3131_3167()
{
var return_v = new Microsoft.CodeAnalysis.SecurityWellKnownAttributeData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 3131, 3167);
return return_v;
}


int
f_802_3186_3201(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 3186, 3201);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,2886,3278);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,2886,3278);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool HasDeclarativeSecurity
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,3351,3541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,3387,3416);

f_802_3387_3415(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,3434,3526);

return _lazySecurityAttributeData != null ||(DynAbs.Tracing.TraceSender.Expression_False(802, 3441, 3525)||f_802_3479_3525(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(802,3351,3541);

int
f_802_3387_3415(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 3387, 3415);
return 0;
}


bool
f_802_3479_3525(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param)
{
var return_v = this_param.HasSuppressUnmanagedCodeSecurityAttribute;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(802, 3479, 3525);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,3290,3552);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,3290,3552);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public SecurityWellKnownAttributeData SecurityInformation
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,3797,3929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,3833,3862);

f_802_3833_3861(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,3880,3914);

return _lazySecurityAttributeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,3797,3929);

int
f_802_3833_3861(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 3833, 3861);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,3715,3940);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,3715,3940);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _hasWindowsRuntimeImportAttribute;

public bool HasWindowsRuntimeImportAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,4145,4284);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4181,4210);

f_802_4181_4209(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4228,4269);

return _hasWindowsRuntimeImportAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,4145,4284);

int
f_802_4181_4209(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 4181, 4209);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,4076,4484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,4076,4484);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,4298,4473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4334,4364);

f_802_4334_4363(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4382,4424);

_hasWindowsRuntimeImportAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4442,4458);

f_802_4442_4457(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(802,4298,4473);

int
f_802_4334_4363(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 4334, 4363);
return 0;
}


int
f_802_4442_4457(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 4442, 4457);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,4076,4484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,4076,4484);
}
		}}

private string _guidString;

public string GuidString
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,4686,4803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4722,4751);

f_802_4722_4750(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4769,4788);

return _guidString;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,4686,4803);

int
f_802_4722_4750(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 4722, 4750);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,4637,5027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,4637,5027);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,4817,5016);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4853,4883);

f_802_4853_4882(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4901,4929);

f_802_4901_4928(value != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4947,4967);

_guidString = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4985,5001);

f_802_4985_5000(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(802,4817,5016);

int
f_802_4853_4882(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 4853, 4882);
return 0;
}


int
f_802_4901_4928(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 4901, 4928);
return 0;
}


int
f_802_4985_5000(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 4985, 5000);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,4637,5027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,4637,5027);
}
		}}

private TypeLayout _layout;

private CharSet _charSet;

public void SetStructLayout(TypeLayout layout, CharSet charSet)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,5208,5554);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,5296,5326);

f_802_5296_5325(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,5340,5449);

f_802_5340_5448(charSet == CharSet.Ansi ||(DynAbs.Tracing.TraceSender.Expression_False(802, 5353, 5406)||charSet == CharSet.Unicode )||(DynAbs.Tracing.TraceSender.Expression_False(802, 5353, 5447)||charSet == Cci.Constants.CharSet_Auto));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,5463,5480);

_layout = layout;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,5494,5513);

_charSet = charSet;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,5527,5543);

f_802_5527_5542(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(802,5208,5554);

int
f_802_5296_5325(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 5296, 5325);
return 0;
}


int
f_802_5340_5448(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 5340, 5448);
return 0;
}


int
f_802_5527_5542(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 5527, 5542);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,5208,5554);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,5208,5554);
}
		}

public bool HasStructLayoutAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,5627,5862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,5663,5692);

f_802_5663_5691(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,5826,5847);

return _charSet != 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,5627,5862);

int
f_802_5663_5691(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 5663, 5691);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,5566,5873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,5566,5873);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public TypeLayout Layout
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,5934,6104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,5970,5999);

f_802_5970_5998(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,6017,6056);

f_802_6017_6055(f_802_6030_6054());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,6074,6089);

return _layout;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,5934,6104);

int
f_802_5970_5998(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 5970, 5998);
return 0;
}


bool
f_802_6030_6054()
{
var return_v = HasStructLayoutAttribute;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(802, 6030, 6054);
return return_v;
}


int
f_802_6017_6055(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 6017, 6055);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,5885,6115);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,5885,6115);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public CharSet MarshallingCharSet
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,6185,6356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,6221,6250);

f_802_6221_6249(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,6268,6307);

f_802_6268_6306(f_802_6281_6305());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,6325,6341);

return _charSet;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,6185,6356);

int
f_802_6221_6249(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 6221, 6249);
return 0;
}


bool
f_802_6281_6305()
{
var return_v = HasStructLayoutAttribute;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(802, 6281, 6305);
return return_v;
}


int
f_802_6268_6306(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 6268, 6306);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,6127,6367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,6127,6367);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _hasSecurityCriticalAttributes;

public bool HasSecurityCriticalAttributes
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,6598,6734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,6634,6663);

f_802_6634_6662(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,6681,6719);

return _hasSecurityCriticalAttributes;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,6598,6734);

int
f_802_6634_6662(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 6634, 6662);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,6532,6931);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,6532,6931);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,6748,6920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,6784,6814);

f_802_6784_6813(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,6832,6871);

_hasSecurityCriticalAttributes = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,6889,6905);

f_802_6889_6904(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(802,6748,6920);

int
f_802_6784_6813(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 6784, 6813);
return 0;
}


int
f_802_6889_6904(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 6889, 6904);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,6532,6931);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,6532,6931);
}
		}}

private bool _hasExcludeFromCodeCoverageAttribute;

public bool HasExcludeFromCodeCoverageAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,7147,7289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,7183,7212);

f_802_7183_7211(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,7230,7274);

return _hasExcludeFromCodeCoverageAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(802,7147,7289);

int
f_802_7183_7211(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 7183, 7211);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,7075,7492);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,7075,7492);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(802,7303,7481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,7339,7369);

f_802_7339_7368(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,7387,7432);

_hasExcludeFromCodeCoverageAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,7450,7466);

f_802_7450_7465(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(802,7303,7481);

int
f_802_7339_7368(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 7339, 7368);
return 0;
}


int
f_802_7450_7465(Microsoft.CodeAnalysis.CommonTypeWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(802, 7450, 7465);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(802,7075,7492);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,7075,7492);
}
		}}

public CommonTypeWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(802,555,7521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,721,745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,1221,1246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,1726,1752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,2251,2293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,2847,2873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4032,4065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,4613,4624);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,5153,5161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,6491,6521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(802,7028,7064);
DynAbs.Tracing.TraceSender.TraceExitConstructor(802,555,7521);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,555,7521);
}


static CommonTypeWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(802,555,7521);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(802,555,7521);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(802,555,7521);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(802,555,7521);
}
}
