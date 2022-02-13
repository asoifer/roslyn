// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class DelegateDeclarationSyntax
    {
        public int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10757, 496, 631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10757, 532, 616);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10757, 539, 569) || ((f_10757_539_561(this) == null && DynAbs.Tracing.TraceSender.Conditional_F2(10757, 572, 573)) || DynAbs.Tracing.TraceSender.Conditional_F3(10757, 576, 615))) ? 0 : f_10757_576_598(this).Parameters.Count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10757, 496, 631);

                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                    f_10757_539_561(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.TypeParameterList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10757, 539, 561);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                    f_10757_576_598(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.TypeParameterList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10757, 576, 598);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10757, 455, 642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10757, 455, 642);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static DelegateDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10757, 392, 649);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10757, 392, 649);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10757, 392, 649);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10757, 392, 649);
    }
}
