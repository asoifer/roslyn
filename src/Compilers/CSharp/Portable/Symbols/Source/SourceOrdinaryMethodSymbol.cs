// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourceOrdinaryMethodSymbol : SourceOrdinaryMethodSymbolBase
    {
        private readonly TypeSymbol _explicitInterfaceType;

        private readonly bool _isExpressionBodied;

        private readonly bool _hasAnyBody;

        private readonly RefKind _refKind;

        private bool _lazyIsVararg;

        private ImmutableArray<ImmutableArray<TypeWithAnnotations>> _lazyTypeParameterConstraintTypes;

        private ImmutableArray<TypeParameterConstraintKind> _lazyTypeParameterConstraintKinds;

        private SourceOrdinaryMethodSymbol _otherPartOfPartial;

        public static SourceOrdinaryMethodSymbol CreateMethodSymbol(
                    NamedTypeSymbol containingType,
                    Binder bodyBinder,
                    MethodDeclarationSyntax syntax,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10268, 2150, 3247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 2442, 2501);

                var
                interfaceSpecifier = f_10268_2467_2500(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 2515, 2549);

                var
                nameToken = f_10268_2531_2548(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 2565, 2598);

                TypeSymbol
                explicitInterfaceType
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 2612, 2643);

                string
                discardedAliasQualifier
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 2657, 2847);

                var
                name = f_10268_2668_2846(bodyBinder, interfaceSpecifier, nameToken.ValueText, diagnostics, out explicitInterfaceType, out discardedAliasQualifier)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 2861, 2906);

                var
                location = f_10268_2876_2905(nameToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 2922, 3067);

                var
                methodKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10268, 2939, 2965) || ((interfaceSpecifier == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10268, 2985, 3004)) || DynAbs.Tracing.TraceSender.Conditional_F3(10268, 3024, 3066))) ? MethodKind.Ordinary
                : MethodKind.ExplicitInterfaceImplementation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 3083, 3236);

                return f_10268_3090_3235(containingType, explicitInterfaceType, name, location, syntax, methodKind, isNullableAnalysisEnabled, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10268, 2150, 3247);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10268_2467_2500(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 2467, 2500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10268_2531_2548(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 2531, 2548);
                    return return_v;
                }


                string
                f_10268_2668_2846(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                explicitInterfaceSpecifierOpt, string
                name, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                explicitInterfaceTypeOpt, out string
                aliasQualifierOpt)
                {
                    var return_v = ExplicitInterfaceHelpers.GetMemberNameAndInterfaceSymbol(binder, explicitInterfaceSpecifierOpt, name, diagnostics, out explicitInterfaceTypeOpt, out aliasQualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 2668, 2846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10268_2876_2905(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 2876, 2905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                f_10268_3090_3235(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                explicitInterfaceType, string
                name, Microsoft.CodeAnalysis.SourceLocation
                location, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.MethodKind
                methodKind, bool
                isNullableAnalysisEnabled, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol(containingType, explicitInterfaceType, name, (Microsoft.CodeAnalysis.Location)location, syntax, methodKind, isNullableAnalysisEnabled, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 3090, 3235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 2150, 3247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 2150, 3247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SourceOrdinaryMethodSymbol(
                    NamedTypeSymbol containingType,
                    TypeSymbol explicitInterfaceType,
                    string name,
                    Location location,
                    MethodDeclarationSyntax syntax,
                    MethodKind methodKind,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics) : base(f_10268_3631_3645_C(containingType), name, location, syntax, methodKind, isIterator: f_10268_3785_3828(f_10268_3816_3827(syntax)), isExtensionMethod: f_10268_3867_3887(syntax).Parameters.FirstOrDefault() is ParameterSyntax firstParam && (DynAbs.Tracing.TraceSender.Expression_True(10268, 3867, 4007) && f_10268_3986_4007_M(!firstParam.IsArgList)) && (DynAbs.Tracing.TraceSender.Expression_True(10268, 3867, 4096) && firstParam.Modifiers.Any(SyntaxKind.ThisKeyword)), isPartial: syntax.Modifiers.IndexOf(SyntaxKind.PartialKeyword) < 0, hasBody: f_10268_4211_4222(syntax) != null || (DynAbs.Tracing.TraceSender.Expression_False(10268, 4211, 4263) || f_10268_4234_4255(syntax) != null), isNullableAnalysisEnabled: isNullableAnalysisEnabled, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10268, 3259, 4868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 737, 759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 792, 811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 844, 855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 891, 899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 923, 936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 2118, 2137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 4392, 4439);

                _explicitInterfaceType = explicitInterfaceType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 4455, 4495);

                bool
                hasBlockBody = f_10268_4475_4486(syntax) != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 4509, 4578);

                _isExpressionBodied = !hasBlockBody && (DynAbs.Tracing.TraceSender.Expression_True(10268, 4531, 4577) && f_10268_4548_4569(syntax) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 4592, 4643);

                bool
                hasBody = hasBlockBody || (DynAbs.Tracing.TraceSender.Expression_False(10268, 4607, 4642) || _isExpressionBodied)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 4657, 4679);

                _hasAnyBody = hasBody;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 4693, 4735);

                _refKind = f_10268_4704_4734(f_10268_4704_4721(syntax));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 4751, 4857);

                f_10268_4751_4856(f_10268_4800_4811(syntax), f_10268_4813_4834(syntax), syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10268, 3259, 4868);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 3259, 4868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 3259, 4868);
            }
        }

        protected override ImmutableArray<TypeParameterSymbol> MakeTypeParameters(CSharpSyntaxNode node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 4880, 5413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 5028, 5071);

                var
                syntax = (MethodDeclarationSyntax)node
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 5085, 5402) || true) && (f_10268_5089_5101(syntax) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 5085, 5402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 5140, 5207);

                    f_10268_5140_5206(f_10268_5168_5192(syntax), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 5225, 5274);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 5085, 5402);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 5085, 5402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 5340, 5387);

                    return f_10268_5347_5386(this, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 5085, 5402);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 4880, 5413);

                int
                f_10268_5089_5101(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 5089, 5101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10268_5168_5192(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ConstraintClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 5168, 5192);
                    return return_v;
                }


                int
                f_10268_5140_5206(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                constraintClauses, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportErrorIfHasConstraints(constraintClauses, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 5140, 5206);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10268_5347_5386(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeTypeParameters(syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 5347, 5386);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 4880, 5413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 4880, 5413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters, bool IsVararg, ImmutableArray<TypeParameterConstraintClause> DeclaredConstraintsForOverrideOrImplementation) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 5425, 11315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 5713, 5738);

                var
                syntax = f_10268_5726_5737(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 5752, 5884);

                var
                withTypeParamsBinder = f_10268_5779_5883(f_10268_5779_5840(f_10268_5779_5804(this), f_10268_5822_5839(syntax)), f_10268_5851_5868(syntax), syntax, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 5900, 5925);

                SyntaxToken
                arglistToken
                = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 6366, 6500);

                var
                signatureBinder = f_10268_6388_6499(withTypeParamsBinder, BinderFlags.SuppressConstraintChecks, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 6516, 6855);

                ImmutableArray<ParameterSymbol>
                parameters = f_10268_6561_6854(signatureBinder, this, f_10268_6634_6654(syntax), out arglistToken, allowRefOrOut: true, allowThis: true, addRefReadOnlyModifier: f_10268_6787_6796() || (DynAbs.Tracing.TraceSender.Expression_False(10268, 6787, 6810) || f_10268_6800_6810()), diagnostics: diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 6871, 6938);

                _lazyIsVararg = (arglistToken.Kind() == SyntaxKind.ArgListKeyword);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 6952, 6968);

                RefKind
                refKind
                = default(RefKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 6982, 7044);

                var
                returnTypeSyntax = f_10268_7005_7043(f_10268_7005_7022(syntax), out refKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 7058, 7147);

                TypeWithAnnotations
                returnType = f_10268_7091_7146(signatureBinder, returnTypeSyntax, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 7221, 8016) || true) && (returnType.IsRestrictedType(ignoreSpanLikeTypes: true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 7221, 8016);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 7313, 8001) || true) && (returnType.SpecialType == SpecialType.System_TypedReference && (DynAbs.Tracing.TraceSender.Expression_True(10268, 7317, 7540) && (f_10268_7402_7433(f_10268_7402_7421(this)) == SpecialType.System_TypedReference || (DynAbs.Tracing.TraceSender.Expression_False(10268, 7402, 7539) || f_10268_7474_7505(f_10268_7474_7493(this)) == SpecialType.System_ArgIterator))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 7313, 8001);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 7313, 8001);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 7313, 8001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 7881, 7982);

                        f_10268_7881_7981(                    // The return type of a method, delegate, or function pointer cannot be '{0}'
                                            diagnostics, ErrorCode.ERR_MethodReturnCantBeRefAny, f_10268_7937_7963(f_10268_7937_7954(syntax)), returnType.Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 7313, 8001);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 7221, 8016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 8032, 8133);

                f_10268_8032_8132(f_10268_8045_8057(this) == RefKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10268, 8045, 8101) || !returnType.IsVoidType()) || (DynAbs.Tracing.TraceSender.Expression_False(10268, 8045, 8131) || f_10268_8105_8131(returnTypeSyntax)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 8149, 8225);

                ImmutableArray<TypeParameterConstraintClause>
                declaredConstraints = default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 8241, 10240) || true) && (f_10268_8245_8255(this) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10268, 8245, 8321) && (f_10268_8265_8298(syntax) != null || (DynAbs.Tracing.TraceSender.Expression_False(10268, 8265, 8320) || f_10268_8310_8320()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 8241, 10240);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 8854, 9738) || true) && (syntax.ConstraintClauses.Count > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 8854, 9738);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 8934, 9146);

                        f_10268_8934_9145(f_10268_8966_8983(syntax), MessageID.IDS_OverrideWithConstraints, diagnostics, f_10268_9090_9114(syntax)[0].WhereKeyword.GetLocation());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 9170, 9617);

                        declaredConstraints = f_10268_9192_9616(f_10268_9192_9304(signatureBinder, BinderFlags.GenericConstraintsClause | BinderFlags.SuppressConstraintChecks), this, f_10268_9394_9408(), f_10268_9410_9434(syntax), f_10268_9436_9460(syntax), diagnostics, performOnlyCycleSafeValidation: false, isForOverride: true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 9639, 9719);

                        f_10268_9639_9718(declaredConstraints.All(clause => clause.ConstraintTypes.IsEmpty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 8854, 9738);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 9967, 10140);
                        foreach (var param in f_10268_9989_9999_I(parameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 9967, 10140);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 10041, 10121);

                            f_10268_10041_10120(f_10268_10067_10092(param), this, declaredConstraints);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 9967, 10140);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10268, 1, 174);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10268, 1, 174);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 10160, 10225);

                    f_10268_10160_10224(returnType, this, declaredConstraints);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 8241, 10240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 10256, 10324);

                return (returnType, parameters, _lazyIsVararg, declaredConstraints);

                static void forceMethodTypeParameters(TypeWithAnnotations type, SourceOrdinaryMethodSymbol method, ImmutableArray<TypeParameterConstraintClause> declaredConstraints)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10268, 10340, 11304);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 10538, 11289);

                        type.VisitType(null, (type, args, unused2) =>
                                         {
                                             if (type.DefaultType is TypeParameterSymbol typeParameterSymbol && typeParameterSymbol.DeclaringMethod == (object)args.method)
                                             {
                                                 var asValueType = args.declaredConstraints.IsDefault ||
                                                     (args.declaredConstraints[typeParameterSymbol.Ordinal].Constraints & (TypeParameterConstraintKind.ReferenceType | TypeParameterConstraintKind.Default)) == 0;
                                                 type.TryForceResolve(asValueType);
                                             }
                                             return false;
                                         }, typePredicate: null, arg: (method, declaredConstraints), canDigThroughNullable: false, useDefaultType: true);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10268, 10340, 11304);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 10340, 11304);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 10340, 11304);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 5425, 11315);

                Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                f_10268_5726_5737(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 5726, 5737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10268_5779_5804(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 5779, 5804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10268_5822_5839(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 5822, 5839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10268_5779_5840(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 5779, 5840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10268_5851_5868(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 5851, 5868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10268_5779_5883(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                memberOpt)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)memberDeclarationOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 5779, 5883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10268_6388_6499(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                containing)
                {
                    var return_v = this_param.WithAdditionalFlagsAndContainingMemberOrLambda(flags, (Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 6388, 6499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10268_6634_6654(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 6634, 6654);
                    return return_v;
                }


                bool
                f_10268_6787_6796()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 6787, 6796);
                    return return_v;
                }


                bool
                f_10268_6800_6810()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 6800, 6810);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10268_6561_6854(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                syntax, out Microsoft.CodeAnalysis.SyntaxToken
                arglistToken, bool
                allowRefOrOut, bool
                allowThis, bool
                addRefReadOnlyModifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ParameterHelpers.MakeParameters(binder, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax)syntax, out arglistToken, allowRefOrOut: allowRefOrOut, allowThis: allowThis, addRefReadOnlyModifier: addRefReadOnlyModifier, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 6561, 6854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10268_7005_7022(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 7005, 7022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10268_7005_7043(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, out Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = syntax.SkipRef(out refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 7005, 7043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10268_7091_7146(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 7091, 7146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10268_7402_7421(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 7402, 7421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10268_7402_7433(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 7402, 7433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10268_7474_7493(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 7474, 7493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10268_7474_7505(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 7474, 7505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10268_7937_7954(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 7937, 7954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10268_7937_7963(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 7937, 7963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_7881_7981(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 7881, 7981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10268_8045_8057(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 8045, 8057);
                    return return_v;
                }


                bool
                f_10268_8105_8131(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 8105, 8131);
                    return return_v;
                }


                int
                f_10268_8032_8132(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 8032, 8132);
                    return 0;
                }


                int
                f_10268_8245_8255(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 8245, 8255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10268_8265_8298(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 8265, 8298);
                    return return_v;
                }


                bool
                f_10268_8310_8320()
                {
                    var return_v = IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 8310, 8320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10268_8966_8983(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 8966, 8983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10268_9090_9114(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ConstraintClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 9090, 9114);
                    return return_v;
                }


                bool
                f_10268_8934_9145(Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.CheckFeatureAvailability(tree, feature, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 8934, 9145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10268_9192_9304(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 9192, 9304);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10268_9394_9408()
                {
                    var return_v = TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 9394, 9408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10268_9410_9434(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 9410, 9434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10268_9436_9460(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ConstraintClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 9436, 9460);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10268_9192_9616(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                containingSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                typeParameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                clauses, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                performOnlyCycleSafeValidation, bool
                isForOverride)
                {
                    var return_v = this_param.BindTypeParameterConstraintClauses((Microsoft.CodeAnalysis.CSharp.Symbol)containingSymbol, typeParameters, typeParameterList, clauses, diagnostics, performOnlyCycleSafeValidation: performOnlyCycleSafeValidation, isForOverride: isForOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 9192, 9616);
                    return return_v;
                }


                int
                f_10268_9639_9718(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 9639, 9718);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10268_10067_10092(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 10067, 10092);
                    return return_v;
                }


                int
                f_10268_10041_10120(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                declaredConstraints)
                {
                    forceMethodTypeParameters(type, method, declaredConstraints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 10041, 10120);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10268_9989_9999_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 9989, 9999);
                    return return_v;
                }


                int
                f_10268_10160_10224(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                declaredConstraints)
                {
                    forceMethodTypeParameters(type, method, declaredConstraints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 10160, 10224);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 5425, 11315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 5425, 11315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void ExtensionMethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 11327, 14857);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 11478, 14846) || true) && (f_10268_11482_11499())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 11478, 14846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 11533, 11558);

                    var
                    syntax = f_10268_11546_11557(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 11576, 11604);

                    var
                    location = locations[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 11622, 11682);

                    var
                    parameter0Type = f_10268_11643_11681(f_10268_11643_11658(this)[0])
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 11700, 11751);

                    var
                    parameter0RefKind = f_10268_11724_11750(f_10268_11724_11739(this)[0])
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 11769, 14831) || true) && (!f_10268_11774_11825(parameter0Type.Type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 11769, 14831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 11949, 12006);

                        var
                        parameterSyntax = f_10268_11971_12002(f_10268_11971_11991(syntax))[0]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 12028, 12071);

                        f_10268_12028_12070(f_10268_12041_12061(parameterSyntax) != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 12093, 12133);

                        var
                        loc = f_10268_12103_12132(f_10268_12103_12123(parameterSyntax))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 12155, 12227);

                        f_10268_12155_12226(diagnostics, ErrorCode.ERR_BadTypeforThis, loc, parameter0Type.Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 11769, 14831);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 11769, 14831);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 12269, 14831) || true) && (parameter0RefKind == RefKind.Ref && (DynAbs.Tracing.TraceSender.Expression_True(10268, 12273, 12341) && f_10268_12309_12341_M(!parameter0Type.Type.IsValueType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 12269, 14831);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 12383, 12476);

                            f_10268_12383_12475(diagnostics, ErrorCode.ERR_RefExtensionMustBeValueTypeOrConstrainedToOne, location, f_10268_12470_12474());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 12269, 14831);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 12269, 14831);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 12518, 14831) || true) && (parameter0RefKind == RefKind.In && (DynAbs.Tracing.TraceSender.Expression_True(10268, 12522, 12599) && parameter0Type.TypeKind != TypeKind.Struct))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 12518, 14831);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 12641, 12715);

                                f_10268_12641_12714(diagnostics, ErrorCode.ERR_InExtensionMustBeValueType, location, f_10268_12709_12713());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 12518, 14831);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 12518, 14831);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 12757, 14831) || true) && ((object)f_10268_12769_12798(f_10268_12769_12783()) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 12757, 14831);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 12848, 12931);

                                    f_10268_12848_12930(diagnostics, ErrorCode.ERR_ExtensionMethodsDecl, location, f_10268_12910_12929(f_10268_12910_12924()));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 12757, 14831);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 12757, 14831);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 12973, 14831) || true) && (f_10268_12977_13006_M(!f_10268_12978_12992().IsScriptClass) && (DynAbs.Tracing.TraceSender.Expression_True(10268, 12977, 13065) && !(f_10268_13012_13035(f_10268_13012_13026()) && (DynAbs.Tracing.TraceSender.Expression_True(10268, 13012, 13064) && f_10268_13039_13059(f_10268_13039_13053()) == 0))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 12973, 14831);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 13334, 13388);

                                        var
                                        typeDecl = f_10268_13349_13362(syntax) as TypeDeclarationSyntax
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 13410, 13488);

                                        var
                                        identifier = (DynAbs.Tracing.TraceSender.Conditional_F1(10268, 13427, 13445) || (((typeDecl != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10268, 13448, 13467)) || DynAbs.Tracing.TraceSender.Conditional_F3(10268, 13470, 13487))) ? f_10268_13448_13467(typeDecl) : f_10268_13470_13487(syntax)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 13510, 13545);

                                        var
                                        loc = identifier.GetLocation()
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 13567, 13619);

                                        f_10268_13567_13618(diagnostics, ErrorCode.ERR_BadExtensionAgg, loc);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 12973, 14831);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 12973, 14831);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 13661, 14831) || true) && (f_10268_13665_13674_M(!IsStatic))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 13661, 14831);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 13716, 13774);

                                            f_10268_13716_13773(diagnostics, ErrorCode.ERR_BadExtensionMeth, location);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 13661, 14831);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 13661, 14831);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 13920, 14065);

                                            var
                                            attributeConstructor = f_10268_13947_14064(f_10268_13947_13967(), WellKnownMember.System_Runtime_CompilerServices_ExtensionAttribute__ctor)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 14087, 14812) || true) && ((object)attributeConstructor == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 14087, 14812);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 14177, 14305);

                                                var
                                                memberDescriptor = f_10268_14200_14304(WellKnownMember.System_Runtime_CompilerServices_ExtensionAttribute__ctor)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 14505, 14789);

                                                f_10268_14505_14788(                        // do not use Binder.ReportUseSiteErrorForAttributeCtor in this case, because we'll need to report a special error id, not a generic use site error.
                                                                        diagnostics, ErrorCode.ERR_ExtensionAttrNotFound, f_10268_14617_14648(f_10268_14617_14637(syntax))[0].Modifiers.FirstOrDefault(SyntaxKind.ThisKeyword).GetLocation(), memberDescriptor.DeclaringTypeMetadataName);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 14087, 14812);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 13661, 14831);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 12973, 14831);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 12757, 14831);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 12518, 14831);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 12269, 14831);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 11769, 14831);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 11478, 14846);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 11327, 14857);

                bool
                f_10268_11482_11499()
                {
                    var return_v = IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 11482, 11499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                f_10268_11546_11557(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 11546, 11557);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10268_11643_11658(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 11643, 11658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10268_11643_11681(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 11643, 11681);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10268_11724_11739(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 11724, 11739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10268_11724_11750(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 11724, 11750);
                    return return_v;
                }


                bool
                f_10268_11774_11825(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsValidExtensionParameterType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 11774, 11825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10268_11971_11991(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 11971, 11991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                f_10268_11971_12002(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 11971, 12002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10268_12041_12061(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12041, 12061);
                    return return_v;
                }


                int
                f_10268_12028_12070(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 12028, 12070);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10268_12103_12123(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12103, 12123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10268_12103_12132(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12103, 12132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_12155_12226(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 12155, 12226);
                    return return_v;
                }


                bool
                f_10268_12309_12341_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12309, 12341);
                    return return_v;
                }


                string
                f_10268_12470_12474()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12470, 12474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_12383_12475(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 12383, 12475);
                    return return_v;
                }


                string
                f_10268_12709_12713()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12709, 12713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_12641_12714(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 12641, 12714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10268_12769_12783()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12769, 12783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10268_12769_12798(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12769, 12798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10268_12910_12924()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12910, 12924);
                    return return_v;
                }


                string
                f_10268_12910_12929(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12910, 12929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_12848_12930(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 12848, 12930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10268_12978_12992()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12978, 12992);
                    return return_v;
                }


                bool
                f_10268_12977_13006_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 12977, 13006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10268_13012_13026()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 13012, 13026);
                    return return_v;
                }


                bool
                f_10268_13012_13035(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 13012, 13035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10268_13039_13053()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 13039, 13053);
                    return return_v;
                }


                int
                f_10268_13039_13059(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 13039, 13059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10268_13349_13362(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 13349, 13362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10268_13448_13467(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 13448, 13467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10268_13470_13487(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 13470, 13487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_13567_13618(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 13567, 13618);
                    return return_v;
                }


                bool
                f_10268_13665_13674_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 13665, 13674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_13716_13773(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 13716, 13773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10268_13947_13967()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 13947, 13967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10268_13947_14064(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 13947, 14064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10268_14200_14304(Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = WellKnownMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 14200, 14304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10268_14617_14637(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 14617, 14637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                f_10268_14617_14648(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 14617, 14648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_14505_14788(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 14505, 14788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 11327, 14857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 11327, 14857);
            }
        }

        protected override MethodSymbol FindExplicitlyImplementedMethod(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 14869, 15179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 14984, 15009);

                var
                syntax = f_10268_14997_15008(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 15023, 15168);

                return f_10268_15030_15167(this, _explicitInterfaceType, syntax.Identifier.ValueText, f_10268_15120_15153(syntax), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 14869, 15179);

                Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                f_10268_14997_15008(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 14997, 15008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10268_15120_15153(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 15120, 15153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10268_15030_15167(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                implementingMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                explicitInterfaceType, string
                interfaceMethodName, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                explicitInterfaceSpecifierSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = implementingMethod.FindExplicitlyImplementedMethod(explicitInterfaceType, interfaceMethodName, explicitInterfaceSpecifierSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 15030, 15167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 14869, 15179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 14869, 15179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Location ReturnTypeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 15238, 15272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 15241, 15272);
                    return f_10268_15241_15272(f_10268_15241_15263(f_10268_15241_15252(this))); DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 15238, 15272);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 15238, 15272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 15238, 15272);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override TypeSymbol ExplicitInterfaceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 15337, 15362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 15340, 15362);
                    return _explicitInterfaceType; DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 15337, 15362);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 15337, 15362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 15337, 15362);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool HasAnyBody
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 15410, 15424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 15413, 15424);
                    return _hasAnyBody; DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 15410, 15424);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 15410, 15424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 15410, 15424);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MethodDeclarationSyntax GetSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 15437, 15635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 15506, 15547);

                f_10268_15506_15546(syntaxReferenceOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 15561, 15624);

                return (MethodDeclarationSyntax)f_10268_15593_15623(syntaxReferenceOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 15437, 15635);

                int
                f_10268_15506_15546(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 15506, 15546);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10268_15593_15623(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 15593, 15623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 15437, 15635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 15437, 15635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void CompleteAsyncMethodChecksBetweenStartAndFinish()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 15647, 15874);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 15744, 15863) || true) && (f_10268_15748_15767())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 15744, 15863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 15801, 15848);

                    f_10268_15801_15847(f_10268_15801_15821(), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 15744, 15863);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 15647, 15874);

                bool
                f_10268_15748_15767()
                {
                    var return_v = IsPartialDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 15748, 15767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10268_15801_15821()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 15801, 15821);
                    return return_v;
                }


                int
                f_10268_15801_15847(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                symbol)
                {
                    this_param.SymbolDeclaredEvent((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 15801, 15847);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 15647, 15874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 15647, 15874);
            }
        }

        public override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 15886, 17083);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 16012, 17015) || true) && (_lazyTypeParameterConstraintTypes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 16012, 17015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 16093, 16127);

                    f_10268_16093_16126(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 16147, 16193);

                    var
                    diagnostics = f_10268_16165_16192()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 16211, 16236);

                    var
                    syntax = f_10268_16224_16235(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 16254, 16455);

                    var
                    withTypeParametersBinder =
                    f_10268_16306_16454(f_10268_16306_16389(f_10268_16306_16331(this), f_10268_16371_16388(syntax)), f_10268_16422_16439(syntax), syntax, this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 16473, 16742);

                    var
                    constraints = f_10268_16491_16741(this, withTypeParametersBinder, f_10268_16598_16612(), f_10268_16635_16659(syntax), f_10268_16682_16706(syntax), diagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 16760, 16963) || true) && (f_10268_16764_16858(ref _lazyTypeParameterConstraintTypes, constraints))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 16760, 16963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 16900, 16944);

                        f_10268_16900_16943(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 16760, 16963);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 16981, 17000);

                    f_10268_16981_16999(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 16012, 17015);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 17031, 17072);

                return _lazyTypeParameterConstraintTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 15886, 17083);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                f_10268_16093_16126(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeParameterConstraintKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 16093, 16126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10268_16165_16192()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 16165, 16192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                f_10268_16224_16235(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 16224, 16235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10268_16306_16331(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 16306, 16331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10268_16371_16388(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 16371, 16388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10268_16306_16389(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 16306, 16389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10268_16422_16439(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 16422, 16439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10268_16306_16454(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                memberOpt)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)memberDeclarationOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 16306, 16454);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10268_16598_16612()
                {
                    var return_v = TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 16598, 16612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10268_16635_16659(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 16635, 16659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10268_16682_16706(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ConstraintClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 16682, 16706);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>
                f_10268_16491_16741(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                binder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                typeParameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                constraintClauses, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = containingSymbol.MakeTypeParameterConstraintTypes(binder, typeParameters, typeParameterList, constraintClauses, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 16491, 16741);
                    return return_v;
                }


                bool
                f_10268_16764_16858(ref System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>
                location, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 16764, 16858);
                    return return_v;
                }


                int
                f_10268_16900_16943(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 16900, 16943);
                    return 0;
                }


                int
                f_10268_16981_16999(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 16981, 16999);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 15886, 17083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 15886, 17083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 17095, 17989);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 17213, 17921) || true) && (_lazyTypeParameterConstraintKinds.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 17213, 17921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 17294, 17319);

                    var
                    syntax = f_10268_17307_17318(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 17337, 17538);

                    var
                    withTypeParametersBinder =
                    f_10268_17389_17537(f_10268_17389_17472(f_10268_17389_17414(this), f_10268_17454_17471(syntax)), f_10268_17505_17522(syntax), syntax, this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 17556, 17791);

                    var
                    constraints = f_10268_17574_17790(this, withTypeParametersBinder, f_10268_17681_17695(), f_10268_17718_17742(syntax), f_10268_17765_17789(syntax))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 17811, 17906);

                    f_10268_17811_17905(ref _lazyTypeParameterConstraintKinds, constraints);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 17213, 17921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 17937, 17978);

                return _lazyTypeParameterConstraintKinds;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 17095, 17989);

                Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                f_10268_17307_17318(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 17307, 17318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10268_17389_17414(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 17389, 17414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10268_17454_17471(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 17454, 17471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10268_17389_17472(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 17389, 17472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10268_17505_17522(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 17505, 17522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10268_17389_17537(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                memberOpt)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)memberDeclarationOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 17389, 17537);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10268_17681_17695()
                {
                    var return_v = TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 17681, 17695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10268_17718_17742(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 17718, 17742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10268_17765_17789(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ConstraintClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 17765, 17789);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                f_10268_17574_17790(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                binder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                typeParameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                constraintClauses)
                {
                    var return_v = containingSymbol.MakeTypeParameterConstraintKinds(binder, typeParameters, typeParameterList, constraintClauses);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 17574, 17790);
                    return return_v;
                }


                bool
                f_10268_17811_17905(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 17811, 17905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 17095, 17989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 17095, 17989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 18055, 18164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 18091, 18110);

                    f_10268_18091_18109(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 18128, 18149);

                    return _lazyIsVararg;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 18055, 18164);

                    int
                    f_10268_18091_18109(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 18091, 18109);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 18001, 18175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 18001, 18175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 18240, 18283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 18243, 18283);
                return f_10268_18243_18283(f_10268_18243_18268(f_10268_18243_18254(this))); DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 18240, 18283);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 18240, 18283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 18240, 18283);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
            f_10268_18243_18254(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
            this_param)
            {
                var return_v = this_param.GetSyntax();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 18243, 18254);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            f_10268_18243_18268(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
            this_param)
            {
                var return_v = this_param.ParameterList;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 18243, 18268);
                return return_v;
            }


            int
            f_10268_18243_18283(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            this_param)
            {
                var return_v = this_param.ParameterCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 18243, 18283);
                return return_v;
            }

        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 18352, 18419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 18388, 18404);

                    return _refKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 18352, 18419);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 18296, 18430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 18296, 18430);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static void InitializePartialMethodParts(SourceOrdinaryMethodSymbol definition, SourceOrdinaryMethodSymbol implementation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10268, 18442, 19121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 18598, 18643);

                f_10268_18598_18642(f_10268_18611_18641(definition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 18657, 18710);

                f_10268_18657_18709(f_10268_18670_18708(implementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 18724, 18845);

                f_10268_18724_18844((object)definition._otherPartOfPartial == null || (DynAbs.Tracing.TraceSender.Expression_False(10268, 18737, 18843) || (object)definition._otherPartOfPartial == implementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 18859, 18984);

                f_10268_18859_18983((object)implementation._otherPartOfPartial == null || (DynAbs.Tracing.TraceSender.Expression_False(10268, 18872, 18982) || (object)implementation._otherPartOfPartial == definition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 19000, 19048);

                definition._otherPartOfPartial = implementation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 19062, 19110);

                implementation._otherPartOfPartial = definition;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10268, 18442, 19121);

                bool
                f_10268_18611_18641(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsPartialDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 18611, 18641);
                    return return_v;
                }


                int
                f_10268_18598_18642(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 18598, 18642);
                    return 0;
                }


                bool
                f_10268_18670_18708(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsPartialImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 18670, 18708);
                    return return_v;
                }


                int
                f_10268_18657_18709(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 18657, 18709);
                    return 0;
                }


                int
                f_10268_18724_18844(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 18724, 18844);
                    return 0;
                }


                int
                f_10268_18859_18983(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 18859, 18983);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 18442, 19121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 18442, 19121);
            }
        }

        internal SourceOrdinaryMethodSymbol OtherPartOfPartial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 19357, 19392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 19363, 19390);

                    return _otherPartOfPartial;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 19357, 19392);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 19278, 19403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 19278, 19403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsPartialDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 19651, 19762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 19687, 19747);

                    return f_10268_19694_19708(this) && (DynAbs.Tracing.TraceSender.Expression_True(10268, 19694, 19724) && !_hasAnyBody) && (DynAbs.Tracing.TraceSender.Expression_True(10268, 19694, 19746) && f_10268_19728_19746_M(!HasExternModifier));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 19651, 19762);

                    bool
                    f_10268_19694_19708(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsPartial;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 19694, 19708);
                        return return_v;
                    }


                    bool
                    f_10268_19728_19746_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 19728, 19746);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 19593, 19773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 19593, 19773);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsPartialImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 20029, 20140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 20065, 20125);

                    return f_10268_20072_20086(this) && (DynAbs.Tracing.TraceSender.Expression_True(10268, 20072, 20124) && (_hasAnyBody || (DynAbs.Tracing.TraceSender.Expression_False(10268, 20091, 20123) || f_10268_20106_20123())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 20029, 20140);

                    bool
                    f_10268_20072_20086(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsPartial;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 20072, 20086);
                        return return_v;
                    }


                    bool
                    f_10268_20106_20123()
                    {
                        var return_v = HasExternModifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 20106, 20123);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 19967, 20151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 19967, 20151);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsPartialWithoutImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 20367, 20489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 20403, 20474);

                    return f_10268_20410_20434(this) && (DynAbs.Tracing.TraceSender.Expression_True(10268, 20410, 20473) && (object)_otherPartOfPartial == null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 20367, 20489);

                    bool
                    f_10268_20410_20434(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsPartialDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 20410, 20434);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 20298, 20500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 20298, 20500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SourceOrdinaryMethodSymbol SourcePartialDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 20804, 20920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 20840, 20905);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10268, 20847, 20875) || ((f_10268_20847_20875(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10268, 20878, 20897)) || DynAbs.Tracing.TraceSender.Conditional_F3(10268, 20900, 20904))) ? _otherPartOfPartial : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 20804, 20920);

                    bool
                    f_10268_20847_20875(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsPartialImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 20847, 20875);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 20720, 20931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 20720, 20931);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SourceOrdinaryMethodSymbol SourcePartialImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 21243, 21355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 21279, 21340);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10268, 21286, 21310) || ((f_10268_21286_21310(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10268, 21313, 21332)) || DynAbs.Tracing.TraceSender.Conditional_F3(10268, 21335, 21339))) ? _otherPartOfPartial : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 21243, 21355);

                    bool
                    f_10268_21286_21310(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsPartialDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 21286, 21310);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 21155, 21366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 21155, 21366);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol PartialDefinitionPart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 21453, 21535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 21489, 21520);

                    return f_10268_21496_21519();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 21453, 21535);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    f_10268_21496_21519()
                    {
                        var return_v = SourcePartialDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 21496, 21519);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 21378, 21546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 21378, 21546);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol PartialImplementationPart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 21637, 21723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 21673, 21708);

                    return f_10268_21680_21707();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 21637, 21723);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    f_10268_21680_21707()
                    {
                        var return_v = SourcePartialImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 21680, 21707);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 21558, 21734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 21558, 21734);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 21807, 21988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 21843, 21973);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10268, 21850, 21869) || ((f_10268_21850_21869() && DynAbs.Tracing.TraceSender.Conditional_F2(10268, 21893, 21931)) || DynAbs.Tracing.TraceSender.Conditional_F3(10268, 21955, 21972))) ? f_10268_21893_21922_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_otherPartOfPartial, 10268, 21893, 21922)?.IsExtern) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10268, 21893, 21931) ?? false
                    ) : f_10268_21955_21972();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 21807, 21988);

                    bool
                    f_10268_21850_21869()
                    {
                        var return_v = IsPartialDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 21850, 21869);
                        return return_v;
                    }


                    bool?
                    f_10268_21893_21922_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 21893, 21922);
                        return return_v;
                    }


                    bool
                    f_10268_21955_21972()
                    {
                        var return_v = HasExternModifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 21955, 21972);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 21746, 21999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 21746, 21999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 22011, 22490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 22217, 22321);

                ref var
                lazyDocComment = ref (DynAbs.Tracing.TraceSender.Conditional_F1(10268, 22246, 22260) || ((expandIncludes && DynAbs.Tracing.TraceSender.Conditional_F2(10268, 22263, 22294)) || DynAbs.Tracing.TraceSender.Conditional_F3(10268, 22297, 22320))) ? ref this.lazyExpandedDocComment : ref this.lazyDocComment
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 22335, 22479);

                return f_10268_22342_22478(f_10268_22406_22433() ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol>(10268, 22406, 22441) ?? this), expandIncludes, ref lazyDocComment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 22011, 22490);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                f_10268_22406_22433()
                {
                    var return_v = SourcePartialImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 22406, 22433);
                    return return_v;
                }


                string
                f_10268_22342_22478(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                symbol, bool
                expandIncludes, ref string
                lazyXmlText)
                {
                    var return_v = SourceDocumentationCommentUtils.GetAndCacheDocumentationComment((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, expandIncludes, ref lazyXmlText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 22342, 22478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 22011, 22490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 22011, 22490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SourceMemberMethodSymbol BoundAttributesSource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 22592, 22679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 22628, 22664);

                    return f_10268_22635_22663(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 22592, 22679);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    f_10268_22635_22663(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.SourcePartialDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 22635, 22663);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 22502, 22690);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 22502, 22690);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 22702, 23192);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 22814, 23181) || true) && ((object)f_10268_22826_22858(this) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 22814, 23181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 22900, 23044);

                    return f_10268_22907_23043(f_10268_22924_23042(f_10268_22946_22976(), f_10268_22978_23041(f_10268_22978_23010(this))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 22814, 23181);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 22814, 23181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 23110, 23166);

                    return f_10268_23117_23165(f_10268_23134_23164());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 22814, 23181);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 22702, 23192);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                f_10268_22826_22858(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.SourcePartialImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 22826, 22858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10268_22946_22976()
                {
                    var return_v = AttributeDeclarationSyntaxList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 22946, 22976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                f_10268_22978_23010(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.SourcePartialImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 22978, 23010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10268_22978_23041(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.AttributeDeclarationSyntaxList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 22978, 23041);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10268_22924_23042(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                item1, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 22924, 23042);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10268_22907_23043(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                many)
                {
                    var return_v = OneOrMany.Create(many);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 22907, 23043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10268_23134_23164()
                {
                    var return_v = AttributeDeclarationSyntaxList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 23134, 23164);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10268_23117_23165(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 23117, 23165);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 22702, 23192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 22702, 23192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxList<AttributeListSyntax> AttributeDeclarationSyntaxList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 23299, 23690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 23335, 23412);

                    var
                    sourceContainer = f_10268_23357_23376(this) as SourceMemberContainerTypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 23430, 23607) || true) && ((object)sourceContainer != null && (DynAbs.Tracing.TraceSender.Expression_True(10268, 23434, 23507) && f_10268_23469_23507(sourceContainer)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 23430, 23607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 23549, 23588);

                        return f_10268_23556_23587(f_10268_23556_23572(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 23430, 23607);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 23627, 23675);

                    return default(SyntaxList<AttributeListSyntax>);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 23299, 23690);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10268_23357_23376(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 23357, 23376);
                        return return_v;
                    }


                    bool
                    f_10268_23469_23507(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.AnyMemberHasAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 23469, 23507);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    f_10268_23556_23572(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 23556, 23572);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    f_10268_23556_23587(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.AttributeLists;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 23556, 23587);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 23204, 23701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 23204, 23701);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 23779, 23814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 23785, 23812);

                    return _isExpressionBodied;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 23779, 23814);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 23713, 23825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 23713, 23825);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override DeclarationModifiers MakeDeclarationModifiers(DeclarationModifiers allowedModifiers, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 23837, 24210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 23992, 24017);

                var
                syntax = f_10268_24005_24016(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 24031, 24199);

                return f_10268_24038_24198(f_10268_24087_24103(syntax), defaultAccess: DeclarationModifiers.None, allowedModifiers, f_10268_24165_24174()[0], diagnostics, out _);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 23837, 24210);

                Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                f_10268_24005_24016(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 24005, 24016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10268_24087_24103(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 24087, 24103);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_24165_24174()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 24165, 24174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10268_24038_24198(Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                defaultAccess, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                allowedModifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                modifierErrors)
                {
                    var return_v = ModifierUtils.MakeAndCheckNontypeMemberModifiers(modifiers, defaultAccess: defaultAccess, allowedModifiers, errorLocation, diagnostics, out modifierErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 24038, 24198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 23837, 24210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 23837, 24210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeParameterSymbol> MakeTypeParameters(MethodDeclarationSyntax syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 24222, 27308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 24368, 24415);

                f_10268_24368_24414(f_10268_24381_24405(syntax) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 24431, 24483);

                OverriddenMethodTypeParameterMapBase
                typeMap = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 24497, 24788) || true) && (f_10268_24501_24516(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 24497, 24788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 24550, 24603);

                    typeMap = f_10268_24560_24602(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 24497, 24788);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 24497, 24788);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 24637, 24788) || true) && (f_10268_24641_24679(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 24637, 24788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 24713, 24773);

                        typeMap = f_10268_24723_24772(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 24637, 24788);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 24497, 24788);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 24804, 24861);

                var
                typeParameters = f_10268_24825_24860(f_10268_24825_24849(syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 24875, 24936);

                var
                result = f_10268_24888_24935()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 24961, 24972);

                    for (int
        ordinal = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 24952, 27246) || true) && (ordinal < typeParameters.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25006, 25015)
        , ordinal++, DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 24952, 27246))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 24952, 27246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25049, 25089);

                        var
                        parameter = typeParameters[ordinal]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25107, 25317) || true) && (parameter.VarianceKeyword.Kind() != SyntaxKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 25107, 25317);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25204, 25298);

                            f_10268_25204_25297(diagnostics, ErrorCode.ERR_IllegalVarianceSyntax, parameter.VarianceKeyword.GetLocation());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 25107, 25317);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25337, 25375);

                        var
                        identifier = f_10268_25354_25374(parameter)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25393, 25433);

                        var
                        location = identifier.GetLocation()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25451, 25483);

                        var
                        name = identifier.ValueText
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25639, 25644);

                            // Note: It is not an error to have a type parameter named the same as its enclosing method: void M<M>() {}

                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25630, 25929) || true) && (i < f_10268_25650_25662(result))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25664, 25667)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 25630, 25929))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 25630, 25929);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25709, 25910) || true) && (name == f_10268_25721_25735(f_10268_25721_25730(result, i)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 25709, 25910);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25785, 25855);

                                    f_10268_25785_25854(diagnostics, ErrorCode.ERR_DuplicateTypeParameter, location, name);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10268, 25881, 25887);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 25709, 25910);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10268, 1, 300);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10268, 1, 300);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 25949, 26070);

                        f_10268_25949_26069(identifier.Text, f_10268_26020_26045(this), diagnostics, location);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 26090, 26156);

                        var
                        tpEnclosing = f_10268_26108_26155(f_10268_26108_26122(), name)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 26174, 26486) || true) && ((object)tpEnclosing != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 26174, 26486);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 26354, 26467);

                            f_10268_26354_26466(                    // Type parameter '{0}' has the same name as the type parameter from outer type '{1}'
                                                diagnostics, ErrorCode.WRN_TypeParameterSameAsOuterTypeParameter, location, name, f_10268_26439_26465(tpEnclosing));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 26174, 26486);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 26506, 26571);

                        var
                        syntaxRefs = f_10268_26523_26570(f_10268_26545_26569(parameter))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 26589, 26637);

                        var
                        locations = f_10268_26605_26636(location)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 26655, 27185);

                        var
                        typeParameter = (DynAbs.Tracing.TraceSender.Conditional_F1(10268, 26675, 26692) || (((typeMap != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10268, 26716, 26955)) || DynAbs.Tracing.TraceSender.Conditional_F3(10268, 26979, 27184))) ? (TypeParameterSymbol)f_10268_26737_26955(typeMap, name, ordinal, locations, syntaxRefs) : f_10268_26979_27184(this, name, ordinal, locations, syntaxRefs)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 27205, 27231);

                        f_10268_27205_27230(
                                        result, typeParameter);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10268, 1, 2295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10268, 1, 2295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 27262, 27297);

                return f_10268_27269_27296(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 24222, 27308);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10268_24381_24405(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 24381, 24405);
                    return return_v;
                }


                int
                f_10268_24368_24414(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 24368, 24414);
                    return 0;
                }


                bool
                f_10268_24501_24516(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 24501, 24516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenMethodTypeParameterMap
                f_10268_24560_24602(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                overridingMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenMethodTypeParameterMap(overridingMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 24560, 24602);
                    return return_v;
                }


                bool
                f_10268_24641_24679(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 24641, 24679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExplicitInterfaceMethodTypeParameterMap
                f_10268_24723_24772(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                implementationMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExplicitInterfaceMethodTypeParameterMap(implementationMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 24723, 24772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                f_10268_24825_24849(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 24825, 24849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>
                f_10268_24825_24860(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 24825, 24860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10268_24888_24935()
                {
                    var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 24888, 24935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_25204_25297(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 25204, 25297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10268_25354_25374(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 25354, 25374);
                    return return_v;
                }


                int
                f_10268_25650_25662(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 25650, 25662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10268_25721_25730(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 25721, 25730);
                    return return_v;
                }


                string
                f_10268_25721_25735(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 25721, 25735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_25785_25854(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 25785, 25854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10268_26020_26045(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 26020, 26045);
                    return return_v;
                }


                int
                f_10268_25949_26069(string
                name, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    SourceMemberContainerTypeSymbol.ReportTypeNamedRecord(name, compilation, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 25949, 26069);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10268_26108_26122()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 26108, 26122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol?
                f_10268_26108_26155(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name)
                {
                    var return_v = type.FindEnclosingTypeParameter(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 26108, 26155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10268_26439_26465(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 26439, 26465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_26354_26466(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 26354, 26466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10268_26545_26569(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                this_param)
                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 26545, 26569);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10268_26523_26570(Microsoft.CodeAnalysis.SyntaxReference
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 26523, 26570);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_26605_26636(Microsoft.CodeAnalysis.Location
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 26605, 26636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol
                f_10268_26737_26955(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenMethodTypeParameterMapBase
                map, string
                name, int
                ordinal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                syntaxRefs)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceOverridingMethodTypeParameterSymbol(map, name, ordinal, locations, syntaxRefs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 26737, 26955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol
                f_10268_26979_27184(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                owner, string
                name, int
                ordinal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                syntaxRefs)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodTypeParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol)owner, name, ordinal, locations, syntaxRefs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 26979, 27184);
                    return return_v;
                }


                int
                f_10268_27205_27230(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 27205, 27230);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10268_27269_27296(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 27269, 27296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 24222, 27308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 24222, 27308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            var implementingPart = this.SourcePartialImplementation;
            if ((object)implementingPart != null)
            {
                implementingPart.ForceComplete(locationOpt, cancellationToken);
            }

            base.ForceComplete(locationOpt, cancellationToken);
        }

        internal override bool IsDefinedInSourceTree(
                    SyntaxTree tree,
                    TextSpan? definedWithinSpan,
                    CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 27754, 28413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 28179, 28402);

                return
                                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.IsDefinedInSourceTree(tree, definedWithinSpan, cancellationToken), 10268, 28203, 28273) || (DynAbs.Tracing.TraceSender.Expression_False(10268, 28203, 28401) || f_10268_28294_28393_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10268_28294_28326(this), 10268, 28294, 28393)?.IsDefinedInSourceTree(tree, definedWithinSpan, cancellationToken)) == true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 27754, 28413);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                f_10268_28294_28326(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.SourcePartialImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 28294, 28326);
                    return return_v;
                }


                bool?
                f_10268_28294_28393_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 28294, 28393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 27754, 28413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 27754, 28413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void CheckConstraintsForExplicitInterfaceType(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 28425, 28945);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 28570, 28934) || true) && ((object)_explicitInterfaceType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 28570, 28934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 28646, 28676);

                    var
                    syntax = f_10268_28659_28675(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 28694, 28750);

                    f_10268_28694_28749(f_10268_28707_28740(syntax) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 28768, 28919);

                    f_10268_28768_28918(_explicitInterfaceType, f_10268_28811_28831(), conversions, f_10268_28846_28904(f_10268_28865_28903(f_10268_28865_28898(syntax))), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 28570, 28934);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 28425, 28945);

                Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                f_10268_28659_28675(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 28659, 28675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10268_28707_28740(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 28707, 28740);
                    return return_v;
                }


                int
                f_10268_28694_28749(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 28694, 28749);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10268_28811_28831()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 28811, 28831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                f_10268_28865_28898(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 28865, 28898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10268_28865_28903(Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 28865, 28903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10268_28846_28904(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 28846, 28904);
                    return return_v;
                }


                int
                f_10268_28768_28918(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.SourceLocation
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, conversions, (Microsoft.CodeAnalysis.Location)location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 28768, 28918);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 28425, 28945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 28425, 28945);
            }
        }

        protected override void PartialMethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 28957, 29275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 29052, 29108);

                var
                implementingPart = f_10268_29075_29107(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 29122, 29264) || true) && ((object)implementingPart != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 29122, 29264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 29192, 29249);

                    f_10268_29192_29248(this, implementingPart, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 29122, 29264);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 28957, 29275);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                f_10268_29075_29107(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.SourcePartialImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 29075, 29107);
                    return return_v;
                }


                int
                f_10268_29192_29248(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                definition, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                implementation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    PartialMethodChecks(definition, implementation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 29192, 29248);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 28957, 29275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 28957, 29275);
            }
        }

        private static void PartialMethodChecks(SourceOrdinaryMethodSymbol definition, SourceOrdinaryMethodSymbol implementation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10268, 29533, 33769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 29706, 29765);

                f_10268_29706_29764(!f_10268_29720_29763(definition, implementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 29781, 29938);

                MethodSymbol
                constructedDefinition = definition.ConstructIfGeneric(f_10268_29848_29936(f_10268_29906_29935(implementation)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 29952, 30107);

                bool
                returnTypesEqual = constructedDefinition.ReturnTypeWithAnnotations.Equals(f_10268_30031_30071(implementation), TypeCompareKind.AllIgnoreOptions)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 30121, 30485) || true) && (!returnTypesEqual
                && (DynAbs.Tracing.TraceSender.Expression_True(10268, 30125, 30244) && !f_10268_30164_30244(f_10268_30218_30243(implementation))) && (DynAbs.Tracing.TraceSender.Expression_True(10268, 30125, 30342) && !f_10268_30266_30342(f_10268_30320_30341(definition))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 30121, 30485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 30376, 30470);

                    f_10268_30376_30469(diagnostics, ErrorCode.ERR_PartialMethodReturnTypeDifference, f_10268_30441_30465(implementation)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 30121, 30485);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 30501, 30691) || true) && (f_10268_30505_30523(definition) != f_10268_30527_30549(implementation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 30501, 30691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 30583, 30676);

                    f_10268_30583_30675(diagnostics, ErrorCode.ERR_PartialMethodRefReturnDifference, f_10268_30647_30671(implementation)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 30501, 30691);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 30707, 30896) || true) && (f_10268_30711_30730(definition) != f_10268_30734_30757(implementation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 30707, 30896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 30791, 30881);

                    f_10268_30791_30880(diagnostics, ErrorCode.ERR_PartialMethodStaticDifference, f_10268_30852_30876(implementation)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 30707, 30896);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 30912, 31123) || true) && (f_10268_30916_30945(definition) != f_10268_30949_30982(implementation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 30912, 31123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 31016, 31108);

                    f_10268_31016_31107(diagnostics, ErrorCode.ERR_PartialMethodReadOnlyDifference, f_10268_31079_31103(implementation)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 30912, 31123);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 31139, 31349) || true) && (f_10268_31143_31171(definition) != f_10268_31175_31207(implementation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 31139, 31349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 31241, 31334);

                    f_10268_31241_31333(diagnostics, ErrorCode.ERR_PartialMethodExtensionDifference, f_10268_31305_31329(implementation)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 31139, 31349);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 31365, 31612) || true) && (f_10268_31369_31388(definition) != f_10268_31392_31415(implementation) && (DynAbs.Tracing.TraceSender.Expression_True(10268, 31369, 31455) && f_10268_31419_31455(definition)))
                ) // Don't cascade.

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 31365, 31612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 31507, 31597);

                    f_10268_31507_31596(diagnostics, ErrorCode.ERR_PartialMethodUnsafeDifference, f_10268_31568_31592(implementation)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 31365, 31612);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 31628, 31821) || true) && (f_10268_31632_31653(definition) != f_10268_31657_31682(implementation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 31628, 31821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 31716, 31806);

                    f_10268_31716_31805(diagnostics, ErrorCode.ERR_PartialMethodParamsDifference, f_10268_31777_31801(implementation)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 31628, 31821);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 31837, 32160) || true) && (f_10268_31841_31877(definition) != f_10268_31881_31921(implementation) || (DynAbs.Tracing.TraceSender.Expression_False(10268, 31841, 32014) || f_10268_31942_31974(definition) != f_10268_31978_32014(implementation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 31837, 32160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 32048, 32145);

                    f_10268_32048_32144(diagnostics, ErrorCode.ERR_PartialMethodAccessibilityDifference, f_10268_32116_32140(implementation)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 31837, 32160);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 32176, 32571) || true) && (f_10268_32180_32200(definition) != f_10268_32204_32228(implementation) || (DynAbs.Tracing.TraceSender.Expression_False(10268, 32180, 32299) || f_10268_32249_32270(definition) != f_10268_32274_32299(implementation)) || (DynAbs.Tracing.TraceSender.Expression_False(10268, 32180, 32366) || f_10268_32320_32339(definition) != f_10268_32343_32366(implementation)) || (DynAbs.Tracing.TraceSender.Expression_False(10268, 32180, 32427) || f_10268_32387_32403(definition) != f_10268_32407_32427(implementation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 32176, 32571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 32461, 32556);

                    f_10268_32461_32555(diagnostics, ErrorCode.ERR_PartialMethodExtendedModDifference, f_10268_32527_32551(implementation)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 32176, 32571);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 32587, 32659);

                f_10268_32587_32658(definition, implementation, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 32675, 33758);

                f_10268_32675_33757(f_10268_32758_32793(implementation), constructedDefinition, implementation, diagnostics, (diagnostics, implementedMethod, implementingMethod, topLevel, returnTypesEqual) =>
                                {
                                    if (returnTypesEqual)
                                    {
                        // report only if this is an unsafe *nullability* difference
                        diagnostics.Add(ErrorCode.WRN_NullabilityMismatchInReturnTypeOnPartial, implementingMethod.Locations[0]);
                                    }
                                }, (diagnostics, implementedMethod, implementingMethod, implementingParameter, blameAttributes, arg) =>
                                {
                                    diagnostics.Add(ErrorCode.WRN_NullabilityMismatchInParameterTypeOnPartial, implementingMethod.Locations[0], new FormattedSymbol(implementingParameter, SymbolDisplayFormat.ShortFormat));
                                }, extraArgument: returnTypesEqual);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10268, 29533, 33769);

                bool
                f_10268_29720_29763(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 29720, 29763);
                    return return_v;
                }


                int
                f_10268_29706_29764(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 29706, 29764);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10268_29906_29935(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 29906, 29935);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10268_29848_29936(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters)
                {
                    var return_v = TypeMap.TypeParametersAsTypeSymbolsWithIgnoredAnnotations(typeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 29848, 29936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10268_30031_30071(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30031, 30071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10268_30218_30243(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30218, 30243);
                    return return_v;
                }


                bool
                f_10268_30164_30244(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = SourceMemberContainerTypeSymbol.IsOrContainsErrorType(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 30164, 30244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10268_30320_30341(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30320, 30341);
                    return return_v;
                }


                bool
                f_10268_30266_30342(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = SourceMemberContainerTypeSymbol.IsOrContainsErrorType(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 30266, 30342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_30441_30465(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30441, 30465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_30376_30469(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 30376, 30469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10268_30505_30523(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30505, 30523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10268_30527_30549(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30527, 30549);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_30647_30671(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30647, 30671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_30583_30675(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 30583, 30675);
                    return return_v;
                }


                bool
                f_10268_30711_30730(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30711, 30730);
                    return return_v;
                }


                bool
                f_10268_30734_30757(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30734, 30757);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_30852_30876(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30852, 30876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_30791_30880(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 30791, 30880);
                    return return_v;
                }


                bool
                f_10268_30916_30945(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30916, 30945);
                    return return_v;
                }


                bool
                f_10268_30949_30982(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 30949, 30982);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_31079_31103(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31079, 31103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_31016_31107(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 31016, 31107);
                    return return_v;
                }


                bool
                f_10268_31143_31171(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31143, 31171);
                    return return_v;
                }


                bool
                f_10268_31175_31207(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31175, 31207);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_31305_31329(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31305, 31329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_31241_31333(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 31241, 31333);
                    return return_v;
                }


                bool
                f_10268_31369_31388(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31369, 31388);
                    return return_v;
                }


                bool
                f_10268_31392_31415(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31392, 31415);
                    return return_v;
                }


                bool
                f_10268_31419_31455(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                symbol)
                {
                    var return_v = symbol.CompilationAllowsUnsafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 31419, 31455);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_31568_31592(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31568, 31592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_31507_31596(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 31507, 31596);
                    return return_v;
                }


                bool
                f_10268_31632_31653(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                method)
                {
                    var return_v = method.IsParams();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 31632, 31653);
                    return return_v;
                }


                bool
                f_10268_31657_31682(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                method)
                {
                    var return_v = method.IsParams();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 31657, 31682);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_31777_31801(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31777, 31801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_31716_31805(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 31716, 31805);
                    return return_v;
                }


                bool
                f_10268_31841_31877(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.HasExplicitAccessModifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31841, 31877);
                    return return_v;
                }


                bool
                f_10268_31881_31921(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.HasExplicitAccessModifier
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31881, 31921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10268_31942_31974(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31942, 31974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10268_31978_32014(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 31978, 32014);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_32116_32140(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 32116, 32140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_32048_32144(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 32048, 32144);
                    return return_v;
                }


                bool
                f_10268_32180_32200(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 32180, 32200);
                    return return_v;
                }


                bool
                f_10268_32204_32228(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVirtual
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 32204, 32228);
                    return return_v;
                }


                bool
                f_10268_32249_32270(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 32249, 32270);
                    return return_v;
                }


                bool
                f_10268_32274_32299(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 32274, 32299);
                    return return_v;
                }


                bool
                f_10268_32320_32339(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 32320, 32339);
                    return return_v;
                }


                bool
                f_10268_32343_32366(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 32343, 32366);
                    return return_v;
                }


                bool
                f_10268_32387_32403(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsNew;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 32387, 32403);
                    return return_v;
                }


                bool
                f_10268_32407_32427(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsNew;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 32407, 32427);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_32527_32551(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 32527, 32551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_32461_32555(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 32461, 32555);
                    return return_v;
                }


                int
                f_10268_32587_32658(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                definition, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                implementation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    PartialMethodConstraintsChecks(definition, implementation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 32587, 32658);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10268_32758_32793(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 32758, 32793);
                    return return_v;
                }


                int
                f_10268_32675_33757(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                baseMethod, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                overrideMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType<bool>
                reportMismatchInReturnType, Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType<bool>
                reportMismatchInParameterType, bool
                extraArgument)
                {
                    SourceMemberContainerTypeSymbol.CheckValidNullableMethodOverride(compilation, baseMethod, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)overrideMethod, diagnostics, reportMismatchInReturnType, reportMismatchInParameterType, extraArgument: extraArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 32675, 33757);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 29533, 33769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 29533, 33769);
            }
        }

        private static void PartialMethodConstraintsChecks(SourceOrdinaryMethodSymbol definition, SourceOrdinaryMethodSymbol implementation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10268, 33781, 35566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 33965, 34024);

                f_10268_33965_34023(!f_10268_33979_34022(definition, implementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34038, 34093);

                f_10268_34038_34092(f_10268_34051_34067(definition) == f_10268_34071_34091(implementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34109, 34157);

                var
                typeParameters1 = f_10268_34131_34156(definition)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34173, 34208);

                int
                arity = typeParameters1.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34222, 34292) || true) && (arity == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 34222, 34292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34270, 34277);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 34222, 34292);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34308, 34360);

                var
                typeParameters2 = f_10268_34330_34359(implementation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34374, 34441);

                var
                indexedTypeParameters = f_10268_34402_34440(arity)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34455, 34540);

                var
                typeMap1 = f_10268_34470_34539(typeParameters1, indexedTypeParameters, allowAlpha: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34554, 34639);

                var
                typeMap2 = f_10268_34569_34638(typeParameters2, indexedTypeParameters, allowAlpha: true)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34722, 34727);

                    // Report any mismatched method constraints.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34713, 35555) || true) && (i < arity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34740, 34743)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 34713, 35555))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 34713, 35555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34777, 34817);

                        var
                        typeParameter1 = typeParameters1[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34835, 34875);

                        var
                        typeParameter2 = typeParameters2[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 34895, 35540) || true) && (!f_10268_34900_34995(typeParameter1, typeMap1, typeParameter2, typeMap2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 34895, 35540);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 35037, 35171);

                            f_10268_35037_35170(diagnostics, ErrorCode.ERR_PartialMethodInconsistentConstraints, f_10268_35105_35129(implementation)[0], implementation, f_10268_35150_35169(typeParameter2));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 34895, 35540);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 34895, 35540);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 35213, 35540) || true) && (!f_10268_35218_35326(typeParameter1, typeMap1, typeParameter2, typeMap2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 35213, 35540);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 35368, 35521);

                                f_10268_35368_35520(diagnostics, ErrorCode.WRN_NullabilityMismatchInConstraintsOnPartialImplementation, f_10268_35455_35479(implementation)[0], implementation, f_10268_35500_35519(typeParameter2));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 35213, 35540);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 34895, 35540);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10268, 1, 843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10268, 1, 843);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10268, 33781, 35566);

                bool
                f_10268_33979_34022(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 33979, 34022);
                    return return_v;
                }


                int
                f_10268_33965_34023(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 33965, 34023);
                    return 0;
                }


                int
                f_10268_34051_34067(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 34051, 34067);
                    return return_v;
                }


                int
                f_10268_34071_34091(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 34071, 34091);
                    return return_v;
                }


                int
                f_10268_34038_34092(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 34038, 34092);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10268_34131_34156(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 34131, 34156);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10268_34330_34359(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 34330, 34359);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10268_34402_34440(int
                count)
                {
                    var return_v = IndexedTypeParameterSymbol.Take(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 34402, 34440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10268_34470_34539(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to, bool
                allowAlpha)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha: allowAlpha);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 34470, 34539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10268_34569_34638(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to, bool
                allowAlpha)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha: allowAlpha);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 34569, 34638);
                    return return_v;
                }


                bool
                f_10268_34900_34995(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2)
                {
                    var return_v = MemberSignatureComparer.HaveSameConstraints(typeParameter1, typeMap1, typeParameter2, typeMap2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 34900, 34995);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_35105_35129(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 35105, 35129);
                    return return_v;
                }


                string
                f_10268_35150_35169(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 35150, 35169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_35037_35170(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 35037, 35170);
                    return return_v;
                }


                bool
                f_10268_35218_35326(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2)
                {
                    var return_v = MemberSignatureComparer.HaveSameNullabilityInConstraints(typeParameter1, typeMap1, typeParameter2, typeMap2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 35218, 35326);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10268_35455_35479(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 35455, 35479);
                    return return_v;
                }


                string
                f_10268_35500_35519(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 35500, 35519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10268_35368_35520(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 35368, 35520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 33781, 35566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 33781, 35566);
            }
        }

        internal override bool CallsAreOmitted(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 35578, 35831);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 35664, 35764) || true) && (f_10268_35668_35703(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10268, 35664, 35764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 35737, 35749);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10268, 35664, 35764);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 35780, 35820);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CallsAreOmitted(syntaxTree), 10268, 35787, 35819);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 35578, 35831);

                bool
                f_10268_35668_35703(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsPartialWithoutImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 35668, 35703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 35578, 35831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 35578, 35831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10268, 35884, 35910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10268, 35887, 35910);
                    return f_10268_35887_35895_M(!IsAsync) && (DynAbs.Tracing.TraceSender.Expression_True(10268, 35887, 35910) && f_10268_35899_35910_M(!IsIterator)); DynAbs.Tracing.TraceSender.TraceExitMethod(10268, 35884, 35910);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10268, 35884, 35910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 35884, 35910);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceOrdinaryMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10268, 611, 35918);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10268, 611, 35918);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10268, 611, 35918);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10268, 611, 35918);

        static Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10268_3816_3827(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 3816, 3827);
            return return_v;
        }


        static bool
        f_10268_3785_3828(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        node)
        {
            var return_v = SyntaxFacts.HasYieldOperations((Microsoft.CodeAnalysis.SyntaxNode?)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 3785, 3828);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        f_10268_3867_3887(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ParameterList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 3867, 3887);
            return return_v;
        }


        static bool
        f_10268_3986_4007_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 3986, 4007);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10268_4211_4222(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 4211, 4222);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10268_4234_4255(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 4234, 4255);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10268_4475_4486(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 4475, 4486);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10268_4548_4569(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 4548, 4569);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        f_10268_4704_4721(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ReturnType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 4704, 4721);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10268_4704_4734(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        syntax)
        {
            var return_v = syntax.GetRefKind();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 4704, 4734);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10268_4800_4811(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 4800, 4811);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        f_10268_4813_4834(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ExpressionBody;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 4813, 4834);
            return return_v;
        }


        int
        f_10268_4751_4856(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        expression, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        syntax, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            CheckForBlockAndExpressionBody((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)block, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)expression, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 4751, 4856);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10268_3631_3645_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10268, 3259, 4868);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        f_10268_15241_15252(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbol
        this_param)
        {
            var return_v = this_param.GetSyntax();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10268, 15241, 15252);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        f_10268_15241_15263(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        this_param)
        {
            var return_v = this_param.ReturnType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 15241, 15263);
            return return_v;
        }


        Microsoft.CodeAnalysis.Location
        f_10268_15241_15272(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 15241, 15272);
            return return_v;
        }


        bool
        f_10268_35887_35895_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 35887, 35895);
            return return_v;
        }


        bool
        f_10268_35899_35910_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10268, 35899, 35910);
            return return_v;
        }

    }
}
