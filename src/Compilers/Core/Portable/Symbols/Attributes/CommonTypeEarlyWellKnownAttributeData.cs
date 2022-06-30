// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
internal class CommonTypeEarlyWellKnownAttributeData : EarlyWellKnownAttributeData
{
private AttributeUsageInfo _attributeUsageInfo ;

public AttributeUsageInfo AttributeUsageInfo
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(801,890,968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,926,953);

return _attributeUsageInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(801,890,968);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(801,821,1259);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,821,1259);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(801,982,1248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1018,1048);

f_801_1018_1047(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1066,1107);

f_801_1066_1106(_attributeUsageInfo.IsNull);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1125,1153);

f_801_1125_1152(f_801_1138_1151_M(!value.IsNull));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1171,1199);

_attributeUsageInfo = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1217,1233);

f_801_1217_1232(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(801,982,1248);

int
f_801_1018_1047(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 1018, 1047);
return 0;
}


int
f_801_1066_1106(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 1066, 1106);
return 0;
}


bool
f_801_1138_1151_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(801, 1138, 1151);
return return_v;
}


int
f_801_1125_1152(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 1125, 1152);
return 0;
}


int
f_801_1217_1232(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 1217, 1232);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(801,821,1259);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,821,1259);
}
		}}

private bool _hasComImportAttribute;

public bool HasComImportAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(801,1431,1559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1467,1496);

f_801_1467_1495(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1514,1544);

return _hasComImportAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(801,1431,1559);

int
f_801_1467_1495(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 1467, 1495);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(801,1373,1748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,1373,1748);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(801,1573,1737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1609,1639);

f_801_1609_1638(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1657,1688);

_hasComImportAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1706,1722);

f_801_1706_1721(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(801,1573,1737);

int
f_801_1609_1638(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 1609, 1638);
return 0;
}


int
f_801_1706_1721(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 1706, 1721);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(801,1373,1748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,1373,1748);
}
		}}

private ImmutableArray<string> _lazyConditionalSymbols ;

public void AddConditionalSymbol(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(801,1916,2131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1986,2016);

f_801_1986_2015(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,2030,2090);

_lazyConditionalSymbols = _lazyConditionalSymbols.Add(name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,2104,2120);

f_801_2104_2119(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(801,1916,2131);

int
f_801_1986_2015(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 1986, 2015);
return 0;
}


int
f_801_2104_2119(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 2104, 2119);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(801,1916,2131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,1916,2131);
}
		}

public ImmutableArray<string> ConditionalSymbols
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(801,2216,2345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,2252,2281);

f_801_2252_2280(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,2299,2330);

return _lazyConditionalSymbols;
DynAbs.Tracing.TraceSender.TraceExitMethod(801,2216,2345);

int
f_801_2252_2280(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 2252, 2280);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(801,2143,2356);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,2143,2356);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private ObsoleteAttributeData _obsoleteAttributeData ;

public ObsoleteAttributeData ObsoleteAttributeData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(801,2599,2775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,2635,2664);

f_801_2635_2663(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,2682,2760);

return (DynAbs.Tracing.TraceSender.Conditional_F1(801, 2689, 2727)||((f_801_2689_2727(_obsoleteAttributeData)&&DynAbs.Tracing.TraceSender.Conditional_F2(801, 2730, 2734))||DynAbs.Tracing.TraceSender.Conditional_F3(801, 2737, 2759)))?null :_obsoleteAttributeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(801,2599,2775);

int
f_801_2635_2663(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 2635, 2663);
return 0;
}


bool
f_801_2689_2727(Microsoft.CodeAnalysis.ObsoleteAttributeData
this_param)
{
var return_v = this_param.IsUninitialized ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(801, 2689, 2727);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(801,2524,3067);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,2524,3067);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(801,2789,3056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,2825,2855);

f_801_2825_2854(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,2873,2901);

f_801_2873_2900(value != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,2919,2956);

f_801_2919_2955(f_801_2932_2954_M(!value.IsUninitialized));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,2976,3007);

_obsoleteAttributeData = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,3025,3041);

f_801_3025_3040(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(801,2789,3056);

int
f_801_2825_2854(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 2825, 2854);
return 0;
}


int
f_801_2873_2900(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 2873, 2900);
return 0;
}


bool
f_801_2932_2954_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(801, 2932, 2954);
return return_v;
}


int
f_801_2919_2955(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 2919, 2955);
return 0;
}


int
f_801_3025_3040(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 3025, 3040);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(801,2524,3067);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,2524,3067);
}
		}}

private bool _hasCodeAnalysisEmbeddedAttribute;

public bool HasCodeAnalysisEmbeddedAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(801,3272,3411);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,3308,3337);

f_801_3308_3336(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,3355,3396);

return _hasCodeAnalysisEmbeddedAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(801,3272,3411);

int
f_801_3308_3336(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 3308, 3336);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(801,3203,3611);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,3203,3611);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(801,3425,3600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,3461,3491);

f_801_3461_3490(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,3509,3551);

_hasCodeAnalysisEmbeddedAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,3569,3585);

f_801_3569_3584(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(801,3425,3600);

int
f_801_3461_3490(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 3461, 3490);
return 0;
}


int
f_801_3569_3584(Microsoft.CodeAnalysis.CommonTypeEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(801, 3569, 3584);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(801,3203,3611);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,3203,3611);
}
		}}

public CommonTypeEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(801,598,3638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,765,810);
this._attributeUsageInfo = AttributeUsageInfo.Null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1340,1362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,1849,1903);
this._lazyConditionalSymbols = ImmutableArray<string>.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,2453,2513);
this._obsoleteAttributeData = ObsoleteAttributeData.Uninitialized;DynAbs.Tracing.TraceSender.TraceSimpleStatement(801,3159,3192);
DynAbs.Tracing.TraceSender.TraceExitConstructor(801,598,3638);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,598,3638);
}


static CommonTypeEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(801,598,3638);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(801,598,3638);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(801,598,3638);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(801,598,3638);
}
}
