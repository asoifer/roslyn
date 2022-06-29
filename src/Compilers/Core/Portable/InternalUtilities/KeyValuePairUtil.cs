// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal static class KeyValuePairUtil
    {
        public static KeyValuePair<K, V> Create<K, V>(K key, V value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(344, 335, 474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(344, 421, 463);

                return f_344_428_462(key, value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(344, 335, 474);

                System.Collections.Generic.KeyValuePair<K, V>
                f_344_428_462(K?
                key, V?
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<K, V>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(344, 428, 462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(344, 335, 474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(344, 335, 474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> keyValuePair, out TKey key, out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(344, 486, 708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(344, 633, 656);

                key = keyValuePair.Key;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(344, 670, 697);

                value = keyValuePair.Value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(344, 486, 708);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(344, 486, 708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(344, 486, 708);
            }
        }

        public static KeyValuePair<TKey, TValue> ToKeyValuePair<TKey, TValue>(this (TKey, TValue) tuple)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(344, 817, 852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(344, 820, 852);
                return f_344_820_852(tuple.Item1, tuple.Item2); DynAbs.Tracing.TraceSender.TraceExitMethod(344, 817, 852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(344, 817, 852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(344, 817, 852);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.KeyValuePair<TKey, TValue>
            f_344_820_852(TKey?
            key, TValue?
            value)
            {
                var return_v = Create(key, value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(344, 820, 852);
                return return_v;
            }

        }

        static KeyValuePairUtil()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(344, 280, 860);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(344, 280, 860);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(344, 280, 860);
        }

    }
}
