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
            // First try to get the cached value for this compilation.
            lock (_valueMap)
            {
                if (_valueMap.TryGetValue(key, out value))
                {
                    return true;
                }
            }

            // Ask the core analysis value provider for the value.
            // We do it outside the lock statement as this may call into user code which can be a long running operation.
            if (!_analysisValueProvider.TryGetValue(key, out value))
            {
                value = default(TValue);
                return false;
            }

            // Store the value for the lifetime of the compilation.
            lock (_valueMap)
            {
                // Check if another thread already stored the computed value.
                TValue storedValue;
                if (_valueMap.TryGetValue(key, out storedValue))
                {
                    // If so, we return the stored value.
                    value = storedValue;
                }
                else
                {
                    // Otherwise, store the value computed here.
                    _valueMap.Add(key, value);
                }
            }

            return true;
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
