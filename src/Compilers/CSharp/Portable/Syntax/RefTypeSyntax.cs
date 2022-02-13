// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class RefTypeSyntax
    {
        public RefTypeSyntax Update(SyntaxToken refKeyword, TypeSyntax type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10793, 361, 523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10793, 454, 512);

                return f_10793_461_511(this, refKeyword, readOnlyKeyword: default, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10793, 361, 523);

                Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax
                f_10793_461_511(Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                refKeyword, Microsoft.CodeAnalysis.SyntaxToken
                readOnlyKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type)
                {
                    var return_v = this_param.Update(refKeyword, readOnlyKeyword: readOnlyKeyword, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10793, 461, 511);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10793, 361, 523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10793, 361, 523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RefTypeSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10793, 310, 530);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10793, 310, 530);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10793, 310, 530);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10793, 310, 530);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static RefTypeSyntax RefType(SyntaxToken refKeyword, TypeSyntax type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10793, 706, 877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10793, 807, 866);

                return f_10793_814_865(refKeyword, readOnlyKeyword: default, type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10793, 706, 877);

                Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax
                f_10793_814_865(Microsoft.CodeAnalysis.SyntaxToken
                refKeyword, Microsoft.CodeAnalysis.SyntaxToken
                readOnlyKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type)
                {
                    var return_v = RefType(refKeyword, readOnlyKeyword: readOnlyKeyword, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10793, 814, 865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10793, 706, 877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10793, 706, 877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
