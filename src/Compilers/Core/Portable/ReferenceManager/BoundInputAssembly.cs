// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    internal partial class CommonReferenceManager<TCompilation, TAssemblySymbol>
    {
        [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
        internal struct BoundInputAssembly
        {

            internal TAssemblySymbol? AssemblySymbol;

            internal AssemblyReferenceBinding[]? ReferenceBinding;

            private string? GetDebuggerDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(528, 1545, 1693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(528, 1614, 1678);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(528, 1621, 1643) || ((AssemblySymbol == null && DynAbs.Tracing.TraceSender.Conditional_F2(528, 1646, 1649)) || DynAbs.Tracing.TraceSender.Conditional_F3(528, 1652, 1677))) ? "?" : f_528_1652_1677(AssemblySymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(528, 1545, 1693);

                    string?
                    f_528_1652_1677(TAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(528, 1652, 1677);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(528, 1545, 1693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(528, 1545, 1693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static BoundInputAssembly()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(528, 488, 1704);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(528, 488, 1704);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(528, 488, 1704);
            }
        }
    }
}
