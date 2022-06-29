// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{

    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal struct LambdaDebugInfo : IEquatable<LambdaDebugInfo>
    {

        public readonly int SyntaxOffset;

        public readonly int ClosureOrdinal;

        public readonly DebugId LambdaId;

        public const int
        StaticClosureOrdinal = -1
        ;

        public const int
        ThisOnlyClosureOrdinal = -2
        ;

        public const int
        MinClosureOrdinal = ThisOnlyClosureOrdinal
        ;

        public LambdaDebugInfo(int syntaxOffset, DebugId lambdaId, int closureOrdinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(64, 1487, 1775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(64, 1590, 1640);

                f_64_1590_1639(closureOrdinal >= MinClosureOrdinal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(64, 1656, 1684);

                SyntaxOffset = syntaxOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(64, 1698, 1730);

                ClosureOrdinal = closureOrdinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(64, 1744, 1764);

                LambdaId = lambdaId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(64, 1487, 1775);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(64, 1487, 1775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(64, 1487, 1775);
            }
        }

        public bool Equals(LambdaDebugInfo other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(64, 1787, 2017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(64, 1853, 2006);

                return SyntaxOffset == other.SyntaxOffset
                && (DynAbs.Tracing.TraceSender.Expression_True(64, 1860, 1953) && ClosureOrdinal == other.ClosureOrdinal
                ) && (DynAbs.Tracing.TraceSender.Expression_True(64, 1860, 2005) && LambdaId.Equals(other.LambdaId));
                DynAbs.Tracing.TraceSender.TraceExitMethod(64, 1787, 2017);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(64, 1787, 2017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(64, 1787, 2017);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(64, 2029, 2167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(64, 2094, 2156);

                return obj is LambdaDebugInfo && (DynAbs.Tracing.TraceSender.Expression_True(64, 2101, 2155) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(64, 2029, 2167);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(64, 2029, 2167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(64, 2029, 2167);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(64, 2179, 2356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(64, 2237, 2345);

                return f_64_2244_2344(ClosureOrdinal, f_64_2293_2343(SyntaxOffset, LambdaId.GetHashCode()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(64, 2179, 2356);

                int
                f_64_2293_2343(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(64, 2293, 2343);
                    return return_v;
                }


                int
                f_64_2244_2344(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(64, 2244, 2344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(64, 2179, 2356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(64, 2179, 2356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(64, 2368, 2780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(64, 2429, 2769);

                return
                (DynAbs.Tracing.TraceSender.Conditional_F1(64, 2453, 2491) || ((ClosureOrdinal == StaticClosureOrdinal && DynAbs.Tracing.TraceSender.Conditional_F2(64, 2494, 2554)) || DynAbs.Tracing.TraceSender.Conditional_F3(64, 2574, 2768))) ? $"({LambdaId.GetDebuggerDisplay()} @{SyntaxOffset}, static)" : (DynAbs.Tracing.TraceSender.Conditional_F1(64, 2574, 2614) || ((ClosureOrdinal == ThisOnlyClosureOrdinal && DynAbs.Tracing.TraceSender.Conditional_F2(64, 2617, 2676)) || DynAbs.Tracing.TraceSender.Conditional_F3(64, 2696, 2768))) ? $"(#{LambdaId.GetDebuggerDisplay()} @{SyntaxOffset}, this)" : $"({LambdaId.GetDebuggerDisplay()} @{SyntaxOffset} in {ClosureOrdinal})";
                DynAbs.Tracing.TraceSender.TraceExitMethod(64, 2368, 2780);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(64, 2368, 2780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(64, 2368, 2780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static LambdaDebugInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(64, 573, 2787);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(64, 1324, 1349);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(64, 1377, 1404);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(64, 1432, 1474);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(64, 573, 2787);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(64, 573, 2787);
        }

        static int
        f_64_1590_1639(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(64, 1590, 1639);
            return 0;
        }

    }
}
