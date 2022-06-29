// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public sealed class SuppressionInfo
    {
        public string Id { get; }

        public AttributeData? Attribute { get; }

        internal SuppressionInfo(string id, AttributeData? attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(203, 810, 951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(203, 544, 569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(203, 758, 798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(203, 896, 904);

                Id = id;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(203, 918, 940);

                Attribute = attribute;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(203, 810, 951);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(203, 810, 951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(203, 810, 951);
            }
        }

        static SuppressionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(203, 374, 958);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(203, 374, 958);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(203, 374, 958);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(203, 374, 958);
    }
}
