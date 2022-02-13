// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class LocalRewriter
    {
        private abstract class BaseSwitchLocalRewriter : DecisionDagRewriter
        {
            private readonly PooledDictionary<SyntaxNode, ArrayBuilder<BoundStatement>> _switchArms;

            protected override ArrayBuilder<BoundStatement> BuilderForSection(SyntaxNode whenClauseSyntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10481, 1298, 1968);
                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement> result = default(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 1549, 1647);

                    // LAFHIS
                    SyntaxNode?
                    sectionSyntax = (DynAbs.Tracing.TraceSender.Conditional_F1(10481, 1577, 1616) || ((whenClauseSyntax is SwitchLabelSyntax && DynAbs.Tracing.TraceSender.Conditional_F2(10481, 1619, 1627)) || DynAbs.Tracing.TraceSender.Conditional_F3(10481, 1630, 1646))) ? f_10481_1619_1627((SwitchLabelSyntax)whenClauseSyntax) : whenClauseSyntax
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 1665, 1700);

                    f_10481_1665_1699(sectionSyntax is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 1718, 1812);

                    bool
                    found = f_10481_1731_1811(_switchArms, sectionSyntax, out result)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 1830, 1919) || true) && (!found || (DynAbs.Tracing.TraceSender.Expression_False(10481, 1834, 1858) || result == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10481, 1830, 1919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 1881, 1919);

                        throw f_10481_1887_1918();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10481, 1830, 1919);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 1939, 1953);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10481, 1298, 1968);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10481_1619_1627(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10481, 1619, 1627);
                        return return_v;
                    }


                    int
                    f_10481_1665_1699(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 1665, 1699);
                        return 0;
                    }


                    bool
                    f_10481_1731_1811(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 1731, 1811);
                        return return_v;
                    }


                    System.InvalidOperationException
                    f_10481_1887_1918()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 1887, 1918);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10481, 1298, 1968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10481, 1298, 1968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected BaseSwitchLocalRewriter(
                            SyntaxNode node,
                            LocalRewriter localRewriter,
                            ImmutableArray<SyntaxNode> arms,
                            bool generateInstrumentation)
            : base(f_10481_2220_2224_C(node), localRewriter, generateInstrumentation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10481, 1984, 2841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 1195, 1281);
                    this._switchArms = f_10481_1209_1281(); try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 2298, 2826);
                        foreach (var arm in f_10481_2318_2322_I(arms))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10481, 2298, 2826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 2364, 2424);

                            var
                            armBuilder = f_10481_2381_2423()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 2649, 2750) || true) && (f_10481_2653_2676())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10481, 2649, 2750);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 2703, 2750);

                                f_10481_2703_2749(armBuilder, f_10481_2718_2748(_factory));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10481, 2649, 2750);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 2774, 2807);

                            f_10481_2774_2806(
                                                _switchArms, arm, armBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10481, 2298, 2826);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10481, 1, 529);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10481, 1, 529);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10481, 1984, 2841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10481, 1984, 2841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10481, 1984, 2841);
                }
            }

            protected new void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10481, 2857, 2979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 2915, 2934);

                    f_10481_2915_2933(_switchArms);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 2952, 2964);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 10481, 2952, 2963);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10481, 2857, 2979);

                    int
                    f_10481_2915_2933(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 2915, 2933);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10481, 2857, 2979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10481, 2857, 2979);
                }
            }

            protected (ImmutableArray<BoundStatement> loweredDag, ImmutableDictionary<SyntaxNode, ImmutableArray<BoundStatement>> switchSections) LowerDecisionDag(BoundDecisionDag decisionDag)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10481, 3164, 3659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 3377, 3428);

                    var
                    loweredDag = f_10481_3394_3427(this, decisionDag)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 3446, 3552);

                    var
                    switchSections = f_10481_3467_3551(_switchArms, kv => kv.Key, kv => kv.Value.ToImmutableAndFree())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 3570, 3590);

                    f_10481_3570_3589(_switchArms);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10481, 3608, 3644);

                    return (loweredDag, switchSections);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10481, 3164, 3659);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10481_3394_3427(Microsoft.CodeAnalysis.CSharp.LocalRewriter.BaseSwitchLocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    decisionDag)
                    {
                        var return_v = this_param.LowerDecisionDagCore(decisionDag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 3394, 3427);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>>
                    f_10481_3467_3551(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>>
                    source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>>, Microsoft.CodeAnalysis.SyntaxNode>
                    keySelector, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>>
                    elementSelector)
                    {
                        var return_v = source.ToImmutableDictionary<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>>, Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>>(keySelector, elementSelector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 3467, 3551);
                        return return_v;
                    }


                    int
                    f_10481_3570_3589(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 3570, 3589);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10481, 3164, 3659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10481, 3164, 3659);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static BaseSwitchLocalRewriter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10481, 637, 3670);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10481, 637, 3670);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10481, 637, 3670);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10481, 637, 3670);

            Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>>
            f_10481_1209_1281()
            {
                var return_v = PooledDictionary<SyntaxNode, ArrayBuilder<BoundStatement>>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 1209, 1281);
                return return_v;
            }


            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
            f_10481_2381_2423()
            {
                var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 2381, 2423);
                return return_v;
            }


            bool
            f_10481_2653_2676()
            {
                var return_v = GenerateInstrumentation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10481, 2653, 2676);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundStatement
            f_10481_2718_2748(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            this_param)
            {
                var return_v = this_param.HiddenSequencePoint();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 2718, 2748);
                return return_v;
            }


            int
            f_10481_2703_2749(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
            this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
            item)
            {
                this_param.Add(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 2703, 2749);
                return 0;
            }


            int
            f_10481_2774_2806(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>>
            this_param, Microsoft.CodeAnalysis.SyntaxNode
            key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
            value)
            {
                this_param.Add(key, value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 2774, 2806);
                return 0;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
            f_10481_2318_2322_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10481, 2318, 2322);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SyntaxNode
            f_10481_2220_2224_C(Microsoft.CodeAnalysis.SyntaxNode
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10481, 1984, 2841);
                return return_v;
            }

        }
    }
}
