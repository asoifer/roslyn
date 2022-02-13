// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class LazyDiagnosticInfo : DiagnosticInfo
    {
        private DiagnosticInfo? _lazyInfo;

        protected LazyDiagnosticInfo()
        : base(f_10612_456_487_C(CSharp.MessageProvider.Instance), (int)ErrorCode.Unknown)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10612, 405, 534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10612, 383, 392);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10612, 405, 534);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10612, 405, 534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10612, 405, 534);
            }
        }

        internal sealed override DiagnosticInfo GetResolvedInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10612, 546, 845);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10612, 628, 801) || true) && (_lazyInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10612, 628, 801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10612, 683, 786);

                    f_10612_683_785(ref _lazyInfo, f_10612_726_739(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DiagnosticInfo?>(10612, 726, 778) ?? CSDiagnosticInfo.VoidDiagnosticInfo), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10612, 628, 801);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10612, 817, 834);

                return _lazyInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10612, 546, 845);

                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10612_726_739(Microsoft.CodeAnalysis.CSharp.LazyDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.ResolveInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10612, 726, 739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10612_683_785(ref Microsoft.CodeAnalysis.DiagnosticInfo?
                location1, Microsoft.CodeAnalysis.DiagnosticInfo
                value, Microsoft.CodeAnalysis.DiagnosticInfo?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10612, 683, 785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10612, 546, 845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10612, 546, 845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract DiagnosticInfo? ResolveInfo();

        static LazyDiagnosticInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10612, 283, 913);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10612, 283, 913);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10612, 283, 913);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10612, 283, 913);

        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_10612_456_487_C(Microsoft.CodeAnalysis.CommonMessageProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10612, 405, 534);
            return return_v;
        }

    }
}
