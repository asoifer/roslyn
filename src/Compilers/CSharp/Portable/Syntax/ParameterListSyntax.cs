// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ParameterListSyntax
    {
        internal int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10787, 501, 905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10787, 537, 551);

                    int
                    count = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10787, 569, 859);
                        foreach (ParameterSyntax parameter in f_10787_607_622_I(f_10787_607_622(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10787, 569, 859);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10787, 735, 840) || true) && (f_10787_739_759_M(!parameter.IsArgList))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10787, 735, 840);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10787, 809, 817);

                                count++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10787, 735, 840);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10787, 569, 859);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10787, 1, 291);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10787, 1, 291);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10787, 877, 890);

                    return count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10787, 501, 905);

                    Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                    f_10787_607_622(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10787, 607, 622);
                        return return_v;
                    }


                    bool
                    f_10787_739_759_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10787, 739, 759);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                    f_10787_607_622_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10787, 607, 622);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10787, 449, 916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10787, 449, 916);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ParameterListSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10787, 392, 923);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10787, 392, 923);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10787, 392, 923);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10787, 392, 923);
    }
}
