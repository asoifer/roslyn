// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public sealed partial class QualifiedNameSyntax : NameSyntax
    {
        internal override SimpleNameSyntax GetUnqualifiedName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10791, 823, 927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10791, 903, 916);

                return f_10791_910_915();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10791, 823, 927);

                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10791_910_915()
                {
                    var return_v = Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10791, 910, 915);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10791, 823, 927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10791, 823, 927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override string ErrorDisplayName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10791, 939, 1082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10791, 1007, 1071);

                return f_10791_1014_1037(f_10791_1014_1018()) + "." + f_10791_1046_1070(f_10791_1046_1051());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10791, 939, 1082);

                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10791_1014_1018()
                {
                    var return_v = Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10791, 1014, 1018);
                    return return_v;
                }


                string
                f_10791_1014_1037(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.ErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10791, 1014, 1037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10791_1046_1051()
                {
                    var return_v = Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10791, 1046, 1051);
                    return return_v;
                }


                string
                f_10791_1046_1070(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.ErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10791, 1046, 1070);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10791, 939, 1082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10791, 939, 1082);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static QualifiedNameSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10791, 422, 1089);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10791, 422, 1089);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10791, 422, 1089);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10791, 422, 1089);
    }
}
