// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundFunctionPointerInvocation
    {
        public FunctionPointerTypeSymbol FunctionPointer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10557, 474, 666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10557, 510, 576);

                    f_10557_510_575(f_10557_523_545(f_10557_523_540()) is FunctionPointerTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10557, 594, 651);

                    return (FunctionPointerTypeSymbol)f_10557_628_650(f_10557_628_645());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10557, 474, 666);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10557_523_540()
                    {
                        var return_v = InvokedExpression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10557, 523, 540);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10557_523_545(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10557, 523, 545);
                        return return_v;
                    }


                    int
                    f_10557_510_575(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10557, 510, 575);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10557_628_645()
                    {
                        var return_v = InvokedExpression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10557, 628, 645);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10557_628_650(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10557, 628, 650);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10557, 401, 677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10557, 401, 677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundFunctionPointerInvocation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10557, 331, 684);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10557, 331, 684);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10557, 331, 684);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10557, 331, 684);
    }
}
