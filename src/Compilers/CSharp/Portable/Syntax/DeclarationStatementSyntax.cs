// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class LocalDeclarationStatementSyntax : StatementSyntax
    {
        public bool IsConst
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10756, 394, 496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10756, 430, 481);

                    return this.Modifiers.Any(SyntaxKind.ConstKeyword);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10756, 394, 496);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10756, 350, 507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10756, 350, 507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static LocalDeclarationStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10756, 263, 514);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10756, 263, 514);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10756, 263, 514);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10756, 263, 514);
    }
}
