// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class EarlyWellKnownAttributeBinder : Binder
    {
        internal EarlyWellKnownAttributeBinder(Binder enclosing)
        : base(f_10331_981_990_C(enclosing), enclosing.Flags | BinderFlags.EarlyAttributeBinding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10331, 904, 1066);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10331, 904, 1066);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10331, 904, 1066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10331, 904, 1066);
            }
        }

        internal CSharpAttributeData GetAttribute(AttributeSyntax node, NamedTypeSymbol boundAttributeType, out bool generatedDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10331, 1078, 1554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 1233, 1286);

                var
                dummyDiagnosticBag = f_10331_1258_1285()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 1300, 1385);

                var
                boundAttribute = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetAttribute(node, boundAttributeType, dummyDiagnosticBag), 10331, 1321, 1384)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 1399, 1467);

                generatedDiagnostics = f_10331_1422_1466_M(!dummyDiagnosticBag.IsEmptyWithoutResolution);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 1481, 1507);

                f_10331_1481_1506(dummyDiagnosticBag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 1521, 1543);

                return boundAttribute;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10331, 1078, 1554);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10331_1258_1285()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10331, 1258, 1285);
                    return return_v;
                }


                bool
                f_10331_1422_1466_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10331, 1422, 1466);
                    return return_v;
                }


                int
                f_10331_1481_1506(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10331, 1481, 1506);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10331, 1078, 1554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10331, 1078, 1554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("EarlyWellKnownAttributeBinder has a better overload - GetAttribute(AttributeSyntax, NamedTypeSymbol, out bool)", true)]
        internal new CSharpAttributeData GetAttribute(AttributeSyntax node, NamedTypeSymbol boundAttributeType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10331, 1734, 2241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 2029, 2078);

                f_10331_2029_2077(false, "Don't call this overload.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 2092, 2152);

                f_10331_2092_2151(diagnostics, ErrorCode.ERR_InternalError, f_10331_2137_2150(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 2166, 2230);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetAttribute(node, boundAttributeType, diagnostics), 10331, 2173, 2229);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10331, 1734, 2241);

                int
                f_10331_2029_2077(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10331, 2029, 2077);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10331_2137_2150(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10331, 2137, 2150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10331_2092_2151(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10331, 2092, 2151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10331, 1734, 2241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10331, 1734, 2241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CanBeValidAttributeArgument(ExpressionSyntax node, Binder typeBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10331, 2452, 6830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 2567, 2594);

                f_10331_2567_2593(node != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 2608, 6819);

                switch (f_10331_2616_2627(node))
                {

                    case SyntaxKind.ObjectCreationExpression:
                    case SyntaxKind.ImplicitObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10331, 2608, 6819);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 2966, 3028);

                            var
                            objectCreation = (BaseObjectCreationExpressionSyntax)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 3054, 3156);

                            return f_10331_3061_3087(objectCreation) == null && (DynAbs.Tracing.TraceSender.Expression_True(10331, 3061, 3155) && (f_10331_3100_3144_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10331_3100_3127(objectCreation), 10331, 3100, 3144)?.Arguments.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10331, 3100, 3149) ?? 0)) == 0);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10331, 2608, 6819);

                    case SyntaxKind.SizeOfExpression:

                    // typeof(int)
                    case SyntaxKind.TypeOfExpression:

                    // constant expressions

                    // SPEC:    Section 7.19: Only the following constructs are permitted in constant expressions:

                    //  Literals (including the null literal).
                    case SyntaxKind.NumericLiteralExpression:
                    case SyntaxKind.StringLiteralExpression:
                    case SyntaxKind.CharacterLiteralExpression:
                    case SyntaxKind.TrueLiteralExpression:
                    case SyntaxKind.FalseLiteralExpression:
                    case SyntaxKind.NullLiteralExpression:

                    //  References to const members of class and struct types.
                    //  References to members of enumeration types.
                    case SyntaxKind.IdentifierName:
                    case SyntaxKind.GenericName:
                    case SyntaxKind.AliasQualifiedName:
                    case SyntaxKind.QualifiedName:
                    case SyntaxKind.PredefinedType:
                    case SyntaxKind.SimpleMemberAccessExpression:

                    //  References to const parameters or local variables. Not valid for attribute arguments, so skipped here.

                    //  Parenthesized sub-expressions, which are themselves constant expressions.
                    case SyntaxKind.ParenthesizedExpression:

                    //  Cast expressions, provided the target type is one of the types listed above.
                    case SyntaxKind.CastExpression:

                    //  checked and unchecked expressions
                    case SyntaxKind.UncheckedExpression:
                    case SyntaxKind.CheckedExpression:

                    //  Default value expressions
                    case SyntaxKind.DefaultExpression:

                    //  The predefined +, –, !, and ~ unary operators.
                    case SyntaxKind.UnaryPlusExpression:
                    case SyntaxKind.UnaryMinusExpression:
                    case SyntaxKind.LogicalNotExpression:
                    case SyntaxKind.BitwiseNotExpression:

                    //  The predefined +, –, *, /, %, <<, >>, &, |, ^, &&, ||, ==, !=, <, >, <=, and >= binary operators, provided each operand is of a type listed above.
                    case SyntaxKind.AddExpression:
                    case SyntaxKind.MultiplyExpression:
                    case SyntaxKind.SubtractExpression:
                    case SyntaxKind.DivideExpression:
                    case SyntaxKind.ModuloExpression:
                    case SyntaxKind.LeftShiftExpression:
                    case SyntaxKind.RightShiftExpression:
                    case SyntaxKind.BitwiseAndExpression:
                    case SyntaxKind.BitwiseOrExpression:
                    case SyntaxKind.ExclusiveOrExpression:
                    case SyntaxKind.LogicalAndExpression:
                    case SyntaxKind.LogicalOrExpression:
                    case SyntaxKind.EqualsExpression:
                    case SyntaxKind.NotEqualsExpression:
                    case SyntaxKind.GreaterThanExpression:
                    case SyntaxKind.LessThanExpression:
                    case SyntaxKind.GreaterThanOrEqualExpression:
                    case SyntaxKind.LessThanOrEqualExpression:
                    case SyntaxKind.InvocationExpression: //  To support nameof(); anything else will be a compile-time error
                    case SyntaxKind.ConditionalExpression: //  The ?: conditional operator.
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10331, 2608, 6819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 6729, 6741);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10331, 2608, 6819);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10331, 2608, 6819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10331, 6791, 6804);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10331, 2608, 6819);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10331, 2452, 6830);

                int
                f_10331_2567_2593(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10331, 2567, 2593);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10331_2616_2627(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10331, 2616, 2627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax?
                f_10331_3061_3087(Microsoft.CodeAnalysis.CSharp.Syntax.BaseObjectCreationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10331, 3061, 3087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax?
                f_10331_3100_3127(Microsoft.CodeAnalysis.CSharp.Syntax.BaseObjectCreationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10331, 3100, 3127);
                    return return_v;
                }


                int?
                f_10331_3100_3144_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10331, 3100, 3144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10331, 2452, 6830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10331, 2452, 6830);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EarlyWellKnownAttributeBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10331, 827, 6837);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10331, 827, 6837);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10331, 827, 6837);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10331, 827, 6837);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10331_981_990_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10331, 904, 1066);
            return return_v;
        }

    }
}
