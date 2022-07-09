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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(216, 1856, 2011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 1924, 1955);

                var
                value = f_216_1936_1954(this, key)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 1969, 2000);

                return f_216_1976_1999(value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(216, 1856, 2011);

                TValue
                f_216_1936_1954(Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                this_param, TKey
                arg)
                {
                    var return_v = this_param._computeValue(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(216, 1936, 1954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>.WrappedValue
                f_216_1976_1999(TValue?
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>.WrappedValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(216, 1976, 1999);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(216, 1856, 2011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(216, 1856, 2011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(216, 2023, 2548);
                // Catch any exceptions from the computeValue callback, which calls into user code.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 2257, 2318);

                    value = f_216_2265_2317(f_216_2265_2311(_valueCache, key, _valueCacheCallback));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 2336, 2366);

                    f_216_2336_2365(value is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 2384, 2396);

                    return true;
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(216, 2425, 2537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 2475, 2491);

                    value = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(216, 2509, 2522);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(216, 2425, 2537);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(216, 2023, 2548);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>.WrappedValue
                f_216_2265_2311(System.Runtime.CompilerServices.ConditionalWeakTable<TKey, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>.WrappedValue>
                this_param, TKey
                key, System.Runtime.CompilerServices.ConditionalWeakTable<TKey, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>.WrappedValue>.CreateValueCallback
                createValueCallback)
                {
                    var return_v = this_param.GetValue(key, createValueCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(216, 2265, 2311);
                    return return_v;
                }


                TValue?
                f_216_2265_2317(Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>.WrappedValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(216, 2265, 2317);
                    return return_v;
                }


                int
                f_216_2336_2365(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(216, 2336, 2365);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(216, 2023, 2548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(216, 2023, 2548);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
