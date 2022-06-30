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
internal class CommonEventEarlyWellKnownAttributeData : EarlyWellKnownAttributeData
{
private ObsoleteAttributeData _obsoleteAttributeData ;

public ObsoleteAttributeData ObsoleteAttributeData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(789,874,1050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(789,910,939);

f_789_910_938(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(789,957,1035);

return (DynAbs.Tracing.TraceSender.Conditional_F1(789, 964, 1002)||((f_789_964_1002(_obsoleteAttributeData)&&DynAbs.Tracing.TraceSender.Conditional_F2(789, 1005, 1009))||DynAbs.Tracing.TraceSender.Conditional_F3(789, 1012, 1034)))?null :_obsoleteAttributeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(789,874,1050);

int
f_789_910_938(Microsoft.CodeAnalysis.CommonEventEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(789, 910, 938);
return 0;
}


bool
f_789_964_1002(Microsoft.CodeAnalysis.ObsoleteAttributeData
this_param)
{
var return_v = this_param.IsUninitialized ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(789, 964, 1002);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(789,799,1342);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(789,799,1342);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(789,1064,1331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(789,1100,1130);

f_789_1100_1129(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(789,1148,1176);

f_789_1148_1175(value != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(789,1194,1231);

f_789_1194_1230(f_789_1207_1229_M(!value.IsUninitialized));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(789,1251,1282);

_obsoleteAttributeData = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(789,1300,1316);

f_789_1300_1315(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(789,1064,1331);

int
f_789_1100_1129(Microsoft.CodeAnalysis.CommonEventEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(789, 1100, 1129);
return 0;
}


int
f_789_1148_1175(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(789, 1148, 1175);
return 0;
}


bool
f_789_1207_1229_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(789, 1207, 1229);
return return_v;
}


int
f_789_1194_1230(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(789, 1194, 1230);
return 0;
}


int
f_789_1300_1315(Microsoft.CodeAnalysis.CommonEventEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(789, 1300, 1315);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(789,799,1342);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(789,799,1342);
}
		}}

public CommonEventEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(789,563,1369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(789,728,788);
this._obsoleteAttributeData = ObsoleteAttributeData.Uninitialized;DynAbs.Tracing.TraceSender.TraceExitConstructor(789,563,1369);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(789,563,1369);
}


static CommonEventEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(789,563,1369);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(789,563,1369);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(789,563,1369);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(789,563,1369);
}
}
