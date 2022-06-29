// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Microsoft.CodeAnalysis
{
    internal static class DictionaryExtensions
    {
        public static TValue GetOrAdd<TKey, TValue>(
                    this Dictionary<TKey, TValue> dictionary,
                    TKey key,
                    TValue value)
                    where TKey : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(100, 715, 1182);
                TValue existingValue = default(TValue);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(100, 923, 1171) || true) && (f_100_927_977(dictionary, key, out existingValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(100, 923, 1171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(100, 1011, 1032);

                    return existingValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(100, 923, 1171);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(100, 923, 1171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(100, 1098, 1125);

                    f_100_1098_1124(dictionary, key, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(100, 1143, 1156);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(100, 923, 1171);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(100, 715, 1182);

                bool
                f_100_927_977(System.Collections.Generic.Dictionary<TKey, TValue>
                this_param, TKey
                key, out TValue?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(100, 927, 977);
                    return return_v;
                }


                int
                f_100_1098_1124(System.Collections.Generic.Dictionary<TKey, TValue>
                this_param, TKey
                key, TValue?
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(100, 1098, 1124);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(100, 715, 1182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(100, 715, 1182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DictionaryExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(100, 422, 1189);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(100, 422, 1189);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(100, 422, 1189);
        }

    }
}
