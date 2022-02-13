// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    internal static class FunctionPointerUtilities
    {
        internal static void CommonVerifyFunctionPointer(FunctionPointerTypeSymbol symbol)
        {
            verifyPointerType(symbol);
            verifySignature(symbol.Signature);
            foreach (var param in symbol.Signature.Parameters)
            {
                verifyParameter(param, symbol.Signature);
            }

            static void verifyPointerType(FunctionPointerTypeSymbol symbol)
            {
                CustomAssert.Equal(SymbolKind.FunctionPointerType, symbol.Kind);
                CustomAssert.Equal(TypeKind.FunctionPointer, symbol.TypeKind);

                CustomAssert.False(symbol.IsReferenceType);
                CustomAssert.False(symbol.IsRefLikeType);
                CustomAssert.False(symbol.IsReadOnly);
                CustomAssert.False(symbol.IsStatic);
                CustomAssert.False(symbol.IsAbstract);
                CustomAssert.False(symbol.IsSealed);
                CustomAssert.False(symbol.CanBeReferencedByName);
                CustomAssert.True(symbol.IsTypeOrTypeAlias());

                CustomAssert.True(symbol.IsValueType);
                CustomAssert.True(symbol.CanBeAssignedNull());

                CustomAssert.Null(symbol.ContainingSymbol);
                CustomAssert.Null(symbol.BaseTypeNoUseSiteDiagnostics);
                CustomAssert.Null(symbol.ObsoleteAttributeData);

                CustomAssert.Empty(symbol.Locations);
                CustomAssert.Empty(symbol.DeclaringSyntaxReferences);
                CustomAssert.Empty(symbol.GetMembers());
                CustomAssert.Empty(symbol.GetTypeMembers());
                CustomAssert.Empty(symbol.InterfacesNoUseSiteDiagnostics());
            }

            static void verifySignature(MethodSymbol symbol)
            {
                CustomAssert.NotNull(symbol);

                CustomAssert.Equal(MethodKind.FunctionPointerSignature, symbol.MethodKind);
                CustomAssert.Equal(string.Empty, symbol.Name);
                CustomAssert.Equal(0, symbol.Arity);
                CustomAssert.Equal(default, symbol.ImplementationAttributes);
                CustomAssert.Equal(Accessibility.NotApplicable, symbol.DeclaredAccessibility);
                CustomAssert.Equal(FlowAnalysisAnnotations.None, symbol.ReturnTypeFlowAnalysisAnnotations);
                CustomAssert.Equal(FlowAnalysisAnnotations.None, symbol.FlowAnalysisAnnotations);

                CustomAssert.False(symbol.IsExtensionMethod);
                CustomAssert.False(symbol.HidesBaseMethodsByName);
                CustomAssert.False(symbol.IsStatic);
                CustomAssert.False(symbol.IsAsync);
                CustomAssert.False(symbol.IsVirtual);
                CustomAssert.False(symbol.IsOverride);
                CustomAssert.False(symbol.IsAbstract);
                CustomAssert.False(symbol.IsExtern);
                CustomAssert.False(symbol.IsExtensionMethod);
                CustomAssert.False(symbol.IsSealed);
                CustomAssert.False(symbol.IsExtern);
                CustomAssert.False(symbol.HasSpecialName);
                CustomAssert.False(symbol.HasDeclarativeSecurity);
                CustomAssert.False(symbol.RequiresSecurityObject);
                CustomAssert.False(symbol.IsDeclaredReadOnly);
                CustomAssert.False(symbol.IsMetadataNewSlot(true));
                CustomAssert.False(symbol.IsMetadataNewSlot(false));
                CustomAssert.False(symbol.IsMetadataVirtual(true));
                CustomAssert.False(symbol.IsMetadataVirtual(false));

                CustomAssert.Equal(symbol.IsVararg, symbol.CallingConvention.IsCallingConvention(CallingConvention.ExtraArguments));

                CustomAssert.True(symbol.IsImplicitlyDeclared);

                CustomAssert.Null(symbol.ContainingSymbol);
                CustomAssert.Null(symbol.AssociatedSymbol);
                CustomAssert.Null(symbol.ReturnValueMarshallingInformation);

                CustomAssert.Empty(symbol.TypeParameters);
                CustomAssert.Empty(symbol.ExplicitInterfaceImplementations);
                CustomAssert.Empty(symbol.Locations);
                CustomAssert.Empty(symbol.DeclaringSyntaxReferences);
                CustomAssert.Empty(symbol.TypeArgumentsWithAnnotations);
                CustomAssert.Empty(symbol.GetAppliedConditionalSymbols());
                CustomAssert.Empty(symbol.ReturnNotNullIfParameterNotNull);
            }

            static void verifyParameter(ParameterSymbol symbol, MethodSymbol containing)
            {
                CustomAssert.NotNull(symbol);

                CustomAssert.Same(symbol.ContainingSymbol, containing);

                CustomAssert.Equal(string.Empty, symbol.Name);
                CustomAssert.Equal(FlowAnalysisAnnotations.None, symbol.FlowAnalysisAnnotations);

                CustomAssert.False(symbol.IsDiscard);
                CustomAssert.False(symbol.IsParams);
                CustomAssert.False(symbol.IsMetadataOptional);
                CustomAssert.False(symbol.IsIDispatchConstant);
                CustomAssert.False(symbol.IsIUnknownConstant);
                CustomAssert.False(symbol.IsCallerFilePath);
                CustomAssert.False(symbol.IsCallerLineNumber);
                CustomAssert.False(symbol.IsCallerFilePath);
                CustomAssert.False(symbol.IsCallerMemberName);

                CustomAssert.True(symbol.IsImplicitlyDeclared);

                CustomAssert.Null(symbol.MarshallingInformation);
                CustomAssert.Null(symbol.ExplicitDefaultConstantValue);

                CustomAssert.Empty(symbol.Locations);
                CustomAssert.Empty(symbol.DeclaringSyntaxReferences);
                CustomAssert.Empty(symbol.NotNullIfParameterNotNull);
            }
        }

        public static void VerifyFunctionPointerSemanticInfo(
            SemanticModel model,
            SyntaxNode syntax,
            string expectedSyntax,
            string? expectedType,
            string? expectedConvertedType = null,
            string? expectedSymbol = null,
            CandidateReason expectedCandidateReason = CandidateReason.None,
            string[]? expectedSymbolCandidates = null)
        {
            AssertEx.Equal(expectedSyntax, syntax.ToString());
            var semanticInfo = model.GetSemanticInfoSummary(syntax);
            ITypeSymbol? exprType;

            if (expectedType is null)
            {
                exprType = semanticInfo.ConvertedType;
                CustomAssert.Null(semanticInfo.Type);
            }
            else
            {
                exprType = semanticInfo.Type;
                AssertEx.Equal(expectedType, semanticInfo.Type.ToTestDisplayString(includeNonNullable: false));
            }

            if (expectedConvertedType is null)
            {
                CustomAssert.Equal(semanticInfo.Type, semanticInfo.ConvertedType, SymbolEqualityComparer.IncludeNullability);
            }
            else
            {
                AssertEx.Equal(expectedConvertedType, semanticInfo.ConvertedType.ToTestDisplayString(includeNonNullable: false));
            }

            verifySymbolInfo(expectedSymbol, expectedCandidateReason, expectedSymbolCandidates, semanticInfo);

            if (exprType is IFunctionPointerTypeSymbol ptrType)
            {
                CommonVerifyFunctionPointer(ptrType.GetSymbol());
            }

            switch (syntax)
            {
                case FunctionPointerTypeSyntax { ParameterList: { Parameters: var paramSyntaxes } }:
                    verifyNestedFunctionPointerSyntaxSemanticInfo(model, (IFunctionPointerTypeSymbol)exprType, paramSyntaxes);
                    break;

                case PrefixUnaryExpressionSyntax { RawKind: (int)SyntaxKind.AddressOfExpression, Operand: var operand }:
                    // Members should only be accessible from the underlying operand
                    CustomAssert.Empty(semanticInfo.MemberGroup);
                    var expectedConversionKind = (expectedType, expectedConvertedType, expectedSymbol) switch
                    {
                        (null, null, _) => ConversionKind.Identity,
                        (_, _, null) => ConversionKind.NoConversion,
                        (_, _, _) => ConversionKind.MethodGroup,
                    };
                    CustomAssert.Equal(expectedConversionKind, semanticInfo.ImplicitConversion.Kind);

                    semanticInfo = model.GetSemanticInfoSummary(operand);
                    CustomAssert.Null(semanticInfo.Type);
                    CustomAssert.Null(semanticInfo.ConvertedType);
                    if (expectedSymbolCandidates != null)
                    {
                        AssertEx.Equal(expectedSymbolCandidates, semanticInfo.MemberGroup.Select(s => s.ToTestDisplayString(includeNonNullable: false)));
                    }
                    else
                    {
                        CustomAssert.Contains(semanticInfo.MemberGroup, actual => actual.ToTestDisplayString(includeNonNullable: false) == expectedSymbol);
                    }

                    verifySymbolInfo(expectedSymbol, expectedCandidateReason, expectedSymbolCandidates, semanticInfo);

                    break;
            }

            static void verifySymbolInfo(
                string? expectedSymbol,
                CandidateReason expectedReason,
                string[]? expectedSymbolCandidates,
                CompilationUtils.SemanticInfoSummary semanticInfo)
            {
                if (expectedSymbol is object)
                {
                    CustomAssert.Empty(semanticInfo.CandidateSymbols);
                    AssertEx.Equal(expectedSymbol, semanticInfo.Symbol.ToTestDisplayString(includeNonNullable: false));
                    CustomAssert.Equal(CandidateReason.None, semanticInfo.CandidateReason);
                }
                else if (expectedSymbolCandidates is object)
                {
                    CustomAssert.Null(semanticInfo.Symbol);
                    CustomAssert.Equal(expectedReason, semanticInfo.CandidateReason);
                    AssertEx.Equal(expectedSymbolCandidates, semanticInfo.CandidateSymbols.Select(s => s.ToTestDisplayString(includeNonNullable: false)));
                }
                else
                {
                    CustomAssert.Null(semanticInfo.Symbol);
                    CustomAssert.Empty(semanticInfo.CandidateSymbols);
                    CustomAssert.Equal(CandidateReason.None, semanticInfo.CandidateReason);
                }
            }

            static void verifyNestedFunctionPointerSyntaxSemanticInfo(SemanticModel model, IFunctionPointerTypeSymbol ptrType, SeparatedSyntaxList<FunctionPointerParameterSyntax> paramSyntaxes)
            {
                // https://github.com/dotnet/roslyn/issues/43321 Nullability in type syntaxes that don't have an origin bound node
                // can differ.
                var signature = ptrType.Signature;
                for (int i = 0; i < paramSyntaxes.Count - 1; i++)
                {
                    var paramSyntax = paramSyntaxes[i].Type!;
                    ITypeSymbol signatureParamType = signature.Parameters[i].Type;
                    assertEqualSemanticInformation(model, paramSyntax, signatureParamType);
                }

                var returnParam = paramSyntaxes[^1].Type;
                assertEqualSemanticInformation(model, returnParam!, signature.ReturnType);
            }

            static void assertEqualSemanticInformation(SemanticModel model, TypeSyntax typeSyntax, ITypeSymbol signatureType)
            {
                var semanticInfo = model.GetSemanticInfoSummary(typeSyntax);
                CustomAssert.Equal<ISymbol>(signatureType, semanticInfo.Type, SymbolEqualityComparer.Default);
                CustomAssert.Equal(semanticInfo.Type, semanticInfo.ConvertedType, SymbolEqualityComparer.IncludeNullability);

                CustomAssert.Equal(CandidateReason.None, semanticInfo.CandidateReason);
                CustomAssert.Equal(signatureType, semanticInfo.Type, SymbolEqualityComparer.Default);
                CustomAssert.Empty(semanticInfo.CandidateSymbols);

                if (typeSyntax is FunctionPointerTypeSyntax { ParameterList: { Parameters: var paramSyntaxes } })
                {
                    var paramPtrType = (IFunctionPointerTypeSymbol)semanticInfo.Type!;
                    CommonVerifyFunctionPointer(paramPtrType.GetSymbol());
                    verifyNestedFunctionPointerSyntaxSemanticInfo(model, paramPtrType, paramSyntaxes);
                }
            }
        }

        public static void VerifyFunctionPointerSymbol(TypeSymbol type, CallingConvention expectedConvention, (RefKind RefKind, Action<TypeSymbol> TypeVerifier) returnVerifier, params (RefKind RefKind, Action<TypeSymbol> TypeVerifier)[] argumentVerifiers)
        {
            FunctionPointerTypeSymbol funcPtr = (FunctionPointerTypeSymbol)type;

            FunctionPointerUtilities.CommonVerifyFunctionPointer(funcPtr);

            var signature = funcPtr.Signature;
            CustomAssert.Equal(expectedConvention, signature.CallingConvention);

            CustomAssert.Equal(returnVerifier.RefKind, signature.RefKind);
            switch (signature.RefKind)
            {
                case RefKind.RefReadOnly:
                    CustomAssert.True(CustomModifierUtils.HasInAttributeModifier(signature.RefCustomModifiers));
                    CustomAssert.False(CustomModifierUtils.HasOutAttributeModifier(signature.RefCustomModifiers));
                    break;

                case RefKind.None:
                case RefKind.Ref:
                    CustomAssert.False(CustomModifierUtils.HasInAttributeModifier(signature.RefCustomModifiers));
                    CustomAssert.False(CustomModifierUtils.HasOutAttributeModifier(signature.RefCustomModifiers));
                    break;

                case RefKind.Out:
                default:
                    CustomAssert.True(false, $"Cannot have a return ref kind of {signature.RefKind}");
                    break;
            }
            returnVerifier.TypeVerifier(signature.ReturnType);

            CustomAssert.Equal(argumentVerifiers.Length, signature.ParameterCount);
            for (int i = 0; i < argumentVerifiers.Length; i++)
            {
                var parameter = signature.Parameters[i];
                CustomAssert.Equal(argumentVerifiers[i].RefKind, parameter.RefKind);
                argumentVerifiers[i].TypeVerifier(parameter.Type);
                switch (parameter.RefKind)
                {
                    case RefKind.Out:
                        CustomAssert.True(CustomModifierUtils.HasOutAttributeModifier(parameter.RefCustomModifiers));
                        CustomAssert.False(CustomModifierUtils.HasInAttributeModifier(parameter.RefCustomModifiers));
                        break;

                    case RefKind.In:
                        CustomAssert.True(CustomModifierUtils.HasInAttributeModifier(parameter.RefCustomModifiers));
                        CustomAssert.False(CustomModifierUtils.HasOutAttributeModifier(parameter.RefCustomModifiers));
                        break;

                    case RefKind.Ref:
                    case RefKind.None:
                        CustomAssert.False(CustomModifierUtils.HasInAttributeModifier(parameter.RefCustomModifiers));
                        CustomAssert.False(CustomModifierUtils.HasOutAttributeModifier(parameter.RefCustomModifiers));
                        break;

                    default:
                        CustomAssert.True(false, $"Cannot have a return ref kind of {parameter.RefKind}");
                        break;
                }
            }
        }

        public static Action<TypeSymbol> IsVoidType() => typeSymbol => CustomAssert.True(typeSymbol.IsVoidType());

        public static Action<TypeSymbol> IsSpecialType(SpecialType specialType)
            => typeSymbol => CustomAssert.Equal(specialType, typeSymbol.SpecialType);

        public static Action<TypeSymbol> IsTypeName(string typeName)
            => typeSymbol => CustomAssert.Equal(typeName, typeSymbol.Name);

        public static Action<TypeSymbol> IsArrayType(Action<TypeSymbol> arrayTypeVerifier)
            => typeSymbol =>
            {
                CustomAssert.True(typeSymbol.IsArray());
                arrayTypeVerifier(((ArrayTypeSymbol)typeSymbol).ElementType);
            };

        public static Action<TypeSymbol> IsUnsupportedType()
            => typeSymbol => CustomAssert.True(typeSymbol is UnsupportedMetadataTypeSymbol);

        public static Action<TypeSymbol> IsFunctionPointerTypeSymbol(CallingConvention callingConvention, (RefKind, Action<TypeSymbol>) returnVerifier, params (RefKind, Action<TypeSymbol>)[] argumentVerifiers)
            => typeSymbol => VerifyFunctionPointerSymbol((FunctionPointerTypeSymbol)typeSymbol, callingConvention, returnVerifier, argumentVerifiers);

        public static Action<TypeSymbol> IsErrorType()
            => typeSymbol => CustomAssert.True(typeSymbol.IsErrorType());

    }
}
