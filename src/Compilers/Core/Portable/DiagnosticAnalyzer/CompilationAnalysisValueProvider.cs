// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class CompilationAnalysisValueProvider<TKey, TValue>
            where TKey : class
    {
        private readonly AnalysisValueProvider<TKey, TValue> _analysisValueProvider;

        private readonly Dictionary<TKey, TValue> _valueMap;

        public CompilationAnalysisValueProvider(AnalysisValueProvider<TKey, TValue> analysisValueProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(243, 1015, 1286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 918, 940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 993, 1002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 1138, 1185);

                _analysisValueProvider = analysisValueProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 1199, 1275);

                _valueMap = f_243_1211_1274<TKey, TValue>(f_243_1240_1273<TKey, TValue>(analysisValueProvider));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(243, 1015, 1286);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(243, 1015, 1286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(243, 1015, 1286);
            }
        }

        internal bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(243, 1298, 2680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 1477, 1486);
                // First try to get the cached value for this compilation.
                lock (_valueMap)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 1520, 1634) || true) && (f_243_1524_1561(_valueMap, key, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(243, 1520, 1634);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 1603, 1615);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(243, 1520, 1634);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 1856, 2015) || true) && (!f_243_1861_1911(_analysisValueProvider, key, out value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(243, 1856, 2015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 1945, 1969);

                    value = default(TValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 1987, 2000);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(243, 1856, 2015);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 2106, 2115);

                // Store the value for the lifetime of the compilation.
                lock (_valueMap)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 2228, 2247);

                    TValue
                    storedValue
                    = default(TValue);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 2265, 2626) || true) && (f_243_2269_2312(_valueMap, key, out storedValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(243, 2265, 2626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 2413, 2433);

                        value = storedValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(243, 2265, 2626);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(243, 2265, 2626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 2581, 2607);

                        f_243_2581_2606(                    // Otherwise, store the value computed here.
                                            _valueMap, key, value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(243, 2265, 2626);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(243, 2657, 2669);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(243, 1298, 2680);

                bool
                f_243_1524_1561(System.Collections.Generic.Dictionary<TKey, TValue>
                this_param, TKey
                key, out TValue
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(243, 1524, 1561);
                    return return_v;
                }


                bool
                f_243_1861_1911(Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                this_param, TKey
                key, out TValue
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(243, 1861, 1911);
                    return return_v;
                }


                bool
                f_243_2269_2312(System.Collections.Generic.Dictionary<TKey, TValue>
                this_param, TKey
                key, out TValue
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(243, 2269, 2312);
                    return return_v;
                }


                int
                f_243_2581_2606(System.Collections.Generic.Dictionary<TKey, TValue>
                this_param, TKey
                key, TValue
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(243, 2581, 2606);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(243, 1298, 2680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(243, 1298, 2680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompilationAnalysisValueProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(243, 752, 2687);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(243, 752, 2687);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(243, 752, 2687);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(243, 752, 2687);

        static System.Collections.Generic.IEqualityComparer<TKey>
        f_243_1240_1273<TKey, TValue>(Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
        this_param) where TKey : class

        {
            var return_v = this_param.KeyComparer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(243, 1240, 1273);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<TKey, TValue>
        f_243_1211_1274<TKey, TValue>(System.Collections.Generic.IEqualityComparer<TKey>
        comparer) where TKey : class

        {
            var return_v = new System.Collections.Generic.Dictionary<TKey, TValue>(comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(243, 1211, 1274);
            return return_v;
        }

    }
}
