// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Specifies the different documentation comment processing modes.
    /// </summary>
    /// <remarks>
    /// Order matters: least processing to most processing.
    /// </remarks>
    public enum DocumentationMode : byte
    {
        /// <summary>
        /// Treats documentation comments as regular comments.
        /// </summary>
        None = 0,

        /// <summary>
        /// Parses documentation comments as structured trivia, but do not report any diagnostics.
        /// </summary>
        Parse = 1,

        /// <summary>
        /// Parses documentation comments as structured trivia and report diagnostics.
        /// </summary>
        Diagnose = 2,
    }
    internal static partial class DocumentationModeEnumBounds
    {
        internal static bool IsValid(this DocumentationMode value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(13, 1090, 1262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(13, 1173, 1251);

                return value >= DocumentationMode.None && (DynAbs.Tracing.TraceSender.Expression_True(13, 1180, 1250) && value <= DocumentationMode.Diagnose);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(13, 1090, 1262);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(13, 1090, 1262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(13, 1090, 1262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DocumentationModeEnumBounds()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(13, 1016, 1269);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(13, 1016, 1269);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(13, 1016, 1269);
        }

    }
}
