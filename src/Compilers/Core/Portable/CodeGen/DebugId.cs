// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{

    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal struct DebugId : IEquatable<DebugId>
    {

        public const int
        UndefinedOrdinal = -1
        ;

        public readonly int Ordinal;

        public readonly int Generation;

        public DebugId(int ordinal, int generation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(53, 1288, 1551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(53, 1356, 1414);

                f_53_1356_1413(ordinal >= 0 || (DynAbs.Tracing.TraceSender.Expression_False(53, 1369, 1412) || ordinal == UndefinedOrdinal));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(53, 1428, 1458);

                f_53_1428_1457(generation >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(53, 1474, 1497);

                this.Ordinal = ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(53, 1511, 1540);

                this.Generation = generation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(53, 1288, 1551);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(53, 1288, 1551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(53, 1288, 1551);
            }
        }

        public bool Equals(DebugId other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(53, 1563, 1725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(53, 1621, 1714);

                return this.Ordinal == other.Ordinal
                && (DynAbs.Tracing.TraceSender.Expression_True(53, 1628, 1713) && this.Generation == other.Generation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(53, 1563, 1725);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(53, 1563, 1725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(53, 1563, 1725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(53, 1737, 1859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(53, 1802, 1848);

                return obj is DebugId && (DynAbs.Tracing.TraceSender.Expression_True(53, 1809, 1847) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(53, 1737, 1859);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(53, 1737, 1859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(53, 1737, 1859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(53, 1871, 1991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(53, 1929, 1980);

                return f_53_1936_1979(this.Ordinal, this.Generation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(53, 1871, 1991);

                int
                f_53_1936_1979(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(53, 1936, 1979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(53, 1871, 1991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(53, 1871, 1991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(53, 2003, 2148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(53, 2064, 2137);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(53, 2071, 2087) || (((Generation > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(53, 2090, 2115)) || DynAbs.Tracing.TraceSender.Conditional_F3(53, 2118, 2136))) ? $"{Ordinal}#{Generation}" : f_53_2118_2136(Ordinal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(53, 2003, 2148);

                string
                f_53_2118_2136(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(53, 2118, 2136);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(53, 2003, 2148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(53, 2003, 2148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static DebugId()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(53, 736, 2155);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(53, 868, 889);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(53, 736, 2155);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(53, 736, 2155);
        }

        static int
        f_53_1356_1413(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(53, 1356, 1413);
            return 0;
        }


        static int
        f_53_1428_1457(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(53, 1428, 1457);
            return 0;
        }

    }
}
