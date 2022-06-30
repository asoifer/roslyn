// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.Text;
using Cci = Microsoft.Cci;

namespace Microsoft.CodeAnalysis
{
internal class CommonMethodWellKnownAttributeData : WellKnownAttributeData, ISecurityAttributeTarget
{
public CommonMethodWellKnownAttributeData(bool preserveSigFirstWriteWins)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(794,669,907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,1397,1423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,1499,1518);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,1542,1563);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,1586,1601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,1705,1721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,1797,1808);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,1901,1918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,5139,5163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,5648,5682);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,6205,6247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,6801,6827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,7991,8027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,767,822);

_preserveSigFirstWriteWins = preserveSigFirstWriteWins;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,836,896);

_dllImportIndex = _methodImplIndex = _preserveSigIndex = -1;
DynAbs.Tracing.TraceSender.TraceExitConstructor(794,669,907);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,669,907);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,669,907);
}
		}

public CommonMethodWellKnownAttributeData()
:this(f_794_983_988_C(false) )
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(794,919,1011);
DynAbs.Tracing.TraceSender.TraceExitConstructor(794,919,1011);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,919,1011);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,919,1011);
}
		}

private readonly bool _preserveSigFirstWriteWins;

private DllImportData _platformInvokeInfo;

private bool _dllImportPreserveSig;

private int _dllImportIndex;

private int _methodImplIndex;

private MethodImplAttributes _attributes;

private int _preserveSigIndex;

public void SetPreserveSignature(int attributeIndex)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,2007,2252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2084,2114);

f_794_2084_2113(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2128,2162);

f_794_2128_2161(attributeIndex >= 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2176,2211);

_preserveSigIndex = attributeIndex;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2225,2241);

f_794_2225_2240(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(794,2007,2252);

int
f_794_2084_2113(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 2084, 2113);
return 0;
}


int
f_794_2128_2161(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 2128, 2161);
return 0;
}


int
f_794_2225_2240(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 2225, 2240);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,2007,2252);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,2007,2252);
}
		}

public void SetMethodImplementation(int attributeIndex, MethodImplAttributes attributes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,2304,2623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2417,2447);

f_794_2417_2446(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2461,2495);

f_794_2461_2494(attributeIndex >= 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2509,2534);

_attributes = attributes;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2548,2582);

_methodImplIndex = attributeIndex;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2596,2612);

f_794_2596_2611(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(794,2304,2623);

int
f_794_2417_2446(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 2417, 2446);
return 0;
}


int
f_794_2461_2494(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 2461, 2494);
return 0;
}


int
f_794_2596_2611(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 2596, 2611);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,2304,2623);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,2304,2623);
}
		}

public void SetDllImport(int attributeIndex, string moduleName, string entryPointName, MethodImportAttributes flags, bool preserveSig)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,2674,3138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2833,2863);

f_794_2833_2862(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2877,2911);

f_794_2877_2910(attributeIndex >= 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,2925,3000);

_platformInvokeInfo = f_794_2947_2999(moduleName, entryPointName, flags);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,3014,3047);

_dllImportIndex = attributeIndex;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,3061,3097);

_dllImportPreserveSig = preserveSig;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,3111,3127);

f_794_3111_3126(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(794,2674,3138);

int
f_794_2833_2862(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 2833, 2862);
return 0;
}


int
f_794_2877_2910(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 2877, 2910);
return 0;
}


Microsoft.CodeAnalysis.DllImportData
f_794_2947_2999(string
moduleName,string
entryPointName,System.Reflection.MethodImportAttributes
flags)
{
var return_v = new Microsoft.CodeAnalysis.DllImportData( moduleName, entryPointName, flags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 2947, 2999);
return return_v;
}


int
f_794_3111_3126(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 3111, 3126);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,2674,3138);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,2674,3138);
}
		}

public DllImportData DllImportPlatformInvokeData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,3223,3348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,3259,3288);

f_794_3259_3287(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,3306,3333);

return _platformInvokeInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(794,3223,3348);

int
f_794_3259_3287(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 3259, 3287);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,3150,3359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,3150,3359);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public MethodImplAttributes MethodImplAttributes
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,3444,5045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,3480,3509);

f_794_3480_3508(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,3527,3552);

var 
result = _attributes
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,3572,3727) || true) && (_dllImportPreserveSig ||(DynAbs.Tracing.TraceSender.Expression_False(794, 3576, 3623)||_preserveSigIndex >= 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(794,3572,3727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,3665,3708);

result |= MethodImplAttributes.PreserveSig;
DynAbs.Tracing.TraceSender.TraceExitCondition(794,3572,3727);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,3747,4996) || true) && (_dllImportIndex >= 0 &&(DynAbs.Tracing.TraceSender.Expression_True(794, 3751, 3797)&&!_dllImportPreserveSig))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(794,3747,4996);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,3839,4977) || true) && (_preserveSigFirstWriteWins)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(794,3839,4977);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,4076,4425) || true) && ((_preserveSigIndex == -1 ||(DynAbs.Tracing.TraceSender.Expression_False(794, 4081, 4143)||_dllImportIndex < _preserveSigIndex)) &&(DynAbs.Tracing.TraceSender.Expression_True(794, 4080, 4296)&&                            (_methodImplIndex == -1 ||(DynAbs.Tracing.TraceSender.Expression_False(794, 4178, 4257)||(_attributes & MethodImplAttributes.PreserveSig) == 0 )||(DynAbs.Tracing.TraceSender.Expression_False(794, 4178, 4295)||_dllImportIndex < _methodImplIndex))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(794,4076,4425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,4354,4398);

result &= ~MethodImplAttributes.PreserveSig;
DynAbs.Tracing.TraceSender.TraceExitCondition(794,4076,4425);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(794,3839,4977);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(794,3839,4977);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,4689,4954) || true) && (_dllImportIndex > _preserveSigIndex &&(DynAbs.Tracing.TraceSender.Expression_True(794, 4693, 4825)&&(_dllImportIndex > _methodImplIndex ||(DynAbs.Tracing.TraceSender.Expression_False(794, 4733, 4824)||(_attributes & MethodImplAttributes.PreserveSig) == 0))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(794,4689,4954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,4883,4927);

result &= ~MethodImplAttributes.PreserveSig;
DynAbs.Tracing.TraceSender.TraceExitCondition(794,4689,4954);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(794,3839,4977);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(794,3747,4996);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,5016,5030);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(794,3444,5045);

int
f_794_3480_3508(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 3480, 3508);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,3371,5056);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,3371,5056);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _hasSpecialNameAttribute;

public bool HasSpecialNameAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,5234,5364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,5270,5299);

f_794_5270_5298(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,5317,5349);

return _hasSpecialNameAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(794,5234,5364);

int
f_794_5270_5298(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 5270, 5298);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,5174,5555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,5174,5555);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,5378,5544);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,5414,5444);

f_794_5414_5443(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,5462,5495);

_hasSpecialNameAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,5513,5529);

f_794_5513_5528(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(794,5378,5544);

int
f_794_5414_5443(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 5414, 5443);
return 0;
}


int
f_794_5513_5528(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 5513, 5528);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,5174,5555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,5174,5555);
}
		}}

private bool _hasDynamicSecurityMethodAttribute;

public bool HasDynamicSecurityMethodAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,5763,5903);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,5799,5828);

f_794_5799_5827(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,5846,5888);

return _hasDynamicSecurityMethodAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(794,5763,5903);

int
f_794_5799_5827(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 5799, 5827);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,5693,6104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,5693,6104);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,5917,6093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,5953,5983);

f_794_5953_5982(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,6001,6044);

_hasDynamicSecurityMethodAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,6062,6078);

f_794_6062_6077(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(794,5917,6093);

int
f_794_5953_5982(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 5953, 5982);
return 0;
}


int
f_794_6062_6077(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 6062, 6077);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,5693,6104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,5693,6104);
}
		}}

private bool _hasSuppressUnmanagedCodeSecurityAttribute;

public bool HasSuppressUnmanagedCodeSecurityAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,6336,6484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,6372,6401);

f_794_6372_6400(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,6419,6469);

return _hasSuppressUnmanagedCodeSecurityAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(794,6336,6484);

int
f_794_6372_6400(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 6372, 6400);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,6258,6693);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,6258,6693);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,6498,6682);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,6534,6564);

f_794_6534_6563(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,6582,6633);

_hasSuppressUnmanagedCodeSecurityAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,6651,6667);

f_794_6651_6666(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(794,6498,6682);

int
f_794_6534_6563(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 6534, 6563);
return 0;
}


int
f_794_6651_6666(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 6651, 6666);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,6258,6693);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,6258,6693);
}
		}}

private SecurityWellKnownAttributeData _lazySecurityAttributeData;

SecurityWellKnownAttributeData ISecurityAttributeTarget.GetOrCreateData()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,6840,7232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,6938,6968);

f_794_6938_6967(this, expected: false);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,6984,7171) || true) && (_lazySecurityAttributeData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(794,6984,7171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,7056,7122);

_lazySecurityAttributeData = f_794_7085_7121();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,7140,7156);

f_794_7140_7155(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(794,6984,7171);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,7187,7221);

return _lazySecurityAttributeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(794,6840,7232);

int
f_794_6938_6967(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 6938, 6967);
return 0;
}


Microsoft.CodeAnalysis.SecurityWellKnownAttributeData
f_794_7085_7121()
{
var return_v = new Microsoft.CodeAnalysis.SecurityWellKnownAttributeData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 7085, 7121);
return return_v;
}


int
f_794_7140_7155(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 7140, 7155);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,6840,7232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,6840,7232);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool HasDeclarativeSecurity
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,7305,7495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,7341,7370);

f_794_7341_7369(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,7388,7480);

return _lazySecurityAttributeData != null ||(DynAbs.Tracing.TraceSender.Expression_False(794, 7395, 7479)||f_794_7433_7479(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(794,7305,7495);

int
f_794_7341_7369(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 7341, 7369);
return 0;
}


bool
f_794_7433_7479(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param)
{
var return_v = this_param.HasSuppressUnmanagedCodeSecurityAttribute;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(794, 7433, 7479);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,7244,7506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,7244,7506);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public SecurityWellKnownAttributeData SecurityInformation
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,7751,7883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,7787,7816);

f_794_7787_7815(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,7834,7868);

return _lazySecurityAttributeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(794,7751,7883);

int
f_794_7787_7815(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 7787, 7815);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,7669,7894);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,7669,7894);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _hasExcludeFromCodeCoverageAttribute;

public bool HasExcludeFromCodeCoverageAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,8110,8252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,8146,8175);

f_794_8146_8174(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,8193,8237);

return _hasExcludeFromCodeCoverageAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(794,8110,8252);

int
f_794_8146_8174(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 8146, 8174);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,8038,8455);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,8038,8455);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(794,8266,8444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,8302,8332);

f_794_8302_8331(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,8350,8395);

_hasExcludeFromCodeCoverageAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(794,8413,8429);

f_794_8413_8428(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(794,8266,8444);

int
f_794_8302_8331(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 8302, 8331);
return 0;
}


int
f_794_8413_8428(Microsoft.CodeAnalysis.CommonMethodWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(794, 8413, 8428);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(794,8038,8455);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,8038,8455);
}
		}}

static CommonMethodWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(794,552,8484);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(794,552,8484);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(794,552,8484);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(794,552,8484);

static bool
f_794_983_988_C(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(794, 919, 1011);
return return_v;
}

}
}
