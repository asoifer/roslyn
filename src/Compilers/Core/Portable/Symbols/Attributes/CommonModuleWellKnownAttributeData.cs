// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
internal class CommonModuleWellKnownAttributeData : WellKnownAttributeData
{
private bool _hasDebuggableAttribute;

public bool HasDebuggableAttribute
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(795,731,860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,767,796);

f_795_767_795(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,814,845);

return _hasDebuggableAttribute;
DynAbs.Tracing.TraceSender.TraceExitMethod(795,731,860);

int
f_795_767_795(Microsoft.CodeAnalysis.CommonModuleWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(795, 767, 795);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(795,672,1050);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(795,672,1050);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(795,874,1039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,910,940);

f_795_910_939(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,958,990);

_hasDebuggableAttribute = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,1008,1024);

f_795_1008_1023(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(795,874,1039);

int
f_795_910_939(Microsoft.CodeAnalysis.CommonModuleWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(795, 910, 939);
return 0;
}


int
f_795_1008_1023(Microsoft.CodeAnalysis.CommonModuleWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(795, 1008, 1023);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(795,672,1050);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(795,672,1050);
}
		}}

private byte _defaultCharacterSet;

internal CharSet DefaultCharacterSet
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(795,1232,1426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,1268,1297);

f_795_1268_1296(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,1315,1356);

f_795_1315_1355(f_795_1328_1354());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,1374,1411);

return (CharSet)_defaultCharacterSet;
DynAbs.Tracing.TraceSender.TraceExitMethod(795,1232,1426);

int
f_795_1268_1296(Microsoft.CodeAnalysis.CommonModuleWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(795, 1268, 1296);
return 0;
}


bool
f_795_1328_1354()
{
var return_v = HasDefaultCharSetAttribute;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(795, 1328, 1354);
return return_v;
}


int
f_795_1315_1355(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(795, 1315, 1355);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(795,1171,1673);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(795,1171,1673);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(795,1440,1662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,1476,1506);

f_795_1476_1505(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,1524,1560);

f_795_1524_1559(f_795_1537_1558(value));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,1578,1613);

_defaultCharacterSet = (byte)value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,1631,1647);

f_795_1631_1646(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(795,1440,1662);

int
f_795_1476_1505(Microsoft.CodeAnalysis.CommonModuleWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(795, 1476, 1505);
return 0;
}


bool
f_795_1537_1558(System.Runtime.InteropServices.CharSet
value)
{
var return_v = IsValidCharSet( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(795, 1537, 1558);
return return_v;
}


int
f_795_1524_1559(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(795, 1524, 1559);
return 0;
}


int
f_795_1631_1646(Microsoft.CodeAnalysis.CommonModuleWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(795, 1631, 1646);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(795,1171,1673);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(795,1171,1673);
}
		}}

internal bool HasDefaultCharSetAttribute
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(795,1750,1791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,1756,1789);

return _defaultCharacterSet != 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(795,1750,1791);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(795,1685,1802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(795,1685,1802);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal static bool IsValidCharSet(CharSet value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(795,1814,1982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,1889,1971);

return value >= Cci.Constants.CharSet_None &&(DynAbs.Tracing.TraceSender.Expression_True(795, 1896, 1970)&&value <= Cci.Constants.CharSet_Auto);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(795,1814,1982);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(795,1814,1982);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(795,1814,1982);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public CommonModuleWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(795,497,2009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,638,661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(795,1138,1158);
DynAbs.Tracing.TraceSender.TraceExitConstructor(795,497,2009);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(795,497,2009);
}


static CommonModuleWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(795,497,2009);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(795,497,2009);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(795,497,2009);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(795,497,2009);
}
}
