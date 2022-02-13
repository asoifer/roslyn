// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public sealed partial class AliasQualifiedNameSyntax : NameSyntax
    {
        internal override SimpleNameSyntax GetUnqualifiedName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10734, 673, 781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10734, 753, 770);

                return f_10734_760_769(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10734, 673, 781);

                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10734_760_769(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10734, 760, 769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10734, 673, 781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10734, 673, 781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override string ErrorDisplayName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10734, 793, 937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10734, 861, 926);

                return f_10734_868_892(f_10734_868_873()) + "::" + f_10734_902_925(f_10734_902_906());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10734, 793, 937);

                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10734_868_873()
                {
                    var return_v = Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10734, 868, 873);
                    return return_v;
                }


                string
                f_10734_868_892(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.ErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10734, 868, 892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10734_902_906()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10734, 902, 906);
                    return return_v;
                }


                string
                f_10734_902_925(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.ErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10734, 902, 925);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10734, 793, 937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10734, 793, 937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AliasQualifiedNameSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10734, 263, 944);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10734, 263, 944);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10734, 263, 944);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10734, 263, 944);
    }
}
