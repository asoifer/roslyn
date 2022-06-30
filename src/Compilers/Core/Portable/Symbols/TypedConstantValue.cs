// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{

    internal struct TypedConstantValue : IEquatable<TypedConstantValue>
    {

        private readonly object? _value;

        internal TypedConstantValue(object? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(649, 804, 1128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(649, 871, 1088);

                f_649_871_1087(value == null || (DynAbs.Tracing.TraceSender.Expression_False(649, 884, 916) || value is string) || (DynAbs.Tracing.TraceSender.Expression_False(649, 884, 956) || f_649_920_956(f_649_920_949(f_649_920_935(value)))) || (DynAbs.Tracing.TraceSender.Expression_False(649, 884, 1062) || (f_649_961_1002(f_649_961_990(f_649_961_976(value))) && (DynAbs.Tracing.TraceSender.Expression_True(649, 961, 1031) && !(value is System.IntPtr)) && (DynAbs.Tracing.TraceSender.Expression_True(649, 961, 1061) && !(value is System.UIntPtr)))) || (DynAbs.Tracing.TraceSender.Expression_False(649, 884, 1086) || value is ITypeSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(649, 1102, 1117);

                _value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(649, 804, 1128);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(649, 804, 1128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(649, 804, 1128);
            }
        }

        internal TypedConstantValue(ImmutableArray<TypedConstant> array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(649, 1140, 1288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(649, 1229, 1277);

                _value = (DynAbs.Tracing.TraceSender.Conditional_F1(649, 1238, 1253) || ((array.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(649, 1256, 1260)) || DynAbs.Tracing.TraceSender.Conditional_F3(649, 1263, 1276))) ? null : (object)array;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(649, 1140, 1288);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(649, 1140, 1288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(649, 1140, 1288);
            }
        }

        public bool IsNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(649, 1451, 1524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(649, 1487, 1509);

                    return _value == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(649, 1451, 1524);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(649, 1408, 1535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(649, 1408, 1535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<TypedConstant> Array
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(649, 1614, 1768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(649, 1650, 1753);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(649, 1657, 1671) || ((_value == null && DynAbs.Tracing.TraceSender.Conditional_F2(649, 1674, 1712)) || DynAbs.Tracing.TraceSender.Conditional_F3(649, 1715, 1752))) ? default(ImmutableArray<TypedConstant>) : (ImmutableArray<TypedConstant>)_value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(649, 1614, 1768);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(649, 1547, 1779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(649, 1547, 1779);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public object? Object
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(649, 1837, 1977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(649, 1873, 1930);

                    f_649_1873_1929(!(_value is ImmutableArray<TypedConstant>));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(649, 1948, 1962);

                    return _value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(649, 1837, 1977);

                    int
                    f_649_1873_1929(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(649, 1873, 1929);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(649, 1791, 1988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(649, 1791, 1988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(649, 2000, 2103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(649, 2058, 2092);

                return f_649_2065_2086_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_value, 649, 2065, 2086)?.GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(649, 2065, 2091) ?? 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(649, 2000, 2103);

                int?
                f_649_2065_2086_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(649, 2065, 2086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(649, 2000, 2103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(649, 2000, 2103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(649, 2115, 2259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(649, 2180, 2248);

                return obj is TypedConstantValue && (DynAbs.Tracing.TraceSender.Expression_True(649, 2187, 2247) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(649, 2115, 2259);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(649, 2115, 2259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(649, 2115, 2259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(TypedConstantValue other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(649, 2271, 2394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(649, 2340, 2383);

                return f_649_2347_2382(_value, other._value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(649, 2271, 2394);

                bool
                f_649_2347_2382(object?
                objA, object?
                objB)
                {
                    var return_v = object.Equals(objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(649, 2347, 2382);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(649, 2271, 2394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(649, 2271, 2394);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static TypedConstantValue()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(649, 558, 2401);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(649, 558, 2401);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(649, 558, 2401);
        }

        static System.Type
        f_649_920_935(object
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(649, 920, 935);
            return return_v;
        }


        static System.Reflection.TypeInfo
        f_649_920_949(System.Type
        type)
        {
            var return_v = type.GetTypeInfo();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(649, 920, 949);
            return return_v;
        }


        static bool
        f_649_920_956(System.Reflection.TypeInfo
        this_param)
        {
            var return_v = this_param.IsEnum;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(649, 920, 956);
            return return_v;
        }


        static System.Type
        f_649_961_976(object
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(649, 961, 976);
            return return_v;
        }


        static System.Reflection.TypeInfo
        f_649_961_990(System.Type
        type)
        {
            var return_v = type.GetTypeInfo();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(649, 961, 990);
            return return_v;
        }


        static bool
        f_649_961_1002(System.Reflection.TypeInfo
        this_param)
        {
            var return_v = this_param.IsPrimitive;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(649, 961, 1002);
            return return_v;
        }


        static int
        f_649_871_1087(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(649, 871, 1087);
            return 0;
        }

    }
}
