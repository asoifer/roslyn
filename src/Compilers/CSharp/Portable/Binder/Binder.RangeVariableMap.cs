// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private class RangeVariableMap : Dictionary<RangeVariableSymbol, ImmutableArray<string>>
        {
            public RangeVariableMap()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10291, 1521, 1550);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10291, 1521, 1550);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10291, 1521, 1550);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10291, 1521, 1550);
                }
            }

            static RangeVariableMap()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10291, 1408, 1561);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10291, 1408, 1561);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10291, 1408, 1561);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10291, 1408, 1561);
        }
    }
}
