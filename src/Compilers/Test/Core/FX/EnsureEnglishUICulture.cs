// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Roslyn.Test.Utilities
{
public class EnsureEnglishUICulture : IDisposable
{
public static CultureInfo PreferredOrNull
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25089,499,871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,535,596);

var 
currentUICultureName = f_25089_562_595(f_25089_562_590())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,614,800) || true) && (f_25089_618_645(currentUICultureName)== 0 ||(DynAbs.Tracing.TraceSender.Expression_False(25089, 618, 727)||f_25089_654_727(currentUICultureName, "en", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25089,614,800);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,769,781);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(25089,614,800);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,820,856);

return f_25089_827_855();
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25089,499,871);

System.Globalization.CultureInfo
f_25089_562_590()
{
var return_v = CultureInfo.CurrentUICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 562, 590);
return return_v;
}


string
f_25089_562_595(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 562, 595);
return return_v;
}


int
f_25089_618_645(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 618, 645);
return return_v;
}


bool
f_25089_654_727(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25089, 654, 727);
return return_v;
}


System.Globalization.CultureInfo
f_25089_827_855()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 827, 855);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25089,433,882);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25089,433,882);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _needToRestore;

private readonly CultureInfo _threadUICulture;

private readonly int _threadId;

public EnsureEnglishUICulture()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25089,1031,1428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,907,921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,961,977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,1009,1018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,1087,1136);

_threadId = f_25089_1099_1135(f_25089_1099_1119());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,1150,1182);

var 
preferred = f_25089_1166_1181()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,1198,1417) || true) && (preferred != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25089,1198,1417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,1253,1301);

_threadUICulture = f_25089_1272_1300();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,1319,1341);

_needToRestore = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,1361,1402);

CultureInfo.CurrentUICulture = preferred;
DynAbs.Tracing.TraceSender.TraceExitCondition(25089,1198,1417);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(25089,1031,1428);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25089,1031,1428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25089,1031,1428);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25089,1440,1786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,1486,1550);

f_25089_1486_1549(_threadId == f_25089_1512_1548(f_25089_1512_1532()));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,1566,1775) || true) && (_needToRestore &&(DynAbs.Tracing.TraceSender.Expression_True(25089, 1570, 1637)&&_threadId == f_25089_1601_1637(f_25089_1601_1621())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25089,1566,1775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,1671,1694);

_needToRestore = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25089,1712,1760);

CultureInfo.CurrentUICulture = _threadUICulture;
DynAbs.Tracing.TraceSender.TraceExitCondition(25089,1566,1775);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25089,1440,1786);

System.Threading.Thread
f_25089_1512_1532()
{
var return_v = Thread.CurrentThread;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 1512, 1532);
return return_v;
}


int
f_25089_1512_1548(System.Threading.Thread
this_param)
{
var return_v = this_param.ManagedThreadId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 1512, 1548);
return return_v;
}


int
f_25089_1486_1549(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25089, 1486, 1549);
return 0;
}


System.Threading.Thread
f_25089_1601_1621()
{
var return_v = Thread.CurrentThread;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 1601, 1621);
return return_v;
}


int
f_25089_1601_1637(System.Threading.Thread
this_param)
{
var return_v = this_param.ManagedThreadId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 1601, 1637);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25089,1440,1786);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25089,1440,1786);
}
		}

static EnsureEnglishUICulture()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25089,367,1793);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25089,367,1793);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25089,367,1793);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25089,367,1793);

static System.Threading.Thread
f_25089_1099_1119()
{
var return_v = Thread.CurrentThread;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 1099, 1119);
return return_v;
}


static int
f_25089_1099_1135(System.Threading.Thread
this_param)
{
var return_v = this_param.ManagedThreadId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 1099, 1135);
return return_v;
}


static System.Globalization.CultureInfo
f_25089_1166_1181()
{
var return_v = PreferredOrNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 1166, 1181);
return return_v;
}


static System.Globalization.CultureInfo
f_25089_1272_1300()
{
var return_v = CultureInfo.CurrentUICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25089, 1272, 1300);
return return_v;
}

}
}
