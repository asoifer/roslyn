// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal static class ConsListExtensions
    {
        public static ConsList<T> Prepend<T>(this ConsList<T>? list, T head)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(99, 461, 621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(99, 554, 610);

                return f_99_561_609(head, list ?? (DynAbs.Tracing.TraceSender.Expression_Null<Roslyn.Utilities.ConsList<T>?>(99, 583, 608) ?? ConsList<T>.Empty));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(99, 461, 621);

                Roslyn.Utilities.ConsList<T>
                f_99_561_609(T?
                head, Roslyn.Utilities.ConsList<T>
                tail)
                {
                    var return_v = new Roslyn.Utilities.ConsList<T>(head, tail);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(99, 561, 609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(99, 461, 621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(99, 461, 621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ContainsReference<T>(this ConsList<T> list, T element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(99, 633, 982);
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(99, 731, 942) || true) && (list != ConsList<T>.Empty)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(99, 765, 781)
   , list = f_99_772_781(list), DynAbs.Tracing.TraceSender.TraceExitCondition(99, 731, 942))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(99, 731, 942);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(99, 815, 927) || true) && (f_99_819_854(f_99_835_844(list), element))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(99, 815, 927);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(99, 896, 908);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(99, 815, 927);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(99, 1, 212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(99, 1, 212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(99, 958, 971);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(99, 633, 982);

                Roslyn.Utilities.ConsList<T>
                f_99_772_781(Roslyn.Utilities.ConsList<T>
                this_param)
                {
                    var return_v = this_param.Tail;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(99, 772, 781);
                    return return_v;
                }


                T?
                f_99_835_844(Roslyn.Utilities.ConsList<T>
                this_param)
                {
                    var return_v = this_param.Head;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(99, 835, 844);
                    return return_v;
                }


                bool
                f_99_819_854(T?
                objA, T?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(99, 819, 854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(99, 633, 982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(99, 633, 982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ConsListExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(99, 404, 989);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(99, 404, 989);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(99, 404, 989);
        }

    }
}
