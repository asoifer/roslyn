// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Roslyn.Test.Utilities
{
public sealed class EqualityUtil<T>
{
private readonly ReadOnlyCollection<EqualityUnit<T>> _equalityUnits;

private readonly Func<T, T, bool> _compareWithEqualityOperator;

private readonly Func<T, T, bool> _compareWithInequalityOperator;

public EqualityUtil(
            IEnumerable<EqualityUnit<T>> equalityUnits,
            Func<T, T, bool> compEquality = null,
            Func<T, T, bool> compInequality = null)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25051,883,1273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25051,708,722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25051,767,795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25051,840,870);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25051,1089,1142);

_equalityUnits = f_25051_1106_1141(f_25051_1106_1128(equalityUnits));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25051,1156,1200);

_compareWithEqualityOperator = compEquality;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25051,1214,1262);

_compareWithInequalityOperator = compInequality;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25051,883,1273);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25051,883,1273);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25051,883,1273);
}
		}

        public void RunAll(bool checkIEquatable = true)
        {
            if (_compareWithEqualityOperator != null)
            {
                EqualityOperator1();
                EqualityOperator2();
            }

            if (_compareWithInequalityOperator != null)
            {
                InequalityOperator1();
                InequalityOperator2();
            }

            if (checkIEquatable)
            {
                ImplementsIEquatable();
            }

            ObjectEquals1();
            ObjectEquals2();
            ObjectEquals3();
            GetHashCode1();

            if (checkIEquatable)
            {
                EquatableEquals1();
                EquatableEquals2();
            }
        }

        private void EqualityOperator1()
        {
            foreach (var unit in _equalityUnits)
            {
                foreach (var value in unit.EqualValues)
                {
                    Assert.True(_compareWithEqualityOperator(unit.Value, value));
                    Assert.True(_compareWithEqualityOperator(value, unit.Value));
                }

                foreach (var value in unit.NotEqualValues)
                {
                    Assert.False(_compareWithEqualityOperator(unit.Value, value));
                    Assert.False(_compareWithEqualityOperator(value, unit.Value));
                }
            }
        }

        private void EqualityOperator2()
        {
            if (typeof(T).GetTypeInfo().IsValueType)
            {
                return;
            }

            foreach (var value in _equalityUnits.SelectMany(x => x.AllValues))
            {
                Assert.False(_compareWithEqualityOperator(default(T), value));
                Assert.False(_compareWithEqualityOperator(value, default(T)));
            }
        }

        private void InequalityOperator1()
        {
            foreach (var unit in _equalityUnits)
            {
                foreach (var value in unit.EqualValues)
                {
                    Assert.False(_compareWithInequalityOperator(unit.Value, value));
                    Assert.False(_compareWithInequalityOperator(value, unit.Value));
                }

                foreach (var value in unit.NotEqualValues)
                {
                    Assert.True(_compareWithInequalityOperator(unit.Value, value));
                    Assert.True(_compareWithInequalityOperator(value, unit.Value));
                }
            }
        }

        private void InequalityOperator2()
        {
            if (typeof(T).GetTypeInfo().IsValueType)
            {
                return;
            }

            foreach (var value in _equalityUnits.SelectMany(x => x.AllValues))
            {
                Assert.True(_compareWithInequalityOperator(default(T), value));
                Assert.True(_compareWithInequalityOperator(value, default(T)));
            }
        }

private void ImplementsIEquatable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25051,4322,4556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25051,4382,4403);

var 
type = typeof(T)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25051,4417,4456);

var 
targetType = typeof(IEquatable<T>)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25051,4470,4545);

f_25051_4470_4544(f_25051_4482_4543(f_25051_4482_4522(f_25051_4482_4500(type)), targetType));
DynAbs.Tracing.TraceSender.TraceExitMethod(25051,4322,4556);

System.Reflection.TypeInfo
f_25051_4482_4500(System.Type
type)
{
var return_v = type.GetTypeInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25051, 4482, 4500);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Type>
f_25051_4482_4522(System.Reflection.TypeInfo
this_param)
{
var return_v = this_param.ImplementedInterfaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25051, 4482, 4522);
return return_v;
}


bool
f_25051_4482_4543(System.Collections.Generic.IEnumerable<System.Type>
source,System.Type
value)
{
var return_v = source.Contains<System.Type>( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25051, 4482, 4543);
return return_v;
}


int
f_25051_4470_4544(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25051, 4470, 4544);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25051,4322,4556);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25051,4322,4556);
}
		}

        private void ObjectEquals1()
        {
            foreach (var unit in _equalityUnits)
            {
                var unitValue = unit.Value;
                foreach (var value in unit.EqualValues)
                {
                    Assert.True(value.Equals(unitValue));
                    Assert.True(unitValue.Equals(value));
                }
            }
        }

        /// <summary>
        /// Comparison with Null should be false for reference types
        /// </summary>
        private void ObjectEquals2()
        {
            if (typeof(T).GetTypeInfo().IsValueType)
            {
                return;
            }

            var allValues = _equalityUnits.SelectMany(x => x.AllValues);
            foreach (var value in allValues)
            {
                Assert.NotNull(value);
            }
        }

        /// <summary>
        /// Passing a value of a different type should just return false
        /// </summary>
        private void ObjectEquals3()
        {
            var allValues = _equalityUnits.SelectMany(x => x.AllValues);
            foreach (var value in allValues)
            {
                Assert.False(value.Equals((object)42));
            }
        }

        private void GetHashCode1()
        {
            foreach (var unit in _equalityUnits)
            {
                foreach (var value in unit.EqualValues)
                {
                    Assert.Equal(value.GetHashCode(), unit.Value.GetHashCode());
                }
            }
        }

        private void EquatableEquals1()
        {
            foreach (var unit in _equalityUnits)
            {
                var equatableUnit = (IEquatable<T>)unit.Value;
                foreach (var value in unit.EqualValues)
                {
                    Assert.True(equatableUnit.Equals(value));
                    var equatableValue = (IEquatable<T>)value;
                    Assert.True(equatableValue.Equals(unit.Value));
                }

                foreach (var value in unit.NotEqualValues)
                {
                    Assert.False(equatableUnit.Equals(value));
                    var equatableValue = (IEquatable<T>)value;
                    Assert.False(equatableValue.Equals(unit.Value));
                }
            }
        }

        /// <summary>
        /// If T is a reference type, null should return false in all cases
        /// </summary>
        private void EquatableEquals2()
        {
            if (typeof(T).GetTypeInfo().IsValueType)
            {
                return;
            }

            foreach (var cur in _equalityUnits.SelectMany(x => x.AllValues))
            {
                var value = (IEquatable<T>)cur;
                Assert.NotNull(value);
            }
        }

static EqualityUtil()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25051,603,7446);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25051,603,7446);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25051,603,7446);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25051,603,7446);

static System.Collections.Generic.List<Roslyn.Test.Utilities.EqualityUnit<T>>
f_25051_1106_1128(System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.EqualityUnit<T>>
source)
{
var return_v = source.ToList<Roslyn.Test.Utilities.EqualityUnit<T>>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25051, 1106, 1128);
return return_v;
}


static System.Collections.ObjectModel.ReadOnlyCollection<Roslyn.Test.Utilities.EqualityUnit<T>>
f_25051_1106_1141(System.Collections.Generic.List<Roslyn.Test.Utilities.EqualityUnit<T>>
this_param)
{
var return_v = this_param.AsReadOnly();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25051, 1106, 1141);
return return_v;
}

}
}
