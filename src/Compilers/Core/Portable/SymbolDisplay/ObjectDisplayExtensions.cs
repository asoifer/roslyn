// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis
{
    internal static class ObjectDisplayExtensions
    {
        internal static bool IncludesOption(this ObjectDisplayOptions options, ObjectDisplayOptions flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(569, 720, 885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(569, 842, 874);

                return (options & flag) == flag;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(569, 720, 885);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(569, 720, 885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(569, 720, 885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ObjectDisplayExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(569, 270, 892);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(569, 270, 892);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(569, 270, 892);
        }

    }
}
