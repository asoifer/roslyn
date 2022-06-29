// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    /// <summary>
    /// Represents a set of filtered diagnostic severities.
    /// Currently, we only support filtering out Hidden and Info severities during build.
    /// </summary>
    [Flags]
    internal enum SeverityFilter
    {
        None = 0x00,
        Hidden = 0x01,
        Info = 0x10
    }
    internal static class SeverityFilterExtensions
    {
        internal static bool Contains(this SeverityFilter severityFilter, ReportDiagnostic severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(200, 662, 1049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(200, 779, 1038);

                return severity switch
                {
                    ReportDiagnostic.Hidden when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(200, 834, 906) && DynAbs.Tracing.TraceSender.Expression_True(200, 834, 906))
    => (severityFilter & SeverityFilter.Hidden) != 0,
                    ReportDiagnostic.Info when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(200, 925, 993) && DynAbs.Tracing.TraceSender.Expression_True(200, 925, 993))
    => (severityFilter & SeverityFilter.Info) != 0,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(200, 1012, 1022) && DynAbs.Tracing.TraceSender.Expression_True(200, 1012, 1022))
    => false
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(200, 662, 1049);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(200, 662, 1049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(200, 662, 1049);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SeverityFilterExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(200, 599, 1056);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(200, 599, 1056);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(200, 599, 1056);
        }

    }
}
