// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

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
        internal ImmutableArray<Symbol> BindCref(CrefSyntax syntax, out Symbol? ambiguityWinner, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 584, 1086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 724, 816);

                ImmutableArray<Symbol>
                symbols = f_10304_757_815(this, syntax, out ambiguityWinner, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 830, 888);

                f_10304_830_887(f_10304_843_861_M(!symbols.IsDefault), "Prefer empty to null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 902, 1046);

                f_10304_902_1045((symbols.Length > 1) == ((object?)ambiguityWinner != null), "ambiguityWinner should be set iff more than one symbol is returned.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 1060, 1075);

                return symbols;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 584, 1086);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_757_815(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                syntax, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindCrefInternal(syntax, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 757, 815);
                    return return_v;
                }


                bool
                f_10304_843_861_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 843, 861);
                    return return_v;
                }


                int
                f_10304_830_887(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 830, 887);
                    return 0;
                }


                int
                f_10304_902_1045(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 902, 1045);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 584, 1086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 584, 1086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> BindCrefInternal(CrefSyntax syntax, out Symbol? ambiguityWinner, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 1098, 2084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 1245, 2073);

                switch (f_10304_1253_1266(syntax))
                {

                    case SyntaxKind.TypeCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 1245, 2073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 1347, 1425);

                        return f_10304_1354_1424(this, syntax, out ambiguityWinner, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 1245, 2073);

                    case SyntaxKind.QualifiedCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 1245, 2073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 1495, 1583);

                        return f_10304_1502_1582(this, syntax, out ambiguityWinner, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 1245, 2073);

                    case SyntaxKind.NameMemberCref:
                    case SyntaxKind.IndexerMemberCref:
                    case SyntaxKind.OperatorMemberCref:
                    case SyntaxKind.ConversionOperatorMemberCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 1245, 2073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 1822, 1954);

                        return f_10304_1829_1953(this, syntax, containerOpt: null, ambiguityWinner: out ambiguityWinner, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 1245, 2073);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 1245, 2073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 2002, 2058);

                        throw f_10304_2008_2057(f_10304_2043_2056(syntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 1245, 2073);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 1098, 2084);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10304_1253_1266(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 1253, 1266);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_1354_1424(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                syntax, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTypeCref((Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax)syntax, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 1354, 1424);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_1502_1582(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                syntax, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindQualifiedCref((Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax)syntax, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 1502, 1582);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_1829_1953(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containerOpt, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindMemberCref((Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax)syntax, containerOpt: containerOpt, out ambiguityWinner, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 1829, 1953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10304_2043_2056(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 2043, 2056);
                    return return_v;
                }


                System.Exception
                f_10304_2008_2057(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 2008, 2057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 1098, 2084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 1098, 2084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> BindTypeCref(TypeCrefSyntax syntax, out Symbol? ambiguityWinner, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 2096, 3120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 2243, 2319);

                NamespaceOrTypeSymbol
                result = f_10304_2274_2318(this, f_10304_2306_2317(syntax))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 2586, 2846) || true) && (f_10304_2590_2601(result) == SymbolKind.ErrorType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 2586, 2846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 2659, 2730);

                    var
                    noTrivia = f_10304_2674_2729(f_10304_2674_2704(syntax, null), null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 2748, 2831);

                    f_10304_2748_2830(diagnostics, ErrorCode.WRN_BadXMLRef, f_10304_2789_2804(syntax), f_10304_2806_2829(noTrivia));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 2586, 2846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 3027, 3050);

                ambiguityWinner = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 3064, 3109);

                return f_10304_3071_3108(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 2096, 3120);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10304_2306_2317(Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 2306, 2317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10304_2274_2318(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax)
                {
                    var return_v = this_param.BindNamespaceOrTypeSymbolInCref(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 2274, 2318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10304_2590_2601(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 2590, 2601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax
                f_10304_2674_2704(Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax
                node, params Microsoft.CodeAnalysis.SyntaxTrivia[]?
                trivia)
                {
                    var return_v = node.WithLeadingTrivia<Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 2674, 2704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax
                f_10304_2674_2729(Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax
                node, params Microsoft.CodeAnalysis.SyntaxTrivia[]?
                trivia)
                {
                    var return_v = node.WithTrailingTrivia<Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 2674, 2729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10304_2789_2804(Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 2789, 2804);
                    return return_v;
                }


                string
                f_10304_2806_2829(Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 2806, 2829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10304_2748_2830(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 2748, 2830);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_3071_3108(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 3071, 3108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 2096, 3120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 2096, 3120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> BindQualifiedCref(QualifiedCrefSyntax syntax, out Symbol? ambiguityWinner, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 3132, 3638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 3447, 3531);

                NamespaceOrTypeSymbol
                container = f_10304_3481_3530(this, f_10304_3513_3529(syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 3545, 3627);

                return f_10304_3552_3626(this, f_10304_3567_3580(syntax), container, out ambiguityWinner, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 3132, 3638);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10304_3513_3529(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax
                this_param)
                {
                    var return_v = this_param.Container;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 3513, 3529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10304_3481_3530(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax)
                {
                    var return_v = this_param.BindNamespaceOrTypeSymbolInCref(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 3481, 3530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                f_10304_3567_3580(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 3567, 3580);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_3552_3626(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                containerOpt, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindMemberCref(syntax, containerOpt, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 3552, 3626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 3132, 3638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 3132, 3638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamespaceOrTypeSymbol BindNamespaceOrTypeSymbolInCref(TypeSyntax syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 4144, 5287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 4249, 4296);

                f_10304_4249_4295(f_10304_4262_4294(Flags, BinderFlags.Cref));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 4929, 4991);

                DiagnosticBag
                unusedDiagnostics = f_10304_4963_4990()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 5005, 5126);

                NamespaceOrTypeSymbol
                namespaceOrTypeSymbol = f_10304_5051_5103(this, syntax, unusedDiagnostics).NamespaceOrTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 5140, 5165);

                f_10304_5140_5164(unusedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 5181, 5233);

                f_10304_5181_5232((object)namespaceOrTypeSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 5247, 5276);

                return namespaceOrTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 4144, 5287);

                bool
                f_10304_4262_4294(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 4262, 4294);
                    return return_v;
                }


                int
                f_10304_4249_4295(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 4249, 4295);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10304_4963_4990()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 4963, 4990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10304_5051_5103(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindNamespaceOrTypeSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 5051, 5103);
                    return return_v;
                }


                int
                f_10304_5140_5164(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 5140, 5164);
                    return 0;
                }


                int
                f_10304_5181_5232(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 5181, 5232);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 4144, 5287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 4144, 5287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> BindMemberCref(MemberCrefSyntax syntax, NamespaceOrTypeSymbol? containerOpt, out Symbol? ambiguityWinner, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 5299, 7627);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 5487, 6161) || true) && ((object?)containerOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10304, 5491, 5569) && f_10304_5524_5541(containerOpt) == SymbolKind.TypeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 5487, 6161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 5805, 5855);

                    CrefSyntax
                    crefSyntax = f_10304_5829_5854(syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 5873, 5944);

                    var
                    noTrivia = f_10304_5888_5943(f_10304_5888_5918(syntax, null), null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 5962, 6049);

                    f_10304_5962_6048(diagnostics, ErrorCode.WRN_BadXMLRef, f_10304_6003_6022(crefSyntax), f_10304_6024_6047(noTrivia));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 6069, 6092);

                    ambiguityWinner = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 6110, 6146);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 5487, 6161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 6177, 6207);

                ImmutableArray<Symbol>
                result
                = default(ImmutableArray<Symbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 6221, 7260);

                switch (f_10304_6229_6242(syntax))
                {

                    case SyntaxKind.NameMemberCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 6221, 7260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 6329, 6435);

                        result = f_10304_6338_6434(this, syntax, containerOpt, out ambiguityWinner, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10304, 6457, 6463);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 6221, 7260);

                    case SyntaxKind.IndexerMemberCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 6221, 7260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 6537, 6649);

                        result = f_10304_6546_6648(this, syntax, containerOpt, out ambiguityWinner, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10304, 6671, 6677);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 6221, 7260);

                    case SyntaxKind.OperatorMemberCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 6221, 7260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 6752, 6866);

                        result = f_10304_6761_6865(this, syntax, containerOpt, out ambiguityWinner, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10304, 6888, 6894);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 6221, 7260);

                    case SyntaxKind.ConversionOperatorMemberCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 6221, 7260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 6979, 7113);

                        result = f_10304_6988_7112(this, syntax, containerOpt, out ambiguityWinner, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10304, 7135, 7141);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 6221, 7260);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 6221, 7260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 7189, 7245);

                        throw f_10304_7195_7244(f_10304_7230_7243(syntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 6221, 7260);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 7276, 7586) || true) && (!result.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 7276, 7586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 7327, 7377);

                    CrefSyntax
                    crefSyntax = f_10304_7351_7376(syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 7395, 7466);

                    var
                    noTrivia = f_10304_7410_7465(f_10304_7410_7440(syntax, null), null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 7484, 7571);

                    f_10304_7484_7570(diagnostics, ErrorCode.WRN_BadXMLRef, f_10304_7525_7544(crefSyntax), f_10304_7546_7569(noTrivia));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 7276, 7586);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 7602, 7616);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 5299, 7627);

                Microsoft.CodeAnalysis.SymbolKind
                f_10304_5524_5541(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 5524, 5541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                f_10304_5829_5854(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax)
                {
                    var return_v = GetRootCrefSyntax(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 5829, 5854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                f_10304_5888_5918(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                node, params Microsoft.CodeAnalysis.SyntaxTrivia[]?
                trivia)
                {
                    var return_v = node.WithLeadingTrivia<Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 5888, 5918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                f_10304_5888_5943(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                node, params Microsoft.CodeAnalysis.SyntaxTrivia[]?
                trivia)
                {
                    var return_v = node.WithTrailingTrivia<Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 5888, 5943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10304_6003_6022(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 6003, 6022);
                    return return_v;
                }


                string
                f_10304_6024_6047(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 6024, 6047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10304_5962_6048(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 5962, 6048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10304_6229_6242(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 6229, 6242);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_6338_6434(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containerOpt, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindNameMemberCref((Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax)syntax, containerOpt, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 6338, 6434);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_6546_6648(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containerOpt, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindIndexerMemberCref((Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax)syntax, containerOpt, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 6546, 6648);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_6761_6865(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containerOpt, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindOperatorMemberCref((Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax)syntax, containerOpt, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 6761, 6865);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_6988_7112(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containerOpt, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindConversionOperatorMemberCref((Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax)syntax, containerOpt, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 6988, 7112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10304_7230_7243(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 7230, 7243);
                    return return_v;
                }


                System.Exception
                f_10304_7195_7244(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 7195, 7244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                f_10304_7351_7376(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax)
                {
                    var return_v = GetRootCrefSyntax(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 7351, 7376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                f_10304_7410_7440(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                node, params Microsoft.CodeAnalysis.SyntaxTrivia[]?
                trivia)
                {
                    var return_v = node.WithLeadingTrivia<Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 7410, 7440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                f_10304_7410_7465(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                node, params Microsoft.CodeAnalysis.SyntaxTrivia[]?
                trivia)
                {
                    var return_v = node.WithTrailingTrivia<Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 7410, 7465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10304_7525_7544(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 7525, 7544);
                    return return_v;
                }


                string
                f_10304_7546_7569(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 7546, 7569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10304_7484_7570(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 7484, 7570);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 5299, 7627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 5299, 7627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> BindNameMemberCref(NameMemberCrefSyntax syntax, NamespaceOrTypeSymbol? containerOpt, out Symbol? ambiguityWinner, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 7639, 9602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 7835, 7898);

                SimpleNameSyntax?
                nameSyntax = f_10304_7866_7877(syntax) as SimpleNameSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 7914, 7924);

                int
                arity
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 7938, 7956);

                string
                memberName
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 7972, 8682) || true) && (nameSyntax != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 7972, 8682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 8028, 8053);

                    arity = f_10304_8036_8052(nameSyntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 8071, 8116);

                    memberName = nameSyntax.Identifier.ValueText;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 7972, 8682);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 7972, 8682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 8359, 8403);

                    f_10304_8359_8402((object?)containerOpt == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 8501, 8561);

                    containerOpt = f_10304_8516_8560(this, f_10304_8548_8559(syntax));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 8581, 8591);

                    arity = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 8609, 8667);

                    memberName = WellKnownMemberNames.InstanceConstructorName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 7972, 8682);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 8698, 8860) || true) && (f_10304_8702_8734(memberName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 8698, 8860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 8768, 8791);

                    ambiguityWinner = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 8809, 8845);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 8698, 8860);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 8876, 9021);

                ImmutableArray<Symbol>
                sortedSymbols = f_10304_8915_9020(this, syntax, containerOpt, memberName, arity, f_10304_8981_8998(syntax) != null, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 9037, 9188) || true) && (sortedSymbols.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 9037, 9188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 9096, 9119);

                    ambiguityWinner = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 9137, 9173);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 9037, 9188);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 9204, 9591);

                return f_10304_9211_9590(this, sortedSymbols, arity, syntax, typeArgumentListSyntax: (DynAbs.Tracing.TraceSender.Conditional_F1(10304, 9365, 9375) || ((arity == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10304, 9378, 9382)) || DynAbs.Tracing.TraceSender.Conditional_F3(10304, 9385, 9434))) ? null : f_10304_9385_9434(((GenericNameSyntax)nameSyntax!)), parameterListSyntax: f_10304_9474_9491(syntax), ambiguityWinner: out ambiguityWinner, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 7639, 9602);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10304_7866_7877(Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 7866, 7877);
                    return return_v;
                }


                int
                f_10304_8036_8052(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 8036, 8052);
                    return return_v;
                }


                int
                f_10304_8359_8402(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 8359, 8402);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10304_8548_8559(Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 8548, 8559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10304_8516_8560(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax)
                {
                    var return_v = this_param.BindNamespaceOrTypeSymbolInCref(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 8516, 8560);
                    return return_v;
                }


                bool
                f_10304_8702_8734(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 8702, 8734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax?
                f_10304_8981_8998(Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 8981, 8998);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_8915_9020(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containerOpt, string
                memberName, int
                arity, bool
                hasParameterList, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ComputeSortedCrefMembers((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, containerOpt, memberName, arity, hasParameterList, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 8915, 9020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                f_10304_9385_9434(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.TypeArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 9385, 9434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax?
                f_10304_9474_9491(Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 9474, 9491);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_9211_9590(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax
                memberSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax?
                typeArgumentListSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax?
                parameterListSyntax, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ProcessCrefMemberLookupResults(symbols, arity, (Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax)memberSyntax, typeArgumentListSyntax: typeArgumentListSyntax, parameterListSyntax: (Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax?)parameterListSyntax, out ambiguityWinner, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 9211, 9590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 7639, 9602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 7639, 9602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> BindIndexerMemberCref(IndexerMemberCrefSyntax syntax, NamespaceOrTypeSymbol? containerOpt, out Symbol? ambiguityWinner, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 9614, 10772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 9816, 9836);

                const int
                arity = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 9852, 10015);

                ImmutableArray<Symbol>
                sortedSymbols = f_10304_9891_10014(this, syntax, containerOpt, WellKnownMemberNames.Indexer, arity, f_10304_9975_9992(syntax) != null, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 10031, 10182) || true) && (sortedSymbols.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 10031, 10182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 10090, 10113);

                    ambiguityWinner = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 10131, 10167);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 10031, 10182);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 10274, 10334);

                f_10304_10274_10333(sortedSymbols.All(SymbolExtensions.IsIndexer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 10439, 10761);

                return f_10304_10446_10760(this, sortedSymbols, arity, syntax, typeArgumentListSyntax: null, parameterListSyntax: f_10304_10644_10661(syntax), ambiguityWinner: out ambiguityWinner, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 9614, 10772);

                Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax?
                f_10304_9975_9992(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 9975, 9992);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_9891_10014(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containerOpt, string
                memberName, int
                arity, bool
                hasParameterList, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ComputeSortedCrefMembers((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, containerOpt, memberName, arity, hasParameterList, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 9891, 10014);
                    return return_v;
                }


                int
                f_10304_10274_10333(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 10274, 10333);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax?
                f_10304_10644_10661(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 10644, 10661);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_10446_10760(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax
                memberSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax?
                typeArgumentListSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax?
                parameterListSyntax, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ProcessCrefMemberLookupResults(symbols, arity, (Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax)memberSyntax, typeArgumentListSyntax: typeArgumentListSyntax, parameterListSyntax: (Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax?)parameterListSyntax, out ambiguityWinner, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 10446, 10760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 9614, 10772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 9614, 10772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> BindOperatorMemberCref(OperatorMemberCrefSyntax syntax, NamespaceOrTypeSymbol? containerOpt, out Symbol? ambiguityWinner, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 10910, 12755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 11114, 11134);

                const int
                arity = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 11150, 11215);

                CrefParameterListSyntax?
                parameterListSyntax = f_10304_11197_11214(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 11520, 11579);

                SyntaxKind
                operatorTokenKind = syntax.OperatorToken.Kind()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 11593, 11801);

                string?
                memberName = (DynAbs.Tracing.TraceSender.Conditional_F1(10304, 11614, 11686) || ((parameterListSyntax != null && (DynAbs.Tracing.TraceSender.Expression_True(10304, 11614, 11686) && parameterListSyntax.Parameters.Count == 1
                ) && DynAbs.Tracing.TraceSender.Conditional_F2(10304, 11706, 11710)) || DynAbs.Tracing.TraceSender.Conditional_F3(10304, 11730, 11800))) ? null
                : f_10304_11730_11800(operatorTokenKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 11815, 11912);

                memberName = memberName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10304, 11828, 11911) ?? f_10304_11842_11911(operatorTokenKind));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 11928, 12076) || true) && (memberName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 11928, 12076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 11984, 12007);

                    ambiguityWinner = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 12025, 12061);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 11928, 12076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 12092, 12237);

                ImmutableArray<Symbol>
                sortedSymbols = f_10304_12131_12236(this, syntax, containerOpt, memberName, arity, f_10304_12197_12214(syntax) != null, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 12253, 12404) || true) && (sortedSymbols.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 12253, 12404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 12312, 12335);

                    ambiguityWinner = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 12353, 12389);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 12253, 12404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 12420, 12744);

                return f_10304_12427_12743(this, sortedSymbols, arity, syntax, typeArgumentListSyntax: null, parameterListSyntax: parameterListSyntax, ambiguityWinner: out ambiguityWinner, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 10910, 12755);

                Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax?
                f_10304_11197_11214(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 11197, 11214);
                    return return_v;
                }


                string
                f_10304_11730_11800(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = OperatorFacts.BinaryOperatorNameFromSyntaxKindIfAny(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 11730, 11800);
                    return return_v;
                }


                string
                f_10304_11842_11911(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = OperatorFacts.UnaryOperatorNameFromSyntaxKindIfAny(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 11842, 11911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax?
                f_10304_12197_12214(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 12197, 12214);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_12131_12236(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containerOpt, string
                memberName, int
                arity, bool
                hasParameterList, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ComputeSortedCrefMembers((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, containerOpt, memberName, arity, hasParameterList, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 12131, 12236);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_12427_12743(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax
                memberSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax?
                typeArgumentListSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax?
                parameterListSyntax, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ProcessCrefMemberLookupResults(symbols, arity, (Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax)memberSyntax, typeArgumentListSyntax: typeArgumentListSyntax, parameterListSyntax: (Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax?)parameterListSyntax, out ambiguityWinner, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 12427, 12743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 10910, 12755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 10910, 12755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> BindConversionOperatorMemberCref(ConversionOperatorMemberCrefSyntax syntax, NamespaceOrTypeSymbol? containerOpt, out Symbol? ambiguityWinner, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 12840, 14622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 13064, 13084);

                const int
                arity = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 13100, 13316);

                string
                memberName = (DynAbs.Tracing.TraceSender.Conditional_F1(10304, 13120, 13189) || ((syntax.ImplicitOrExplicitKeyword.Kind() == SyntaxKind.ImplicitKeyword
                && DynAbs.Tracing.TraceSender.Conditional_F2(10304, 13209, 13252)) || DynAbs.Tracing.TraceSender.Conditional_F3(10304, 13272, 13315))) ? WellKnownMemberNames.ImplicitConversionName
                : WellKnownMemberNames.ExplicitConversionName
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 13332, 13477);

                ImmutableArray<Symbol>
                sortedSymbols = f_10304_13371_13476(this, syntax, containerOpt, memberName, arity, f_10304_13437_13454(syntax) != null, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 13493, 13644) || true) && (sortedSymbols.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 13493, 13644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 13552, 13575);

                    ambiguityWinner = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 13593, 13629);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 13493, 13644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 13660, 13748);

                TypeSymbol
                returnType = f_10304_13684_13747(this, f_10304_13714_13725(syntax), syntax, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 13872, 14107);

                sortedSymbols = sortedSymbols.WhereAsArray((symbol, returnType) =>
                                symbol.Kind != SymbolKind.Method || TypeSymbol.Equals(((MethodSymbol)symbol).ReturnType, returnType, TypeCompareKind.ConsiderEverything2), returnType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 14123, 14273) || true) && (!sortedSymbols.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 14123, 14273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 14181, 14204);

                    ambiguityWinner = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 14222, 14258);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 14123, 14273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 14289, 14611);

                return f_10304_14296_14610(this, sortedSymbols, arity, syntax, typeArgumentListSyntax: null, parameterListSyntax: f_10304_14494_14511(syntax), ambiguityWinner: out ambiguityWinner, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 12840, 14622);

                Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax?
                f_10304_13437_13454(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 13437, 13454);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_13371_13476(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containerOpt, string
                memberName, int
                arity, bool
                hasParameterList, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ComputeSortedCrefMembers((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, containerOpt, memberName, arity, hasParameterList, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 13371, 13476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10304_13714_13725(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 13714, 13725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10304_13684_13747(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax
                memberCrefSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindCrefParameterOrReturnType(typeSyntax, (Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax)memberCrefSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 13684, 13747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax?
                f_10304_14494_14511(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 14494, 14511);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_14296_14610(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax
                memberSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax?
                typeArgumentListSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax?
                parameterListSyntax, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ProcessCrefMemberLookupResults(symbols, arity, (Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax)memberSyntax, typeArgumentListSyntax: typeArgumentListSyntax, parameterListSyntax: (Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax?)parameterListSyntax, out ambiguityWinner, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 14296, 14610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 12840, 14622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 12840, 14622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> ComputeSortedCrefMembers(CSharpSyntaxNode syntax, NamespaceOrTypeSymbol? containerOpt, string memberName, int arity, bool hasParameterList, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 15100, 15597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 15322, 15373);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 15387, 15500);

                var
                result = f_10304_15400_15499(this, containerOpt, memberName, arity, hasParameterList, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 15514, 15558);

                f_10304_15514_15557(diagnostics, syntax, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 15572, 15586);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 15100, 15597);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_15400_15499(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containerOpt, string
                memberName, int
                arity, bool
                hasParameterList, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ComputeSortedCrefMembers(containerOpt, memberName, arity, hasParameterList, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 15400, 15499);
                    return return_v;
                }


                bool
                f_10304_15514_15557(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 15514, 15557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 15100, 15597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 15100, 15597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> ComputeSortedCrefMembers(NamespaceOrTypeSymbol? containerOpt, string memberName, int arity, bool hasParameterList, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 15609, 22525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 15965, 15994);

                ArrayBuilder<Symbol>
                builder
                = default(ArrayBuilder<Symbol>);
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 16027, 16076);

                    LookupResult
                    result = f_10304_16049_16075()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 16094, 16486);

                    f_10304_16094_16485(this, result, containerOpt, name: memberName, arity: arity, basesBeingResolved: null, options: LookupOptions.AllMethodsOnArityZero, diagnose: false, useSiteDiagnostics: ref useSiteDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 16609, 22110) || true) && (f_10304_16613_16633(result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 16609, 22110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 16858, 16903);

                        builder = f_10304_16868_16902();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 16925, 16958);

                        f_10304_16925_16957(builder, f_10304_16942_16956(result));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 16980, 16994);

                        f_10304_16980_16993(result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 16609, 22110);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 16609, 22110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 17076, 17090);

                        f_10304_17076_17089(result);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 19495, 19535);

                        NamedTypeSymbol?
                        constructorType = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 19559, 21309) || true) && (arity == 0)
                        ) // Member arity

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 19559, 21309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 19639, 19704);

                            NamedTypeSymbol?
                            containerType = containerOpt as NamedTypeSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 19730, 21286) || true) && ((object?)containerType != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 19730, 21286);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 20148, 20477) || true) && (f_10304_20152_20170(containerType) == memberName && (DynAbs.Tracing.TraceSender.Expression_True(10304, 20152, 20348) && (hasParameterList || (DynAbs.Tracing.TraceSender.Expression_False(10304, 20189, 20233) || f_10304_20209_20228(containerType) == 0) || (DynAbs.Tracing.TraceSender.Expression_False(10304, 20189, 20347) || !f_10304_20238_20347(f_10304_20256_20275(this), f_10304_20277_20309(containerType), TypeCompareKind.ConsiderEverything2)))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 20148, 20477);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 20414, 20446);

                                    constructorType = containerType;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 20148, 20477);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 19730, 21286);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 19730, 21286);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 20535, 21286) || true) && ((object?)containerOpt == null && (DynAbs.Tracing.TraceSender.Expression_True(10304, 20539, 20588) && hasParameterList))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 20535, 21286);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 20949, 21009);

                                    NamedTypeSymbol?
                                    binderContainingType = f_10304_20989_21008(this)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 21039, 21259) || true) && ((object?)binderContainingType != null && (DynAbs.Tracing.TraceSender.Expression_True(10304, 21043, 21123) && memberName == f_10304_21098_21123(binderContainingType)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 21039, 21259);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 21189, 21228);

                                        constructorType = binderContainingType;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 21039, 21259);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 20535, 21286);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 19730, 21286);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 19559, 21309);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 21333, 22091) || true) && ((object?)constructorType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 21333, 22091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 21419, 21508);

                            ImmutableArray<MethodSymbol>
                            instanceConstructors = f_10304_21471_21507(constructorType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 21534, 21592);

                            int
                            numInstanceConstructors = instanceConstructors.Length
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 21620, 21773) || true) && (numInstanceConstructors == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 21620, 21773);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 21710, 21746);

                                return ImmutableArray<Symbol>.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 21620, 21773);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 21801, 21869);

                            builder = f_10304_21811_21868(numInstanceConstructors);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 21895, 21934);

                            f_10304_21895_21933(builder, instanceConstructors);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 21333, 22091);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 21333, 22091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 22032, 22068);

                            return ImmutableArray<Symbol>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 21333, 22091);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 16609, 22110);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 22141, 22171);

                f_10304_22141_22170(builder != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 22347, 22462) || true) && (f_10304_22351_22364(builder) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 22347, 22462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 22402, 22447);

                    f_10304_22402_22446(builder, ConsistentSymbolOrder.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 22347, 22462);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 22478, 22514);

                return f_10304_22485_22513(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 15609, 22525);

                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10304_16049_16075()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 16049, 16075);
                    return return_v;
                }


                int
                f_10304_16094_16485(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                qualifierOpt, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    this_param.LookupSymbolsOrMembersInternal(result, qualifierOpt, name: name, arity: arity, basesBeingResolved: basesBeingResolved, options: options, diagnose: diagnose, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 16094, 16485);
                    return 0;
                }


                bool
                f_10304_16613_16633(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 16613, 16633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_16868_16902()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 16868, 16902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_16942_16956(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 16942, 16956);
                    return return_v;
                }


                int
                f_10304_16925_16957(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 16925, 16957);
                    return 0;
                }


                int
                f_10304_16980_16993(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 16980, 16993);
                    return 0;
                }


                int
                f_10304_17076_17089(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 17076, 17089);
                    return 0;
                }


                string
                f_10304_20152_20170(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 20152, 20170);
                    return return_v;
                }


                int
                f_10304_20209_20228(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 20209, 20228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10304_20256_20275(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 20256, 20275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10304_20277_20309(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 20277, 20309);
                    return return_v;
                }


                bool
                f_10304_20238_20347(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 20238, 20347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10304_20989_21008(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 20989, 21008);
                    return return_v;
                }


                string
                f_10304_21098_21123(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 21098, 21123);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10304_21471_21507(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 21471, 21507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_21811_21868(int
                capacity)
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 21811, 21868);
                    return return_v;
                }


                int
                f_10304_21895_21933(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                items)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 21895, 21933);
                    return 0;
                }


                int
                f_10304_22141_22170(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 22141, 22170);
                    return 0;
                }


                int
                f_10304_22351_22364(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 22351, 22364);
                    return return_v;
                }


                int
                f_10304_22402_22446(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.ConsistentSymbolOrder
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 22402, 22446);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_22485_22513(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 22485, 22513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 15609, 22525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 15609, 22525);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> ProcessCrefMemberLookupResults(
                    ImmutableArray<Symbol> symbols,
                    int arity,
                    MemberCrefSyntax memberSyntax,
                    TypeArgumentListSyntax? typeArgumentListSyntax,
                    BaseCrefParameterListSyntax? parameterListSyntax,
                    out Symbol? ambiguityWinner,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 22722, 27044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 23128, 23159);

                f_10304_23128_23158(f_10304_23141_23157_M(!symbols.IsEmpty));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 23175, 23394) || true) && (parameterListSyntax == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 23175, 23394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 23240, 23379);

                    return f_10304_23247_23378(this, symbols, arity, memberSyntax, typeArgumentListSyntax, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 23175, 23394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 23410, 23479);

                ArrayBuilder<Symbol>
                candidates = f_10304_23444_23478()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 23493, 23581);

                f_10304_23493_23580(this, symbols, arity, typeArgumentListSyntax, candidates);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 23597, 23701);

                ImmutableArray<ParameterSymbol>
                parameterSymbols = f_10304_23648_23700(this, parameterListSyntax, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 23715, 23863);

                ImmutableArray<Symbol>
                results = f_10304_23748_23862(candidates, parameterSymbols, arity, memberSyntax, out ambiguityWinner, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 23879, 23897);

                f_10304_23879_23896(
                            candidates);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 24077, 27002) || true) && (results.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 24077, 27002);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 24143, 24148);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 24134, 26987) || true) && (i < parameterSymbols.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 24179, 24182)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 24134, 26987))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 24134, 26987);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 24224, 26968) || true) && (f_10304_24228_24298(f_10304_24273_24297(parameterSymbols[i])))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 24224, 26968);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 26810, 26913);

                                f_10304_26810_26912(                        // This warning is new in Roslyn, because our better-defined semantics for
                                                                            // cref lookup disallow some things that were possible in dev12.
                                                                            //
                                                                            // Consider the following code:
                                                                            //
                                                                            //   public class C<T>
                                                                            //   {
                                                                            //       public class Inner { }
                                                                            //   
                                                                            //       public void M(Inner i) { }
                                                                            //   
                                                                            //       /// <see cref="M"/>
                                                                            //       /// <see cref="C{T}.M"/>
                                                                            //       /// <see cref="C{Q}.M"/>
                                                                            //       /// <see cref="C{Q}.M(C{Q}.Inner)"/>
                                                                            //       /// <see cref="C{Q}.M(Inner)"/> // WRN_UnqualifiedNestedTypeInCref
                                                                            //       public void N() { }
                                                                            //   }
                                                                            //
                                                                            // Dev12 binds all of the crefs as "M:C`1.M(C{`0}.Inner)".
                                                                            // Roslyn accepts all but the last.  The issue is that the context for performing
                                                                            // the lookup is not C<Q>, but C<T>.  Consequently, Inner binds to C<T>.Inner and
                                                                            // then overload resolution fails because C<T>.Inner does not match C<Q>.Inner,
                                                                            // the parameter type of C<Q>.M.  Since we could not agree that the old behavior
                                                                            // was desirable (other than for backwards compatibility) and since mimicking it
                                                                            // would have been expensive, we settled on introducing a new warning that at
                                                                            // least hints to the user how then can work around the issue (i.e. by qualifying
                                                                            // Inner as C{Q}.Inner).  Additional details are available in DevDiv #743425.
                                                                            //
                                                                            // CONSIDER: We could actually put the qualified form in the warning message,
                                                                            // but that would probably just make it more frustrating (i.e. if the compiler
                                                                            // knows exactly what I mean, why do I have to type it).
                                                                            //
                                                                            // NOTE: This is not a great location (whole parameter instead of problematic type),
                                                                            // but it's better than nothing.
                                                        diagnostics, ErrorCode.WRN_UnqualifiedNestedTypeInCref, f_10304_26869_26911(f_10304_26869_26899(parameterListSyntax)[i]));
                                DynAbs.Tracing.TraceSender.TraceBreak(10304, 26939, 26945);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 24224, 26968);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10304, 1, 2854);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10304, 1, 2854);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 24077, 27002);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 27018, 27033);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 22722, 27044);

                bool
                f_10304_23141_23157_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 23141, 23157);
                    return return_v;
                }


                int
                f_10304_23128_23158(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 23128, 23158);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_23247_23378(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                memberSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax?
                typeArgumentListSyntax, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ProcessParameterlessCrefMemberLookupResults(symbols, arity, memberSyntax, typeArgumentListSyntax, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 23247, 23378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_23444_23478()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 23444, 23478);
                    return return_v;
                }


                int
                f_10304_23493_23580(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax?
                typeArgumentListSyntax, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                candidates)
                {
                    this_param.GetCrefOverloadResolutionCandidates(symbols, arity, typeArgumentListSyntax, candidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 23493, 23580);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10304_23648_23700(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax
                parameterListSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindCrefParameters(parameterListSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 23648, 23700);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_23748_23862(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                candidates, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameterSymbols, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                memberSyntax, out Microsoft.CodeAnalysis.CSharp.Symbol?
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = PerformCrefOverloadResolution(candidates, parameterSymbols, arity, memberSyntax, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 23748, 23862);
                    return return_v;
                }


                int
                f_10304_23879_23896(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 23879, 23896);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10304_24273_24297(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 24273, 24297);
                    return return_v;
                }


                bool
                f_10304_24228_24298(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = ContainsNestedTypeOfUnconstructedGenericType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 24228, 24298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax>
                f_10304_26869_26899(Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 26869, 26899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10304_26869_26911(Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 26869, 26911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10304_26810_26912(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 26810, 26912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 22722, 27044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 22722, 27044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ContainsNestedTypeOfUnconstructedGenericType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10304, 27056, 29271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 27162, 29260);

                switch (f_10304_27170_27183(type))
                {

                    case TypeKind.Array:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 27162, 29260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 27259, 27348);

                        return f_10304_27266_27347(f_10304_27311_27346(((ArrayTypeSymbol)type)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 27162, 29260);

                    case TypeKind.Pointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 27162, 29260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 27410, 27503);

                        return f_10304_27417_27502(f_10304_27462_27501(((PointerTypeSymbol)type)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 27162, 29260);

                    case TypeKind.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 27162, 29260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 27573, 27642);

                        MethodSymbol
                        signature = f_10304_27598_27641(((FunctionPointerTypeSymbol)type))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 27664, 27819) || true) && (f_10304_27668_27734(f_10304_27713_27733(signature)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 27664, 27819);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 27784, 27796);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 27664, 27819);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 27843, 28115);
                            foreach (var param in f_10304_27865_27885_I(f_10304_27865_27885(signature)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 27843, 28115);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 27935, 28092) || true) && (f_10304_27939_27995(f_10304_27984_27994(param)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 27935, 28092);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 28053, 28065);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 27935, 28092);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 27843, 28115);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10304, 1, 273);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10304, 1, 273);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 28139, 28152);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 27162, 29260);

                    case TypeKind.Delegate:
                    case TypeKind.Class:
                    case TypeKind.Interface:
                    case TypeKind.Struct:
                    case TypeKind.Enum:
                    case TypeKind.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 27162, 29260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 28409, 28459);

                        NamedTypeSymbol
                        namedType = (NamedTypeSymbol)type
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 28481, 28619) || true) && (f_10304_28485_28534(namedType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 28481, 28619);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 28584, 28596);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 28481, 28619);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 28643, 28983);
                            foreach (TypeWithAnnotations typeArgument in f_10304_28688_28746_I(f_10304_28688_28746(namedType)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 28643, 28983);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 28796, 28960) || true) && (f_10304_28800_28863(typeArgument.Type))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 28796, 28960);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 28921, 28933);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 28796, 28960);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 28643, 28983);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10304, 1, 341);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10304, 1, 341);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 29007, 29020);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 27162, 29260);

                    case TypeKind.Dynamic:
                    case TypeKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 27162, 29260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 29128, 29141);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 27162, 29260);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 27162, 29260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 29189, 29245);

                        throw f_10304_29195_29244(f_10304_29230_29243(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 27162, 29260);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10304, 27056, 29271);

                Microsoft.CodeAnalysis.TypeKind
                f_10304_27170_27183(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 27170, 27183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10304_27311_27346(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 27311, 27346);
                    return return_v;
                }


                bool
                f_10304_27266_27347(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = ContainsNestedTypeOfUnconstructedGenericType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 27266, 27347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10304_27462_27501(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 27462, 27501);
                    return return_v;
                }


                bool
                f_10304_27417_27502(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = ContainsNestedTypeOfUnconstructedGenericType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 27417, 27502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10304_27598_27641(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 27598, 27641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10304_27713_27733(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 27713, 27733);
                    return return_v;
                }


                bool
                f_10304_27668_27734(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = ContainsNestedTypeOfUnconstructedGenericType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 27668, 27734);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10304_27865_27885(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 27865, 27885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10304_27984_27994(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 27984, 27994);
                    return return_v;
                }


                bool
                f_10304_27939_27995(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = ContainsNestedTypeOfUnconstructedGenericType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 27939, 27995);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10304_27865_27885_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 27865, 27885);
                    return return_v;
                }


                bool
                f_10304_28485_28534(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = IsNestedTypeOfUnconstructedGenericType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 28485, 28534);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10304_28688_28746(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 28688, 28746);
                    return return_v;
                }


                bool
                f_10304_28800_28863(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = ContainsNestedTypeOfUnconstructedGenericType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 28800, 28863);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10304_28688_28746_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 28688, 28746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10304_29230_29243(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 29230, 29243);
                    return return_v;
                }


                System.Exception
                f_10304_29195_29244(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 29195, 29244);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 27056, 29271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 27056, 29271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNestedTypeOfUnconstructedGenericType(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10304, 29283, 29754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 29388, 29437);

                NamedTypeSymbol
                containing = f_10304_29417_29436(type)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 29451, 29714) || true) && ((object)containing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 29451, 29714);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 29518, 29642) || true) && (f_10304_29522_29538(containing) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10304, 29522, 29569) && f_10304_29546_29569(containing)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 29518, 29642);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 29611, 29623);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 29518, 29642);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 29660, 29699);

                        containing = f_10304_29673_29698(containing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 29451, 29714);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10304, 29451, 29714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10304, 29451, 29714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 29730, 29743);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10304, 29283, 29754);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10304_29417_29436(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 29417, 29436);
                    return return_v;
                }


                int
                f_10304_29522_29538(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 29522, 29538);
                    return return_v;
                }


                bool
                f_10304_29546_29569(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 29546, 29569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10304_29673_29698(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 29673, 29698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 29283, 29754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 29283, 29754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Symbol> ProcessParameterlessCrefMemberLookupResults(
                    ImmutableArray<Symbol> symbols,
                    int arity,
                    MemberCrefSyntax memberSyntax,
                    TypeArgumentListSyntax? typeArgumentListSyntax,
                    out Symbol? ambiguityWinner,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 30198, 34506);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 30778, 31864) || true) && (symbols.Length > 1 && (DynAbs.Tracing.TraceSender.Expression_True(10304, 30782, 30814) && arity == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 30778, 31864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 30848, 30881);

                    bool
                    hasNonGenericMethod = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 30899, 30929);

                    bool
                    hasGenericMethod = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 30947, 31603);
                        foreach (Symbol s in f_10304_30968_30975_I(symbols))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 30947, 31603);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 31017, 31130) || true) && (f_10304_31021_31027(s) != SymbolKind.Method)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 31017, 31130);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 31098, 31107);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 31017, 31130);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 31154, 31408) || true) && (f_10304_31158_31181(((MethodSymbol)s)) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 31154, 31408);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 31236, 31263);

                                hasNonGenericMethod = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 31154, 31408);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 31154, 31408);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 31361, 31385);

                                hasGenericMethod = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 31154, 31408);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 31432, 31584) || true) && (hasGenericMethod && (DynAbs.Tracing.TraceSender.Expression_True(10304, 31436, 31475) && hasNonGenericMethod))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 31432, 31584);
                                DynAbs.Tracing.TraceSender.TraceBreak(10304, 31525, 31531);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 31432, 31584);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 30947, 31603);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10304, 1, 657);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10304, 1, 657);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 31623, 31849) || true) && (hasNonGenericMethod && (DynAbs.Tracing.TraceSender.Expression_True(10304, 31627, 31666) && hasGenericMethod))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 31623, 31849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 31708, 31830);

                        symbols = symbols.WhereAsArray(s =>
                                                s.Kind != SymbolKind.Method || ((MethodSymbol)s).Arity == 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 31623, 31849);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 30778, 31864);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 31880, 31911);

                f_10304_31880_31910(f_10304_31893_31909_M(!symbols.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 31927, 31954);

                Symbol
                symbol = symbols[0]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32143, 34333) || true) && (symbols.Length > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 32143, 34333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32293, 32382);

                    ArrayBuilder<Symbol>
                    unwrappedSymbols = f_10304_32333_32381(symbols.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32402, 32553);
                        foreach (Symbol wrapped in f_10304_32429_32436_I(symbols))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 32402, 32553);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32478, 32534);

                            f_10304_32478_32533(unwrappedSymbols, f_10304_32499_32532(wrapped));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 32402, 32553);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10304, 1, 152);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10304, 1, 152);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32573, 32599);

                    BestSymbolInfo
                    secondBest
                    = default(BestSymbolInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32617, 32691);

                    BestSymbolInfo
                    best = f_10304_32639_32690(this, unwrappedSymbols, out secondBest)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32711, 32738);

                    f_10304_32711_32737(f_10304_32724_32736_M(!best.IsNone));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32756, 32789);

                    f_10304_32756_32788(f_10304_32769_32787_M(!secondBest.IsNone));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32809, 32833);

                    f_10304_32809_32832(
                                    unwrappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32853, 32873);

                    int
                    symbolIndex = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32893, 33097) || true) && (best.IsFromCompilation)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 32893, 33097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 32961, 32986);

                        symbolIndex = best.Index;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 33008, 33038);

                        symbol = symbols[symbolIndex];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 32893, 33097);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 33117, 34041) || true) && (f_10304_33121_33132(symbol) == SymbolKind.TypeParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 33117, 34041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 33202, 33258);

                        CrefSyntax
                        crefSyntax = f_10304_33226_33257(memberSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 33280, 33372);

                        f_10304_33280_33371(diagnostics, ErrorCode.WRN_BadXMLRefTypeVar, f_10304_33328_33347(crefSyntax), f_10304_33349_33370(crefSyntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 33117, 34041);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 33117, 34041);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 33414, 34041) || true) && (secondBest.IsFromCompilation == best.IsFromCompilation)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 33414, 34041);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 33514, 33570);

                            CrefSyntax
                            crefSyntax = f_10304_33538_33569(memberSyntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 33592, 33634);

                            int
                            otherIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(10304, 33609, 33625) || ((symbolIndex == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10304, 33628, 33629)) || DynAbs.Tracing.TraceSender.Conditional_F3(10304, 33632, 33633))) ? 1 : 0
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 33656, 33782);

                            f_10304_33656_33781(diagnostics, ErrorCode.WRN_AmbiguousXMLReference, f_10304_33709_33728(crefSyntax), f_10304_33730_33751(crefSyntax), symbol, symbols[otherIndex]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 33806, 33895);

                            ambiguityWinner = f_10304_33824_33894(this, arity, typeArgumentListSyntax, symbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 33917, 34022);

                            return symbols.SelectAsArray(sym => ConstructWithCrefTypeParameters(arity, typeArgumentListSyntax, sym));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 33414, 34041);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 33117, 34041);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 32143, 34333);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 32143, 34333);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 34075, 34333) || true) && (f_10304_34079_34090(symbol) == SymbolKind.TypeParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 34075, 34333);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 34152, 34208);

                        CrefSyntax
                        crefSyntax = f_10304_34176_34207(memberSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 34226, 34318);

                        f_10304_34226_34317(diagnostics, ErrorCode.WRN_BadXMLRefTypeVar, f_10304_34274_34293(crefSyntax), f_10304_34295_34316(crefSyntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 34075, 34333);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 32143, 34333);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 34349, 34372);

                ambiguityWinner = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 34386, 34495);

                return f_10304_34393_34494(f_10304_34423_34493(this, arity, typeArgumentListSyntax, symbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 30198, 34506);

                Microsoft.CodeAnalysis.SymbolKind
                f_10304_31021_31027(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 31021, 31027);
                    return return_v;
                }


                int
                f_10304_31158_31181(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 31158, 31181);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_30968_30975_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 30968, 30975);
                    return return_v;
                }


                bool
                f_10304_31893_31909_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 31893, 31909);
                    return return_v;
                }


                int
                f_10304_31880_31910(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 31880, 31910);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_32333_32381(int
                capacity)
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 32333, 32381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10304_32499_32532(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = UnwrapAliasNoDiagnostics(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 32499, 32532);
                    return return_v;
                }


                int
                f_10304_32478_32533(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 32478, 32533);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_32429_32436_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 32429, 32436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.BestSymbolInfo
                f_10304_32639_32690(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, out Microsoft.CodeAnalysis.CSharp.Binder.BestSymbolInfo
                secondBest)
                {
                    var return_v = this_param.GetBestSymbolInfo(symbols, out secondBest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 32639, 32690);
                    return return_v;
                }


                bool
                f_10304_32724_32736_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 32724, 32736);
                    return return_v;
                }


                int
                f_10304_32711_32737(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 32711, 32737);
                    return 0;
                }


                bool
                f_10304_32769_32787_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 32769, 32787);
                    return return_v;
                }


                int
                f_10304_32756_32788(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 32756, 32788);
                    return 0;
                }


                int
                f_10304_32809_32832(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 32809, 32832);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10304_33121_33132(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 33121, 33132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                f_10304_33226_33257(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax)
                {
                    var return_v = GetRootCrefSyntax(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 33226, 33257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10304_33328_33347(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 33328, 33347);
                    return return_v;
                }


                string
                f_10304_33349_33370(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 33349, 33370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10304_33280_33371(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 33280, 33371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                f_10304_33538_33569(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax)
                {
                    var return_v = GetRootCrefSyntax(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 33538, 33569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10304_33709_33728(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 33709, 33728);
                    return return_v;
                }


                string
                f_10304_33730_33751(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 33730, 33751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10304_33656_33781(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 33656, 33781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10304_33824_33894(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax?
                typeArgumentListSyntax, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.ConstructWithCrefTypeParameters(arity, typeArgumentListSyntax, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 33824, 33894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10304_34079_34090(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 34079, 34090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                f_10304_34176_34207(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax)
                {
                    var return_v = GetRootCrefSyntax(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 34176, 34207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10304_34274_34293(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 34274, 34293);
                    return return_v;
                }


                string
                f_10304_34295_34316(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 34295, 34316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10304_34226_34317(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 34226, 34317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10304_34423_34493(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax?
                typeArgumentListSyntax, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.ConstructWithCrefTypeParameters(arity, typeArgumentListSyntax, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 34423, 34493);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_34393_34494(Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 34393, 34494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 30198, 34506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 30198, 34506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetCrefOverloadResolutionCandidates(ImmutableArray<Symbol> symbols, int arity, TypeArgumentListSyntax? typeArgumentListSyntax, ArrayBuilder<Symbol> candidates)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 34745, 35645);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 34942, 35634);
                    foreach (Symbol candidate in f_10304_34971_34978_I(symbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 34942, 35634);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 35012, 35116);

                        Symbol
                        constructedCandidate = f_10304_35042_35115(this, arity, typeArgumentListSyntax, candidate)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 35134, 35218);

                        NamedTypeSymbol?
                        constructedCandidateType = constructedCandidate as NamedTypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 35236, 35619) || true) && ((object?)constructedCandidateType == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 35236, 35619);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 35414, 35451);

                            f_10304_35414_35450(                    // Construct before overload resolution so the signatures will match.
                                                candidates, constructedCandidate);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 35236, 35619);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 35236, 35619);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 35533, 35600);

                            f_10304_35533_35599(candidates, f_10304_35553_35598(constructedCandidateType));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 35236, 35619);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 34942, 35634);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10304, 1, 693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10304, 1, 693);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 34745, 35645);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10304_35042_35115(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, int
                arity, Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax?
                typeArgumentListSyntax, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.ConstructWithCrefTypeParameters(arity, typeArgumentListSyntax, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 35042, 35115);
                    return return_v;
                }


                int
                f_10304_35414_35450(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 35414, 35450);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10304_35553_35598(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 35553, 35598);
                    return return_v;
                }


                int
                f_10304_35533_35599(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                items)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 35533, 35599);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_34971_34978_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 34971, 34978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 34745, 35645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 34745, 35645);
            }
        }

        private static ImmutableArray<Symbol> PerformCrefOverloadResolution(ArrayBuilder<Symbol> candidates, ImmutableArray<ParameterSymbol> parameterSymbols, int arity, MemberCrefSyntax memberSyntax, out Symbol? ambiguityWinner, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10304, 36101, 42566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 36374, 36410);

                ArrayBuilder<Symbol>?
                viable = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 36426, 41925);
                    foreach (Symbol candidate in f_10304_36455_36465_I(candidates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 36426, 41925);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 37117, 37140);

                        Symbol
                        signatureMember
                        = default(Symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 37158, 40422);

                        switch (f_10304_37166_37180(candidate))
                        {

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 37158, 40422);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 37302, 37357);

                                    MethodSymbol
                                    candidateMethod = (MethodSymbol)candidate
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 37387, 37447);

                                    MethodKind
                                    candidateMethodKind = f_10304_37420_37446(candidateMethod)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 37477, 37533);

                                    bool
                                    candidateMethodIsVararg = f_10304_37508_37532(candidateMethod)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 37670, 37860);

                                    int
                                    signatureMemberArity = (DynAbs.Tracing.TraceSender.Conditional_F1(10304, 37697, 37742) || ((candidateMethodKind == MethodKind.Constructor
                                    && DynAbs.Tracing.TraceSender.Conditional_F2(10304, 37778, 37779)) || DynAbs.Tracing.TraceSender.Conditional_F3(10304, 37815, 37859))) ? 0
                                    : ((DynAbs.Tracing.TraceSender.Conditional_F1(10304, 37816, 37826) || ((arity == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10304, 37829, 37850)) || DynAbs.Tracing.TraceSender.Conditional_F3(10304, 37853, 37858))) ? f_10304_37829_37850(candidateMethod) : arity)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 38027, 39119);

                                    signatureMember = f_10304_38045_39118(methodKind: candidateMethodKind, typeParameters: f_10304_38191_38251(signatureMemberArity), parameters: parameterSymbols, callingConvention: (DynAbs.Tracing.TraceSender.Conditional_F1(10304, 38451, 38474) || ((candidateMethodIsVararg && DynAbs.Tracing.TraceSender.Conditional_F2(10304, 38477, 38523)) || DynAbs.Tracing.TraceSender.Conditional_F3(10304, 38526, 38565))) ? Microsoft.Cci.CallingConvention.ExtraArguments : Microsoft.Cci.CallingConvention.HasThis, containingType: null, name: null, refKind: RefKind.None, isInitOnly: false, returnType: default, refCustomModifiers: ImmutableArray<CustomModifier>.Empty, explicitInterfaceImplementations: ImmutableArray<MethodSymbol>.Empty);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10304, 39149, 39155);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 37158, 40422);

                            case SymbolKind.Property:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 37158, 40422);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 39375, 40035);

                                    signatureMember = f_10304_39393_40034(parameters: parameterSymbols, containingType: null, name: null, refKind: RefKind.None, type: default, refCustomModifiers: ImmutableArray<CustomModifier>.Empty, isStatic: false, explicitInterfaceImplementations: ImmutableArray<PropertySymbol>.Empty);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10304, 40065, 40071);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 37158, 40422);

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 37158, 40422);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 40279, 40336);

                                throw f_10304_40285_40335(f_10304_40320_40334(candidate));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 37158, 40422);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 37158, 40422);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 40394, 40403);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 37158, 40422);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 40442, 41910) || true) && (f_10304_40446_40517(MemberSignatureComparer.CrefComparer, signatureMember, candidate))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 40442, 41910);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 40559, 40791);

                            f_10304_40559_40790(f_10304_40572_40598(candidate) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(10304, 40572, 40669) || f_10304_40607_40621(candidate) == WellKnownMemberNames.InstanceConstructorName) || (DynAbs.Tracing.TraceSender.Expression_False(10304, 40572, 40683) || arity == 0), "Can only have a 0-arity, non-constructor candidate if the desired arity is 0.");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 40815, 41891) || true) && (viable == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 40815, 41891);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 40883, 40927);

                                viable = f_10304_40892_40926();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 40953, 40975);

                                f_10304_40953_40974(viable, candidate);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 40815, 41891);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 40815, 41891);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 41073, 41127);

                                bool
                                oldArityIsZero = f_10304_41095_41121(f_10304_41095_41104(viable, 0)) == 0
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 41153, 41207);

                                bool
                                newArityIsZero = f_10304_41175_41201(candidate) == 0
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 41543, 41868) || true) && (!oldArityIsZero || (DynAbs.Tracing.TraceSender.Expression_False(10304, 41547, 41580) || newArityIsZero))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 41543, 41868);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 41638, 41787) || true) && (!oldArityIsZero && (DynAbs.Tracing.TraceSender.Expression_True(10304, 41642, 41675) && newArityIsZero))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 41638, 41787);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 41741, 41756);

                                        f_10304_41741_41755(viable);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 41638, 41787);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 41819, 41841);

                                    f_10304_41819_41840(
                                                                viable, candidate);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 41543, 41868);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 40815, 41891);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 40442, 41910);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 36426, 41925);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10304, 1, 5500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10304, 1, 5500);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 41941, 42085) || true) && (viable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 41941, 42085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 41993, 42016);

                    ambiguityWinner = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 42034, 42070);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 41941, 42085);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 42101, 42504) || true) && (f_10304_42105_42117(viable) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 42101, 42504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 42155, 42183);

                    ambiguityWinner = f_10304_42173_42182(viable, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 42201, 42257);

                    CrefSyntax
                    crefSyntax = f_10304_42225_42256(memberSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 42275, 42400);

                    f_10304_42275_42399(diagnostics, ErrorCode.WRN_AmbiguousXMLReference, f_10304_42328_42347(crefSyntax), f_10304_42349_42370(crefSyntax), ambiguityWinner, f_10304_42389_42398(viable, 1));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 42101, 42504);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 42101, 42504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 42466, 42489);

                    ambiguityWinner = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 42101, 42504);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 42520, 42555);

                return f_10304_42527_42554(viable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10304, 36101, 42566);

                Microsoft.CodeAnalysis.SymbolKind
                f_10304_37166_37180(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 37166, 37180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10304_37420_37446(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 37420, 37446);
                    return return_v;
                }


                bool
                f_10304_37508_37532(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 37508, 37532);
                    return return_v;
                }


                int
                f_10304_37829_37850(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 37829, 37850);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10304_38191_38251(int
                count)
                {
                    var return_v = IndexedTypeParameterSymbol.TakeSymbols(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 38191, 38251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyMethodSymbol
                f_10304_38045_39118(Microsoft.CodeAnalysis.MethodKind
                methodKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.Cci.CallingConvention
                callingConvention, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                containingType, string
                name, Microsoft.CodeAnalysis.RefKind
                refKind, bool
                isInitOnly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                explicitInterfaceImplementations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyMethodSymbol(methodKind: methodKind, typeParameters: typeParameters, parameters: parameters, callingConvention: callingConvention, containingType: containingType, name: name, refKind: refKind, isInitOnly: isInitOnly, returnType: returnType, refCustomModifiers: refCustomModifiers, explicitInterfaceImplementations: explicitInterfaceImplementations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 38045, 39118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyPropertySymbol
                f_10304_39393_40034(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                containingType, string
                name, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, bool
                isStatic, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                explicitInterfaceImplementations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyPropertySymbol(parameters: parameters, containingType: containingType, name: name, refKind: refKind, type: type, refCustomModifiers: refCustomModifiers, isStatic: isStatic, explicitInterfaceImplementations: explicitInterfaceImplementations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 39393, 40034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10304_40320_40334(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 40320, 40334);
                    return return_v;
                }


                System.Exception
                f_10304_40285_40335(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 40285, 40335);
                    return return_v;
                }


                bool
                f_10304_40446_40517(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 40446, 40517);
                    return return_v;
                }


                int
                f_10304_40572_40598(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 40572, 40598);
                    return return_v;
                }


                string
                f_10304_40607_40621(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 40607, 40621);
                    return return_v;
                }


                int
                f_10304_40559_40790(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 40559, 40790);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_40892_40926()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 40892, 40926);
                    return return_v;
                }


                int
                f_10304_40953_40974(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 40953, 40974);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10304_41095_41104(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 41095, 41104);
                    return return_v;
                }


                int
                f_10304_41095_41121(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 41095, 41121);
                    return return_v;
                }


                int
                f_10304_41175_41201(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 41175, 41201);
                    return return_v;
                }


                int
                f_10304_41741_41755(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 41741, 41755);
                    return 0;
                }


                int
                f_10304_41819_41840(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 41819, 41840);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_36455_36465_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 36455, 36465);
                    return return_v;
                }


                int
                f_10304_42105_42117(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 42105, 42117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10304_42173_42182(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 42173, 42182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                f_10304_42225_42256(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax)
                {
                    var return_v = GetRootCrefSyntax(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 42225, 42256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10304_42328_42347(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 42328, 42347);
                    return return_v;
                }


                string
                f_10304_42349_42370(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 42349, 42370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10304_42389_42398(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 42389, 42398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10304_42275_42399(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 42275, 42399);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10304_42527_42554(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 42527, 42554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 36101, 42566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 36101, 42566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol ConstructWithCrefTypeParameters(int arity, TypeArgumentListSyntax? typeArgumentListSyntax, Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 42738, 44527);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 42883, 44486) || true) && (arity > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 42883, 44486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 42930, 42977);

                    f_10304_42930_42976(typeArgumentListSyntax is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 42995, 43083);

                    SeparatedSyntaxList<TypeSyntax>
                    typeArgumentSyntaxes = f_10304_43050_43082(typeArgumentListSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 43101, 43189);

                    var
                    typeArgumentsWithAnnotations = f_10304_43136_43188(arity)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 43209, 43271);

                    DiagnosticBag
                    unusedDiagnostics = f_10304_43243_43270()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 43298, 43303);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 43289, 43978) || true) && (i < arity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 43316, 43319)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 43289, 43978))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 43289, 43978);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 43361, 43417);

                            TypeSyntax
                            typeArgumentSyntax = typeArgumentSyntaxes[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 43441, 43508);

                            var
                            typeArgument = f_10304_43460_43507(this, typeArgumentSyntax, unusedDiagnostics)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 43530, 43577);

                            f_10304_43530_43576(typeArgumentsWithAnnotations, typeArgument);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 43670, 43909);

                            f_10304_43670_43908(f_10304_43683_43721(typeArgumentSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(10304, 43683, 43795) || !f_10304_43726_43795(f_10304_43726_43755(typeArgumentSyntax))) || (DynAbs.Tracing.TraceSender.Expression_False(10304, 43683, 43907) || (!f_10304_43826_43858(unusedDiagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10304, 43825, 43906) && typeArgument.Type is CrefTypeParameterSymbol))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 43933, 43959);

                            f_10304_43933_43958(
                                                unusedDiagnostics);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10304, 1, 690);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10304, 1, 690);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 43996, 44021);

                    f_10304_43996_44020(unusedDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 44041, 44471) || true) && (f_10304_44045_44056(symbol) == SymbolKind.Method)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 44041, 44471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 44119, 44212);

                        symbol = f_10304_44128_44211(((MethodSymbol)symbol), f_10304_44161_44210(typeArgumentsWithAnnotations));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 44041, 44471);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 44041, 44471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 44294, 44334);

                        f_10304_44294_44333(symbol is NamedTypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 44356, 44452);

                        symbol = f_10304_44365_44451(((NamedTypeSymbol)symbol), f_10304_44401_44450(typeArgumentsWithAnnotations));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 44041, 44471);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 42883, 44486);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 44502, 44516);

                return symbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 42738, 44527);

                int
                f_10304_42930_42976(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 42930, 42976);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                f_10304_43050_43082(Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 43050, 43082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10304_43136_43188(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 43136, 43188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10304_43243_43270()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 43243, 43270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10304_43460_43507(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 43460, 43507);
                    return return_v;
                }


                int
                f_10304_43530_43576(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 43530, 43576);
                    return 0;
                }


                bool
                f_10304_43683_43721(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 43683, 43721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10304_43726_43755(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 43726, 43755);
                    return return_v;
                }


                bool
                f_10304_43726_43795(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = tree.ReportDocumentationCommentDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 43726, 43795);
                    return return_v;
                }


                bool
                f_10304_43826_43858(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 43826, 43858);
                    return return_v;
                }


                int
                f_10304_43670_43908(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 43670, 43908);
                    return 0;
                }


                int
                f_10304_43933_43958(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 43933, 43958);
                    return 0;
                }


                int
                f_10304_43996_44020(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 43996, 44020);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10304_44045_44056(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 44045, 44056);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10304_44161_44210(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 44161, 44210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10304_44128_44211(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 44128, 44211);
                    return return_v;
                }


                int
                f_10304_44294_44333(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 44294, 44333);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10304_44401_44450(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 44401, 44450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10304_44365_44451(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 44365, 44451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 42738, 44527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 42738, 44527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<ParameterSymbol> BindCrefParameters(BaseCrefParameterListSyntax parameterListSyntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 44539, 45493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 44698, 44827);

                ArrayBuilder<ParameterSymbol>
                parameterBuilder = f_10304_44747_44826(parameterListSyntax.Parameters.Count)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 44843, 45421);
                    foreach (CrefParameterSyntax parameter in f_10304_44885_44915_I(f_10304_44885_44915(parameterListSyntax)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 44843, 45421);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 44949, 45012);

                        RefKind
                        refKind = f_10304_44967_45011(parameter.RefKindKeyword.Kind())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 45032, 45083);

                        f_10304_45032_45082(f_10304_45045_45071(parameterListSyntax) is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 45101, 45224);

                        TypeSymbol
                        type = f_10304_45119_45223(this, f_10304_45149_45163(parameter), f_10304_45183_45209(parameterListSyntax), diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 45244, 45406);

                        f_10304_45244_45405(
                                        parameterBuilder, f_10304_45265_45404(TypeWithAnnotations.Create(type), ImmutableArray<CustomModifier>.Empty, isParams: false, refKind: refKind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 44843, 45421);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10304, 1, 579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10304, 1, 579);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 45437, 45482);

                return f_10304_45444_45481(parameterBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 44539, 45493);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10304_44747_44826(int
                capacity)
                {
                    var return_v = ArrayBuilder<ParameterSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 44747, 44826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax>
                f_10304_44885_44915(Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 44885, 44915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10304_44967_45011(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                syntaxKind)
                {
                    var return_v = syntaxKind.GetRefKind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 44967, 45011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10304_45045_45071(Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 45045, 45071);
                    return return_v;
                }


                int
                f_10304_45032_45082(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 45032, 45082);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10304_45149_45163(Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 45149, 45163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10304_45183_45209(Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 45183, 45209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10304_45119_45223(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberCrefSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindCrefParameterOrReturnType(typeSyntax, (Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax)memberCrefSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 45119, 45223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol
                f_10304_45265_45404(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, bool
                isParams, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol(type, refCustomModifiers, isParams: isParams, refKind: refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 45265, 45404);
                    return return_v;
                }


                int
                f_10304_45244_45405(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 45244, 45405);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax>
                f_10304_44885_44915_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 44885, 44915);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10304_45444_45481(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 45444, 45481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 44539, 45493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 44539, 45493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol BindCrefParameterOrReturnType(TypeSyntax typeSyntax, MemberCrefSyntax memberCrefSyntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10304, 45654, 48214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 45812, 45874);

                DiagnosticBag
                unusedDiagnostics = f_10304_45846_45873()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 46312, 46360);

                f_10304_46312_46359(f_10304_46325_46358());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 46374, 46475);

                Binder
                parameterOrReturnTypeBinder = f_10304_46411_46474(this, BinderFlags.CrefParameterOrReturnType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 46850, 47114);

                f_10304_46850_47113(!f_10304_46864_46922(f_10304_46864_46880(this), f_10304_46900_46921(typeSyntax)) || (DynAbs.Tracing.TraceSender.Expression_False(10304, 46863, 47112) || f_10304_46943_47021(f_10304_46943_46999(f_10304_46943_46959(this), f_10304_46977_46998(typeSyntax)), typeSyntax).Flags ==
                                (parameterOrReturnTypeBinder.Flags & ~BinderFlags.SemanticModel)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 47130, 47221);

                TypeSymbol
                type = f_10304_47148_47215(parameterOrReturnTypeBinder, typeSyntax, unusedDiagnostics).Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 47237, 48134) || true) && (f_10304_47241_47273(unusedDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 47237, 48134);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 47307, 47873) || true) && (f_10304_47311_47349(unusedDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 47307, 47873);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 47391, 47433);

                        f_10304_47391_47432(f_10304_47404_47421(typeSyntax) is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 47455, 47661);

                        ErrorCode
                        code = (DynAbs.Tracing.TraceSender.Conditional_F1(10304, 47472, 47539) || ((f_10304_47472_47496(f_10304_47472_47489(typeSyntax)) == SyntaxKind.ConversionOperatorMemberCref
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10304, 47567, 47600)) || DynAbs.Tracing.TraceSender.Conditional_F3(10304, 47628, 47660))) ? ErrorCode.WRN_BadXMLRefReturnType
                        : ErrorCode.WRN_BadXMLRefParamType
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 47683, 47743);

                        CrefSyntax
                        crefSyntax = f_10304_47707_47742(memberCrefSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 47765, 47854);

                        f_10304_47765_47853(diagnostics, code, f_10304_47787_47806(typeSyntax), f_10304_47808_47829(typeSyntax), f_10304_47831_47852(crefSyntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 47307, 47873);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 47237, 48134);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 47237, 48134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 47939, 48119);

                    f_10304_47939_48118(f_10304_47952_47965(type) != TypeKind.Error || (DynAbs.Tracing.TraceSender.Expression_False(10304, 47952, 48017) || f_10304_47987_48017(typeSyntax)) || (DynAbs.Tracing.TraceSender.Expression_False(10304, 47952, 48083) || !f_10304_48022_48083(f_10304_48022_48043(typeSyntax))), "Why wasn't there a diagnostic?");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 47237, 48134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 48150, 48175);

                f_10304_48150_48174(
                            unusedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 48191, 48203);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10304, 45654, 48214);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10304_45846_45873()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 45846, 45873);
                    return return_v;
                }


                bool
                f_10304_46325_46358()
                {
                    var return_v = InCrefButNotParameterOrReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 46325, 46358);
                    return return_v;
                }


                int
                f_10304_46312_46359(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 46312, 46359);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10304_46411_46474(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 46411, 46474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10304_46864_46880(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 46864, 46880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10304_46900_46921(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 46900, 46921);
                    return return_v;
                }


                bool
                f_10304_46864_46922(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.ContainsSyntaxTree(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 46864, 46922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10304_46943_46959(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 46943, 46959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10304_46977_46998(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 46977, 46998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10304_46943_46999(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 46943, 46999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10304_46943_47021(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 46943, 47021);
                    return return_v;
                }


                int
                f_10304_46850_47113(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 46850, 47113);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10304_47148_47215(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 47148, 47215);
                    return return_v;
                }


                bool
                f_10304_47241_47273(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 47241, 47273);
                    return return_v;
                }


                bool
                f_10304_47311_47349(Microsoft.CodeAnalysis.DiagnosticBag
                unusedDiagnostics)
                {
                    var return_v = HasNonObsoleteError(unusedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 47311, 47349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10304_47404_47421(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 47404, 47421);
                    return return_v;
                }


                int
                f_10304_47391_47432(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 47391, 47432);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10304_47472_47489(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 47472, 47489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10304_47472_47496(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 47472, 47496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                f_10304_47707_47742(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                syntax)
                {
                    var return_v = GetRootCrefSyntax(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 47707, 47742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10304_47787_47806(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 47787, 47806);
                    return return_v;
                }


                string
                f_10304_47808_47829(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 47808, 47829);
                    return return_v;
                }


                string
                f_10304_47831_47852(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 47831, 47852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10304_47765_47853(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 47765, 47853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10304_47952_47965(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 47952, 47965);
                    return return_v;
                }


                bool
                f_10304_47987_48017(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 47987, 48017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10304_48022_48043(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 48022, 48043);
                    return return_v;
                }


                bool
                f_10304_48022_48083(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = tree.ReportDocumentationCommentDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 48022, 48083);
                    return return_v;
                }


                int
                f_10304_47939_48118(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 47939, 48118);
                    return 0;
                }


                int
                f_10304_48150_48174(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 48150, 48174);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 45654, 48214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 45654, 48214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasNonObsoleteError(DiagnosticBag unusedDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10304, 48226, 49111);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 48323, 49073);
                    foreach (Diagnostic diag in f_10304_48351_48383_I(f_10304_48351_48383(unusedDiagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 48323, 49073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 48596, 49058);

                        switch ((ErrorCode)f_10304_48615_48624(diag))
                        {

                            case ErrorCode.ERR_DeprecatedSymbolStr:
                            case ErrorCode.ERR_DeprecatedCollectionInitAddStr:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 48596, 49058);
                                DynAbs.Tracing.TraceSender.TraceBreak(10304, 48803, 48809);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 48596, 49058);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 48596, 49058);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 48865, 49007) || true) && (f_10304_48869_48882(diag) == DiagnosticSeverity.Error)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10304, 48865, 49007);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 48968, 48980);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 48865, 49007);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10304, 49033, 49039);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 48596, 49058);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10304, 48323, 49073);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10304, 1, 751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10304, 1, 751);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 49087, 49100);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10304, 48226, 49111);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10304_48351_48383(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 48351, 48383);
                    return return_v;
                }


                int
                f_10304_48615_48624(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 48615, 48624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10304_48869_48882(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 48869, 48882);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10304_48351_48383_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 48351, 48383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 48226, 49111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 48226, 49111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CrefSyntax GetRootCrefSyntax(MemberCrefSyntax syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10304, 49123, 49467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 49216, 49257);

                SyntaxNode?
                parentSyntax = f_10304_49243_49256(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10304, 49306, 49456);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10304, 49313, 49385) || ((parentSyntax == null || (DynAbs.Tracing.TraceSender.Expression_False(10304, 49313, 49385) || f_10304_49337_49385(parentSyntax, SyntaxKind.XmlCrefAttribute)) && DynAbs.Tracing.TraceSender.Conditional_F2(10304, 49405, 49411)) || DynAbs.Tracing.TraceSender.Conditional_F3(10304, 49431, 49455))) ? syntax
                : (CrefSyntax)parentSyntax;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10304, 49123, 49467);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10304_49243_49256(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10304, 49243, 49256);
                    return return_v;
                }


                bool
                f_10304_49337_49385(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10304, 49337, 49385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10304, 49123, 49467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10304, 49123, 49467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
