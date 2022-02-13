// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class LazyObsoleteDiagnosticInfo : DiagnosticInfo
    {
        private DiagnosticInfo _lazyActualObsoleteDiagnostic;

        private readonly object _symbolOrSymbolWithAnnotations;

        private readonly Symbol _containingSymbol;

        private readonly BinderFlags _binderFlags;

        internal LazyObsoleteDiagnosticInfo(object symbol, Symbol containingSymbol, BinderFlags binderFlags)
        : base(f_10614_816_847_C(CSharp.MessageProvider.Instance), (int)ErrorCode.Unknown)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10614, 695, 1169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 482, 511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 548, 578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 613, 630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 670, 682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 897, 961);

                f_10614_897_960(symbol is Symbol || (DynAbs.Tracing.TraceSender.Expression_False(10614, 910, 959) || symbol is TypeWithAnnotations));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 975, 1015);

                _symbolOrSymbolWithAnnotations = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 1029, 1066);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 1080, 1107);

                _binderFlags = binderFlags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 1121, 1158);

                _lazyActualObsoleteDiagnostic = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10614, 695, 1169);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10614, 695, 1169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10614, 695, 1169);
            }
        }

        internal override DiagnosticInfo GetResolvedInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10614, 1181, 2592);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 1256, 2528) || true) && (_lazyActualObsoleteDiagnostic == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10614, 1256, 2528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 1537, 1655);

                    var
                    symbol = (_symbolOrSymbolWithAnnotations as Symbol) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol?>(10614, 1550, 1654) ?? ((TypeWithAnnotations)_symbolOrSymbolWithAnnotations).Type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 1673, 1713);

                    f_10614_1673_1712(symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 1733, 1843);

                    var
                    kind = f_10614_1744_1842(symbol, _containingSymbol, forceComplete: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 1861, 1911);

                    f_10614_1861_1910(kind != ObsoleteDiagnosticKind.Lazy);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 1929, 2000);

                    f_10614_1929_1999(kind != ObsoleteDiagnosticKind.LazyPotentiallySuppressed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 2020, 2198);

                    var
                    info = (DynAbs.Tracing.TraceSender.Conditional_F1(10614, 2031, 2074) || (((kind == ObsoleteDiagnosticKind.Diagnostic) && DynAbs.Tracing.TraceSender.Conditional_F2(10614, 2098, 2169)) || DynAbs.Tracing.TraceSender.Conditional_F3(10614, 2193, 2197))) ? f_10614_2098_2169(symbol, _binderFlags) : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 2399, 2513);

                    f_10614_2399_2512(ref _lazyActualObsoleteDiagnostic, info ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DiagnosticInfo?>(10614, 2462, 2505) ?? CSDiagnosticInfo.VoidDiagnosticInfo), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10614, 1256, 2528);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10614, 2544, 2581);

                return _lazyActualObsoleteDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10614, 1181, 2592);

                int
                f_10614_1673_1712(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    this_param.ForceCompleteObsoleteAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10614, 1673, 1712);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ObsoleteDiagnosticKind
                f_10614_1744_1842(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbol
                containingMember, bool
                forceComplete)
                {
                    var return_v = ObsoleteAttributeHelpers.GetObsoleteDiagnosticKind(symbol, containingMember, forceComplete: forceComplete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10614, 1744, 1842);
                    return return_v;
                }


                int
                f_10614_1861_1910(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10614, 1861, 1910);
                    return 0;
                }


                int
                f_10614_1929_1999(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10614, 1929, 1999);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10614_2098_2169(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.BinderFlags
                location)
                {
                    var return_v = ObsoleteAttributeHelpers.CreateObsoleteDiagnostic(symbol, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10614, 2098, 2169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10614_2399_2512(ref Microsoft.CodeAnalysis.DiagnosticInfo?
                location1, Microsoft.CodeAnalysis.DiagnosticInfo
                value, Microsoft.CodeAnalysis.DiagnosticInfo?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10614, 2399, 2512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10614, 1181, 2592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10614, 1181, 2592);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LazyObsoleteDiagnosticInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10614, 377, 2599);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10614, 377, 2599);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10614, 377, 2599);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10614, 377, 2599);

        int
        f_10614_897_960(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10614, 897, 960);
            return 0;
        }


        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_10614_816_847_C(Microsoft.CodeAnalysis.CommonMessageProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10614, 695, 1169);
            return return_v;
        }

    }
}
