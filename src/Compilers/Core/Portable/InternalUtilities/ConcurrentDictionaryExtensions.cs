// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Roslyn.Utilities
{
    internal static class ConcurrentDictionaryExtensions
    {
        public static void Add<K, V>(this ConcurrentDictionary<K, V> dict, K key, V value)
                    where K : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(314, 774, 1063);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(314, 912, 1052) || true) && (!f_314_917_940(dict, key, value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(314, 912, 1052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(314, 974, 1037);

                    throw f_314_980_1036("adding a duplicate", nameof(key));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(314, 912, 1052);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(314, 774, 1063);

                bool
                f_314_917_940(System.Collections.Concurrent.ConcurrentDictionary<K, V>
                this_param, K
                key, V?
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(314, 917, 940);
                    return return_v;
                }


                System.ArgumentException
                f_314_980_1036(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(314, 980, 1036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(314, 774, 1063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(314, 774, 1063);
            }
        }

        public static TValue GetOrAdd<TKey, TArg, TValue>(this ConcurrentDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TArg, TValue> valueFactory, TArg factoryArgument)
                    where TKey : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(314, 1075, 1682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(314, 1322, 1385);

                return f_314_1329_1384(dictionary, key, valueFactory, factoryArgument);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(314, 1075, 1682);

                TValue
                f_314_1329_1384(System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>
                this_param, TKey
                key, System.Func<TKey, TArg, TValue>
                valueFactory, TArg?
                factoryArgument)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory, factoryArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(314, 1329, 1384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(314, 1075, 1682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(314, 1075, 1682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ConcurrentDictionaryExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(314, 343, 1689);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(314, 343, 1689);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(314, 343, 1689);
        }

    }
}
