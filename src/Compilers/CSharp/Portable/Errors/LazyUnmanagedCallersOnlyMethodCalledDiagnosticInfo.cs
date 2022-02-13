// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class LazyUnmanagedCallersOnlyMethodCalledDiagnosticInfo : DiagnosticInfo
    {
        private DiagnosticInfo? _lazyActualUnmanagedCallersOnlyDiagnostic;

        private readonly MethodSymbol _method;

        private readonly bool _isDelegateConversion;

        internal LazyUnmanagedCallersOnlyMethodCalledDiagnosticInfo(MethodSymbol method, bool isDelegateConversion)
        : base(f_10615_772_803_C(CSharp.MessageProvider.Instance), (int)ErrorCode.Unknown)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10615, 644, 1003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 486, 527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 570, 577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 610, 631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 853, 870);

                _method = method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 884, 933);

                _lazyActualUnmanagedCallersOnlyDiagnostic = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 947, 992);

                _isDelegateConversion = isDelegateConversion;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10615, 644, 1003);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10615, 644, 1003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10615, 644, 1003);
            }
        }

        internal override DiagnosticInfo GetResolvedInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10615, 1015, 2278);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 1090, 2202) || true) && (_lazyActualUnmanagedCallersOnlyDiagnostic is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10615, 1090, 2202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 1177, 1314);

                    UnmanagedCallersOnlyAttributeData?
                    unmanagedCallersOnlyAttributeData = f_10615_1248_1313(_method, forceComplete: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 1332, 1447);

                    f_10615_1332_1446(!f_10615_1346_1445(unmanagedCallersOnlyAttributeData, UnmanagedCallersOnlyAttributeData.Uninitialized));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 1465, 1595);

                    f_10615_1465_1594(!f_10615_1479_1593(unmanagedCallersOnlyAttributeData, UnmanagedCallersOnlyAttributeData.AttributePresentDataNotBound));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 1615, 2080);

                    var
                    info = (DynAbs.Tracing.TraceSender.Conditional_F1(10615, 1626, 1667) || ((unmanagedCallersOnlyAttributeData is null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10615, 1691, 1726)) || DynAbs.Tracing.TraceSender.Conditional_F3(10615, 1750, 2079))) ? CSDiagnosticInfo.VoidDiagnosticInfo
                    : f_10615_1750_2079((DynAbs.Tracing.TraceSender.Conditional_F1(10615, 1771, 1792) || ((_isDelegateConversion
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10615, 1843, 1911)) || DynAbs.Tracing.TraceSender.Conditional_F3(10615, 1962, 2025))) ? ErrorCode.ERR_UnmanagedCallersOnlyMethodsCannotBeConvertedToDelegate
                    : ErrorCode.ERR_UnmanagedCallersOnlyMethodsCannotBeCalledDirectly, _method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 2100, 2187);

                    f_10615_2100_2186(ref _lazyActualUnmanagedCallersOnlyDiagnostic, info, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10615, 1090, 2202);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10615, 2218, 2267);

                return _lazyActualUnmanagedCallersOnlyDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10615, 1015, 2278);

                Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                f_10615_1248_1313(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, bool
                forceComplete)
                {
                    var return_v = this_param.GetUnmanagedCallersOnlyAttributeData(forceComplete: forceComplete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10615, 1248, 1313);
                    return return_v;
                }


                bool
                f_10615_1346_1445(Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                objA, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10615, 1346, 1445);
                    return return_v;
                }


                int
                f_10615_1332_1446(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10615, 1332, 1446);
                    return 0;
                }


                bool
                f_10615_1479_1593(Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                objA, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10615, 1479, 1593);
                    return return_v;
                }


                int
                f_10615_1465_1594(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10615, 1465, 1594);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10615_1750_2079(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10615, 1750, 2079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10615_2100_2186(ref Microsoft.CodeAnalysis.DiagnosticInfo?
                location1, Microsoft.CodeAnalysis.DiagnosticInfo
                value, Microsoft.CodeAnalysis.DiagnosticInfo?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10615, 2100, 2186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10615, 1015, 2278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10615, 1015, 2278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LazyUnmanagedCallersOnlyMethodCalledDiagnosticInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10615, 356, 2285);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10615, 356, 2285);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10615, 356, 2285);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10615, 356, 2285);

        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_10615_772_803_C(Microsoft.CodeAnalysis.CommonMessageProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10615, 644, 1003);
            return return_v;
        }

    }
}
