// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Reflection;
using Microsoft.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal static class EnumUtilities
    {
        internal static ulong ConvertEnumUnderlyingTypeToUInt64(object value, SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(326, 586, 2115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 705, 739);

                f_326_705_738(value != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 753, 809);

                f_326_753_808(f_326_766_807(f_326_766_795(f_326_766_781(value))));

                unchecked
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 867, 2089);

                    switch (specialType)
                    {

                        case SpecialType.System_SByte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(326, 867, 2089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 984, 1011);

                            return (ulong)(sbyte)value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(326, 867, 2089);

                        case SpecialType.System_Int16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(326, 867, 2089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 1089, 1116);

                            return (ulong)(short)value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(326, 867, 2089);

                        case SpecialType.System_Int32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(326, 867, 2089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 1194, 1219);

                            return (ulong)(int)value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(326, 867, 2089);

                        case SpecialType.System_Int64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(326, 867, 2089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 1297, 1323);

                            return (ulong)(long)value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(326, 867, 2089);

                        case SpecialType.System_Byte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(326, 867, 2089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 1400, 1419);

                            return (byte)value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(326, 867, 2089);

                        case SpecialType.System_UInt16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(326, 867, 2089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 1498, 1519);

                            return (ushort)value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(326, 867, 2089);

                        case SpecialType.System_UInt32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(326, 867, 2089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 1598, 1617);

                            return (uint)value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(326, 867, 2089);

                        case SpecialType.System_UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(326, 867, 2089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 1696, 1716);

                            return (ulong)value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(326, 867, 2089);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(326, 867, 2089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 1956, 2070);

                            throw f_326_1962_2069(f_326_1992_2068("{0} is not a valid underlying type for an enum", specialType));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(326, 867, 2089);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(326, 586, 2115);

                int
                f_326_705_738(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(326, 705, 738);
                    return 0;
                }


                System.Type
                f_326_766_781(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(326, 766, 781);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_326_766_795(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(326, 766, 795);
                    return return_v;
                }


                bool
                f_326_766_807(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsPrimitive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(326, 766, 807);
                    return return_v;
                }


                int
                f_326_753_808(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(326, 753, 808);
                    return 0;
                }


                string
                f_326_1992_2068(string
                format, Microsoft.CodeAnalysis.SpecialType
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(326, 1992, 2068);
                    return return_v;
                }


                System.InvalidOperationException
                f_326_1962_2069(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(326, 1962, 2069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(326, 586, 2115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(326, 586, 2115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T[] GetValues<T>() where T : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(326, 2127, 2252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 2203, 2241);

                return (T[])f_326_2215_2240(typeof(T));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(326, 2127, 2252);

                System.Array
                f_326_2215_2240(System.Type
                enumType)
                {
                    var return_v = Enum.GetValues(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(326, 2215, 2240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(326, 2127, 2252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(326, 2127, 2252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ContainsAllValues<T>(int mask) where T : struct, Enum, IConvertible
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(326, 2275, 2653);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 2388, 2616);
                    foreach (T value in f_326_2408_2422_I(f_326_2408_2422()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(326, 2388, 2616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 2456, 2486);

                        int
                        val = f_326_2466_2485(value, null)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 2504, 2601) || true) && ((val & mask) != val)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(326, 2504, 2601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 2569, 2582);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(326, 2504, 2601);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(326, 2388, 2616);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(326, 1, 229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(326, 1, 229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(326, 2630, 2642);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(326, 2275, 2653);

                T[]
                f_326_2408_2422()
                {
                    var return_v = GetValues<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(326, 2408, 2422);
                    return return_v;
                }


                int
                f_326_2466_2485(T
                this_param, System.IFormatProvider?
                provider)
                {
                    var return_v = this_param.ToInt32(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(326, 2466, 2485);
                    return return_v;
                }


                T[]
                f_326_2408_2422_I(T[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(326, 2408, 2422);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(326, 2275, 2653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(326, 2275, 2653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnumUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(326, 344, 2668);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(326, 344, 2668);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(326, 344, 2668);
        }

    }
}
