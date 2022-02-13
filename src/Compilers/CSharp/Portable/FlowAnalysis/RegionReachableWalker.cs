// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class RegionReachableWalker : AbstractRegionControlFlowPass
    {
        internal static void Analyze(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion,
                    out bool startPointIsReachable, out bool endPointIsReachable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10907, 633, 1543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 872, 967);

                var
                walker = f_10907_885_966(compilation, member, node, firstInRegion, lastInRegion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 981, 1027);

                var
                diagnostics = f_10907_999_1026()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 1041, 1064);

                bool
                badRegion = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 1114, 1157);

                    f_10907_1114_1156(walker, ref badRegion, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 1175, 1272);

                    startPointIsReachable = badRegion || (DynAbs.Tracing.TraceSender.Expression_False(10907, 1199, 1271) || f_10907_1212_1271(walker._regionStartPointIsReachable, true));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 1290, 1397);

                    endPointIsReachable = badRegion || (DynAbs.Tracing.TraceSender.Expression_False(10907, 1312, 1396) || f_10907_1325_1396(walker._regionEndPointIsReachable, walker.State.Alive));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10907, 1426, 1532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 1466, 1485);

                    f_10907_1466_1484(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 1503, 1517);

                    f_10907_1503_1516(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10907, 1426, 1532);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10907, 633, 1543);

                Microsoft.CodeAnalysis.CSharp.RegionReachableWalker
                f_10907_885_966(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.RegionReachableWalker(compilation, member, node, firstInRegion, lastInRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10907, 885, 966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10907_999_1026()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10907, 999, 1026);
                    return return_v;
                }


                bool
                f_10907_1114_1156(Microsoft.CodeAnalysis.CSharp.RegionReachableWalker
                this_param, ref bool
                badRegion, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Analyze(ref badRegion, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10907, 1114, 1156);
                    return return_v;
                }


                bool
                f_10907_1212_1271(bool?
                this_param, bool
                defaultValue)
                {
                    var return_v = this_param.GetValueOrDefault(defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10907, 1212, 1271);
                    return return_v;
                }


                bool
                f_10907_1325_1396(bool?
                this_param, bool
                defaultValue)
                {
                    var return_v = this_param.GetValueOrDefault(defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10907, 1325, 1396);
                    return return_v;
                }


                int
                f_10907_1466_1484(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10907, 1466, 1484);
                    return 0;
                }


                int
                f_10907_1503_1516(Microsoft.CodeAnalysis.CSharp.RegionReachableWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10907, 1503, 1516);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10907, 633, 1543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10907, 633, 1543);
            }
        }

        private bool? _regionStartPointIsReachable;

        private bool? _regionEndPointIsReachable;

        private RegionReachableWalker(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion)
        : base(f_10907_1822_1833_C(compilation), member, node, firstInRegion, lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10907, 1661, 1899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 1569, 1597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 1622, 1648);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10907, 1661, 1899);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10907, 1661, 1899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10907, 1661, 1899);
            }
        }

        protected override void EnterRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10907, 1911, 2065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 1973, 2021);

                _regionStartPointIsReachable = this.State.Alive;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 2035, 2054);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EnterRegion(), 10907, 2035, 2053);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10907, 1911, 2065);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10907, 1911, 2065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10907, 1911, 2065);
            }
        }

        protected override void LeaveRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10907, 2077, 2229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 2139, 2185);

                _regionEndPointIsReachable = this.State.Alive;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10907, 2199, 2218);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.LeaveRegion(), 10907, 2199, 2217);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10907, 2077, 2229);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10907, 2077, 2229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10907, 2077, 2229);
            }
        }

        static RegionReachableWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10907, 548, 2236);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10907, 548, 2236);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10907, 548, 2236);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10907, 548, 2236);

        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10907_1822_1833_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10907, 1661, 1899);
            return return_v;
        }

    }
}
