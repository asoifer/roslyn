// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public sealed class AnalyzerImageReference : AnalyzerReference
    {
        private readonly ImmutableArray<DiagnosticAnalyzer> _analyzers;

        private readonly string? _fullPath;

        private readonly string? _display;

        private readonly string _id;

        public AnalyzerImageReference(ImmutableArray<DiagnosticAnalyzer> analyzers, string? fullPath = null, string? display = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(233, 814, 1292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 710, 719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 755, 763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 798, 801);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 963, 1128) || true) && (analyzers.Any(a => a == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(233, 963, 1128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 1030, 1113);

                    throw f_233_1036_1112("Cannot have null-valued analyzer", nameof(analyzers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(233, 963, 1128);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 1144, 1167);

                _analyzers = analyzers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 1181, 1202);

                _fullPath = fullPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 1216, 1235);

                _display = display;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 1249, 1281);

                _id = Guid.NewGuid().ToString();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(233, 814, 1292);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(233, 814, 1292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(233, 814, 1292);
            }
        }

        public override ImmutableArray<DiagnosticAnalyzer> GetAnalyzersForAllLanguages()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(233, 1304, 1438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 1409, 1427);

                return _analyzers;
                DynAbs.Tracing.TraceSender.TraceExitMethod(233, 1304, 1438);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(233, 1304, 1438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(233, 1304, 1438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<DiagnosticAnalyzer> GetAnalyzers(string language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(233, 1450, 1584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 1555, 1573);

                return _analyzers;
                DynAbs.Tracing.TraceSender.TraceExitMethod(233, 1450, 1584);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(233, 1450, 1584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(233, 1450, 1584);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string? FullPath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(233, 1653, 1721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 1689, 1706);

                    return _fullPath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(233, 1653, 1721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(233, 1596, 1732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(233, 1596, 1732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(233, 1799, 1921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 1835, 1906);

                    return _display ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(233, 1842, 1905) ?? _fullPath ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(233, 1854, 1905) ?? f_233_1867_1905()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(233, 1799, 1921);

                    string
                    f_233_1867_1905()
                    {
                        var return_v = CodeAnalysisResources.InMemoryAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(233, 1867, 1905);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(233, 1744, 1932);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(233, 1744, 1932);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Id
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(233, 1994, 2056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2030, 2041);

                    return _id;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(233, 1994, 2056);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(233, 1944, 2067);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(233, 1944, 2067);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(233, 2079, 2611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2139, 2168);

                var
                sb = f_233_2148_2167()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2182, 2204);

                f_233_2182_2203(sb, "Assembly");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2220, 2383) || true) && (_fullPath != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(233, 2220, 2383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2275, 2296);

                    f_233_2275_2295(sb, " Path='");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2314, 2335);

                    f_233_2314_2334(sb, _fullPath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2353, 2368);

                    f_233_2353_2367(sb, "'");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(233, 2220, 2383);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2399, 2563) || true) && (_display != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(233, 2399, 2563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2453, 2477);

                    f_233_2453_2476(sb, " Display='");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2495, 2515);

                    f_233_2495_2514(sb, _display);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2533, 2548);

                    f_233_2533_2547(sb, "'");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(233, 2399, 2563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(233, 2579, 2600);

                return f_233_2586_2599(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(233, 2079, 2611);

                System.Text.StringBuilder
                f_233_2148_2167()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(233, 2148, 2167);
                    return return_v;
                }


                System.Text.StringBuilder
                f_233_2182_2203(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(233, 2182, 2203);
                    return return_v;
                }


                System.Text.StringBuilder
                f_233_2275_2295(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(233, 2275, 2295);
                    return return_v;
                }


                System.Text.StringBuilder
                f_233_2314_2334(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(233, 2314, 2334);
                    return return_v;
                }


                System.Text.StringBuilder
                f_233_2353_2367(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(233, 2353, 2367);
                    return return_v;
                }


                System.Text.StringBuilder
                f_233_2453_2476(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(233, 2453, 2476);
                    return return_v;
                }


                System.Text.StringBuilder
                f_233_2495_2514(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(233, 2495, 2514);
                    return return_v;
                }


                System.Text.StringBuilder
                f_233_2533_2547(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(233, 2533, 2547);
                    return return_v;
                }


                string
                f_233_2586_2599(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(233, 2586, 2599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(233, 2079, 2611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(233, 2079, 2611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AnalyzerImageReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(233, 480, 2618);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(233, 480, 2618);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(233, 480, 2618);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(233, 480, 2618);

        static System.ArgumentException
        f_233_1036_1112(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(233, 1036, 1112);
            return return_v;
        }

    }
}
