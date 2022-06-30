// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
internal class CommonParameterWellKnownAttributeData : WellKnownAttributeData, IMarshalAsAttributeTarget
{
private bool _hasOutAttribute;

public bool HasOutAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(797,704,826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,740,769);

f_797_740_768(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,787,811);

return _hasOutAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(797,704,826);

int
f_797_740_768(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 740, 768);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(797,652,1009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,652,1009);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(797,840,998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,876,906);

f_797_876_905(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,924,949);

_hasOutAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,967,983);

f_797_967_982(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(797,840,998);

int
f_797_876_905(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 876, 905);
return 0;
}


int
f_797_967_982(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 967, 982);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(797,652,1009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,652,1009);
}
		}}

private bool _hasInAttribute;

public bool HasInAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(797,1160,1281);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1196,1225);

f_797_1196_1224(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1243,1266);

return _hasInAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(797,1160,1281);

int
f_797_1196_1224(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 1196, 1224);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(797,1109,1463);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,1109,1463);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(797,1295,1452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1331,1361);

f_797_1331_1360(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1379,1403);

_hasInAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1421,1437);

f_797_1421_1436(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(797,1295,1452);

int
f_797_1331_1360(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 1331, 1360);
return 0;
}


int
f_797_1421_1436(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 1421, 1436);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(797,1109,1463);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,1109,1463);
}
		}}

private MarshalPseudoCustomAttributeData _lazyMarshalAsData;

MarshalPseudoCustomAttributeData IMarshalAsAttributeTarget.GetOrCreateData()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(797,1603,1974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1704,1734);

f_797_1704_1733(this, expected: false);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1748,1921) || true) && (_lazyMarshalAsData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(797,1748,1921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1812,1872);

_lazyMarshalAsData = f_797_1833_1871();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1890,1906);

f_797_1890_1905(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(797,1748,1921);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1937,1963);

return _lazyMarshalAsData;
DynAbs.Tracing.TraceSender.TraceExitMethod(797,1603,1974);

int
f_797_1704_1733(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 1704, 1733);
return 0;
}


Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
f_797_1833_1871()
{
var return_v = new Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 1833, 1871);
return return_v;
}


int
f_797_1890_1905(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 1890, 1905);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(797,1603,1974);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,1603,1974);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public MarshalPseudoCustomAttributeData MarshallingInformation
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(797,2221,2345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,2257,2286);

f_797_2257_2285(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,2304,2330);

return _lazyMarshalAsData;
DynAbs.Tracing.TraceSender.TraceExitMethod(797,2221,2345);

int
f_797_2257_2285(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 2257, 2285);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(797,2134,2356);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,2134,2356);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _hasIDispatchConstantAttribute;

public bool HasIDispatchConstantAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(797,2552,2688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,2588,2617);

f_797_2588_2616(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,2635,2673);

return _hasIDispatchConstantAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(797,2552,2688);

int
f_797_2588_2616(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 2588, 2616);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(797,2486,2885);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,2486,2885);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(797,2702,2874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,2738,2768);

f_797_2738_2767(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,2786,2825);

_hasIDispatchConstantAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,2843,2859);

f_797_2843_2858(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(797,2702,2874);

int
f_797_2738_2767(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 2738, 2767);
return 0;
}


int
f_797_2843_2858(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 2843, 2858);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(797,2486,2885);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,2486,2885);
}
		}}

private bool _hasIUnknownConstantAttribute;

public bool HasIUnknownConstantAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(797,3078,3213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,3114,3143);

f_797_3114_3142(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,3161,3198);

return _hasIUnknownConstantAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(797,3078,3213);

int
f_797_3114_3142(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 3114, 3142);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(797,3013,3409);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,3013,3409);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(797,3227,3398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,3263,3293);

f_797_3263_3292(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,3311,3349);

_hasIUnknownConstantAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,3367,3383);

f_797_3367_3382(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(797,3227,3398);

int
f_797_3263_3292(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 3263, 3292);
return 0;
}


int
f_797_3367_3382(Microsoft.CodeAnalysis.CommonParameterWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(797, 3367, 3382);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(797,3013,3409);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,3013,3409);
}
		}}

public CommonParameterWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(797,461,3436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,625,641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1083,1098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,1572,1590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,2445,2475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(797,2973,3002);
DynAbs.Tracing.TraceSender.TraceExitConstructor(797,461,3436);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,461,3436);
}


static CommonParameterWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(797,461,3436);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(797,461,3436);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(797,461,3436);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(797,461,3436);
}
}
