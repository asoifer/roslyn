// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
internal class CommonPropertyEarlyWellKnownAttributeData : EarlyWellKnownAttributeData
{
private ObsoleteAttributeData _obsoleteAttributeData ;

public ObsoleteAttributeData ObsoleteAttributeData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(798,780,956);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(798,816,845);

f_798_816_844(this, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(798,863,941);

return (DynAbs.Tracing.TraceSender.Conditional_F1(798, 870, 908)||((f_798_870_908(_obsoleteAttributeData)&&DynAbs.Tracing.TraceSender.Conditional_F2(798, 911, 915))||DynAbs.Tracing.TraceSender.Conditional_F3(798, 918, 940)))?null :_obsoleteAttributeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(798,780,956);

int
f_798_816_844(Microsoft.CodeAnalysis.CommonPropertyEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(798, 816, 844);
return 0;
}


bool
f_798_870_908(Microsoft.CodeAnalysis.ObsoleteAttributeData
this_param)
{
var return_v = this_param.IsUninitialized ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(798, 870, 908);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(798,705,1248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(798,705,1248);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(798,970,1237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(798,1006,1036);

f_798_1006_1035(this, expected: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(798,1054,1082);

f_798_1054_1081(value != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(798,1100,1137);

f_798_1100_1136(f_798_1113_1135_M(!value.IsUninitialized));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(798,1157,1188);

_obsoleteAttributeData = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(798,1206,1222);

f_798_1206_1221(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(798,970,1237);

int
f_798_1006_1035(Microsoft.CodeAnalysis.CommonPropertyEarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifySealed( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(798, 1006, 1035);
return 0;
}


int
f_798_1054_1081(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(798, 1054, 1081);
return 0;
}


bool
f_798_1113_1135_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(798, 1113, 1135);
return return_v;
}


int
f_798_1100_1136(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(798, 1100, 1136);
return 0;
}


int
f_798_1206_1221(Microsoft.CodeAnalysis.CommonPropertyEarlyWellKnownAttributeData
this_param)
{
this_param.SetDataStored();
DynAbs.Tracing.TraceSender.TraceEndInvocation(798, 1206, 1221);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(798,705,1248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(798,705,1248);
}
		}}

public CommonPropertyEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(798,466,1275);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(798,634,694);
this._obsoleteAttributeData = ObsoleteAttributeData.Uninitialized;DynAbs.Tracing.TraceSender.TraceExitConstructor(798,466,1275);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(798,466,1275);
}


static CommonPropertyEarlyWellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(798,466,1275);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(798,466,1275);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(798,466,1275);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(798,466,1275);
}
}
