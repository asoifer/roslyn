// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class InitializerRewriter
    {
        internal static BoundTypeOrInstanceInitializers RewriteConstructor(ImmutableArray<BoundInitializer> boundInitializers, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10435, 582, 1246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 746, 789);

                f_10435_746_788(f_10435_759_787_M(!boundInitializers.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 803, 918);

                f_10435_803_917((f_10435_817_834(method) == MethodKind.Constructor) || (DynAbs.Tracing.TraceSender.Expression_False(10435, 816, 916) || (f_10435_866_883(method) == MethodKind.StaticConstructor)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 934, 988);

                var
                sourceMethod = method as SourceMemberMethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 1002, 1104);

                var
                syntax = (DynAbs.Tracing.TraceSender.Conditional_F1(10435, 1015, 1045) || ((((object)sourceMethod != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10435, 1048, 1071)) || DynAbs.Tracing.TraceSender.Conditional_F3(10435, 1074, 1103))) ? f_10435_1048_1071(sourceMethod) : f_10435_1074_1103(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 1118, 1235);

                return f_10435_1125_1234(syntax, boundInitializers.SelectAsArray(RewriteInitializersAsStatements));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10435, 582, 1246);

                bool
                f_10435_759_787_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 759, 787);
                    return return_v;
                }


                int
                f_10435_746_788(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 746, 788);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10435_817_834(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 817, 834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10435_866_883(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 866, 883);
                    return return_v;
                }


                int
                f_10435_803_917(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 803, 917);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10435_1048_1071(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 1048, 1071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10435_1074_1103(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 1074, 1103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers
                f_10435_1125_1234(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers((Microsoft.CodeAnalysis.SyntaxNode)syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 1125, 1234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10435, 582, 1246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10435, 582, 1246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundTypeOrInstanceInitializers RewriteScriptInitializer(ImmutableArray<BoundInitializer> boundInitializers, SynthesizedInteractiveInitializerMethod method, out bool hasTrailingExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10435, 1258, 3858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 1487, 1530);

                f_10435_1487_1529(f_10435_1500_1528_M(!boundInitializers.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 1546, 1635);

                var
                boundStatements = f_10435_1568_1634(boundInitializers.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 1649, 1694);

                var
                submissionResultType = f_10435_1676_1693(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 1708, 1775);

                var
                hasSubmissionResultType = (object)submissionResultType != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 1789, 1825);

                BoundStatement
                lastStatement = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 1839, 1881);

                BoundExpression
                trailingExpression = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 1897, 3148);
                    foreach (var initializer in f_10435_1925_1942_I(boundInitializers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10435, 1897, 3148);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 2254, 3047) || true) && (hasSubmissionResultType && (DynAbs.Tracing.TraceSender.Expression_True(10435, 2258, 2347) && (initializer == boundInitializers.Last())) && (DynAbs.Tracing.TraceSender.Expression_True(10435, 2258, 2430) && (f_10435_2373_2389(initializer) == BoundKind.GlobalStatementInitializer)) && (DynAbs.Tracing.TraceSender.Expression_True(10435, 2258, 2529) && f_10435_2455_2529(f_10435_2455_2482(method), f_10435_2506_2528(initializer))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10435, 2254, 3047);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 2571, 2644);

                            lastStatement = f_10435_2587_2643(((BoundGlobalStatementInitializer)initializer));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 2666, 2726);

                            var
                            expression = f_10435_2683_2725(lastStatement)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 2748, 3028) || true) && (expression != null && (DynAbs.Tracing.TraceSender.Expression_True(10435, 2752, 2830) && (object)f_10435_2807_2822(expression) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10435, 2752, 2888) && !f_10435_2860_2888(f_10435_2860_2875(expression))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10435, 2748, 3028);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 2938, 2970);

                                trailingExpression = expression;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 2996, 3005);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10435, 2748, 3028);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10435, 2254, 3047);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 3067, 3133);

                        f_10435_3067_3132(
                                        boundStatements, f_10435_3087_3131(initializer));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10435, 1897, 3148);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10435, 1, 1252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10435, 1, 1252);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 3164, 3719) || true) && (hasSubmissionResultType && (DynAbs.Tracing.TraceSender.Expression_True(10435, 3168, 3223) && (trailingExpression != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10435, 3164, 3719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 3257, 3306);

                    f_10435_3257_3305(!f_10435_3271_3304(submissionResultType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 3459, 3561);

                    f_10435_3459_3560(
                                    // Note: The trailing expression was already converted to the submission result type in Binder.BindGlobalStatement.
                                    boundStatements, f_10435_3479_3559(lastStatement.Syntax, RefKind.None, trailingExpression));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 3579, 3608);

                    hasTrailingExpression = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10435, 3164, 3719);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10435, 3164, 3719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 3674, 3704);

                    hasTrailingExpression = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10435, 3164, 3719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 3735, 3847);

                return f_10435_3742_3846(f_10435_3778_3807(method), f_10435_3809_3845(boundStatements));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10435, 1258, 3858);

                bool
                f_10435_1500_1528_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 1500, 1528);
                    return return_v;
                }


                int
                f_10435_1487_1529(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 1487, 1529);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10435_1568_1634(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 1568, 1634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10435_1676_1693(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                this_param)
                {
                    var return_v = this_param.ResultType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 1676, 1693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10435_2373_2389(Microsoft.CodeAnalysis.CSharp.BoundInitializer
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 2373, 2389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10435_2455_2482(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 2455, 2482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10435_2506_2528(Microsoft.CodeAnalysis.CSharp.BoundInitializer
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 2506, 2528);
                    return return_v;
                }


                bool
                f_10435_2455_2529(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                tree)
                {
                    var return_v = this_param.IsSubmissionSyntaxTree(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 2455, 2529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10435_2587_2643(Microsoft.CodeAnalysis.CSharp.BoundGlobalStatementInitializer
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 2587, 2643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10435_2683_2725(Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = GetTrailingScriptExpression(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 2683, 2725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10435_2807_2822(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 2807, 2822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10435_2860_2875(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 2860, 2875);
                    return return_v;
                }


                bool
                f_10435_2860_2888(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 2860, 2888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10435_3087_3131(Microsoft.CodeAnalysis.CSharp.BoundInitializer
                initializer)
                {
                    var return_v = RewriteInitializersAsStatements(initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 3087, 3131);
                    return return_v;
                }


                int
                f_10435_3067_3132(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 3067, 3132);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                f_10435_1925_1942_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 1925, 1942);
                    return return_v;
                }


                bool
                f_10435_3271_3304(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 3271, 3304);
                    return return_v;
                }


                int
                f_10435_3257_3305(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 3257, 3305);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10435_3479_3559(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expressionOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundReturnStatement(syntax, refKind, expressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 3479, 3559);
                    return return_v;
                }


                int
                f_10435_3459_3560(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 3459, 3560);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10435_3778_3807(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 3778, 3807);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10435_3809_3845(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 3809, 3845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers
                f_10435_3742_3846(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers((Microsoft.CodeAnalysis.SyntaxNode)syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 3742, 3846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10435, 1258, 3858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10435, 1258, 3858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundExpression GetTrailingScriptExpression(BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10435, 4052, 4396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 4162, 4385);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10435, 4169, 4292) || (((f_10435_4170_4184(statement) == BoundKind.ExpressionStatement) && (DynAbs.Tracing.TraceSender.Expression_True(10435, 4169, 4292) && ((ExpressionStatementSyntax)statement.Syntax).SemicolonToken.IsMissing) && DynAbs.Tracing.TraceSender.Conditional_F2(10435, 4312, 4360)) || DynAbs.Tracing.TraceSender.Conditional_F3(10435, 4380, 4384))) ? f_10435_4312_4360(((BoundExpressionStatement)statement)) : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10435, 4052, 4396);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10435_4170_4184(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 4170, 4184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10435_4312_4360(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 4312, 4360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10435, 4052, 4396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10435, 4052, 4396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundStatement RewriteFieldInitializer(BoundFieldEqualsValue fieldInit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10435, 4408, 5926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 4519, 4556);

                SyntaxNode
                syntax = fieldInit.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 4593, 4700);

                syntax = ((DynAbs.Tracing.TraceSender.Conditional_F1(10435, 4604, 4639) || (((syntax is EqualsValueClauseSyntax) && DynAbs.Tracing.TraceSender.Conditional_F2(10435, 4642, 4681)) || DynAbs.Tracing.TraceSender.Conditional_F3(10435, 4684, 4688))) ? f_10435_4642_4681(((EqualsValueClauseSyntax)syntax)) : null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?>(10435, 4603, 4699) ?? syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 4779, 4937);

                var
                boundReceiver = (DynAbs.Tracing.TraceSender.Conditional_F1(10435, 4799, 4823) || ((f_10435_4799_4823(f_10435_4799_4814(fieldInit)) && DynAbs.Tracing.TraceSender.Conditional_F2(10435, 4826, 4830)) || DynAbs.Tracing.TraceSender.Conditional_F3(10435, 4874, 4936))) ? null : f_10435_4874_4936(syntax, f_10435_4905_4935(f_10435_4905_4920(fieldInit)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 4953, 5541);

                BoundStatement
                boundStatement =
                                new BoundExpressionStatement(syntax,
                                    new BoundAssignmentOperator(syntax,
                f_10435_5121_5292(syntax, boundReceiver, f_10435_5223_5238(fieldInit), constantValueOpt: null),
                f_10435_5319_5334(fieldInit),
                f_10435_5361_5381(f_10435_5361_5376(fieldInit)))
                                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10435, 5060, 5435) })
                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_10435_5479_5504_M(!fieldInit.Locals.IsEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(10435, 5479, 5538) || f_10435_5508_5538(fieldInit)), 10435, 5002, 5540) }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 5557, 5790) || true) && (f_10435_5561_5586_M(!fieldInit.Locals.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10435, 5557, 5790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 5620, 5775);

                    boundStatement = new BoundBlock(syntax, f_10435_5660_5676(fieldInit), f_10435_5678_5715(boundStatement)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_10435_5742_5772(fieldInit), 10435, 5637, 5774) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10435, 5557, 5790);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 5806, 5879);

                f_10435_5806_5878(f_10435_5819_5877(boundStatement));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 5893, 5915);

                return boundStatement;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10435, 4408, 5926);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10435_4642_4681(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 4642, 4681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10435_4799_4814(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                this_param)
                {
                    var return_v = this_param.Field;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 4799, 4814);
                    return return_v;
                }


                bool
                f_10435_4799_4823(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 4799, 4823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10435_4905_4920(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                this_param)
                {
                    var return_v = this_param.Field;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 4905, 4920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10435_4905_4935(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 4905, 4935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10435_4874_4936(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundThisReference(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 4874, 4936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10435_5223_5238(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                this_param)
                {
                    var return_v = this_param.Field;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 5223, 5238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10435_5121_5292(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundThisReference?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression?)receiver, fieldSymbol, constantValueOpt: constantValueOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 5121, 5292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10435_5319_5334(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 5319, 5334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10435_5361_5376(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                this_param)
                {
                    var return_v = this_param.Field;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 5361, 5376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10435_5361_5381(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 5361, 5381);
                    return return_v;
                }


                bool
                f_10435_5479_5504_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 5479, 5504);
                    return return_v;
                }


                bool
                f_10435_5508_5538(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 5508, 5538);
                    return return_v;
                }


                bool
                f_10435_5561_5586_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 5561, 5586);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10435_5660_5676(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 5660, 5676);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10435_5678_5715(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 5678, 5715);
                    return return_v;
                }


                bool
                f_10435_5742_5772(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 5742, 5772);
                    return return_v;
                }


                bool
                f_10435_5819_5877(Microsoft.CodeAnalysis.CSharp.BoundStatement
                initializer)
                {
                    var return_v = LocalRewriter.IsFieldOrPropertyInitializer(initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 5819, 5877);
                    return return_v;
                }


                int
                f_10435_5806_5878(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 5806, 5878);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10435, 4408, 5926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10435, 4408, 5926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundStatement RewriteInitializersAsStatements(BoundInitializer initializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10435, 5938, 6512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 6054, 6501);

                switch (f_10435_6062_6078(initializer))
                {

                    case BoundKind.FieldEqualsValue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10435, 6054, 6501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 6166, 6233);

                        return f_10435_6173_6232(initializer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10435, 6054, 6501);

                    case BoundKind.GlobalStatementInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10435, 6054, 6501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 6315, 6379);

                        return f_10435_6322_6378(((BoundGlobalStatementInitializer)initializer));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10435, 6054, 6501);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10435, 6054, 6501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10435, 6427, 6486);

                        throw f_10435_6433_6485(f_10435_6468_6484(initializer));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10435, 6054, 6501);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10435, 5938, 6512);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10435_6062_6078(Microsoft.CodeAnalysis.CSharp.BoundInitializer
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 6062, 6078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10435_6173_6232(Microsoft.CodeAnalysis.CSharp.BoundInitializer
                fieldInit)
                {
                    var return_v = RewriteFieldInitializer((Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue)fieldInit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 6173, 6232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10435_6322_6378(Microsoft.CodeAnalysis.CSharp.BoundGlobalStatementInitializer
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 6322, 6378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10435_6468_6484(Microsoft.CodeAnalysis.CSharp.BoundInitializer
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10435, 6468, 6484);
                    return return_v;
                }


                System.Exception
                f_10435_6433_6485(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10435, 6433, 6485);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10435, 5938, 6512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10435, 5938, 6512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static InitializerRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10435, 524, 6519);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10435, 524, 6519);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10435, 524, 6519);
        }

    }
}
