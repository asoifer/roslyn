// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Roslyn.Test.Utilities
{
public sealed class EqualityUnit<T>
{
private static readonly ReadOnlyCollection<T> s_emptyCollection ;

public readonly T Value;

public readonly ReadOnlyCollection<T> EqualValues;

public readonly ReadOnlyCollection<T> NotEqualValues;

public IEnumerable<T> AllValues
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(25049,747,833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,753,831);

return f_25049_760_830(f_25049_760_807(f_25049_760_787(Value, 1), EqualValues), NotEqualValues);
DynAbs.Tracing.TraceSender.TraceExitMethod(25049,747,833);

System.Collections.Generic.IEnumerable<T>
f_25049_760_787(T
element,int
count)
{
var return_v = Enumerable.Repeat( element, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25049, 760, 787);
return return_v;
}


System.Collections.Generic.IEnumerable<T>
f_25049_760_807(System.Collections.Generic.IEnumerable<T>
first,System.Collections.ObjectModel.ReadOnlyCollection<T>
second)
{
var return_v = first.Concat<T>( (System.Collections.Generic.IEnumerable<T>)second);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25049, 760, 807);
return return_v;
}


System.Collections.Generic.IEnumerable<T>
f_25049_760_830(System.Collections.Generic.IEnumerable<T>
first,System.Collections.ObjectModel.ReadOnlyCollection<T>
second)
{
var return_v = first.Concat<T>( (System.Collections.Generic.IEnumerable<T>)second);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25049, 760, 830);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25049,691,844);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25049,691,844);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public EqualityUnit(T value)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25049,856,1029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,552,557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,606,617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,666,680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,909,923);

Value = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,937,969);

EqualValues = s_emptyCollection;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,983,1018);

NotEqualValues = s_emptyCollection;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25049,856,1029);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25049,856,1029);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25049,856,1029);
}
		}

public EqualityUnit(
            T value,
            ReadOnlyCollection<T> equalValues,
            ReadOnlyCollection<T> notEqualValues)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25049,1041,1318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,552,557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,606,617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,666,680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,1207,1221);

Value = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,1235,1261);

EqualValues = equalValues;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,1275,1307);

NotEqualValues = notEqualValues;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25049,1041,1318);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25049,1041,1318);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25049,1041,1318);
}
		}

        public EqualityUnit<T> WithEqualValues(params T[] equalValues)
        {
            return new EqualityUnit<T>(
                Value,
                EqualValues.Concat(equalValues).ToList().AsReadOnly(),
                NotEqualValues);
        }

        public EqualityUnit<T> WithNotEqualValues(params T[] notEqualValues)
        {
            return new EqualityUnit<T>(
                Value,
                EqualValues,
                NotEqualValues.Concat(notEqualValues).ToList().AsReadOnly());
        }

static EqualityUnit()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25049,365,1868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25049,463,521);
s_emptyCollection = f_25049_483_521<T>(new T[] { });DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25049,365,1868);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25049,365,1868);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25049,365,1868);

static System.Collections.ObjectModel.ReadOnlyCollection<T>
f_25049_483_521<T>(T[]
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<T>( (System.Collections.Generic.IList<T>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25049, 483, 521);
return return_v;
}

}
}
