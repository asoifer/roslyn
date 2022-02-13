// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ArrayRankSpecifierSyntax
    {
        public int Rank
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10738, 365, 440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10738, 401, 425);

                    return this.Sizes.Count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10738, 365, 440);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10738, 325, 451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10738, 325, 451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ArrayRankSpecifierSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10738, 263, 458);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10738, 263, 458);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10738, 263, 458);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10738, 263, 458);
    }
}
