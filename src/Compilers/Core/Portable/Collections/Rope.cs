// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract class Rope
    {
        public static readonly Rope Empty;

        public abstract override string ToString();

        public abstract int Length { get; }

        protected abstract IEnumerable<char> GetChars();

        private Rope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(111, 780, 798);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(111, 780, 798);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 780, 798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 780, 798);
            }
        }

        public static Rope ForString(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 903, 1093);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 966, 1041) || true) && (s == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 966, 1041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 998, 1041);

                    throw f_111_1004_1040(nameof(s));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 966, 1041);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1057, 1082);

                return f_111_1064_1081(s);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 903, 1093);

                System.ArgumentNullException
                f_111_1004_1040(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 1004, 1040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Rope.StringRope
                f_111_1064_1081(string
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.Rope.StringRope(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 1064, 1081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 903, 1093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 903, 1093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Rope Concat(Rope r1, Rope r2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 1223, 1711);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1291, 1368) || true) && (r1 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 1291, 1368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1324, 1368);

                    throw f_111_1330_1367(nameof(r1));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 1291, 1368);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1384, 1461) || true) && (r2 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 1384, 1461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1417, 1461);

                    throw f_111_1423_1460(nameof(r2));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 1384, 1461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1477, 1700);

                return
                (DynAbs.Tracing.TraceSender.Conditional_F1(111, 1501, 1515) || ((f_111_1501_1510(r1) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(111, 1518, 1520)) || DynAbs.Tracing.TraceSender.Conditional_F3(111, 1540, 1699))) ? r2 : (DynAbs.Tracing.TraceSender.Conditional_F1(111, 1540, 1554) || ((f_111_1540_1549(r2) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(111, 1557, 1559)) || DynAbs.Tracing.TraceSender.Conditional_F3(111, 1579, 1699))) ? r1 : (DynAbs.Tracing.TraceSender.Conditional_F1(111, 1579, 1614) || ((checked(f_111_1587_1596(r1) + f_111_1599_1608(r2) < 32) && DynAbs.Tracing.TraceSender.Conditional_F2(111, 1617, 1657)) || DynAbs.Tracing.TraceSender.Conditional_F3(111, 1677, 1699))) ? f_111_1617_1657(f_111_1627_1640(r1) + f_111_1643_1656(r2)) : f_111_1677_1699(r1, r2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 1223, 1711);

                System.ArgumentNullException
                f_111_1330_1367(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 1330, 1367);
                    return return_v;
                }


                System.ArgumentNullException
                f_111_1423_1460(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 1423, 1460);
                    return return_v;
                }


                int
                f_111_1501_1510(Microsoft.CodeAnalysis.Rope
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 1501, 1510);
                    return return_v;
                }


                int
                f_111_1540_1549(Microsoft.CodeAnalysis.Rope
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 1540, 1549);
                    return return_v;
                }


                int
                f_111_1587_1596(Microsoft.CodeAnalysis.Rope
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 1587, 1596);
                    return return_v;
                }


                int
                f_111_1599_1608(Microsoft.CodeAnalysis.Rope
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 1599, 1608);
                    return return_v;
                }


                string
                f_111_1627_1640(Microsoft.CodeAnalysis.Rope
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 1627, 1640);
                    return return_v;
                }


                string
                f_111_1643_1656(Microsoft.CodeAnalysis.Rope
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 1643, 1656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Rope
                f_111_1617_1657(string
                s)
                {
                    var return_v = ForString(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 1617, 1657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Rope.ConcatRope
                f_111_1677_1699(Microsoft.CodeAnalysis.Rope
                left, Microsoft.CodeAnalysis.Rope
                right)
                {
                    var return_v = new Microsoft.CodeAnalysis.Rope.ConcatRope(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 1677, 1699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 1223, 1711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 1223, 1711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 1859, 2399);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1924, 2006) || true) && (!(obj is Rope other) || (DynAbs.Tracing.TraceSender.Expression_False(111, 1928, 1974) || f_111_1952_1958() != f_111_1962_1974(other)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 1924, 2006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1993, 2006);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 1924, 2006);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2020, 2066) || true) && (f_111_2024_2030() == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 2020, 2066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2054, 2066);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 2020, 2066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2080, 2120);

                var
                chars0 = f_111_2093_2119(f_111_2093_2103(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2134, 2180);

                var
                chars1 = f_111_2147_2179(f_111_2147_2163(other))
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2194, 2360) || true) && (f_111_2201_2218(chars0) && (DynAbs.Tracing.TraceSender.Expression_True(111, 2201, 2239) && f_111_2222_2239(chars1)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 2194, 2360);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2273, 2345) || true) && (f_111_2277_2291(chars0) != f_111_2295_2309(chars1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 2273, 2345);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2332, 2345);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 2273, 2345);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 2194, 2360);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 2194, 2360);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(111, 2194, 2360);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2376, 2388);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 1859, 2399);

                int
                f_111_1952_1958()
                {
                    var return_v = Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 1952, 1958);
                    return return_v;
                }


                int
                f_111_1962_1974(Microsoft.CodeAnalysis.Rope
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 1962, 1974);
                    return return_v;
                }


                int
                f_111_2024_2030()
                {
                    var return_v = Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 2024, 2030);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<char>
                f_111_2093_2103(Microsoft.CodeAnalysis.Rope
                this_param)
                {
                    var return_v = this_param.GetChars();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 2093, 2103);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<char>
                f_111_2093_2119(System.Collections.Generic.IEnumerable<char>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 2093, 2119);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<char>
                f_111_2147_2163(Microsoft.CodeAnalysis.Rope
                this_param)
                {
                    var return_v = this_param.GetChars();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 2147, 2163);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<char>
                f_111_2147_2179(System.Collections.Generic.IEnumerable<char>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 2147, 2179);
                    return return_v;
                }


                bool
                f_111_2201_2218(System.Collections.Generic.IEnumerator<char>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 2201, 2218);
                    return return_v;
                }


                bool
                f_111_2222_2239(System.Collections.Generic.IEnumerator<char>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 2222, 2239);
                    return return_v;
                }


                char
                f_111_2277_2291(System.Collections.Generic.IEnumerator<char>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 2277, 2291);
                    return return_v;
                }


                char
                f_111_2295_2309(System.Collections.Generic.IEnumerator<char>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 2295, 2309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 1859, 2399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 1859, 2399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 2411, 2630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2469, 2489);

                int
                result = f_111_2482_2488()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2503, 2589);
                    foreach (char c in f_111_2522_2532_I(f_111_2522_2532(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 2503, 2589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2551, 2589);

                        result = f_111_2560_2588(c, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 2503, 2589);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 1, 87);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(111, 1, 87);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2605, 2619);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 2411, 2630);

                int
                f_111_2482_2488()
                {
                    var return_v = Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 2482, 2488);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<char>
                f_111_2522_2532(Microsoft.CodeAnalysis.Rope
                this_param)
                {
                    var return_v = this_param.GetChars();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 2522, 2532);
                    return return_v;
                }


                int
                f_111_2560_2588(char
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 2560, 2588);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<char>
                f_111_2522_2532_I(System.Collections.Generic.IEnumerable<char>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 2522, 2532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 2411, 2630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 2411, 2630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class StringRope : Rope
        {
            private readonly string _value;

            public StringRope(string value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(111, 2845, 2895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2824, 2830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2880, 2894);
                    _value = value; DynAbs.Tracing.TraceSender.TraceExitConstructor(111, 2845, 2895);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 2845, 2895);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 2845, 2895);
                }
            }

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 2943, 2952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2946, 2952);
                    return _value; DynAbs.Tracing.TraceSender.TraceExitMethod(111, 2943, 2952);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 2943, 2952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 2943, 2952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int Length
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 2994, 3010);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 2997, 3010);
                        return f_111_2997_3010(_value); DynAbs.Tracing.TraceSender.TraceExitMethod(111, 2994, 3010);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 2994, 3010);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 2994, 3010);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected override IEnumerable<char> GetChars()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 3073, 3082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3076, 3082);
                    return _value; DynAbs.Tracing.TraceSender.TraceExitMethod(111, 3073, 3082);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 3073, 3082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 3073, 3082);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static StringRope()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(111, 2737, 3094);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(111, 2737, 3094);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 2737, 3094);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(111, 2737, 3094);

            int
            f_111_2997_3010(string
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 2997, 3010);
                return return_v;
            }

        }
        private sealed class ConcatRope : Rope
        {
            private readonly Rope _left, _right;

            public override int Length { get; }

            public ConcatRope(Rope left, Rope right)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(111, 3385, 3582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3306, 3311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3313, 3319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3334, 3369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3458, 3471);

                    _left = left;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3489, 3504);

                    _right = right;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3522, 3567);

                    Length = checked(f_111_3539_3550(left) + f_111_3553_3565(right));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(111, 3385, 3582);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 3385, 3582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 3385, 3582);
                }
            }

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 3598, 4473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3664, 3708);

                    var
                    psb = f_111_3674_3707()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3726, 3756);

                    var
                    stack = f_111_3738_3755()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3774, 3791);

                    f_111_3774_3790(stack, this);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3809, 4409) || true) && (f_111_3816_3827(stack) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 3809, 4409);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3874, 4390);

                            switch (f_111_3882_3893(stack))
                            {

                                case StringRope s:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 3874, 4390);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 3991, 4024);

                                    f_111_3991_4023(psb.Builder, f_111_4010_4022(s));
                                    DynAbs.Tracing.TraceSender.TraceBreak(111, 4054, 4060);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 3874, 4390);

                                case ConcatRope c:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 3874, 4390);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4134, 4155);

                                    f_111_4134_4154(stack, c._right);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4185, 4205);

                                    f_111_4185_4204(stack, c._left);
                                    DynAbs.Tracing.TraceSender.TraceBreak(111, 4235, 4241);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 3874, 4390);

                                case var v:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 3874, 4390);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4308, 4367);

                                    throw f_111_4314_4366(f_111_4349_4365(f_111_4349_4360(v)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 3874, 4390);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 3809, 4409);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 3809, 4409);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(111, 3809, 4409);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4429, 4458);

                    return f_111_4436_4457(psb);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 3598, 4473);

                    Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    f_111_3674_3707()
                    {
                        var return_v = PooledStringBuilder.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 3674, 3707);
                        return return_v;
                    }


                    System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    f_111_3738_3755()
                    {
                        var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 3738, 3755);
                        return return_v;
                    }


                    int
                    f_111_3774_3790(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    this_param, Microsoft.CodeAnalysis.Rope.ConcatRope
                    item)
                    {
                        this_param.Push((Microsoft.CodeAnalysis.Rope)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 3774, 3790);
                        return 0;
                    }


                    int
                    f_111_3816_3827(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 3816, 3827);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Rope
                    f_111_3882_3893(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 3882, 3893);
                        return return_v;
                    }


                    string
                    f_111_4010_4022(Microsoft.CodeAnalysis.Rope.StringRope
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4010, 4022);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_111_3991_4023(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 3991, 4023);
                        return return_v;
                    }


                    int
                    f_111_4134_4154(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    this_param, Microsoft.CodeAnalysis.Rope
                    item)
                    {
                        this_param.Push(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4134, 4154);
                        return 0;
                    }


                    int
                    f_111_4185_4204(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    this_param, Microsoft.CodeAnalysis.Rope
                    item)
                    {
                        this_param.Push(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4185, 4204);
                        return 0;
                    }


                    System.Type
                    f_111_4349_4360(Microsoft.CodeAnalysis.Rope
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4349, 4360);
                        return return_v;
                    }


                    string
                    f_111_4349_4365(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 4349, 4365);
                        return return_v;
                    }


                    System.Exception
                    f_111_4314_4366(string
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4314, 4366);
                        return return_v;
                    }


                    string
                    f_111_4436_4457(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToStringAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4436, 4457);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 3598, 4473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 3598, 4473);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override IEnumerable<char> GetChars()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 4489, 5314);

                    var listYield = new List<Char>();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4569, 4599);

                    var
                    stack = f_111_4581_4598()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4617, 4634);

                    f_111_4617_4633(stack, this);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4652, 5299) || true) && (f_111_4659_4670(stack) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 4652, 5299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4717, 5280);

                            switch (f_111_4725_4736(stack))
                            {

                                case StringRope s:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 4717, 5280);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4834, 4914);
                                        foreach (var c in f_111_4852_4864_I(f_111_4852_4864(s)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 4834, 4914);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4899, 4914);

                                            listYield.Add(c);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 4834, 4914);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 1, 81);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(111, 1, 81);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(111, 4944, 4950);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 4717, 5280);

                                case ConcatRope c:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 4717, 5280);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 5024, 5045);

                                    f_111_5024_5044(stack, c._right);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 5075, 5095);

                                    f_111_5075_5094(stack, c._left);
                                    DynAbs.Tracing.TraceSender.TraceBreak(111, 5125, 5131);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 4717, 5280);

                                case var v:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 4717, 5280);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 5198, 5257);

                                    throw f_111_5204_5256(f_111_5239_5255(f_111_5239_5250(v)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 4717, 5280);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 4652, 5299);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 4652, 5299);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(111, 4652, 5299);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 4489, 5314);

                    return listYield;

                    System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    f_111_4581_4598()
                    {
                        var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4581, 4598);
                        return return_v;
                    }


                    int
                    f_111_4617_4633(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    this_param, Microsoft.CodeAnalysis.Rope.ConcatRope
                    item)
                    {
                        this_param.Push((Microsoft.CodeAnalysis.Rope)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4617, 4633);
                        return 0;
                    }


                    int
                    f_111_4659_4670(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 4659, 4670);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Rope
                    f_111_4725_4736(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4725, 4736);
                        return return_v;
                    }


                    string
                    f_111_4852_4864(Microsoft.CodeAnalysis.Rope.StringRope
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4852, 4864);
                        return return_v;
                    }


                    string
                    f_111_4852_4864_I(string
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4852, 4864);
                        return return_v;
                    }


                    int
                    f_111_5024_5044(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    this_param, Microsoft.CodeAnalysis.Rope
                    item)
                    {
                        this_param.Push(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 5024, 5044);
                        return 0;
                    }


                    int
                    f_111_5075_5094(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Rope>
                    this_param, Microsoft.CodeAnalysis.Rope
                    item)
                    {
                        this_param.Push(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 5075, 5094);
                        return 0;
                    }


                    System.Type
                    f_111_5239_5250(Microsoft.CodeAnalysis.Rope
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 5239, 5250);
                        return return_v;
                    }


                    string
                    f_111_5239_5255(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 5239, 5255);
                        return return_v;
                    }


                    System.Exception
                    f_111_5204_5256(string
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 5204, 5256);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 4489, 5314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 4489, 5314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConcatRope()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(111, 3221, 5325);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(111, 3221, 5325);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 3221, 5325);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(111, 3221, 5325);

            static int
            f_111_3539_3550(Microsoft.CodeAnalysis.Rope
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 3539, 3550);
                return return_v;
            }


            static int
            f_111_3553_3565(Microsoft.CodeAnalysis.Rope
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 3553, 3565);
                return return_v;
            }

        }

        static Rope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(111, 519, 5332);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 592, 613);
            Empty = f_111_600_613(""); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(111, 519, 5332);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 519, 5332);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(111, 519, 5332);

        static Microsoft.CodeAnalysis.Rope
        f_111_600_613(string
        s)
        {
            var return_v = ForString(s);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 600, 613);
            return return_v;
        }

    }
}
