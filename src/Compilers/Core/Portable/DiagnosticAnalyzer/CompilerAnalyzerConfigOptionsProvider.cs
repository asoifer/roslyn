// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class CompilerAnalyzerConfigOptionsProvider : AnalyzerConfigOptionsProvider
    {
        private readonly ImmutableDictionary<object, AnalyzerConfigOptions> _treeDict;

        public static CompilerAnalyzerConfigOptionsProvider Empty { get; }

        internal CompilerAnalyzerConfigOptionsProvider(
                    ImmutableDictionary<object, AnalyzerConfigOptions> treeDict,
                    AnalyzerConfigOptions globalOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(251, 764, 1036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(251, 476, 485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(251, 1048, 1108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(251, 960, 981);

                _treeDict = treeDict;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(251, 995, 1025);

                GlobalOptions = globalOptions;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(251, 764, 1036);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(251, 764, 1036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(251, 764, 1036);
            }
        }

        public override AnalyzerConfigOptions GlobalOptions { get; }

        public override AnalyzerConfigOptions GetOptions(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(251, 1199, 1294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(251, 1202, 1294);

                // LAFHIS
                //return (DynAbs.Tracing.TraceSender.Conditional_F1(251, 1202, 1246) || 
                //    ((f_251_1202_1246(_treeDict, tree, out options) && 
                //    DynAbs.Tracing.TraceSender.Conditional_F2(251, 1249, 1256)) || 
                //    DynAbs.Tracing.TraceSender.Conditional_F3(251, 1259, 1294))) ? 
                //    options : f_251_1259_1294(); 

                DynAbs.Tracing.TraceSender.Conditional_F1(251, 1202, 1246);
                return
                    (f_251_1202_1246(_treeDict, tree, out var options) &&
                    DynAbs.Tracing.TraceSender.Conditional_F2(251, 1249, 1256)) ||
                    DynAbs.Tracing.TraceSender.Conditional_F3(251, 1259, 1294) ?
                    options : f_251_1259_1294();

                DynAbs.Tracing.TraceSender.TraceExitMethod(251, 1199, 1294);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(251, 1199, 1294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(251, 1199, 1294);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_251_1202_1246(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            key, out Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
            value)
            {
                var return_v = this_param.TryGetValue((object)key, out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(251, 1202, 1246);
                return return_v;
            }


            Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
            f_251_1259_1294()
            {
                var return_v = CompilerAnalyzerConfigOptions.Empty;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(251, 1259, 1294);
                return return_v;
            }

        }

        public override AnalyzerConfigOptions GetOptions(AdditionalText textFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(251, 1394, 1493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(251, 1397, 1493);

                // LAFHIS
                //return (DynAbs.Tracing.TraceSender.Conditional_F1(251, 1397, 1445) || 
                //    ((f_251_1397_1445(_treeDict, textFile, out options) && 
                //    DynAbs.Tracing.TraceSender.Conditional_F2(251, 1448, 1455)) || 
                //    DynAbs.Tracing.TraceSender.Conditional_F3(251, 1458, 1493))) ? options : 
                //    f_251_1458_1493(); 

                DynAbs.Tracing.TraceSender.Conditional_F1(251, 1397, 1445);
                return (f_251_1397_1445(_treeDict, textFile, out var options) &&
                    DynAbs.Tracing.TraceSender.Conditional_F2(251, 1448, 1455)) ||
                    DynAbs.Tracing.TraceSender.Conditional_F3(251, 1458, 1493) ? options :
                    f_251_1458_1493();

                DynAbs.Tracing.TraceSender.TraceExitMethod(251, 1394, 1493);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(251, 1394, 1493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(251, 1394, 1493);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_251_1397_1445(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
            this_param, Microsoft.CodeAnalysis.AdditionalText
            key, out Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
            value)
            {
                var return_v = this_param.TryGetValue((object)key, out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(251, 1397, 1445);
                return return_v;
            }


            Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
            f_251_1458_1493()
            {
                var return_v = CompilerAnalyzerConfigOptions.Empty;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(251, 1458, 1493);
                return return_v;
            }

        }

        internal CompilerAnalyzerConfigOptionsProvider WithAdditionalTreeOptions(ImmutableDictionary<object, AnalyzerConfigOptions> treeDict)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(251, 1653, 1742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(251, 1656, 1742);
                return f_251_1656_1742(f_251_1698_1726(_treeDict, treeDict), f_251_1728_1741()); DynAbs.Tracing.TraceSender.TraceExitMethod(251, 1653, 1742);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(251, 1653, 1742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(251, 1653, 1742);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
            f_251_1698_1726(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
            this_param, System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
            pairs)
            {
                var return_v = this_param.AddRange((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>>)pairs);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(251, 1698, 1726);
                return return_v;
            }


            Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
            f_251_1728_1741()
            {
                var return_v = GlobalOptions;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(251, 1728, 1741);
                return return_v;
            }


            Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
            f_251_1656_1742(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
            treeDict, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
            globalOptions)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider(treeDict, globalOptions);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(251, 1656, 1742);
                return return_v;
            }

        }

        internal CompilerAnalyzerConfigOptionsProvider WithGlobalOptions(AnalyzerConfigOptions globalOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(251, 1870, 1940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(251, 1873, 1940);
                return f_251_1873_1940(_treeDict, globalOptions); DynAbs.Tracing.TraceSender.TraceExitMethod(251, 1870, 1940);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(251, 1870, 1940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(251, 1870, 1940);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
            f_251_1873_1940(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
            treeDict, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
            globalOptions)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider(treeDict, globalOptions);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(251, 1873, 1940);
                return return_v;
            }

        }

        static CompilerAnalyzerConfigOptionsProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(251, 300, 1948);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(251, 498, 752);
            Empty = f_251_580_751(ImmutableDictionary<object, AnalyzerConfigOptions>.Empty, f_251_715_750()); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(251, 300, 1948);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(251, 300, 1948);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(251, 300, 1948);

        static Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
        f_251_715_750()
        {
            var return_v = CompilerAnalyzerConfigOptions.Empty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(251, 715, 750);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
        f_251_580_751(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
        treeDict, Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
        globalOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider(treeDict, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions)globalOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(251, 580, 751);
            return return_v;
        }

    }
}
