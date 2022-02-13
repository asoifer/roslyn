// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal partial class DirectiveTriviaSyntax
    {
        internal override DirectiveStack ApplyDirectives(DirectiveStack stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10824, 489, 633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10824, 584, 622);

                return stack.Add(f_10824_601_620(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10824, 489, 633);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive
                f_10824_601_620(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Directive(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10824, 601, 620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10824, 489, 633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10824, 489, 633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DirectiveTriviaSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10824, 428, 640);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10824, 428, 640);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10824, 428, 640);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10824, 428, 640);
    }
}
