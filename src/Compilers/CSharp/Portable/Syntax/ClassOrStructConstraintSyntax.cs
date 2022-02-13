// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ClassOrStructConstraintSyntax
    {
        public ClassOrStructConstraintSyntax Update(SyntaxToken classOrStructKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10747, 330, 494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10747, 432, 483);

                return f_10747_439_482(this, classOrStructKeyword, f_10747_468_481());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10747, 330, 494);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10747_468_481()
                {
                    var return_v = QuestionToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10747, 468, 481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax
                f_10747_439_482(Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                classOrStructKeyword, Microsoft.CodeAnalysis.SyntaxToken
                questionToken)
                {
                    var return_v = this_param.Update(classOrStructKeyword, questionToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10747, 439, 482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10747, 330, 494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10747, 330, 494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ClassOrStructConstraintSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10747, 263, 501);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10747, 263, 501);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10747, 263, 501);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10747, 263, 501);
    }
}
