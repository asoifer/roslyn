// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CSharp
{
    public static partial class SyntaxFacts
    {
        private sealed class SyntaxKindEqualityComparer : IEqualityComparer<SyntaxKind>
        {
            public bool Equals(SyntaxKind x, SyntaxKind y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10081, 453, 561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10081, 532, 546);

                    return x == y;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10081, 453, 561);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10081, 453, 561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10081, 453, 561);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(SyntaxKind obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10081, 577, 679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10081, 648, 664);

                    return (int)obj;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10081, 577, 679);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10081, 577, 679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10081, 577, 679);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SyntaxKindEqualityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10081, 349, 690);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10081, 349, 690);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10081, 349, 690);
            }


            static SyntaxKindEqualityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10081, 349, 690);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10081, 349, 690);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10081, 349, 690);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10081, 349, 690);
        }

        public static IEqualityComparer<SyntaxKind> EqualityComparer { get; }
    }
}
