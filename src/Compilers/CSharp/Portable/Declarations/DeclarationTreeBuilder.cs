// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using CoreInternalSyntax = Microsoft.CodeAnalysis.Syntax.InternalSyntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class DeclarationTreeBuilder : CSharpSyntaxVisitor<SingleNamespaceOrTypeDeclaration>
    {
        private readonly SyntaxTree _syntaxTree;

        private readonly string _scriptClassName;

        private readonly bool _isSubmission;

        private DeclarationTreeBuilder(SyntaxTree syntaxTree, string scriptClassName, bool isSubmission)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10044, 899, 1148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 778, 789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 824, 840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 873, 886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 1020, 1045);

                _syntaxTree = syntaxTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 1059, 1094);

                _scriptClassName = scriptClassName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 1108, 1137);

                _isSubmission = isSubmission;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10044, 899, 1148);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 899, 1148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 899, 1148);
            }
        }

        public static RootSingleNamespaceDeclaration ForTree(
                    SyntaxTree syntaxTree,
                    string scriptClassName,
                    bool isSubmission)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 1160, 1527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 1343, 1427);

                var
                builder = f_10044_1357_1426(syntaxTree, scriptClassName, isSubmission)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 1441, 1516);

                return (RootSingleNamespaceDeclaration)f_10044_1480_1515(builder, f_10044_1494_1514(syntaxTree));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 1160, 1527);

                Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                f_10044_1357_1426(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, string
                scriptClassName, bool
                isSubmission)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder(syntaxTree, scriptClassName, isSubmission);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 1357, 1426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10044_1494_1514(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 1494, 1514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration?
                f_10044_1480_1515(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 1480, 1515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 1160, 1527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 1160, 1527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<SingleNamespaceOrTypeDeclaration> VisitNamespaceChildren(
                    CSharpSyntaxNode node,
                    SyntaxList<MemberDeclarationSyntax> members,
                    CoreInternalSyntax.SyntaxList<Syntax.InternalSyntax.MemberDeclarationSyntax> internalMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 1539, 5287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 1845, 2007);

                f_10044_1845_2006(f_10044_1858_1869(node) == SyntaxKind.NamespaceDeclaration || (DynAbs.Tracing.TraceSender.Expression_False(10044, 1858, 2005) || (f_10044_1909_1920(node) == SyntaxKind.CompilationUnit && (DynAbs.Tracing.TraceSender.Expression_True(10044, 1909, 2004) && f_10044_1954_1978(f_10044_1954_1973(_syntaxTree)) == SourceCodeKind.Regular))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2023, 2156) || true) && (members.Count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 2023, 2156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2079, 2141);

                    return ImmutableArray<SingleNamespaceOrTypeDeclaration>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 2023, 2156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2321, 2351);

                bool
                hasGlobalMembers = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2365, 2488);

                bool
                acceptSimpleProgram = f_10044_2392_2403(node) == SyntaxKind.CompilationUnit && (DynAbs.Tracing.TraceSender.Expression_True(10044, 2392, 2487) && f_10044_2437_2461(f_10044_2437_2456(_syntaxTree)) == SourceCodeKind.Regular)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2502, 2535);

                bool
                hasAwaitExpressions = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2549, 2573);

                bool
                isIterator = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2587, 2624);

                bool
                hasReturnWithExpression = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2638, 2688);

                GlobalStatementSyntax
                firstGlobalStatement = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2704, 2787);

                var
                childrenBuilder = f_10044_2726_2786()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2801, 4239);
                    foreach (var member in f_10044_2824_2831_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 2801, 4239);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2865, 2930);

                        SingleNamespaceOrTypeDeclaration
                        namespaceOrType = f_10044_2916_2929(this, member)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 2948, 4224) || true) && (namespaceOrType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 2948, 4224);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3017, 3054);

                            f_10044_3017_3053(childrenBuilder, namespaceOrType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 2948, 4224);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 2948, 4224);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3096, 4224) || true) && (acceptSimpleProgram && (DynAbs.Tracing.TraceSender.Expression_True(10044, 3100, 3164) && f_10044_3123_3164(member, SyntaxKind.GlobalStatement)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 3096, 4224);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3206, 3249);

                                var
                                global = (GlobalStatementSyntax)member
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3302, 3391) || true) && (firstGlobalStatement == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 3302, 3391);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3361, 3391);

                                    firstGlobalStatement = global;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 3302, 3391);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3413, 3454);

                                var
                                topLevelStatement = f_10044_3437_3453(global)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3478, 3647) || true) && (!hasAwaitExpressions)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 3478, 3647);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3552, 3624);

                                    hasAwaitExpressions = f_10044_3574_3623(topLevelStatement);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 3478, 3647);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3671, 3822) || true) && (!isIterator)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 3671, 3822);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3736, 3799);

                                    isIterator = f_10044_3749_3798(topLevelStatement);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 3671, 3822);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3846, 4028) || true) && (!hasReturnWithExpression)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 3846, 4028);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 3924, 4005);

                                    hasReturnWithExpression = f_10044_3950_4004(topLevelStatement);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 3846, 4028);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 3096, 4224);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 3096, 4224);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 4070, 4224) || true) && (!hasGlobalMembers && (DynAbs.Tracing.TraceSender.Expression_True(10044, 4074, 4139) && f_10044_4095_4108(member) != SyntaxKind.IncompleteMember))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 4070, 4224);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 4181, 4205);

                                    hasGlobalMembers = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 4070, 4224);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 3096, 4224);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 2948, 4224);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 2801, 4239);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 1, 1439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 1, 1439);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 4348, 4552) || true) && (firstGlobalStatement is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 4348, 4552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 4416, 4537);

                    f_10044_4416_4536(childrenBuilder, f_10044_4436_4535(firstGlobalStatement, hasAwaitExpressions, isIterator, hasReturnWithExpression));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 4348, 4552);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 4676, 5216) || true) && (hasGlobalMembers)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 4676, 5216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 4804, 4907);

                    SingleTypeDeclaration.TypeDeclarationFlags
                    declFlags = SingleTypeDeclaration.TypeDeclarationFlags.None
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 4925, 5040);

                    var
                    memberNames = f_10044_4943_5039(internalMembers, ref declFlags, skipGlobalStatements: acceptSimpleProgram)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 5058, 5105);

                    var
                    container = f_10044_5074_5104(_syntaxTree, node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 5125, 5201);

                    f_10044_5125_5200(
                                    childrenBuilder, f_10044_5145_5199(memberNames, container, declFlags));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 4676, 5216);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 5232, 5276);

                return f_10044_5239_5275(childrenBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 1539, 5287);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_1858_1869(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 1858, 1869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_1909_1920(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 1909, 1920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10044_1954_1973(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 1954, 1973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10044_1954_1978(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 1954, 1978);
                    return return_v;
                }


                int
                f_10044_1845_2006(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 1845, 2006);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_2392_2403(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 2392, 2403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10044_2437_2456(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 2437, 2456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10044_2437_2461(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 2437, 2461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10044_2726_2786()
                {
                    var return_v = ArrayBuilder<SingleNamespaceOrTypeDeclaration>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 2726, 2786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration?
                f_10044_2916_2929(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 2916, 2929);
                    return return_v;
                }


                int
                f_10044_3017_3053(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 3017, 3053);
                    return 0;
                }


                bool
                f_10044_3123_3164(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 3123, 3164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10044_3437_3453(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 3437, 3453);
                    return return_v;
                }


                bool
                f_10044_3574_3623(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node)
                {
                    var return_v = SyntaxFacts.HasAwaitOperations((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 3574, 3623);
                    return return_v;
                }


                bool
                f_10044_3749_3798(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node)
                {
                    var return_v = SyntaxFacts.HasYieldOperations((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 3749, 3798);
                    return return_v;
                }


                bool
                f_10044_3950_4004(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node)
                {
                    var return_v = SyntaxFacts.HasReturnWithExpression((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 3950, 4004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_4095_4108(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 4095, 4108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10044_2824_2831_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 2824, 2831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                f_10044_4436_4535(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                firstGlobalStatement, bool
                hasAwaitExpressions, bool
                isIterator, bool
                hasReturnWithExpression)
                {
                    var return_v = CreateSimpleProgram(firstGlobalStatement, hasAwaitExpressions, isIterator, hasReturnWithExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 4436, 4535);
                    return return_v;
                }


                int
                f_10044_4416_4536(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 4416, 4536);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_10044_4943_5039(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>
                members, ref Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags, bool
                skipGlobalStatements)
                {
                    var return_v = GetNonTypeMemberNames(members, ref declFlags, skipGlobalStatements: skipGlobalStatements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 4943, 5039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10044_5074_5104(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetReference((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 5074, 5104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                f_10044_5145_5199(System.Collections.Immutable.ImmutableHashSet<string>
                memberNames, Microsoft.CodeAnalysis.SyntaxReference
                container, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags)
                {
                    var return_v = CreateImplicitClass(memberNames, container, declFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 5145, 5199);
                    return return_v;
                }


                int
                f_10044_5125_5200(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 5125, 5200);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10044_5239_5275(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 5239, 5275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 1539, 5287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 1539, 5287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SingleNamespaceOrTypeDeclaration CreateImplicitClass(ImmutableHashSet<string> memberNames, SyntaxReference container, SingleTypeDeclaration.TypeDeclarationFlags declFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 5299, 6133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 5510, 6122);

                return f_10044_5517_6121(kind: DeclarationKind.ImplicitClass, name: TypeSymbol.ImplicitTypeName, arity: 0, modifiers: DeclarationModifiers.Internal | DeclarationModifiers.Partial | DeclarationModifiers.Sealed, declFlags: declFlags, syntaxReference: container, nameLocation: f_10044_5912_5941(container), memberNames: memberNames, children: ImmutableArray<SingleTypeDeclaration>.Empty, diagnostics: ImmutableArray<Diagnostic>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 5299, 6133);

                Microsoft.CodeAnalysis.SourceLocation
                f_10044_5912_5941(Microsoft.CodeAnalysis.SyntaxReference
                syntaxRef)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(syntaxRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 5912, 5941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                f_10044_5517_6121(Microsoft.CodeAnalysis.CSharp.DeclarationKind
                kind, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags, Microsoft.CodeAnalysis.SyntaxReference
                syntaxReference, Microsoft.CodeAnalysis.SourceLocation
                nameLocation, System.Collections.Immutable.ImmutableHashSet<string>
                memberNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration(kind: kind, name: name, arity: arity, modifiers: modifiers, declFlags: declFlags, syntaxReference: syntaxReference, nameLocation: nameLocation, memberNames: memberNames, children: children, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 5517, 6121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 5299, 6133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 5299, 6133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SingleNamespaceOrTypeDeclaration CreateSimpleProgram(GlobalStatementSyntax firstGlobalStatement, bool hasAwaitExpressions, bool isIterator, bool hasReturnWithExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 6145, 7568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 6354, 7557);

                return f_10044_6361_7556(kind: DeclarationKind.SimpleProgram, name: WellKnownMemberNames.TopLevelStatementsEntryPointTypeName, arity: 0, modifiers: DeclarationModifiers.Internal | DeclarationModifiers.Partial | DeclarationModifiers.Static, declFlags: ((DynAbs.Tracing.TraceSender.Conditional_F1(10044, 6700, 6719) || ((hasAwaitExpressions && DynAbs.Tracing.TraceSender.Conditional_F2(10044, 6722, 6784)) || DynAbs.Tracing.TraceSender.Conditional_F3(10044, 6787, 6834))) ? SingleTypeDeclaration.TypeDeclarationFlags.HasAwaitExpressions : SingleTypeDeclaration.TypeDeclarationFlags.None) |
                                           ((DynAbs.Tracing.TraceSender.Conditional_F1(10044, 6867, 6877) || ((isIterator && DynAbs.Tracing.TraceSender.Conditional_F2(10044, 6880, 6933)) || DynAbs.Tracing.TraceSender.Conditional_F3(10044, 6936, 6983))) ? SingleTypeDeclaration.TypeDeclarationFlags.IsIterator : SingleTypeDeclaration.TypeDeclarationFlags.None) |
                                           ((DynAbs.Tracing.TraceSender.Conditional_F1(10044, 7016, 7039) || ((hasReturnWithExpression && DynAbs.Tracing.TraceSender.Conditional_F2(10044, 7042, 7108)) || DynAbs.Tracing.TraceSender.Conditional_F3(10044, 7111, 7158))) ? SingleTypeDeclaration.TypeDeclarationFlags.HasReturnWithExpression : SingleTypeDeclaration.TypeDeclarationFlags.None), syntaxReference: f_10044_7195_7268(f_10044_7195_7226(firstGlobalStatement), f_10044_7240_7267(firstGlobalStatement)), nameLocation: f_10044_7301_7357(f_10044_7320_7356(firstGlobalStatement)), memberNames: ImmutableHashSet<string>.Empty, children: ImmutableArray<SingleTypeDeclaration>.Empty, diagnostics: ImmutableArray<Diagnostic>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 6145, 7568);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10044_7195_7226(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 7195, 7226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10044_7240_7267(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 7240, 7267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10044_7195_7268(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = this_param.GetReference((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 7195, 7268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10044_7320_7356(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 7320, 7356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10044_7301_7357(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 7301, 7357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                f_10044_6361_7556(Microsoft.CodeAnalysis.CSharp.DeclarationKind
                kind, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags, Microsoft.CodeAnalysis.SyntaxReference
                syntaxReference, Microsoft.CodeAnalysis.SourceLocation
                nameLocation, System.Collections.Immutable.ImmutableHashSet<string>
                memberNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration(kind: kind, name: name, arity: arity, modifiers: modifiers, declFlags: declFlags, syntaxReference: syntaxReference, nameLocation: nameLocation, memberNames: memberNames, children: children, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 6361, 7556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 6145, 7568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 6145, 7568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RootSingleNamespaceDeclaration CreateScriptRootDeclaration(CompilationUnitSyntax compilationUnit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 7841, 9982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 7971, 8036);

                f_10044_7971_8035(f_10044_7984_8008(f_10044_7984_8003(_syntaxTree)) != SourceCodeKind.Regular);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 8052, 8090);

                var
                members = f_10044_8066_8089(compilationUnit)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 8104, 8184);

                var
                rootChildren = f_10044_8123_8183()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 8198, 8269);

                var
                scriptChildren = f_10044_8219_8268()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 8285, 8930);
                    foreach (var member in f_10044_8308_8315_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 8285, 8930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 8349, 8374);

                        var
                        decl = f_10044_8360_8373(this, member)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 8392, 8915) || true) && (decl != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 8392, 8915);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 8612, 8896) || true) && (f_10044_8616_8625(decl) == DeclarationKind.Namespace)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 8612, 8896);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 8704, 8727);

                                f_10044_8704_8726(rootChildren, decl);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 8612, 8896);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 8612, 8896);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 8825, 8873);

                                f_10044_8825_8872(scriptChildren, decl);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 8612, 8896);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 8392, 8915);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 8285, 8930);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 1, 646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 1, 646);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 9016, 9119);

                SingleTypeDeclaration.TypeDeclarationFlags
                declFlags = SingleTypeDeclaration.TypeDeclarationFlags.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 9133, 9268);

                var
                membernames = f_10044_9151_9267(f_10044_9173_9251(((Syntax.InternalSyntax.CompilationUnitSyntax)(f_10044_9220_9241(compilationUnit)))), ref declFlags)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 9282, 9499);

                f_10044_9282_9498(rootChildren, f_10044_9317_9497(this, compilationUnit, f_10044_9395_9430(scriptChildren), membernames, declFlags));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 9515, 9971);

                return f_10044_9522_9970(hasUsings: compilationUnit.Usings.Any(), hasExternAliases: compilationUnit.Externs.Any(), treeNode: f_10044_9709_9750(_syntaxTree, compilationUnit), children: f_10044_9779_9812(rootChildren), referenceDirectives: f_10044_9852_9891(compilationUnit), hasAssemblyAttributes: compilationUnit.AttributeLists.Any());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 7841, 9982);

                Microsoft.CodeAnalysis.ParseOptions
                f_10044_7984_8003(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 7984, 8003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10044_7984_8008(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 7984, 8008);
                    return return_v;
                }


                int
                f_10044_7971_8035(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 7971, 8035);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10044_8066_8089(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 8066, 8089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10044_8123_8183()
                {
                    var return_v = ArrayBuilder<SingleNamespaceOrTypeDeclaration>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 8123, 8183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10044_8219_8268()
                {
                    var return_v = ArrayBuilder<SingleTypeDeclaration>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 8219, 8268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration?
                f_10044_8360_8373(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 8360, 8373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationKind
                f_10044_8616_8625(Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 8616, 8625);
                    return return_v;
                }


                int
                f_10044_8704_8726(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 8704, 8726);
                    return 0;
                }


                int
                f_10044_8825_8872(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 8825, 8872);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10044_8308_8315_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 8308, 8315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10044_9220_9241(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 9220, 9241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>
                f_10044_9173_9251(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 9173, 9251);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_10044_9151_9267(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>
                members, ref Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags)
                {
                    var return_v = GetNonTypeMemberNames(members, ref declFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 9151, 9267);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10044_9395_9430(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 9395, 9430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                f_10044_9317_9497(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                parent, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                children, System.Collections.Immutable.ImmutableHashSet<string>
                memberNames, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags)
                {
                    var return_v = this_param.CreateScriptClass(parent, children, memberNames, declFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 9317, 9497);
                    return return_v;
                }


                int
                f_10044_9282_9498(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 9282, 9498);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10044_9709_9750(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                node)
                {
                    var return_v = this_param.GetReference((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 9709, 9750);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10044_9779_9812(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 9779, 9812);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>
                f_10044_9852_9891(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                compilationUnit)
                {
                    var return_v = GetReferenceDirectives(compilationUnit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 9852, 9891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                f_10044_9522_9970(bool
                hasUsings, bool
                hasExternAliases, Microsoft.CodeAnalysis.SyntaxReference
                treeNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>
                referenceDirectives, bool
                hasAssemblyAttributes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration(hasUsings: hasUsings, hasExternAliases: hasExternAliases, treeNode: treeNode, children: children, referenceDirectives: referenceDirectives, hasAssemblyAttributes: hasAssemblyAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 9522, 9970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 7841, 9982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 7841, 9982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<ReferenceDirective> GetReferenceDirectives(CompilationUnitSyntax compilationUnit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 9994, 10834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 10130, 10319);

                IList<ReferenceDirectiveTriviaSyntax>
                directiveNodes = f_10044_10185_10318(compilationUnit, d => !d.File.ContainsDiagnostics && !string.IsNullOrEmpty(d.File.ValueText))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 10333, 10459) || true) && (f_10044_10337_10357(directiveNodes) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 10333, 10459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 10396, 10444);

                    return ImmutableArray<ReferenceDirective>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 10333, 10459);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 10475, 10559);

                var
                directives = f_10044_10492_10558(f_10044_10537_10557(directiveNodes))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 10573, 10770);
                    foreach (var directiveNode in f_10044_10603_10617_I(directiveNodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 10573, 10770);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 10651, 10755);

                        f_10044_10651_10754(directives, f_10044_10666_10753(directiveNode.File.ValueText, f_10044_10719_10752(directiveNode)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 10573, 10770);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 1, 198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 1, 198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 10784, 10823);

                return f_10044_10791_10822(directives);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 9994, 10834);

                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax>
                f_10044_10185_10318(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax, bool>?
                filter)
                {
                    var return_v = this_param.GetReferenceDirectives(filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 10185, 10318);
                    return return_v;
                }


                int
                f_10044_10337_10357(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 10337, 10357);
                    return return_v;
                }


                int
                f_10044_10537_10557(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 10537, 10557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ReferenceDirective>
                f_10044_10492_10558(int
                capacity)
                {
                    var return_v = ArrayBuilder<ReferenceDirective>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 10492, 10558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10044_10719_10752(Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 10719, 10752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReferenceDirective
                f_10044_10666_10753(string
                file, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.ReferenceDirective(file, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 10666, 10753);
                    return return_v;
                }


                int
                f_10044_10651_10754(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ReferenceDirective>
                this_param, Microsoft.CodeAnalysis.ReferenceDirective
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 10651, 10754);
                    return 0;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax>
                f_10044_10603_10617_I(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 10603, 10617);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>
                f_10044_10791_10822(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ReferenceDirective>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 10791, 10822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 9994, 10834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 9994, 10834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SingleNamespaceOrTypeDeclaration CreateScriptClass(
                    CompilationUnitSyntax parent,
                    ImmutableArray<SingleTypeDeclaration> children,
                    ImmutableHashSet<string> memberNames,
                    SingleTypeDeclaration.TypeDeclarationFlags declFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 10846, 12812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 11152, 11264);

                f_10044_11152_11263(f_10044_11165_11178(parent) == SyntaxKind.CompilationUnit && (DynAbs.Tracing.TraceSender.Expression_True(10044, 11165, 11262) && f_10044_11212_11236(f_10044_11212_11231(_syntaxTree)) != SourceCodeKind.Regular));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 11343, 11398);

                var
                parentReference = f_10044_11365_11397(_syntaxTree, parent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 11412, 11455);

                var
                fullName = f_10044_11427_11454(_scriptClassName, '.')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 11593, 12241);

                SingleNamespaceOrTypeDeclaration
                decl = f_10044_11633_12240(kind: (DynAbs.Tracing.TraceSender.Conditional_F1(10044, 11683, 11696) || ((_isSubmission && DynAbs.Tracing.TraceSender.Conditional_F2(10044, 11699, 11725)) || DynAbs.Tracing.TraceSender.Conditional_F3(10044, 11728, 11750))) ? DeclarationKind.Submission : DeclarationKind.Script, name: f_10044_11775_11790(fullName), arity: 0, modifiers: DeclarationModifiers.Internal | DeclarationModifiers.Partial | DeclarationModifiers.Sealed, declFlags: declFlags, syntaxReference: parentReference, nameLocation: f_10044_12060_12095(parentReference), memberNames: memberNames, children: children, diagnostics: ImmutableArray<Diagnostic>.Empty)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 12266, 12289);

                    for (int
        i = f_10044_12270_12285(fullName) - 2
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 12257, 12773) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 12299, 12302)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 12257, 12773))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 12257, 12773);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 12336, 12758);

                        decl = f_10044_12343_12757(name: fullName[i], hasUsings: false, hasExternAliases: false, syntaxReference: parentReference, nameLocation: f_10044_12593_12628(parentReference), children: f_10044_12661_12688(decl), diagnostics: ImmutableArray<Diagnostic>.Empty);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 1, 517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 1, 517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 12789, 12801);

                return decl;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 10846, 12812);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_11165_11178(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 11165, 11178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10044_11212_11231(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 11212, 11231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10044_11212_11236(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 11212, 11236);
                    return return_v;
                }


                int
                f_10044_11152_11263(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 11152, 11263);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10044_11365_11397(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                node)
                {
                    var return_v = this_param.GetReference((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 11365, 11397);
                    return return_v;
                }


                string[]
                f_10044_11427_11454(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 11427, 11454);
                    return return_v;
                }


                string
                f_10044_11775_11790(string[]
                source)
                {
                    var return_v = source.Last<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 11775, 11790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10044_12060_12095(Microsoft.CodeAnalysis.SyntaxReference
                syntaxRef)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(syntaxRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 12060, 12095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                f_10044_11633_12240(Microsoft.CodeAnalysis.CSharp.DeclarationKind
                kind, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags, Microsoft.CodeAnalysis.SyntaxReference
                syntaxReference, Microsoft.CodeAnalysis.SourceLocation
                nameLocation, System.Collections.Immutable.ImmutableHashSet<string>
                memberNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration(kind: kind, name: name, arity: arity, modifiers: modifiers, declFlags: declFlags, syntaxReference: syntaxReference, nameLocation: nameLocation, memberNames: memberNames, children: children, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 11633, 12240);
                    return return_v;
                }


                int
                f_10044_12270_12285(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 12270, 12285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10044_12593_12628(Microsoft.CodeAnalysis.SyntaxReference
                syntaxRef)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(syntaxRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 12593, 12628);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10044_12661_12688(Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 12661, 12688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                f_10044_12343_12757(string
                name, bool
                hasUsings, bool
                hasExternAliases, Microsoft.CodeAnalysis.SyntaxReference
                syntaxReference, Microsoft.CodeAnalysis.SourceLocation
                nameLocation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = SingleNamespaceDeclaration.Create(name: name, hasUsings: hasUsings, hasExternAliases: hasExternAliases, syntaxReference: syntaxReference, nameLocation: nameLocation, children: children, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 12343, 12757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 10846, 12812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 10846, 12812);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SingleNamespaceOrTypeDeclaration VisitCompilationUnit(CompilationUnitSyntax compilationUnit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 12824, 13747);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 12957, 13112) || true) && (f_10044_12961_12985(f_10044_12961_12980(_syntaxTree)) != SourceCodeKind.Regular)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 12957, 13112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 13045, 13097);

                    return f_10044_13052_13096(this, compilationUnit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 12957, 13112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 13128, 13288);

                var
                children = f_10044_13143_13287(this, compilationUnit, f_10044_13183_13206(compilationUnit), f_10044_13208_13286(((Syntax.InternalSyntax.CompilationUnitSyntax)(f_10044_13255_13276(compilationUnit)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 13304, 13736);

                return f_10044_13311_13735(hasUsings: compilationUnit.Usings.Any(), hasExternAliases: compilationUnit.Externs.Any(), treeNode: f_10044_13498_13539(_syntaxTree, compilationUnit), children: children, referenceDirectives: ImmutableArray<ReferenceDirective>.Empty, hasAssemblyAttributes: compilationUnit.AttributeLists.Any());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 12824, 13747);

                Microsoft.CodeAnalysis.ParseOptions
                f_10044_12961_12980(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 12961, 12980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10044_12961_12985(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 12961, 12985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                f_10044_13052_13096(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                compilationUnit)
                {
                    var return_v = this_param.CreateScriptRootDeclaration(compilationUnit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 13052, 13096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10044_13183_13206(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 13183, 13206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10044_13255_13276(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 13255, 13276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>
                f_10044_13208_13286(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 13208, 13286);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10044_13143_13287(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                node, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                members, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>
                internalMembers)
                {
                    var return_v = this_param.VisitNamespaceChildren((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, members, internalMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 13143, 13287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10044_13498_13539(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                node)
                {
                    var return_v = this_param.GetReference((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 13498, 13539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                f_10044_13311_13735(bool
                hasUsings, bool
                hasExternAliases, Microsoft.CodeAnalysis.SyntaxReference
                treeNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>
                referenceDirectives, bool
                hasAssemblyAttributes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration(hasUsings: hasUsings, hasExternAliases: hasExternAliases, treeNode: treeNode, children: children, referenceDirectives: referenceDirectives, hasAssemblyAttributes: hasAssemblyAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 13311, 13735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 12824, 13747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 12824, 13747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SingleNamespaceOrTypeDeclaration VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 13759, 16609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 13891, 13969);

                var
                children = f_10044_13906_13968(this, node, f_10044_13935_13947(node), f_10044_13949_13967(f_10044_13949_13959(node)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 13985, 14020);

                bool
                hasUsings = node.Usings.Any()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 14034, 14071);

                bool
                hasExterns = node.Externs.Any()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 14085, 14113);

                NameSyntax
                name = f_10044_14103_14112(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 14127, 14163);

                CSharpSyntaxNode
                currentNode = node
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 14177, 14204);

                QualifiedNameSyntax
                dotted
                = default(QualifiedNameSyntax);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 14218, 15049) || true) && ((dotted = name as QualifiedNameSyntax) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 14218, 15049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 14305, 14760);

                        var
                        ns = f_10044_14314_14759(name: f_10044_14376_14388(dotted).Identifier.ValueText, hasUsings: hasUsings, hasExternAliases: hasExterns, syntaxReference: f_10044_14543_14580(_syntaxTree, currentNode), nameLocation: f_10044_14617_14649(f_10044_14636_14648(dotted)), children: children, diagnostics: ImmutableArray<Diagnostic>.Empty)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 14780, 14813);

                        var
                        nsDeclaration = new[] { ns }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 14831, 14910);

                        children = f_10044_14842_14909(nsDeclaration);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 14928, 14961);

                        currentNode = name = f_10044_14949_14960(dotted);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 14979, 14997);

                        hasUsings = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 15015, 15034);

                        hasExterns = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 14218, 15049);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 14218, 15049);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 14218, 15049);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 15065, 15111);

                var
                diagnostics = f_10044_15083_15110()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 15125, 15338) || true) && (f_10044_15129_15155(f_10044_15145_15154(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 15125, 15338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 15245, 15323);

                    f_10044_15245_15322(                // We're not allowed to have generics.
                                    diagnostics, ErrorCode.ERR_UnexpectedGenericName, f_10044_15298_15321(f_10044_15298_15307(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 15125, 15338);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 15354, 15509) || true) && (f_10044_15358_15382(f_10044_15372_15381(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 15354, 15509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 15416, 15494);

                    f_10044_15416_15493(diagnostics, ErrorCode.ERR_UnexpectedAliasedName, f_10044_15469_15492(f_10044_15469_15478(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 15354, 15509);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 15525, 15700) || true) && (node.AttributeLists.Count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 15525, 15700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 15592, 15685);

                    f_10044_15592_15684(diagnostics, ErrorCode.ERR_BadModifiersOnNamespace, f_10044_15647_15683(f_10044_15647_15666(node)[0]));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 15525, 15700);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 15716, 15881) || true) && (node.Modifiers.Count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 15716, 15881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 15778, 15866);

                    f_10044_15778_15865(diagnostics, ErrorCode.ERR_BadModifiersOnNamespace, f_10044_15833_15847(node)[0].GetLocation());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 15716, 15881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 16169, 16598);

                return f_10044_16176_16597(name: f_10044_16234_16259(name).Identifier.ValueText, hasUsings: hasUsings, hasExternAliases: hasExterns, syntaxReference: f_10044_16402_16439(_syntaxTree, currentNode), nameLocation: f_10044_16472_16496(name), children: children, diagnostics: f_10044_16565_16596(diagnostics));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 13759, 16609);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10044_13935_13947(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 13935, 13947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NamespaceDeclarationSyntax
                f_10044_13949_13959(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 13949, 13959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>
                f_10044_13949_13967(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 13949, 13967);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10044_13906_13968(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                node, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                members, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>
                internalMembers)
                {
                    var return_v = this_param.VisitNamespaceChildren((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, members, internalMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 13906, 13968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10044_14103_14112(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 14103, 14112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10044_14376_14388(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 14376, 14388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10044_14543_14580(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetReference((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 14543, 14580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10044_14636_14648(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 14636, 14648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10044_14617_14649(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 14617, 14649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                f_10044_14314_14759(string
                name, bool
                hasUsings, bool
                hasExternAliases, Microsoft.CodeAnalysis.SyntaxReference
                syntaxReference, Microsoft.CodeAnalysis.SourceLocation
                nameLocation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = SingleNamespaceDeclaration.Create(name: name, hasUsings: hasUsings, hasExternAliases: hasExternAliases, syntaxReference: syntaxReference, nameLocation: nameLocation, children: children, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 14314, 14759);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10044_14842_14909(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 14842, 14909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10044_14949_14960(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 14949, 14960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10044_15083_15110()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 15083, 15110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10044_15145_15154(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 15145, 15154);
                    return return_v;
                }


                bool
                f_10044_15129_15155(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                name)
                {
                    var return_v = ContainsGeneric(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 15129, 15155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10044_15298_15307(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 15298, 15307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10044_15298_15321(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 15298, 15321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10044_15245_15322(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 15245, 15322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10044_15372_15381(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 15372, 15381);
                    return return_v;
                }


                bool
                f_10044_15358_15382(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                name)
                {
                    var return_v = ContainsAlias(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 15358, 15382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10044_15469_15478(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 15469, 15478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10044_15469_15492(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 15469, 15492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10044_15416_15493(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 15416, 15493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10044_15647_15666(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 15647, 15666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10044_15647_15683(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 15647, 15683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10044_15592_15684(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 15592, 15684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10044_15833_15847(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 15833, 15847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10044_15778_15865(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 15778, 15865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10044_16234_16259(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.GetUnqualifiedName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 16234, 16259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10044_16402_16439(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetReference((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 16402, 16439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10044_16472_16496(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 16472, 16496);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10044_16565_16596(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 16565, 16596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                f_10044_16176_16597(string
                name, bool
                hasUsings, bool
                hasExternAliases, Microsoft.CodeAnalysis.SyntaxReference
                syntaxReference, Microsoft.CodeAnalysis.SourceLocation
                nameLocation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = SingleNamespaceDeclaration.Create(name: name, hasUsings: hasUsings, hasExternAliases: hasExternAliases, syntaxReference: syntaxReference, nameLocation: nameLocation, children: children, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 16176, 16597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 13759, 16609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 13759, 16609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ContainsAlias(NameSyntax name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 16621, 17133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 16696, 17093);

                switch (f_10044_16704_16715(name))
                {

                    case SyntaxKind.GenericName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 16696, 17093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 16799, 16812);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 16696, 17093);

                    case SyntaxKind.AliasQualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 16696, 17093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 16887, 16899);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 16696, 17093);

                    case SyntaxKind.QualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 16696, 17093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 16969, 17015);

                        var
                        qualifiedName = (QualifiedNameSyntax)name
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 17037, 17078);

                        return f_10044_17044_17077(f_10044_17058_17076(qualifiedName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 16696, 17093);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 17109, 17122);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 16621, 17133);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_16704_16715(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 16704, 16715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10044_17058_17076(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 17058, 17076);
                    return return_v;
                }


                bool
                f_10044_17044_17077(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                name)
                {
                    var return_v = ContainsAlias(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 17044, 17077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 16621, 17133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 16621, 17133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ContainsGeneric(NameSyntax name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 17145, 17750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 17222, 17710);

                switch (f_10044_17230_17241(name))
                {

                    case SyntaxKind.GenericName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 17222, 17710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 17325, 17337);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 17222, 17710);

                    case SyntaxKind.AliasQualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 17222, 17710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 17412, 17474);

                        return f_10044_17419_17473(f_10044_17435_17472(((AliasQualifiedNameSyntax)name)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 17222, 17710);

                    case SyntaxKind.QualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 17222, 17710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 17544, 17590);

                        var
                        qualifiedName = (QualifiedNameSyntax)name
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 17612, 17695);

                        return f_10044_17619_17654(f_10044_17635_17653(qualifiedName)) || (DynAbs.Tracing.TraceSender.Expression_False(10044, 17619, 17694) || f_10044_17658_17694(f_10044_17674_17693(qualifiedName)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 17222, 17710);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 17726, 17739);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 17145, 17750);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_17230_17241(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 17230, 17241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10044_17435_17472(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 17435, 17472);
                    return return_v;
                }


                bool
                f_10044_17419_17473(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                name)
                {
                    var return_v = ContainsGeneric((Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 17419, 17473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10044_17635_17653(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 17635, 17653);
                    return return_v;
                }


                bool
                f_10044_17619_17654(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                name)
                {
                    var return_v = ContainsGeneric(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 17619, 17654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10044_17674_17693(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 17674, 17693);
                    return return_v;
                }


                bool
                f_10044_17658_17694(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                name)
                {
                    var return_v = ContainsGeneric((Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 17658, 17694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 17145, 17750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 17145, 17750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SingleNamespaceOrTypeDeclaration VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 17762, 17954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 17886, 17943);

                return f_10044_17893_17942(this, node, DeclarationKind.Class);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 17762, 17954);

                Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                f_10044_17893_17942(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax
                node, Microsoft.CodeAnalysis.CSharp.DeclarationKind
                kind)
                {
                    var return_v = this_param.VisitTypeDeclaration((Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)node, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 17893, 17942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 17762, 17954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 17762, 17954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SingleNamespaceOrTypeDeclaration VisitStructDeclaration(StructDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 17966, 18161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 18092, 18150);

                return f_10044_18099_18149(this, node, DeclarationKind.Struct);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 17966, 18161);

                Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                f_10044_18099_18149(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax
                node, Microsoft.CodeAnalysis.CSharp.DeclarationKind
                kind)
                {
                    var return_v = this_param.VisitTypeDeclaration((Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)node, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 18099, 18149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 17966, 18161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 17966, 18161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SingleNamespaceOrTypeDeclaration VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 18173, 18377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 18305, 18366);

                return f_10044_18312_18365(this, node, DeclarationKind.Interface);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 18173, 18377);

                Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                f_10044_18312_18365(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax
                node, Microsoft.CodeAnalysis.CSharp.DeclarationKind
                kind)
                {
                    var return_v = this_param.VisitTypeDeclaration((Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)node, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 18312, 18365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 18173, 18377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 18173, 18377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SingleNamespaceOrTypeDeclaration VisitRecordDeclaration(RecordDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 18504, 18557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 18507, 18557);
                return f_10044_18507_18557(this, node, DeclarationKind.Record); DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 18504, 18557);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 18504, 18557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 18504, 18557);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
            f_10044_18507_18557(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
            node, Microsoft.CodeAnalysis.CSharp.DeclarationKind
            kind)
            {
                var return_v = this_param.VisitTypeDeclaration((Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)node, kind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 18507, 18557);
                return return_v;
            }

        }

        private SingleNamespaceOrTypeDeclaration VisitTypeDeclaration(TypeDeclarationSyntax node, DeclarationKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 18570, 20531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 18706, 18933);

                SingleTypeDeclaration.TypeDeclarationFlags
                declFlags = (DynAbs.Tracing.TraceSender.Conditional_F1(10044, 18761, 18786) || ((node.AttributeLists.Any() && DynAbs.Tracing.TraceSender.Conditional_F2(10044, 18806, 18865)) || DynAbs.Tracing.TraceSender.Conditional_F3(10044, 18885, 18932))) ? SingleTypeDeclaration.TypeDeclarationFlags.HasAnyAttributes : SingleTypeDeclaration.TypeDeclarationFlags.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 18949, 19099) || true) && (f_10044_18953_18966(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 18949, 19099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 19008, 19084);

                    declFlags |= SingleTypeDeclaration.TypeDeclarationFlags.HasBaseDeclarations;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 18949, 19099);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 19115, 19161);

                var
                diagnostics = f_10044_19133_19160()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 19175, 19315) || true) && (f_10044_19179_19189(node) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 19175, 19315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 19228, 19300);

                    f_10044_19228_19299(f_10044_19263_19285(node), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 19175, 19315);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 19331, 19508);

                var
                memberNames = f_10044_19349_19507(f_10044_19371_19438(((Syntax.InternalSyntax.TypeDeclarationSyntax)(f_10044_19418_19428(node)))), ref declFlags)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 19600, 19889) || true) && (((declFlags & SingleTypeDeclaration.TypeDeclarationFlags.HasAnyNontypeMembers) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10044, 19604, 19763) && node is RecordDeclarationSyntax { ParameterList: { } }))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 19600, 19889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 19797, 19874);

                    declFlags |= SingleTypeDeclaration.TypeDeclarationFlags.HasAnyNontypeMembers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 19600, 19889);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 19905, 19985);

                var
                modifiers = node.Modifiers.ToDeclarationModifiers(diagnostics: diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 20001, 20520);

                return f_10044_20008_20519(kind: kind, name: node.Identifier.ValueText, modifiers: modifiers, arity: f_10044_20177_20187(node), declFlags: declFlags, syntaxReference: f_10044_20262_20292(_syntaxTree, node), nameLocation: f_10044_20325_20360(f_10044_20344_20359(node)), memberNames: memberNames, children: f_10044_20432_20455(this, node), diagnostics: f_10044_20487_20518(diagnostics));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 18570, 20531);

                Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax?
                f_10044_18953_18966(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.BaseList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 18953, 18966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10044_19133_19160()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 19133, 19160);
                    return return_v;
                }


                int
                f_10044_19179_19189(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 19179, 19189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10044_19263_19285(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ConstraintClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 19263, 19285);
                    return return_v;
                }


                int
                f_10044_19228_19299(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                constraintClauses, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    Symbol.ReportErrorIfHasConstraints(constraintClauses, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 19228, 19299);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10044_19418_19428(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 19418, 19428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>
                f_10044_19371_19438(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 19371, 19438);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_10044_19349_19507(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>
                members, ref Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags)
                {
                    var return_v = GetNonTypeMemberNames(members, ref declFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 19349, 19507);
                    return return_v;
                }


                int
                f_10044_20177_20187(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 20177, 20187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10044_20262_20292(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetReference((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 20262, 20292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10044_20344_20359(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 20344, 20359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10044_20325_20360(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 20325, 20360);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10044_20432_20455(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                node)
                {
                    var return_v = this_param.VisitTypeChildren(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 20432, 20455);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10044_20487_20518(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 20487, 20518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                f_10044_20008_20519(Microsoft.CodeAnalysis.CSharp.DeclarationKind
                kind, string
                name, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, int
                arity, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags, Microsoft.CodeAnalysis.SyntaxReference
                syntaxReference, Microsoft.CodeAnalysis.SourceLocation
                nameLocation, System.Collections.Immutable.ImmutableHashSet<string>
                memberNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration(kind: kind, name: name, modifiers: modifiers, arity: arity, declFlags: declFlags, syntaxReference: syntaxReference, nameLocation: nameLocation, memberNames: memberNames, children: children, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 20008, 20519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 18570, 20531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 18570, 20531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<SingleTypeDeclaration> VisitTypeChildren(TypeDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 20543, 21205);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 20659, 20786) || true) && (node.Members.Count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 20659, 20786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 20720, 20771);

                    return ImmutableArray<SingleTypeDeclaration>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 20659, 20786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 20802, 20867);

                var
                children = f_10044_20817_20866()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 20881, 21141);
                    foreach (var member in f_10044_20904_20916_I(f_10044_20904_20916(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 20881, 21141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 20950, 21004);

                        var
                        typeDecl = f_10044_20965_20978(this, member) as SingleTypeDeclaration
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 21022, 21126) || true) && (typeDecl != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 21022, 21126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 21084, 21107);

                            f_10044_21084_21106(children, typeDecl);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 21022, 21126);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 20881, 21141);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 1, 261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 1, 261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 21157, 21194);

                return f_10044_21164_21193(children);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 20543, 21205);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10044_20817_20866()
                {
                    var return_v = ArrayBuilder<SingleTypeDeclaration>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 20817, 20866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10044_20904_20916(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 20904, 20916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration?
                f_10044_20965_20978(Microsoft.CodeAnalysis.CSharp.DeclarationTreeBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 20965, 20978);
                    return return_v;
                }


                int
                f_10044_21084_21106(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 21084, 21106);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10044_20904_20916_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 20904, 20916);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10044_21164_21193(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 21164, 21193);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 20543, 21205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 20543, 21205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SingleNamespaceOrTypeDeclaration VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 21217, 22545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 21347, 21535);

                var
                declFlags = (DynAbs.Tracing.TraceSender.Conditional_F1(10044, 21363, 21388) || ((node.AttributeLists.Any() && DynAbs.Tracing.TraceSender.Conditional_F2(10044, 21408, 21467)) || DynAbs.Tracing.TraceSender.Conditional_F3(10044, 21487, 21534))) ? SingleTypeDeclaration.TypeDeclarationFlags.HasAnyAttributes
                : SingleTypeDeclaration.TypeDeclarationFlags.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 21551, 21597);

                var
                diagnostics = f_10044_21569_21596()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 21611, 21751) || true) && (f_10044_21615_21625(node) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 21611, 21751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 21664, 21736);

                    f_10044_21664_21735(f_10044_21699_21721(node), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 21611, 21751);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 21767, 21844);

                declFlags |= SingleTypeDeclaration.TypeDeclarationFlags.HasAnyNontypeMembers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 21860, 21940);

                var
                modifiers = node.Modifiers.ToDeclarationModifiers(diagnostics: diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 21956, 22534);

                return f_10044_21963_22533(kind: DeclarationKind.Delegate, name: node.Identifier.ValueText, modifiers: modifiers, declFlags: declFlags, arity: f_10044_22191_22201(node), syntaxReference: f_10044_22237_22267(_syntaxTree, node), nameLocation: f_10044_22300_22335(f_10044_22319_22334(node)), memberNames: ImmutableHashSet<string>.Empty, children: ImmutableArray<SingleTypeDeclaration>.Empty, diagnostics: f_10044_22501_22532(diagnostics));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 21217, 22545);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10044_21569_21596()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 21569, 21596);
                    return return_v;
                }


                int
                f_10044_21615_21625(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 21615, 21625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10044_21699_21721(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ConstraintClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 21699, 21721);
                    return return_v;
                }


                int
                f_10044_21664_21735(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                constraintClauses, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    Symbol.ReportErrorIfHasConstraints(constraintClauses, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 21664, 21735);
                    return 0;
                }


                int
                f_10044_22191_22201(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 22191, 22201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10044_22237_22267(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetReference((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 22237, 22267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10044_22319_22334(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 22319, 22334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10044_22300_22335(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 22300, 22335);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10044_22501_22532(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 22501, 22532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                f_10044_21963_22533(Microsoft.CodeAnalysis.CSharp.DeclarationKind
                kind, string
                name, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags, int
                arity, Microsoft.CodeAnalysis.SyntaxReference
                syntaxReference, Microsoft.CodeAnalysis.SourceLocation
                nameLocation, System.Collections.Immutable.ImmutableHashSet<string>
                memberNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration(kind: kind, name: name, modifiers: modifiers, declFlags: declFlags, arity: arity, syntaxReference: syntaxReference, nameLocation: nameLocation, memberNames: memberNames, children: children, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 21963, 22533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 21217, 22545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 21217, 22545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SingleNamespaceOrTypeDeclaration VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10044, 22557, 23942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 22679, 22706);

                var
                members = f_10044_22693_22705(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 22722, 22949);

                SingleTypeDeclaration.TypeDeclarationFlags
                declFlags = (DynAbs.Tracing.TraceSender.Conditional_F1(10044, 22777, 22802) || ((node.AttributeLists.Any() && DynAbs.Tracing.TraceSender.Conditional_F2(10044, 22822, 22881)) || DynAbs.Tracing.TraceSender.Conditional_F3(10044, 22901, 22948))) ? SingleTypeDeclaration.TypeDeclarationFlags.HasAnyAttributes : SingleTypeDeclaration.TypeDeclarationFlags.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 22965, 23115) || true) && (f_10044_22969_22982(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 22965, 23115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 23024, 23100);

                    declFlags |= SingleTypeDeclaration.TypeDeclarationFlags.HasBaseDeclarations;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 22965, 23115);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 23131, 23213);

                ImmutableHashSet<string>
                memberNames = f_10044_23170_23212(members, ref declFlags)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 23229, 23275);

                var
                diagnostics = f_10044_23247_23274()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 23289, 23369);

                var
                modifiers = node.Modifiers.ToDeclarationModifiers(diagnostics: diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 23385, 23931);

                return f_10044_23392_23930(kind: DeclarationKind.Enum, name: node.Identifier.ValueText, arity: 0, modifiers: modifiers, declFlags: declFlags, syntaxReference: f_10044_23653_23683(_syntaxTree, node), nameLocation: f_10044_23716_23751(f_10044_23735_23750(node)), memberNames: memberNames, children: ImmutableArray<SingleTypeDeclaration>.Empty, diagnostics: f_10044_23898_23929(diagnostics));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10044, 22557, 23942);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax>
                f_10044_22693_22705(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 22693, 22705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax?
                f_10044_22969_22982(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.BaseList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 22969, 22982);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_10044_23170_23212(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax>
                members, ref Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags)
                {
                    var return_v = GetEnumMemberNames(members, ref declFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 23170, 23212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10044_23247_23274()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 23247, 23274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10044_23653_23683(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetReference((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 23653, 23683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10044_23735_23750(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 23735, 23750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10044_23716_23751(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 23716, 23751);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10044_23898_23929(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 23898, 23929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                f_10044_23392_23930(Microsoft.CodeAnalysis.CSharp.DeclarationKind
                kind, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationFlags
                declFlags, Microsoft.CodeAnalysis.SyntaxReference
                syntaxReference, Microsoft.CodeAnalysis.SourceLocation
                nameLocation, System.Collections.Immutable.ImmutableHashSet<string>
                memberNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration(kind: kind, name: name, arity: arity, modifiers: modifiers, declFlags: declFlags, syntaxReference: syntaxReference, nameLocation: nameLocation, memberNames: memberNames, children: children, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 23392, 23930);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 22557, 23942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 22557, 23942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ObjectPool<ImmutableHashSet<string>.Builder> s_memberNameBuilderPool;

        private static ImmutableHashSet<string> ToImmutableAndFree(ImmutableHashSet<string>.Builder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 24171, 24452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 24296, 24331);

                var
                result = f_10044_24309_24330(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 24345, 24361);

                f_10044_24345_24360(builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 24375, 24413);

                f_10044_24375_24412(s_memberNameBuilderPool, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 24427, 24441);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 24171, 24452);

                System.Collections.Immutable.ImmutableHashSet<string>
                f_10044_24309_24330(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 24309, 24330);
                    return return_v;
                }


                int
                f_10044_24345_24360(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 24345, 24360);
                    return 0;
                }


                int
                f_10044_24375_24412(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableHashSet<string>.Builder>
                this_param, System.Collections.Immutable.ImmutableHashSet<string>.Builder
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 24375, 24412);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 24171, 24452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 24171, 24452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableHashSet<string> GetEnumMemberNames(SeparatedSyntaxList<EnumMemberDeclarationSyntax> members, ref SingleTypeDeclaration.TypeDeclarationFlags declFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 24464, 25522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 24663, 24687);

                var
                cnt = members.Count
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 24703, 24763);

                var
                memberNamesBuilder = f_10044_24728_24762(s_memberNameBuilderPool)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 24777, 24915) || true) && (cnt != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 24777, 24915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 24823, 24900);

                    declFlags |= SingleTypeDeclaration.TypeDeclarationFlags.HasAnyNontypeMembers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 24777, 24915);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 24931, 24967);

                bool
                anyMemberHasAttributes = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 24981, 25279);
                    foreach (var member in f_10044_25004_25011_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 24981, 25279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 25045, 25097);

                        f_10044_25045_25096(memberNamesBuilder, member.Identifier.ValueText);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 25115, 25264) || true) && (!anyMemberHasAttributes && (DynAbs.Tracing.TraceSender.Expression_True(10044, 25119, 25173) && member.AttributeLists.Any()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 25115, 25264);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 25215, 25245);

                            anyMemberHasAttributes = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 25115, 25264);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 24981, 25279);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 1, 299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 1, 299);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 25295, 25449) || true) && (anyMemberHasAttributes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 25295, 25449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 25355, 25434);

                    declFlags |= SingleTypeDeclaration.TypeDeclarationFlags.AnyMemberHasAttributes;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 25295, 25449);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 25465, 25511);

                return f_10044_25472_25510(memberNamesBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 24464, 25522);

                System.Collections.Immutable.ImmutableHashSet<string>.Builder
                f_10044_24728_24762(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableHashSet<string>.Builder>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 24728, 24762);
                    return return_v;
                }


                bool
                f_10044_25045_25096(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 25045, 25096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax>
                f_10044_25004_25011_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 25004, 25011);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_10044_25472_25510(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                builder)
                {
                    var return_v = ToImmutableAndFree(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 25472, 25510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 24464, 25522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 24464, 25522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableHashSet<string> GetNonTypeMemberNames(
                    CoreInternalSyntax.SyntaxList<Syntax.InternalSyntax.MemberDeclarationSyntax> members, ref SingleTypeDeclaration.TypeDeclarationFlags declFlags, bool skipGlobalStatements = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 25534, 27427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 25813, 25854);

                bool
                anyMethodHadExtensionSyntax = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 25868, 25904);

                bool
                anyMemberHasAttributes = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 25918, 25949);

                bool
                anyNonTypeMembers = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 25965, 26024);

                var
                memberNameBuilder = f_10044_25989_26023(s_memberNameBuilderPool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 26040, 26836);
                    foreach (var member in f_10044_26063_26070_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 26040, 26836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 26104, 26198);

                        f_10044_26104_26197(member, memberNameBuilder, ref anyNonTypeMembers, skipGlobalStatements);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 26472, 26647) || true) && (!anyMethodHadExtensionSyntax && (DynAbs.Tracing.TraceSender.Expression_True(10044, 26476, 26551) && f_10044_26508_26551(member)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 26472, 26647);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 26593, 26628);

                            anyMethodHadExtensionSyntax = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 26472, 26647);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 26667, 26821) || true) && (!anyMemberHasAttributes && (DynAbs.Tracing.TraceSender.Expression_True(10044, 26671, 26730) && f_10044_26698_26730(member)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 26667, 26821);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 26772, 26802);

                            anyMemberHasAttributes = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 26667, 26821);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 26040, 26836);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 1, 797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 1, 797);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 26852, 27022) || true) && (anyMethodHadExtensionSyntax)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 26852, 27022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 26917, 27007);

                    declFlags |= SingleTypeDeclaration.TypeDeclarationFlags.AnyMemberHasExtensionMethodSyntax;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 26852, 27022);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27038, 27192) || true) && (anyMemberHasAttributes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 27038, 27192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27098, 27177);

                    declFlags |= SingleTypeDeclaration.TypeDeclarationFlags.AnyMemberHasAttributes;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 27038, 27192);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27208, 27355) || true) && (anyNonTypeMembers)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 27208, 27355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27263, 27340);

                    declFlags |= SingleTypeDeclaration.TypeDeclarationFlags.HasAnyNontypeMembers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 27208, 27355);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27371, 27416);

                return f_10044_27378_27415(memberNameBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 25534, 27427);

                System.Collections.Immutable.ImmutableHashSet<string>.Builder
                f_10044_25989_26023(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableHashSet<string>.Builder>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 25989, 26023);
                    return return_v;
                }


                int
                f_10044_26104_26197(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax
                member, System.Collections.Immutable.ImmutableHashSet<string>.Builder
                set, ref bool
                anyNonTypeMembers, bool
                skipGlobalStatements)
                {
                    AddNonTypeMemberNames((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)member, set, ref anyNonTypeMembers, skipGlobalStatements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 26104, 26197);
                    return 0;
                }


                bool
                f_10044_26508_26551(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax
                member)
                {
                    var return_v = CheckMethodMemberForExtensionSyntax((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 26508, 26551);
                    return return_v;
                }


                bool
                f_10044_26698_26730(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax
                member)
                {
                    var return_v = CheckMemberForAttributes((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 26698, 26730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>
                f_10044_26063_26070_I(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 26063, 26070);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_10044_27378_27415(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                builder)
                {
                    var return_v = ToImmutableAndFree(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 27378, 27415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 25534, 27427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 25534, 27427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckMethodMemberForExtensionSyntax(Syntax.InternalSyntax.CSharpSyntaxNode member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 27439, 28439);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27566, 28401) || true) && (f_10044_27570_27581(member) == SyntaxKind.MethodDeclaration)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 27566, 28401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27647, 27718);

                    var
                    methodDecl = (Syntax.InternalSyntax.MethodDeclarationSyntax)member
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27738, 27779);

                    var
                    paramList = methodDecl.parameterList
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27797, 28386) || true) && (paramList != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 27797, 28386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27860, 27898);

                        var
                        parameters = f_10044_27877_27897(paramList)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27922, 28367) || true) && (parameters.Count != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 27922, 28367);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 27997, 28032);

                            var
                            firstParameter = parameters[0]
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 28058, 28344);
                                foreach (var modifier in f_10044_28083_28107_I(f_10044_28083_28107(firstParameter)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 28058, 28344);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 28165, 28317) || true) && (f_10044_28169_28182(modifier) == SyntaxKind.ThisKeyword)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 28165, 28317);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 28274, 28286);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 28165, 28317);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 28058, 28344);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 1, 287);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 1, 287);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 27922, 28367);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 27797, 28386);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 27566, 28401);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 28415, 28428);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 27439, 28439);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_27570_27581(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 27570, 27581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParameterSyntax>
                f_10044_27877_27897(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 27877, 27897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10044_28083_28107(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParameterSyntax?
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 28083, 28107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_28169_28182(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 28169, 28182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10044_28083_28107_I(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 28083, 28107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 27439, 28439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 27439, 28439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckMemberForAttributes(Syntax.InternalSyntax.CSharpSyntaxNode member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 28451, 30679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 28567, 30639);

                switch (f_10044_28575_28586(member))
                {

                    case SyntaxKind.CompilationUnit:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 28567, 30639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 28674, 28758);

                        return (f_10044_28682_28750(((Syntax.InternalSyntax.CompilationUnitSyntax)member))).Any();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 28567, 30639);

                    case SyntaxKind.ClassDeclaration:
                    case SyntaxKind.StructDeclaration:
                    case SyntaxKind.InterfaceDeclaration:
                    case SyntaxKind.EnumDeclaration:
                    case SyntaxKind.RecordDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 28567, 30639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 29042, 29130);

                        return (f_10044_29050_29122(((Syntax.InternalSyntax.BaseTypeDeclarationSyntax)member))).Any();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 28567, 30639);

                    case SyntaxKind.DelegateDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 28567, 30639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 29208, 29296);

                        return (f_10044_29216_29288(((Syntax.InternalSyntax.DelegateDeclarationSyntax)member))).Any();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 28567, 30639);

                    case SyntaxKind.FieldDeclaration:
                    case SyntaxKind.EventFieldDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 28567, 30639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 29427, 29516);

                        return (f_10044_29435_29508(((Syntax.InternalSyntax.BaseFieldDeclarationSyntax)member))).Any();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 28567, 30639);

                    case SyntaxKind.MethodDeclaration:
                    case SyntaxKind.OperatorDeclaration:
                    case SyntaxKind.ConversionOperatorDeclaration:
                    case SyntaxKind.ConstructorDeclaration:
                    case SyntaxKind.DestructorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 28567, 30639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 29823, 29913);

                        return (f_10044_29831_29905(((Syntax.InternalSyntax.BaseMethodDeclarationSyntax)member))).Any();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 28567, 30639);

                    case SyntaxKind.PropertyDeclaration:
                    case SyntaxKind.EventDeclaration:
                    case SyntaxKind.IndexerDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 28567, 30639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 30095, 30170);

                        var
                        baseProp = (Syntax.InternalSyntax.BasePropertyDeclarationSyntax)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 30192, 30243);

                        bool
                        hasAttributes = baseProp.AttributeLists.Any()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 30267, 30579) || true) && (!hasAttributes && (DynAbs.Tracing.TraceSender.Expression_True(10044, 30271, 30318) && f_10044_30289_30310(baseProp) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30267, 30579);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 30368, 30556);
                                foreach (var accessor in f_10044_30393_30424_I(f_10044_30393_30424(f_10044_30393_30414(baseProp))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30368, 30556);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 30482, 30529);

                                    hasAttributes |= accessor.AttributeLists.Any();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30368, 30556);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 1, 189);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 1, 189);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30267, 30579);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 30603, 30624);

                        return hasAttributes;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 28567, 30639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 30655, 30668);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 28451, 30679);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_28575_28586(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 28575, 28586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax>
                f_10044_28682_28750(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 28682, 28750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax>
                f_10044_29050_29122(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BaseTypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 29050, 29122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax>
                f_10044_29216_29288(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 29216, 29288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax>
                f_10044_29435_29508(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BaseFieldDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 29435, 29508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax>
                f_10044_29831_29905(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 29831, 29905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AccessorListSyntax?
                f_10044_30289_30310(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BasePropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AccessorList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 30289, 30310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AccessorListSyntax
                f_10044_30393_30414(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BasePropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AccessorList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 30393, 30414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AccessorDeclarationSyntax>
                f_10044_30393_30424(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AccessorListSyntax
                this_param)
                {
                    var return_v = this_param.Accessors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 30393, 30424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AccessorDeclarationSyntax>
                f_10044_30393_30424_I(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AccessorDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 30393, 30424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 28451, 30679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 28451, 30679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddNonTypeMemberNames(
                    Syntax.InternalSyntax.CSharpSyntaxNode member, ImmutableHashSet<string>.Builder set, ref bool anyNonTypeMembers, bool skipGlobalStatements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10044, 30691, 35806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 30911, 35795);

                switch (f_10044_30919_30930(member))
                {

                    case SyntaxKind.FieldDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30911, 35795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 31019, 31044);

                        anyNonTypeMembers = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 31066, 31290);

                        CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Syntax.InternalSyntax.VariableDeclaratorSyntax>
                        fieldDeclarators =
                        f_10044_31213_31289(f_10044_31213_31279(((Syntax.InternalSyntax.FieldDeclarationSyntax)member)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 31312, 31361);

                        int
                        numFieldDeclarators = fieldDeclarators.Count
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 31392, 31397);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 31383, 31550) || true) && (i < numFieldDeclarators)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 31424, 31427)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 31383, 31550))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 31383, 31550);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 31477, 31527);

                                f_10044_31477_31526(set, f_10044_31485_31525(f_10044_31485_31515(fieldDeclarators[i])));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 1, 168);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 1, 168);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10044, 31572, 31578);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30911, 35795);

                    case SyntaxKind.EventFieldDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30911, 35795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 31658, 31683);

                        anyNonTypeMembers = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 31705, 31918);

                        CoreInternalSyntax.SeparatedSyntaxList<Syntax.InternalSyntax.VariableDeclaratorSyntax>
                        eventDeclarators =
                        f_10044_31836_31917(f_10044_31836_31907(((Syntax.InternalSyntax.EventFieldDeclarationSyntax)member)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 31940, 31989);

                        int
                        numEventDeclarators = eventDeclarators.Count
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 32020, 32025);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 32011, 32178) || true) && (i < numEventDeclarators)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 32052, 32055)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 32011, 32178))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 32011, 32178);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 32105, 32155);

                                f_10044_32105_32154(set, f_10044_32113_32153(f_10044_32113_32143(eventDeclarators[i])));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10044, 1, 168);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10044, 1, 168);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10044, 32200, 32206);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30911, 35795);

                    case SyntaxKind.MethodDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30911, 35795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 32282, 32307);

                        anyNonTypeMembers = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 32701, 32772);

                        var
                        methodDecl = (Syntax.InternalSyntax.MethodDeclarationSyntax)member
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 32794, 32957) || true) && (f_10044_32798_32835(methodDecl) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 32794, 32957);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 32893, 32934);

                            f_10044_32893_32933(set, f_10044_32901_32932(f_10044_32901_32922(methodDecl)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 32794, 32957);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10044, 32979, 32985);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30911, 35795);

                    case SyntaxKind.PropertyDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30911, 35795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 33063, 33088);

                        anyNonTypeMembers = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 33192, 33267);

                        var
                        propertyDecl = (Syntax.InternalSyntax.PropertyDeclarationSyntax)member
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 33289, 33456) || true) && (f_10044_33293_33332(propertyDecl) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 33289, 33456);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 33390, 33433);

                            f_10044_33390_33432(set, f_10044_33398_33431(f_10044_33398_33421(propertyDecl)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 33289, 33456);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10044, 33478, 33484);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30911, 35795);

                    case SyntaxKind.EventDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30911, 35795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 33559, 33584);

                        anyNonTypeMembers = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 33688, 33757);

                        var
                        eventDecl = (Syntax.InternalSyntax.EventDeclarationSyntax)member
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 33779, 33940) || true) && (f_10044_33783_33819(eventDecl) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 33779, 33940);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 33877, 33917);

                            f_10044_33877_33916(set, f_10044_33885_33915(f_10044_33885_33905(eventDecl)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 33779, 33940);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10044, 33962, 33968);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30911, 35795);

                    case SyntaxKind.ConstructorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30911, 35795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 34049, 34074);

                        anyNonTypeMembers = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 34096, 34353);

                        f_10044_34096_34352(set, (DynAbs.Tracing.TraceSender.Conditional_F1(10044, 34104, 34209) || ((((Syntax.InternalSyntax.ConstructorDeclarationSyntax)member).Modifiers.Any((int)SyntaxKind.StaticKeyword) && DynAbs.Tracing.TraceSender.Conditional_F2(10044, 34237, 34279)) || DynAbs.Tracing.TraceSender.Conditional_F3(10044, 34307, 34351))) ? WellKnownMemberNames.StaticConstructorName
                        : WellKnownMemberNames.InstanceConstructorName);
                        DynAbs.Tracing.TraceSender.TraceBreak(10044, 34375, 34381);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30911, 35795);

                    case SyntaxKind.DestructorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30911, 35795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 34461, 34486);

                        anyNonTypeMembers = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 34508, 34553);

                        f_10044_34508_34552(set, WellKnownMemberNames.DestructorName);
                        DynAbs.Tracing.TraceSender.TraceBreak(10044, 34575, 34581);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30911, 35795);

                    case SyntaxKind.IndexerDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30911, 35795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 34658, 34683);

                        anyNonTypeMembers = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 34705, 34743);

                        f_10044_34705_34742(set, WellKnownMemberNames.Indexer);
                        DynAbs.Tracing.TraceSender.TraceBreak(10044, 34765, 34771);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30911, 35795);

                    case SyntaxKind.OperatorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30911, 35795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 34849, 34874);

                        anyNonTypeMembers = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 34896, 34965);

                        var
                        opDecl = (Syntax.InternalSyntax.OperatorDeclarationSyntax)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 34987, 35048);

                        var
                        name = f_10044_34998_35047(opDecl)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 35070, 35084);

                        f_10044_35070_35083(set, name);
                        DynAbs.Tracing.TraceSender.TraceBreak(10044, 35106, 35112);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30911, 35795);

                    case SyntaxKind.ConversionOperatorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30911, 35795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 35200, 35225);

                        anyNonTypeMembers = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 35247, 35527);

                        f_10044_35247_35526(set, (DynAbs.Tracing.TraceSender.Conditional_F1(10044, 35255, 35383) || ((f_10044_35255_35353(f_10044_35255_35348(((Syntax.InternalSyntax.ConversionOperatorDeclarationSyntax)member))) == SyntaxKind.ImplicitKeyword
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10044, 35411, 35454)) || DynAbs.Tracing.TraceSender.Conditional_F3(10044, 35482, 35525))) ? WellKnownMemberNames.ImplicitConversionName
                        : WellKnownMemberNames.ExplicitConversionName);
                        DynAbs.Tracing.TraceSender.TraceBreak(10044, 35549, 35555);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30911, 35795);

                    case SyntaxKind.GlobalStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 30911, 35795);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 35629, 35752) || true) && (!skipGlobalStatements)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10044, 35629, 35752);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 35704, 35729);

                            anyNonTypeMembers = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 35629, 35752);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10044, 35774, 35780);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10044, 30911, 35795);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10044, 30691, 35806);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_30919_30930(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 30919, 30930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDeclarationSyntax
                f_10044_31213_31279(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.FieldDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 31213, 31279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDeclaratorSyntax>
                f_10044_31213_31289(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 31213, 31289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10044_31485_31515(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDeclaratorSyntax?
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 31485, 31515);
                    return return_v;
                }


                string
                f_10044_31485_31525(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 31485, 31525);
                    return return_v;
                }


                bool
                f_10044_31477_31526(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 31477, 31526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDeclarationSyntax
                f_10044_31836_31907(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.EventFieldDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 31836, 31907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDeclaratorSyntax>
                f_10044_31836_31917(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 31836, 31917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10044_32113_32143(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.VariableDeclaratorSyntax?
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 32113, 32143);
                    return return_v;
                }


                string
                f_10044_32113_32153(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 32113, 32153);
                    return return_v;
                }


                bool
                f_10044_32105_32154(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 32105, 32154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExplicitInterfaceSpecifierSyntax?
                f_10044_32798_32835(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 32798, 32835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10044_32901_32922(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 32901, 32922);
                    return return_v;
                }


                string
                f_10044_32901_32932(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 32901, 32932);
                    return return_v;
                }


                bool
                f_10044_32893_32933(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 32893, 32933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExplicitInterfaceSpecifierSyntax?
                f_10044_33293_33332(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 33293, 33332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10044_33398_33421(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 33398, 33421);
                    return return_v;
                }


                string
                f_10044_33398_33431(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 33398, 33431);
                    return return_v;
                }


                bool
                f_10044_33390_33432(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 33390, 33432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExplicitInterfaceSpecifierSyntax?
                f_10044_33783_33819(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.EventDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 33783, 33819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10044_33885_33905(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.EventDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 33885, 33905);
                    return return_v;
                }


                string
                f_10044_33885_33915(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 33885, 33915);
                    return return_v;
                }


                bool
                f_10044_33877_33916(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 33877, 33916);
                    return return_v;
                }


                bool
                f_10044_34096_34352(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 34096, 34352);
                    return return_v;
                }


                bool
                f_10044_34508_34552(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 34508, 34552);
                    return return_v;
                }


                bool
                f_10044_34705_34742(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 34705, 34742);
                    return return_v;
                }


                string
                f_10044_34998_35047(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.OperatorDeclarationSyntax
                declaration)
                {
                    var return_v = OperatorFacts.OperatorNameFromDeclaration(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 34998, 35047);
                    return return_v;
                }


                bool
                f_10044_35070_35083(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 35070, 35083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10044_35255_35348(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ConversionOperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ImplicitOrExplicitKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 35255, 35348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10044_35255_35353(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10044, 35255, 35353);
                    return return_v;
                }


                bool
                f_10044_35247_35526(System.Collections.Immutable.ImmutableHashSet<string>.Builder
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 35247, 35526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10044, 30691, 35806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 30691, 35806);
            }
        }

        static DeclarationTreeBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10044, 633, 35813);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10044, 24023, 24158);
            s_memberNameBuilderPool = f_10044_24062_24158(() => ImmutableHashSet.CreateBuilder<string>()); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10044, 633, 35813);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10044, 633, 35813);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10044, 633, 35813);

        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableHashSet<string>.Builder>
        f_10044_24062_24158(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableHashSet<string>.Builder>.Factory
        factory)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableHashSet<string>.Builder>(factory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10044, 24062, 24158);
            return return_v;
        }

    }
}
