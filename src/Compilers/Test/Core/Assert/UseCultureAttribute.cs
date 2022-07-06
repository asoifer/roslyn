// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using Xunit.Sdk;

namespace Roslyn.Test.Utilities
{
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class UseCultureAttribute : BeforeAfterTestAttribute
{
private readonly Lazy<CultureInfo> _culture;

private readonly Lazy<CultureInfo> _uiCulture;

private CultureInfo _originalCulture;

private CultureInfo _originalUICulture;

public UseCultureAttribute(string culture)
:this(f_25052_1874_1881_C(culture) ,culture)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25052,1811,1913);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25052,1811,1913);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25052,1811,1913);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25052,1811,1913);
}
		}

public UseCultureAttribute(string culture, string uiCulture)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25052,2264,2556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,1171,1179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,1225,1235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,1266,1282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,1313,1331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,2349,2438);

_culture = f_25052_2360_2437(() => new CultureInfo(culture, useUserOverride: false));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,2452,2545);

_uiCulture = f_25052_2465_2544(() => new CultureInfo(uiCulture, useUserOverride: false));
DynAbs.Tracing.TraceSender.TraceExitConstructor(25052,2264,2556);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25052,2264,2556);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25052,2264,2556);
}
		}

public CultureInfo Culture {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25052,2673,2690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,2676,2690);
return f_25052_2676_2690(_culture);DynAbs.Tracing.TraceSender.TraceExitMethod(25052,2673,2690);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25052,2673,2690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25052,2673,2690);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public CultureInfo UICulture {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25052,2813,2832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,2816,2832);
return f_25052_2816_2832(_uiCulture);DynAbs.Tracing.TraceSender.TraceExitMethod(25052,2813,2832);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25052,2813,2832);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25052,2813,2832);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override void Before(MethodInfo methodUnderTest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25052,3168,3597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,3248,3294);

_originalCulture = f_25052_3267_3293();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,3308,3358);

_originalUICulture = f_25052_3329_3357();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,3374,3411);

CultureInfo.CurrentCulture = f_25052_3403_3410();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,3425,3466);

CultureInfo.CurrentUICulture = f_25052_3456_3465();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,3480,3525);

f_25052_3480_3524(f_25052_3480_3506());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,3539,3586);

f_25052_3539_3585(f_25052_3539_3567());
DynAbs.Tracing.TraceSender.TraceExitMethod(25052,3168,3597);

System.Globalization.CultureInfo
f_25052_3267_3293()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25052, 3267, 3293);
return return_v;
}


System.Globalization.CultureInfo
f_25052_3329_3357()
{
var return_v = CultureInfo.CurrentUICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25052, 3329, 3357);
return return_v;
}


System.Globalization.CultureInfo
f_25052_3403_3410()
{
var return_v = Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25052, 3403, 3410);
return return_v;
}


System.Globalization.CultureInfo
f_25052_3456_3465()
{
var return_v = UICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25052, 3456, 3465);
return return_v;
}


System.Globalization.CultureInfo
f_25052_3480_3506()
{
var return_v =             CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25052, 3480, 3506);
return return_v;
}


int
f_25052_3480_3524(System.Globalization.CultureInfo
this_param)
{
this_param.ClearCachedData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25052, 3480, 3524);
return 0;
}


System.Globalization.CultureInfo
f_25052_3539_3567()
{
var return_v =             CultureInfo.CurrentUICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25052, 3539, 3567);
return return_v;
}


int
f_25052_3539_3585(System.Globalization.CultureInfo
this_param)
{
this_param.ClearCachedData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25052, 3539, 3585);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25052,3168,3597);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25052,3168,3597);
}
		}

public override void After(MethodInfo methodUnderTest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25052,3868,4188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,3947,3993);

CultureInfo.CurrentCulture = _originalCulture;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,4007,4057);

CultureInfo.CurrentUICulture = _originalUICulture;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,4071,4116);

f_25052_4071_4115(f_25052_4071_4097());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25052,4130,4177);

f_25052_4130_4176(f_25052_4130_4158());
DynAbs.Tracing.TraceSender.TraceExitMethod(25052,3868,4188);

System.Globalization.CultureInfo
f_25052_4071_4097()
{
var return_v =             CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25052, 4071, 4097);
return return_v;
}


int
f_25052_4071_4115(System.Globalization.CultureInfo
this_param)
{
this_param.ClearCachedData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25052, 4071, 4115);
return 0;
}


System.Globalization.CultureInfo
f_25052_4130_4158()
{
var return_v =             CultureInfo.CurrentUICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25052, 4130, 4158);
return return_v;
}


int
f_25052_4130_4176(System.Globalization.CultureInfo
this_param)
{
this_param.ClearCachedData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25052, 4130, 4176);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25052,3868,4188);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25052,3868,4188);
}
		}

static UseCultureAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25052,947,4195);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25052,947,4195);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25052,947,4195);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25052,947,4195);

static string
f_25052_1874_1881_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25052, 1811, 1913);
return return_v;
}


static System.Lazy<System.Globalization.CultureInfo>
f_25052_2360_2437(System.Func<System.Globalization.CultureInfo>
valueFactory)
{
var return_v = new System.Lazy<System.Globalization.CultureInfo>( valueFactory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25052, 2360, 2437);
return return_v;
}


static System.Lazy<System.Globalization.CultureInfo>
f_25052_2465_2544(System.Func<System.Globalization.CultureInfo>
valueFactory)
{
var return_v = new System.Lazy<System.Globalization.CultureInfo>( valueFactory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25052, 2465, 2544);
return return_v;
}


System.Globalization.CultureInfo
f_25052_2676_2690(System.Lazy<System.Globalization.CultureInfo>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25052, 2676, 2690);
return return_v;
}


System.Globalization.CultureInfo
f_25052_2816_2832(System.Lazy<System.Globalization.CultureInfo>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25052, 2816, 2832);
return return_v;
}

}
}
