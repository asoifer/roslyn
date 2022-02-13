// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.CodeGen
{
    internal class Optimizer
    {
        public static BoundStatement Optimize(
                    BoundStatement src, bool debugFriendly,
                    out HashSet<LocalSymbol> stackLocals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10968, 2196, 3232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 2479, 2553);

                var
                locals = f_10968_2492_2552()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 2567, 2645);

                src = (BoundStatement)f_10968_2589_2644(src, locals, debugFriendly);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 2661, 2692);

                f_10968_2661_2691(locals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 2708, 2730);

                BoundStatement
                result
                = default(BoundStatement);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 2744, 3050) || true) && (f_10968_2748_2760(locals) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 2744, 3050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 2799, 2818);

                    stackLocals = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 2836, 2849);

                    result = src;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 2744, 3050);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 2744, 3050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 2915, 2967);

                    stackLocals = f_10968_2929_2966(f_10968_2954_2965(locals));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 2985, 3035);

                    result = f_10968_2994_3034(src, locals);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 2744, 3050);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3066, 3161);
                    foreach (var info in f_10968_3087_3100_I(f_10968_3087_3100(locals)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 3066, 3161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3134, 3146);

                        f_10968_3134_3145(info);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 3066, 3161);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 96);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 96);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3177, 3191);

                f_10968_3177_3190(
                            locals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3207, 3221);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10968, 2196, 3232);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                f_10968_2492_2552()
                {
                    var return_v = PooledDictionary<LocalSymbol, LocalDefUseInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 2492, 2552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_2589_2644(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                locals, bool
                debugFriendly)
                {
                    var return_v = StackOptimizerPass1.Analyze((Microsoft.CodeAnalysis.CSharp.BoundNode)node, (System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>)locals, debugFriendly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 2589, 2644);
                    return return_v;
                }


                int
                f_10968_2661_2691(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                info)
                {
                    FilterValidStackLocals((System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 2661, 2691);
                    return 0;
                }


                int
                f_10968_2748_2760(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 2748, 2760);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>.KeyCollection
                f_10968_2954_2965(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 2954, 2965);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10968_2929_2966(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>.KeyCollection
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 2929, 2966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10968_2994_3034(Microsoft.CodeAnalysis.CSharp.BoundStatement
                src, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                info)
                {
                    var return_v = StackOptimizerPass2.Rewrite(src, (System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 2994, 3034);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>.ValueCollection
                f_10968_3087_3100(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 3087, 3100);
                    return return_v;
                }


                int
                f_10968_3134_3145(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 3134, 3145);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>.ValueCollection
                f_10968_3087_3100_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 3087, 3100);
                    return return_v;
                }


                int
                f_10968_3177_3190(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 3177, 3190);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 2196, 3232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 2196, 3232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void FilterValidStackLocals(Dictionary<LocalSymbol, LocalDefUseInfo> info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10968, 3244, 4265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3432, 3490);

                var
                dummies = f_10968_3446_3489()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3506, 3994);
                    foreach (var local in f_10968_3528_3547_I(f_10968_3528_3547(f_10968_3528_3537(info))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 3506, 3994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3581, 3607);

                        var
                        locInfo = f_10968_3595_3606(info, local)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3627, 3979) || true) && (f_10968_3631_3652(local) == SynthesizedLocalKind.OptimizerTemp)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 3627, 3979);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3732, 3753);

                            f_10968_3732_3752(dummies, locInfo);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3775, 3794);

                            f_10968_3775_3793(info, local);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 3627, 3979);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 3627, 3979);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3836, 3979) || true) && (f_10968_3840_3862(locInfo))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 3836, 3979);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3904, 3919);

                                f_10968_3904_3918(locInfo);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 3941, 3960);

                                f_10968_3941_3959(info, local);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 3836, 3979);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 3627, 3979);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 3506, 3994);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 489);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 4010, 4118) || true) && (f_10968_4014_4024(info) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 4010, 4118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 4063, 4103);

                    f_10968_4063_4102(info, dummies);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 4010, 4118);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 4134, 4225);
                    foreach (var dummy in f_10968_4156_4163_I(dummies))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 4134, 4225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 4197, 4210);

                        f_10968_4197_4209(dummy);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 4134, 4225);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 92);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 92);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 4239, 4254);

                f_10968_4239_4253(dummies);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10968, 3244, 4265);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                f_10968_3446_3489()
                {
                    var return_v = ArrayBuilder<LocalDefUseInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 3446, 3489);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>.KeyCollection
                f_10968_3528_3537(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 3528, 3537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol[]
                f_10968_3528_3547(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>.KeyCollection
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 3528, 3547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                f_10968_3595_3606(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 3595, 3606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10968_3631_3652(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 3631, 3652);
                    return return_v;
                }


                int
                f_10968_3732_3752(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 3732, 3752);
                    return 0;
                }


                bool
                f_10968_3775_3793(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 3775, 3793);
                    return return_v;
                }


                bool
                f_10968_3840_3862(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.CannotSchedule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 3840, 3862);
                    return return_v;
                }


                int
                f_10968_3904_3918(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 3904, 3918);
                    return 0;
                }


                bool
                f_10968_3941_3959(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 3941, 3959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol[]
                f_10968_3528_3547_I(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 3528, 3547);
                    return return_v;
                }


                int
                f_10968_4014_4024(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 4014, 4024);
                    return return_v;
                }


                int
                f_10968_4063_4102(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                info, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                dummies)
                {
                    RemoveIntersectingLocals(info, dummies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 4063, 4102);
                    return 0;
                }


                int
                f_10968_4197_4209(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 4197, 4209);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                f_10968_4156_4163_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 4156, 4163);
                    return return_v;
                }


                int
                f_10968_4239_4253(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 4239, 4253);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 3244, 4265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 3244, 4265);
            }
        }

        private static void RemoveIntersectingLocals(Dictionary<LocalSymbol, LocalDefUseInfo> info, ArrayBuilder<LocalDefUseInfo> dummies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10968, 4277, 8201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 4728, 4796);

                var
                defs = f_10968_4739_4795(f_10968_4781_4794(dummies))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 4810, 5161);
                    foreach (var dummy in f_10968_4832_4839_I(dummies))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 4810, 5161);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 4873, 5146);
                            foreach (var def in f_10968_4893_4908_I(f_10968_4893_4908(dummy)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 4873, 5146);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 5016, 5127) || true) && (def.Start != def.End)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 5016, 5127);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 5090, 5104);

                                    f_10968_5090_5103(defs, def);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 5016, 5127);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 4873, 5146);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 274);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 274);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 4810, 5161);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 5177, 5203);

                var
                dummyCnt = f_10968_5192_5202(defs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 5543, 5754);

                // LAFHIS
                //var
                //ordered = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from i in info
                //                                                                  from d in i.Value.LocalDefs
                //                                                                  orderby d.End - d.Start, d.End ascending
                //                                                                  select new { i = i.Key, d = d }, 10968, 5557, 5753);

                var
                ordered = from i in info
                        from d in i.Value.LocalDefs
                        orderby d.End - d.Start, d.End ascending
                        select new { i = i.Key, d = d };

                DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 5557, 5753);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 6128, 8162);
                    foreach (var pair in ordered /*f_10968_6149_6156_I(ordered)*/)
                    {
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 6149, 6156);

                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 6128, 8162);

                        // LAFHIS
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 6190, 6419);
                        var tempR = pair.i; //f_10968_6212_6218(pair);
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 6212, 6218);

                        if (!f_10968_6195_6219(info, tempR))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 6190, 6419);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 6391, 6400);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 6190, 6419);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 6439, 6459);

                        // LAFHIS
                        var newDef = pair.d; //f_10968_6452_6458(pair);
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 6452, 6458);

                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 6477, 6498);

                        var
                        cnt = f_10968_6487_6497(defs)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 6518, 6534);

                        bool
                        intersects
                        = default(bool);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 6677, 7881) || true) && (cnt > 5000)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 6677, 7881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 6930, 6948);

                            intersects = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 6677, 7881);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 6677, 7881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7030, 7049);

                            intersects = false;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7080, 7085);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7071, 7396) || true) && (i < dummyCnt)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7101, 7104)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 7071, 7396))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 7071, 7396);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7154, 7172);

                                    var
                                    def = f_10968_7164_7171(defs, i)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7200, 7373) || true) && (newDef.ConflictsWithDummy(def))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 7200, 7373);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7292, 7310);

                                        intersects = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10968, 7340, 7346);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 7200, 7373);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 326);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 326);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7420, 7862) || true) && (!intersects)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 7420, 7862);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7494, 7506);
                                    for (int
            i = dummyCnt
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7485, 7839) || true) && (i < cnt)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7517, 7520)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 7485, 7839))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 7485, 7839);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7578, 7596);

                                        var
                                        def = f_10968_7588_7595(defs, i)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7628, 7812) || true) && (newDef.ConflictsWith(def))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 7628, 7812);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7723, 7741);

                                            intersects = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(10968, 7775, 7781);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 7628, 7812);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 355);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 355);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 7420, 7862);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 6677, 7881);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7901, 8147) || true) && (intersects)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 7901, 8147);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 7957, 7987);

                            // LAFHIS
                            var tempI = pair.i; //f_10968_7962_7968(pair);
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 7962, 7968);

                            f_10968_7957_7986(f_10968_7957_7979(f_10968_7957_7969(info, tempI)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 8009, 8029);

                            // LAFHIS
                            var tempI2 = pair.i; // f_10968_8021_8027(pair)
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 8021, 8027);

                            f_10968_8009_8028(info, tempI2);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 7901, 8147);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 7901, 8147);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 8111, 8128);

                            f_10968_8111_8127(defs, newDef);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 7901, 8147);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 6128, 8162);
                    }
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 6149, 6156);
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 2035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 2035);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 8178, 8190);

                f_10968_8178_8189(
                            defs);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10968, 4277, 8201);

                int
                f_10968_4781_4794(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 4781, 4794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                f_10968_4739_4795(int
                capacity)
                {
                    var return_v = ArrayBuilder<LocalDefUseSpan>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 4739, 4795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                f_10968_4893_4908(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.LocalDefs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 4893, 4908);
                    return return_v;
                }


                int
                f_10968_5090_5103(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 5090, 5103);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                f_10968_4893_4908_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 4893, 4908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                f_10968_4832_4839_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 4832, 4839);
                    return return_v;
                }


                int
                f_10968_5192_5202(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 5192, 5202);
                    return return_v;
                }


                //Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                //f_10968_6212_6218(dynamic
                //this_param)
                //{
                //    var return_v = this_param.i;
                //    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 6212, 6218);
                //    return return_v;
                //}


                bool
                f_10968_6195_6219(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 6195, 6219);
                    return return_v;
                }


                //Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                //f_10968_6452_6458(dynamic
                //this_param)
                //{
                //    var return_v = this_param.d;
                //    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 6452, 6458);
                //    return return_v;
                //}


                int
                f_10968_6487_6497(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 6487, 6497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                f_10968_7164_7171(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 7164, 7171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                f_10968_7588_7595(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 7588, 7595);
                    return return_v;
                }


                //Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                //f_10968_7962_7968(dynamic
                //this_param)
                //{
                //    var return_v = this_param.i;
                //    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 7962, 7968);
                //    return return_v;
                //}


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                f_10968_7957_7969(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 7957, 7969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                f_10968_7957_7979(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.LocalDefs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 7957, 7979);
                    return return_v;
                }


                int
                f_10968_7957_7986(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 7957, 7986);
                    return 0;
                }


                //Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                //f_10968_8021_8027(dynamic
                //this_param)
                //{
                //    var return_v = this_param.i;
                //    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 8021, 8027);
                //    return return_v;
                //}


                bool
                f_10968_8009_8028(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 8009, 8028);
                    return return_v;
                }


                int
                f_10968_8111_8127(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 8111, 8127);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<dynamic>
                f_10968_6149_6156_I(System.Collections.Generic.IEnumerable<dynamic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 6149, 6156);
                    return return_v;
                }


                int
                f_10968_8178_8189(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 8178, 8189);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 4277, 8201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 4277, 8201);
            }
        }

        public Optimizer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10968, 681, 8208);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10968, 681, 8208);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 681, 8208);
        }


        static Optimizer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10968, 681, 8208);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10968, 681, 8208);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 681, 8208);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10968, 681, 8208);
    }
    internal class LocalDefUseInfo
    {
        public int StackAtDeclaration { get; private set; }

        private readonly ObjectPool<LocalDefUseInfo> _pool;

        private static readonly ObjectPool<LocalDefUseInfo> s_poolInstance;

        private ArrayBuilder<LocalDefUseSpan> _localDefs;

        public ArrayBuilder<LocalDefUseSpan> LocalDefs
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 9299, 9571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 9335, 9359);

                    var
                    result = _localDefs
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 9377, 9522) || true) && (result == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 9377, 9522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 9437, 9503);

                        _localDefs = result = f_10968_9459_9502();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 9377, 9522);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 9542, 9556);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 9299, 9571);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                    f_10968_9459_9502()
                    {
                        var return_v = ArrayBuilder<LocalDefUseSpan>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 9459, 9502);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 9228, 9582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 9228, 9582);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool CannotSchedule { get; private set; }

        public void ShouldNotSchedule()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 9735, 9829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 9791, 9818);

                this.CannotSchedule = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 9735, 9829);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 9735, 9829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 9735, 9829);
            }
        }

        private LocalDefUseInfo(ObjectPool<LocalDefUseInfo> pool)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10968, 9841, 9947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 8878, 8929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 8984, 8989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 9207, 9217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 9675, 9723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 9923, 9936);

                _pool = pool;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10968, 9841, 9947);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 9841, 9947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 9841, 9947);
            }
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 9959, 10172);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10002, 10127) || true) && (_localDefs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 10002, 10127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10058, 10076);

                    f_10968_10058_10075(_localDefs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10094, 10112);

                    _localDefs = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 10002, 10127);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10143, 10161);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_pool, 10968, 10143, 10160)?.Free(this), 10968, 10149, 10160);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 9959, 10172);

                int
                f_10968_10058_10075(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 10058, 10075);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 9959, 10172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 9959, 10172);
            }
        }

        public static ObjectPool<LocalDefUseInfo> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10968, 10231, 10478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10310, 10350);

                ObjectPool<LocalDefUseInfo>
                pool = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10364, 10441);

                pool = f_10968_10371_10440(() => new LocalDefUseInfo(pool), 128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10455, 10467);

                return pool;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10968, 10231, 10478);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                f_10968_10371_10440(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>.Factory
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 10371, 10440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 10231, 10478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 10231, 10478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static LocalDefUseInfo GetInstance(int stackAtDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10968, 10490, 10827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10580, 10621);

                var
                instance = f_10968_10595_10620(s_poolInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10635, 10677);

                f_10968_10635_10676(instance._localDefs == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10691, 10740);

                instance.StackAtDeclaration = stackAtDeclaration;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10754, 10786);

                instance.CannotSchedule = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 10800, 10816);

                return instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10968, 10490, 10827);

                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                f_10968_10595_10620(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 10595, 10620);
                    return return_v;
                }


                int
                f_10968_10635_10676(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 10635, 10676);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 10490, 10827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 10490, 10827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LocalDefUseInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10968, 8763, 10834);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 9078, 9107);
            s_poolInstance = f_10968_9095_9107(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10968, 8763, 10834);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 8763, 10834);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10968, 8763, 10834);

        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
        f_10968_9095_9107()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 9095, 9107);
            return return_v;
        }

    }

    internal struct LocalDefUseSpan
    {

        public readonly int Start;

        public readonly int End;

        public LocalDefUseSpan(int start) : this(f_10968_11237_11242_C(start), start)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10968, 11196, 11254);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10968, 11196, 11254);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 11196, 11254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 11196, 11254);
            }
        }

        private LocalDefUseSpan(int start, int end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10968, 11266, 11393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 11334, 11353);

                this.Start = start;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 11367, 11382);

                this.End = end;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10968, 11266, 11393);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 11266, 11393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 11266, 11393);
            }
        }

        internal LocalDefUseSpan WithEnd(int end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 11405, 11526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 11471, 11515);

                return f_10968_11478_11514(this.Start, end);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 11405, 11526);

                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                f_10968_11478_11514(int
                start, int
                end)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 11478, 11514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 11405, 11526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 11405, 11526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 11538, 11655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 11596, 11644);

                // LAFHIS
                var temp1 = (this.Start).ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 11609, 11619);
                var temp2 = (this.End).ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 11629, 11637);

                return "[" + temp1 + " ," + temp2 + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 11538, 11655);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 11538, 11655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 11538, 11655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ConflictsWith(LocalDefUseSpan other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 12267, 12402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 12340, 12391);

                return Contains(other.Start) ^ Contains(other.End);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 12267, 12402);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 12267, 12402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 12267, 12402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool Contains(int val)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 12414, 12522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 12469, 12511);

                return this.Start < val && (DynAbs.Tracing.TraceSender.Expression_True(10968, 12476, 12510) && this.End > val);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 12414, 12522);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 12414, 12522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 12414, 12522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ConflictsWithDummy(LocalDefUseSpan dummy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 12960, 13100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 13038, 13089);

                return Includes(dummy.Start) ^ Includes(dummy.End);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 12960, 13100);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 12960, 13100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 12960, 13100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool Includes(int val)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 13112, 13222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 13167, 13211);

                return this.Start <= val && (DynAbs.Tracing.TraceSender.Expression_True(10968, 13174, 13210) && this.End >= val);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 13112, 13222);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 13112, 13222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 13112, 13222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static LocalDefUseSpan()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10968, 11076, 13229);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10968, 11076, 13229);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 11076, 13229);
        }

        static int
        f_10968_11237_11242_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10968, 11196, 11254);
            return return_v;
        }

    }

    // context of expression evaluation. 
    // it will affect inference of stack behavior
    // it will also affect when locals can be scheduled to the stack
    // Example:
    //      Goo(x, ref x)     <-- x cannot be a stack local as it is used in different contexts.
    internal enum ExprContext
    {
        None,
        Sideeffects,
        Value,
        Address,
        AssignmentTarget,
        Box
    }
    internal sealed class StackOptimizerPass1 : BoundTreeRewriter
    {
        private readonly bool _debugFriendly;

        private readonly ArrayBuilder<(BoundExpression, ExprContext)> _evalStack;

        private int _counter;

        private ExprContext _context;

        private BoundLocal _assignmentLocal;

        private readonly Dictionary<LocalSymbol, LocalDefUseInfo> _locals;

        private readonly SmallDictionary<object, DummyLocal> _dummyVariables;

        public static readonly DummyLocal empty;

        private int _recursionDepth;

        private StackOptimizerPass1(Dictionary<LocalSymbol, LocalDefUseInfo> locals,
                    ArrayBuilder<ValueTuple<BoundExpression, ExprContext>> evalStack,
                    bool debugFriendly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10968, 15315, 15761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 14170, 14184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 14257, 14267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 14292, 14300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 14331, 14339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 14369, 14385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 14456, 14525);
                this._locals = f_10968_14479_14525(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 14915, 15021);
                this._dummyVariables = f_10968_14946_15021(ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 15287, 15302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 15528, 15545);

                _locals = locals;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 15559, 15582);

                _evalStack = evalStack;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 15596, 15627);

                _debugFriendly = debugFriendly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 15689, 15712);

                f_10968_15689_15711(this, empty, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 15726, 15750);

                f_10968_15726_15749(this, empty);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10968, 15315, 15761);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 15315, 15761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 15315, 15761);
            }
        }

        public static BoundNode Analyze(
                    BoundNode node,
                    Dictionary<LocalSymbol, LocalDefUseInfo> locals,
                    bool debugFriendly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10968, 15773, 16252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 15954, 16039);

                var
                evalStack = f_10968_15970_16038()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16053, 16126);

                var
                analyzer = f_10968_16068_16125(locals, evalStack, debugFriendly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16140, 16177);

                var
                rewritten = f_10968_16156_16176(analyzer, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16191, 16208);

                f_10968_16191_16207(evalStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16224, 16241);

                return rewritten;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10968, 15773, 16252);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext)>
                f_10968_15970_16038()
                {
                    var return_v = ArrayBuilder<ValueTuple<BoundExpression, ExprContext>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 15970, 16038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                f_10968_16068_16125(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                locals, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext)>
                evalStack, bool
                debugFriendly)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1(locals, evalStack, debugFriendly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 16068, 16125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_16156_16176(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 16156, 16176);
                    return return_v;
                }


                int
                f_10968_16191_16207(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 16191, 16207);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 15773, 16252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 15773, 16252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode Visit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 16264, 16743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16336, 16353);

                BoundNode
                result
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16369, 16416);

                BoundExpression
                expr = node as BoundExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16430, 16702) || true) && (expr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 16430, 16702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16480, 16523);

                    f_10968_16480_16522(f_10968_16493_16502(expr) != BoundKind.Label);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16541, 16591);

                    result = f_10968_16550_16590(this, expr, ExprContext.Value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 16430, 16702);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 16430, 16702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16657, 16687);

                    result = f_10968_16666_16686(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 16430, 16702);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16718, 16732);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 16264, 16743);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_16493_16502(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 16493, 16502);
                    return return_v;
                }


                int
                f_10968_16480_16522(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 16480, 16522);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_16550_16590(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 16550, 16590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_16666_16686(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = this_param.VisitStatement(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 16666, 16686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 16264, 16743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 16264, 16743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitExpressionCore(BoundExpression node, ExprContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 16755, 17931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16866, 16893);

                var
                prevContext = _context
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16907, 16936);

                int
                prevStack = f_10968_16923_16935(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 16950, 16969);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 17082, 17206);

                var
                result = (DynAbs.Tracing.TraceSender.Conditional_F1(10968, 17095, 17121) || ((f_10968_17095_17113(node) == null && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 17141, 17181)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 17201, 17205))) ? node = (BoundExpression)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10968, 17165, 17181) : node
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 17222, 17245);

                _context = prevContext;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 17259, 17273);

                _counter += 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 17289, 17890);

                switch (context)
                {

                    case ExprContext.Sideeffects:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 17289, 17890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 17389, 17414);

                        f_10968_17389_17413(this, prevStack);
                        DynAbs.Tracing.TraceSender.TraceBreak(10968, 17436, 17442);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 17289, 17890);

                    case ExprContext.AssignmentTarget:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 17289, 17890);
                        DynAbs.Tracing.TraceSender.TraceBreak(10968, 17518, 17524);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 17289, 17890);

                    case ExprContext.Value:
                    case ExprContext.Address:
                    case ExprContext.Box:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 17289, 17890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 17671, 17696);

                        f_10968_17671_17695(this, prevStack);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 17718, 17747);

                        f_10968_17718_17746(this, node, context);
                        DynAbs.Tracing.TraceSender.TraceBreak(10968, 17769, 17775);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 17289, 17890);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 17289, 17890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 17825, 17875);

                        throw f_10968_17831_17874(context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 17289, 17890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 17906, 17920);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 16755, 17931);

                int
                f_10968_16923_16935(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 16923, 16935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_17095_17113(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 17095, 17113);
                    return return_v;
                }


                int
                f_10968_17389_17413(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 17389, 17413);
                    return 0;
                }


                int
                f_10968_17671_17695(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 17671, 17695);
                    return 0;
                }


                int
                f_10968_17718_17746(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    this_param.PushEvalStack(result, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 17718, 17746);
                    return 0;
                }


                System.Exception
                f_10968_17831_17874(Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 17831, 17874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 16755, 17931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 16755, 17931);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitExpression(BoundExpression node, ExprContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 17943, 18513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18050, 18073);

                BoundExpression
                result
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18087, 18105);

                _recursionDepth++;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18121, 18440) || true) && (_recursionDepth > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 18121, 18440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18178, 18237);

                    f_10968_18178_18236(_recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18257, 18301);

                    result = f_10968_18266_18300(this, node, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 18121, 18440);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 18121, 18440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18367, 18425);

                    result = f_10968_18376_18424(this, node, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 18121, 18440);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18456, 18474);

                _recursionDepth--;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18488, 18502);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 17943, 18513);

                int
                f_10968_18178_18236(int
                recursionDepth)
                {
                    StackGuard.EnsureSufficientExecutionStack(recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 18178, 18236);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_18266_18300(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpressionCore(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 18266, 18300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_18376_18424(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpressionCoreWithStackGuard(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 18376, 18424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 17943, 18513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 17943, 18513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitExpressionCoreWithStackGuard(BoundExpression node, ExprContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 18525, 19055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18650, 18685);

                f_10968_18650_18684(_recursionDepth == 1);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18737, 18785);

                    var
                    result = f_10968_18750_18784(this, node, context)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18803, 18838);

                    f_10968_18803_18837(_recursionDepth == 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18856, 18870);

                    return result;
                }
                catch (InsufficientExecutionStackException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10968, 18899, 19044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 18978, 19029);

                    throw f_10968_18984_19028(ex, node);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10968, 18899, 19044);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 18525, 19055);

                int
                f_10968_18650_18684(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 18650, 18684);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_18750_18784(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpressionCore(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 18750, 18784);
                    return return_v;
                }


                int
                f_10968_18803_18837(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 18803, 18837);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException
                f_10968_18984_19028(System.InsufficientExecutionStackException
                inner, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException((System.Exception)inner, (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 18984, 19028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 18525, 19055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 18525, 19055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BoundExpression VisitExpressionWithoutStackGuard(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 19067, 19229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 19181, 19218);

                throw f_10968_19187_19217();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 19067, 19229);

                System.Exception
                f_10968_19187_19217()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 19187, 19217);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 19067, 19229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 19067, 19229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void PushEvalStack(BoundExpression result, ExprContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 19241, 19456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 19337, 19397);

                f_10968_19337_19396(result != null || (DynAbs.Tracing.TraceSender.Expression_False(10968, 19350, 19395) || context == ExprContext.None));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 19411, 19445);

                f_10968_19411_19444(_evalStack, (result, context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 19241, 19456);

                int
                f_10968_19337_19396(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 19337, 19396);
                    return 0;
                }


                int
                f_10968_19411_19444(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext)>
                this_param, (Microsoft.CodeAnalysis.CSharp.BoundExpression? result, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext context)
                item)
                {
                    this_param.Add(((Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 19411, 19444);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 19241, 19456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 19241, 19456);
            }
        }

        private int StackDepth()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 19468, 19552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 19517, 19541);

                return f_10968_19524_19540(_evalStack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 19468, 19552);

                int
                f_10968_19524_19540(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 19524, 19540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 19468, 19552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 19468, 19552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool EvalStackIsEmpty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 19564, 19656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 19620, 19645);

                return f_10968_19627_19639(this) == 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 19564, 19656);

                int
                f_10968_19627_19639(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 19627, 19639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 19564, 19656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 19564, 19656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetStackDepth(int depth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 19668, 19764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 19730, 19753);

                f_10968_19730_19752(_evalStack, depth);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 19668, 19764);

                int
                f_10968_19730_19752(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext)>
                this_param, int
                limit)
                {
                    this_param.Clip(limit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 19730, 19752);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 19668, 19764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 19668, 19764);
            }
        }

        private void PopEvalStack()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 19776, 19875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 19828, 19864);

                f_10968_19828_19863(this, f_10968_19842_19858(_evalStack) - 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 19776, 19875);

                int
                f_10968_19842_19858(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 19842, 19858);
                    return return_v;
                }


                int
                f_10968_19828_19863(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 19828, 19863);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 19776, 19875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 19776, 19875);
            }
        }

        private void ClearEvalStack()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 19887, 19971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 19941, 19960);

                f_10968_19941_19959(_evalStack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 19887, 19971);

                int
                f_10968_19941_19959(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext)>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 19941, 19959);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 19887, 19971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 19887, 19971);
            }
        }

        public BoundNode VisitStatement(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 19983, 20158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20055, 20104);

                f_10968_20055_20103(node == null || (DynAbs.Tracing.TraceSender.Expression_False(10968, 20068, 20102) || f_10968_20084_20102(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20118, 20147);

                return f_10968_20125_20146(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 19983, 20158);

                bool
                f_10968_20084_20102(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.EvalStackIsEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 20084, 20102);
                    return return_v;
                }


                int
                f_10968_20055_20103(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 20055, 20103);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_20125_20146(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode?
                node)
                {
                    var return_v = this_param.VisitSideEffect(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 20125, 20146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 19983, 20158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 19983, 20158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundNode VisitSideEffect(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 20170, 20722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20243, 20272);

                var
                origStack = f_10968_20259_20271(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20286, 20313);

                var
                prevContext = _context
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20329, 20359);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10968, 20342, 20358)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20486, 20575) || true) && (_debugFriendly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 20486, 20575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20538, 20560);

                    f_10968_20538_20559(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 20486, 20575);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20591, 20614);

                _context = prevContext;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20628, 20653);

                f_10968_20628_20652(this, origStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20667, 20681);

                _counter += 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20697, 20711);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 20170, 20722);

                int
                f_10968_20259_20271(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 20259, 20271);
                    return return_v;
                }


                int
                f_10968_20538_20559(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 20538, 20559);
                    return 0;
                }


                int
                f_10968_20628_20652(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 20628, 20652);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 20170, 20722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 20170, 20722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConversion(BoundConversion node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 20734, 21110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 20822, 21012);

                var
                context = (DynAbs.Tracing.TraceSender.Conditional_F1(10968, 20836, 20907) || ((_context == ExprContext.Sideeffects && (DynAbs.Tracing.TraceSender.Expression_True(10968, 20836, 20907) && !f_10968_20876_20907(node)) && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 20939, 20962)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 20994, 21011))) ? ExprContext.Sideeffects : ExprContext.Value
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 21028, 21099);

                return f_10968_21035_21098(node, f_10968_21054_21097(this, f_10968_21075_21087(node), context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 20734, 21110);

                bool
                f_10968_20876_20907(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionHasSideEffects();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 20876, 20907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_21075_21087(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 21075, 21087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_21054_21097(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 21054, 21097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10968_21035_21098(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = this_param.UpdateOperand(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 21035, 21098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 20734, 21110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 20734, 21110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPassByCopy(BoundPassByCopy node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 21122, 21504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 21210, 21364);

                var
                context = (DynAbs.Tracing.TraceSender.Conditional_F1(10968, 21224, 21259) || ((_context == ExprContext.Sideeffects && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 21291, 21314)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 21346, 21363))) ? ExprContext.Sideeffects : ExprContext.Value
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 21380, 21493);

                return f_10968_21387_21492(node, f_10968_21417_21463(this, f_10968_21438_21453(node), context), f_10968_21482_21491(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 21122, 21504);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_21438_21453(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 21438, 21453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_21417_21463(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 21417, 21463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_21482_21491(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 21482, 21491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                f_10968_21387_21492(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.Update(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 21387, 21492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 21122, 21504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 21122, 21504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBlock(BoundBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 21516, 21893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 21594, 21682);

                f_10968_21594_21681(f_10968_21607_21625(this), "entering blocks when evaluation stack is not empty?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 21807, 21837);

                f_10968_21807_21836(this, f_10968_21821_21832(node), 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 21853, 21882);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBlock(node), 10968, 21860, 21881);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 21516, 21893);

                bool
                f_10968_21607_21625(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.EvalStackIsEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 21607, 21625);
                    return return_v;
                }


                int
                f_10968_21594_21681(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 21594, 21681);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10968_21821_21832(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 21821, 21832);
                    return return_v;
                }


                int
                f_10968_21807_21836(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, int
                stack)
                {
                    this_param.DeclareLocals(locals, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 21807, 21836);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 21516, 21893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 21516, 21893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSequence(BoundSequence node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 22747, 27785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 25498, 25534);

                var
                declarationStack = f_10968_25521_25533(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 25550, 25575);

                var
                locals = f_10968_25563_25574(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 25589, 26361) || true) && (f_10968_25593_25617_M(!locals.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 25589, 26361);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 25651, 26346) || true) && (_context == ExprContext.Sideeffects)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 25651, 26346);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 25732, 26205);
                            foreach (var local in f_10968_25754_25760_I(locals))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 25732, 26205);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 25810, 26182) || true) && (f_10968_25814_25858(this, local, node))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 25810, 26182);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 25961, 26003);

                                    f_10968_25961_26002(this, local, declarationStack + 1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 25810, 26182);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 25810, 26182);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26117, 26155);

                                    f_10968_26117_26154(this, local, declarationStack);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 25810, 26182);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 25732, 26205);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 474);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 474);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 25651, 26346);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 25651, 26346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26287, 26327);

                        f_10968_26287_26326(this, locals, declarationStack);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 25651, 26346);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 25589, 26361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26412, 26439);

                var
                origContext = _context
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26455, 26490);

                var
                sideeffects = f_10968_26473_26489(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26504, 26562);

                ArrayBuilder<BoundExpression>
                rewrittenSideeffects = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26576, 27373) || true) && (f_10968_26580_26602_M(!sideeffects.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 26576, 27373);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26645, 26650);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26636, 27358) || true) && (i < sideeffects.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26676, 26679)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 26636, 27358))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 26636, 27358);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26721, 26753);

                            var
                            sideeffect = sideeffects[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26775, 26859);

                            var
                            rewrittenSideeffect = f_10968_26801_26858(this, sideeffect, ExprContext.Sideeffects)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 26883, 27164) || true) && (rewrittenSideeffects == null && (DynAbs.Tracing.TraceSender.Expression_True(10968, 26887, 26952) && rewrittenSideeffect != sideeffect))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 26883, 27164);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 27002, 27069);

                                rewrittenSideeffects = f_10968_27025_27068();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 27095, 27141);

                                f_10968_27095_27140(rewrittenSideeffects, sideeffects, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 26883, 27164);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 27188, 27339) || true) && (rewrittenSideeffects != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 27188, 27339);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 27270, 27316);

                                f_10968_27270_27315(rewrittenSideeffects, rewrittenSideeffect);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 27188, 27339);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 723);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 723);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 26576, 27373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 27389, 27447);

                var
                value = f_10968_27401_27446(this, f_10968_27422_27432(node), origContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 27463, 27774);

                return f_10968_27470_27773(node, f_10968_27482_27493(node), (DynAbs.Tracing.TraceSender.Conditional_F1(10968, 27528, 27556) || ((rewrittenSideeffects != null && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 27596, 27637)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 27677, 27688))) ? f_10968_27596_27637(rewrittenSideeffects) : sideeffects, value, f_10968_27763_27772(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 22747, 27785);

                int
                f_10968_25521_25533(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 25521, 25533);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10968_25563_25574(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 25563, 25574);
                    return return_v;
                }


                bool
                f_10968_25593_25617_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 25593, 25617);
                    return return_v;
                }


                bool
                f_10968_25814_25858(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, Microsoft.CodeAnalysis.CSharp.BoundSequence
                node)
                {
                    var return_v = this_param.IsNestedLocalOfCompoundOperator(local, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 25814, 25858);
                    return return_v;
                }


                int
                f_10968_25961_26002(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, int
                stack)
                {
                    this_param.DeclareLocal(local, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 25961, 26002);
                    return 0;
                }


                int
                f_10968_26117_26154(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, int
                stack)
                {
                    this_param.DeclareLocal(local, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 26117, 26154);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10968_25754_25760_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 25754, 25760);
                    return return_v;
                }


                int
                f_10968_26287_26326(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, int
                stack)
                {
                    this_param.DeclareLocals(locals, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 26287, 26326);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_26473_26489(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.SideEffects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 26473, 26489);
                    return return_v;
                }


                bool
                f_10968_26580_26602_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 26580, 26602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_26801_26858(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 26801, 26858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_27025_27068()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 27025, 27068);
                    return return_v;
                }


                int
                f_10968_27095_27140(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items, int
                length)
                {
                    this_param.AddRange(items, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 27095, 27140);
                    return 0;
                }


                int
                f_10968_27270_27315(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 27270, 27315);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_27422_27432(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 27422, 27432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_27401_27446(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 27401, 27446);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10968_27482_27493(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 27482, 27493);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_27596_27637(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 27596, 27637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_27763_27772(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 27763, 27772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10968_27470_27773(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(locals, sideEffects, value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 27470, 27773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 22747, 27785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 22747, 27785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsNestedLocalOfCompoundOperator(LocalSymbol local, BoundSequence node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 28171, 30344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 28279, 28302);

                var
                value = f_10968_28291_28301(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 28383, 30304) || true) && (value != null && (DynAbs.Tracing.TraceSender.Expression_True(10968, 28387, 28433) && f_10968_28404_28414(value) == BoundKind.Local) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 28387, 28477) && f_10968_28437_28468(((BoundLocal)value)) == local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 28383, 30304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 28511, 28546);

                    var
                    sideeffects = f_10968_28529_28545(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 28564, 28613);

                    var
                    lastSideeffect = sideeffects.LastOrDefault()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 28633, 30289) || true) && (lastSideeffect != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 28633, 30289);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 28788, 30270) || true) && (f_10968_28792_28811(lastSideeffect) == BoundKind.AssignmentOperator)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 28788, 30270);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 28893, 28950);

                            var
                            assignment = (BoundAssignmentOperator)lastSideeffect
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 28976, 30247) || true) && (f_10968_28980_29027(assignment) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 28980, 29103) && f_10968_29060_29081(f_10968_29060_29076(assignment)) == BoundKind.Sequence))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 28976, 30247);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 29243, 29309);

                                var
                                localUsedWalker = f_10968_29265_29308(local, _recursionDepth)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 29348, 29353);
                                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 29339, 29654) || true) && (i < sideeffects.Length - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 29383, 29386)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 29339, 29654))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 29339, 29654);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 29452, 29623) || true) && (f_10968_29456_29501(localUsedWalker, sideeffects[i]))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 29452, 29623);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 29575, 29588);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 29452, 29623);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 316);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 316);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 29837, 29997) || true) && (f_10968_29841_29887(localUsedWalker, f_10968_29871_29886(assignment)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 29837, 29997);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 29953, 29966);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 29837, 29997);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 30089, 30176);

                                f_10968_30089_30175(f_10968_30102_30149(localUsedWalker, f_10968_30132_30148(assignment)), "who assigns the temp?");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 30208, 30220);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 28976, 30247);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 28788, 30270);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 28633, 30289);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 28383, 30304);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 30320, 30333);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 28171, 30344);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_28291_28301(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 28291, 28301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_28404_28414(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 28404, 28414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_28437_28468(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 28437, 28468);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_28529_28545(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.SideEffects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 28529, 28545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_28792_28811(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 28792, 28811);
                    return return_v;
                }


                bool
                f_10968_28980_29027(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                node)
                {
                    var return_v = IsIndirectOrInstanceFieldAssignment(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 28980, 29027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_29060_29076(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 29060, 29076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_29060_29081(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 29060, 29081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1.LocalUsedWalker
                f_10968_29265_29308(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, int
                recursionDepth)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1.LocalUsedWalker(local, recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 29265, 29308);
                    return return_v;
                }


                bool
                f_10968_29456_29501(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1.LocalUsedWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.IsLocalUsedIn((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 29456, 29501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_29871_29886(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 29871, 29886);
                    return return_v;
                }


                bool
                f_10968_29841_29887(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1.LocalUsedWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.IsLocalUsedIn((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 29841, 29887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_30132_30148(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 30132, 30148);
                    return return_v;
                }


                bool
                f_10968_30102_30149(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1.LocalUsedWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.IsLocalUsedIn((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 30102, 30149);
                    return return_v;
                }


                int
                f_10968_30089_30175(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 30089, 30175);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 28171, 30344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 28171, 30344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class LocalUsedWalker : BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
        {
            private readonly LocalSymbol _local;

            private bool _found;

            internal LocalUsedWalker(LocalSymbol local, int recursionDepth)
            : base(f_10968_30664_30678_C(recursionDepth))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10968, 30576, 30742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 30519, 30525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 30553, 30559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 30712, 30727);

                    _local = local;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10968, 30576, 30742);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 30576, 30742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 30576, 30742);
                }
            }

            public bool IsLocalUsedIn(BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 30758, 30931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 30832, 30847);

                    _found = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 30865, 30882);

                    f_10968_30865_30881(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 30902, 30916);

                    return _found;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 30758, 30931);

                    Microsoft.CodeAnalysis.CSharp.BoundNode
                    f_10968_30865_30881(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1.LocalUsedWalker
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node)
                    {
                        var return_v = this_param.Visit(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 30865, 30881);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 30758, 30931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 30758, 30931);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode Visit(BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 30947, 31170);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 31027, 31123) || true) && (!_found)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 31027, 31123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 31080, 31104);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10968, 31087, 31103);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 31027, 31123);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 31143, 31155);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 30947, 31170);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 30947, 31170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 30947, 31170);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitLocal(BoundLocal node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 31186, 31424);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 31272, 31377) || true) && (f_10968_31276_31292(node) == _local)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 31272, 31377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 31344, 31358);

                        _found = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 31272, 31377);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 31397, 31409);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 31186, 31424);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10968_31276_31292(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 31276, 31292);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 31186, 31424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 31186, 31424);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static LocalUsedWalker()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10968, 30356, 31435);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10968, 30356, 31435);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 30356, 31435);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10968, 30356, 31435);

            static int
            f_10968_30664_30678_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10968, 30576, 30742);
                return return_v;
            }

        }

        public override BoundNode VisitExpressionStatement(BoundExpressionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 31447, 31665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 31553, 31654);

                return f_10968_31560_31653(node, f_10968_31590_31652(this, f_10968_31611_31626(node), ExprContext.Sideeffects));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 31447, 31665);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_31611_31626(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 31611, 31626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_31590_31652(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 31590, 31652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10968_31560_31653(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Update(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 31560, 31653);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 31447, 31665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 31447, 31665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocal(BoundLocal node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 31677, 32991);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 31755, 32935) || true) && (f_10968_31759_31780(node) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 31755, 32935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 31822, 32920);

                    switch (_context)
                    {

                        case ExprContext.Address:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 31822, 32920);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 31931, 32237) || true) && (f_10968_31935_31959(f_10968_31935_31951(node)) != RefKind.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 31931, 32237);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 32033, 32065);

                                f_10968_32033_32064(this, f_10968_32047_32063(node));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 31931, 32237);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 31931, 32237);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 32179, 32210);

                                f_10968_32179_32209(this, f_10968_32192_32208(node));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 31931, 32237);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10968, 32263, 32269);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 31822, 32920);

                        case ExprContext.AssignmentTarget:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 31822, 32920);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 32353, 32392);

                            f_10968_32353_32391(_assignmentLocal == null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 32578, 32602);

                            _assignmentLocal = node;
                            DynAbs.Tracing.TraceSender.TraceBreak(10968, 32630, 32636);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 31822, 32920);

                        case ExprContext.Sideeffects:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 31822, 32920);
                            DynAbs.Tracing.TraceSender.TraceBreak(10968, 32715, 32721);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 31822, 32920);

                        case ExprContext.Value:
                        case ExprContext.Box:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 31822, 32920);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 32837, 32869);

                            f_10968_32837_32868(this, f_10968_32851_32867(node));
                            DynAbs.Tracing.TraceSender.TraceBreak(10968, 32895, 32901);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 31822, 32920);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 31755, 32935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 32951, 32980);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocal(node), 10968, 32958, 32979);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 31677, 32991);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_31759_31780(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 31759, 31780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_31935_31951(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 31935, 31951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10968_31935_31959(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 31935, 31959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_32047_32063(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 32047, 32063);
                    return return_v;
                }


                int
                f_10968_32033_32064(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.RecordVarRead(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 32033, 32064);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_32192_32208(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 32192, 32208);
                    return return_v;
                }


                int
                f_10968_32179_32209(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.RecordVarRef(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 32179, 32209);
                    return 0;
                }


                int
                f_10968_32353_32391(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 32353, 32391);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_32851_32867(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 32851, 32867);
                    return return_v;
                }


                int
                f_10968_32837_32868(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.RecordVarRead(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 32837, 32868);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 31677, 32991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 31677, 32991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAssignmentOperator(BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 33003, 38493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 33107, 33149);

                var
                sequence = f_10968_33122_33131(node) as BoundSequence
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 33163, 33999) || true) && (sequence != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 33163, 33999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 33511, 33796);

                    BoundExpression
                    rewritten = f_10968_33539_33795(sequence, f_10968_33555_33570(sequence), f_10968_33613_33633(sequence), f_10968_33676_33738(node, f_10968_33688_33702(sequence), f_10968_33704_33714(node), f_10968_33716_33726(node), f_10968_33728_33737(node)), f_10968_33781_33794(sequence))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 33816, 33862);

                    rewritten = (BoundExpression)f_10968_33845_33861(this, rewritten);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 33936, 33947);

                    _counter--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 33967, 33984);

                    return rewritten;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 33163, 33999);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 34017, 34071);

                var
                isIndirectAssignment = f_10968_34044_34070(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 34087, 34306);

                var
                left = f_10968_34098_34305(this, f_10968_34114_34123(node), (DynAbs.Tracing.TraceSender.Conditional_F1(10968, 34125, 34145) || ((isIndirectAssignment && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 34201, 34220)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 34276, 34304))) ? ExprContext.Address : ExprContext.AssignmentTarget)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 34396, 34435);

                var
                assignmentLocal = _assignmentLocal
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 34449, 34473);

                _assignmentLocal = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 34489, 34610);

                f_10968_34489_34609(_context != ExprContext.AssignmentTarget, "assignment expression cannot be a target of another assignment");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 34626, 34649);

                ExprContext
                rhsContext
                = default(ExprContext);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 34663, 35349) || true) && (f_10968_34667_34677(node) || (DynAbs.Tracing.TraceSender.Expression_False(10968, 34667, 34712) || _context == ExprContext.Address))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 34663, 35349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 34847, 34880);

                    rhsContext = ExprContext.Address;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 34663, 35349);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 34663, 35349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 34946, 35186);

                    f_10968_34946_35185(_context == ExprContext.Value || (DynAbs.Tracing.TraceSender.Expression_False(10968, 34959, 35049) || _context == ExprContext.Box) || (DynAbs.Tracing.TraceSender.Expression_False(10968, 34959, 35118) || _context == ExprContext.Sideeffects), "assignment expression cannot be a target of another assignment");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 35303, 35334);

                    rhsContext = ExprContext.Value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 34663, 35349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 35596, 35631);

                BoundExpression
                right = f_10968_35620_35630(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 35645, 35859);

                bool
                mayPushReceiver = (f_10968_35669_35679(right) == BoundKind.ObjectCreationExpression && (DynAbs.Tracing.TraceSender.Expression_True(10968, 35669, 35766) && f_10968_35738_35766(f_10968_35738_35748(right))) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 35669, 35857) && f_10968_35787_35852(f_10968_35787_35837(((BoundObjectCreationExpression)right))) != 0))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 35875, 36060) || true) && (mayPushReceiver)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 35875, 36060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 36007, 36045);

                    f_10968_36007_36044(this, null, ExprContext.None);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 35875, 36060);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 36076, 36124);

                right = f_10968_36084_36123(this, f_10968_36100_36110(node), rhsContext);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 36140, 36223) || true) && (mayPushReceiver)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 36140, 36223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 36193, 36208);

                    f_10968_36193_36207(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 36140, 36223);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 36319, 38411) || true) && (assignmentLocal != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 36319, 38411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 36599, 37012);

                    f_10968_36599_37011(f_10968_36634_36706(f_10968_36634_36648(f_10968_36634_36643(node)), f_10968_36656_36671(f_10968_36656_36666(node)), TypeCompareKind.AllIgnoreOptions) || (DynAbs.Tracing.TraceSender.Expression_False(10968, 36634, 36799) || f_10968_36731_36799(f_10968_36765_36774(node), f_10968_36776_36786(node), f_10968_36788_36798(node))), @"type of the assignment value is not the same as the type of assignment target. 
                This is not expected by the optimizer and is typically a result of a bug somewhere else.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 37032, 37114);

                    f_10968_37032_37113(!isIndirectAssignment, "indirect assignment is a read, not a write");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 37134, 37188);

                    LocalSymbol
                    localSymbol = f_10968_37160_37187(assignmentLocal)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 37437, 37666) || true) && (f_10968_37441_37460(localSymbol) == RefKind.RefReadOnly && (DynAbs.Tracing.TraceSender.Expression_True(10968, 37441, 37574) && (_context == ExprContext.Address || (DynAbs.Tracing.TraceSender.Expression_False(10968, 37509, 37573) || _context == ExprContext.Value))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 37437, 37666);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 37616, 37647);

                        f_10968_37616_37646(this, localSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 37437, 37666);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 37982, 38307) || true) && (f_10968_37986_38017(this, localSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 37986, 38091) && f_10968_38042_38091(f_10968_38042_38062(assignmentLocal))) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 37986, 38129) && f_10968_38095_38105(right) == BoundKind.Conversion) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 37986, 38215) && f_10968_38154_38215(f_10968_38154_38193(((BoundConversion)right)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 37982, 38307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 38257, 38288);

                        f_10968_38257_38287(this, localSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 37982, 38307);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 38327, 38355);

                    f_10968_38327_38354(this, localSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 38373, 38396);

                    assignmentLocal = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 36319, 38411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 38427, 38482);

                return f_10968_38434_38481(node, left, right, f_10968_38459_38469(node), f_10968_38471_38480(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 33003, 38493);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_33122_33131(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 33122, 33131);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10968_33555_33570(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 33555, 33570);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_33613_33633(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.SideEffects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 33613, 33633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_33688_33702(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 33688, 33702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_33704_33714(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 33704, 33714);
                    return return_v;
                }


                bool
                f_10968_33716_33726(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 33716, 33726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_33728_33737(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 33728, 33737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10968_33676_33738(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, bool
                isRef, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(left, right, isRef, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 33676, 33738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_33781_33794(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 33781, 33794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10968_33539_33795(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(locals, sideEffects, (Microsoft.CodeAnalysis.CSharp.BoundExpression)value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 33539, 33795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_33845_33861(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 33845, 33861);
                    return return_v;
                }


                bool
                f_10968_34044_34070(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                node)
                {
                    var return_v = IsIndirectAssignment(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 34044, 34070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_34114_34123(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 34114, 34123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_34098_34305(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 34098, 34305);
                    return return_v;
                }


                int
                f_10968_34489_34609(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 34489, 34609);
                    return 0;
                }


                bool
                f_10968_34667_34677(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 34667, 34677);
                    return return_v;
                }


                int
                f_10968_34946_35185(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 34946, 35185);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_35620_35630(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 35620, 35630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_35669_35679(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 35669, 35679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_35738_35748(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 35738, 35748);
                    return return_v;
                }


                bool
                f_10968_35738_35766(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVerifierValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 35738, 35766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10968_35787_35837(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 35787, 35837);
                    return return_v;
                }


                int
                f_10968_35787_35852(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 35787, 35852);
                    return return_v;
                }


                int
                f_10968_36007_36044(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    this_param.PushEvalStack(result, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 36007, 36044);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_36100_36110(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 36100, 36110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_36084_36123(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 36084, 36123);
                    return return_v;
                }


                int
                f_10968_36193_36207(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.PopEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 36193, 36207);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_36634_36643(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 36634, 36643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_36634_36648(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 36634, 36648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_36656_36666(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 36656, 36666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_36656_36671(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 36656, 36671);
                    return return_v;
                }


                bool
                f_10968_36634_36706(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 36634, 36706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_36765_36774(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 36765, 36774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_36776_36786(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 36776, 36786);
                    return return_v;
                }


                bool
                f_10968_36788_36798(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 36788, 36798);
                    return return_v;
                }


                bool
                f_10968_36731_36799(Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, bool
                isRef)
                {
                    var return_v = IsFixedBufferAssignmentToRefLocal(left, right, isRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 36731, 36799);
                    return return_v;
                }


                int
                f_10968_36599_37011(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 36599, 37011);
                    return 0;
                }


                int
                f_10968_37032_37113(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 37032, 37113);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_37160_37187(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 37160, 37187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10968_37441_37460(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 37441, 37460);
                    return return_v;
                }


                int
                f_10968_37616_37646(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localSymbol)
                {
                    this_param.ShouldNotSchedule(localSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 37616, 37646);
                    return 0;
                }


                bool
                f_10968_37986_38017(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.CanScheduleToStack(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 37986, 38017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_38042_38062(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 38042, 38062);
                    return return_v;
                }


                bool
                f_10968_38042_38091(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 38042, 38091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_38095_38105(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 38095, 38105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10968_38154_38193(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 38154, 38193);
                    return return_v;
                }


                bool
                f_10968_38154_38215(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind)
                {
                    var return_v = kind.IsPointerConversion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 38154, 38215);
                    return return_v;
                }


                int
                f_10968_38257_38287(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localSymbol)
                {
                    this_param.ShouldNotSchedule(localSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 38257, 38287);
                    return 0;
                }


                int
                f_10968_38327_38354(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.RecordVarWrite(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 38327, 38354);
                    return 0;
                }


                bool
                f_10968_38459_38469(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 38459, 38469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_38471_38480(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 38471, 38480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10968_38434_38481(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, bool
                isRef, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(left, right, isRef, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 38434, 38481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 33003, 38493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 33003, 38493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsFixedBufferAssignmentToRefLocal(BoundExpression left, BoundExpression right, bool isRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 39063, 39306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 39066, 39306);
                return isRef && (DynAbs.Tracing.TraceSender.Expression_True(10968, 39066, 39128) && right is BoundFieldAccess fieldAccess) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 39066, 39189) && f_10968_39148_39189(f_10968_39148_39171(fieldAccess))) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 39066, 39306) && f_10968_39209_39306(f_10968_39209_39218(left), f_10968_39226_39271(((PointerTypeSymbol)f_10968_39246_39256(right))), TypeCompareKind.AllIgnoreOptions)); DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 39063, 39306);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 39063, 39306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 39063, 39306);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
            f_10968_39148_39171(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
            this_param)
            {
                var return_v = this_param.FieldSymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 39148, 39171);
                return return_v;
            }


            bool
            f_10968_39148_39189(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
            this_param)
            {
                var return_v = this_param.IsFixedSizeBuffer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 39148, 39189);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            f_10968_39209_39218(Microsoft.CodeAnalysis.CSharp.BoundExpression
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 39209, 39218);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            f_10968_39246_39256(Microsoft.CodeAnalysis.CSharp.BoundExpression
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 39246, 39256);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            f_10968_39226_39271(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol?
            this_param)
            {
                var return_v = this_param.PointedAtType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 39226, 39271);
                return return_v;
            }


            bool
            f_10968_39209_39306(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            t2, Microsoft.CodeAnalysis.TypeCompareKind
            compareKind)
            {
                var return_v = this_param.Equals(t2, compareKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 39209, 39306);
                return return_v;
            }

        }

        // indirect assignment is assignment to a value referenced indirectly
        // it may only happen if 
        //      1) lhs is a reference (must be a parameter or a local)
        //      2) it is not a ref/out assignment where the reference itself would be assigned
        private static bool IsIndirectAssignment(BoundAssignmentOperator node)
        {
            var lhs = node.Left;

            Debug.Assert(!node.IsRef ||
              (lhs is BoundLocal local && local.LocalSymbol.RefKind != RefKind.None) ||
              (lhs is BoundParameter param && param.ParameterSymbol.RefKind != RefKind.None),
                                "only ref symbols can be a target of a ref assignment");

            switch (lhs.Kind)
            {
                case BoundKind.ThisReference:
                    Debug.Assert(lhs.Type.IsValueType, "'this' is assignable only in structs");
                    return true;

                case BoundKind.Parameter:
                    if (((BoundParameter)lhs).ParameterSymbol.RefKind != RefKind.None)
                    {
                        return !node.IsRef;
                    }

                    return false;

                case BoundKind.Local:
                    if (((BoundLocal)lhs).LocalSymbol.RefKind != RefKind.None)
                    {
                        return !node.IsRef;
                    }

                    return false;

                case BoundKind.Call:
                    Debug.Assert(((BoundCall)lhs).Method.RefKind == RefKind.Ref, "only ref returning methods are assignable");
                    return true;

                case BoundKind.FunctionPointerInvocation:
                    Debug.Assert(((BoundFunctionPointerInvocation)lhs).FunctionPointer.Signature.RefKind == RefKind.Ref, "only ref returning function pointers are assignable");
                    return true;

                case BoundKind.ConditionalOperator:
                    Debug.Assert(((BoundConditionalOperator)lhs).IsRef, "only ref ternaries are assignable");
                    return true;

                case BoundKind.AssignmentOperator:
                    Debug.Assert(((BoundAssignmentOperator)lhs).IsRef, "only ref assignments are assignable");
                    return true;

                case BoundKind.Sequence:
                    Debug.Assert(!IsIndirectAssignment(node.Update(((BoundSequence)node.Left).Value, node.Right, node.IsRef, node.Type)),
                        "indirect assignment to a sequence is unexpected");
                    return false;

                case BoundKind.RefValueOperator:
                case BoundKind.PointerIndirectionOperator:
                case BoundKind.PseudoVariable:
                    return true;

                case BoundKind.ModuleVersionId:
                case BoundKind.InstrumentationPayloadRoot:
                    // these are just stores into special static fields
                    goto case BoundKind.FieldAccess;

                case BoundKind.FieldAccess:
                case BoundKind.ArrayAccess:
                    // always symbolic stores
                    return false;

                default:
                    throw ExceptionUtilities.UnexpectedValue(lhs.Kind);
            }
        }

        private static bool IsIndirectOrInstanceFieldAssignment(BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10968, 42684, 43028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 42794, 42814);

                var
                lhs = f_10968_42804_42813(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 42828, 42967) || true) && (f_10968_42832_42840(lhs) == BoundKind.FieldAccess)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 42828, 42967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 42899, 42952);

                    return f_10968_42906_42951_M(!f_10968_42907_42942(((BoundFieldAccess)lhs)).IsStatic);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 42828, 42967);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 42983, 43017);

                return f_10968_42990_43016(node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10968, 42684, 43028);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_42804_42813(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 42804, 42813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_42832_42840(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 42832, 42840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10968_42907_42942(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 42907, 42942);
                    return return_v;
                }


                bool
                f_10968_42906_42951_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 42906, 42951);
                    return return_v;
                }


                bool
                f_10968_42990_43016(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                node)
                {
                    var return_v = IsIndirectAssignment(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 42990, 43016);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 42684, 43028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 42684, 43028);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCall(BoundCall node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 43040, 44034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 43116, 43148);

                var
                receiver = f_10968_43131_43147(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 43388, 43785) || true) && (f_10968_43392_43428(f_10968_43392_43403(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 43388, 43785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 43462, 43501);

                    receiver = f_10968_43473_43500(this, receiver);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 43388, 43785);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 43388, 43785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 43722, 43736);

                    _counter += 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 43754, 43770);

                    receiver = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 43388, 43785);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 43801, 43835);

                MethodSymbol
                method = f_10968_43823_43834(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 43849, 43950);

                var
                rewrittenArguments = f_10968_43874_43949(this, f_10968_43889_43903(node), f_10968_43905_43922(method), f_10968_43924_43948(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 43966, 44023);

                return f_10968_43973_44022(node, receiver, method, rewrittenArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 43040, 44034);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10968_43131_43147(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 43131, 43147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10968_43392_43403(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 43392, 43403);
                    return return_v;
                }


                bool
                f_10968_43392_43428(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 43392, 43428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_43473_43500(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver)
                {
                    var return_v = this_param.VisitCallReceiver(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 43473, 43500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10968_43823_43834(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 43823, 43834);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_43889_43903(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 43889, 43903);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10968_43905_43922(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 43905, 43922);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10968_43924_43948(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 43924, 43948);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_43874_43949(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt)
                {
                    var return_v = this_param.VisitArguments(arguments, parameters, argRefKindsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 43874, 43949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10968_43973_44022(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = this_param.Update(receiverOpt, method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 43973, 44022);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 43040, 44034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 43040, 44034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitCallReceiver(BoundExpression receiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 44046, 44958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 44138, 44171);

                var
                receiverType = f_10968_44157_44170(receiver)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 44185, 44205);

                ExprContext
                context
                = default(ExprContext);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 44221, 44855) || true) && (f_10968_44225_44253(receiverType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 44221, 44855);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 44287, 44682) || true) && (f_10968_44291_44321(receiverType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 44287, 44682);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 44460, 44486);

                        context = ExprContext.Box;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 44287, 44682);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 44287, 44682);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 44635, 44663);

                        context = ExprContext.Value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 44287, 44682);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 44221, 44855);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 44221, 44855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 44810, 44840);

                    context = ExprContext.Address;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 44221, 44855);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 44871, 44917);

                receiver = f_10968_44882_44916(this, receiver, context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 44931, 44947);

                return receiver;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 44046, 44958);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_44157_44170(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 44157, 44170);
                    return return_v;
                }


                bool
                f_10968_44225_44253(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 44225, 44253);
                    return return_v;
                }


                bool
                f_10968_44291_44321(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 44291, 44321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_44882_44916(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 44882, 44916);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 44046, 44958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 44046, 44958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<BoundExpression> VisitArguments(ImmutableArray<BoundExpression> arguments, ImmutableArray<ParameterSymbol> parameters, ImmutableArray<RefKind> argRefKindsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 44970, 45949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 45176, 45211);

                f_10968_45176_45210(f_10968_45189_45209_M(!arguments.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 45225, 45261);

                f_10968_45225_45260(f_10968_45238_45259_M(!parameters.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 45383, 45480);

                f_10968_45383_45479(arguments.Length == parameters.Length || (DynAbs.Tracing.TraceSender.Expression_False(10968, 45396, 45478) || arguments.Length == parameters.Length + 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 45496, 45552);

                ArrayBuilder<BoundExpression>
                rewrittenArguments = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 45575, 45580);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 45566, 45834) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 45604, 45607)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 45566, 45834))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 45566, 45834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 45641, 45737);

                        RefKind
                        argRefKind = f_10968_45662_45736(arguments, parameters, argRefKindsOpt, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 45755, 45819);

                        f_10968_45755_45818(this, arguments, ref rewrittenArguments, i, argRefKind);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 45850, 45938);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10968, 45857, 45883) || ((rewrittenArguments != null && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 45886, 45925)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 45928, 45937))) ? f_10968_45886_45925(rewrittenArguments) : arguments;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 44970, 45949);

                bool
                f_10968_45189_45209_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 45189, 45209);
                    return return_v;
                }


                int
                f_10968_45176_45210(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 45176, 45210);
                    return 0;
                }


                bool
                f_10968_45238_45259_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 45238, 45259);
                    return return_v;
                }


                int
                f_10968_45225_45260(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 45225, 45260);
                    return 0;
                }


                int
                f_10968_45383_45479(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 45383, 45479);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10968_45662_45736(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, int
                i)
                {
                    var return_v = CodeGenerator.GetArgumentRefKind(arguments, parameters, argRefKindsOpt, i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 45662, 45736);
                    return return_v;
                }


                int
                f_10968_45755_45818(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                rewrittenArguments, int
                i, Microsoft.CodeAnalysis.RefKind
                argRefKind)
                {
                    this_param.VisitArgument(arguments, ref rewrittenArguments, i, argRefKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 45755, 45818);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_45886_45925(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 45886, 45925);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 44970, 45949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 44970, 45949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VisitArgument(ImmutableArray<BoundExpression> arguments, ref ArrayBuilder<BoundExpression> rewrittenArguments, int i, RefKind argRefKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 45961, 46729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 46136, 46229);

                ExprContext
                context = (DynAbs.Tracing.TraceSender.Conditional_F1(10968, 46158, 46186) || (((argRefKind == RefKind.None) && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 46189, 46206)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 46209, 46228))) ? ExprContext.Value : ExprContext.Address
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 46245, 46268);

                var
                arg = arguments[i]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 46282, 46343);

                BoundExpression
                rewrittenArg = f_10968_46313_46342(this, arg, context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 46359, 46586) || true) && (rewrittenArguments == null && (DynAbs.Tracing.TraceSender.Expression_True(10968, 46363, 46412) && arg != rewrittenArg))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 46359, 46586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 46446, 46511);

                    rewrittenArguments = f_10968_46467_46510();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 46529, 46571);

                    f_10968_46529_46570(rewrittenArguments, arguments, i);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 46359, 46586);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 46602, 46718) || true) && (rewrittenArguments != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 46602, 46718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 46666, 46703);

                    f_10968_46666_46702(rewrittenArguments, rewrittenArg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 46602, 46718);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 45961, 46729);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_46313_46342(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 46313, 46342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_46467_46510()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 46467, 46510);
                    return return_v;
                }


                int
                f_10968_46529_46570(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items, int
                length)
                {
                    this_param.AddRange(items, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 46529, 46570);
                    return 0;
                }


                int
                f_10968_46666_46702(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 46666, 46702);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 45961, 46729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 45961, 46729);
            }
        }

        public override BoundNode VisitArgListOperator(BoundArgListOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 46741, 47448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 46841, 46897);

                ArrayBuilder<BoundExpression>
                rewrittenArguments = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 46911, 46970);

                ImmutableArray<BoundExpression>
                arguments = f_10968_46955_46969(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 46984, 47050);

                ImmutableArray<RefKind>
                argRefKindsOpt = f_10968_47025_47049(node)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 47075, 47080);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 47066, 47320) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 47104, 47107)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 47066, 47320))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 47066, 47320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 47141, 47226);

                        RefKind
                        refKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10968, 47159, 47190) || ((argRefKindsOpt.IsDefaultOrEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 47193, 47205)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 47208, 47225))) ? RefKind.None : argRefKindsOpt[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 47244, 47305);

                        f_10968_47244_47304(this, arguments, ref rewrittenArguments, i, refKind);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 47336, 47437);

                return f_10968_47343_47436(node, f_10968_47355_47395_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(rewrittenArguments, 10968, 47355, 47395)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>?>(10968, 47355, 47408) ?? arguments), argRefKindsOpt, f_10968_47426_47435(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 46741, 47448);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_46955_46969(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 46955, 46969);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10968_47025_47049(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 47025, 47049);
                    return return_v;
                }


                int
                f_10968_47244_47304(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                rewrittenArguments, int
                i, Microsoft.CodeAnalysis.RefKind
                argRefKind)
                {
                    this_param.VisitArgument(arguments, ref rewrittenArguments, i, argRefKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 47244, 47304);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                f_10968_47355_47395_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 47355, 47395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_47426_47435(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 47426, 47435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                f_10968_47343_47436(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.Update(arguments, argumentRefKindsOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 47343, 47436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 46741, 47448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 46741, 47448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMakeRefOperator(BoundMakeRefOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 47460, 47846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 47699, 47773);

                var
                rewrittenOperand = f_10968_47722_47772(this, f_10968_47738_47750(node), ExprContext.Address)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 47787, 47835);

                return f_10968_47794_47834(node, rewrittenOperand, f_10968_47824_47833(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 47460, 47846);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_47738_47750(Microsoft.CodeAnalysis.CSharp.BoundMakeRefOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 47738, 47750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_47722_47772(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 47722, 47772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_47824_47833(Microsoft.CodeAnalysis.CSharp.BoundMakeRefOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 47824, 47833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMakeRefOperator
                f_10968_47794_47834(Microsoft.CodeAnalysis.CSharp.BoundMakeRefOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 47794, 47834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 47460, 47846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 47460, 47846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitObjectCreationExpression(BoundObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 47858, 48463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 47974, 48009);

                var
                constructor = f_10968_47992_48008(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 48023, 48129);

                var
                rewrittenArguments = f_10968_48048_48128(this, f_10968_48063_48077(node), f_10968_48079_48101(constructor), f_10968_48103_48127(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 48143, 48195);

                f_10968_48143_48194(f_10968_48156_48185(node) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 48211, 48452);

                return f_10968_48218_48451(node, constructor, rewrittenArguments, f_10968_48263_48284(node), f_10968_48286_48310(node), f_10968_48329_48342(node), f_10968_48344_48364(node), f_10968_48366_48387(node), f_10968_48389_48407(node), initializerExpressionOpt: null, f_10968_48441_48450(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 47858, 48463);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10968_47992_48008(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 47992, 48008);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_48063_48077(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 48063, 48077);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10968_48079_48101(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 48079, 48101);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10968_48103_48127(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 48103, 48127);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_48048_48128(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt)
                {
                    var return_v = this_param.VisitArguments(arguments, parameters, argRefKindsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 48048, 48128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10968_48156_48185(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 48156, 48185);
                    return return_v;
                }


                int
                f_10968_48143_48194(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 48143, 48194);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10968_48263_48284(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 48263, 48284);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10968_48286_48310(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 48286, 48310);
                    return return_v;
                }


                bool
                f_10968_48329_48342(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 48329, 48342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10968_48344_48364(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 48344, 48364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10968_48366_48387(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 48366, 48387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_48389_48407(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 48389, 48407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_48441_48450(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 48441, 48450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10968_48218_48451(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                initializerExpressionOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(constructor, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, constantValueOpt, initializerExpressionOpt: initializerExpressionOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 48218, 48451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 47858, 48463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 47858, 48463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayAccess(BoundArrayAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 48475, 48917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 48714, 48740);

                var
                oldContext = _context
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 48754, 48783);

                _context = ExprContext.Value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 48799, 48840);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitArrayAccess(node), 10968, 48812, 48839)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 48856, 48878);

                _context = oldContext;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 48892, 48906);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 48475, 48917);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 48475, 48917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 48475, 48917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFieldAccess(BoundFieldAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 48929, 50744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 49019, 49048);

                var
                field = f_10968_49031_49047(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 49062, 49094);

                var
                receiver = f_10968_49077_49093(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 49272, 50630) || true) && (f_10968_49276_49291_M(!field.IsStatic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 49272, 50630);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 49325, 50376) || true) && (f_10968_49329_49360(f_10968_49329_49342(receiver)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 49325, 50376);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 49474, 49528);

                        receiver = f_10968_49485_49527(this, receiver, ExprContext.Box);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 49325, 50376);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 49325, 50376);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 49827, 50357) || true) && (f_10968_49831_49856(f_10968_49831_49844(receiver)) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 49831, 50072) && (
                                                    _context == ExprContext.AssignmentTarget || (DynAbs.Tracing.TraceSender.Expression_False(10968, 49891, 49995) || _context == ExprContext.Address) || (DynAbs.Tracing.TraceSender.Expression_False(10968, 49891, 50071) || f_10968_50028_50071(receiver)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 49827, 50357);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 50122, 50180);

                            receiver = f_10968_50133_50179(this, receiver, ExprContext.Address);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 49827, 50357);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 49827, 50357);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 50278, 50334);

                            receiver = f_10968_50289_50333(this, receiver, ExprContext.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 49827, 50357);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 49325, 50376);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 49272, 50630);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 49272, 50630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 50567, 50581);

                    _counter += 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 50599, 50615);

                    receiver = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 49272, 50630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 50646, 50733);

                return f_10968_50653_50732(node, receiver, field, f_10968_50682_50703(node), f_10968_50705_50720(node), f_10968_50722_50731(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 48929, 50744);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10968_49031_49047(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 49031, 49047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10968_49077_49093(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 49077, 49093);
                    return return_v;
                }


                bool
                f_10968_49276_49291_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 49276, 49291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_49329_49342(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 49329, 49342);
                    return return_v;
                }


                bool
                f_10968_49329_49360(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 49329, 49360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_49485_49527(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 49485, 49527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_49831_49844(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 49831, 49844);
                    return return_v;
                }


                bool
                f_10968_49831_49856(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 49831, 49856);
                    return return_v;
                }


                bool
                f_10968_50028_50071(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = CodeGenerator.FieldLoadMustUseRef(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 50028, 50071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_50133_50179(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 50133, 50179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_50289_50333(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 50289, 50333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_50682_50703(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 50682, 50703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10968_50705_50720(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 50705, 50720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_50722_50731(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 50722, 50731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10968_50653_50732(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = this_param.Update(receiver, fieldSymbol, constantValueOpt, resultKind, typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 50653, 50732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 48929, 50744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 48929, 50744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLabelStatement(BoundLabelStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 50756, 50939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 50852, 50876);

                f_10968_50852_50875(this, f_10968_50864_50874(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 50890, 50928);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLabelStatement(node), 10968, 50897, 50927);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 50756, 50939);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10968_50864_50874(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 50864, 50874);
                    return return_v;
                }


                int
                f_10968_50852_50875(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.RecordLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 50852, 50875);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 50756, 50939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 50756, 50939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLabel(BoundLabel node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 50951, 51140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51029, 51103);

                f_10968_51029_51102(false, "we should not have label expressions at this stage");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51117, 51129);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 50951, 51140);

                int
                f_10968_51029_51102(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 51029, 51102);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 50951, 51140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 50951, 51140);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIsPatternExpression(BoundIsPatternExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 51152, 51374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51258, 51337);

                f_10968_51258_51336(false, "we should not have is-pattern expressions at this stage");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51351, 51363);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 51152, 51374);

                int
                f_10968_51258_51336(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 51258, 51336);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 51152, 51374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 51152, 51374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitGotoStatement(BoundGotoStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 51386, 51718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51480, 51579);

                f_10968_51480_51578(f_10968_51493_51515(node) == null, "we should not have label expressions at this stage");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51595, 51638);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitGotoStatement(node), 10968, 51608, 51637)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51652, 51677);

                f_10968_51652_51676(this, f_10968_51665_51675(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51693, 51707);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 51386, 51718);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10968_51493_51515(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.CaseExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 51493, 51515);
                    return return_v;
                }


                int
                f_10968_51480_51578(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 51480, 51578);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10968_51665_51675(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 51665, 51675);
                    return return_v;
                }


                int
                f_10968_51652_51676(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.RecordBranch(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 51652, 51676);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 51386, 51718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 51386, 51718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalGoto(BoundConditionalGoto node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 51730, 52011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51828, 51873);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConditionalGoto(node), 10968, 51841, 51872)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51887, 51902);

                f_10968_51887_51901(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51945, 51970);

                f_10968_51945_51969(this, f_10968_51958_51968(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 51986, 52000);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 51730, 52011);

                int
                f_10968_51887_51901(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.PopEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 51887, 51901);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10968_51958_51968(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 51958, 51968);
                    return return_v;
                }


                int
                f_10968_51945_51969(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.RecordBranch(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 51945, 51969);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 51730, 52011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 51730, 52011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSwitchDispatch(BoundSwitchDispatch node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 52023, 53212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 52119, 52152);

                f_10968_52119_52151(f_10968_52132_52150(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 52320, 52370);

                BoundExpression
                boundExpression = f_10968_52354_52369(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 52384, 52676) || true) && (f_10968_52388_52408(boundExpression) == BoundKind.Local)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 52384, 52676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 52461, 52518);

                    var
                    localSym = f_10968_52476_52517(((BoundLocal)boundExpression))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 52536, 52661) || true) && (f_10968_52540_52556(localSym) == RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 52536, 52661);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 52614, 52642);

                        f_10968_52614_52641(this, localSym);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 52536, 52661);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 52384, 52676);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 52692, 52755);

                boundExpression = (BoundExpression)f_10968_52727_52754(this, boundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 52830, 52845);

                f_10968_52830_52844(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 52899, 52921);

                f_10968_52899_52920(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 52937, 52969);

                f_10968_52937_52968(this, f_10968_52950_52967(node));
                foreach ((_, LabelSymbol label) in f_10968_53018_53028(node))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 53062, 53082);

                    f_10968_53062_53081(this, label);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 53113, 53201);

                return f_10968_53120_53200(node, boundExpression, f_10968_53149_53159(node), f_10968_53161_53178(node), f_10968_53180_53199(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 52023, 53212);

                bool
                f_10968_52132_52150(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.EvalStackIsEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 52132, 52150);
                    return return_v;
                }


                int
                f_10968_52119_52151(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 52119, 52151);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_52354_52369(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 52354, 52369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_52388_52408(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 52388, 52408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_52476_52517(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 52476, 52517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10968_52540_52556(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 52540, 52556);
                    return return_v;
                }


                int
                f_10968_52614_52641(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localSymbol)
                {
                    this_param.ShouldNotSchedule(localSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 52614, 52641);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_52727_52754(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 52727, 52754);
                    return return_v;
                }


                int
                f_10968_52830_52844(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.PopEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 52830, 52844);
                    return 0;
                }


                int
                f_10968_52899_52920(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 52899, 52920);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10968_52950_52967(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.DefaultLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 52950, 52967);
                    return return_v;
                }


                int
                f_10968_52937_52968(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.RecordBranch(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 52937, 52968);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                f_10968_53018_53028(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Cases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 53018, 53028);
                    return return_v;
                }


                int
                f_10968_53062_53081(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.RecordBranch(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 53062, 53081);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                f_10968_53149_53159(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Cases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 53149, 53159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10968_53161_53178(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.DefaultLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 53161, 53178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10968_53180_53199(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.EqualityMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 53180, 53199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                f_10968_53120_53200(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                cases, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                defaultLabel, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                equalityMethod)
                {
                    var return_v = this_param.Update(expression, cases, defaultLabel, equalityMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 53120, 53200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 52023, 53212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 52023, 53212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalOperator(BoundConditionalOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 53224, 54287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 53330, 53359);

                var
                origStack = f_10968_53346_53358(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 53373, 53457);

                BoundExpression
                condition = f_10968_53401_53456(this, f_10968_53422_53436(node), ExprContext.Value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 53473, 53508);

                var
                cookie = f_10968_53486_53507(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 53547, 53614);

                var
                context = (DynAbs.Tracing.TraceSender.Conditional_F1(10968, 53561, 53571) || ((f_10968_53561_53571(node) && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 53574, 53593)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 53596, 53613))) ? ExprContext.Address : ExprContext.Value
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 53630, 53655);

                f_10968_53630_53654(this, origStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 53718, 53796);

                BoundExpression
                consequence = f_10968_53748_53795(this, f_10968_53769_53785(node), context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 53812, 53837);

                f_10968_53812_53836(this, cookie);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 53878, 53903);

                f_10968_53878_53902(this, origStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 53966, 54044);

                BoundExpression
                alternative = f_10968_53996_54043(this, f_10968_54017_54033(node), context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54060, 54085);

                f_10968_54060_54084(this, cookie);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54126, 54276);

                return f_10968_54133_54275(node, f_10968_54145_54155(node), condition, consequence, alternative, f_10968_54194_54215(node), f_10968_54217_54236(node), f_10968_54238_54263(node), f_10968_54265_54274(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 53224, 54287);

                int
                f_10968_53346_53358(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 53346, 53358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_53422_53436(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 53422, 53436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_53401_53456(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 53401, 53456);
                    return return_v;
                }


                object
                f_10968_53486_53507(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.GetStackStateCookie();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 53486, 53507);
                    return return_v;
                }


                bool
                f_10968_53561_53571(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 53561, 53571);
                    return return_v;
                }


                int
                f_10968_53630_53654(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 53630, 53654);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_53769_53785(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 53769, 53785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_53748_53795(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 53748, 53795);
                    return return_v;
                }


                int
                f_10968_53812_53836(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, object
                cookie)
                {
                    this_param.EnsureStackState(cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 53812, 53836);
                    return 0;
                }


                int
                f_10968_53878_53902(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 53878, 53902);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_54017_54033(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 54017, 54033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_53996_54043(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 53996, 54043);
                    return return_v;
                }


                int
                f_10968_54060_54084(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, object
                cookie)
                {
                    this_param.EnsureStackState(cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 54060, 54084);
                    return 0;
                }


                bool
                f_10968_54145_54155(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 54145, 54155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_54194_54215(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 54194, 54215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_54217_54236(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.NaturalTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 54217, 54236);
                    return return_v;
                }


                bool
                f_10968_54238_54263(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 54238, 54263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_54265_54274(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 54265, 54274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                f_10968_54133_54275(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param, bool
                isRef, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundExpression
                consequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                alternative, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                naturalTypeOpt, bool
                wasTargetTyped, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(isRef, condition, consequence, alternative, constantValueOpt, naturalTypeOpt, wasTargetTyped, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 54133, 54275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 53224, 54287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 53224, 54287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBinaryOperator(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 54299, 56649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54395, 54429);

                BoundExpression
                child = f_10968_54419_54428(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54445, 54606) || true) && (f_10968_54449_54459(child) != BoundKind.BinaryOperator || (DynAbs.Tracing.TraceSender.Expression_False(10968, 54449, 54518) || f_10968_54491_54510(child) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 54445, 54606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54552, 54591);

                    return f_10968_54559_54590(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 54445, 54606);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54697, 54757);

                var
                stack = f_10968_54709_54756()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54771, 54788);

                f_10968_54771_54787(stack, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54804, 54860);

                BoundBinaryOperator
                binary = (BoundBinaryOperator)child
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54876, 55209) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 54876, 55209);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54921, 54940);

                        f_10968_54921_54939(stack, binary);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54958, 54978);

                        child = f_10968_54966_54977(binary);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 54998, 55138) || true) && (f_10968_55002_55012(child) != BoundKind.BinaryOperator || (DynAbs.Tracing.TraceSender.Expression_False(10968, 55002, 55071) || f_10968_55044_55063(child) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 54998, 55138);
                            DynAbs.Tracing.TraceSender.TraceBreak(10968, 55113, 55119);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 54998, 55138);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55158, 55194);

                        binary = (BoundBinaryOperator)child;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 54876, 55209);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 54876, 55209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 54876, 55209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55225, 55252);

                var
                prevContext = _context
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55266, 55295);

                int
                prevStack = f_10968_55282_55294(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55311, 55357);

                var
                left = (BoundExpression)f_10968_55339_55356(this, child)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55373, 56530) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 55373, 56530);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55418, 55439);

                        binary = f_10968_55427_55438(stack);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55459, 55531);

                        var
                        isLogical = (f_10968_55476_55495(binary) & BinaryOperatorKind.Logical) != 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55551, 55572);

                        object
                        cookie = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55590, 55813) || true) && (isLogical)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 55590, 55813);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55645, 55676);

                            cookie = f_10968_55654_55675(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55726, 55751);

                            f_10968_55726_55750(this, prevStack);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 55590, 55813);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55833, 55887);

                        var
                        right = (BoundExpression)f_10968_55862_55886(this, f_10968_55873_55885(binary))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55907, 56031) || true) && (isLogical)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 55907, 56031);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 55962, 55987);

                            f_10968_55962_55986(this, cookie);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 55907, 56031);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56051, 56090);

                        var
                        type = f_10968_56062_56089(this, f_10968_56077_56088(binary))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56108, 56231);

                        left = f_10968_56115_56230(binary, f_10968_56129_56148(binary), f_10968_56150_56173(binary), f_10968_56175_56191(binary), f_10968_56193_56210(binary), left, right, type);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56251, 56338) || true) && (f_10968_56255_56266(stack) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 56251, 56338);
                            DynAbs.Tracing.TraceSender.TraceBreak(10968, 56313, 56319);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 56251, 56338);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56358, 56381);

                        _context = prevContext;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56399, 56413);

                        _counter += 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56431, 56456);

                        f_10968_56431_56455(this, prevStack);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56474, 56515);

                        f_10968_56474_56514(this, binary, ExprContext.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 55373, 56530);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 55373, 56530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 55373, 56530);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56546, 56583);

                f_10968_56546_56582((object)binary == node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56597, 56610);

                f_10968_56597_56609(stack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56626, 56638);

                return left;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 54299, 56649);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_54419_54428(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 54419, 54428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_54449_54459(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 54449, 54459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_54491_54510(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 54491, 54510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_54559_54590(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node)
                {
                    var return_v = this_param.VisitBinaryOperatorSimple(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 54559, 54590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                f_10968_54709_54756()
                {
                    var return_v = ArrayBuilder<BoundBinaryOperator>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 54709, 54756);
                    return return_v;
                }


                int
                f_10968_54771_54787(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 54771, 54787);
                    return 0;
                }


                int
                f_10968_54921_54939(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 54921, 54939);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_54966_54977(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 54966, 54977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_55002_55012(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 55002, 55012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_55044_55063(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 55044, 55063);
                    return return_v;
                }


                int
                f_10968_55282_55294(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 55282, 55294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_55339_55356(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 55339, 55356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10968_55427_55438(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 55427, 55438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10968_55476_55495(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 55476, 55495);
                    return return_v;
                }


                object
                f_10968_55654_55675(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.GetStackStateCookie();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 55654, 55675);
                    return return_v;
                }


                int
                f_10968_55726_55750(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 55726, 55750);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_55873_55885(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 55873, 55885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_55862_55886(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 55862, 55886);
                    return return_v;
                }


                int
                f_10968_55962_55986(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, object?
                cookie)
                {
                    this_param.EnsureStackState(cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 55962, 55986);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_56077_56088(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 56077, 56088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_56062_56089(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 56062, 56089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10968_56129_56148(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 56129, 56148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_56150_56173(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 56150, 56173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10968_56175_56191(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 56175, 56191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10968_56193_56210(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 56193, 56210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10968_56115_56230(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operatorKind, constantValueOpt, methodOpt, resultKind, left, right, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 56115, 56230);
                    return return_v;
                }


                int
                f_10968_56255_56266(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 56255, 56266);
                    return return_v;
                }


                int
                f_10968_56431_56455(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 56431, 56455);
                    return 0;
                }


                int
                f_10968_56474_56514(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                result, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    this_param.PushEvalStack((Microsoft.CodeAnalysis.CSharp.BoundExpression)result, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 56474, 56514);
                    return 0;
                }


                int
                f_10968_56546_56582(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 56546, 56582);
                    return 0;
                }


                int
                f_10968_56597_56609(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 56597, 56609);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 54299, 56649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 54299, 56649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundNode VisitBinaryOperatorSimple(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 56661, 57536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56755, 56825);

                var
                isLogical = (f_10968_56772_56789(node) & BinaryOperatorKind.Logical) != 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56839, 57471) || true) && (isLogical)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 56839, 57471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56886, 56915);

                    var
                    origStack = f_10968_56902_56914(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 56933, 56995);

                    BoundExpression
                    left = (BoundExpression)f_10968_56973_56994(this, f_10968_56984_56993(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 57015, 57050);

                    var
                    cookie = f_10968_57028_57049(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 57098, 57123);

                    f_10968_57098_57122(this, origStack);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 57184, 57248);

                    BoundExpression
                    right = (BoundExpression)f_10968_57225_57247(this, f_10968_57236_57246(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 57268, 57293);

                    f_10968_57268_57292(this, cookie);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 57338, 57456);

                    return f_10968_57345_57455(node, f_10968_57357_57374(node), f_10968_57376_57397(node), f_10968_57399_57413(node), f_10968_57415_57430(node), left, right, f_10968_57445_57454(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 56839, 57471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 57487, 57525);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBinaryOperator(node), 10968, 57494, 57524);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 56661, 57536);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10968_56772_56789(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 56772, 56789);
                    return return_v;
                }


                int
                f_10968_56902_56914(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 56902, 56914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_56984_56993(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 56984, 56993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_56973_56994(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 56973, 56994);
                    return return_v;
                }


                object
                f_10968_57028_57049(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.GetStackStateCookie();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 57028, 57049);
                    return return_v;
                }


                int
                f_10968_57098_57122(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 57098, 57122);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_57236_57246(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 57236, 57246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_57225_57247(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 57225, 57247);
                    return return_v;
                }


                int
                f_10968_57268_57292(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, object
                cookie)
                {
                    this_param.EnsureStackState(cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 57268, 57292);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10968_57357_57374(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 57357, 57374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_57376_57397(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 57376, 57397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10968_57399_57413(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 57399, 57413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10968_57415_57430(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 57415, 57430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_57445_57454(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 57445, 57454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10968_57345_57455(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operatorKind, constantValueOpt, methodOpt, resultKind, left, right, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 57345, 57455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 56661, 57536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 56661, 57536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNullCoalescingOperator(BoundNullCoalescingOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 57548, 58345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 57660, 57689);

                var
                origStack = f_10968_57676_57688(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 57703, 57772);

                BoundExpression
                left = (BoundExpression)f_10968_57743_57771(this, f_10968_57754_57770(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 57788, 57823);

                var
                cookie = f_10968_57801_57822(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 58053, 58078);

                f_10968_58053_58077(this, origStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 58092, 58163);

                BoundExpression
                right = (BoundExpression)f_10968_58133_58162(this, f_10968_58144_58161(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 58179, 58204);

                f_10968_58179_58203(this, cookie);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 58245, 58334);

                return f_10968_58252_58333(node, left, right, f_10968_58277_58296(node), f_10968_58298_58321(node), f_10968_58323_58332(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 57548, 58345);

                int
                f_10968_57676_57688(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 57676, 57688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_57754_57770(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 57754, 57770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_57743_57771(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 57743, 57771);
                    return return_v;
                }


                object
                f_10968_57801_57822(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.GetStackStateCookie();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 57801, 57822);
                    return return_v;
                }


                int
                f_10968_58053_58077(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 58053, 58077);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_58144_58161(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 58144, 58161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_58133_58162(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 58133, 58162);
                    return return_v;
                }


                int
                f_10968_58179_58203(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, object
                cookie)
                {
                    this_param.EnsureStackState(cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 58179, 58203);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10968_58277_58296(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 58277, 58296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperatorResultKind
                f_10968_58298_58321(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.OperatorResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 58298, 58321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_58323_58332(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 58323, 58332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                f_10968_58252_58333(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                leftOperand, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rightOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                leftConversion, Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperatorResultKind
                operatorResultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(leftOperand, rightOperand, leftConversion, operatorResultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 58252, 58333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 57548, 58345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 57548, 58345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLoweredConditionalAccess(BoundLoweredConditionalAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 58357, 59636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 58473, 58502);

                var
                origStack = f_10968_58489_58501(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 58516, 58576);

                BoundExpression
                receiver = f_10968_58543_58575(this, f_10968_58561_58574(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 58592, 58627);

                var
                cookie = f_10968_58605_58626(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 58841, 58866);

                f_10968_58841_58865(this, origStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 58880, 58956);

                BoundExpression
                whenNotNull = (BoundExpression)f_10968_58927_58955(this, f_10968_58938_58954(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 58972, 58997);

                f_10968_58972_58996(this, cookie);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59038, 59070);

                var
                whenNull = f_10968_59053_59069(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59084, 59513) || true) && (whenNull != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 59084, 59513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59138, 59163);

                    f_10968_59138_59162(this, origStack);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59227, 59276);

                    whenNull = (BoundExpression)f_10968_59255_59275(this, whenNull);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59294, 59319);

                    f_10968_59294_59318(this, cookie);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 59084, 59513);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 59084, 59513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59484, 59498);

                    _counter += 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 59084, 59513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59529, 59625);

                return f_10968_59536_59624(node, receiver, f_10968_59558_59580(node), whenNotNull, whenNull, f_10968_59605_59612(node), f_10968_59614_59623(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 58357, 59636);

                int
                f_10968_58489_58501(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 58489, 58501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_58561_58574(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 58561, 58574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_58543_58575(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.VisitCallReceiver(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 58543, 58575);
                    return return_v;
                }


                object
                f_10968_58605_58626(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.GetStackStateCookie();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 58605, 58626);
                    return return_v;
                }


                int
                f_10968_58841_58865(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 58841, 58865);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_58938_58954(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 58938, 58954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_58927_58955(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 58927, 58955);
                    return return_v;
                }


                int
                f_10968_58972_58996(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, object
                cookie)
                {
                    this_param.EnsureStackState(cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 58972, 58996);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10968_59053_59069(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNullOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 59053, 59069);
                    return return_v;
                }


                int
                f_10968_59138_59162(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 59138, 59162);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_59255_59275(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 59255, 59275);
                    return return_v;
                }


                int
                f_10968_59294_59318(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, object
                cookie)
                {
                    this_param.EnsureStackState(cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 59294, 59318);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10968_59558_59580(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.HasValueMethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 59558, 59580);
                    return return_v;
                }


                int
                f_10968_59605_59612(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 59605, 59612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_59614_59623(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 59614, 59623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                f_10968_59536_59624(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                hasValueMethodOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
                whenNotNull, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenNullOpt, int
                id, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(receiver, hasValueMethodOpt, whenNotNull, whenNullOpt, id, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 59536, 59624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 58357, 59636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 58357, 59636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitComplexConditionalReceiver(BoundComplexConditionalReceiver node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 59648, 60560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59768, 59790);

                f_10968_59768_59789(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59806, 59835);

                var
                origStack = f_10968_59822_59834(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59851, 59889);

                f_10968_59851_59888(this, null, ExprContext.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59905, 59940);

                var
                cookie = f_10968_59918_59939(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 59979, 60004);

                f_10968_59979_60003(this, origStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 60067, 60143);

                var
                valueTypeReceiver = (BoundExpression)f_10968_60108_60142(this, f_10968_60119_60141(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 60159, 60184);

                f_10968_60159_60183(this, cookie);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 60224, 60249);

                f_10968_60224_60248(this, origStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 60312, 60396);

                var
                referenceTypeReceiver = (BoundExpression)f_10968_60357_60395(this, f_10968_60368_60394(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 60412, 60437);

                f_10968_60412_60436(this, cookie);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 60477, 60549);

                return f_10968_60484_60548(node, valueTypeReceiver, referenceTypeReceiver, f_10968_60538_60547(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 59648, 60560);

                int
                f_10968_59768_59789(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 59768, 59789);
                    return 0;
                }


                int
                f_10968_59822_59834(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 59822, 59834);
                    return return_v;
                }


                int
                f_10968_59851_59888(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    this_param.PushEvalStack(result, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 59851, 59888);
                    return 0;
                }


                object
                f_10968_59918_59939(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.GetStackStateCookie();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 59918, 59939);
                    return return_v;
                }


                int
                f_10968_59979_60003(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 59979, 60003);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_60119_60141(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.ValueTypeReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 60119, 60141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_60108_60142(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 60108, 60142);
                    return return_v;
                }


                int
                f_10968_60159_60183(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, object
                cookie)
                {
                    this_param.EnsureStackState(cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 60159, 60183);
                    return 0;
                }


                int
                f_10968_60224_60248(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 60224, 60248);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_60368_60394(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.ReferenceTypeReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 60368, 60394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_60357_60395(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 60357, 60395);
                    return return_v;
                }


                int
                f_10968_60412_60436(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, object
                cookie)
                {
                    this_param.EnsureStackState(cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 60412, 60436);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_60538_60547(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 60538, 60547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                f_10968_60484_60548(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                valueTypeReceiver, Microsoft.CodeAnalysis.CSharp.BoundExpression
                referenceTypeReceiver, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(valueTypeReceiver, referenceTypeReceiver, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 60484, 60548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 59648, 60560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 59648, 60560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUnaryOperator(BoundUnaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 60572, 61334);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 60716, 61323) || true) && (f_10968_60720_60749(f_10968_60720_60737(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 60720, 60813) && f_10968_60753_60781(f_10968_60753_60770(node)) == UnaryOperatorKind.UnaryMinus))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 60716, 61323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 60847, 60876);

                    var
                    origStack = f_10968_60863_60875(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 60894, 60987);

                    f_10968_60894_60986(this, f_10968_60908_60966(node.Syntax, f_10968_60948_60965(f_10968_60948_60960(node))), ExprContext.Value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 61005, 61073);

                    BoundExpression
                    operand = (BoundExpression)f_10968_61048_61072(this, f_10968_61059_61071(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 61091, 61205);

                    return f_10968_61098_61204(node, f_10968_61110_61127(node), operand, f_10968_61138_61159(node), f_10968_61161_61175(node), f_10968_61177_61192(node), f_10968_61194_61203(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 60716, 61323);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 60716, 61323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 61271, 61308);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitUnaryOperator(node), 10968, 61278, 61307);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 60716, 61323);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 60572, 61334);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10968_60720_60737(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 60720, 60737);
                    return return_v;
                }


                bool
                f_10968_60720_60749(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.IsChecked();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 60720, 60749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10968_60753_60770(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 60753, 60770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10968_60753_60781(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 60753, 60781);
                    return return_v;
                }


                int
                f_10968_60863_60875(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 60863, 60875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_60948_60960(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 60948, 60960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_60948_60965(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 60948, 60965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                f_10968_60908_60966(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression(syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 60908, 60966);
                    return return_v;
                }


                int
                f_10968_60894_60986(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                result, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    this_param.PushEvalStack((Microsoft.CodeAnalysis.CSharp.BoundExpression)result, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 60894, 60986);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_61059_61071(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 61059, 61071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_61048_61072(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 61048, 61072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10968_61110_61127(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 61110, 61127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_61138_61159(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 61138, 61159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10968_61161_61175(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 61161, 61175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10968_61177_61192(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 61177, 61192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_61194_61203(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 61194, 61203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                f_10968_61098_61204(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operatorKind, operand, constantValueOpt, methodOpt, resultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 61098, 61204);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 60572, 61334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 60572, 61334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTryStatement(BoundTryStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 61346, 61895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 61438, 61460);

                f_10968_61438_61459(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 61474, 61527);

                var
                tryBlock = (BoundBlock)f_10968_61501_61526(this, f_10968_61512_61525(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 61543, 61594);

                var
                catchBlocks = f_10968_61561_61593(this, f_10968_61576_61592(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 61610, 61632);

                f_10968_61610_61631(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 61646, 61710);

                var
                finallyBlock = (BoundBlock)f_10968_61677_61709(this, f_10968_61688_61708(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 61726, 61748);

                f_10968_61726_61747(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 61764, 61884);

                return f_10968_61771_61883(node, tryBlock, catchBlocks, finallyBlock, finallyLabelOpt: f_10968_61837_61857(node), f_10968_61859_61882(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 61346, 61895);

                int
                f_10968_61438_61459(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 61438, 61459);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10968_61512_61525(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.TryBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 61512, 61525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_61501_61526(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 61501, 61526);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10968_61576_61592(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.CatchBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 61576, 61592);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10968_61561_61593(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 61561, 61593);
                    return return_v;
                }


                int
                f_10968_61610_61631(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 61610, 61631);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10968_61688_61708(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 61688, 61708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_61677_61709(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 61677, 61709);
                    return return_v;
                }


                int
                f_10968_61726_61747(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 61726, 61747);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                f_10968_61837_61857(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyLabelOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 61837, 61857);
                    return return_v;
                }


                bool
                f_10968_61859_61882(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.PreferFaultHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 61859, 61882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                f_10968_61771_61883(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                catchBlocks, Microsoft.CodeAnalysis.CSharp.BoundBlock
                finallyBlockOpt, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                finallyLabelOpt, bool
                preferFaultHandler)
                {
                    var return_v = this_param.Update(tryBlock, catchBlocks, finallyBlockOpt, finallyLabelOpt: finallyLabelOpt, preferFaultHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 61771, 61883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 61346, 61895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 61346, 61895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCatchBlock(BoundCatchBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 61907, 64274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 61995, 62017);

                f_10968_61995_62016(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62033, 62082);

                var
                exceptionSourceOpt = f_10968_62058_62081(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62096, 62133);

                f_10968_62096_62132(this, f_10968_62110_62121(node), stack: 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62149, 63026) || true) && (exceptionSourceOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 62149, 63026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62269, 62307);

                    f_10968_62269_62306(this, null, ExprContext.None);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62325, 62336);

                    _counter++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62428, 62947) || true) && (f_10968_62432_62455(exceptionSourceOpt) == BoundKind.Local)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 62428, 62947);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62516, 62577);

                        f_10968_62516_62576(this, f_10968_62531_62575(((BoundLocal)exceptionSourceOpt)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 62428, 62947);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 62428, 62947);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62659, 62688);

                        int
                        prevStack = f_10968_62675_62687(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62710, 62797);

                        exceptionSourceOpt = f_10968_62731_62796(this, exceptionSourceOpt, ExprContext.AssignmentTarget);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62819, 62843);

                        _assignmentLocal = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62903, 62928);

                        f_10968_62903_62927(this, prevStack);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 62428, 62947);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 62967, 62982);

                    f_10968_62967_62981(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63000, 63011);

                    _counter++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 62149, 63026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63042, 63076);

                BoundStatementList
                filterPrologue
                = default(BoundStatementList);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63090, 63391) || true) && (f_10968_63094_63125(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 63090, 63391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63167, 63189);

                    f_10968_63167_63188(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63207, 63288);

                    filterPrologue = (BoundStatementList)f_10968_63244_63287(this, f_10968_63255_63286(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 63090, 63391);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 63090, 63391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63354, 63376);

                    filterPrologue = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 63090, 63391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63407, 63435);

                BoundExpression
                boundFilter
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63449, 63961) || true) && (f_10968_63453_63476(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 63449, 63961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63518, 63585);

                    boundFilter = (BoundExpression)f_10968_63549_63584(this, f_10968_63560_63583(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63678, 63693);

                    f_10968_63678_63692(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63711, 63722);

                    _counter++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63839, 63861);

                    f_10968_63839_63860(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 63449, 63961);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 63449, 63961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63927, 63946);

                    boundFilter = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 63449, 63961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 63977, 64028);

                var
                boundBlock = (BoundBlock)f_10968_64006_64027(this, f_10968_64017_64026(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 64042, 64103);

                var
                exceptionTypeOpt = f_10968_64065_64102(this, f_10968_64080_64101(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 64119, 64263);

                return f_10968_64126_64262(node, f_10968_64138_64149(node), exceptionSourceOpt, exceptionTypeOpt, filterPrologue, boundFilter, boundBlock, f_10968_64230_64261(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 61907, 64274);

                int
                f_10968_61995_62016(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 61995, 62016);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10968_62058_62081(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 62058, 62081);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10968_62110_62121(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 62110, 62121);
                    return return_v;
                }


                int
                f_10968_62096_62132(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, int
                stack)
                {
                    this_param.DeclareLocals(locals, stack: stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 62096, 62132);
                    return 0;
                }


                int
                f_10968_62269_62306(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    this_param.PushEvalStack(result, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 62269, 62306);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_62432_62455(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 62432, 62455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_62531_62575(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 62531, 62575);
                    return return_v;
                }


                int
                f_10968_62516_62576(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.RecordVarWrite(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 62516, 62576);
                    return 0;
                }


                int
                f_10968_62675_62687(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 62675, 62687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_62731_62796(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 62731, 62796);
                    return return_v;
                }


                int
                f_10968_62903_62927(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 62903, 62927);
                    return 0;
                }


                int
                f_10968_62967_62981(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.PopEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 62967, 62981);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                f_10968_63094_63125(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterPrologueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 63094, 63125);
                    return return_v;
                }


                int
                f_10968_63167_63188(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 63167, 63188);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10968_63255_63286(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterPrologueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 63255, 63286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_63244_63287(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatementList
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 63244, 63287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10968_63453_63476(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 63453, 63476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_63560_63583(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 63560, 63583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_63549_63584(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 63549, 63584);
                    return return_v;
                }


                int
                f_10968_63678_63692(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.PopEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 63678, 63692);
                    return 0;
                }


                int
                f_10968_63839_63860(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 63839, 63860);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10968_64017_64026(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 64017, 64026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_64006_64027(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 64006, 64027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_64080_64101(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 64080, 64101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_64065_64102(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 64065, 64102);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10968_64138_64149(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 64138, 64149);
                    return return_v;
                }


                bool
                f_10968_64230_64261(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.IsSynthesizedAsyncCatchAll;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 64230, 64261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10968_64126_64262(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                exceptionSourceOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                exceptionTypeOpt, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                exceptionFilterPrologueOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                exceptionFilterOpt, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body, bool
                isSynthesizedAsyncCatchAll)
                {
                    var return_v = this_param.Update(locals, exceptionSourceOpt, exceptionTypeOpt, exceptionFilterPrologueOpt, exceptionFilterOpt, body, isSynthesizedAsyncCatchAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 64126, 64262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 61907, 64274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 61907, 64274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConvertedStackAllocExpression(BoundConvertedStackAllocExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 64286, 64605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 64505, 64527);

                f_10968_64505_64526(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 64541, 64594);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConvertedStackAllocExpression(node), 10968, 64548, 64593);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 64286, 64605);

                int
                f_10968_64505_64526(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 64505, 64526);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 64286, 64605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 64286, 64605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayInitialization(BoundArrayInitialization node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 64617, 66100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 64804, 64826);

                f_10968_64804_64825(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 64842, 64879);

                var
                initializers = f_10968_64861_64878(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 64893, 64952);

                ArrayBuilder<BoundExpression>
                rewrittenInitializers = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 64966, 65889) || true) && (f_10968_64970_64993_M(!initializers.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 64966, 65889);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65036, 65041);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65027, 65874) || true) && (i < initializers.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65068, 65071)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 65027, 65874))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 65027, 65874);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65184, 65206);

                            f_10968_65184_65205(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65230, 65264);

                            var
                            initializer = initializers[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65286, 65366);

                            var
                            rewrittenInitializer = f_10968_65313_65365(this, initializer, ExprContext.Value)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65390, 65677) || true) && (rewrittenInitializers == null && (DynAbs.Tracing.TraceSender.Expression_True(10968, 65394, 65462) && rewrittenInitializer != initializer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 65390, 65677);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65512, 65580);

                                rewrittenInitializers = f_10968_65536_65579();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65606, 65654);

                                f_10968_65606_65653(rewrittenInitializers, initializers, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 65390, 65677);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65701, 65855) || true) && (rewrittenInitializers != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 65701, 65855);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65784, 65832);

                                f_10968_65784_65831(rewrittenInitializers, rewrittenInitializer);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 65701, 65855);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 848);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 848);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 64966, 65889);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 65905, 66089);

                return f_10968_65912_66088(node, (DynAbs.Tracing.TraceSender.Conditional_F1(10968, 65924, 65953) || ((rewrittenInitializers != null && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 65993, 66035)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 66075, 66087))) ? f_10968_65993_66035(rewrittenInitializers) : initializers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 64617, 66100);

                int
                f_10968_64804_64825(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 64804, 64825);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_64861_64878(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 64861, 64878);
                    return return_v;
                }


                bool
                f_10968_64970_64993_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 64970, 64993);
                    return return_v;
                }


                int
                f_10968_65184_65205(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 65184, 65205);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_65313_65365(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 65313, 65365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_65536_65579()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 65536, 65579);
                    return return_v;
                }


                int
                f_10968_65606_65653(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items, int
                length)
                {
                    this_param.AddRange(items, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 65606, 65653);
                    return 0;
                }


                int
                f_10968_65784_65831(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 65784, 65831);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_65993_66035(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 65993, 66035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                f_10968_65912_66088(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    var return_v = this_param.Update(initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 65912, 66088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 64617, 66100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 64617, 66100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAddressOfOperator(BoundAddressOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 66112, 66390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 66214, 66303);

                BoundExpression
                visitedOperand = f_10968_66247_66302(this, f_10968_66268_66280(node), ExprContext.Address)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 66317, 66379);

                return f_10968_66324_66378(node, visitedOperand, f_10968_66352_66366(node), f_10968_66368_66377(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 66112, 66390);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_66268_66280(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 66268, 66280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_66247_66302(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext
                context)
                {
                    var return_v = this_param.VisitExpression(node, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 66247, 66302);
                    return return_v;
                }


                bool
                f_10968_66352_66366(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.IsManaged;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 66352, 66366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_66368_66377(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 66368, 66377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                f_10968_66324_66378(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, bool
                isManaged, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand, isManaged, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 66324, 66378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 66112, 66390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 66112, 66390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitReturnStatement(BoundReturnStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 66402, 66754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 66500, 66580);

                BoundExpression
                expressionOpt = (BoundExpression)f_10968_66549_66579(this, f_10968_66560_66578(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 66657, 66679);

                f_10968_66657_66678(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 66695, 66743);

                return f_10968_66702_66742(node, f_10968_66714_66726(node), expressionOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 66402, 66754);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10968_66560_66578(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 66560, 66578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_66549_66579(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 66549, 66579);
                    return return_v;
                }


                int
                f_10968_66657_66678(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    this_param.EnsureOnlyEvalStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 66657, 66678);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10968_66714_66726(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 66714, 66726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10968_66702_66742(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expressionOpt)
                {
                    var return_v = this_param.Update(refKind, expressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 66702, 66742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 66402, 66754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 66402, 66754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EnsureOnlyEvalStack()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 66919, 67010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 66978, 66999);

                f_10968_66978_66998(this, empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 66919, 67010);

                int
                f_10968_66978_66998(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                local)
                {
                    this_param.RecordVarRead((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 66978, 66998);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 66919, 67010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 66919, 67010);
            }
        }

        private object GetStackStateCookie()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 67022, 67366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67135, 67164);

                var
                dummy = f_10968_67147_67163()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67178, 67212);

                f_10968_67178_67211(_dummyVariables, dummy, dummy);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67226, 67288);

                f_10968_67226_67287(_locals, dummy, f_10968_67245_67286(f_10968_67273_67285(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67302, 67326);

                f_10968_67302_67325(this, dummy);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67342, 67355);

                return dummy;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 67022, 67366);

                Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                f_10968_67147_67163()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67147, 67163);
                    return return_v;
                }


                int
                f_10968_67178_67211(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal>
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                key, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67178, 67211);
                    return 0;
                }


                int
                f_10968_67273_67285(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67273, 67285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                f_10968_67245_67286(int
                stackAtDeclaration)
                {
                    var return_v = LocalDefUseInfo.GetInstance(stackAtDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67245, 67286);
                    return return_v;
                }


                int
                f_10968_67226_67287(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                key, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67226, 67287);
                    return 0;
                }


                int
                f_10968_67302_67325(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                local)
                {
                    this_param.RecordDummyWrite((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67302, 67325);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 67022, 67366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 67022, 67366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EnsureStackState(object cookie)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 67378, 67497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67447, 67486);

                f_10968_67447_67485(this, f_10968_67461_67484(_dummyVariables, cookie));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 67378, 67497);

                Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                f_10968_67461_67484(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal>
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 67461, 67484);
                    return return_v;
                }


                int
                f_10968_67447_67485(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                local)
                {
                    this_param.RecordVarRead((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67447, 67485);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 67378, 67497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 67378, 67497);
            }
        }

        private void RecordBranch(LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 67551, 68102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67620, 67637);

                DummyLocal
                dummy
                = default(DummyLocal);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67651, 68091) || true) && (f_10968_67655_67700(_dummyVariables, label, out dummy))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 67651, 68091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67734, 67755);

                    f_10968_67734_67754(this, dummy);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 67651, 68091);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 67651, 68091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67877, 67902);

                    dummy = f_10968_67885_67901();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67920, 67954);

                    f_10968_67920_67953(_dummyVariables, label, dummy);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 67972, 68034);

                    f_10968_67972_68033(_locals, dummy, f_10968_67991_68032(f_10968_68019_68031(this)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 68052, 68076);

                    f_10968_68052_68075(this, dummy);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 67651, 68091);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 67551, 68102);

                bool
                f_10968_67655_67700(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                value)
                {
                    var return_v = this_param.TryGetValue((object)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67655, 67700);
                    return return_v;
                }


                int
                f_10968_67734_67754(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                local)
                {
                    this_param.RecordVarRead((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67734, 67754);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                f_10968_67885_67901()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67885, 67901);
                    return return_v;
                }


                int
                f_10968_67920_67953(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67920, 67953);
                    return 0;
                }


                int
                f_10968_68019_68031(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 68019, 68031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                f_10968_67991_68032(int
                stackAtDeclaration)
                {
                    var return_v = LocalDefUseInfo.GetInstance(stackAtDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67991, 68032);
                    return return_v;
                }


                int
                f_10968_67972_68033(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                key, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 67972, 68033);
                    return 0;
                }


                int
                f_10968_68052_68075(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                local)
                {
                    this_param.RecordDummyWrite((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 68052, 68075);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 67551, 68102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 67551, 68102);
            }
        }

        private void RecordLabel(LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 68114, 68631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 68182, 68199);

                DummyLocal
                dummy
                = default(DummyLocal);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 68213, 68620) || true) && (f_10968_68217_68262(_dummyVariables, label, out dummy))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 68213, 68620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 68296, 68317);

                    f_10968_68296_68316(this, dummy);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 68213, 68620);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 68213, 68620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 68500, 68514);

                    dummy = empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 68532, 68566);

                    f_10968_68532_68565(_dummyVariables, label, dummy);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 68584, 68605);

                    f_10968_68584_68604(this, dummy);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 68213, 68620);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 68114, 68631);

                bool
                f_10968_68217_68262(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                value)
                {
                    var return_v = this_param.TryGetValue((object)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 68217, 68262);
                    return return_v;
                }


                int
                f_10968_68296_68316(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                local)
                {
                    this_param.RecordVarRead((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 68296, 68316);
                    return 0;
                }


                int
                f_10968_68532_68565(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 68532, 68565);
                    return 0;
                }


                int
                f_10968_68584_68604(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
                local)
                {
                    this_param.RecordVarRead((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 68584, 68604);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 68114, 68631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 68114, 68631);
            }
        }

        private void ShouldNotSchedule(LocalSymbol localSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 68643, 68913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 68723, 68752);

                LocalDefUseInfo
                localDefInfo
                = default(LocalDefUseInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 68766, 68902) || true) && (f_10968_68770_68820(_locals, localSymbol, out localDefInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 68766, 68902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 68854, 68887);

                    f_10968_68854_68886(localDefInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 68766, 68902);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 68643, 68913);

                bool
                f_10968_68770_68820(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 68770, 68820);
                    return return_v;
                }


                int
                f_10968_68854_68886(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    this_param.ShouldNotSchedule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 68854, 68886);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 68643, 68913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 68643, 68913);
            }
        }

        private void RecordVarRef(LocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 68925, 69303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 68994, 69068);

                f_10968_68994_69067(f_10968_69007_69020(local) == RefKind.None, "cannot take a ref of a ref");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69084, 69170) || true) && (!f_10968_69089_69114(this, local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 69084, 69170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69148, 69155);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 69084, 69170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69267, 69292);

                f_10968_69267_69291(this, local);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 68925, 69303);

                Microsoft.CodeAnalysis.RefKind
                f_10968_69007_69020(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 69007, 69020);
                    return return_v;
                }


                int
                f_10968_68994_69067(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 68994, 69067);
                    return 0;
                }


                bool
                f_10968_69089_69114(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.CanScheduleToStack(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 69089, 69114);
                    return return_v;
                }


                int
                f_10968_69267_69291(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localSymbol)
                {
                    this_param.ShouldNotSchedule(localSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 69267, 69291);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 68925, 69303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 68925, 69303);
            }
        }

        private void RecordVarRead(LocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 69315, 70686);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69385, 69471) || true) && (!f_10968_69390_69415(this, local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 69385, 69471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69449, 69456);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 69385, 69471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69487, 69516);

                var
                locInfo = f_10968_69501_69515(_locals, local)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69532, 69614) || true) && (f_10968_69536_69558(locInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 69532, 69614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69592, 69599);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 69532, 69614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69630, 69659);

                var
                defs = f_10968_69641_69658(locInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69673, 69837) || true) && (f_10968_69677_69687(defs) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 69673, 69837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69769, 69797);

                    f_10968_69769_69796(                //reading before writing.
                                    locInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69815, 69822);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 69673, 69837);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 69904, 70485) || true) && (f_10968_69908_69929(local) != SynthesizedLocalKind.OptimizerTemp)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 69904, 70485);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 70001, 70271) || true) && (f_10968_70005_70031(locInfo) != f_10968_70035_70047(this) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 70005, 70097) && !f_10968_70073_70097(this, local)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 70001, 70271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 70195, 70223);

                        f_10968_70195_70222(                    //reading at different eval stack.
                                            locInfo);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 70245, 70252);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 70001, 70271);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 69904, 70485);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 69904, 70485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 70395, 70470);

                    f_10968_70395_70469(local == empty || (DynAbs.Tracing.TraceSender.Expression_False(10968, 70408, 70468) || f_10968_70426_70452(locInfo) == f_10968_70456_70468(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 69904, 70485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 70501, 70527);

                var
                last = f_10968_70512_70522(defs) - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 70541, 70583);

                defs[last] = defs[last].WithEnd(_counter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 70599, 70643);

                var
                nextDef = f_10968_70613_70642(_counter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 70657, 70675);

                f_10968_70657_70674(defs, nextDef);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 69315, 70686);

                bool
                f_10968_69390_69415(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.CanScheduleToStack(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 69390, 69415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                f_10968_69501_69515(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 69501, 69515);
                    return return_v;
                }


                bool
                f_10968_69536_69558(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.CannotSchedule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 69536, 69558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                f_10968_69641_69658(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.LocalDefs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 69641, 69658);
                    return return_v;
                }


                int
                f_10968_69677_69687(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 69677, 69687);
                    return return_v;
                }


                int
                f_10968_69769_69796(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    this_param.ShouldNotSchedule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 69769, 69796);
                    return 0;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10968_69908_69929(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 69908, 69929);
                    return return_v;
                }


                int
                f_10968_70005_70031(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.StackAtDeclaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 70005, 70031);
                    return return_v;
                }


                int
                f_10968_70035_70047(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 70035, 70047);
                    return return_v;
                }


                bool
                f_10968_70073_70097(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.EvalStackHasLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 70073, 70097);
                    return return_v;
                }


                int
                f_10968_70195_70222(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    this_param.ShouldNotSchedule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 70195, 70222);
                    return 0;
                }


                int
                f_10968_70426_70452(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.StackAtDeclaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 70426, 70452);
                    return return_v;
                }


                int
                f_10968_70456_70468(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 70456, 70468);
                    return return_v;
                }


                int
                f_10968_70395_70469(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 70395, 70469);
                    return 0;
                }


                int
                f_10968_70512_70522(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 70512, 70522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                f_10968_70613_70642(int
                start)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 70613, 70642);
                    return return_v;
                }


                int
                f_10968_70657_70674(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 70657, 70674);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 69315, 70686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 69315, 70686);
            }
        }

        private bool EvalStackHasLocal(LocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 70698, 71046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 70772, 70800);

                var
                top = f_10968_70782_70799(_evalStack)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 70816, 71035);

                return top.Item2 == ((DynAbs.Tracing.TraceSender.Conditional_F1(10968, 70837, 70866) || ((f_10968_70837_70850(local) == RefKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 70869, 70886)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 70889, 70908))) ? ExprContext.Value : ExprContext.Address) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 70823, 70966) && f_10968_70933_70947(top.Item1) == BoundKind.Local) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 70823, 71034) && f_10968_70990_71025(((BoundLocal)top.Item1)) == local);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 70698, 71046);

                (Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext)
                f_10968_70782_70799(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.CodeGen.ExprContext)>
                this_param)
                {
                    var return_v = this_param.Last();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 70782, 70799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10968_70837_70850(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 70837, 70850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_70933_70947(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 70933, 70947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_70990_71025(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 70990, 71025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 70698, 71046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 70698, 71046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RecordDummyWrite(LocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 71058, 71509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 71131, 71205);

                f_10968_71131_71204(f_10968_71144_71165(local) == SynthesizedLocalKind.OptimizerTemp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 71221, 71250);

                var
                locInfo = f_10968_71235_71249(_locals, local)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 71320, 71395);

                f_10968_71320_71394(local == empty || (DynAbs.Tracing.TraceSender.Expression_False(10968, 71333, 71393) || f_10968_71351_71377(locInfo) == f_10968_71381_71393(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 71411, 71454);

                var
                locDef = f_10968_71424_71453(_counter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 71468, 71498);

                f_10968_71468_71497(f_10968_71468_71485(locInfo), locDef);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 71058, 71509);

                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10968_71144_71165(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 71144, 71165);
                    return return_v;
                }


                int
                f_10968_71131_71204(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 71131, 71204);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                f_10968_71235_71249(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 71235, 71249);
                    return return_v;
                }


                int
                f_10968_71351_71377(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.StackAtDeclaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 71351, 71377);
                    return return_v;
                }


                int
                f_10968_71381_71393(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 71381, 71393);
                    return return_v;
                }


                int
                f_10968_71320_71394(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 71320, 71394);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                f_10968_71424_71453(int
                start)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 71424, 71453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                f_10968_71468_71485(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.LocalDefs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 71468, 71485);
                    return return_v;
                }


                int
                f_10968_71468_71497(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 71468, 71497);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 71058, 71509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 71058, 71509);
            }
        }

        private void RecordVarWrite(LocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 71521, 72409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 71592, 71666);

                f_10968_71592_71665(f_10968_71605_71626(local) != SynthesizedLocalKind.OptimizerTemp);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 71682, 71768) || true) && (!f_10968_71687_71712(this, local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 71682, 71768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 71746, 71753);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 71682, 71768);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 71784, 71813);

                var
                locInfo = f_10968_71798_71812(_locals, local)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 71827, 71909) || true) && (f_10968_71831_71853(locInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 71827, 71909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 71887, 71894);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 71827, 71909);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 72049, 72082);

                var
                evalStack = f_10968_72065_72077(this) - 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 72098, 72295) || true) && (f_10968_72102_72128(locInfo) != evalStack)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 72098, 72295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 72227, 72255);

                    f_10968_72227_72254(                //writing at different eval stack.
                                    locInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 72273, 72280);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 72098, 72295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 72311, 72354);

                var
                locDef = f_10968_72324_72353(_counter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 72368, 72398);

                f_10968_72368_72397(f_10968_72368_72385(locInfo), locDef);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 71521, 72409);

                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10968_71605_71626(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 71605, 71626);
                    return return_v;
                }


                int
                f_10968_71592_71665(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 71592, 71665);
                    return 0;
                }


                bool
                f_10968_71687_71712(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.CanScheduleToStack(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 71687, 71712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                f_10968_71798_71812(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 71798, 71812);
                    return return_v;
                }


                bool
                f_10968_71831_71853(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.CannotSchedule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 71831, 71853);
                    return return_v;
                }


                int
                f_10968_72065_72077(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param)
                {
                    var return_v = this_param.StackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 72065, 72077);
                    return return_v;
                }


                int
                f_10968_72102_72128(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.StackAtDeclaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 72102, 72128);
                    return return_v;
                }


                int
                f_10968_72227_72254(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    this_param.ShouldNotSchedule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 72227, 72254);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                f_10968_72324_72353(int
                start)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 72324, 72353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                f_10968_72368_72385(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.LocalDefs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 72368, 72385);
                    return return_v;
                }


                int
                f_10968_72368_72397(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 72368, 72397);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 71521, 72409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 71521, 72409);
            }
        }

        private bool CanScheduleToStack(LocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 72421, 72617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 72496, 72606);

                return f_10968_72503_72527(local) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 72503, 72605) && (!_debugFriendly || (DynAbs.Tracing.TraceSender.Expression_False(10968, 72549, 72604) || !f_10968_72569_72604(f_10968_72569_72590(local)))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 72421, 72617);

                bool
                f_10968_72503_72527(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.CanScheduleToStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 72503, 72527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10968_72569_72590(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 72569, 72590);
                    return return_v;
                }


                bool
                f_10968_72569_72604(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.IsLongLived();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 72569, 72604);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 72421, 72617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 72421, 72617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DeclareLocals(ImmutableArray<LocalSymbol> locals, int stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 72629, 72842);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 72727, 72831);
                    foreach (var local in f_10968_72749_72755_I(locals))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 72727, 72831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 72789, 72816);

                        f_10968_72789_72815(this, local, stack);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 72727, 72831);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 72629, 72842);

                int
                f_10968_72789_72815(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, int
                stack)
                {
                    this_param.DeclareLocal(local, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 72789, 72815);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10968_72749_72755_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 72749, 72755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 72629, 72842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 72629, 72842);
            }
        }

        private void DeclareLocal(LocalSymbol local, int stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 72854, 73711);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 72934, 73700) || true) && ((object)local != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 72934, 73700);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 72993, 73685) || true) && (f_10968_72997_73022(this, local))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 72993, 73685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 73064, 73085);

                        LocalDefUseInfo
                        info
                        = default(LocalDefUseInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 73107, 73666) || true) && (!f_10968_73112_73148(_locals, local, out info))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 73107, 73666);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 73198, 73253);

                            f_10968_73198_73252(_locals, local, f_10968_73217_73251(stack));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 73107, 73666);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 73107, 73666);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 73351, 73471);

                            f_10968_73351_73470(f_10968_73364_73385(local) == SynthesizedLocalKind.LoweringTemp, "only lowering temps may be sometimes reused");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 73497, 73643) || true) && (f_10968_73501_73524(info) != stack)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 73497, 73643);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 73591, 73616);

                                f_10968_73591_73615(info);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 73497, 73643);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 73107, 73666);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 72993, 73685);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 72934, 73700);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 72854, 73711);

                bool
                f_10968_72997_73022(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.CanScheduleToStack(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 72997, 73022);
                    return return_v;
                }


                bool
                f_10968_73112_73148(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 73112, 73148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                f_10968_73217_73251(int
                stackAtDeclaration)
                {
                    var return_v = LocalDefUseInfo.GetInstance(stackAtDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 73217, 73251);
                    return return_v;
                }


                int
                f_10968_73198_73252(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 73198, 73252);
                    return 0;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10968_73364_73385(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 73364, 73385);
                    return return_v;
                }


                int
                f_10968_73351_73470(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 73351, 73470);
                    return 0;
                }


                int
                f_10968_73501_73524(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.StackAtDeclaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 73501, 73524);
                    return return_v;
                }


                int
                f_10968_73591_73615(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    this_param.ShouldNotSchedule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 73591, 73615);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 72854, 73711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 72854, 73711);
            }
        }

        static StackOptimizerPass1()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10968, 14070, 73718);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 15238, 15262);
            empty = f_10968_15246_15262(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10968, 14070, 73718);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 14070, 73718);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10968, 14070, 73718);

        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
        f_10968_14479_14525()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 14479, 14525);
            return return_v;
        }


        Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal>
        f_10968_14946_15021(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal>((System.Collections.Generic.IEqualityComparer<object>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 14946, 15021);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
        f_10968_15246_15262()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 15246, 15262);
            return return_v;
        }


        int
        f_10968_15689_15711(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
        this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
        local, int
        stack)
        {
            this_param.DeclareLocal((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local, stack);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 15689, 15711);
            return 0;
        }


        int
        f_10968_15726_15749(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass1
        this_param, Microsoft.CodeAnalysis.CSharp.CodeGen.DummyLocal
        local)
        {
            this_param.RecordDummyWrite((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)local);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 15726, 15749);
            return 0;
        }

    }
    internal sealed class StackOptimizerPass2 : BoundTreeRewriterWithStackGuard
    {
        private int _nodeCounter;

        private readonly Dictionary<LocalSymbol, LocalDefUseInfo> _info;

        private StackOptimizerPass2(Dictionary<LocalSymbol, LocalDefUseInfo> info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10968, 74300, 74423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 74201, 74213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 74282, 74287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 74399, 74412);

                _info = info;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10968, 74300, 74423);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 74300, 74423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 74300, 74423);
            }
        }

        public static BoundStatement Rewrite(BoundStatement src, Dictionary<LocalSymbol, LocalDefUseInfo> info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10968, 74435, 74678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 74563, 74609);

                var
                scheduler = f_10968_74579_74608(info)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 74623, 74667);

                return (BoundStatement)f_10968_74646_74666(scheduler, src);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10968, 74435, 74678);

                Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                f_10968_74579_74608(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                info)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 74579, 74608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_74646_74666(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 74646, 74666);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 74435, 74678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 74435, 74678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode Visit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 74690, 75333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 74762, 74779);

                BoundNode
                result
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 74984, 75027);

                var
                asExpression = node as BoundExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75041, 75258) || true) && (asExpression != null && (DynAbs.Tracing.TraceSender.Expression_True(10968, 75045, 75103) && f_10968_75069_75095(asExpression) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 75041, 75258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75137, 75151);

                    result = node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 75041, 75258);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 75041, 75258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75217, 75243);

                    result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10968, 75226, 75242);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 75041, 75258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75274, 75292);

                _nodeCounter += 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75308, 75322);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 74690, 75333);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_75069_75095(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 75069, 75095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 74690, 75333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 74690, 75333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBinaryOperator(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 75345, 76947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75441, 75475);

                BoundExpression
                child = f_10968_75465_75474(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75491, 75651) || true) && (f_10968_75495_75505(child) != BoundKind.BinaryOperator || (DynAbs.Tracing.TraceSender.Expression_False(10968, 75495, 75564) || f_10968_75537_75556(child) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 75491, 75651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75598, 75636);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBinaryOperator(node), 10968, 75605, 75635);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 75491, 75651);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75742, 75802);

                var
                stack = f_10968_75754_75801()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75816, 75833);

                f_10968_75816_75832(stack, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75849, 75905);

                BoundBinaryOperator
                binary = (BoundBinaryOperator)child
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75921, 76254) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 75921, 76254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 75966, 75985);

                        f_10968_75966_75984(stack, binary);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76003, 76023);

                        child = f_10968_76011_76022(binary);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76043, 76183) || true) && (f_10968_76047_76057(child) != BoundKind.BinaryOperator || (DynAbs.Tracing.TraceSender.Expression_False(10968, 76047, 76116) || f_10968_76089_76108(child) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 76043, 76183);
                            DynAbs.Tracing.TraceSender.TraceBreak(10968, 76158, 76164);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 76043, 76183);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76203, 76239);

                        binary = (BoundBinaryOperator)child;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 75921, 76254);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 75921, 76254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 75921, 76254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76270, 76316);

                var
                left = (BoundExpression)f_10968_76298_76315(this, child)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76332, 76828) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 76332, 76828);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76377, 76398);

                        binary = f_10968_76386_76397(stack);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76416, 76470);

                        var
                        right = (BoundExpression)f_10968_76445_76469(this, f_10968_76456_76468(binary))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76488, 76527);

                        var
                        type = f_10968_76499_76526(this, f_10968_76514_76525(binary))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76545, 76668);

                        left = f_10968_76552_76667(binary, f_10968_76566_76585(binary), f_10968_76587_76610(binary), f_10968_76612_76628(binary), f_10968_76630_76647(binary), left, right, type);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76688, 76775) || true) && (f_10968_76692_76703(stack) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 76688, 76775);
                            DynAbs.Tracing.TraceSender.TraceBreak(10968, 76750, 76756);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 76688, 76775);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76795, 76813);

                        _nodeCounter += 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 76332, 76828);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10968, 76332, 76828);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10968, 76332, 76828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76844, 76881);

                f_10968_76844_76880((object)binary == node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76895, 76908);

                f_10968_76895_76907(stack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 76924, 76936);

                return left;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 75345, 76947);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_75465_75474(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 75465, 75474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_75495_75505(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 75495, 75505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_75537_75556(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 75537, 75556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                f_10968_75754_75801()
                {
                    var return_v = ArrayBuilder<BoundBinaryOperator>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 75754, 75801);
                    return return_v;
                }


                int
                f_10968_75816_75832(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 75816, 75832);
                    return 0;
                }


                int
                f_10968_75966_75984(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 75966, 75984);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_76011_76022(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 76011, 76022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_76047_76057(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 76047, 76057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_76089_76108(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 76089, 76108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_76298_76315(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 76298, 76315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10968_76386_76397(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 76386, 76397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_76456_76468(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 76456, 76468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_76445_76469(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 76445, 76469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_76514_76525(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 76514, 76525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_76499_76526(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 76499, 76526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10968_76566_76585(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 76566, 76585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_76587_76610(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 76587, 76610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10968_76612_76628(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 76612, 76628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10968_76630_76647(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 76630, 76647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10968_76552_76667(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operatorKind, constantValueOpt, methodOpt, resultKind, left, right, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 76552, 76667);
                    return return_v;
                }


                int
                f_10968_76692_76703(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 76692, 76703);
                    return return_v;
                }


                int
                f_10968_76844_76880(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 76844, 76880);
                    return 0;
                }


                int
                f_10968_76895_76907(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 76895, 76907);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 75345, 76947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 75345, 76947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsLastAccess(LocalDefUseInfo locInfo, int counter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10968, 76959, 77141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 77054, 77130);

                return f_10968_77061_77129(f_10968_77061_77078(locInfo), (d) => counter == d.Start && counter == d.End);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10968, 76959, 77141);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                f_10968_77061_77078(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.LocalDefs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 77061, 77078);
                    return return_v;
                }


                bool
                f_10968_77061_77129(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                builder, System.Func<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan, bool>
                predicate)
                {
                    var return_v = builder.Any<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 77061, 77129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 76959, 77141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 76959, 77141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocal(BoundLocal node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 77153, 77783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 77231, 77255);

                LocalDefUseInfo
                locInfo
                = default(LocalDefUseInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 77269, 77400) || true) && (!f_10968_77274_77322(_info, f_10968_77292_77308(node), out locInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 77269, 77400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 77356, 77385);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocal(node), 10968, 77363, 77384);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 77269, 77400);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 77463, 77622) || true) && (!f_10968_77468_77503(locInfo, _nodeCounter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 77463, 77622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 77537, 77607);

                    return f_10968_77544_77606(node.Syntax, f_10968_77570_77594(f_10968_77570_77586(node)), f_10968_77596_77605(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 77463, 77622);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 77743, 77772);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocal(node), 10968, 77750, 77771);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 77153, 77783);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_77292_77308(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 77292, 77308);
                    return return_v;
                }


                bool
                f_10968_77274_77322(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 77274, 77322);
                    return return_v;
                }


                bool
                f_10968_77468_77503(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                locInfo, int
                counter)
                {
                    var return_v = IsLastAccess(locInfo, counter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 77468, 77503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_77570_77586(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 77570, 77586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10968_77570_77594(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 77570, 77594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_77596_77605(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 77596, 77605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDup
                f_10968_77544_77606(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDup(syntax, refKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 77544, 77606);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 77153, 77783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 77153, 77783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitObjectCreationExpression(BoundObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 77795, 78353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 77911, 77986);

                ImmutableArray<BoundExpression>
                arguments = f_10968_77955_77985(this, f_10968_77970_77984(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 78000, 78052);

                f_10968_78000_78051(f_10968_78013_78042(node) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 78066, 78110);

                TypeSymbol
                type = f_10968_78084_78109(this, f_10968_78099_78108(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 78124, 78342);

                return f_10968_78131_78341(node, f_10968_78143_78159(node), arguments, f_10968_78172_78193(node), f_10968_78195_78219(node), f_10968_78221_78234(node), f_10968_78236_78256(node), f_10968_78258_78279(node), f_10968_78281_78302(node), initializerExpressionOpt: null, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 77795, 78353);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_77970_77984(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 77970, 77984);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10968_77955_77985(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 77955, 77985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10968_78013_78042(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 78013, 78042);
                    return return_v;
                }


                int
                f_10968_78000_78051(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 78000, 78051);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_78099_78108(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 78099, 78108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_78084_78109(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 78084, 78109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10968_78143_78159(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 78143, 78159);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10968_78172_78193(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 78172, 78193);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10968_78195_78219(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 78195, 78219);
                    return return_v;
                }


                bool
                f_10968_78221_78234(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 78221, 78234);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10968_78236_78256(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 78236, 78256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10968_78258_78279(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 78258, 78279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10968_78281_78302(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 78281, 78302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10968_78131_78341(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                initializerExpressionOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(constructor, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, constantValueOpt, initializerExpressionOpt: initializerExpressionOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 78131, 78341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 77795, 78353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 77795, 78353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAssignmentOperator(BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 78365, 80396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 78469, 78493);

                LocalDefUseInfo
                locInfo
                = default(LocalDefUseInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 78507, 78542);

                var
                left = f_10968_78518_78527(node) as BoundLocal
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 78651, 78811) || true) && (left == null || (DynAbs.Tracing.TraceSender.Expression_False(10968, 78655, 78720) || !f_10968_78672_78720(_info, f_10968_78690_78706(left), out locInfo)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 78651, 78811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 78754, 78796);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAssignmentOperator(node), 10968, 78761, 78795);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 78651, 78811);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 79013, 79096);

                var
                isIndirectLocalStore = f_10968_79040_79064(f_10968_79040_79056(left)) != RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10968, 79040, 79095) && f_10968_79084_79095_M(!node.IsRef))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 79110, 79225) || true) && (isIndirectLocalStore)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 79110, 79225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 79168, 79210);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAssignmentOperator(node), 10968, 79175, 79209);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 79110, 79225);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 79619, 79637);

                _nodeCounter += 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 79681, 79728);

                var
                right = (BoundExpression)f_10968_79710_79727(this, f_10968_79716_79726(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 79783, 79876);

                f_10968_79783_79875(f_10968_79796_79874(f_10968_79796_79813(locInfo), (d) => _nodeCounter == d.Start && _nodeCounter <= d.End));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 79890, 79939);

                var
                isLast = f_10968_79903_79938(locInfo, _nodeCounter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 79955, 80385) || true) && (isLast)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 79955, 80385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 80076, 80089);

                    return right;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 79955, 80385);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 79955, 80385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 80315, 80370);

                    return f_10968_80322_80369(node, left, right, f_10968_80347_80357(node), f_10968_80359_80368(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 79955, 80385);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 78365, 80396);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_78518_78527(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 78518, 78527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_78690_78706(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 78690, 78706);
                    return return_v;
                }


                bool
                f_10968_78672_78720(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 78672, 78720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_79040_79056(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 79040, 79056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10968_79040_79064(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 79040, 79064);
                    return return_v;
                }


                bool
                f_10968_79084_79095_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 79084, 79095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10968_79716_79726(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 79716, 79726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_79710_79727(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 79710, 79727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                f_10968_79796_79813(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                this_param)
                {
                    var return_v = this_param.LocalDefs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 79796, 79813);
                    return return_v;
                }


                bool
                f_10968_79796_79874(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>
                builder, System.Func<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan, bool>
                predicate)
                {
                    var return_v = builder.Any<Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseSpan>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 79796, 79874);
                    return return_v;
                }


                int
                f_10968_79783_79875(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 79783, 79875);
                    return 0;
                }


                bool
                f_10968_79903_79938(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                locInfo, int
                counter)
                {
                    var return_v = IsLastAccess(locInfo, counter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 79903, 79938);
                    return return_v;
                }


                bool
                f_10968_80347_80357(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 80347, 80357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10968_80359_80368(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 80359, 80368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10968_80322_80369(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, bool
                isRef, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right, isRef, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 80322, 80369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 78365, 80396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 78365, 80396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCatchBlock(BoundCatchBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 80408, 82289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 80496, 80542);

                var
                exceptionSource = f_10968_80518_80541(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 80556, 80589);

                var
                type = f_10968_80567_80588(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 80603, 80656);

                var
                filterPrologue = f_10968_80624_80655(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 80670, 80707);

                var
                filter = f_10968_80683_80706(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 80721, 80742);

                var
                body = f_10968_80732_80741(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 80758, 81700) || true) && (exceptionSource != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 80758, 81700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 80875, 80890);

                    _nodeCounter++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 80910, 81590) || true) && (f_10968_80914_80934(exceptionSource) == BoundKind.Local)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 80910, 81590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 80995, 81055);

                        var
                        sourceLocal = f_10968_81013_81054(((BoundLocal)exceptionSource))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 81077, 81101);

                        LocalDefUseInfo
                        locInfo
                        = default(LocalDefUseInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 81224, 81431) || true) && (f_10968_81228_81271(_info, sourceLocal, out locInfo) && (DynAbs.Tracing.TraceSender.Expression_True(10968, 81228, 81335) && f_10968_81300_81335(locInfo, _nodeCounter)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 81224, 81431);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 81385, 81408);

                            exceptionSource = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 81224, 81431);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 80910, 81590);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 80910, 81590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 81513, 81571);

                        exceptionSource = (BoundExpression)f_10968_81548_81570(this, exceptionSource);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 80910, 81590);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 81670, 81685);

                    _nodeCounter++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 80758, 81700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 81716, 81814);

                filterPrologue = (DynAbs.Tracing.TraceSender.Conditional_F1(10968, 81733, 81757) || (((filterPrologue != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10968, 81760, 81806)) || DynAbs.Tracing.TraceSender.Conditional_F3(10968, 81809, 81813))) ? (BoundStatementList)f_10968_81780_81806(this, filterPrologue) : null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 81830, 82050) || true) && (filter != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10968, 81830, 82050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 81882, 81927);

                    filter = (BoundExpression)f_10968_81908_81926(this, filter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 82020, 82035);

                    _nodeCounter++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10968, 81830, 82050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 82066, 82102);

                body = (BoundBlock)f_10968_82085_82101(this, body);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 82116, 82144);

                type = f_10968_82123_82143(this, type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 82160, 82278);

                return f_10968_82167_82277(node, f_10968_82179_82190(node), exceptionSource, type, filterPrologue, filter, body, f_10968_82245_82276(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 80408, 82289);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10968_80518_80541(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 80518, 80541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_80567_80588(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 80567, 80588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                f_10968_80624_80655(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterPrologueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 80624, 80655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10968_80683_80706(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 80683, 80706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10968_80732_80741(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 80732, 80741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10968_80914_80934(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 80914, 80934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10968_81013_81054(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 81013, 81054);
                    return return_v;
                }


                bool
                f_10968_81228_81271(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, out Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 81228, 81271);
                    return return_v;
                }


                bool
                f_10968_81300_81335(Microsoft.CodeAnalysis.CSharp.CodeGen.LocalDefUseInfo
                locInfo, int
                counter)
                {
                    var return_v = IsLastAccess(locInfo, counter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 81300, 81335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_81548_81570(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 81548, 81570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_81780_81806(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatementList
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 81780, 81806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_81908_81926(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 81908, 81926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10968_82085_82101(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 82085, 82101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10968_82123_82143(Microsoft.CodeAnalysis.CSharp.CodeGen.StackOptimizerPass2
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 82123, 82143);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10968_82179_82190(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 82179, 82190);
                    return return_v;
                }


                bool
                f_10968_82245_82276(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.IsSynthesizedAsyncCatchAll;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 82245, 82276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10968_82167_82277(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                exceptionSourceOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                exceptionTypeOpt, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                exceptionFilterPrologueOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                exceptionFilterOpt, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body, bool
                isSynthesizedAsyncCatchAll)
                {
                    var return_v = this_param.Update(locals, exceptionSourceOpt, exceptionTypeOpt, exceptionFilterPrologueOpt, exceptionFilterOpt, body, isSynthesizedAsyncCatchAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 82167, 82277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 80408, 82289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 80408, 82289);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StackOptimizerPass2()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10968, 74097, 82296);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10968, 74097, 82296);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 74097, 82296);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10968, 74097, 82296);
    }
    internal sealed class DummyLocal : LocalSymbol
    {
        internal override bool IsImportedFromMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 82437, 82458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 82443, 82456);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 82437, 82458);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 82367, 82469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 82367, 82469);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LocalDeclarationKind DeclarationKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 82560, 82601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 82566, 82599);

                    return LocalDeclarationKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 82560, 82601);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 82481, 82612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 82481, 82612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SynthesizedLocalKind SynthesizedKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 82703, 82753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 82709, 82751);

                    return SynthesizedLocalKind.OptimizerTemp;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 82703, 82753);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 82624, 82764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 82624, 82764);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxNode ScopeDesignatorOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 82848, 82868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 82854, 82866);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 82848, 82868);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 82776, 82879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 82776, 82879);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LocalSymbol WithSynthesizedLocalKindAndSyntax(SynthesizedLocalKind kind, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 82891, 83072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 83025, 83061);

                throw f_10968_83031_83060();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 82891, 83072);

                System.NotImplementedException
                f_10968_83031_83060()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 83031, 83060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 82891, 83072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 82891, 83072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxToken IdentifierToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 83154, 83190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 83160, 83188);

                    return default(SyntaxToken);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 83154, 83190);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 83084, 83201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 83084, 83201);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsPinned
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 83269, 83290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 83275, 83288);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 83269, 83290);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 83213, 83301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 83213, 83301);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 83377, 83421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 83383, 83419);

                    throw f_10968_83389_83418();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 83377, 83421);

                    System.NotImplementedException
                    f_10968_83389_83418()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 83389, 83418);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 83313, 83432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 83313, 83432);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 83524, 83568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 83530, 83566);

                    throw f_10968_83536_83565();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 83524, 83568);

                    System.NotImplementedException
                    f_10968_83536_83565()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 83536, 83565);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 83444, 83579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 83444, 83579);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 83666, 83710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 83672, 83708);

                    throw f_10968_83678_83707();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 83666, 83710);

                    System.NotImplementedException
                    f_10968_83678_83707()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 83678, 83707);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 83591, 83721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 83591, 83721);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 83831, 83875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 83837, 83873);

                    throw f_10968_83843_83872();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 83831, 83875);

                    System.NotImplementedException
                    f_10968_83843_83872()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 83843, 83872);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 83733, 83886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 83733, 83886);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue GetConstantValue(SyntaxNode node, LocalSymbol inProgress, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 83898, 84086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 84039, 84075);

                throw f_10968_84045_84074();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 83898, 84086);

                System.NotImplementedException
                f_10968_84045_84074()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 84045, 84074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 83898, 84086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 83898, 84086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsCompilerGenerated
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 84165, 84185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 84171, 84183);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 84165, 84185);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 84098, 84196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 84098, 84196);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<Diagnostic> GetConstantValueDiagnostics(BoundExpression boundInitValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 84208, 84384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 84337, 84373);

                throw f_10968_84343_84372();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 84208, 84384);

                System.NotImplementedException
                f_10968_84343_84372()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 84343, 84372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 84208, 84384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 84208, 84384);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode GetDeclaratorSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 84396, 84518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 84471, 84507);

                throw f_10968_84477_84506();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 84396, 84518);

                System.NotImplementedException
                f_10968_84477_84506()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10968, 84477, 84506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 84396, 84518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 84396, 84518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 84586, 84614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 84592, 84612);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 84586, 84614);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 84530, 84625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 84530, 84625);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override uint ValEscapeScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 84867, 84906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 84870, 84906);
                    throw f_10968_84876_84906(); DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 84867, 84906);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 84867, 84906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 84867, 84906);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override uint RefEscapeScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10968, 85149, 85188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10968, 85152, 85188);
                    throw f_10968_85158_85188(); DynAbs.Tracing.TraceSender.TraceExitMethod(10968, 85149, 85188);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10968, 85149, 85188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 85149, 85188);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DummyLocal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10968, 82304, 85196);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10968, 82304, 85196);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 82304, 85196);
        }


        static DummyLocal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10968, 82304, 85196);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10968, 82304, 85196);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10968, 82304, 85196);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10968, 82304, 85196);

        System.Exception
        f_10968_84876_84906()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 84876, 84906);
            return return_v;
        }


        System.Exception
        f_10968_85158_85188()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10968, 85158, 85188);
            return return_v;
        }

    }
}
