// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceUserDefinedOperatorSymbolBase : SourceMemberMethodSymbol
    {
        private const TypeCompareKind
        ComparisonForUserDefinedOperators = TypeCompareKind.IgnoreTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes
        ;

        private readonly string _name;

        private readonly bool _isExpressionBodied;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        private TypeWithAnnotations _lazyReturnType;

        protected SourceUserDefinedOperatorSymbolBase(
                    MethodKind methodKind,
                    string name,
                    SourceMemberContainerTypeSymbol containingType,
                    Location location,
                    CSharpSyntaxNode syntax,
                    DeclarationModifiers declarationModifiers,
                    bool hasBody,
                    bool isExpressionBodied,
                    bool isIterator,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics) : base(f_10279_1412_1426_C(containingType), f_10279_1428_1449(syntax), location, isIterator: isIterator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10279, 916, 4647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 726, 731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 764, 783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 1509, 1522);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 1536, 1577);

                _isExpressionBodied = isExpressionBodied;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 1593, 1653);

                f_10279_1593_1652(
                            this, declarationModifiers, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 1939, 2088);

                f_10279_1939_2087(
                            // We will bind the formal parameters and the return type lazily. For now,
                            // assume that the return type is non-void; when we do the lazy initialization
                            // of the parameters and return type we will update the flag if necessary.

                            this, methodKind, declarationModifiers, returnsVoid: false, isExtensionMethod: false, isNullableAnalysisEnabled: isNullableAnalysisEnabled);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 2104, 2561) || true) && (f_10279_2108_2139(f_10279_2108_2127(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10279, 2108, 2305) && (methodKind == MethodKind.Conversion || (DynAbs.Tracing.TraceSender.Expression_False(10279, 2161, 2249) || name == WellKnownMemberNames.EqualityOperatorName) || (DynAbs.Tracing.TraceSender.Expression_False(10279, 2161, 2304) || name == WellKnownMemberNames.InequalityOperatorName))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 2104, 2561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 2539, 2546);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 2104, 2561);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 2577, 2936) || true) && (f_10279_2581_2609(f_10279_2581_2600(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 2577, 2936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 2827, 2896);

                    f_10279_2827_2895(                // Similarly if we're in a static class, though we have not reported it yet.

                                    // CS0715: '{0}': static classes cannot contain user-defined operators
                                    diagnostics, ErrorCode.ERR_OperatorInStaticClass, location, this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 2914, 2921);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 2577, 2936);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 3069, 3359) || true) && (f_10279_3073_3099(this) != Accessibility.Public || (DynAbs.Tracing.TraceSender.Expression_False(10279, 3073, 3141) || f_10279_3127_3141_M(!this.IsStatic)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 3069, 3359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 3266, 3344);

                    f_10279_3266_3343(                // CS0558: User-defined operator '...' must be declared static and public
                                    diagnostics, ErrorCode.ERR_OperatorsMustBeStatic, f_10279_3319_3333(this)[0], this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 3069, 3359);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 3697, 4256) || true) && (hasBody && (DynAbs.Tracing.TraceSender.Expression_True(10279, 3701, 3720) && f_10279_3712_3720()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 3697, 4256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 3754, 3815);

                    f_10279_3754_3814(diagnostics, ErrorCode.ERR_ExternHasBody, location, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 3697, 4256);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 3697, 4256);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 3849, 4256) || true) && (!hasBody && (DynAbs.Tracing.TraceSender.Expression_True(10279, 3853, 3874) && f_10279_3865_3874_M(!IsExtern)) && (DynAbs.Tracing.TraceSender.Expression_True(10279, 3853, 3889) && f_10279_3878_3889_M(!IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10279, 3853, 3903) && f_10279_3893_3903_M(!IsPartial)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 3849, 4256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 4174, 4241);

                        f_10279_4174_4240(                // Do not report that the body is missing if the operator is marked as
                                                          // partial or abstract; we will already have given an error for that so
                                                          // there's no need to "cascade" the error.
                                        diagnostics, ErrorCode.ERR_ConcreteMissingBody, location, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 3849, 4256);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 3697, 4256);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 4406, 4525);

                var
                info = f_10279_4417_4524(this.DeclarationModifiers, this, isExplicitInterfaceImplementation: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 4539, 4636) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 4539, 4636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 4589, 4621);

                    f_10279_4589_4620(diagnostics, info, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 4539, 4636);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10279, 916, 4647);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 916, 4647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 916, 4647);
            }
        }

        protected static DeclarationModifiers MakeDeclarationModifiers(BaseMethodDeclarationSyntax syntax, Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10279, 4659, 5309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 4828, 4877);

                var
                defaultAccess = DeclarationModifiers.Private
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 4891, 5111);

                var
                allowedModifiers =
                                DeclarationModifiers.AccessibilityMask |
                                DeclarationModifiers.Static |
                                DeclarationModifiers.Extern |
                                DeclarationModifiers.Unsafe
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 5127, 5298);

                return f_10279_5134_5297(f_10279_5201_5217(syntax), defaultAccess, allowedModifiers, location, diagnostics, modifierErrors: out _);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10279, 4659, 5309);

                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10279_5201_5217(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 5201, 5217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10279_5134_5297(Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                defaultAccess, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                allowedModifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                modifierErrors)
                {
                    var return_v = ModifierUtils.MakeAndCheckNontypeMemberModifiers(modifiers, defaultAccess, allowedModifiers, errorLocation, diagnostics, out modifierErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 5134, 5297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 4659, 5309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 4659, 5309);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Location ReturnTypeLocation { get; }

        protected (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters) MakeParametersAndBindReturnType(BaseMethodDeclarationSyntax declarationSyntax, TypeSyntax returnTypeSyntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 5388, 8048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 5634, 5665);

                TypeWithAnnotations
                returnType
                = default(TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 5679, 5722);

                ImmutableArray<ParameterSymbol>
                parameters
                = default(ImmutableArray<ParameterSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 5738, 5895);

                var
                binder = f_10279_5751_5894(f_10279_5751_5841(f_10279_5751_5776(this), f_10279_5812_5840(declarationSyntax)), returnTypeSyntax, declarationSyntax, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 5911, 5936);

                SyntaxToken
                arglistToken
                = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 5952, 6039);

                var
                signatureBinder = f_10279_5974_6038(binder, BinderFlags.SuppressConstraintChecks)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 6055, 6407);

                parameters = f_10279_6068_6406(signatureBinder, this, f_10279_6175_6206(declarationSyntax), out arglistToken, allowRefOrOut: true, allowThis: false, addRefReadOnlyModifier: false, diagnostics: diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 6423, 6957) || true) && (arglistToken.Kind() == SyntaxKind.ArgListKeyword)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 6423, 6957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 6698, 6778);

                    f_10279_6698_6777(                // This is a parse-time error in the native compiler; it is a semantic analysis error in Roslyn.

                                    // error CS1669: __arglist is not valid in this context
                                    diagnostics, ErrorCode.ERR_IllegalVarArgs, f_10279_6744_6776(arglistToken));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 6423, 6957);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 6973, 7042);

                returnType = f_10279_6986_7041(signatureBinder, returnTypeSyntax, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 7197, 7499) || true) && (returnType.IsRestrictedType(ignoreSpanLikeTypes: true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 7197, 7499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 7384, 7484);

                    f_10279_7384_7483(                // The return type of a method, delegate, or function pointer cannot be '{0}'
                                    diagnostics, ErrorCode.ERR_MethodReturnCantBeRefAny, f_10279_7440_7465(returnTypeSyntax), returnType.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 7197, 7499);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 7515, 7989) || true) && (f_10279_7519_7543(returnType.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 7515, 7989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 7858, 7974);

                    f_10279_7858_7973(                // Operators in interfaces was introduced in C# 8, so there's no need to be specially concerned about
                                                      // maintaining backcompat with the native compiler bug around interfaces.
                                                      // '{0}': static types cannot be used as return types
                                    diagnostics, f_10279_7874_7928(useWarning: false), f_10279_7930_7955(returnTypeSyntax), returnType.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 7515, 7989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 8005, 8037);

                return (returnType, parameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 5388, 8048);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10279_5751_5776(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 5751, 5776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10279_5812_5840(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 5812, 5840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10279_5751_5841(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 5751, 5841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10279_5751_5894(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                memberOpt)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)memberDeclarationOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 5751, 5894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10279_5974_6038(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 5974, 6038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10279_6175_6206(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 6175, 6206);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10279_6068_6406(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                syntax, out Microsoft.CodeAnalysis.SyntaxToken
                arglistToken, bool
                allowRefOrOut, bool
                allowThis, bool
                addRefReadOnlyModifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ParameterHelpers.MakeParameters(binder, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax)syntax, out arglistToken, allowRefOrOut: allowRefOrOut, allowThis: allowThis, addRefReadOnlyModifier: addRefReadOnlyModifier, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 6068, 6406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10279_6744_6776(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 6744, 6776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_6698_6777(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 6698, 6777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10279_6986_7041(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 6986, 7041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10279_7440_7465(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 7440, 7465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_7384_7483(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 7384, 7483);
                    return return_v;
                }


                bool
                f_10279_7519_7543(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 7519, 7543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10279_7874_7928(bool
                useWarning)
                {
                    var return_v = ErrorFacts.GetStaticClassReturnCode(useWarning: useWarning);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 7874, 7928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10279_7930_7955(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 7930, 7955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_7858_7973(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 7858, 7973);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 5388, 8048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 5388, 8048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void MethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 8060, 9186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 8148, 8230);

                (_lazyReturnType, _lazyParameters) = f_10279_8185_8229(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 8246, 8296);

                f_10279_8246_8295(
                            this, _lazyReturnType.IsVoidType());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 8521, 8835) || true) && ((f_10279_8526_8563(f_10279_8526_8545(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10279, 8526, 8729) && (f_10279_8585_8595() == MethodKind.Conversion || (DynAbs.Tracing.TraceSender.Expression_False(10279, 8585, 8673) || f_10279_8624_8628() == WellKnownMemberNames.EqualityOperatorName) || (DynAbs.Tracing.TraceSender.Expression_False(10279, 8585, 8728) || f_10279_8677_8681() == WellKnownMemberNames.InequalityOperatorName)))) || (DynAbs.Tracing.TraceSender.Expression_False(10279, 8525, 8779) || f_10279_8751_8779(f_10279_8751_8770(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 8521, 8835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 8813, 8820);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 8521, 8835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 9001, 9076);

                f_10279_9001_9075(this, _lazyReturnType, _lazyParameters, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 9090, 9124);

                f_10279_9090_9123(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 9138, 9175);

                f_10279_9138_9174(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 8060, 9186);

                (Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations ReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol> Parameters)
                f_10279_8185_8229(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeParametersAndBindReturnType(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 8185, 8229);
                    return return_v;
                }


                int
                f_10279_8246_8295(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, bool
                returnsVoid)
                {
                    this_param.SetReturnsVoid(returnsVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 8246, 8295);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10279_8526_8545(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 8526, 8545);
                    return return_v;
                }


                bool
                f_10279_8526_8563(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 8526, 8563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10279_8585_8595()
                {
                    var return_v = MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 8585, 8595);
                    return return_v;
                }


                string
                f_10279_8624_8628()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 8624, 8628);
                    return return_v;
                }


                string
                f_10279_8677_8681()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 8677, 8681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10279_8751_8770(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 8751, 8770);
                    return return_v;
                }


                bool
                f_10279_8751_8779(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 8751, 8779);
                    return return_v;
                }


                int
                f_10279_9001_9075(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckEffectiveAccessibility(returnType, parameters, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 9001, 9075);
                    return 0;
                }


                int
                f_10279_9090_9123(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckValueParameters(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 9090, 9123);
                    return 0;
                }


                int
                f_10279_9138_9174(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckOperatorSignatures(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 9138, 9174);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 8060, 9186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 8060, 9186);
            }
        }

        protected abstract (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters) MakeParametersAndBindReturnType(DiagnosticBag diagnostics);

        private void CheckValueParameters(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 9365, 9832);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 9528, 9821);
                    foreach (var p in f_10279_9546_9561_I(f_10279_9546_9561(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 9528, 9821);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 9595, 9806) || true) && (f_10279_9599_9608(p) != RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10279, 9599, 9651) && f_10279_9628_9637(p) != RefKind.In))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 9595, 9806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 9693, 9759);

                            f_10279_9693_9758(diagnostics, ErrorCode.ERR_IllegalRefParam, f_10279_9740_9754(this)[0]);
                            DynAbs.Tracing.TraceSender.TraceBreak(10279, 9781, 9787);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 9595, 9806);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 9528, 9821);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10279, 1, 294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10279, 1, 294);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 9365, 9832);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10279_9546_9561(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 9546, 9561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10279_9599_9608(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 9599, 9608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10279_9628_9637(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 9628, 9637);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_9740_9754(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 9740, 9754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_9693_9758(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 9693, 9758);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10279_9546_9561_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 9546, 9561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 9365, 9832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 9365, 9832);
            }
        }

        private void CheckOperatorSignatures(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 9844, 11683);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 10123, 10244) || true) && (!f_10279_10128_10188(f_10279_10157_10166(this), f_10279_10168_10187(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 10123, 10244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 10222, 10229);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 10123, 10244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 10260, 11672);

                switch (f_10279_10268_10277(this))
                {

                    case WellKnownMemberNames.ImplicitConversionName:
                    case WellKnownMemberNames.ExplicitConversionName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 10260, 11672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 10449, 10498);

                        f_10279_10449_10497(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10279, 10520, 10526);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 10260, 11672);

                    case WellKnownMemberNames.UnaryNegationOperatorName:
                    case WellKnownMemberNames.UnaryPlusOperatorName:
                    case WellKnownMemberNames.LogicalNotOperatorName:
                    case WellKnownMemberNames.OnesComplementOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 10260, 11672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 10824, 10857);

                        f_10279_10824_10856(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10279, 10879, 10885);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 10260, 11672);

                    case WellKnownMemberNames.TrueOperatorName:
                    case WellKnownMemberNames.FalseOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 10260, 11672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 11032, 11069);

                        f_10279_11032_11068(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10279, 11091, 11097);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 10260, 11672);

                    case WellKnownMemberNames.IncrementOperatorName:
                    case WellKnownMemberNames.DecrementOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 10260, 11672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 11253, 11299);

                        f_10279_11253_11298(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10279, 11321, 11327);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 10260, 11672);

                    case WellKnownMemberNames.LeftShiftOperatorName:
                    case WellKnownMemberNames.RightShiftOperatorName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 10260, 11672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 11484, 11517);

                        f_10279_11484_11516(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10279, 11539, 11545);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 10260, 11672);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 10260, 11672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 11595, 11629);

                        f_10279_11595_11628(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10279, 11651, 11657);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 10260, 11672);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 9844, 11683);

                string
                f_10279_10157_10166(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 10157, 10166);
                    return return_v;
                }


                int
                f_10279_10168_10187(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 10168, 10187);
                    return return_v;
                }


                bool
                f_10279_10128_10188(string
                name, int
                parameterCount)
                {
                    var return_v = DoesOperatorHaveCorrectArity(name, parameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 10128, 10188);
                    return return_v;
                }


                string
                f_10279_10268_10277(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 10268, 10277);
                    return return_v;
                }


                int
                f_10279_10449_10497(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckUserDefinedConversionSignature(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 10449, 10497);
                    return 0;
                }


                int
                f_10279_10824_10856(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckUnarySignature(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 10824, 10856);
                    return 0;
                }


                int
                f_10279_11032_11068(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckTrueFalseSignature(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 11032, 11068);
                    return 0;
                }


                int
                f_10279_11253_11298(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckIncrementDecrementSignature(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 11253, 11298);
                    return 0;
                }


                int
                f_10279_11484_11516(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckShiftSignature(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 11484, 11516);
                    return 0;
                }


                int
                f_10279_11595_11628(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckBinarySignature(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 11595, 11628);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 9844, 11683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 9844, 11683);
            }
        }

        private static bool DoesOperatorHaveCorrectArity(string name, int parameterCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10279, 11695, 12642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 11801, 12631);

                switch (name)
                {

                    case WellKnownMemberNames.IncrementOperatorName:
                    case WellKnownMemberNames.DecrementOperatorName:
                    case WellKnownMemberNames.UnaryNegationOperatorName:
                    case WellKnownMemberNames.UnaryPlusOperatorName:
                    case WellKnownMemberNames.LogicalNotOperatorName:
                    case WellKnownMemberNames.OnesComplementOperatorName:
                    case WellKnownMemberNames.TrueOperatorName:
                    case WellKnownMemberNames.FalseOperatorName:
                    case WellKnownMemberNames.ImplicitConversionName:
                    case WellKnownMemberNames.ExplicitConversionName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 11801, 12631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 12514, 12541);

                        return parameterCount == 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 11801, 12631);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 11801, 12631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 12589, 12616);

                        return parameterCount == 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 11801, 12631);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10279, 11695, 12642);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 11695, 12642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 11695, 12642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckUserDefinedConversionSignature(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 12654, 20775);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 12754, 12966) || true) && (f_10279_12758_12774(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 12754, 12966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 12878, 12951);

                    f_10279_12878_12950(                // CS0590: User-defined operators cannot return void
                                    diagnostics, ErrorCode.ERR_OperatorCantReturnVoid, f_10279_12932_12946(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 12754, 12966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 13228, 13266);

                var
                source = f_10279_13241_13265(this, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 13280, 13309);

                var
                target = f_10279_13293_13308(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 13323, 13359);

                var
                source0 = f_10279_13337_13358(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 13373, 13409);

                var
                target0 = f_10279_13387_13408(target)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 13638, 13950) || true) && (f_10279_13642_13667(source0) || (DynAbs.Tracing.TraceSender.Expression_False(10279, 13642, 13696) || f_10279_13671_13696(target0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 13638, 13950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 13830, 13910);

                    f_10279_13830_13909(                // CS0552: '{0}': user-defined conversions to or from an interface are not allowed
                                    diagnostics, ErrorCode.ERR_ConversionWithInterface, f_10279_13885_13899(this)[0], this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 13928, 13935);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 13638, 13950);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 14103, 14640) || true) && (!f_10279_14108_14138(this, source0) && (DynAbs.Tracing.TraceSender.Expression_True(10279, 14107, 14190) && !f_10279_14160_14190(this, target0)) && (DynAbs.Tracing.TraceSender.Expression_True(10279, 14107, 14334) &&                // allow conversion between T and Nullable<T> in declaration of Nullable<T>
                                !f_10279_14305_14334(this, source)) && (DynAbs.Tracing.TraceSender.Expression_True(10279, 14107, 14385) && !f_10279_14356_14385(this, target)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 14103, 14640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 14514, 14600);

                    f_10279_14514_14599(                // CS0556: User-defined conversion must convert to or from the enclosing type
                                    diagnostics, ErrorCode.ERR_ConversionNotInvolvingContainedType, f_10279_14581_14595(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 14618, 14625);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 14103, 14640);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 14713, 15245) || true) && ((DynAbs.Tracing.TraceSender.Conditional_F1(10279, 14717, 14778) || (((f_10279_14718_14744(f_10279_14718_14732()) == SpecialType.System_Nullable_T)
                && DynAbs.Tracing.TraceSender.Conditional_F2(10279, 14802, 14858)) || DynAbs.Tracing.TraceSender.Conditional_F3(10279, 14882, 14940))) ? f_10279_14802_14858(source, target, ComparisonForUserDefinedOperators) : f_10279_14882_14940(source0, target0, ComparisonForUserDefinedOperators))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 14713, 15245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 15136, 15205);

                    f_10279_15136_15204(                // CS0555: User-defined operator cannot take an object of the enclosing type 
                                                        // and convert to an object of the enclosing type
                                    diagnostics, ErrorCode.ERR_IdentityConversion, f_10279_15186_15200(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 15223, 15230);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 14713, 15245);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 18727, 19018) || true) && (f_10279_18731_18749(source) || (DynAbs.Tracing.TraceSender.Expression_False(10279, 18731, 18771) || f_10279_18753_18771(target)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 18727, 19018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 18901, 18978);

                    f_10279_18901_18977(                // '{0}': user-defined conversions to or from the dynamic type are not allowed
                                    diagnostics, ErrorCode.ERR_BadDynamicConversion, f_10279_18953_18967(this)[0], this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 18996, 19003);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 18727, 19018);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19034, 19050);

                TypeSymbol
                same
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19064, 19085);

                TypeSymbol
                different
                = default(TypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19101, 19352) || true) && (f_10279_19105_19135(this, source0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 19101, 19352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19169, 19183);

                    same = source;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19201, 19220);

                    different = target;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 19101, 19352);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 19101, 19352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19286, 19300);

                    same = target;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19318, 19337);

                    different = source;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 19101, 19352);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19368, 20764) || true) && (f_10279_19372_19395(different))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 19368, 20764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19476, 19519);

                    f_10279_19476_19518(!f_10279_19490_19517(different));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19623, 19661);

                    f_10279_19623_19660(!f_10279_19637_19659(same));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19681, 19731);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 19751, 20674) || true) && (f_10279_19755_19863(same, different, ComparisonForUserDefinedOperators, useSiteDiagnostics: ref useSiteDiagnostics))
                    ) // tomat: ignoreDynamic should be true, but we don't want to introduce breaking change. See bug 605326.

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 19751, 20674);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 20104, 20179);

                        f_10279_20104_20178(                    // '{0}': user-defined conversions to or from a base type are not allowed
                                            diagnostics, ErrorCode.ERR_ConversionWithBase, f_10279_20154_20168(this)[0], this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 19751, 20674);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 19751, 20674);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 20221, 20674) || true) && (f_10279_20225_20333(different, same, ComparisonForUserDefinedOperators, useSiteDiagnostics: ref useSiteDiagnostics))
                        ) // tomat: ignoreDynamic should be true, but we don't want to introduce breaking change. See bug 605326.

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 20221, 20674);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 20577, 20655);

                            f_10279_20577_20654(                    // '{0}': user-defined conversions to or from a derived type are not allowed
                                                diagnostics, ErrorCode.ERR_ConversionWithDerived, f_10279_20630_20644(this)[0], this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 20221, 20674);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 19751, 20674);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 20694, 20749);

                    f_10279_20694_20748(
                                    diagnostics, f_10279_20710_20724(this)[0], useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 19368, 20764);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 12654, 20775);

                bool
                f_10279_12758_12774(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 12758, 12774);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_12932_12946(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 12932, 12946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_12878_12950(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 12878, 12950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_13241_13265(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 13241, 13265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_13293_13308(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 13293, 13308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_13337_13358(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 13337, 13358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_13387_13408(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 13387, 13408);
                    return return_v;
                }


                bool
                f_10279_13642_13667(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 13642, 13667);
                    return return_v;
                }


                bool
                f_10279_13671_13696(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 13671, 13696);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_13885_13899(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 13885, 13899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_13830_13909(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 13830, 13909);
                    return return_v;
                }


                bool
                f_10279_14108_14138(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MatchesContainingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 14108, 14138);
                    return return_v;
                }


                bool
                f_10279_14160_14190(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MatchesContainingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 14160, 14190);
                    return return_v;
                }


                bool
                f_10279_14305_14334(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MatchesContainingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 14305, 14334);
                    return return_v;
                }


                bool
                f_10279_14356_14385(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MatchesContainingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 14356, 14385);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_14581_14595(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 14581, 14595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_14514_14599(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 14514, 14599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10279_14718_14732()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 14718, 14732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10279_14718_14744(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 14718, 14744);
                    return return_v;
                }


                bool
                f_10279_14802_14858(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 14802, 14858);
                    return return_v;
                }


                bool
                f_10279_14882_14940(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 14882, 14940);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_15186_15200(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 15186, 15200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_15136_15204(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 15136, 15204);
                    return return_v;
                }


                bool
                f_10279_18731_18749(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 18731, 18749);
                    return return_v;
                }


                bool
                f_10279_18753_18771(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 18753, 18771);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_18953_18967(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 18953, 18967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_18901_18977(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 18901, 18977);
                    return return_v;
                }


                bool
                f_10279_19105_19135(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MatchesContainingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 19105, 19135);
                    return return_v;
                }


                bool
                f_10279_19372_19395(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 19372, 19395);
                    return return_v;
                }


                bool
                f_10279_19490_19517(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 19490, 19517);
                    return return_v;
                }


                int
                f_10279_19476_19518(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 19476, 19518);
                    return 0;
                }


                bool
                f_10279_19637_19659(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 19637, 19659);
                    return return_v;
                }


                int
                f_10279_19623_19660(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 19623, 19660);
                    return 0;
                }


                bool
                f_10279_19755_19863(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsDerivedFrom(type, comparison, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 19755, 19863);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_20154_20168(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 20154, 20168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_20104_20178(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 20104, 20178);
                    return return_v;
                }


                bool
                f_10279_20225_20333(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsDerivedFrom(type, comparison, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 20225, 20333);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_20630_20644(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 20630, 20644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_20577_20654(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 20577, 20654);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_20710_20724(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 20710, 20724);
                    return return_v;
                }


                bool
                f_10279_20694_20748(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 20694, 20748);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 12654, 20775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 12654, 20775);
            }
        }

        private void CheckUnarySignature(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 20787, 21591);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 21012, 21286) || true) && (!f_10279_21017_21079(this, f_10279_21039_21078(f_10279_21039_21063(this, 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 21012, 21286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 21195, 21271);

                    f_10279_21195_21270(                // The parameter of a unary operator must be the containing type
                                    diagnostics, ErrorCode.ERR_BadUnaryOperatorSignature, f_10279_21252_21266(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 21012, 21286);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 21302, 21580) || true) && (f_10279_21306_21322(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 21302, 21580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 21492, 21565);

                    f_10279_21492_21564(                // The Roslyn parser does not detect this error.
                                                        // CS0590: User-defined operators cannot return void
                                    diagnostics, ErrorCode.ERR_OperatorCantReturnVoid, f_10279_21546_21560(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 21302, 21580);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 20787, 21591);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_21039_21063(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 21039, 21063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_21039_21078(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 21039, 21078);
                    return return_v;
                }


                bool
                f_10279_21017_21079(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MatchesContainingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 21017, 21079);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_21252_21266(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 21252, 21266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_21195_21270(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 21195, 21270);
                    return return_v;
                }


                bool
                f_10279_21306_21322(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 21306, 21322);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_21546_21560(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 21546, 21560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_21492_21564(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 21492, 21564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 20787, 21591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 20787, 21591);
            }
        }

        private void CheckTrueFalseSignature(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 21603, 22388);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 21840, 22087) || true) && (f_10279_21844_21871(f_10279_21844_21859(this)) != SpecialType.System_Boolean)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 21840, 22087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 22010, 22072);

                    f_10279_22010_22071(                // The return type of operator True or False must be bool
                                    diagnostics, ErrorCode.ERR_OpTFRetType, f_10279_22053_22067(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 21840, 22087);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 22103, 22377) || true) && (!f_10279_22108_22170(this, f_10279_22130_22169(f_10279_22130_22154(this, 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 22103, 22377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 22286, 22362);

                    f_10279_22286_22361(                // The parameter of a unary operator must be the containing type
                                    diagnostics, ErrorCode.ERR_BadUnaryOperatorSignature, f_10279_22343_22357(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 22103, 22377);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 21603, 22388);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_21844_21859(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 21844, 21859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10279_21844_21871(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 21844, 21871);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_22053_22067(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 22053, 22067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_22010_22071(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 22010, 22071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_22130_22154(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 22130, 22154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_22130_22169(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 22130, 22169);
                    return return_v;
                }


                bool
                f_10279_22108_22170(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MatchesContainingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 22108, 22170);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_22343_22357(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 22343, 22357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_22286_22361(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 22286, 22361);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 21603, 22388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 21603, 22388);
            }
        }

        private void CheckIncrementDecrementSignature(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 22400, 25693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 24747, 24792);

                var
                parameterType = f_10279_24767_24791(this, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 24806, 24856);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 24872, 25611) || true) && (!f_10279_24877_24928(this, f_10279_24899_24927(parameterType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 24872, 25611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 25059, 25128);

                    f_10279_25059_25127(                // CS0559: The parameter type for ++ or -- operator must be the containing type
                                    diagnostics, ErrorCode.ERR_BadIncDecSignature, f_10279_25109_25123(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 24872, 25611);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 24872, 25611);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 25162, 25611) || true) && (!f_10279_25167_25333(f_10279_25167_25216(f_10279_25167_25182(this)), parameterType, ComparisonForUserDefinedOperators, useSiteDiagnostics: ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 25162, 25611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 25529, 25596);

                        f_10279_25529_25595(                // CS0448: The return type for ++ or -- operator must match the parameter type
                                                            //         or be derived from the parameter type
                                        diagnostics, ErrorCode.ERR_BadIncDecRetType, f_10279_25577_25591(this)[0]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 25162, 25611);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 24872, 25611);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 25627, 25682);

                f_10279_25627_25681(
                            diagnostics, f_10279_25643_25657(this)[0], useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 22400, 25693);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_24767_24791(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 24767, 24791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_24899_24927(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 24899, 24927);
                    return return_v;
                }


                bool
                f_10279_24877_24928(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MatchesContainingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 24877, 24928);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_25109_25123(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 25109, 25123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_25059_25127(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 25059, 25127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_25167_25182(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 25167, 25182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_25167_25216(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.EffectiveTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 25167, 25216);
                    return return_v;
                }


                bool
                f_10279_25167_25333(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsEqualToOrDerivedFrom(type, comparison, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 25167, 25333);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_25577_25591(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 25577, 25591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_25529_25595(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 25529, 25595);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_25643_25657(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 25643, 25657);
                    return return_v;
                }


                bool
                f_10279_25627_25681(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 25627, 25681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 22400, 25693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 22400, 25693);
            }
        }

        private bool MatchesContainingType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 25705, 25867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 25781, 25856);

                return f_10279_25788_25855(type, f_10279_25800_25819(this), ComparisonForUserDefinedOperators);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 25705, 25867);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10279_25800_25819(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 25800, 25819);
                    return return_v;
                }


                bool
                f_10279_25788_25855(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 25788, 25855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 25705, 25867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 25705, 25867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckShiftSignature(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 25879, 27031);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 26203, 26726) || true) && (!f_10279_26208_26270(this, f_10279_26230_26269(f_10279_26230_26254(this, 0))) || (DynAbs.Tracing.TraceSender.Expression_False(10279, 26207, 26370) || f_10279_26291_26342(f_10279_26291_26330(f_10279_26291_26315(this, 1))) != SpecialType.System_Int32))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 26203, 26726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 26635, 26711);

                    f_10279_26635_26710(                // CS0546: The first operand of an overloaded shift operator must have the 
                                                        //         same type as the containing type, and the type of the second 
                                                        //         operand must be int
                                    diagnostics, ErrorCode.ERR_BadShiftOperatorSignature, f_10279_26692_26706(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 26203, 26726);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 26742, 27020) || true) && (f_10279_26746_26762(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 26742, 27020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 26932, 27005);

                    f_10279_26932_27004(                // The Roslyn parser does not detect this error.
                                                        // CS0590: User-defined operators cannot return void
                                    diagnostics, ErrorCode.ERR_OperatorCantReturnVoid, f_10279_26986_27000(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 26742, 27020);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 25879, 27031);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_26230_26254(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 26230, 26254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_26230_26269(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 26230, 26269);
                    return return_v;
                }


                bool
                f_10279_26208_26270(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MatchesContainingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 26208, 26270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_26291_26315(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 26291, 26315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_26291_26330(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 26291, 26330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10279_26291_26342(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 26291, 26342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_26692_26706(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 26692, 26706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_26635_26710(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 26635, 26710);
                    return return_v;
                }


                bool
                f_10279_26746_26762(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 26746, 26762);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_26986_27000(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 26986, 27000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_26932_27004(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 26932, 27004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 25879, 27031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 25879, 27031);
            }
        }

        private void CheckBinarySignature(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 27043, 27974);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 27300, 27676) || true) && (!f_10279_27305_27367(this, f_10279_27327_27366(f_10279_27327_27351(this, 0))) && (DynAbs.Tracing.TraceSender.Expression_True(10279, 27304, 27451) && !f_10279_27389_27451(this, f_10279_27411_27450(f_10279_27411_27435(this, 1)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 27300, 27676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 27584, 27661);

                    f_10279_27584_27660(                // CS0563: One of the parameters of a binary operator must be the containing type
                                    diagnostics, ErrorCode.ERR_BadBinaryOperatorSignature, f_10279_27642_27656(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 27300, 27676);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 27692, 27963) || true) && (f_10279_27696_27712(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 27692, 27963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 27875, 27948);

                    f_10279_27875_27947(                // The parser does not detect this error.
                                                        // CS0590: User-defined operators cannot return void
                                    diagnostics, ErrorCode.ERR_OperatorCantReturnVoid, f_10279_27929_27943(this)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 27692, 27963);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 27043, 27974);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_27327_27351(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 27327, 27351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_27327_27366(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 27327, 27366);
                    return return_v;
                }


                bool
                f_10279_27305_27367(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MatchesContainingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 27305, 27367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_27411_27435(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 27411, 27435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_27411_27450(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 27411, 27450);
                    return return_v;
                }


                bool
                f_10279_27389_27451(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MatchesContainingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 27389, 27451);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_27642_27656(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 27642, 27656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_27584_27660(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 27584, 27660);
                    return return_v;
                }


                bool
                f_10279_27696_27712(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 27696, 27712);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_27929_27943(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 27929, 27943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10279_27875_27947(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 27875, 27947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 27043, 27974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 27043, 27974);
            }
        }

        public sealed override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 28045, 28109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 28081, 28094);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 28045, 28109);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 27986, 28120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 27986, 28120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 28196, 28308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 28232, 28251);

                    f_10279_28232_28250(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 28269, 28293);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ReturnsVoid, 10279, 28276, 28292);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 28196, 28308);

                    int
                    f_10279_28232_28250(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 28232, 28250);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 28132, 28319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 28132, 28319);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 28392, 28456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 28428, 28441);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 28392, 28456);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 28331, 28467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 28331, 28467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 28549, 28613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 28585, 28598);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 28549, 28613);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 28479, 28624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 28479, 28624);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 28718, 28791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 28754, 28776);

                    return this.locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 28718, 28791);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 28636, 28802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 28636, 28802);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 28882, 29229);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 28918, 29157) || true) && (f_10279_28922_28948_M(!_lazyParameters.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 28918, 29157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 28990, 29026);

                        int
                        result = _lazyParameters.Length
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 29048, 29102);

                        f_10279_29048_29101(result == f_10279_29071_29100(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 29124, 29138);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 28918, 29157);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 29177, 29214);

                    return f_10279_29184_29213(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 28882, 29229);

                    bool
                    f_10279_28922_28948_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 28922, 28948);
                        return return_v;
                    }


                    int
                    f_10279_29071_29100(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetParameterCountFromSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 29071, 29100);
                        return return_v;
                    }


                    int
                    f_10279_29048_29101(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 29048, 29101);
                        return 0;
                    }


                    int
                    f_10279_29184_29213(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetParameterCountFromSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 29184, 29213);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 28814, 29240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 28814, 29240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract int GetParameterCountFromSyntax();

        public sealed override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 29407, 29518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 29443, 29462);

                    f_10279_29443_29461(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 29480, 29503);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 29407, 29518);

                    int
                    f_10279_29443_29461(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 29443, 29461);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 29317, 29529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 29317, 29529);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 29639, 29696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 29645, 29694);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 29639, 29696);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 29541, 29707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 29541, 29707);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 29841, 29901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 29844, 29901);
                return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 29841, 29901);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 29841, 29901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 29841, 29901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 30028, 30080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 30031, 30080);
                return ImmutableArray<TypeParameterConstraintKind>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 30028, 30080);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 30028, 30080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 30028, 30080);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 30156, 30184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 30162, 30182);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 30156, 30184);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 30093, 30195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 30093, 30195);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 30300, 30411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 30336, 30355);

                    f_10279_30336_30354(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 30373, 30396);

                    return _lazyReturnType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 30300, 30411);

                    int
                    f_10279_30336_30354(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 30336, 30354);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 30207, 30422);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 30207, 30422);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 30507, 30542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 30513, 30540);

                    return _isExpressionBodied;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 30507, 30542);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 30434, 30553);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 30434, 30553);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10279, 30565, 32216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 30967, 31006);

                var
                compilation = f_10279_30985_31005()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 31022, 31116);

                f_10279_31022_31115(f_10279_31022_31037(this), compilation, conversions, f_10279_31084_31098(this)[0], diagnostics);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 31132, 31320);
                    foreach (var parameter in f_10279_31158_31173_I(f_10279_31158_31173(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 31132, 31320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 31207, 31305);

                        f_10279_31207_31304(f_10279_31207_31221(parameter), compilation, conversions, f_10279_31268_31287(parameter)[0], diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 31132, 31320);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10279, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10279, 1, 189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 31336, 31448);

                f_10279_31336_31447(compilation, f_10279_31398_31408(), diagnostics, modifyCompilation: true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 31464, 31656) || true) && (f_10279_31468_31502(f_10279_31468_31478()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 31464, 31656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 31536, 31641);

                    f_10279_31536_31640(compilation, diagnostics, f_10279_31596_31614(), modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 31464, 31656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 31672, 31787);

                f_10279_31672_31786(compilation, f_10279_31737_31747(), diagnostics, modifyCompilation: true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 31803, 32073) || true) && (f_10279_31807_31853(compilation, this) && (DynAbs.Tracing.TraceSender.Expression_True(10279, 31807, 31924) && f_10279_31874_31899().NeedsNullableAttribute()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10279, 31803, 32073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 31958, 32058);

                    f_10279_31958_32057(compilation, diagnostics, f_10279_32013_32031(), modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10279, 31803, 32073);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 32089, 32205);

                f_10279_32089_32204(compilation, this, f_10279_32155_32165(), diagnostics, modifyCompilation: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10279, 30565, 32216);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10279_30985_31005()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 30985, 31005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_31022_31037(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 31022, 31037);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_31084_31098(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 31084, 31098);
                    return return_v;
                }


                int
                f_10279_31022_31115(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, conversions, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 31022, 31115);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10279_31158_31173(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 31158, 31173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_31207_31221(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 31207, 31221);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10279_31268_31287(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 31268, 31287);
                    return return_v;
                }


                int
                f_10279_31207_31304(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, conversions, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 31207, 31304);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10279_31158_31173_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 31158, 31173);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10279_31398_31408()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 31398, 31408);
                    return return_v;
                }


                int
                f_10279_31336_31447(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureIsReadOnlyAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 31336, 31447);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10279_31468_31478()
                {
                    var return_v = ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 31468, 31478);
                    return return_v;
                }


                bool
                f_10279_31468_31502(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 31468, 31502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10279_31596_31614()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 31596, 31614);
                    return return_v;
                }


                int
                f_10279_31536_31640(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNativeIntegerAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 31536, 31640);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10279_31737_31747()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 31737, 31747);
                    return return_v;
                }


                int
                f_10279_31672_31786(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNativeIntegerAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 31672, 31786);
                    return 0;
                }


                bool
                f_10279_31807_31853(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 31807, 31853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10279_31874_31899()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 31874, 31899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10279_32013_32031()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 32013, 32031);
                    return return_v;
                }


                int
                f_10279_31958_32057(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNullableAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 31958, 32057);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10279_32155_32165()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 32155, 32165);
                    return return_v;
                }


                int
                f_10279_32089_32204(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
                container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNullableAttributeExists(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)container, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 32089, 32204);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10279, 30565, 32216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 30565, 32216);
            }
        }

        static SourceUserDefinedOperatorSymbolBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10279, 431, 32223);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10279, 564, 691);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10279, 431, 32223);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10279, 431, 32223);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10279, 431, 32223);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10279_1428_1449(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 1428, 1449);
            return return_v;
        }


        int
        f_10279_1593_1652(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
        symbol, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        modifiers, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            symbol.CheckUnsafeModifier(modifiers, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 1593, 1652);
            return 0;
        }


        int
        f_10279_1939_2087(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
        this_param, Microsoft.CodeAnalysis.MethodKind
        methodKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        declarationModifiers, bool
        returnsVoid, bool
        isExtensionMethod, bool
        isNullableAnalysisEnabled)
        {
            this_param.MakeFlags(methodKind, declarationModifiers, returnsVoid: returnsVoid, isExtensionMethod: isExtensionMethod, isNullableAnalysisEnabled: isNullableAnalysisEnabled);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 1939, 2087);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10279_2108_2127(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 2108, 2127);
            return return_v;
        }


        bool
        f_10279_2108_2139(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 2108, 2139);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10279_2581_2600(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 2581, 2600);
            return return_v;
        }


        bool
        f_10279_2581_2609(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 2581, 2609);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10279_2827_2895(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 2827, 2895);
            return return_v;
        }


        Microsoft.CodeAnalysis.Accessibility
        f_10279_3073_3099(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
        this_param)
        {
            var return_v = this_param.DeclaredAccessibility;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 3073, 3099);
            return return_v;
        }


        bool
        f_10279_3127_3141_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 3127, 3141);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10279_3319_3333(Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 3319, 3333);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10279_3266_3343(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 3266, 3343);
            return return_v;
        }


        bool
        f_10279_3712_3720()
        {
            var return_v = IsExtern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 3712, 3720);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10279_3754_3814(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 3754, 3814);
            return return_v;
        }


        bool
        f_10279_3865_3874_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 3865, 3874);
            return return_v;
        }


        bool
        f_10279_3878_3889_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 3878, 3889);
            return return_v;
        }


        bool
        f_10279_3893_3903_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10279, 3893, 3903);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10279_4174_4240(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location, params object[]
        args)
        {
            var return_v = diagnostics.Add(code, location, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 4174, 4240);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10279_4417_4524(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        modifiers, Microsoft.CodeAnalysis.CSharp.Symbols.SourceUserDefinedOperatorSymbolBase
        symbol, bool
        isExplicitInterfaceImplementation)
        {
            var return_v = ModifierUtils.CheckAccessibility(modifiers, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, isExplicitInterfaceImplementation: isExplicitInterfaceImplementation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 4417, 4524);
            return return_v;
        }


        int
        f_10279_4589_4620(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        info, Microsoft.CodeAnalysis.Location
        location)
        {
            diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10279, 4589, 4620);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10279_1412_1426_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10279, 916, 4647);
            return return_v;
        }

    }
}
