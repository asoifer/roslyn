// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal class AnalysisValueProvider<TKey, TValue>
            where TKey : class
    {
        private readonly Func<TKey, TValue> _computeValue;

        private readonly ConditionalWeakTable<TKey, WrappedValue> _valueCache;

        private readonly ConditionalWeakTable<TKey, WrappedValue>.CreateValueCallback _valueCacheCallback;

        internal IEqualityComparer<TKey> KeyComparer { get; private set; }

        public AnalysisValueProvider(Func<TKey, TValue> computeValue, IEqualityComparer<TKey> keyComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(216, 1197, 1624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 551, 564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 987, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 1087, 1106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 1119, 1185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 1320, 1349);

                _computeValue = computeValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 1363, 1423);

                KeyComparer = keyComparer ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEqualityComparer<TKey>>(216, 1377, 1422) ?? f_216_1392_1422<TKey>());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 1437, 1498);

                _valueCache = f_216_1451_1497<TKey>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 1512, 1613);

                _valueCacheCallback = new ConditionalWeakTable<TKey, WrappedValue>.CreateValueCallback(ComputeValue);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(216, 1197, 1624);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(216, 1197, 1624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(216, 1197, 1624);
            }
        }
        private sealed class WrappedValue
        {
            public WrappedValue(TValue value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(216, 1694, 1789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 1805, 1833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 1760, 1774);

                    Value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(216, 1694, 1789);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(216, 1694, 1789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(216, 1694, 1789);
                }
            }

            public TValue Value { get; }

            static WrappedValue()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(216, 1636, 1844);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(216, 1636, 1844);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(216, 1636, 1844);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(216, 1636, 1844);
        }

        private WrappedValue ComputeValue(TKey key)
        {
            var value = _computeValue(key);
            return new WrappedValue(value);
        }

        internal bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
        {
            // Catch any exceptions from the computeValue callback, which calls into user code.
            try
            {
                value = _valueCache.GetValue(key, _valueCacheCallback).Value;
                Debug.Assert(value is object);
                return true;
            }
            catch (Exception)
            {
                value = default;
                return false;
            }
        }

        static AnalysisValueProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(216, 420, 2555);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(216, 420, 2555);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(216, 420, 2555);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(216, 420, 2555);

        static System.Collections.Generic.EqualityComparer<TKey>
        f_216_1392_1422<TKey>() where TKey : class

        {
            var return_v = EqualityComparer<TKey>.Default;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(216, 1392, 1422);
            return return_v;
        }


        static System.Runtime.CompilerServices.ConditionalWeakTable<TKey, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>.WrappedValue>
        f_216_1451_1497<TKey>() where TKey : class

        {
            var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<TKey, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>.WrappedValue>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(216, 1451, 1497);
            return return_v;
        }

    }
}
