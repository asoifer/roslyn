// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis
{

    [DebuggerDisplay("{Value,nq}")]
    internal struct ArrayElement<T>
    {

        internal T Value;

        public static implicit operator T(ArrayElement<T> element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(92, 432, 547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 515, 536);

                return element.Value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(92, 432, 547);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(92, 432, 547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(92, 432, 547);
            }
        }

        [return: NotNullIfNotNull(parameterName: "items")]
        public static ArrayElement<T>[]? MakeElementArray(T[]? items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(92, 1273, 1725);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 1419, 1497) || true) && (items == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(92, 1419, 1497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 1470, 1482);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(92, 1419, 1497);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 1513, 1559);

                var
                array = new ArrayElement<T>[items.Length]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 1582, 1587);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 1573, 1685) || true) && (i < items.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 1607, 1610)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(92, 1573, 1685))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(92, 1573, 1685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 1644, 1670);

                        array[i].Value = items[i];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(92, 1, 113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(92, 1, 113);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 1701, 1714);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(92, 1273, 1725);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(92, 1273, 1725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(92, 1273, 1725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "items")]
        public static T[]? MakeArray(ArrayElement<T>[]? items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(92, 1737, 2168);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 1876, 1954) || true) && (items == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(92, 1876, 1954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 1927, 1939);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(92, 1876, 1954);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 1970, 2002);

                var
                array = new T[f_92_1988_2000(items)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 2025, 2030);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 2016, 2128) || true) && (i < f_92_2036_2048(items))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 2050, 2053)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(92, 2016, 2128))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(92, 2016, 2128);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 2087, 2113);

                        array[i] = items[i].Value;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(92, 1, 113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(92, 1, 113);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(92, 2144, 2157);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(92, 1737, 2168);

                int
                f_92_1988_2000(Microsoft.CodeAnalysis.ArrayElement<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(92, 1988, 2000);
                    return return_v;
                }


                int
                f_92_2036_2048(Microsoft.CodeAnalysis.ArrayElement<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(92, 2036, 2048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(92, 1737, 2168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(92, 1737, 2168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static ArrayElement()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(92, 318, 2175);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(92, 318, 2175);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(92, 318, 2175);
        }
    }
}
