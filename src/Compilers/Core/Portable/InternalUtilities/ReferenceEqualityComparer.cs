// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Roslyn.Utilities
{
    internal class ReferenceEqualityComparer : IEqualityComparer<object?>
    {
        public static readonly ReferenceEqualityComparer Instance;

        private ReferenceEqualityComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(359, 586, 643);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(359, 586, 643);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(359, 586, 643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(359, 586, 643);
            }
        }

        bool IEqualityComparer<object?>.Equals(object? a, object? b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(359, 655, 765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(359, 740, 754);

                return a == b;
                DynAbs.Tracing.TraceSender.TraceExitMethod(359, 655, 765);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(359, 655, 765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(359, 655, 765);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int IEqualityComparer<object?>.GetHashCode(object? a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(359, 777, 914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(359, 855, 903);

                return f_359_862_902(a);
                DynAbs.Tracing.TraceSender.TraceExitMethod(359, 777, 914);

                int
                f_359_862_902(object?
                a)
                {
                    var return_v = ReferenceEqualityComparer.GetHashCode(a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(359, 862, 902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(359, 777, 914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(359, 777, 914);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int GetHashCode(object? a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(359, 926, 1102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(359, 1053, 1091);

                return f_359_1060_1090(a!);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(359, 926, 1102);

                int
                f_359_1060_1090(object
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(359, 1060, 1090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(359, 926, 1102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(359, 926, 1102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ReferenceEqualityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(359, 422, 1109);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(359, 557, 573);
            Instance = f_359_568_573();
            static Roslyn.Utilities.ReferenceEqualityComparer
f_359_568_573()
            {
                var return_v = new Roslyn.Utilities.ReferenceEqualityComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(359, 568, 573);
                return return_v;
            }
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(359, 422, 1109);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(359, 422, 1109);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(359, 422, 1109);
    }
}
