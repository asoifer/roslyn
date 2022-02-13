// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class SynthesizedExplicitImplementationForwardingMethod : SynthesizedImplementationMethod
    {
        private readonly MethodSymbol _implementingMethod;

        public SynthesizedExplicitImplementationForwardingMethod(MethodSymbol interfaceMethod, MethodSymbol implementingMethod, NamedTypeSymbol implementingType)
        : base(f_10676_1579_1594_C(interfaceMethod), implementingType, generateDebugInfo: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10676, 1405, 1716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10676, 1373, 1392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10676, 1664, 1705);

                _implementingMethod = implementingMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10676, 1405, 1716);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10676, 1405, 1716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10676, 1405, 1716);
            }
        }

        public MethodSymbol ImplementingMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10676, 1791, 1826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10676, 1797, 1824);

                    return _implementingMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10676, 1791, 1826);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10676, 1728, 1837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10676, 1728, 1837);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10676, 1911, 2122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10676, 1947, 2107);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10676, 1954, 1986) || ((f_10676_1954_1986(_implementingMethod) && DynAbs.Tracing.TraceSender.Conditional_F2(10676, 2010, 2040)) || DynAbs.Tracing.TraceSender.Conditional_F3(10676, 2064, 2106))) ? f_10676_2010_2040(_implementingMethod) : MethodKind.ExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10676, 1911, 2122);

                    bool
                    f_10676_1954_1986(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodSymbol)
                    {
                        var return_v = methodSymbol.IsAccessor();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10676, 1954, 1986);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10676_2010_2040(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10676, 2010, 2040);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10676, 1849, 2133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10676, 1849, 2133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10676_1579_1594_C(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10676, 1405, 1716);
            return return_v;
        }

    }
}
