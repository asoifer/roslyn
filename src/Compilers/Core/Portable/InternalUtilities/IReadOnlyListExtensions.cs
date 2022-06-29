// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal static class IReadOnlyListExtensions
    {
        public static bool Contains<T>(this IReadOnlyList<T> list, T item, IEqualityComparer<T>? comparer = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(339, 342, 758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(339, 472, 513);

                comparer ??= f_339_485_512();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(339, 536, 541);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(339, 527, 718) || true) && (i < f_339_547_557(list))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(339, 559, 562)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(339, 527, 718))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(339, 527, 718);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(339, 596, 703) || true) && (f_339_600_630(comparer, item, f_339_622_629(list, i)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(339, 596, 703);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(339, 672, 684);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(339, 596, 703);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(339, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(339, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(339, 734, 747);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(339, 342, 758);

                System.Collections.Generic.EqualityComparer<T>
                f_339_485_512()
                {
                    var return_v = EqualityComparer<T>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(339, 485, 512);
                    return return_v;
                }


                int
                f_339_547_557(System.Collections.Generic.IReadOnlyList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(339, 547, 557);
                    return return_v;
                }


                T?
                f_339_622_629(System.Collections.Generic.IReadOnlyList<T>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(339, 622, 629);
                    return return_v;
                }


                bool
                f_339_600_630(System.Collections.Generic.IEqualityComparer<T>
                this_param, T?
                x, T?
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(339, 600, 630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(339, 342, 758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(339, 342, 758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static IReadOnlyListExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(339, 280, 765);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(339, 280, 765);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(339, 280, 765);
        }

    }
}
