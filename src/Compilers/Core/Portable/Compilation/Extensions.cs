// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Threading;

namespace Microsoft.CodeAnalysis
{
    public static class ModelExtensions
    {
        public static SymbolInfo GetSymbolInfo(this SemanticModel semanticModel, SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 767, 1018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 947, 1007);

                return f_152_954_1006(semanticModel, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 767, 1018);

                Microsoft.CodeAnalysis.SymbolInfo
                f_152_954_1006(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfo(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 954, 1006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 767, 1018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 767, 1018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSpeculativeSymbolInfo(this SemanticModel semanticModel, int position, SyntaxNode expression, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 2473, 2752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 2658, 2741);

                return f_152_2665_2740(semanticModel, position, expression, bindingOption);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 2473, 2752);

                Microsoft.CodeAnalysis.SymbolInfo
                f_152_2665_2740(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.SyntaxNode
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeSymbolInfo(position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 2665, 2740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 2473, 2752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 2473, 2752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeInfo GetTypeInfo(this SemanticModel semanticModel, SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 3164, 3409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 3340, 3398);

                return f_152_3347_3397(semanticModel, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 3164, 3409);

                Microsoft.CodeAnalysis.TypeInfo
                f_152_3347_3397(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetTypeInfo(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 3347, 3397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 3164, 3409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 3164, 3409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IAliasSymbol? GetAliasInfo(this SemanticModel semanticModel, SyntaxNode nameSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 3890, 4154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 4078, 4143);

                return f_152_4085_4142(semanticModel, nameSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 3890, 4154);

                Microsoft.CodeAnalysis.IAliasSymbol?
                f_152_4085_4142(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                nameSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAliasInfo(nameSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 4085, 4142);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 3890, 4154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 3890, 4154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IAliasSymbol? GetSpeculativeAliasInfo(this SemanticModel semanticModel, int position, SyntaxNode nameSyntax, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 5410, 5690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 5597, 5679);

                return f_152_5604_5678(semanticModel, position, nameSyntax, bindingOption);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 5410, 5690);

                Microsoft.CodeAnalysis.IAliasSymbol?
                f_152_5604_5678(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.SyntaxNode
                nameSyntax, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeAliasInfo(position, nameSyntax, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 5604, 5678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 5410, 5690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 5410, 5690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeInfo GetSpeculativeTypeInfo(this SemanticModel semanticModel, int position, SyntaxNode expression, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 7145, 7418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 7326, 7407);

                return f_152_7333_7406(semanticModel, position, expression, bindingOption);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 7145, 7418);

                Microsoft.CodeAnalysis.TypeInfo
                f_152_7333_7406(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.SyntaxNode
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeTypeInfo(position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 7333, 7406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 7145, 7418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 7145, 7418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymbol? GetDeclaredSymbol(this SemanticModel semanticModel, SyntaxNode declaration, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 8122, 8400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 8311, 8389);

                return f_152_8318_8388(semanticModel, declaration, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 8122, 8400);

                Microsoft.CodeAnalysis.ISymbol?
                f_152_8318_8388(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                declaration, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbolForNode(declaration, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 8318, 8388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 8122, 8400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 8122, 8400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<ISymbol> GetMemberGroup(this SemanticModel semanticModel, SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 8757, 9023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 8951, 9012);

                return f_152_8958_9011(semanticModel, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 8757, 9023);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_152_8958_9011(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetMemberGroup(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 8958, 9011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 8757, 9023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 8757, 9023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ControlFlowAnalysis AnalyzeControlFlow(this SemanticModel semanticModel, SyntaxNode firstStatement, SyntaxNode lastStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 9149, 9395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 9313, 9384);

                return f_152_9320_9383(semanticModel, firstStatement, lastStatement);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 9149, 9395);

                Microsoft.CodeAnalysis.ControlFlowAnalysis
                f_152_9320_9383(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                firstStatement, Microsoft.CodeAnalysis.SyntaxNode
                lastStatement)
                {
                    var return_v = this_param.AnalyzeControlFlow(firstStatement, lastStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 9320, 9383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 9149, 9395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 9149, 9395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ControlFlowAnalysis AnalyzeControlFlow(this SemanticModel semanticModel, SyntaxNode statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 9521, 9716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 9654, 9705);

                return f_152_9661_9704(semanticModel, statement);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 9521, 9716);

                Microsoft.CodeAnalysis.ControlFlowAnalysis
                f_152_9661_9704(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                statement)
                {
                    var return_v = this_param.AnalyzeControlFlow(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 9661, 9704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 9521, 9716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 9521, 9716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DataFlowAnalysis AnalyzeDataFlow(this SemanticModel semanticModel, SyntaxNode firstStatement, SyntaxNode lastStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 9839, 10076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 9997, 10065);

                return f_152_10004_10064(semanticModel, firstStatement, lastStatement);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 9839, 10076);

                Microsoft.CodeAnalysis.DataFlowAnalysis
                f_152_10004_10064(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                firstStatement, Microsoft.CodeAnalysis.SyntaxNode
                lastStatement)
                {
                    var return_v = this_param.AnalyzeDataFlow(firstStatement, lastStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 10004, 10064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 9839, 10076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 9839, 10076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DataFlowAnalysis AnalyzeDataFlow(this SemanticModel semanticModel, SyntaxNode statementOrExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(152, 10199, 10409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(152, 10338, 10398);

                return f_152_10345_10397(semanticModel, statementOrExpression);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(152, 10199, 10409);

                Microsoft.CodeAnalysis.DataFlowAnalysis
                f_152_10345_10397(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                statementOrExpression)
                {
                    var return_v = this_param.AnalyzeDataFlow(statementOrExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(152, 10345, 10397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(152, 10199, 10409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 10199, 10409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ModelExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(152, 313, 10416);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(152, 313, 10416);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(152, 313, 10416);
        }

    }
}
