// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
internal abstract class CommonParameterEarlyWellKnownAttributeData : EarlyWellKnownAttributeData
{
private ConstantValue _defaultParameterValue ;

public ConstantValue DefaultParameterValue
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(796,764,845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,800,830);

return _defaultParameterValue;
DynAbs.Tracing.TraceSender.TraceExitMethod(796,764,845);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(796,697,1112);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(796,697,1112);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(796,859,1101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,895,925);

f_796_895_924(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,943,1003);

f_796_943_1002(_defaultParameterValue == f_796_982_1001());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1021,1052);

_defaultParameterValue = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1070,1086);

f_796_1070_1085(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(796,859,1101);

int
f_796_895_924(Microsoft.CodeAnalysis.CommonParameterEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 895, 924);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_796_982_1001()
{
var return_v = ConstantValue.Unset;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(796, 982, 1001);
return return_v;
}


int
f_796_943_1002(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 943, 1002);
return 0;
}


int
f_796_1070_1085(Microsoft.CodeAnalysis.CommonParameterEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 1070, 1085);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(796,697,1112);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(796,697,1112);
}
		}}

private bool _hasCallerLineNumberAttribute;

public bool HasCallerLineNumberAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(796,1300,1435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1336,1365);

f_796_1336_1364(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1383,1420);

return _hasCallerLineNumberAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(796,1300,1435);

int
f_796_1336_1364(Microsoft.CodeAnalysis.CommonParameterEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 1336, 1364);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(796,1235,1631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(796,1235,1631);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(796,1449,1620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1485,1515);

f_796_1485_1514(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1533,1571);

_hasCallerLineNumberAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1589,1605);

f_796_1589_1604(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(796,1449,1620);

int
f_796_1485_1514(Microsoft.CodeAnalysis.CommonParameterEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 1485, 1514);
return 0;
}


int
f_796_1589_1604(Microsoft.CodeAnalysis.CommonParameterEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 1589, 1604);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(796,1235,1631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(796,1235,1631);
}
		}}

private bool _hasCallerFilePathAttribute;

public bool HasCallerFilePathAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(796,1757,1890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1793,1822);

f_796_1793_1821(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1840,1875);

return _hasCallerFilePathAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(796,1757,1890);

int
f_796_1793_1821(Microsoft.CodeAnalysis.CommonParameterEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 1793, 1821);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(796,1694,2084);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(796,1694,2084);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(796,1904,2073);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1940,1970);

f_796_1940_1969(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1988,2024);

_hasCallerFilePathAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,2042,2058);

f_796_2042_2057(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(796,1904,2073);

int
f_796_1940_1969(Microsoft.CodeAnalysis.CommonParameterEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 1940, 1969);
return 0;
}


int
f_796_2042_2057(Microsoft.CodeAnalysis.CommonParameterEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 2042, 2057);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(796,1694,2084);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(796,1694,2084);
}
		}}

private bool _hasCallerMemberNameAttribute;

public bool HasCallerMemberNameAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(796,2214,2349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,2250,2279);

f_796_2250_2278(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,2297,2334);

return _hasCallerMemberNameAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(796,2214,2349);

int
f_796_2250_2278(Microsoft.CodeAnalysis.CommonParameterEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 2250, 2278);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(796,2149,2545);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(796,2149,2545);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(796,2363,2534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,2399,2429);

f_796_2399_2428(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,2447,2485);

_hasCallerMemberNameAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,2503,2519);

f_796_2503_2518(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(796,2363,2534);

int
f_796_2399_2428(Microsoft.CodeAnalysis.CommonParameterEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 2399, 2428);
return 0;
}


int
f_796_2503_2518(Microsoft.CodeAnalysis.CommonParameterEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(796, 2503, 2518);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(796,2149,2545);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(796,2149,2545);
}
		}}

public CommonParameterEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(796,431,2572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,640,684);
this._defaultParameterValue = f_796_665_684();DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1195,1224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,1656,1683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(796,2109,2138);
DynAbs.Tracing.TraceSender.TraceExitConstructor(796,431,2572);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(796,431,2572);
}


static CommonParameterEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(796,431,2572);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(796,431,2572);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(796,431,2572);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(796,431,2572);

Microsoft.CodeAnalysis.ConstantValue
f_796_665_684()
{
var return_v = ConstantValue.Unset;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(796, 665, 684);
return return_v;
}

}
}
