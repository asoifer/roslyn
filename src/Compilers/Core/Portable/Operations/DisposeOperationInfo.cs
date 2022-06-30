// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Operations
{

    internal struct DisposeOperationInfo
    {

        public readonly IMethodSymbol? DisposeMethod;

        public readonly ImmutableArray<IArgumentOperation> DisposeArguments;

        public DisposeOperationInfo(IMethodSymbol? disposeMethod, ImmutableArray<IArgumentOperation> disposeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(461, 487, 713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(461, 622, 652);

                DisposeMethod = disposeMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(461, 666, 702);

                DisposeArguments = disposeArguments;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(461, 487, 713);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(461, 487, 713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(461, 487, 713);
            }
        }
        static DisposeOperationInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(461, 297, 720);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(461, 297, 720);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(461, 297, 720);
        }
    }
}
