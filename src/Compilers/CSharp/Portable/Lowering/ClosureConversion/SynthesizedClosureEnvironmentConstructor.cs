// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SynthesizedClosureEnvironmentConstructor : SynthesizedInstanceConstructor, ISynthesizedMethodBodyImplementationSymbol
    {
        internal SynthesizedClosureEnvironmentConstructor(SynthesizedClosureEnvironment frame)
        : base(f_10458_627_632_C(frame))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10458, 520, 655);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10458, 520, 655);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10458, 520, 655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10458, 520, 655);
            }
        }

        IMethodSymbolInternal ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10458, 763, 853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10458, 769, 851);

                    return f_10458_776_850(((ISynthesizedMethodBodyImplementationSymbol)f_10458_821_842(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10458, 763, 853);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10458_821_842(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironmentConstructor
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10458, 821, 842);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal?
                    f_10458_776_850(Microsoft.CodeAnalysis.Symbols.ISynthesizedMethodBodyImplementationSymbol
                    this_param)
                    {
                        var return_v = this_param.Method;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10458, 776, 850);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10458, 667, 864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10458, 667, 864);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10458, 972, 993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10458, 978, 991);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10458, 972, 993);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10458, 876, 1004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10458, 876, 1004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SynthesizedClosureEnvironmentConstructor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10458, 364, 1011);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10458, 364, 1011);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10458, 364, 1011);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10458, 364, 1011);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10458_627_632_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10458, 520, 655);
            return return_v;
        }

    }
}
