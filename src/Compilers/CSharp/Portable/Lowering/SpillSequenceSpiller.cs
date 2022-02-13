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
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Operations;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SpillSequenceSpiller : BoundTreeRewriterWithStackGuard
    {
        private const BoundKind
        SpillSequenceBuilderKind = (BoundKind)byte.MaxValue
        ;

        private readonly SyntheticBoundNodeFactory _F;

        private readonly PooledDictionary<LocalSymbol, LocalSymbol> _tempSubstitution;

        private SpillSequenceSpiller(MethodSymbol method, SyntaxNode syntaxNode, TypeCompilationState compilationState, PooledDictionary<LocalSymbol, LocalSymbol> tempSubstitution, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10437, 986, 1400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 883, 885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 956, 973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 1210, 1296);

                _F = f_10437_1215_1295(method, syntaxNode, compilationState, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 1310, 1338);

                _F.CurrentFunction = method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 1352, 1389);

                _tempSubstitution = tempSubstitution;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10437, 986, 1400);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 986, 1400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 986, 1400);
            }
        }
        private sealed class BoundSpillSequenceBuilder : BoundExpression
        {
            public readonly BoundExpression Value;

            private ArrayBuilder<LocalSymbol> _locals;

            private ArrayBuilder<BoundStatement> _statements;

            public BoundSpillSequenceBuilder(SyntaxNode syntax, BoundExpression value = null)
            : base(f_10437_1782_1806_C(SpillSequenceBuilderKind), syntax, f_10437_1816_1827_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(value, 10437, 1816, 1827)?.Type))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10437, 1676, 1967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 1533, 1538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 1589, 1596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 1648, 1659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 1861, 1915);

                    f_10437_1861_1914(f_10437_1874_1885_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(value, 10437, 1874, 1885)?.Kind) != SpillSequenceBuilderKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 1933, 1952);

                    this.Value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10437, 1676, 1967);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 1676, 1967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 1676, 1967);
                }
            }

            public bool HasStatements
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 2041, 2131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 2085, 2112);

                        return _statements != null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 2041, 2131);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 1983, 2146);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 1983, 2146);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool HasLocals
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 2216, 2302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 2260, 2283);

                        return _locals != null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 2216, 2302);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 2162, 2317);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 2162, 2317);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ImmutableArray<LocalSymbol> GetLocals()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 2333, 2512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 2412, 2497);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10437, 2419, 2436) || (((_locals == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10437, 2439, 2472)) || DynAbs.Tracing.TraceSender.Conditional_F3(10437, 2475, 2496))) ? ImmutableArray<LocalSymbol>.Empty : f_10437_2475_2496(_locals);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 2333, 2512);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10437_2475_2496(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 2475, 2496);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 2333, 2512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 2333, 2512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImmutableArray<BoundStatement> GetStatements()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 2528, 2810);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 2614, 2742) || true) && (_statements == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 2614, 2742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 2679, 2723);

                        return ImmutableArray<BoundStatement>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 2614, 2742);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 2762, 2795);

                    return f_10437_2769_2794(_statements);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 2528, 2810);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10437_2769_2794(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 2769, 2794);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 2528, 2810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 2528, 2810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal BoundSpillSequenceBuilder Update(BoundExpression value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 2826, 3127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 2923, 2986);

                    var
                    result = f_10437_2936_2985(this.Syntax, value)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3004, 3029);

                    result._locals = _locals;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3047, 3080);

                    result._statements = _statements;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3098, 3112);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 2826, 3127);

                    Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                    f_10437_2936_2985(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 2936, 2985);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 2826, 3127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 2826, 3127);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 3143, 3307);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3194, 3230) || true) && (_locals != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 3194, 3230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3215, 3230);

                        f_10437_3215_3229(_locals);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 3194, 3230);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3248, 3292) || true) && (_statements != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 3248, 3292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3273, 3292);

                        f_10437_3273_3291(_statements);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 3248, 3292);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 3143, 3307);

                    int
                    f_10437_3215_3229(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 3215, 3229);
                        return 0;
                    }


                    int
                    f_10437_3273_3291(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 3273, 3291);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 3143, 3307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 3143, 3307);
                }
            }

            internal void Include(BoundSpillSequenceBuilder other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 3323, 3627);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3410, 3612) || true) && (other != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 3410, 3612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3469, 3516);

                        f_10437_3469_3515(ref _locals, ref other._locals);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3538, 3593);

                        f_10437_3538_3592(ref _statements, ref other._statements);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 3410, 3612);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 3323, 3627);

                    int
                    f_10437_3469_3515(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    left, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    right)
                    {
                        IncludeAndFree(ref left, ref right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 3469, 3515);
                        return 0;
                    }


                    int
                    f_10437_3538_3592(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    left, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    right)
                    {
                        IncludeAndFree(ref left, ref right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 3538, 3592);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 3323, 3627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 3323, 3627);
                }
            }

            private static void IncludeAndFree<T>(ref ArrayBuilder<T> left, ref ArrayBuilder<T> right)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10437, 3643, 4077);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3766, 3851) || true) && (right == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 3766, 3851);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3825, 3832);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 3766, 3851);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3871, 3990) || true) && (left == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 3871, 3990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3929, 3942);

                        left = right;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 3964, 3971);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 3871, 3990);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 4010, 4031);

                    f_10437_4010_4030<T>(
                                    left, right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 4049, 4062);

                    f_10437_4049_4061<T>(right);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10437, 3643, 4077);

                    int
                    f_10437_4010_4030<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 4010, 4030);
                        return 0;
                    }


                    int
                    f_10437_4049_4061<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 4049, 4061);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 3643, 4077);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 3643, 4077);
                }
            }

            public void AddLocal(LocalSymbol local)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 4093, 4349);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 4165, 4295) || true) && (_locals == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 4165, 4295);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 4226, 4276);

                        _locals = f_10437_4236_4275();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 4165, 4295);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 4315, 4334);

                    f_10437_4315_4333(
                                    _locals, local);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 4093, 4349);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10437_4236_4275()
                    {
                        var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 4236, 4275);
                        return return_v;
                    }


                    int
                    f_10437_4315_4333(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 4315, 4333);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 4093, 4349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 4093, 4349);
                }
            }

            public void AddLocals(ImmutableArray<LocalSymbol> locals)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 4365, 4575);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 4455, 4560);
                        foreach (var local in f_10437_4477_4483_I(locals))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 4455, 4560);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 4525, 4541);

                            f_10437_4525_4540(this, local);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 4455, 4560);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10437, 1, 106);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10437, 1, 106);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 4365, 4575);

                    int
                    f_10437_4525_4540(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    local)
                    {
                        this_param.AddLocal(local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 4525, 4540);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10437_4477_4483_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 4477, 4483);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 4365, 4575);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 4365, 4575);
                }
            }

            public void AddStatement(BoundStatement statement)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 4591, 4877);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 4674, 4815) || true) && (_statements == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 4674, 4815);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 4739, 4796);

                        _statements = f_10437_4753_4795();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 4674, 4815);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 4835, 4862);

                    f_10437_4835_4861(
                                    _statements, statement);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 4591, 4877);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10437_4753_4795()
                    {
                        var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 4753, 4795);
                        return return_v;
                    }


                    int
                    f_10437_4835_4861(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 4835, 4861);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 4591, 4877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 4591, 4877);
                }
            }

            public void AddStatements(ImmutableArray<BoundStatement> statements)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 4893, 5130);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 4994, 5115);
                        foreach (var statement in f_10437_5020_5030_I(statements))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 4994, 5115);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 5072, 5096);

                            f_10437_5072_5095(this, statement);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 4994, 5115);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10437, 1, 122);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10437, 1, 122);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 4893, 5130);

                    int
                    f_10437_5072_5095(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    statement)
                    {
                        this_param.AddStatement(statement);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 5072, 5095);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10437_5020_5030_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 5020, 5030);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 4893, 5130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 4893, 5130);
                }
            }

            internal void AddExpressions(ImmutableArray<BoundExpression> expressions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 5146, 5472);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 5252, 5457);
                        foreach (var expression in f_10437_5279_5290_I(expressions))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 5252, 5457);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 5332, 5438);

                            f_10437_5332_5437(this, new BoundExpressionStatement(expression.Syntax, expression) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10437, 5345, 5436) });
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 5252, 5457);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10437, 1, 206);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10437, 1, 206);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 5146, 5472);

                    int
                    f_10437_5332_5437(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    statement)
                    {
                        this_param.AddStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 5332, 5437);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10437_5279_5290_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 5279, 5290);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 5146, 5472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 5146, 5472);
                }
            }

            internal override string Dump()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 5499, 6192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 5563, 6123);

                    var
                    node = f_10437_5574_6122("boundSpillSequenceBuilder", null, new TreeDumperNode[]
                                        {
f_10437_5697_5749("locals", f_10437_5726_5742(this), null),
f_10437_5776_5893("statements", null, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from x in this.GetStatements() select BoundTreeDumperNodeProducer.MakeTree(x),10437,5815,5892)),
f_10437_5920_6028("value", null, new TreeDumperNode[] { f_10437_5977_6025(this.Value)}),
f_10437_6055_6098("type", f_10437_6082_6091(this), null)                    })
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 6141, 6177);

                    return f_10437_6148_6176(node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 5499, 6192);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10437_5726_5742(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                    this_param)
                    {
                        var return_v = this_param.GetLocals();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 5726, 5742);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10437_5697_5749(string
                    text, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    value, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>?
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, (object)value, children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 5697, 5749);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10437_5776_5893(string
                    text, object?
                    value, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, value, children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 5776, 5893);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10437_5977_6025(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = BoundTreeDumperNodeProducer.MakeTree((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 5977, 6025);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10437_5920_6028(string
                    text, object?
                    value, Microsoft.CodeAnalysis.TreeDumperNode[]
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, value, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>)children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 5920, 6028);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10437_6082_6091(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 6082, 6091);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10437_6055_6098(string
                    text, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    value, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>?
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, (object?)value, children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 6055, 6098);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10437_5574_6122(string
                    text, object?
                    value, Microsoft.CodeAnalysis.TreeDumperNode[]
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, value, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>)children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 5574, 6122);
                        return return_v;
                    }


                    string
                    f_10437_6148_6176(Microsoft.CodeAnalysis.TreeDumperNode
                    root)
                    {
                        var return_v = TreeDumper.DumpCompact(root);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 6148, 6176);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 5499, 6192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 5499, 6192);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static BoundSpillSequenceBuilder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10437, 1412, 6211);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10437, 1412, 6211);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 1412, 6211);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10437, 1412, 6211);

            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            f_10437_1816_1827_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 1816, 1827);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundKind?
            f_10437_1874_1885_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 1874, 1885);
                return return_v;
            }


            int
            f_10437_1861_1914(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 1861, 1914);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.BoundKind
            f_10437_1782_1806_C(Microsoft.CodeAnalysis.CSharp.BoundKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10437, 1676, 1967);
                return return_v;
            }

        }
        private sealed class LocalSubstituter : BoundTreeRewriterWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
        {
            private readonly PooledDictionary<LocalSymbol, LocalSymbol> _tempSubstitution;

            private LocalSubstituter(PooledDictionary<LocalSymbol, LocalSymbol> tempSubstitution, int recursionDepth = 0)
            : base(f_10437_6588_6602_C(recursionDepth))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10437, 6454, 6688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 6420, 6437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 6636, 6673);

                    _tempSubstitution = tempSubstitution;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10437, 6454, 6688);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 6454, 6688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 6454, 6688);
                }
            }

            public static BoundNode Rewrite(PooledDictionary<LocalSymbol, LocalSymbol> tempSubstitution, BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10437, 6704, 7090);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 6845, 6949) || true) && (f_10437_6849_6871(tempSubstitution) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 6845, 6949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 6918, 6930);

                        return node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 6845, 6949);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 6969, 7026);

                    var
                    substituter = f_10437_6987_7025(tempSubstitution)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 7044, 7075);

                    return f_10437_7051_7074(substituter, node);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10437, 6704, 7090);

                    int
                    f_10437_6849_6871(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 6849, 6871);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.LocalSubstituter
                    f_10437_6987_7025(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    tempSubstitution)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.LocalSubstituter(tempSubstitution);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 6987, 7025);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10437_7051_7074(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.LocalSubstituter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node)
                    {
                        var return_v = this_param.Visit(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 7051, 7074);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 6704, 7090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 6704, 7090);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitLocal(BoundLocal node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 7106, 7615);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 7192, 7551) || true) && (!f_10437_7197_7243(f_10437_7197_7229(f_10437_7197_7213(node))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 7192, 7551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 7285, 7307);

                        LocalSymbol
                        longLived
                        = default(LocalSymbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 7329, 7532) || true) && (f_10437_7333_7395(_tempSubstitution, f_10437_7363_7379(node), out longLived))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 7329, 7532);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 7445, 7509);

                            return f_10437_7452_7508(node, longLived, f_10437_7475_7496(node), f_10437_7498_7507(node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 7329, 7532);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 7192, 7551);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 7571, 7600);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocal(node), 10437, 7578, 7599);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 7106, 7615);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10437_7197_7213(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 7197, 7213);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SynthesizedLocalKind
                    f_10437_7197_7229(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.SynthesizedKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 7197, 7229);
                        return return_v;
                    }


                    bool
                    f_10437_7197_7243(Microsoft.CodeAnalysis.SynthesizedLocalKind
                    kind)
                    {
                        var return_v = kind.IsLongLived();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 7197, 7243);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10437_7363_7379(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 7363, 7379);
                        return return_v;
                    }


                    bool
                    f_10437_7333_7395(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 7333, 7395);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10437_7475_7496(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.ConstantValueOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 7475, 7496);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10437_7498_7507(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 7498, 7507);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLocal
                    f_10437_7452_7508(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    localSymbol, Microsoft.CodeAnalysis.ConstantValue?
                    constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = this_param.Update(localSymbol, constantValueOpt, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 7452, 7508);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 7106, 7615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 7106, 7615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static LocalSubstituter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10437, 6223, 7626);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10437, 6223, 7626);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 6223, 7626);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10437, 6223, 7626);

            static int
            f_10437_6588_6602_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10437, 6454, 6688);
                return return_v;
            }

        }

        internal static BoundStatement Rewrite(BoundStatement body, MethodSymbol method, TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10437, 7638, 8232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 7809, 7889);

                var
                tempSubstitution = f_10437_7832_7888()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 7903, 8012);

                var
                spiller = f_10437_7917_8011(method, body.Syntax, compilationState, tempSubstitution, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8026, 8065);

                BoundNode
                result = f_10437_8045_8064(spiller, body)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8079, 8139);

                result = f_10437_8088_8138(tempSubstitution, result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8153, 8177);

                f_10437_8153_8176(tempSubstitution);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8191, 8221);

                return (BoundStatement)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10437, 7638, 8232);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10437_7832_7888()
                {
                    var return_v = PooledDictionary<LocalSymbol, LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 7832, 7888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                f_10437_7917_8011(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                tempSubstitution, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller(method, syntaxNode, compilationState, tempSubstitution, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 7917, 8011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10437_8045_8064(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 8045, 8064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10437_8088_8138(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                tempSubstitution, Microsoft.CodeAnalysis.CSharp.BoundNode?
                node)
                {
                    var return_v = LocalSubstituter.Rewrite(tempSubstitution, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 8088, 8138);
                    return return_v;
                }


                int
                f_10437_8153_8176(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 8153, 8176);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 7638, 8232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 7638, 8232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitExpression(ref BoundSpillSequenceBuilder builder, BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 8244, 8869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8375, 8423);

                var
                e = (BoundExpression)f_10437_8400_8422(this, expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8437, 8546) || true) && (e == null || (DynAbs.Tracing.TraceSender.Expression_False(10437, 8441, 8488) || f_10437_8454_8460(e) != SpillSequenceBuilderKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 8437, 8546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8522, 8531);

                    return e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 8437, 8546);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8562, 8608);

                var
                newBuilder = (BoundSpillSequenceBuilder)e
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8622, 8818) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 8622, 8818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8675, 8709);

                    builder = f_10437_8685_8708(newBuilder, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 8622, 8818);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 8622, 8818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8775, 8803);

                    f_10437_8775_8802(builder, newBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 8622, 8818);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 8834, 8858);

                return newBuilder.Value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 8244, 8869);

                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10437_8400_8422(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 8400, 8422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10437_8454_8460(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 8454, 8460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_8685_8708(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = this_param.Update(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 8685, 8708);
                    return return_v;
                }


                int
                f_10437_8775_8802(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                other)
                {
                    this_param.Include(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 8775, 8802);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 8244, 8869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 8244, 8869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression UpdateExpression(BoundSpillSequenceBuilder builder, BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10437, 8881, 9377);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9016, 9102) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 9016, 9102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9069, 9087);

                    return expression;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 9016, 9102);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9118, 9154);

                f_10437_9118_9153(builder.Value == null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9168, 9316) || true) && (f_10437_9172_9190_M(!builder.HasLocals) && (DynAbs.Tracing.TraceSender.Expression_True(10437, 9172, 9216) && f_10437_9194_9216_M(!builder.HasStatements)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 9168, 9316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9250, 9265);

                    f_10437_9250_9264(builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9283, 9301);

                    return expression;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 9168, 9316);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9332, 9366);

                return f_10437_9339_9365(builder, expression);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10437, 8881, 9377);

                int
                f_10437_9118_9153(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 9118, 9153);
                    return 0;
                }


                bool
                f_10437_9172_9190_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 9172, 9190);
                    return return_v;
                }


                bool
                f_10437_9194_9216_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 9194, 9216);
                    return return_v;
                }


                int
                f_10437_9250_9264(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 9250, 9264);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_9339_9365(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = this_param.Update(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 9339, 9365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 8881, 9377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 8881, 9377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement UpdateStatement(BoundSpillSequenceBuilder builder, BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 9389, 9970);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9513, 9648) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 9513, 9648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9566, 9598);

                    f_10437_9566_9597(statement != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9616, 9633);

                    return statement;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 9513, 9648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9664, 9700);

                f_10437_9664_9699(builder.Value == null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9714, 9816) || true) && (statement != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 9714, 9816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9769, 9801);

                    f_10437_9769_9800(builder, statement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 9714, 9816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9832, 9900);

                var
                result = f_10437_9845_9899(_F, f_10437_9854_9873(builder), f_10437_9875_9898(builder))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9916, 9931);

                f_10437_9916_9930(
                            builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 9945, 9959);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 9389, 9970);

                int
                f_10437_9566_9597(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 9566, 9597);
                    return 0;
                }


                int
                f_10437_9664_9699(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 9664, 9699);
                    return 0;
                }


                int
                f_10437_9769_9800(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.AddStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 9769, 9800);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10437_9854_9873(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param)
                {
                    var return_v = this_param.GetLocals();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 9854, 9873);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10437_9875_9898(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param)
                {
                    var return_v = this_param.GetStatements();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 9875, 9898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10437_9845_9899(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 9845, 9899);
                    return return_v;
                }


                int
                f_10437_9916_9930(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 9916, 9930);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 9389, 9970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 9389, 9970);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression Spill(
            BoundSpillSequenceBuilder builder,
            BoundExpression expression,
            RefKind refKind = RefKind.None,
            bool sideEffectsOnly = false)
        {
            Debug.Assert(builder != null);
            if (builder.Syntax != null)
                _F.Syntax = builder.Syntax;

            while (true)
            {
                switch (expression.Kind)
                {
                    case BoundKind.ArrayInitialization:
                        Debug.Assert(refKind == RefKind.None);
                        Debug.Assert(!sideEffectsOnly);
                        var arrayInitialization = (BoundArrayInitialization)expression;
                        var newInitializers = VisitExpressionList(ref builder, arrayInitialization.Initializers, forceSpill: true);
                        return arrayInitialization.Update(newInitializers);

                    case BoundKind.ArgListOperator:
                        Debug.Assert(refKind == RefKind.None);
                        Debug.Assert(!sideEffectsOnly);
                        var argumentList = (BoundArgListOperator)expression;
                        var newArgs = VisitExpressionList(ref builder, argumentList.Arguments, argumentList.ArgumentRefKindsOpt, forceSpill: true);
                        return argumentList.Update(newArgs, argumentList.ArgumentRefKindsOpt, argumentList.Type);

                    case SpillSequenceBuilderKind:
                        var sequenceBuilder = (BoundSpillSequenceBuilder)expression;
                        builder.Include(sequenceBuilder);
                        expression = sequenceBuilder.Value;
                        continue;

                    case BoundKind.Sequence:
                        // neither the side-effects nor the value of the sequence contains await 
                        // (otherwise it would be converted to a SpillSequenceBuilder).
                        if (refKind != RefKind.None)
                        {
                            return expression;
                        }

                        goto default;

                    case BoundKind.ThisReference:
                    case BoundKind.BaseReference:
                        if (refKind != RefKind.None || expression.Type.IsReferenceType)
                        {
                            return expression;
                        }

                        goto default;

                    case BoundKind.Parameter:
                        if (refKind != RefKind.None)
                        {
                            return expression;
                        }

                        goto default;

                    case BoundKind.Local:
                        var local = (BoundLocal)expression;
                        if (local.LocalSymbol.SynthesizedKind == SynthesizedLocalKind.Spill || refKind != RefKind.None)
                        {
                            return local;
                        }

                        goto default;

                    case BoundKind.FieldAccess:
                        var field = (BoundFieldAccess)expression;
                        var fieldSymbol = field.FieldSymbol;
                        if (fieldSymbol.IsStatic)
                        {
                            // no need to spill static fields if used as locations or if readonly
                            if (refKind != RefKind.None || fieldSymbol.IsReadOnly)
                            {
                                return field;
                            }
                            goto default;
                        }

                        if (refKind == RefKind.None) goto default;

                        var receiver = Spill(builder, field.ReceiverOpt, fieldSymbol.ContainingType.IsValueType ? refKind : RefKind.None);
                        return field.Update(receiver, fieldSymbol, field.ConstantValueOpt, field.ResultKind, field.Type);

                    case BoundKind.Literal:
                    case BoundKind.TypeExpression:
                        return expression;

                    case BoundKind.ConditionalReceiver:
                        // we will rewrite this as a part of rewriting whole LoweredConditionalAccess
                        // later, if needed
                        return expression;

                    default:
                        if (expression.Type.IsVoidType() || sideEffectsOnly)
                        {
                            builder.AddStatement(_F.ExpressionStatement(expression));
                            return null;
                        }
                        else
                        {
                            BoundAssignmentOperator assignToTemp;

                            var replacement = _F.StoreToTemp(
                                expression,
                                out assignToTemp,
                                refKind: refKind,
                                kind: SynthesizedLocalKind.Spill,
                                syntaxOpt: _F.Syntax);

                            builder.AddLocal(replacement.LocalSymbol);
                            builder.AddStatement(_F.ExpressionStatement(assignToTemp));
                            return replacement;
                        }
                }
            }
        }

        private ImmutableArray<BoundExpression> VisitExpressionList(
                    ref BoundSpillSequenceBuilder builder,
                    ImmutableArray<BoundExpression> args,
                    ImmutableArray<RefKind> refKinds = default(ImmutableArray<RefKind>),
                    bool forceSpill = false,
                    bool sideEffectsOnly = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 15501, 18269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 15852, 15905);

                f_10437_15852_15904(!sideEffectsOnly || (DynAbs.Tracing.TraceSender.Expression_False(10437, 15865, 15903) || refKinds.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 15919, 15986);

                f_10437_15919_15985(refKinds.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10437, 15932, 15984) || refKinds.Length == args.Length));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16002, 16083) || true) && (args.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 16002, 16083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16056, 16068);

                    return args;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 16002, 16083);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16099, 16129);

                var
                newList = f_10437_16113_16128(this, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16143, 16187);

                f_10437_16143_16186(newList.Length == args.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16203, 16217);

                int
                lastSpill
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16231, 16691) || true) && (forceSpill)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 16231, 16691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16279, 16306);

                    lastSpill = newList.Length;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 16231, 16691);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 16231, 16691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16372, 16387);

                    lastSpill = -1;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16414, 16436);
                        for (int
        i = newList.Length - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16405, 16676) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16446, 16449)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 16405, 16676))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 16405, 16676);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16491, 16657) || true) && (f_10437_16495_16510(newList[i]) == SpillSequenceBuilderKind)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 16491, 16657);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16588, 16602);

                                lastSpill = i;
                                DynAbs.Tracing.TraceSender.TraceBreak(10437, 16628, 16634);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 16491, 16657);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10437, 1, 272);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10437, 1, 272);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 16231, 16691);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16707, 16790) || true) && (lastSpill == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 16707, 16790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16760, 16775);

                    return newList;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 16707, 16790);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16806, 17094) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 16806, 17094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 16886, 17079);

                    builder = f_10437_16896_17078((DynAbs.Tracing.TraceSender.Conditional_F1(10437, 16926, 16952) || ((lastSpill < newList.Length && DynAbs.Tracing.TraceSender.Conditional_F2(10437, 16955, 17070)) || DynAbs.Tracing.TraceSender.Conditional_F3(10437, 17073, 17077))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(10437, 16956, 17005) || (((newList[lastSpill] is BoundSpillSequenceBuilder) && DynAbs.Tracing.TraceSender.Conditional_F2(10437, 17008, 17062)) || DynAbs.Tracing.TraceSender.Conditional_F3(10437, 17065, 17069))) ? ((BoundSpillSequenceBuilder)newList[lastSpill]).Syntax : null) : null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 16806, 17094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17110, 17181);

                var
                result = f_10437_17123_17180(newList.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17282, 17287);

                    // everything up until the last spill must be spilled entirely
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17273, 17705) || true) && (i < lastSpill)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17304, 17307)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 17273, 17705))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 17273, 17705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17341, 17403);

                        var
                        refKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10437, 17355, 17373) || ((refKinds.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10437, 17376, 17388)) || DynAbs.Tracing.TraceSender.Conditional_F3(10437, 17391, 17402))) ? RefKind.None : refKinds[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17421, 17492);

                        var
                        replacement = f_10437_17439_17491(this, builder, newList[i], refKind, sideEffectsOnly)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17512, 17565);

                        f_10437_17512_17564(sideEffectsOnly || (DynAbs.Tracing.TraceSender.Expression_False(10437, 17525, 17563) || replacement != null));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17585, 17690) || true) && (!sideEffectsOnly)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 17585, 17690);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17647, 17671);

                            f_10437_17647_17670(result, replacement);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 17585, 17690);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10437, 1, 433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10437, 1, 433);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17808, 18207) || true) && (lastSpill < newList.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 17808, 18207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17872, 17938);

                    var
                    lastSpillNode = (BoundSpillSequenceBuilder)newList[lastSpill]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 17956, 17987);

                    f_10437_17956_17986(builder, lastSpillNode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18005, 18037);

                    f_10437_18005_18036(result, lastSpillNode.Value);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18066, 18083);

                        for (int
        i = lastSpill + 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18057, 18192) || true) && (i < newList.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18105, 18108)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 18057, 18192))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 18057, 18192);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18150, 18173);

                            f_10437_18150_18172(result, newList[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10437, 1, 136);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10437, 1, 136);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 17808, 18207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18223, 18258);

                return f_10437_18230_18257(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 15501, 18269);

                int
                f_10437_15852_15904(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 15852, 15904);
                    return 0;
                }


                int
                f_10437_15919_15985(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 15919, 15985);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_16113_16128(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 16113, 16128);
                    return return_v;
                }


                int
                f_10437_16143_16186(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 16143, 16186);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10437_16495_16510(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 16495, 16510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_16896_17078(Microsoft.CodeAnalysis.SyntaxNode?
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 16896, 17078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_17123_17180(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 17123, 17180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_17439_17491(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.RefKind
                refKind, bool
                sideEffectsOnly)
                {
                    var return_v = this_param.Spill(builder, expression, refKind, sideEffectsOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 17439, 17491);
                    return return_v;
                }


                int
                f_10437_17512_17564(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 17512, 17564);
                    return 0;
                }


                int
                f_10437_17647_17670(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 17647, 17670);
                    return 0;
                }


                int
                f_10437_17956_17986(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                other)
                {
                    this_param.Include(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 17956, 17986);
                    return 0;
                }


                int
                f_10437_18005_18036(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 18005, 18036);
                    return 0;
                }


                int
                f_10437_18150_18172(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 18150, 18172);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_18230_18257(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 18230, 18257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 15501, 18269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 15501, 18269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSwitchDispatch(BoundSwitchDispatch node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 18319, 18667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18415, 18456);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18470, 18533);

                var
                expression = f_10437_18487_18532(this, ref builder, f_10437_18516_18531(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18547, 18656);

                return f_10437_18554_18655(this, builder, f_10437_18579_18654(node, expression, f_10437_18603_18613(node), f_10437_18615_18632(node), f_10437_18634_18653(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 18319, 18667);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_18516_18531(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 18516, 18531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_18487_18532(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 18487, 18532);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                f_10437_18603_18613(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Cases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 18603, 18613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10437_18615_18632(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.DefaultLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 18615, 18632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10437_18634_18653(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.EqualityMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 18634, 18653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                f_10437_18579_18654(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                cases, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                defaultLabel, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                equalityMethod)
                {
                    var return_v = this_param.Update(expression, cases, defaultLabel, equalityMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 18579, 18654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_18554_18655(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 18554, 18655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 18319, 18667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 18319, 18667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitThrowStatement(BoundThrowStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 18679, 18990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18775, 18816);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18830, 18908);

                BoundExpression
                expression = f_10437_18859_18907(this, ref builder, f_10437_18888_18906(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 18922, 18979);

                return f_10437_18929_18978(this, builder, f_10437_18954_18977(node, expression));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 18679, 18990);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10437_18888_18906(Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 18888, 18906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_18859_18907(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 18859, 18907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                f_10437_18954_18977(Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expressionOpt)
                {
                    var return_v = this_param.Update(expressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 18954, 18977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_18929_18978(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 18929, 18978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 18679, 18990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 18679, 18990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitExpressionStatement(BoundExpressionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 19002, 19418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 19108, 19149);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 19163, 19232);

                BoundExpression
                expr = f_10437_19186_19231(this, ref builder, f_10437_19215_19230(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 19246, 19273);

                f_10437_19246_19272(expr != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 19287, 19342);

                f_10437_19287_19341(builder == null || (DynAbs.Tracing.TraceSender.Expression_False(10437, 19300, 19340) || builder.Value == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 19356, 19407);

                return f_10437_19363_19406(this, builder, f_10437_19388_19405(node, expr));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 19002, 19418);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_19215_19230(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 19215, 19230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_19186_19231(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 19186, 19231);
                    return return_v;
                }


                int
                f_10437_19246_19272(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 19246, 19272);
                    return 0;
                }


                int
                f_10437_19287_19341(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 19287, 19341);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_19388_19405(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Update(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 19388, 19405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_19363_19406(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 19363, 19406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 19002, 19418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 19002, 19418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalGoto(BoundConditionalGoto node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 19430, 19754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 19528, 19569);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 19583, 19644);

                var
                condition = f_10437_19599_19643(this, ref builder, f_10437_19628_19642(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 19658, 19743);

                return f_10437_19665_19742(this, builder, f_10437_19690_19741(node, condition, f_10437_19713_19728(node), f_10437_19730_19740(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 19430, 19754);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_19628_19642(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 19628, 19642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_19599_19643(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 19599, 19643);
                    return return_v;
                }


                bool
                f_10437_19713_19728(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.JumpIfTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 19713, 19728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10437_19730_19740(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 19730, 19740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                f_10437_19690_19741(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, bool
                jumpIfTrue, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Update(condition, jumpIfTrue, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 19690, 19741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_19665_19742(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 19665, 19742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 19430, 19754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 19430, 19754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitReturnStatement(BoundReturnStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 19766, 20081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 19864, 19905);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 19919, 19985);

                var
                expression = f_10437_19936_19984(this, ref builder, f_10437_19965_19983(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 19999, 20070);

                return f_10437_20006_20069(this, builder, f_10437_20031_20068(node, f_10437_20043_20055(node), expression));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 19766, 20081);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10437_19965_19983(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 19965, 19983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_19936_19984(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 19936, 19984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10437_20043_20055(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 20043, 20055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10437_20031_20068(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expressionOpt)
                {
                    var return_v = this_param.Update(refKind, expressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 20031, 20068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_20006_20069(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 20006, 20069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 19766, 20081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 19766, 20081);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitYieldReturnStatement(BoundYieldReturnStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 20093, 20401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 20201, 20242);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 20256, 20319);

                var
                expression = f_10437_20273_20318(this, ref builder, f_10437_20302_20317(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 20333, 20390);

                return f_10437_20340_20389(this, builder, f_10437_20365_20388(node, expression));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 20093, 20401);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_20302_20317(Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 20302, 20317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_20273_20318(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 20273, 20318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                f_10437_20365_20388(Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Update(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 20365, 20388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_20340_20389(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 20340, 20389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 20093, 20401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 20093, 20401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCatchBlock(BoundCatchBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 20413, 21571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 20501, 20591);

                BoundExpression
                exceptionSourceOpt = (BoundExpression)f_10437_20555_20590(this, f_10437_20566_20589(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 20605, 20630);

                var
                locals = f_10437_20618_20629(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 20646, 20711);

                var
                exceptionFilterPrologueOpt = f_10437_20679_20710(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 20725, 20774);

                f_10437_20725_20773(exceptionFilterPrologueOpt is null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 20821, 20862);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 20876, 20955);

                var
                exceptionFilterOpt = f_10437_20901_20954(this, ref builder, f_10437_20930_20953(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 20969, 21244) || true) && (builder is { })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 20969, 21244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 21021, 21057);

                    f_10437_21021_21056(builder.Value is null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 21075, 21121);

                    locals = locals.AddRange(f_10437_21100_21119(builder));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 21139, 21229);

                    exceptionFilterPrologueOpt = f_10437_21168_21228(node.Syntax, f_10437_21204_21227(builder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 20969, 21244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 21260, 21312);

                BoundBlock
                body = (BoundBlock)f_10437_21290_21311(this, f_10437_21301_21310(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 21326, 21394);

                TypeSymbol
                exceptionTypeOpt = f_10437_21356_21393(this, f_10437_21371_21392(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 21408, 21560);

                return f_10437_21415_21559(node, locals, exceptionSourceOpt, exceptionTypeOpt, exceptionFilterPrologueOpt, exceptionFilterOpt, body, f_10437_21527_21558(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 20413, 21571);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10437_20566_20589(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 20566, 20589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10437_20555_20590(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 20555, 20590);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10437_20618_20629(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 20618, 20629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                f_10437_20679_20710(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterPrologueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 20679, 20710);
                    return return_v;
                }


                int
                f_10437_20725_20773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 20725, 20773);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10437_20930_20953(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 20930, 20953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_20901_20954(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 20901, 20954);
                    return return_v;
                }


                int
                f_10437_21021_21056(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 21021, 21056);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10437_21100_21119(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param)
                {
                    var return_v = this_param.GetLocals();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 21100, 21119);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10437_21204_21227(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param)
                {
                    var return_v = this_param.GetStatements();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 21204, 21227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10437_21168_21228(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStatementList(syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 21168, 21228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10437_21301_21310(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 21301, 21310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10437_21290_21311(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 21290, 21311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10437_21371_21392(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 21371, 21392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10437_21356_21393(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 21356, 21393);
                    return return_v;
                }


                bool
                f_10437_21527_21558(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.IsSynthesizedAsyncCatchAll;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 21527, 21558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10437_21415_21559(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                exceptionSourceOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                exceptionTypeOpt, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                exceptionFilterPrologueOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
                exceptionFilterOpt, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                body, bool
                isSynthesizedAsyncCatchAll)
                {
                    var return_v = this_param.Update(locals, exceptionSourceOpt, exceptionTypeOpt, exceptionFilterPrologueOpt, exceptionFilterOpt, body, isSynthesizedAsyncCatchAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 21415, 21559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 20413, 21571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 20413, 21571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode DefaultVisit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 21594, 21769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 21673, 21713);

                f_10437_21673_21712(!(node is BoundStatement));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 21727, 21758);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DefaultVisit(node), 10437, 21734, 21757);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 21594, 21769);

                int
                f_10437_21673_21712(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 21673, 21712);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 21594, 21769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 21594, 21769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAwaitExpression(BoundAwaitExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 21850, 22344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 22124, 22165);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 22179, 22236);

                var
                expr = f_10437_22190_22235(this, ref builder, f_10437_22219_22234(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 22250, 22333);

                return f_10437_22257_22332(builder, f_10437_22283_22331(node, expr, f_10437_22301_22319(node), f_10437_22321_22330(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 21850, 22344);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_22219_22234(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 22219, 22234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_22190_22235(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 22190, 22235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10437_22301_22319(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.AwaitableInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 22301, 22319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_22321_22330(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 22321, 22330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                f_10437_22283_22331(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                awaitableInfo, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(expression, awaitableInfo, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 22283, 22331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_22257_22332(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 22257, 22332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 21850, 22344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 21850, 22344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSpillSequence(BoundSpillSequence node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 22356, 22880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 22450, 22507);

                var
                builder = f_10437_22464_22506(node.Syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 22623, 22647);

                _F.Syntax = node.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 22663, 22714);

                f_10437_22663_22713(
                            builder, f_10437_22685_22712(this, f_10437_22695_22711(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 22728, 22759);

                f_10437_22728_22758(builder, f_10437_22746_22757(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 22773, 22826);

                var
                value = f_10437_22785_22825(this, ref builder, f_10437_22814_22824(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 22840, 22869);

                return f_10437_22847_22868(builder, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 22356, 22880);

                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_22464_22506(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 22464, 22506);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10437_22695_22711(Microsoft.CodeAnalysis.CSharp.BoundSpillSequence
                this_param)
                {
                    var return_v = this_param.SideEffects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 22695, 22711);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10437_22685_22712(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundStatement>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 22685, 22712);
                    return return_v;
                }


                int
                f_10437_22663_22713(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    this_param.AddStatements(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 22663, 22713);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10437_22746_22757(Microsoft.CodeAnalysis.CSharp.BoundSpillSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 22746, 22757);
                    return return_v;
                }


                int
                f_10437_22728_22758(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.AddLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 22728, 22758);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_22814_22824(Microsoft.CodeAnalysis.CSharp.BoundSpillSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 22814, 22824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_22785_22825(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 22785, 22825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_22847_22868(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = this_param.Update(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 22847, 22868);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 22356, 22880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 22356, 22880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAddressOfOperator(BoundAddressOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 22892, 23207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 22994, 23035);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 23049, 23103);

                var
                expr = f_10437_23060_23102(this, ref builder, f_10437_23089_23101(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 23117, 23196);

                return f_10437_23124_23195(builder, f_10437_23150_23194(node, expr, f_10437_23168_23182(node), f_10437_23184_23193(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 22892, 23207);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_23089_23101(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 23089, 23101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_23060_23102(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 23060, 23102);
                    return return_v;
                }


                bool
                f_10437_23168_23182(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.IsManaged;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 23168, 23182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_23184_23193(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 23184, 23193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                f_10437_23150_23194(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, bool
                isManaged, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand, isManaged, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 23150, 23194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_23124_23195(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 23124, 23195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 22892, 23207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 22892, 23207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArgListOperator(BoundArgListOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 23219, 23552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 23317, 23358);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 23372, 23435);

                var
                newArgs = f_10437_23386_23434(this, ref builder, f_10437_23419_23433(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 23449, 23541);

                return f_10437_23456_23540(builder, f_10437_23482_23539(node, newArgs, f_10437_23503_23527(node), f_10437_23529_23538(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 23219, 23552);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_23419_23433(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 23419, 23433);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_23386_23434(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.VisitExpressionList(ref builder, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 23386, 23434);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10437_23503_23527(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 23503, 23527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10437_23529_23538(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 23529, 23538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                f_10437_23482_23539(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.Update(arguments, argumentRefKindsOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 23482, 23539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_23456_23540(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 23456, 23540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 23219, 23552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 23219, 23552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayAccess(BoundArrayAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 23564, 24604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 23654, 23695);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 23709, 23772);

                var
                expression = f_10437_23726_23771(this, ref builder, f_10437_23755_23770(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 23788, 23836);

                BoundSpillSequenceBuilder
                indicesBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 23850, 23923);

                var
                indices = f_10437_23864_23922(this, ref indicesBuilder, f_10437_23909_23921(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 23939, 24300) || true) && (indicesBuilder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 23939, 24300);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24082, 24225) || true) && (builder == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 24082, 24225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24143, 24206);

                        builder = f_10437_24153_24205(indicesBuilder.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 24082, 24225);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24245, 24285);

                    expression = f_10437_24258_24284(this, builder, expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 23939, 24300);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24316, 24492) || true) && (builder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 24316, 24492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24369, 24401);

                    f_10437_24369_24400(builder, indicesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24419, 24444);

                    indicesBuilder = builder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24462, 24477);

                    builder = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 24316, 24492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24508, 24593);

                return f_10437_24515_24592(indicesBuilder, f_10437_24548_24591(node, expression, indices, f_10437_24581_24590(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 23564, 24604);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_23755_23770(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 23755, 23770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_23726_23771(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 23726, 23771);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_23909_23921(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 23909, 23921);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_23864_23922(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.VisitExpressionList(ref builder, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 23864, 23922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_24153_24205(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 24153, 24205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_24258_24284(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Spill(builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 24258, 24284);
                    return return_v;
                }


                int
                f_10437_24369_24400(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                other)
                {
                    this_param.Include(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 24369, 24400);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_24581_24590(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 24581, 24590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                f_10437_24548_24591(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(expression, indices, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 24548, 24591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_24515_24592(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 24515, 24592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 23564, 24604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 23564, 24604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayCreation(BoundArrayCreation node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 24616, 25535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24710, 24751);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24765, 24852);

                var
                init = (BoundArrayInitialization)f_10437_24802_24851(this, ref builder, f_10437_24831_24850(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24866, 24905);

                ImmutableArray<BoundExpression>
                bounds
                = default(ImmutableArray<BoundExpression>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24919, 25437) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 24919, 25437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 24972, 25027);

                    bounds = f_10437_24981_25026(this, ref builder, f_10437_25014_25025(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 24919, 25437);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 24919, 25437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 25168, 25234);

                    var
                    boundsBuilder = f_10437_25188_25233(builder.Syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 25252, 25331);

                    bounds = f_10437_25261_25330(this, ref boundsBuilder, f_10437_25300_25311(node), forceSpill: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 25349, 25380);

                    f_10437_25349_25379(boundsBuilder, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 25398, 25422);

                    builder = boundsBuilder;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 24919, 25437);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 25453, 25524);

                return f_10437_25460_25523(builder, f_10437_25486_25522(node, bounds, init, f_10437_25512_25521(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 24616, 25535);

                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                f_10437_24831_24850(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 24831, 24850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_24802_24851(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression?)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 24802, 24851);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_25014_25025(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.Bounds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 25014, 25025);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_24981_25026(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.VisitExpressionList(ref builder, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 24981, 25026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_25188_25233(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 25188, 25233);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_25300_25311(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.Bounds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 25300, 25311);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_25261_25330(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, bool
                forceSpill)
                {
                    var return_v = this_param.VisitExpressionList(ref builder, args, forceSpill: forceSpill);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 25261, 25330);
                    return return_v;
                }


                int
                f_10437_25349_25379(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                other)
                {
                    this_param.Include(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 25349, 25379);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_25512_25521(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 25512, 25521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                f_10437_25486_25522(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                bounds, Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                initializerOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(bounds, initializerOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 25486, 25522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_25460_25523(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 25460, 25523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 24616, 25535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 24616, 25535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayInitialization(BoundArrayInitialization node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 25547, 25869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 25653, 25694);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 25708, 25784);

                var
                initializers = f_10437_25727_25783(this, ref builder, f_10437_25765_25782(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 25798, 25858);

                return f_10437_25805_25857(builder, f_10437_25831_25856(node, initializers));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 25547, 25869);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_25765_25782(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 25765, 25782);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_25727_25783(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.VisitExpressionList(ref builder, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 25727, 25783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                f_10437_25831_25856(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    var return_v = this_param.Update(initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 25831, 25856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_25805_25857(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 25805, 25857);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 25547, 25869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 25547, 25869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConvertedStackAllocExpression(BoundConvertedStackAllocExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 25881, 26361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 26007, 26048);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 26062, 26127);

                BoundExpression
                count = f_10437_26086_26126(this, ref builder, f_10437_26115_26125(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 26141, 26238);

                var
                initializerOpt = (BoundArrayInitialization)f_10437_26188_26237(this, ref builder, f_10437_26217_26236(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 26252, 26350);

                return f_10437_26259_26349(builder, f_10437_26285_26348(node, f_10437_26297_26313(node), count, initializerOpt, f_10437_26338_26347(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 25881, 26361);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_26115_26125(Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 26115, 26125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_26086_26126(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 26086, 26126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                f_10437_26217_26236(Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 26217, 26236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_26188_26237(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression?)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 26188, 26237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_26297_26313(Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 26297, 26313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_26338_26347(Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 26338, 26347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                f_10437_26285_26348(Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                count, Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                initializerOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(elementType, count, initializerOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 26285, 26348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_26259_26349(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 26259, 26349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 25881, 26361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 25881, 26361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayLength(BoundArrayLength node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 26373, 26675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 26463, 26504);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 26518, 26581);

                var
                expression = f_10437_26535_26580(this, ref builder, f_10437_26564_26579(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 26595, 26664);

                return f_10437_26602_26663(builder, f_10437_26628_26662(node, expression, f_10437_26652_26661(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 26373, 26675);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_26564_26579(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 26564, 26579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_26535_26580(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 26535, 26580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_26652_26661(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 26652, 26661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                f_10437_26628_26662(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 26628, 26662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_26602_26663(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 26602, 26663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 26373, 26675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 26373, 26675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAsOperator(BoundAsOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 26687, 27012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 26775, 26816);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 26830, 26887);

                var
                operand = f_10437_26844_26886(this, ref builder, f_10437_26873_26885(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 26901, 27001);

                return f_10437_26908_27000(builder, f_10437_26934_26999(node, operand, f_10437_26955_26970(node), f_10437_26972_26987(node), f_10437_26989_26998(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 26687, 27012);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_26873_26885(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 26873, 26885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_26844_26886(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 26844, 26886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10437_26955_26970(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.TargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 26955, 26970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10437_26972_26987(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 26972, 26987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_26989_26998(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 26989, 26998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                f_10437_26934_26999(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                targetType, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand, targetType, conversion, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 26934, 26999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_26908_27000(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 26908, 27000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 26687, 27012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 26687, 27012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAssignmentOperator(BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 27024, 33123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 27128, 27169);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 27183, 27236);

                var
                right = f_10437_27195_27235(this, ref builder, f_10437_27224_27234(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 27252, 27285);

                BoundExpression
                left = f_10437_27275_27284(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 27299, 30034) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 27299, 30034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 27352, 27394);

                    left = f_10437_27359_27393(this, ref builder, left);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 27299, 30034);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 27299, 30034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 27529, 27593);

                    var
                    leftBuilder = f_10437_27547_27592(builder.Syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 27613, 29930);

                    switch (f_10437_27621_27630(left))
                    {

                        case BoundKind.Local:
                        case BoundKind.Parameter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 27613, 29930);
                            DynAbs.Tracing.TraceSender.TraceBreak(10437, 27885, 27891);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 27613, 29930);

                        case BoundKind.FieldAccess:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 27613, 29930);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 27968, 28003);

                            var
                            field = (BoundFieldAccess)left
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 28138, 28176) || true) && (f_10437_28142_28168(f_10437_28142_28159(field)))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 28138, 28176);
                                DynAbs.Tracing.TraceSender.TraceBreak(10437, 28170, 28176);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 28138, 28176);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 28320, 28402);

                            left = f_10437_28327_28401(field, ref leftBuilder, isAssignmentTarget: true);
                            DynAbs.Tracing.TraceSender.TraceBreak(10437, 28428, 28434);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 27613, 29930);

                        case BoundKind.ArrayAccess:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 27613, 29930);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 28511, 28552);

                            var
                            arrayAccess = (BoundArrayAccess)left
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 28666, 28740);

                            var
                            expression = f_10437_28683_28739(this, ref leftBuilder, f_10437_28716_28738(arrayAccess))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 28766, 28824);

                            expression = f_10437_28779_28823(this, leftBuilder, expression, RefKind.None);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 28850, 28945);

                            var
                            indices = f_10437_28864_28944(this, ref leftBuilder, f_10437_28906_28925(arrayAccess), forceSpill: true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 28971, 29036);

                            left = f_10437_28978_29035(arrayAccess, expression, indices, f_10437_29018_29034(arrayAccess));
                            DynAbs.Tracing.TraceSender.TraceBreak(10437, 29062, 29068);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 27613, 29930);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 27613, 29930);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 29800, 29879);

                            left = f_10437_29807_29878(this, leftBuilder, f_10437_29826_29864(this, ref leftBuilder, left), RefKind.Ref);
                            DynAbs.Tracing.TraceSender.TraceBreak(10437, 29905, 29911);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 27613, 29930);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 29950, 29979);

                    f_10437_29950_29978(
                                    leftBuilder, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 29997, 30019);

                    builder = leftBuilder;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 27299, 30034);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 30050, 30132);

                return f_10437_30057_30131(builder, f_10437_30083_30130(node, left, right, f_10437_30108_30118(node), f_10437_30120_30129(node)));

                BoundExpression fieldWithSpilledReceiver(BoundFieldAccess field, ref BoundSpillSequenceBuilder leftBuilder, bool isAssignmentTarget)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 30148, 33112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 30313, 30350);

                        var
                        generateDummyFieldAccess = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 30368, 32906) || true) && (f_10437_30372_30399_M(!f_10437_30373_30390(field).IsStatic))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 30368, 32906);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 30441, 30483);

                            f_10437_30441_30482(f_10437_30454_30471(field) is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 30505, 30530);

                            BoundExpression
                            receiver
                            = default(BoundExpression);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 30552, 32759) || true) && (f_10437_30556_30604(f_10437_30556_30588(f_10437_30556_30573(field))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 30552, 32759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 30755, 30838);

                                receiver = f_10437_30766_30837(this, leftBuilder, f_10437_30785_30836(this, ref leftBuilder, f_10437_30818_30835(field)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 31182, 31229);

                                generateDummyFieldAccess = !isAssignmentTarget;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 30552, 32759);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 30552, 32759);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 31279, 32759) || true) && (f_10437_31283_31300(field) is BoundArrayAccess arrayAccess)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 31279, 32759);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 31511, 31585);

                                    var
                                    expression = f_10437_31528_31584(this, ref leftBuilder, f_10437_31561_31583(arrayAccess))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 31611, 31669);

                                    expression = f_10437_31624_31668(this, leftBuilder, expression, RefKind.None);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 31695, 31790);

                                    var
                                    indices = f_10437_31709_31789(this, ref leftBuilder, f_10437_31751_31770(arrayAccess), forceSpill: true)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 31816, 31885);

                                    receiver = f_10437_31827_31884(arrayAccess, expression, indices, f_10437_31867_31883(arrayAccess));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 32240, 32292);

                                    f_10437_32240_32291(this, leftBuilder, receiver, sideEffectsOnly: true);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 31279, 32759);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 31279, 32759);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 32342, 32759) || true) && (f_10437_32346_32363(field) is BoundFieldAccess receiverField)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 32342, 32759);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 32447, 32542);

                                        receiver = f_10437_32458_32541(receiverField, ref leftBuilder, isAssignmentTarget: false);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 32342, 32759);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 32342, 32759);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 32640, 32736);

                                        receiver = f_10437_32651_32735(this, leftBuilder, f_10437_32670_32721(this, ref leftBuilder, f_10437_32703_32720(field)), RefKind.Ref);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 32342, 32759);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 31279, 32759);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 30552, 32759);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 32783, 32887);

                            field = f_10437_32791_32886(field, receiver, f_10437_32814_32831(field), f_10437_32833_32855(field), f_10437_32857_32873(field), f_10437_32875_32885(field));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 30368, 32906);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 32926, 33064) || true) && (generateDummyFieldAccess)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 32926, 33064);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 32996, 33045);

                            f_10437_32996_33044(this, leftBuilder, field, sideEffectsOnly: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 32926, 33064);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 33084, 33097);

                        return field;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 30148, 33112);

                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10437_30373_30390(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.FieldSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 30373, 30390);
                            return return_v;
                        }


                        bool
                        f_10437_30372_30399_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 30372, 30399);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10437_30454_30471(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.ReceiverOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 30454, 30471);
                            return return_v;
                        }


                        int
                        f_10437_30441_30482(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 30441, 30482);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10437_30556_30573(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.FieldSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 30556, 30573);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10437_30556_30588(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 30556, 30588);
                            return return_v;
                        }


                        bool
                        f_10437_30556_30604(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsReferenceType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 30556, 30604);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_30818_30835(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.ReceiverOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 30818, 30835);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_30785_30836(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                        this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                        builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression)
                        {
                            var return_v = this_param.VisitExpression(ref builder, expression);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 30785, 30836);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_30766_30837(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                        this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                        builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression)
                        {
                            var return_v = this_param.Spill(builder, expression);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 30766, 30837);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_31283_31300(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.ReceiverOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 31283, 31300);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_31561_31583(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 31561, 31583);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_31528_31584(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                        this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                        builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression)
                        {
                            var return_v = this_param.VisitExpression(ref builder, expression);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 31528, 31584);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_31624_31668(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                        this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                        builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression, Microsoft.CodeAnalysis.RefKind
                        refKind)
                        {
                            var return_v = this_param.Spill(builder, expression, refKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 31624, 31668);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        f_10437_31751_31770(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                        this_param)
                        {
                            var return_v = this_param.Indices;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 31751, 31770);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        f_10437_31709_31789(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                        this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                        builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        args, bool
                        forceSpill)
                        {
                            var return_v = this_param.VisitExpressionList(ref builder, args, forceSpill: forceSpill);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 31709, 31789);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10437_31867_31883(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 31867, 31883);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                        f_10437_31827_31884(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        indices, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = this_param.Update(expression, indices, type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 31827, 31884);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_32240_32291(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                        this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                        builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression, bool
                        sideEffectsOnly)
                        {
                            var return_v = this_param.Spill(builder, expression, sideEffectsOnly: sideEffectsOnly);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 32240, 32291);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_32346_32363(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.ReceiverOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 32346, 32363);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_32458_32541(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        field, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                        leftBuilder, bool
                        isAssignmentTarget)
                        {
                            var return_v = fieldWithSpilledReceiver(field, ref leftBuilder, isAssignmentTarget: isAssignmentTarget);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 32458, 32541);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_32703_32720(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.ReceiverOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 32703, 32720);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_32670_32721(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                        this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                        builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression)
                        {
                            var return_v = this_param.VisitExpression(ref builder, expression);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 32670, 32721);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_32651_32735(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                        this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                        builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression, Microsoft.CodeAnalysis.RefKind
                        refKind)
                        {
                            var return_v = this_param.Spill(builder, expression, refKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 32651, 32735);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10437_32814_32831(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.FieldSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 32814, 32831);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValue?
                        f_10437_32833_32855(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.ConstantValueOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 32833, 32855);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.LookupResultKind
                        f_10437_32857_32873(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.ResultKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 32857, 32873);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10437_32875_32885(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 32875, 32885);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        f_10437_32791_32886(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                        constantValueOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                        resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        typeSymbol)
                        {
                            var return_v = this_param.Update(receiver, fieldSymbol, constantValueOpt, resultKind, typeSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 32791, 32886);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10437_32996_33044(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                        this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                        builder, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        expression, bool
                        sideEffectsOnly)
                        {
                            var return_v = this_param.Spill(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, sideEffectsOnly: sideEffectsOnly);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 32996, 33044);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 30148, 33112);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 30148, 33112);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 27024, 33123);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_27224_27234(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 27224, 27234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_27195_27235(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 27195, 27235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_27275_27284(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 27275, 27284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_27359_27393(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 27359, 27393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_27547_27592(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 27547, 27592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10437_27621_27630(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 27621, 27630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10437_28142_28159(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 28142, 28159);
                    return return_v;
                }


                bool
                f_10437_28142_28168(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 28142, 28168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_28327_28401(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                field, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                leftBuilder, bool
                isAssignmentTarget)
                {
                    var return_v = fieldWithSpilledReceiver(field, ref leftBuilder, isAssignmentTarget: isAssignmentTarget);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 28327, 28401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_28716_28738(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 28716, 28738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_28683_28739(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 28683, 28739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_28779_28823(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.Spill(builder, expression, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 28779, 28823);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_28906_28925(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 28906, 28925);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_28864_28944(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, bool
                forceSpill)
                {
                    var return_v = this_param.VisitExpressionList(ref builder, args, forceSpill: forceSpill);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 28864, 28944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_29018_29034(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 29018, 29034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                f_10437_28978_29035(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(expression, indices, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 28978, 29035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_29826_29864(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 29826, 29864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_29807_29878(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.Spill(builder, expression, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 29807, 29878);
                    return return_v;
                }


                int
                f_10437_29950_29978(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                other)
                {
                    this_param.Include(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 29950, 29978);
                    return 0;
                }


                bool
                f_10437_30108_30118(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 30108, 30118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_30120_30129(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 30120, 30129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10437_30083_30130(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, bool
                isRef, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(left, right, isRef, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 30083, 30130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_30057_30131(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 30057, 30131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 27024, 33123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 27024, 33123);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBadExpression(BoundBadExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 33135, 33311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 33288, 33300);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 33135, 33311);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 33135, 33311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 33135, 33311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUserDefinedConditionalLogicalOperator(BoundUserDefinedConditionalLogicalOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 33323, 33513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 33465, 33502);

                throw f_10437_33471_33501();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 33323, 33513);

                System.Exception
                f_10437_33471_33501()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 33471, 33501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 33323, 33513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 33323, 33513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBinaryOperator(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 33525, 35298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 33621, 33662);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 33676, 33729);

                var
                right = f_10437_33688_33728(this, ref builder, f_10437_33717_33727(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 33743, 33764);

                BoundExpression
                left
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 33778, 35129) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 33778, 35129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 33831, 33878);

                    left = f_10437_33838_33877(this, ref builder, f_10437_33867_33876(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 33778, 35129);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 33778, 35129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 33944, 34008);

                    var
                    leftBuilder = f_10437_33962_34007(builder.Syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 34026, 34077);

                    left = f_10437_34033_34076(this, ref leftBuilder, f_10437_34066_34075(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 34095, 34127);

                    left = f_10437_34102_34126(this, leftBuilder, left);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 34145, 35114) || true) && (f_10437_34149_34166(node) == BinaryOperatorKind.LogicalBoolOr || (DynAbs.Tracing.TraceSender.Expression_False(10437, 34149, 34260) || f_10437_34206_34223(node) == BinaryOperatorKind.LogicalBoolAnd))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 34145, 35114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 34302, 34396);

                        var
                        tmp = f_10437_34312_34395(_F, f_10437_34332_34341(node), kind: SynthesizedLocalKind.Spill, syntax: f_10437_34385_34394(_F))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 34418, 34444);

                        f_10437_34418_34443(leftBuilder, tmp);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 34466, 34527);

                        f_10437_34466_34526(leftBuilder, f_10437_34491_34525(_F, f_10437_34505_34518(_F, tmp), left));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 34549, 34791);

                        f_10437_34549_34790(leftBuilder, f_10437_34574_34789(_F, (DynAbs.Tracing.TraceSender.Conditional_F1(10437, 34606, 34660) || ((f_10437_34606_34623(node) == BinaryOperatorKind.LogicalBoolAnd && DynAbs.Tracing.TraceSender.Conditional_F2(10437, 34663, 34676)) || DynAbs.Tracing.TraceSender.Conditional_F3(10437, 34679, 34700))) ? f_10437_34663_34676(_F, tmp) : f_10437_34679_34700(_F, f_10437_34686_34699(_F, tmp)), f_10437_34727_34788(this, builder, f_10437_34752_34787(_F, f_10437_34766_34779(_F, tmp), right))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 34815, 34867);

                        return f_10437_34822_34866(leftBuilder, f_10437_34852_34865(_F, tmp));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 34145, 35114);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 34145, 35114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 35022, 35051);

                        f_10437_35022_35050(                    // if the right-hand-side has await, spill the left
                                            leftBuilder, builder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 35073, 35095);

                        builder = leftBuilder;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 34145, 35114);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 33778, 35129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 35145, 35287);

                return f_10437_35152_35286(builder, f_10437_35178_35285(node, f_10437_35190_35207(node), f_10437_35209_35227(node), f_10437_35229_35243(node), f_10437_35245_35260(node), left, right, f_10437_35275_35284(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 33525, 35298);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_33717_33727(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 33717, 33727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_33688_33728(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 33688, 33728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_33867_33876(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 33867, 33876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_33838_33877(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 33838, 33877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_33962_34007(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 33962, 34007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_34066_34075(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 34066, 34075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_34033_34076(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34033, 34076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_34102_34126(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Spill(builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34102, 34126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10437_34149_34166(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 34149, 34166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10437_34206_34223(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 34206, 34223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_34332_34341(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 34332, 34341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10437_34385_34394(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 34385, 34394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10437_34312_34395(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.SynthesizedLocal(type, kind: kind, syntax: syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34312, 34395);
                    return return_v;
                }


                int
                f_10437_34418_34443(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.AddLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34418, 34443);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_34505_34518(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34505, 34518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_34491_34525(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34491, 34525);
                    return return_v;
                }


                int
                f_10437_34466_34526(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    this_param.AddStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34466, 34526);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10437_34606_34623(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 34606, 34623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_34663_34676(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34663, 34676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_34686_34699(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34686, 34699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_34679_34700(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression)
                {
                    var return_v = this_param.Not((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34679, 34700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_34766_34779(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34766, 34779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_34752_34787(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34752, 34787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_34727_34788(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34727, 34788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_34574_34789(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause)
                {
                    var return_v = this_param.If(condition, thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34574, 34789);
                    return return_v;
                }


                int
                f_10437_34549_34790(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.AddStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34549, 34790);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_34852_34865(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34852, 34865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_34822_34866(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 34822, 34866);
                    return return_v;
                }


                int
                f_10437_35022_35050(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                other)
                {
                    this_param.Include(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 35022, 35050);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10437_35190_35207(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 35190, 35207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10437_35209_35227(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 35209, 35227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10437_35229_35243(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 35229, 35243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10437_35245_35260(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 35245, 35260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_35275_35284(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 35275, 35284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10437_35178_35285(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 35178, 35285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_35152_35286(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 35152, 35286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 33525, 35298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 33525, 35298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCall(BoundCall node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 35310, 36426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 35386, 35427);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 35441, 35537);

                var
                arguments = f_10437_35457_35536(this, ref builder, f_10437_35495_35509(node), f_10437_35511_35535(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 35553, 35585);

                BoundExpression
                receiver = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 35599, 36319) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 35599, 36319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 35652, 35710);

                    receiver = f_10437_35663_35709(this, ref builder, f_10437_35692_35708(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 35599, 36319);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 35599, 36319);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 35744, 36319) || true) && (f_10437_35748_35784(f_10437_35748_35759(node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 35744, 36319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 35906, 35974);

                        var
                        receiverBuilder = f_10437_35928_35973(builder.Syntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 35994, 36022);

                        receiver = f_10437_36005_36021(node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 36040, 36089);

                        RefKind
                        refKind = f_10437_36058_36088(receiver)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 36109, 36209);

                        receiver = f_10437_36120_36208(this, receiverBuilder, f_10437_36143_36189(this, ref receiverBuilder, receiver), refKind: refKind);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 36227, 36260);

                        f_10437_36227_36259(receiverBuilder, builder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 36278, 36304);

                        builder = receiverBuilder;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 35744, 36319);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 35599, 36319);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 36335, 36415);

                return f_10437_36342_36414(builder, f_10437_36368_36413(node, receiver, f_10437_36390_36401(node), arguments));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 35310, 36426);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_35495_35509(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 35495, 35509);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10437_35511_35535(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 35511, 35535);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_35457_35536(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds)
                {
                    var return_v = this_param.VisitExpressionList(ref builder, args, refKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 35457, 35536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10437_35692_35708(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 35692, 35708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_35663_35709(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 35663, 35709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10437_35748_35759(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 35748, 35759);
                    return return_v;
                }


                bool
                f_10437_35748_35784(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 35748, 35784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_35928_35973(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 35928, 35973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10437_36005_36021(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 36005, 36021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10437_36058_36088(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver)
                {
                    var return_v = ReceiverSpillRefKind(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 36058, 36088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_36143_36189(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 36143, 36189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_36120_36208(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.Spill(builder, expression, refKind: refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 36120, 36208);
                    return return_v;
                }


                int
                f_10437_36227_36259(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                other)
                {
                    this_param.Include(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 36227, 36259);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10437_36390_36401(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 36390, 36401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10437_36368_36413(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = this_param.Update(receiverOpt, method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 36368, 36413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_36342_36414(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 36342, 36414);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 35310, 36426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 35310, 36426);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static RefKind ReceiverSpillRefKind(BoundExpression receiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10437, 36438, 36807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 36532, 36558);

                var
                result = RefKind.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 36572, 36766) || true) && (f_10437_36576_36606_M(!f_10437_36577_36590(receiver).IsReferenceType) && (DynAbs.Tracing.TraceSender.Expression_True(10437, 36576, 36656) && f_10437_36610_36656(receiver)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 36572, 36766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 36690, 36751);

                    result = (DynAbs.Tracing.TraceSender.Conditional_F1(10437, 36699, 36723) || ((f_10437_36699_36723(f_10437_36699_36712(receiver)) && DynAbs.Tracing.TraceSender.Conditional_F2(10437, 36726, 36736)) || DynAbs.Tracing.TraceSender.Conditional_F3(10437, 36739, 36750))) ? RefKind.In : RefKind.Ref;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 36572, 36766);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 36782, 36796);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10437, 36438, 36807);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10437_36577_36590(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 36577, 36590);
                    return return_v;
                }


                bool
                f_10437_36576_36606_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 36576, 36606);
                    return return_v;
                }


                bool
                f_10437_36610_36656(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = LocalRewriter.CanBePassedByReference(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 36610, 36656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_36699_36712(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 36699, 36712);
                    return return_v;
                }


                bool
                f_10437_36699_36723(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 36699, 36723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 36438, 36807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 36438, 36807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalOperator(BoundConditionalOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 36819, 39093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 36925, 36975);

                BoundSpillSequenceBuilder
                conditionBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 36989, 37059);

                var
                condition = f_10437_37005_37058(this, ref conditionBuilder, f_10437_37043_37057(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37075, 37127);

                BoundSpillSequenceBuilder
                consequenceBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37141, 37217);

                var
                consequence = f_10437_37159_37216(this, ref consequenceBuilder, f_10437_37199_37215(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37233, 37285);

                BoundSpillSequenceBuilder
                alternativeBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37299, 37375);

                var
                alternative = f_10437_37317_37374(this, ref alternativeBuilder, f_10437_37357_37373(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37391, 37680) || true) && (consequenceBuilder == null && (DynAbs.Tracing.TraceSender.Expression_True(10437, 37395, 37451) && alternativeBuilder == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 37391, 37680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37485, 37665);

                    return f_10437_37492_37664(conditionBuilder, f_10437_37527_37663(node, f_10437_37539_37549(node), condition, consequence, alternative, f_10437_37588_37609(node), f_10437_37611_37630(node), f_10437_37632_37651(node), f_10437_37653_37662(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 37391, 37680);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37696, 37826) || true) && (conditionBuilder == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 37696, 37826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37726, 37826);

                    conditionBuilder = f_10437_37745_37825((consequenceBuilder ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?>(10437, 37776, 37816) ?? alternativeBuilder)).Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 37696, 37826);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37840, 37950) || true) && (consequenceBuilder == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 37840, 37950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37872, 37950);

                    consequenceBuilder = f_10437_37893_37949(alternativeBuilder.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 37840, 37950);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37964, 38074) || true) && (alternativeBuilder == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 37964, 38074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 37996, 38074);

                    alternativeBuilder = f_10437_38017_38073(consequenceBuilder.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 37964, 38074);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 38090, 39082) || true) && (f_10437_38094_38116(f_10437_38094_38103(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 38090, 39082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 38150, 38418);

                    f_10437_38150_38417(conditionBuilder, f_10437_38202_38416(_F, condition, f_10437_38244_38316(this, consequenceBuilder, f_10437_38280_38315(_F, consequence)), f_10437_38343_38415(this, alternativeBuilder, f_10437_38379_38414(_F, alternative))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 38438, 38492);

                    return f_10437_38445_38491(conditionBuilder, f_10437_38469_38490(_F, f_10437_38480_38489(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 38090, 39082);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 38090, 39082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 38558, 38652);

                    var
                    tmp = f_10437_38568_38651(_F, f_10437_38588_38597(node), kind: SynthesizedLocalKind.Spill, syntax: f_10437_38641_38650(_F))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 38672, 38703);

                    f_10437_38672_38702(
                                    conditionBuilder, tmp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 38721, 39001);

                    f_10437_38721_39000(conditionBuilder, f_10437_38773_38999(_F, condition, f_10437_38815_38893(this, consequenceBuilder, f_10437_38851_38892(_F, f_10437_38865_38878(_F, tmp), consequence)), f_10437_38920_38998(this, alternativeBuilder, f_10437_38956_38997(_F, f_10437_38970_38983(_F, tmp), alternative))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 39021, 39067);

                    return f_10437_39028_39066(conditionBuilder, f_10437_39052_39065(_F, tmp));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 38090, 39082);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 36819, 39093);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_37043_37057(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 37043, 37057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_37005_37058(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 37005, 37058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_37199_37215(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 37199, 37215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_37159_37216(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 37159, 37216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_37357_37373(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 37357, 37373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_37317_37374(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 37317, 37374);
                    return return_v;
                }


                bool
                f_10437_37539_37549(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 37539, 37549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10437_37588_37609(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 37588, 37609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10437_37611_37630(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.NaturalTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 37611, 37630);
                    return return_v;
                }


                bool
                f_10437_37632_37651(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.WasTargetTyped;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 37632, 37651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_37653_37662(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 37653, 37662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                f_10437_37527_37663(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 37527, 37663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_37492_37664(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 37492, 37664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_37745_37825(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 37745, 37825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_37893_37949(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 37893, 37949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_38017_38073(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38017, 38073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_38094_38103(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 38094, 38103);
                    return return_v;
                }


                bool
                f_10437_38094_38116(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38094, 38116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_38280_38315(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.ExpressionStatement(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38280, 38315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_38244_38316(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38244, 38316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_38379_38414(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.ExpressionStatement(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38379, 38414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_38343_38415(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38343, 38415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_38202_38416(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause, Microsoft.CodeAnalysis.CSharp.BoundStatement
                elseClauseOpt)
                {
                    var return_v = this_param.If(condition, thenClause, elseClauseOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38202, 38416);
                    return return_v;
                }


                int
                f_10437_38150_38417(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.AddStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38150, 38417);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_38480_38489(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 38480, 38489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_38469_38490(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Default(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38469, 38490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_38445_38491(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = this_param.Update(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38445, 38491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_38588_38597(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 38588, 38597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10437_38641_38650(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 38641, 38650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10437_38568_38651(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.SynthesizedLocal(type, kind: kind, syntax: syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38568, 38651);
                    return return_v;
                }


                int
                f_10437_38672_38702(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.AddLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38672, 38702);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_38865_38878(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38865, 38878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_38851_38892(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38851, 38892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_38815_38893(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38815, 38893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_38970_38983(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38970, 38983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_38956_38997(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38956, 38997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_38920_38998(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38920, 38998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_38773_38999(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause, Microsoft.CodeAnalysis.CSharp.BoundStatement
                elseClauseOpt)
                {
                    var return_v = this_param.If(condition, thenClause, elseClauseOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38773, 38999);
                    return return_v;
                }


                int
                f_10437_38721_39000(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.AddStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 38721, 39000);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_39052_39065(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 39052, 39065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_39028_39066(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                value)
                {
                    var return_v = this_param.Update((Microsoft.CodeAnalysis.CSharp.BoundExpression)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 39028, 39066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 36819, 39093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 36819, 39093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConversion(BoundConversion node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 39105, 39680);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 39193, 39430) || true) && (f_10437_39197_39216(node) == ConversionKind.AnonymousFunction && (DynAbs.Tracing.TraceSender.Expression_True(10437, 39197, 39284) && f_10437_39256_39284(f_10437_39256_39265(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 39193, 39430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 39403, 39415);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 39193, 39430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 39446, 39487);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 39501, 39558);

                var
                operand = f_10437_39515_39557(this, ref builder, f_10437_39544_39556(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 39572, 39669);

                return f_10437_39579_39668(builder, f_10437_39640_39667(node, operand));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 39105, 39680);

                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10437_39197_39216(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 39197, 39216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_39256_39265(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 39256, 39265);
                    return return_v;
                }


                bool
                f_10437_39256_39284(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                _type)
                {
                    var return_v = _type.IsExpressionTree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 39256, 39284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_39544_39556(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 39544, 39556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_39515_39557(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 39515, 39557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10437_39640_39667(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = this_param.UpdateOperand(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 39640, 39667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_39579_39668(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundConversion
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 39579, 39668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 39105, 39680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 39105, 39680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPassByCopy(BoundPassByCopy node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 39692, 40076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 39780, 39821);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 39835, 39898);

                var
                expression = f_10437_39852_39897(this, ref builder, f_10437_39881_39896(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 39912, 40065);

                return f_10437_39919_40064(builder, f_10437_39980_40063(node, expression, type: f_10437_40053_40062(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 39692, 40076);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_39881_39896(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 39881, 39896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_39852_39897(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 39852, 39897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10437_40053_40062(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 40053, 40062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                f_10437_39980_40063(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.Update(expression, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 39980, 40063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_39919_40064(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 39919, 40064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 39692, 40076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 39692, 40076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMethodGroup(BoundMethodGroup node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 40088, 40226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 40178, 40215);

                throw f_10437_40184_40214();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 40088, 40226);

                System.Exception
                f_10437_40184_40214()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 40184, 40214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 40088, 40226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 40088, 40226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDelegateCreationExpression(BoundDelegateCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 40238, 40604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 40358, 40399);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 40413, 40472);

                var
                argument = f_10437_40428_40471(this, ref builder, f_10437_40457_40470(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 40486, 40593);

                return f_10437_40493_40592(builder, f_10437_40519_40591(node, argument, f_10437_40541_40555(node), f_10437_40557_40579(node), f_10437_40581_40590(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 40238, 40604);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_40457_40470(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 40457, 40470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_40428_40471(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 40428, 40471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10437_40541_40555(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 40541, 40555);
                    return return_v;
                }


                bool
                f_10437_40557_40579(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 40557, 40579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_40581_40590(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 40581, 40590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                f_10437_40519_40591(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt, bool
                isExtensionMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(argument, methodOpt, isExtensionMethod, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 40519, 40591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_40493_40592(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 40493, 40592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 40238, 40604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 40238, 40604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFieldAccess(BoundFieldAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 40616, 40973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 40706, 40747);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 40761, 40823);

                var
                receiver = f_10437_40776_40822(this, ref builder, f_10437_40805_40821(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 40837, 40962);

                return f_10437_40844_40961(builder, f_10437_40870_40960(node, receiver, f_10437_40892_40908(node), f_10437_40910_40931(node), f_10437_40933_40948(node), f_10437_40950_40959(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 40616, 40973);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10437_40805_40821(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 40805, 40821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_40776_40822(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 40776, 40822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10437_40892_40908(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 40892, 40908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10437_40910_40931(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 40910, 40931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10437_40933_40948(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 40933, 40948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_40950_40959(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 40950, 40959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10437_40870_40960(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = this_param.Update(receiver, fieldSymbol, constantValueOpt, resultKind, typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 40870, 40960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_40844_40961(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 40844, 40961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 40616, 40973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 40616, 40973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIsOperator(BoundIsOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 40985, 41310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 41073, 41114);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 41128, 41185);

                var
                operand = f_10437_41142_41184(this, ref builder, f_10437_41171_41183(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 41199, 41299);

                return f_10437_41206_41298(builder, f_10437_41232_41297(node, operand, f_10437_41253_41268(node), f_10437_41270_41285(node), f_10437_41287_41296(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 40985, 41310);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_41171_41183(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 41171, 41183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_41142_41184(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 41142, 41184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10437_41253_41268(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                this_param)
                {
                    var return_v = this_param.TargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 41253, 41268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10437_41270_41285(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 41270, 41285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_41287_41296(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 41287, 41296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                f_10437_41232_41297(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                targetType, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand, targetType, conversion, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 41232, 41297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_41206_41298(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 41206, 41298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 40985, 41310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 40985, 41310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMakeRefOperator(BoundMakeRefOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 41322, 41468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 41420, 41457);

                throw f_10437_41426_41456();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 41322, 41468);

                System.Exception
                f_10437_41426_41456()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 41426, 41456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 41322, 41468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 41322, 41468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNullCoalescingOperator(BoundNullCoalescingOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 41480, 42793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 41592, 41633);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 41647, 41707);

                var
                right = f_10437_41659_41706(this, ref builder, f_10437_41688_41705(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 41721, 41742);

                BoundExpression
                left
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 41756, 42650) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 41756, 42650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 41809, 41863);

                    left = f_10437_41816_41862(this, ref builder, f_10437_41845_41861(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 41756, 42650);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 41756, 42650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 41929, 41993);

                    var
                    leftBuilder = f_10437_41947_41992(builder.Syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 42011, 42069);

                    left = f_10437_42018_42068(this, ref leftBuilder, f_10437_42051_42067(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 42087, 42119);

                    left = f_10437_42094_42118(this, leftBuilder, left);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 42139, 42233);

                    var
                    tmp = f_10437_42149_42232(_F, f_10437_42169_42178(node), kind: SynthesizedLocalKind.Spill, syntax: f_10437_42222_42231(_F))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 42251, 42277);

                    f_10437_42251_42276(leftBuilder, tmp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 42295, 42356);

                    f_10437_42295_42355(leftBuilder, f_10437_42320_42354(_F, f_10437_42334_42347(_F, tmp), left));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 42374, 42563);

                    f_10437_42374_42562(leftBuilder, f_10437_42399_42561(_F, f_10437_42427_42476(_F, f_10437_42442_42455(_F, tmp), f_10437_42457_42475(_F, f_10437_42465_42474(left))), f_10437_42499_42560(this, builder, f_10437_42524_42559(_F, f_10437_42538_42551(_F, tmp), right))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 42583, 42635);

                    return f_10437_42590_42634(leftBuilder, f_10437_42620_42633(_F, tmp));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 41756, 42650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 42666, 42782);

                return f_10437_42673_42781(builder, f_10437_42699_42780(node, left, right, f_10437_42724_42743(node), f_10437_42745_42768(node), f_10437_42770_42779(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 41480, 42793);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_41688_41705(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 41688, 41705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_41659_41706(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 41659, 41706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_41845_41861(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 41845, 41861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_41816_41862(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 41816, 41862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_41947_41992(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 41947, 41992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_42051_42067(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 42051, 42067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_42018_42068(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42018, 42068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_42094_42118(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Spill(builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42094, 42118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_42169_42178(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 42169, 42178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10437_42222_42231(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 42222, 42231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10437_42149_42232(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.SynthesizedLocal(type, kind: kind, syntax: syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42149, 42232);
                    return return_v;
                }


                int
                f_10437_42251_42276(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.AddLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42251, 42276);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_42334_42347(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42334, 42347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_42320_42354(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42320, 42354);
                    return return_v;
                }


                int
                f_10437_42295_42355(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    this_param.AddStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42295, 42355);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_42442_42455(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42442, 42455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10437_42465_42474(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 42465, 42474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_42457_42475(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.Null(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42457, 42475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10437_42427_42476(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.ObjectEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42427, 42476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_42538_42551(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42538, 42551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_42524_42559(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42524, 42559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_42499_42560(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42499, 42560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_42399_42561(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause)
                {
                    var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42399, 42561);
                    return return_v;
                }


                int
                f_10437_42374_42562(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.AddStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42374, 42562);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_42620_42633(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42620, 42633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_42590_42634(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42590, 42634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10437_42724_42743(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 42724, 42743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperatorResultKind
                f_10437_42745_42768(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.OperatorResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 42745, 42768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_42770_42779(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 42770, 42779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                f_10437_42699_42780(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                leftOperand, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rightOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                leftConversion, Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperatorResultKind
                operatorResultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(leftOperand, rightOperand, leftConversion, operatorResultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42699, 42780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_42673_42781(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42673, 42781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 41480, 42793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 41480, 42793);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLoweredConditionalAccess(BoundLoweredConditionalAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 42805, 47692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 42921, 42979);

                var
                receiverRefKind = f_10437_42943_42978(f_10437_42964_42977(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 42995, 43044);

                BoundSpillSequenceBuilder
                receiverBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43058, 43125);

                var
                receiver = f_10437_43073_43124(this, ref receiverBuilder, f_10437_43110_43123(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43141, 43193);

                BoundSpillSequenceBuilder
                whenNotNullBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43207, 43283);

                var
                whenNotNull = f_10437_43225_43282(this, ref whenNotNullBuilder, f_10437_43265_43281(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43299, 43348);

                BoundSpillSequenceBuilder
                whenNullBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43362, 43435);

                var
                whenNullOpt = f_10437_43380_43434(this, ref whenNullBuilder, f_10437_43417_43433(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43451, 43691) || true) && (whenNotNullBuilder == null && (DynAbs.Tracing.TraceSender.Expression_True(10437, 43455, 43508) && whenNullBuilder == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 43451, 43691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43542, 43676);

                    return f_10437_43549_43675(receiverBuilder, f_10437_43583_43674(node, receiver, f_10437_43605_43627(node), whenNotNull, whenNullOpt, f_10437_43655_43662(node), f_10437_43664_43673(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 43451, 43691);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43707, 43832) || true) && (receiverBuilder == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 43707, 43832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43736, 43832);

                    receiverBuilder = f_10437_43754_43831((whenNotNullBuilder ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?>(10437, 43785, 43822) ?? whenNullBuilder)).Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 43707, 43832);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43846, 43953) || true) && (whenNotNullBuilder == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 43846, 43953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43878, 43953);

                    whenNotNullBuilder = f_10437_43899_43952(whenNullBuilder.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 43846, 43953);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43967, 44071) || true) && (whenNullBuilder == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 43967, 44071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 43996, 44071);

                    whenNullBuilder = f_10437_44014_44070(whenNotNullBuilder.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 43967, 44071);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 44087, 44113);

                BoundExpression
                condition
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 44127, 46249) || true) && (f_10437_44131_44160(f_10437_44131_44144(receiver)) || (DynAbs.Tracing.TraceSender.Expression_False(10437, 44131, 44189) || f_10437_44164_44189(f_10437_44164_44177(receiver))) || (DynAbs.Tracing.TraceSender.Expression_False(10437, 44131, 44224) || receiverRefKind == RefKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 44127, 46249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 44295, 44353);

                    receiver = f_10437_44306_44352(this, receiverBuilder, receiver, RefKind.None);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 44371, 44412);

                    var
                    hasValueOpt = f_10437_44389_44411(node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 44432, 44839) || true) && (hasValueOpt == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 44432, 44839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 44497, 44695);

                        condition = f_10437_44509_44694(_F, f_10437_44553_44616(_F, f_10437_44564_44605(_F, SpecialType.System_Object), receiver), f_10437_44643_44693(_F, f_10437_44651_44692(_F, SpecialType.System_Object)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 44432, 44839);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 44432, 44839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 44777, 44820);

                        condition = f_10437_44789_44819(_F, receiver, hasValueOpt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 44432, 44839);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 44127, 46249);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 44127, 46249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 44905, 44950);

                    f_10437_44905_44949(f_10437_44918_44940(node) == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 44968, 45025);

                    receiver = f_10437_44979_45024(this, receiverBuilder, receiver, RefKind.Ref);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 45045, 45160);

                    var
                    clone = f_10437_45057_45159(_F, f_10437_45077_45090(receiver), f_10437_45092_45101(_F), refKind: RefKind.None, kind: SynthesizedLocalKind.Spill)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 45178, 45210);

                    f_10437_45178_45209(receiverBuilder, clone);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 45278, 45514);

                    var
                    isNotClass = f_10437_45295_45513(_F, f_10437_45347_45427(_F, f_10437_45358_45399(_F, SpecialType.System_Object), f_10437_45401_45426(_F, f_10437_45412_45425(receiver))), f_10437_45462_45512(_F, f_10437_45470_45511(_F, SpecialType.System_Object)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 45610, 46146);

                    condition = f_10437_45622_46145(_F, isNotClass, f_10437_45722_46106(_F, f_10437_45780_45830(_F, f_10437_45804_45819(_F, clone), receiver), f_10437_45873_46105(_F, f_10437_45937_46007(_F, f_10437_45948_45989(_F, SpecialType.System_Object), f_10437_45991_46006(_F, clone)), f_10437_46054_46104(_F, f_10437_46062_46103(_F, SpecialType.System_Object)))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 46166, 46234);

                    receiver = f_10437_46177_46233(_F, receiver, f_10437_46217_46232(_F, clone));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 44127, 46249);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 46265, 47681) || true) && (f_10437_46269_46291(f_10437_46269_46278(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 46265, 47681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 46325, 46425);

                    var
                    whenNotNullStatement = f_10437_46352_46424(this, whenNotNullBuilder, f_10437_46388_46423(_F, whenNotNull))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 46443, 46559);

                    whenNotNullStatement = f_10437_46466_46558(whenNotNullStatement, receiver, f_10437_46534_46541(node), f_10437_46543_46557());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 46579, 46664);

                    f_10437_46579_46663(whenNullOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10437, 46592, 46662) || !f_10437_46616_46662(whenNullOpt)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 46684, 46753);

                    f_10437_46684_46752(
                                    receiverBuilder, f_10437_46713_46751(_F, condition, whenNotNullStatement));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 46773, 46826);

                    return f_10437_46780_46825(receiverBuilder, f_10437_46803_46824(_F, f_10437_46814_46823(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 46265, 47681);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 46265, 47681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 46892, 46986);

                    var
                    tmp = f_10437_46902_46985(_F, f_10437_46922_46931(node), kind: SynthesizedLocalKind.Spill, syntax: f_10437_46975_46984(_F))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 47004, 47110);

                    var
                    whenNotNullStatement = f_10437_47031_47109(this, whenNotNullBuilder, f_10437_47067_47108(_F, f_10437_47081_47094(_F, tmp), whenNotNull))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 47128, 47244);

                    whenNotNullStatement = f_10437_47151_47243(whenNotNullStatement, receiver, f_10437_47219_47226(node), f_10437_47228_47242());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 47264, 47315);

                    whenNullOpt = whenNullOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression>(10437, 47278, 47314) ?? f_10437_47293_47314(_F, f_10437_47304_47313(node)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 47335, 47365);

                    f_10437_47335_47364(
                                    receiverBuilder, tmp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 47383, 47601);

                    f_10437_47383_47600(receiverBuilder, f_10437_47434_47599(_F, condition, whenNotNullStatement, f_10437_47523_47598(this, whenNullBuilder, f_10437_47556_47597(_F, f_10437_47570_47583(_F, tmp), whenNullOpt))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 47621, 47666);

                    return f_10437_47628_47665(receiverBuilder, f_10437_47651_47664(_F, tmp));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 46265, 47681);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 42805, 47692);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_42964_42977(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 42964, 42977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10437_42943_42978(Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = ReceiverSpillRefKind(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 42943, 42978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_43110_43123(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 43110, 43123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_43073_43124(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 43073, 43124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_43265_43281(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 43265, 43281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_43225_43282(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 43225, 43282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10437_43417_43433(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNullOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 43417, 43433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_43380_43434(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 43380, 43434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10437_43605_43627(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.HasValueMethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 43605, 43627);
                    return return_v;
                }


                int
                f_10437_43655_43662(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 43655, 43662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_43664_43673(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 43664, 43673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                f_10437_43583_43674(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                hasValueMethodOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
                whenNotNull, Microsoft.CodeAnalysis.CSharp.BoundExpression
                whenNullOpt, int
                id, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(receiver, hasValueMethodOpt, whenNotNull, whenNullOpt, id, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 43583, 43674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_43549_43675(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 43549, 43675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_43754_43831(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 43754, 43831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_43899_43952(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 43899, 43952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_44014_44070(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 44014, 44070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10437_44131_44144(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 44131, 44144);
                    return return_v;
                }


                bool
                f_10437_44131_44160(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 44131, 44160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_44164_44177(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 44164, 44177);
                    return return_v;
                }


                bool
                f_10437_44164_44189(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 44164, 44189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_44306_44352(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.Spill(builder, expression, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 44306, 44352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10437_44389_44411(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.HasValueMethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 44389, 44411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10437_44564_44605(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 44564, 44605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_44553_44616(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 44553, 44616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10437_44651_44692(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 44651, 44692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_44643_44693(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 44643, 44693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10437_44509_44694(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.ObjectNotEqual(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 44509, 44694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10437_44789_44819(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call(receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 44789, 44819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10437_44918_44940(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.HasValueMethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 44918, 44940);
                    return return_v;
                }


                int
                f_10437_44905_44949(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 44905, 44949);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_44979_45024(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.Spill(builder, expression, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 44979, 45024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10437_45077_45090(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 45077, 45090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10437_45092_45101(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 45092, 45101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10437_45057_45159(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = this_param.SynthesizedLocal(type, syntax, refKind: refKind, kind: kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45057, 45159);
                    return return_v;
                }


                int
                f_10437_45178_45209(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.AddLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45178, 45209);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10437_45358_45399(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45358, 45399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_45412_45425(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 45412, 45425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_45401_45426(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Default(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45401, 45426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_45347_45427(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45347, 45427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10437_45470_45511(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45470, 45511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_45462_45512(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45462, 45512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10437_45295_45513(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.ObjectNotEqual(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45295, 45513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_45804_45819(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45804, 45819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10437_45780_45830(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45780, 45830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10437_45948_45989(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45948, 45989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_45991_46006(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45991, 46006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_45937_46007(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45937, 46007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10437_46062_46103(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46062, 46103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_46054_46104(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46054, 46104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10437_45873_46105(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.ObjectNotEqual(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45873, 46105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_45722_46106(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                parts)
                {
                    var return_v = this_param.MakeSequence(parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45722, 46106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10437_45622_46145(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.LogicalOr((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 45622, 46145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_46217_46232(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46217, 46232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_46177_46233(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                valueTypeReceiver, Microsoft.CodeAnalysis.CSharp.BoundLocal
                referenceTypeReceiver)
                {
                    var return_v = this_param.ComplexConditionalReceiver(valueTypeReceiver, (Microsoft.CodeAnalysis.CSharp.BoundExpression)referenceTypeReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46177, 46233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_46269_46278(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 46269, 46278);
                    return return_v;
                }


                bool
                f_10437_46269_46291(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46269, 46291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_46388_46423(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.ExpressionStatement(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46388, 46423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_46352_46424(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46352, 46424);
                    return return_v;
                }


                int
                f_10437_46534_46541(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 46534, 46541);
                    return return_v;
                }


                int
                f_10437_46543_46557()
                {
                    var return_v = RecursionDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 46543, 46557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_46466_46558(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, int
                receiverID, int
                recursionDepth)
                {
                    var return_v = ConditionalReceiverReplacer.Replace((Microsoft.CodeAnalysis.CSharp.BoundNode)node, receiver, receiverID, recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46466, 46558);
                    return return_v;
                }


                bool
                f_10437_46616_46662(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = LocalRewriter.ReadIsSideeffecting(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46616, 46662);
                    return return_v;
                }


                int
                f_10437_46579_46663(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46579, 46663);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_46713_46751(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause)
                {
                    var return_v = this_param.If(condition, thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46713, 46751);
                    return return_v;
                }


                int
                f_10437_46684_46752(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.AddStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46684, 46752);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_46814_46823(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 46814, 46823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_46803_46824(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Default(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46803, 46824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_46780_46825(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = this_param.Update(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46780, 46825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_46922_46931(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 46922, 46931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10437_46975_46984(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 46975, 46984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10437_46902_46985(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.SynthesizedLocal(type, kind: kind, syntax: syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 46902, 46985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_47081_47094(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47081, 47094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_47067_47108(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47067, 47108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_47031_47109(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47031, 47109);
                    return return_v;
                }


                int
                f_10437_47219_47226(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 47219, 47226);
                    return return_v;
                }


                int
                f_10437_47228_47242()
                {
                    var return_v = RecursionDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 47228, 47242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_47151_47243(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, int
                receiverID, int
                recursionDepth)
                {
                    var return_v = ConditionalReceiverReplacer.Replace((Microsoft.CodeAnalysis.CSharp.BoundNode)node, receiver, receiverID, recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47151, 47243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_47304_47313(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 47304, 47313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_47293_47314(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Default(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47293, 47314);
                    return return_v;
                }


                int
                f_10437_47335_47364(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.AddLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47335, 47364);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_47570_47583(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47570, 47583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10437_47556_47597(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47556, 47597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_47523_47598(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = this_param.UpdateStatement(builder, (Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47523, 47598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10437_47434_47599(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause, Microsoft.CodeAnalysis.CSharp.BoundStatement
                elseClauseOpt)
                {
                    var return_v = this_param.If(condition, thenClause, elseClauseOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47434, 47599);
                    return return_v;
                }


                int
                f_10437_47383_47600(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.AddStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47383, 47600);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10437_47651_47664(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47651, 47664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_47628_47665(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                value)
                {
                    var return_v = this_param.Update((Microsoft.CodeAnalysis.CSharp.BoundExpression)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 47628, 47665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 42805, 47692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 42805, 47692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class ConditionalReceiverReplacer : BoundTreeRewriterWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
        {
            private readonly BoundExpression _receiver;

            private readonly int _receiverId;

            private int _replaced;

            private ConditionalReceiverReplacer(BoundExpression receiver, int receiverId, int recursionDepth)
            : base(f_10437_48186_48200_C(recursionDepth))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10437, 48064, 48313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 47885, 47894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 47930, 47941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 48030, 48039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 48234, 48255);

                    _receiver = receiver;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 48273, 48298);

                    _receiverId = receiverId;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10437, 48064, 48313);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 48064, 48313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 48064, 48313);
                }
            }

            public static BoundStatement Replace(BoundNode node, BoundExpression receiver, int receiverID, int recursionDepth)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10437, 48329, 48794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 48476, 48561);

                    var
                    replacer = f_10437_48491_48560(receiver, receiverID, recursionDepth)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 48579, 48629);

                    var
                    result = (BoundStatement)f_10437_48608_48628(replacer, node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 48658, 48737);

                    f_10437_48658_48736(replacer._replaced == 1, "should have replaced exactly one node");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 48765, 48779);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10437, 48329, 48794);

                    Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.ConditionalReceiverReplacer
                    f_10437_48491_48560(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    receiver, int
                    receiverId, int
                    recursionDepth)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.ConditionalReceiverReplacer(receiver, receiverId, recursionDepth);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 48491, 48560);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10437_48608_48628(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.ConditionalReceiverReplacer
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node)
                    {
                        var return_v = this_param.Visit(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 48608, 48628);
                        return return_v;
                    }


                    int
                    f_10437_48658_48736(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 48658, 48736);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 48329, 48794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 48329, 48794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitConditionalReceiver(BoundConditionalReceiver node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 48810, 49128);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 48924, 49081) || true) && (f_10437_48928_48935(node) == _receiverId)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 48924, 49081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49003, 49015);

                        _replaced++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49045, 49062);

                        return _receiver;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 48924, 49081);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49101, 49113);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 48810, 49128);

                    int
                    f_10437_48928_48935(Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 48928, 48935);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 48810, 49128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 48810, 49128);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConditionalReceiverReplacer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10437, 47704, 49139);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10437, 47704, 49139);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 47704, 49139);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10437, 47704, 49139);

            static int
            f_10437_48186_48200_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10437, 48064, 48313);
                return return_v;
            }

        }

        public override BoundNode VisitLambda(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 49151, 49465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49231, 49275);

                var
                oldCurrentFunction = f_10437_49256_49274(_F)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49289, 49322);

                _F.CurrentFunction = f_10437_49310_49321(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49336, 49372);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLambda(node), 10437, 49349, 49371)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49386, 49426);

                _F.CurrentFunction = oldCurrentFunction;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49440, 49454);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 49151, 49465);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10437_49256_49274(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 49256, 49274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10437_49310_49321(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 49310, 49321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 49151, 49465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 49151, 49465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocalFunctionStatement(BoundLocalFunctionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 49477, 49839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49589, 49633);

                var
                oldCurrentFunction = f_10437_49614_49632(_F)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49647, 49680);

                _F.CurrentFunction = f_10437_49668_49679(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49694, 49746);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocalFunctionStatement(node), 10437, 49707, 49745)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49760, 49800);

                _F.CurrentFunction = oldCurrentFunction;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49814, 49828);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 49477, 49839);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10437_49614_49632(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 49614, 49632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10437_49668_49679(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 49668, 49679);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 49477, 49839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 49477, 49839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitObjectCreationExpression(BoundObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 49851, 50458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 49967, 50019);

                f_10437_49967_50018(f_10437_49980_50009(node) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 50033, 50074);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 50088, 50184);

                var
                arguments = f_10437_50104_50183(this, ref builder, f_10437_50142_50156(node), f_10437_50158_50182(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 50198, 50447);

                return f_10437_50205_50446(builder, f_10437_50231_50445(node, f_10437_50243_50259(node), arguments, f_10437_50272_50293(node), f_10437_50295_50319(node), f_10437_50321_50334(node), f_10437_50336_50356(node), f_10437_50358_50379(node), f_10437_50381_50402(node), f_10437_50404_50433(node), f_10437_50435_50444(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 49851, 50458);

                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10437_49980_50009(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 49980, 50009);
                    return return_v;
                }


                int
                f_10437_49967_50018(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 49967, 50018);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_50142_50156(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50142, 50156);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10437_50158_50182(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50158, 50182);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_50104_50183(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds)
                {
                    var return_v = this_param.VisitExpressionList(ref builder, args, refKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 50104, 50183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10437_50243_50259(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50243, 50259);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10437_50272_50293(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50272, 50293);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10437_50295_50319(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50295, 50319);
                    return return_v;
                }


                bool
                f_10437_50321_50334(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50321, 50334);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10437_50336_50356(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50336, 50356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10437_50358_50379(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50358, 50379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10437_50381_50402(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50381, 50402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10437_50404_50433(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50404, 50433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_50435_50444(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50435, 50444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10437_50231_50445(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
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
                    var return_v = this_param.Update(constructor, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, constantValueOpt, initializerExpressionOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 50231, 50445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_50205_50446(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 50205, 50446);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 49851, 50458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 49851, 50458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPointerElementAccess(BoundPointerElementAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 50470, 51375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 50578, 50619);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 50633, 50686);

                var
                index = f_10437_50645_50685(this, ref builder, f_10437_50674_50684(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 50700, 50727);

                BoundExpression
                expression
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 50741, 51258) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 50741, 51258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 50794, 50853);

                    expression = f_10437_50807_50852(this, ref builder, f_10437_50836_50851(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 50741, 51258);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 50741, 51258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 50919, 50989);

                    var
                    expressionBuilder = f_10437_50943_50988(builder.Syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51007, 51076);

                    expression = f_10437_51020_51075(this, ref expressionBuilder, f_10437_51059_51074(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51094, 51144);

                    expression = f_10437_51107_51143(this, expressionBuilder, expression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51162, 51197);

                    f_10437_51162_51196(expressionBuilder, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51215, 51243);

                    builder = expressionBuilder;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 50741, 51258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51274, 51364);

                return f_10437_51281_51363(builder, f_10437_51307_51362(node, expression, index, f_10437_51338_51350(node), f_10437_51352_51361(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 50470, 51375);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_50674_50684(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50674, 50684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_50645_50685(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 50645, 50685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_50836_50851(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 50836, 50851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_50807_50852(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 50807, 50852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_50943_50988(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 50943, 50988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_51059_51074(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 51059, 51074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_51020_51075(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 51020, 51075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_51107_51143(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Spill(builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 51107, 51143);
                    return return_v;
                }


                int
                f_10437_51162_51196(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                other)
                {
                    this_param.Include(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 51162, 51196);
                    return 0;
                }


                bool
                f_10437_51338_51350(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 51338, 51350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_51352_51361(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 51352, 51361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                f_10437_51307_51362(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.BoundExpression
                index, bool
                @checked, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(expression, index, @checked, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 51307, 51362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_51281_51363(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 51281, 51363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 50470, 51375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 50470, 51375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPointerIndirectionOperator(BoundPointerIndirectionOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 51387, 51710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51507, 51548);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51562, 51619);

                var
                operand = f_10437_51576_51618(this, ref builder, f_10437_51605_51617(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51633, 51699);

                return f_10437_51640_51698(builder, f_10437_51666_51697(node, operand, f_10437_51687_51696(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 51387, 51710);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_51605_51617(Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 51605, 51617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_51576_51618(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 51576, 51618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_51687_51696(Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 51687, 51696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                f_10437_51666_51697(Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 51666, 51697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_51640_51698(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 51640, 51698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 51387, 51710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 51387, 51710);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSequence(BoundSequence node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 51722, 52647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51806, 51852);

                BoundSpillSequenceBuilder
                valueBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51866, 51924);

                var
                value = f_10437_51878_51923(this, ref valueBuilder, f_10437_51912_51922(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51940, 51981);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 51997, 52123);

                var
                sideEffects = f_10437_52015_52122(this, ref builder, f_10437_52048_52064(node), forceSpill: valueBuilder != null, sideEffectsOnly: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 52139, 52294) || true) && (builder == null && (DynAbs.Tracing.TraceSender.Expression_True(10437, 52143, 52182) && valueBuilder == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 52139, 52294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 52216, 52279);

                    return f_10437_52223_52278(node, f_10437_52235_52246(node), sideEffects, value, f_10437_52268_52277(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 52139, 52294);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 52310, 52439) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 52310, 52439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 52363, 52424);

                    builder = f_10437_52373_52423(valueBuilder.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 52310, 52439);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 52455, 52497);

                f_10437_52455_52496(this, builder, f_10437_52484_52495(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 52511, 52547);

                f_10437_52511_52546(builder, sideEffects);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 52561, 52591);

                f_10437_52561_52590(builder, valueBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 52607, 52636);

                return f_10437_52614_52635(builder, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 51722, 52647);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_51912_51922(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 51912, 51922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_51878_51923(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 51878, 51923);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_52048_52064(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.SideEffects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 52048, 52064);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10437_52015_52122(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, bool
                forceSpill, bool
                sideEffectsOnly)
                {
                    var return_v = this_param.VisitExpressionList(ref builder, args, forceSpill: forceSpill, sideEffectsOnly: sideEffectsOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 52015, 52122);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10437_52235_52246(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 52235, 52246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_52268_52277(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 52268, 52277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10437_52223_52278(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(locals, sideEffects, value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 52223, 52278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_52373_52423(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 52373, 52423);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10437_52484_52495(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 52484, 52495);
                    return return_v;
                }


                int
                f_10437_52455_52496(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.PromoteAndAddLocals(builder, locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 52455, 52496);
                    return 0;
                }


                int
                f_10437_52511_52546(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions)
                {
                    this_param.AddExpressions(expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 52511, 52546);
                    return 0;
                }


                int
                f_10437_52561_52590(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                other)
                {
                    this_param.Include(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 52561, 52590);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                f_10437_52614_52635(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = this_param.Update(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 52614, 52635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 51722, 52647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 51722, 52647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitThrowExpression(BoundThrowExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 52659, 52975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 52757, 52798);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 52812, 52884);

                BoundExpression
                operand = f_10437_52838_52883(this, ref builder, f_10437_52867_52882(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 52898, 52964);

                return f_10437_52905_52963(builder, f_10437_52931_52962(node, operand, f_10437_52952_52961(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 52659, 52975);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_52867_52882(Microsoft.CodeAnalysis.CSharp.BoundThrowExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 52867, 52882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_52838_52883(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 52838, 52883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10437_52952_52961(Microsoft.CodeAnalysis.CSharp.BoundThrowExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 52952, 52961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThrowExpression
                f_10437_52931_52962(Microsoft.CodeAnalysis.CSharp.BoundThrowExpression
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.Update(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 52931, 52962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_52905_52963(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundThrowExpression
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 52905, 52963);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 52659, 52975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 52659, 52975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void PromoteAndAddLocals(BoundSpillSequenceBuilder builder, ImmutableArray<LocalSymbol> locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 53419, 54056);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 53547, 54045);
                    foreach (var local in f_10437_53569_53575_I(locals))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 53547, 54045);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 53609, 54030) || true) && (f_10437_53613_53648(f_10437_53613_53634(local)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 53609, 54030);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 53690, 53714);

                            f_10437_53690_53713(builder, local);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 53609, 54030);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10437, 53609, 54030);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 53796, 53899);

                            LocalSymbol
                            longLived = f_10437_53820_53898(local, SynthesizedLocalKind.Spill, f_10437_53888_53897(_F))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 53921, 53961);

                            f_10437_53921_53960(_tempSubstitution, local, longLived);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 53983, 54011);

                            f_10437_53983_54010(builder, longLived);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 53609, 54030);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10437, 53547, 54045);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10437, 1, 499);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10437, 1, 499);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 53419, 54056);

                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10437_53613_53634(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 53613, 53634);
                    return return_v;
                }


                bool
                f_10437_53613_53648(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.IsLongLived();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 53613, 53648);
                    return return_v;
                }


                int
                f_10437_53690_53713(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.AddLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 53690, 53713);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10437_53888_53897(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 53888, 53897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10437_53820_53898(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.WithSynthesizedLocalKindAndSyntax(kind, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 53820, 53898);
                    return return_v;
                }


                int
                f_10437_53921_53960(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 53921, 53960);
                    return 0;
                }


                int
                f_10437_53983_54010(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.AddLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 53983, 54010);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10437_53569_53575_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 53569, 53575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 53419, 54056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 53419, 54056);
            }
        }

        public override BoundNode VisitUnaryOperator(BoundUnaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 54068, 54452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 54162, 54203);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 54217, 54286);

                BoundExpression
                operand = f_10437_54243_54285(this, ref builder, f_10437_54272_54284(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 54300, 54441);

                return f_10437_54307_54440(builder, f_10437_54333_54439(node, f_10437_54345_54362(node), operand, f_10437_54373_54394(node), f_10437_54396_54410(node), f_10437_54412_54427(node), f_10437_54429_54438(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 54068, 54452);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_54272_54284(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 54272, 54284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_54243_54285(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 54243, 54285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10437_54345_54362(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 54345, 54362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10437_54373_54394(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 54373, 54394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10437_54396_54410(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 54396, 54410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10437_54412_54427(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 54412, 54427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_54429_54438(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 54429, 54438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                f_10437_54333_54439(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operatorKind, operand, constantValueOpt, methodOpt, resultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 54333, 54439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_54307_54440(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 54307, 54440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 54068, 54452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 54068, 54452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitReadOnlySpanFromArray(BoundReadOnlySpanFromArray node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 54464, 54812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 54574, 54615);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 54629, 54698);

                BoundExpression
                operand = f_10437_54655_54697(this, ref builder, f_10437_54684_54696(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 54712, 54801);

                return f_10437_54719_54800(builder, f_10437_54745_54799(node, operand, f_10437_54766_54787(node), f_10437_54789_54798(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 54464, 54812);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_54684_54696(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 54684, 54696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_54655_54697(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 54655, 54697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10437_54766_54787(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param)
                {
                    var return_v = this_param.ConversionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 54766, 54787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10437_54789_54798(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 54789, 54798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                f_10437_54745_54799(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                conversionMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand, conversionMethod, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 54745, 54799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_54719_54800(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 54719, 54800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 54464, 54812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 54464, 54812);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSequencePointExpression(BoundSequencePointExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10437, 54824, 55162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 54938, 54979);

                BoundSpillSequenceBuilder
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 54993, 55068);

                BoundExpression
                expression = f_10437_55022_55067(this, ref builder, f_10437_55051_55066(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 55082, 55151);

                return f_10437_55089_55150(builder, f_10437_55115_55149(node, expression, f_10437_55139_55148(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10437, 54824, 55162);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_55051_55066(Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 55051, 55066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_55022_55067(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller
                this_param, ref Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder?
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.VisitExpression(ref builder, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 55022, 55067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10437_55139_55148(Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10437, 55139, 55148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                f_10437_55115_55149(Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.Update(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 55115, 55149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10437_55089_55150(Microsoft.CodeAnalysis.CSharp.SpillSequenceSpiller.BoundSpillSequenceBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                expression)
                {
                    var return_v = UpdateExpression(builder, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 55089, 55150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10437, 54824, 55162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 54824, 55162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SpillSequenceSpiller()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10437, 659, 55191);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10437, 776, 827);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10437, 659, 55191);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10437, 659, 55191);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10437, 659, 55191);

        Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        f_10437_1215_1295(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        topLevelMethod, Microsoft.CodeAnalysis.SyntaxNode
        node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
        compilationState, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory(topLevelMethod, node, compilationState, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10437, 1215, 1295);
            return return_v;
        }

    }
}
