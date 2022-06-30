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
internal class CommonFieldEarlyWellKnownAttributeData : EarlyWellKnownAttributeData
{
private ObsoleteAttributeData _obsoleteAttributeData ;

public ObsoleteAttributeData ObsoleteAttributeData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(791,873,1049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(791,909,938);

f_791_909_937(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(791,956,1034);

return (DynAbs.Tracing.TraceSender.Conditional_F1(791, 963, 1001)||((f_791_963_1001(_obsoleteAttributeData)&&DynAbs.Tracing.TraceSender.Conditional_F2(791, 1004, 1008))||DynAbs.Tracing.TraceSender.Conditional_F3(791, 1011, 1033)))?null :_obsoleteAttributeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(791,873,1049);

int
f_791_909_937(Microsoft.CodeAnalysis.CommonFieldEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(791, 909, 937);
return 0;
}


bool
f_791_963_1001(Microsoft.CodeAnalysis.ObsoleteAttributeData
this_param)
{
var return_v = this_param.IsUninitialized ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(791, 963, 1001);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(791,798,1341);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(791,798,1341);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(791,1063,1330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(791,1099,1129);

f_791_1099_1128(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(791,1147,1175);

f_791_1147_1174(value != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(791,1193,1230);

f_791_1193_1229(f_791_1206_1228_M(!value.IsUninitialized));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(791,1250,1281);

_obsoleteAttributeData = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(791,1299,1315);

f_791_1299_1314(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(791,1063,1330);

int
f_791_1099_1128(Microsoft.CodeAnalysis.CommonFieldEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(791, 1099, 1128);
return 0;
}


int
f_791_1147_1174(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(791, 1147, 1174);
return 0;
}


bool
f_791_1206_1228_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(791, 1206, 1228);
return return_v;
}


int
f_791_1193_1229(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(791, 1193, 1229);
return 0;
}


int
f_791_1299_1314(Microsoft.CodeAnalysis.CommonFieldEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(791, 1299, 1314);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(791,798,1341);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(791,798,1341);
}
		}}

public CommonFieldEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(791,562,1368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(791,727,787);
this._obsoleteAttributeData = ObsoleteAttributeData.Uninitialized;DynAbs.Tracing.TraceSender.TraceExitConstructor(791,562,1368);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(791,562,1368);
}


static CommonFieldEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(791,562,1368);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(791,562,1368);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(791,562,1368);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(791,562,1368);
}
}
