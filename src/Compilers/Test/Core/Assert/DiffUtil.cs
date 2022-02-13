// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public class DiffUtil
    {
        private enum EditKind
        {
            /// <summary>
            /// No change.
            /// </summary>
            None = 0,

            /// <summary>
            /// Node value was updated.
            /// </summary>
            Update = 1,

            /// <summary>
            /// Node was inserted.
            /// </summary>
            Insert = 2,

            /// <summary>
            /// Node was deleted.
            /// </summary>
            Delete = 3,
        }
        private class LCS<T> : LongestCommonSubsequence<IList<T>>
        {
            public static readonly LCS<T> Default;

            private readonly IEqualityComparer<T> _comparer;

            public LCS(IEqualityComparer<T> comparer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25012, 1183, 1293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 1157, 1166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 1257, 1278);

                    _comparer = comparer;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25012, 1183, 1293);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25012, 1183, 1293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 1183, 1293);
                }
            }

            protected override bool ItemsEqual(IList<T> sequenceA, int indexA, IList<T> sequenceB, int indexB)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25012, 1309, 1517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 1440, 1502);

                    return f_25012_1447_1501(_comparer, f_25012_1464_1481(sequenceA, indexA), f_25012_1483_1500(sequenceB, indexB));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25012, 1309, 1517);

                    T
                    f_25012_1464_1481(System.Collections.Generic.IList<T>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25012, 1464, 1481);
                        return return_v;
                    }


                    T
                    f_25012_1483_1500(System.Collections.Generic.IList<T>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25012, 1483, 1500);
                        return return_v;
                    }


                    bool
                    f_25012_1447_1501(System.Collections.Generic.IEqualityComparer<T>
                    this_param, T
                    x, T
                    y)
                    {
                        var return_v = this_param.Equals(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 1447, 1501);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25012, 1309, 1517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 1309, 1517);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public IEnumerable<string> CalculateDiff(IList<T> sequenceA, IList<T> sequenceB, Func<T, string> toString)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25012, 1533, 2415);

                    var listYield = new List<String>();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 1672, 2400);
                        foreach (var edit in f_25012_1693_1767_I(f_25012_1693_1767(f_25012_1693_1757(this, sequenceA, f_25012_1713_1728(sequenceA), sequenceB, f_25012_1741_1756(sequenceB)))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 1672, 2400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 1809, 2381);

                            switch (edit.Kind)
                            {

                                case EditKind.Delete:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 1809, 2381);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 1927, 1982);

                                    listYield.Add("--> " + f_25012_1949_1981(toString, f_25012_1958_1980(sequenceA, edit.IndexA)));
                                    DynAbs.Tracing.TraceSender.TraceBreak(25012, 2012, 2018);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 1809, 2381);

                                case EditKind.Insert:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 1809, 2381);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 2097, 2152);

                                    listYield.Add("++> " + f_25012_2119_2151(toString, f_25012_2128_2150(sequenceB, edit.IndexB)));
                                    DynAbs.Tracing.TraceSender.TraceBreak(25012, 2182, 2188);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 1809, 2381);

                                case EditKind.Update:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 1809, 2381);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 2267, 2322);

                                    listYield.Add("    " + f_25012_2289_2321(toString, f_25012_2298_2320(sequenceB, edit.IndexB)));
                                    DynAbs.Tracing.TraceSender.TraceBreak(25012, 2352, 2358);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 1809, 2381);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 1672, 2400);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25012, 1, 729);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25012, 1, 729);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25012, 1533, 2415);

                    return listYield;

                    int
                    f_25012_1713_1728(System.Collections.Generic.IList<T>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25012, 1713, 1728);
                        return return_v;
                    }


                    int
                    f_25012_1741_1756(System.Collections.Generic.IList<T>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25012, 1741, 1756);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<System.Collections.Generic.IList<T>>.Edit>
                    f_25012_1693_1757(Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LCS<T>
                    this_param, System.Collections.Generic.IList<T>
                    sequenceA, int
                    lengthA, System.Collections.Generic.IList<T>
                    sequenceB, int
                    lengthB)
                    {
                        var return_v = this_param.GetEdits(sequenceA, lengthA, sequenceB, lengthB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 1693, 1757);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<System.Collections.Generic.IList<T>>.Edit>
                    f_25012_1693_1767(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<System.Collections.Generic.IList<T>>.Edit>
                    source)
                    {
                        var return_v = source.Reverse<Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<System.Collections.Generic.IList<T>>.Edit>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 1693, 1767);
                        return return_v;
                    }


                    T
                    f_25012_1958_1980(System.Collections.Generic.IList<T>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25012, 1958, 1980);
                        return return_v;
                    }


                    string
                    f_25012_1949_1981(System.Func<T, string>
                    this_param, T
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 1949, 1981);
                        return return_v;
                    }


                    T
                    f_25012_2128_2150(System.Collections.Generic.IList<T>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25012, 2128, 2150);
                        return return_v;
                    }


                    string
                    f_25012_2119_2151(System.Func<T, string>
                    this_param, T
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 2119, 2151);
                        return return_v;
                    }


                    T
                    f_25012_2298_2320(System.Collections.Generic.IList<T>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25012, 2298, 2320);
                        return return_v;
                    }


                    string
                    f_25012_2289_2321(System.Func<T, string>
                    this_param, T
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 2289, 2321);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<System.Collections.Generic.IList<T>>.Edit>
                    f_25012_1693_1767_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<System.Collections.Generic.IList<T>>.Edit>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 1693, 1767);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25012, 1533, 2415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 1533, 2415);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static LCS()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25012, 941, 2426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 1053, 1102);
                Default = f_25012_1063_1102<T>(f_25012_1074_1101<T>()); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25012, 941, 2426);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 941, 2426);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25012, 941, 2426);

            static System.Collections.Generic.EqualityComparer<T>
            f_25012_1074_1101<T>()
            {
                var return_v = EqualityComparer<T>.Default;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25012, 1074, 1101);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LCS<T>
            f_25012_1063_1102<T>(System.Collections.Generic.EqualityComparer<T>
            comparer)
            {
                var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LCS<T>((System.Collections.Generic.IEqualityComparer<T>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 1063, 1102);
                return return_v;
            }

        }

        public static string DiffReport<T>(IEnumerable<T> expected, IEnumerable<T> actual, string separator, IEqualityComparer<T> comparer = null, Func<T, string> toString = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25012, 2438, 3059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 2634, 2703);

                var
                lcs = (DynAbs.Tracing.TraceSender.Conditional_F1(25012, 2644, 2662) || (((comparer != null) && DynAbs.Tracing.TraceSender.Conditional_F2(25012, 2665, 2685)) || DynAbs.Tracing.TraceSender.Conditional_F3(25012, 2688, 2702))) ? f_25012_2665_2685<T>(comparer) : LCS<T>.Default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 2717, 2783);

                toString = toString ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Func<T, string>?>(25012, 2728, 2782) ?? new Func<T, string>(obj => obj.ToString()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 2799, 2869);

                IList<T>
                expectedList = expected as IList<T> ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IList<T>?>(25012, 2823, 2868) ?? f_25012_2847_2868<T>(expected))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 2883, 2947);

                IList<T>
                actualList = actual as IList<T> ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IList<T>?>(25012, 2905, 2946) ?? f_25012_2927_2946<T>(actual))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 2963, 3048);

                return f_25012_2970_3047<T>(separator, f_25012_2993_3046<T>(lcs, expectedList, actualList, toString));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25012, 2438, 3059);

                Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LCS<T>
                f_25012_2665_2685<T>(System.Collections.Generic.IEqualityComparer<T>
                comparer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LCS<T>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 2665, 2685);
                    return return_v;
                }


                System.Collections.Generic.List<T>
                f_25012_2847_2868<T>(System.Collections.Generic.IEnumerable<T>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<T>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 2847, 2868);
                    return return_v;
                }


                System.Collections.Generic.List<T>
                f_25012_2927_2946<T>(System.Collections.Generic.IEnumerable<T>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<T>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 2927, 2946);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25012_2993_3046<T>(Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LCS<T>
                this_param, System.Collections.Generic.IList<T>
                sequenceA, System.Collections.Generic.IList<T>
                sequenceB, System.Func<T, string>
                toString)
                {
                    var return_v = this_param.CalculateDiff(sequenceA, sequenceB, toString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 2993, 3046);
                    return return_v;
                }


                string
                f_25012_2970_3047<T>(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 2970, 3047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25012, 2438, 3059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 2438, 3059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly char[] s_lineSplitChars;

        public static string[] Lines(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25012, 3154, 3300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 3217, 3289);

                return f_25012_3224_3288(s, s_lineSplitChars, StringSplitOptions.RemoveEmptyEntries);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25012, 3154, 3300);

                string[]
                f_25012_3224_3288(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 3224, 3288);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25012, 3154, 3300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 3154, 3300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string DiffReport(string expected, string actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25012, 3312, 3565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 3400, 3430);

                var
                exlines = f_25012_3414_3429(expected)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 3444, 3472);

                var
                aclines = f_25012_3458_3471(actual)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 3486, 3554);

                return f_25012_3493_3553(exlines, aclines, separator: f_25012_3533_3552());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25012, 3312, 3565);

                string[]
                f_25012_3414_3429(string
                s)
                {
                    var return_v = Lines(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 3414, 3429);
                    return return_v;
                }


                string[]
                f_25012_3458_3471(string
                s)
                {
                    var return_v = Lines(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 3458, 3471);
                    return return_v;
                }


                string
                f_25012_3533_3552()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25012, 3533, 3552);
                    return return_v;
                }


                string
                f_25012_3493_3553(string[]
                expected, string[]
                actual, string
                separator)
                {
                    var return_v = DiffReport((System.Collections.Generic.IEnumerable<string>)expected, (System.Collections.Generic.IEnumerable<string>)actual, separator: separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 3493, 3553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25012, 3312, 3565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 3312, 3565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private abstract class LongestCommonSubsequence<TSequence>
        {
            protected struct Edit
            {

                public readonly EditKind Kind;

                public readonly int IndexA;

                public readonly int IndexB;

                internal Edit(EditKind kind, int indexA, int indexB)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(25012, 3953, 4168);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4046, 4063);

                        this.Kind = kind;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4085, 4106);

                        this.IndexA = indexA;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4128, 4149);

                        this.IndexB = indexB;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(25012, 3953, 4168);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25012, 3953, 4168);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 3953, 4168);
                    }
                }
                static Edit()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25012, 3759, 4183);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25012, 3759, 4183);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 3759, 4183);
                }
            }

            private const int
            DeleteCost = 1
            ;

            private const int
            InsertCost = 1
            ;

            private const int
            UpdateCost = 2
            ;

            protected abstract bool ItemsEqual(TSequence sequenceA, int indexA, TSequence sequenceB, int indexB);

            protected IEnumerable<KeyValuePair<int, int>> GetMatchingPairs(TSequence sequenceA, int lengthA, TSequence sequenceB, int lengthB)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25012, 4459, 5341);

                    var listYield = new List<KeyValuePair<Int32, Int32>>();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4622, 4691);

                    int[,]
                    d = f_25012_4633_4690(this, sequenceA, lengthA, sequenceB, lengthB)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4709, 4725);

                    int
                    i = lengthA
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4743, 4759);

                    int
                    j = lengthB
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4779, 5326) || true) && (i != 0 && (DynAbs.Tracing.TraceSender.Expression_True(25012, 4786, 4802) && j != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 4779, 5326);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4844, 5307) || true) && (d[i, j] == d[i - 1, j] + DeleteCost)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 4844, 5307);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4933, 4937);

                                i--;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 4844, 5307);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 4844, 5307);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4987, 5307) || true) && (d[i, j] == d[i, j - 1] + InsertCost)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 4987, 5307);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5076, 5080);

                                    j--;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 4987, 5307);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 4987, 5307);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5178, 5182);

                                    i--;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5208, 5212);

                                    j--;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5238, 5284);

                                    listYield.Add(f_25012_5251_5283(i, j));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 4987, 5307);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 4844, 5307);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 4779, 5326);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25012, 4779, 5326);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25012, 4779, 5326);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25012, 4459, 5341);

                    return listYield;

                    int[,]
                    f_25012_4633_4690(Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>
                    this_param, TSequence
                    sequenceA, int
                    lengthA, TSequence
                    sequenceB, int
                    lengthB)
                    {
                        var return_v = this_param.ComputeCostMatrix(sequenceA, lengthA, sequenceB, lengthB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 4633, 4690);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<int, int>
                    f_25012_5251_5283(int
                    key, int
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<int, int>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 5251, 5283);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25012, 4459, 5341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 4459, 5341);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected IEnumerable<Edit> GetEdits(TSequence sequenceA, int lengthA, TSequence sequenceB, int lengthB)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25012, 5357, 6686);

                    var listYield = new List<Edit>();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5494, 5563);

                    int[,]
                    d = f_25012_5505_5562(this, sequenceA, lengthA, sequenceB, lengthB)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5581, 5597);

                    int
                    i = lengthA
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5615, 5631);

                    int
                    j = lengthB
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5651, 6341) || true) && (i != 0 && (DynAbs.Tracing.TraceSender.Expression_True(25012, 5658, 5674) && j != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 5651, 6341);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5716, 6322) || true) && (d[i, j] == d[i - 1, j] + DeleteCost)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 5716, 6322);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5805, 5809);

                                i--;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5835, 5881);

                                listYield.Add(f_25012_5848_5880(EditKind.Delete, i, -1));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 5716, 6322);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 5716, 6322);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 5931, 6322) || true) && (d[i, j] == d[i, j - 1] + InsertCost)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 5931, 6322);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 6020, 6024);

                                    j--;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 6050, 6096);

                                    listYield.Add(f_25012_6063_6095(EditKind.Insert, -1, j));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 5931, 6322);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 5931, 6322);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 6194, 6198);

                                    i--;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 6224, 6228);

                                    j--;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 6254, 6299);

                                    listYield.Add(f_25012_6267_6298(EditKind.Update, i, j));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 5931, 6322);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 5716, 6322);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 5651, 6341);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25012, 5651, 6341);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25012, 5651, 6341);
                    }
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 6361, 6506) || true) && (i > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 6361, 6506);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 6415, 6419);

                            i--;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 6441, 6487);

                            listYield.Add(f_25012_6454_6486(EditKind.Delete, i, -1));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 6361, 6506);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25012, 6361, 6506);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25012, 6361, 6506);
                    }
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 6526, 6671) || true) && (j > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 6526, 6671);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 6580, 6584);

                            j--;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 6606, 6652);

                            listYield.Add(f_25012_6619_6651(EditKind.Insert, -1, j));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 6526, 6671);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25012, 6526, 6671);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25012, 6526, 6671);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25012, 5357, 6686);

                    return listYield;

                    int[,]
                    f_25012_5505_5562(Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>
                    this_param, TSequence
                    sequenceA, int
                    lengthA, TSequence
                    sequenceB, int
                    lengthB)
                    {
                        var return_v = this_param.ComputeCostMatrix(sequenceA, lengthA, sequenceB, lengthB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 5505, 5562);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>.Edit
                    f_25012_5848_5880(Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.EditKind
                    kind, int
                    indexA, int
                    indexB)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>.Edit(kind, indexA, indexB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 5848, 5880);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>.Edit
                    f_25012_6063_6095(Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.EditKind
                    kind, int
                    indexA, int
                    indexB)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>.Edit(kind, indexA, indexB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 6063, 6095);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>.Edit
                    f_25012_6267_6298(Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.EditKind
                    kind, int
                    indexA, int
                    indexB)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>.Edit(kind, indexA, indexB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 6267, 6298);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>.Edit
                    f_25012_6454_6486(Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.EditKind
                    kind, int
                    indexA, int
                    indexB)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>.Edit(kind, indexA, indexB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 6454, 6486);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>.Edit
                    f_25012_6619_6651(Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.EditKind
                    kind, int
                    indexA, int
                    indexB)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>.Edit(kind, indexA, indexB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 6619, 6651);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25012, 5357, 6686);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 5357, 6686);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected double ComputeDistance(TSequence sequenceA, int lengthA, TSequence sequenceB, int lengthB)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25012, 7098, 7817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 7231, 7274);

                    f_25012_7231_7273(lengthA >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(25012, 7244, 7272) && lengthB >= 0));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 7294, 7427) || true) && (lengthA == 0 || (DynAbs.Tracing.TraceSender.Expression_False(25012, 7298, 7326) || lengthB == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 7294, 7427);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 7368, 7408);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(25012, 7375, 7395) || (((lengthA == lengthB) && DynAbs.Tracing.TraceSender.Conditional_F2(25012, 7398, 7401)) || DynAbs.Tracing.TraceSender.Conditional_F3(25012, 7404, 7407))) ? 0.0 : 1.0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 7294, 7427);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 7447, 7465);

                    int
                    lcsLength = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 7483, 7633);
                        foreach (var pair in f_25012_7504_7560_I(f_25012_7504_7560(this, sequenceA, lengthA, sequenceB, lengthB)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 7483, 7633);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 7602, 7614);

                            lcsLength++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 7483, 7633);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25012, 1, 151);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25012, 1, 151);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 7653, 7690);

                    int
                    max = f_25012_7663_7689(lengthA, lengthB)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 7708, 7739);

                    f_25012_7708_7738(lcsLength <= max);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 7757, 7802);

                    return 1.0 - (double)lcsLength / (double)max;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25012, 7098, 7817);

                    int
                    f_25012_7231_7273(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 7231, 7273);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, int>>
                    f_25012_7504_7560(Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>
                    this_param, TSequence
                    sequenceA, int
                    lengthA, TSequence
                    sequenceB, int
                    lengthB)
                    {
                        var return_v = this_param.GetMatchingPairs(sequenceA, lengthA, sequenceB, lengthB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 7504, 7560);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, int>>
                    f_25012_7504_7560_I(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, int>>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 7504, 7560);
                        return return_v;
                    }


                    int
                    f_25012_7663_7689(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Max(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 7663, 7689);
                        return return_v;
                    }


                    int
                    f_25012_7708_7738(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 7708, 7738);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25012, 7098, 7817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 7098, 7817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private int[,] ComputeCostMatrix(TSequence sequenceA, int lengthA, TSequence sequenceB, int lengthB)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25012, 9369, 10636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 9502, 9523);

                    var
                    la = lengthA + 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 9541, 9562);

                    var
                    lb = lengthB + 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 9740, 9764);

                    var
                    d = new int[la, lb]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 9784, 9796);

                    d[0, 0] = 0;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 9823, 9828);
                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 9814, 9943) || true) && (i <= lengthA)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 9844, 9847)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 9814, 9943))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 9814, 9943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 9889, 9924);

                            d[i, 0] = d[i - 1, 0] + DeleteCost;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25012, 1, 130);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25012, 1, 130);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 9972, 9977);

                        for (int
        j = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 9963, 10092) || true) && (j <= lengthB)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 9993, 9996)
        , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 9963, 10092))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 9963, 10092);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10038, 10073);

                            d[0, j] = d[0, j - 1] + InsertCost;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25012, 1, 130);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25012, 1, 130);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10121, 10126);

                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10112, 10592) || true) && (i <= lengthA)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10142, 10145)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 10112, 10592))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 10112, 10592);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10196, 10201);
                                for (int
            j = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10187, 10573) || true) && (j <= lengthB)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10217, 10220)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(25012, 10187, 10573))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25012, 10187, 10573);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10270, 10363);

                                    int
                                    m1 = d[i - 1, j - 1] + ((DynAbs.Tracing.TraceSender.Conditional_F1(25012, 10298, 10344) || ((f_25012_10298_10344(this, sequenceA, i - 1, sequenceB, j - 1) && DynAbs.Tracing.TraceSender.Conditional_F2(25012, 10347, 10348)) || DynAbs.Tracing.TraceSender.Conditional_F3(25012, 10351, 10361))) ? 0 : UpdateCost)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10389, 10423);

                                    int
                                    m2 = d[i - 1, j] + DeleteCost
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10449, 10483);

                                    int
                                    m3 = d[i, j - 1] + InsertCost
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10509, 10550);

                                    d[i, j] = f_25012_10519_10549(f_25012_10528_10544(m1, m2), m3);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25012, 1, 387);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25012, 1, 387);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25012, 1, 481);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25012, 1, 481);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 10612, 10621);

                    return d;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25012, 9369, 10636);

                    bool
                    f_25012_10298_10344(Microsoft.CodeAnalysis.Test.Utilities.DiffUtil.LongestCommonSubsequence<TSequence>
                    this_param, TSequence
                    sequenceA, int
                    indexA, TSequence
                    sequenceB, int
                    indexB)
                    {
                        var return_v = this_param.ItemsEqual(sequenceA, indexA, sequenceB, indexB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 10298, 10344);
                        return return_v;
                    }


                    int
                    f_25012_10528_10544(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 10528, 10544);
                        return return_v;
                    }


                    int
                    f_25012_10519_10549(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25012, 10519, 10549);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25012, 9369, 10636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 9369, 10636);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LongestCommonSubsequence()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25012, 3676, 10647);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25012, 3676, 10647);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 3676, 10647);
            }


            static LongestCommonSubsequence()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25012, 3676, 10647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4217, 4231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4264, 4278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 4311, 4325);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25012, 3676, 10647);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 3676, 10647);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25012, 3676, 10647);
        }

        public DiffUtil()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25012, 384, 10654);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25012, 384, 10654);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 384, 10654);
        }


        static DiffUtil()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25012, 384, 10654);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25012, 3102, 3141);
            s_lineSplitChars = new[] { '\r', '\n' }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25012, 384, 10654);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25012, 384, 10654);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25012, 384, 10654);
    }
}
