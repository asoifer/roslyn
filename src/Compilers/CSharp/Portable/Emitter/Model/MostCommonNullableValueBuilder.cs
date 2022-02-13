// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct MostCommonNullableValueBuilder
    {

        private int _value0;

        private int _value1;

        private int _value2;

        internal byte? MostCommonValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10196, 605, 1112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 641, 649);

                    int
                    max
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 667, 674);

                    byte
                    b
                    = default(byte);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 692, 940) || true) && (_value1 > _value0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10196, 692, 940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 755, 769);

                        max = _value1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 791, 797);

                        b = 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10196, 692, 940);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10196, 692, 940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 879, 893);

                        max = _value0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 915, 921);

                        b = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10196, 692, 940);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 958, 1045) || true) && (_value2 > max)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10196, 958, 1045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1017, 1026);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10196, 958, 1045);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1063, 1097);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10196, 1070, 1078) || ((max == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10196, 1081, 1092)) || DynAbs.Tracing.TraceSender.Conditional_F3(10196, 1095, 1096))) ? (byte?)null : b;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10196, 605, 1112);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10196, 550, 1123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10196, 550, 1123);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void AddValue(byte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10196, 1135, 1600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1194, 1589);

                switch (value)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10196, 1194, 1589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1270, 1280);

                        _value0++;
                        DynAbs.Tracing.TraceSender.TraceBreak(10196, 1302, 1308);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10196, 1194, 1589);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10196, 1194, 1589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1355, 1365);

                        _value1++;
                        DynAbs.Tracing.TraceSender.TraceBreak(10196, 1387, 1393);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10196, 1194, 1589);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10196, 1194, 1589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1440, 1450);

                        _value2++;
                        DynAbs.Tracing.TraceSender.TraceBreak(10196, 1472, 1478);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10196, 1194, 1589);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10196, 1194, 1589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1526, 1574);

                        throw f_10196_1532_1573(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10196, 1194, 1589);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10196, 1135, 1600);

                System.Exception
                f_10196_1532_1573(byte
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10196, 1532, 1573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10196, 1135, 1600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10196, 1135, 1600);
            }
        }

        internal void AddValue(byte? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10196, 1612, 1785);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1672, 1774) || true) && (value != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10196, 1672, 1774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1723, 1759);

                    AddValue(f_10196_1732_1757(value));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10196, 1672, 1774);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10196, 1612, 1785);

                byte
                f_10196_1732_1757(byte?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10196, 1732, 1757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10196, 1612, 1785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10196, 1612, 1785);
            }
        }

        internal void AddValue(TypeWithAnnotations type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10196, 1797, 2055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1870, 1917);

                var
                builder = f_10196_1884_1916()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1931, 1967);

                type.AddNullableTransforms(builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 1981, 2015);

                AddValue(GetCommonValue(builder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 2029, 2044);

                f_10196_2029_2043(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10196, 1797, 2055);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                f_10196_1884_1916()
                {
                    var return_v = ArrayBuilder<byte>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10196, 1884, 1916);
                    return return_v;
                }


                int
                f_10196_2029_2043(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10196, 2029, 2043);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10196, 1797, 2055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10196, 1797, 2055);
            }
        }

        internal static byte? GetCommonValue(ArrayBuilder<byte> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10196, 2222, 2667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 2311, 2333);

                int
                n = f_10196_2319_2332(builder)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 2347, 2418) || true) && (n == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10196, 2347, 2418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 2391, 2403);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10196, 2347, 2418);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 2432, 2452);

                byte
                b = f_10196_2441_2451(builder, 0)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 2475, 2480);
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 2466, 2633) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 2489, 2492)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10196, 2466, 2633))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10196, 2466, 2633);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 2526, 2618) || true) && (f_10196_2530_2540(builder, i) != b)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10196, 2526, 2618);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 2587, 2599);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10196, 2526, 2618);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10196, 1, 168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10196, 1, 168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10196, 2647, 2656);

                return b;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10196, 2222, 2667);

                int
                f_10196_2319_2332(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10196, 2319, 2332);
                    return return_v;
                }


                byte
                f_10196_2441_2451(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10196, 2441, 2451);
                    return return_v;
                }


                byte
                f_10196_2530_2540(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10196, 2530, 2540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10196, 2222, 2667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10196, 2222, 2667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static MostCommonNullableValueBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10196, 395, 2674);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10196, 395, 2674);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10196, 395, 2674);
        }
    }
}
