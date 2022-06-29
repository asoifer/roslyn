// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Roslyn.Utilities
{
    internal static class RoslynLazyInitializer
    {
        public static T EnsureInitialized<T>([NotNull] ref T? target) where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(361, 554, 606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(361, 557, 606);
                return f_361_557_606(ref target!); DynAbs.Tracing.TraceSender.TraceExitMethod(361, 554, 606);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(361, 554, 606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(361, 554, 606);
            }
            throw new System.Exception("Slicer error: unreachable code");

            T
            f_361_557_606(ref T
            target)
            {
                var return_v = LazyInitializer.EnsureInitialized<T>(ref target);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(361, 557, 606);
                return return_v;
            }

        }

        public static T EnsureInitialized<T>([NotNull] ref T? target, Func<T> valueFactory) where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(361, 819, 885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(361, 822, 885);
                return f_361_822_885(ref target!, valueFactory); DynAbs.Tracing.TraceSender.TraceExitMethod(361, 819, 885);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(361, 819, 885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(361, 819, 885);
            }
            throw new System.Exception("Slicer error: unreachable code");

            T
            f_361_822_885(ref T
            target, System.Func<T>
            valueFactory)
            {
                var return_v = LazyInitializer.EnsureInitialized<T>(ref target, valueFactory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(361, 822, 885);
                return return_v;
            }

        }

        public static T EnsureInitialized<T>([NotNull] ref T? target, ref bool initialized, [NotNull] ref object? syncLock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(361, 1127, 1210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(361, 1130, 1210);
                return f_361_1130_1210(ref target!, ref initialized, ref syncLock); DynAbs.Tracing.TraceSender.TraceExitMethod(361, 1127, 1210);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(361, 1127, 1210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(361, 1127, 1210);
            }
            throw new System.Exception("Slicer error: unreachable code");

            T
            f_361_1130_1210(ref T
            target, ref bool
            initialized, ref object?
            syncLock)
            {
                var return_v = LazyInitializer.EnsureInitialized<T>(ref target, ref initialized, ref syncLock);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(361, 1130, 1210);
                return return_v;
            }

        }

        public static T EnsureInitialized<T>([NotNull] ref T? target, ref bool initialized, [NotNull] ref object? syncLock, Func<T> valueFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(361, 1483, 1580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(361, 1486, 1580);
                return f_361_1486_1580(ref target!, ref initialized, ref syncLock, valueFactory); DynAbs.Tracing.TraceSender.TraceExitMethod(361, 1483, 1580);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(361, 1483, 1580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(361, 1483, 1580);
            }
            throw new System.Exception("Slicer error: unreachable code");

            T
            f_361_1486_1580(ref T
            target, ref bool
            initialized, ref object?
            syncLock, System.Func<T>
            valueFactory)
            {
                var return_v = LazyInitializer.EnsureInitialized<T>(ref target, ref initialized, ref syncLock, valueFactory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(361, 1486, 1580);
                return return_v;
            }

        }

        static RoslynLazyInitializer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(361, 325, 1588);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(361, 325, 1588);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(361, 325, 1588);
        }

    }
}
