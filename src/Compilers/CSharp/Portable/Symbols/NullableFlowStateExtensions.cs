// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class NullableFlowStateExtensions
    {
        public static bool MayBeNull(this NullableFlowState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10138, 429, 466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 432, 466);
                return state != NullableFlowState.NotNull; DynAbs.Tracing.TraceSender.TraceExitMethod(10138, 429, 466);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10138, 429, 466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10138, 429, 466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNotNull(this NullableFlowState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10138, 538, 575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 541, 575);
                return state == NullableFlowState.NotNull; DynAbs.Tracing.TraceSender.TraceExitMethod(10138, 538, 575);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10138, 538, 575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10138, 538, 575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NullableFlowState Join(this NullableFlowState a, NullableFlowState b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10138, 899, 917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 902, 917);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10138, 902, 909) || (((a > b) && DynAbs.Tracing.TraceSender.Conditional_F2(10138, 912, 913)) || DynAbs.Tracing.TraceSender.Conditional_F3(10138, 916, 917))) ? a : b; DynAbs.Tracing.TraceSender.TraceExitMethod(10138, 899, 917);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10138, 899, 917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10138, 899, 917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NullableFlowState Meet(this NullableFlowState a, NullableFlowState b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10138, 1268, 1286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 1271, 1286);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10138, 1271, 1278) || (((a < b) && DynAbs.Tracing.TraceSender.Conditional_F2(10138, 1281, 1282)) || DynAbs.Tracing.TraceSender.Conditional_F3(10138, 1285, 1286))) ? a : b; DynAbs.Tracing.TraceSender.TraceExitMethod(10138, 1268, 1286);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10138, 1268, 1286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10138, 1268, 1286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CodeAnalysis.NullableFlowState ToPublicFlowState(this CSharp.NullableFlowState nullableFlowState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10138, 1413, 1855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 1429, 1855);
                return nullableFlowState switch
                {
                    CSharp.NullableFlowState.NotNull when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 1486, 1560) && DynAbs.Tracing.TraceSender.Expression_True(10138, 1486, 1560))
    => CodeAnalysis.NullableFlowState.NotNull,
                    CSharp.NullableFlowState.MaybeNull when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 1579, 1657) && DynAbs.Tracing.TraceSender.Expression_True(10138, 1579, 1657))
    => CodeAnalysis.NullableFlowState.MaybeNull,
                    CSharp.NullableFlowState.MaybeDefault when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 1676, 1757) && DynAbs.Tracing.TraceSender.Expression_True(10138, 1676, 1757))
    => CodeAnalysis.NullableFlowState.MaybeNull,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 1776, 1840) && DynAbs.Tracing.TraceSender.Expression_True(10138, 1776, 1840))
    => throw f_10138_1787_1840(nullableFlowState)
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(10138, 1413, 1855);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10138, 1413, 1855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10138, 1413, 1855);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10138_1787_1840(Microsoft.CodeAnalysis.CSharp.NullableFlowState
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10138, 1787, 1840);
                return return_v;
            }

        }

        public static CSharp.NullableFlowState ToInternalFlowState(this CodeAnalysis.NullableFlowState flowState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10138, 2052, 2468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 2068, 2468);
                return flowState switch
                {
                    CodeAnalysis.NullableFlowState.None when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 2117, 2188) && DynAbs.Tracing.TraceSender.Expression_True(10138, 2117, 2188))
    => CSharp.NullableFlowState.NotNull,
                    CodeAnalysis.NullableFlowState.NotNull when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 2207, 2281) && DynAbs.Tracing.TraceSender.Expression_True(10138, 2207, 2281))
    => CSharp.NullableFlowState.NotNull,
                    CodeAnalysis.NullableFlowState.MaybeNull when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 2300, 2378) && DynAbs.Tracing.TraceSender.Expression_True(10138, 2300, 2378))
    => CSharp.NullableFlowState.MaybeNull,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10138, 2397, 2453) && DynAbs.Tracing.TraceSender.Expression_True(10138, 2397, 2453))
    => throw f_10138_2408_2453(flowState)
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(10138, 2052, 2468);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10138, 2052, 2468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10138, 2052, 2468);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10138_2408_2453(Microsoft.CodeAnalysis.NullableFlowState
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10138, 2408, 2453);
                return return_v;
            }

        }

        static NullableFlowStateExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10138, 304, 2476);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10138, 304, 2476);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10138, 304, 2476);
        }

    }
}
