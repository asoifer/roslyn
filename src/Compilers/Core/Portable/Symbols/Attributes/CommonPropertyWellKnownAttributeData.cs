// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
internal class CommonPropertyWellKnownAttributeData : WellKnownAttributeData
{
private bool _hasSpecialNameAttribute;

public bool HasSpecialNameAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(799,699,829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,735,764);

f_799_735_763(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,782,814);

return _hasSpecialNameAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(799,699,829);

int
f_799_735_763(Microsoft.CodeAnalysis.CommonPropertyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(799, 735, 763);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(799,639,1020);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(799,639,1020);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(799,843,1009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,879,909);

f_799_879_908(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,927,960);

_hasSpecialNameAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,978,994);

f_799_978_993(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(799,843,1009);

int
f_799_879_908(Microsoft.CodeAnalysis.CommonPropertyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(799, 879, 908);
return 0;
}


int
f_799_978_993(Microsoft.CodeAnalysis.CommonPropertyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(799, 978, 993);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(799,639,1020);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(799,639,1020);
}
		}}

private bool _hasExcludeFromCodeCoverageAttribute;

public bool HasExcludeFromCodeCoverageAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(799,1236,1378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,1272,1301);

f_799_1272_1300(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,1319,1363);

return _hasExcludeFromCodeCoverageAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(799,1236,1378);

int
f_799_1272_1300(Microsoft.CodeAnalysis.CommonPropertyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(799, 1272, 1300);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(799,1164,1581);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(799,1164,1581);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(799,1392,1570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,1428,1458);

f_799_1428_1457(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,1476,1521);

_hasExcludeFromCodeCoverageAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,1539,1555);

f_799_1539_1554(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(799,1392,1570);

int
f_799_1428_1457(Microsoft.CodeAnalysis.CommonPropertyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(799, 1428, 1457);
return 0;
}


int
f_799_1539_1554(Microsoft.CodeAnalysis.CommonPropertyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(799, 1539, 1554);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(799,1164,1581);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(799,1164,1581);
}
		}}

public CommonPropertyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(799,460,1610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,604,628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(799,1117,1153);
DynAbs.Tracing.TraceSender.TraceExitConstructor(799,460,1610);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(799,460,1610);
}


static CommonPropertyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(799,460,1610);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(799,460,1610);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(799,460,1610);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(799,460,1610);
}
}
