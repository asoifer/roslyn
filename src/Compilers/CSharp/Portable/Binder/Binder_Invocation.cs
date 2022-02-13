// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private BoundExpression BindMethodGroup(ExpressionSyntax node, bool invoked, bool indexed, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 776, 1731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 918, 1720);

                switch (f_10310_926_937(node))
                {

                    case SyntaxKind.IdentifierName:
                    case SyntaxKind.GenericName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 918, 1720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 1070, 1147);

                        return f_10310_1077_1146(this, node, invoked, indexed, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 918, 1720);

                    case SyntaxKind.SimpleMemberAccessExpression:
                    case SyntaxKind.PointerMemberAccessExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 918, 1720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 1296, 1387);

                        return f_10310_1303_1386(this, node, invoked, indexed, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 918, 1720);

                    case SyntaxKind.ParenthesizedExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 918, 1720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 1467, 1598);

                        return f_10310_1474_1597(this, f_10310_1490_1538(((ParenthesizedExpressionSyntax)node)), invoked: false, indexed: false, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 918, 1720);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 918, 1720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 1646, 1705);

                        return f_10310_1653_1704(this, node, diagnostics, invoked, indexed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 918, 1720);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 776, 1731);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10310_926_937(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 926, 937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_1077_1146(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, bool
                invoked, bool
                indexed, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindIdentifier((Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax)node, invoked, indexed, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 1077, 1146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_1303_1386(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, bool
                invoked, bool
                indexed, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindMemberAccess((Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax)node, invoked, indexed, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 1303, 1386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10310_1490_1538(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 1490, 1538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_1474_1597(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, bool
                invoked, bool
                indexed, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindMethodGroup(node, invoked: invoked, indexed: indexed, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 1474, 1597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_1653_1704(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                invoked, bool
                indexed)
                {
                    var return_v = this_param.BindExpression(node, diagnostics, invoked, indexed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 1653, 1704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 776, 1731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 776, 1731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<MethodSymbol> GetOriginalMethods(OverloadResolutionResult<MethodSymbol> overloadResolutionResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10310, 1743, 2737);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 2333, 2460) || true) && (overloadResolutionResult == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 2333, 2460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 2403, 2445);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 2333, 2460);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 2476, 2531);

                var
                builder = f_10310_2490_2530()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 2545, 2676);
                    foreach (var result in f_10310_2568_2600_I(f_10310_2568_2600(overloadResolutionResult)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 2545, 2676);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 2634, 2661);

                        f_10310_2634_2660(builder, result.Member);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 2545, 2676);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 2690, 2726);

                return f_10310_2697_2725(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10310, 1743, 2737);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_2490_2530()
                {
                    var return_v = ArrayBuilder<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 2490, 2530);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                f_10310_2568_2600(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 2568, 2600);
                    return return_v;
                }


                int
                f_10310_2634_2660(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 2634, 2660);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                f_10310_2568_2600_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 2568, 2600);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_2697_2725(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 2697, 2725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 1743, 2737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 1743, 2737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression MakeInvocationExpression(
                    SyntaxNode node,
                    BoundExpression receiver,
                    string methodName,
                    ImmutableArray<BoundExpression> args,
                    DiagnosticBag diagnostics,
                    SeparatedSyntaxList<TypeSyntax> typeArgsSyntax = default(SeparatedSyntaxList<TypeSyntax>),
                    ImmutableArray<TypeWithAnnotations> typeArgs = default(ImmutableArray<TypeWithAnnotations>),
                    CSharpSyntaxNode queryClause = null,
                    bool allowFieldsAndProperties = false,
                    bool allowUnexpandedForm = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 3851, 7336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 4476, 4507);

                f_10310_4476_4506(receiver != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 4523, 4575);

                receiver = f_10310_4534_4574(this, receiver, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 4589, 4771);

                var
                boundExpression = f_10310_4611_4770(this, node, node, receiver, methodName, typeArgs.NullToEmpty().Length, typeArgsSyntax, typeArgs, invoked: true, indexed: false, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 4916, 5955) || true) && (!allowFieldsAndProperties && (DynAbs.Tracing.TraceSender.Expression_True(10310, 4920, 5048) && (f_10310_4950_4970(boundExpression) == BoundKind.FieldAccess || (DynAbs.Tracing.TraceSender.Expression_False(10310, 4950, 5047) || f_10310_4999_5019(boundExpression) == BoundKind.PropertyAccess))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 4916, 5955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 5082, 5096);

                    Symbol
                    symbol
                    = default(Symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 5114, 5130);

                    MessageID
                    msgId
                    = default(MessageID);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 5148, 5569) || true) && (f_10310_5152_5172(boundExpression) == BoundKind.FieldAccess)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 5148, 5569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 5239, 5270);

                        msgId = MessageID.IDS_SK_FIELD;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 5292, 5349);

                        symbol = f_10310_5301_5348(((BoundFieldAccess)boundExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 5148, 5569);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 5148, 5569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 5431, 5465);

                        msgId = MessageID.IDS_SK_PROPERTY;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 5487, 5550);

                        symbol = f_10310_5496_5549(((BoundPropertyAccess)boundExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 5148, 5569);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 5589, 5818);

                    f_10310_5589_5817(
                                    diagnostics, ErrorCode.ERR_BadSKknown, f_10310_5674_5687(node), methodName, f_10310_5743_5759(msgId), f_10310_5782_5816(MessageID.IDS_SK_METHOD));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 5838, 5940);

                    return f_10310_5845_5939(this, node, LookupResultKind.Empty, f_10310_5889_5918(symbol), args.Add(receiver));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 4916, 5955);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 5971, 6065);

                boundExpression = f_10310_5989_6064(this, boundExpression, BindValueKind.RValueOrMethodGroup, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 6079, 6123);

                boundExpression.WasCompilerGenerated = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 6139, 6195);

                var
                analyzedArguments = f_10310_6163_6194()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 6209, 6493);

                f_10310_6209_6492(!args.Any(e => e.Kind == BoundKind.OutVariablePendingInference ||
                                                        e.Kind == BoundKind.OutDeconstructVarPendingInference ||
                                                        e.Kind == BoundKind.DiscardExpression && !e.HasExpressionType()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 6507, 6550);

                f_10310_6507_6549(analyzedArguments.Arguments, args);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 6564, 6777);

                BoundExpression
                result = f_10310_6589_6776(this, node, node, methodName, boundExpression, analyzedArguments, diagnostics, queryClause, allowUnexpandedForm: allowUnexpandedForm)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 6854, 7207) || true) && (queryClause != null && (DynAbs.Tracing.TraceSender.Expression_True(10310, 6858, 6923) && f_10310_6881_6892(result) == BoundKind.DynamicInvocation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 6854, 7207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 7041, 7082);

                    f_10310_7041_7081(f_10310_7054_7080(diagnostics));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 7102, 7192);

                    result = f_10310_7111_7191(this, node, boundExpression, LookupResultKind.Viable, analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 6854, 7207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 7223, 7258);

                result.WasCompilerGenerated = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 7272, 7297);

                f_10310_7272_7296(analyzedArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 7311, 7325);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 3851, 7336);

                int
                f_10310_4476_4506(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 4476, 4506);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_4534_4574(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 4534, 4574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_4611_4770(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxNode
                right, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundLeft, string
                rightName, int
                rightArity, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArgumentsSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, bool
                invoked, bool
                indexed, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindInstanceMemberAccess(node, right, boundLeft, rightName, rightArity, typeArgumentsSyntax, typeArgumentsWithAnnotations, invoked: invoked, indexed: indexed, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 4611, 4770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_4950_4970(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 4950, 4970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_4999_5019(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 4999, 5019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_5152_5172(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 5152, 5172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10310_5301_5348(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 5301, 5348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10310_5496_5549(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 5496, 5549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10310_5674_5687(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 5674, 5687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10310_5743_5759(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 5743, 5759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10310_5782_5816(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 5782, 5816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10310_5589_5817(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 5589, 5817);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10310_5889_5918(Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 5889, 5918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10310_5845_5939(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childNodes)
                {
                    var return_v = this_param.BadExpression(syntax, resultKind, symbols, childNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 5845, 5939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_5989_6064(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValue(expr, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 5989, 6064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10310_6163_6194()
                {
                    var return_v = AnalyzedArguments.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 6163, 6194);
                    return return_v;
                }


                int
                f_10310_6209_6492(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 6209, 6492);
                    return 0;
                }


                int
                f_10310_6507_6549(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 6507, 6549);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_6589_6776(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxNode
                expression, string
                methodName, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundExpression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                queryClause, bool
                allowUnexpandedForm)
                {
                    var return_v = this_param.BindInvocationExpression(node, expression, methodName, boundExpression, analyzedArguments, diagnostics, queryClause, allowUnexpandedForm: allowUnexpandedForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 6589, 6776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_6881_6892(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 6881, 6892);
                    return return_v;
                }


                bool
                f_10310_7054_7080(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 7054, 7080);
                    return return_v;
                }


                int
                f_10310_7041_7081(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 7041, 7081);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_7111_7191(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments)
                {
                    var return_v = this_param.CreateBadCall(node, expr, resultKind, analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 7111, 7191);
                    return return_v;
                }


                int
                f_10310_7272_7296(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 7272, 7296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 3851, 7336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 3851, 7336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindInvocationExpression(
                    InvocationExpressionSyntax node,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 7451, 9061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 7611, 7634);

                BoundExpression
                result
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 7648, 7819) || true) && (f_10310_7652_7704(this, node, diagnostics, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 7648, 7819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 7738, 7752);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 7648, 7819);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 7913, 7985);

                bool
                isArglist = f_10310_7930_7952(f_10310_7930_7945(node)) == SyntaxKind.ArgListExpression
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 7999, 8069);

                AnalyzedArguments
                analyzedArguments = f_10310_8037_8068()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 8085, 8981) || true) && (isArglist)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 8085, 8981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 8132, 8226);

                    f_10310_8132_8225(this, f_10310_8154_8171(node), diagnostics, analyzedArguments, allowArglist: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 8244, 8311);

                    result = f_10310_8253_8310(this, node, diagnostics, analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 8085, 8981);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 8085, 8981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 8377, 8501);

                    BoundExpression
                    boundExpression = f_10310_8411_8500(this, f_10310_8427_8442(node), invoked: true, indexed: false, diagnostics: diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 8519, 8613);

                    boundExpression = f_10310_8537_8612(this, boundExpression, BindValueKind.RValueOrMethodGroup, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 8631, 8725);

                    string
                    name = (DynAbs.Tracing.TraceSender.Conditional_F1(10310, 8645, 8690) || ((f_10310_8645_8665(boundExpression) == BoundKind.MethodGroup && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 8693, 8717)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 8720, 8724))) ? f_10310_8693_8717(f_10310_8701_8716(node)) : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 8743, 8836);

                    f_10310_8743_8835(this, f_10310_8765_8782(node), diagnostics, analyzedArguments, allowArglist: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 8854, 8966);

                    result = f_10310_8863_8965(this, node, f_10310_8894_8909(node), name, boundExpression, analyzedArguments, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 8085, 8981);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 8997, 9022);

                f_10310_8997_9021(
                            analyzedArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 9036, 9050);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 7451, 9061);

                bool
                f_10310_7652_7704(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                result)
                {
                    var return_v = this_param.TryBindNameofOperator(node, diagnostics, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 7652, 7704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10310_7930_7945(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 7930, 7945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10310_7930_7952(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 7930, 7952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10310_8037_8068()
                {
                    var return_v = AnalyzedArguments.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 8037, 8068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10310_8154_8171(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 8154, 8171);
                    return return_v;
                }


                int
                f_10310_8132_8225(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                argumentListOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                result, bool
                allowArglist)
                {
                    this_param.BindArgumentsAndNames(argumentListOpt, diagnostics, result, allowArglist: allowArglist);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 8132, 8225);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_8253_8310(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments)
                {
                    var return_v = this_param.BindArgListOperator(node, diagnostics, analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 8253, 8310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10310_8427_8442(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 8427, 8442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_8411_8500(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, bool
                invoked, bool
                indexed, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindMethodGroup(node, invoked: invoked, indexed: indexed, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 8411, 8500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_8537_8612(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValue(expr, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 8537, 8612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_8645_8665(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 8645, 8665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10310_8701_8716(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 8701, 8716);
                    return return_v;
                }


                string
                f_10310_8693_8717(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    var return_v = GetName(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 8693, 8717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10310_8765_8782(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 8765, 8782);
                    return return_v;
                }


                int
                f_10310_8743_8835(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                argumentListOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                result, bool
                allowArglist)
                {
                    this_param.BindArgumentsAndNames(argumentListOpt, diagnostics, result, allowArglist: allowArglist);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 8743, 8835);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10310_8894_8909(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 8894, 8909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_8863_8965(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, string?
                methodName, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundExpression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindInvocationExpression((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.SyntaxNode)expression, methodName, boundExpression, analyzedArguments, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 8863, 8965);
                    return return_v;
                }


                int
                f_10310_8997_9021(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 8997, 9021);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 7451, 9061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 7451, 9061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindArgListOperator(InvocationExpressionSyntax node, DiagnosticBag diagnostics, AnalyzedArguments analyzedArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 9073, 11882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 9238, 9283);

                bool
                hasErrors = f_10310_9255_9282(analyzedArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 9398, 9480);

                TypeSymbol
                objType = f_10310_9419_9479(this, SpecialType.System_Object, diagnostics, node)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 9503, 9508);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 9494, 11583) || true) && (i < f_10310_9514_9547(analyzedArguments.Arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 9549, 9552)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 9494, 11583))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 9494, 11583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 9586, 9644);

                        BoundExpression
                        argument = f_10310_9613_9643(analyzedArguments.Arguments, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 9664, 11095) || true) && (f_10310_9668_9681(argument) == BoundKind.OutVariablePendingInference)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 9664, 11095);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 9764, 9870);

                            analyzedArguments.Arguments[i] = f_10310_9797_9869(((OutVariablePendingInference)argument), this, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 9664, 11095);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 9664, 11095);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 9912, 11095) || true) && ((object)f_10310_9924_9937(argument) == null && (DynAbs.Tracing.TraceSender.Expression_True(10310, 9916, 9971) && f_10310_9949_9971_M(!argument.HasAnyErrors)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 9912, 11095);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 10526, 10623);

                                analyzedArguments.Arguments[i] = f_10310_10559_10622(this, objType, argument, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 9912, 11095);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 9912, 11095);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 10665, 11095) || true) && (f_10310_10669_10695(f_10310_10669_10682(argument)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 10665, 11095);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 10737, 10809);

                                    f_10310_10737_10808(diagnostics, ErrorCode.ERR_CantUseVoidInArglist, argument.Syntax);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 10831, 10848);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 10665, 11095);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 10665, 11095);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 10890, 11095) || true) && (f_10310_10894_10922(analyzedArguments, i) == RefKind.None)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 10890, 11095);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 10980, 11076);

                                        analyzedArguments.Arguments[i] = f_10310_11013_11075(this, f_10310_11031_11061(analyzedArguments.Arguments, i), diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 10890, 11095);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 10665, 11095);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 9912, 11095);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 9664, 11095);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 11115, 11568);

                        switch (f_10310_11123_11151(analyzedArguments, i))
                        {

                            case RefKind.None:
                            case RefKind.Ref:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 11115, 11568);
                                DynAbs.Tracing.TraceSender.TraceBreak(10310, 11276, 11282);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 11115, 11568);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 11115, 11568);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 11399, 11474);

                                f_10310_11399_11473(diagnostics, ErrorCode.ERR_CantUseInOrOutInArglist, argument.Syntax);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 11500, 11517);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(10310, 11543, 11549);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 11115, 11568);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 2090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 2090);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 11599, 11685);

                ImmutableArray<BoundExpression>
                arguments = f_10310_11643_11684(analyzedArguments.Arguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 11699, 11781);

                ImmutableArray<RefKind>
                refKinds = f_10310_11734_11780(analyzedArguments.RefKinds)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 11795, 11871);

                return f_10310_11802_11870(node, arguments, refKinds, null, hasErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 9073, 11882);

                bool
                f_10310_9255_9282(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 9255, 9282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10310_9419_9479(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 9419, 9479);
                    return return_v;
                }


                int
                f_10310_9514_9547(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 9514, 9547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_9613_9643(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 9613, 9643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_9668_9681(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 9668, 9681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_9797_9869(Microsoft.CodeAnalysis.CSharp.OutVariablePendingInference
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt)
                {
                    var return_v = this_param.FailInference(binder, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 9797, 9869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_9924_9937(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 9924, 9937);
                    return return_v;
                }


                bool
                f_10310_9949_9971_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 9949, 9971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_10559_10622(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 10559, 10622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_10669_10682(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 10669, 10682);
                    return return_v;
                }


                bool
                f_10310_10669_10695(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 10669, 10695);
                    return return_v;
                }


                int
                f_10310_10737_10808(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 10737, 10808);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10310_10894_10922(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.RefKind(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 10894, 10922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_11031_11061(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 11031, 11061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_11013_11075(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 11013, 11075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10310_11123_11151(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.RefKind(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 11123, 11151);
                    return return_v;
                }


                int
                f_10310_11399_11473(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 11399, 11473);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_11643_11684(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 11643, 11684);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10310_11734_11780(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableOrNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 11734, 11780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                f_10310_11802_11870(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundArgListOperator((Microsoft.CodeAnalysis.SyntaxNode)syntax, arguments, argumentRefKindsOpt, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 11802, 11870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 9073, 11882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 9073, 11882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindInvocationExpression(
                    SyntaxNode node,
                    SyntaxNode expression,
                    string methodName,
                    BoundExpression boundExpression,
                    AnalyzedArguments analyzedArguments,
                    DiagnosticBag diagnostics,
                    CSharpSyntaxNode queryClause = null,
                    bool allowUnexpandedForm = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 11997, 14840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 12401, 12424);

                BoundExpression
                result
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 12438, 12467);

                NamedTypeSymbol
                delegateType
                = default(NamedTypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 12483, 14716) || true) && ((object)f_10310_12495_12515(boundExpression) != null && (DynAbs.Tracing.TraceSender.Expression_True(10310, 12487, 12559) && f_10310_12527_12559(f_10310_12527_12547(boundExpression))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 12483, 14716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 12846, 12902);

                    f_10310_12846_12901(this, boundExpression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 12920, 13055);

                    result = f_10310_12929_13054(this, node, boundExpression, analyzedArguments, ImmutableArray<MethodSymbol>.Empty, diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 12483, 14716);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 12483, 14716);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 13089, 14716) || true) && (f_10310_13093_13113(boundExpression) == BoundKind.MethodGroup)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 13089, 14716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 13172, 13228);

                        f_10310_13172_13227(this, boundExpression, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 13246, 13508);

                        result = f_10310_13255_13507(this, node, expression, methodName, boundExpression, analyzedArguments, diagnostics, queryClause, allowUnexpandedForm: allowUnexpandedForm, anyApplicableCandidates: out _);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 13089, 14716);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 13089, 14716);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 13542, 14716) || true) && ((object)(delegateType = f_10310_13570_13602(boundExpression)) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 13542, 14716);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 13645, 13874) || true) && (f_10310_13649_13725(diagnostics, delegateType, node: node))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 13645, 13874);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 13767, 13855);

                                return f_10310_13774_13854(this, node, boundExpression, LookupResultKind.Viable, analyzedArguments);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 13645, 13874);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 13894, 14032);

                            result = f_10310_13903_14031(this, node, expression, methodName, boundExpression, analyzedArguments, diagnostics, queryClause, delegateType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 13542, 14716);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 13542, 14716);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 14066, 14716) || true) && (f_10310_14070_14096_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10310_14070_14090(boundExpression), 10310, 14070, 14096)?.Kind) == SymbolKind.FunctionPointerType)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 14066, 14716);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 14164, 14220);

                                f_10310_14164_14219(this, boundExpression, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 14238, 14332);

                                result = f_10310_14247_14331(this, node, boundExpression, analyzedArguments, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 14066, 14716);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 14066, 14716);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 14398, 14585) || true) && (f_10310_14402_14431_M(!boundExpression.HasAnyErrors))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 14398, 14585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 14473, 14566);

                                    f_10310_14473_14565(diagnostics, f_10310_14489_14543(ErrorCode.ERR_MethodNameExpected), f_10310_14545_14564(expression));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 14398, 14585);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 14605, 14701);

                                result = f_10310_14614_14700(this, node, boundExpression, LookupResultKind.NotInvocable, analyzedArguments);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 14066, 14716);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 13542, 14716);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 13089, 14716);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 12483, 14716);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 14732, 14799);

                f_10310_14732_14798(this, result, f_10310_14768_14784(this), diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 14815, 14829);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 11997, 14840);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_12495_12515(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 12495, 12515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_12527_12547(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 12527, 12547);
                    return return_v;
                }


                bool
                f_10310_12527_12559(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 12527, 12559);
                    return return_v;
                }


                int
                f_10310_12846_12901(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportSuppressionIfNeeded(expr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 12846, 12901);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_12929_13054(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                applicableMethods, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                queryClause)
                {
                    var return_v = this_param.BindDynamicInvocation(node, expression, arguments, applicableMethods, diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 12929, 13054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_13093_13113(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 13093, 13113);
                    return return_v;
                }


                int
                f_10310_13172_13227(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportSuppressionIfNeeded(expr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 13172, 13227);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_13255_13507(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SyntaxNode
                expression, string
                methodName, Microsoft.CodeAnalysis.CSharp.BoundExpression
                methodGroup, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                queryClause, bool
                allowUnexpandedForm, out bool
                anyApplicableCandidates)
                {
                    var return_v = this_param.BindMethodGroupInvocation(syntax, expression, methodName, (Microsoft.CodeAnalysis.CSharp.BoundMethodGroup)methodGroup, analyzedArguments, diagnostics, queryClause, allowUnexpandedForm: allowUnexpandedForm, out anyApplicableCandidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 13255, 13507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10310_13570_13602(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = GetDelegateType(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 13570, 13602);
                    return return_v;
                }


                bool
                f_10310_13649_13725(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                possibleDelegateType, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = ReportDelegateInvokeUseSiteDiagnostic(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)possibleDelegateType, node: node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 13649, 13725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_13774_13854(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments)
                {
                    var return_v = this_param.CreateBadCall(node, expr, resultKind, analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 13774, 13854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_13903_14031(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxNode
                expression, string
                methodName, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundExpression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                queryClause, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType)
                {
                    var return_v = this_param.BindDelegateInvocation(node, expression, methodName, boundExpression, analyzedArguments, diagnostics, queryClause, delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 13903, 14031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_14070_14090(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 14070, 14090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10310_14070_14096_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 14070, 14096);
                    return return_v;
                }


                int
                f_10310_14164_14219(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportSuppressionIfNeeded(expr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 14164, 14219);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                f_10310_14247_14331(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundExpression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindFunctionPointerInvocation(node, boundExpression, analyzedArguments, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 14247, 14331);
                    return return_v;
                }


                bool
                f_10310_14402_14431_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 14402, 14431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10310_14489_14543(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 14489, 14543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10310_14545_14564(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 14545, 14564);
                    return return_v;
                }


                int
                f_10310_14473_14565(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 14473, 14565);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_14614_14700(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments)
                {
                    var return_v = this_param.CreateBadCall(node, expr, resultKind, analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 14614, 14700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10310_14768_14784(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 14768, 14784);
                    return return_v;
                }


                int
                f_10310_14732_14798(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckRestrictedTypeReceiver(expression, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 14732, 14798);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 11997, 14840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 11997, 14840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindDynamicInvocation(
                    SyntaxNode node,
                    BoundExpression expression,
                    AnalyzedArguments arguments,
                    ImmutableArray<MethodSymbol> applicableMethods,
                    DiagnosticBag diagnostics,
                    CSharpSyntaxNode queryClause)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 14852, 19917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 15180, 15244);

                f_10310_15180_15243(this, arguments, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 15260, 15283);

                bool
                hasErrors = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 15297, 19279) || true) && (f_10310_15301_15316(expression) == BoundKind.MethodGroup)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 15297, 19279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 15375, 15435);

                    BoundMethodGroup
                    methodGroup = (BoundMethodGroup)expression
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 15453, 15504);

                    BoundExpression
                    receiver = f_10310_15480_15503(methodGroup)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 15643, 19142) || true) && (receiver != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 15643, 19142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 15705, 19123);

                        switch (f_10310_15713_15726(receiver))
                        {

                            case BoundKind.BaseReference:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 15705, 19123);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 15835, 15916);

                                f_10310_15835_15915(diagnostics, ErrorCode.ERR_NoDynamicPhantomOnBase, node, f_10310_15898_15914(methodGroup));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 15946, 15963);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(10310, 15993, 15999);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 15705, 19123);

                            case BoundKind.ThisReference:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 15705, 19123);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 16223, 17584) || true) && ((f_10310_16228_16252() || (DynAbs.Tracing.TraceSender.Expression_False(10310, 16228, 16274) || f_10310_16256_16274())) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 16227, 16308) && f_10310_16279_16308(receiver)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 16223, 17584);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 16906, 17553);

                                    expression = f_10310_16919_17552(methodGroup, f_10310_16976_17004(methodGroup), f_10310_17043_17059(methodGroup), f_10310_17098_17117(methodGroup), f_10310_17156_17183(methodGroup), f_10310_17222_17245(methodGroup), f_10310_17284_17301(methodGroup) & ~BoundMethodGroupFlags.HasImplicitReceiver, receiverOpt: f_10310_17398_17478(f_10310_17398_17454(node, null, f_10310_17434_17453(this))), resultKind: f_10310_17529_17551(methodGroup));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 16223, 17584);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10310, 17616, 17622);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 15705, 19123);

                            case BoundKind.TypeOrValueExpression:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 15705, 19123);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 17717, 17772);

                                var
                                typeOrValue = (BoundTypeOrValueExpression)receiver
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 18220, 18241);

                                bool
                                inStaticContext
                                = default(bool);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 18271, 18396);

                                bool
                                useType = f_10310_18286_18326(typeOrValue.Data.ValueSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 18286, 18395) && !f_10310_18331_18395(this, isExplicit: false, inStaticContext: out inStaticContext))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 18428, 18522);

                                BoundExpression
                                finalReceiver = f_10310_18460_18521(this, typeOrValue, useType, diagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 18554, 19064);

                                expression = f_10310_18567_19063(methodGroup, f_10310_18624_18652(methodGroup), f_10310_18691_18707(methodGroup), f_10310_18746_18765(methodGroup), f_10310_18804_18831(methodGroup), f_10310_18870_18893(methodGroup), f_10310_18932_18949(methodGroup), finalReceiver, f_10310_19040_19062(methodGroup));
                                DynAbs.Tracing.TraceSender.TraceBreak(10310, 19094, 19100);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 15705, 19123);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 15643, 19142);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 15297, 19279);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 15297, 19279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 19208, 19264);

                    expression = f_10310_19221_19263(this, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 15297, 19279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 19295, 19397);

                ImmutableArray<BoundExpression>
                argArray = f_10310_19338_19396(this, arguments, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 19411, 19470);

                var
                refKindsArray = f_10310_19431_19469(arguments.RefKinds)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 19486, 19582);

                hasErrors &= f_10310_19499_19581(node, argArray, refKindsArray, diagnostics, queryClause);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 19598, 19906);

                return f_10310_19605_19905(node, f_10310_19673_19693(arguments), refKindsArray, applicableMethods, expression, argArray, type: f_10310_19842_19865(f_10310_19842_19853()), hasErrors: hasErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 14852, 19917);

                int
                f_10310_15180_15243(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckNamedArgumentsForDynamicInvocation(arguments, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 15180, 15243);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_15301_15316(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 15301, 15316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10310_15480_15503(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 15480, 15503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_15713_15726(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 15713, 15726);
                    return return_v;
                }


                string
                f_10310_15898_15914(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 15898, 15914);
                    return return_v;
                }


                int
                f_10310_15835_15915(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 15835, 15915);
                    return 0;
                }


                bool
                f_10310_16228_16252()
                {
                    var return_v = InConstructorInitializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 16228, 16252);
                    return return_v;
                }


                bool
                f_10310_16256_16274()
                {
                    var return_v = InFieldInitializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 16256, 16274);
                    return return_v;
                }


                bool
                f_10310_16279_16308(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 16279, 16308);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10310_16976_17004(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArgumentsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 16976, 17004);
                    return return_v;
                }


                string
                f_10310_17043_17059(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 17043, 17059);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_17098_17117(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 17098, 17117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10310_17156_17183(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.LookupSymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 17156, 17183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10310_17222_17245(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.LookupError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 17222, 17245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroupFlags?
                f_10310_17284_17301(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 17284, 17301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10310_17434_17453(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 17434, 17453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10310_17398_17454(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
                aliasOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeExpression(syntax, aliasOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 17398, 17454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10310_17398_17478(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                node)
                {
                    var return_v = node.MakeCompilerGenerated<Microsoft.CodeAnalysis.CSharp.BoundTypeExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 17398, 17478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10310_17529_17551(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 17529, 17551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                f_10310_16919_17552(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsOpt, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, Microsoft.CodeAnalysis.CSharp.Symbol?
                lookupSymbolOpt, Microsoft.CodeAnalysis.DiagnosticInfo?
                lookupError, Microsoft.CodeAnalysis.CSharp.BoundMethodGroupFlags?
                flags, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind)
                {
                    var return_v = this_param.Update(typeArgumentsOpt, name, methods, lookupSymbolOpt, lookupError, flags, receiverOpt: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, resultKind: resultKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 16919, 17552);
                    return return_v;
                }


                bool
                f_10310_18286_18326(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsInstance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 18286, 18326);
                    return return_v;
                }


                bool
                f_10310_18331_18395(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, bool
                isExplicit, out bool
                inStaticContext)
                {
                    var return_v = this_param.HasThis(isExplicit: isExplicit, out inStaticContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 18331, 18395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_18460_18521(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeOrValueExpression
                receiver, bool
                useType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReplaceTypeOrValueReceiver((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, useType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 18460, 18521);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10310_18624_18652(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArgumentsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 18624, 18652);
                    return return_v;
                }


                string
                f_10310_18691_18707(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 18691, 18707);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_18746_18765(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 18746, 18765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10310_18804_18831(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.LookupSymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 18804, 18831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10310_18870_18893(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.LookupError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 18870, 18893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroupFlags?
                f_10310_18932_18949(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 18932, 18949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10310_19040_19062(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 19040, 19062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                f_10310_18567_19063(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsOpt, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, Microsoft.CodeAnalysis.CSharp.Symbol?
                lookupSymbolOpt, Microsoft.CodeAnalysis.DiagnosticInfo?
                lookupError, Microsoft.CodeAnalysis.CSharp.BoundMethodGroupFlags?
                flags, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind)
                {
                    var return_v = this_param.Update(typeArgumentsOpt, name, methods, lookupSymbolOpt, lookupError, flags, receiverOpt, resultKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 18567, 19063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_19221_19263(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 19221, 19263);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_19338_19396(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BuildArgumentsForDynamicInvocation(arguments, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 19338, 19396);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10310_19431_19469(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableOrNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 19431, 19469);
                    return return_v;
                }


                bool
                f_10310_19499_19581(Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                queryClause)
                {
                    var return_v = ReportBadDynamicArguments(node, arguments, refKinds, diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 19499, 19581);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10310_19673_19693(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    var return_v = this_param.GetNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 19673, 19693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10310_19842_19853()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 19842, 19853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_19842_19865(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DynamicType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 19842, 19865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
                f_10310_19605_19905(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                applicableMethods, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation(syntax, argumentNamesOpt, argumentRefKindsOpt, applicableMethods, expression, arguments, type: type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 19605, 19905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 14852, 19917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 14852, 19917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckNamedArgumentsForDynamicInvocation(AnalyzedArguments arguments, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 19929, 20805);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20062, 20148) || true) && (f_10310_20066_20087(arguments.Names) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 20062, 20148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20126, 20133);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 20062, 20148);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20164, 20285) || true) && (!f_10310_20169_20229(f_10310_20169_20196(f_10310_20169_20180())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 20164, 20285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20263, 20270);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 20164, 20285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20301, 20323);

                bool
                seenName = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20346, 20351);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20337, 20794) || true) && (i < f_10310_20357_20378(arguments.Names))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20380, 20383)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 20337, 20794))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 20337, 20794);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20417, 20779) || true) && (f_10310_20421_20439(arguments.Names, i) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 20417, 20779);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20489, 20505);

                            seenName = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 20417, 20779);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 20417, 20779);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20547, 20779) || true) && (seenName)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 20547, 20779);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20601, 20731);

                                f_10310_20601_20730(diagnostics, ErrorCode.ERR_NamedArgumentSpecificationBeforeFixedArgumentInDynamicInvocation, f_10310_20700_20722(arguments.Arguments, i).Syntax);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20753, 20760);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 20547, 20779);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 20417, 20779);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 458);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 19929, 20805);

                int
                f_10310_20066_20087(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 20066, 20087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10310_20169_20180()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 20169, 20180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10310_20169_20196(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 20169, 20196);
                    return return_v;
                }


                bool
                f_10310_20169_20229(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                self)
                {
                    var return_v = self.AllowNonTrailingNamedArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 20169, 20229);
                    return return_v;
                }


                int
                f_10310_20357_20378(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 20357, 20378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10310_20421_20439(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 20421, 20439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_20700_20722(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 20700, 20722);
                    return return_v;
                }


                int
                f_10310_20601_20730(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 20601, 20730);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 19929, 20805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 19929, 20805);
            }
        }

        private ImmutableArray<BoundExpression> BuildArgumentsForDynamicInvocation(AnalyzedArguments arguments, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 20817, 21646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 20972, 21055);

                var
                builder = f_10310_20986_21054(f_10310_21028_21053(arguments.Arguments))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 21069, 21107);

                f_10310_21069_21106(builder, arguments.Arguments);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 21130, 21135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 21137, 21154);
                    for (int
        i = 0
        ,
        n = f_10310_21141_21154(builder)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 21121, 21583) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 21163, 21166)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 21121, 21583))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 21121, 21583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 21200, 21568);

                        builder[i] = f_10310_21213_21223(builder, i) switch
                        {
                            OutVariablePendingInference outvar when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 21271, 21348) && DynAbs.Tracing.TraceSender.Expression_True(10310, 21271, 21348))
        => f_10310_21309_21348(outvar, this, diagnostics),
                            BoundDiscardExpression discard when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 21402, 21435) || true) && (!f_10310_21408_21435(discard)) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 21402, 21435) || true)
        => f_10310_21439_21479(discard, this, diagnostics),
                            var arg when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 21502, 21548) && DynAbs.Tracing.TraceSender.Expression_True(10310, 21502, 21548))
        => f_10310_21513_21548(this, arg, diagnostics)
                        };
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 21599, 21635);

                return f_10310_21606_21634(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 20817, 21646);

                int
                f_10310_21028_21053(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 21028, 21053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_20986_21054(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 20986, 21054);
                    return return_v;
                }


                int
                f_10310_21069_21106(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 21069, 21106);
                    return 0;
                }


                int
                f_10310_21141_21154(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 21141, 21154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_21213_21223(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 21213, 21223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_21309_21348(Microsoft.CodeAnalysis.CSharp.OutVariablePendingInference
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt)
                {
                    var return_v = this_param.FailInference(binder, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 21309, 21348);
                    return return_v;
                }


                bool
                f_10310_21408_21435(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                node)
                {
                    var return_v = node.HasExpressionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 21408, 21435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                f_10310_21439_21479(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt)
                {
                    var return_v = this_param.FailInference(binder, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 21439, 21479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_21513_21548(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 21513, 21548);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_21606_21634(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 21606, 21634);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 20817, 21646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 20817, 21646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ReportBadDynamicArguments(
                    SyntaxNode node,
                    ImmutableArray<BoundExpression> arguments,
                    ImmutableArray<RefKind> refKinds,
                    DiagnosticBag diagnostics,
                    CSharpSyntaxNode queryClause)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10310, 21705, 24992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 21992, 22015);

                bool
                hasErrors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22029, 22059);

                bool
                reportedBadQuery = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22075, 22502) || true) && (f_10310_22079_22098_M(!refKinds.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 22075, 22502);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22141, 22153);
                        for (int
        argIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22132, 22487) || true) && (argIndex < refKinds.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22183, 22193)
        , argIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 22132, 22487))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 22132, 22487);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22235, 22468) || true) && (refKinds[argIndex] == RefKind.In)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 22235, 22468);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22321, 22402);

                                f_10310_22321_22401(diagnostics, ErrorCode.ERR_InDynamicMethodArg, arguments[argIndex].Syntax);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22428, 22445);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 22235, 22468);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 356);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 356);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 22075, 22502);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22518, 24950);
                    foreach (var arg in f_10310_22538_22547_I(arguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 22518, 24950);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22581, 24935) || true) && (!f_10310_22586_22612(arg))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 22581, 24935);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22654, 22955) || true) && (queryClause != null && (DynAbs.Tracing.TraceSender.Expression_True(10310, 22658, 22698) && !reportedBadQuery))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 22654, 22955);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22748, 22772);

                                reportedBadQuery = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22798, 22854);

                                f_10310_22798_22853(diagnostics, ErrorCode.ERR_BadDynamicQuery, node);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22880, 22897);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22923, 22932);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 22654, 22955);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 22979, 24916) || true) && (f_10310_22983_22991(arg) == BoundKind.Lambda || (DynAbs.Tracing.TraceSender.Expression_False(10310, 22983, 23050) || f_10310_23015_23023(arg) == BoundKind.UnboundLambda))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 22979, 24916);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 23276, 23348);

                                f_10310_23276_23347(diagnostics, ErrorCode.ERR_BadDynamicMethodArgLambda, arg.Syntax);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 23374, 23391);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 22979, 24916);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 22979, 24916);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 23441, 24916) || true) && (f_10310_23445_23453(arg) == BoundKind.MethodGroup)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 23441, 24916);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 23673, 23745);

                                    f_10310_23673_23744(diagnostics, ErrorCode.ERR_BadDynamicMethodArgMemgrp, arg.Syntax);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 23771, 23788);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 23441, 24916);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 23441, 24916);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 23838, 24916) || true) && (f_10310_23842_23850(arg) == BoundKind.ArgListOperator)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 23838, 24916);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 24171, 24250);

                                        f_10310_24171_24249(diagnostics, ErrorCode.ERR_BadDynamicMethodArg, arg.Syntax, "__arglist");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 23838, 24916);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 23838, 24916);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 24572, 24611);

                                        f_10310_24572_24610((object)f_10310_24593_24601(arg) != null);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 24774, 24850);

                                        f_10310_24774_24849(diagnostics, ErrorCode.ERR_BadDynamicMethodArg, arg.Syntax, f_10310_24840_24848(arg));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 24876, 24893);

                                        hasErrors = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 23838, 24916);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 23441, 24916);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 22979, 24916);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 22581, 24935);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 22518, 24950);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 2433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 2433);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 24964, 24981);

                return hasErrors;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10310, 21705, 24992);

                bool
                f_10310_22079_22098_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 22079, 22098);
                    return return_v;
                }


                int
                f_10310_22321_22401(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 22321, 22401);
                    return 0;
                }


                bool
                f_10310_22586_22612(Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = IsLegalDynamicOperand(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 22586, 22612);
                    return return_v;
                }


                int
                f_10310_22798_22853(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 22798, 22853);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_22983_22991(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 22983, 22991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_23015_23023(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 23015, 23023);
                    return return_v;
                }


                int
                f_10310_23276_23347(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 23276, 23347);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_23445_23453(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 23445, 23453);
                    return return_v;
                }


                int
                f_10310_23673_23744(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 23673, 23744);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_23842_23850(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 23842, 23850);
                    return return_v;
                }


                int
                f_10310_24171_24249(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 24171, 24249);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_24593_24601(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 24593, 24601);
                    return return_v;
                }


                int
                f_10310_24572_24610(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 24572, 24610);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_24840_24848(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 24840, 24848);
                    return return_v;
                }


                int
                f_10310_24774_24849(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 24774, 24849);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_22538_22547_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 22538, 22547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 21705, 24992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 21705, 24992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindDelegateInvocation(
                    SyntaxNode node,
                    SyntaxNode expression,
                    string methodName,
                    BoundExpression boundExpression,
                    AnalyzedArguments analyzedArguments,
                    DiagnosticBag diagnostics,
                    CSharpSyntaxNode queryClause,
                    NamedTypeSymbol delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 25004, 27026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 25396, 25419);

                BoundExpression
                result
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 25433, 25477);

                var
                methodGroup = f_10310_25451_25476()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 25491, 25580);

                f_10310_25491_25579(methodGroup, boundExpression, f_10310_25545_25578(delegateType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 25594, 25678);

                var
                overloadResolutionResult = f_10310_25625_25677()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 25692, 25742);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 25756, 26125);

                f_10310_25756_26124(f_10310_25756_25774(), methods: f_10310_25837_25856(methodGroup), typeArguments: f_10310_25890_25915(methodGroup), receiver: f_10310_25944_25964(methodGroup), arguments: analyzedArguments, result: overloadResolutionResult, useSiteDiagnostics: ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 26139, 26181);

                f_10310_26139_26180(diagnostics, node, useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 26378, 26906) || true) && (f_10310_26382_26418(analyzedArguments) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 26382, 26469) && f_10310_26422_26469(overloadResolutionResult)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 26378, 26906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 26503, 26654);

                    result = f_10310_26512_26653(this, node, boundExpression, analyzedArguments, f_10310_26576_26626(overloadResolutionResult), diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 26378, 26906);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 26378, 26906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 26720, 26891);

                    result = f_10310_26729_26890(this, node, expression, methodName, overloadResolutionResult, analyzedArguments, methodGroup, delegateType, diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 26378, 26906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 26922, 26954);

                f_10310_26922_26953(
                            overloadResolutionResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 26968, 26987);

                f_10310_26968_26986(methodGroup);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 27001, 27015);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 25004, 27026);

                Microsoft.CodeAnalysis.CSharp.MethodGroup
                f_10310_25451_25476()
                {
                    var return_v = MethodGroup.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 25451, 25476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10310_25545_25578(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 25545, 25578);
                    return return_v;
                }


                int
                f_10310_25491_25579(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.PopulateWithSingleMethod(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 25491, 25579);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_25625_25677()
                {
                    var return_v = OverloadResolutionResult<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 25625, 25677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution
                f_10310_25756_25774()
                {
                    var return_v = OverloadResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 25756, 25774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_25837_25856(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 25837, 25856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10310_25890_25915(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 25890, 25915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_25944_25964(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 25944, 25964);
                    return return_v;
                }


                int
                f_10310_25756_26124(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                result, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    this_param.MethodInvocationOverloadResolution(methods: methods, typeArguments: typeArguments, receiver: receiver, arguments: arguments, result: result, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 25756, 26124);
                    return 0;
                }


                bool
                f_10310_26139_26180(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 26139, 26180);
                    return return_v;
                }


                bool
                f_10310_26382_26418(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    var return_v = this_param.HasDynamicArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 26382, 26418);
                    return return_v;
                }


                bool
                f_10310_26422_26469(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.HasAnyApplicableMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 26422, 26469);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_26576_26626(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.GetAllApplicableMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 26576, 26626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_26512_26653(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                applicableMethods, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                queryClause)
                {
                    var return_v = this_param.BindDynamicInvocation(node, expression, arguments, applicableMethods, diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 26512, 26653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_26729_26890(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxNode
                expression, string
                methodName, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                result, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.CSharp.MethodGroup
                methodGroup, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateTypeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                queryClause)
                {
                    var return_v = this_param.BindInvocationExpressionContinued(node, expression, methodName, result, analyzedArguments, methodGroup, delegateTypeOpt, diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 26729, 26890);
                    return return_v;
                }


                int
                f_10310_26922_26953(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 26922, 26953);
                    return 0;
                }


                int
                f_10310_26968_26986(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 26968, 26986);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 25004, 27026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 25004, 27026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasApplicableConditionalMethod(OverloadResolutionResult<MethodSymbol> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10310, 27038, 27444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 27161, 27185);

                var
                r = f_10310_27169_27184(results)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 27208, 27213);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 27199, 27404) || true) && (i < r.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 27229, 27232)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 27199, 27404))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 27199, 27404);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 27266, 27389) || true) && (r[i].IsApplicable && (DynAbs.Tracing.TraceSender.Expression_True(10310, 27270, 27316) && f_10310_27291_27316(r[i].Member)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 27266, 27389);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 27358, 27370);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 27266, 27389);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 27420, 27433);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10310, 27038, 27444);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                f_10310_27169_27184(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 27169, 27184);
                    return return_v;
                }


                bool
                f_10310_27291_27316(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsConditional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 27291, 27316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 27038, 27444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 27038, 27444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindMethodGroupInvocation(
                    SyntaxNode syntax,
                    SyntaxNode expression,
                    string methodName,
                    BoundMethodGroup methodGroup,
                    AnalyzedArguments analyzedArguments,
                    DiagnosticBag diagnostics,
                    CSharpSyntaxNode queryClause,
                    bool allowUnexpandedForm,
                    out bool anyApplicableCandidates)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 27456, 36029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 27893, 27916);

                BoundExpression
                result
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 27930, 27980);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 27994, 28244);

                var
                resolution = f_10310_28011_28243(this, methodGroup, expression, methodName, analyzedArguments, isMethodGroupConversion: false, useSiteDiagnostics: ref useSiteDiagnostics, allowUnexpandedForm: allowUnexpandedForm)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 28258, 28306);

                f_10310_28258_28305(diagnostics, expression, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 28320, 28457);

                anyApplicableCandidates = resolution.ResultKind == LookupResultKind.Viable && (DynAbs.Tracing.TraceSender.Expression_True(10310, 28346, 28456) && f_10310_28398_28456(resolution.OverloadResolutionResult));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 28473, 28549) || true) && (f_10310_28477_28502_M(!methodGroup.HasAnyErrors))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 28473, 28549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 28504, 28549);

                    f_10310_28504_28548(diagnostics, resolution.Diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 28473, 28549);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 28588, 35958) || true) && (resolution.HasAnyErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 28588, 35958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 28649, 28694);

                    ImmutableArray<MethodSymbol>
                    originalMethods
                    = default(ImmutableArray<MethodSymbol>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 28712, 28740);

                    LookupResultKind
                    resultKind
                    = default(LookupResultKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 28758, 28808);

                    ImmutableArray<TypeWithAnnotations>
                    typeArguments
                    = default(ImmutableArray<TypeWithAnnotations>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 28826, 29411) || true) && (resolution.OverloadResolutionResult != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 28826, 29411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 28915, 28989);

                        originalMethods = f_10310_28933_28988(resolution.OverloadResolutionResult);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 29011, 29058);

                        resultKind = f_10310_29024_29057(resolution.MethodGroup);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 29080, 29147);

                        typeArguments = f_10310_29096_29146(f_10310_29096_29132(resolution.MethodGroup));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 28826, 29411);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 28826, 29411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 29229, 29267);

                        originalMethods = f_10310_29247_29266(methodGroup);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 29289, 29325);

                        resultKind = f_10310_29302_29324(methodGroup);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 29347, 29392);

                        typeArguments = f_10310_29363_29391(methodGroup);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 28826, 29411);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 29431, 29832);

                    result = f_10310_29440_29831(this, syntax, methodName, f_10310_29538_29561(methodGroup), originalMethods, resultKind, typeArguments, analyzedArguments, invokedAsExtensionMethod: resolution.IsExtensionMethodGroup, isDelegate: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 28588, 35958);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 28588, 35958);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 29866, 35958) || true) && (f_10310_29870_29889_M(!resolution.IsEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 29866, 35958);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 30372, 35790) || true) && (resolution.ResultKind != LookupResultKind.Viable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 30372, 35790);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 30466, 31126) || true) && (resolution.MethodGroup != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 30466, 31126);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 30682, 30736);

                                DiagnosticBag
                                discarded = f_10310_30708_30735()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 30762, 31060);

                                result = f_10310_30771_31059(this, syntax, expression, methodName, resolution.OverloadResolutionResult, resolution.AnalyzedArguments, resolution.MethodGroup, delegateTypeOpt: null, diagnostics: discarded, queryClause: queryClause);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 31086, 31103);

                                f_10310_31086_31102(discarded);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 30466, 31126);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 31290, 31377);

                            result = f_10310_31299_31376(this, syntax, methodGroup, f_10310_31334_31356(methodGroup), analyzedArguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 30372, 35790);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 30372, 35790);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 31640, 35771) || true) && (f_10310_31644_31691(resolution.AnalyzedArguments) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 31644, 31778) && f_10310_31720_31778(resolution.OverloadResolutionResult)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 31640, 35771);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 31828, 35350) || true) && (resolution.IsLocalFunctionInvocation)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 31828, 35350);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 31926, 32132);

                                    result = f_10310_31935_32131(this, syntax, expression, methodName, methodGroup, diagnostics, queryClause, resolution);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 31828, 35350);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 31828, 35350);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 32190, 35350) || true) && (resolution.IsExtensionMethodGroup)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 32190, 35350);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 32860, 32954);

                                        f_10310_32860_32953(f_10310_32873_32896(methodGroup) != null && (DynAbs.Tracing.TraceSender.Expression_True(10310, 32873, 32952) && (object)f_10310_32916_32944(f_10310_32916_32939(methodGroup)) != null));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 32986, 33103);

                                        f_10310_32986_33102(diagnostics, ErrorCode.ERR_BadArgTypeDynamicExtension, syntax, f_10310_33055_33083(f_10310_33055_33078(methodGroup)), f_10310_33085_33101(methodGroup));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 33133, 33220);

                                        result = f_10310_33142_33219(this, syntax, methodGroup, f_10310_33177_33199(methodGroup), analyzedArguments);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 32190, 35350);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 32190, 35350);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 33334, 33818) || true) && (f_10310_33338_33405(resolution.OverloadResolutionResult))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 33334, 33818);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 33692, 33787);

                                            f_10310_33692_33786(diagnostics, ErrorCode.WRN_DynamicDispatchToConditionalMethod, syntax, f_10310_33769_33785(methodGroup));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 33334, 33818);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 34332, 34804);

                                        var
                                        finalApplicableCandidates = f_10310_34364_34803(this, syntax, resolution.OverloadResolutionResult, f_10310_34542_34565(methodGroup), f_10310_34664_34692(methodGroup), diagnostics)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 34834, 35323) || true) && (finalApplicableCandidates.Length > 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 34834, 35323);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 34940, 35075);

                                            result = f_10310_34949_35074(this, syntax, methodGroup, resolution.AnalyzedArguments, finalApplicableCandidates, diagnostics, queryClause);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 34834, 35323);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 34834, 35323);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 35205, 35292);

                                            result = f_10310_35214_35291(this, syntax, methodGroup, f_10310_35249_35271(methodGroup), analyzedArguments);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 34834, 35323);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 32190, 35350);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 31828, 35350);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 31640, 35771);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 31640, 35771);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 35448, 35748);

                                result = f_10310_35457_35747(this, syntax, expression, methodName, resolution.OverloadResolutionResult, resolution.AnalyzedArguments, resolution.MethodGroup, delegateTypeOpt: null, diagnostics: diagnostics, queryClause: queryClause);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 31640, 35771);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 30372, 35790);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 29866, 35958);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 29866, 35958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 35856, 35943);

                        result = f_10310_35865_35942(this, syntax, methodGroup, f_10310_35900_35922(methodGroup), analyzedArguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 29866, 35958);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 28588, 35958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 35972, 35990);

                resolution.Free();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 36004, 36018);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 27456, 36029);

                Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                f_10310_28011_28243(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, Microsoft.CodeAnalysis.SyntaxNode
                expression, string
                methodName, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, bool
                isMethodGroupConversion, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, bool
                allowUnexpandedForm)
                {
                    var return_v = this_param.ResolveMethodGroup(node, expression, methodName, analyzedArguments, isMethodGroupConversion: isMethodGroupConversion, useSiteDiagnostics: ref useSiteDiagnostics, allowUnexpandedForm: allowUnexpandedForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 28011, 28243);
                    return return_v;
                }


                bool
                f_10310_28258_28305(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 28258, 28305);
                    return return_v;
                }


                bool
                f_10310_28398_28456(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.HasAnyApplicableMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 28398, 28456);
                    return return_v;
                }


                bool
                f_10310_28477_28502_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 28477, 28502);
                    return return_v;
                }


                int
                f_10310_28504_28548(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 28504, 28548);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_28933_28988(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                overloadResolutionResult)
                {
                    var return_v = GetOriginalMethods(overloadResolutionResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 28933, 28988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10310_29024_29057(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 29024, 29057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10310_29096_29132(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 29096, 29132);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10310_29096_29146(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 29096, 29146);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_29247_29266(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 29247, 29266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10310_29302_29324(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 29302, 29324);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10310_29363_29391(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArgumentsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 29363, 29391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10310_29538_29561(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 29538, 29561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_29440_29831(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, string
                name, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, bool
                invokedAsExtensionMethod, bool
                isDelegate)
                {
                    var return_v = this_param.CreateBadCall(node, name, receiver, methods, resultKind, typeArgumentsWithAnnotations, analyzedArguments, invokedAsExtensionMethod: invokedAsExtensionMethod, isDelegate: isDelegate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 29440, 29831);
                    return return_v;
                }


                bool
                f_10310_29870_29889_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 29870, 29889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10310_30708_30735()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 30708, 30735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_30771_31059(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxNode
                expression, string
                methodName, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                result, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.CSharp.MethodGroup
                methodGroup, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateTypeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                queryClause)
                {
                    var return_v = this_param.BindInvocationExpressionContinued(node, expression, methodName, result, analyzedArguments, methodGroup, delegateTypeOpt: delegateTypeOpt, diagnostics: diagnostics, queryClause: queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 30771, 31059);
                    return return_v;
                }


                int
                f_10310_31086_31102(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 31086, 31102);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10310_31334_31356(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 31334, 31356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_31299_31376(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                expr, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments)
                {
                    var return_v = this_param.CreateBadCall(node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expr, resultKind, analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 31299, 31376);
                    return return_v;
                }


                bool
                f_10310_31644_31691(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    var return_v = this_param.HasDynamicArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 31644, 31691);
                    return return_v;
                }


                bool
                f_10310_31720_31778(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.HasAnyApplicableMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 31720, 31778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_31935_32131(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SyntaxNode
                expression, string
                methodName, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                boundMethodGroup, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                queryClause, Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                resolution)
                {
                    var return_v = this_param.BindLocalFunctionInvocationWithDynamicArgument(syntax, expression, methodName, boundMethodGroup, diagnostics, queryClause, resolution);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 31935, 32131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10310_32873_32896(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.InstanceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 32873, 32896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_32916_32939(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.InstanceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 32916, 32939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_32916_32944(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 32916, 32944);
                    return return_v;
                }


                int
                f_10310_32860_32953(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 32860, 32953);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_33055_33078(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.InstanceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 33055, 33078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_33055_33083(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 33055, 33083);
                    return return_v;
                }


                string
                f_10310_33085_33101(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 33085, 33101);
                    return return_v;
                }


                int
                f_10310_32986_33102(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 32986, 33102);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10310_33177_33199(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 33177, 33199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_33142_33219(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                expr, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments)
                {
                    var return_v = this_param.CreateBadCall(node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expr, resultKind, analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 33142, 33219);
                    return return_v;
                }


                bool
                f_10310_33338_33405(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                results)
                {
                    var return_v = HasApplicableConditionalMethod(results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 33338, 33405);
                    return return_v;
                }


                string
                f_10310_33769_33785(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 33769, 33785);
                    return return_v;
                }


                int
                f_10310_33692_33786(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 33692, 33786);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10310_34542_34565(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 34542, 34565);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10310_34664_34692(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArgumentsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 34664, 34692);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_34364_34803(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                overloadResolutionResult, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetCandidatesPassingFinalValidation<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(syntax, overloadResolutionResult, receiverOpt, typeArgumentsOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 34364, 34803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_34949_35074(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                expression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                applicableMethods, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                queryClause)
                {
                    var return_v = this_param.BindDynamicInvocation(node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, arguments, applicableMethods, diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 34949, 35074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10310_35249_35271(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 35249, 35271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_35214_35291(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                expr, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments)
                {
                    var return_v = this_param.CreateBadCall(node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expr, resultKind, analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 35214, 35291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_35457_35747(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxNode
                expression, string
                methodName, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                result, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.CSharp.MethodGroup
                methodGroup, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateTypeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                queryClause)
                {
                    var return_v = this_param.BindInvocationExpressionContinued(node, expression, methodName, result, analyzedArguments, methodGroup, delegateTypeOpt: delegateTypeOpt, diagnostics: diagnostics, queryClause: queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 35457, 35747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10310_35900_35922(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 35900, 35922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_35865_35942(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                expr, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments)
                {
                    var return_v = this_param.CreateBadCall(node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expr, resultKind, analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 35865, 35942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 27456, 36029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 27456, 36029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindLocalFunctionInvocationWithDynamicArgument(
                    SyntaxNode syntax,
                    SyntaxNode expression,
                    string methodName,
                    BoundMethodGroup boundMethodGroup,
                    DiagnosticBag diagnostics,
                    CSharpSyntaxNode queryClause,
                    MethodGroupResolution resolution)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 36041, 41189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 37034, 37085);

                f_10310_37034_37084(resolution.IsLocalFunctionInvocation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 37099, 37159);

                f_10310_37099_37158(f_10310_37112_37157(resolution.OverloadResolutionResult));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 37173, 37207);

                f_10310_37173_37206(queryClause == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 37223, 37289);

                var
                validResult = f_10310_37241_37288(resolution.OverloadResolutionResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 37303, 37367);

                var
                args = f_10310_37314_37366(resolution.AnalyzedArguments.Arguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 37381, 37459);

                var
                refKindsArray = f_10310_37401_37458(resolution.AnalyzedArguments.RefKinds)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 37475, 37556);

                f_10310_37475_37555(syntax, args, refKindsArray, diagnostics, queryClause);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 37572, 37611);

                var
                localFunction = validResult.Member
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 37625, 37663);

                var
                methodResult = validResult.Result
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 38019, 39263) || true) && (f_10310_38023_38070(localFunction) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 38023, 38155) && methodResult.Kind == MemberResolutionKind.ApplicableInNormalForm))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 38019, 39263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 38189, 38231);

                    var
                    parameters = f_10310_38206_38230(localFunction)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 38251, 38292);

                    f_10310_38251_38291(f_10310_38264_38290(parameters.Last()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 38312, 38355);

                    var
                    lastParamIndex = parameters.Length - 1
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 38384, 38389);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 38375, 39248) || true) && (i < args.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 38408, 38411)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 38375, 39248))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 38375, 39248);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 38453, 38471);

                            var
                            arg = args[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 38493, 39229) || true) && (f_10310_38497_38517(arg) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 38497, 38601) && methodResult.ParameterFromArgument(i) == lastParamIndex))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 38493, 39229);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 38651, 38831);

                                f_10310_38651_38830(diagnostics, ErrorCode.ERR_DynamicLocalFunctionParamsParameter, syntax, f_10310_38787_38809(parameters.Last()), f_10310_38811_38829(localFunction));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 38857, 39206);

                                return f_10310_38864_39205(this, syntax, boundMethodGroup, resolution.AnalyzedArguments, f_10310_39059_39120(resolution.OverloadResolutionResult), diagnostics, queryClause);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 38493, 39229);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 874);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 874);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 38019, 39263);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 40106, 40699) || true) && (boundMethodGroup.TypeArgumentsOpt.IsDefaultOrEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10310, 40110, 40193) && f_10310_40164_40193(localFunction)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 40106, 40699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 40227, 40365);

                    f_10310_40227_40364(diagnostics, ErrorCode.ERR_DynamicLocalFunctionTypeParameter, syntax, f_10310_40345_40363(localFunction));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 40383, 40684);

                    return f_10310_40390_40683(this, syntax, boundMethodGroup, resolution.AnalyzedArguments, f_10310_40553_40614(resolution.OverloadResolutionResult), diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 40106, 40699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 40715, 41178);

                return f_10310_40722_41177(this, node: syntax, expression: expression, methodName: methodName, result: resolution.OverloadResolutionResult, analyzedArguments: resolution.AnalyzedArguments, methodGroup: resolution.MethodGroup, delegateTypeOpt: null, diagnostics: diagnostics, queryClause: queryClause);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 36041, 41189);

                int
                f_10310_37034_37084(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 37034, 37084);
                    return 0;
                }


                bool
                f_10310_37112_37157(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Succeeded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 37112, 37157);
                    return return_v;
                }


                int
                f_10310_37099_37158(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 37099, 37158);
                    return 0;
                }


                int
                f_10310_37173_37206(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 37173, 37206);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_37241_37288(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.ValidResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 37241, 37288);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_37314_37366(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 37314, 37366);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10310_37401_37458(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableOrNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 37401, 37458);
                    return return_v;
                }


                bool
                f_10310_37475_37555(Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                queryClause)
                {
                    var return_v = ReportBadDynamicArguments(node, arguments, refKinds, diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 37475, 37555);
                    return return_v;
                }


                bool
                f_10310_38023_38070(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = OverloadResolution.IsValidParams((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 38023, 38070);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10310_38206_38230(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 38206, 38230);
                    return return_v;
                }


                bool
                f_10310_38264_38290(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 38264, 38290);
                    return return_v;
                }


                int
                f_10310_38251_38291(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 38251, 38291);
                    return 0;
                }


                bool
                f_10310_38497_38517(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasDynamicType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 38497, 38517);
                    return return_v;
                }


                string
                f_10310_38787_38809(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 38787, 38809);
                    return return_v;
                }


                string
                f_10310_38811_38829(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 38811, 38829);
                    return return_v;
                }


                int
                f_10310_38651_38830(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 38651, 38830);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_39059_39120(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.GetAllApplicableMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 39059, 39120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_38864_39205(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                expression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                applicableMethods, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                queryClause)
                {
                    var return_v = this_param.BindDynamicInvocation(node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, arguments, applicableMethods, diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 38864, 39205);
                    return return_v;
                }


                bool
                f_10310_40164_40193(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 40164, 40193);
                    return return_v;
                }


                string
                f_10310_40345_40363(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 40345, 40363);
                    return return_v;
                }


                int
                f_10310_40227_40364(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 40227, 40364);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_40553_40614(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.GetAllApplicableMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 40553, 40614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_40390_40683(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                expression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                applicableMethods, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                queryClause)
                {
                    var return_v = this_param.BindDynamicInvocation(node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, arguments, applicableMethods, diagnostics, queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 40390, 40683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_40722_41177(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxNode
                expression, string
                methodName, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                result, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.CSharp.MethodGroup
                methodGroup, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateTypeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                queryClause)
                {
                    var return_v = this_param.BindInvocationExpressionContinued(node: node, expression: expression, methodName: methodName, result: result, analyzedArguments: analyzedArguments, methodGroup: methodGroup, delegateTypeOpt: delegateTypeOpt, diagnostics: diagnostics, queryClause: queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 40722, 41177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 36041, 41189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 36041, 41189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TMethodOrPropertySymbol> GetCandidatesPassingFinalValidation<TMethodOrPropertySymbol>(
                    SyntaxNode syntax,
                    OverloadResolutionResult<TMethodOrPropertySymbol> overloadResolutionResult,
                    BoundExpression receiverOpt,
                    ImmutableArray<TypeWithAnnotations> typeArgumentsOpt,
                    DiagnosticBag diagnostics) where TMethodOrPropertySymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 41201, 44410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 41644, 41706);

                f_10310_41644_41705<TMethodOrPropertySymbol>(f_10310_41657_41704<TMethodOrPropertySymbol>(overloadResolutionResult));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 41722, 41796);

                var
                finalCandidates = f_10310_41744_41795<TMethodOrPropertySymbol>()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 41810, 41843);

                DiagnosticBag
                firstFailed = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 41857, 41922);

                DiagnosticBag
                candidateDiagnostics = f_10310_41894_41921<TMethodOrPropertySymbol>()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 41947, 41952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 41954, 42003);

                    for (int
        i = 0
        ,
        n = f_10310_41958_42003<TMethodOrPropertySymbol>(overloadResolutionResult.ResultsBuilder)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 41938, 43883) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 42012, 42015)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 41938, 43883))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 41938, 43883);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 42049, 42105);

                        var
                        result = f_10310_42062_42104<TMethodOrPropertySymbol>(overloadResolutionResult.ResultsBuilder, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 42123, 43868) || true) && (result.Result.IsApplicable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 42123, 43868);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 43025, 43490) || true) && (!f_10310_43030_43166<TMethodOrPropertySymbol>(this, receiverOpt, result.Member, syntax, candidateDiagnostics, invokedAsExtensionMethod: false) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 43029, 43347) && (typeArgumentsOpt.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10310, 43196, 43346) || f_10310_43226_43346<TMethodOrPropertySymbol>(((MethodSymbol)(object)result.Member), f_10310_43281_43297<TMethodOrPropertySymbol>(this), syntax, f_10310_43307_43323<TMethodOrPropertySymbol>(this), candidateDiagnostics)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 43025, 43490);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 43397, 43432);

                                f_10310_43397_43431<TMethodOrPropertySymbol>(finalCandidates, result.Member);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 43458, 43467);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 43025, 43490);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 43514, 43849) || true) && (firstFailed == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 43514, 43849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 43587, 43622);

                                firstFailed = candidateDiagnostics;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 43648, 43699);

                                candidateDiagnostics = f_10310_43671_43698<TMethodOrPropertySymbol>();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 43514, 43849);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 43514, 43849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 43797, 43826);

                                f_10310_43797_43825<TMethodOrPropertySymbol>(candidateDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 43514, 43849);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 42123, 43868);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 1946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 1946);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 43899, 44295) || true) && (firstFailed != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 43899, 44295);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 44116, 44241) || true) && (f_10310_44120_44141<TMethodOrPropertySymbol>(finalCandidates) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 44116, 44241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 44188, 44222);

                        f_10310_44188_44221<TMethodOrPropertySymbol>(diagnostics, firstFailed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 44116, 44241);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 44261, 44280);

                    f_10310_44261_44279<TMethodOrPropertySymbol>(
                                    firstFailed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 43899, 44295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 44311, 44339);

                f_10310_44311_44338<TMethodOrPropertySymbol>(
                            candidateDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 44355, 44399);

                return f_10310_44362_44398<TMethodOrPropertySymbol>(finalCandidates);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 41201, 44410);

                bool
                f_10310_41657_41704<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMethodOrPropertySymbol>
                this_param) where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = this_param.HasAnyApplicableMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 41657, 41704);
                    return return_v;
                }


                int
                f_10310_41644_41705<TMethodOrPropertySymbol>(bool
                condition) where TMethodOrPropertySymbol : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 41644, 41705);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMethodOrPropertySymbol>
                f_10310_41744_41795<TMethodOrPropertySymbol>() where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = ArrayBuilder<TMethodOrPropertySymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 41744, 41795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10310_41894_41921<TMethodOrPropertySymbol>() where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 41894, 41921);
                    return return_v;
                }


                int
                f_10310_41958_42003<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMethodOrPropertySymbol>>
                this_param) where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 41958, 42003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMethodOrPropertySymbol>
                f_10310_42062_42104<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMethodOrPropertySymbol>>
                this_param, int
                i0) where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 42062, 42104);
                    return return_v;
                }


                bool
                f_10310_43030_43166<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, TMethodOrPropertySymbol
                memberSymbol, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                invokedAsExtensionMethod) where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = this_param.MemberGroupFinalValidationAccessibilityChecks(receiverOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, node, diagnostics, invokedAsExtensionMethod: invokedAsExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 43030, 43166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10310_43281_43297<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.CSharp.Binder
                this_param) where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 43281, 43297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10310_43307_43323<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.CSharp.Binder
                this_param) where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 43307, 43323);
                    return return_v;
                }


                bool
                f_10310_43226_43346<TMethodOrPropertySymbol>(object
                method, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics) where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = ((MethodSymbol)method).CheckConstraints((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, syntaxNode, currentCompilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 43226, 43346);
                    return return_v;
                }


                int
                f_10310_43397_43431<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMethodOrPropertySymbol>
                this_param, TMethodOrPropertySymbol
                item) where TMethodOrPropertySymbol : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 43397, 43431);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10310_43671_43698<TMethodOrPropertySymbol>() where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 43671, 43698);
                    return return_v;
                }


                int
                f_10310_43797_43825<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.DiagnosticBag
                this_param) where TMethodOrPropertySymbol : Symbol

                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 43797, 43825);
                    return 0;
                }


                int
                f_10310_44120_44141<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMethodOrPropertySymbol>
                this_param) where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 44120, 44141);
                    return return_v;
                }


                int
                f_10310_44188_44221<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag) where TMethodOrPropertySymbol : Symbol

                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 44188, 44221);
                    return 0;
                }


                int
                f_10310_44261_44279<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.DiagnosticBag
                this_param) where TMethodOrPropertySymbol : Symbol

                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 44261, 44279);
                    return 0;
                }


                int
                f_10310_44311_44338<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.DiagnosticBag
                this_param) where TMethodOrPropertySymbol : Symbol

                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 44311, 44338);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TMethodOrPropertySymbol>
                f_10310_44362_44398<TMethodOrPropertySymbol>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMethodOrPropertySymbol>
                this_param) where TMethodOrPropertySymbol : Symbol

                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 44362, 44398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 41201, 44410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 41201, 44410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckRestrictedTypeReceiver(BoundExpression expression, CSharpCompilation compilation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 44422, 47691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 44573, 44607);

                f_10310_44573_44606(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 44907, 47680);

                switch (f_10310_44915_44930(expression))
                {

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 44907, 47680);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 45033, 45066);

                            var
                            call = (BoundCall)expression
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 45092, 46603) || true) && (f_10310_45096_45114_M(!call.HasAnyErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 45096, 45142) && f_10310_45118_45134(call) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 45096, 45183) && (object)f_10310_45154_45175(f_10310_45154_45170(call)) != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 45092, 46603);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 45448, 46576) || true) && (f_10310_45452_45492(f_10310_45452_45473(f_10310_45452_45468(call))) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 45452, 45602) && !f_10310_45497_45602(f_10310_45515_45541(f_10310_45515_45526(call)), f_10310_45543_45564(f_10310_45543_45559(call)), TypeCompareKind.ConsiderEverything2)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 45448, 46576);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 45668, 45792);

                                    SymbolDistinguisher
                                    distinguisher = f_10310_45704_45791(compilation, f_10310_45741_45762(f_10310_45741_45757(call)), f_10310_45764_45790(f_10310_45764_45775(call)))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 45826, 45943);

                                    f_10310_45826_45942(diagnostics, ErrorCode.ERR_NoImplicitConv, f_10310_45875_45891(call).Syntax, f_10310_45900_45919(distinguisher), f_10310_45921_45941(distinguisher));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 45448, 46576);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 45448, 46576);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 46112, 46576) || true) && (f_10310_46116_46137(f_10310_46116_46132(call)) == BoundKind.BaseReference && (DynAbs.Tracing.TraceSender.Expression_True(10310, 46116, 46206) && f_10310_46168_46206(f_10310_46168_46187(this))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 46112, 46576);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 46272, 46394);

                                        SymbolDistinguisher
                                        distinguisher = f_10310_46308_46393(compilation, f_10310_46345_46364(this), f_10310_46366_46392(f_10310_46366_46377(call)))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 46428, 46545);

                                        f_10310_46428_46544(diagnostics, ErrorCode.ERR_NoImplicitConv, f_10310_46477_46493(call).Syntax, f_10310_46502_46521(distinguisher), f_10310_46523_46543(distinguisher));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 46112, 46576);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 45448, 46576);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 45092, 46603);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10310, 46648, 46654);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 44907, 47680);

                    case BoundKind.DynamicInvocation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 44907, 47680);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 46754, 46805);

                            var
                            dynInvoke = (BoundDynamicInvocation)expression
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 46831, 47421) || true) && (f_10310_46835_46858_M(!dynInvoke.HasAnyErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 46835, 46932) && (object)f_10310_46899_46924(f_10310_46899_46919(dynInvoke)) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 46835, 47009) && f_10310_46965_47009(f_10310_46965_46990(f_10310_46965_46985(dynInvoke)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 46831, 47421);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 47284, 47394);

                                f_10310_47284_47393(diagnostics, ErrorCode.ERR_BadDynamicMethodArg, f_10310_47338_47358(dynInvoke).Syntax, f_10310_47367_47392(f_10310_47367_47387(dynInvoke)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 46831, 47421);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10310, 47466, 47472);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 44907, 47680);

                    case BoundKind.FunctionPointerInvocation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 44907, 47680);
                        DynAbs.Tracing.TraceSender.TraceBreak(10310, 47553, 47559);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 44907, 47680);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 44907, 47680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 47607, 47665);

                        throw f_10310_47613_47664(f_10310_47648_47663(expression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 44907, 47680);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 44422, 47691);

                int
                f_10310_44573_44606(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 44573, 44606);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_44915_44930(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 44915, 44930);
                    return return_v;
                }


                bool
                f_10310_45096_45114_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45096, 45114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10310_45118_45134(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45118, 45134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_45154_45170(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45154, 45170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_45154_45175(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45154, 45175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_45452_45468(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45452, 45468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_45452_45473(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45452, 45473);
                    return return_v;
                }


                bool
                f_10310_45452_45492(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 45452, 45492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10310_45515_45526(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45515, 45526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10310_45515_45541(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45515, 45541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_45543_45559(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45543, 45559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_45543_45564(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45543, 45564);
                    return return_v;
                }


                bool
                f_10310_45497_45602(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 45497, 45602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_45741_45757(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45741, 45757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_45741_45762(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45741, 45762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10310_45764_45775(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45764, 45775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10310_45764_45790(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45764, 45790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                f_10310_45704_45791(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol0, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol1)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol0, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 45704, 45791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_45875_45891(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45875, 45891);
                    return return_v;
                }


                System.IFormattable
                f_10310_45900_45919(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                this_param)
                {
                    var return_v = this_param.First;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45900, 45919);
                    return return_v;
                }


                System.IFormattable
                f_10310_45921_45941(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                this_param)
                {
                    var return_v = this_param.Second;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 45921, 45941);
                    return return_v;
                }


                int
                f_10310_45826_45942(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 45826, 45942);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_46116_46132(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46116, 46132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_46116_46137(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46116, 46137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10310_46168_46187(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46168, 46187);
                    return return_v;
                }


                bool
                f_10310_46168_46206(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 46168, 46206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10310_46345_46364(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46345, 46364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10310_46366_46377(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46366, 46377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10310_46366_46392(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46366, 46392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                f_10310_46308_46393(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol0, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol1)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol0, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 46308, 46393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_46477_46493(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46477, 46493);
                    return return_v;
                }


                System.IFormattable
                f_10310_46502_46521(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                this_param)
                {
                    var return_v = this_param.First;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46502, 46521);
                    return return_v;
                }


                System.IFormattable
                f_10310_46523_46543(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                this_param)
                {
                    var return_v = this_param.Second;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46523, 46543);
                    return return_v;
                }


                int
                f_10310_46428_46544(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 46428, 46544);
                    return 0;
                }


                bool
                f_10310_46835_46858_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46835, 46858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_46899_46919(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46899, 46919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_46899_46924(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46899, 46924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_46965_46985(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46965, 46985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_46965_46990(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 46965, 46990);
                    return return_v;
                }


                bool
                f_10310_46965_47009(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 46965, 47009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_47338_47358(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 47338, 47358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_47367_47387(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 47367, 47387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_47367_47392(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 47367, 47392);
                    return return_v;
                }


                int
                f_10310_47284_47393(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 47284, 47393);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_47648_47663(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 47648, 47663);
                    return return_v;
                }


                System.Exception
                f_10310_47613_47664(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 47613, 47664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 44422, 47691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 44422, 47691);
            }
        }

        private BoundCall BindInvocationExpressionContinued(
                    SyntaxNode node,
                    SyntaxNode expression,
                    string methodName,
                    OverloadResolutionResult<MethodSymbol> result,
                    AnalyzedArguments analyzedArguments,
                    MethodGroup methodGroup,
                    NamedTypeSymbol delegateTypeOpt,
                    DiagnosticBag diagnostics,
                    CSharpSyntaxNode queryClause = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 48861, 62375);
                Microsoft.CodeAnalysis.BitVector defaultArguments = default(Microsoft.CodeAnalysis.BitVector);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 49320, 49347);

                f_10310_49320_49346(node != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 49361, 49395);

                f_10310_49361_49394(methodGroup != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 49409, 49449);

                f_10310_49409_49448(f_10310_49422_49439(methodGroup) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 49463, 49507);

                f_10310_49463_49506(f_10310_49476_49501(f_10310_49476_49495(methodGroup)) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 49521, 49605);

                f_10310_49521_49604(((object)delegateTypeOpt == null) || (DynAbs.Tracing.TraceSender.Expression_False(10310, 49534, 49603) || (f_10310_49572_49597(f_10310_49572_49591(methodGroup)) == 1)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 49621, 49687);

                var
                invokedAsExtensionMethod = f_10310_49652_49686(methodGroup)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 49873, 49950);

                f_10310_49873_49949(!invokedAsExtensionMethod || (DynAbs.Tracing.TraceSender.Expression_False(10310, 49886, 49948) || ((object)delegateTypeOpt == null)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 50652, 53620) || true) && (f_10310_50656_50673_M(!result.Succeeded))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 50652, 53620);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 50707, 53137) || true) && (f_10310_50711_50738(analyzedArguments))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 50707, 53137);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 50949, 52349);
                            foreach (var argument in f_10310_50974_51001_I(analyzedArguments.Arguments))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 50949, 52349);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 51051, 52326);

                                switch (argument)
                                {

                                    case UnboundLambda unboundLambda:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 51051, 52326);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 51192, 51251);

                                        var
                                        boundWithErrors = f_10310_51214_51250(unboundLambda)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 51285, 51335);

                                        f_10310_51285_51334(diagnostics, f_10310_51306_51333(boundWithErrors));
                                        DynAbs.Tracing.TraceSender.TraceBreak(10310, 51369, 51375);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 51051, 52326);

                                    case BoundUnconvertedObjectCreationExpression _:
                                    case BoundTupleLiteral _:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 51051, 52326);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 51644, 51689);

                                        _ = f_10310_51648_51688(this, argument, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10310, 51723, 51729);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 51051, 52326);

                                    case BoundUnconvertedSwitchExpression { Type: { } naturalType } switchExpr:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 51051, 52326);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 51868, 51965);

                                        _ = f_10310_51872_51964(this, switchExpr, naturalType, conversionIfTargetTyped: null, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10310, 51999, 52005);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 51051, 52326);

                                    case BoundUnconvertedConditionalOperator { Type: { } naturalType } conditionalExpr:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 51051, 52326);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 52152, 52259);

                                        _ = f_10310_52156_52258(this, conditionalExpr, naturalType, conversionIfTargetTyped: null, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10310, 52293, 52299);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 51051, 52326);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 50949, 52349);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 1401);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 1401);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 50707, 53137);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 50707, 53137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 52547, 52613);

                        string
                        name = (DynAbs.Tracing.TraceSender.Conditional_F1(10310, 52561, 52592) || (((object)delegateTypeOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 52595, 52605)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 52608, 52612))) ? methodName : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 52635, 53118);

                        f_10310_52635_53117(result, binder: this, location: f_10310_52710_52770(node, expression), nodeOpt: node, diagnostics: diagnostics, name: name, receiver: f_10310_52860_52880(methodGroup), invokedExpression: expression, arguments: analyzedArguments, memberGroup: f_10310_52956_52989(f_10310_52956_52975(methodGroup)), typeContainingConstructor: null, delegateTypeBeingInvoked: delegateTypeOpt, queryClause: queryClause);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 50707, 53137);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 53157, 53605);

                    return f_10310_53164_53604(this, node, f_10310_53184_53200(methodGroup), (DynAbs.Tracing.TraceSender.Conditional_F1(10310, 53202, 53341) || ((invokedAsExtensionMethod && (DynAbs.Tracing.TraceSender.Expression_True(10310, 53202, 53267) && f_10310_53230_53263(analyzedArguments.Arguments) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 53202, 53341) && (object)f_10310_53279_53299(methodGroup) == (object)f_10310_53311_53341(analyzedArguments.Arguments, 0)) && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 53344, 53348)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 53351, 53371))) ? null : f_10310_53351_53371(methodGroup), f_10310_53394_53420(result), f_10310_53422_53444(methodGroup), f_10310_53446_53485(f_10310_53446_53471(methodGroup)), analyzedArguments, invokedAsExtensionMethod: invokedAsExtensionMethod, isDelegate: ((object)delegateTypeOpt != null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 50652, 53620);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 53827, 53865);

                var
                methodResult = f_10310_53846_53864(result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 53879, 53927);

                var
                returnType = f_10310_53896_53926(methodResult.Member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 53941, 54018);

                f_10310_53941_54017(this, methodResult, analyzedArguments.Arguments, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 54034, 54067);

                var
                method = methodResult.Member
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 54081, 54170);

                var
                expanded = methodResult.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 54184, 54239);

                var
                argsToParams = methodResult.Result.ArgsToParamsOpt
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 54255, 54449);

                f_10310_54255_54448(this, node, f_10310_54282_54299(method), analyzedArguments.Arguments, analyzedArguments.RefKinds, ref argsToParams, out defaultArguments, expanded, enableCallerInfo: true, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 54951, 55091);

                var
                receiver = f_10310_54966_55090(this, f_10310_54993_55013(methodGroup), f_10310_55015_55047_M(!method.RequiresInstanceReceiver) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 55015, 55076) && !invokedAsExtensionMethod), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 55525, 55636);

                var
                gotError = f_10310_55540_55635(this, receiver, method, expression, diagnostics, invokedAsExtensionMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 55652, 55721);

                f_10310_55652_55720(this, receiver, method, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 55737, 58183) || true) && (invokedAsExtensionMethod)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 55737, 58183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 55799, 55864);

                    BoundExpression
                    receiverArgument = f_10310_55834_55863(analyzedArguments, 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 55882, 55944);

                    ParameterSymbol
                    receiverParameter = method.Parameters.First()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 56074, 56538) || true) && ((object)receiver != receiverArgument)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 56074, 56538);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 56287, 56348);

                        f_10310_56287_56347(argsToParams.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10310, 56300, 56346) || argsToParams[0] == 0));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 56370, 56519);

                        receiverArgument = f_10310_56389_56518(this, receiver, methodResult.Result.ConversionForArg(0), f_10310_56482_56504(receiverParameter), diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 56074, 56538);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 56558, 58098) || true) && (f_10310_56562_56587(receiverParameter) == RefKind.Ref)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 56558, 58098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 56871, 56956);

                        receiverArgument = f_10310_56890_56955(this, receiverArgument, BindValueKind.RefOrOut, diagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 56980, 57163) || true) && (f_10310_56984_57016(analyzedArguments.RefKinds) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 56980, 57163);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 57071, 57140);

                            analyzedArguments.RefKinds.Count = f_10310_57106_57139(analyzedArguments.Arguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 56980, 57163);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 57432, 57476);

                        analyzedArguments.RefKinds[0] = RefKind.Ref;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 57498, 57603);

                        f_10310_57498_57602(receiverArgument.Syntax, MessageID.IDS_FeatureRefExtensionMethods, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 56558, 58098);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 56558, 58098);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 57645, 58098) || true) && (f_10310_57649_57674(receiverParameter) == RefKind.In)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 57645, 58098);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 57893, 57952);

                            f_10310_57893_57951(f_10310_57906_57934(analyzedArguments, 0) == RefKind.None);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 57974, 58079);

                            f_10310_57974_58078(receiverArgument.Syntax, MessageID.IDS_FeatureRefExtensionMethods, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 57645, 58098);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 56558, 58098);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 58118, 58168);

                    analyzedArguments.Arguments[0] = receiverArgument;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 55737, 58183);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 58640, 58824) || true) && (invokedAsExtensionMethod || (DynAbs.Tracing.TraceSender.Expression_False(10310, 58644, 58759) || (f_10310_58673_58705_M(!method.RequiresInstanceReceiver) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 58673, 58725) && receiver != null) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 58673, 58758) && f_10310_58729_58758(receiver)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 58640, 58824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 58793, 58809);

                    receiver = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 58640, 58824);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 58840, 58884);

                var
                argNames = f_10310_58855_58883(analyzedArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 58898, 58963);

                var
                argRefKinds = f_10310_58916_58962(analyzedArguments.RefKinds)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 58977, 59030);

                var
                args = f_10310_58988_59029(analyzedArguments.Arguments)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 59046, 59302) || true) && (!gotError && (DynAbs.Tracing.TraceSender.Expression_True(10310, 59050, 59094) && f_10310_59063_59094(method)) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 59050, 59114) && receiver != null) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 59050, 59158) && f_10310_59118_59131(receiver) == BoundKind.ThisReference) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 59050, 59191) && f_10310_59162_59191(receiver)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 59046, 59302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 59225, 59287);

                    gotError = f_10310_59236_59286(this, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 59046, 59302);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 59626, 59980) || true) && (f_10310_59630_59657(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 59626, 59980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 59898, 59965);

                    gotError = f_10310_59909_59952(this, node, diagnostics) || (DynAbs.Tracing.TraceSender.Expression_False(10310, 59909, 59964) || gotError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 59626, 59980);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 59996, 60080);

                bool
                hasBaseReceiver = receiver != null && (DynAbs.Tracing.TraceSender.Expression_True(10310, 60019, 60079) && f_10310_60039_60052(receiver) == BoundKind.BaseReference)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 60096, 60168);

                f_10310_60096_60167(this, diagnostics, method, node, hasBaseReceiver);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 60182, 60287);

                f_10310_60182_60286(diagnostics, method, f_10310_60243_60256(node), isDelegateConversion: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 60485, 60591);

                f_10310_60485_60590(f_10310_60498_60521_M(!method.HasUseSiteError), "Shouldn't have reached this point if there were use site errors.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 60607, 60933) || true) && (f_10310_60611_60638(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 60607, 60933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 60672, 60835);

                    ErrorCode
                    code = (DynAbs.Tracing.TraceSender.Conditional_F1(10310, 60689, 60704) || ((hasBaseReceiver
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 60728, 60771)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 60795, 60834))) ? ErrorCode.ERR_CallingBaseFinalizeDeprecated
                    : ErrorCode.ERR_CallingFinalizeDeprecated
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 60853, 60884);

                    f_10310_60853_60883(diagnostics, code, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 60902, 60918);

                    gotError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 60607, 60933);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 60949, 61024);

                f_10310_60949_61023(args.IsDefaultOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10310, 60962, 61022) || (object)receiver != (object)args[0]));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 61040, 61406) || true) && (!gotError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 61040, 61406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 61087, 61391);

                    gotError = !f_10310_61099_61390(node, method, receiver, f_10310_61233_61250(method), args, argsToParams, f_10310_61335_61355(this), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 61040, 61406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 61422, 61476);

                bool
                isDelegateCall = (object)delegateTypeOpt != null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 61490, 61995) || true) && (!isDelegateCall)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 61490, 61995);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 61543, 61980) || true) && (f_10310_61547_61578(method))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 61543, 61980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 61620, 61961);

                        f_10310_61620_61960(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10310, 61645, 61691) || ((f_10310_61645_61656(node) == SyntaxKind.InvocationExpression && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 61743, 61788)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 61840, 61844))) ? f_10310_61743_61788(((InvocationExpressionSyntax)node)) : node, receiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 61543, 61980);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 61490, 61995);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 62011, 62364);

                return f_10310_62018_62363(node, receiver, method, args, argNames, argRefKinds, isDelegateCall: isDelegateCall, expanded: expanded, invokedAsExtensionMethod: invokedAsExtensionMethod, argsToParamsOpt: argsToParams, defaultArguments, resultKind: LookupResultKind.Viable, type: returnType, hasErrors: gotError);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 48861, 62375);

                int
                f_10310_49320_49346(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 49320, 49346);
                    return 0;
                }


                int
                f_10310_49361_49394(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 49361, 49394);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10310_49422_49439(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 49422, 49439);
                    return return_v;
                }


                int
                f_10310_49409_49448(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 49409, 49448);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_49476_49495(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 49476, 49495);
                    return return_v;
                }


                int
                f_10310_49476_49501(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 49476, 49501);
                    return return_v;
                }


                int
                f_10310_49463_49506(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 49463, 49506);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_49572_49591(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 49572, 49591);
                    return return_v;
                }


                int
                f_10310_49572_49597(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 49572, 49597);
                    return return_v;
                }


                int
                f_10310_49521_49604(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 49521, 49604);
                    return 0;
                }


                bool
                f_10310_49652_49686(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.IsExtensionMethodGroup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 49652, 49686);
                    return return_v;
                }


                int
                f_10310_49873_49949(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 49873, 49949);
                    return 0;
                }


                bool
                f_10310_50656_50673_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 50656, 50673);
                    return return_v;
                }


                bool
                f_10310_50711_50738(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 50711, 50738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10310_51214_51250(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.BindForErrorRecovery();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 51214, 51250);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10310_51306_51333(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 51306, 51333);
                    return return_v;
                }


                int
                f_10310_51285_51334(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 51285, 51334);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_51648_51688(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 51648, 51688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_51872_51964(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.CSharp.Conversion?
                conversionIfTargetTyped, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ConvertSwitchExpression(source, destination, conversionIfTargetTyped: conversionIfTargetTyped, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 51872, 51964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_52156_52258(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.CSharp.Conversion?
                conversionIfTargetTyped, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ConvertConditionalExpression(source, destination, conversionIfTargetTyped: conversionIfTargetTyped, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 52156, 52258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_50974_51001_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 50974, 51001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10310_52710_52770(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxNode
                expression)
                {
                    var return_v = GetLocationForOverloadResolutionDiagnostic(node, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 52710, 52770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_52860_52880(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 52860, 52880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_52956_52975(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 52956, 52975);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_52956_52989(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 52956, 52989);
                    return return_v;
                }


                int
                f_10310_52635_53117(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.SyntaxNode
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, string?
                name, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.SyntaxNode
                invokedExpression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                memberGroup, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeContainingConstructor, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                delegateTypeBeingInvoked, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                queryClause)
                {
                    this_param.ReportDiagnostics<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(binder: binder, location: location, nodeOpt: nodeOpt, diagnostics: diagnostics, name: name, receiver: receiver, invokedExpression: invokedExpression, arguments: arguments, memberGroup: memberGroup, typeContainingConstructor: typeContainingConstructor, delegateTypeBeingInvoked: delegateTypeBeingInvoked, queryClause: queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 52635, 53117);
                    return 0;
                }


                string
                f_10310_53184_53200(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 53184, 53200);
                    return return_v;
                }


                int
                f_10310_53230_53263(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 53230, 53263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_53279_53299(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 53279, 53299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_53311_53341(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 53311, 53341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_53351_53371(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 53351, 53371);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_53394_53420(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                overloadResolutionResult)
                {
                    var return_v = GetOriginalMethods(overloadResolutionResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 53394, 53420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10310_53422_53444(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 53422, 53444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10310_53446_53471(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 53446, 53471);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10310_53446_53485(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 53446, 53485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_53164_53604(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, string
                name, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, bool
                invokedAsExtensionMethod, bool
                isDelegate)
                {
                    var return_v = this_param.CreateBadCall(node, name, receiver, methods, resultKind, typeArgumentsWithAnnotations, analyzedArguments, invokedAsExtensionMethod: invokedAsExtensionMethod, isDelegate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 53164, 53604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_53846_53864(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.ValidResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 53846, 53864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_53896_53926(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 53896, 53926);
                    return return_v;
                }


                int
                f_10310_53941_54017(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methodResult, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CoerceArguments<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(methodResult, arguments, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 53941, 54017);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10310_54282_54299(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 54282, 54299);
                    return return_v;
                }


                int
                f_10310_54255_54448(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argumentsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsBuilder, ref System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, out Microsoft.CodeAnalysis.BitVector
                defaultArguments, bool
                expanded, bool
                enableCallerInfo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.BindDefaultArguments(node, parameters, argumentsBuilder, argumentRefKindsBuilder, ref argsToParamsOpt, out defaultArguments, expanded, enableCallerInfo: enableCallerInfo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 54255, 54448);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_54993_55013(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 54993, 55013);
                    return return_v;
                }


                bool
                f_10310_55015_55047_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 55015, 55047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_54966_55090(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, bool
                useType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReplaceTypeOrValueReceiver(receiver, useType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 54966, 55090);
                    return return_v;
                }


                bool
                f_10310_55540_55635(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                invokedAsExtensionMethod)
                {
                    var return_v = this_param.MemberGroupFinalValidation(receiverOpt, methodSymbol, node, diagnostics, invokedAsExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 55540, 55635);
                    return return_v;
                }


                bool
                f_10310_55652_55720(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckImplicitThisCopyInReadOnlyMember(receiver, method, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 55652, 55720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_55834_55863(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.Argument(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 55834, 55863);
                    return return_v;
                }


                int
                f_10310_56287_56347(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 56287, 56347);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_56482_56504(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 56482, 56504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_56389_56518(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(source, conversion, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 56389, 56518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10310_56562_56587(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 56562, 56587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_56890_56955(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValue(expr, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 56890, 56955);
                    return return_v;
                }


                int
                f_10310_56984_57016(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 56984, 57016);
                    return return_v;
                }


                int
                f_10310_57106_57139(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 57106, 57139);
                    return return_v;
                }


                bool
                f_10310_57498_57602(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability(syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 57498, 57602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10310_57649_57674(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 57649, 57674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10310_57906_57934(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.RefKind(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 57906, 57934);
                    return return_v;
                }


                int
                f_10310_57893_57951(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 57893, 57951);
                    return 0;
                }


                bool
                f_10310_57974_58078(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability(syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 57974, 58078);
                    return return_v;
                }


                bool
                f_10310_58673_58705_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 58673, 58705);
                    return return_v;
                }


                bool
                f_10310_58729_58758(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 58729, 58758);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10310_58855_58883(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    var return_v = this_param.GetNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 58855, 58883);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10310_58916_58962(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableOrNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 58916, 58962);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_58988_59029(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 58988, 59029);
                    return return_v;
                }


                bool
                f_10310_59063_59094(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 59063, 59094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_59118_59131(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 59118, 59131);
                    return return_v;
                }


                bool
                f_10310_59162_59191(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 59162, 59191);
                    return return_v;
                }


                bool
                f_10310_59236_59286(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                thisOrBaseToken, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.IsRefOrOutThisParameterCaptured((Microsoft.CodeAnalysis.SyntaxNodeOrToken)thisOrBaseToken, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 59236, 59286);
                    return return_v;
                }


                bool
                f_10310_59630_59657(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = member.HasUnsafeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 59630, 59657);
                    return return_v;
                }


                bool
                f_10310_59909_59952(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportUnsafeIfNotAllowed(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 59909, 59952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_60039_60052(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 60039, 60052);
                    return return_v;
                }


                int
                f_10310_60096_60167(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 60096, 60167);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10310_60243_60256(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 60243, 60256);
                    return return_v;
                }


                int
                f_10310_60182_60286(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.Location
                location, bool
                isDelegateConversion)
                {
                    ReportDiagnosticsIfUnmanagedCallersOnly(diagnostics, symbol, location, isDelegateConversion: isDelegateConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 60182, 60286);
                    return 0;
                }


                bool
                f_10310_60498_60521_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 60498, 60521);
                    return return_v;
                }


                int
                f_10310_60485_60590(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 60485, 60590);
                    return 0;
                }


                bool
                f_10310_60611_60638(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsRuntimeFinalizer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 60611, 60638);
                    return return_v;
                }


                int
                f_10310_60853_60883(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 60853, 60883);
                    return 0;
                }


                int
                f_10310_60949_61023(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 60949, 61023);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10310_61233_61250(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 61233, 61250);
                    return return_v;
                }


                uint
                f_10310_61335_61355(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 61335, 61355);
                    return return_v;
                }


                bool
                f_10310_61099_61390(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckInvocationArgMixing(syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt, parameters, argsOpt, argsToParamsOpt, scopeOfTheContainingExpression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 61099, 61390);
                    return return_v;
                }


                bool
                f_10310_61547_61578(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 61547, 61578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10310_61645_61656(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 61645, 61656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10310_61743_61788(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 61743, 61788);
                    return return_v;
                }


                int
                f_10310_61620_61960(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                boundLeft, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.WarnOnAccessOfOffDefault(node, boundLeft, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 61620, 61960);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_62018_62363(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                isDelegateCall, bool
                expanded, bool
                invokedAsExtensionMethod, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundCall(syntax, receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall: isDelegateCall, expanded: expanded, invokedAsExtensionMethod: invokedAsExtensionMethod, argsToParamsOpt: argsToParamsOpt, defaultArguments, resultKind: resultKind, type: type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 62018, 62363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 48861, 62375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 48861, 62375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SourceLocation GetCallerLocation(SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10310, 62407, 63223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 62498, 63163);

                var
                token = syntax switch
                {
                    InvocationExpressionSyntax invocation when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 62556, 62635) && DynAbs.Tracing.TraceSender.Expression_True(10310, 62556, 62635))
=> f_10310_62597_62635(f_10310_62597_62620(invocation)),
                    BaseObjectCreationExpressionSyntax objectCreation when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 62654, 62732) && DynAbs.Tracing.TraceSender.Expression_True(10310, 62654, 62732))
=> f_10310_62707_62732(objectCreation),
                    ConstructorInitializerSyntax constructorInitializer when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 62751, 62856) && DynAbs.Tracing.TraceSender.Expression_True(10310, 62751, 62856))
=> f_10310_62806_62856(f_10310_62806_62841(constructorInitializer)),
                    PrimaryConstructorBaseTypeSyntax primaryConstructorBaseType when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 62875, 62992) && DynAbs.Tracing.TraceSender.Expression_True(10310, 62875, 62992))
=> f_10310_62938_62992(f_10310_62938_62977(primaryConstructorBaseType)),
                    ElementAccessExpressionSyntax elementAccess when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 63011, 63101) && DynAbs.Tracing.TraceSender.Expression_True(10310, 63011, 63101))
=> f_10310_63058_63101(f_10310_63058_63084(elementAccess)),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 63120, 63147) && DynAbs.Tracing.TraceSender.Expression_True(10310, 63120, 63147))
=> f_10310_63125_63147(syntax)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 63179, 63212);

                return f_10310_63186_63211(token);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10310, 62407, 63223);

                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10310_62597_62620(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 62597, 62620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10310_62597_62635(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.OpenParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 62597, 62635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10310_62707_62732(Microsoft.CodeAnalysis.CSharp.Syntax.BaseObjectCreationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.NewKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 62707, 62732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10310_62806_62841(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 62806, 62841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10310_62806_62856(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.OpenParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 62806, 62856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10310_62938_62977(Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 62938, 62977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10310_62938_62992(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.OpenParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 62938, 62992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax
                f_10310_63058_63084(Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 63058, 63084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10310_63058_63101(Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.OpenBracketToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 63058, 63101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10310_63125_63147(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 63125, 63147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10310_63186_63211(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 63186, 63211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 62407, 63223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 62407, 63223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression GetDefaultParameterSpecialNoConversion(SyntaxNode syntax, ParameterSymbol parameter, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 63235, 66356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 63395, 63430);

                var
                parameterType = f_10310_63415_63429(parameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 63444, 63542);

                f_10310_63444_63541(f_10310_63457_63482(parameterType) || (DynAbs.Tracing.TraceSender.Expression_False(10310, 63457, 63540) || f_10310_63486_63511(parameterType) == SpecialType.System_Object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 64305, 64342);

                BoundExpression?
                defaultValue = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 64356, 66260) || true) && (f_10310_64360_64387(parameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 64356, 66260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 64457, 64554);

                    defaultValue = new BoundDefaultExpression(syntax, parameterType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 64472, 64553) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 64356, 66260);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 64356, 66260);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 64588, 66260) || true) && (f_10310_64592_64620(parameter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 64588, 66260);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 64654, 65187) || true) && (f_10310_64658_64791(f_10310_64681_64692(), WellKnownMember.System_Runtime_InteropServices_UnknownWrapper__ctor, diagnostics, syntax: syntax) is MethodSymbol methodSymbol)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 64654, 65187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 64922, 65026);

                            var
                            unknownArgument = new BoundDefaultExpression(syntax, parameterType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 64944, 65025) }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 65048, 65168);

                            defaultValue = new BoundObjectCreationExpression(syntax, methodSymbol, unknownArgument) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 65063, 65167) };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 64654, 65187);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 64588, 66260);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 64588, 66260);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 65221, 66260) || true) && (f_10310_65225_65254(parameter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 65221, 66260);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 65288, 65825) || true) && (f_10310_65292_65426(f_10310_65315_65326(), WellKnownMember.System_Runtime_InteropServices_DispatchWrapper__ctor, diagnostics, syntax: syntax) is MethodSymbol methodSymbol)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 65288, 65825);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 65558, 65663);

                                var
                                dispatchArgument = new BoundDefaultExpression(syntax, parameterType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 65581, 65662) }
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 65685, 65806);

                                defaultValue = new BoundObjectCreationExpression(syntax, methodSymbol, dispatchArgument) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 65700, 65805) };
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 65288, 65825);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 65221, 66260);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 65221, 66260);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 65891, 66245) || true) && (f_10310_65895_65997(f_10310_65918_65929(), WellKnownMember.System_Type__Missing, diagnostics, syntax: syntax) is FieldSymbol fieldSymbol)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 65891, 66245);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 66103, 66226);

                                defaultValue = new BoundFieldAccess(syntax, null, fieldSymbol, ConstantValue.NotAvailable) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 66118, 66225) };
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 65891, 66245);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 65221, 66260);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 64588, 66260);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 64356, 66260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 66276, 66345);

                return defaultValue ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10310, 66283, 66344) ?? f_10310_66299_66344(f_10310_66299_66320(this, syntax)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 63235, 66356);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_63415_63429(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 63415, 63429);
                    return return_v;
                }


                bool
                f_10310_63457_63482(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 63457, 63482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10310_63486_63511(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 63486, 63511);
                    return return_v;
                }


                int
                f_10310_63444_63541(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 63444, 63541);
                    return 0;
                }


                bool
                f_10310_64360_64387(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsMarshalAsObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 64360, 64387);
                    return return_v;
                }


                bool
                f_10310_64592_64620(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsIUnknownConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 64592, 64620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10310_64681_64692()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 64681, 64692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10310_64658_64791(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = GetWellKnownTypeMember(compilation, member, diagnostics, syntax: syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 64658, 64791);
                    return return_v;
                }


                bool
                f_10310_65225_65254(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsIDispatchConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 65225, 65254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10310_65315_65326()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 65315, 65326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10310_65292_65426(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = GetWellKnownTypeMember(compilation, member, diagnostics, syntax: syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 65292, 65426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10310_65918_65929()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 65918, 65929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10310_65895_65997(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = GetWellKnownTypeMember(compilation, member, diagnostics, syntax: syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 65895, 65997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10310_66299_66320(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.BadExpression(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 66299, 66320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10310_66299_66344(Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                node)
                {
                    var return_v = node.MakeCompilerGenerated<Microsoft.CodeAnalysis.CSharp.BoundBadExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 66299, 66344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 63235, 66356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 63235, 66356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ParameterSymbol? GetCorrespondingParameter(
                    int argumentOrdinal,
                    ImmutableArray<ParameterSymbol> parameters,
                    ImmutableArray<int> argsToParamsOpt,
                    bool expanded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10310, 66368, 67615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 66621, 66647);

                int
                n = parameters.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 66661, 66688);

                ParameterSymbol?
                parameter
                = default(ParameterSymbol?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 66704, 67571) || true) && (argsToParamsOpt.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 66704, 67571);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 66767, 67116) || true) && (argumentOrdinal < n)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 66767, 67116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 66832, 66872);

                        parameter = parameters[argumentOrdinal];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 66767, 67116);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 66767, 67116);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 66914, 67116) || true) && (expanded)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 66914, 67116);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 66968, 66998);

                            parameter = parameters[n - 1];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 66914, 67116);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 66914, 67116);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 67080, 67097);

                            parameter = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 66914, 67116);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 66767, 67116);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 66704, 67571);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 66704, 67571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 67182, 67237);

                    f_10310_67182_67236(argumentOrdinal < argsToParamsOpt.Length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 67255, 67311);

                    int
                    parameterOrdinal = argsToParamsOpt[argumentOrdinal]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 67331, 67556) || true) && (parameterOrdinal < n)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 67331, 67556);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 67397, 67438);

                        parameter = parameters[parameterOrdinal];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 67331, 67556);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 67331, 67556);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 67520, 67537);

                        parameter = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 67331, 67556);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 66704, 67571);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 67587, 67604);

                return parameter;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10310, 66368, 67615);

                int
                f_10310_67182_67236(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 67182, 67236);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 66368, 67615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 66368, 67615);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void BindDefaultArguments(
                    SyntaxNode node,
                    ImmutableArray<ParameterSymbol> parameters,
                    ArrayBuilder<BoundExpression> argumentsBuilder,
                    ArrayBuilder<RefKind>? argumentRefKindsBuilder,
                    ref ImmutableArray<int> argsToParamsOpt,
                    out BitVector defaultArguments,
                    bool expanded,
                    bool enableCallerInfo,
                    DiagnosticBag diagnostics,
                    bool assertMissingParametersAreOptional = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 67627, 77071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 68162, 68222);

                var
                visitedParameters = BitVector.Create(parameters.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 68245, 68250);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 68236, 68564) || true) && (i < f_10310_68256_68278(argumentsBuilder))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 68280, 68283)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 68236, 68564))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 68236, 68564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 68317, 68401);

                        var
                        parameter = f_10310_68333_68400(i, parameters, argsToParamsOpt, expanded)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 68419, 68549) || true) && (parameter is not null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 68419, 68549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 68486, 68530);

                            visitedParameters[f_10310_68504_68521(parameter)] = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 68419, 68549);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 329);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 329);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 68725, 68934) || true) && (parameters.All(static (param, visitedParameters) => visitedParameters[param.Ordinal], visitedParameters))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 68725, 68934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 68867, 68894);

                    defaultArguments = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 68912, 68919);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 68725, 68934);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 69161, 69341);

                var
                containingMember = f_10310_69184_69202(this) switch
                {
                    FieldSymbol { AssociatedSymbol: { } symbol } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 69242, 69296) && DynAbs.Tracing.TraceSender.Expression_True(10310, 69242, 69296))
=> symbol,
                    var c when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 69315, 69325) && DynAbs.Tracing.TraceSender.Expression_True(10310, 69315, 69325))
=> c
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 69357, 69412);

                defaultArguments = BitVector.Create(parameters.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 69426, 69472);

                ArrayBuilder<int>?
                argsToParamsBuilder = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 69486, 69705) || true) && (f_10310_69490_69516_M(!argsToParamsOpt.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 69486, 69705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 69550, 69626);

                    argsToParamsBuilder = f_10310_69572_69625(argsToParamsOpt.Length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 69644, 69690);

                    f_10310_69644_69689(argsToParamsBuilder, argsToParamsOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 69486, 69705);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 70038, 70108);

                f_10310_70038_70107(!expanded || (DynAbs.Tracing.TraceSender.Expression_False(10310, 70051, 70106) || f_10310_70064_70106(parameters[parameters.Length - 1])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 70257, 70288);

                var
                temp = parameters.AsSpan()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 70302, 70351);

                var
                lastIndex = temp.Length - ((DynAbs.Tracing.TraceSender.Conditional_F1(10310, 70333, 70341) || ((expanded && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 70344, 70345)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 70348, 70349))) ? 1 : 0)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 70472, 71201);
                    foreach (var parameter in f_10310_70498_70522_I(temp.Slice(0, lastIndex)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 70472, 71201);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 70556, 71186) || true) && (f_10310_70560_70597_M(!visitedParameters[f_10310_70579_70596(parameter)]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 70556, 71186);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 70639, 70713);

                            f_10310_70639_70712(f_10310_70652_70672(parameter) || (DynAbs.Tracing.TraceSender.Expression_False(10310, 70652, 70711) || !assertMissingParametersAreOptional));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 70737, 70785);

                            defaultArguments[f_10310_70754_70776(argumentsBuilder)] = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 70807, 70915);

                            f_10310_70807_70914(argumentsBuilder, f_10310_70828_70913(node, parameter, containingMember, enableCallerInfo, diagnostics));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 70939, 71099) || true) && (argumentRefKindsBuilder is { Count: > 0 })
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 70939, 71099);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 71034, 71076);

                                f_10310_71034_71075(argumentRefKindsBuilder, RefKind.None);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 70939, 71099);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 71123, 71167);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(argsToParamsBuilder, 10310, 71123, 71166)?.Add(f_10310_71148_71165(parameter)), 10310, 71143, 71166);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 70556, 71186);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 70472, 71201);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 730);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 730);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 71215, 71358);

                f_10310_71215_71357(argumentRefKindsBuilder is null || (DynAbs.Tracing.TraceSender.Expression_False(10310, 71228, 71297) || f_10310_71263_71292(argumentRefKindsBuilder) == 0) || (DynAbs.Tracing.TraceSender.Expression_False(10310, 71228, 71356) || f_10310_71301_71330(argumentRefKindsBuilder) == f_10310_71334_71356(argumentsBuilder)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 71372, 71469);

                f_10310_71372_71468(argsToParamsBuilder is null || (DynAbs.Tracing.TraceSender.Expression_False(10310, 71385, 71467) || f_10310_71416_71441(argsToParamsBuilder) == f_10310_71445_71467(argumentsBuilder)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 71485, 71670) || true) && (argsToParamsBuilder is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 71485, 71670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 71552, 71610);

                    argsToParamsOpt = f_10310_71570_71609(argsToParamsBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 71628, 71655);

                    f_10310_71628_71654(argsToParamsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 71485, 71670);
                }

                BoundExpression bindDefaultArgument(SyntaxNode syntax, ParameterSymbol parameter, Symbol containingMember, bool enableCallerInfo, DiagnosticBag diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 71686, 77058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 71875, 71917);

                        TypeSymbol
                        parameterType = f_10310_71902_71916(parameter)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 71935, 72438) || true) && (f_10310_71939_71988(Flags, BinderFlags.ParameterDefaultValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 71935, 72438);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 72330, 72419);

                            return new BoundDefaultExpression(syntax, parameterType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 72337, 72418) };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 71935, 72438);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 72458, 72783);

                        var
                        defaultConstantValue = f_10310_72485_72523(parameter) switch
                        {
    // Bad default values are implicitly replaced with default(T) at call sites.
    { IsBad: true } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 72669, 72706) && DynAbs.Tracing.TraceSender.Expression_True(10310, 72669, 72706))
=> f_10310_72688_72706(),
                            var constantValue when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 72729, 72763) && DynAbs.Tracing.TraceSender.Expression_True(10310, 72729, 72763))
=> constantValue
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 72801, 72868);

                        f_10310_72801_72867((object?)defaultConstantValue != f_10310_72847_72866());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 72888, 72967);

                        var
                        callerSourceLocation = (DynAbs.Tracing.TraceSender.Conditional_F1(10310, 72915, 72931) || ((enableCallerInfo && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 72934, 72959)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 72962, 72966))) ? f_10310_72934_72959(syntax) : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 72985, 73014);

                        BoundExpression
                        defaultValue
                        = default(BoundExpression);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 73032, 75676) || true) && (callerSourceLocation is object && (DynAbs.Tracing.TraceSender.Expression_True(10310, 73036, 73098) && f_10310_73070_73098(parameter)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 73032, 75676);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 73140, 73237);

                            int
                            line = f_10310_73151_73236(f_10310_73151_73182(callerSourceLocation), f_10310_73204_73235(callerSourceLocation))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 73259, 73413);

                            defaultValue = new BoundLiteral(syntax, f_10310_73299_73325(line), f_10310_73327_73379(f_10310_73327_73338(), SpecialType.System_Int32)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 73274, 73412) };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 73032, 75676);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 73032, 75676);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 73455, 75676) || true) && (callerSourceLocation is object && (DynAbs.Tracing.TraceSender.Expression_True(10310, 73459, 73519) && f_10310_73493_73519(parameter)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 73455, 75676);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 73561, 73700);

                                string
                                path = f_10310_73575_73699(f_10310_73575_73606(callerSourceLocation), f_10310_73622_73653(callerSourceLocation), f_10310_73655_73698(f_10310_73655_73674(f_10310_73655_73666())))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 73722, 73877);

                                defaultValue = new BoundLiteral(syntax, f_10310_73762_73788(path), f_10310_73790_73843(f_10310_73790_73801(), SpecialType.System_String)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 73737, 73876) };
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 73455, 75676);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 73455, 75676);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 73919, 75676) || true) && (callerSourceLocation is object && (DynAbs.Tracing.TraceSender.Expression_True(10310, 73923, 73985) && f_10310_73957_73985(parameter)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 73919, 75676);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 74027, 74083);

                                    var
                                    memberName = f_10310_74044_74082(containingMember)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 74105, 74266);

                                    defaultValue = new BoundLiteral(syntax, f_10310_74145_74177(memberName), f_10310_74179_74232(f_10310_74179_74190(), SpecialType.System_String)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 74120, 74265) };
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 73919, 75676);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 73919, 75676);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 74308, 75676) || true) && (defaultConstantValue == ConstantValue.NotAvailable)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 74308, 75676);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 74499, 75146) || true) && (f_10310_74503_74528(parameterType) || (DynAbs.Tracing.TraceSender.Expression_False(10310, 74503, 74586) || f_10310_74532_74557(parameterType) == SpecialType.System_Object))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 74499, 75146);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 74757, 74843);

                                            defaultValue = f_10310_74772_74842(this, syntax, parameter, diagnostics);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 74499, 75146);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 74499, 75146);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 75026, 75123);

                                            defaultValue = new BoundDefaultExpression(syntax, parameterType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 75041, 75122) };
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 74499, 75146);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 74308, 75676);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 74308, 75676);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 75188, 75676) || true) && (f_10310_75192_75219(defaultConstantValue))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 75188, 75676);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 75261, 75358);

                                            defaultValue = new BoundDefaultExpression(syntax, parameterType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 75276, 75357) };
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 75188, 75676);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 75188, 75676);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 75440, 75527);

                                            TypeSymbol
                                            constantType = f_10310_75466_75526(f_10310_75466_75477(), f_10310_75493_75525(defaultConstantValue))
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 75549, 75657);

                                            defaultValue = new BoundLiteral(syntax, defaultConstantValue, constantType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 75564, 75656) };
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 75188, 75676);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 74308, 75676);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 73919, 75676);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 73455, 75676);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 73032, 75676);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 75696, 75747);

                        HashSet<DiagnosticInfo>?
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 75765, 75887);

                        Conversion
                        conversion = f_10310_75789_75886(f_10310_75789_75800(), defaultValue, parameterType, ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 75905, 75949);

                        f_10310_75905_75948(diagnostics, syntax, useSiteDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 75969, 77003) || true) && (f_10310_75973_75992_M(!conversion.IsValid) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 75973, 76094) && defaultConstantValue is { SpecialType: SpecialType.System_Decimal or SpecialType.System_DateTime }))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 75969, 77003);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 76507, 76604);

                            defaultValue = new BoundDefaultExpression(syntax, parameterType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10310, 76522, 76603) };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 75969, 77003);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 75969, 77003);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 76686, 76876) || true) && (f_10310_76690_76709_M(!conversion.IsValid))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 76686, 76876);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 76759, 76853);

                                f_10310_76759_76852(this, diagnostics, syntax, conversion, defaultValue, parameterType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 76686, 76876);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 76898, 76984);

                            defaultValue = f_10310_76913_76983(this, defaultValue, conversion, parameterType, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 75969, 77003);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 77023, 77043);

                        return defaultValue;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 71686, 77058);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10310_71902_71916(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 71902, 71916);
                            return return_v;
                        }


                        bool
                        f_10310_71939_71988(Microsoft.CodeAnalysis.CSharp.BinderFlags
                        self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                        other)
                        {
                            var return_v = self.Includes(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 71939, 71988);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValue?
                        f_10310_72485_72523(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ExplicitDefaultConstantValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 72485, 72523);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValue
                        f_10310_72688_72706()
                        {
                            var return_v = ConstantValue.Null;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 72688, 72706);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValue
                        f_10310_72847_72866()
                        {
                            var return_v = ConstantValue.Unset;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 72847, 72866);
                            return return_v;
                        }


                        int
                        f_10310_72801_72867(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 72801, 72867);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.SourceLocation
                        f_10310_72934_72959(Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            var return_v = GetCallerLocation(syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 72934, 72959);
                            return return_v;
                        }


                        bool
                        f_10310_73070_73098(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.IsCallerLineNumber;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73070, 73098);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTree
                        f_10310_73151_73182(Microsoft.CodeAnalysis.SourceLocation
                        this_param)
                        {
                            var return_v = this_param.SourceTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73151, 73182);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Text.TextSpan
                        f_10310_73204_73235(Microsoft.CodeAnalysis.SourceLocation
                        this_param)
                        {
                            var return_v = this_param.SourceSpan;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73204, 73235);
                            return return_v;
                        }


                        int
                        f_10310_73151_73236(Microsoft.CodeAnalysis.SyntaxTree
                        this_param, Microsoft.CodeAnalysis.Text.TextSpan
                        span)
                        {
                            var return_v = this_param.GetDisplayLineNumber(span);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 73151, 73236);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValue
                        f_10310_73299_73325(int
                        value)
                        {
                            var return_v = ConstantValue.Create(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 73299, 73325);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10310_73327_73338()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73327, 73338);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10310_73327_73379(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.SpecialType
                        specialType)
                        {
                            var return_v = this_param.GetSpecialType(specialType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 73327, 73379);
                            return return_v;
                        }


                        bool
                        f_10310_73493_73519(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.IsCallerFilePath;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73493, 73519);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTree
                        f_10310_73575_73606(Microsoft.CodeAnalysis.SourceLocation
                        this_param)
                        {
                            var return_v = this_param.SourceTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73575, 73606);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Text.TextSpan
                        f_10310_73622_73653(Microsoft.CodeAnalysis.SourceLocation
                        this_param)
                        {
                            var return_v = this_param.SourceSpan;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73622, 73653);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10310_73655_73666()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73655, 73666);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                        f_10310_73655_73674(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.Options;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73655, 73674);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SourceReferenceResolver?
                        f_10310_73655_73698(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                        this_param)
                        {
                            var return_v = this_param.SourceReferenceResolver;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73655, 73698);
                            return return_v;
                        }


                        string
                        f_10310_73575_73699(Microsoft.CodeAnalysis.SyntaxTree
                        this_param, Microsoft.CodeAnalysis.Text.TextSpan
                        span, Microsoft.CodeAnalysis.SourceReferenceResolver?
                        resolver)
                        {
                            var return_v = this_param.GetDisplayPath(span, resolver);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 73575, 73699);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValue
                        f_10310_73762_73788(string
                        value)
                        {
                            var return_v = ConstantValue.Create(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 73762, 73788);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10310_73790_73801()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73790, 73801);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10310_73790_73843(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.SpecialType
                        specialType)
                        {
                            var return_v = this_param.GetSpecialType(specialType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 73790, 73843);
                            return return_v;
                        }


                        bool
                        f_10310_73957_73985(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.IsCallerMemberName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 73957, 73985);
                            return return_v;
                        }


                        string
                        f_10310_74044_74082(Microsoft.CodeAnalysis.CSharp.Symbol
                        member)
                        {
                            var return_v = member.GetMemberCallerName();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 74044, 74082);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValue
                        f_10310_74145_74177(string
                        value)
                        {
                            var return_v = ConstantValue.Create(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 74145, 74177);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10310_74179_74190()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 74179, 74190);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10310_74179_74232(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.SpecialType
                        specialType)
                        {
                            var return_v = this_param.GetSpecialType(specialType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 74179, 74232);
                            return return_v;
                        }


                        bool
                        f_10310_74503_74528(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsDynamic();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 74503, 74528);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10310_74532_74557(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 74532, 74557);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10310_74772_74842(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        parameter, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = this_param.GetDefaultParameterSpecialNoConversion(syntax, parameter, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 74772, 74842);
                            return return_v;
                        }


                        bool
                        f_10310_75192_75219(Microsoft.CodeAnalysis.ConstantValue
                        this_param)
                        {
                            var return_v = this_param.IsNull;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 75192, 75219);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10310_75466_75477()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 75466, 75477);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10310_75493_75525(Microsoft.CodeAnalysis.ConstantValue
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 75493, 75525);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10310_75466_75526(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.SpecialType
                        specialType)
                        {
                            var return_v = this_param.GetSpecialType(specialType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 75466, 75526);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Conversions
                        f_10310_75789_75800()
                        {
                            var return_v = Conversions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 75789, 75800);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Conversion
                        f_10310_75789_75886(Microsoft.CodeAnalysis.CSharp.Conversions
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 75789, 75886);
                            return return_v;
                        }


                        bool
                        f_10310_75905_75948(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                        node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                        useSiteDiagnostics)
                        {
                            var return_v = diagnostics.Add(node, useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 75905, 75948);
                            return return_v;
                        }


                        bool
                        f_10310_75973_75992_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 75973, 75992);
                            return return_v;
                        }


                        bool
                        f_10310_76690_76709_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 76690, 76709);
                            return return_v;
                        }


                        int
                        f_10310_76759_76852(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.Conversion
                        conversion, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        targetType)
                        {
                            this_param.GenerateImplicitConversionError(diagnostics, syntax, conversion, operand, targetType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 76759, 76852);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10310_76913_76983(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        source, Microsoft.CodeAnalysis.CSharp.Conversion
                        conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = this_param.CreateConversion(source, conversion, destination, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 76913, 76983);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 71686, 77058);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 71686, 77058);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 67627, 77071);

                int
                f_10310_68256_68278(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 68256, 68278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?
                f_10310_68333_68400(int
                argumentOrdinal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, bool
                expanded)
                {
                    var return_v = GetCorrespondingParameter(argumentOrdinal, parameters, argsToParamsOpt, expanded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 68333, 68400);
                    return return_v;
                }


                int
                f_10310_68504_68521(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 68504, 68521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10310_69184_69202(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMember();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 69184, 69202);
                    return return_v;
                }


                bool
                f_10310_69490_69516_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 69490, 69516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_10310_69572_69625(int
                capacity)
                {
                    var return_v = ArrayBuilder<int>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 69572, 69625);
                    return return_v;
                }


                int
                f_10310_69644_69689(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, System.Collections.Immutable.ImmutableArray<int>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 69644, 69689);
                    return 0;
                }


                bool
                f_10310_70064_70106(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 70064, 70106);
                    return return_v;
                }


                int
                f_10310_70038_70107(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 70038, 70107);
                    return 0;
                }


                int
                f_10310_70579_70596(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 70579, 70596);
                    return return_v;
                }


                bool
                f_10310_70560_70597_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 70560, 70597);
                    return return_v;
                }


                bool
                f_10310_70652_70672(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 70652, 70672);
                    return return_v;
                }


                int
                f_10310_70639_70712(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 70639, 70712);
                    return 0;
                }


                int
                f_10310_70754_70776(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 70754, 70776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_70828_70913(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Symbol
                containingMember, bool
                enableCallerInfo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = bindDefaultArgument(syntax, parameter, containingMember, enableCallerInfo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 70828, 70913);
                    return return_v;
                }


                int
                f_10310_70807_70914(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 70807, 70914);
                    return 0;
                }


                int
                f_10310_71034_71075(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.RefKind
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 71034, 71075);
                    return 0;
                }


                int
                f_10310_71148_71165(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 71148, 71165);
                    return return_v;
                }


                System.ReadOnlySpan<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10310_70498_70522_I(System.ReadOnlySpan<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 70498, 70522);
                    return return_v;
                }


                int
                f_10310_71263_71292(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 71263, 71292);
                    return return_v;
                }


                int
                f_10310_71301_71330(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 71301, 71330);
                    return return_v;
                }


                int
                f_10310_71334_71356(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 71334, 71356);
                    return return_v;
                }


                int
                f_10310_71215_71357(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 71215, 71357);
                    return 0;
                }


                int
                f_10310_71416_71441(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 71416, 71441);
                    return return_v;
                }


                int
                f_10310_71445_71467(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 71445, 71467);
                    return return_v;
                }


                int
                f_10310_71372_71468(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 71372, 71468);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10310_71570_71609(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.ToImmutableOrNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 71570, 71609);
                    return return_v;
                }


                int
                f_10310_71628_71654(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 71628, 71654);
                    return 0;
                }


            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 67627, 77071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 67627, 77071);
            }
        }

        internal bool CheckImplicitThisCopyInReadOnlyMember(BoundExpression receiver, MethodSymbol method, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 77275, 78415);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 77677, 78376) || true) && (receiver is BoundThisReference && (DynAbs.Tracing.TraceSender.Expression_True(10310, 77681, 77757) && f_10310_77732_77757(f_10310_77732_77745(receiver))) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 77681, 77835) && f_10310_77778_77802() is MethodSymbol containingMethod) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 77681, 77894) && f_10310_77856_77894(containingMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 77681, 78074) && f_10310_77965_78074(f_10310_77983_78014(containingMethod), f_10310_78016_78037(method), TypeCompareKind.ConsiderEverything)) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 77681, 78124) && f_10310_78095_78124_M(!method.IsEffectivelyReadOnly)) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 77681, 78176) && f_10310_78145_78176(method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 77677, 78376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 78210, 78330);

                    f_10310_78210_78329(diagnostics, ErrorCode.WRN_ImplicitCopyInReadOnlyMember, receiver.Syntax, method, ThisParameterSymbol.SymbolName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 78348, 78361);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 77677, 78376);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 78392, 78404);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 77275, 78415);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_77732_77745(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 77732, 77745);
                    return return_v;
                }


                bool
                f_10310_77732_77757(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 77732, 77757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10310_77778_77802()
                {
                    var return_v = ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 77778, 77802);
                    return return_v;
                }


                bool
                f_10310_77856_77894(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsEffectivelyReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 77856, 77894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10310_77983_78014(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 77983, 78014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10310_78016_78037(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 78016, 78037);
                    return return_v;
                }


                bool
                f_10310_77965_78074(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 77965, 78074);
                    return return_v;
                }


                bool
                f_10310_78095_78124_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 78095, 78124);
                    return return_v;
                }


                bool
                f_10310_78145_78176(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 78145, 78176);
                    return return_v;
                }


                int
                f_10310_78210_78329(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 78210, 78329);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 77275, 78415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 77275, 78415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Location GetLocationForOverloadResolutionDiagnostic(SyntaxNode node, SyntaxNode expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10310, 78592, 79288);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 78723, 79229) || true) && (node != expression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 78723, 79229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 78779, 79214);

                    switch (f_10310_78787_78804(expression))
                    {

                        case SyntaxKind.QualifiedName:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 78779, 79214);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 78902, 78963);

                            return f_10310_78909_78962(f_10310_78909_78948(((QualifiedNameSyntax)expression)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 78779, 79214);

                        case SyntaxKind.SimpleMemberAccessExpression:
                        case SyntaxKind.PointerMemberAccessExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 78779, 79214);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 79126, 79195);

                            return f_10310_79133_79194(f_10310_79133_79180(((MemberAccessExpressionSyntax)expression)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 78779, 79214);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 78723, 79229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 79245, 79277);

                return f_10310_79252_79276(expression);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10310, 78592, 79288);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10310_78787_78804(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 78787, 78804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10310_78909_78948(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 78909, 78948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10310_78909_78962(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 78909, 78962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10310_79133_79180(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 79133, 79180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10310_79133_79194(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 79133, 79194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10310_79252_79276(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 79252, 79276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 78592, 79288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 78592, 79288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression ReplaceTypeOrValueReceiver(BoundExpression receiver, bool useType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 79836, 81330);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 79978, 80067) || true) && ((object)receiver == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 79978, 80067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 80040, 80052);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 79978, 80067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 80083, 81319);

                switch (f_10310_80091_80104(receiver))
                {

                    case BoundKind.TypeOrValueExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 80083, 81319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 80197, 80252);

                        var
                        typeOrValue = (BoundTypeOrValueExpression)receiver
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 80274, 80745) || true) && (useType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 80274, 80745);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 80335, 80390);

                            f_10310_80335_80389(diagnostics, typeOrValue.Data.TypeDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 80416, 80455);

                            return typeOrValue.Data.TypeExpression;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 80274, 80745);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 80274, 80745);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 80553, 80609);

                            f_10310_80553_80608(diagnostics, typeOrValue.Data.ValueDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 80635, 80722);

                            return f_10310_80642_80721(this, typeOrValue.Data.ValueExpression, BindValueKind.RValue, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 80274, 80745);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 80083, 81319);

                    case BoundKind.QueryClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 80083, 81319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 80887, 80922);

                        var
                        q = (BoundQueryClause)receiver
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 80944, 80964);

                        var
                        value = f_10310_80956_80963(q)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 80986, 81057);

                        var
                        replaced = f_10310_81001_81056(this, value, useType, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 81079, 81206);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10310, 81086, 81105) || (((value == replaced) && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 81108, 81109)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 81112, 81205))) ? q : f_10310_81112_81205(q, replaced, f_10310_81131_81146(q), f_10310_81148_81159(q), f_10310_81161_81167(q), f_10310_81169_81177(q), f_10310_81179_81196(q), f_10310_81198_81204(q));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 80083, 81319);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 80083, 81319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 81256, 81304);

                        return f_10310_81263_81303(this, receiver, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 80083, 81319);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 79836, 81330);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_80091_80104(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 80091, 80104);
                    return return_v;
                }


                int
                f_10310_80335_80389(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 80335, 80389);
                    return 0;
                }


                int
                f_10310_80553_80608(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 80553, 80608);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_80642_80721(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValue(expr, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 80642, 80721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_80956_80963(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 80956, 80963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_81001_81056(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, bool
                useType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReplaceTypeOrValueReceiver(receiver, useType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 81001, 81056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                f_10310_81131_81146(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.DefinedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 81131, 81146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10310_81148_81159(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 81148, 81159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10310_81161_81167(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Cast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 81161, 81167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10310_81169_81177(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 81169, 81177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10310_81179_81196(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.UnoptimizedForm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 81179, 81196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_81198_81204(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 81198, 81204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10310_81112_81205(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                definedSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                operation, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                cast, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                unoptimizedForm, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(value, definedSymbol, operation, cast, binder, unoptimizedForm, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 81112, 81205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_81263_81303(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 81263, 81303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 79836, 81330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 79836, 81330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static NamedTypeSymbol GetDelegateType(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10310, 81469, 81895);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 81562, 81858) || true) && ((object)expr != null && (DynAbs.Tracing.TraceSender.Expression_True(10310, 81566, 81627) && f_10310_81590_81599(expr) != BoundKind.TypeExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 81562, 81858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 81661, 81701);

                    var
                    type = f_10310_81672_81681(expr) as NamedTypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 81719, 81843) || true) && (((object)type != null) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 81723, 81770) && f_10310_81749_81770(type)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 81719, 81843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 81812, 81824);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 81719, 81843);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 81562, 81858);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 81872, 81884);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10310, 81469, 81895);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_81590_81599(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 81590, 81599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_81672_81681(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 81672, 81681);
                    return return_v;
                }


                bool
                f_10310_81749_81770(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 81749, 81770);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 81469, 81895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 81469, 81895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundCall CreateBadCall(
                    SyntaxNode node,
                    string name,
                    BoundExpression receiver,
                    ImmutableArray<MethodSymbol> methods,
                    LookupResultKind resultKind,
                    ImmutableArray<TypeWithAnnotations> typeArgumentsWithAnnotations,
                    AnalyzedArguments analyzedArguments,
                    bool invokedAsExtensionMethod,
                    bool isDelegate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 81907, 84049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 82355, 82375);

                MethodSymbol
                method
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 82389, 82426);

                ImmutableArray<BoundExpression>
                args
                = default(ImmutableArray<BoundExpression>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 82440, 82924) || true) && (f_10310_82444_82490_M(!typeArgumentsWithAnnotations.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 82440, 82924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 82524, 82590);

                    var
                    constructedMethods = f_10310_82549_82589()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 82608, 82839);
                        foreach (var m in f_10310_82626_82633_I(methods))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 82608, 82839);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 82675, 82820);

                            f_10310_82675_82819(constructedMethods, (DynAbs.Tracing.TraceSender.Conditional_F1(10310, 82698, 82770) || ((f_10310_82698_82715(m) == m && (DynAbs.Tracing.TraceSender.Expression_True(10310, 82698, 82770) && f_10310_82724_82731(m) == typeArgumentsWithAnnotations.Length) && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 82773, 82814)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 82817, 82818))) ? f_10310_82773_82814(m, typeArgumentsWithAnnotations) : m);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 82608, 82839);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 232);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 232);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 82859, 82909);

                    methods = f_10310_82869_82908(constructedMethods);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 82440, 82924);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 82940, 83535) || true) && (methods.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10310, 82944, 82996) && !f_10310_82968_82996(methods[0])))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 82940, 83535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 83030, 83050);

                    method = methods[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 82940, 83535);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 82940, 83535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 83116, 83258);

                    var
                    returnType = f_10310_83133_83167(methods) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>(10310, 83133, 83257) ?? f_10310_83171_83257(f_10310_83199_83215(this), string.Empty, arity: 0, errorInfo: null))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 83276, 83436);

                    var
                    methodContainer = (DynAbs.Tracing.TraceSender.Conditional_F1(10310, 83298, 83355) || (((object)receiver != null && (DynAbs.Tracing.TraceSender.Expression_True(10310, 83298, 83355) && (object)f_10310_83334_83347(receiver) != null
                    ) && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 83379, 83392)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 83416, 83435))) ? f_10310_83379_83392(receiver) : f_10310_83416_83435(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 83454, 83520);

                    method = f_10310_83463_83519(methodContainer, returnType, name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 82940, 83535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 83551, 83617);

                args = f_10310_83558_83616(this, analyzedArguments, methods);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 83631, 83675);

                var
                argNames = f_10310_83646_83674(analyzedArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 83689, 83754);

                var
                argRefKinds = f_10310_83707_83753(analyzedArguments.RefKinds)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 83768, 83816);

                receiver = f_10310_83779_83815(this, receiver);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 83830, 84038);

                return f_10310_83837_84037(node, receiver, method, args, argNames, argRefKinds, isDelegate, invokedAsExtensionMethod: invokedAsExtensionMethod, originalMethods: methods, resultKind: resultKind, binder: this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 81907, 84049);

                bool
                f_10310_82444_82490_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 82444, 82490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_82549_82589()
                {
                    var return_v = ArrayBuilder<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 82549, 82589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10310_82698_82715(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 82698, 82715);
                    return return_v;
                }


                int
                f_10310_82724_82731(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 82724, 82731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10310_82773_82814(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 82773, 82814);
                    return return_v;
                }


                int
                f_10310_82675_82819(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 82675, 82819);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_82626_82633_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 82626, 82633);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_82869_82908(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 82869, 82908);
                    return return_v;
                }


                bool
                f_10310_82968_82996(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = IsUnboundGeneric(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 82968, 82996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_83133_83167(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                members)
                {
                    var return_v = GetCommonTypeOrReturnType(members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 83133, 83167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10310_83199_83215(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 83199, 83215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10310_83171_83257(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                name, int
                arity, Microsoft.CodeAnalysis.DiagnosticInfo?
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(compilation, name, arity: arity, errorInfo: errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 83171, 83257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_83334_83347(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 83334, 83347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_83379_83392(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 83379, 83392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10310_83416_83435(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 83416, 83435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol
                f_10310_83463_83519(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol(containingType, returnType, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 83463, 83519);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_83558_83616(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods)
                {
                    var return_v = this_param.BuildArgumentsForErrorRecovery(analyzedArguments, methods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 83558, 83616);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10310_83646_83674(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    var return_v = this_param.GetNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 83646, 83674);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10310_83707_83753(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableOrNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 83707, 83753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_83779_83815(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression)
                {
                    var return_v = this_param.BindToTypeForErrorRecovery(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 83779, 83815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_83837_84037(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                namedArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, bool
                isDelegateCall, bool
                invokedAsExtensionMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                originalMethods, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = BoundCall.ErrorCall(node, receiverOpt, method, arguments, namedArguments, refKinds, isDelegateCall, invokedAsExtensionMethod: invokedAsExtensionMethod, originalMethods: originalMethods, resultKind: resultKind, binder: binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 83837, 84037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 81907, 84049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 81907, 84049);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsUnboundGeneric(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10310, 84061, 84222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 84143, 84211);

                return f_10310_84150_84172(method) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 84150, 84210) && f_10310_84176_84200(method) == method);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10310, 84061, 84222);

                bool
                f_10310_84150_84172(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 84150, 84172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10310_84176_84200(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.ConstructedFrom();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 84176, 84200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 84061, 84222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 84061, 84222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const int
        MaxParameterListsForErrorRecovery = 10
        ;

        private ImmutableArray<BoundExpression> BuildArgumentsForErrorRecovery(AnalyzedArguments analyzedArguments, ImmutableArray<MethodSymbol> methods)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 84509, 85337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 84679, 84763);

                var
                parameterListList = f_10310_84703_84762()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 84777, 85161);
                    foreach (var m in f_10310_84795_84802_I(methods))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 84777, 85161);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 84836, 85146) || true) && (!f_10310_84841_84860(m) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 84840, 84884) && f_10310_84864_84880(m) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 84836, 85146);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 84926, 84962);

                            f_10310_84926_84961(parameterListList, f_10310_84948_84960(m));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 84984, 85127) || true) && (f_10310_84988_85011(parameterListList) == MaxParameterListsForErrorRecovery)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 84984, 85127);
                                DynAbs.Tracing.TraceSender.TraceBreak(10310, 85098, 85104);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 84984, 85127);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 84836, 85146);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 84777, 85161);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 385);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 85177, 85259);

                var
                result = f_10310_85190_85258(this, analyzedArguments, parameterListList)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 85273, 85298);

                f_10310_85273_85297(parameterListList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 85312, 85326);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 84509, 85337);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                f_10310_84703_84762()
                {
                    var return_v = ArrayBuilder<ImmutableArray<ParameterSymbol>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 84703, 84762);
                    return return_v;
                }


                bool
                f_10310_84841_84860(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = IsUnboundGeneric(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 84841, 84860);
                    return return_v;
                }


                int
                f_10310_84864_84880(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 84864, 84880);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10310_84948_84960(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 84948, 84960);
                    return return_v;
                }


                int
                f_10310_84926_84961(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 84926, 84961);
                    return 0;
                }


                int
                f_10310_84988_85011(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 84988, 85011);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_84795_84802_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 84795, 84802);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_85190_85258(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                parameterListList)
                {
                    var return_v = this_param.BuildArgumentsForErrorRecovery(analyzedArguments, (System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>)parameterListList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 85190, 85258);
                    return return_v;
                }


                int
                f_10310_85273_85297(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 85273, 85297);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 84509, 85337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 84509, 85337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<BoundExpression> BuildArgumentsForErrorRecovery(AnalyzedArguments analyzedArguments, ImmutableArray<PropertySymbol> properties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 85349, 86161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 85524, 85608);

                var
                parameterListList = f_10310_85548_85607()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 85622, 85985);
                    foreach (var p in f_10310_85640_85650_I(properties))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 85622, 85985);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 85684, 85970) || true) && (f_10310_85688_85704(p) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 85684, 85970);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 85750, 85786);

                            f_10310_85750_85785(parameterListList, f_10310_85772_85784(p));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 85808, 85951) || true) && (f_10310_85812_85835(parameterListList) == MaxParameterListsForErrorRecovery)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 85808, 85951);
                                DynAbs.Tracing.TraceSender.TraceBreak(10310, 85922, 85928);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 85808, 85951);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 85684, 85970);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 85622, 85985);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 364);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86001, 86083);

                var
                result = f_10310_86014_86082(this, analyzedArguments, parameterListList)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86097, 86122);

                f_10310_86097_86121(parameterListList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86136, 86150);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 85349, 86161);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                f_10310_85548_85607()
                {
                    var return_v = ArrayBuilder<ImmutableArray<ParameterSymbol>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 85548, 85607);
                    return return_v;
                }


                int
                f_10310_85688_85704(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 85688, 85704);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10310_85772_85784(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 85772, 85784);
                    return return_v;
                }


                int
                f_10310_85750_85785(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 85750, 85785);
                    return 0;
                }


                int
                f_10310_85812_85835(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 85812, 85835);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10310_85640_85650_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 85640, 85650);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_86014_86082(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                parameterListList)
                {
                    var return_v = this_param.BuildArgumentsForErrorRecovery(analyzedArguments, (System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>)parameterListList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 86014, 86082);
                    return return_v;
                }


                int
                f_10310_86097_86121(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 86097, 86121);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 85349, 86161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 85349, 86161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<BoundExpression> BuildArgumentsForErrorRecovery(AnalyzedArguments analyzedArguments, IEnumerable<ImmutableArray<ParameterSymbol>> parameterListList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 86173, 91824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86369, 86424);

                var
                discardedDiagnostics = f_10310_86396_86423()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86438, 86492);

                int
                argumentCount = f_10310_86458_86491(analyzedArguments.Arguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86506, 86608);

                ArrayBuilder<BoundExpression>
                newArguments = f_10310_86551_86607(argumentCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86622, 86673);

                f_10310_86622_86672(newArguments, analyzedArguments.Arguments);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86696, 86701);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86687, 90587) || true) && (i < argumentCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86722, 86725)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 86687, 90587))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 86687, 90587);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86759, 86790);

                        var
                        argument = f_10310_86774_86789(newArguments, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 86808, 90572);

                        switch (f_10310_86816_86829(argument))
                        {

                            case BoundKind.UnboundLambda:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 86808, 90572);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 87041, 87087);

                                    var
                                    unboundArgument = (UnboundLambda)argument
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 87117, 87695);
                                        foreach (var parameterList in f_10310_87147_87164_I(parameterListList))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 87117, 87695);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 87230, 87317);

                                            var
                                            parameterType = f_10310_87250_87316(analyzedArguments, i, parameterList)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 87351, 87664) || true) && (f_10310_87355_87374_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(parameterType, 10310, 87355, 87374)?.Kind) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10310, 87355, 87486) && (object)f_10310_87447_87478(parameterType) != null))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 87351, 87664);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 87560, 87629);

                                                var
                                                discarded = f_10310_87576_87628(unboundArgument, parameterType)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 87351, 87664);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 87117, 87695);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 579);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 579);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 87823, 87880);

                                    newArguments[i] = f_10310_87841_87879(unboundArgument);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10310, 87910, 87916);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 86808, 90572);

                            case BoundKind.OutVariablePendingInference:
                            case BoundKind.DiscardExpression:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 86808, 90572);
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 88120, 88255) || true) && (f_10310_88124_88152(argument))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 88120, 88255);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10310, 88218, 88224);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 88120, 88255);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 88287, 88340);

                                    var
                                    candidateType = f_10310_88307_88339(i)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 88370, 89709) || true) && (f_10310_88374_88387(argument) == BoundKind.OutVariablePendingInference)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 88370, 89709);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 88494, 89004) || true) && ((object)candidateType == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 88494, 89004);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 88601, 88685);

                                            newArguments[i] = f_10310_88619_88684(((OutVariablePendingInference)argument), this, null);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 88494, 89004);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 88494, 89004);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 88831, 88969);

                                            newArguments[i] = f_10310_88849_88968(((OutVariablePendingInference)argument), TypeWithAnnotations.Create(candidateType), null);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 88494, 89004);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 88370, 89709);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 88370, 89709);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 89070, 89709) || true) && (f_10310_89074_89087(argument) == BoundKind.DiscardExpression)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 89070, 89709);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 89184, 89678) || true) && ((object)candidateType == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 89184, 89678);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 89291, 89370);

                                                newArguments[i] = f_10310_89309_89369(((BoundDiscardExpression)argument), this, null);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 89184, 89678);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 89184, 89678);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 89516, 89643);

                                                newArguments[i] = f_10310_89534_89642(((BoundDiscardExpression)argument), TypeWithAnnotations.Create(candidateType));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 89184, 89678);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 89070, 89709);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 88370, 89709);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10310, 89741, 89747);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 86808, 90572);

                            case BoundKind.OutDeconstructVarPendingInference:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 86808, 90572);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 89902, 89986);

                                    newArguments[i] = f_10310_89920_89985(((OutDeconstructVarPendingInference)argument), this);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10310, 90016, 90022);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 86808, 90572);

                            case BoundKind.Parameter:
                            case BoundKind.Local:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 86808, 90572);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 90196, 90251);

                                    newArguments[i] = f_10310_90214_90250(this, argument);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10310, 90281, 90287);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 86808, 90572);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 86808, 90572);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 90401, 90490);

                                    newArguments[i] = f_10310_90419_90489(this, argument, f_10310_90456_90488(i));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10310, 90520, 90526);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 86808, 90572);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 3901);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 3901);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 90603, 90631);

                f_10310_90603_90630(
                            discardedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 90645, 90686);

                return f_10310_90652_90685(newArguments);

                TypeSymbol getCorrespondingParameterType(int i)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 90702, 91813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 90854, 90886);

                        TypeSymbol
                        candidateType = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 90904, 91759);
                            foreach (var parameterList in f_10310_90934_90951_I(parameterListList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 90904, 91759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 90993, 91080);

                                var
                                parameterType = f_10310_91013_91079(analyzedArguments, i, parameterList)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 91102, 91740) || true) && ((object)parameterType != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 91102, 91740);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 91185, 91717) || true) && ((object)candidateType == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 91185, 91717);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 91276, 91306);

                                        candidateType = parameterType;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 91185, 91717);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 91185, 91717);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 91364, 91717) || true) && (!f_10310_91369_91529(candidateType, parameterType, TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 91364, 91717);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 91633, 91654);

                                            candidateType = null;
                                            DynAbs.Tracing.TraceSender.TraceBreak(10310, 91684, 91690);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 91364, 91717);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 91185, 91717);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 91102, 91740);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 90904, 91759);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 856);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 856);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 91777, 91798);

                        return candidateType;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 90702, 91813);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10310_91013_91079(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                        analyzedArguments, int
                        i, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        parameterList)
                        {
                            var return_v = GetCorrespondingParameterType(analyzedArguments, i, parameterList);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 91013, 91079);
                            return return_v;
                        }


                        bool
                        f_10310_91369_91529(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        t2, Microsoft.CodeAnalysis.TypeCompareKind
                        compareKind)
                        {
                            var return_v = this_param.Equals(t2, compareKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 91369, 91529);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                        f_10310_90934_90951_I(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 90934, 90951);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 90702, 91813);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 90702, 91813);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 86173, 91824);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10310_86396_86423()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 86396, 86423);
                    return return_v;
                }


                int
                f_10310_86458_86491(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 86458, 86491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_86551_86607(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 86551, 86607);
                    return return_v;
                }


                int
                f_10310_86622_86672(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 86622, 86672);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_86774_86789(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 86774, 86789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_86816_86829(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 86816, 86829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_87250_87316(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, int
                i, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameterList)
                {
                    var return_v = GetCorrespondingParameterType(analyzedArguments, i, parameterList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 87250, 87316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10310_87355_87374_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 87355, 87374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10310_87447_87478(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 87447, 87478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10310_87576_87628(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateType)
                {
                    var return_v = this_param.Bind((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 87576, 87628);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                f_10310_87147_87164_I(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 87147, 87164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10310_87841_87879(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.BindForErrorRecovery();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 87841, 87879);
                    return return_v;
                }


                bool
                f_10310_88124_88152(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasExpressionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 88124, 88152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_88307_88339(int
                i)
                {
                    var return_v = getCorrespondingParameterType(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 88307, 88339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_88374_88387(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 88374, 88387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_88619_88684(Microsoft.CodeAnalysis.CSharp.OutVariablePendingInference
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt)
                {
                    var return_v = this_param.FailInference(binder, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 88619, 88684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_88849_88968(Microsoft.CodeAnalysis.CSharp.OutVariablePendingInference
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt)
                {
                    var return_v = this_param.SetInferredTypeWithAnnotations(type, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 88849, 88968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_89074_89087(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 89074, 89087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                f_10310_89309_89369(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt)
                {
                    var return_v = this_param.FailInference(binder, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 89309, 89369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_89534_89642(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SetInferredTypeWithAnnotations(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 89534, 89642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                f_10310_89920_89985(Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = this_param.FailInference(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 89920, 89985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_90214_90250(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.BindToTypeForErrorRecovery(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 90214, 90250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_90456_90488(int
                i)
                {
                    var return_v = getCorrespondingParameterType(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 90456, 90488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_90419_90489(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.BindToTypeForErrorRecovery(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 90419, 90489);
                    return return_v;
                }


                int
                f_10310_90603_90630(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 90603, 90630);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_90652_90685(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 90652, 90685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 86173, 91824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 86173, 91824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeSymbol GetCorrespondingParameterType(AnalyzedArguments analyzedArguments, int i, ImmutableArray<ParameterSymbol> parameterList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10310, 92490, 93176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 92661, 92701);

                string
                name = f_10310_92675_92700(analyzedArguments, i)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 92715, 93016) || true) && (name != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 92715, 93016);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 92819, 92969);
                        foreach (var parameter in f_10310_92845_92858_I(parameterList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 92819, 92969);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 92900, 92950) || true) && (f_10310_92904_92918(parameter) == name)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 92900, 92950);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 92928, 92950);

                                return f_10310_92935_92949(parameter);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 92900, 92950);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 92819, 92969);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 151);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 151);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 92989, 93001);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 92715, 93016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 93032, 93097);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10310, 93039, 93065) || (((i < parameterList.Length) && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 93068, 93089)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 93092, 93096))) ? f_10310_93068_93089(parameterList[i]) : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10310, 92490, 93176);

                string
                f_10310_92675_92700(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.Name(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 92675, 92700);
                    return return_v;
                }


                string
                f_10310_92904_92918(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 92904, 92918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_92935_92949(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 92935, 92949);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10310_92845_92858_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 92845, 92858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_93068_93089(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 93068, 93089);
                    return return_v;
                }

                // CONSIDER: should we handle variable argument lists?
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 92490, 93176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 92490, 93176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<BoundExpression> BuildArgumentsForErrorRecovery(AnalyzedArguments analyzedArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 93351, 93604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 93483, 93593);

                return f_10310_93490_93592(this, analyzedArguments, f_10310_93540_93591());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 93351, 93604);

                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                f_10310_93540_93591()
                {
                    var return_v = Enumerable.Empty<ImmutableArray<ParameterSymbol>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 93540, 93591);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_93490_93592(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>>
                parameterListList)
                {
                    var return_v = this_param.BuildArgumentsForErrorRecovery(analyzedArguments, parameterListList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 93490, 93592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 93351, 93604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 93351, 93604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundCall CreateBadCall(
                    SyntaxNode node,
                    BoundExpression expr,
                    LookupResultKind resultKind,
                    AnalyzedArguments analyzedArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 93616, 94701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 93830, 93941);

                TypeSymbol
                returnType = f_10310_93854_93940(f_10310_93882_93898(this), string.Empty, arity: 0, errorInfo: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 93955, 94010);

                var
                methodContainer = f_10310_93977_93986(expr) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10310, 93977, 94009) ?? f_10310_93990_94009(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94024, 94111);

                MethodSymbol
                method = f_10310_94046_94110(methodContainer, returnType, string.Empty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94127, 94188);

                var
                args = f_10310_94138_94187(this, analyzedArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94202, 94246);

                var
                argNames = f_10310_94217_94245(analyzedArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94260, 94325);

                var
                argRefKinds = f_10310_94278_94324(analyzedArguments.RefKinds)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94339, 94470);

                var
                originalMethods = (DynAbs.Tracing.TraceSender.Conditional_F1(10310, 94361, 94397) || (((f_10310_94362_94371(expr) == BoundKind.MethodGroup) && DynAbs.Tracing.TraceSender.Conditional_F2(10310, 94400, 94432)) || DynAbs.Tracing.TraceSender.Conditional_F3(10310, 94435, 94469))) ? f_10310_94400_94432(((BoundMethodGroup)expr)) : ImmutableArray<MethodSymbol>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94486, 94690);

                return f_10310_94493_94689(node, expr, method, args, argNames, argRefKinds, isDelegateCall: false, invokedAsExtensionMethod: false, originalMethods: originalMethods, resultKind: resultKind, binder: this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 93616, 94701);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10310_93882_93898(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 93882, 93898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10310_93854_93940(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                name, int
                arity, Microsoft.CodeAnalysis.DiagnosticInfo?
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(compilation, name, arity: arity, errorInfo: errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 93854, 93940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_93977_93986(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 93977, 93986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10310_93990_94009(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 93990, 94009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol
                f_10310_94046_94110(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol(containingType, returnType, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 94046, 94110);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_94138_94187(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments)
                {
                    var return_v = this_param.BuildArgumentsForErrorRecovery(analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 94138, 94187);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10310_94217_94245(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    var return_v = this_param.GetNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 94217, 94245);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10310_94278_94324(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableOrNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 94278, 94324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_94362_94371(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 94362, 94371);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_94400_94432(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 94400, 94432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10310_94493_94689(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                namedArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, bool
                isDelegateCall, bool
                invokedAsExtensionMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                originalMethods, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = BoundCall.ErrorCall(node, receiverOpt, method, arguments, namedArguments, refKinds, isDelegateCall: isDelegateCall, invokedAsExtensionMethod: invokedAsExtensionMethod, originalMethods: originalMethods, resultKind: resultKind, binder: binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 94493, 94689);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 93616, 94701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 93616, 94701);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeSymbol GetCommonTypeOrReturnType<TMember>(ImmutableArray<TMember> members)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10310, 94713, 95394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94867, 94890);

                TypeSymbol
                type = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94913, 94918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94920, 94938);
                    for (int
        i = 0
        ,
        n = members.Length
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94904, 95355) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94947, 94950)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 94904, 95355))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 94904, 95355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 94984, 95046);

                        TypeSymbol
                        returnType = f_10310_95008_95040<TMember>(members[i]).Type
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 95064, 95340) || true) && ((object)type == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 95064, 95340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 95130, 95148);

                            type = returnType;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 95064, 95340);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 95064, 95340);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 95190, 95340) || true) && (!f_10310_95195_95267<TMember>(type, returnType, TypeCompareKind.ConsiderEverything2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 95190, 95340);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 95309, 95321);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 95190, 95340);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 95064, 95340);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10310, 1, 452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10310, 1, 452);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 95371, 95383);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10310, 94713, 95394);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10310_95008_95040<TMember>(TMember
                symbol) where TMember : Symbol

                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 95008, 95040);
                    return return_v;
                }


                bool
                f_10310_95195_95267<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison) where TMember : Symbol

                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 95195, 95267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 94713, 95394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 94713, 95394);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryBindNameofOperator(InvocationExpressionSyntax node, DiagnosticBag diagnostics, out BoundExpression result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 95406, 96240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 95553, 95567);

                result = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 95581, 95873) || true) && (f_10310_95585_95607(f_10310_95585_95600(node)) != SyntaxKind.IdentifierName || (DynAbs.Tracing.TraceSender.Expression_False(10310, 95585, 95752) || ((IdentifierNameSyntax)f_10310_95680_95695(node)).Identifier.ContextualKind() != SyntaxKind.NameOfKeyword) || (DynAbs.Tracing.TraceSender.Expression_False(10310, 95585, 95811) || f_10310_95773_95790(node).Arguments.Count != 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 95581, 95873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 95845, 95858);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 95581, 95873);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 95889, 95946);

                ArgumentSyntax
                argument = f_10310_95915_95942(f_10310_95915_95932(node))[0]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 95960, 96132) || true) && (f_10310_95964_95982(argument) != null || (DynAbs.Tracing.TraceSender.Expression_False(10310, 95964, 96042) || f_10310_95994_96018(argument) != default(SyntaxToken)) || (DynAbs.Tracing.TraceSender.Expression_False(10310, 95964, 96070) || f_10310_96046_96070(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 95960, 96132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 96104, 96117);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 95960, 96132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 96148, 96203);

                result = f_10310_96157_96202(this, node, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 96217, 96229);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 95406, 96240);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10310_95585_95600(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 95585, 95600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10310_95585_95607(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 95585, 95607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10310_95680_95695(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 95680, 95695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10310_95773_95790(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 95773, 95790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10310_95915_95932(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 95915, 95932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10310_95915_95942(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 95915, 95942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax?
                f_10310_95964_95982(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 95964, 95982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10310_95994_96018(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.RefOrOutKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 95994, 96018);
                    return return_v;
                }


                bool
                f_10310_96046_96070(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.InvocableNameofInScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 96046, 96070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_96157_96202(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindNameofOperatorInternal(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 96157, 96202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 95406, 96240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 95406, 96240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindNameofOperatorInternal(InvocationExpressionSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 96252, 97805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 96387, 96460);

                f_10310_96387_96459(node, MessageID.IDS_FeatureNameof, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 96474, 96531);

                var
                argument = f_10310_96489_96530(f_10310_96489_96516(f_10310_96489_96506(node))[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 96545, 96562);

                string
                name = ""
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 96711, 96763);

                var
                nameofBinder = f_10310_96730_96762(argument, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 96777, 96848);

                var
                boundArgument = f_10310_96797_96847(nameofBinder, argument, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 96862, 97540) || true) && (f_10310_96866_96893_M(!boundArgument.HasAnyErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 96866, 96958) && f_10310_96897_96958(this, argument, out name, diagnostics)) && (DynAbs.Tracing.TraceSender.Expression_True(10310, 96866, 97005) && f_10310_96962_96980(boundArgument) == BoundKind.MethodGroup))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 96862, 97540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 97039, 97089);

                    var
                    methodGroup = (BoundMethodGroup)boundArgument
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 97107, 97525) || true) && (f_10310_97111_97157_M(!methodGroup.TypeArgumentsOpt.IsDefaultOrEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 97107, 97525);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 97269, 97355);

                        f_10310_97269_97354(                    // method group with type parameters not allowed
                                            diagnostics, ErrorCode.ERR_NameofMethodGroupWithTypeParameters, f_10310_97336_97353(argument));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 97107, 97525);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 97107, 97525);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 97437, 97506);

                        f_10310_97437_97505(nameofBinder, methodGroup, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 97107, 97525);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 96862, 97540);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 97556, 97645);

                boundArgument = f_10310_97572_97644(this, boundArgument, diagnostics, reportNoTargetType: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 97659, 97794);

                return f_10310_97666_97793(node, boundArgument, f_10310_97711_97737(name), f_10310_97739_97792(f_10310_97739_97750(), SpecialType.System_String));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 96252, 97805);

                bool
                f_10310_96387_96459(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 96387, 96459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10310_96489_96506(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 96489, 96506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10310_96489_96516(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 96489, 96516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10310_96489_96530(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 96489, 96530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NameofBinder
                f_10310_96730_96762(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                nameofArgument, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.NameofBinder((Microsoft.CodeAnalysis.SyntaxNode)nameofArgument, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 96730, 96762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_96797_96847(Microsoft.CodeAnalysis.CSharp.NameofBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindExpression(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 96797, 96847);
                    return return_v;
                }


                bool
                f_10310_96866_96893_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 96866, 96893);
                    return return_v;
                }


                bool
                f_10310_96897_96958(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                argument, out string
                name, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckSyntaxForNameofArgument(argument, out name, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 96897, 96958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10310_96962_96980(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 96962, 96980);
                    return return_v;
                }


                bool
                f_10310_97111_97157_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 97111, 97157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10310_97336_97353(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 97336, 97353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10310_97269_97354(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 97269, 97354);
                    return return_v;
                }


                int
                f_10310_97437_97505(Microsoft.CodeAnalysis.CSharp.NameofBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                methodGroup, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EnsureNameofExpressionSymbols(methodGroup, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 97437, 97505);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10310_97572_97644(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                reportNoTargetType)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics, reportNoTargetType: reportNoTargetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 97572, 97644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10310_97711_97737(string
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 97711, 97737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10310_97739_97750()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 97739, 97750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10310_97739_97792(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 97739, 97792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNameOfOperator
                f_10310_97666_97793(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundNameOfOperator((Microsoft.CodeAnalysis.SyntaxNode)syntax, argument, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 97666, 97793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 96252, 97805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 96252, 97805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EnsureNameofExpressionSymbols(BoundMethodGroup methodGroup, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 97817, 98569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 98033, 98083);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 98097, 98247);

                var
                resolution = f_10310_98114_98246(this, methodGroup, analyzedArguments: null, isMethodGroupConversion: false, useSiteDiagnostics: ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 98261, 98317);

                f_10310_98261_98316(diagnostics, methodGroup.Syntax, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 98331, 98376);

                f_10310_98331_98375(diagnostics, resolution.Diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 98390, 98558) || true) && (resolution.IsExtensionMethodGroup)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 98390, 98558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 98461, 98543);

                    f_10310_98461_98542(diagnostics, ErrorCode.ERR_NameofExtensionMethod, f_10310_98514_98541(methodGroup.Syntax));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 98390, 98558);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 97817, 98569);

                Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                f_10310_98114_98246(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, bool
                isMethodGroupConversion, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ResolveMethodGroup(node, analyzedArguments: analyzedArguments, isMethodGroupConversion: isMethodGroupConversion, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 98114, 98246);
                    return return_v;
                }


                bool
                f_10310_98261_98316(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 98261, 98316);
                    return return_v;
                }


                int
                f_10310_98331_98375(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 98331, 98375);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10310_98514_98541(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 98514, 98541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10310_98461_98542(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 98461, 98542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 97817, 98569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 97817, 98569);
            }
        }

        /// <summary>
        /// Returns true if syntax form is OK (so no errors were reported)
        /// </summary>
        private bool CheckSyntaxForNameofArgument(ExpressionSyntax argument, out string name, DiagnosticBag diagnostics, bool top = true)
        {
            switch (argument.Kind())
            {
                case SyntaxKind.IdentifierName:
                    {
                        var syntax = (IdentifierNameSyntax)argument;
                        name = syntax.Identifier.ValueText;
                        return true;
                    }
                case SyntaxKind.GenericName:
                    {
                        var syntax = (GenericNameSyntax)argument;
                        name = syntax.Identifier.ValueText;
                        return true;
                    }
                case SyntaxKind.SimpleMemberAccessExpression:
                    {
                        var syntax = (MemberAccessExpressionSyntax)argument;
                        bool ok = true;
                        switch (syntax.Expression.Kind())
                        {
                            case SyntaxKind.BaseExpression:
                            case SyntaxKind.ThisExpression:
                                break;
                            default:
                                ok = CheckSyntaxForNameofArgument(syntax.Expression, out name, diagnostics, false);
                                break;
                        }
                        name = syntax.Name.Identifier.ValueText;
                        return ok;
                    }
                case SyntaxKind.AliasQualifiedName:
                    {
                        var syntax = (AliasQualifiedNameSyntax)argument;
                        bool ok = true;
                        if (top)
                        {
                            diagnostics.Add(ErrorCode.ERR_AliasQualifiedNameNotAnExpression, argument.Location);
                            ok = false;
                        }
                        name = syntax.Name.Identifier.ValueText;
                        return ok;
                    }
                case SyntaxKind.ThisExpression:
                case SyntaxKind.BaseExpression:
                case SyntaxKind.PredefinedType:
                    name = "";
                    if (top) goto default;
                    return true;
                default:
                    {
                        var code = top ? ErrorCode.ERR_ExpressionHasNoName : ErrorCode.ERR_SubexpressionNotInNameof;
                        diagnostics.Add(code, argument.Location);
                        name = "";
                        return false;
                    }
            }
        }

        private bool InvocableNameofInScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 101540, 102139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 101602, 101648);

                var
                lookupResult = f_10310_101621_101647()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 101662, 101768);

                const LookupOptions
                options = LookupOptions.AllMethodsOnArityZero | LookupOptions.MustBeInvocableIfMember
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 101782, 101832);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 101846, 102010);

                f_10310_101846_102009(this, lookupResult, f_10310_101891_101936(SyntaxKind.NameOfKeyword), useSiteDiagnostics: ref useSiteDiagnostics, arity: 0, options: options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 102026, 102066);

                var
                result = f_10310_102039_102065(lookupResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 102080, 102100);

                f_10310_102080_102099(lookupResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 102114, 102128);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 101540, 102139);

                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10310_101621_101647()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 101621, 101647);
                    return return_v;
                }


                string
                f_10310_101891_101936(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 101891, 101936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10310_101846_102009(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = this_param.LookupSymbolsWithFallback(result, name, useSiteDiagnostics: ref useSiteDiagnostics, arity: arity, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 101846, 102009);
                    return return_v;
                }


                bool
                f_10310_102039_102065(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 102039, 102065);
                    return return_v;
                }


                int
                f_10310_102080_102099(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 102080, 102099);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 101540, 102139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 101540, 102139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundFunctionPointerInvocation BindFunctionPointerInvocation(SyntaxNode node, BoundExpression boundExpression, AnalyzedArguments analyzedArguments, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10310, 102169, 105528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 102376, 102446);

                f_10310_102376_102445(f_10310_102395_102415(boundExpression) is FunctionPointerTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 102462, 102524);

                var
                funcPtr = (FunctionPointerTypeSymbol)f_10310_102503_102523(boundExpression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 102540, 102639);

                var
                overloadResolutionResult = f_10310_102571_102638()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 102653, 102704);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 102718, 102796);

                var
                methodsBuilder = f_10310_102739_102795(1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 102810, 102848);

                f_10310_102810_102847(methodsBuilder, f_10310_102829_102846(funcPtr));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 102862, 103069);

                f_10310_102862_103068(f_10310_102862_102880(), methodsBuilder, analyzedArguments, overloadResolutionResult, ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 103085, 104285) || true) && (f_10310_103089_103124_M(!overloadResolutionResult.Succeeded))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 103085, 104285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 103158, 103248);

                    ImmutableArray<FunctionPointerMethodSymbol>
                    methods = f_10310_103212_103247(methodsBuilder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 103266, 103807);

                    f_10310_103266_103806(overloadResolutionResult, binder: this, f_10310_103366_103379(node), nodeOpt: null, diagnostics, name: null, boundExpression, boundExpression.Syntax, analyzedArguments, methods, typeContainingConstructor: null, delegateTypeBeingInvoked: null, returnRefKind: f_10310_103780_103805(f_10310_103780_103797(funcPtr)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 103827, 104270);

                    return f_10310_103834_104269(node, boundExpression, f_10310_103956_104045(this, analyzedArguments, f_10310_104006_104044(methods)), f_10310_104068_104114(analyzedArguments.RefKinds), LookupResultKind.OverloadResolutionFailure, f_10310_104202_104230(f_10310_104202_104219(funcPtr)), hasErrors: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 103085, 104285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 104301, 104323);

                f_10310_104301_104322(
                            methodsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 104339, 104443);

                MemberResolutionResult<FunctionPointerMethodSymbol>
                methodResult = f_10310_104406_104442(overloadResolutionResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 104457, 104581);

                f_10310_104457_104580(this, methodResult, analyzedArguments.Arguments, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 104597, 104650);

                var
                args = f_10310_104608_104649(analyzedArguments.Arguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 104664, 104726);

                var
                refKinds = f_10310_104679_104725(analyzedArguments.RefKinds)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 104742, 104803);

                bool
                hasErrors = f_10310_104759_104802(this, node, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 104817, 105234) || true) && (!hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10310, 104817, 105234);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 104865, 105219);

                    hasErrors = !f_10310_104878_105218(node, f_10310_104952_104969(funcPtr), receiverOpt: null, f_10310_105032_105060(f_10310_105032_105049(funcPtr)), args, methodResult.Result.ArgsToParamsOpt, f_10310_105168_105183(), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10310, 104817, 105234);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 105250, 105517);

                return f_10310_105257_105516(node, boundExpression, args, refKinds, LookupResultKind.Viable, f_10310_105459_105487(f_10310_105459_105476(funcPtr)), hasErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10310, 102169, 105528);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10310_102395_102415(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 102395, 102415);
                    return return_v;
                }


                int
                f_10310_102376_102445(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 102376, 102445);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_102503_102523(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 102503, 102523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                f_10310_102571_102638()
                {
                    var return_v = OverloadResolutionResult<FunctionPointerMethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 102571, 102638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                f_10310_102739_102795(int
                capacity)
                {
                    var return_v = ArrayBuilder<FunctionPointerMethodSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 102739, 102795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10310_102829_102846(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 102829, 102846);
                    return return_v;
                }


                int
                f_10310_102810_102847(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 102810, 102847);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution
                f_10310_102862_102880()
                {
                    var return_v = OverloadResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 102862, 102880);
                    return return_v;
                }


                int
                f_10310_102862_103068(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                funcPtrBuilder, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                overloadResolutionResult, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    this_param.FunctionPointerOverloadResolution(funcPtrBuilder, analyzedArguments, overloadResolutionResult, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 102862, 103068);
                    return 0;
                }


                bool
                f_10310_103089_103124_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 103089, 103124);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                f_10310_103212_103247(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 103212, 103247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10310_103366_103379(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 103366, 103379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10310_103780_103797(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 103780, 103797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10310_103780_103805(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 103780, 103805);
                    return return_v;
                }


                int
                f_10310_103266_103806(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.SyntaxNode
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, string
                name, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.SyntaxNode
                invokedExpression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                memberGroup, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeContainingConstructor, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateTypeBeingInvoked, Microsoft.CodeAnalysis.RefKind
                returnRefKind)
                {
                    this_param.ReportDiagnostics<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>(binder: binder, location, nodeOpt: nodeOpt, diagnostics, name: name, receiver, invokedExpression, arguments, memberGroup, typeContainingConstructor: typeContainingConstructor, delegateTypeBeingInvoked: delegateTypeBeingInvoked, returnRefKind: (Microsoft.CodeAnalysis.RefKind?)returnRefKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 103266, 103806);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10310_104006_104044(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                from)
                {
                    var return_v = StaticCast<MethodSymbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 104006, 104044);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_103956_104045(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods)
                {
                    var return_v = this_param.BuildArgumentsForErrorRecovery(analyzedArguments, methods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 103956, 104045);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10310_104068_104114(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableOrNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 104068, 104114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10310_104202_104219(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 104202, 104219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_104202_104230(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 104202, 104230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                f_10310_103834_104269(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                invokedExpression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation(syntax, invokedExpression, arguments, argumentRefKindsOpt, resultKind, type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 103834, 104269);
                    return return_v;
                }


                int
                f_10310_104301_104322(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 104301, 104322);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                f_10310_104406_104442(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                this_param)
                {
                    var return_v = this_param.ValidResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 104406, 104442);
                    return return_v;
                }


                int
                f_10310_104457_104580(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                methodResult, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CoerceArguments<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>(methodResult, arguments, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 104457, 104580);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10310_104608_104649(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 104608, 104649);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10310_104679_104725(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableOrNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 104679, 104725);
                    return return_v;
                }


                bool
                f_10310_104759_104802(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportUnsafeIfNotAllowed(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 104759, 104802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10310_104952_104969(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 104952, 104969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10310_105032_105049(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 105032, 105049);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10310_105032_105060(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 105032, 105060);
                    return return_v;
                }


                uint
                f_10310_105168_105183()
                {
                    var return_v = LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 105168, 105183);
                    return return_v;
                }


                bool
                f_10310_104878_105218(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                argsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, uint
                scopeOfTheContainingExpression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckInvocationArgMixing(syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, receiverOpt: receiverOpt, parameters, argsOpt, argsToParamsOpt, scopeOfTheContainingExpression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 104878, 105218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10310_105459_105476(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 105459, 105476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10310_105459_105487(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10310, 105459, 105487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                f_10310_105257_105516(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                invokedExpression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation(syntax, invokedExpression, arguments, argumentRefKindsOpt, resultKind, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10310, 105257, 105516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10310, 102169, 105528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10310, 102169, 105528);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
