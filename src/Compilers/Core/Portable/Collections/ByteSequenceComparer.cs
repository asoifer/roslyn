// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Collections
{
    internal sealed class ByteSequenceComparer : IEqualityComparer<byte[]>, IEqualityComparer<ImmutableArray<byte>>
    {
        internal static readonly ByteSequenceComparer Instance;

        private ByteSequenceComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(95, 722, 774);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(95, 722, 774);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(95, 722, 774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(95, 722, 774);
            }
        }

        internal static bool Equals(ImmutableArray<byte> x, ImmutableArray<byte> y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(95, 786, 1316);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 886, 957) || true) && (x == y)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 886, 957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 930, 942);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(95, 886, 957);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 973, 1089) || true) && (x.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(95, 977, 1003) || y.IsDefault) || (DynAbs.Tracing.TraceSender.Expression_False(95, 977, 1027) || x.Length != y.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 973, 1089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1061, 1074);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(95, 973, 1089);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1114, 1119);

                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1105, 1277) || true) && (i < x.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1135, 1138)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(95, 1105, 1277))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 1105, 1277);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1172, 1262) || true) && (x[i] != y[i])
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 1172, 1262);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1230, 1243);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(95, 1172, 1262);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(95, 1, 173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(95, 1, 173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1293, 1305);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(95, 786, 1316);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(95, 786, 1316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(95, 786, 1316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool Equals(byte[]? left, int leftStart, byte[]? right, int rightStart, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(95, 1328, 1963);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1452, 1570) || true) && (left == null || (DynAbs.Tracing.TraceSender.Expression_False(95, 1456, 1485) || right == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 1452, 1570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1519, 1555);

                    return f_95_1526_1554(left, right);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(95, 1452, 1570);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1586, 1706) || true) && (f_95_1590_1618(left, right) && (DynAbs.Tracing.TraceSender.Expression_True(95, 1590, 1645) && leftStart == rightStart))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 1586, 1706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1679, 1691);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(95, 1586, 1706);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1731, 1736);

                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1722, 1924) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1750, 1753)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(95, 1722, 1924))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 1722, 1924);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1787, 1909) || true) && (left[leftStart + i] != right[rightStart + i])
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 1787, 1909);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1877, 1890);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(95, 1787, 1909);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(95, 1, 203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(95, 1, 203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 1940, 1952);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(95, 1328, 1963);

                bool
                f_95_1526_1554(byte[]?
                objA, byte[]?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 1526, 1554);
                    return return_v;
                }


                bool
                f_95_1590_1618(byte[]
                objA, byte[]
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 1590, 1618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(95, 1328, 1963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(95, 1328, 1963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool Equals(byte[]? left, byte[]? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(95, 1975, 2528);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2056, 2149) || true) && (f_95_2060_2088(left, right))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 2056, 2149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2122, 2134);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(95, 2056, 2149);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2165, 2291) || true) && (left == null || (DynAbs.Tracing.TraceSender.Expression_False(95, 2169, 2198) || right == null) || (DynAbs.Tracing.TraceSender.Expression_False(95, 2169, 2229) || f_95_2202_2213(left) != f_95_2217_2229(right)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 2165, 2291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2263, 2276);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(95, 2165, 2291);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2316, 2321);

                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2307, 2489) || true) && (i < f_95_2327_2338(left))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2340, 2343)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(95, 2307, 2489))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 2307, 2489);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2377, 2474) || true) && (left[i] != right[i])
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(95, 2377, 2474);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2442, 2455);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(95, 2377, 2474);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(95, 1, 183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(95, 1, 183);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2505, 2517);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(95, 1975, 2528);

                bool
                f_95_2060_2088(byte[]?
                objA, byte[]?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 2060, 2088);
                    return return_v;
                }


                int
                f_95_2202_2213(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(95, 2202, 2213);
                    return return_v;
                }


                int
                f_95_2217_2229(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(95, 2217, 2229);
                    return return_v;
                }


                int
                f_95_2327_2338(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(95, 2327, 2338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(95, 1975, 2528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(95, 1975, 2528);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetHashCode(byte[] x)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(95, 2685, 2836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2751, 2781);

                f_95_2751_2780(x != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2795, 2825);

                return f_95_2802_2824(x);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(95, 2685, 2836);

                int
                f_95_2751_2780(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 2751, 2780);
                    return 0;
                }


                int
                f_95_2802_2824(byte[]
                data)
                {
                    var return_v = Hash.GetFNVHashCode(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 2802, 2824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(95, 2685, 2836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(95, 2685, 2836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetHashCode(ImmutableArray<byte> x)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(95, 2848, 3010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2928, 2955);

                f_95_2928_2954(f_95_2941_2953_M(!x.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 2969, 2999);

                return f_95_2976_2998(x);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(95, 2848, 3010);

                bool
                f_95_2941_2953_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(95, 2941, 2953);
                    return return_v;
                }


                int
                f_95_2928_2954(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 2928, 2954);
                    return 0;
                }


                int
                f_95_2976_2998(System.Collections.Immutable.ImmutableArray<byte>
                data)
                {
                    var return_v = Hash.GetFNVHashCode(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 2976, 2998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(95, 2848, 3010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(95, 2848, 3010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool IEqualityComparer<byte[]>.Equals(byte[]? x, byte[]? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(95, 3022, 3137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 3106, 3126);

                return f_95_3113_3125(x, y);
                DynAbs.Tracing.TraceSender.TraceExitMethod(95, 3022, 3137);

                bool
                f_95_3113_3125(byte[]?
                left, byte[]?
                right)
                {
                    var return_v = Equals(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 3113, 3125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(95, 3022, 3137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(95, 3022, 3137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int IEqualityComparer<byte[]>.GetHashCode(byte[] x)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(95, 3149, 3258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 3225, 3247);

                return f_95_3232_3246(x);
                DynAbs.Tracing.TraceSender.TraceExitMethod(95, 3149, 3258);

                int
                f_95_3232_3246(byte[]
                x)
                {
                    var return_v = GetHashCode(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 3232, 3246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(95, 3149, 3258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(95, 3149, 3258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool IEqualityComparer<ImmutableArray<byte>>.Equals(ImmutableArray<byte> x, ImmutableArray<byte> y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(95, 3270, 3425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 3394, 3414);

                return f_95_3401_3413(x, y);
                DynAbs.Tracing.TraceSender.TraceExitMethod(95, 3270, 3425);

                bool
                f_95_3401_3413(System.Collections.Immutable.ImmutableArray<byte>
                x, System.Collections.Immutable.ImmutableArray<byte>
                y)
                {
                    var return_v = Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 3401, 3413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(95, 3270, 3425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(95, 3270, 3425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int IEqualityComparer<ImmutableArray<byte>>.GetHashCode(ImmutableArray<byte> x)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(95, 3437, 3574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 3541, 3563);

                return f_95_3548_3562(x);
                DynAbs.Tracing.TraceSender.TraceExitMethod(95, 3437, 3574);

                int
                f_95_3548_3562(System.Collections.Immutable.ImmutableArray<byte>
                x)
                {
                    var return_v = GetHashCode(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 3548, 3562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(95, 3437, 3574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(95, 3437, 3574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ByteSequenceComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(95, 498, 3581);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(95, 672, 709);
            Instance = f_95_683_709(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(95, 498, 3581);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(95, 498, 3581);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(95, 498, 3581);

        static Microsoft.CodeAnalysis.Collections.ByteSequenceComparer
        f_95_683_709()
        {
            var return_v = new Microsoft.CodeAnalysis.Collections.ByteSequenceComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(95, 683, 709);
            return return_v;
        }

    }
}
