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
    internal sealed class SourceUserDefinedConversionSymbol : SourceUserDefinedOperatorSymbolBase
    {
        public static SourceUserDefinedConversionSymbol CreateUserDefinedConversionSymbol(
                    SourceMemberContainerTypeSymbol containingType,
                    ConversionOperatorDeclarationSyntax syntax,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10277, 531, 1456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 1028, 1064);

                var
                location = f_10277_1043_1063(f_10277_1043_1054(syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 1078, 1286);

                string
                name = (DynAbs.Tracing.TraceSender.Conditional_F1(10277, 1092, 1159) || ((syntax.ImplicitOrExplicitKeyword.IsKind(SyntaxKind.ImplicitKeyword) && DynAbs.Tracing.TraceSender.Conditional_F2(10277, 1179, 1222)) || DynAbs.Tracing.TraceSender.Conditional_F3(10277, 1242, 1285))) ? WellKnownMemberNames.ImplicitConversionName
                : WellKnownMemberNames.ExplicitConversionName
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 1302, 1445);

                return f_10277_1309_1444(containingType, name, location, syntax, isNullableAnalysisEnabled, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10277, 531, 1456);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10277_1043_1054(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 1043, 1054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10277_1043_1063(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 1043, 1063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                f_10277_1309_1444(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType, string
                name, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                syntax, bool
                isNullableAnalysisEnabled, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol(containingType, name, location, syntax, isNullableAnalysisEnabled, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 1309, 1444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10277, 531, 1456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10277, 531, 1456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SourceUserDefinedConversionSymbol(
                    SourceMemberContainerTypeSymbol containingType,
                    string name,
                    Location location,
                    ConversionOperatorDeclarationSyntax syntax,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics) : base(
        f_10277_2028_2049_C(MethodKind.Conversion), name, containingType, location, syntax, f_10277_2176_2231(syntax, location, diagnostics), hasBody: f_10277_2259_2278(syntax), isExpressionBodied: f_10277_2317_2328(syntax) == null && (DynAbs.Tracing.TraceSender.Expression_True(10277, 2317, 2369) && f_10277_2340_2361(syntax) != null), isIterator: f_10277_2400_2443(f_10277_2431_2442(syntax)), isNullableAnalysisEnabled: isNullableAnalysisEnabled, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10277, 1686, 2890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 2570, 2676);

                f_10277_2570_2675(f_10277_2619_2630(syntax), f_10277_2632_2653(syntax), syntax, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 2692, 2879) || true) && (f_10277_2696_2716(syntax).Parameters.Count != 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10277, 2692, 2879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 2772, 2864);

                    f_10277_2772_2863(diagnostics, ErrorCode.ERR_OvlUnaryOperatorExpected, f_10277_2828_2862(f_10277_2828_2848(syntax)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10277, 2692, 2879);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10277, 1686, 2890);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10277, 1686, 2890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10277, 1686, 2890);
            }
        }

        internal ConversionOperatorDeclarationSyntax GetSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10277, 2902, 3124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 2983, 3024);

                f_10277_2983_3023(syntaxReferenceOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 3038, 3113);

                return (ConversionOperatorDeclarationSyntax)f_10277_3082_3112(syntaxReferenceOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10277, 2902, 3124);

                int
                f_10277_2983_3023(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 2983, 3023);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10277_3082_3112(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 3082, 3112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10277, 2902, 3124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10277, 2902, 3124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10277, 3136, 3272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 3213, 3261);

                return f_10277_3220_3260(f_10277_3220_3245(f_10277_3220_3231(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10277, 3136, 3272);

                Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                f_10277_3220_3231(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 3220, 3231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10277_3220_3245(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 3220, 3245);
                    return return_v;
                }


                int
                f_10277_3220_3260(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 3220, 3260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10277, 3136, 3272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10277, 3136, 3272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Location ReturnTypeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10277, 3355, 3439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 3391, 3424);

                    return f_10277_3398_3423(f_10277_3398_3414(f_10277_3398_3409(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10277, 3355, 3439);

                    Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                    f_10277_3398_3409(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 3398, 3409);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    f_10277_3398_3414(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 3398, 3414);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10277_3398_3423(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 3398, 3423);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10277, 3284, 3450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10277, 3284, 3450);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10277, 3527, 3547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 3533, 3545);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10277, 3527, 3547);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10277, 3462, 3558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10277, 3462, 3558);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10277, 3570, 3757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 3689, 3746);

                return f_10277_3696_3745(f_10277_3713_3744(f_10277_3713_3729(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10277, 3570, 3757);

                Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                f_10277_3713_3729(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 3713, 3729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10277_3713_3744(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 3713, 3744);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10277_3696_3745(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 3696, 3745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10277, 3570, 3757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10277, 3570, 3757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10277, 3769, 4136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 3948, 4016);

                ConversionOperatorDeclarationSyntax
                declarationSyntax = f_10277_4004_4015(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10277, 4030, 4125);

                return f_10277_4037_4124(this, declarationSyntax, f_10277_4088_4110(declarationSyntax), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10277, 3769, 4136);

                Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                f_10277_4004_4015(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 4004, 4015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10277_4088_4110(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 4088, 4110);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations ReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol> Parameters)
                f_10277_4037_4124(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedConversionSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                declarationSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                returnTypeSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeParametersAndBindReturnType((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)declarationSyntax, returnTypeSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 4037, 4124);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10277, 3769, 4136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10277, 3769, 4136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceUserDefinedConversionSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10277, 421, 4143);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10277, 421, 4143);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10277, 421, 4143);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10277, 421, 4143);

        static Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10277_2176_2231(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
        syntax, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = MakeDeclarationModifiers((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)syntax, location, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 2176, 2231);
            return return_v;
        }


        static bool
        f_10277_2259_2278(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
        declaration)
        {
            var return_v = declaration.HasAnyBody();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 2259, 2278);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10277_2317_2328(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 2317, 2328);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10277_2340_2361(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 2340, 2361);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10277_2431_2442(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 2431, 2442);
            return return_v;
        }


        static bool
        f_10277_2400_2443(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        node)
        {
            var return_v = SyntaxFacts.HasYieldOperations((Microsoft.CodeAnalysis.SyntaxNode?)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 2400, 2443);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10277_2619_2630(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 2619, 2630);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10277_2632_2653(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 2632, 2653);
            return return_v;
        }


        int
        f_10277_2570_2675(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        expression, Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
        syntax, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            CheckForBlockAndExpressionBody((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)block, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)expression, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 2570, 2675);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        f_10277_2696_2716(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ParameterList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 2696, 2716);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        f_10277_2828_2848(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ParameterList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10277, 2828, 2848);
            return return_v;
        }


        Microsoft.CodeAnalysis.Location
        f_10277_2828_2862(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        this_param)
        {
            var return_v = this_param.GetLocation();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 2828, 2862);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10277_2772_2863(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10277, 2772, 2863);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MethodKind
        f_10277_2028_2049_C(Microsoft.CodeAnalysis.MethodKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10277, 1686, 2890);
            return return_v;
        }

    }
}
