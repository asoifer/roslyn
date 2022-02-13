// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal partial class IdentifierNameSyntax
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10825, 488, 585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10825, 546, 574);

                return f_10825_553_573(f_10825_553_568(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10825, 488, 585);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10825_553_568(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10825, 553, 568);
                    return return_v;
                }


                string
                f_10825_553_573(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10825, 553, 573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10825, 488, 585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10825, 488, 585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10825, 428, 592);
    }
}
