// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Describes how severe a diagnostic is.
    /// </summary>
    public enum DiagnosticSeverity
    {
        /// <summary>
        /// Something that is an issue, as determined by some authority,
        /// but is not surfaced through normal means.
        /// There may be different mechanisms that act on these issues.
        /// </summary>
        Hidden = 0,

        /// <summary>
        /// Information that does not indicate a problem (i.e. not prescriptive).
        /// </summary>
        Info = 1,

        /// <summary>
        /// Something suspicious but allowed.
        /// </summary>
        Warning = 2,

        /// <summary>
        /// Something not allowed by the rules of the language or other authority.
        /// </summary>
        Error = 3,
    }
    internal static class InternalDiagnosticSeverity
    {
        public const DiagnosticSeverity
        Unknown = (DiagnosticSeverity)InternalErrorCode.Unknown
        ;

        public const DiagnosticSeverity
        Void = (DiagnosticSeverity)InternalErrorCode.Void
        ;

        static InternalDiagnosticSeverity()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(186, 1209, 1792);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(186, 1454, 1509);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(186, 1735, 1784);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(186, 1209, 1792);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(186, 1209, 1792);
        }

    }
    internal static class InternalErrorCode
    {
        public const int
        Unknown = -1
        ;

        public const int
        Void = -2
        ;

        static InternalErrorCode()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(186, 1937, 2289);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(186, 2105, 2117);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(186, 2272, 2281);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(186, 1937, 2289);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(186, 1937, 2289);
        }

    }
}
