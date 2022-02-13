// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class UsingStatementBinder : LockOrUsingBinder
    {
        private readonly UsingStatementSyntax _syntax;

        public UsingStatementBinder(Binder enclosing, UsingStatementSyntax syntax)
        : base(f_10374_771_780_C(enclosing))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10374, 676, 834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 656, 663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 806, 823);

                _syntax = syntax;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10374, 676, 834);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10374, 676, 834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 676, 834);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10374, 846, 2815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 931, 990);

                ExpressionSyntax
                expressionSyntax = f_10374_967_989()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 1004, 1070);

                VariableDeclarationSyntax
                declarationSyntax = f_10374_1050_1069(_syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 1086, 1157);

                f_10374_1086_1156((expressionSyntax == null) ^ (declarationSyntax == null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 1204, 2804) || true) && (expressionSyntax != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 1204, 2804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 1266, 1319);

                    var
                    locals = f_10374_1279_1318()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 1337, 1418);

                    f_10374_1337_1417(this, locals, expressionSyntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 1436, 1471);

                    return f_10374_1443_1470(locals);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 1204, 2804);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 1204, 2804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 1537, 1623);

                    var
                    locals = f_10374_1550_1622(declarationSyntax.Variables.Count)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 1773, 2269);

                    f_10374_1773_2268(f_10374_1773_1795(declarationSyntax), (rankSpecifier, args) =>
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
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 2289, 2734);
                        foreach (VariableDeclaratorSyntax declarator in f_10374_2337_2364_I(f_10374_2337_2364(declarationSyntax)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 2289, 2734);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 2406, 2495);

                            f_10374_2406_2494(locals, f_10374_2417_2493(this, declarationSyntax, declarator, LocalDeclarationKind.UsingVariable));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 2640, 2715);

                            f_10374_2640_2714(this, locals, declarator);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 2289, 2734);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10374, 1, 446);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10374, 1, 446);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 2754, 2789);

                    return f_10374_2761_2788(locals);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 1204, 2804);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10374, 846, 2815);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10374_967_989()
                {
                    var return_v = TargetExpressionSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 967, 989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax?
                f_10374_1050_1069(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 1050, 1069);
                    return return_v;
                }


                int
                f_10374_1086_1156(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 1086, 1156);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10374_1279_1318()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 1279, 1318);
                    return return_v;
                }


                int
                f_10374_1337_1417(Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 1337, 1417);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10374_1443_1470(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 1443, 1470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10374_1550_1622(int
                capacity)
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 1550, 1622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10374_1773_1795(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 1773, 1795);
                    return return_v;
                }


                int
                f_10374_1773_2268(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, System.Action<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax, (Microsoft.CodeAnalysis.CSharp.UsingStatementBinder binder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals)>
                action, (Microsoft.CodeAnalysis.CSharp.UsingStatementBinder binder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals)
                argument)
                {
                    type.VisitRankSpecifiers<(Microsoft.CodeAnalysis.CSharp.UsingStatementBinder binder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals)>(action, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 1773, 2268);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10374_2337_2364(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 2337, 2364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10374_2417_2493(Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                declaration, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declarator, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind)
                {
                    var return_v = this_param.MakeLocal(declaration, declarator, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 2417, 2493);
                    return return_v;
                }


                int
                f_10374_2406_2494(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 2406, 2494);
                    return 0;
                }


                int
                f_10374_2640_2714(Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                node)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 2640, 2714);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10374_2337_2364_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 2337, 2364);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10374_2761_2788(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 2761, 2788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10374, 846, 2815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 846, 2815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ExpressionSyntax TargetExpressionSyntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10374, 2910, 2987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 2946, 2972);

                    return f_10374_2953_2971(_syntax);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10374, 2910, 2987);

                    Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                    f_10374_2953_2971(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 2953, 2971);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10374, 2827, 2998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 2827, 2998);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override BoundStatement BindUsingStatementParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10374, 3010, 3809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 3141, 3200);

                ExpressionSyntax
                expressionSyntax = f_10374_3177_3199()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 3214, 3280);

                VariableDeclarationSyntax
                declarationSyntax = f_10374_3260_3279(_syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 3294, 3349);

                bool
                hasAwait = _syntax.AwaitKeyword.Kind() != default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 3365, 3436);

                f_10374_3365_3435((expressionSyntax == null) ^ (declarationSyntax == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 3483, 3686);

                var
                boundUsingStatement = f_10374_3509_3685((CSharpSyntaxNode)expressionSyntax ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?>(10374, 3550, 3605) ?? declarationSyntax), f_10374_3607_3627(_syntax), f_10374_3629_3649(_syntax), originalBinder, this, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 3700, 3757);

                f_10374_3700_3756(boundUsingStatement is BoundUsingStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 3771, 3798);

                return boundUsingStatement;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10374, 3010, 3809);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10374_3177_3199()
                {
                    var return_v = TargetExpressionSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 3177, 3199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax?
                f_10374_3260_3279(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 3260, 3279);
                    return return_v;
                }


                int
                f_10374_3365_3435(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 3365, 3435);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10374_3607_3627(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                this_param)
                {
                    var return_v = this_param.UsingKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 3607, 3627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10374_3629_3649(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                this_param)
                {
                    var return_v = this_param.AwaitKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 3629, 3649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10374_3509_3685(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                syntax, Microsoft.CodeAnalysis.SyntaxToken
                usingKeyword, Microsoft.CodeAnalysis.SyntaxToken
                awaitKeyword, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                usingBinderOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = BindUsingStatementOrDeclarationFromParts((Microsoft.CodeAnalysis.SyntaxNode?)syntax, usingKeyword, awaitKeyword, originalBinder, usingBinderOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 3509, 3685);
                    return return_v;
                }


                int
                f_10374_3700_3756(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 3700, 3756);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10374, 3010, 3809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 3010, 3809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundStatement BindUsingStatementOrDeclarationFromParts(SyntaxNode syntax, SyntaxToken usingKeyword, SyntaxToken awaitKeyword, Binder originalBinder, UsingStatementBinder? usingBinderOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10374, 3839, 14499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4094, 4174);

                bool
                isUsingDeclaration = f_10374_4120_4133(syntax) == SyntaxKind.LocalDeclarationStatement
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4188, 4279);

                bool
                isExpression = !isUsingDeclaration && (DynAbs.Tracing.TraceSender.Expression_True(10374, 4208, 4278) && f_10374_4231_4244(syntax) != SyntaxKind.VariableDeclaration)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4293, 4333);

                bool
                hasAwait = awaitKeyword != default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4349, 4408);

                f_10374_4349_4407(isUsingDeclaration || (DynAbs.Tracing.TraceSender.Expression_False(10374, 4362, 4406) || usingBinderOpt != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4424, 4490);

                TypeSymbol
                disposableInterface = f_10374_4457_4489(hasAwait)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4506, 4556);

                f_10374_4506_4555((object)disposableInterface != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4570, 4686);

                bool
                hasErrors = f_10374_4587_4685(disposableInterface, diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10374, 4646, 4654) || ((hasAwait && DynAbs.Tracing.TraceSender.Conditional_F2(10374, 4657, 4669)) || DynAbs.Tracing.TraceSender.Conditional_F3(10374, 4672, 4684))) ? awaitKeyword : usingKeyword)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4702, 4735);

                Conversion
                iDisposableConversion
                = default(Conversion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4749, 4813);

                ImmutableArray<BoundLocalDeclaration>
                declarationsOpt = default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4827, 4890);

                BoundMultipleLocalDeclarations?
                multipleDeclarationsOpt = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4904, 4942);

                BoundExpression?
                expressionOpt = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 4956, 4994);

                TypeSymbol?
                declarationTypeOpt = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 5008, 5047);

                MethodArgumentInfo?
                patternDisposeInfo
                = default(MethodArgumentInfo?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 5061, 5090);

                TypeSymbol?
                awaitableTypeOpt
                = default(TypeSymbol?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 5106, 6599) || true) && (isExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 5106, 6599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 5156, 5238);

                    expressionOpt = f_10374_5172_5237(usingBinderOpt!, diagnostics, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 5256, 5409);

                    hasErrors |= !f_10374_5270_5408(fromExpression: true, out iDisposableConversion, out patternDisposeInfo, out awaitableTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 5106, 6599);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 5106, 6599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 5475, 5632);

                    VariableDeclarationSyntax
                    declarationSyntax = (DynAbs.Tracing.TraceSender.Conditional_F1(10374, 5521, 5539) || ((isUsingDeclaration && DynAbs.Tracing.TraceSender.Conditional_F2(10374, 5542, 5595)) || DynAbs.Tracing.TraceSender.Conditional_F3(10374, 5598, 5631))) ? f_10374_5542_5595(((LocalDeclarationStatementSyntax)syntax)) : (VariableDeclarationSyntax)syntax
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 5650, 5788);

                    f_10374_5650_5787(originalBinder, declarationSyntax, LocalDeclarationKind.UsingVariable, diagnostics, out declarationsOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 5808, 5893);

                    f_10374_5808_5892(f_10374_5821_5845_M(!declarationsOpt.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10374, 5821, 5891) && f_10374_5849_5883(declarationsOpt[0]) != null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 5911, 6008);

                    multipleDeclarationsOpt = f_10374_5937_6007(declarationSyntax, declarationsOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 6026, 6088);

                    declarationTypeOpt = f_10374_6047_6087(declarationsOpt[0].DeclaredTypeOpt!);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 6108, 6584) || true) && (f_10374_6112_6142(declarationTypeOpt))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 6108, 6584);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 6184, 6235);

                        iDisposableConversion = Conversion.ImplicitDynamic;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 6257, 6283);

                        patternDisposeInfo = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 6305, 6329);

                        awaitableTypeOpt = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 6108, 6584);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 6108, 6584);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 6411, 6565);

                        hasErrors |= !f_10374_6425_6564(fromExpression: false, out iDisposableConversion, out patternDisposeInfo, out awaitableTypeOpt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 6108, 6584);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 5106, 6599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 6615, 6651);

                BoundAwaitableInfo?
                awaitOpt = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 6665, 7673) || true) && (hasAwait)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 6665, 7673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 6819, 6924);

                    f_10374_6819_6923(                // even if we don't have a proper value to await, we'll still report bad usages of `await`
                                    originalBinder, syntax, awaitKeyword.GetLocation(), diagnostics, ref hasErrors);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 6944, 7658) || true) && (awaitableTypeOpt is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 6944, 7658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 7014, 7195);

                        awaitOpt = new BoundAwaitableInfo(syntax, awaitableInstancePlaceholder: null, isDynamic: true, getAwaiter: null, isCompleted: null, getResult: null) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10374, 7025, 7194) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 6944, 7658);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 6944, 7658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 7277, 7360);

                        hasErrors |= f_10374_7290_7359(awaitableTypeOpt, diagnostics, awaitKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 7382, 7528);

                        var
                        placeholder = f_10374_7400_7527(f_10374_7400_7503(syntax, valEscape: f_10374_7454_7484(originalBinder), awaitableTypeOpt))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 7550, 7639);

                        awaitOpt = f_10374_7561_7638(originalBinder, placeholder, syntax, diagnostics, ref hasErrors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 6944, 7658);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 6665, 7673);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 7914, 8702) || true) && (isUsingDeclaration)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 7914, 8702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 7970, 8098);

                    return f_10374_7977_8097(syntax, patternDisposeInfo, iDisposableConversion, awaitOpt, declarationsOpt, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 7914, 8702);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 7914, 8702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 8164, 8284);

                    BoundStatement
                    boundBody = f_10374_8191_8283(originalBinder, f_10374_8236_8269(usingBinderOpt!._syntax), diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 8304, 8687);

                    return f_10374_8311_8686(usingBinderOpt._syntax, f_10374_8402_8423(usingBinderOpt), multipleDeclarationsOpt, expressionOpt, iDisposableConversion, boundBody, awaitOpt, patternDisposeInfo, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 7914, 8702);
                }

                bool populateDisposableConversionOrDisposeMethod(bool fromExpression, out Conversion iDisposableConversion, out MethodArgumentInfo? patternDisposeInfo, out TypeSymbol? awaitableType)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10374, 8718, 13695);
                        Microsoft.CodeAnalysis.BitVector defaultArguments = default(Microsoft.CodeAnalysis.BitVector);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 8933, 8984);

                        HashSet<DiagnosticInfo>?
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 9002, 9106);

                        iDisposableConversion = f_10374_9026_9105(fromExpression, disposableInterface, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 9124, 9150);

                        patternDisposeInfo = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 9168, 9189);

                        awaitableType = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 9209, 9253);

                        f_10374_9209_9252(
                                        diagnostics, syntax, useSiteDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 9273, 9597) || true) && (iDisposableConversion.IsImplicit)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 9273, 9597);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 9351, 9544) || true) && (hasAwait)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 9351, 9544);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 9413, 9521);

                                awaitableType = f_10374_9429_9520(f_10374_9429_9455(originalBinder), WellKnownType.System_Threading_Tasks_ValueTask);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 9351, 9544);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 9566, 9578);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 9273, 9597);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 9617, 9672);

                        f_10374_9617_9671(!fromExpression || (DynAbs.Tracing.TraceSender.Expression_False(10374, 9630, 9670) || expressionOpt != null));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 9690, 9767);

                        TypeSymbol?
                        type = (DynAbs.Tracing.TraceSender.Conditional_F1(10374, 9709, 9723) || ((fromExpression && DynAbs.Tracing.TraceSender.Conditional_F2(10374, 9726, 9745)) || DynAbs.Tracing.TraceSender.Conditional_F3(10374, 9748, 9766))) ? f_10374_9726_9745(expressionOpt!) : declarationTypeOpt
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 10061, 12721) || true) && (type is object && (DynAbs.Tracing.TraceSender.Expression_True(10374, 10065, 10115) && (f_10374_10084_10102(type) || (DynAbs.Tracing.TraceSender.Expression_False(10374, 10084, 10114) || hasAwait))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 10061, 12721);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 10157, 10413);

                            BoundExpression?
                            receiver = (DynAbs.Tracing.TraceSender.Conditional_F1(10374, 10185, 10199) || ((fromExpression
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10374, 10250, 10263)) || DynAbs.Tracing.TraceSender.Conditional_F3(10374, 10314, 10412))) ? expressionOpt
                            : new BoundLocal(syntax, f_10374_10337_10367(declarationsOpt[0]), null, type) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10374, 10314, 10412) }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 10437, 10704);

                            DiagnosticBag
                            patternDiagnostics = (DynAbs.Tracing.TraceSender.Conditional_F1(10374, 10472, 10555) || ((f_10374_10472_10555(f_10374_10472_10498(originalBinder), MessageID.IDS_FeatureUsingDeclarations) && DynAbs.Tracing.TraceSender.Conditional_F2(10374, 10614, 10625)) || DynAbs.Tracing.TraceSender.Conditional_F3(10374, 10684, 10703))) ? diagnostics
                            : f_10374_10684_10703()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 10726, 10846);

                            MethodSymbol
                            disposeMethod = f_10374_10755_10845(originalBinder, receiver, syntax, hasAwait, patternDiagnostics)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 10868, 12702) || true) && (disposeMethod is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 10868, 12702);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 10945, 11067);

                                f_10374_10945_11066(MessageID.IDS_FeatureUsingDeclarations, diagnostics, f_10374_11022_11048(originalBinder), f_10374_11050_11065(syntax));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 11095, 11190);

                                var
                                argumentsBuilder = f_10374_11118_11189(f_10374_11160_11188(disposeMethod))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 11216, 11259);

                                ImmutableArray<int>
                                argsToParams = default
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 11285, 11336);

                                bool
                                expanded = f_10374_11301_11335(disposeMethod)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 11362, 12309);

                                f_10374_11362_12308(originalBinder, DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(usingBinderOpt, 10374, 11863, 11886)?._syntax ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax?>(10374, 11863, 11896) ?? syntax), f_10374_11927_11951(disposeMethod), argumentsBuilder, argumentRefKindsBuilder: null, ref argsToParams, out defaultArguments, expanded, enableCallerInfo: true, patternDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 12337, 12477);

                                patternDisposeInfo = f_10374_12358_12476(disposeMethod, f_10374_12396_12433(argumentsBuilder), argsToParams, defaultArguments, expanded);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 12503, 12641) || true) && (hasAwait)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 12503, 12641);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 12573, 12614);

                                    awaitableType = f_10374_12589_12613(disposeMethod);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 12503, 12641);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 12667, 12679);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 10868, 12702);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 10061, 12721);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 12741, 13647) || true) && (type is null || (DynAbs.Tracing.TraceSender.Expression_False(10374, 12745, 12780) || !f_10374_12762_12780(type)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 12741, 13647);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 12915, 12981);

                            TypeSymbol
                            alternateInterface = f_10374_12947_12980(!hasAwait)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 13003, 13043);

                            HashSet<DiagnosticInfo>?
                            ignored = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 13065, 13166);

                            Conversion
                            alternateConversion = f_10374_13098_13165(fromExpression, alternateInterface, ref ignored)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 13190, 13239);

                            bool
                            wrongAsync = alternateConversion.IsImplicit
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 13261, 13520);

                            ErrorCode
                            errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10374, 13283, 13293) || ((wrongAsync
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10374, 13321, 13416)) || DynAbs.Tracing.TraceSender.Conditional_F3(10374, 13444, 13519))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(10374, 13322, 13330) || ((hasAwait && DynAbs.Tracing.TraceSender.Conditional_F2(10374, 13333, 13375)) || DynAbs.Tracing.TraceSender.Conditional_F3(10374, 13378, 13415))) ? ErrorCode.ERR_NoConvToIAsyncDispWrongAsync : ErrorCode.ERR_NoConvToIDispWrongAsync)
                            : ((DynAbs.Tracing.TraceSender.Conditional_F1(10374, 13445, 13453) || ((hasAwait && DynAbs.Tracing.TraceSender.Conditional_F2(10374, 13456, 13488)) || DynAbs.Tracing.TraceSender.Conditional_F3(10374, 13491, 13518))) ? ErrorCode.ERR_NoConvToIAsyncDisp : ErrorCode.ERR_NoConvToIDisp)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 13544, 13628);

                            f_10374_13544_13627(diagnostics, errorCode, syntax, declarationTypeOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10374, 13582, 13626) ?? f_10374_13604_13626(expressionOpt!)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 12741, 13647);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 13667, 13680);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10374, 8718, 13695);

                        Microsoft.CodeAnalysis.CSharp.Conversion
                        f_10374_9026_9105(bool
                        fromExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        targetInterface, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        diag)
                        {
                            var return_v = classifyConversion(fromExpression, targetInterface, ref diag);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 9026, 9105);
                            return return_v;
                        }


                        bool
                        f_10374_9209_9252(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                        node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        useSiteDiagnostics)
                        {
                            var return_v = diagnostics.Add(node, useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 9209, 9252);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10374_9429_9455(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 9429, 9455);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10374_9429_9520(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.WellKnownType
                        type)
                        {
                            var return_v = this_param.GetWellKnownType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 9429, 9520);
                            return return_v;
                        }


                        int
                        f_10374_9617_9671(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 9617, 9671);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10374_9726_9745(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 9726, 9745);
                            return return_v;
                        }


                        bool
                        f_10374_10084_10102(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsRefLikeType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 10084, 10102);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                        f_10374_10337_10367(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                        this_param)
                        {
                            var return_v = this_param.LocalSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 10337, 10367);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10374_10472_10498(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 10472, 10498);
                            return return_v;
                        }


                        bool
                        f_10374_10472_10555(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation, Microsoft.CodeAnalysis.CSharp.MessageID
                        feature)
                        {
                            var return_v = compilation.IsFeatureEnabled(feature);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 10472, 10555);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticBag
                        f_10374_10684_10703()
                        {
                            var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 10684, 10703);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10374_10755_10845(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        expr, Microsoft.CodeAnalysis.SyntaxNode
                        syntaxNode, bool
                        hasAwait, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = this_param.TryFindDisposePatternMethod(expr, syntaxNode, hasAwait, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 10755, 10845);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10374_11022_11048(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 11022, 11048);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10374_11050_11065(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 11050, 11065);
                            return return_v;
                        }


                        bool
                        f_10374_10945_11066(Microsoft.CodeAnalysis.CSharp.MessageID
                        feature, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            var return_v = feature.CheckFeatureAvailability(diagnostics, (Microsoft.CodeAnalysis.Compilation)compilation, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 10945, 11066);
                            return return_v;
                        }


                        int
                        f_10374_11160_11188(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ParameterCount;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 11160, 11188);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        f_10374_11118_11189(int
                        capacity)
                        {
                            var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 11118, 11189);
                            return return_v;
                        }


                        bool
                        f_10374_11301_11335(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        member)
                        {
                            var return_v = member.HasParamsParameter();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 11301, 11335);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10374_11927_11951(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 11927, 11951);
                            return return_v;
                        }


                        int
                        f_10374_11362_12308(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.SyntaxNode
                        node, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        parameters, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        argumentsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>?
                        argumentRefKindsBuilder, ref System.Collections.Immutable.ImmutableArray<int>
                        argsToParamsOpt, out Microsoft.CodeAnalysis.BitVector
                        defaultArguments, bool
                        expanded, bool
                        enableCallerInfo, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            this_param.BindDefaultArguments(node, parameters, argumentsBuilder, argumentRefKindsBuilder: argumentRefKindsBuilder, ref argsToParamsOpt, out defaultArguments, expanded, enableCallerInfo: enableCallerInfo, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 11362, 12308);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        f_10374_12396_12433(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        this_param)
                        {
                            var return_v = this_param.ToImmutableAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 12396, 12433);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                        f_10374_12358_12476(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        Method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        Arguments, System.Collections.Immutable.ImmutableArray<int>
                        ArgsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                        DefaultArguments, bool
                        Expanded)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo(Method, Arguments, ArgsToParamsOpt, DefaultArguments, Expanded);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 12358, 12476);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10374_12589_12613(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 12589, 12613);
                            return return_v;
                        }


                        bool
                        f_10374_12762_12780(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsErrorType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 12762, 12780);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10374_12947_12980(bool
                        isAsync)
                        {
                            var return_v = getDisposableInterface(isAsync);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 12947, 12980);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Conversion
                        f_10374_13098_13165(bool
                        fromExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        targetInterface, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        diag)
                        {
                            var return_v = classifyConversion(fromExpression, targetInterface, ref diag);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 13098, 13165);
                            return return_v;
                        }


                        object
                        f_10374_13604_13626(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Display;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 13604, 13626);
                            return return_v;
                        }


                        int
                        f_10374_13544_13627(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.SyntaxNode
                        syntax, params object[]
                        args)
                        {
                            Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 13544, 13627);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10374, 8718, 13695);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 8718, 13695);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                Conversion classifyConversion(bool fromExpression, TypeSymbol targetInterface, ref HashSet<DiagnosticInfo>? diag)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10374, 13711, 14159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 13857, 14144);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10374, 13864, 13878) || ((fromExpression && DynAbs.Tracing.TraceSender.Conditional_F2(10374, 13902, 14011)) || DynAbs.Tracing.TraceSender.Conditional_F3(10374, 14035, 14143))) ? f_10374_13902_14011(f_10374_13902_13928(originalBinder), expressionOpt, targetInterface, ref diag) : f_10374_14035_14143(f_10374_14035_14061(originalBinder), declarationTypeOpt, targetInterface, ref diag);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10374, 13711, 14159);

                        Microsoft.CodeAnalysis.CSharp.Conversions
                        f_10374_13902_13928(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Conversions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 13902, 13928);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Conversion
                        f_10374_13902_14011(Microsoft.CodeAnalysis.CSharp.Conversions
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 13902, 14011);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Conversions
                        f_10374_14035_14061(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Conversions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 14035, 14061);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Conversion
                        f_10374_14035_14143(Microsoft.CodeAnalysis.CSharp.Conversions
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.ClassifyImplicitConversionFromType(source, destination, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 14035, 14143);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10374, 13711, 14159);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 13711, 14159);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                TypeSymbol getDisposableInterface(bool isAsync)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10374, 14175, 14488);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 14255, 14473);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10374, 14262, 14269) || ((isAsync
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10374, 14293, 14375)) || DynAbs.Tracing.TraceSender.Conditional_F3(10374, 14399, 14472))) ? f_10374_14293_14375(f_10374_14293_14319(originalBinder), WellKnownType.System_IAsyncDisposable) : f_10374_14399_14472(f_10374_14399_14425(originalBinder), SpecialType.System_IDisposable);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10374, 14175, 14488);

                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10374_14293_14319(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 14293, 14319);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10374_14293_14375(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.WellKnownType
                        type)
                        {
                            var return_v = this_param.GetWellKnownType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 14293, 14375);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10374_14399_14425(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 14399, 14425);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10374_14399_14472(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.SpecialType
                        specialType)
                        {
                            var return_v = this_param.GetSpecialType(specialType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 14399, 14472);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10374, 14175, 14488);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 14175, 14488);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10374, 3839, 14499);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10374_4120_4133(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 4120, 4133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10374_4231_4244(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 4231, 4244);
                    return return_v;
                }


                int
                f_10374_4349_4407(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 4349, 4407);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10374_4457_4489(bool
                isAsync)
                {
                    var return_v = getDisposableInterface(isAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 4457, 4489);
                    return return_v;
                }


                int
                f_10374_4506_4555(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 4506, 4555);
                    return 0;
                }


                bool
                f_10374_4587_4685(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 4587, 4685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10374_5172_5237(Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    var return_v = this_param.BindTargetExpression(diagnostics, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 5172, 5237);
                    return return_v;
                }


                bool
                f_10374_5270_5408(bool
                fromExpression, out Microsoft.CodeAnalysis.CSharp.Conversion
                iDisposableConversion, out Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                patternDisposeInfo, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                awaitableType)
                {
                    var return_v = populateDisposableConversionOrDisposeMethod(fromExpression: fromExpression, out iDisposableConversion, out patternDisposeInfo, out awaitableType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 5270, 5408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10374_5542_5595(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 5542, 5595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10374_5650_5787(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                nodeOpt, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                localKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
                declarations)
                {
                    var return_v = this_param.BindForOrUsingOrFixedDeclarations(nodeOpt, localKind, diagnostics, out declarations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 5650, 5787);
                    return return_v;
                }


                bool
                f_10374_5821_5845_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 5821, 5845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?
                f_10374_5849_5883(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.DeclaredTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 5849, 5883);
                    return return_v;
                }


                int
                f_10374_5808_5892(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 5808, 5892);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
                f_10374_5937_6007(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
                localDeclarations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations((Microsoft.CodeAnalysis.SyntaxNode)syntax, localDeclarations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 5937, 6007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10374_6047_6087(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 6047, 6087);
                    return return_v;
                }


                bool
                f_10374_6112_6142(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 6112, 6142);
                    return return_v;
                }


                bool
                f_10374_6425_6564(bool
                fromExpression, out Microsoft.CodeAnalysis.CSharp.Conversion
                iDisposableConversion, out Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                patternDisposeInfo, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                awaitableType)
                {
                    var return_v = populateDisposableConversionOrDisposeMethod(fromExpression: fromExpression, out iDisposableConversion, out patternDisposeInfo, out awaitableType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 6425, 6564);
                    return return_v;
                }


                int
                f_10374_6819_6923(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    this_param.ReportBadAwaitDiagnostics(node, location, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 6819, 6923);
                    return 0;
                }


                bool
                f_10374_7290_7359(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 7290, 7359);
                    return return_v;
                }


                uint
                f_10374_7454_7484(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 7454, 7484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                f_10374_7400_7503(Microsoft.CodeAnalysis.SyntaxNode
                syntax, uint
                valEscape, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder(syntax, valEscape: valEscape, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 7400, 7503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                f_10374_7400_7527(Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                node)
                {
                    var return_v = node.MakeCompilerGenerated<Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 7400, 7527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10374_7561_7638(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                placeholder, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    var return_v = this_param.BindAwaitInfo(placeholder, node, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 7561, 7638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations
                f_10374_7977_8097(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                patternDisposeInfoOpt, Microsoft.CodeAnalysis.CSharp.Conversion
                iDisposableConversion, Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                awaitOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
                localDeclarations, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations(syntax, patternDisposeInfoOpt, iDisposableConversion, awaitOpt, localDeclarations, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 7977, 8097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10374_8236_8269(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 8236, 8269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10374_8191_8283(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPossibleEmbeddedStatement(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 8191, 8283);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10374_8402_8423(Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 8402, 8423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                f_10374_8311_8686(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations?
                declarationsOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expressionOpt, Microsoft.CodeAnalysis.CSharp.Conversion
                iDisposableConversion, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                awaitOpt, Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                patternDisposeInfoOpt, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundUsingStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, locals, declarationsOpt, expressionOpt, iDisposableConversion, body, awaitOpt, patternDisposeInfoOpt, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10374, 8311, 8686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10374, 3839, 14499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 3839, 14499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10374, 14511, 14797);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 14635, 14733) || true) && (_syntax == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10374, 14635, 14733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 14699, 14718);

                    return f_10374_14706_14717(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10374, 14635, 14733);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 14749, 14786);

                throw f_10374_14755_14785();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10374, 14511, 14797);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10374_14706_14717(Microsoft.CodeAnalysis.CSharp.UsingStatementBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 14706, 14717);
                    return return_v;
                }


                System.Exception
                f_10374_14755_14785()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 14755, 14785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10374, 14511, 14797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 14511, 14797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10374, 14809, 15003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 14955, 14992);

                throw f_10374_14961_14991();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10374, 14809, 15003);

                System.Exception
                f_10374_14961_14991()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10374, 14961, 14991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10374, 14809, 15003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 14809, 15003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10374, 15084, 15150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10374, 15120, 15135);

                    return _syntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10374, 15084, 15150);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10374, 15015, 15161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 15015, 15161);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static UsingStatementBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10374, 539, 15168);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10374, 539, 15168);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10374, 539, 15168);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10374, 539, 15168);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10374_771_780_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10374, 676, 834);
            return return_v;
        }

    }
}
