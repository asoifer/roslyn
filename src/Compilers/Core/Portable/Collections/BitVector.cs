// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Roslyn.Utilities;
using Word = System.UInt64;

namespace Microsoft.CodeAnalysis
{

    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal struct BitVector : IEquatable<BitVector>
    {

        private const Word
        ZeroWord = 0
        ;

        private const int
        Log2BitsPerWord = 6
        ;

        public const int
        BitsPerWord = 1 << Log2BitsPerWord
        ;

        private static Word[] s_emptyArray
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 863, 885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 866, 885);
                    return f_93_866_885(); DynAbs.Tracing.TraceSender.TraceExitMethod(93, 863, 885);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 863, 885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 863, 885);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly BitVector s_nullValue;

        private static readonly BitVector s_emptyValue;

        private Word _bits0;

        private Word[] _bits;

        private int _capacity;

        private BitVector(Word bits0, Word[] bits, int capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(93, 1142, 1473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 1223, 1270);

                int
                requiredWords = WordsForCapacity(capacity)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 1284, 1349);

                f_93_1284_1348(requiredWords == 0 || (DynAbs.Tracing.TraceSender.Expression_False(93, 1297, 1347) || requiredWords <= f_93_1336_1347(bits)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 1363, 1378);

                _bits0 = bits0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 1392, 1405);

                _bits = bits;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 1419, 1440);

                _capacity = capacity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 1454, 1462);

                Check();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(93, 1142, 1473);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 1142, 1473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 1142, 1473);
            }
        }

        public bool Equals(BitVector other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 1485, 2055);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 1859, 2026) || true) && (_capacity == other._capacity && (DynAbs.Tracing.TraceSender.Expression_True(93, 1863, 1917) && _bits0 == other._bits0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 1859, 2026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 1930, 1953);

                    var
                    a = f_93_1938_1952(_bits)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 1959, 1988);

                    var
                    b = f_93_1967_1987(other._bits)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 1994, 2020);

                    return a.SequenceEqual(b);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 1859, 2026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2031, 2044);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 1485, 2055);

                System.Span<ulong>
                f_93_1938_1952(ulong[]
                array)
                {
                    var return_v = array.AsSpan<ulong>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 1938, 1952);
                    return return_v;
                }


                System.Span<ulong>
                f_93_1967_1987(ulong[]
                array)
                {
                    var return_v = array.AsSpan<ulong>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 1967, 1987);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 1485, 2055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 1485, 2055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 2067, 2190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2132, 2179);

                return obj is BitVector other && (DynAbs.Tracing.TraceSender.Expression_True(93, 2139, 2178) && Equals(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 2067, 2190);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 2067, 2190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 2067, 2190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(BitVector left, BitVector right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(93, 2202, 2327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2290, 2316);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(93, 2202, 2327);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 2202, 2327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 2202, 2327);
            }
        }

        public static bool operator !=(BitVector left, BitVector right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(93, 2339, 2465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2427, 2454);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(93, 2339, 2465);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 2339, 2465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 2339, 2465);
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 2477, 2877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2535, 2571);

                int
                bitsHash = f_93_2550_2570(_bits0)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2587, 2809) || true) && (_bits != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 2587, 2809);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2647, 2652);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2638, 2794) || true) && (i < f_93_2658_2670(_bits))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2672, 2675)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(93, 2638, 2794))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 2638, 2794);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2717, 2775);

                            bitsHash = f_93_2728_2774(f_93_2741_2763(_bits[i]), bitsHash);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(93, 1, 157);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(93, 1, 157);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 2587, 2809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2825, 2866);

                return f_93_2832_2865(_capacity, bitsHash);
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 2477, 2877);

                int
                f_93_2550_2570(ulong
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 2550, 2570);
                    return return_v;
                }


                int
                f_93_2658_2670(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 2658, 2670);
                    return return_v;
                }


                int
                f_93_2741_2763(ulong
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 2741, 2763);
                    return return_v;
                }


                int
                f_93_2728_2774(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 2728, 2774);
                    return return_v;
                }


                int
                f_93_2832_2865(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 2832, 2865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 2477, 2877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 2477, 2877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int WordsForCapacity(int capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(93, 2889, 3097);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2963, 2991) || true) && (capacity <= 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 2963, 2991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 2982, 2991);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 2963, 2991);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3005, 3055);

                int
                lastIndex = (capacity - 1) >> Log2BitsPerWord
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3069, 3086);

                return lastIndex;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(93, 2889, 3097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 2889, 3097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 2889, 3097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int Capacity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 3129, 3141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3132, 3141);
                    return _capacity; DynAbs.Tracing.TraceSender.TraceExitMethod(93, 3129, 3141);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 3129, 3141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 3129, 3141);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [Conditional("DEBUG_BITARRAY")]
        private void Check()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 3154, 3327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3240, 3316);

                f_93_3240_3315(_capacity == 0 || (DynAbs.Tracing.TraceSender.Expression_False(93, 3253, 3314) || WordsForCapacity(_capacity) <= f_93_3302_3314(_bits)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 3154, 3327);

                int
                f_93_3302_3314(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 3302, 3314);
                    return return_v;
                }


                int
                f_93_3240_3315(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 3240, 3315);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 3154, 3327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 3154, 3327);
            }
        }

        public void EnsureCapacity(int newCapacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 3339, 3725);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3407, 3692) || true) && (newCapacity > _capacity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 3407, 3692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3468, 3518);

                    int
                    requiredWords = WordsForCapacity(newCapacity)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3536, 3609) || true) && (requiredWords > f_93_3556_3568(_bits))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 3536, 3609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3570, 3609);

                        f_93_3570_3608(ref _bits, requiredWords);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 3536, 3609);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3627, 3651);

                    _capacity = newCapacity;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3669, 3677);

                    Check();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 3407, 3692);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3706, 3714);

                Check();
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 3339, 3725);

                int
                f_93_3556_3568(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 3556, 3568);
                    return return_v;
                }


                int
                f_93_3570_3608(ref ulong[]
                array, int
                newSize)
                {
                    Array.Resize(ref array, newSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 3570, 3608);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 3339, 3725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 3339, 3725);
            }
        }

        public IEnumerable<Word> Words()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 3737, 4029);

                var listYield = new List<UInt64>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3794, 3880) || true) && (_capacity > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 3794, 3880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3845, 3865);

                    listYield.Add(_bits0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 3794, 3880);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3905, 3910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3912, 3934);

                    for (int
        i = 0
        ,
        n = f_93_3916_3929_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_bits, 93, 3916, 3929)?.Length) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(93, 3916, 3934) ?? 0)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3896, 4018) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3943, 3946)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(93, 3896, 4018))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 3896, 4018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 3980, 4003);

                        listYield.Add(_bits![i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(93, 1, 123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(93, 1, 123);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 3737, 4029);

                return listYield;

                int?
                f_93_3916_3929_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 3916, 3929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 3737, 4029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 3737, 4029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<int> TrueBits()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 4041, 5152);

                var listYield = new List<Int32>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4100, 4108);

                Check();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4122, 4514) || true) && (_bits0 != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 4122, 4514);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4180, 4187);
                        for (int
        bit = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4171, 4499) || true) && (bit < BitsPerWord)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4208, 4213)
        , bit++, DynAbs.Tracing.TraceSender.TraceExitCondition(93, 4171, 4499))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 4171, 4499);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4255, 4284);

                            Word
                            mask = ((Word)1) << bit
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4306, 4480) || true) && ((_bits0 & mask) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 4306, 4480);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4380, 4414) || true) && (bit >= _capacity)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 4380, 4414);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4402, 4414);

                                    return listYield;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 4380, 4414);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4440, 4457);

                                listYield.Add(bit);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(93, 4306, 4480);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(93, 1, 329);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(93, 1, 329);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 4122, 4514);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4537, 4542);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4528, 5141) || true) && (i < f_93_4548_4560(_bits))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4562, 4565)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(93, 4528, 5141))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 4528, 5141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4599, 4617);

                        Word
                        w = _bits[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4635, 5126) || true) && (w != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 4635, 5126);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4696, 4701);
                                for (int
            b = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4687, 5107) || true) && (b < BitsPerWord)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4720, 4723)
            , b++, DynAbs.Tracing.TraceSender.TraceExitCondition(93, 4687, 5107))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 4687, 5107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4773, 4800);

                                    Word
                                    mask = ((Word)1) << b
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4826, 5084) || true) && ((w & mask) != 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 4826, 5084);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4903, 4946);

                                        int
                                        bit = ((i + 1) << Log2BitsPerWord) | b
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4976, 5010) || true) && (bit >= _capacity)
                                        )
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 4976, 5010);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 4998, 5010);

                                            return listYield;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(93, 4976, 5010);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 5040, 5057);

                                        listYield.Add(bit);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 4826, 5084);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(93, 1, 421);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(93, 1, 421);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(93, 4635, 5126);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(93, 1, 614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(93, 1, 614);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 4041, 5152);

                return listYield;

                int
                f_93_4548_4560(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 4548, 4560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 4041, 5152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 4041, 5152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BitVector Create(int capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(93, 5284, 5555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 5353, 5400);

                int
                requiredWords = WordsForCapacity(capacity)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 5414, 5490);

                Word[]
                bits = (DynAbs.Tracing.TraceSender.Conditional_F1(93, 5428, 5448) || (((requiredWords == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(93, 5451, 5463)) || DynAbs.Tracing.TraceSender.Conditional_F3(93, 5466, 5489))) ? s_emptyArray : new Word[requiredWords]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 5504, 5544);

                return f_93_5511_5543(0, bits, capacity);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(93, 5284, 5555);

                Microsoft.CodeAnalysis.BitVector
                f_93_5511_5543(int
                bits0, ulong[]
                bits, int
                capacity)
                {
                    var return_v = new Microsoft.CodeAnalysis.BitVector((ulong)bits0, bits, capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 5511, 5543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 5284, 5555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 5284, 5555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BitVector AllSet(int capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(93, 5774, 6918);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 5843, 5922) || true) && (capacity == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 5843, 5922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 5894, 5907);

                    return Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 5843, 5922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 5938, 5985);

                int
                requiredWords = WordsForCapacity(capacity)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 5999, 6075);

                Word[]
                bits = (DynAbs.Tracing.TraceSender.Conditional_F1(93, 6013, 6033) || (((requiredWords == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(93, 6036, 6048)) || DynAbs.Tracing.TraceSender.Conditional_F3(93, 6051, 6074))) ? s_emptyArray : new Word[requiredWords]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6089, 6122);

                int
                lastWord = requiredWords - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6136, 6159);

                Word
                bits0 = ~ZeroWord
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6182, 6187);
                    for (int
        j = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6173, 6245) || true) && (j < lastWord)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6203, 6206)
        , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(93, 6173, 6245))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 6173, 6245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6225, 6245);

                        bits[j] = ~ZeroWord;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(93, 1, 73);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(93, 1, 73);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6259, 6312);

                int
                numTrailingBits = capacity & ((BitsPerWord) - 1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6326, 6847) || true) && (numTrailingBits > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 6326, 6847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6383, 6428);

                    f_93_6383_6427(numTrailingBits <= BitsPerWord);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6446, 6496);

                    Word
                    lastBits = ~((~ZeroWord) << numTrailingBits)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6514, 6716) || true) && (lastWord < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 6514, 6716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6572, 6589);

                        bits0 = lastBits;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 6514, 6716);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 6514, 6716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6671, 6697);

                        bits[lastWord] = lastBits;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 6514, 6716);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 6326, 6847);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 6326, 6847);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6750, 6847) || true) && (requiredWords > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 6750, 6847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6805, 6832);

                        bits[lastWord] = ~ZeroWord;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 6750, 6847);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 6326, 6847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 6863, 6907);

                return f_93_6870_6906(bits0, bits, capacity);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(93, 5774, 6918);

                int
                f_93_6383_6427(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 6383, 6427);
                    return 0;
                }


                Microsoft.CodeAnalysis.BitVector
                f_93_6870_6906(ulong
                bits0, ulong[]
                bits, int
                capacity)
                {
                    var return_v = new Microsoft.CodeAnalysis.BitVector(bits0, bits, capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 6870, 6906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 5774, 6918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 5774, 6918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BitVector Clone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 7051, 7413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7100, 7115);

                Word[]
                newBits
                = default(Word[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7129, 7337) || true) && (_bits is null || (DynAbs.Tracing.TraceSender.Expression_False(93, 7133, 7167) || f_93_7150_7162(_bits) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 7129, 7337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7201, 7224);

                    newBits = s_emptyArray;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 7129, 7337);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 7129, 7337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7290, 7322);

                    newBits = (Word[])f_93_7308_7321(_bits);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 7129, 7337);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7353, 7402);

                return f_93_7360_7401(_bits0, newBits, _capacity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 7051, 7413);

                int
                f_93_7150_7162(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 7150, 7162);
                    return return_v;
                }


                object
                f_93_7308_7321(ulong[]
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 7308, 7321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_93_7360_7401(ulong
                bits0, ulong[]
                bits, int
                capacity)
                {
                    var return_v = new Microsoft.CodeAnalysis.BitVector(bits0, bits, capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 7360, 7401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 7051, 7413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 7051, 7413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Invert()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 7520, 7795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7565, 7582);

                _bits0 = ~_bits0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7596, 7784) || true) && (!(_bits is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 7596, 7784);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7659, 7664);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7650, 7769) || true) && (i < f_93_7670_7682(_bits))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7684, 7687)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(93, 7650, 7769))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 7650, 7769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7729, 7750);

                            _bits[i] = ~_bits[i];
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(93, 1, 120);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(93, 1, 120);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 7596, 7784);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 7520, 7795);

                int
                f_93_7670_7682(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 7670, 7682);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 7520, 7795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 7520, 7795);
            }
        }

        public bool IsNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 7939, 8011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 7975, 7996);

                    return _bits == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(93, 7939, 8011);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 7896, 8022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 7896, 8022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static BitVector Null
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 8063, 8077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 8066, 8077);
                    return s_nullValue; DynAbs.Tracing.TraceSender.TraceExitMethod(93, 8063, 8077);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 8063, 8077);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 8063, 8077);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static BitVector Empty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 8120, 8135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 8123, 8135);
                    return s_emptyValue; DynAbs.Tracing.TraceSender.TraceExitMethod(93, 8120, 8135);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 8120, 8135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 8120, 8135);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IntersectWith(in BitVector other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 8485, 9877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 8555, 8579);

                bool
                anyChanged = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 8593, 8630);

                int
                otherLength = f_93_8611_8629(other._bits)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 8644, 8665);

                var
                thisBits = _bits
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 8679, 8712);

                int
                thisLength = f_93_8696_8711(thisBits)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 8728, 8800) || true) && (otherLength > thisLength)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 8728, 8800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 8775, 8800);

                    otherLength = thisLength;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 8728, 8800);
                }

                // intersect the inline portion
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 8880, 8898);

                    var
                    oldV = _bits0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 8916, 8947);

                    var
                    newV = oldV & other._bits0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 8965, 9096) || true) && (newV != oldV)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 8965, 9096);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9023, 9037);

                        _bits0 = newV;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9059, 9077);

                        anyChanged = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 8965, 9096);
                    }
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9187, 9192);
                    // intersect up to their common length.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9178, 9491) || true) && (i < otherLength)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9211, 9214)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(93, 9178, 9491))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 9178, 9491);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9248, 9271);

                        var
                        oldV = thisBits[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9289, 9322);

                        var
                        newV = oldV & other._bits[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9340, 9476) || true) && (newV != oldV)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 9340, 9476);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9398, 9417);

                            thisBits[i] = newV;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9439, 9457);

                            anyChanged = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(93, 9340, 9476);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(93, 1, 314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(93, 1, 314);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9588, 9603);

                    // treat the other bit array as being extended with zeroes
                    for (int
        i = otherLength
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9579, 9810) || true) && (i < thisLength)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9621, 9624)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(93, 9579, 9810))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 9579, 9810);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9658, 9795) || true) && (thisBits[i] != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 9658, 9795);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9720, 9736);

                            thisBits[i] = 0;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9758, 9776);

                            anyChanged = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(93, 9658, 9795);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(93, 1, 232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(93, 1, 232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9826, 9834);

                Check();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 9848, 9866);

                return anyChanged;
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 8485, 9877);

                int
                f_93_8611_8629(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 8611, 8629);
                    return return_v;
                }


                int
                f_93_8696_8711(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 8696, 8711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 8485, 9877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 8485, 9877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool UnionWith(in BitVector other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 10134, 10796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10200, 10224);

                bool
                anyChanged = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10240, 10322) || true) && (other._capacity > _capacity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 10240, 10322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10290, 10322);

                    EnsureCapacity(other._capacity);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 10240, 10322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10338, 10360);

                Word
                oldbits = _bits0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10374, 10397);

                _bits0 |= other._bits0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10413, 10471) || true) && (oldbits != _bits0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 10413, 10471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10453, 10471);

                    anyChanged = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 10413, 10471);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10496, 10501);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10487, 10727) || true) && (i < f_93_10507_10525(other._bits))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10527, 10530)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(93, 10487, 10727))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 10487, 10727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10564, 10583);

                        oldbits = _bits[i];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10601, 10628);

                        _bits[i] |= other._bits[i];

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10648, 10712) || true) && (_bits[i] != oldbits)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 10648, 10712);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10694, 10712);

                            anyChanged = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(93, 10648, 10712);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(93, 1, 241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(93, 1, 241);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10743, 10751);

                Check();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10767, 10785);

                return anyChanged;
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 10134, 10796);

                int
                f_93_10507_10525(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 10507, 10525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 10134, 10796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 10134, 10796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 10860, 11221);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10896, 10969) || true) && (index < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 10896, 10969);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10932, 10969);

                        throw f_93_10938_10968();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 10896, 10969);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 10987, 11045) || true) && (index >= _capacity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 10987, 11045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11032, 11045);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 10987, 11045);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11063, 11102);

                    int
                    i = (index >> Log2BitsPerWord) - 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11120, 11159);

                    var
                    word = (DynAbs.Tracing.TraceSender.Conditional_F1(93, 11131, 11138) || (((i < 0) && DynAbs.Tracing.TraceSender.Conditional_F2(93, 11141, 11147)) || DynAbs.Tracing.TraceSender.Conditional_F3(93, 11150, 11158))) ? _bits0 : _bits[i]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11179, 11206);

                    return IsTrue(word, index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(93, 10860, 11221);

                    System.IndexOutOfRangeException
                    f_93_10938_10968()
                    {
                        var return_v = new System.IndexOutOfRangeException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 10938, 10968);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 10860, 11221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 10860, 11221);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 11237, 12016);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11273, 11346) || true) && (index < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 11273, 11346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11309, 11346);

                        throw f_93_11315_11345();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 11273, 11346);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11364, 11435) || true) && (index >= _capacity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 11364, 11435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11409, 11435);

                        EnsureCapacity(index + 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 11364, 11435);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11453, 11492);

                    int
                    i = (index >> Log2BitsPerWord) - 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11510, 11544);

                    int
                    b = index & (BitsPerWord - 1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11562, 11589);

                    Word
                    mask = ((Word)1) << b
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11607, 12001) || true) && (i < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 11607, 12001);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11658, 11777) || true) && (value)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 11658, 11777);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11694, 11709);

                            _bits0 |= mask;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(93, 11658, 11777);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 11658, 11777);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11761, 11777);

                            _bits0 &= ~mask;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(93, 11658, 11777);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 11607, 12001);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 11607, 12001);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11859, 11982) || true) && (value)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 11859, 11982);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11895, 11912);

                            _bits[i] |= mask;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(93, 11859, 11982);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 11859, 11982);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 11964, 11982);

                            _bits[i] &= ~mask;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(93, 11859, 11982);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(93, 11607, 12001);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(93, 11237, 12016);

                    System.IndexOutOfRangeException
                    f_93_11315_11345()
                    {
                        var return_v = new System.IndexOutOfRangeException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 11315, 11345);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 11237, 12016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 11237, 12016);
                }
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 12039, 12174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12083, 12094);

                _bits0 = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12108, 12163) || true) && (_bits != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 12108, 12163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12127, 12163);

                    f_93_12127_12162(_bits, 0, f_93_12149_12161(_bits));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 12108, 12163);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 12039, 12174);

                int
                f_93_12149_12161(ulong[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 12149, 12161);
                    return return_v;
                }


                int
                f_93_12127_12162(ulong[]
                array, int
                index, int
                length)
                {
                    Array.Clear((System.Array)array, index, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 12127, 12162);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 12039, 12174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 12039, 12174);
            }
        }

        public static bool IsTrue(Word word, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(93, 12186, 12384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12258, 12292);

                int
                b = index & (BitsPerWord - 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12306, 12333);

                Word
                mask = ((Word)1) << b
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12347, 12373);

                return (word & mask) != 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(93, 12186, 12384);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 12186, 12384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 12186, 12384);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int WordsRequired(int capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(93, 12396, 12557);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12466, 12494) || true) && (capacity <= 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 12466, 12494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12485, 12494);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(93, 12466, 12494);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12508, 12546);

                return WordsForCapacity(capacity) + 1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(93, 12396, 12557);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 12396, 12557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 12396, 12557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(93, 12569, 12856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12630, 12662);

                var
                value = new char[_capacity]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12685, 12690);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12676, 12806) || true) && (i < _capacity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12707, 12710)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(93, 12676, 12806))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(93, 12676, 12806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12744, 12791);

                        value[_capacity - i - 1] = (DynAbs.Tracing.TraceSender.Conditional_F1(93, 12771, 12778) || ((this[i] && DynAbs.Tracing.TraceSender.Conditional_F2(93, 12781, 12784)) || DynAbs.Tracing.TraceSender.Conditional_F3(93, 12787, 12790))) ? '1' : '0';
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(93, 1, 131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(93, 1, 131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 12820, 12845);

                return f_93_12827_12844(value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(93, 12569, 12856);

                string
                f_93_12827_12844(char[]
                value)
                {
                    var return_v = new string(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 12827, 12844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(93, 12569, 12856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 12569, 12856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static BitVector()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(93, 382, 12863);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 520, 532);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 561, 580);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 610, 644);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 930, 951);
            s_nullValue = default; DynAbs.Tracing.TraceSender.TraceSimpleStatement(93, 996, 1034);
            s_emptyValue = new(0, s_emptyArray, 0); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(93, 382, 12863);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(93, 382, 12863);
        }

        static ulong[]
        f_93_866_885()
        {
            var return_v = Array.Empty<Word>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 866, 885);
            return return_v;
        }


        static int
        f_93_1336_1347(ulong[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(93, 1336, 1347);
            return return_v;
        }


        static int
        f_93_1284_1348(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(93, 1284, 1348);
            return 0;
        }

    }
}
