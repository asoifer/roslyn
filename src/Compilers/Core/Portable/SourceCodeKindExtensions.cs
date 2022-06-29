// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    internal static partial class SourceCodeKindExtensions
    {
        internal static SourceCodeKind MapSpecifiedToEffectiveKind(this SourceCodeKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(32, 320, 903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(32, 429, 892);

                switch (kind)
                {

                    case SourceCodeKind.Script:
#pragma warning disable CS0618 // SourceCodeKind.Interactive is obsolete
                    case SourceCodeKind.Interactive:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(32, 429, 892);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(32, 722, 751);

                        return SourceCodeKind.Script;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(32, 429, 892);

                    case SourceCodeKind.Regular:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(32, 429, 892);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(32, 847, 877);

                        return SourceCodeKind.Regular;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(32, 429, 892);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(32, 320, 903);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(32, 320, 903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(32, 320, 903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValid(this SourceCodeKind value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(32, 915, 1079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(32, 995, 1068);

                return value >= SourceCodeKind.Regular && (DynAbs.Tracing.TraceSender.Expression_True(32, 1002, 1067) && value <= SourceCodeKind.Script);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(32, 915, 1079);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(32, 915, 1079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(32, 915, 1079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceCodeKindExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(32, 249, 1086);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(32, 249, 1086);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(32, 249, 1086);
        }

    }
}
