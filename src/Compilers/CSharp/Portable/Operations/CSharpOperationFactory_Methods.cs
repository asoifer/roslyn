// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Operations
{
    internal sealed partial class CSharpOperationFactory
    {
        internal ImmutableArray<BoundStatement> ToStatements(BoundStatement? statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 634, 1079);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 738, 852) || true) && (statement == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 738, 852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 793, 837);

                    return ImmutableArray<BoundStatement>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 738, 852);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 868, 1012) || true) && (f_10952_872_886(statement) == BoundKind.StatementList)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 868, 1012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 947, 997);

                    return f_10952_954_996(((BoundStatementList)statement));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 868, 1012);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 1028, 1068);

                return f_10952_1035_1067(statement);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 634, 1079);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10952_872_886(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 872, 886);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10952_954_996(Microsoft.CodeAnalysis.CSharp.BoundStatementList
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 954, 996);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10952_1035_1067(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 1035, 1067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 634, 1079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 634, 1079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IInstanceReferenceOperation CreateImplicitReceiver(SyntaxNode syntax, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 1186, 1338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 1202, 1338);
                return f_10952_1202_1338(InstanceReferenceKind.ImplicitReceiver, _semanticModel, syntax, f_10952_1297_1319(type), isImplicit: true); DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 1186, 1338);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 1186, 1338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 1186, 1338);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.ITypeSymbol?
            f_10952_1297_1319(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            symbol)
            {
                var return_v = symbol.GetPublicSymbol();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 1297, 1319);
                return return_v;
            }


            Microsoft.CodeAnalysis.Operations.InstanceReferenceOperation
            f_10952_1202_1338(Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
            referenceKind, Microsoft.CodeAnalysis.SemanticModel
            semanticModel, Microsoft.CodeAnalysis.SyntaxNode
            syntax, Microsoft.CodeAnalysis.ITypeSymbol
            type, bool
            isImplicit)
            {
                var return_v = new Microsoft.CodeAnalysis.Operations.InstanceReferenceOperation(referenceKind, semanticModel, syntax, type, isImplicit: isImplicit);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 1202, 1338);
                return return_v;
            }

        }

        internal IArgumentOperation CreateArgumentOperation(ArgumentKind kind, IParameterSymbol? parameter, BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 1351, 2133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 1561, 1599);

                IOperation
                value = f_10952_1580_1598(this, expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 1636, 1808);

                (SyntaxNode syntax, bool isImplicit) = (DynAbs.Tracing.TraceSender.Conditional_F1(10952, 1675, 1722) || ((expression.Syntax is { Parent: ArgumentSyntax } && DynAbs.Tracing.TraceSender.Conditional_F2(10952, 1725, 1784)) || DynAbs.Tracing.TraceSender.Conditional_F3(10952, 1787, 1807))) ? (f_10952_1726_1750(expression.Syntax), f_10952_1752_1783(expression)) : (f_10952_1788_1800(value), true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 1822, 2122);

                return f_10952_1829_2121(kind, parameter, value, OperationFactory.IdentityConversion, OperationFactory.IdentityConversion, _semanticModel, syntax, isImplicit);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 1351, 2133);

                Microsoft.CodeAnalysis.IOperation?
                f_10952_1580_1598(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundNode)
                {
                    var return_v = this_param.Create((Microsoft.CodeAnalysis.CSharp.BoundNode)boundNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 1580, 1598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10952_1726_1750(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 1726, 1750);
                    return return_v;
                }


                bool
                f_10952_1752_1783(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 1752, 1783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10952_1788_1800(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 1788, 1800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.ArgumentOperation
                f_10952_1829_2121(Microsoft.CodeAnalysis.Operations.ArgumentKind
                argumentKind, Microsoft.CodeAnalysis.IParameterSymbol?
                parameter, Microsoft.CodeAnalysis.IOperation
                value, Microsoft.CodeAnalysis.Operations.IConvertibleConversion
                inConversion, Microsoft.CodeAnalysis.Operations.IConvertibleConversion
                outConversion, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.ArgumentOperation(argumentKind, parameter, value, inConversion, outConversion, semanticModel, syntax, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 1829, 2121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 1351, 2133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 1351, 2133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IVariableInitializerOperation? CreateVariableDeclaratorInitializer(BoundLocalDeclaration boundLocalDeclaration, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 2145, 3484);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 2309, 3445) || true) && (f_10952_2313_2349(boundLocalDeclaration) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 2309, 3445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 2391, 2428);

                    SyntaxNode?
                    initializerSyntax = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 2446, 2481);

                    bool
                    initializerIsImplicit = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 2499, 2805) || true) && (syntax is VariableDeclaratorSyntax variableDeclarator)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 2499, 2805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 2598, 2649);

                        initializerSyntax = f_10952_2618_2648(variableDeclarator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 2499, 2805);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 2499, 2805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 2731, 2786);

                        f_10952_2731_2785($"Unexpected syntax kind: {f_10952_2769_2782(syntax)}");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 2499, 2805);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 2825, 3179) || true) && (initializerSyntax == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 2825, 3179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 3045, 3109);

                        initializerSyntax = f_10952_3065_3101(boundLocalDeclaration).Syntax;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 3131, 3160);

                        initializerIsImplicit = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 2825, 3179);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 3199, 3263);

                    IOperation
                    value = f_10952_3218_3262(this, f_10952_3225_3261(boundLocalDeclaration))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 3281, 3430);

                    return f_10952_3288_3429(locals: ImmutableArray<ILocalSymbol>.Empty, value, _semanticModel, initializerSyntax, initializerIsImplicit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 2309, 3445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 3461, 3473);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 2145, 3484);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10952_2313_2349(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 2313, 2349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10952_2618_2648(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 2618, 2648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10952_2769_2782(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 2769, 2782);
                    return return_v;
                }


                int
                f_10952_2731_2785(string
                message)
                {
                    Debug.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 2731, 2785);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10952_3065_3101(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 3065, 3101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10952_3225_3261(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 3225, 3261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10952_3218_3262(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundNode)
                {
                    var return_v = this_param.Create((Microsoft.CodeAnalysis.CSharp.BoundNode)boundNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 3218, 3262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.VariableInitializerOperation
                f_10952_3288_3429(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
                locals, Microsoft.CodeAnalysis.IOperation
                value, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.VariableInitializerOperation(locals: locals, value, semanticModel, syntax, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 3288, 3429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 2145, 3484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 2145, 3484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IVariableDeclaratorOperation CreateVariableDeclaratorInternal(BoundLocalDeclaration boundLocalDeclaration, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 3496, 4178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 3654, 3728);

                ILocalSymbol
                symbol = f_10952_3676_3727(f_10952_3676_3709(boundLocalDeclaration))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 3742, 3766);

                bool
                isImplicit = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 3782, 3894);

                IVariableInitializerOperation?
                initializer = f_10952_3827_3893(this, boundLocalDeclaration, syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 3908, 4036);

                ImmutableArray<IOperation>
                ignoredDimensions = f_10952_3955_4035(this, f_10952_4000_4034(boundLocalDeclaration))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 4052, 4167);

                return f_10952_4059_4166(symbol, initializer, ignoredDimensions, _semanticModel, syntax, isImplicit);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 3496, 4178);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10952_3676_3709(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 3676, 3709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol?
                f_10952_3676_3727(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 3676, 3727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
                f_10952_3827_3893(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                boundLocalDeclaration, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.CreateVariableDeclaratorInitializer(boundLocalDeclaration, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 3827, 3893);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10952_4000_4034(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.ArgumentsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 4000, 4034);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_10952_3955_4035(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                boundNodes)
                {
                    var return_v = this_param.CreateFromArray<Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.IOperation>(boundNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 3955, 4035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.VariableDeclaratorOperation
                f_10952_4059_4166(Microsoft.CodeAnalysis.ILocalSymbol
                symbol, Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
                initializer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                ignoredArguments, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.VariableDeclaratorOperation(symbol, initializer, ignoredArguments, semanticModel, syntax, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 4059, 4166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 3496, 4178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 3496, 4178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("boundLocal")]
        internal IVariableDeclaratorOperation? CreateVariableDeclarator(BoundLocal? boundLocal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 4190, 4620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 4352, 4609);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10952, 4359, 4377) || ((boundLocal == null && DynAbs.Tracing.TraceSender.Conditional_F2(10952, 4380, 4384)) || DynAbs.Tracing.TraceSender.Conditional_F3(10952, 4387, 4608))) ? null : f_10952_4387_4608(f_10952_4419_4459(f_10952_4419_4441(boundLocal)), initializer: null, ignoredArguments: ImmutableArray<IOperation>.Empty, semanticModel: _semanticModel, syntax: boundLocal.Syntax, isImplicit: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 4190, 4620);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10952_4419_4441(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 4419, 4441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol?
                f_10952_4419_4459(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 4419, 4459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.VariableDeclaratorOperation
                f_10952_4387_4608(Microsoft.CodeAnalysis.ILocalSymbol
                symbol, Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
                initializer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                ignoredArguments, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.VariableDeclaratorOperation(symbol, initializer: initializer, ignoredArguments: ignoredArguments, semanticModel: semanticModel, syntax: syntax, isImplicit: isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 4387, 4608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 4190, 4620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 4190, 4620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IOperation? CreateReceiverOperation(BoundNode? instance, Symbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 4632, 5175);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 4738, 4864) || true) && (instance == null || (DynAbs.Tracing.TraceSender.Expression_False(10952, 4742, 4803) || f_10952_4762_4775(instance) == BoundKind.TypeExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 4738, 4864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 4837, 4849);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 4738, 4864);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 4949, 5124) || true) && (symbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10952, 4953, 4986) && f_10952_4971_4986(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10952, 4953, 5019) && f_10952_4990_5019(instance)) && (DynAbs.Tracing.TraceSender.Expression_True(10952, 4953, 5063) && f_10952_5023_5036(instance) == BoundKind.ThisReference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 4949, 5124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 5097, 5109);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 4949, 5124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 5140, 5164);

                return f_10952_5147_5163(this, instance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 4632, 5175);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10952_4762_4775(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 4762, 4775);
                    return return_v;
                }


                bool
                f_10952_4971_4986(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 4971, 4986);
                    return return_v;
                }


                bool
                f_10952_4990_5019(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 4990, 5019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10952_5023_5036(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 5023, 5036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10952_5147_5163(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                boundNode)
                {
                    var return_v = this_param.Create(boundNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 5147, 5163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 4632, 5175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 4632, 5175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsCallVirtual(MethodSymbol? targetMethod, BoundExpression? receiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 5187, 5517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 5293, 5506);

                return (object?)targetMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10952, 5300, 5349) && receiver != null) && (DynAbs.Tracing.TraceSender.Expression_True(10952, 5300, 5451) && (f_10952_5374_5396(targetMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10952, 5374, 5423) || f_10952_5400_5423(targetMethod)) || (DynAbs.Tracing.TraceSender.Expression_False(10952, 5374, 5450) || f_10952_5427_5450(targetMethod)))) && (DynAbs.Tracing.TraceSender.Expression_True(10952, 5300, 5505) && f_10952_5475_5505_M(!receiver.SuppressVirtualCalls));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 5187, 5517);

                bool
                f_10952_5374_5396(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 5374, 5396);
                    return return_v;
                }


                bool
                f_10952_5400_5423(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 5400, 5423);
                    return return_v;
                }


                bool
                f_10952_5427_5450(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 5427, 5450);
                    return return_v;
                }


                bool
                f_10952_5475_5505_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 5475, 5505);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 5187, 5517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 5187, 5517);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsMethodInvalid(LookupResultKind resultKind, MethodSymbol targetMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 5614, 5743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 5630, 5743);
                return resultKind == LookupResultKind.OverloadResolutionFailure || (DynAbs.Tracing.TraceSender.Expression_False(10952, 5630, 5743) || f_10952_5690_5722_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(targetMethod, 10952, 5690, 5722)?.OriginalDefinition) is ErrorMethodSymbol); DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 5614, 5743);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 5614, 5743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 5614, 5743);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
            f_10952_5690_5722_M(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 5690, 5722);
                return return_v;
            }

        }

        internal IEventReferenceOperation CreateBoundEventAccessOperation(BoundEventAssignmentOperator boundEventAssignmentOperator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 5756, 7094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 5905, 5961);

                SyntaxNode
                syntax = boundEventAssignmentOperator.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 6571, 6646);

                IEventSymbol
                @event = f_10952_6593_6645(f_10952_6593_6627(boundEventAssignmentOperator))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 6660, 6785);

                IOperation?
                instance = f_10952_6683_6784(this, f_10952_6707_6747(boundEventAssignmentOperator), f_10952_6749_6783(boundEventAssignmentOperator))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 6799, 6872);

                SyntaxNode
                eventAccessSyntax = f_10952_6830_6871(((AssignmentExpressionSyntax)syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 6886, 6954);

                bool
                isImplicit = f_10952_6904_6953(boundEventAssignmentOperator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 6970, 7083);

                return f_10952_6977_7082(@event, instance, _semanticModel, eventAccessSyntax, f_10952_7058_7069(@event), isImplicit);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 5756, 7094);

                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10952_6593_6627(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Event;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 6593, 6627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IEventSymbol?
                f_10952_6593_6645(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 6593, 6645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10952_6707_6747(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 6707, 6747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10952_6749_6783(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Event;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 6749, 6783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10952_6683_6784(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                instance, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol)
                {
                    var return_v = this_param.CreateReceiverOperation((Microsoft.CodeAnalysis.CSharp.BoundNode?)instance, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 6683, 6784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10952_6830_6871(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 6830, 6871);
                    return return_v;
                }


                bool
                f_10952_6904_6953(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 6904, 6953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10952_7058_7069(Microsoft.CodeAnalysis.IEventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 7058, 7069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.EventReferenceOperation
                f_10952_6977_7082(Microsoft.CodeAnalysis.IEventSymbol
                @event, Microsoft.CodeAnalysis.IOperation?
                instance, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ITypeSymbol
                type, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.EventReferenceOperation(@event, instance, semanticModel, syntax, type, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 6977, 7082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 5756, 7094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 5756, 7094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IOperation CreateDelegateTargetOperation(BoundNode delegateNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 7106, 9502);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 7204, 9491) || true) && (delegateNode is BoundConversion boundConversion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 7204, 9491);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 7289, 8213) || true) && (f_10952_7293_7323(boundConversion) == ConversionKind.MethodGroup)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 7289, 8213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 7696, 7748);

                        f_10952_7696_7747(f_10952_7709_7734(boundConversion) is not null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 7770, 8073);

                        return f_10952_7777_8072(this, f_10952_7839_7862(boundConversion), f_10952_7936_7961(boundConversion), f_10952_8035_8071(boundConversion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 7289, 8213);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 7289, 8213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 8155, 8194);

                        return f_10952_8162_8193(this, f_10952_8169_8192(boundConversion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 7289, 8213);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 7204, 9491);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 7204, 9491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 8279, 8363);

                    var
                    boundDelegateCreationExpression = (BoundDelegateCreationExpression)delegateNode
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 8381, 9476) || true) && (f_10952_8385_8430(f_10952_8385_8425(boundDelegateCreationExpression)) == BoundKind.MethodGroup && (DynAbs.Tracing.TraceSender.Expression_True(10952, 8385, 8529) && f_10952_8480_8521(boundDelegateCreationExpression) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 8381, 9476);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 9051, 9146);

                        BoundMethodGroup
                        boundMethodGroup = (BoundMethodGroup)f_10952_9105_9145(boundDelegateCreationExpression)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 9168, 9319);

                        return f_10952_9175_9318(this, boundMethodGroup, f_10952_9237_9278(boundDelegateCreationExpression), f_10952_9280_9317(boundMethodGroup));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 8381, 9476);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 8381, 9476);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 9401, 9457);

                        return f_10952_9408_9456(this, f_10952_9415_9455(boundDelegateCreationExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 8381, 9476);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 7204, 9491);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 7106, 9502);

                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10952_7293_7323(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 7293, 7323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10952_7709_7734(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.SymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 7709, 7734);
                    return return_v;
                }


                int
                f_10952_7696_7747(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 7696, 7747);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10952_7839_7862(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 7839, 7862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10952_7936_7961(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.SymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 7936, 7961);
                    return return_v;
                }


                bool
                f_10952_8035_8071(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.SuppressVirtualCalls;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 8035, 8071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
                f_10952_7777_8072(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundMethodGroup, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, bool
                suppressVirtualCalls)
                {
                    var return_v = this_param.CreateBoundMethodGroupSingleMethodOperation((Microsoft.CodeAnalysis.CSharp.BoundMethodGroup)boundMethodGroup, methodSymbol, suppressVirtualCalls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 7777, 8072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10952_8169_8192(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 8169, 8192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10952_8162_8193(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundNode)
                {
                    var return_v = this_param.Create((Microsoft.CodeAnalysis.CSharp.BoundNode)boundNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 8162, 8193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10952_8385_8425(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 8385, 8425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10952_8385_8430(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 8385, 8430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10952_8480_8521(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 8480, 8521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10952_9105_9145(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 9105, 9145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10952_9237_9278(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 9237, 9278);
                    return return_v;
                }


                bool
                f_10952_9280_9317(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.SuppressVirtualCalls;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 9280, 9317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
                f_10952_9175_9318(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                boundMethodGroup, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, bool
                suppressVirtualCalls)
                {
                    var return_v = this_param.CreateBoundMethodGroupSingleMethodOperation(boundMethodGroup, methodSymbol, suppressVirtualCalls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 9175, 9318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10952_9415_9455(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 9415, 9455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10952_9408_9456(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundNode)
                {
                    var return_v = this_param.Create((Microsoft.CodeAnalysis.CSharp.BoundNode)boundNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 9408, 9456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 7106, 9502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 7106, 9502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IOperation CreateMemberInitializerInitializedMember(BoundNode initializedMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 9514, 10157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 9630, 10146);

                switch (initializedMember)
                {

                    case BoundObjectInitializerMember objectInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 9630, 10146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 9763, 9872);

                        return f_10952_9770_9871(this, objectInitializer, isObjectOrCollectionInitializer: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 9630, 10146);

                    case BoundDynamicObjectInitializerMember dynamicInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 9630, 10146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 9972, 10050);

                        return f_10952_9979_10049(this, dynamicInitializer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 9630, 10146);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 9630, 10146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 10098, 10131);

                        return f_10952_10105_10130(this, initializedMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 9630, 10146);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 9514, 10157);

                Microsoft.CodeAnalysis.IOperation
                f_10952_9770_9871(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                boundObjectInitializerMember, bool
                isObjectOrCollectionInitializer)
                {
                    var return_v = this_param.CreateBoundObjectInitializerMemberOperation(boundObjectInitializerMember, isObjectOrCollectionInitializer: isObjectOrCollectionInitializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 9770, 9871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_10952_9979_10049(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectInitializerMember
                boundDynamicObjectInitializerMember)
                {
                    var return_v = this_param.CreateBoundDynamicObjectInitializerMemberOperation(boundDynamicObjectInitializerMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 9979, 10049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10952_10105_10130(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                boundNode)
                {
                    var return_v = this_param.Create(boundNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 10105, 10130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 9514, 10157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 9514, 10157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<IArgumentOperation> DeriveArguments(BoundNode containingExpression, bool isObjectOrCollectionInitializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 10169, 11360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 10323, 11349);

                switch (f_10952_10331_10356(containingExpression))
                {

                    case BoundKind.ObjectInitializerMember:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 10323, 11349);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 10478, 10564);

                            var
                            boundObjectInitializerMember = (BoundObjectInitializerMember)containingExpression
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 10590, 10664);

                            var
                            property = (PropertySymbol?)f_10952_10622_10663(boundObjectInitializerMember)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 10690, 10725);

                            f_10952_10690_10724(property is not null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 10751, 11216);

                            return f_10952_10758_11215(this, property, f_10952_10859_10897(boundObjectInitializerMember), f_10952_10936_10980(boundObjectInitializerMember), f_10952_11019_11064(boundObjectInitializerMember), f_10952_11103_11140(boundObjectInitializerMember), boundObjectInitializerMember.Syntax);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 10323, 11349);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 10323, 11349);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 11289, 11334);

                        return f_10952_11296_11333(this, containingExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 10323, 11349);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 10169, 11360);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10952_10331_10356(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 10331, 10356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10952_10622_10663(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 10622, 10663);
                    return return_v;
                }


                int
                f_10952_10690_10724(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 10690, 10724);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10952_10859_10897(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 10859, 10897);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10952_10936_10980(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 10936, 10980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10952_11019_11064(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 11019, 11064);
                    return return_v;
                }


                bool
                f_10952_11103_11140(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 11103, 11140);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_10952_10758_11215(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                methodOrIndexer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                boundArguments, System.Collections.Immutable.ImmutableArray<int>
                argumentsToParametersOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, bool
                expanded, Microsoft.CodeAnalysis.SyntaxNode
                invocationSyntax)
                {
                    var return_v = this_param.DeriveArguments((Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, boundArguments, argumentsToParametersOpt, defaultArguments, expanded, invocationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 10758, 11215);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_10952_11296_11333(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                containingExpression)
                {
                    var return_v = this_param.DeriveArguments(containingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 11296, 11333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 10169, 11360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 10169, 11360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<IArgumentOperation> DeriveArguments(BoundNode containingExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 11372, 14528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 11488, 14517);

                switch (f_10952_11496_11521(containingExpression))
                {

                    case BoundKind.IndexerAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 11488, 14517);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 11633, 11693);

                            var
                            boundIndexer = (BoundIndexerAccess)containingExpression
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 11719, 12133);

                            return f_10952_11726_12132(this, f_10952_11742_11762(boundIndexer), f_10952_11812_11834(boundIndexer), f_10952_11884_11912(boundIndexer), f_10952_11962_11991(boundIndexer), f_10952_12041_12062(boundIndexer), boundIndexer.Syntax);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 11488, 14517);

                    case BoundKind.ObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 11488, 14517);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 12263, 12336);

                            var
                            objectCreation = (BoundObjectCreationExpression)containingExpression
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 12362, 12792);

                            return f_10952_12369_12791(this, f_10952_12385_12411(objectCreation), f_10952_12461_12485(objectCreation), f_10952_12535_12565(objectCreation), f_10952_12615_12646(objectCreation), f_10952_12696_12719(objectCreation), objectCreation.Syntax);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 11488, 14517);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 11488, 14517);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 12902, 12950);

                            var
                            boundCall = (BoundCall)containingExpression
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 12976, 13455);

                            return f_10952_12983_13454(this, f_10952_12999_13015(boundCall), f_10952_13065_13084(boundCall), f_10952_13134_13159(boundCall), f_10952_13209_13235(boundCall), f_10952_13285_13303(boundCall), boundCall.Syntax, f_10952_13419_13453(boundCall));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 11488, 14517);

                    case BoundKind.CollectionElementInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 11488, 14517);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 13589, 13685);

                            var
                            boundCollectionElementInitializer = (BoundCollectionElementInitializer)containingExpression
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 13711, 14361);

                            return f_10952_13718_14360(this, f_10952_13734_13777(boundCollectionElementInitializer), f_10952_13827_13870(boundCollectionElementInitializer), f_10952_13920_13969(boundCollectionElementInitializer), f_10952_14019_14069(boundCollectionElementInitializer), f_10952_14119_14161(boundCollectionElementInitializer), boundCollectionElementInitializer.Syntax, f_10952_14301_14359(boundCollectionElementInitializer));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 11488, 14517);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 11488, 14517);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 14434, 14502);

                        throw f_10952_14440_14501(f_10952_14475_14500(containingExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 11488, 14517);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 11372, 14528);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10952_11496_11521(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 11496, 11521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10952_11742_11762(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 11742, 11762);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10952_11812_11834(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 11812, 11834);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10952_11884_11912(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 11884, 11912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10952_11962_11991(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 11962, 11991);
                    return return_v;
                }


                bool
                f_10952_12041_12062(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 12041, 12062);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_10952_11726_12132(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                methodOrIndexer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                boundArguments, System.Collections.Immutable.ImmutableArray<int>
                argumentsToParametersOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, bool
                expanded, Microsoft.CodeAnalysis.SyntaxNode
                invocationSyntax)
                {
                    var return_v = this_param.DeriveArguments((Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, boundArguments, argumentsToParametersOpt, defaultArguments, expanded, invocationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 11726, 12132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10952_12385_12411(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 12385, 12411);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10952_12461_12485(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 12461, 12485);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10952_12535_12565(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 12535, 12565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10952_12615_12646(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 12615, 12646);
                    return return_v;
                }


                bool
                f_10952_12696_12719(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 12696, 12719);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_10952_12369_12791(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOrIndexer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                boundArguments, System.Collections.Immutable.ImmutableArray<int>
                argumentsToParametersOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, bool
                expanded, Microsoft.CodeAnalysis.SyntaxNode
                invocationSyntax)
                {
                    var return_v = this_param.DeriveArguments((Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, boundArguments, argumentsToParametersOpt, defaultArguments, expanded, invocationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 12369, 12791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10952_12999_13015(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 12999, 13015);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10952_13065_13084(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 13065, 13084);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10952_13134_13159(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 13134, 13159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10952_13209_13235(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 13209, 13235);
                    return return_v;
                }


                bool
                f_10952_13285_13303(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 13285, 13303);
                    return return_v;
                }


                bool
                f_10952_13419_13453(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.InvokedAsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 13419, 13453);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_10952_12983_13454(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOrIndexer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                boundArguments, System.Collections.Immutable.ImmutableArray<int>
                argumentsToParametersOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, bool
                expanded, Microsoft.CodeAnalysis.SyntaxNode
                invocationSyntax, bool
                invokedAsExtensionMethod)
                {
                    var return_v = this_param.DeriveArguments((Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, boundArguments, argumentsToParametersOpt, defaultArguments, expanded, invocationSyntax, invokedAsExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 12983, 13454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10952_13734_13777(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 13734, 13777);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10952_13827_13870(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 13827, 13870);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10952_13920_13969(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 13920, 13969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10952_14019_14069(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 14019, 14069);
                    return return_v;
                }


                bool
                f_10952_14119_14161(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 14119, 14161);
                    return return_v;
                }


                bool
                f_10952_14301_14359(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.InvokedAsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 14301, 14359);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_10952_13718_14360(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOrIndexer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                boundArguments, System.Collections.Immutable.ImmutableArray<int>
                argumentsToParametersOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, bool
                expanded, Microsoft.CodeAnalysis.SyntaxNode
                invocationSyntax, bool
                invokedAsExtensionMethod)
                {
                    var return_v = this_param.DeriveArguments((Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, boundArguments, argumentsToParametersOpt, defaultArguments, expanded, invocationSyntax, invokedAsExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 13718, 14360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10952_14475_14500(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 14475, 14500);
                    return return_v;
                }


                System.Exception
                f_10952_14440_14501(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 14440, 14501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 11372, 14528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 11372, 14528);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<IArgumentOperation> DeriveArguments(
                    Symbol methodOrIndexer,
                    ImmutableArray<BoundExpression> boundArguments,
                    ImmutableArray<int> argumentsToParametersOpt,
                    BitVector defaultArguments,
                    bool expanded,
                    SyntaxNode invocationSyntax,
                    bool invokedAsExtensionMethod = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 14540, 16060);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 15312, 15496) || true) && (f_10952_15316_15347(methodOrIndexer).IsDefaultOrEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10952, 15316, 15399) && boundArguments.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 15312, 15496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 15433, 15481);

                    return ImmutableArray<IArgumentOperation>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 15312, 15496);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 15512, 16049);

                return f_10952_15519_16048(operationFactory: this, f_10952_15657_15683(_semanticModel), syntax: invocationSyntax, arguments: boundArguments, methodOrIndexer: methodOrIndexer, expanded: expanded, argsToParamsOpt: argumentsToParametersOpt, defaultArguments: defaultArguments, invokedAsExtensionMethod: invokedAsExtensionMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 14540, 16060);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10952_15316_15347(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 15316, 15347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_10952_15657_15683(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 15657, 15683);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                f_10952_15519_16048(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                operationFactory, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.CSharp.Symbol
                methodOrIndexer, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, bool
                invokedAsExtensionMethod)
                {
                    var return_v = LocalRewriter.MakeArgumentsInEvaluationOrder(operationFactory: operationFactory, compilation: (Microsoft.CodeAnalysis.CSharp.CSharpCompilation)compilation, syntax: syntax, arguments: arguments, methodOrIndexer: methodOrIndexer, expanded: expanded, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, invokedAsExtensionMethod: invokedAsExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 15519, 16048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 14540, 16060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 14540, 16060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<BoundNode> CreateInvalidChildrenFromArgumentsExpression(BoundNode? receiverOpt, ImmutableArray<BoundExpression> arguments, BoundExpression? additionalNodeOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10952, 16072, 16934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 16293, 16345);

                var
                builder = f_10952_16307_16344()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 16361, 16743) || true) && (receiverOpt != null
                && (DynAbs.Tracing.TraceSender.Expression_True(10952, 16365, 16669) && (f_10952_16405_16438_M(!receiverOpt.WasCompilerGenerated) || (DynAbs.Tracing.TraceSender.Expression_False(10952, 16405, 16668) || (f_10952_16463_16479(receiverOpt) != BoundKind.ThisReference
                && (DynAbs.Tracing.TraceSender.Expression_True(10952, 16463, 16576) && f_10952_16533_16549(receiverOpt) != BoundKind.BaseReference
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10952, 16463, 16667) && f_10952_16603_16619(receiverOpt) != BoundKind.ObjectOrCollectionValuePlaceholder))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 16361, 16743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 16703, 16728);

                    f_10952_16703_16727(builder, receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 16361, 16743);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 16759, 16815);

                f_10952_16759_16814(
                            builder, f_10952_16776_16813(arguments));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 16831, 16871);

                f_10952_16831_16870(
                            builder, additionalNodeOpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 16887, 16923);

                return f_10952_16894_16922(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10952, 16072, 16934);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10952_16307_16344()
                {
                    var return_v = ArrayBuilder<BoundNode>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 16307, 16344);
                    return return_v;
                }


                bool
                f_10952_16405_16438_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 16405, 16438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10952_16463_16479(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 16463, 16479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10952_16533_16549(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 16533, 16549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10952_16603_16619(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 16603, 16619);
                    return return_v;
                }


                int
                f_10952_16703_16727(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundNode>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 16703, 16727);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10952_16776_16813(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                from)
                {
                    var return_v = StaticCast<BoundNode>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 16776, 16813);
                    return return_v;
                }


                int
                f_10952_16759_16814(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundNode>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 16759, 16814);
                    return 0;
                }


                int
                f_10952_16831_16870(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundNode>
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                value)
                {
                    builder.AddIfNotNull<Microsoft.CodeAnalysis.CSharp.BoundNode>((Microsoft.CodeAnalysis.CSharp.BoundNode?)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 16831, 16870);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10952_16894_16922(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundNode>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 16894, 16922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 16072, 16934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 16072, 16934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<IOperation> GetAnonymousObjectCreationInitializers(
                    ImmutableArray<BoundExpression> arguments,
                    ImmutableArray<BoundAnonymousPropertyDeclaration> declarations,
                    SyntaxNode syntax,
                    ITypeSymbol type,
                    bool isImplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10952, 16946, 21241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 17377, 17431);

                f_10952_17377_17430(arguments.Length >= declarations.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 17447, 17516);

                var
                builder = f_10952_17461_17515(arguments.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 17530, 17562);

                var
                currentDeclarationIndex = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 17585, 17590);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 17576, 20381) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 17614, 17617)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 17576, 20381))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 17576, 20381);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 17651, 17691);

                        IOperation
                        value = f_10952_17670_17690(this, arguments[i])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 17711, 17729);

                        IOperation
                        target
                        = default(IOperation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 17747, 17773);

                        bool
                        isImplicitAssignment
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 17884, 18188);

                        var
                        instance = f_10952_17899_18187(referenceKind: InstanceReferenceKind.ImplicitReceiver, semanticModel: _semanticModel, syntax: syntax, type: type, isImplicit: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 18280, 18390);

                        PropertySymbol
                        property = f_10952_18306_18389(f_10952_18352_18385(type), i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 18408, 18531);

                        BoundAnonymousPropertyDeclaration?
                        anonymousProperty = f_10952_18463_18530(declarations, property, ref currentDeclarationIndex)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 18549, 19968) || true) && (anonymousProperty is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 18549, 19968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 18717, 19134);

                            target = f_10952_18726_19133(f_10952_18783_18809(property), arguments: ImmutableArray<IArgumentOperation>.Empty, instance, semanticModel: _semanticModel, syntax: f_10952_19013_19025(value), type: f_10952_19058_19089(f_10952_19058_19071(property)), isImplicit: true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 19156, 19184);

                            isImplicitAssignment = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 18549, 19968);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 18549, 19968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 19266, 19893);

                            target = f_10952_19275_19892(f_10952_19306_19350(f_10952_19306_19332(anonymousProperty)), ImmutableArray<IArgumentOperation>.Empty, instance, _semanticModel, anonymousProperty.Syntax, f_10952_19751_19790(anonymousProperty), f_10952_19853_19891(anonymousProperty));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 19915, 19949);

                            isImplicitAssignment = isImplicit;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 18549, 19968);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 19988, 20042);

                        var
                        assignmentSyntax = f_10952_20011_20031_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10952_20011_20023(value), 10952, 20011, 20031)?.Parent) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SyntaxNode?>(10952, 20011, 20041) ?? syntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 20060, 20102);

                        ITypeSymbol?
                        assignmentType = f_10952_20090_20101(target)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 20120, 20139);

                        bool
                        isRef = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 20157, 20324);

                        var
                        assignment = f_10952_20174_20323(isRef, target, value, _semanticModel, assignmentSyntax, assignmentType, f_10952_20276_20300(value), isImplicitAssignment)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 20342, 20366);

                        f_10952_20342_20365(builder, assignment);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10952, 1, 2806);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10952, 1, 2806);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 20397, 20458);

                f_10952_20397_20457(currentDeclarationIndex == declarations.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 20472, 20508);

                return f_10952_20479_20507(builder);

                static BoundAnonymousPropertyDeclaration? getDeclaration(ImmutableArray<BoundAnonymousPropertyDeclaration> declarations, PropertySymbol currentProperty, ref int currentDeclarationIndex)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10952, 20524, 21230);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 20742, 20865) || true) && (currentDeclarationIndex >= declarations.Length)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 20742, 20865);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 20834, 20846);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 20742, 20865);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 20885, 20948);

                        var
                        currentDeclaration = declarations[currentDeclarationIndex]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 20968, 21183) || true) && (f_10952_20972_21002(currentProperty) == f_10952_21006_21048(f_10952_21006_21033(currentDeclaration)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 20968, 21183);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 21090, 21116);

                            currentDeclarationIndex++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 21138, 21164);

                            return currentDeclaration;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 20968, 21183);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 21203, 21215);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10952, 20524, 21230);

                        int?
                        f_10952_20972_21002(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.MemberIndexOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 20972, 21002);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        f_10952_21006_21033(Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration
                        this_param)
                        {
                            var return_v = this_param.Property;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 21006, 21033);
                            return return_v;
                        }


                        int?
                        f_10952_21006_21048(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.MemberIndexOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 21006, 21048);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 20524, 21230);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 20524, 21230);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10952, 16946, 21241);

                int
                f_10952_17377_17430(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 17377, 17430);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                f_10952_17461_17515(int
                capacity)
                {
                    var return_v = ArrayBuilder<IOperation>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 17461, 17515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10952_17670_17690(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundNode)
                {
                    var return_v = this_param.Create((Microsoft.CodeAnalysis.CSharp.BoundNode)boundNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 17670, 17690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.InstanceReferenceOperation
                f_10952_17899_18187(Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
                referenceKind, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ITypeSymbol
                type, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.InstanceReferenceOperation(referenceKind: referenceKind, semanticModel: semanticModel, syntax: syntax, type: type, isImplicit: isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 17899, 18187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10952_18352_18385(Microsoft.CodeAnalysis.ITypeSymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 18352, 18385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10952_18306_18389(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, int
                index)
                {
                    var return_v = AnonymousTypeManager.GetAnonymousTypeProperty(type, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 18306, 18389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration?
                f_10952_18463_18530(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration>
                declarations, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                currentProperty, ref int
                currentDeclarationIndex)
                {
                    var return_v = getDeclaration(declarations, currentProperty, ref currentDeclarationIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 18463, 18530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol?
                f_10952_18783_18809(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 18783, 18809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10952_19013_19025(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 19013, 19025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10952_19058_19071(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 19058, 19071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_10952_19058_19089(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 19058, 19089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.PropertyReferenceOperation
                f_10952_18726_19133(Microsoft.CodeAnalysis.IPropertySymbol
                property, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                arguments, Microsoft.CodeAnalysis.Operations.InstanceReferenceOperation
                instance, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ITypeSymbol
                type, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.PropertyReferenceOperation(property, arguments: arguments, (Microsoft.CodeAnalysis.IOperation)instance, semanticModel: semanticModel, syntax: syntax, type: type, isImplicit: isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 18726, 19133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10952_19306_19332(Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration
                this_param)
                {
                    var return_v = this_param.Property;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 19306, 19332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol?
                f_10952_19306_19350(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 19306, 19350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_10952_19751_19790(Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration
                this_param)
                {
                    var return_v = this_param.GetPublicTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 19751, 19790);
                    return return_v;
                }


                bool
                f_10952_19853_19891(Microsoft.CodeAnalysis.CSharp.BoundAnonymousPropertyDeclaration
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 19853, 19891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.PropertyReferenceOperation
                f_10952_19275_19892(Microsoft.CodeAnalysis.IPropertySymbol
                property, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
                arguments, Microsoft.CodeAnalysis.Operations.InstanceReferenceOperation
                instance, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ITypeSymbol?
                type, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.PropertyReferenceOperation(property, arguments, (Microsoft.CodeAnalysis.IOperation)instance, semanticModel, syntax, type, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 19275, 19892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10952_20011_20023(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 20011, 20023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10952_20011_20031_M(Microsoft.CodeAnalysis.SyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 20011, 20031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_10952_20090_20101(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10952, 20090, 20101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10952_20276_20300(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.GetConstantValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 20276, 20300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.SimpleAssignmentOperation
                f_10952_20174_20323(bool
                isRef, Microsoft.CodeAnalysis.IOperation
                target, Microsoft.CodeAnalysis.IOperation
                value, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ITypeSymbol?
                type, Microsoft.CodeAnalysis.ConstantValue?
                constantValue, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.SimpleAssignmentOperation(isRef, target, value, semanticModel, syntax, type, constantValue, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 20174, 20323);
                    return return_v;
                }


                int
                f_10952_20342_20365(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.Operations.SimpleAssignmentOperation
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.IOperation)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 20342, 20365);
                    return 0;
                }


                int
                f_10952_20397_20457(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 20397, 20457);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_10952_20479_20507(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 20479, 20507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 16946, 21241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 16946, 21241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal class Helper
        {
            internal static bool IsPostfixIncrementOrDecrement(CSharp.UnaryOperatorKind operatorKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10952, 21299, 21753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 21421, 21738);

                    switch (f_10952_21429_21452(operatorKind))
                    {

                        case CSharp.UnaryOperatorKind.PostfixIncrement:
                        case CSharp.UnaryOperatorKind.PostfixDecrement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 21421, 21738);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 21636, 21648);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 21421, 21738);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 21421, 21738);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 21706, 21719);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 21421, 21738);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10952, 21299, 21753);

                    Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                    f_10952_21429_21452(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                    kind)
                    {
                        var return_v = kind.Operator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 21429, 21452);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 21299, 21753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 21299, 21753);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static bool IsDecrement(CSharp.UnaryOperatorKind operatorKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10952, 21769, 22204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 21873, 22189);

                    switch (f_10952_21881_21904(operatorKind))
                    {

                        case CSharp.UnaryOperatorKind.PrefixDecrement:
                        case CSharp.UnaryOperatorKind.PostfixDecrement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 21873, 22189);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 22087, 22099);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 21873, 22189);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 21873, 22189);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 22157, 22170);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 21873, 22189);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10952, 21769, 22204);

                    Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                    f_10952_21881_21904(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                    kind)
                    {
                        var return_v = kind.Operator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 21881, 21904);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 21769, 22204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 21769, 22204);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static UnaryOperatorKind DeriveUnaryOperatorKind(CSharp.UnaryOperatorKind operatorKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10952, 22220, 23220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 22349, 23155);

                    switch (f_10952_22357_22380(operatorKind))
                    {

                        case CSharp.UnaryOperatorKind.UnaryPlus:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 22349, 23155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 22488, 22518);

                            return UnaryOperatorKind.Plus;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 22349, 23155);

                        case CSharp.UnaryOperatorKind.UnaryMinus:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 22349, 23155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 22609, 22640);

                            return UnaryOperatorKind.Minus;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 22349, 23155);

                        case CSharp.UnaryOperatorKind.LogicalNegation:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 22349, 23155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 22736, 22765);

                            return UnaryOperatorKind.Not;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 22349, 23155);

                        case CSharp.UnaryOperatorKind.BitwiseComplement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 22349, 23155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 22863, 22904);

                            return UnaryOperatorKind.BitwiseNegation;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 22349, 23155);

                        case CSharp.UnaryOperatorKind.True:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 22349, 23155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 22989, 23019);

                            return UnaryOperatorKind.True;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 22349, 23155);

                        case CSharp.UnaryOperatorKind.False:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 22349, 23155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 23105, 23136);

                            return UnaryOperatorKind.False;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 22349, 23155);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 23175, 23205);

                    return UnaryOperatorKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10952, 22220, 23220);

                    Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                    f_10952_22357_22380(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                    kind)
                    {
                        var return_v = kind.Operator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 22357, 22380);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 22220, 23220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 22220, 23220);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static BinaryOperatorKind DeriveBinaryOperatorKind(CSharp.BinaryOperatorKind operatorKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10952, 23236, 25799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 23368, 25733);

                    switch (f_10952_23376_23410(operatorKind))
                    {

                        case CSharp.BinaryOperatorKind.Addition:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 23518, 23548);

                            return BinaryOperatorKind.Add;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.Subtraction:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 23641, 23676);

                            return BinaryOperatorKind.Subtract;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.Multiplication:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 23772, 23807);

                            return BinaryOperatorKind.Multiply;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.Division:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 23897, 23930);

                            return BinaryOperatorKind.Divide;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.Remainder:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 24021, 24057);

                            return BinaryOperatorKind.Remainder;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.LeftShift:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 24148, 24184);

                            return BinaryOperatorKind.LeftShift;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.RightShift:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 24276, 24313);

                            return BinaryOperatorKind.RightShift;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.And:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 24398, 24428);

                            return BinaryOperatorKind.And;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.Or:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 24512, 24541);

                            return BinaryOperatorKind.Or;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.Xor:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 24626, 24664);

                            return BinaryOperatorKind.ExclusiveOr;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.LessThan:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 24754, 24789);

                            return BinaryOperatorKind.LessThan;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.LessThanOrEqual:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 24886, 24928);

                            return BinaryOperatorKind.LessThanOrEqual;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.Equal:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 25015, 25048);

                            return BinaryOperatorKind.Equals;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.NotEqual:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 25138, 25174);

                            return BinaryOperatorKind.NotEquals;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.GreaterThanOrEqual:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 25274, 25319);

                            return BinaryOperatorKind.GreaterThanOrEqual;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.GreaterThan:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 25412, 25450);

                            return BinaryOperatorKind.GreaterThan;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.LogicalAnd:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 25542, 25583);

                            return BinaryOperatorKind.ConditionalAnd;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);

                        case CSharp.BinaryOperatorKind.LogicalOr:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10952, 23368, 25733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 25674, 25714);

                            return BinaryOperatorKind.ConditionalOr;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10952, 23368, 25733);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10952, 25753, 25784);

                    return BinaryOperatorKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10952, 23236, 25799);

                    Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    f_10952_23376_23410(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    kind)
                    {
                        var return_v = kind.OperatorWithLogical();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10952, 23376, 23410);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10952, 23236, 25799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 23236, 25799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Helper()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10952, 21253, 25810);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10952, 21253, 25810);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 21253, 25810);
            }


            static Helper()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10952, 21253, 25810);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10952, 21253, 25810);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10952, 21253, 25810);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10952, 21253, 25810);
        }
    }
}
