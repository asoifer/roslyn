// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Roslyn.Test.Utilities
{
public static class EqualityUtil
{
public static void RunAll<T>(
            Func<T, T, bool> compEqualsOperator,
            Func<T, T, bool> compNotEqualsOperator,
            params EqualityUnit<T>[] values)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25050,335,659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25050,538,620);

var 
util = f_25050_549_619(values, compEqualsOperator, compNotEqualsOperator)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25050,634,648);

f_25050_634_647(            util);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25050,335,659);

Roslyn.Test.Utilities.EqualityUtil<T>
f_25050_549_619(Roslyn.Test.Utilities.EqualityUnit<T>[]
equalityUnits,System.Func<T, T, bool>
compEquality,System.Func<T, T, bool>
compInequality)
{
var return_v = new Roslyn.Test.Utilities.EqualityUtil<T>( (System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.EqualityUnit<T>>)equalityUnits, compEquality, compInequality);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25050, 549, 619);
return return_v;
}


int
f_25050_634_647(Roslyn.Test.Utilities.EqualityUtil<T>
this_param)
{
this_param.RunAll();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25050, 634, 647);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25050,335,659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25050,335,659);
}
		}

public static void RunAll<T>(EqualityUnit<T> unit, bool checkIEquatable = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25050,671,826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25050,775,815);

f_25050_775_814(checkIEquatable, new[] { unit });
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25050,671,826);

int
f_25050_775_814(bool
checkIEquatable,params Roslyn.Test.Utilities.EqualityUnit<T>[]
values)
{
RunAll( checkIEquatable, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25050, 775, 814);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25050,671,826);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25050,671,826);
}
		}

public static void RunAll<T>(params EqualityUnit<T>[] values)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25050,838,981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25050,924,970);

f_25050_924_969(checkIEquatable: true, values: values);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25050,838,981);

int
f_25050_924_969(bool
checkIEquatable,params Roslyn.Test.Utilities.EqualityUnit<T>[]
values)
{
RunAll( checkIEquatable: checkIEquatable, values: values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25050, 924, 969);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25050,838,981);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25050,838,981);
}
		}

public static void RunAll<T>(bool checkIEquatable, params EqualityUnit<T>[] values)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25050,993,1194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25050,1101,1140);

var 
util = f_25050_1112_1139(values)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25050,1154,1183);

f_25050_1154_1182(            util, checkIEquatable);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25050,993,1194);

Roslyn.Test.Utilities.EqualityUtil<T>
f_25050_1112_1139(Roslyn.Test.Utilities.EqualityUnit<T>[]
equalityUnits)
{
var return_v = new Roslyn.Test.Utilities.EqualityUtil<T>( (System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.EqualityUnit<T>>)equalityUnits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25050, 1112, 1139);
return return_v;
}


int
f_25050_1154_1182(Roslyn.Test.Utilities.EqualityUtil<T>
this_param,bool
checkIEquatable)
{
this_param.RunAll( checkIEquatable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25050, 1154, 1182);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25050,993,1194);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25050,993,1194);
}
		}

static EqualityUtil()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25050,286,1201);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25050,286,1201);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25050,286,1201);
}

}
}
