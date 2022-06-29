// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Determines the level of optimization of the generated code.
    /// </summary>
    public enum OptimizationLevel
    {
        /// <summary>
        /// Disables all optimizations and instruments the generated code to improve debugging experience.
        /// </summary>
        /// <remarks>
        /// The compiler prefers debuggability over performance. Do not use for code running in a production environment.
        /// <list type="bullet">
        /// <item><description>JIT optimizations are disabled via assembly level attribute (<see cref="DebuggableAttribute"/>).</description></item>
        /// <item><description>Edit and Continue is enabled.</description></item>
        /// <item><description>Slots for local variables are not reused, lifetime of local variables is extended to make the values available during debugging.</description></item>
        /// </list>
        /// <para>
        /// Corresponds to command line argument /optimize-.
        /// </para>
        /// </remarks>
        Debug = 0,

        /// <summary>
        /// Enables all optimizations, debugging experience might be degraded.
        /// </summary>
        /// <remarks>
        /// The compiler prefers performance over debuggability. Use for code running in a production environment.
        /// <list type="bullet">
        /// <item><description>JIT optimizations are enabled via assembly level attribute (<see cref="DebuggableAttribute"/>).</description></item>
        /// <item><description>Edit and Continue is disabled.</description></item>
        /// <item><description>Sequence points may be optimized away. As a result it might not be possible to place or hit a breakpoint.</description></item>
        /// <item><description>User-defined locals might be optimized away. They might not be available while debugging.</description></item>
        /// </list>
        /// <para>
        /// Corresponds to command line argument /optimize+.
        /// </para>
        /// </remarks>
        Release = 1
    }
    internal static class OptimizationLevelFacts
    {
        public static string ToPdbSerializedString(this OptimizationLevel optimization, bool debugPlusMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(157, 2556, 2806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 2559, 2806);
                return optimization switch
                {
                    OptimizationLevel.Release when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 2603, 2641) && DynAbs.Tracing.TraceSender.Expression_True(157, 2603, 2641))
        => "release",
                    OptimizationLevel.Debug when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 2656, 2721) && DynAbs.Tracing.TraceSender.Expression_True(157, 2656, 2721))
        => (DynAbs.Tracing.TraceSender.Conditional_F1(157, 2683, 2696) || ((debugPlusMode && DynAbs.Tracing.TraceSender.Conditional_F2(157, 2699, 2711)) || DynAbs.Tracing.TraceSender.Conditional_F3(157, 2714, 2721))) ? "debug-plus" : "debug",
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 2736, 2795) && DynAbs.Tracing.TraceSender.Expression_True(157, 2736, 2795))
        => throw f_157_2747_2795(optimization)
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(157, 2556, 2806);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(157, 2556, 2806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(157, 2556, 2806);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_157_2747_2795(Microsoft.CodeAnalysis.OptimizationLevel
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(157, 2747, 2795);
                return return_v;
            }

        }

        public static bool TryParsePdbSerializedString(string value, out OptimizationLevel optimizationLevel, out bool debugPlusMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(157, 2819, 3684);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 2969, 3564) || true) && (value == "release")
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(157, 2969, 3564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3025, 3071);

                    optimizationLevel = OptimizationLevel.Release;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3089, 3111);

                    debugPlusMode = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3129, 3141);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(157, 2969, 3564);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(157, 2969, 3564);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3175, 3564) || true) && (value == "debug")
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(157, 3175, 3564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3229, 3273);

                        optimizationLevel = OptimizationLevel.Debug;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3291, 3313);

                        debugPlusMode = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3331, 3343);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(157, 3175, 3564);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(157, 3175, 3564);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3377, 3564) || true) && (value == "debug-plus")
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(157, 3377, 3564);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3436, 3480);

                            optimizationLevel = OptimizationLevel.Debug;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3498, 3519);

                            debugPlusMode = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3537, 3549);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(157, 3377, 3564);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(157, 3175, 3564);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(157, 2969, 3564);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3580, 3608);

                optimizationLevel = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3622, 3646);

                debugPlusMode = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3660, 3673);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(157, 2819, 3684);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(157, 2819, 3684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(157, 2819, 3684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OptimizationLevelFacts()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(157, 2386, 3691);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(157, 2386, 3691);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(157, 2386, 3691);
        }

    }
    internal static partial class EnumBounds
    {
        internal static bool IsValid(this OptimizationLevel value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(157, 3758, 3930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(157, 3841, 3919);

                return value >= OptimizationLevel.Debug && (DynAbs.Tracing.TraceSender.Expression_True(157, 3848, 3918) && value <= OptimizationLevel.Release);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(157, 3758, 3930);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(157, 3758, 3930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(157, 3758, 3930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
