// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class ConstantEvaluationHelpers
    {
        [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
        internal struct FieldInfo
        {

            public readonly SourceFieldSymbolWithSyntaxReference Field;

            public readonly bool StartsCycle;

            public FieldInfo(SourceFieldSymbolWithSyntaxReference field, bool startsCycle)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10223, 827, 1021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 938, 957);

                    this.Field = field;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 975, 1006);

                    this.StartsCycle = startsCycle;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10223, 827, 1021);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10223, 827, 1021);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10223, 827, 1021);
                }
            }

            private string GetDebuggerDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10223, 1037, 1304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 1105, 1139);

                    var
                    value = f_10223_1117_1138(this.Field)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 1157, 1258) || true) && (this.StartsCycle)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 1157, 1258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 1219, 1239);

                        value += " [cycle]";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 1157, 1258);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 1276, 1289);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10223, 1037, 1304);

                    string
                    f_10223_1117_1138(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 1117, 1138);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10223, 1037, 1304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10223, 1037, 1304);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static FieldInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10223, 598, 1315);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10223, 598, 1315);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10223, 598, 1315);
            }
        }

        internal static void OrderAllDependencies(
                    this SourceFieldSymbolWithSyntaxReference field,
                    ArrayBuilder<FieldInfo> order,
                    bool earlyDecodingWellKnownAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10223, 1920, 3004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2145, 2176);

                f_10223_2145_2175(f_10223_2158_2169(order) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2192, 2317);

                var
                graph = f_10223_2204_2316()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2333, 2393);

                f_10223_2333_2392(graph, field, earlyDecodingWellKnownAttributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2409, 2440);

                f_10223_2409_2439(f_10223_2422_2433(graph) >= 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2454, 2472);

                f_10223_2454_2471(graph);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2499, 2577);

                var
                fields = f_10223_2512_2576()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2591, 2619);

                f_10223_2591_2618(fields, f_10223_2607_2617(graph));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2643, 2668);

                f_10223_2643_2667(graph, order);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2768, 2867);

                var
                map = f_10223_2778_2866(f_10223_2828_2865(f_10223_2828_2854(order, o => o.Field)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2881, 2928);

                f_10223_2881_2927(f_10223_2894_2926(fields, f => map.Contains(f)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2942, 2956);

                f_10223_2942_2955(fields);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 2980, 2993);

                f_10223_2980_2992(
                            graph);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10223, 1920, 3004);

                int
                f_10223_2158_2169(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 2158, 2169);
                    return return_v;
                }


                int
                f_10223_2145_2175(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2145, 2175);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                f_10223_2204_2316()
                {
                    var return_v = PooledDictionary<SourceFieldSymbolWithSyntaxReference, Node<SourceFieldSymbolWithSyntaxReference>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2204, 2316);
                    return return_v;
                }


                int
                f_10223_2333_2392(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                graph, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                field, bool
                earlyDecodingWellKnownAttributes)
                {
                    CreateGraph((System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>)graph, field, earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2333, 2392);
                    return 0;
                }


                int
                f_10223_2422_2433(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 2422, 2433);
                    return return_v;
                }


                int
                f_10223_2409_2439(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2409, 2439);
                    return 0;
                }


                int
                f_10223_2454_2471(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                graph)
                {
                    CheckGraph((System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>)graph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2454, 2471);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_2512_2576()
                {
                    var return_v = ArrayBuilder<SourceFieldSymbolWithSyntaxReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2512, 2576);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>.KeyCollection
                f_10223_2607_2617(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 2607, 2617);
                    return return_v;
                }


                int
                f_10223_2591_2618(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>.KeyCollection
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2591, 2618);
                    return 0;
                }


                int
                f_10223_2643_2667(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                graph, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo>
                order)
                {
                    OrderGraph((System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>)graph, order);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2643, 2667);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_2828_2854(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2828, 2854);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_2828_2865(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                source)
                {
                    var return_v = source.Distinct<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2828, 2865);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_2778_2866(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2778, 2866);
                    return return_v;
                }


                bool
                f_10223_2894_2926(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                builder, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, bool>
                predicate)
                {
                    var return_v = builder.All<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2894, 2926);
                    return return_v;
                }


                int
                f_10223_2881_2927(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2881, 2927);
                    return 0;
                }


                int
                f_10223_2942_2955(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2942, 2955);
                    return 0;
                }


                int
                f_10223_2980_2992(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 2980, 2992);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10223, 1920, 3004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10223, 1920, 3004);
            }
        }

        private struct Node<T> where T : class
        {

            public ImmutableHashSet<T> Dependencies;

            public ImmutableHashSet<T> DependedOnBy;
            static Node()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10223, 3016, 3420);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10223, 3016, 3420);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10223, 3016, 3420);
            }
        }

        private static void CreateGraph(
                    Dictionary<SourceFieldSymbolWithSyntaxReference, Node<SourceFieldSymbolWithSyntaxReference>> graph,
                    SourceFieldSymbolWithSyntaxReference field,
                    bool earlyDecodingWellKnownAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10223, 3566, 5963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 3845, 3924);

                var
                pending = f_10223_3859_3923()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 3938, 3958);

                f_10223_3938_3957(pending, field);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 3974, 5921) || true) && (f_10223_3981_3994(pending) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 3974, 5921);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 4032, 4054);

                        field = f_10223_4040_4053(pending);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 4074, 4122);

                        Node<SourceFieldSymbolWithSyntaxReference>
                        node
                        = default(Node<SourceFieldSymbolWithSyntaxReference>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 4140, 4641) || true) && (f_10223_4144_4178(graph, field, out node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 4140, 4641);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 4220, 4381) || true) && (node.Dependencies != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 4220, 4381);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 4349, 4358);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 4220, 4381);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 4140, 4641);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 4140, 4641);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 4463, 4519);

                            node = f_10223_4470_4518();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 4541, 4622);

                            node.DependedOnBy = ImmutableHashSet<SourceFieldSymbolWithSyntaxReference>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 4140, 4641);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 4661, 4749);

                        var
                        dependencies = f_10223_4680_4748(field, earlyDecodingWellKnownAttributes)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 5266, 5299);

                        node.Dependencies = dependencies;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 5317, 5337);

                        graph[field] = node;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 5357, 5906);
                            foreach (var dependency in f_10223_5384_5396_I(dependencies))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 5357, 5906);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 5438, 5463);

                                f_10223_5438_5462(pending, dependency);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 5487, 5767) || true) && (!f_10223_5492_5531(graph, dependency, out node))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 5487, 5767);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 5581, 5637);

                                    node = f_10223_5588_5636();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 5663, 5744);

                                    node.DependedOnBy = ImmutableHashSet<SourceFieldSymbolWithSyntaxReference>.Empty;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 5487, 5767);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 5791, 5840);

                                node.DependedOnBy = f_10223_5811_5839(node.DependedOnBy, field);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 5862, 5887);

                                graph[dependency] = node;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 5357, 5906);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 1, 550);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 1, 550);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 3974, 5921);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 3974, 5921);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 3974, 5921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 5937, 5952);

                f_10223_5937_5951(
                            pending);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10223, 3566, 5963);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_3859_3923()
                {
                    var return_v = ArrayBuilder<SourceFieldSymbolWithSyntaxReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 3859, 3923);
                    return return_v;
                }


                int
                f_10223_3938_3957(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 3938, 3957);
                    return 0;
                }


                int
                f_10223_3981_3994(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 3981, 3994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                f_10223_4040_4053(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 4040, 4053);
                    return return_v;
                }


                bool
                f_10223_4144_4178(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 4144, 4178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_4470_4518()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 4470, 4518);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_4680_4748(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                this_param, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValueDependencies(earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 4680, 4748);
                    return return_v;
                }


                int
                f_10223_5438_5462(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 5438, 5462);
                    return 0;
                }


                bool
                f_10223_5492_5531(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 5492, 5531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_5588_5636()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 5588, 5636);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_5811_5839(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 5811, 5839);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_5384_5396_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 5384, 5396);
                    return return_v;
                }


                int
                f_10223_5937_5951(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 5937, 5951);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10223, 3566, 5963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10223, 3566, 5963);
            }
        }

        private static void OrderGraph(
                    Dictionary<SourceFieldSymbolWithSyntaxReference, Node<SourceFieldSymbolWithSyntaxReference>> graph,
                    ArrayBuilder<FieldInfo> order)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10223, 5975, 10540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 6188, 6218);

                f_10223_6188_6217(f_10223_6201_6212(graph) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 6234, 6305);

                PooledHashSet<SourceFieldSymbolWithSyntaxReference>
                lastUpdated = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 6319, 6400);

                ArrayBuilder<SourceFieldSymbolWithSyntaxReference>
                fieldsInvolvedInCycles = null
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 6416, 10448) || true) && (f_10223_6423_6434(graph) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 6416, 10448);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 6554, 6646);

                        var
                        search = ((IEnumerable<SourceFieldSymbolWithSyntaxReference>)lastUpdated) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>?>(10223, 6567, 6645) ?? f_10223_6635_6645(graph))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 6664, 6739);

                        var
                        set = f_10223_6674_6738()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 6757, 7159);
                            foreach (var field in f_10223_6779_6785_I(search))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 6757, 7159);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 6827, 6875);

                                Node<SourceFieldSymbolWithSyntaxReference>
                                node
                                = default(Node<SourceFieldSymbolWithSyntaxReference>);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 6897, 7140) || true) && (f_10223_6901_6935(graph, field, out node))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 6897, 7140);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 6985, 7117) || true) && (f_10223_6989_7012(node.Dependencies) == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 6985, 7117);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 7075, 7090);

                                        f_10223_7075_7089(set, field);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 6985, 7117);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 6897, 7140);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 6757, 7159);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 1, 403);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 1, 403);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 7179, 7199);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(lastUpdated, 10223, 7179, 7198)?.Free(), 10223, 7191, 7198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 7217, 7236);

                        lastUpdated = null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 7254, 10402) || true) && (f_10223_7258_7267(set) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 7254, 10402);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 7313, 7393);

                            var
                            updated = f_10223_7327_7392()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 7492, 8164);
                                foreach (var field in f_10223_7514_7517_I(set))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 7492, 8164);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 7567, 7591);

                                    var
                                    node = f_10223_7578_7590(graph, field)
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 7748, 8093);
                                        foreach (var dependedOnBy in f_10223_7777_7794_I(node.DependedOnBy))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 7748, 8093);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 7852, 7880);

                                            var
                                            n = f_10223_7860_7879(graph, dependedOnBy)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 7910, 7956);

                                            n.Dependencies = f_10223_7927_7955(n.Dependencies, field);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 7986, 8010);

                                            graph[dependedOnBy] = n;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 8040, 8066);

                                            f_10223_8040_8065(updated, dependedOnBy);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 7748, 8093);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 1, 346);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 1, 346);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 8121, 8141);

                                    f_10223_8121_8140(
                                                            graph, field);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 7492, 8164);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 1, 673);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 1, 673);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 8188, 8206);

                            f_10223_8188_8205(graph);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 8287, 8435);
                                foreach (var item in f_10223_8308_8311_I(set))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 8287, 8435);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 8361, 8412);

                                    f_10223_8361_8411(order, f_10223_8371_8410(item, startsCycle: false));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 8287, 8435);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 1, 149);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 1, 149);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 8459, 8481);

                            lastUpdated = updated;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 7254, 10402);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 7254, 10402);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 8916, 8984);

                            var
                            field = f_10223_8928_8983(graph, ref fieldsInvolvedInCycles)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 9056, 9080);

                            var
                            node = f_10223_9067_9079(graph, field)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 9229, 9492);
                                foreach (var dependency in f_10223_9256_9273_I(node.Dependencies))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 9229, 9492);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 9323, 9349);

                                    var
                                    n = f_10223_9331_9348(graph, dependency)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 9375, 9421);

                                    n.DependedOnBy = f_10223_9392_9420(n.DependedOnBy, field);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 9447, 9469);

                                    graph[dependency] = n;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 9229, 9492);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 1, 264);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 1, 264);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 9516, 9536);

                            node = f_10223_9523_9535(graph, field);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 9558, 9638);

                            var
                            updated = f_10223_9572_9637()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 9783, 10104);
                                foreach (var dependedOnBy in f_10223_9812_9829_I(node.DependedOnBy))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 9783, 10104);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 9879, 9907);

                                    var
                                    n = f_10223_9887_9906(graph, dependedOnBy)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 9933, 9979);

                                    n.Dependencies = f_10223_9950_9978(n.Dependencies, field);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10005, 10029);

                                    graph[dependedOnBy] = n;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10055, 10081);

                                    f_10223_10055_10080(updated, dependedOnBy);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 9783, 10104);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 1, 322);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 1, 322);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10128, 10148);

                            f_10223_10128_10147(
                                                graph, field);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10172, 10190);

                            f_10223_10172_10189(graph);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10286, 10337);

                            f_10223_10286_10336(
                                                // Add the start of the cycle to the ordered list.
                                                order, f_10223_10296_10335(field, startsCycle: true));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10361, 10383);

                            lastUpdated = updated;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 7254, 10402);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10422, 10433);

                        f_10223_10422_10432(
                                        set);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 6416, 10448);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 6416, 10448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 6416, 10448);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10464, 10484);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(lastUpdated, 10223, 10464, 10483)?.Free(), 10223, 10476, 10483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10498, 10529);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(fieldsInvolvedInCycles, 10223, 10498, 10528)?.Free(), 10223, 10521, 10528);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10223, 5975, 10540);

                int
                f_10223_6201_6212(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 6201, 6212);
                    return return_v;
                }


                int
                f_10223_6188_6217(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 6188, 6217);
                    return 0;
                }


                int
                f_10223_6423_6434(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 6423, 6434);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>.KeyCollection
                f_10223_6635_6645(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 6635, 6645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_6674_6738()
                {
                    var return_v = ArrayBuilder<SourceFieldSymbolWithSyntaxReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 6674, 6738);
                    return return_v;
                }


                bool
                f_10223_6901_6935(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 6901, 6935);
                    return return_v;
                }


                int
                f_10223_6989_7012(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 6989, 7012);
                    return return_v;
                }


                int
                f_10223_7075_7089(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 7075, 7089);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_6779_6785_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 6779, 6785);
                    return return_v;
                }


                int
                f_10223_7258_7267(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 7258, 7267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_7327_7392()
                {
                    var return_v = PooledHashSet<SourceFieldSymbolWithSyntaxReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 7327, 7392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_7578_7590(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 7578, 7590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_7860_7879(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 7860, 7879);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_7927_7955(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 7927, 7955);
                    return return_v;
                }


                bool
                f_10223_8040_8065(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 8040, 8065);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_7777_7794_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 7777, 7794);
                    return return_v;
                }


                bool
                f_10223_8121_8140(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 8121, 8140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_7514_7517_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 7514, 7517);
                    return return_v;
                }


                int
                f_10223_8188_8205(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                graph)
                {
                    CheckGraph(graph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 8188, 8205);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo
                f_10223_8371_8410(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                field, bool
                startsCycle)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo(field, startsCycle: startsCycle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 8371, 8410);
                    return return_v;
                }


                int
                f_10223_8361_8411(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 8361, 8411);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_8308_8311_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 8308, 8311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                f_10223_8928_8983(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                graph, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>?
                fieldsInvolvedInCycles)
                {
                    var return_v = GetStartOfFirstCycle(graph, ref fieldsInvolvedInCycles);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 8928, 8983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_9067_9079(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 9067, 9079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_9331_9348(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 9331, 9348);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_9392_9420(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 9392, 9420);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_9256_9273_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 9256, 9273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_9523_9535(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 9523, 9535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_9572_9637()
                {
                    var return_v = PooledHashSet<SourceFieldSymbolWithSyntaxReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 9572, 9637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_9887_9906(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 9887, 9906);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_9950_9978(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 9950, 9978);
                    return return_v;
                }


                bool
                f_10223_10055_10080(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 10055, 10080);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_9812_9829_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 9812, 9829);
                    return return_v;
                }


                bool
                f_10223_10128_10147(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 10128, 10147);
                    return return_v;
                }


                int
                f_10223_10172_10189(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                graph)
                {
                    CheckGraph(graph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 10172, 10189);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo
                f_10223_10296_10335(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                field, bool
                startsCycle)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo(field, startsCycle: startsCycle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 10296, 10335);
                    return return_v;
                }


                int
                f_10223_10286_10336(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.FieldInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 10286, 10336);
                    return 0;
                }


                int
                f_10223_10422_10432(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 10422, 10432);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10223, 5975, 10540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10223, 5975, 10540);
            }
        }

        private static SourceFieldSymbolWithSyntaxReference GetStartOfFirstCycle(
                    Dictionary<SourceFieldSymbolWithSyntaxReference, Node<SourceFieldSymbolWithSyntaxReference>> graph,
                    ref ArrayBuilder<SourceFieldSymbolWithSyntaxReference> fieldsInvolvedInCycles)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10223, 10552, 11893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10855, 10885);

                f_10223_10855_10884(f_10223_10868_10879(graph) > 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10901, 11579) || true) && (fieldsInvolvedInCycles is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 10901, 11579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 10969, 11070);

                    fieldsInvolvedInCycles = f_10223_10994_11069(f_10223_11057_11068(graph));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 11332, 11564);

                    f_10223_11332_11563(                // We sort fields that belong to the same compilation by location to process cycles in deterministic order.
                                                        // Relative order between compilations is not important, cycles do not cross compilation boundaries. 
                                    fieldsInvolvedInCycles, f_10223_11364_11562(f_10223_11364_11418(f_10223_11364_11374(graph), static f => f.DeclaringCompilation), static g => g.OrderByDescending((f1, f2) => g.Key.CompareSourceLocations(f1.ErrorLocation, f2.ErrorLocation))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 10901, 11579);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 11595, 11882) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 11595, 11882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 11640, 11714);

                        SourceFieldSymbolWithSyntaxReference
                        field = f_10223_11685_11713(fieldsInvolvedInCycles)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 11734, 11867) || true) && (f_10223_11738_11762(graph, field) && (DynAbs.Tracing.TraceSender.Expression_True(10223, 11738, 11793) && f_10223_11766_11793(graph, field)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 11734, 11867);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 11835, 11848);

                            return field;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 11734, 11867);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 11595, 11882);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 11595, 11882);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 11595, 11882);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10223, 10552, 11893);

                int
                f_10223_10868_10879(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 10868, 10879);
                    return return_v;
                }


                int
                f_10223_10855_10884(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 10855, 10884);
                    return 0;
                }


                int
                f_10223_11057_11068(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 11057, 11068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_10994_11069(int
                capacity)
                {
                    var return_v = ArrayBuilder<SourceFieldSymbolWithSyntaxReference>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 10994, 11069);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>.KeyCollection
                f_10223_11364_11374(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 11364, 11374);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                f_10223_11364_11418(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>.KeyCollection
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
                keySelector)
                {
                    var return_v = source.GroupBy<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 11364, 11418);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_11364_11562(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                source, System.Func<System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                selector)
                {
                    var return_v = source.SelectMany<System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.CSharpCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 11364, 11562);
                    return return_v;
                }


                int
                f_10223_11332_11563(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 11332, 11563);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                f_10223_11685_11713(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 11685, 11713);
                    return return_v;
                }


                bool
                f_10223_11738_11762(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 11738, 11762);
                    return return_v;
                }


                bool
                f_10223_11766_11793(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                graph, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                field)
                {
                    var return_v = IsPartOfCycle(graph, field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 11766, 11793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10223, 10552, 11893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10223, 10552, 11893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsPartOfCycle(
                    Dictionary<SourceFieldSymbolWithSyntaxReference, Node<SourceFieldSymbolWithSyntaxReference>> graph,
                    SourceFieldSymbolWithSyntaxReference field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10223, 11905, 13082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12134, 12210);

                var
                set = f_10223_12144_12209()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12224, 12301);

                var
                stack = f_10223_12236_12300()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12317, 12369);

                SourceFieldSymbolWithSyntaxReference
                stopAt = field
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12383, 12403);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12417, 12435);

                f_10223_12417_12434(stack, field);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12451, 12989) || true) && (f_10223_12458_12469(stack) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 12451, 12989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12507, 12527);

                        field = f_10223_12515_12526(stack);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12545, 12569);

                        var
                        node = f_10223_12556_12568(graph, field)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12589, 12730) || true) && (f_10223_12593_12627(node.Dependencies, stopAt))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 12589, 12730);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12669, 12683);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(10223, 12705, 12711);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 12589, 12730);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12750, 12974);
                            foreach (var dependency in f_10223_12777_12794_I(node.Dependencies))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 12750, 12974);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12836, 12955) || true) && (f_10223_12840_12859(set, dependency))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 12836, 12955);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 12909, 12932);

                                    f_10223_12909_12931(stack, dependency);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 12836, 12955);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 12750, 12974);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 1, 225);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 1, 225);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 12451, 12989);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 12451, 12989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 12451, 12989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13005, 13018);

                f_10223_13005_13017(
                            stack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13032, 13043);

                f_10223_13032_13042(set);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13057, 13071);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10223, 11905, 13082);

                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_12144_12209()
                {
                    var return_v = PooledHashSet<SourceFieldSymbolWithSyntaxReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 12144, 12209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_12236_12300()
                {
                    var return_v = ArrayBuilder<SourceFieldSymbolWithSyntaxReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 12236, 12300);
                    return return_v;
                }


                int
                f_10223_12417_12434(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 12417, 12434);
                    return 0;
                }


                int
                f_10223_12458_12469(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 12458, 12469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                f_10223_12515_12526(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 12515, 12526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_12556_12568(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 12556, 12568);
                    return return_v;
                }


                bool
                f_10223_12593_12627(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 12593, 12627);
                    return return_v;
                }


                bool
                f_10223_12840_12859(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 12840, 12859);
                    return return_v;
                }


                int
                f_10223_12909_12931(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 12909, 12931);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_12777_12794_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 12777, 12794);
                    return return_v;
                }


                int
                f_10223_13005_13017(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 13005, 13017);
                    return 0;
                }


                int
                f_10223_13032_13042(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 13032, 13042);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10223, 11905, 13082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10223, 11905, 13082);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        private static void CheckGraph(Dictionary<SourceFieldSymbolWithSyntaxReference, Node<SourceFieldSymbolWithSyntaxReference>> graph)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10223, 13094, 14600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13376, 13387);

                int
                i = 10
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13403, 14468);
                    foreach (var pair in f_10223_13424_13429_I(graph))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 13403, 14468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13463, 13484);

                        var
                        field = pair.Key
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13502, 13524);

                        var
                        node = pair.Value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13544, 13584);

                        f_10223_13544_13583(node.Dependencies != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13602, 13642);

                        f_10223_13602_13641(node.DependedOnBy != null);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13662, 13986);
                            foreach (var dependency in f_10223_13689_13706_I(node.Dependencies))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 13662, 13986);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13748, 13793);

                                Node<SourceFieldSymbolWithSyntaxReference>
                                n
                                = default(Node<SourceFieldSymbolWithSyntaxReference>);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13815, 13861);

                                var
                                ok = f_10223_13824_13860(graph, dependency, out n)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13883, 13900);

                                f_10223_13883_13899(ok);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 13922, 13967);

                                f_10223_13922_13966(f_10223_13935_13965(n.DependedOnBy, field));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 13662, 13986);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 1, 325);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 1, 325);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 14006, 14334);
                            foreach (var dependedOnBy in f_10223_14035_14052_I(node.DependedOnBy))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 14006, 14334);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 14094, 14139);

                                Node<SourceFieldSymbolWithSyntaxReference>
                                n
                                = default(Node<SourceFieldSymbolWithSyntaxReference>);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 14161, 14209);

                                var
                                ok = f_10223_14170_14208(graph, dependedOnBy, out n)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 14231, 14248);

                                f_10223_14231_14247(ok);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 14270, 14315);

                                f_10223_14270_14314(f_10223_14283_14313(n.Dependencies, field));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 14006, 14334);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 1, 329);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 1, 329);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 14354, 14358);

                        i--;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 14376, 14453) || true) && (i == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10223, 14376, 14453);
                            DynAbs.Tracing.TraceSender.TraceBreak(10223, 14428, 14434);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 14376, 14453);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10223, 13403, 14468);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10223, 1, 1066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10223, 1, 1066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10223, 14484, 14589);

                f_10223_14484_14588(f_10223_14497_14540(f_10223_14497_14509(graph), n => n.DependedOnBy.Count) == f_10223_14544_14587(f_10223_14544_14556(graph), n => n.Dependencies.Count));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10223, 13094, 14600);

                int
                f_10223_13544_13583(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 13544, 13583);
                    return 0;
                }


                int
                f_10223_13602_13641(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 13602, 13641);
                    return 0;
                }


                bool
                f_10223_13824_13860(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 13824, 13860);
                    return return_v;
                }


                int
                f_10223_13883_13899(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 13883, 13899);
                    return 0;
                }


                bool
                f_10223_13935_13965(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 13935, 13965);
                    return return_v;
                }


                int
                f_10223_13922_13966(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 13922, 13966);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_13689_13706_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 13689, 13706);
                    return return_v;
                }


                bool
                f_10223_14170_14208(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 14170, 14208);
                    return return_v;
                }


                int
                f_10223_14231_14247(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 14231, 14247);
                    return 0;
                }


                bool
                f_10223_14283_14313(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 14283, 14313);
                    return return_v;
                }


                int
                f_10223_14270_14314(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 14270, 14314);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                f_10223_14035_14052_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 14035, 14052);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                f_10223_13424_13429_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 13424, 13429);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>.ValueCollection
                f_10223_14497_14509(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 14497, 14509);
                    return return_v;
                }


                int
                f_10223_14497_14540(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>.ValueCollection
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>, int>
                selector)
                {
                    var return_v = source.Sum<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 14497, 14540);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>.ValueCollection
                f_10223_14544_14556(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10223, 14544, 14556);
                    return return_v;
                }


                int
                f_10223_14544_14587(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference, Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>.ValueCollection
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>, int>
                selector)
                {
                    var return_v = source.Sum<Microsoft.CodeAnalysis.CSharp.Symbols.ConstantEvaluationHelpers.Node<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 14544, 14587);
                    return return_v;
                }


                int
                f_10223_14484_14588(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10223, 14484, 14588);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10223, 13094, 14600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10223, 13094, 14600);
            }
        }

        static ConstantEvaluationHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10223, 534, 14607);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10223, 534, 14607);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10223, 534, 14607);
        }

    }
}
