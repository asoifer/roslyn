// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class AccessibilityExtensions
    {
        public static bool HasProtected(this Accessibility accessibility)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10087, 380, 792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10087, 470, 781);

                switch (accessibility)
                {

                    case Accessibility.Protected:
                    case Accessibility.ProtectedOrInternal:
                    case Accessibility.ProtectedAndInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10087, 470, 781);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10087, 691, 703);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10087, 470, 781);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10087, 470, 781);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10087, 753, 766);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10087, 470, 781);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10087, 380, 792);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10087, 380, 792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10087, 380, 792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AccessibilityExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10087, 318, 799);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10087, 318, 799);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10087, 318, 799);
        }

    }
}

