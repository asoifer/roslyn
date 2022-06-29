// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.Diagnostics
{

    internal struct SuppressMessageInfo
    {

        public string Id;

        public string Scope;

        public string Target;

        public string MessageId;

        public AttributeData Attribute;
        static SuppressMessageInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(273, 282, 494);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(273, 282, 494);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(273, 282, 494);
        }
    }
}
