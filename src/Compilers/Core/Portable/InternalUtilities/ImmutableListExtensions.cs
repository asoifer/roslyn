// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Roslyn.Utilities
{
    internal static class ImmutableListExtensions
    {
        internal static ImmutableList<T> ToImmutableListOrEmpty<T>(this T[]? items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(334, 379, 643);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(334, 479, 578) || true) && (items == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(334, 479, 578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(334, 530, 563);

                    return f_334_537_562();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(334, 479, 578);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(334, 594, 632);

                return f_334_601_631(items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(334, 379, 643);

                System.Collections.Immutable.ImmutableList<T>
                f_334_537_562()
                {
                    var return_v = ImmutableList.Create<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(334, 537, 562);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableList<T>
                f_334_601_631(params T[]
                items)
                {
                    var return_v = ImmutableList.Create<T>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(334, 601, 631);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(334, 379, 643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(334, 379, 643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableList<T> ToImmutableListOrEmpty<T>(this IEnumerable<T>? items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(334, 655, 935);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(334, 766, 865) || true) && (items == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(334, 766, 865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(334, 817, 850);

                    return f_334_824_849();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(334, 766, 865);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(334, 881, 924);

                return f_334_888_923(items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(334, 655, 935);

                System.Collections.Immutable.ImmutableList<T>
                f_334_824_849()
                {
                    var return_v = ImmutableList.Create<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(334, 824, 849);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableList<T>
                f_334_888_923(System.Collections.Generic.IEnumerable<T>
                items)
                {
                    var return_v = ImmutableList.CreateRange<T>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(334, 888, 923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(334, 655, 935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(334, 655, 935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ImmutableListExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(334, 317, 942);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(334, 317, 942);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(334, 317, 942);
        }

    }
}
