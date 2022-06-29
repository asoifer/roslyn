// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal static partial class SpecializedCollections
    {
        public static IEnumerator<T> EmptyEnumerator<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 349, 470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 423, 459);

                return Empty.Enumerator<T>.Instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 349, 470);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 349, 470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 349, 470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<T> EmptyEnumerable<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 482, 597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 556, 586);

                return Empty.List<T>.Instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 482, 597);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 482, 597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 482, 597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ICollection<T> EmptyCollection<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 609, 724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 683, 713);

                return Empty.List<T>.Instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 609, 724);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 609, 724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 609, 724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IList<T> EmptyList<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 736, 839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 798, 828);

                return Empty.List<T>.Instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 736, 839);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 736, 839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 736, 839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IReadOnlyList<T> EmptyBoxedImmutableArray<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 851, 992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 936, 981);

                return Empty.BoxedImmutableArray<T>.Instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 851, 992);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 851, 992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 851, 992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IReadOnlyList<T> EmptyReadOnlyList<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 1004, 1123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 1082, 1112);

                return Empty.List<T>.Instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 1004, 1123);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 1004, 1123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 1004, 1123);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISet<T> EmptySet<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 1135, 1235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 1195, 1224);

                return Empty.Set<T>.Instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 1135, 1235);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 1135, 1235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 1135, 1235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IReadOnlySet<T> EmptyReadOnlySet<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 1247, 1363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 1323, 1352);

                return Empty.Set<T>.Instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 1247, 1363);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 1247, 1363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 1247, 1363);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IDictionary<TKey, TValue> EmptyDictionary<TKey, TValue>()
                    where TKey : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 1375, 1563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 1505, 1552);

                return Empty.Dictionary<TKey, TValue>.Instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 1375, 1563);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 1375, 1563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 1375, 1563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IReadOnlyDictionary<TKey, TValue> EmptyReadOnlyDictionary<TKey, TValue>()
                    where TKey : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 1575, 1779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 1721, 1768);

                return Empty.Dictionary<TKey, TValue>.Instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 1575, 1779);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 1575, 1779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 1575, 1779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<T> SingletonEnumerable<T>(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 1791, 1923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 1876, 1912);

                return f_368_1883_1911(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 1791, 1923);

                Roslyn.Utilities.SpecializedCollections.Singleton.List<T>
                f_368_1883_1911(T?
                value)
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.Singleton.List<T>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 1883, 1911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 1791, 1923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 1791, 1923);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ICollection<T> SingletonCollection<T>(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 1935, 2067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 2020, 2056);

                return f_368_2027_2055(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 1935, 2067);

                Roslyn.Utilities.SpecializedCollections.Singleton.List<T>
                f_368_2027_2055(T?
                value)
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.Singleton.List<T>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 2027, 2055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 1935, 2067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 1935, 2067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerator<T> SingletonEnumerator<T>(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 2079, 2217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 2164, 2206);

                return f_368_2171_2205(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 2079, 2217);

                Roslyn.Utilities.SpecializedCollections.Singleton.Enumerator<T>
                f_368_2171_2205(T?
                value)
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.Singleton.Enumerator<T>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 2171, 2205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 2079, 2217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 2079, 2217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IReadOnlyList<T> SingletonReadOnlyList<T>(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 2229, 2365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 2318, 2354);

                return f_368_2325_2353(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 2229, 2365);

                Roslyn.Utilities.SpecializedCollections.Singleton.List<T>
                f_368_2325_2353(T?
                value)
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.Singleton.List<T>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 2325, 2353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 2229, 2365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 2229, 2365);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IList<T> SingletonList<T>(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 2377, 2497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 2450, 2486);

                return f_368_2457_2485(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 2377, 2497);

                Roslyn.Utilities.SpecializedCollections.Singleton.List<T>
                f_368_2457_2485(T?
                value)
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.Singleton.List<T>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 2457, 2485);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 2377, 2497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 2377, 2497);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<T> ReadOnlyEnumerable<T>(IEnumerable<T> values)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 2509, 2676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 2607, 2665);

                return f_368_2614_2664(values);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 2509, 2676);

                Roslyn.Utilities.SpecializedCollections.ReadOnly.Enumerable<System.Collections.Generic.IEnumerable<T>, T>
                f_368_2614_2664(System.Collections.Generic.IEnumerable<T>
                underlying)
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.ReadOnly.Enumerable<System.Collections.Generic.IEnumerable<T>, T>(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 2614, 2664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 2509, 2676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 2509, 2676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ICollection<T> ReadOnlyCollection<T>(ICollection<T>? collection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 2688, 2967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 2791, 2956);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(368, 2798, 2841) || ((collection == null || (DynAbs.Tracing.TraceSender.Expression_False(368, 2798, 2841) || f_368_2820_2836(collection) == 0
                ) && DynAbs.Tracing.TraceSender.Conditional_F2(368, 2861, 2881)) || DynAbs.Tracing.TraceSender.Conditional_F3(368, 2901, 2955))) ? f_368_2861_2881() : f_368_2901_2955(collection);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 2688, 2967);

                int
                f_368_2820_2836(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(368, 2820, 2836);
                    return return_v;
                }


                System.Collections.Generic.ICollection<T>
                f_368_2861_2881()
                {
                    var return_v = EmptyCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 2861, 2881);
                    return return_v;
                }


                Roslyn.Utilities.SpecializedCollections.ReadOnly.Collection<System.Collections.Generic.ICollection<T>, T>
                f_368_2901_2955(System.Collections.Generic.ICollection<T>
                underlying)
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.ReadOnly.Collection<System.Collections.Generic.ICollection<T>, T>(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 2901, 2955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 2688, 2967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 2688, 2967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISet<T> ReadOnlySet<T>(ISet<T>? set)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 2979, 3188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 3054, 3177);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(368, 3061, 3090) || ((set == null || (DynAbs.Tracing.TraceSender.Expression_False(368, 3061, 3090) || f_368_3076_3085(set) == 0
                ) && DynAbs.Tracing.TraceSender.Conditional_F2(368, 3110, 3123)) || DynAbs.Tracing.TraceSender.Conditional_F3(368, 3143, 3176))) ? f_368_3110_3123() : f_368_3143_3176(set);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 2979, 3188);

                int
                f_368_3076_3085(System.Collections.Generic.ISet<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(368, 3076, 3085);
                    return return_v;
                }


                System.Collections.Generic.ISet<T>
                f_368_3110_3123()
                {
                    var return_v = EmptySet<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 3110, 3123);
                    return return_v;
                }


                Roslyn.Utilities.SpecializedCollections.ReadOnly.Set<System.Collections.Generic.ISet<T>, T>
                f_368_3143_3176(System.Collections.Generic.ISet<T>
                underlying)
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.ReadOnly.Set<System.Collections.Generic.ISet<T>, T>(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 3143, 3176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 2979, 3188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 2979, 3188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IReadOnlySet<T> StronglyTypedReadOnlySet<T>(ISet<T>? set)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(368, 3200, 3438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(368, 3296, 3427);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(368, 3303, 3332) || ((set == null || (DynAbs.Tracing.TraceSender.Expression_False(368, 3303, 3332) || f_368_3318_3327(set) == 0
                ) && DynAbs.Tracing.TraceSender.Conditional_F2(368, 3352, 3373)) || DynAbs.Tracing.TraceSender.Conditional_F3(368, 3393, 3426))) ? f_368_3352_3373() : f_368_3393_3426(set);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(368, 3200, 3438);

                int
                f_368_3318_3327(System.Collections.Generic.ISet<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(368, 3318, 3327);
                    return return_v;
                }


                Roslyn.Utilities.IReadOnlySet<T>
                f_368_3352_3373()
                {
                    var return_v = EmptyReadOnlySet<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 3352, 3373);
                    return return_v;
                }


                Roslyn.Utilities.SpecializedCollections.ReadOnly.Set<System.Collections.Generic.ISet<T>, T>
                f_368_3393_3426(System.Collections.Generic.ISet<T>
                underlying)
                {
                    var return_v = new Roslyn.Utilities.SpecializedCollections.ReadOnly.Set<System.Collections.Generic.ISet<T>, T>(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(368, 3393, 3426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(368, 3200, 3438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 3200, 3438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SpecializedCollections()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(368, 280, 3445);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(368, 280, 3445);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(368, 280, 3445);
        }

    }
}
