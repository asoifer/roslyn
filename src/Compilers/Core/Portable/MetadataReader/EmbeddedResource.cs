// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Reflection;

namespace Microsoft.CodeAnalysis
{

    internal struct EmbeddedResource
    {

        public readonly uint Offset;

        public readonly ManifestResourceAttributes Attributes;

        public readonly string Name;

        internal EmbeddedResource(uint offset, ManifestResourceAttributes attributes, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(404, 489, 710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(404, 604, 625);

                this.Offset = offset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(404, 639, 668);

                this.Attributes = attributes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(404, 682, 699);

                this.Name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(404, 489, 710);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(404, 489, 710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(404, 489, 710);
            }
        }
        static EmbeddedResource()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(404, 298, 717);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(404, 298, 717);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(404, 298, 717);
        }
    }
}
