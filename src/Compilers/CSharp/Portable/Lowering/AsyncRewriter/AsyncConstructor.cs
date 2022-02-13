// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class AsyncConstructor : SynthesizedInstanceConstructor, ISynthesizedMethodBodyImplementationSymbol
    {
        internal AsyncConstructor(AsyncStateMachine stateMachineType)
        : base(f_10442_578_594_C(stateMachineType))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10442, 496, 617);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10442, 496, 617);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10442, 496, 617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10442, 496, 617);
            }
        }

        IMethodSymbolInternal ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10442, 725, 815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10442, 731, 813);

                    return f_10442_738_812(((ISynthesizedMethodBodyImplementationSymbol)f_10442_783_804(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10442, 725, 815);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10442_783_804(Microsoft.CodeAnalysis.CSharp.AsyncConstructor
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10442, 783, 804);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal?
                    f_10442_738_812(Microsoft.CodeAnalysis.Symbols.ISynthesizedMethodBodyImplementationSymbol
                    this_param)
                    {
                        var return_v = this_param.Method;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10442, 738, 812);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10442, 629, 826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10442, 629, 826);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISynthesizedMethodBodyImplementationSymbol.HasMethodBodyDependency
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10442, 934, 955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10442, 940, 953);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10442, 934, 955);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10442, 838, 966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10442, 838, 966);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static AsyncConstructor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10442, 364, 973);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10442, 364, 973);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10442, 364, 973);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10442, 364, 973);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10442_578_594_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10442, 496, 617);
            return return_v;
        }

    }
}
