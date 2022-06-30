// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents the compiler's analysis of whether an expression may be null
    /// </summary>
    // Review docs: https://github.com/dotnet/roslyn/issues/35046
    public enum NullableFlowState : byte
    {
        /// <summary>
        /// Syntax is not an expression, or was not analyzed.
        /// </summary>
        None = 0,
        /// <summary>
        /// Expression is not null.
        /// </summary>
        NotNull,
        /// <summary>
        /// Expression may be null.
        /// </summary>
        MaybeNull
    }
    internal static class NullableFlowStateExtensions
    {
        public static NullableAnnotation ToAnnotation(this NullableFlowState nullableFlowState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(638, 1381, 1923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(638, 1493, 1912);

                switch (nullableFlowState)
                {

                    case CodeAnalysis.NullableFlowState.MaybeNull:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(638, 1493, 1912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(638, 1620, 1669);

                        return CodeAnalysis.NullableAnnotation.Annotated;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(638, 1493, 1912);

                    case CodeAnalysis.NullableFlowState.NotNull:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(638, 1493, 1912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(638, 1753, 1805);

                        return CodeAnalysis.NullableAnnotation.NotAnnotated;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(638, 1493, 1912);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(638, 1493, 1912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(638, 1853, 1897);

                        return CodeAnalysis.NullableAnnotation.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(638, 1493, 1912);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(638, 1381, 1923);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(638, 1381, 1923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(638, 1381, 1923);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NullableFlowStateExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(638, 828, 1930);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(638, 828, 1930);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(638, 828, 1930);
        }

    }
}
