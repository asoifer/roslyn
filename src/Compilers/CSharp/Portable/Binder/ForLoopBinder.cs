// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ForLoopBinder : LoopBinder
    {
        private readonly ForStatementSyntax _syntax;

        public ForLoopBinder(Binder enclosing, ForStatementSyntax syntax)
        : base(f_10341_747_756_C(enclosing))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10341, 661, 853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 641, 648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 782, 811);

                f_10341_782_810(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 825, 842);

                _syntax = syntax;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10341, 661, 853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10341, 661, 853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10341, 661, 853);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10341, 865, 2366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 950, 1003);

                var
                locals = f_10341_963_1002()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 1088, 2304) || true) && (f_10341_1092_1111(_syntax) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10341, 1088, 2304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 1153, 1651);

                    f_10341_1153_1650(f_10341_1153_1177(f_10341_1153_1172(_syntax)), (rankSpecifier, args) =>
                                    {
                                        foreach (var size in rankSpecifier.Sizes)
                                        {
                                            if (size.Kind() != SyntaxKind.OmittedArraySizeExpression)
                                            {
                                                ExpressionVariableFinder.FindExpressionVariables(args.binder, args.locals, size);
                                            }
                                        }
                                    }, (binder: this, locals: locals));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 1671, 2138);
                        foreach (var vdecl in f_10341_1693_1722_I(f_10341_1693_1722(f_10341_1693_1712(_syntax))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10341, 1671, 2138);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 1764, 1858);

                            var
                            localSymbol = f_10341_1782_1857(this, f_10341_1792_1811(_syntax), vdecl, LocalDeclarationKind.RegularVariable)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 1880, 1904);

                            f_10341_1880_1903(locals, localSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 2049, 2119);

                            f_10341_2049_2118(this, locals, vdecl);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10341, 1671, 2138);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10341, 1, 468);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10341, 1, 468);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10341, 1088, 2304);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10341, 1088, 2304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 2204, 2289);

                    f_10341_2204_2288(this, locals, f_10341_2267_2287(_syntax));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10341, 1088, 2304);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 2320, 2355);

                return f_10341_2327_2354(locals);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10341, 865, 2366);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10341_963_1002()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 963, 1002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax?
                f_10341_1092_1111(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 1092, 1111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10341_1153_1172(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 1153, 1172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10341_1153_1177(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 1153, 1177);
                    return return_v;
                }


                int
                f_10341_1153_1650(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, System.Action<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax, (Microsoft.CodeAnalysis.CSharp.ForLoopBinder binder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals)>
                action, (Microsoft.CodeAnalysis.CSharp.ForLoopBinder binder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals)
                argument)
                {
                    type.VisitRankSpecifiers<(Microsoft.CodeAnalysis.CSharp.ForLoopBinder binder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals)>(action, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 1153, 1650);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10341_1693_1712(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 1693, 1712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10341_1693_1722(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 1693, 1722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10341_1792_1811(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 1792, 1811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10341_1782_1857(Microsoft.CodeAnalysis.CSharp.ForLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                declaration, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declarator, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind)
                {
                    var return_v = this_param.MakeLocal(declaration, declarator, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 1782, 1857);
                    return return_v;
                }


                int
                f_10341_1880_1903(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 1880, 1903);
                    return 0;
                }


                int
                f_10341_2049_2118(Microsoft.CodeAnalysis.CSharp.ForLoopBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                node)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 2049, 2118);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10341_1693_1722_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 1693, 1722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10341_2267_2287(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 2267, 2287);
                    return return_v;
                }


                int
                f_10341_2204_2288(Microsoft.CodeAnalysis.CSharp.ForLoopBinder
                binder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                nodes)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)binder, builder, nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 2204, 2288);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10341_2327_2354(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 2327, 2354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10341, 865, 2366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10341, 865, 2366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundForStatement BindForParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10341, 2378, 2618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 2501, 2579);

                BoundForStatement
                result = f_10341_2528_2578(this, _syntax, originalBinder, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 2593, 2607);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10341, 2378, 2618);

                Microsoft.CodeAnalysis.CSharp.BoundForStatement
                f_10341_2528_2578(Microsoft.CodeAnalysis.CSharp.ForLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindForParts(node, originalBinder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 2528, 2578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10341, 2378, 2618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10341, 2378, 2618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundForStatement BindForParts(ForStatementSyntax node, Binder originalBinder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10341, 2630, 5800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 2768, 2795);

                BoundStatement
                initializer
                = default(BoundStatement);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 2878, 3320) || true) && (f_10341_2882_2901(_syntax) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10341, 2878, 3320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 2943, 2988);

                    ImmutableArray<BoundLocalDeclaration>
                    unused
                    = default(ImmutableArray<BoundLocalDeclaration>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3006, 3150);

                    initializer = f_10341_3020_3149(originalBinder, f_10341_3069_3085(node), LocalDeclarationKind.RegularVariable, diagnostics, out unused);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10341, 2878, 3320);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10341, 2878, 3320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3216, 3305);

                    initializer = f_10341_3230_3304(originalBinder, f_10341_3273_3290(node), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10341, 2878, 3320);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3336, 3369);

                BoundExpression
                condition = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3383, 3435);

                var
                innerLocals = ImmutableArray<LocalSymbol>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3449, 3499);

                ExpressionSyntax
                conditionSyntax = f_10341_3484_3498(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3513, 3835) || true) && (conditionSyntax != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10341, 3513, 3835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3574, 3633);

                    originalBinder = f_10341_3591_3632(originalBinder, conditionSyntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3651, 3730);

                    condition = f_10341_3663_3729(originalBinder, conditionSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3748, 3820);

                    innerLocals = f_10341_3762_3819(originalBinder, conditionSyntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10341, 3513, 3835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3851, 3883);

                BoundStatement
                increment = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3897, 3968);

                SeparatedSyntaxList<ExpressionSyntax>
                incrementors = f_10341_3950_3967(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 3982, 5117) || true) && (incrementors.Count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10341, 3982, 5117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 4042, 4085);

                    var
                    scopeDesignator = incrementors.First()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 4103, 4167);

                    var
                    incrementBinder = f_10341_4125_4166(originalBinder, scopeDesignator)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 4185, 4268);

                    increment = f_10341_4197_4267(incrementBinder, incrementors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 4286, 4399);

                    f_10341_4286_4398(f_10341_4299_4313(increment) != BoundKind.StatementList || (DynAbs.Tracing.TraceSender.Expression_False(10341, 4299, 4397) || ((BoundStatementList)increment).Statements.Length > 1));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 4419, 4491);

                    var
                    locals = f_10341_4432_4490(incrementBinder, scopeDesignator)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 4509, 5102) || true) && (f_10341_4513_4528_M(!locals.IsEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10341, 4509, 5102);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 4570, 5083) || true) && (f_10341_4574_4588(increment) == BoundKind.StatementList)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10341, 4570, 5083);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 4665, 4818);

                            increment = new BoundBlock(scopeDesignator, locals, f_10341_4717_4759(((BoundStatementList)increment)))
                            { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10341, 4677, 4817) };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10341, 4570, 5083);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10341, 4570, 5083);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 4916, 5060);

                            increment = new BoundBlock(increment.Syntax, locals, f_10341_4969_5001(increment))
                            { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10341, 4928, 5059) };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10341, 4570, 5083);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10341, 4509, 5102);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10341, 3982, 5117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 5133, 5218);

                var
                body = f_10341_5144_5217(originalBinder, f_10341_5189_5203(node), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 5234, 5300);

                f_10341_5234_5299(f_10341_5247_5258(this) == f_10341_5262_5298(this, node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 5314, 5789);

                return f_10341_5321_5788(node, f_10341_5391_5402(this), initializer, innerLocals, condition, increment, body, f_10341_5710_5725(this), f_10341_5769_5787(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10341, 2630, 5800);

                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax?
                f_10341_2882_2901(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 2882, 2901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax?
                f_10341_3069_3085(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 3069, 3085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10341_3020_3149(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax?
                nodeOpt, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                localKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
                declarations)
                {
                    var return_v = this_param.BindForOrUsingOrFixedDeclarations(nodeOpt, localKind, diagnostics, out declarations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 3020, 3149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10341_3273_3290(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 3273, 3290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10341_3230_3304(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                statements, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindStatementExpressionList(statements, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 3230, 3304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10341_3484_3498(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 3484, 3498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10341_3591_3632(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 3591, 3632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10341_3663_3729(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindBooleanExpression(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 3663, 3729);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10341_3762_3819(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 3762, 3819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10341_3950_3967(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Incrementors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 3950, 3967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10341_4125_4166(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 4125, 4166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10341_4197_4267(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                statements, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindStatementExpressionList(statements, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 4197, 4267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10341_4299_4313(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 4299, 4313);
                    return return_v;
                }


                int
                f_10341_4286_4398(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 4286, 4398);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10341_4432_4490(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 4432, 4490);
                    return return_v;
                }


                bool
                f_10341_4513_4528_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 4513, 4528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10341_4574_4588(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 4574, 4588);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10341_4717_4759(Microsoft.CodeAnalysis.CSharp.BoundStatementList
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 4717, 4759);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10341_4969_5001(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 4969, 5001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10341_5189_5203(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 5189, 5203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10341_5144_5217(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPossibleEmbeddedStatement(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 5144, 5217);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10341_5247_5258(Microsoft.CodeAnalysis.CSharp.ForLoopBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 5247, 5258);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10341_5262_5298(Microsoft.CodeAnalysis.CSharp.ForLoopBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 5262, 5298);
                    return return_v;
                }


                int
                f_10341_5234_5299(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 5234, 5299);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10341_5391_5402(Microsoft.CodeAnalysis.CSharp.ForLoopBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 5391, 5402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10341_5710_5725(Microsoft.CodeAnalysis.CSharp.ForLoopBinder
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 5710, 5725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10341_5769_5787(Microsoft.CodeAnalysis.CSharp.ForLoopBinder
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 5769, 5787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundForStatement
                f_10341_5321_5788(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                outerLocals, Microsoft.CodeAnalysis.CSharp.BoundStatement
                initializer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                innerLocals, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                increment, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                breakLabel, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundForStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, outerLocals, initializer, innerLocals, condition, increment, body, breakLabel, continueLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 5321, 5788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10341, 2630, 5800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10341, 2630, 5800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10341, 5812, 6098);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 5936, 6034) || true) && (_syntax == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10341, 5936, 6034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 6000, 6019);

                    return f_10341_6007_6018(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10341, 5936, 6034);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 6050, 6087);

                throw f_10341_6056_6086();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10341, 5812, 6098);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10341_6007_6018(Microsoft.CodeAnalysis.CSharp.ForLoopBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 6007, 6018);
                    return return_v;
                }


                System.Exception
                f_10341_6056_6086()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 6056, 6086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10341, 5812, 6098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10341, 5812, 6098);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10341, 6110, 6304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 6256, 6293);

                throw f_10341_6262_6292();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10341, 6110, 6304);

                System.Exception
                f_10341_6262_6292()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10341, 6262, 6292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10341, 6110, 6304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10341, 6110, 6304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10341, 6385, 6451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10341, 6421, 6436);

                    return _syntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10341, 6385, 6451);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10341, 6316, 6462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10341, 6316, 6462);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ForLoopBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10341, 540, 6469);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10341, 540, 6469);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10341, 540, 6469);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10341, 540, 6469);

        int
        f_10341_782_810(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10341, 782, 810);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10341_747_756_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10341, 661, 853);
            return return_v;
        }

    }
}
