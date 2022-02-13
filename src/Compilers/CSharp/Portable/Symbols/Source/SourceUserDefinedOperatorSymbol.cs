// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourceUserDefinedOperatorSymbol : SourceUserDefinedOperatorSymbolBase
    {
        public static SourceUserDefinedOperatorSymbol CreateUserDefinedOperatorSymbol(
                    SourceMemberContainerTypeSymbol containingType,
                    OperatorDeclarationSyntax syntax,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10278, 544, 1138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 840, 890);

                var
                location = syntax.OperatorToken.GetLocation()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 906, 970);

                string
                name = f_10278_920_969(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 986, 1127);

                return f_10278_993_1126(containingType, name, location, syntax, isNullableAnalysisEnabled, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10278, 544, 1138);

                string
                f_10278_920_969(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                declaration)
                {
                    var return_v = OperatorFacts.OperatorNameFromDeclaration(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 920, 969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbol
                f_10278_993_1126(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType, string
                name, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                syntax, bool
                isNullableAnalysisEnabled, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbol(containingType, name, location, syntax, isNullableAnalysisEnabled, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 993, 1126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10278, 544, 1138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10278, 544, 1138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SourceUserDefinedOperatorSymbol(
                    SourceMemberContainerTypeSymbol containingType,
                    string name,
                    Location location,
                    OperatorDeclarationSyntax syntax,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics) : base(
        f_10278_1698_1728_C(MethodKind.UserDefinedOperator), name, containingType, location, syntax, f_10278_1855_1910(syntax, location, diagnostics), hasBody: f_10278_1938_1957(syntax), isExpressionBodied: f_10278_1996_2007(syntax) == null && (DynAbs.Tracing.TraceSender.Expression_True(10278, 1996, 2048) && f_10278_2019_2040(syntax) != null), isIterator: f_10278_2079_2122(f_10278_2110_2121(syntax)), isNullableAnalysisEnabled: isNullableAnalysisEnabled, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10278, 1368, 2688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 2249, 2355);

                f_10278_2249_2354(f_10278_2298_2309(syntax), f_10278_2311_2332(syntax), syntax, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 2371, 2677) || true) && (name != WellKnownMemberNames.EqualityOperatorName && (DynAbs.Tracing.TraceSender.Expression_True(10278, 2375, 2479) && name != WellKnownMemberNames.InequalityOperatorName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10278, 2371, 2677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 2513, 2662);

                    f_10278_2513_2661(this, syntax, location, hasBody: f_10278_2582_2593(syntax) != null || (DynAbs.Tracing.TraceSender.Expression_False(10278, 2582, 2634) || f_10278_2605_2626(syntax) != null), diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10278, 2371, 2677);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10278, 1368, 2688);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10278, 1368, 2688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10278, 1368, 2688);
            }
        }

        internal OperatorDeclarationSyntax GetSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10278, 2700, 2902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 2771, 2812);

                f_10278_2771_2811(syntaxReferenceOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 2826, 2891);

                return (OperatorDeclarationSyntax)f_10278_2860_2890(syntaxReferenceOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10278, 2700, 2902);

                int
                f_10278_2771_2811(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 2771, 2811);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10278_2860_2890(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 2860, 2890);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10278, 2700, 2902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10278, 2700, 2902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10278, 2914, 3050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 2991, 3039);

                return f_10278_2998_3038(f_10278_2998_3023(f_10278_2998_3009(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10278, 2914, 3050);

                Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                f_10278_2998_3009(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 2998, 3009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10278_2998_3023(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 2998, 3023);
                    return return_v;
                }


                int
                f_10278_2998_3038(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 2998, 3038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10278, 2914, 3050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10278, 2914, 3050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Location ReturnTypeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10278, 3133, 3223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 3169, 3208);

                    return f_10278_3176_3207(f_10278_3176_3198(f_10278_3176_3187(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10278, 3133, 3223);

                    Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                    f_10278_3176_3187(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbol
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 3176, 3187);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    f_10278_3176_3198(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 3176, 3198);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10278_3176_3207(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 3176, 3207);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10278, 3062, 3234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10278, 3062, 3234);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10278, 3311, 3331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 3317, 3329);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10278, 3311, 3331);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10278, 3246, 3342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10278, 3246, 3342);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10278, 3354, 3541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 3473, 3530);

                return f_10278_3480_3529(f_10278_3497_3528(f_10278_3497_3513(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10278, 3354, 3541);

                Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                f_10278_3497_3513(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 3497, 3513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10278_3497_3528(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 3497, 3528);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10278_3480_3529(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 3480, 3529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10278, 3354, 3541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10278, 3354, 3541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10278, 3553, 3916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 3732, 3790);

                OperatorDeclarationSyntax
                declarationSyntax = f_10278_3778_3789(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10278, 3804, 3905);

                return f_10278_3811_3904(this, declarationSyntax, f_10278_3862_3890(declarationSyntax), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10278, 3553, 3916);

                Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                f_10278_3778_3789(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 3778, 3789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10278_3862_3890(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 3862, 3890);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations ReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol> Parameters)
                f_10278_3811_3904(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                declarationSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                returnTypeSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeParametersAndBindReturnType((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)declarationSyntax, returnTypeSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 3811, 3904);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10278, 3553, 3916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10278, 3553, 3916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceUserDefinedOperatorSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10278, 436, 3923);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10278, 436, 3923);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10278, 436, 3923);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10278, 436, 3923);

        static Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10278_1855_1910(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
        syntax, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = MakeDeclarationModifiers((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)syntax, location, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 1855, 1910);
            return return_v;
        }


        static bool
        f_10278_1938_1957(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
        declaration)
        {
            var return_v = declaration.HasAnyBody();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 1938, 1957);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10278_1996_2007(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 1996, 2007);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10278_2019_2040(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 2019, 2040);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10278_2110_2121(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 2110, 2121);
            return return_v;
        }


        static bool
        f_10278_2079_2122(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        node)
        {
            var return_v = SyntaxFacts.HasYieldOperations((Microsoft.CodeAnalysis.SyntaxNode?)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 2079, 2122);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10278_2298_2309(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 2298, 2309);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10278_2311_2332(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 2311, 2332);
            return return_v;
        }


        int
        f_10278_2249_2354(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        expression, Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
        syntax, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            CheckForBlockAndExpressionBody((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)block, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)expression, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 2249, 2354);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10278_2582_2593(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 2582, 2593);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10278_2605_2626(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10278, 2605, 2626);
            return return_v;
        }


        int
        f_10278_2513_2661(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
        declarationSyntax, Microsoft.CodeAnalysis.Location
        location, bool
        hasBody, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.CheckFeatureAvailabilityAndRuntimeSupport((Microsoft.CodeAnalysis.SyntaxNode)declarationSyntax, location, hasBody: hasBody, diagnostics: diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10278, 2513, 2661);
            return 0;
        }


        static Microsoft.CodeAnalysis.MethodKind
        f_10278_1698_1728_C(Microsoft.CodeAnalysis.MethodKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10278, 1368, 2688);
            return return_v;
        }

    }
}
