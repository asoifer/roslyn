// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public sealed partial class ArgumentSyntax
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public SyntaxToken RefOrOutKeyword
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10737, 639, 661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10737, 642, 661);
                    return f_10737_642_661(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10737, 639, 661);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10737, 521, 673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10737, 521, 673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public ArgumentSyntax WithRefOrOutKeyword(SyntaxToken refOrOutKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10737, 842, 1072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10737, 992, 1061);

                return f_10737_999_1060(this, f_10737_1011_1025(this), refOrOutKeyword, f_10737_1044_1059(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10737, 842, 1072);

                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax?
                f_10737_1011_1025(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10737, 1011, 1025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10737_1044_1059(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10737, 1044, 1059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                f_10737_999_1060(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax?
                nameColon, Microsoft.CodeAnalysis.SyntaxToken
                refKindKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.Update(nameColon, refKindKeyword, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10737, 999, 1060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10737, 842, 1072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10737, 842, 1072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ArgumentSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10737, 295, 1079);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10737, 295, 1079);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10737, 295, 1079);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10737, 295, 1079);

        Microsoft.CodeAnalysis.SyntaxToken
        f_10737_642_661(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
        this_param)
        {
            var return_v = this_param.RefKindKeyword;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10737, 642, 661);
            return return_v;
        }

    }
}
