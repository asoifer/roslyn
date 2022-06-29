// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal static class Hash
    {
        internal static int Combine(int newKey, int currentKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 529, 678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 609, 667);

                return unchecked((currentKey * (int)0xA5555529) + newKey);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 529, 678);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 529, 678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 529, 678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int Combine(bool newKeyPart, int currentKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 690, 833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 775, 822);

                return f_332_782_821(currentKey, (DynAbs.Tracing.TraceSender.Conditional_F1(332, 802, 812) || ((newKeyPart && DynAbs.Tracing.TraceSender.Conditional_F2(332, 815, 816)) || DynAbs.Tracing.TraceSender.Conditional_F3(332, 819, 820))) ? 1 : 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 690, 833);

                int
                f_332_782_821(int
                newKey, int
                currentKey)
                {
                    var return_v = Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 782, 821);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 690, 833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 690, 833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int Combine<T>(T newKeyPart, int currentKey) where T : class?
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 1198, 1527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 1300, 1351);

                int
                hash = unchecked(currentKey * (int)0xA5555529)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 1367, 1488) || true) && (newKeyPart != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 1367, 1488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 1423, 1473);

                    return unchecked(hash + f_332_1447_1471(newKeyPart));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(332, 1367, 1488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 1504, 1516);

                return hash;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 1198, 1527);

                int
                f_332_1447_1471(T
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 1447, 1471);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 1198, 1527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 1198, 1527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineValues<T>(IEnumerable<T>? values, int maxItemsToHash = int.MaxValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 1539, 2303);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 1659, 1735) || true) && (values == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 1659, 1735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 1711, 1720);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(332, 1659, 1735);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 1751, 1768);

                var
                hashCode = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 1782, 1796);

                var
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 1810, 2260);
                    foreach (var value in f_332_1832_1838_I(values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 1810, 2260);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 1872, 1968) || true) && (count++ >= maxItemsToHash)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 1872, 1968);
                            DynAbs.Tracing.TraceSender.TraceBreak(332, 1943, 1949);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(332, 1872, 1968);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2112, 2245) || true) && (value != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 2112, 2245);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2171, 2226);

                            hashCode = f_332_2182_2225(f_332_2195_2214(value), hashCode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(332, 2112, 2245);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(332, 1810, 2260);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2276, 2292);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 1539, 2303);

                int
                f_332_2195_2214(T
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 2195, 2214);
                    return return_v;
                }


                int
                f_332_2182_2225(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 2182, 2225);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_332_1832_1838_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 1832, 1838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 1539, 2303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 1539, 2303);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineValues<T>(T[]? values, int maxItemsToHash = int.MaxValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 2315, 3038);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2424, 2500) || true) && (values == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 2424, 2500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2476, 2485);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(332, 2424, 2500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2516, 2570);

                var
                maxSize = f_332_2530_2569(maxItemsToHash, f_332_2555_2568(values))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2584, 2601);

                var
                hashCode = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2626, 2631);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2617, 2995) || true) && (i < maxSize)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2646, 2649)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(332, 2617, 2995))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 2617, 2995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2683, 2703);

                        T
                        value = values[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2847, 2980) || true) && (value != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 2847, 2980);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 2906, 2961);

                            hashCode = f_332_2917_2960(f_332_2930_2949(value), hashCode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(332, 2847, 2980);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 3011, 3027);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 2315, 3038);

                int
                f_332_2555_2568(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(332, 2555, 2568);
                    return return_v;
                }


                int
                f_332_2530_2569(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 2530, 2569);
                    return return_v;
                }


                int
                f_332_2930_2949(T
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 2930, 2949);
                    return return_v;
                }


                int
                f_332_2917_2960(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 2917, 2960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 2315, 3038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 2315, 3038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineValues<T>(ImmutableArray<T> values, int maxItemsToHash = int.MaxValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 3050, 3825);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 3172, 3257) || true) && (values.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 3172, 3257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 3233, 3242);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(332, 3172, 3257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 3273, 3290);

                var
                hashCode = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 3304, 3318);

                var
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 3332, 3782);
                    foreach (var value in f_332_3354_3360_I(values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 3332, 3782);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 3394, 3490) || true) && (count++ >= maxItemsToHash)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 3394, 3490);
                            DynAbs.Tracing.TraceSender.TraceBreak(332, 3465, 3471);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(332, 3394, 3490);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 3634, 3767) || true) && (value != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 3634, 3767);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 3693, 3748);

                            hashCode = f_332_3704_3747(f_332_3717_3736(value), hashCode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(332, 3634, 3767);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(332, 3332, 3782);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 3798, 3814);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 3050, 3825);

                int
                f_332_3717_3736(T
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 3717, 3736);
                    return return_v;
                }


                int
                f_332_3704_3747(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 3704, 3747);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_332_3354_3360_I(System.Collections.Immutable.ImmutableArray<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 3354, 3360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 3050, 3825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 3050, 3825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineValues(IEnumerable<string?>? values, StringComparer stringComparer, int maxItemsToHash = int.MaxValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 3837, 4525);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 3991, 4067) || true) && (values == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 3991, 4067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 4043, 4052);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(332, 3991, 4067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 4083, 4100);

                var
                hashCode = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 4114, 4128);

                var
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 4142, 4482);
                    foreach (var value in f_332_4164_4170_I(values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 4142, 4482);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 4204, 4300) || true) && (count++ >= maxItemsToHash)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 4204, 4300);
                            DynAbs.Tracing.TraceSender.TraceBreak(332, 4275, 4281);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(332, 4204, 4300);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 4320, 4467) || true) && (value != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 4320, 4467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 4379, 4448);

                            hashCode = f_332_4390_4447(f_332_4403_4436(stringComparer, value), hashCode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(332, 4320, 4467);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(332, 4142, 4482);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 4498, 4514);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 3837, 4525);

                int
                f_332_4403_4436(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 4403, 4436);
                    return return_v;
                }


                int
                f_332_4390_4447(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 4390, 4447);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string?>
                f_332_4164_4170_I(System.Collections.Generic.IEnumerable<string?>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 4164, 4170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 3837, 4525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 3837, 4525);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const int
        FnvOffsetBias = unchecked((int)2166136261)
        ;

        internal const int
        FnvPrime = 16777619
        ;

        internal static int GetFNVHashCode(byte[] data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 5401, 5710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 5473, 5507);

                int
                hashCode = Hash.FnvOffsetBias
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 5532, 5537);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 5523, 5667) || true) && (i < f_332_5543_5554(data))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 5556, 5559)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(332, 5523, 5667))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 5523, 5667);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 5593, 5652);

                        hashCode = unchecked((hashCode ^ data[i]) * Hash.FnvPrime);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 5683, 5699);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 5401, 5710);

                int
                f_332_5543_5554(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(332, 5543, 5554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 5401, 5710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 5401, 5710);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetFNVHashCode(ReadOnlySpan<byte> data, out bool isAscii)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 6349, 6833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 6451, 6485);

                int
                hashCode = Hash.FnvOffsetBias
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 6501, 6520);

                byte
                asciiMask = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 6545, 6550);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 6536, 6742) || true) && (i < data.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 6569, 6572)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(332, 6536, 6742))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 6536, 6742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 6606, 6623);

                        byte
                        b = data[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 6641, 6656);

                        asciiMask |= b;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 6674, 6727);

                        hashCode = unchecked((hashCode ^ b) * Hash.FnvPrime);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 6758, 6792);

                isAscii = (asciiMask & 0x80) == 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 6806, 6822);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 6349, 6833);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 6349, 6833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 6349, 6833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetFNVHashCode(ImmutableArray<byte> data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 7180, 7503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 7266, 7300);

                int
                hashCode = Hash.FnvOffsetBias
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 7325, 7330);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 7316, 7460) || true) && (i < data.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 7349, 7352)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(332, 7316, 7460))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 7316, 7460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 7386, 7445);

                        hashCode = unchecked((hashCode ^ data[i]) * Hash.FnvPrime);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 7476, 7492);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 7180, 7503);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 7180, 7503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 7180, 7503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetFNVHashCode(ReadOnlySpan<char> data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 8030, 8351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 8114, 8148);

                int
                hashCode = Hash.FnvOffsetBias
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 8173, 8178);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 8164, 8308) || true) && (i < data.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 8197, 8200)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(332, 8164, 8308))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 8164, 8308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 8234, 8293);

                        hashCode = unchecked((hashCode ^ data[i]) * Hash.FnvPrime);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 8324, 8340);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 8030, 8351);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 8030, 8351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 8030, 8351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetFNVHashCode(string text, int start, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(332, 9386, 9431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 9389, 9431);
                return f_332_9389_9431(f_332_9404_9430(text, start, length)); DynAbs.Tracing.TraceSender.TraceExitMethod(332, 9386, 9431);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 9386, 9431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 9386, 9431);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.ReadOnlySpan<char>
            f_332_9404_9430(string
            text, int
            start, int
            length)
            {
                var return_v = text.AsSpan(start, length);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 9404, 9430);
                return return_v;
            }


            int
            f_332_9389_9431(System.ReadOnlySpan<char>
            data)
            {
                var return_v = GetFNVHashCode(data);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 9389, 9431);
                return return_v;
            }

        }

        internal static int GetCaseInsensitiveFNVHashCode(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 9444, 9608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 9531, 9597);

                return f_332_9538_9596(f_332_9568_9595(text, 0, f_332_9583_9594(text)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 9444, 9608);

                int
                f_332_9583_9594(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(332, 9583, 9594);
                    return return_v;
                }


                System.ReadOnlySpan<char>
                f_332_9568_9595(string
                text, int
                start, int
                length)
                {
                    var return_v = text.AsSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 9568, 9595);
                    return return_v;
                }


                int
                f_332_9538_9596(System.ReadOnlySpan<char>
                data)
                {
                    var return_v = GetCaseInsensitiveFNVHashCode(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 9538, 9596);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 9444, 9608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 9444, 9608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetCaseInsensitiveFNVHashCode(ReadOnlySpan<char> data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 9620, 9991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 9719, 9753);

                int
                hashCode = Hash.FnvOffsetBias
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 9778, 9783);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 9769, 9948) || true) && (i < data.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 9802, 9805)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(332, 9769, 9948))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 9769, 9948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 9839, 9933);

                        hashCode = unchecked((hashCode ^ f_332_9872_9914(data[i])) * Hash.FnvPrime);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 9964, 9980);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 9620, 9991);

                char
                f_332_9872_9914(char
                c)
                {
                    var return_v = CaseInsensitiveComparison.ToLower(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 9872, 9914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 9620, 9991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 9620, 9991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetFNVHashCode(string text, int start)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 10494, 10652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 10577, 10641);

                return f_332_10584_10640(text, start, length: f_332_10620_10631(text) - start);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 10494, 10652);

                int
                f_332_10620_10631(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(332, 10620, 10631);
                    return return_v;
                }


                int
                f_332_10584_10640(string
                text, int
                start, int
                length)
                {
                    var return_v = GetFNVHashCode(text, start, length: length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 10584, 10640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 10494, 10652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 10494, 10652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetFNVHashCode(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 10998, 11129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 11070, 11118);

                return f_332_11077_11117(Hash.FnvOffsetBias, text);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 10998, 11129);

                int
                f_332_11077_11117(int
                hashCode, string
                text)
                {
                    var return_v = CombineFNVHash(hashCode, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 11077, 11117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 10998, 11129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 10998, 11129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetFNVHashCode(System.Text.StringBuilder text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 11475, 11831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 11566, 11600);

                int
                hashCode = Hash.FnvOffsetBias
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 11614, 11636);

                int
                end = f_332_11624_11635(text)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 11661, 11666);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 11652, 11788) || true) && (i < end)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 11677, 11680)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(332, 11652, 11788))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 11652, 11788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 11714, 11773);

                        hashCode = unchecked((hashCode ^ f_332_11747_11754(text, i)) * Hash.FnvPrime);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 11804, 11820);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 11475, 11831);

                int
                f_332_11624_11635(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(332, 11624, 11635);
                    return return_v;
                }


                char
                f_332_11747_11754(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(332, 11747, 11754);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 11475, 11831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 11475, 11831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetFNVHashCode(char[] text, int start, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 12484, 12851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 12579, 12613);

                int
                hashCode = Hash.FnvOffsetBias
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 12627, 12652);

                int
                end = start + length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 12677, 12686);

                    for (int
        i = start
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 12668, 12808) || true) && (i < end)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 12697, 12700)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(332, 12668, 12808))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 12668, 12808);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 12734, 12793);

                        hashCode = unchecked((hashCode ^ text[i]) * Hash.FnvPrime);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 12824, 12840);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 12484, 12851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 12484, 12851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 12484, 12851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetFNVHashCode(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 13448, 13578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 13516, 13567);

                return f_332_13523_13566(Hash.FnvOffsetBias, ch);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 13448, 13578);

                int
                f_332_13523_13566(int
                hashCode, char
                ch)
                {
                    var return_v = Hash.CombineFNVHash(hashCode, ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 13523, 13566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 13448, 13578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 13448, 13578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineFNVHash(int hashCode, string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 14064, 14320);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 14150, 14277);
                    foreach (char ch in f_332_14170_14174_I(text))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(332, 14150, 14277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 14208, 14262);

                        hashCode = unchecked((hashCode ^ ch) * Hash.FnvPrime);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(332, 14150, 14277);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(332, 1, 128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(332, 1, 128);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 14293, 14309);

                return hashCode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 14064, 14320);

                string
                f_332_14170_14174_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(332, 14170, 14174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 14064, 14320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 14064, 14320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineFNVHash(int hashCode, char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(332, 14807, 14950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 14889, 14939);

                return unchecked((hashCode ^ ch) * Hash.FnvPrime);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(332, 14807, 14950);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(332, 14807, 14950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 14807, 14950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Hash()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(332, 363, 14957);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 4758, 4800);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(332, 5034, 5053);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(332, 363, 14957);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(332, 363, 14957);
        }

    }
}
