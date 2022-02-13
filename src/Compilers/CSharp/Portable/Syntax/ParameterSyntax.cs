// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ParameterSyntax
    {
        internal bool IsArgList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10788, 493, 634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10788, 529, 619);

                    return f_10788_536_545(this) == null && (DynAbs.Tracing.TraceSender.Expression_True(10788, 536, 618) && this.Identifier.ContextualKind() == SyntaxKind.ArgListKeyword);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10788, 493, 634);

                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                    f_10788_536_545(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10788, 536, 545);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10788, 445, 645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10788, 445, 645);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ParameterSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10788, 392, 652);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10788, 392, 652);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10788, 392, 652);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10788, 392, 652);
    }
}
