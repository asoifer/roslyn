// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class LocalRewriter
    {
        private abstract class PatternLocalRewriter
        {
            protected readonly LocalRewriter _localRewriter;

            protected readonly SyntheticBoundNodeFactory _factory;

            protected readonly DagTempAllocator _tempAllocator;

            public PatternLocalRewriter(SyntaxNode node, LocalRewriter localRewriter, bool generateInstrumentation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10476, 1025, 1424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 861, 875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 935, 943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 994, 1008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 1965, 2012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 1161, 1192);

                    _localRewriter = localRewriter;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 1210, 1244);

                    _factory = localRewriter._factory;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 1262, 1312);

                    GenerateInstrumentation = generateInstrumentation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 1330, 1409);

                    _tempAllocator = f_10476_1347_1408(_factory, node, generateInstrumentation);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10476, 1025, 1424);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 1025, 1424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 1025, 1424);
                }
            }

            protected bool GenerateInstrumentation { get; }

            public void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 2028, 2116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 2079, 2101);

                    f_10476_2079_2100(_tempAllocator);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 2028, 2116);

                    int
                    f_10476_2079_2100(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 2079, 2100);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 2028, 2116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 2028, 2116);
                }
            }
            public sealed class DagTempAllocator
            {
                private readonly SyntheticBoundNodeFactory _factory;

                private readonly PooledDictionary<BoundDagTemp, BoundExpression> _map;

                private readonly ArrayBuilder<LocalSymbol> _temps;

                private readonly SyntaxNode _node;

                private readonly bool _generateSequencePoints;

                public DagTempAllocator(SyntheticBoundNodeFactory factory, SyntaxNode node, bool generateSequencePoints)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10476, 2653, 2942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 2244, 2252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 2336, 2404);
                        this._map = f_10476_2343_2404(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 2466, 2514);
                        this._temps = f_10476_2475_2514(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 2561, 2566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 2609, 2632);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 2798, 2817);

                        _factory = factory;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 2839, 2852);

                        _node = node;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 2874, 2923);

                        _generateSequencePoints = generateSequencePoints;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10476, 2653, 2942);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 2653, 2942);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 2653, 2942);
                    }
                }

                public void Free()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 2962, 3088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3021, 3035);

                        f_10476_3021_3034(_temps);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3057, 3069);

                        f_10476_3057_3068(_map);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 2962, 3088);

                        int
                        f_10476_3021_3034(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3021, 3034);
                            return 0;
                        }


                        int
                        f_10476_3057_3068(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3057, 3068);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 2962, 3088);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 2962, 3088);
                    }
                }

                public string Dump()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 3119, 3756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3180, 3232);

                        var
                        poolElement = f_10476_3198_3231()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3254, 3288);

                        var
                        builder = poolElement.Builder
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3310, 3604);
                            foreach (var kv in f_10476_3329_3333_I(_map))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 3310, 3604);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3383, 3407);

                                f_10476_3383_3406(builder, "Key: ");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3433, 3467);

                                f_10476_3433_3466(builder, f_10476_3452_3465(kv.Key));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3493, 3519);

                                f_10476_3493_3518(builder, "Value: ");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3545, 3581);

                                f_10476_3545_3580(builder, f_10476_3564_3579(kv.Value));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 3310, 3604);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10476, 1, 295);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10476, 1, 295);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3628, 3660);

                        var
                        result = f_10476_3641_3659(builder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3682, 3701);

                        f_10476_3682_3700(poolElement);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3723, 3737);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 3119, 3756);

                        Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                        f_10476_3198_3231()
                        {
                            var return_v = PooledStringBuilder.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3198, 3231);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_10476_3383_3406(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3383, 3406);
                            return return_v;
                        }


                        string
                        f_10476_3452_3465(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Dump();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3452, 3465);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_10476_3433_3466(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.AppendLine(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3433, 3466);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_10476_3493_3518(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3493, 3518);
                            return return_v;
                        }


                        string
                        f_10476_3564_3579(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Dump();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3564, 3579);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_10476_3545_3580(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.AppendLine(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3545, 3580);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        f_10476_3329_3333_I(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3329, 3333);
                            return return_v;
                        }


                        string
                        f_10476_3641_3659(System.Text.StringBuilder
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3641, 3659);
                            return return_v;
                        }


                        int
                        f_10476_3682_3700(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3682, 3700);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 3119, 3756);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 3119, 3756);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public BoundExpression GetTemp(BoundDagTemp dagTemp)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 3784, 4448);
                        Microsoft.CodeAnalysis.CSharp.BoundExpression result = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3877, 4391) || true) && (!f_10476_3882_3935(_map, dagTemp, out result))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 3877, 4391);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 3985, 4105);

                            var
                            kind = (DynAbs.Tracing.TraceSender.Conditional_F1(10476, 3996, 4019) || ((_generateSequencePoints && DynAbs.Tracing.TraceSender.Conditional_F2(10476, 4022, 4068)) || DynAbs.Tracing.TraceSender.Conditional_F3(10476, 4071, 4104))) ? SynthesizedLocalKind.SwitchCasePatternMatching : SynthesizedLocalKind.LoweringTemp
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 4131, 4217);

                            LocalSymbol
                            temp = f_10476_4150_4216(_factory, f_10476_4176_4188(dagTemp), syntax: _node, kind: kind)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 4243, 4273);

                            result = f_10476_4252_4272(_factory, temp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 4299, 4325);

                            f_10476_4299_4324(_map, dagTemp, result);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 4351, 4368);

                            f_10476_4351_4367(_temps, temp);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 3877, 4391);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 4415, 4429);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 3784, 4448);

                        bool
                        f_10476_3882_3935(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        key, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 3882, 3935);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10476_4176_4188(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 4176, 4188);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                        f_10476_4150_4216(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type, Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.SynthesizedLocalKind
                        kind)
                        {
                            var return_v = this_param.SynthesizedLocal(type, syntax: syntax, kind: kind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 4150, 4216);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundLocal
                        f_10476_4252_4272(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                        local)
                        {
                            var return_v = this_param.Local(local);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 4252, 4272);
                            return return_v;
                        }


                        int
                        f_10476_4299_4324(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        key, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 4299, 4324);
                            return 0;
                        }


                        int
                        f_10476_4351_4367(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 4351, 4367);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 3784, 4448);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 3784, 4448);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public bool TrySetTemp(BoundDagTemp dagTemp, BoundExpression translation)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 5044, 5386);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 5158, 5330) || true) && (!f_10476_5163_5188(_map, dagTemp))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 5158, 5330);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 5238, 5269);

                            f_10476_5238_5268(_map, dagTemp, translation);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 5295, 5307);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 5158, 5330);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 5354, 5367);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 5044, 5386);

                        bool
                        f_10476_5163_5188(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        key)
                        {
                            var return_v = this_param.ContainsKey(key);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 5163, 5188);
                            return return_v;
                        }


                        int
                        f_10476_5238_5268(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        key, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 5238, 5268);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 5044, 5386);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 5044, 5386);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public ImmutableArray<LocalSymbol> AllTemps()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 5406, 5544);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 5492, 5525);

                        return f_10476_5499_5524(_temps);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 5406, 5544);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        f_10476_5499_5524(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        items)
                        {
                            var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 5499, 5524);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 5406, 5544);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 5406, 5544);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static DagTempAllocator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10476, 2132, 5559);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10476, 2132, 5559);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 2132, 5559);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10476, 2132, 5559);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10476_2343_2404()
                {
                    var return_v = PooledDictionary<BoundDagTemp, BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 2343, 2404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10476_2475_2514()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 2475, 2514);
                    return return_v;
                }

            }

            protected BoundExpression LowerEvaluation(BoundDagEvaluation evaluation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 5713, 12746);
                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol getValueOrDefault = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 5818, 5883);

                    BoundExpression
                    input = f_10476_5842_5882(_tempAllocator, f_10476_5865_5881(evaluation))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 5901, 12731);

                    switch (evaluation)
                    {

                        case BoundDagFieldEvaluation f:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 5901, 12731);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 6049, 6077);

                                FieldSymbol
                                field = f_10476_6069_6076(f)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 6107, 6166);

                                var
                                outputTemp = f_10476_6124_6165(f.Syntax, f_10476_6151_6161(field), f)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 6196, 6256);

                                BoundExpression
                                output = f_10476_6221_6255(_tempAllocator, outputTemp)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 6286, 6409);

                                BoundExpression
                                access = f_10476_6311_6408(_localRewriter, f.Syntax, input, field, null, LookupResultKind.Viable, f_10476_6397_6407(field))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 6439, 6474);

                                access.WasCompilerGenerated = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 6504, 6557);

                                return f_10476_6511_6556(_factory, output, access);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 5901, 12731);

                        case BoundDagPropertyEvaluation p:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 5901, 12731);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 6699, 6736);

                                PropertySymbol
                                property = f_10476_6725_6735(p)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 6766, 6828);

                                var
                                outputTemp = f_10476_6783_6827(p.Syntax, f_10476_6810_6823(property), p)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 6858, 6918);

                                BoundExpression
                                output = f_10476_6883_6917(_tempAllocator, outputTemp)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 6948, 7029);

                                return f_10476_6955_7028(_factory, output, f_10476_6993_7027(_factory, input, property));
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 5901, 12731);

                        case BoundDagDeconstructEvaluation d:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 5901, 12731);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 7174, 7216);

                                MethodSymbol
                                method = f_10476_7196_7215(d)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 7246, 7303);

                                var
                                refKindBuilder = f_10476_7267_7302()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 7333, 7394);

                                var
                                argBuilder = f_10476_7350_7393()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 7424, 7449);

                                BoundExpression
                                receiver
                                = default(BoundExpression);

                                int
                                f_10476_8908_8963(Microsoft.CodeAnalysis.RefKind
                                refKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                                expression)
                                {
                                    addArg(refKind, expression);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 8908, 8963);
                                    return 0;
                                }

                                int
                                f_10476_8143_8185(Microsoft.CodeAnalysis.RefKind
                                refKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                                expression)
                                {
                                    addArg(refKind, expression);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 8143, 8185);
                                    return 0;
                                }

                                void addArg(RefKind refKind, BoundExpression expression)
                                {
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 7479, 7720);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 7600, 7628);

                                        f_10476_7600_7627(refKindBuilder, refKind);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 7662, 7689);

                                        f_10476_7662_7688(argBuilder, expression);
                                        DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 7479, 7720);

                                        int
                                        f_10476_7600_7627(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                                        this_param, Microsoft.CodeAnalysis.RefKind
                                        item)
                                        {
                                            this_param.Add(item);
                                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 7600, 7627);
                                            return 0;
                                        }


                                        int
                                        f_10476_7662_7688(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                                        this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                                        item)
                                        {
                                            this_param.Add(item);
                                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 7662, 7688);
                                            return 0;
                                        }

                                    }
                                    catch
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 7479, 7720);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 7479, 7720);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 7752, 7824);

                                f_10476_7752_7823(f_10476_7765_7776(method) == WellKnownMemberNames.DeconstructMethodName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 7854, 7873);

                                int
                                extensionExtra
                                = default(int);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 7903, 8470) || true) && (f_10476_7907_7922(method))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 7903, 8470);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 7988, 8027);

                                    f_10476_7988_8026(f_10476_8001_8025(method));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8061, 8109);

                                    receiver = f_10476_8072_8108(_factory, f_10476_8086_8107(method));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8143, 8186);

                                    f_10476_8143_8185(f_10476_8150_8174(method)[0], input);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8220, 8239);

                                    extensionExtra = 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 7903, 8470);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 7903, 8470);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8369, 8386);

                                    receiver = input;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8420, 8439);

                                    extensionExtra = 0;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 7903, 8470);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8511, 8529);

                                    for (int
        i = extensionExtra
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8502, 8995) || true) && (i < f_10476_8535_8556(method))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8558, 8561)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 8502, 8995))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 8502, 8995);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8627, 8676);

                                        ParameterSymbol
                                        parameter = f_10476_8655_8672(method)[i]
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8710, 8757);

                                        f_10476_8710_8756(f_10476_8723_8740(parameter) == RefKind.Out);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8791, 8874);

                                        var
                                        outputTemp = f_10476_8808_8873(d.Syntax, f_10476_8835_8849(parameter), d, i - extensionExtra)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 8908, 8964);

                                        f_10476_8908_8963(RefKind.Out, f_10476_8928_8962(_tempAllocator, outputTemp));
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10476, 1, 494);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10476, 1, 494);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 9027, 9136);

                                return f_10476_9034_9135(_factory, receiver, method, f_10476_9066_9101(refKindBuilder), f_10476_9103_9134(argBuilder));
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 5901, 12731);

                        case BoundDagTypeEvaluation t:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 5901, 12731);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 9274, 9308);

                                TypeSymbol
                                inputType = f_10476_9297_9307(input)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 9338, 9369);

                                f_10476_9338_9368(inputType is { });

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 9399, 9748) || true) && (f_10476_9403_9424(inputType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 9399, 9748);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 9580, 9640);

                                    inputType = f_10476_9592_9639(_factory, SpecialType.System_Object);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 9674, 9717);

                                    input = f_10476_9682_9716(_factory, inputType, input);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 9399, 9748);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 9780, 9805);

                                TypeSymbol
                                type = f_10476_9798_9804(t)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 9835, 9888);

                                var
                                outputTemp = f_10476_9852_9887(t.Syntax, type, t)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 9918, 9978);

                                BoundExpression
                                output = f_10476_9943_9977(_tempAllocator, outputTemp)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 10008, 10058);

                                HashSet<DiagnosticInfo>
                                useSiteDiagnostics = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 10088, 10219);

                                Conversion
                                conversion = f_10476_10112_10218(f_10476_10112_10144(f_10476_10112_10132(_factory)), inputType, f_10476_10182_10193(output), ref useSiteDiagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 10249, 10311);

                                f_10476_10249_10310(_localRewriter._diagnostics, t.Syntax, useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 10341, 10367);

                                BoundExpression
                                evaluated
                                = default(BoundExpression);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 10397, 11555) || true) && (conversion.Exists)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 10397, 11555);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 10484, 11357) || true) && (conversion.Kind == ConversionKind.ExplicitNullable && (DynAbs.Tracing.TraceSender.Expression_True(10476, 10488, 10670) && f_10476_10579_10670(f_10476_10579_10616(inputType), f_10476_10624_10635(output), TypeCompareKind.AllIgnoreOptions)) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 10488, 10854) && f_10476_10711_10854(_localRewriter, t.Syntax, inputType, SpecialMember.System_Nullable_T_GetValueOrDefault, out getValueOrDefault)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 10484, 11357);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 11070, 11122);

                                        evaluated = f_10476_11082_11121(_factory, input, getValueOrDefault);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 10484, 11357);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 10484, 11357);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 11268, 11322);

                                        evaluated = f_10476_11280_11321(_factory, type, input, conversion);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 10484, 11357);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 10397, 11555);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 10397, 11555);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 11487, 11524);

                                    evaluated = f_10476_11499_11523(_factory, input, type);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 10397, 11555);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 11587, 11643);

                                return f_10476_11594_11642(_factory, output, evaluated);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 5901, 12731);

                        case BoundDagIndexEvaluation e:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 5901, 12731);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 11996, 12051);

                                f_10476_11996_12050(f_10476_12009_12044(f_10476_12009_12029(f_10476_12009_12019(e))) == 1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 12081, 12175);

                                f_10476_12081_12174(f_10476_12094_12145(f_10476_12094_12133(f_10476_12094_12125(f_10476_12094_12114(f_10476_12094_12104(e)))[0])) == SpecialType.System_Int32);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 12205, 12255);

                                TypeSymbol
                                type = f_10476_12223_12254(f_10476_12223_12243(f_10476_12223_12233(e)))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 12285, 12338);

                                var
                                outputTemp = f_10476_12302_12337(e.Syntax, type, e)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 12368, 12428);

                                BoundExpression
                                output = f_10476_12393_12427(_tempAllocator, outputTemp)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 12458, 12574);

                                return f_10476_12465_12573(_factory, output, f_10476_12503_12572(_factory, input, f_10476_12524_12544(f_10476_12524_12534(e)), f_10476_12546_12571(_factory, f_10476_12563_12570(e))));
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 5901, 12731);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 5901, 12731);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 12659, 12712);

                            throw f_10476_12665_12711(evaluation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 5901, 12731);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 5713, 12746);

                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_5865_5881(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 5865, 5881);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_5842_5882(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 5842, 5882);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10476_6069_6076(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                    this_param)
                    {
                        var return_v = this_param.Field;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 6069, 6076);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_6151_6161(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 6151, 6161);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_6124_6165(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                    source)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 6124, 6165);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_6221_6255(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 6221, 6255);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_6397_6407(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 6397, 6407);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_6311_6408(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    rewrittenReceiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                    constantValueOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                    resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = this_param.MakeFieldAccess(syntax, rewrittenReceiver, fieldSymbol, constantValueOpt, resultKind, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 6311, 6408);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    f_10476_6511_6556(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.AssignmentExpression(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 6511, 6556);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10476_6725_6735(Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                    this_param)
                    {
                        var return_v = this_param.Property;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 6725, 6735);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_6810_6823(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 6810, 6823);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_6783_6827(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                    source)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 6783, 6827);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_6883_6917(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 6883, 6917);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_6993_7027(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    property)
                    {
                        var return_v = this_param.Property(receiverOpt, property);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 6993, 7027);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    f_10476_6955_7028(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.AssignmentExpression(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 6955, 7028);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10476_7196_7215(Microsoft.CodeAnalysis.CSharp.BoundDagDeconstructEvaluation
                    this_param)
                    {
                        var return_v = this_param.DeconstructMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 7196, 7215);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                    f_10476_7267_7302()
                    {
                        var return_v = ArrayBuilder<RefKind>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 7267, 7302);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10476_7350_7393()
                    {
                        var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 7350, 7393);
                        return return_v;
                    }


                    string
                    f_10476_7765_7776(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 7765, 7776);
                        return return_v;
                    }


                    int
                    f_10476_7752_7823(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 7752, 7823);
                        return 0;
                    }


                    bool
                    f_10476_7907_7922(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 7907, 7922);
                        return return_v;
                    }


                    bool
                    f_10476_8001_8025(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtensionMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 8001, 8025);
                        return return_v;
                    }


                    int
                    f_10476_7988_8026(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 7988, 8026);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10476_8086_8107(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 8086, 8107);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    f_10476_8072_8108(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = this_param.Type((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 8072, 8108);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                    f_10476_8150_8174(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterRefKinds;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 8150, 8174);
                        return return_v;
                    }


                    int
                    f_10476_8535_8556(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 8535, 8556);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10476_8655_8672(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 8655, 8672);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10476_8723_8740(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 8723, 8740);
                        return return_v;
                    }


                    int
                    f_10476_8710_8756(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 8710, 8756);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_8835_8849(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 8835, 8849);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_8808_8873(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundDagDeconstructEvaluation
                    source, int
                    index)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 8808, 8873);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_8928_8962(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 8928, 8962);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                    f_10476_9066_9101(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 9066, 9101);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10476_9103_9134(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 9103, 9134);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10476_9034_9135(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                    refKinds, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    args)
                    {
                        var return_v = this_param.Call(receiver, method, refKinds, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 9034, 9135);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10476_9297_9307(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 9297, 9307);
                        return return_v;
                    }


                    int
                    f_10476_9338_9368(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 9338, 9368);
                        return 0;
                    }


                    bool
                    f_10476_9403_9424(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsDynamic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 9403, 9424);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10476_9592_9639(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 9592, 9639);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_9682_9716(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg)
                    {
                        var return_v = this_param.Convert(type, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 9682, 9716);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_9798_9804(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 9798, 9804);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_9852_9887(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                    source)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 9852, 9887);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_9943_9977(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 9943, 9977);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10476_10112_10132(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 10112, 10132);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Conversions
                    f_10476_10112_10144(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Conversions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 10112, 10144);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10476_10182_10193(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 10182, 10193);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Conversion
                    f_10476_10112_10218(Microsoft.CodeAnalysis.CSharp.Conversions
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics)
                    {
                        var return_v = this_param.ClassifyBuiltInConversion(source, destination, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 10112, 10218);
                        return return_v;
                    }


                    bool
                    f_10476_10249_10310(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                    node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                    useSiteDiagnostics)
                    {
                        var return_v = diagnostics.Add(node, useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 10249, 10310);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_10579_10616(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.GetNullableUnderlyingType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 10579, 10616);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10476_10624_10635(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 10624, 10635);
                        return return_v;
                    }


                    bool
                    f_10476_10579_10670(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    compareKind)
                    {
                        var return_v = this_param.Equals(t2, compareKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 10579, 10670);
                        return return_v;
                    }


                    bool
                    f_10476_10711_10854(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    nullableType, Microsoft.CodeAnalysis.SpecialMember
                    member, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    result)
                    {
                        var return_v = this_param.TryGetNullableMethod(syntax, nullableType, member, out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 10711, 10854);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10476_11082_11121(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.Call(receiver, method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 11082, 11121);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_11280_11321(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg, Microsoft.CodeAnalysis.CSharp.Conversion
                    conversion)
                    {
                        var return_v = this_param.Convert(type, arg, conversion);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 11280, 11321);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                    f_10476_11499_11523(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = this_param.As(operand, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 11499, 11523);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    f_10476_11594_11642(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.AssignmentExpression(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 11594, 11642);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10476_12009_12019(Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                    this_param)
                    {
                        var return_v = this_param.Property;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12009, 12019);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10476_12009_12029(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12009, 12029);
                        return return_v;
                    }


                    int
                    f_10476_12009_12044(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12009, 12044);
                        return return_v;
                    }


                    int
                    f_10476_11996_12050(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 11996, 12050);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10476_12094_12104(Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                    this_param)
                    {
                        var return_v = this_param.Property;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12094, 12104);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10476_12094_12114(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12094, 12114);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10476_12094_12125(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12094, 12125);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_12094_12133(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12094, 12133);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10476_12094_12145(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12094, 12145);
                        return return_v;
                    }


                    int
                    f_10476_12081_12174(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 12081, 12174);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10476_12223_12233(Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                    this_param)
                    {
                        var return_v = this_param.Property;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12223, 12233);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10476_12223_12243(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12223, 12243);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_12223_12254(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12223, 12254);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_12302_12337(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                    source)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 12302, 12337);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_12393_12427(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 12393, 12427);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10476_12524_12534(Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                    this_param)
                    {
                        var return_v = this_param.Property;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12524, 12534);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10476_12524_12544(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12524, 12544);
                        return return_v;
                    }


                    int
                    f_10476_12563_12570(Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                    this_param)
                    {
                        var return_v = this_param.Index;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 12563, 12570);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10476_12546_12571(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 12546, 12571);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10476_12503_12572(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    arg0)
                    {
                        var return_v = this_param.Call(receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 12503, 12572);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    f_10476_12465_12573(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundCall
                    right)
                    {
                        var return_v = this_param.AssignmentExpression(left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 12465, 12573);
                        return return_v;
                    }


                    System.Exception
                    f_10476_12665_12711(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 12665, 12711);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 5713, 12746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 5713, 12746);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected BoundExpression LowerTest(BoundDagTest test)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 12946, 14520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 13033, 13063);

                    _factory.Syntax = test.Syntax;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 13081, 13140);

                    BoundExpression
                    input = f_10476_13105_13139(_tempAllocator, f_10476_13128_13138(test))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 13158, 13190);

                    f_10476_13158_13189(f_10476_13171_13181(input) is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 13208, 14505);

                    switch (test)
                    {

                        case BoundDagNonNullTest d:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 13208, 14505);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 13315, 13454);

                            return f_10476_13322_13453(this, d.Syntax, input, (DynAbs.Tracing.TraceSender.Conditional_F1(10476, 13353, 13380) || ((f_10476_13353_13380(f_10476_13353_13363(input)) && DynAbs.Tracing.TraceSender.Conditional_F2(10476, 13383, 13422)) || DynAbs.Tracing.TraceSender.Conditional_F3(10476, 13425, 13452))) ? BinaryOperatorKind.NullableNullNotEqual : BinaryOperatorKind.NotEqual);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 13208, 14505);

                        case BoundDagTypeTest d:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 13208, 14505);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 13661, 13695);

                            return f_10476_13668_13694(_factory, input, f_10476_13687_13693(d));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 13208, 14505);

                        case BoundDagExplicitNullTest d:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 13208, 14505);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 13777, 13910);

                            return f_10476_13784_13909(this, d.Syntax, input, (DynAbs.Tracing.TraceSender.Conditional_F1(10476, 13815, 13842) || ((f_10476_13815_13842(f_10476_13815_13825(input)) && DynAbs.Tracing.TraceSender.Conditional_F2(10476, 13845, 13881)) || DynAbs.Tracing.TraceSender.Conditional_F3(10476, 13884, 13908))) ? BinaryOperatorKind.NullableNullEqual : BinaryOperatorKind.Equal);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 13208, 14505);

                        case BoundDagValueTest d:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 13208, 14505);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 13985, 14028);

                            f_10476_13985_14027(!f_10476_13999_14026(f_10476_13999_14009(input)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 14054, 14101);

                            return f_10476_14061_14100(this, d.Syntax, input, f_10476_14092_14099(d));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 13208, 14505);

                        case BoundDagRelationalTest d:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 13208, 14505);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 14181, 14224);

                            f_10476_14181_14223(!f_10476_14195_14222(f_10476_14195_14205(input)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 14250, 14287);

                            f_10476_14250_14286(f_10476_14263_14285(f_10476_14263_14273(input)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 14313, 14381);

                            return f_10476_14320_14380(this, d.Syntax, input, f_10476_14356_14370(d), f_10476_14372_14379(d));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 13208, 14505);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 13208, 14505);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 14439, 14486);

                            throw f_10476_14445_14485(test);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 13208, 14505);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 12946, 14520);

                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_13128_13138(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 13128, 13138);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_13105_13139(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 13105, 13139);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10476_13171_13181(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 13171, 13181);
                        return return_v;
                    }


                    int
                    f_10476_13158_13189(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 13158, 13189);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_13353_13363(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 13353, 13363);
                        return return_v;
                    }


                    bool
                    f_10476_13353_13380(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsNullableType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 13353, 13380);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_13322_13453(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    rewrittenExpr, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    operatorKind)
                    {
                        var return_v = this_param.MakeNullCheck(syntax, rewrittenExpr, operatorKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 13322, 13453);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_13687_13693(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 13687, 13693);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                    f_10476_13668_13694(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = this_param.Is(operand, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 13668, 13694);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_13815_13825(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 13815, 13825);
                        return return_v;
                    }


                    bool
                    f_10476_13815_13842(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsNullableType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 13815, 13842);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_13784_13909(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    rewrittenExpr, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    operatorKind)
                    {
                        var return_v = this_param.MakeNullCheck(syntax, rewrittenExpr, operatorKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 13784, 13909);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_13999_14009(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 13999, 14009);
                        return return_v;
                    }


                    bool
                    f_10476_13999_14026(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsNullableType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 13999, 14026);
                        return return_v;
                    }


                    int
                    f_10476_13985_14027(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 13985, 14027);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10476_14092_14099(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 14092, 14099);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_14061_14100(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input, Microsoft.CodeAnalysis.ConstantValue
                    value)
                    {
                        var return_v = this_param.MakeValueTest(syntax, input, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 14061, 14100);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_14195_14205(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 14195, 14205);
                        return return_v;
                    }


                    bool
                    f_10476_14195_14222(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsNullableType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 14195, 14222);
                        return return_v;
                    }


                    int
                    f_10476_14181_14223(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 14181, 14223);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_14263_14273(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 14263, 14273);
                        return return_v;
                    }


                    bool
                    f_10476_14263_14285(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsValueType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 14263, 14285);
                        return return_v;
                    }


                    int
                    f_10476_14250_14286(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 14250, 14286);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    f_10476_14356_14370(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                    this_param)
                    {
                        var return_v = this_param.OperatorKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 14356, 14370);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10476_14372_14379(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 14372, 14379);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_14320_14380(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    operatorKind, Microsoft.CodeAnalysis.ConstantValue
                    value)
                    {
                        var return_v = this_param.MakeRelationalTest(syntax, input, operatorKind, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 14320, 14380);
                        return return_v;
                    }


                    System.Exception
                    f_10476_14445_14485(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 14445, 14485);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 12946, 14520);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 12946, 14520);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private BoundExpression MakeNullCheck(SyntaxNode syntax, BoundExpression rewrittenExpr, BinaryOperatorKind operatorKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 14536, 15545);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 14689, 15437) || true) && (f_10476_14693_14740(f_10476_14693_14711(rewrittenExpr)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 14689, 15437);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 14782, 14854);

                        TypeSymbol
                        objectType = f_10476_14806_14853(_factory, SpecialType.System_Object)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 14876, 14991);

                        var
                        operandType = f_10476_14894_14990(TypeWithAnnotations.Create(f_10476_14943_14988(_factory, SpecialType.System_Void)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 15013, 15418);

                        return f_10476_15020_15417(_localRewriter, syntax, operatorKind, f_10476_15152_15196(_factory, operandType, rewrittenExpr), f_10476_15223_15310(_factory, operandType, f_10476_15253_15309(syntax, f_10476_15278_15296(), objectType)), f_10476_15337_15385(_factory, SpecialType.System_Boolean), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 14689, 15437);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 15457, 15530);

                    return f_10476_15464_15529(_localRewriter, syntax, rewrittenExpr, operatorKind);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 14536, 15545);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10476_14693_14711(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 14693, 14711);
                        return return_v;
                    }


                    bool
                    f_10476_14693_14740(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    type)
                    {
                        var return_v = type.IsPointerOrFunctionPointer();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 14693, 14740);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10476_14806_14853(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 14806, 14853);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10476_14943_14988(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 14943, 14988);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    f_10476_14894_14990(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    pointedAtType)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 14894, 14990);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_15152_15196(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg)
                    {
                        var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 15152, 15196);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10476_15278_15296()
                    {
                        var return_v = ConstantValue.Null;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 15278, 15296);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10476_15253_15309(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.ConstantValue
                    constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral(syntax, constantValueOpt, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 15253, 15309);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_15223_15310(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    arg)
                    {
                        var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 15223, 15310);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10476_15337_15385(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 15337, 15385);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_15020_15417(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    loweredLeft, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    method)
                    {
                        var return_v = this_param.MakeBinaryOperator(syntax, operatorKind, loweredLeft, loweredRight, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 15020, 15417);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_15464_15529(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    rewrittenExpr, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    operatorKind)
                    {
                        var return_v = this_param.MakeNullCheck(syntax, rewrittenExpr, operatorKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 15464, 15529);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 14536, 15545);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 14536, 15545);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected BoundExpression MakeValueTest(SyntaxNode syntax, BoundExpression input, ConstantValue value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 15561, 16090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 15696, 15762);

                    TypeSymbol
                    comparisonType = f_10476_15724_15761(f_10476_15724_15734(input))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 15780, 15845);

                    var
                    operatorType = f_10476_15799_15844(comparisonType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 15863, 15918);

                    f_10476_15863_15917(operatorType != BinaryOperatorKind.Error);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 15936, 15995);

                    var
                    operatorKind = BinaryOperatorKind.Equal | operatorType
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 16013, 16075);

                    return f_10476_16020_16074(this, syntax, input, operatorKind, value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 15561, 16090);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10476_15724_15734(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 15724, 15734);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_15724_15761(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    type)
                    {
                        var return_v = type.EnumUnderlyingTypeOrSelf();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 15724, 15761);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    f_10476_15799_15844(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = Binder.RelationalOperatorType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 15799, 15844);
                        return return_v;
                    }


                    int
                    f_10476_15863_15917(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 15863, 15917);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_16020_16074(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    operatorKind, Microsoft.CodeAnalysis.ConstantValue
                    value)
                    {
                        var return_v = this_param.MakeRelationalTest(syntax, input, operatorKind, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 16020, 16074);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 15561, 16090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 15561, 16090);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected BoundExpression MakeRelationalTest(SyntaxNode syntax, BoundExpression input, BinaryOperatorKind operatorKind, ConstantValue value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 16106, 17935);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 16279, 16672) || true) && (f_10476_16283_16305(f_10476_16283_16293(input)) == SpecialType.System_Double && (DynAbs.Tracing.TraceSender.Expression_True(10476, 16283, 16369) && f_10476_16338_16369(f_10476_16351_16368(value))) || (DynAbs.Tracing.TraceSender.Expression_False(10476, 16283, 16479) || f_10476_16394_16416(f_10476_16394_16404(input)) == SpecialType.System_Single && (DynAbs.Tracing.TraceSender.Expression_True(10476, 16394, 16479) && f_10476_16449_16479(f_10476_16461_16478(value)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 16279, 16672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 16521, 16587);

                        f_10476_16521_16586(f_10476_16534_16557(operatorKind) == BinaryOperatorKind.Equal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 16609, 16653);

                        return f_10476_16616_16652(_factory, input);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 16279, 16672);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 16692, 16772);

                    BoundExpression
                    literal = f_10476_16718_16771(_localRewriter, syntax, value, f_10476_16760_16770(input))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 16790, 16856);

                    TypeSymbol
                    comparisonType = f_10476_16818_16855(f_10476_16818_16828(input))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 16874, 17743) || true) && (f_10476_16878_16905(operatorKind) == BinaryOperatorKind.Int && (DynAbs.Tracing.TraceSender.Expression_True(10476, 16878, 16989) && f_10476_16935_16961(comparisonType) != SpecialType.System_Int32))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 16874, 17743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 17128, 17494);

                        f_10476_17128_17493(f_10476_17141_17167(comparisonType) switch
                        {
                            SpecialType.System_Byte when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 17223, 17254) && DynAbs.Tracing.TraceSender.Expression_True(10476, 17223, 17254))
    => true,
                            SpecialType.System_SByte when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 17281, 17313) && DynAbs.Tracing.TraceSender.Expression_True(10476, 17281, 17313))
    => true,
                            SpecialType.System_Int16 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 17340, 17372) && DynAbs.Tracing.TraceSender.Expression_True(10476, 17340, 17372))
    => true,
                            SpecialType.System_UInt16 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 17399, 17432) && DynAbs.Tracing.TraceSender.Expression_True(10476, 17399, 17432))
    => true,
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 17459, 17469) && DynAbs.Tracing.TraceSender.Expression_True(10476, 17459, 17469))
    => false
                        });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 17516, 17580);

                        comparisonType = f_10476_17533_17579(_factory, SpecialType.System_Int32);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 17602, 17650);

                        input = f_10476_17610_17649(_factory, comparisonType, input);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 17672, 17724);

                        literal = f_10476_17682_17723(_factory, comparisonType, literal);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 16874, 17743);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 17763, 17920);

                    return f_10476_17770_17919(this._localRewriter, f_10476_17809_17824(_factory), operatorKind, input, literal, f_10476_17856_17904(_factory, SpecialType.System_Boolean), method: null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 16106, 17935);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10476_16283_16293(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 16283, 16293);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10476_16283_16305(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 16283, 16305);
                        return return_v;
                    }


                    double
                    f_10476_16351_16368(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.DoubleValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 16351, 16368);
                        return return_v;
                    }


                    bool
                    f_10476_16338_16369(double
                    d)
                    {
                        var return_v = double.IsNaN(d);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 16338, 16369);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_16394_16404(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 16394, 16404);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10476_16394_16416(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 16394, 16416);
                        return return_v;
                    }


                    float
                    f_10476_16461_16478(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.SingleValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 16461, 16478);
                        return return_v;
                    }


                    bool
                    f_10476_16449_16479(float
                    f)
                    {
                        var return_v = float.IsNaN(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 16449, 16479);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    f_10476_16534_16557(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    kind)
                    {
                        var return_v = kind.Operator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 16534, 16557);
                        return return_v;
                    }


                    int
                    f_10476_16521_16586(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 16521, 16586);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_16616_16652(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    input)
                    {
                        var return_v = this_param.MakeIsNotANumberTest(input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 16616, 16652);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_16760_16770(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 16760, 16770);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_16718_16771(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.ConstantValue
                    constantValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = this_param.MakeLiteral(syntax, constantValue, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 16718, 16771);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_16818_16828(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 16818, 16828);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_16818_16855(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.EnumUnderlyingTypeOrSelf();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 16818, 16855);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    f_10476_16878_16905(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    kind)
                    {
                        var return_v = kind.OperandTypes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 16878, 16905);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10476_16935_16961(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 16935, 16961);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10476_17141_17167(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 17141, 17167);
                        return return_v;
                    }


                    int
                    f_10476_17128_17493(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 17128, 17493);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10476_17533_17579(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 17533, 17579);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_17610_17649(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg)
                    {
                        var return_v = this_param.Convert(type, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 17610, 17649);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_17682_17723(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg)
                    {
                        var return_v = this_param.Convert(type, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 17682, 17723);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10476_17809_17824(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Syntax;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 17809, 17824);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10476_17856_17904(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 17856, 17904);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_17770_17919(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    loweredLeft, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    method)
                    {
                        var return_v = this_param.MakeBinaryOperator(syntax, operatorKind, loweredLeft, loweredRight, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, method: method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 17770, 17919);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 16106, 17935);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 16106, 17935);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected bool TryLowerTypeTestAndCast(
                            BoundDagTest test,
                            BoundDagEvaluation evaluation,
                            [NotNullWhen(true)] out BoundExpression sideEffect,
                            [NotNullWhen(true)] out BoundExpression testExpression)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 18746, 21379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 19044, 19094);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 19182, 20095) || true) && (test is BoundDagTypeTest typeDecision && (DynAbs.Tracing.TraceSender.Expression_True(10476, 19186, 19300) && evaluation is BoundDagTypeEvaluation typeEvaluation1) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 19186, 19358) && f_10476_19325_19358(f_10476_19325_19342(typeDecision))) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 19186, 19463) && f_10476_19383_19463(f_10476_19383_19403(typeEvaluation1), f_10476_19411_19428(typeDecision), TypeCompareKind.AllIgnoreOptions)) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 19186, 19531) && f_10476_19488_19509(typeEvaluation1) == f_10476_19513_19531(typeDecision)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 19182, 20095);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 19573, 19632);

                        BoundExpression
                        input = f_10476_19597_19631(_tempAllocator, f_10476_19620_19630(test))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 19654, 19773);

                        BoundExpression
                        output = f_10476_19679_19772(_tempAllocator, f_10476_19702_19771(evaluation.Syntax, f_10476_19738_19758(typeEvaluation1), evaluation))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 19795, 19828);

                        f_10476_19795_19827(f_10476_19808_19819(output) is { });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 19850, 19943);

                        sideEffect = f_10476_19863_19942(_factory, output, f_10476_19901_19941(_factory, input, f_10476_19920_19940(typeEvaluation1)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 19965, 20042);

                        testExpression = f_10476_19982_20041(_factory, output, f_10476_20014_20040(_factory, f_10476_20028_20039(output)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 20064, 20076);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 19182, 20095);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 20186, 21278) || true) && (test is BoundDagNonNullTest nonNullTest && (DynAbs.Tracing.TraceSender.Expression_True(10476, 20190, 20306) && evaluation is BoundDagTypeEvaluation typeEvaluation2) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 20190, 20471) && f_10476_20331_20452(f_10476_20331_20363(f_10476_20331_20351(_factory)), f_10476_20390_20405(f_10476_20390_20400(test)), f_10476_20407_20427(typeEvaluation2), ref useSiteDiagnostics) is Conversion conv) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 20190, 20579) && (conv.IsIdentity || (DynAbs.Tracing.TraceSender.Expression_False(10476, 20497, 20561) || conv.Kind == ConversionKind.ImplicitReference) || (DynAbs.Tracing.TraceSender.Expression_False(10476, 20497, 20578) || conv.IsBoxing))) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 20190, 20646) && f_10476_20604_20625(typeEvaluation2) == f_10476_20629_20646(nonNullTest)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 20186, 21278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 20688, 20747);

                        BoundExpression
                        input = f_10476_20712_20746(_tempAllocator, f_10476_20735_20745(test))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 20769, 20805);

                        var
                        baseType = f_10476_20784_20804(typeEvaluation2)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 20827, 20934);

                        BoundExpression
                        output = f_10476_20852_20933(_tempAllocator, f_10476_20875_20932(evaluation.Syntax, baseType, evaluation))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 20956, 21042);

                        sideEffect = f_10476_20969_21041(_factory, output, f_10476_21007_21040(_factory, baseType, input));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 21064, 21138);

                        testExpression = f_10476_21081_21137(_factory, output, f_10476_21113_21136(_factory, baseType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 21160, 21225);

                        f_10476_21160_21224(_localRewriter._diagnostics, test.Syntax, useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 21247, 21259);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 20186, 21278);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 21298, 21333);

                    sideEffect = testExpression = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 21351, 21364);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 18746, 21379);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_19325_19342(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 19325, 19342);
                        return return_v;
                    }


                    bool
                    f_10476_19325_19358(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsReferenceType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 19325, 19358);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_19383_19403(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 19383, 19403);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_19411_19428(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 19411, 19428);
                        return return_v;
                    }


                    bool
                    f_10476_19383_19463(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    compareKind)
                    {
                        var return_v = this_param.Equals(t2, compareKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 19383, 19463);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_19488_19509(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 19488, 19509);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_19513_19531(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 19513, 19531);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_19620_19630(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 19620, 19630);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_19597_19631(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 19597, 19631);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_19738_19758(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 19738, 19758);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_19702_19771(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                    source)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, source);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 19702, 19771);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_19679_19772(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 19679, 19772);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10476_19808_19819(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 19808, 19819);
                        return return_v;
                    }


                    int
                    f_10476_19795_19827(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 19795, 19827);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_19920_19940(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 19920, 19940);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                    f_10476_19901_19941(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = this_param.As(operand, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 19901, 19941);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    f_10476_19863_19942(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                    right)
                    {
                        var return_v = this_param.AssignmentExpression(left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 19863, 19942);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_20028_20039(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 20028, 20039);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_20014_20040(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = this_param.Null(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 20014, 20040);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    f_10476_19982_20041(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.ObjectNotEqual(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 19982, 20041);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10476_20331_20351(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 20331, 20351);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Conversions
                    f_10476_20331_20363(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Conversions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 20331, 20363);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_20390_20400(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 20390, 20400);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_20390_20405(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 20390, 20405);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_20407_20427(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 20407, 20427);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Conversion
                    f_10476_20331_20452(Microsoft.CodeAnalysis.CSharp.Conversions
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics)
                    {
                        var return_v = this_param.ClassifyBuiltInConversion(source, destination, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 20331, 20452);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_20604_20625(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 20604, 20625);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_20629_20646(Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 20629, 20646);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_20735_20745(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    this_param)
                    {
                        var return_v = this_param.Input;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 20735, 20745);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_20712_20746(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 20712, 20746);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_20784_20804(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 20784, 20804);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_20875_20932(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                    source)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, source);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 20875, 20932);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_20852_20933(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 20852, 20933);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_21007_21040(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg)
                    {
                        var return_v = this_param.Convert(type, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 21007, 21040);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    f_10476_20969_21041(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.AssignmentExpression(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 20969, 21041);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_21113_21136(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = this_param.Null(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 21113, 21136);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    f_10476_21081_21137(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.ObjectNotEqual(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 21081, 21137);
                        return return_v;
                    }


                    bool
                    f_10476_21160_21224(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                    node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                    useSiteDiagnostics)
                    {
                        var return_v = diagnostics.Add(node, useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 21160, 21224);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 18746, 21379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 18746, 21379);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected BoundDecisionDag ShareTempsAndEvaluateInput(
                            BoundExpression loweredInput,
                            BoundDecisionDag decisionDag,
                            Action<BoundExpression> addCode,
                            out BoundExpression savedInputExpression)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 21656, 27184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 21946, 21985);

                    f_10476_21946_21984(f_10476_21959_21976(loweredInput) is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 22120, 22311);

                    bool
                    anyWhenClause =
                                        decisionDag.TopologicallySortedNodes
                                        .Any(node => node is BoundWhenDecisionDagNode { WhenExpression: { ConstantValue: null } })
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 22331, 22394);

                    var
                    inputDagTemp = f_10476_22350_22393(loweredInput)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 22412, 23525) || true) && ((f_10476_22417_22434(loweredInput) == BoundKind.Local || (DynAbs.Tracing.TraceSender.Expression_False(10476, 22417, 22497) || f_10476_22457_22474(loweredInput) == BoundKind.Parameter))
                    && (DynAbs.Tracing.TraceSender.Expression_True(10476, 22416, 22564) && f_10476_22523_22548(loweredInput) == RefKind.None) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 22416, 22603) && !anyWhenClause))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 22412, 23525);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 23383, 23457);

                        bool
                        tempAssigned = f_10476_23403_23456(_tempAllocator, inputDagTemp, loweredInput)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 23479, 23506);

                        f_10476_23479_23505(tempAssigned);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 22412, 23525);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 23545, 24574);
                        foreach (BoundDecisionDagNode node in f_10476_23583_23619_I(f_10476_23583_23619(decisionDag)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 23545, 24574);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 23661, 24555) || true) && (node is BoundWhenDecisionDagNode w)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 23661, 24555);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 24057, 24532);
                                    foreach (BoundPatternBinding binding in f_10476_24097_24107_I(f_10476_24097_24107(w)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 24057, 24532);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 24165, 24505) || true) && (binding.VariableAccess is BoundLocal l)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 24165, 24505);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 24273, 24357);

                                            f_10476_24273_24356(f_10476_24286_24315(f_10476_24286_24299(l)) == LocalDeclarationKind.PatternVariable);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 24391, 24474);

                                            _ = f_10476_24395_24473(_tempAllocator, binding.TempContainingValue, binding.VariableAccess);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 24165, 24505);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 24057, 24532);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10476, 1, 476);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10476, 1, 476);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 23661, 24555);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 23545, 24574);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10476, 1, 1030);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10476, 1, 1030);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 24594, 26057) || true) && (f_10476_24598_24627(f_10476_24598_24615(loweredInput)) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 24598, 24774) && !f_10476_24653_24774(f_10476_24653_24689(f_10476_24653_24670(loweredInput)), f_10476_24697_24773(f_10476_24697_24717(_factory), WellKnownType.System_ValueTuple_TRest))) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 24598, 24855) && f_10476_24799_24825(loweredInput.Syntax) == SyntaxKind.TupleExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 24598, 24930) && loweredInput is BoundObjectCreationExpression expr) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 24598, 25023) && !decisionDag.TopologicallySortedNodes.Any(n => usesOriginalInput(n))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 24594, 26057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 25441, 25543);

                        decisionDag = f_10476_25455_25542(this, decisionDag, expr, addCode, !anyWhenClause, out savedInputExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 24594, 26057);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 24594, 26057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 25730, 25795);

                        BoundExpression
                        inputTemp = f_10476_25758_25794(_tempAllocator, inputDagTemp)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 25817, 25850);

                        savedInputExpression = inputTemp;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 25872, 26038) || true) && (inputTemp != loweredInput)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 25872, 26038);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 25951, 26015);

                            f_10476_25951_26014(addCode, f_10476_25959_26013(_factory, inputTemp, loweredInput));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 25872, 26038);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 24594, 26057);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 26077, 26120);

                    f_10476_26077_26119(savedInputExpression != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 26138, 26157);

                    return decisionDag;

                    static bool usesOriginalInput(BoundDecisionDagNode node)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10476, 26177, 27169);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 26274, 27150);

                            switch (node)
                            {

                                case BoundWhenDecisionDagNode n:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 26274, 27150);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 26398, 26464);

                                    return n.Bindings.Any(b => b.TempContainingValue.IsOriginalInput);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 26274, 27150);

                                case BoundTestDecisionDagNode t:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 26274, 27150);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 26552, 26588);

                                    return f_10476_26559_26587(f_10476_26559_26571(f_10476_26559_26565(t)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 26274, 27150);

                                case BoundEvaluationDecisionDagNode e:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 26274, 27150);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 26682, 27050);

                                    switch (f_10476_26690_26702(e))
                                    {

                                        case BoundDagFieldEvaluation f:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 26682, 27050);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 26837, 26897);

                                            return f_10476_26844_26867(f_10476_26844_26851(f)) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 26844, 26896) && !f_10476_26872_26896(f_10476_26872_26879(f)));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 26682, 27050);

                                        default:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 26682, 27050);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 26977, 27019);

                                            return f_10476_26984_27018(f_10476_26984_27002(f_10476_26984_26996(e)));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 26682, 27050);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 26274, 27150);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 26274, 27150);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 27114, 27127);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 26274, 27150);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10476, 26177, 27169);

                            Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            f_10476_26559_26565(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                            this_param)
                            {
                                var return_v = this_param.Test;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 26559, 26565);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10476_26559_26571(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 26559, 26571);
                                return return_v;
                            }


                            bool
                            f_10476_26559_26587(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            this_param)
                            {
                                var return_v = this_param.IsOriginalInput;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 26559, 26587);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                            f_10476_26690_26702(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                            this_param)
                            {
                                var return_v = this_param.Evaluation;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 26690, 26702);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10476_26844_26851(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 26844, 26851);
                                return return_v;
                            }


                            bool
                            f_10476_26844_26867(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            this_param)
                            {
                                var return_v = this_param.IsOriginalInput;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 26844, 26867);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            f_10476_26872_26879(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                            this_param)
                            {
                                var return_v = this_param.Field;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 26872, 26879);
                                return return_v;
                            }


                            bool
                            f_10476_26872_26896(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            this_param)
                            {
                                var return_v = this_param.IsTupleElement();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 26872, 26896);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                            f_10476_26984_26996(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                            this_param)
                            {
                                var return_v = this_param.Evaluation;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 26984, 26996);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10476_26984_27002(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 26984, 27002);
                                return return_v;
                            }


                            bool
                            f_10476_26984_27018(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            this_param)
                            {
                                var return_v = this_param.IsOriginalInput;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 26984, 27018);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 26177, 27169);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 26177, 27169);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 21656, 27184);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10476_21959_21976(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 21959, 21976);
                        return return_v;
                    }


                    int
                    f_10476_21946_21984(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 21946, 21984);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_22350_22393(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expr)
                    {
                        var return_v = BoundDagTemp.ForOriginalInput(expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 22350, 22393);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10476_22417_22434(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 22417, 22434);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10476_22457_22474(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 22457, 22474);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10476_22523_22548(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = node.GetRefKind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 22523, 22548);
                        return return_v;
                    }


                    bool
                    f_10476_23403_23456(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    translation)
                    {
                        var return_v = this_param.TrySetTemp(dagTemp, translation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 23403, 23456);
                        return return_v;
                    }


                    int
                    f_10476_23479_23505(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 23479, 23505);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    f_10476_23583_23619(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    this_param)
                    {
                        var return_v = this_param.TopologicallySortedNodes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 23583, 23619);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                    f_10476_24097_24107(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                    this_param)
                    {
                        var return_v = this_param.Bindings;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 24097, 24107);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10476_24286_24299(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 24286, 24299);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                    f_10476_24286_24315(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclarationKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 24286, 24315);
                        return return_v;
                    }


                    int
                    f_10476_24273_24356(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 24273, 24356);
                        return 0;
                    }


                    bool
                    f_10476_24395_24473(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    translation)
                    {
                        var return_v = this_param.TrySetTemp(dagTemp, translation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 24395, 24473);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                    f_10476_24097_24107_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 24097, 24107);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    f_10476_23583_23619_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 23583, 23619);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_24598_24615(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 24598, 24615);
                        return return_v;
                    }


                    bool
                    f_10476_24598_24627(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsTupleType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 24598, 24627);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_24653_24670(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 24653, 24670);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_24653_24689(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 24653, 24689);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10476_24697_24717(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 24697, 24717);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10476_24697_24773(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    type)
                    {
                        var return_v = this_param.GetWellKnownType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 24697, 24773);
                        return return_v;
                    }


                    bool
                    f_10476_24653_24774(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 24653, 24774);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10476_24799_24825(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = node.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 24799, 24825);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    f_10476_25455_25542(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    decisionDag, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    loweredInput, System.Action<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    addCode, bool
                    canShareInputs, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                    savedInputExpression)
                    {
                        var return_v = this_param.RewriteTupleInput(decisionDag, loweredInput, addCode, canShareInputs, out savedInputExpression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 25455, 25542);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_25758_25794(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 25758, 25794);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    f_10476_25959_26013(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.AssignmentExpression(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 25959, 26013);
                        return return_v;
                    }


                    int
                    f_10476_25951_26014(System.Action<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    obj)
                    {
                        this_param.Invoke((Microsoft.CodeAnalysis.CSharp.BoundExpression)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 25951, 26014);
                        return 0;
                    }


                    int
                    f_10476_26077_26119(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 26077, 26119);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 21656, 27184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 21656, 27184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private BoundDecisionDag RewriteTupleInput(
                            BoundDecisionDag decisionDag,
                            BoundObjectCreationExpression loweredInput,
                            Action<BoundExpression> addCode,
                            bool canShareInputs,
                            out BoundExpression savedInputExpression)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 27981, 32115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 28312, 28354);

                    int
                    count = loweredInput.Arguments.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 28442, 28532);

                    var
                    originalInput = f_10476_28462_28531(loweredInput.Syntax, f_10476_28513_28530(loweredInput))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 28550, 28642);

                    var
                    newArguments = f_10476_28569_28641(loweredInput.Arguments.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 28669, 28674);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 28660, 29254) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 28687, 28690)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 28660, 29254))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 28660, 29254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 28732, 28803);

                            var
                            field = f_10476_28744_28802(f_10476_28744_28775(f_10476_28744_28761(loweredInput))[i])
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 28825, 28853);

                            f_10476_28825_28852(field != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 28875, 28912);

                            var
                            expr = f_10476_28886_28908(loweredInput)[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 28934, 29024);

                            var
                            fieldFetchEvaluation = f_10476_28961_29023(expr.Syntax, field, originalInput)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 29046, 29120);

                            var
                            temp = f_10476_29057_29119(expr.Syntax, f_10476_29087_29096(expr), fieldFetchEvaluation)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 29142, 29166);

                            f_10476_29142_29165(temp, expr);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 29188, 29235);

                            f_10476_29188_29234(newArguments, f_10476_29205_29233(_tempAllocator, temp));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10476, 1, 595);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10476, 1, 595);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 29274, 29330);

                    var
                    rewrittenDag = f_10476_29293_29329(decisionDag, makeReplacement)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 29348, 29765);

                    savedInputExpression = f_10476_29371_29764(loweredInput, f_10476_29413_29437(loweredInput), arguments: f_10476_29450_29483(newArguments), f_10476_29485_29514(loweredInput), f_10476_29516_29548(loweredInput), f_10476_29571_29592(loweredInput), f_10476_29594_29622(loweredInput), f_10476_29624_29653(loweredInput), f_10476_29655_29684(loweredInput), f_10476_29707_29744(loweredInput), f_10476_29746_29763(loweredInput));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 29785, 29805);

                    return rewrittenDag;

                    void storeToTemp(BoundDagTemp temp, BoundExpression expr)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 29825, 30463);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 29923, 30444) || true) && (canShareInputs && (DynAbs.Tracing.TraceSender.Expression_True(10476, 29927, 30011) && (f_10476_29946_29955(expr) == BoundKind.Parameter || (DynAbs.Tracing.TraceSender.Expression_False(10476, 29946, 30010) || f_10476_29982_29991(expr) == BoundKind.Local))) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 29927, 30052) && f_10476_30015_30052(_tempAllocator, temp, expr)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 29923, 30444);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 29923, 30444);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 29923, 30444);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 30282, 30333);

                                var
                                tempToHoldInput = f_10476_30304_30332(_tempAllocator, temp)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 30359, 30421);

                                f_10476_30359_30420(addCode, f_10476_30367_30419(_factory, tempToHoldInput, expr));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 29923, 30444);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 29825, 30463);

                            Microsoft.CodeAnalysis.CSharp.BoundKind
                            f_10476_29946_29955(Microsoft.CodeAnalysis.CSharp.BoundExpression
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29946, 29955);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundKind
                            f_10476_29982_29991(Microsoft.CodeAnalysis.CSharp.BoundExpression
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29982, 29991);
                                return return_v;
                            }


                            bool
                            f_10476_30015_30052(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                            this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            dagTemp, Microsoft.CodeAnalysis.CSharp.BoundExpression
                            translation)
                            {
                                var return_v = this_param.TrySetTemp(dagTemp, translation);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 30015, 30052);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundExpression
                            f_10476_30304_30332(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                            this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            dagTemp)
                            {
                                var return_v = this_param.GetTemp(dagTemp);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 30304, 30332);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                            f_10476_30367_30419(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                            this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                            left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                            right)
                            {
                                var return_v = this_param.AssignmentExpression(left, right);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 30367, 30419);
                                return return_v;
                            }


                            int
                            f_10476_30359_30420(System.Action<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                            this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                            obj)
                            {
                                this_param.Invoke((Microsoft.CodeAnalysis.CSharp.BoundExpression)obj);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 30359, 30420);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 29825, 30463);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 29825, 30463);
                        }
                    }

                    BoundDecisionDagNode makeReplacement(BoundDecisionDagNode node, Func<BoundDecisionDagNode, BoundDecisionDagNode> replacement)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10476, 30483, 32100);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 30649, 31995);

                            switch (node)
                            {

                                case BoundEvaluationDecisionDagNode evalNode:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 30649, 31995);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 30786, 31367) || true) && (f_10476_30790_30809(evalNode) is BoundDagFieldEvaluation eval && (DynAbs.Tracing.TraceSender.Expression_True(10476, 30790, 30904) && f_10476_30878_30904(f_10476_30878_30888(eval))) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 30790, 30964) && f_10476_30941_30951(eval) is var field) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 30790, 31038) && f_10476_31001_31030(field) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10476, 30790, 31107) && f_10476_31075_31098(field) is int i))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 30786, 31367);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 31302, 31336);

                                        return f_10476_31309_31335(replacement, f_10476_31321_31334(evalNode));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 30786, 31367);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 31695, 31752);

                                    f_10476_31695_31751(f_10476_31708_31750_M(!f_10476_31709_31734(f_10476_31709_31728(evalNode)).IsOriginalInput));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10476, 31782, 31788);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 30649, 31995);

                                case BoundTestDecisionDagNode testNode:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10476, 30649, 31995);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 31885, 31936);

                                    f_10476_31885_31935(f_10476_31898_31934_M(!f_10476_31899_31918(f_10476_31899_31912(testNode)).IsOriginalInput));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10476, 31966, 31972);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10476, 30649, 31995);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10476, 32019, 32081);

                            return f_10476_32026_32080(node, replacement);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 30483, 32100);

                            Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                            f_10476_30790_30809(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                            this_param)
                            {
                                var return_v = this_param.Evaluation;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 30790, 30809);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10476_30878_30888(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 30878, 30888);
                                return return_v;
                            }


                            bool
                            f_10476_30878_30904(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            this_param)
                            {
                                var return_v = this_param.IsOriginalInput;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 30878, 30904);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            f_10476_30941_30951(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                            this_param)
                            {
                                var return_v = this_param.Field;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 30941, 30951);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            f_10476_31001_31030(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            this_param)
                            {
                                var return_v = this_param.CorrespondingTupleField;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 31001, 31030);
                                return return_v;
                            }


                            int
                            f_10476_31075_31098(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            this_param)
                            {
                                var return_v = this_param.TupleElementIndex;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 31075, 31098);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            f_10476_31321_31334(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                            this_param)
                            {
                                var return_v = this_param.Next;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 31321, 31334);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            f_10476_31309_31335(System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                            this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            arg)
                            {
                                var return_v = this_param.Invoke(arg);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 31309, 31335);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                            f_10476_31709_31728(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                            this_param)
                            {
                                var return_v = this_param.Evaluation;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 31709, 31728);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10476_31709_31734(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 31709, 31734);
                                return return_v;
                            }


                            bool
                            f_10476_31708_31750_M(bool
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 31708, 31750);
                                return return_v;
                            }


                            int
                            f_10476_31695_31751(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 31695, 31751);
                                return 0;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            f_10476_31899_31912(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                            this_param)
                            {
                                var return_v = this_param.Test;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 31899, 31912);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10476_31899_31918(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 31899, 31918);
                                return return_v;
                            }


                            bool
                            f_10476_31898_31934_M(bool
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 31898, 31934);
                                return return_v;
                            }


                            int
                            f_10476_31885_31935(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 31885, 31935);
                                return 0;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            f_10476_32026_32080(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            dag, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                            replacement)
                            {
                                var return_v = BoundDecisionDag.TrivialReplacement(dag, replacement);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 32026, 32080);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 30483, 32100);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 30483, 32100);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10476, 27981, 32115);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_28513_28530(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 28513, 28530);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_28462_28531(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = BoundDagTemp.ForOriginalInput(syntax, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 28462, 28531);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10476_28569_28641(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 28569, 28641);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_28744_28761(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 28744, 28761);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    f_10476_28744_28775(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TupleElements;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 28744, 28775);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10476_28744_28802(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.CorrespondingTupleField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 28744, 28802);
                        return return_v;
                    }


                    int
                    f_10476_28825_28852(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 28825, 28852);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10476_28886_28908(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 28886, 28908);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                    f_10476_28961_29023(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    field, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    input)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation(syntax, field, input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 28961, 29023);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10476_29087_29096(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29087, 29096);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    f_10476_29057_29119(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    type, Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                    source)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 29057, 29119);
                        return return_v;
                    }


                    int
                    f_10476_29142_29165(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    temp, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expr)
                    {
                        storeToTemp(temp, expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 29142, 29165);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10476_29205_29233(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                    dagTemp)
                    {
                        var return_v = this_param.GetTemp(dagTemp);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 29205, 29233);
                        return return_v;
                    }


                    int
                    f_10476_29188_29234(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 29188, 29234);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    f_10476_29293_29329(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    this_param, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                    makeReplacement)
                    {
                        var return_v = this_param.Rewrite(makeReplacement);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 29293, 29329);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10476_29413_29437(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.Constructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29413, 29437);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10476_29450_29483(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 29450, 29483);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<string>
                    f_10476_29485_29514(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.ArgumentNamesOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29485, 29514);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                    f_10476_29516_29548(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.ArgumentRefKindsOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29516, 29548);
                        return return_v;
                    }


                    bool
                    f_10476_29571_29592(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.Expanded;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29571, 29592);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<int>
                    f_10476_29594_29622(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.ArgsToParamsOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29594, 29622);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.BitVector
                    f_10476_29624_29653(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.DefaultArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29624, 29653);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10476_29655_29684(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29655, 29684);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                    f_10476_29707_29744(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.InitializerExpressionOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29707, 29744);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10476_29746_29763(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10476, 29746, 29763);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    f_10476_29371_29764(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
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
                        var return_v = this_param.Update(constructor, arguments: arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, constantValueOpt, initializerExpressionOpt, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 29371, 29764);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10476, 27981, 32115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 27981, 32115);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static PatternLocalRewriter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10476, 760, 32126);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10476, 760, 32126);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10476, 760, 32126);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10476, 760, 32126);

            Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
            f_10476_1347_1408(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            factory, Microsoft.CodeAnalysis.SyntaxNode
            node, bool
            generateSequencePoints)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator(factory, node, generateSequencePoints);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10476, 1347, 1408);
                return return_v;
            }

        }
    }
}
