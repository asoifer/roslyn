// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis
{
internal class CommonEventWellKnownAttributeData : WellKnownAttributeData, ISkipLocalsInitAttributeTarget
{
private bool _hasSpecialNameAttribute;

public bool HasSpecialNameAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(790,623,753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,659,688);

f_790_659_687(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,706,738);

return _hasSpecialNameAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(790,623,753);

int
f_790_659_687(Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(790, 659, 687);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(790,563,944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(790,563,944);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(790,767,933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,803,833);

f_790_803_832(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,851,884);

_hasSpecialNameAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,902,918);

f_790_902_917(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(790,767,933);

int
f_790_803_832(Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(790, 803, 832);
return 0;
}


int
f_790_902_917(Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(790, 902, 917);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(790,563,944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(790,563,944);
}
		}}

private bool _hasExcludeFromCodeCoverageAttribute;

public bool HasExcludeFromCodeCoverageAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(790,1088,1230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,1124,1153);

f_790_1124_1152(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,1171,1215);

return _hasExcludeFromCodeCoverageAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(790,1088,1230);

int
f_790_1124_1152(Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(790, 1124, 1152);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(790,1016,1433);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(790,1016,1433);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(790,1244,1422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,1280,1310);

f_790_1280_1309(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,1328,1373);

_hasExcludeFromCodeCoverageAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,1391,1407);

f_790_1391_1406(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(790,1244,1422);

int
f_790_1280_1309(Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(790, 1280, 1309);
return 0;
}


int
f_790_1391_1406(Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(790, 1391, 1406);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(790,1016,1433);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(790,1016,1433);
}
		}}

private bool _hasSkipLocalsInitAttribute;

public bool HasSkipLocalsInitAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(790,1559,1692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,1595,1624);

f_790_1595_1623(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,1642,1677);

return _hasSkipLocalsInitAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(790,1559,1692);

int
f_790_1595_1623(Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(790, 1595, 1623);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(790,1496,1886);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(790,1496,1886);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(790,1706,1875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,1742,1772);

f_790_1742_1771(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,1790,1826);

_hasSkipLocalsInitAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,1844,1860);

f_790_1844_1859(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(790,1706,1875);

int
f_790_1742_1771(Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(790, 1742, 1771);
return 0;
}


int
f_790_1844_1859(Microsoft.CodeAnalysis.CommonEventWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(790, 1844, 1859);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(790,1496,1886);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(790,1496,1886);
}
		}}

public CommonEventWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(790,393,1893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,528,552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,969,1005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(790,1458,1485);
DynAbs.Tracing.TraceSender.TraceExitConstructor(790,393,1893);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(790,393,1893);
}


static CommonEventWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(790,393,1893);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(790,393,1893);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(790,393,1893);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(790,393,1893);
}
}
