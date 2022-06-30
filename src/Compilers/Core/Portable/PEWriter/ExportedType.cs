// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Cci
{

    internal struct ExportedType
    {

        public readonly ITypeReference Type;

        public readonly bool IsForwarder;

        public readonly int ParentIndex;

        public ExportedType(ITypeReference type, int parentIndex, bool isForwarder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(484, 1048, 1251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(484, 1148, 1160);

                Type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(484, 1174, 1200);

                IsForwarder = isForwarder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(484, 1214, 1240);

                ParentIndex = parentIndex;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(484, 1048, 1251);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(484, 1048, 1251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(484, 1048, 1251);
            }
        }
        static ExportedType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(484, 340, 1258);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(484, 340, 1258);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(484, 340, 1258);
        }
    }
}
