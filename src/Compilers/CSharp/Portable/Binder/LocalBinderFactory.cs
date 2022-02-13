// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class LocalBinderFactory : CSharpSyntaxWalker
    {
        private readonly SmallDictionary<SyntaxNode, Binder> _map;

        private Symbol _containingMemberOrLambda;

        private Binder _enclosing;

        private readonly SyntaxNode _root;

        private void Visit(CSharpSyntaxNode syntax, Binder enclosing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 1685, 2098);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 1771, 2087) || true) && (_enclosing == enclosing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 1771, 2087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 1832, 1851);

                    f_10348_1832_1850(this, syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 1771, 2087);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 1771, 2087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 1917, 1950);

                    Binder
                    oldEnclosing = _enclosing
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 1968, 1991);

                    _enclosing = enclosing;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 2009, 2028);

                    f_10348_2009_2027(this, syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 2046, 2072);

                    _enclosing = oldEnclosing;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 1771, 2087);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 1685, 2098);

                int
                f_10348_1832_1850(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 1832, 1850);
                    return 0;
                }


                int
                f_10348_2009_2027(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 2009, 2027);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 1685, 2098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 1685, 2098);
            }
        }

        private void VisitRankSpecifiers(TypeSyntax type, Binder enclosing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 2110, 2638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 2202, 2627);

                f_10348_2202_2626(type, (rankSpecifier, args) =>
                {
                    foreach (var size in rankSpecifier.Sizes)
                    {
                        if (size.Kind() != SyntaxKind.OmittedArraySizeExpression)
                        {
                            args.localBinderFactory.Visit(size, args.binder);
                        }
                    }
                }, (localBinderFactory: this, binder: enclosing));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 2110, 2638);

                int
                f_10348_2202_2626(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, System.Action<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax, (Microsoft.CodeAnalysis.CSharp.LocalBinderFactory localBinderFactory, Microsoft.CodeAnalysis.CSharp.Binder binder)>
                action, (Microsoft.CodeAnalysis.CSharp.LocalBinderFactory localBinderFactory, Microsoft.CodeAnalysis.CSharp.Binder binder)
                argument)
                {
                    type.VisitRankSpecifiers<(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory localBinderFactory, Microsoft.CodeAnalysis.CSharp.Binder binder)>(action, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 2202, 2626);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 2110, 2638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 2110, 2638);
            }
        }

        public static SmallDictionary<SyntaxNode, Binder> BuildMap(
                    Symbol containingMemberOrLambda,
                    SyntaxNode syntax,
                    Binder enclosing,
                    Action<Binder, SyntaxNode> binderUpdatedHandler = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10348, 3079, 5008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 3341, 3423);

                var
                builder = f_10348_3355_3422(containingMemberOrLambda, syntax, enclosing)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 3439, 3465);

                StatementSyntax
                statement
                = default(StatementSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 3479, 3529);

                var
                expressionSyntax = syntax as ExpressionSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 3543, 4961) || true) && (expressionSyntax != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 3543, 4961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 3605, 3665);

                    enclosing = f_10348_3617_3664(syntax, enclosing);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 3685, 3826) || true) && ((object)binderUpdatedHandler != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 3685, 3826);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 3767, 3807);

                        f_10348_3767_3806(binderUpdatedHandler, enclosing, syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 3685, 3826);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 3846, 3882);

                    f_10348_3846_3881(
                                    builder, syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 3900, 3943);

                    f_10348_3900_3942(builder, expressionSyntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 3543, 4961);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 3543, 4961);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 3977, 4961) || true) && (f_10348_3981_3994(syntax) != SyntaxKind.Block && (DynAbs.Tracing.TraceSender.Expression_True(10348, 3981, 4065) && (statement = syntax as StatementSyntax) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 3977, 4961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 4099, 4140);

                        CSharpSyntaxNode
                        embeddedScopeDesignator
                        = default(CSharpSyntaxNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 4158, 4267);

                        enclosing = f_10348_4170_4266(builder, statement, enclosing, out embeddedScopeDesignator);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 4287, 4445) || true) && ((object)binderUpdatedHandler != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 4287, 4445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 4369, 4426);

                            f_10348_4369_4425(binderUpdatedHandler, enclosing, embeddedScopeDesignator);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 4287, 4445);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 4465, 4614) || true) && (embeddedScopeDesignator != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 4465, 4614);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 4542, 4595);

                            f_10348_4542_4594(builder, embeddedScopeDesignator, enclosing);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 4465, 4614);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 4634, 4670);

                        f_10348_4634_4669(
                                        builder, statement, enclosing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 3977, 4961);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 3977, 4961);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 4736, 4875) || true) && ((object)binderUpdatedHandler != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 4736, 4875);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 4818, 4856);

                            f_10348_4818_4855(binderUpdatedHandler, enclosing, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 4736, 4875);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 4895, 4946);

                        f_10348_4895_4945(
                                        builder, syntax, enclosing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 3977, 4961);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 3543, 4961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 4977, 4997);

                return builder._map;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10348, 3079, 5008);

                Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                f_10348_3355_3422(Microsoft.CodeAnalysis.CSharp.Symbol
                containingMemberOrLambda, Microsoft.CodeAnalysis.SyntaxNode
                root, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LocalBinderFactory(containingMemberOrLambda, root, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 3355, 3422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_3617_3664(Microsoft.CodeAnalysis.SyntaxNode
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder(scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 3617, 3664);
                    return return_v;
                }


                int
                f_10348_3767_3806(System.Action<Microsoft.CodeAnalysis.CSharp.Binder, Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                arg1, Microsoft.CodeAnalysis.SyntaxNode
                arg2)
                {
                    this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 3767, 3806);
                    return 0;
                }


                int
                f_10348_3846_3881(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap(node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 3846, 3881);
                    return 0;
                }


                int
                f_10348_3900_3942(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 3900, 3942);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10348_3981_3994(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 3981, 3994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10348_4170_4266(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, out Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                embeddedScopeDesignator)
                {
                    var return_v = this_param.GetBinderForPossibleEmbeddedStatement(statement, enclosing, out embeddedScopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 4170, 4266);
                    return return_v;
                }


                int
                f_10348_4369_4425(System.Action<Microsoft.CodeAnalysis.CSharp.Binder, Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                arg1, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                arg2)
                {
                    this_param.Invoke(arg1, (Microsoft.CodeAnalysis.SyntaxNode)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 4369, 4425);
                    return 0;
                }


                int
                f_10348_4542_4594(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 4542, 4594);
                    return 0;
                }


                int
                f_10348_4634_4669(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 4634, 4669);
                    return 0;
                }


                int
                f_10348_4818_4855(System.Action<Microsoft.CodeAnalysis.CSharp.Binder, Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                arg1, Microsoft.CodeAnalysis.SyntaxNode
                arg2)
                {
                    this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 4818, 4855);
                    return 0;
                }


                int
                f_10348_4895_4945(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 4895, 4945);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 3079, 5008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 3079, 5008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void VisitCompilationUnit(CompilationUnitSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 5020, 5351);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 5114, 5340);
                    foreach (MemberDeclarationSyntax member in f_10348_5157_5169_I(f_10348_5157_5169(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 5114, 5340);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 5203, 5325) || true) && (f_10348_5207_5220(member) == SyntaxKind.GlobalStatement)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 5203, 5325);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 5292, 5306);

                            f_10348_5292_5305(this, member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 5203, 5325);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 5114, 5340);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 227);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 5020, 5351);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10348_5157_5169(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 5157, 5169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10348_5207_5220(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 5207, 5220);
                    return return_v;
                }


                int
                f_10348_5292_5305(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 5292, 5305);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10348_5157_5169_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 5157, 5169);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 5020, 5351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 5020, 5351);
            }
        }

        private LocalBinderFactory(Symbol containingMemberOrLambda, SyntaxNode root, Binder enclosing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10348, 5363, 5974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 1537, 1541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 1567, 1592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 1618, 1628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 1667, 1672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 5482, 5537);

                f_10348_5482_5536((object)containingMemberOrLambda != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 5551, 5733);

                f_10348_5551_5732(f_10348_5564_5593(containingMemberOrLambda) != SymbolKind.Local && (DynAbs.Tracing.TraceSender.Expression_True(10348, 5564, 5674) && f_10348_5617_5646(containingMemberOrLambda) != SymbolKind.RangeVariable) && (DynAbs.Tracing.TraceSender.Expression_True(10348, 5564, 5731) && f_10348_5678_5707(containingMemberOrLambda) != SymbolKind.Parameter));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 5749, 5832);

                _map = f_10348_5756_5831(ReferenceEqualityComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 5846, 5899);

                _containingMemberOrLambda = containingMemberOrLambda;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 5913, 5936);

                _enclosing = enclosing;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 5950, 5963);

                _root = root;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10348, 5363, 5974);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 5363, 5974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 5363, 5974);
            }
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 6054, 6221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 6152, 6169);

                f_10348_6152_6168(this, f_10348_6158_6167(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 6183, 6210);

                f_10348_6183_6209(this, f_10348_6189_6208(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 6054, 6221);

                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10348_6158_6167(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 6158, 6167);
                    return return_v;
                }


                int
                f_10348_6152_6168(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 6152, 6168);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10348_6189_6208(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 6189, 6208);
                    return return_v;
                }


                int
                f_10348_6183_6209(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 6183, 6209);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 6054, 6221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 6054, 6221);
            }
        }

        public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 6233, 6603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 6341, 6407);

                Binder
                enclosing = f_10348_6360_6406(node, _enclosing)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 6421, 6447);

                f_10348_6421_6446(this, node, enclosing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 6463, 6498);

                f_10348_6463_6497(this, f_10348_6469_6485(node), enclosing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 6512, 6540);

                f_10348_6512_6539(this, f_10348_6518_6527(node), enclosing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 6554, 6592);

                f_10348_6554_6591(this, f_10348_6560_6579(node), enclosing);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 6233, 6603);

                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_6360_6406(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 6360, 6406);
                    return return_v;
                }


                int
                f_10348_6421_6446(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 6421, 6446);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                f_10348_6469_6485(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 6469, 6485);
                    return return_v;
                }


                int
                f_10348_6463_6497(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 6463, 6497);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10348_6518_6527(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 6518, 6527);
                    return return_v;
                }


                int
                f_10348_6512_6539(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 6512, 6539);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10348_6560_6579(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 6560, 6579);
                    return return_v;
                }


                int
                f_10348_6554_6591(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 6554, 6591);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 6233, 6603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 6233, 6603);
            }
        }

        public override void VisitRecordDeclaration(RecordDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 6615, 6953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 6713, 6756);

                f_10348_6713_6755(f_10348_6726_6744(node) is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 6772, 6838);

                Binder
                enclosing = f_10348_6791_6837(node, _enclosing)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 6852, 6878);

                f_10348_6852_6877(this, node, enclosing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 6892, 6942);

                f_10348_6892_6941(this, f_10348_6898_6929(node), enclosing);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 6615, 6953);

                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
                f_10348_6726_6744(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 6726, 6744);
                    return return_v;
                }


                int
                f_10348_6713_6755(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 6713, 6755);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_6791_6837(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 6791, 6837);
                    return return_v;
                }


                int
                f_10348_6852_6877(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 6852, 6877);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax?
                f_10348_6898_6929(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.PrimaryConstructorBaseType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 6898, 6929);
                    return return_v;
                }


                int
                f_10348_6892_6941(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax?
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 6892, 6941);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 6615, 6953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 6615, 6953);
            }
        }

        public override void VisitPrimaryConstructorBaseType(PrimaryConstructorBaseTypeSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 6965, 7308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 7081, 7167);

                Binder
                enclosing = f_10348_7100_7166(_enclosing, BinderFlags.ConstructorInitializer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 7181, 7207);

                f_10348_7181_7206(this, node, enclosing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 7221, 7297);

                f_10348_7221_7296(this, node, f_10348_7267_7284(node), enclosing);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 6965, 7308);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10348_7100_7166(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 7100, 7166);
                    return return_v;
                }


                int
                f_10348_7181_7206(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 7181, 7206);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10348_7267_7284(Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 7267, 7284);
                    return return_v;
                }


                int
                f_10348_7221_7296(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                argumentList, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.VisitConstructorInitializerArgumentList((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, argumentList, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 7221, 7296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 6965, 7308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 6965, 7308);
            }
        }

        public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 7320, 7495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 7426, 7443);

                f_10348_7426_7442(this, f_10348_7432_7441(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 7457, 7484);

                f_10348_7457_7483(this, f_10348_7463_7482(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 7320, 7495);

                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10348_7432_7441(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 7432, 7441);
                    return return_v;
                }


                int
                f_10348_7426_7442(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 7426, 7442);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10348_7463_7482(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 7463, 7482);
                    return return_v;
                }


                int
                f_10348_7457_7483(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 7457, 7483);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 7320, 7495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 7320, 7495);
            }
        }

        public override void VisitAccessorDeclaration(AccessorDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 7507, 7678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 7609, 7626);

                f_10348_7609_7625(this, f_10348_7615_7624(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 7640, 7667);

                f_10348_7640_7666(this, f_10348_7646_7665(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 7507, 7678);

                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10348_7615_7624(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 7615, 7624);
                    return return_v;
                }


                int
                f_10348_7609_7625(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 7609, 7625);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10348_7646_7665(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 7646, 7665);
                    return return_v;
                }


                int
                f_10348_7640_7666(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 7640, 7666);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 7507, 7678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 7507, 7678);
            }
        }

        public override void VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 7690, 7881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 7812, 7829);

                f_10348_7812_7828(this, f_10348_7818_7827(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 7843, 7870);

                f_10348_7843_7869(this, f_10348_7849_7868(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 7690, 7881);

                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10348_7818_7827(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 7818, 7827);
                    return return_v;
                }


                int
                f_10348_7812_7828(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 7812, 7828);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10348_7849_7868(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 7849, 7868);
                    return return_v;
                }


                int
                f_10348_7843_7869(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 7843, 7869);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 7690, 7881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 7690, 7881);
            }
        }

        public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 7893, 8064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 7995, 8012);

                f_10348_7995_8011(this, f_10348_8001_8010(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 8026, 8053);

                f_10348_8026_8052(this, f_10348_8032_8051(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 7893, 8064);

                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10348_8001_8010(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 8001, 8010);
                    return return_v;
                }


                int
                f_10348_7995_8011(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 7995, 8011);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10348_8032_8051(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 8032, 8051);
                    return return_v;
                }


                int
                f_10348_8026_8052(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 8026, 8052);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 7893, 8064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 7893, 8064);
            }
        }

        public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 8076, 8223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 8184, 8212);

                f_10348_8184_8211(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 8076, 8223);

                int
                f_10348_8184_8211(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
                node)
                {
                    this_param.VisitLambdaExpression((Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 8184, 8211);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 8076, 8223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 8076, 8223);
            }
        }

        private void VisitLambdaExpression(LambdaExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 8235, 8860);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 8393, 8466) || true) && (_root != node)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 8393, 8466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 8444, 8451);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 8393, 8466);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 8482, 8516);

                CSharpSyntaxNode
                body = f_10348_8506_8515(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 8530, 8849) || true) && (f_10348_8534_8545(body) == SyntaxKind.Block)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 8530, 8849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 8599, 8629);

                    f_10348_8599_8628(this, body);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 8530, 8849);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 8530, 8849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 8695, 8755);

                    var
                    binder = f_10348_8708_8754(body, _enclosing)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 8773, 8796);

                    f_10348_8773_8795(this, body, binder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 8814, 8834);

                    f_10348_8814_8833(this, body, binder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 8530, 8849);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 8235, 8860);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10348_8506_8515(Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 8506, 8515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10348_8534_8545(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 8534, 8545);
                    return return_v;
                }


                int
                f_10348_8599_8628(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    this_param.VisitBlock((Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 8599, 8628);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_8708_8754(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 8708, 8754);
                    return return_v;
                }


                int
                f_10348_8773_8795(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 8773, 8795);
                    return 0;
                }


                int
                f_10348_8814_8833(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                enclosing)
                {
                    this_param.Visit(syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 8814, 8833);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 8235, 8860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 8235, 8860);
            }
        }

        public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 8872, 9033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 8994, 9022);

                f_10348_8994_9021(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 8872, 9033);

                int
                f_10348_8994_9021(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
                node)
                {
                    this_param.VisitLambdaExpression((Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 8994, 9021);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 8872, 9033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 8872, 9033);
            }
        }

        public override void VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 9045, 10153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9153, 9198);

                Symbol
                oldMethod = _containingMemberOrLambda
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9212, 9239);

                Binder
                binder = _enclosing
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9253, 9317);

                LocalFunctionSymbol
                match = f_10348_9281_9316(node, _enclosing)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9333, 9744) || true) && ((object)match != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 9333, 9744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9392, 9426);

                    _containingMemberOrLambda = match;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9446, 9588);

                    binder = (DynAbs.Tracing.TraceSender.Conditional_F1(10348, 9455, 9476) || ((f_10348_9455_9476(match) && DynAbs.Tracing.TraceSender.Conditional_F2(10348, 9500, 9553)) || DynAbs.Tracing.TraceSender.Conditional_F3(10348, 9577, 9587))) ? f_10348_9500_9553(match, _enclosing) : _enclosing;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9608, 9668);

                    binder = f_10348_9617_9667(binder, f_10348_9652_9666(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9686, 9729);

                    binder = f_10348_9695_9728(match, binder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 9333, 9744);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9760, 9794);

                BlockSyntax
                blockBody = f_10348_9784_9793(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9808, 9903) || true) && (blockBody != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 9808, 9903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9863, 9888);

                    f_10348_9863_9887(this, blockBody, binder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 9808, 9903);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9919, 9979);

                ArrowExpressionClauseSyntax
                arrowBody = f_10348_9959_9978(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 9993, 10088) || true) && (arrowBody != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 9993, 10088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 10048, 10073);

                    f_10348_10048_10072(this, arrowBody, binder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 9993, 10088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 10104, 10142);

                _containingMemberOrLambda = oldMethod;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 9045, 10153);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10348_9281_9316(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    var return_v = FindLocalFunction(node, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 9281, 9316);
                    return return_v;
                }


                bool
                f_10348_9455_9476(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 9455, 9476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.WithMethodTypeParametersBinder
                f_10348_9500_9553(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                methodSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.WithMethodTypeParametersBinder((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)methodSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 9500, 9553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10348_9652_9666(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 9652, 9666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10348_9617_9667(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers)
                {
                    var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 9617, 9667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InMethodBinder
                f_10348_9695_9728(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.InMethodBinder((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)owner, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 9695, 9728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10348_9784_9793(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 9784, 9793);
                    return return_v;
                }


                int
                f_10348_9863_9887(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 9863, 9887);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10348_9959_9978(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 9959, 9978);
                    return return_v;
                }


                int
                f_10348_10048_10072(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 10048, 10072);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 9045, 10153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 9045, 10153);
            }
        }

        private static LocalFunctionSymbol FindLocalFunction(LocalFunctionStatementSyntax node, Binder enclosing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10348, 10165, 11154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 10295, 10328);

                LocalFunctionSymbol
                match = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 10512, 10551);

                Binder
                possibleScopeBinder = enclosing
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 10565, 10747) || true) && (possibleScopeBinder != null && (DynAbs.Tracing.TraceSender.Expression_True(10348, 10572, 10651) && f_10348_10603_10651_M(!possibleScopeBinder.IsLocalFunctionsScopeBinder)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 10565, 10747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 10685, 10732);

                        possibleScopeBinder = f_10348_10707_10731(possibleScopeBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 10565, 10747);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 10565, 10747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 10565, 10747);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 10763, 11114) || true) && (possibleScopeBinder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 10763, 11114);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 10828, 11099);
                        foreach (var candidate in f_10348_10854_10888_I(f_10348_10854_10888(possibleScopeBinder)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 10828, 11099);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 10930, 11080) || true) && (f_10348_10934_10953(candidate)[0] == node.Identifier.GetLocation())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 10930, 11080);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 11039, 11057);

                                match = candidate;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 10930, 11080);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 10828, 11099);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 272);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 272);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 10763, 11114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 11130, 11143);

                return match;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10348, 10165, 11154);

                bool
                f_10348_10603_10651_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 10603, 10651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10348_10707_10731(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 10707, 10731);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10348_10854_10888(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 10854, 10888);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10348_10934_10953(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 10934, 10953);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10348_10854_10888_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 10854, 10888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 10165, 11154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 10165, 11154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void VisitArrowExpressionClause(ArrowExpressionClauseSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 11166, 11440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 11272, 11337);

                var
                arrowBinder = f_10348_11290_11336(node, _enclosing)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 11351, 11379);

                f_10348_11351_11378(this, node, arrowBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 11393, 11429);

                f_10348_11393_11428(this, f_10348_11399_11414(node), arrowBinder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 11166, 11440);

                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_11290_11336(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 11290, 11336);
                    return return_v;
                }


                int
                f_10348_11351_11378(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 11351, 11378);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_11399_11414(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 11399, 11414);
                    return return_v;
                }


                int
                f_10348_11393_11428(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 11393, 11428);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 11166, 11440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 11166, 11440);
            }
        }

        public override void VisitEqualsValueClause(EqualsValueClauseSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 11452, 11713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 11550, 11615);

                var
                valueBinder = f_10348_11568_11614(node, _enclosing)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 11629, 11657);

                f_10348_11629_11656(this, node, valueBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 11671, 11702);

                f_10348_11671_11701(this, f_10348_11677_11687(node), valueBinder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 11452, 11713);

                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_11568_11614(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 11568, 11614);
                    return return_v;
                }


                int
                f_10348_11629_11656(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 11629, 11656);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_11677_11687(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 11677, 11687);
                    return return_v;
                }


                int
                f_10348_11671_11701(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 11671, 11701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 11452, 11713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 11452, 11713);
            }
        }

        public override void VisitAttribute(AttributeSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 11725, 12202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 11807, 11871);

                var
                attrBinder = f_10348_11824_11870(node, _enclosing)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 11885, 11912);

                f_10348_11885_11911(this, node, attrBinder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 11928, 12191) || true) && (f_10348_11932_11966_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10348_11932_11949(node), 10348, 11932, 11966)?.Arguments.Count) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 11928, 12191);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 12004, 12176);
                        foreach (AttributeArgumentSyntax argument in f_10348_12049_12076_I(f_10348_12049_12076(f_10348_12049_12066(node))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 12004, 12176);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 12118, 12157);

                            f_10348_12118_12156(this, f_10348_12124_12143(argument), attrBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 12004, 12176);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 173);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 173);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 11928, 12191);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 11725, 12202);

                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_11824_11870(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 11824, 11870);
                    return return_v;
                }


                int
                f_10348_11885_11911(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 11885, 11911);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                f_10348_11932_11949(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 11932, 11949);
                    return return_v;
                }


                int?
                f_10348_11932_11966_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 11932, 11966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                f_10348_12049_12066(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 12049, 12066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10348_12049_12076(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 12049, 12076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_12124_12143(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 12124, 12143);
                    return return_v;
                }


                int
                f_10348_12118_12156(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 12118, 12156);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10348_12049_12076_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 12049, 12076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 11725, 12202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 11725, 12202);
            }
        }

        public override void VisitConstructorInitializer(ConstructorInitializerSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 12214, 12537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 12322, 12402);

                var
                binder = f_10348_12335_12401(_enclosing, BinderFlags.ConstructorInitializer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 12416, 12439);

                f_10348_12416_12438(this, node, binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 12453, 12526);

                f_10348_12453_12525(this, node, f_10348_12499_12516(node), binder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 12214, 12537);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10348_12335_12401(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 12335, 12401);
                    return return_v;
                }


                int
                f_10348_12416_12438(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 12416, 12438);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10348_12499_12516(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 12499, 12516);
                    return return_v;
                }


                int
                f_10348_12453_12525(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                argumentList, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.VisitConstructorInitializerArgumentList((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, argumentList, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 12453, 12525);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 12214, 12537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 12214, 12537);
            }
        }

        private void VisitConstructorInitializerArgumentList(CSharpSyntaxNode node, ArgumentListSyntax argumentList, Binder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 12549, 13020);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 12697, 13009) || true) && (argumentList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 12697, 13009);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 12755, 12946) || true) && (_root == node)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 12755, 12946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 12814, 12874);

                        binder = f_10348_12823_12873(argumentList, binder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 12896, 12927);

                        f_10348_12896_12926(this, argumentList, binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 12755, 12946);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 12966, 12994);

                    f_10348_12966_12993(this, argumentList, binder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 12697, 13009);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 12549, 13020);

                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_12823_12873(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 12823, 12873);
                    return return_v;
                }


                int
                f_10348_12896_12926(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 12896, 12926);
                    return 0;
                }


                int
                f_10348_12966_12993(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 12966, 12993);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 12549, 13020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 12549, 13020);
            }
        }

        public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 13032, 13339);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 13216, 13289) || true) && (_root != node)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 13216, 13289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 13267, 13274);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 13216, 13289);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 13305, 13328);

                f_10348_13305_13327(this, f_10348_13316_13326(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 13032, 13339);

                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10348_13316_13326(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 13316, 13326);
                    return return_v;
                }


                int
                f_10348_13305_13327(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                node)
                {
                    this_param.VisitBlock(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 13305, 13327);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 13032, 13339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 13032, 13339);
            }
        }

        public override void VisitGlobalStatement(GlobalStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 13351, 13478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 13445, 13467);

                f_10348_13445_13466(this, f_10348_13451_13465(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 13351, 13478);

                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10348_13451_13465(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 13451, 13465);
                    return return_v;
                }


                int
                f_10348_13445_13466(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 13445, 13466);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 13351, 13478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 13351, 13478);
            }
        }

        public override void VisitBlock(BlockSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 13639, 14126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 13713, 13800);

                f_10348_13713_13799((object)_containingMemberOrLambda == f_10348_13763_13798(_enclosing));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 13814, 13866);

                var
                blockBinder = f_10348_13832_13865(_enclosing, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 13880, 13908);

                f_10348_13880_13907(this, node, blockBinder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 13983, 14115);
                    foreach (StatementSyntax statement in f_10348_14021_14036_I(f_10348_14021_14036(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 13983, 14115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 14070, 14100);

                        f_10348_14070_14099(this, statement, blockBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 13983, 14115);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 133);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 13639, 14126);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10348_13763_13798(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 13763, 13798);
                    return return_v;
                }


                int
                f_10348_13713_13799(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 13713, 13799);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BlockBinder
                f_10348_13832_13865(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                block)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BlockBinder(enclosing, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 13832, 13865);
                    return return_v;
                }


                int
                f_10348_13880_13907(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                node, Microsoft.CodeAnalysis.CSharp.BlockBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 13880, 13907);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10348_14021_14036(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 14021, 14036);
                    return return_v;
                }


                int
                f_10348_14070_14099(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BlockBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 14070, 14099);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10348_14021_14036_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 14021, 14036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 13639, 14126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 13639, 14126);
            }
        }

        public override void VisitUsingStatement(UsingStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 14138, 15224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 14230, 14317);

                f_10348_14230_14316((object)_containingMemberOrLambda == f_10348_14280_14315(_enclosing));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 14331, 14392);

                var
                usingBinder = f_10348_14349_14391(_enclosing, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 14406, 14434);

                f_10348_14406_14433(this, node, usingBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 14450, 14502);

                ExpressionSyntax
                expressionSyntax = f_10348_14486_14501(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 14516, 14579);

                VariableDeclarationSyntax
                declarationSyntax = f_10348_14562_14578(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 14595, 14666);

                f_10348_14595_14665((expressionSyntax == null) ^ (declarationSyntax == null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 14713, 15137) || true) && (expressionSyntax != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 14713, 15137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 14775, 14812);

                    f_10348_14775_14811(this, expressionSyntax, usingBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 14713, 15137);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 14713, 15137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 14878, 14935);

                    f_10348_14878_14934(this, f_10348_14898_14920(declarationSyntax), usingBinder);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 14955, 15122);
                        foreach (VariableDeclaratorSyntax declarator in f_10348_15003_15030_I(f_10348_15003_15030(declarationSyntax)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 14955, 15122);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 15072, 15103);

                            f_10348_15072_15102(this, declarator, usingBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 14955, 15122);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 168);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 168);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 14713, 15137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 15153, 15213);

                f_10348_15153_15212(this, f_10348_15184_15198(node), usingBinder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 14138, 15224);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10348_14280_14315(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 14280, 14315);
                    return return_v;
                }


                int
                f_10348_14230_14316(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 14230, 14316);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                f_10348_14349_14391(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UsingStatementBinder(enclosing, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 14349, 14391);
                    return return_v;
                }


                int
                f_10348_14406_14433(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 14406, 14433);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10348_14486_14501(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 14486, 14501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax?
                f_10348_14562_14578(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 14562, 14578);
                    return return_v;
                }


                int
                f_10348_14595_14665(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 14595, 14665);
                    return 0;
                }


                int
                f_10348_14775_14811(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 14775, 14811);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10348_14898_14920(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 14898, 14920);
                    return return_v;
                }


                int
                f_10348_14878_14934(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                enclosing)
                {
                    this_param.VisitRankSpecifiers(type, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 14878, 14934);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10348_15003_15030(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 15003, 15030);
                    return return_v;
                }


                int
                f_10348_15072_15102(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15072, 15102);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10348_15003_15030_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15003, 15030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10348_15184_15198(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 15184, 15198);
                    return return_v;
                }


                int
                f_10348_15153_15212(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                enclosing)
                {
                    this_param.VisitPossibleEmbeddedStatement(statement, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15153, 15212);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 14138, 15224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 14138, 15224);
            }
        }

        public override void VisitWhileStatement(WhileStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 15236, 15659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 15328, 15415);

                f_10348_15328_15414((object)_containingMemberOrLambda == f_10348_15378_15413(_enclosing));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 15429, 15481);

                var
                whileBinder = f_10348_15447_15480(_enclosing, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 15495, 15523);

                f_10348_15495_15522(this, node, whileBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 15539, 15574);

                f_10348_15539_15573(this, f_10348_15545_15559(node), whileBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 15588, 15648);

                f_10348_15588_15647(this, f_10348_15619_15633(node), whileBinder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 15236, 15659);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10348_15378_15413(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 15378, 15413);
                    return return_v;
                }


                int
                f_10348_15328_15414(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15328, 15414);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.WhileBinder
                f_10348_15447_15480(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.WhileBinder(enclosing, (Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15447, 15480);
                    return return_v;
                }


                int
                f_10348_15495_15522(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.WhileBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15495, 15522);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_15545_15559(Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 15545, 15559);
                    return return_v;
                }


                int
                f_10348_15539_15573(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.WhileBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15539, 15573);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10348_15619_15633(Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 15619, 15633);
                    return return_v;
                }


                int
                f_10348_15588_15647(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.CSharp.WhileBinder
                enclosing)
                {
                    this_param.VisitPossibleEmbeddedStatement(statement, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15588, 15647);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 15236, 15659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 15236, 15659);
            }
        }

        public override void VisitDoStatement(DoStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 15671, 16088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 15757, 15844);

                f_10348_15757_15843((object)_containingMemberOrLambda == f_10348_15807_15842(_enclosing));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 15858, 15910);

                var
                whileBinder = f_10348_15876_15909(_enclosing, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 15924, 15952);

                f_10348_15924_15951(this, node, whileBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 15968, 16003);

                f_10348_15968_16002(this, f_10348_15974_15988(node), whileBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16017, 16077);

                f_10348_16017_16076(this, f_10348_16048_16062(node), whileBinder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 15671, 16088);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10348_15807_15842(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 15807, 15842);
                    return return_v;
                }


                int
                f_10348_15757_15843(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15757, 15843);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.WhileBinder
                f_10348_15876_15909(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.WhileBinder(enclosing, (Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15876, 15909);
                    return return_v;
                }


                int
                f_10348_15924_15951(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.WhileBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15924, 15951);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_15974_15988(Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 15974, 15988);
                    return return_v;
                }


                int
                f_10348_15968_16002(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.WhileBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 15968, 16002);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10348_16048_16062(Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 16048, 16062);
                    return return_v;
                }


                int
                f_10348_16017_16076(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.CSharp.WhileBinder
                enclosing)
                {
                    this_param.VisitPossibleEmbeddedStatement(statement, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 16017, 16076);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 15671, 16088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 15671, 16088);
            }
        }

        public override void VisitForStatement(ForStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 16100, 17835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16188, 16275);

                f_10348_16188_16274((object)_containingMemberOrLambda == f_10348_16238_16273(_enclosing));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16289, 16341);

                Binder
                binder = f_10348_16305_16340(_enclosing, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16355, 16378);

                f_10348_16355_16377(this, node, binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16394, 16451);

                VariableDeclarationSyntax
                declaration = f_10348_16434_16450(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16465, 16967) || true) && (declaration != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 16465, 16967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16522, 16568);

                    f_10348_16522_16567(this, f_10348_16542_16558(declaration), binder);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16588, 16740);
                        foreach (VariableDeclaratorSyntax variable in f_10348_16634_16655_I(f_10348_16634_16655(declaration)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 16588, 16740);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16697, 16721);

                            f_10348_16697_16720(this, variable, binder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 16588, 16740);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 153);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 153);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 16465, 16967);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 16465, 16967);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16806, 16952);
                        foreach (ExpressionSyntax initializer in f_10348_16847_16864_I(f_10348_16847_16864(node)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 16806, 16952);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16906, 16933);

                            f_10348_16906_16932(this, initializer, binder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 16806, 16952);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 147);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 147);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 16465, 16967);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 16983, 17027);

                ExpressionSyntax
                condition = f_10348_17012_17026(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17041, 17257) || true) && (condition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 17041, 17257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17096, 17153);

                    binder = f_10348_17105_17152(condition, binder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17171, 17199);

                    f_10348_17171_17198(this, condition, binder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17217, 17242);

                    f_10348_17217_17241(this, condition, binder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 17041, 17257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17273, 17344);

                SeparatedSyntaxList<ExpressionSyntax>
                incrementors = f_10348_17326_17343(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17358, 17753) || true) && (incrementors.Count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 17358, 17753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17418, 17498);

                    var
                    incrementorsBinder = f_10348_17443_17497(incrementors, binder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17516, 17567);

                    f_10348_17516_17566(this, incrementors.First(), incrementorsBinder);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17585, 17738);
                        foreach (ExpressionSyntax incrementor in f_10348_17626_17638_I(incrementors))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 17585, 17738);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17680, 17719);

                            f_10348_17680_17718(this, incrementor, incrementorsBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 17585, 17738);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 154);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 154);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 17358, 17753);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17769, 17824);

                f_10348_17769_17823(this, f_10348_17800_17814(node), binder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 16100, 17835);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10348_16238_16273(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 16238, 16273);
                    return return_v;
                }


                int
                f_10348_16188_16274(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 16188, 16274);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ForLoopBinder
                f_10348_16305_16340(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ForLoopBinder(enclosing, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 16305, 16340);
                    return return_v;
                }


                int
                f_10348_16355_16377(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 16355, 16377);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax?
                f_10348_16434_16450(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 16434, 16450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10348_16542_16558(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 16542, 16558);
                    return return_v;
                }


                int
                f_10348_16522_16567(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.VisitRankSpecifiers(type, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 16522, 16567);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10348_16634_16655(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 16634, 16655);
                    return return_v;
                }


                int
                f_10348_16697_16720(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 16697, 16720);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10348_16634_16655_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 16634, 16655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10348_16847_16864(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 16847, 16864);
                    return return_v;
                }


                int
                f_10348_16906_16932(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 16906, 16932);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10348_16847_16864_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 16847, 16864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10348_17012_17026(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 17012, 17026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_17105_17152(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 17105, 17152);
                    return return_v;
                }


                int
                f_10348_17171_17198(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 17171, 17198);
                    return 0;
                }


                int
                f_10348_17217_17241(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 17217, 17241);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10348_17326_17343(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Incrementors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 17326, 17343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExpressionListVariableBinder
                f_10348_17443_17497(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                expressions, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionListVariableBinder(expressions, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 17443, 17497);
                    return return_v;
                }


                int
                f_10348_17516_17566(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.ExpressionListVariableBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 17516, 17566);
                    return 0;
                }


                int
                f_10348_17680_17718(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ExpressionListVariableBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 17680, 17718);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10348_17626_17638_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 17626, 17638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10348_17800_17814(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 17800, 17814);
                    return return_v;
                }


                int
                f_10348_17769_17823(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.VisitPossibleEmbeddedStatement(statement, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 17769, 17823);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 16100, 17835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 16100, 17835);
            }
        }

        private void VisitCommonForEachStatement(CommonForEachStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 17847, 18426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 17947, 18034);

                f_10348_17947_18033((object)_containingMemberOrLambda == f_10348_17997_18032(_enclosing));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 18048, 18126);

                var
                patternBinder = f_10348_18068_18125(f_10348_18097_18112(node), _enclosing)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 18142, 18183);

                f_10348_18142_18182(this, f_10348_18151_18166(node), patternBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 18197, 18235);

                f_10348_18197_18234(this, f_10348_18203_18218(node), patternBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 18251, 18307);

                var
                binder = f_10348_18264_18306(patternBinder, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 18321, 18344);

                f_10348_18321_18343(this, node, binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 18360, 18415);

                f_10348_18360_18414(this, f_10348_18391_18405(node), binder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 17847, 18426);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10348_17997_18032(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 17997, 18032);
                    return return_v;
                }


                int
                f_10348_17947_18033(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 17947, 18033);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_18097_18112(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 18097, 18112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_18068_18125(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 18068, 18125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_18151_18166(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 18151, 18166);
                    return return_v;
                }


                int
                f_10348_18142_18182(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 18142, 18182);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_18203_18218(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 18203, 18218);
                    return return_v;
                }


                int
                f_10348_18197_18234(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 18197, 18234);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                f_10348_18264_18306(Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                enclosing, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder((Microsoft.CodeAnalysis.CSharp.Binder)enclosing, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 18264, 18306);
                    return return_v;
                }


                int
                f_10348_18321_18343(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 18321, 18343);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10348_18391_18405(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 18391, 18405);
                    return return_v;
                }


                int
                f_10348_18360_18414(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.CSharp.ForEachLoopBinder
                enclosing)
                {
                    this_param.VisitPossibleEmbeddedStatement(statement, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 18360, 18414);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 17847, 18426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 17847, 18426);
            }
        }

        public override void VisitForEachStatement(ForEachStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 18438, 18579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 18534, 18568);

                f_10348_18534_18567(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 18438, 18579);

                int
                f_10348_18534_18567(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                node)
                {
                    this_param.VisitCommonForEachStatement((Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 18534, 18567);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 18438, 18579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 18438, 18579);
            }
        }

        public override void VisitForEachVariableStatement(ForEachVariableStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 18591, 18748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 18703, 18737);

                f_10348_18703_18736(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 18591, 18748);

                int
                f_10348_18703_18736(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                node)
                {
                    this_param.VisitCommonForEachStatement((Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 18703, 18736);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 18591, 18748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 18591, 18748);
            }
        }

        public override void VisitCheckedStatement(CheckedStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 18760, 19056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 18856, 18966);

                Binder
                binder = f_10348_18872_18965(_enclosing, @checked: f_10348_18922_18933(node) == SyntaxKind.CheckedStatement)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 18980, 19003);

                f_10348_18980_19002(this, node, binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 19019, 19045);

                f_10348_19019_19044(this, f_10348_19025_19035(node), binder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 18760, 19056);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10348_18922_18933(Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 18922, 18933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10348_18872_18965(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, bool
                @checked)
                {
                    var return_v = this_param.WithCheckedOrUncheckedRegion(@checked: @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 18872, 18965);
                    return return_v;
                }


                int
                f_10348_18980_19002(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 18980, 19002);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10348_19025_19035(Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 19025, 19035);
                    return return_v;
                }


                int
                f_10348_19019_19044(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 19019, 19044);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 18760, 19056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 18760, 19056);
            }
        }

        public override void VisitUnsafeStatement(UnsafeStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 19068, 19377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 19162, 19235);

                Binder
                binder = f_10348_19178_19234(_enclosing, BinderFlags.UnsafeRegion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 19249, 19272);

                f_10348_19249_19271(this, node, binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 19288, 19314);

                f_10348_19288_19313(this, f_10348_19294_19304(node), binder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 19068, 19377);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10348_19178_19234(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 19178, 19234);
                    return return_v;
                }


                int
                f_10348_19249_19271(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 19249, 19271);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10348_19294_19304(Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 19294, 19304);
                    return return_v;
                }


                int
                f_10348_19288_19313(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 19288, 19313);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 19068, 19377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 19068, 19377);
            }
        }

        public override void VisitFixedStatement(FixedStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 19389, 20082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 19481, 19568);

                f_10348_19481_19567((object)_containingMemberOrLambda == f_10348_19531_19566(_enclosing));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 19582, 19638);

                var
                binder = f_10348_19595_19637(_enclosing, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 19652, 19675);

                f_10348_19652_19674(this, node, binder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 19691, 20000) || true) && (f_10348_19695_19711(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 19691, 20000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 19753, 19804);

                    f_10348_19753_19803(this, f_10348_19773_19794(f_10348_19773_19789(node)), binder);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 19824, 19985);
                        foreach (VariableDeclaratorSyntax declarator in f_10348_19872_19898_I(f_10348_19872_19898(f_10348_19872_19888(node))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 19824, 19985);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 19940, 19966);

                            f_10348_19940_19965(this, declarator, binder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 19824, 19985);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 162);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 162);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 19691, 20000);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20016, 20071);

                f_10348_20016_20070(this, f_10348_20047_20061(node), binder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 19389, 20082);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10348_19531_19566(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 19531, 19566);
                    return return_v;
                }


                int
                f_10348_19481_19567(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 19481, 19567);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.FixedStatementBinder
                f_10348_19595_19637(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.FixedStatementBinder(enclosing, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 19595, 19637);
                    return return_v;
                }


                int
                f_10348_19652_19674(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.FixedStatementBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 19652, 19674);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10348_19695_19711(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 19695, 19711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10348_19773_19789(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 19773, 19789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10348_19773_19794(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 19773, 19794);
                    return return_v;
                }


                int
                f_10348_19753_19803(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.FixedStatementBinder
                enclosing)
                {
                    this_param.VisitRankSpecifiers(type, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 19753, 19803);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10348_19872_19888(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 19872, 19888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10348_19872_19898(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 19872, 19898);
                    return return_v;
                }


                int
                f_10348_19940_19965(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.FixedStatementBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 19940, 19965);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10348_19872_19898_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 19872, 19898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10348_20047_20061(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 20047, 20061);
                    return return_v;
                }


                int
                f_10348_20016_20070(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.CSharp.FixedStatementBinder
                enclosing)
                {
                    this_param.VisitPossibleEmbeddedStatement(statement, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 20016, 20070);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 19389, 20082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 19389, 20082);
            }
        }

        public override void VisitLockStatement(LockStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 20094, 20698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20184, 20234);

                var
                lockBinder = f_10348_20201_20233(_enclosing, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20248, 20275);

                f_10348_20248_20274(this, node, lockBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20291, 20326);

                f_10348_20291_20325(this, f_10348_20297_20312(node), lockBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20342, 20385);

                StatementSyntax
                statement = f_10348_20370_20384(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20399, 20479);

                Binder
                statementBinder = f_10348_20424_20478(lockBinder, BinderFlags.InLockBody)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20493, 20612) || true) && (statementBinder != lockBinder)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 20493, 20612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20560, 20597);

                    f_10348_20560_20596(this, statement, statementBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 20493, 20612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20628, 20687);

                f_10348_20628_20686(this, statement, statementBinder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 20094, 20698);

                Microsoft.CodeAnalysis.CSharp.LockBinder
                f_10348_20201_20233(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LockBinder(enclosing, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 20201, 20233);
                    return return_v;
                }


                int
                f_10348_20248_20274(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.LockBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 20248, 20274);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_20297_20312(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 20297, 20312);
                    return return_v;
                }


                int
                f_10348_20291_20325(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.LockBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 20291, 20325);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10348_20370_20384(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 20370, 20384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10348_20424_20478(Microsoft.CodeAnalysis.CSharp.LockBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 20424, 20478);
                    return return_v;
                }


                int
                f_10348_20560_20596(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 20560, 20596);
                    return 0;
                }


                int
                f_10348_20628_20686(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.VisitPossibleEmbeddedStatement(statement, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 20628, 20686);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 20094, 20698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 20094, 20698);
            }
        }

        public override void VisitSwitchStatement(SwitchStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 20710, 21266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20804, 20891);

                f_10348_20804_20890((object)_containingMemberOrLambda == f_10348_20854_20889(_enclosing));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20905, 20943);

                f_10348_20905_20942(this, f_10348_20914_20929(node), _enclosing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 20957, 20992);

                f_10348_20957_20991(this, f_10348_20963_20978(node), _enclosing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21008, 21065);

                var
                switchBinder = f_10348_21027_21064(_enclosing, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21079, 21108);

                f_10348_21079_21107(this, node, switchBinder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21124, 21255);
                    foreach (SwitchSectionSyntax section in f_10348_21164_21177_I(f_10348_21164_21177(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 21124, 21255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21211, 21240);

                        f_10348_21211_21239(this, section, switchBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 21124, 21255);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 20710, 21266);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10348_20854_20889(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 20854, 20889);
                    return return_v;
                }


                int
                f_10348_20804_20890(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 20804, 20890);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_20914_20929(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 20914, 20929);
                    return return_v;
                }


                int
                f_10348_20905_20942(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 20905, 20942);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_20963_20978(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 20963, 20978);
                    return return_v;
                }


                int
                f_10348_20957_20991(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 20957, 20991);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SwitchBinder
                f_10348_21027_21064(Microsoft.CodeAnalysis.CSharp.Binder
                next, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                switchSyntax)
                {
                    var return_v = SwitchBinder.Create(next, switchSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 21027, 21064);
                    return return_v;
                }


                int
                f_10348_21079_21107(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.SwitchBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 21079, 21107);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10348_21164_21177(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Sections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 21164, 21177);
                    return return_v;
                }


                int
                f_10348_21211_21239(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.SwitchBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 21211, 21239);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10348_21164_21177_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 21164, 21177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 20710, 21266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 20710, 21266);
            }
        }

        public override void VisitSwitchSection(SwitchSectionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 21278, 22625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21368, 21435);

                var
                patternBinder = f_10348_21388_21434(node, _enclosing)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21449, 21479);

                f_10348_21449_21478(this, node, patternBinder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21495, 22464);
                    foreach (SwitchLabelSyntax label in f_10348_21531_21542_I(f_10348_21531_21542(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 21495, 22464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21576, 22449);

                        switch (f_10348_21584_21596(label))
                        {

                            case SyntaxKind.CasePatternSwitchLabel:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 21576, 22449);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21734, 21788);

                                    var
                                    switchLabel = (CasePatternSwitchLabelSyntax)label
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21818, 21860);

                                    f_10348_21818_21859(this, f_10348_21824_21843(switchLabel), patternBinder);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21890, 22076) || true) && (f_10348_21894_21916(switchLabel) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 21890, 22076);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 21990, 22045);

                                        f_10348_21990_22044(this, f_10348_21996_22028(f_10348_21996_22018(switchLabel)), patternBinder);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 21890, 22076);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10348, 22106, 22112);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 21576, 22449);

                            case SyntaxKind.CaseSwitchLabel:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 21576, 22449);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 22250, 22297);

                                    var
                                    switchLabel = (CaseSwitchLabelSyntax)label
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 22327, 22367);

                                    f_10348_22327_22366(this, f_10348_22333_22350(switchLabel), patternBinder);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10348, 22397, 22403);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 21576, 22449);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 21495, 22464);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 970);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 970);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 22480, 22614);
                    foreach (StatementSyntax statement in f_10348_22518_22533_I(f_10348_22518_22533(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 22480, 22614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 22567, 22599);

                        f_10348_22567_22598(this, statement, patternBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 22480, 22614);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 135);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 21278, 22625);

                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_21388_21434(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 21388, 21434);
                    return return_v;
                }


                int
                f_10348_21449_21478(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                node, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 21449, 21478);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                f_10348_21531_21542(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                this_param)
                {
                    var return_v = this_param.Labels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 21531, 21542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10348_21584_21596(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 21584, 21596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10348_21824_21843(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 21824, 21843);
                    return return_v;
                }


                int
                f_10348_21818_21859(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 21818, 21859);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax?
                f_10348_21894_21916(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 21894, 21916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                f_10348_21996_22018(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 21996, 22018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_21996_22028(Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 21996, 22028);
                    return return_v;
                }


                int
                f_10348_21990_22044(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 21990, 22044);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_22333_22350(Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 22333, 22350);
                    return return_v;
                }


                int
                f_10348_22327_22366(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 22327, 22366);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                f_10348_21531_21542_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 21531, 21542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10348_22518_22533(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 22518, 22533);
                    return return_v;
                }


                int
                f_10348_22567_22598(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 22567, 22598);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10348_22518_22533_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 22518, 22533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 21278, 22625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 21278, 22625);
            }
        }

        public override void VisitSwitchExpression(SwitchExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 22637, 23525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 22733, 22807);

                var
                switchExpressionBinder = f_10348_22762_22806(node, _enclosing)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 22821, 22860);

                f_10348_22821_22859(this, node, switchExpressionBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 22874, 22930);

                f_10348_22874_22929(this, f_10348_22880_22904(node), switchExpressionBinder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 22944, 23514);
                    foreach (SwitchExpressionArmSyntax arm in f_10348_22986_22995_I(f_10348_22986_22995(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 22944, 23514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 23029, 23108);

                        var
                        armScopeBinder = f_10348_23050_23107(arm, switchExpressionBinder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 23126, 23217);

                        var
                        armBinder = f_10348_23142_23216(arm, armScopeBinder, switchExpressionBinder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 23235, 23260);

                        f_10348_23235_23259(this, arm, armBinder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 23278, 23308);

                        f_10348_23278_23307(this, f_10348_23284_23295(arm), armBinder);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 23326, 23446) || true) && (f_10348_23330_23344(arm) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 23326, 23446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 23394, 23427);

                            f_10348_23394_23426(this, f_10348_23400_23414(arm), armBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 23326, 23446);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 23466, 23499);

                        f_10348_23466_23498(this, f_10348_23472_23486(arm), armBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 22944, 23514);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 571);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 22637, 23525);

                Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                f_10348_22762_22806(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                switchExpressionSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder(switchExpressionSyntax, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 22762, 22806);
                    return return_v;
                }


                int
                f_10348_22821_22859(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 22821, 22859);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_22880_22904(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                this_param)
                {
                    var return_v = this_param.GoverningExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 22880, 22904);
                    return return_v;
                }


                int
                f_10348_22874_22929(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 22874, 22929);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax>
                f_10348_22986_22995(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Arms;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 22986, 22995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_23050_23107(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, (Microsoft.CodeAnalysis.CSharp.Binder)next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 23050, 23107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SwitchExpressionArmBinder
                f_10348_23142_23216(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                arm, Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                armScopeBinder, Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                switchExpressionBinder)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SwitchExpressionArmBinder(arm, armScopeBinder, switchExpressionBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 23142, 23216);
                    return return_v;
                }


                int
                f_10348_23235_23259(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                node, Microsoft.CodeAnalysis.CSharp.SwitchExpressionArmBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 23235, 23259);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10348_23284_23295(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 23284, 23295);
                    return return_v;
                }


                int
                f_10348_23278_23307(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.SwitchExpressionArmBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 23278, 23307);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax?
                f_10348_23330_23344(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 23330, 23344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                f_10348_23400_23414(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 23400, 23414);
                    return return_v;
                }


                int
                f_10348_23394_23426(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.SwitchExpressionArmBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 23394, 23426);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_23472_23486(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 23472, 23486);
                    return return_v;
                }


                int
                f_10348_23466_23498(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.SwitchExpressionArmBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 23466, 23498);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax>
                f_10348_22986_22995_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 22986, 22995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 22637, 23525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 22637, 23525);
            }
        }

        public override void VisitIfStatement(IfStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 23537, 23784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 23623, 23657);

                f_10348_23623_23656(this, f_10348_23629_23643(node), _enclosing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 23671, 23730);

                f_10348_23671_23729(this, f_10348_23702_23716(node), _enclosing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 23744, 23773);

                f_10348_23744_23772(this, f_10348_23750_23759(node), _enclosing);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 23537, 23784);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_23629_23643(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 23629, 23643);
                    return return_v;
                }


                int
                f_10348_23623_23656(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 23623, 23656);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10348_23702_23716(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 23702, 23716);
                    return return_v;
                }


                int
                f_10348_23671_23729(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.VisitPossibleEmbeddedStatement(statement, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 23671, 23729);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax?
                f_10348_23750_23759(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
                this_param)
                {
                    var return_v = this_param.Else;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 23750, 23759);
                    return return_v;
                }


                int
                f_10348_23744_23772(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax?
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 23744, 23772);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 23537, 23784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 23537, 23784);
            }
        }

        public override void VisitElseClause(ElseClauseSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 23796, 23950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 23880, 23939);

                f_10348_23880_23938(this, f_10348_23911_23925(node), _enclosing);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 23796, 23950);

                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10348_23911_23925(Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 23911, 23925);
                    return return_v;
                }


                int
                f_10348_23880_23938(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.VisitPossibleEmbeddedStatement(statement, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 23880, 23938);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 23796, 23950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 23796, 23950);
            }
        }

        public override void VisitLabeledStatement(LabeledStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 23962, 24103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 24058, 24092);

                f_10348_24058_24091(this, f_10348_24064_24078(node), _enclosing);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 23962, 24103);

                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10348_24064_24078(Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 24064, 24078);
                    return return_v;
                }


                int
                f_10348_24058_24091(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 24058, 24091);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 23962, 24103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 23962, 24103);
            }
        }

        public override void VisitTryStatement(TryStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 24115, 25114);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 24203, 24852) || true) && (node.Catches.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 24203, 24852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 24657, 24741);

                    f_10348_24657_24740(this, f_10348_24663_24673(node), f_10348_24675_24739(_enclosing, BinderFlags.InTryBlockOfTryCatch));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 24203, 24852);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 24203, 24852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 24807, 24837);

                    f_10348_24807_24836(this, f_10348_24813_24823(node), _enclosing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 24203, 24852);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 24868, 24982);
                    foreach (CatchClauseSyntax c in f_10348_24900_24912_I(f_10348_24900_24912(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 24868, 24982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 24946, 24967);

                        f_10348_24946_24966(this, c, _enclosing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 24868, 24982);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 115);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 24998, 25103) || true) && (f_10348_25002_25014(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 24998, 25103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 25056, 25088);

                    f_10348_25056_25087(this, f_10348_25062_25074(node), _enclosing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 24998, 25103);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 24115, 25114);

                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10348_24663_24673(Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 24663, 24673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10348_24675_24739(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 24675, 24739);
                    return return_v;
                }


                int
                f_10348_24657_24740(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 24657, 24740);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10348_24813_24823(Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 24813, 24823);
                    return return_v;
                }


                int
                f_10348_24807_24836(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 24807, 24836);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>
                f_10348_24900_24912(Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
                this_param)
                {
                    var return_v = this_param.Catches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 24900, 24912);
                    return return_v;
                }


                int
                f_10348_24946_24966(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 24946, 24966);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>
                f_10348_24900_24912_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 24900, 24912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax?
                f_10348_25002_25014(Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 25002, 25014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax
                f_10348_25062_25074(Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 25062, 25074);
                    return return_v;
                }


                int
                f_10348_25056_25087(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 25056, 25087);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 24115, 25114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 24115, 25114);
            }
        }

        public override void VisitCatchClause(CatchClauseSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 25126, 25749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 25212, 25299);

                f_10348_25212_25298((object)_containingMemberOrLambda == f_10348_25262_25297(_enclosing));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 25313, 25372);

                var
                clauseBinder = f_10348_25332_25371(_enclosing, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 25386, 25415);

                f_10348_25386_25414(this, node, clauseBinder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 25431, 25690) || true) && (f_10348_25435_25446(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 25431, 25690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 25488, 25570);

                    Binder
                    filterBinder = f_10348_25510_25569(clauseBinder, BinderFlags.InCatchFilter)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 25588, 25624);

                    f_10348_25588_25623(this, f_10348_25597_25608(node), filterBinder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 25642, 25675);

                    f_10348_25642_25674(this, f_10348_25648_25659(node), filterBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 25431, 25690);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 25706, 25738);

                f_10348_25706_25737(this, f_10348_25712_25722(node), clauseBinder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 25126, 25749);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10348_25262_25297(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 25262, 25297);
                    return return_v;
                }


                int
                f_10348_25212_25298(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 25212, 25298);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CatchClauseBinder
                f_10348_25332_25371(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CatchClauseBinder(enclosing, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 25332, 25371);
                    return return_v;
                }


                int
                f_10348_25386_25414(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.CatchClauseBinder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 25386, 25414);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax?
                f_10348_25435_25446(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 25435, 25446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10348_25510_25569(Microsoft.CodeAnalysis.CSharp.CatchClauseBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 25510, 25569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax
                f_10348_25597_25608(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 25597, 25608);
                    return return_v;
                }


                int
                f_10348_25588_25623(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 25588, 25623);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax
                f_10348_25648_25659(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 25648, 25659);
                    return return_v;
                }


                int
                f_10348_25642_25674(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 25642, 25674);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10348_25712_25722(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 25712, 25722);
                    return return_v;
                }


                int
                f_10348_25706_25737(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.CatchClauseBinder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 25706, 25737);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 25126, 25749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 25126, 25749);
            }
        }

        public override void VisitCatchFilterClause(CatchFilterClauseSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 25761, 25899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 25859, 25888);

                f_10348_25859_25887(this, f_10348_25865_25886(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 25761, 25899);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_25865_25886(Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax
                this_param)
                {
                    var return_v = this_param.FilterExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 25865, 25886);
                    return return_v;
                }


                int
                f_10348_25859_25887(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 25859, 25887);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 25761, 25899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 25761, 25899);
            }
        }

        public override void VisitFinallyClause(FinallyClauseSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 25911, 27215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 26729, 26778);

                var
                additionalFlags = BinderFlags.InFinallyBlock
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 26792, 26948) || true) && (f_10348_26796_26847(_enclosing.Flags, BinderFlags.InCatchBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 26792, 26948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 26881, 26933);

                    additionalFlags |= BinderFlags.InNestedFinallyBlock;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 26792, 26948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 26964, 27031);

                f_10348_26964_27030(this, f_10348_26970_26980(node), f_10348_26982_27029(_enclosing, additionalFlags));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 27047, 27068);

                Binder
                finallyBinder
                = default(Binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 27082, 27204);

                f_10348_27082_27203(f_10348_27095_27142(_map, f_10348_27112_27122(node), out finallyBinder) && (DynAbs.Tracing.TraceSender.Expression_True(10348, 27095, 27202) && f_10348_27146_27202(finallyBinder.Flags, BinderFlags.InFinallyBlock)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 25911, 27215);

                bool
                f_10348_26796_26847(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 26796, 26847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10348_26970_26980(Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 26970, 26980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10348_26982_27029(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 26982, 27029);
                    return return_v;
                }


                int
                f_10348_26964_27030(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 26964, 27030);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10348_27112_27122(Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 27112, 27122);
                    return return_v;
                }


                bool
                f_10348_27095_27142(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                key, out Microsoft.CodeAnalysis.CSharp.Binder
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.SyntaxNode)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 27095, 27142);
                    return return_v;
                }


                bool
                f_10348_27146_27202(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 27146, 27202);
                    return return_v;
                }


                int
                f_10348_27082_27203(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 27082, 27203);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 25911, 27215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 25911, 27215);
            }
        }

        public override void VisitYieldStatement(YieldStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 27227, 27441);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 27319, 27430) || true) && (f_10348_27323_27338(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 27319, 27430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 27380, 27415);

                    f_10348_27380_27414(this, f_10348_27386_27401(node), _enclosing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 27319, 27430);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 27227, 27441);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10348_27323_27338(Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 27323, 27338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_27386_27401(Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 27386, 27401);
                    return return_v;
                }


                int
                f_10348_27380_27414(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 27380, 27414);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 27227, 27441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 27227, 27441);
            }
        }

        public override void VisitExpressionStatement(ExpressionStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 27453, 27601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 27555, 27590);

                f_10348_27555_27589(this, f_10348_27561_27576(node), _enclosing);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 27453, 27601);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_27561_27576(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 27561, 27576);
                    return return_v;
                }


                int
                f_10348_27555_27589(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 27555, 27589);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 27453, 27601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 27453, 27601);
            }
        }

        public override void VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 27613, 27938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 27727, 27782);

                f_10348_27727_27781(this, f_10348_27747_27768(f_10348_27747_27763(node)), _enclosing);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 27798, 27927);
                    foreach (VariableDeclaratorSyntax decl in f_10348_27840_27866_I(f_10348_27840_27866(f_10348_27840_27856(node))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 27798, 27927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 27900, 27912);

                        f_10348_27900_27911(this, decl);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 27798, 27927);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 130);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 27613, 27938);

                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10348_27747_27763(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 27747, 27763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10348_27747_27768(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 27747, 27768);
                    return return_v;
                }


                int
                f_10348_27727_27781(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.VisitRankSpecifiers(type, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 27727, 27781);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10348_27840_27856(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 27840, 27856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10348_27840_27866(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 27840, 27866);
                    return return_v;
                }


                int
                f_10348_27900_27911(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 27900, 27911);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10348_27840_27866_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 27840, 27866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 27613, 27938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 27613, 27938);
            }
        }

        public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 27950, 28131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 28050, 28075);

                f_10348_28050_28074(this, f_10348_28056_28073(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 28089, 28120);

                f_10348_28089_28119(this, f_10348_28095_28118_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10348_28095_28111(node), 10348, 28095, 28118)?.Value));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 27950, 28131);

                Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax?
                f_10348_28056_28073(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 28056, 28073);
                    return return_v;
                }


                int
                f_10348_28050_28074(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 28050, 28074);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10348_28095_28111(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 28095, 28111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10348_28095_28118_M(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 28095, 28118);
                    return return_v;
                }


                int
                f_10348_28089_28119(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 28089, 28119);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 27950, 28131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 27950, 28131);
            }
        }

        public override void VisitReturnStatement(ReturnStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 28143, 28359);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 28237, 28348) || true) && (f_10348_28241_28256(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 28237, 28348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 28298, 28333);

                    f_10348_28298_28332(this, f_10348_28304_28319(node), _enclosing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 28237, 28348);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 28143, 28359);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10348_28241_28256(Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 28241, 28256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_28304_28319(Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 28304, 28319);
                    return return_v;
                }


                int
                f_10348_28298_28332(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 28298, 28332);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 28143, 28359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 28143, 28359);
            }
        }

        public override void VisitThrowStatement(ThrowStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 28371, 28585);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 28463, 28574) || true) && (f_10348_28467_28482(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 28463, 28574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 28524, 28559);

                    f_10348_28524_28558(this, f_10348_28530_28545(node), _enclosing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 28463, 28574);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 28371, 28585);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10348_28467_28482(Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 28467, 28482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_28530_28545(Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 28530, 28545);
                    return return_v;
                }


                int
                f_10348_28524_28558(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 28524, 28558);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 28371, 28585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 28371, 28585);
            }
        }

        public override void VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 28597, 29467);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 29138, 29456) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 29138, 29456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 29183, 29201);

                        f_10348_29183_29200(this, f_10348_29189_29199(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 29219, 29267);

                        var
                        binOp = f_10348_29231_29240(node) as BinaryExpressionSyntax
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 29285, 29408) || true) && (binOp == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 29285, 29408);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 29344, 29361);

                            f_10348_29344_29360(this, f_10348_29350_29359(node));
                            DynAbs.Tracing.TraceSender.TraceBreak(10348, 29383, 29389);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 29285, 29408);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 29428, 29441);

                        node = binOp;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 29138, 29456);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 29138, 29456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 29138, 29456);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 28597, 29467);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_29189_29199(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 29189, 29199);
                    return return_v;
                }


                int
                f_10348_29183_29200(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 29183, 29200);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_29231_29240(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 29231, 29240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_29350_29359(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 29350, 29359);
                    return return_v;
                }


                int
                f_10348_29344_29360(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 29344, 29360);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 28597, 29467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 28597, 29467);
            }
        }

        public override void DefaultVisit(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 29479, 29818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 29783, 29807);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DefaultVisit(node), 10348, 29783, 29806);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 29479, 29818);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 29479, 29818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 29479, 29818);
            }
        }

        private void AddToMap(SyntaxNode node, Binder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 29830, 31086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 30033, 30147);

                f_10348_30033_30146(f_10348_30046_30081(node) || (DynAbs.Tracing.TraceSender.Expression_False(10348, 30046, 30145) || (node == _root && (DynAbs.Tracing.TraceSender.Expression_True(10348, 30103, 30144) && node is ExpressionSyntax))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 30768, 30784);

                Binder
                existing
                = default(Binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 30905, 31039);

                f_10348_30905_31038(!f_10348_30919_30955(_map, node, out existing) || (DynAbs.Tracing.TraceSender.Expression_False(10348, 30918, 30977) || existing == binder) || (DynAbs.Tracing.TraceSender.Expression_False(10348, 30918, 31004) || existing == f_10348_30993_31004(binder)) || (DynAbs.Tracing.TraceSender.Expression_False(10348, 30918, 31037) || existing == f_10348_31020_31037_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10348_31020_31031(binder), 10348, 31020, 31037)?.Next)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 31055, 31075);

                _map[node] = binder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 29830, 31086);

                bool
                f_10348_30046_30081(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = syntax.CanHaveAssociatedLocalBinder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 30046, 30081);
                    return return_v;
                }


                int
                f_10348_30033_30146(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 30033, 30146);
                    return 0;
                }


                bool
                f_10348_30919_30955(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key, out Microsoft.CodeAnalysis.CSharp.Binder
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 30919, 30955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10348_30993_31004(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 30993, 31004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10348_31020_31031(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 31020, 31031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10348_31020_31037_M(Microsoft.CodeAnalysis.CSharp.Binder?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 31020, 31037);
                    return return_v;
                }


                int
                f_10348_30905_31038(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 30905, 31038);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 29830, 31086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 29830, 31086);
            }
        }

        private Binder GetBinderForPossibleEmbeddedStatement(StatementSyntax statement, Binder enclosing, out CSharpSyntaxNode embeddedScopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 31590, 33216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 31758, 33205);

                switch (f_10348_31766_31782(statement))
                {

                    case SyntaxKind.LocalDeclarationStatement:
                    case SyntaxKind.LabeledStatement:
                    case SyntaxKind.LocalFunctionStatement:
                    // It is an error to have a declaration or a label in an embedded statement,
                    // but we still want to bind it.  

                    case SyntaxKind.ExpressionStatement:
                    case SyntaxKind.LockStatement:
                    case SyntaxKind.IfStatement:
                    case SyntaxKind.YieldReturnStatement:
                    case SyntaxKind.ReturnStatement:
                    case SyntaxKind.ThrowStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 31758, 33205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 32438, 32524);

                        f_10348_32438_32523((object)_containingMemberOrLambda == f_10348_32488_32522(enclosing));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 32546, 32582);

                        embeddedScopeDesignator = statement;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 32604, 32661);

                        return f_10348_32611_32660(enclosing, statement);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 31758, 33205);

                    case SyntaxKind.SwitchStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 31758, 33205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 32735, 32821);

                        f_10348_32735_32820((object)_containingMemberOrLambda == f_10348_32785_32819(enclosing));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 32843, 32898);

                        var
                        switchStatement = (SwitchStatementSyntax)statement
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 32920, 32973);

                        embeddedScopeDesignator = f_10348_32946_32972(switchStatement);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 32995, 33070);

                        return f_10348_33002_33069(f_10348_33031_33057(switchStatement), enclosing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 31758, 33205);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 31758, 33205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 33120, 33151);

                        embeddedScopeDesignator = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 33173, 33190);

                        return enclosing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 31758, 33205);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 31590, 33216);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10348_31766_31782(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 31766, 31782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10348_32488_32522(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 32488, 32522);
                    return return_v;
                }


                int
                f_10348_32438_32523(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 32438, 32523);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.EmbeddedStatementBinder
                f_10348_32611_32660(Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.EmbeddedStatementBinder(enclosing, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 32611, 32660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10348_32785_32819(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 32785, 32819);
                    return return_v;
                }


                int
                f_10348_32735_32820(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 32735, 32820);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_32946_32972(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 32946, 32972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_33031_33057(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 33031, 33057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder
                f_10348_33002_33069(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                scopeDesignator, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionVariableBinder((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 33002, 33069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 31590, 33216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 31590, 33216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VisitPossibleEmbeddedStatement(StatementSyntax statement, Binder enclosing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 33228, 34271);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 33341, 34260) || true) && (statement != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 33341, 34260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 33396, 33437);

                    CSharpSyntaxNode
                    embeddedScopeDesignator
                    = default(CSharpSyntaxNode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 33935, 34036);

                    enclosing = f_10348_33947_34035(this, statement, enclosing, out embeddedScopeDesignator);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 34056, 34197) || true) && (embeddedScopeDesignator != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 34056, 34197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 34133, 34178);

                        f_10348_34133_34177(this, embeddedScopeDesignator, enclosing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 34056, 34197);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 34217, 34245);

                    f_10348_34217_34244(this, statement, enclosing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 33341, 34260);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 33228, 34271);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10348_33947_34035(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing, out Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                embeddedScopeDesignator)
                {
                    var return_v = this_param.GetBinderForPossibleEmbeddedStatement(statement, enclosing, out embeddedScopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 33947, 34035);
                    return return_v;
                }


                int
                f_10348_34133_34177(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    this_param.AddToMap((Microsoft.CodeAnalysis.SyntaxNode)node, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 34133, 34177);
                    return 0;
                }


                int
                f_10348_34217_34244(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 34217, 34244);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 33228, 34271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 33228, 34271);
            }
        }

        public override void VisitQueryExpression(QueryExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 34283, 34453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 34377, 34411);

                f_10348_34377_34410(this, f_10348_34383_34409(f_10348_34383_34398(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 34425, 34442);

                f_10348_34425_34441(this, f_10348_34431_34440(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 34283, 34453);

                Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                f_10348_34383_34398(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.FromClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 34383, 34398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_34383_34409(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 34383, 34409);
                    return return_v;
                }


                int
                f_10348_34377_34410(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 34377, 34410);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10348_34431_34440(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 34431, 34440);
                    return return_v;
                }


                int
                f_10348_34425_34441(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 34425, 34441);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 34283, 34453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 34283, 34453);
            }
        }

        public override void VisitQueryBody(QueryBodySyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10348, 34465, 34847);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 34547, 34795);
                    foreach (QueryClauseSyntax clause in f_10348_34584_34596_I(f_10348_34584_34596(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 34547, 34795);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 34630, 34780) || true) && (f_10348_34634_34647(clause) == SyntaxKind.JoinClause)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10348, 34630, 34780);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 34714, 34761);

                            f_10348_34714_34760(this, f_10348_34720_34759(((JoinClauseSyntax)clause)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 34630, 34780);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10348, 34547, 34795);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10348, 1, 249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10348, 1, 249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10348, 34811, 34836);

                f_10348_34811_34835(this, f_10348_34817_34834(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10348, 34465, 34847);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                f_10348_34584_34596(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.Clauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 34584, 34596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10348_34634_34647(Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 34634, 34647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10348_34720_34759(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.InExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 34720, 34759);
                    return return_v;
                }


                int
                f_10348_34714_34760(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 34714, 34760);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                f_10348_34584_34596_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 34584, 34596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax?
                f_10348_34817_34834(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.Continuation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 34817, 34834);
                    return return_v;
                }


                int
                f_10348_34811_34835(Microsoft.CodeAnalysis.CSharp.LocalBinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 34811, 34835);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10348, 34465, 34847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 34465, 34847);
            }
        }

        static LocalBinderFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10348, 1406, 34854);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10348, 1406, 34854);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10348, 1406, 34854);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10348, 1406, 34854);

        int
        f_10348_5482_5536(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 5482, 5536);
            return 0;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10348_5564_5593(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 5564, 5593);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10348_5617_5646(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 5617, 5646);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10348_5678_5707(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10348, 5678, 5707);
            return return_v;
        }


        int
        f_10348_5551_5732(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 5551, 5732);
            return 0;
        }


        Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
        f_10348_5756_5831(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.SyntaxNode>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10348, 5756, 5831);
            return return_v;
        }

    }
}
