// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal sealed class CharMemoryEqualityComparer : IEqualityComparer<ReadOnlyMemory<char>>
    {
        public static readonly CharMemoryEqualityComparer Instance;

        private CharMemoryEqualityComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(311, 620, 660);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(311, 620, 660);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(311, 620, 660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(311, 620, 660);
            }
        }

        public bool Equals(ReadOnlyMemory<char> x, ReadOnlyMemory<char> y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(311, 739, 770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(311, 742, 770);
                return x.Span.SequenceEqual(y.Span); DynAbs.Tracing.TraceSender.TraceExitMethod(311, 739, 770);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(311, 739, 770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(311, 739, 770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(ReadOnlyMemory<char> mem)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(311, 832, 864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(311, 835, 864);
                return f_311_835_864(mem.Span); DynAbs.Tracing.TraceSender.TraceExitMethod(311, 832, 864);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(311, 832, 864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(311, 832, 864);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_311_835_864(System.ReadOnlySpan<char>
            data)
            {
                var return_v = Hash.GetFNVHashCode(data);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(311, 835, 864);
                return return_v;
            }

        }

        static CharMemoryEqualityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(311, 407, 872);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(311, 564, 607);
            Instance = f_311_575_607(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(311, 407, 872);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(311, 407, 872);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(311, 407, 872);

        static Roslyn.Utilities.CharMemoryEqualityComparer
        f_311_575_607()
        {
            var return_v = new Roslyn.Utilities.CharMemoryEqualityComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(311, 575, 607);
            return return_v;
        }

    }
}
