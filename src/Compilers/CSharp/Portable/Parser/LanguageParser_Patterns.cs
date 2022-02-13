// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    using Microsoft.CodeAnalysis.Syntax.InternalSyntax;
    internal partial class LanguageParser : SyntaxParser
    {
        private CSharpSyntaxNode ParseTypeOrPatternForIsOperator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 865, 1034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 948, 1023);

                return f_10035_955_1022(this, f_10035_984_1021(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 865, 1034);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10035_984_1021(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseTypeOrPatternForIsOperatorCore();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 984, 1021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10035_955_1022(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.CheckRecursivePatternFeature(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 955, 1022);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 865, 1034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 865, 1034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpSyntaxNode CheckRecursivePatternFeature(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 1046, 1610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 1147, 1599);

                switch (f_10035_1155_1164(node))
                {

                    case SyntaxKind.RecursivePattern:
                    case SyntaxKind.DiscardPattern:
                    case SyntaxKind.VarPattern when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 1325, 1418) || true) && (f_10035_1330_1371(f_10035_1330_1366(((VarPatternSyntax)node))) == SyntaxKind.ParenthesizedVariableDesignation) && (DynAbs.Tracing.TraceSender.Expression_True(10035, 1325, 1418) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 1147, 1599);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 1441, 1524);

                        return f_10035_1448_1523(this, node, MessageID.IDS_FeatureRecursivePatterns);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 1147, 1599);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 1147, 1599);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 1572, 1584);

                        return node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 1147, 1599);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 1046, 1610);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_1155_1164(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 1155, 1164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax
                f_10035_1330_1366(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VarPatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 1330, 1366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_1330_1371(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 1330, 1371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10035_1448_1523(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>(node, feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 1448, 1523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 1046, 1610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 1046, 1610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpSyntaxNode ParseTypeOrPatternForIsOperatorCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 1622, 2186);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax type = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 1709, 1798);

                var
                pattern = f_10035_1723_1797(this, f_10035_1736_1781(SyntaxKind.IsPatternExpression), afterIs: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 1812, 2175);

                return pattern switch
                {
                    ConstantPatternSyntax cp when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 1891, 1955) || true) && (f_10035_1896_1955(this, f_10035_1920_1933(cp), out type)) && (DynAbs.Tracing.TraceSender.Expression_True(10035, 1891, 1955) || true)
    => type,
                    TypePatternSyntax tp when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 1982, 2013) && DynAbs.Tracing.TraceSender.Expression_True(10035, 1982, 2013))
    => f_10035_2006_2013(tp),
                    DiscardPatternSyntax dp when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2032, 2129) && DynAbs.Tracing.TraceSender.Expression_True(10035, 2032, 2129))
    => f_10035_2059_2129(_syntaxFactory, f_10035_2089_2128(f_10035_2109_2127(dp))),
                    var p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2148, 2158) && DynAbs.Tracing.TraceSender.Expression_True(10035, 2148, 2158))
    => p,
                };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 1622, 2186);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                f_10035_1736_1781(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                op)
                {
                    var return_v = GetPrecedence(op);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 1736, 1781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_1723_1797(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence, bool
                afterIs)
                {
                    var return_v = this_param.ParsePattern(precedence, afterIs: afterIs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 1723, 1797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10035_1920_1933(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConstantPatternSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 1920, 1933);
                    return return_v;
                }


                bool
                f_10035_1896_1955(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expression, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax
                type)
                {
                    var return_v = this_param.ConvertExpressionToType(expression, out type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 1896, 1955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10035_2006_2013(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypePatternSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 2006, 2013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_2109_2127(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DiscardPatternSyntax
                this_param)
                {
                    var return_v = this_param.UnderscoreToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 2109, 2127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_2089_2128(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = ConvertToIdentifier(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 2089, 2128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                f_10035_2059_2129(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier)
                {
                    var return_v = this_param.IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 2059, 2129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 1622, 2186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 1622, 2186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ConvertExpressionToType(ExpressionSyntax expression, out NameSyntax type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 2198, 3035);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax leftType = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2309, 2321);

                type = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2335, 3023);

                switch (expression)
                {

                    case SimpleNameSyntax s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 2335, 3023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2433, 2442);

                        type = s;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2464, 2476);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 2335, 3023);

                    case MemberAccessExpressionSyntax { Expression: var expr, OperatorToken: { Kind: SyntaxKind.DotToken } dotToken, Name: var simpleName }
                                        when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2655, 2707) || true) && (f_10035_2660_2707(this, expr, out leftType)) && (DynAbs.Tracing.TraceSender.Expression_True(10035, 2655, 2707) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 2335, 3023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2730, 2798);

                        type = f_10035_2737_2797(_syntaxFactory, leftType, dotToken, simpleName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2820, 2832);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 2335, 3023);

                    case AliasQualifiedNameSyntax a:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 2335, 3023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2904, 2913);

                        type = a;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2935, 2947);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 2335, 3023);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 2335, 3023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 2995, 3008);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 2335, 3023);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 3023, 3024);
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 2198, 3035);

                bool
                f_10035_2660_2707(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expression, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax
                type)
                {
                    var return_v = this_param.ConvertExpressionToType(expression, out type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 2660, 2707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.QualifiedNameSyntax
                f_10035_2737_2797(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax
                left, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                dotToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SimpleNameSyntax
                right)
                {
                    var return_v = this_param.QualifiedName(left, dotToken, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 2737, 2797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 2198, 3035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 2198, 3035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PatternSyntax ParsePattern(Precedence precedence, bool afterIs = false, bool whenIsKeyword = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 3045, 3255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 3177, 3244);

                return f_10035_3184_3243(this, precedence, afterIs, whenIsKeyword);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 3045, 3255);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_3184_3243(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence, bool
                afterIs, bool
                whenIsKeyword)
                {
                    var return_v = this_param.ParseDisjunctivePattern(precedence, afterIs, whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 3184, 3243);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 3045, 3255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 3045, 3255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PatternSyntax ParseDisjunctivePattern(Precedence precedence, bool afterIs, bool whenIsKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 3267, 3976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 3394, 3477);

                PatternSyntax
                result = f_10035_3417_3476(this, precedence, afterIs, whenIsKeyword)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 3491, 3935) || true) && (f_10035_3498_3530(f_10035_3498_3515(this)) == SyntaxKind.OrKeyword)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 3491, 3935);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 3588, 3636);

                        var
                        orToken = f_10035_3602_3635(f_10035_3619_3634(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 3654, 3726);

                        var
                        right = f_10035_3666_3725(this, precedence, afterIs, whenIsKeyword)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 3744, 3828);

                        result = f_10035_3753_3827(_syntaxFactory, SyntaxKind.OrPattern, result, orToken, right);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 3846, 3920);

                        result = f_10035_3855_3919(this, result, MessageID.IDS_FeatureOrPattern);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 3491, 3935);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10035, 3491, 3935);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10035, 3491, 3935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 3951, 3965);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 3267, 3976);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_3417_3476(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence, bool
                afterIs, bool
                whenIsKeyword)
                {
                    var return_v = this_param.ParseConjunctivePattern(precedence, afterIs, whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 3417, 3476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_3498_3515(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 3498, 3515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_3498_3530(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 3498, 3530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_3619_3634(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 3619, 3634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_3602_3635(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = ConvertToKeyword(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 3602, 3635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_3666_3725(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence, bool
                afterIs, bool
                whenIsKeyword)
                {
                    var return_v = this_param.ParseConjunctivePattern(precedence, afterIs, whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 3666, 3725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryPatternSyntax
                f_10035_3753_3827(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                left, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                right)
                {
                    var return_v = this_param.BinaryPattern(kind, left, operatorToken, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 3753, 3827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_3855_3919(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax>(node, feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 3855, 3919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 3267, 3976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 3267, 3976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LooksLikeTypeOfPattern()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 4132, 4990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 4194, 4221);

                var
                tk = f_10035_4203_4220(f_10035_4203_4215())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 4235, 4332) || true) && (f_10035_4239_4271(tk))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 4235, 4332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 4305, 4317);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 4235, 4332);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 4348, 4649) || true) && (tk == SyntaxKind.IdentifierToken && (DynAbs.Tracing.TraceSender.Expression_True(10035, 4352, 4450) && f_10035_4388_4420(f_10035_4388_4405(this)) != SyntaxKind.UnderscoreToken) && (DynAbs.Tracing.TraceSender.Expression_True(10035, 4352, 4588) && (f_10035_4472_4504(f_10035_4472_4489(this)) != SyntaxKind.NameOfKeyword || (DynAbs.Tracing.TraceSender.Expression_False(10035, 4472, 4587) || f_10035_4536_4558(f_10035_4536_4553(this, 1)) != SyntaxKind.OpenParenToken))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 4348, 4649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 4622, 4634);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 4348, 4649);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 4665, 4755) || true) && (f_10035_4669_4694(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 4665, 4755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 4728, 4740);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 4665, 4755);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 4861, 4950) || true) && (f_10035_4865_4889(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 4861, 4950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 4923, 4935);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 4861, 4950);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 4966, 4979);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 4132, 4990);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_4203_4215()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 4203, 4215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_4203_4220(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 4203, 4220);
                    return return_v;
                }


                bool
                f_10035_4239_4271(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsPredefinedType(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 4239, 4271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_4388_4405(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 4388, 4405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_4388_4420(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 4388, 4420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_4472_4489(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 4472, 4489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_4472_4504(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 4472, 4504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_4536_4553(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, int
                n)
                {
                    var return_v = this_param.PeekToken(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 4536, 4553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_4536_4558(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 4536, 4558);
                    return return_v;
                }


                bool
                f_10035_4669_4694(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.LooksLikeTupleArrayType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 4669, 4694);
                    return return_v;
                }


                bool
                f_10035_4865_4889(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.IsFunctionPointerStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 4865, 4889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 4132, 4990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 4132, 4990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PatternSyntax ParseConjunctivePattern(Precedence precedence, bool afterIs, bool whenIsKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 5002, 5706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 5129, 5208);

                PatternSyntax
                result = f_10035_5152_5207(this, precedence, afterIs, whenIsKeyword)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 5222, 5665) || true) && (f_10035_5229_5261(f_10035_5229_5246(this)) == SyntaxKind.AndKeyword)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 5222, 5665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 5320, 5368);

                        var
                        orToken = f_10035_5334_5367(f_10035_5351_5366(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 5386, 5454);

                        var
                        right = f_10035_5398_5453(this, precedence, afterIs, whenIsKeyword)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 5472, 5557);

                        result = f_10035_5481_5556(_syntaxFactory, SyntaxKind.AndPattern, result, orToken, right);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 5575, 5650);

                        result = f_10035_5584_5649(this, result, MessageID.IDS_FeatureAndPattern);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 5222, 5665);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10035, 5222, 5665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10035, 5222, 5665);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 5681, 5695);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 5002, 5706);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_5152_5207(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence, bool
                afterIs, bool
                whenIsKeyword)
                {
                    var return_v = this_param.ParseNegatedPattern(precedence, afterIs, whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 5152, 5207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_5229_5246(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 5229, 5246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_5229_5261(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 5229, 5261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_5351_5366(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 5351, 5366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_5334_5367(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = ConvertToKeyword(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 5334, 5367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_5398_5453(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence, bool
                afterIs, bool
                whenIsKeyword)
                {
                    var return_v = this_param.ParseNegatedPattern(precedence, afterIs, whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 5398, 5453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryPatternSyntax
                f_10035_5481_5556(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                left, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                right)
                {
                    var return_v = this_param.BinaryPattern(kind, left, operatorToken, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 5481, 5556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_5584_5649(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax>(node, feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 5584, 5649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 5002, 5706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 5002, 5706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanDesignation(bool permitTuple)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 5718, 7144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 5789, 7133);

                switch (f_10035_5797_5819(f_10035_5797_5814(this)))
                {

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 5789, 7133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 5883, 5896);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 5789, 7133);

                    case SyntaxKind.IdentifierToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 5789, 7133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 5968, 6006);

                        bool
                        result = f_10035_5982_6005(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6028, 6044);

                        f_10035_6028_6043(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6066, 6080);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 5789, 7133);

                    case SyntaxKind.OpenParenToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 5789, 7133);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6151, 6253) || true) && (!permitTuple)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 6151, 6253);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6217, 6230);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 6151, 6253);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6277, 6299);

                        bool
                        sawComma = false
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6321, 7118) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 6321, 7118);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6382, 6398);

                                f_10035_6382_6397(this);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6450, 6587) || true) && (!f_10035_6455_6489(this, permitTuple: true))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 6450, 6587);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6547, 6560);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 6450, 6587);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6613, 7095);

                                switch (f_10035_6621_6643(f_10035_6621_6638(this)))
                                {

                                    case SyntaxKind.CloseParenToken:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 6613, 7095);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6767, 6783);

                                        f_10035_6767_6782(this);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6817, 6833);

                                        return sawComma;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 6613, 7095);

                                    case SyntaxKind.CommaToken:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 6613, 7095);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6924, 6940);

                                        sawComma = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 6974, 6983);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 6613, 7095);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 6613, 7095);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 7055, 7068);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 6613, 7095);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 6321, 7118);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10035, 6321, 7118);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10035, 6321, 7118);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 5789, 7133);
                        break;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 5718, 7144);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_5797_5814(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 5797, 5814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_5797_5819(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 5797, 5819);
                    return return_v;
                }


                bool
                f_10035_5982_6005(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.IsTrueIdentifier();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 5982, 6005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_6028_6043(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 6028, 6043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_6382_6397(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 6382, 6397);
                    return return_v;
                }


                bool
                f_10035_6455_6489(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, bool
                permitTuple)
                {
                    var return_v = this_param.ScanDesignation(permitTuple: permitTuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 6455, 6489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_6621_6638(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 6621, 6638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_6621_6643(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 6621, 6643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_6767_6782(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 6767, 6782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 5718, 7144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 5718, 7144);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PatternSyntax ParseNegatedPattern(Precedence precedence, bool afterIs, bool whenIsKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 7156, 7835);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 7279, 7824) || true) && (f_10035_7283_7315(f_10035_7283_7300(this)) == SyntaxKind.NotKeyword)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 7279, 7824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 7374, 7423);

                    var
                    notToken = f_10035_7389_7422(f_10035_7406_7421(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 7441, 7511);

                    var
                    pattern = f_10035_7455_7510(this, precedence, afterIs, whenIsKeyword)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 7529, 7589);

                    var
                    result = f_10035_7542_7588(_syntaxFactory, notToken, pattern)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 7607, 7680);

                    return f_10035_7614_7679(this, result, MessageID.IDS_FeatureNotPattern);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 7279, 7824);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 7279, 7824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 7746, 7809);

                    return f_10035_7753_7808(this, precedence, afterIs, whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 7279, 7824);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 7156, 7835);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_7283_7300(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 7283, 7300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_7283_7315(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 7283, 7315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_7406_7421(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 7406, 7421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_7389_7422(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = ConvertToKeyword(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 7389, 7422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_7455_7510(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence, bool
                afterIs, bool
                whenIsKeyword)
                {
                    var return_v = this_param.ParseNegatedPattern(precedence, afterIs, whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 7455, 7510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.UnaryPatternSyntax
                f_10035_7542_7588(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                pattern)
                {
                    var return_v = this_param.UnaryPattern(operatorToken, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 7542, 7588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.UnaryPatternSyntax
                f_10035_7614_7679(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.UnaryPatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.UnaryPatternSyntax>(node, feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 7614, 7679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_7753_7808(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence, bool
                afterIs, bool
                whenIsKeyword)
                {
                    var return_v = this_param.ParsePrimaryPattern(precedence, afterIs, whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 7753, 7808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 7156, 7835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 7156, 7835);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PatternSyntax ParsePrimaryPattern(Precedence precedence, bool afterIs, bool whenIsKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 7847, 10714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 8040, 8072);

                var
                tk = f_10035_8049_8071(f_10035_8049_8066(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 8086, 8546);

                switch (tk)
                {

                    case SyntaxKind.CommaToken:
                    case SyntaxKind.SemicolonToken:
                    case SyntaxKind.CloseBraceToken:
                    case SyntaxKind.CloseParenToken:
                    case SyntaxKind.CloseBracketToken:
                    case SyntaxKind.EqualsGreaterThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 8086, 8546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 8437, 8531);

                        return f_10035_8444_8530(_syntaxFactory, f_10035_8475_8529(this, ErrorCode.ERR_MissingPattern));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 8086, 8546);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 8562, 8762) || true) && (f_10035_8566_8593(f_10035_8566_8578()) == SyntaxKind.UnderscoreToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 8562, 8762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 8657, 8747);

                    return f_10035_8664_8746(_syntaxFactory, f_10035_8694_8745(this, SyntaxKind.UnderscoreToken));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 8562, 8762);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 8778, 9618);

                switch (f_10035_8786_8803(f_10035_8786_8798()))
                {

                    case SyntaxKind.LessThanToken:
                    case SyntaxKind.LessThanEqualsToken:
                    case SyntaxKind.GreaterThanToken:
                    case SyntaxKind.GreaterThanEqualsToken:
                    case SyntaxKind.EqualsEqualsToken:
                    case SyntaxKind.ExclamationEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 8778, 9618);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 9214, 9252);

                        var
                        relationalToken = f_10035_9236_9251(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 9274, 9318);

                        f_10035_9274_9317(precedence < Precedence.Shift);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 9340, 9404);

                        var
                        expression = f_10035_9357_9403(this, Precedence.Relational)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 9426, 9501);

                        var
                        result = f_10035_9439_9500(_syntaxFactory, relationalToken, expression)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 9523, 9603);

                        return f_10035_9530_9602(this, result, MessageID.IDS_FeatureRelationalPattern);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 8778, 9618);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 9634, 9672);

                var
                resetPoint = f_10035_9651_9671(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 9722, 9745);

                    TypeSyntax
                    type = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 9763, 10258) || true) && (f_10035_9767_9791(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 9763, 10258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 9833, 9920);

                        type = f_10035_9840_9919(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10035, 9855, 9862) || ((afterIs && DynAbs.Tracing.TraceSender.Conditional_F2(10035, 9865, 9886)) || DynAbs.Tracing.TraceSender.Conditional_F3(10035, 9889, 9918))) ? ParseTypeMode.AfterIs : ParseTypeMode.DefinitePattern);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 9942, 10239) || true) && (f_10035_9946_9960(type) || (DynAbs.Tracing.TraceSender.Expression_False(10035, 9946, 10004) || !f_10035_9965_10004(this, precedence)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 9942, 10239);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 10151, 10178);

                            f_10035_10151_10177(                        // either it is not shaped like a type, or it is a constant expression.
                                                    this, ref resetPoint);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 10204, 10216);

                            type = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 9942, 10239);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 9763, 10258);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 10278, 10351);

                    PatternSyntax
                    p = f_10035_10296_10350(this, type, precedence, whenIsKeyword)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 10369, 10414) || true) && (p != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 10369, 10414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 10405, 10414);

                        return p;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 10369, 10414);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 10434, 10461);

                    f_10035_10434_10460(
                                    this, ref resetPoint);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 10479, 10527);

                    var
                    value = f_10035_10491_10526(this, precedence)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 10545, 10590);

                    return f_10035_10552_10589(_syntaxFactory, value);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10035, 10619, 10703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 10659, 10688);

                    f_10035_10659_10687(this, ref resetPoint);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10035, 10619, 10703);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 7847, 10714);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_8049_8066(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 8049, 8066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_8049_8071(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 8049, 8071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                f_10035_8475_8529(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.ParseIdentifierName(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 8475, 8529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConstantPatternSyntax
                f_10035_8444_8530(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                expression)
                {
                    var return_v = this_param.ConstantPattern((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 8444, 8530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_8566_8578()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 8566, 8578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_8566_8593(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 8566, 8593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_8694_8745(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 8694, 8745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DiscardPatternSyntax
                f_10035_8664_8746(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                underscoreToken)
                {
                    var return_v = this_param.DiscardPattern(underscoreToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 8664, 8746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_8786_8798()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 8786, 8798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_8786_8803(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 8786, 8803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_9236_9251(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 9236, 9251);
                    return return_v;
                }


                int
                f_10035_9274_9317(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 9274, 9317);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10035_9357_9403(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence)
                {
                    var return_v = this_param.ParseSubExpression(precedence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 9357, 9403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.RelationalPatternSyntax
                f_10035_9439_9500(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.RelationalPattern(operatorToken, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 9439, 9500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.RelationalPatternSyntax
                f_10035_9530_9602(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.RelationalPatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.RelationalPatternSyntax>(node, feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 9530, 9602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                f_10035_9651_9671(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.GetResetPoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 9651, 9671);
                    return return_v;
                }


                bool
                f_10035_9767_9791(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.LooksLikeTypeOfPattern();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 9767, 9791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10035_9840_9919(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ParseTypeMode
                mode)
                {
                    var return_v = this_param.ParseType(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 9840, 9919);
                    return return_v;
                }


                bool
                f_10035_9946_9960(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 9946, 9960);
                    return return_v;
                }


                bool
                f_10035_9965_10004(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence)
                {
                    var return_v = this_param.CanTokenFollowTypeInPattern(precedence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 9965, 10004);
                    return return_v;
                }


                int
                f_10035_10151_10177(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                state)
                {
                    this_param.Reset(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 10151, 10177);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_10296_10350(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax?
                type, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence, bool
                whenIsKeyword)
                {
                    var return_v = this_param.ParsePatternContinued(type, precedence, whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 10296, 10350);
                    return return_v;
                }


                int
                f_10035_10434_10460(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                state)
                {
                    this_param.Reset(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 10434, 10460);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10035_10491_10526(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence)
                {
                    var return_v = this_param.ParseSubExpression(precedence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 10491, 10526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConstantPatternSyntax
                f_10035_10552_10589(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.ConstantPattern(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 10552, 10589);
                    return return_v;
                }


                int
                f_10035_10659_10687(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                state)
                {
                    this_param.Release(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 10659, 10687);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 7847, 10714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 7847, 10714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool CanTokenFollowTypeInPattern(Precedence precedence)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 10856, 11962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 10936, 11951);

                switch (f_10035_10944_10966(f_10035_10944_10961(this)))
                {

                    case SyntaxKind.OpenParenToken:
                    case SyntaxKind.OpenBraceToken:
                    case SyntaxKind.IdentifierToken:
                    case SyntaxKind.CloseBraceToken:   // for efficiency, test some tokens that can follow a type pattern
                    case SyntaxKind.CloseBracketToken:
                    case SyntaxKind.CloseParenToken:
                    case SyntaxKind.CommaToken:
                    case SyntaxKind.SemicolonToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 10936, 11951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 11467, 11479);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 10936, 11951);

                    case SyntaxKind.DotToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 10936, 11951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 11611, 11624);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 10936, 11951);

                    case var kind:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 10936, 11951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 11780, 11936);

                        return !f_10035_11788_11837(kind) || (DynAbs.Tracing.TraceSender.Expression_False(10035, 11787, 11935) || f_10035_11869_11921(f_10035_11883_11920(kind)) <= precedence);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 10936, 11951);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 10856, 11962);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_10944_10961(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 10944, 10961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_10944_10966(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 10944, 10966);
                    return return_v;
                }


                bool
                f_10035_11788_11837(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = SyntaxFacts.IsBinaryExpressionOperatorToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 11788, 11837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_11883_11920(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = SyntaxFacts.GetBinaryExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 11883, 11920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                f_10035_11869_11921(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                op)
                {
                    var return_v = GetPrecedence(op);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 11869, 11921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 10856, 11962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 10856, 11962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PatternSyntax ParsePatternContinued(TypeSyntax type, Precedence precedence, bool whenIsKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 11974, 18122);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken openParenToken = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken);
                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax> subPatterns = default(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax>);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken closeParenToken = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyPatternClauseSyntax propertyPatternClause0 = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyPatternClauseSyntax);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax designation0 = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyPatternClauseSyntax propertyPatternClause = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyPatternClauseSyntax);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax designation = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax expression = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 12102, 12923) || true) && (f_10035_12106_12116_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(type, 10035, 12106, 12116)?.Kind) == SyntaxKind.IdentifierName)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 12102, 12923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 12179, 12227);

                    var
                    typeIdentifier = (IdentifierNameSyntax)type
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 12245, 12297);

                    var
                    typeIdentifierToken = f_10035_12271_12296(typeIdentifier)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 12315, 12908) || true) && (f_10035_12319_12353(typeIdentifierToken) == SyntaxKind.VarKeyword && (DynAbs.Tracing.TraceSender.Expression_True(10035, 12319, 12505) && (f_10035_12404_12426(f_10035_12404_12421(this)) == SyntaxKind.OpenParenToken || (DynAbs.Tracing.TraceSender.Expression_False(10035, 12404, 12504) || f_10035_12459_12504(this, whenIsKeyword)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 12315, 12908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 12677, 12730);

                        var
                        varToken = f_10035_12692_12729(typeIdentifierToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 12752, 12808);

                        var
                        varDesignation = f_10035_12773_12807(this, forPattern: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 12830, 12889);

                        return f_10035_12837_12888(_syntaxFactory, varToken, varDesignation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 12315, 12908);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 12102, 12923);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 12939, 15536) || true) && (f_10035_12943_12965(f_10035_12943_12960(this)) == SyntaxKind.OpenParenToken && (DynAbs.Tracing.TraceSender.Expression_True(10035, 12943, 13032) && (type != null || (DynAbs.Tracing.TraceSender.Expression_False(10035, 12999, 13031) || !f_10035_13016_13031()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 12939, 15536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 13188, 13546);

                    f_10035_13188_13545(this, openToken: out openParenToken, subPatterns: out subPatterns, closeToken: out closeParenToken, openKind: SyntaxKind.OpenParenToken, closeKind: SyntaxKind.CloseParenToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 13566, 13649);

                    f_10035_13566_13648(out propertyPatternClause0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 13667, 13743);

                    f_10035_13667_13742(whenIsKeyword, out designation0);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 13763, 15222) || true) && (type == null && (DynAbs.Tracing.TraceSender.Expression_True(10035, 13767, 13834) && propertyPatternClause0 == null) && (DynAbs.Tracing.TraceSender.Expression_True(10035, 13767, 13879) && designation0 == null) && (DynAbs.Tracing.TraceSender.Expression_True(10035, 13767, 13926) && subPatterns.Count == 1) && (DynAbs.Tracing.TraceSender.Expression_True(10035, 13767, 13982) && subPatterns.SeparatorCount == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10035, 13767, 14039) && f_10035_14007_14031(subPatterns[0]) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 13763, 15222);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 14081, 14121);

                        var
                        subpattern = f_10035_14098_14120(subPatterns[0])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 14143, 15203);

                        switch (subpattern)
                        {

                            case ConstantPatternSyntax cp:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 14143, 15203);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 14580, 14697);

                                // LAFHIS
                                ExpressionSyntax
                                expressionX = f_10035_14610_14696(_syntaxFactory, openParenToken, f_10035_14665_14678(cp), closeParenToken)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 14727, 14789);

                                expressionX = f_10035_14740_14788(this, expressionX, precedence);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 14819, 14869);

                                return f_10035_14826_14868(_syntaxFactory, expressionX);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 14143, 15203);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 14143, 15203);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 14933, 15053);

                                var
                                parenthesizedPattern = f_10035_14960_15052(_syntaxFactory, openParenToken, f_10035_15012_15034(subPatterns[0]), closeParenToken)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 15083, 15180);

                                return f_10035_15090_15179(this, parenthesizedPattern, MessageID.IDS_FeatureParenthesizedPattern);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 14143, 15203);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 13763, 15222);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 15242, 15357);

                    var
                    positionalPatternClause = f_10035_15272_15356(_syntaxFactory, openParenToken, subPatterns, closeParenToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 15375, 15489);

                    var
                    result = f_10035_15388_15488(_syntaxFactory, type, positionalPatternClause, propertyPatternClause0, designation0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 15507, 15521);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 12939, 15536);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 15552, 15893) || true) && (f_10035_15556_15637(out propertyPatternClause))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 15552, 15893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 15671, 15747);

                    f_10035_15671_15746(whenIsKeyword, out designation0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 15765, 15878);

                    return f_10035_15772_15877(_syntaxFactory, type, positionalPatternClause: null, propertyPatternClause, designation0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 15552, 15893);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 15909, 16785) || true) && (type != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 15909, 16785);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 15959, 16770) || true) && (f_10035_15963_16037(whenIsKeyword, out designation))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 15959, 16770);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 16079, 16139);

                        return f_10035_16086_16138(_syntaxFactory, type, designation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 15959, 16770);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 15959, 16770);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 16311, 16575) || true) && (f_10035_16315_16364(this, type, out expression))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 16311, 16575);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 16414, 16476);

                            expression = f_10035_16427_16475(this, expression, precedence);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 16502, 16552);

                            return f_10035_16509_16551(_syntaxFactory, expression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 16311, 16575);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 16599, 16650);

                        var
                        typePattern = f_10035_16617_16649(_syntaxFactory, type)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 16672, 16751);

                        return f_10035_16679_16750(this, typePattern, MessageID.IDS_FeatureTypePattern);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 15959, 16770);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 15909, 16785);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 16867, 16879);

                return null;

                bool parsePropertyPatternClause(out PropertyPatternClauseSyntax propertyPatternClauseResult)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 16895, 17330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17020, 17055);

                        propertyPatternClauseResult = null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17073, 17282) || true) && (f_10035_17077_17099(f_10035_17077_17094(this)) == SyntaxKind.OpenBraceToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 17073, 17282);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17170, 17229);

                            propertyPatternClauseResult = f_10035_17200_17228(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17251, 17263);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 17073, 17282);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17302, 17315);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 16895, 17330);

                        Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                        f_10035_17077_17094(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                        this_param)
                        {
                            var return_v = this_param.CurrentToken;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 17077, 17094);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_10035_17077_17099(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 17077, 17099);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyPatternClauseSyntax
                        f_10035_17200_17228(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                        this_param)
                        {
                            var return_v = this_param.ParsePropertyPatternClause();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 17200, 17228);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 16895, 17330);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 16895, 17330);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool parseDesignation(bool whenIsKeywordB, out VariableDesignationSyntax designationResult)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 17369, 17801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17493, 17518);

                        designationResult = null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17536, 17753) || true) && (f_10035_17540_17563(this) && (DynAbs.Tracing.TraceSender.Expression_True(10035, 17540, 17613) && f_10035_17567_17613(this, whenIsKeywordB)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 17536, 17753);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17655, 17700);

                            designationResult = f_10035_17675_17699(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17722, 17734);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 17536, 17753);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17773, 17786);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 17369, 17801);

                        bool
                        f_10035_17540_17563(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                        this_param)
                        {
                            var return_v = this_param.IsTrueIdentifier();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 17540, 17563);
                            return return_v;
                        }


                        bool
                        f_10035_17567_17613(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                        this_param, bool
                        whenIsKeyword)
                        {
                            var return_v = this_param.IsValidPatternDesignation(whenIsKeyword);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 17567, 17613);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax
                        f_10035_17675_17699(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                        this_param)
                        {
                            var return_v = this_param.ParseSimpleDesignation();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 17675, 17699);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 17369, 17801);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 17369, 17801);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool looksLikeCast()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 17817, 18111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17870, 17908);

                        var
                        resetPoint = f_10035_17887_17907(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17926, 17972);

                        bool
                        result = f_10035_17940_17971(this, forPattern: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 17990, 18017);

                        f_10035_17990_18016(this, ref resetPoint);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 18035, 18064);

                        f_10035_18035_18063(this, ref resetPoint);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 18082, 18096);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 17817, 18111);

                        Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                        f_10035_17887_17907(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                        this_param)
                        {
                            var return_v = this_param.GetResetPoint();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 17887, 17907);
                            return return_v;
                        }


                        bool
                        f_10035_17940_17971(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                        this_param, bool
                        forPattern)
                        {
                            var return_v = this_param.ScanCast(forPattern: forPattern);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 17940, 17971);
                            return return_v;
                        }


                        int
                        f_10035_17990_18016(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                        this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                        state)
                        {
                            this_param.Reset(ref state);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 17990, 18016);
                            return 0;
                        }


                        int
                        f_10035_18035_18063(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                        this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                        state)
                        {
                            this_param.Release(ref state);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 18035, 18063);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 17817, 18111);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 17817, 18111);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 11974, 18122);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10035_12106_12116_M(Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 12106, 12116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_12271_12296(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 12271, 12296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_12319_12353(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 12319, 12353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_12404_12421(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 12404, 12421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_12404_12426(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 12404, 12426);
                    return return_v;
                }


                bool
                f_10035_12459_12504(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, bool
                whenIsKeyword)
                {
                    var return_v = this_param.IsValidPatternDesignation(whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 12459, 12504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_12692_12729(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = ConvertToKeyword(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 12692, 12729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax
                f_10035_12773_12807(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, bool
                forPattern)
                {
                    var return_v = this_param.ParseDesignation(forPattern: forPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 12773, 12807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VarPatternSyntax
                f_10035_12837_12888(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                varKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax
                designation)
                {
                    var return_v = this_param.VarPattern(varKeyword, designation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 12837, 12888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_12943_12960(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 12943, 12960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_12943_12965(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 12943, 12965);
                    return return_v;
                }


                bool
                f_10035_13016_13031()
                {
                    var return_v = looksLikeCast();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 13016, 13031);
                    return return_v;
                }


                int
                f_10035_13188_13545(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                openToken, out Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax>
                subPatterns, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                closeToken, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                openKind, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                closeKind)
                {
                    this_param.ParseSubpatternList(out openToken, out subPatterns, out closeToken, openKind: openKind, closeKind: closeKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 13188, 13545);
                    return 0;
                }


                bool
                f_10035_13566_13648(out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyPatternClauseSyntax
                propertyPatternClauseResult)
                {
                    var return_v = parsePropertyPatternClause(out propertyPatternClauseResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 13566, 13648);
                    return return_v;
                }


                bool
                f_10035_13667_13742(bool
                whenIsKeywordB, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax
                designationResult)
                {
                    var return_v = parseDesignation(whenIsKeywordB, out designationResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 13667, 13742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameColonSyntax?
                f_10035_14007_14031(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax?
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 14007, 14031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_14098_14120(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax?
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 14098, 14120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10035_14665_14678(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConstantPatternSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 14665, 14678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParenthesizedExpressionSyntax
                f_10035_14610_14696(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                closeParenToken)
                {
                    var return_v = this_param.ParenthesizedExpression(openParenToken, expression, closeParenToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 14610, 14696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10035_14740_14788(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                leftOperand, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence)
                {
                    var return_v = this_param.ParseExpressionContinued(leftOperand, precedence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 14740, 14788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConstantPatternSyntax
                f_10035_14826_14868(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.ConstantPattern(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 14826, 14868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_15012_15034(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax?
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 15012, 15034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParenthesizedPatternSyntax
                f_10035_14960_15052(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                pattern, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                closeParenToken)
                {
                    var return_v = this_param.ParenthesizedPattern(openParenToken, pattern, closeParenToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 14960, 15052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParenthesizedPatternSyntax
                f_10035_15090_15179(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParenthesizedPatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParenthesizedPatternSyntax>(node, feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 15090, 15179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PositionalPatternClauseSyntax
                f_10035_15272_15356(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                openParenToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax>
                subpatterns, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                closeParenToken)
                {
                    var return_v = this_param.PositionalPatternClause(openParenToken, subpatterns, closeParenToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 15272, 15356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.RecursivePatternSyntax
                f_10035_15388_15488(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax?
                type, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PositionalPatternClauseSyntax
                positionalPatternClause, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyPatternClauseSyntax?
                propertyPatternClause, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax?
                designation)
                {
                    var return_v = this_param.RecursivePattern(type, positionalPatternClause, propertyPatternClause, designation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 15388, 15488);
                    return return_v;
                }


                bool
                f_10035_15556_15637(out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyPatternClauseSyntax
                propertyPatternClauseResult)
                {
                    var return_v = parsePropertyPatternClause(out propertyPatternClauseResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 15556, 15637);
                    return return_v;
                }


                bool
                f_10035_15671_15746(bool
                whenIsKeywordB, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax
                designationResult)
                {
                    var return_v = parseDesignation(whenIsKeywordB, out designationResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 15671, 15746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.RecursivePatternSyntax
                f_10035_15772_15877(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax?
                type, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PositionalPatternClauseSyntax?
                positionalPatternClause, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyPatternClauseSyntax
                propertyPatternClause, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax
                designation)
                {
                    var return_v = this_param.RecursivePattern(type, positionalPatternClause: positionalPatternClause, propertyPatternClause, designation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 15772, 15877);
                    return return_v;
                }


                bool
                f_10035_15963_16037(bool
                whenIsKeywordB, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax
                designationResult)
                {
                    var return_v = parseDesignation(whenIsKeywordB, out designationResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 15963, 16037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DeclarationPatternSyntax
                f_10035_16086_16138(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDesignationSyntax
                designation)
                {
                    var return_v = this_param.DeclarationPattern(type, designation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 16086, 16138);
                    return return_v;
                }


                bool
                f_10035_16315_16364(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                type, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.ConvertTypeToExpression(type, out expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 16315, 16364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10035_16427_16475(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                leftOperand, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence)
                {
                    var return_v = this_param.ParseExpressionContinued(leftOperand, precedence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 16427, 16475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConstantPatternSyntax
                f_10035_16509_16551(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.ConstantPattern(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 16509, 16551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypePatternSyntax
                f_10035_16617_16649(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                type)
                {
                    var return_v = this_param.TypePattern(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 16617, 16649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypePatternSyntax
                f_10035_16679_16750(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypePatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypePatternSyntax>(node, feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 16679, 16750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 11974, 18122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 11974, 18122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsValidPatternDesignation(bool whenIsKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 18134, 20663);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 18217, 20623) || true) && (f_10035_18221_18238(f_10035_18221_18233()) == SyntaxKind.IdentifierToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 18217, 20623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 18302, 20608);

                    switch (f_10035_18310_18337(f_10035_18310_18322()))
                    {

                        case SyntaxKind.WhenKeyword:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 18302, 20608);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 18433, 18455);

                            return !whenIsKeyword;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 18302, 20608);

                        case SyntaxKind.AndKeyword:
                        case SyntaxKind.OrKeyword:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 18302, 20608);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 18578, 18605);

                            var
                            tk = f_10035_18587_18604(f_10035_18587_18599(this, 1))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 18631, 20425);

                            switch (tk)
                            {

                                case SyntaxKind.CloseBraceToken:
                                case SyntaxKind.CloseBracketToken:
                                case SyntaxKind.CloseParenToken:
                                case SyntaxKind.CommaToken:
                                case SyntaxKind.SemicolonToken:
                                case SyntaxKind.QuestionToken:
                                case SyntaxKind.ColonToken:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 18631, 20425);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 19126, 19138);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 18631, 20425);

                                case SyntaxKind.LessThanEqualsToken:
                                case SyntaxKind.LessThanToken:
                                case SyntaxKind.GreaterThanEqualsToken:
                                case SyntaxKind.GreaterThanToken:
                                case SyntaxKind.IdentifierToken:
                                case SyntaxKind.OpenBraceToken:
                                case SyntaxKind.OpenParenToken:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 18631, 20425);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 19680, 19693);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 18631, 20425);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 18631, 20425);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 19765, 19817) || true) && (f_10035_19769_19803(tk))
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 19765, 19817);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 19805, 19817);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 19765, 19817);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 20065, 20103);

                                    var
                                    resetPoint = f_10035_20082_20102(this)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 20137, 20157);

                                    _ = f_10035_20141_20156(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 20191, 20226);

                                    var
                                    result = !f_10035_20205_20225(this)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 20260, 20287);

                                    f_10035_20260_20286(this, ref resetPoint);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 20321, 20350);

                                    f_10035_20321_20349(this, ref resetPoint);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 20384, 20398);

                                    return result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 18631, 20425);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 18302, 20608);

                        case SyntaxKind.UnderscoreToken: // discard is a valid pattern designation
                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 18302, 20608);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 20577, 20589);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 18302, 20608);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 18217, 20623);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 20639, 20652);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 18134, 20663);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_18221_18233()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 18221, 18233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_18221_18238(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 18221, 18238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_18310_18322()
                {
                    var return_v = CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 18310, 18322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_18310_18337(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 18310, 18337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_18587_18599(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, int
                n)
                {
                    var return_v = this_param.PeekToken(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 18587, 18599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_18587_18604(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 18587, 18604);
                    return return_v;
                }


                bool
                f_10035_19769_19803(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = SyntaxFacts.IsBinaryExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 19769, 19803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                f_10035_20082_20102(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.GetResetPoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 20082, 20102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_20141_20156(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 20141, 20156);
                    return return_v;
                }


                bool
                f_10035_20205_20225(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CanStartExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 20205, 20225);
                    return return_v;
                }


                int
                f_10035_20260_20286(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                state)
                {
                    this_param.Reset(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 20260, 20286);
                    return 0;
                }


                int
                f_10035_20321_20349(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                state)
                {
                    this_param.Release(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 20321, 20349);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 18134, 20663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 18134, 20663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpSyntaxNode ParseExpressionOrPatternForSwitchStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 20675, 20866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 20769, 20855);

                return f_10035_20776_20854(this, f_10035_20805_20853(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 20675, 20866);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10035_20805_20853(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseExpressionOrPatternForSwitchStatementCore();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 20805, 20853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10035_20776_20854(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.CheckRecursivePatternFeature(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 20776, 20854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 20675, 20866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 20675, 20866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpSyntaxNode ParseExpressionOrPatternForSwitchStatementCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 20878, 21442);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax expr = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 20976, 21048);

                var
                pattern = f_10035_20990_21047(this, Precedence.Conditional, whenIsKeyword: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 21062, 21431);

                return pattern switch
                {
                    ConstantPatternSyntax cp when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 21116, 21157) && DynAbs.Tracing.TraceSender.Expression_True(10035, 21116, 21157))
    => f_10035_21144_21157(cp),
                    TypePatternSyntax tp when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 21197, 21261) || true) && (f_10035_21202_21261(this, f_10035_21226_21233(tp), out expr)) && (DynAbs.Tracing.TraceSender.Expression_True(10035, 21197, 21261) || true)
    => expr,
                    DiscardPatternSyntax dp when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 21288, 21385) && DynAbs.Tracing.TraceSender.Expression_True(10035, 21288, 21385))
    => f_10035_21315_21385(_syntaxFactory, f_10035_21345_21384(f_10035_21365_21383(dp))),
                    var p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 21404, 21414) && DynAbs.Tracing.TraceSender.Expression_True(10035, 21404, 21414))
    => p,
                };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 20878, 21442);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_20990_21047(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence, bool
                whenIsKeyword)
                {
                    var return_v = this_param.ParsePattern(precedence, whenIsKeyword: whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 20990, 21047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10035_21144_21157(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConstantPatternSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 21144, 21157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10035_21226_21233(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypePatternSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 21226, 21233);
                    return return_v;
                }


                bool
                f_10035_21202_21261(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                type, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.ConvertTypeToExpression(type, out expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 21202, 21261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_21365_21383(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DiscardPatternSyntax
                this_param)
                {
                    var return_v = this_param.UnderscoreToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 21365, 21383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_21345_21384(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = ConvertToIdentifier(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 21345, 21384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                f_10035_21315_21385(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier)
                {
                    var return_v = this_param.IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 21315, 21385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 20878, 21442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 20878, 21442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ConvertTypeToExpression(TypeSyntax type, out ExpressionSyntax expr, bool permitTypeArguments = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 21454, 22454);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax leftExpr = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 21593, 21605);

                expr = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 21619, 22443);

                switch (type)
                {

                    case GenericNameSyntax g:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 21619, 22443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 21712, 21721);

                        expr = g;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 21743, 21770);

                        return permitTypeArguments;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 21619, 22443);

                    case SimpleNameSyntax s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 21619, 22443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 21834, 21843);

                        expr = s;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 21865, 21877);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 21619, 22443);

                    case QualifiedNameSyntax { Left: var left, dotToken: var dotToken, Right: var right }
                                            when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 22010, 22069) || true) && ((permitTypeArguments || (DynAbs.Tracing.TraceSender.Expression_False(10035, 22016, 22068) || !(right is GenericNameSyntax)))) && (DynAbs.Tracing.TraceSender.Expression_True(10035, 22010, 22069) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 21619, 22443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 22092, 22199);

                        var
                        newLeft = (DynAbs.Tracing.TraceSender.Conditional_F1(10035, 22106, 22180) || ((f_10035_22106_22180(this, left, out leftExpr, permitTypeArguments: true) && DynAbs.Tracing.TraceSender.Conditional_F2(10035, 22183, 22191)) || DynAbs.Tracing.TraceSender.Conditional_F3(10035, 22194, 22198))) ? leftExpr : left
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 22221, 22333);

                        expr = f_10035_22228_22332(_syntaxFactory, SyntaxKind.SimpleMemberAccessExpression, newLeft, dotToken, right);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 22355, 22367);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 21619, 22443);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 21619, 22443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 22415, 22428);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 21619, 22443);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 21454, 22454);

                bool
                f_10035_22106_22180(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax
                type, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr, bool
                permitTypeArguments)
                {
                    var return_v = this_param.ConvertTypeToExpression((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax)type, out expr, permitTypeArguments: permitTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 22106, 22180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberAccessExpressionSyntax
                f_10035_22228_22332(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SimpleNameSyntax
                name)
                {
                    var return_v = this_param.MemberAccessExpression(kind, expression, operatorToken, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 22228, 22332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 21454, 22454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 21454, 22454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LooksLikeTupleArrayType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 22466, 22980);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 22529, 22646) || true) && (f_10035_22533_22555(f_10035_22533_22550(this)) != SyntaxKind.OpenParenToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 22529, 22646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 22618, 22631);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 22529, 22646);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 22662, 22702);

                ResetPoint
                resetPoint = f_10035_22686_22701(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 22752, 22811);

                    return f_10035_22759_22785(this, forPattern: true) != ScanTypeFlags.NotType;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10035, 22840, 22969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 22880, 22907);

                    f_10035_22880_22906(this, ref resetPoint);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 22925, 22954);

                    f_10035_22925_22953(this, ref resetPoint);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10035, 22840, 22969);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 22466, 22980);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_22533_22550(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 22533, 22550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_22533_22555(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 22533, 22555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                f_10035_22686_22701(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.GetResetPoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 22686, 22701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ScanTypeFlags
                f_10035_22759_22785(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, bool
                forPattern)
                {
                    var return_v = this_param.ScanType(forPattern: forPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 22759, 22785);
                    return return_v;
                }


                int
                f_10035_22880_22906(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                state)
                {
                    this_param.Reset(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 22880, 22906);
                    return 0;
                }


                int
                f_10035_22925_22953(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.ResetPoint
                state)
                {
                    this_param.Release(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 22925, 22953);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 22466, 22980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 22466, 22980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PropertyPatternClauseSyntax ParsePropertyPatternClause()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 22992, 23534);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken openBraceToken = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken);
                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax> subPatterns = default(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax>);
                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken closeBraceToken = default(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 23081, 23419);

                f_10035_23081_23418(this, openToken: out openBraceToken, subPatterns: out subPatterns, closeToken: out closeBraceToken, openKind: SyntaxKind.OpenBraceToken, closeKind: SyntaxKind.CloseBraceToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 23433, 23523);

                return f_10035_23440_23522(_syntaxFactory, openBraceToken, subPatterns, closeBraceToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 22992, 23534);

                int
                f_10035_23081_23418(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                openToken, out Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax>
                subPatterns, out Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                closeToken, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                openKind, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                closeKind)
                {
                    this_param.ParseSubpatternList(out openToken, out subPatterns, out closeToken, openKind: openKind, closeKind: closeKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 23081, 23418);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyPatternClauseSyntax
                f_10035_23440_23522(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                openBraceToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax>
                subpatterns, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                closeBraceToken)
                {
                    var return_v = this_param.PropertyPatternClause(openBraceToken, subpatterns, closeBraceToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 23440, 23522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 22992, 23534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 22992, 23534);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ParseSubpatternList(
            out SyntaxToken openToken,
            out SeparatedSyntaxList<SubpatternSyntax> subPatterns,
            out SyntaxToken closeToken,
            SyntaxKind openKind,
            SyntaxKind closeKind)
        {
            Debug.Assert(openKind == SyntaxKind.OpenParenToken || openKind == SyntaxKind.OpenBraceToken);
            Debug.Assert(closeKind == SyntaxKind.CloseParenToken || closeKind == SyntaxKind.CloseBraceToken);
            Debug.Assert((openKind == SyntaxKind.OpenParenToken) == (closeKind == SyntaxKind.CloseParenToken));
            Debug.Assert(openKind == this.CurrentToken.Kind);

            openToken = this.EatToken(openKind);
            var list = _pool.AllocateSeparated<SubpatternSyntax>();
            try
            {
tryAgain:

                if (this.IsPossibleSubpatternElement() || this.CurrentToken.Kind == SyntaxKind.CommaToken)
                {
                    // first pattern
                    list.Add(this.ParseSubpatternElement());

                    // additional patterns
                    int lastTokenPosition = -1;
                    while (IsMakingProgress(ref lastTokenPosition))
                    {
                        if (this.CurrentToken.Kind == SyntaxKind.CloseParenToken ||
                            this.CurrentToken.Kind == SyntaxKind.CloseBraceToken ||
                            this.CurrentToken.Kind == SyntaxKind.SemicolonToken)
                        {
                            break;
                        }
                        else if (this.CurrentToken.Kind == SyntaxKind.CommaToken || this.IsPossibleSubpatternElement())
                        {
                            list.AddSeparator(this.EatToken(SyntaxKind.CommaToken));
                            if (this.CurrentToken.Kind == SyntaxKind.CloseBraceToken)
                            {
                                break;
                            }
                            list.Add(this.ParseSubpatternElement());
                            continue;
                        }
                        else if (this.SkipBadPatternListTokens(ref openToken, list, SyntaxKind.CommaToken, closeKind) == PostSkipAction.Abort)
                        {
                            break;
                        }
                    }
                }
                else if (this.SkipBadPatternListTokens(ref openToken, list, SyntaxKind.IdentifierToken, closeKind) == PostSkipAction.Continue)
                {
                    goto tryAgain;
                }

                closeToken = this.EatToken(closeKind);
                subPatterns = list.ToList();
            }
            finally
            {
                _pool.Free(list);
            }
        }

        private SubpatternSyntax ParseSubpatternElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 26405, 27005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 26479, 26512);

                NameColonSyntax
                nameColon = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 26526, 26855) || true) && (f_10035_26530_26552(f_10035_26530_26547(this)) == SyntaxKind.IdentifierToken && (DynAbs.Tracing.TraceSender.Expression_True(10035, 26530, 26633) && f_10035_26586_26608(f_10035_26586_26603(this, 1)) == SyntaxKind.ColonToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 26526, 26855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 26667, 26705);

                    var
                    name = f_10035_26678_26704(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 26723, 26772);

                    var
                    colon = f_10035_26735_26771(this, SyntaxKind.ColonToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 26790, 26840);

                    nameColon = f_10035_26802_26839(_syntaxFactory, name, colon);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 26526, 26855);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 26871, 26922);

                var
                pattern = f_10035_26885_26921(this, Precedence.Conditional)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 26936, 26994);

                return f_10035_26943_26993(this._syntaxFactory, nameColon, pattern);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 26405, 27005);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_26530_26547(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 26530, 26547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_26530_26552(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 26530, 26552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_26586_26603(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, int
                n)
                {
                    var return_v = this_param.PeekToken(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 26586, 26603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_26586_26608(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 26586, 26608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                f_10035_26678_26704(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseIdentifierName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 26678, 26704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_26735_26771(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 26735, 26771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameColonSyntax
                f_10035_26802_26839(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                name, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                colonToken)
                {
                    var return_v = this_param.NameColon(name, colonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 26802, 26839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_26885_26921(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence)
                {
                    var return_v = this_param.ParsePattern(precedence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 26885, 26921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax
                f_10035_26943_26993(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameColonSyntax?
                nameColon, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                pattern)
                {
                    var return_v = this_param.Subpattern(nameColon, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 26943, 26993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 26405, 27005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 26405, 27005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsPossibleSubpatternElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 27336, 27927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 27403, 27916);

                return f_10035_27410_27501(this, allowBinaryExpressions: false, allowAssignmentExpressions: false) || (DynAbs.Tracing.TraceSender.Expression_False(10035, 27410, 27915) || f_10035_27522_27544(f_10035_27522_27539(this)) switch
                {
                    SyntaxKind.OpenBraceToken when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 27592, 27625) && DynAbs.Tracing.TraceSender.Expression_True(10035, 27592, 27625))
=> true,
                    SyntaxKind.LessThanToken when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 27648, 27680) && DynAbs.Tracing.TraceSender.Expression_True(10035, 27648, 27680))
=> true,
                    SyntaxKind.LessThanEqualsToken when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 27703, 27741) && DynAbs.Tracing.TraceSender.Expression_True(10035, 27703, 27741))
=> true,
                    SyntaxKind.GreaterThanToken when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 27764, 27799) && DynAbs.Tracing.TraceSender.Expression_True(10035, 27764, 27799))
=> true,
                    SyntaxKind.GreaterThanEqualsToken when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 27822, 27863) && DynAbs.Tracing.TraceSender.Expression_True(10035, 27822, 27863))
=> true,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 27886, 27896) && DynAbs.Tracing.TraceSender.Expression_True(10035, 27886, 27896))
=> false
                });
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 27336, 27927);

                bool
                f_10035_27410_27501(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, bool
                allowBinaryExpressions, bool
                allowAssignmentExpressions)
                {
                    var return_v = this_param.IsPossibleExpression(allowBinaryExpressions: allowBinaryExpressions, allowAssignmentExpressions: allowAssignmentExpressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 27410, 27501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_27522_27539(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 27522, 27539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_27522_27544(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 27522, 27544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 27336, 27927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 27336, 27927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PostSkipAction SkipBadPatternListTokens(
                    ref SyntaxToken open,
                    SeparatedSyntaxListBuilder<SubpatternSyntax> list,
                    SyntaxKind expected,
                    SyntaxKind closeKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 27939, 28521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 28180, 28510);

                return f_10035_28187_28509(this, ref open, list, p => p.CurrentToken.Kind != SyntaxKind.CommaToken && !p.IsPossibleSubpatternElement(), p => p.CurrentToken.Kind == closeKind || p.CurrentToken.Kind == SyntaxKind.SemicolonToken || p.IsTerminator(), expected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 27939, 28521);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.PostSkipAction
                f_10035_28187_28509(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                startToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax>
                list, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser, bool>
                isNotExpectedFunction, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser, bool>
                abortFunction, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected)
                {
                    var return_v = this_param.SkipBadSeparatedListTokensWithExpectedKind<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SubpatternSyntax>(ref startToken, list, isNotExpectedFunction, abortFunction, expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 28187, 28509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 27939, 28521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 27939, 28521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ExpressionSyntax ParseSwitchExpression(ExpressionSyntax governingExpression, SyntaxToken switchKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 28533, 29408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 28956, 29013);

                var
                openBrace = f_10035_28972_29012(this, SyntaxKind.OpenBraceToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 29027, 29071);

                var
                arms = f_10035_29038_29070(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 29085, 29144);

                var
                closeBrace = f_10035_29102_29143(this, SyntaxKind.CloseBraceToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 29158, 29268);

                var
                result = f_10035_29171_29267(_syntaxFactory, governingExpression, switchKeyword, openBrace, arms, closeBrace)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 29282, 29369);

                result = f_10035_29291_29368(this, result, MessageID.IDS_FeatureRecursivePatterns);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 29383, 29397);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 28533, 29408);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_28972_29012(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 28972, 29012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionArmSyntax>
                f_10035_29038_29070(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseSwitchExpressionArms();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 29038, 29070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_29102_29143(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 29102, 29143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionSyntax
                f_10035_29171_29267(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                governingExpression, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                switchKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                openBraceToken, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionArmSyntax>
                arms, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                closeBraceToken)
                {
                    var return_v = this_param.SwitchExpression(governingExpression, switchKeyword, openBraceToken, arms, closeBraceToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 29171, 29267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionSyntax
                f_10035_29291_29368(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionSyntax>(node, feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 29291, 29368);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 28533, 29408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 28533, 29408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SeparatedSyntaxList<SwitchExpressionArmSyntax> ParseSwitchExpressionArms()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10035, 29420, 31336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 29527, 29591);

                var
                arms = f_10035_29538_29590(_pool)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 29607, 31189) || true) && (f_10035_29614_29636(f_10035_29614_29631(this)) != SyntaxKind.CloseBraceToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 29607, 31189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 30141, 30212);

                        var
                        pattern = f_10035_30155_30211(this, Precedence.Coalescing, whenIsKeyword: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 30230, 30286);

                        var
                        whenClause = f_10035_30247_30285(this, Precedence.Coalescing)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 30304, 30365);

                        var
                        arrow = f_10035_30316_30364(this, SyntaxKind.EqualsGreaterThanToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 30383, 30422);

                        var
                        expression = f_10035_30400_30421(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 30440, 30542);

                        var
                        switchExpressionCase = f_10035_30467_30541(_syntaxFactory, pattern, whenClause, arrow, expression)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 30618, 30733) || true) && (f_10035_30622_30648(switchExpressionCase) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10035, 30622, 30704) && f_10035_30657_30679(f_10035_30657_30674(this)) != SyntaxKind.CommaToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 30618, 30733);
                            DynAbs.Tracing.TraceSender.TraceBreak(10035, 30727, 30733);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 30618, 30733);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 30753, 30784);

                        arms.Add(switchExpressionCase);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 30802, 31174) || true) && (f_10035_30806_30828(f_10035_30806_30823(this)) != SyntaxKind.CloseBraceToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10035, 30802, 31174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 30900, 31103);

                            var
                            commaToken = (DynAbs.Tracing.TraceSender.Conditional_F1(10035, 30917, 30968) || ((f_10035_30917_30939(f_10035_30917_30934(this)) == SyntaxKind.SemicolonToken
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10035, 30996, 31038)) || DynAbs.Tracing.TraceSender.Conditional_F3(10035, 31066, 31102))) ? f_10035_30996_31038(this, SyntaxKind.CommaToken) : f_10035_31066_31102(this, SyntaxKind.CommaToken)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 31125, 31155);

                            arms.AddSeparator(commaToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 30802, 31174);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10035, 29607, 31189);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10035, 29607, 31189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10035, 29607, 31189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 31205, 31266);

                SeparatedSyntaxList<SwitchExpressionArmSyntax>
                result = arms
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 31280, 31297);

                f_10035_31280_31296(_pool, arms);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10035, 31311, 31325);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10035, 29420, 31336);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionArmSyntax>
                f_10035_29538_29590(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.AllocateSeparated<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionArmSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 29538, 29590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_29614_29631(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 29614, 29631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_29614_29636(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 29614, 29636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                f_10035_30155_30211(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence, bool
                whenIsKeyword)
                {
                    var return_v = this_param.ParsePattern(precedence, whenIsKeyword: whenIsKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 30155, 30211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.WhenClauseSyntax
                f_10035_30247_30285(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser.Precedence
                precedence)
                {
                    var return_v = this_param.ParseWhenClause(precedence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 30247, 30285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_30316_30364(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 30316, 30364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10035_30400_30421(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseExpressionCore();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 30400, 30421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionArmSyntax
                f_10035_30467_30541(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PatternSyntax
                pattern, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.WhenClauseSyntax
                whenClause, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                equalsGreaterThanToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.SwitchExpressionArm(pattern, whenClause, equalsGreaterThanToken, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 30467, 30541);
                    return return_v;
                }


                int
                f_10035_30622_30648(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 30622, 30648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_30657_30674(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 30657, 30674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_30657_30679(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 30657, 30679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_30806_30823(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 30806, 30823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_30806_30828(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 30806, 30828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_30917_30934(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 30917, 30934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10035_30917_30939(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10035, 30917, 30939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_30996_31038(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected)
                {
                    var return_v = this_param.EatTokenAsKind(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 30996, 31038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10035_31066_31102(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 31066, 31102);
                    return return_v;
                }


                int
                f_10035_31280_31296(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionArmSyntax>
                item)
                {
                    this_param.Free<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SwitchExpressionArmSyntax>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10035, 31280, 31296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10035, 29420, 31336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10035, 29420, 31336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
