// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis
{
    internal static class GreenNodeExtensions
    {
        public static TNode WithAnnotationsGreen<TNode>(this TNode node, IEnumerable<SyntaxAnnotation> annotations) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(662, 424, 1481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 580, 646);

                var
                newAnnotations = f_662_601_645()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 660, 876);
                    foreach (var candidate in f_662_686_697_I(annotations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 660, 876);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 731, 861) || true) && (!f_662_736_770(newAnnotations, candidate))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 731, 861);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 812, 842);

                            f_662_812_841(newAnnotations, candidate);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(662, 731, 861);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(662, 660, 876);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(662, 1, 217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(662, 1, 217);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 892, 1470) || true) && (f_662_896_916(newAnnotations) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 892, 1470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 955, 977);

                    f_662_955_976(newAnnotations);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 995, 1043);

                    var
                    existingAnnotations = f_662_1021_1042(node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 1061, 1322) || true) && (existingAnnotations == null || (DynAbs.Tracing.TraceSender.Expression_False(662, 1065, 1127) || f_662_1096_1122(existingAnnotations) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 1061, 1322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 1169, 1181);

                        return node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(662, 1061, 1322);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 1061, 1322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 1263, 1303);

                        return (TNode)f_662_1277_1302(node, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(662, 1061, 1322);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(662, 892, 1470);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 892, 1470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 1388, 1455);

                    return (TNode)f_662_1402_1454(node, f_662_1422_1453(newAnnotations));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(662, 892, 1470);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(662, 424, 1481);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_662_601_645()
                {
                    var return_v = ArrayBuilder<SyntaxAnnotation>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 601, 645);
                    return return_v;
                }


                bool
                f_662_736_770(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 736, 770);
                    return return_v;
                }


                int
                f_662_812_841(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 812, 841);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_662_686_697_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 686, 697);
                    return return_v;
                }


                int
                f_662_896_916(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(662, 896, 916);
                    return return_v;
                }


                int
                f_662_955_976(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 955, 976);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_662_1021_1042(TNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 1021, 1042);
                    return return_v;
                }


                int
                f_662_1096_1122(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(662, 1096, 1122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_662_1277_1302(TNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation[]?
                annotations)
                {
                    var return_v = this_param.SetAnnotations(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 1277, 1302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_662_1422_1453(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param)
                {
                    var return_v = this_param.ToArrayAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 1422, 1453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_662_1402_1454(TNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = this_param.SetAnnotations(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 1402, 1454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(662, 424, 1481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(662, 424, 1481);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TNode WithAdditionalAnnotationsGreen<TNode>(this TNode node, IEnumerable<SyntaxAnnotation>? annotations) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(662, 1493, 2496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 1660, 1708);

                var
                existingAnnotations = f_662_1686_1707(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 1724, 1808) || true) && (annotations == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 1724, 1808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 1781, 1793);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(662, 1724, 1808);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 1824, 1890);

                var
                newAnnotations = f_662_1845_1889()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 1904, 1949);

                f_662_1904_1948(newAnnotations, existingAnnotations);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 1965, 2181);
                    foreach (var candidate in f_662_1991_2002_I(annotations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 1965, 2181);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 2036, 2166) || true) && (!f_662_2041_2075(newAnnotations, candidate))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 2036, 2166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 2117, 2147);

                            f_662_2117_2146(newAnnotations, candidate);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(662, 2036, 2166);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(662, 1965, 2181);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(662, 1, 217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(662, 1, 217);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 2197, 2485) || true) && (f_662_2201_2221(newAnnotations) == f_662_2225_2251(existingAnnotations))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 2197, 2485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 2285, 2307);

                    f_662_2285_2306(newAnnotations);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 2325, 2337);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(662, 2197, 2485);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 2197, 2485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 2403, 2470);

                    return (TNode)f_662_2417_2469(node, f_662_2437_2468(newAnnotations));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(662, 2197, 2485);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(662, 1493, 2496);

                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_662_1686_1707(TNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 1686, 1707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_662_1845_1889()
                {
                    var return_v = ArrayBuilder<SyntaxAnnotation>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 1845, 1889);
                    return return_v;
                }


                int
                f_662_1904_1948(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param, params Microsoft.CodeAnalysis.SyntaxAnnotation[]
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 1904, 1948);
                    return 0;
                }


                bool
                f_662_2041_2075(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 2041, 2075);
                    return return_v;
                }


                int
                f_662_2117_2146(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 2117, 2146);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_662_1991_2002_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 1991, 2002);
                    return return_v;
                }


                int
                f_662_2201_2221(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(662, 2201, 2221);
                    return return_v;
                }


                int
                f_662_2225_2251(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(662, 2225, 2251);
                    return return_v;
                }


                int
                f_662_2285_2306(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 2285, 2306);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_662_2437_2468(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param)
                {
                    var return_v = this_param.ToArrayAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 2437, 2468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_662_2417_2469(TNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = this_param.SetAnnotations(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 2417, 2469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(662, 1493, 2496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(662, 1493, 2496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TNode WithoutAnnotationsGreen<TNode>(this TNode node, IEnumerable<SyntaxAnnotation>? annotations) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(662, 2508, 3712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 2668, 2716);

                var
                existingAnnotations = f_662_2694_2715(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 2732, 2851) || true) && (annotations == null || (DynAbs.Tracing.TraceSender.Expression_False(662, 2736, 2790) || f_662_2759_2785(existingAnnotations) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 2732, 2851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 2824, 2836);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(662, 2732, 2851);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 2867, 2937);

                var
                removalAnnotations = f_662_2892_2936()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 2951, 2992);

                f_662_2951_2991(removalAnnotations, annotations);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 3042, 3148) || true) && (f_662_3046_3070(removalAnnotations) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 3042, 3148);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 3117, 3129);

                        return node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(662, 3042, 3148);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 3168, 3234);

                    var
                    newAnnotations = f_662_3189_3233()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 3252, 3504);
                        foreach (var candidate in f_662_3278_3297_I(existingAnnotations))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 3252, 3504);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 3339, 3485) || true) && (!f_662_3344_3382(removalAnnotations, candidate))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 3339, 3485);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 3432, 3462);

                                f_662_3432_3461(newAnnotations, candidate);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(662, 3339, 3485);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(662, 3252, 3504);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(662, 1, 253);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(662, 1, 253);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 3524, 3591);

                    return (TNode)f_662_3538_3590(node, f_662_3558_3589(newAnnotations));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(662, 3620, 3701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 3660, 3686);

                    f_662_3660_3685(removalAnnotations);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(662, 3620, 3701);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(662, 2508, 3712);

                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_662_2694_2715(TNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 2694, 2715);
                    return return_v;
                }


                int
                f_662_2759_2785(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(662, 2759, 2785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_662_2892_2936()
                {
                    var return_v = ArrayBuilder<SyntaxAnnotation>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 2892, 2936);
                    return return_v;
                }


                int
                f_662_2951_2991(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 2951, 2991);
                    return 0;
                }


                int
                f_662_3046_3070(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(662, 3046, 3070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_662_3189_3233()
                {
                    var return_v = ArrayBuilder<SyntaxAnnotation>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 3189, 3233);
                    return return_v;
                }


                bool
                f_662_3344_3382(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 3344, 3382);
                    return return_v;
                }


                int
                f_662_3432_3461(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 3432, 3461);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_662_3278_3297_I(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 3278, 3297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_662_3558_3589(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param)
                {
                    var return_v = this_param.ToArrayAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 3558, 3589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_662_3538_3590(TNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = this_param.SetAnnotations(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 3538, 3590);
                    return return_v;
                }


                int
                f_662_3660_3685(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 3660, 3685);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(662, 2508, 3712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(662, 2508, 3712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TNode WithDiagnosticsGreen<TNode>(this TNode node, DiagnosticInfo[]? diagnostics) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(662, 3724, 3926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 3868, 3915);

                return (TNode)f_662_3882_3914(node, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(662, 3724, 3926);

                Microsoft.CodeAnalysis.GreenNode
                f_662_3882_3914(TNode
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo[]?
                diagnostics)
                {
                    var return_v = this_param.SetDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 3882, 3914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(662, 3724, 3926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(662, 3724, 3926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TNode WithoutDiagnosticsGreen<TNode>(this TNode node) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(662, 3938, 4274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 4054, 4090);

                var
                current = f_662_4068_4089(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 4104, 4207) || true) && (current == null || (DynAbs.Tracing.TraceSender.Expression_False(662, 4108, 4146) || f_662_4127_4141(current) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(662, 4104, 4207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 4180, 4192);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(662, 4104, 4207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(662, 4223, 4263);

                return (TNode)f_662_4237_4262(node, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(662, 3938, 4274);

                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_662_4068_4089(TNode
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 4068, 4089);
                    return return_v;
                }


                int
                f_662_4127_4141(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(662, 4127, 4141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_662_4237_4262(TNode
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo[]?
                diagnostics)
                {
                    var return_v = this_param.SetDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(662, 4237, 4262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(662, 3938, 4274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(662, 3938, 4274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static GreenNodeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(662, 366, 4281);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(662, 366, 4281);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(662, 366, 4281);
        }

    }
}
