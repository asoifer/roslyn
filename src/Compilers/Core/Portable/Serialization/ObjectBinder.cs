// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal static class ObjectBinder
    {
        private static readonly object s_gate;

        private static ObjectBinderSnapshot? s_lastSnapshot;

        private static readonly Dictionary<Type, int> s_typeToIndex;

        private static readonly List<Type> s_types;

        private static readonly List<Func<ObjectReader, IObjectWritable>> s_typeReaders;

        public static ObjectBinderSnapshot GetSnapshot()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(541, 2003, 2364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 2082, 2088);
                lock (s_gate)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 2122, 2290) || true) && (s_lastSnapshot == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(541, 2122, 2290);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 2190, 2271);

                        s_lastSnapshot = f_541_2207_2270(s_typeToIndex, s_types, s_typeReaders);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(541, 2122, 2290);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 2310, 2338);

                    return s_lastSnapshot.Value;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(541, 2003, 2364);

                Roslyn.Utilities.ObjectBinderSnapshot
                f_541_2207_2270(System.Collections.Generic.Dictionary<System.Type, int>
                typeToIndex, System.Collections.Generic.List<System.Type>
                types, System.Collections.Generic.List<System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>>
                typeReaders)
                {
                    var return_v = new Roslyn.Utilities.ObjectBinderSnapshot(typeToIndex, types, typeReaders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(541, 2207, 2270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(541, 2003, 2364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(541, 2003, 2364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void RegisterTypeReader(Type type, Func<ObjectReader, IObjectWritable> typeReader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(541, 2376, 3111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 2503, 2509);
                lock (s_gate)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 2543, 2724) || true) && (f_541_2547_2578(s_typeToIndex, type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(541, 2543, 2724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 2698, 2705);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(541, 2543, 2724);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 2744, 2776);

                    int
                    index = f_541_2756_2775(s_typeReaders)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 2794, 2812);

                    f_541_2794_2811(s_types, type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 2830, 2860);

                    f_541_2830_2859(s_typeReaders, typeReader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 2878, 2909);

                    f_541_2878_2908(s_typeToIndex, type, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 3063, 3085);

                    s_lastSnapshot = null;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(541, 2376, 3111);

                bool
                f_541_2547_2578(System.Collections.Generic.Dictionary<System.Type, int>
                this_param, System.Type
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(541, 2547, 2578);
                    return return_v;
                }


                int
                f_541_2756_2775(System.Collections.Generic.List<System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(541, 2756, 2775);
                    return return_v;
                }


                int
                f_541_2794_2811(System.Collections.Generic.List<System.Type>
                this_param, System.Type
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(541, 2794, 2811);
                    return 0;
                }


                int
                f_541_2830_2859(System.Collections.Generic.List<System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>>
                this_param, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(541, 2830, 2859);
                    return 0;
                }


                int
                f_541_2878_2908(System.Collections.Generic.Dictionary<System.Type, int>
                this_param, System.Type
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(541, 2878, 2908);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(541, 2376, 3111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(541, 2376, 3111);
            }
        }

        static ObjectBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(541, 646, 3118);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 820, 834);
            s_gate = new(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 1170, 1191);
            s_lastSnapshot = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 1629, 1650);
            s_typeToIndex = new(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 1696, 1711);
            s_types = new(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(541, 1788, 1809);
            s_typeReaders = new(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(541, 646, 3118);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(541, 646, 3118);
        }

    }
}
