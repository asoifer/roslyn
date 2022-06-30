// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// The kind of metadata a PE file image contains.
    /// </summary>
    public enum MetadataImageKind : byte
    {
        /// <summary>
        /// The PE file is an assembly.
        /// </summary>
        Assembly = 0,

        /// <summary>
        /// The PE file is a module.
        /// </summary>
        Module = 1
    }
    internal static partial class EnumBounds
    {
        internal static bool IsValid(this MetadataImageKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(429, 677, 848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(429, 759, 837);

                return kind >= MetadataImageKind.Assembly && (DynAbs.Tracing.TraceSender.Expression_True(429, 766, 836) && kind <= MetadataImageKind.Module);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(429, 677, 848);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(429, 677, 848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(429, 677, 848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
