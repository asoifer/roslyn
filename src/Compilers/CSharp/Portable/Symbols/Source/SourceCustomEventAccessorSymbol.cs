// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourceCustomEventAccessorSymbol : SourceEventAccessorSymbol
    {
        internal SourceCustomEventAccessorSymbol(
                    SourceEventSymbol @event,
                    AccessorDeclarationSyntax syntax,
                    EventSymbol explicitlyImplementedEventOpt,
                    string aliasQualifierOpt,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics)
        : base(f_10243_1136_1142_C(@event), f_10243_1164_1185(syntax), f_10243_1207_1258(syntax.Keyword.GetLocation()), explicitlyImplementedEventOpt, aliasQualifierOpt, isAdder: f_10243_1339_1352(syntax) == SyntaxKind.AddAccessorDeclaration, isIterator: f_10243_1423_1466(f_10243_1454_1465(syntax)), isNullableAnalysisEnabled: isNullableAnalysisEnabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10243, 808, 2618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 1566, 1595);

                f_10243_1566_1594(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 1609, 1731);

                f_10243_1609_1730(f_10243_1622_1635(syntax) == SyntaxKind.AddAccessorDeclaration || (DynAbs.Tracing.TraceSender.Expression_False(10243, 1622, 1729) || f_10243_1676_1689(syntax) == SyntaxKind.RemoveAccessorDeclaration));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 1747, 1853);

                f_10243_1747_1852(this, syntax, f_10243_1797_1810(this), hasBody: true, diagnostics: diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 1869, 2302) || true) && (f_10243_1873_1884(syntax) != null || (DynAbs.Tracing.TraceSender.Expression_False(10243, 1873, 1925) || f_10243_1896_1917(syntax) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10243, 1869, 2302);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 1959, 2113) || true) && (f_10243_1963_1971() && (DynAbs.Tracing.TraceSender.Expression_True(10243, 1963, 1986) && f_10243_1975_1986_M(!IsAbstract)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10243, 1959, 2113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 2028, 2094);

                        f_10243_2028_2093(diagnostics, ErrorCode.ERR_ExternHasBody, f_10243_2073_2086(this), this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10243, 1959, 2113);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10243, 1869, 2302);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 2318, 2485) || true) && (syntax.Modifiers.Count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10243, 2318, 2485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 2382, 2470);

                    f_10243_2382_2469(diagnostics, ErrorCode.ERR_NoModifiersOnAccessor, f_10243_2435_2451(syntax)[0].GetLocation());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10243, 2318, 2485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 2501, 2607);

                f_10243_2501_2606(f_10243_2550_2561(syntax), f_10243_2563_2584(syntax), syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10243, 808, 2618);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10243, 808, 2618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10243, 808, 2618);
            }
        }

        internal AccessorDeclarationSyntax GetSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10243, 2630, 2832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 2701, 2742);

                f_10243_2701_2741(syntaxReferenceOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 2756, 2821);

                return (AccessorDeclarationSyntax)f_10243_2790_2820(syntaxReferenceOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10243, 2630, 2832);

                int
                f_10243_2701_2741(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 2701, 2741);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10243_2790_2820(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 2790, 2820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10243, 2630, 2832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10243, 2630, 2832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10243, 2920, 3022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 2956, 3007);

                    return f_10243_2963_3006(f_10243_2963_2984(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10243, 2920, 3022);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10243_2963_2984(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 2963, 2984);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Accessibility
                    f_10243_2963_3006(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 2963, 3006);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10243, 2844, 3033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10243, 2844, 3033);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10243, 3045, 3220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 3157, 3209);

                return f_10243_3164_3208(f_10243_3181_3207(f_10243_3181_3192(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10243, 3045, 3220);

                Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                f_10243_3181_3192(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventAccessorSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 3181, 3192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10243_3181_3207(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 3181, 3207);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10243_3164_3208(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 3164, 3208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10243, 3045, 3220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10243, 3045, 3220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10243, 3298, 3319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 3304, 3317);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10243, 3298, 3319);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10243, 3232, 3330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10243, 3232, 3330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10243, 3407, 3427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 3413, 3425);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10243, 3407, 3427);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10243, 3342, 3438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10243, 3342, 3438);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10243, 3516, 3771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 3552, 3577);

                    var
                    syntax = f_10243_3565_3576(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 3595, 3629);

                    var
                    hasBody = f_10243_3609_3620(syntax) != null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 3647, 3701);

                    var
                    hasExpressionBody = f_10243_3671_3692(syntax) != null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10243, 3719, 3756);

                    return !hasBody && (DynAbs.Tracing.TraceSender.Expression_True(10243, 3726, 3755) && hasExpressionBody);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10243, 3516, 3771);

                    Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    f_10243_3565_3576(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 3565, 3576);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                    f_10243_3609_3620(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Body;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 3609, 3620);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                    f_10243_3671_3692(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.ExpressionBody;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 3671, 3692);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10243, 3450, 3782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10243, 3450, 3782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceCustomEventAccessorSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10243, 710, 3789);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10243, 710, 3789);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10243, 710, 3789);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10243, 710, 3789);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10243_1164_1185(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 1164, 1185);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10243_1207_1258(Microsoft.CodeAnalysis.Location
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 1207, 1258);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10243_1339_1352(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Kind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 1339, 1352);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10243_1454_1465(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 1454, 1465);
            return return_v;
        }


        static bool
        f_10243_1423_1466(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        node)
        {
            var return_v = SyntaxFacts.HasYieldOperations((Microsoft.CodeAnalysis.SyntaxNode?)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 1423, 1466);
            return return_v;
        }


        int
        f_10243_1566_1594(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 1566, 1594);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10243_1622_1635(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Kind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 1622, 1635);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10243_1676_1689(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Kind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 1676, 1689);
            return return_v;
        }


        int
        f_10243_1609_1730(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 1609, 1730);
            return 0;
        }


        Microsoft.CodeAnalysis.Location
        f_10243_1797_1810(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventAccessorSymbol
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 1797, 1810);
            return return_v;
        }


        int
        f_10243_1747_1852(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventAccessorSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        declarationSyntax, Microsoft.CodeAnalysis.Location
        location, bool
        hasBody, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.CheckFeatureAvailabilityAndRuntimeSupport((Microsoft.CodeAnalysis.SyntaxNode)declarationSyntax, location, hasBody: hasBody, diagnostics: diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 1747, 1852);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10243_1873_1884(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 1873, 1884);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10243_1896_1917(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 1896, 1917);
            return return_v;
        }


        bool
        f_10243_1963_1971()
        {
            var return_v = IsExtern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 1963, 1971);
            return return_v;
        }


        bool
        f_10243_1975_1986_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 1975, 1986);
            return return_v;
        }


        Microsoft.CodeAnalysis.Location
        f_10243_2073_2086(Microsoft.CodeAnalysis.CSharp.Symbols.SourceCustomEventAccessorSymbol
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 2073, 2086);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10243_2028_2093(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 2028, 2093);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTokenList
        f_10243_2435_2451(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 2435, 2451);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10243_2382_2469(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 2382, 2469);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10243_2550_2561(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 2550, 2561);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10243_2563_2584(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10243, 2563, 2584);
            return return_v;
        }


        int
        f_10243_2501_2606(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        expression, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        syntax, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            CheckForBlockAndExpressionBody((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)block, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)expression, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10243, 2501, 2606);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        f_10243_1136_1142_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10243, 808, 2618);
            return return_v;
        }

    }
}
