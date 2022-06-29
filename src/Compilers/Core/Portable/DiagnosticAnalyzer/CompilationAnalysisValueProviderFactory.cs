// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Threading;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class CompilationAnalysisValueProviderFactory
    {
        private Dictionary<object, object> _lazySharedStateProviderMap;

        public CompilationAnalysisValueProvider<TKey, TValue> GetValueProvider<TKey, TValue>(AnalysisValueProvider<TKey, TValue> analysisSharedStateProvider)
                    where TKey : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(244, 497, 1427);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(244, 703, 892) || true) && (_lazySharedStateProviderMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(244, 703, 892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(244, 776, 877);

                    f_244_776_876(ref _lazySharedStateProviderMap, f_244_837_869(), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(244, 703, 892);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(244, 908, 921);

                object
                value
                = default(object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(244, 941, 968);
                lock (_lazySharedStateProviderMap)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(244, 1002, 1322) || true) && (!f_244_1007_1086(_lazySharedStateProviderMap, analysisSharedStateProvider, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(244, 1002, 1322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(244, 1128, 1216);

                        value = f_244_1136_1215(analysisSharedStateProvider);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(244, 1238, 1303);

                        _lazySharedStateProviderMap[analysisSharedStateProvider] = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(244, 1002, 1322);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(244, 1353, 1416);

                return value as CompilationAnalysisValueProvider<TKey, TValue>;
                DynAbs.Tracing.TraceSender.TraceExitMethod(244, 497, 1427);

                System.Collections.Generic.Dictionary<object, object>
                f_244_837_869()
                {
                    var return_v = new System.Collections.Generic.Dictionary<object, object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(244, 837, 869);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<object, object>?
                f_244_776_876(ref System.Collections.Generic.Dictionary<object, object>?
                location1, System.Collections.Generic.Dictionary<object, object>
                value, System.Collections.Generic.Dictionary<object, object>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(244, 776, 876);
                    return return_v;
                }


                bool
                f_244_1007_1086(System.Collections.Generic.Dictionary<object, object>
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue((object)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(244, 1007, 1086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProvider<TKey, TValue>
                f_244_1136_1215(Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                analysisValueProvider)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProvider<TKey, TValue>(analysisValueProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(244, 1136, 1215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(244, 497, 1427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(244, 497, 1427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationAnalysisValueProviderFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(244, 344, 1434);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(244, 457, 484);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(244, 344, 1434);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(244, 344, 1434);
        }


        static CompilationAnalysisValueProviderFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(244, 344, 1434);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(244, 344, 1434);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(244, 344, 1434);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(244, 344, 1434);
    }
}
