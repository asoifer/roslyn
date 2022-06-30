// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Specifies what symbols to import from metadata.
    /// </summary>
    public enum MetadataImportOptions : byte
    {
        /// <summary>
        /// Only import public and protected symbols.
        /// </summary>
        Public = 0,

        /// <summary>
        /// Import public, protected and internal symbols.
        /// </summary>
        Internal = 1,

        /// <summary>
        /// Import all symbols.
        /// </summary>
        All = 2,
    }
    internal static partial class EnumBounds
    {
        internal static bool IsValid(this MetadataImportOptions value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(408, 857, 1038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(408, 944, 1027);

                return value >= MetadataImportOptions.Public && (DynAbs.Tracing.TraceSender.Expression_True(408, 951, 1026) && value <= MetadataImportOptions.All);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(408, 857, 1038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(408, 857, 1038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(408, 857, 1038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
