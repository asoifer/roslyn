// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Roslyn.Utilities
{
    internal static class InterlockedOperations
    {
        public static T Initialize<T>([NotNull] ref T? target, T value) where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(338, 1206, 1447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(338, 1310, 1353);

                f_338_1310_1352((object?)value != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(338, 1367, 1436);

                return f_338_1374_1426(ref target, value, null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<T?>(338, 1374, 1435) ?? value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(338, 1206, 1447);

                int
                f_338_1310_1352(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(338, 1310, 1352);
                    return 0;
                }


                T?
                f_338_1374_1426(ref T?
                location1, T
                value, T?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(338, 1374, 1426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(338, 1206, 1447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(338, 1206, 1447);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "initializedValue")]
        public static T Initialize<T>(ref T target, T initializedValue, T uninitializedValue) where T : class?
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(338, 2387, 2854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(338, 2585, 2647);

                f_338_2585_2646((object?)initializedValue != uninitializedValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(338, 2661, 2752);

                T
                oldValue = f_338_2674_2751(ref target, initializedValue, uninitializedValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(338, 2766, 2843);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(338, 2773, 2812) || (((object?)oldValue == uninitializedValue && DynAbs.Tracing.TraceSender.Conditional_F2(338, 2815, 2831)) || DynAbs.Tracing.TraceSender.Conditional_F3(338, 2834, 2842))) ? initializedValue : oldValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(338, 2387, 2854);

                int
                f_338_2585_2646(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(338, 2585, 2646);
                    return 0;
                }


                T
                f_338_2674_2751(ref T?
                location1, T?
                value, T?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(338, 2674, 2751);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(338, 2387, 2854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(338, 2387, 2854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> Initialize<T>(ref ImmutableArray<T> target, ImmutableArray<T> initializedValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(338, 3595, 3989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(338, 3731, 3773);

                f_338_3731_3772(f_338_3744_3771_M(!initializedValue.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(338, 3787, 3908);

                var
                oldValue = f_338_3802_3907(ref target, initializedValue, default(ImmutableArray<T>))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(338, 3922, 3978);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(338, 3929, 3947) || ((oldValue.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(338, 3950, 3966)) || DynAbs.Tracing.TraceSender.Conditional_F3(338, 3969, 3977))) ? initializedValue : oldValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(338, 3595, 3989);

                bool
                f_338_3744_3771_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(338, 3744, 3771);
                    return return_v;
                }


                int
                f_338_3731_3772(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(338, 3731, 3772);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_338_3802_3907(ref System.Collections.Immutable.ImmutableArray<T>
                location, System.Collections.Immutable.ImmutableArray<T>
                value, System.Collections.Immutable.ImmutableArray<T>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(338, 3802, 3907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(338, 3595, 3989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(338, 3595, 3989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static InterlockedOperations()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(338, 374, 3996);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(338, 374, 3996);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(338, 374, 3996);
        }

    }
}
