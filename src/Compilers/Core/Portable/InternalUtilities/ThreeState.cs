// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents an optional bool as a single byte.
    /// </summary>
    internal enum ThreeState : byte
    {
        Unknown = 0,
        False = 1,
        True = 2,
    }
    internal static class ThreeStateHelpers
    {
        public static ThreeState ToThreeState(this bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(392, 542, 682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(392, 621, 671);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(392, 628, 633) || ((value && DynAbs.Tracing.TraceSender.Conditional_F2(392, 636, 651)) || DynAbs.Tracing.TraceSender.Conditional_F3(392, 654, 670))) ? ThreeState.True : ThreeState.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(392, 542, 682);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(392, 542, 682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(392, 542, 682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasValue(this ThreeState value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(392, 694, 815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(392, 769, 804);

                return value != ThreeState.Unknown;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(392, 694, 815);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(392, 694, 815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(392, 694, 815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Value(this ThreeState value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(392, 827, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(392, 899, 941);

                f_392_899_940(value != ThreeState.Unknown);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(392, 955, 987);

                return value == ThreeState.True;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(392, 827, 998);

                int
                f_392_899_940(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(392, 899, 940);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(392, 827, 998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(392, 827, 998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ThreeStateHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(392, 486, 1005);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(392, 486, 1005);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(392, 486, 1005);
        }

    }
}
