// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;
using static Microsoft.CodeAnalysis.CSharp.SyntaxKind;

namespace Microsoft.CodeAnalysis.CSharp
{
    public static partial class SyntaxFacts
    {
        public static bool IsAliasQualifier(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 733, 919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 810, 858);

                var
                p = f_10032_818_829(node) as AliasQualifiedNameSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 872, 908);

                return p != null && (DynAbs.Tracing.TraceSender.Expression_True(10032, 879, 907) && f_10032_892_899(p) == node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 733, 919);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_818_829(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 818, 829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10032_892_899(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 892, 899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 733, 919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 733, 919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAttributeName(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 931, 1696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1007, 1032);

                var
                parent = f_10032_1020_1031(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1046, 1150) || true) && (parent == null || (DynAbs.Tracing.TraceSender.Expression_False(10032, 1050, 1088) || !f_10032_1069_1088(f_10032_1076_1087(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 1046, 1150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1122, 1135);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 1046, 1150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1166, 1581);

                switch (f_10032_1174_1187(parent))
                {

                    case QualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 1166, 1581);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1262, 1299);

                        var
                        qn = (QualifiedNameSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1321, 1379);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10032, 1328, 1344) || ((f_10032_1328_1336(qn) == node && DynAbs.Tracing.TraceSender.Conditional_F2(10032, 1347, 1370)) || DynAbs.Tracing.TraceSender.Conditional_F3(10032, 1373, 1378))) ? f_10032_1347_1370(parent) : false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 1166, 1581);

                    case AliasQualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 1166, 1581);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1445, 1487);

                        var
                        an = (AliasQualifiedNameSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1509, 1566);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10032, 1516, 1531) || ((f_10032_1516_1523(an) == node && DynAbs.Tracing.TraceSender.Conditional_F2(10032, 1534, 1557)) || DynAbs.Tracing.TraceSender.Conditional_F3(10032, 1560, 1565))) ? f_10032_1534_1557(parent) : false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 1166, 1581);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1597, 1636);

                var
                p = f_10032_1605_1616(node) as AttributeSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1650, 1685);

                return p != null && (DynAbs.Tracing.TraceSender.Expression_True(10032, 1657, 1684) && f_10032_1670_1676(p) == node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 931, 1696);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_1020_1031(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 1020, 1031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10032_1076_1087(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 1076, 1087);
                    return return_v;
                }


                bool
                f_10032_1069_1088(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsName(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 1069, 1088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10032_1174_1187(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 1174, 1187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10032_1328_1336(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 1328, 1336);
                    return return_v;
                }


                bool
                f_10032_1347_1370(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = IsAttributeName(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 1347, 1370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10032_1516_1523(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 1516, 1523);
                    return return_v;
                }


                bool
                f_10032_1534_1557(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = IsAttributeName(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 1534, 1557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_1605_1616(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 1605, 1616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10032_1670_1676(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 1670, 1676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 931, 1696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 931, 1696);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsInvoked(ExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 1836, 2117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1912, 1981);

                node = (ExpressionSyntax)f_10032_1937_1980(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 1995, 2047);

                var
                inv = f_10032_2005_2016(node) as InvocationExpressionSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 2061, 2106);

                return inv != null && (DynAbs.Tracing.TraceSender.Expression_True(10032, 2068, 2105) && f_10032_2083_2097(inv) == node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 1836, 2117);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10032_1937_1980(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = SyntaxFactory.GetStandaloneExpression(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 1937, 1980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10032_2005_2016(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 2005, 2016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10032_2083_2097(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 2083, 2097);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 1836, 2117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 1836, 2117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIndexed(ExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 2261, 2557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 2337, 2406);

                node = (ExpressionSyntax)f_10032_2362_2405(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 2420, 2479);

                var
                indexer = f_10032_2434_2445(node) as ElementAccessExpressionSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 2493, 2546);

                return indexer != null && (DynAbs.Tracing.TraceSender.Expression_True(10032, 2500, 2545) && f_10032_2519_2537(indexer) == node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 2261, 2557);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10032_2362_2405(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = SyntaxFactory.GetStandaloneExpression(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 2362, 2405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10032_2434_2445(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 2434, 2445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10032_2519_2537(Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 2519, 2537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 2261, 2557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 2261, 2557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNamespaceAliasQualifier(ExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 2569, 2785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 2661, 2714);

                var
                parent = f_10032_2674_2685(node) as AliasQualifiedNameSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 2728, 2774);

                return parent != null && (DynAbs.Tracing.TraceSender.Expression_True(10032, 2735, 2773) && f_10032_2753_2765(parent) == node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 2569, 2785);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10032_2674_2685(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 2674, 2685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10032_2753_2765(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 2753, 2765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 2569, 2785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 2569, 2785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsInTypeOnlyContext(ExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 3008, 9095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 3094, 3145);

                node = f_10032_3101_3144(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 3159, 3184);

                var
                parent = f_10032_3172_3183(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 3198, 9055) || true) && (parent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3198, 9055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 3250, 9040);

                    switch (f_10032_3258_3271(parent))
                    {

                        case Attribute:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 3354, 3400);

                            return f_10032_3361_3391(((AttributeSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case ArrayType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 3465, 3518);

                            return f_10032_3472_3509(((ArrayTypeSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case PointerType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 3585, 3640);

                            return f_10032_3592_3631(((PointerTypeSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case FunctionPointerType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 3820, 3857);

                            throw f_10032_3826_3856();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case PredefinedType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 3927, 3939);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case NullableType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 4007, 4063);

                            return f_10032_4014_4054(((NullableTypeSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case TypeArgumentList:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 4211, 4223);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case CastExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 4293, 4344);

                            return f_10032_4300_4335(((CastExpressionSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case ObjectCreationExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 4424, 4485);

                            return f_10032_4431_4476(((ObjectCreationExpressionSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case StackAllocArrayCreationExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 4574, 4644);

                            return f_10032_4581_4635(((StackAllocArrayCreationExpressionSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case FromClause:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 4710, 4757);

                            return f_10032_4717_4748(((FromClauseSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case JoinClause:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 4823, 4870);

                            return f_10032_4830_4861(((JoinClauseSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case VariableDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 4945, 5001);

                            return f_10032_4952_4992(((VariableDeclarationSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case ForEachStatement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 5073, 5126);

                            return f_10032_5080_5117(((ForEachStatementSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case CatchDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 5198, 5251);

                            return f_10032_5205_5242(((CatchDeclarationSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case AsExpression:
                        case IsExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 5359, 5413);

                            return f_10032_5366_5404(((BinaryExpressionSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case TypeOfExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 5485, 5538);

                            return f_10032_5492_5529(((TypeOfExpressionSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case SizeOfExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 5610, 5663);

                            return f_10032_5617_5654(((SizeOfExpressionSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case DefaultExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 5736, 5790);

                            return f_10032_5743_5781(((DefaultExpressionSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case RefValueExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 5864, 5919);

                            return f_10032_5871_5910(((RefValueExpressionSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case RefType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 5982, 6026);

                            return f_10032_5989_6017(((RefTypeSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case Parameter:
                        case FunctionPointerParameter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 6143, 6193);

                            return f_10032_6150_6184(((BaseParameterSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case TypeConstraint:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 6263, 6314);

                            return f_10032_6270_6305(((TypeConstraintSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case MethodDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 6387, 6447);

                            return f_10032_6394_6438(((MethodDeclarationSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case IndexerDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 6521, 6576);

                            return f_10032_6528_6567(((IndexerDeclarationSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case OperatorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 6651, 6713);

                            return f_10032_6658_6704(((OperatorDeclarationSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case ConversionOperatorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 6798, 6864);

                            return f_10032_6805_6855(((ConversionOperatorDeclarationSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case PropertyDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 6939, 6995);

                            return f_10032_6946_6986(((PropertyDeclarationSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case DelegateDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 7070, 7132);

                            return f_10032_7077_7123(((DelegateDeclarationSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case EventDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 7204, 7257);

                            return f_10032_7211_7248(((EventDeclarationSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case LocalFunctionStatement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 7335, 7400);

                            return f_10032_7342_7391(((LocalFunctionStatementSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case SimpleBaseType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 7470, 7482);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case PrimaryConstructorBaseType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 7564, 7627);

                            return f_10032_7571_7618(((PrimaryConstructorBaseTypeSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case CrefParameter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 7696, 7708);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case ConversionOperatorMemberCref:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 7792, 7857);

                            return f_10032_7799_7848(((ConversionOperatorMemberCrefSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case ExplicitInterfaceSpecifier:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 8327, 8390);

                            return f_10032_8334_8381(((ExplicitInterfaceSpecifierSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case DeclarationPattern:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 8464, 8519);

                            return f_10032_8471_8510(((DeclarationPatternSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case RecursivePattern:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 8591, 8644);

                            return f_10032_8598_8635(((RecursivePatternSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case TupleElement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 8712, 8761);

                            return f_10032_8719_8752(((TupleElementSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case DeclarationExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 8838, 8896);

                            return f_10032_8845_8887(((DeclarationExpressionSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);

                        case IncompleteMember:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 3250, 9040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 8968, 9021);

                            return f_10032_8975_9012(((IncompleteMemberSyntax)parent)) == node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3250, 9040);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 3198, 9055);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 9071, 9084);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 3008, 9095);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10032_3101_3144(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = SyntaxFactory.GetStandaloneExpression(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 3101, 3144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10032_3172_3183(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 3172, 3183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10032_3258_3271(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 3258, 3271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10032_3361_3391(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 3361, 3391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_3472_3509(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 3472, 3509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_3592_3631(Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 3592, 3631);
                    return return_v;
                }


                System.Exception
                f_10032_3826_3856()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 3826, 3856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_4014_4054(Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 4014, 4054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_4300_4335(Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 4300, 4335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_4431_4476(Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 4431, 4476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_4581_4635(Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 4581, 4635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10032_4717_4748(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 4717, 4748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10032_4830_4861(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 4830, 4861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_4952_4992(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 4952, 4992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_5080_5117(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 5080, 5117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_5205_5242(Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 5205, 5242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10032_5366_5404(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 5366, 5404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_5492_5529(Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 5492, 5529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_5617_5654(Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 5617, 5654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_5743_5781(Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 5743, 5781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_5871_5910(Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 5871, 5910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_5989_6017(Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 5989, 6017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10032_6150_6184(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 6150, 6184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_6270_6305(Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 6270, 6305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_6394_6438(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 6394, 6438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_6528_6567(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 6528, 6567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_6658_6704(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 6658, 6704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_6805_6855(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 6805, 6855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_6946_6986(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 6946, 6986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_7077_7123(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 7077, 7123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_7211_7248(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 7211, 7248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_7342_7391(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 7342, 7391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_7571_7618(Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 7571, 7618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_7799_7848(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 7799, 7848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10032_8334_8381(Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 8334, 8381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_8471_8510(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 8471, 8510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10032_8598_8635(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 8598, 8635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_8719_8752(Microsoft.CodeAnalysis.CSharp.Syntax.TupleElementSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 8719, 8752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10032_8845_8887(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 8845, 8887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10032_8975_9012(Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 8975, 9012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 3008, 9095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 3008, 9095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsInNamespaceOrTypeContext(ExpressionSyntax? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 9336, 10508);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 9430, 10468) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 9430, 10468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 9480, 9549);

                    node = (ExpressionSyntax)f_10032_9505_9548(node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 9567, 9592);

                    var
                    parent = f_10032_9580_9591(node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 9610, 10453) || true) && (parent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 9610, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 9670, 10434);

                        switch (f_10032_9678_9691(parent))
                        {

                            case UsingDirective:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 9670, 10434);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 9791, 9842);

                                return f_10032_9798_9833(((UsingDirectiveSyntax)parent)) == node;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 9670, 10434);

                            case QualifiedName:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 9670, 10434);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 10262, 10312);

                                return f_10032_10269_10303(((QualifiedNameSyntax)parent)) == node;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 9670, 10434);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 9670, 10434);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 10378, 10411);

                                return f_10032_10385_10410(node);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 9670, 10434);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 9610, 10453);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 9430, 10468);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 10484, 10497);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 9336, 10508);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10032_9505_9548(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = SyntaxFactory.GetStandaloneExpression(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 9505, 9548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10032_9580_9591(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 9580, 9591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10032_9678_9691(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 9678, 9691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10032_9798_9833(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 9798, 9833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10032_10269_10303(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 10269, 10303);
                    return return_v;
                }


                bool
                f_10032_10385_10410(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = IsInTypeOnlyContext(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 10385, 10410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 9336, 10508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 9336, 10508);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNamedArgumentName(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 10747, 12841);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11049, 11143) || true) && (!f_10032_11054_11081(node, IdentifierName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 11049, 11143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11115, 11128);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 11049, 11143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11159, 11185);

                var
                parent1 = f_10032_11173_11184(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11199, 11310) || true) && (parent1 == null || (DynAbs.Tracing.TraceSender.Expression_False(10032, 11203, 11248) || !f_10032_11223_11248(parent1, NameColon)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 11199, 11310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11282, 11295);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 11199, 11310);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11326, 11355);

                var
                parent2 = f_10032_11340_11354(parent1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11369, 11471) || true) && (f_10032_11373_11410(parent2, SyntaxKind.Subpattern))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 11369, 11471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11444, 11456);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 11369, 11471);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11487, 11636) || true) && (parent2 == null || (DynAbs.Tracing.TraceSender.Expression_False(10032, 11491, 11574) || !(f_10032_11512_11536(parent2, Argument) || (DynAbs.Tracing.TraceSender.Expression_False(10032, 11512, 11573) || f_10032_11540_11573(parent2, AttributeArgument)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 11487, 11636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11608, 11621);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 11487, 11636);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11652, 11681);

                var
                parent3 = f_10032_11666_11680(parent2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11695, 11776) || true) && (parent3 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 11695, 11776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11748, 11761);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 11695, 11776);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11792, 11899) || true) && (f_10032_11796_11838(parent3, SyntaxKind.TupleExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 11792, 11899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11872, 11884);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 11792, 11899);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 11915, 12058) || true) && (!(parent3 is BaseArgumentListSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10032, 11921, 11995) || f_10032_11958_11995(parent3, AttributeArgumentList))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 11915, 12058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 12030, 12043);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 11915, 12058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 12074, 12103);

                var
                parent4 = f_10032_12088_12102(parent3)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 12117, 12198) || true) && (parent4 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 12117, 12198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 12170, 12183);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 12117, 12198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 12214, 12830);

                switch (f_10032_12222_12236(parent4))
                {

                    case InvocationExpression:
                    case TupleExpression:
                    case ObjectCreationExpression:
                    case ImplicitObjectCreationExpression:
                    case ObjectInitializerExpression:
                    case ElementAccessExpression:
                    case Attribute:
                    case BaseConstructorInitializer:
                    case ThisConstructorInitializer:
                    case PrimaryConstructorBaseType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 12214, 12830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 12742, 12754);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 12214, 12830);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 12214, 12830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 12802, 12815);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 12214, 12830);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 10747, 12841);

                bool
                f_10032_11054_11081(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 11054, 11081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_11173_11184(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 11173, 11184);
                    return return_v;
                }


                bool
                f_10032_11223_11248(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 11223, 11248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_11340_11354(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 11340, 11354);
                    return return_v;
                }


                bool
                f_10032_11373_11410(Microsoft.CodeAnalysis.SyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 11373, 11410);
                    return return_v;
                }


                bool
                f_10032_11512_11536(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 11512, 11536);
                    return return_v;
                }


                bool
                f_10032_11540_11573(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 11540, 11573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_11666_11680(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 11666, 11680);
                    return return_v;
                }


                bool
                f_10032_11796_11838(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 11796, 11838);
                    return return_v;
                }


                bool
                f_10032_11958_11995(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 11958, 11995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_12088_12102(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 12088, 12102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10032_12222_12236(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 12222, 12236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 10747, 12841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 10747, 12841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsFixedStatementExpression(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 12969, 13872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13056, 13082);

                var
                current = f_10032_13070_13081(node)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13284, 13412) || true) && (current != null && (DynAbs.Tracing.TraceSender.Expression_True(10032, 13291, 13385) && (f_10032_13311_13350(current, ParenthesizedExpression) || (DynAbs.Tracing.TraceSender.Expression_False(10032, 13311, 13384) || f_10032_13354_13384(current, CastExpression)))))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13284, 13412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13387, 13412);

                        current = f_10032_13397_13411(current);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13284, 13412);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10032, 13284, 13412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10032, 13284, 13412);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13426, 13498) || true) && (current == null || (DynAbs.Tracing.TraceSender.Expression_False(10032, 13430, 13483) || !f_10032_13450_13483(current, EqualsValueClause)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13426, 13498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13485, 13498);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13426, 13498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13512, 13537);

                current = f_10032_13522_13536(current);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13551, 13624) || true) && (current == null || (DynAbs.Tracing.TraceSender.Expression_False(10032, 13555, 13609) || !f_10032_13575_13609(current, VariableDeclarator)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13551, 13624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13611, 13624);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13551, 13624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13638, 13663);

                current = f_10032_13648_13662(current);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13677, 13751) || true) && (current == null || (DynAbs.Tracing.TraceSender.Expression_False(10032, 13681, 13736) || !f_10032_13701_13736(current, VariableDeclaration)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13677, 13751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13738, 13751);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13677, 13751);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13765, 13790);

                current = f_10032_13775_13789(current);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13804, 13861);

                return current != null && (DynAbs.Tracing.TraceSender.Expression_True(10032, 13811, 13860) && f_10032_13830_13860(current, FixedStatement));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 12969, 13872);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_13070_13081(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 13070, 13081);
                    return return_v;
                }


                bool
                f_10032_13311_13350(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 13311, 13350);
                    return return_v;
                }


                bool
                f_10032_13354_13384(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 13354, 13384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_13397_13411(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 13397, 13411);
                    return return_v;
                }


                bool
                f_10032_13450_13483(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 13450, 13483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_13522_13536(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 13522, 13536);
                    return return_v;
                }


                bool
                f_10032_13575_13609(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 13575, 13609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_13648_13662(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 13648, 13662);
                    return return_v;
                }


                bool
                f_10032_13701_13736(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 13701, 13736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_13775_13789(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 13775, 13789);
                    return return_v;
                }


                bool
                f_10032_13830_13860(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 13830, 13860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 12969, 13872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 12969, 13872);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetText(Accessibility accessibility)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 13884, 15008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 13966, 14997);

                switch (accessibility)
                {

                    case Accessibility.NotApplicable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13966, 14997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 14076, 14096);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13966, 14997);

                    case Accessibility.Private:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13966, 14997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 14163, 14206);

                        return f_10032_14170_14205(PrivateKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13966, 14997);

                    case Accessibility.ProtectedAndInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13966, 14997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 14286, 14375);

                        return f_10032_14293_14328(PrivateKeyword) + " " + f_10032_14337_14374(ProtectedKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13966, 14997);

                    case Accessibility.Internal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13966, 14997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 14443, 14487);

                        return f_10032_14450_14486(InternalKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13966, 14997);

                    case Accessibility.Protected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13966, 14997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 14556, 14601);

                        return f_10032_14563_14600(ProtectedKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13966, 14997);

                    case Accessibility.ProtectedOrInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13966, 14997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 14680, 14770);

                        return f_10032_14687_14724(ProtectedKeyword) + " " + f_10032_14733_14769(InternalKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13966, 14997);

                    case Accessibility.Public:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13966, 14997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 14836, 14878);

                        return f_10032_14843_14877(PublicKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13966, 14997);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 13966, 14997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 14926, 14982);

                        throw f_10032_14932_14981(accessibility);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 13966, 14997);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 13884, 15008);

                string
                f_10032_14170_14205(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 14170, 14205);
                    return return_v;
                }


                string
                f_10032_14293_14328(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 14293, 14328);
                    return return_v;
                }


                string
                f_10032_14337_14374(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 14337, 14374);
                    return return_v;
                }


                string
                f_10032_14450_14486(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 14450, 14486);
                    return return_v;
                }


                string
                f_10032_14563_14600(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 14563, 14600);
                    return return_v;
                }


                string
                f_10032_14687_14724(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 14687, 14724);
                    return return_v;
                }


                string
                f_10032_14733_14769(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 14733, 14769);
                    return return_v;
                }


                string
                f_10032_14843_14877(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 14843, 14877);
                    return return_v;
                }


                System.Exception
                f_10032_14932_14981(Microsoft.CodeAnalysis.Accessibility
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 14932, 14981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 13884, 15008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 13884, 15008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsStatementExpression(SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 15020, 17151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 15633, 17140);

                switch (f_10032_15641_15654(syntax))
                {

                    case InvocationExpression:
                    case ObjectCreationExpression:
                    case SimpleAssignmentExpression:
                    case AddAssignmentExpression:
                    case SubtractAssignmentExpression:
                    case MultiplyAssignmentExpression:
                    case DivideAssignmentExpression:
                    case ModuloAssignmentExpression:
                    case AndAssignmentExpression:
                    case OrAssignmentExpression:
                    case ExclusiveOrAssignmentExpression:
                    case LeftShiftAssignmentExpression:
                    case RightShiftAssignmentExpression:
                    case CoalesceAssignmentExpression:
                    case PostIncrementExpression:
                    case PostDecrementExpression:
                    case PreIncrementExpression:
                    case PreDecrementExpression:
                    case AwaitExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 15633, 17140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 16617, 16629);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 15633, 17140);

                    case ConditionalAccessExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 15633, 17140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 16704, 16759);

                        var
                        access = (ConditionalAccessExpressionSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 16781, 16830);

                        return f_10032_16788_16829(f_10032_16810_16828(access));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 15633, 17140);

                    case IdentifierName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 15633, 17140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 17038, 17062);

                        return f_10032_17045_17061(syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 15633, 17140);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 15633, 17140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 17112, 17125);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 15633, 17140);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 15020, 17151);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10032_15641_15654(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 15641, 15654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10032_16810_16828(Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.WhenNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 16810, 16828);
                    return return_v;
                }


                bool
                f_10032_16788_16829(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    var return_v = IsStatementExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 16788, 16829);
                    return return_v;
                }


                bool
                f_10032_17045_17061(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 17045, 17061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 15020, 17151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 15020, 17151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [System.Obsolete("IsLambdaBody API is obsolete", true)]
        public static bool IsLambdaBody(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 17163, 17354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 17301, 17343);

                return f_10032_17308_17342(node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 17163, 17354);

                bool
                f_10032_17308_17342(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = LambdaUtilities.IsLambdaBody(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 17308, 17342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 17163, 17354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 17163, 17354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsIdentifierVar(this Syntax.InternalSyntax.SyntaxToken node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 17366, 17535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 17472, 17524);

                return f_10032_17479_17498(node) == SyntaxKind.VarKeyword;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 17366, 17535);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10032_17479_17498(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 17479, 17498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 17366, 17535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 17366, 17535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsIdentifierVarOrPredefinedType(this Syntax.InternalSyntax.SyntaxToken node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 17547, 17741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 17669, 17730);

                return f_10032_17676_17698(node) || (DynAbs.Tracing.TraceSender.Expression_False(10032, 17676, 17729) || f_10032_17702_17729(f_10032_17719_17728(node)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 17547, 17741);

                bool
                f_10032_17676_17698(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node)
                {
                    var return_v = node.IsIdentifierVar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 17676, 17698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10032_17719_17728(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 17719, 17728);
                    return return_v;
                }


                bool
                f_10032_17702_17729(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = IsPredefinedType(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 17702, 17729);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 17547, 17741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 17547, 17741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsDeclarationExpressionType(SyntaxNode node, [NotNullWhen(true)] out DeclarationExpressionSyntax? parent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 17753, 18009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 17904, 17956);

                parent = f_10032_17913_17924(node) as DeclarationExpressionSyntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 17970, 17998);

                return node == f_10032_17985_17997_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(parent, 10032, 17985, 17997)?.Type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 17753, 18009);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10032_17913_17924(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 17913, 17924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10032_17985_17997_M(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 17985, 17997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 17753, 18009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 17753, 18009);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string? TryGetInferredMemberName(this SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 18210, 19677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 18305, 18327);

                SyntaxToken
                nameToken
                = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 18341, 19591);

                switch (f_10032_18349_18362(syntax))
                {

                    case SyntaxKind.SingleVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 18341, 19591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 18460, 18525);

                        nameToken = f_10032_18472_18524(((SingleVariableDesignationSyntax)syntax));
                        DynAbs.Tracing.TraceSender.TraceBreak(10032, 18547, 18553);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 18341, 19591);

                    case SyntaxKind.DeclarationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 18341, 19591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 18633, 18687);

                        var
                        declaration = (DeclarationExpressionSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 18709, 18762);

                        var
                        designationKind = f_10032_18731_18761(f_10032_18731_18754(declaration))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 18784, 19012) || true) && (designationKind == SyntaxKind.ParenthesizedVariableDesignation || (DynAbs.Tracing.TraceSender.Expression_False(10032, 18788, 18927) || designationKind == SyntaxKind.DiscardDesignation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 18784, 19012);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 18977, 18989);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 18784, 19012);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 19036, 19118);

                        nameToken = f_10032_19048_19117(((SingleVariableDesignationSyntax)f_10032_19082_19105(declaration)));
                        DynAbs.Tracing.TraceSender.TraceBreak(10032, 19140, 19146);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 18341, 19591);

                    case SyntaxKind.ParenthesizedVariableDesignation:
                    case SyntaxKind.DiscardDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 18341, 19591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 19290, 19302);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 18341, 19591);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 18341, 19591);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 19352, 19542) || true) && (syntax is ExpressionSyntax expr)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 19352, 19542);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 19437, 19487);

                            nameToken = f_10032_19449_19486(expr);
                            DynAbs.Tracing.TraceSender.TraceBreak(10032, 19513, 19519);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 19352, 19542);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 19564, 19576);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 18341, 19591);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 19607, 19666);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10032, 19614, 19636) || ((nameToken.RawKind != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10032, 19639, 19658)) || DynAbs.Tracing.TraceSender.Conditional_F3(10032, 19661, 19665))) ? nameToken.ValueText : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 18210, 19677);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10032_18349_18362(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 18349, 18362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10032_18472_18524(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 18472, 18524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10032_18731_18754(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 18731, 18754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10032_18731_18761(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 18731, 18761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10032_19082_19105(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 19082, 19105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10032_19048_19117(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 19048, 19117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10032_19449_19486(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                input)
                {
                    var return_v = input.ExtractAnonymousTypeMemberName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 19449, 19486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 18210, 19677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 18210, 19677);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsReservedTupleElementName(string elementName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 20048, 20218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 20138, 20207);

                return f_10032_20145_20200(elementName) != -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 20048, 20218);

                int
                f_10032_20145_20200(string
                name)
                {
                    var return_v = NamedTypeSymbol.IsTupleElementNameReserved(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 20145, 20200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 20048, 20218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 20048, 20218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasAnyBody(this BaseMethodDeclarationSyntax declaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 20230, 20420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 20332, 20409);

                return (f_10032_20340_20356(declaration) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?>(10032, 20340, 20399) ?? (SyntaxNode?)f_10032_20373_20399(declaration))) != null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 20230, 20420);

                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10032_20340_20356(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 20340, 20356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10032_20373_20399(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 20373, 20399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 20230, 20420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 20230, 20420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsTopLevelStatement([NotNullWhen(true)] GlobalStatementSyntax? syntax)
        {
            // LAFHIS
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(99999, 99999, 99999);
            return syntax?.Parent?.IsKind(SyntaxKind.CompilationUnit) == true;
        }

        internal static bool IsSimpleProgramTopLevelStatement(GlobalStatementSyntax? syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 20637, 20852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 20746, 20841);

                return f_10032_20753_20780(syntax) && (DynAbs.Tracing.TraceSender.Expression_True(10032, 20753, 20840) && f_10032_20784_20814(f_10032_20784_20809(f_10032_20784_20801(syntax))) == SourceCodeKind.Regular);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 20637, 20852);

                bool
                f_10032_20753_20780(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax?
                syntax)
                {
                    var return_v = IsTopLevelStatement(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 20753, 20780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10032_20784_20801(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 20784, 20801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10032_20784_20809(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 20784, 20809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10032_20784_20814(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10032, 20784, 20814);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 20637, 20852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 20637, 20852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasAwaitOperations(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 20864, 21921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 20991, 21910);

                return f_10032_20998_21909(f_10032_20998_21060(node, child => !IsNestedFunction(child)), node =>
                                            {
                                                switch (node)
                                                {
                                                    case AwaitExpressionSyntax _:
                                                    case LocalDeclarationStatementSyntax local when local.AwaitKeyword.IsKind(SyntaxKind.AwaitKeyword):
                                                    case CommonForEachStatementSyntax @foreach when @foreach.AwaitKeyword.IsKind(SyntaxKind.AwaitKeyword):
                                                    case UsingStatementSyntax @using when @using.AwaitKeyword.IsKind(SyntaxKind.AwaitKeyword):
                                                        return true;
                                                    default:
                                                        return false;
                                                }
                                            });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 20864, 21921);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10032_20998_21060(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = this_param.DescendantNodesAndSelf(descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 20998, 21060);
                    return return_v;
                }


                bool
                f_10032_20998_21909(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 20998, 21909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 20864, 21921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 20864, 21921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNestedFunction(SyntaxNode child)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 21933, 22408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 22013, 22397);

                switch (f_10032_22021_22033(child))
                {

                    case SyntaxKind.LocalFunctionStatement:
                    case SyntaxKind.AnonymousMethodExpression:
                    case SyntaxKind.SimpleLambdaExpression:
                    case SyntaxKind.ParenthesizedLambdaExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 22013, 22397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 22309, 22321);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 22013, 22397);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10032, 22013, 22397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 22369, 22382);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10032, 22013, 22397);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 21933, 22408);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10032_22021_22033(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 22021, 22033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 21933, 22408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 21933, 22408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasYieldOperations(SyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 22420, 22961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 22564, 22950);

                return node is object && (DynAbs.Tracing.TraceSender.Expression_True(10032, 22571, 22949) && f_10032_22609_22949(f_10032_22609_22913(node, child =>
                   {
                       Debug.Assert(ReferenceEquals(node, child) || child is not (MemberDeclarationSyntax or TypeDeclarationSyntax));
                       return !IsNestedFunction(child) && !(node is ExpressionSyntax);
                   }), n => n is YieldStatementSyntax));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 22420, 22961);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10032_22609_22913(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = this_param.DescendantNodesAndSelf(descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 22609, 22913);
                    return return_v;
                }


                bool
                f_10032_22609_22949(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 22609, 22949);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 22420, 22961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 22420, 22961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasReturnWithExpression(SyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10032, 22973, 23329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10032, 23122, 23318);

                return node is object && (DynAbs.Tracing.TraceSender.Expression_True(10032, 23129, 23317) && f_10032_23167_23317(f_10032_23167_23260(node, child => !IsNestedFunction(child) && !(node is ExpressionSyntax)), n => n is ReturnStatementSyntax { Expression: { } }));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10032, 22973, 23329);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10032_23167_23260(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = this_param.DescendantNodesAndSelf(descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 23167, 23260);
                    return return_v;
                }


                bool
                f_10032_23167_23317(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10032, 23167, 23317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10032, 22973, 23329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10032, 22973, 23329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
