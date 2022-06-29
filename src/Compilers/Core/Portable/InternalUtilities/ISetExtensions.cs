// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Roslyn.Utilities
{
    internal static class ISetExtensions
    {
        public static bool AddAll<T>(this ISet<T> set, IEnumerable<T> values)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(341, 370, 632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 464, 483);

                var
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 497, 591);
                    foreach (var v in f_341_515_521_I(values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(341, 497, 591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 555, 576);

                        result |= f_341_565_575(set, v);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(341, 497, 591);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(341, 1, 95);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(341, 1, 95);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 607, 621);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(341, 370, 632);

                bool
                f_341_565_575(System.Collections.Generic.ISet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(341, 565, 575);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_341_515_521_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(341, 515, 521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(341, 370, 632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(341, 370, 632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AddAll<T>(this ISet<T> set, ImmutableArray<T> values)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(341, 644, 909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 741, 760);

                var
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 774, 868);
                    foreach (var v in f_341_792_798_I(values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(341, 774, 868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 832, 853);

                        result |= f_341_842_852(set, v);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(341, 774, 868);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(341, 1, 95);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(341, 1, 95);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 884, 898);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(341, 644, 909);

                bool
                f_341_842_852(System.Collections.Generic.ISet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(341, 842, 852);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_341_792_798_I(System.Collections.Immutable.ImmutableArray<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(341, 792, 798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(341, 644, 909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(341, 644, 909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool RemoveAll<T>(this ISet<T> set, IEnumerable<T> values)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(341, 921, 1189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 1018, 1037);

                var
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 1051, 1148);
                    foreach (var v in f_341_1069_1075_I(values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(341, 1051, 1148);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 1109, 1133);

                        result |= f_341_1119_1132(set, v);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(341, 1051, 1148);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(341, 1, 98);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(341, 1, 98);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 1164, 1178);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(341, 921, 1189);

                bool
                f_341_1119_1132(System.Collections.Generic.ISet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(341, 1119, 1132);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_341_1069_1075_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(341, 1069, 1075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(341, 921, 1189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(341, 921, 1189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool RemoveAll<T>(this ISet<T> set, ImmutableArray<T> values)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(341, 1201, 1472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 1301, 1320);

                var
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 1334, 1431);
                    foreach (var v in f_341_1352_1358_I(values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(341, 1334, 1431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 1392, 1416);

                        result |= f_341_1402_1415(set, v);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(341, 1334, 1431);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(341, 1, 98);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(341, 1, 98);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(341, 1447, 1461);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(341, 1201, 1472);

                bool
                f_341_1402_1415(System.Collections.Generic.ISet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(341, 1402, 1415);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_341_1352_1358_I(System.Collections.Immutable.ImmutableArray<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(341, 1352, 1358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(341, 1201, 1472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(341, 1201, 1472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ISetExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(341, 317, 1479);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(341, 317, 1479);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(341, 317, 1479);
        }

    }
}
