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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 523, 5972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 630, 656);

                f_21010_630_655(symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 670, 704);

                f_21010_670_703(f_21010_686_702(symbol));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 718, 857);
                    foreach (var param in f_21010_740_767_I(f_21010_740_767(f_21010_740_756(symbol))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 718, 857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 801, 842);

                        f_21010_801_841(param, f_21010_824_840(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 718, 857);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21010, 1, 140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21010, 1, 140);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 523, 5972);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 523, 5972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 523, 5972);
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 5984, 12890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6427, 6477);

                f_21010_6427_6476(expectedSyntax, f_21010_6458_6475(syntax));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6491, 6547);

                var
                semanticInfo = f_21010_6510_6546(model, syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6561, 6583);

                ITypeSymbol?
                exprType
                = default(ITypeSymbol?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6599, 6967) || true) && (expectedType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 6599, 6967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6657, 6695);

                    exprType = semanticInfo.ConvertedType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6713, 6744);

                    f_21010_6713_6743(semanticInfo.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 6599, 6967);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 6599, 6967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6810, 6839);

                    exprType = semanticInfo.Type;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6857, 6952);

                    f_21010_6857_6951(expectedType, f_21010_6886_6950(semanticInfo.Type, includeNonNullable: false));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 6599, 6967);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6983, 7347) || true) && (expectedConvertedType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 6983, 7347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7050, 7153);

                    f_21010_7050_7152(semanticInfo.Type, semanticInfo.ConvertedType, SymbolEqualityComparer.IncludeNullability);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 6983, 7347);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 6983, 7347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7219, 7332);

                    f_21010_7219_7331(expectedConvertedType, f_21010_7257_7330(semanticInfo.ConvertedType, includeNonNullable: false));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 6983, 7347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7363, 7461);

                f_21010_7363_7460(expectedSymbol, expectedCandidateReason, expectedSymbolCandidates, semanticInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7477, 7625) || true) && (exprType is IFunctionPointerTypeSymbol ptrType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 7477, 7625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7561, 7610);

                    f_21010_7561_7609(f_21010_7589_7608(ptrType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 7477, 7625);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7641, 9502);

                switch (syntax)
                {

                    case FunctionPointerTypeSyntax { ParameterList: { Parameters: var paramSyntaxes } }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 7641, 9502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7795, 7901);

                        f_21010_7795_7900(model, exprType, paramSyntaxes);
                        DynAbs.Tracing.TraceSender.TraceBreak(21010, 7923, 7929);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 7641, 9502);

                    case PrefixUnaryExpressionSyntax { RawKind: (int)SyntaxKind.AddressOfExpression, Operand: var operand }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 7641, 9502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8161, 8200);

                        f_21010_8161_8199(semanticInfo.MemberGroup);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8222, 8563);

                        var
                        expectedConversionKind = (expectedType, expectedConvertedType, expectedSymbol) switch
                        {
                            (null, null, _) => ConversionKind.Identity,
                            (_, _, null) => ConversionKind.NoConversion,
                            (_, _, _) => ConversionKind.MethodGroup,
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8585, 8660);

                        f_21010_8585_8659(expectedConversionKind, semanticInfo.ImplicitConversion.Kind);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8684, 8737);

                        semanticInfo = f_21010_8699_8736(model, operand);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8759, 8790);

                        f_21010_8759_8789(semanticInfo.Type);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8812, 8852);

                        f_21010_8812_8851(semanticInfo.ConvertedType);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8874, 9335) || true) && (expectedSymbolCandidates != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 8874, 9335);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8960, 9089);

                            f_21010_8960_9088(expectedSymbolCandidates, semanticInfo.MemberGroup.Select(s => s.ToTestDisplayString(includeNonNullable: false)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 8874, 9335);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 8874, 9335);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 9187, 9312);

                            f_21010_9187_9311(semanticInfo.MemberGroup, actual => actual.ToTestDisplayString(includeNonNullable: false) == expectedSymbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 8874, 9335);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 9359, 9457);

                        f_21010_9359_9456(expectedSymbol, expectedCandidateReason, expectedSymbolCandidates, semanticInfo);
                        DynAbs.Tracing.TraceSender.TraceBreak(21010, 9481, 9487);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 7641, 9502);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 5984, 12890);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 5984, 12890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 5984, 12890);
            }
        }

        public static void VerifyFunctionPointerSymbol(TypeSymbol type, CallingConvention expectedConvention, (RefKind RefKind, Action<TypeSymbol> TypeVerifier) returnVerifier, params (RefKind RefKind, Action<TypeSymbol> TypeVerifier)[] argumentVerifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 12902, 16025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 13174, 13242);

                FunctionPointerTypeSymbol
                funcPtr = (FunctionPointerTypeSymbol)type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 13258, 13320);

                f_21010_13258_13319(funcPtr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 13336, 13370);

                var
                signature = f_21010_13352_13369(funcPtr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 13384, 13446);

                f_21010_13384_13445(expectedConvention, f_21010_13417_13444(signature));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 13462, 13518);

                f_21010_13462_13517(returnVerifier.RefKind, f_21010_13499_13516(signature));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 13532, 14386);

                switch (f_21010_13540_13557(signature))
                {

                    case RefKind.RefReadOnly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 13532, 14386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 13638, 13724);

                        f_21010_13638_13723(CustomModifierUtils.HasInAttributeModifier(f_21010_13693_13721(signature)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 13746, 13834);

                        f_21010_13746_13833(CustomModifierUtils.HasOutAttributeModifier(f_21010_13803_13831(signature)));
                        DynAbs.Tracing.TraceSender.TraceBreak(21010, 13856, 13862);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 13532, 14386);

                    case RefKind.None:
                    case RefKind.Ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 13532, 14386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 13957, 14044);

                        f_21010_13957_14043(CustomModifierUtils.HasInAttributeModifier(f_21010_14013_14041(signature)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14066, 14154);

                        f_21010_14066_14153(CustomModifierUtils.HasOutAttributeModifier(f_21010_14123_14151(signature)));
                        DynAbs.Tracing.TraceSender.TraceBreak(21010, 14176, 14182);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 13532, 14386);

                    case RefKind.Out:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 13532, 14386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14267, 14343);

                        f_21010_14267_14342(false, $"Cannot have a return ref kind of {f_21010_14322_14339(signature)}");
                        DynAbs.Tracing.TraceSender.TraceBreak(21010, 14365, 14371);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 13532, 14386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14400, 14450);

                f_21010_14400_14449(ref returnVerifier, f_21010_14428_14448(signature));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14466, 14531);

                f_21010_14466_14530(f_21010_14479_14503(argumentVerifiers), f_21010_14505_14529(signature));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14554, 14559);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14545, 16014) || true) && (i < f_21010_14565_14589(argumentVerifiers))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14591, 14594)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 14545, 16014))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 14545, 16014);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14628, 14668);

                        var
                        parameter = f_21010_14644_14664(signature)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14686, 14748);

                        f_21010_14686_14747(argumentVerifiers[i].RefKind, f_21010_14729_14746(parameter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14766, 14816);

                        f_21010_14766_14815(argumentVerifiers[i], f_21010_14800_14814(parameter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14834, 15999);

                        switch (f_21010_14842_14859(parameter))
                        {

                            case RefKind.Out:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 14834, 15999);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 14944, 15031);

                                f_21010_14944_15030(CustomModifierUtils.HasOutAttributeModifier(f_21010_15000_15028(parameter)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 15057, 15144);

                                f_21010_15057_15143(CustomModifierUtils.HasInAttributeModifier(f_21010_15113_15141(parameter)));
                                DynAbs.Tracing.TraceSender.TraceBreak(21010, 15170, 15176);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 14834, 15999);

                            case RefKind.In:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 14834, 15999);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 15242, 15328);

                                f_21010_15242_15327(CustomModifierUtils.HasInAttributeModifier(f_21010_15297_15325(parameter)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 15354, 15442);

                                f_21010_15354_15441(CustomModifierUtils.HasOutAttributeModifier(f_21010_15411_15439(parameter)));
                                DynAbs.Tracing.TraceSender.TraceBreak(21010, 15468, 15474);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 14834, 15999);

                            case RefKind.Ref:
                            case RefKind.None:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 14834, 15999);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 15581, 15668);

                                f_21010_15581_15667(CustomModifierUtils.HasInAttributeModifier(f_21010_15637_15665(parameter)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 15694, 15782);

                                f_21010_15694_15781(CustomModifierUtils.HasOutAttributeModifier(f_21010_15751_15779(parameter)));
                                DynAbs.Tracing.TraceSender.TraceBreak(21010, 15808, 15814);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 14834, 15999);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 14834, 15999);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 15872, 15948);

                                f_21010_15872_15947(false, $"Cannot have a return ref kind of {f_21010_15927_15944(parameter)}");
                                DynAbs.Tracing.TraceSender.TraceBreak(21010, 15974, 15980);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 14834, 15999);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21010, 1, 1470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21010, 1, 1470);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 12902, 16025);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 12902, 16025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 12902, 16025);
            }
        }

        public static Action<TypeSymbol> IsVoidType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21010, 16083, 16136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 16086, 16136);
                return typeSymbol => Assert.True(typeSymbol.IsVoidType()); DynAbs.Tracing.TraceSender.TraceExitMethod(21010, 16083, 16136);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 16083, 16136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 16083, 16136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Action<TypeSymbol> IsSpecialType(SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21010, 16234, 16300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 16237, 16300);
                return typeSymbol => Assert.Equal(specialType, typeSymbol.SpecialType); DynAbs.Tracing.TraceSender.TraceExitMethod(21010, 16234, 16300);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 16234, 16300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 16234, 16300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Action<TypeSymbol> IsTypeName(string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21010, 16387, 16443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 16390, 16443);
                return typeSymbol => Assert.Equal(typeName, typeSymbol.Name); DynAbs.Tracing.TraceSender.TraceExitMethod(21010, 16387, 16443);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 16387, 16443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 16387, 16443);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Action<TypeSymbol> IsArrayType(Action<TypeSymbol> arrayTypeVerifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21010, 16552, 16729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 16555, 16729);
                return typeSymbol =>
                            {
                                Assert.True(typeSymbol.IsArray());
                                arrayTypeVerifier(((ArrayTypeSymbol)typeSymbol).ElementType);
                            }; DynAbs.Tracing.TraceSender.TraceExitMethod(21010, 16552, 16729);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 16552, 16729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 16552, 16729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Action<TypeSymbol> IsUnsupportedType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21010, 16808, 16881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 16811, 16881);
                return typeSymbol => Assert.True(typeSymbol is UnsupportedMetadataTypeSymbol); DynAbs.Tracing.TraceSender.TraceExitMethod(21010, 16808, 16881);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 16808, 16881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 16808, 16881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Action<TypeSymbol> IsFunctionPointerTypeSymbol(CallingConvention callingConvention, (RefKind, Action<TypeSymbol>) returnVerifier, params (RefKind, Action<TypeSymbol>)[] argumentVerifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21010, 17109, 17246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 17112, 17246);
                return typeSymbol => VerifyFunctionPointerSymbol((FunctionPointerTypeSymbol)typeSymbol, callingConvention, returnVerifier, argumentVerifiers); DynAbs.Tracing.TraceSender.TraceExitMethod(21010, 17109, 17246);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 17109, 17246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 17109, 17246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Action<TypeSymbol> IsErrorType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21010, 17319, 17373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 17322, 17373);
                return typeSymbol => Assert.True(typeSymbol.IsErrorType()); DynAbs.Tracing.TraceSender.TraceExitMethod(21010, 17319, 17373);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 17319, 17373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 17319, 17373);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FunctionPointerUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21010, 460, 17383);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21010, 460, 17383);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 460, 17383);
        }


        static int
        f_21010_630_655(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        symbol)
        {
            verifyPointerType(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 630, 655);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        f_21010_686_702(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 686, 702);
            return return_v;
        }


        static int
        f_21010_670_703(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        symbol)
        {
            verifySignature((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 670, 703);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        f_21010_740_756(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 740, 756);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_21010_740_767(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 740, 767);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        f_21010_824_840(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 824, 840);
            return return_v;
        }


        static int
        f_21010_801_841(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        symbol, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        containing)
        {
            verifyParameter(symbol, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)containing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 801, 841);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_21010_740_767_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 740, 767);
            return return_v;
        }


        static string
        f_21010_6458_6475(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6458, 6475);
            return return_v;
        }


        static int
        f_21010_6427_6476(string
        expected, string
        actual)
        {
            AssertEx.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6427, 6476);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary
        f_21010_6510_6546(Microsoft.CodeAnalysis.SemanticModel
        semanticModel, Microsoft.CodeAnalysis.SyntaxNode
        node)
        {
            var return_v = semanticModel.GetSemanticInfoSummary(node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6510, 6546);
            return return_v;
        }


        static int
        f_21010_6713_6743(Microsoft.CodeAnalysis.ITypeSymbol
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6713, 6743);
            return 0;
        }


        static string
        f_21010_6886_6950(Microsoft.CodeAnalysis.ITypeSymbol
        symbol, bool
        includeNonNullable)
        {
            var return_v = symbol.ToTestDisplayString(includeNonNullable: includeNonNullable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6886, 6950);
            return return_v;
        }


        static int
        f_21010_6857_6951(string
        expected, string
        actual)
        {
            AssertEx.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6857, 6951);
            return 0;
        }


        static int
        f_21010_7050_7152(Microsoft.CodeAnalysis.ITypeSymbol
        expected, Microsoft.CodeAnalysis.ITypeSymbol
        actual, Microsoft.CodeAnalysis.SymbolEqualityComparer
        comparer)
        {
            Assert.Equal((Microsoft.CodeAnalysis.ISymbol)expected, (Microsoft.CodeAnalysis.ISymbol)actual, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.ISymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7050, 7152);
            return 0;
        }


        static string
        f_21010_7257_7330(Microsoft.CodeAnalysis.ITypeSymbol
        symbol, bool
        includeNonNullable)
        {
            var return_v = symbol.ToTestDisplayString(includeNonNullable: includeNonNullable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7257, 7330);
            return return_v;
        }


        static int
        f_21010_7219_7331(string
        expected, string
        actual)
        {
            AssertEx.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7219, 7331);
            return 0;
        }


        static int
        f_21010_7363_7460(string?
        expectedSymbol, Microsoft.CodeAnalysis.CandidateReason
        expectedReason, string[]?
        expectedSymbolCandidates, Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary
        semanticInfo)
        {
            verifySymbolInfo(expectedSymbol, expectedReason, expectedSymbolCandidates, semanticInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7363, 7460);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol?
        f_21010_7589_7608(Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol
        symbol)
        {
            var return_v = symbol.GetSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7589, 7608);
            return return_v;
        }


        static int
        f_21010_7561_7609(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        symbol)
        {
            CommonVerifyFunctionPointer(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7561, 7609);
            return 0;
        }


        static int
        f_21010_7795_7900(Microsoft.CodeAnalysis.SemanticModel
        model, Microsoft.CodeAnalysis.ITypeSymbol
        ptrType, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax>
        paramSyntaxes)
        {
            verifyNestedFunctionPointerSyntaxSemanticInfo(model, (Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol)ptrType, paramSyntaxes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7795, 7900);
            return 0;
        }


        static int
        f_21010_8161_8199(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8161, 8199);
            return 0;
        }


        static int
        f_21010_8585_8659(Microsoft.CodeAnalysis.CSharp.ConversionKind
        expected, Microsoft.CodeAnalysis.CSharp.ConversionKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8585, 8659);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary
        f_21010_8699_8736(Microsoft.CodeAnalysis.SemanticModel
        semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
        node)
        {
            var return_v = semanticModel.GetSemanticInfoSummary((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8699, 8736);
            return return_v;
        }


        static int
        f_21010_8759_8789(Microsoft.CodeAnalysis.ITypeSymbol
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8759, 8789);
            return 0;
        }


        static int
        f_21010_8812_8851(Microsoft.CodeAnalysis.ITypeSymbol
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8812, 8851);
            return 0;
        }


        static int
        f_21010_8960_9088(string[]
        expected, System.Collections.Generic.IEnumerable<string>
        actual)
        {
            AssertEx.Equal((System.Collections.Generic.IEnumerable<string>)expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8960, 9088);
            return 0;
        }


        static int
        f_21010_9187_9311(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
        collection, System.Predicate<Microsoft.CodeAnalysis.ISymbol>
        filter)
        {
            Assert.Contains((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)collection, filter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 9187, 9311);
            return 0;
        }


        static int
        f_21010_9359_9456(string?
        expectedSymbol, Microsoft.CodeAnalysis.CandidateReason
        expectedReason, string[]?
        expectedSymbolCandidates, Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary
        semanticInfo)
        {
            verifySymbolInfo(expectedSymbol, expectedReason, expectedSymbolCandidates, semanticInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 9359, 9456);
            return 0;
        }


        static int
        f_21010_13258_13319(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        symbol)
        {
            FunctionPointerUtilities.CommonVerifyFunctionPointer(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 13258, 13319);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        f_21010_13352_13369(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 13352, 13369);
            return return_v;
        }


        static Microsoft.Cci.CallingConvention
        f_21010_13417_13444(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.CallingConvention;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 13417, 13444);
            return return_v;
        }


        static int
        f_21010_13384_13445(Microsoft.Cci.CallingConvention
        expected, Microsoft.Cci.CallingConvention
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 13384, 13445);
            return 0;
        }


        static Microsoft.CodeAnalysis.RefKind
        f_21010_13499_13516(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 13499, 13516);
            return return_v;
        }


        static int
        f_21010_13462_13517(Microsoft.CodeAnalysis.RefKind
        expected, Microsoft.CodeAnalysis.RefKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 13462, 13517);
            return 0;
        }


        static Microsoft.CodeAnalysis.RefKind
        f_21010_13540_13557(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 13540, 13557);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_21010_13693_13721(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 13693, 13721);
            return return_v;
        }


        static int
        f_21010_13638_13723(bool
        condition)
        {
            Assert.True(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 13638, 13723);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_21010_13803_13831(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 13803, 13831);
            return return_v;
        }


        static int
        f_21010_13746_13833(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 13746, 13833);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_21010_14013_14041(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 14013, 14041);
            return return_v;
        }


        static int
        f_21010_13957_14043(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 13957, 14043);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_21010_14123_14151(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 14123, 14151);
            return return_v;
        }


        static int
        f_21010_14066_14153(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 14066, 14153);
            return 0;
        }


        static Microsoft.CodeAnalysis.RefKind
        f_21010_14322_14339(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 14322, 14339);
            return return_v;
        }


        static int
        f_21010_14267_14342(bool
        condition, string
        userMessage)
        {
            Assert.True(condition, userMessage);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 14267, 14342);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_21010_14428_14448(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 14428, 14448);
            return return_v;
        }


        static int
        f_21010_14400_14449(ref (Microsoft.CodeAnalysis.RefKind RefKind, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol> TypeVerifier)
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        obj)
        {
            this_param.TypeVerifier(obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 14400, 14449);
            return 0;
        }


        static int
        f_21010_14479_14503((Microsoft.CodeAnalysis.RefKind RefKind, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol> TypeVerifier)[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 14479, 14503);
            return return_v;
        }


        static int
        f_21010_14505_14529(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.ParameterCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 14505, 14529);
            return return_v;
        }


        static int
        f_21010_14466_14530(int
        expected, int
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 14466, 14530);
            return 0;
        }


        static int
        f_21010_14565_14589((Microsoft.CodeAnalysis.RefKind RefKind, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol> TypeVerifier)[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 14565, 14589);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_21010_14644_14664(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 14644, 14664);
            return return_v;
        }


        static Microsoft.CodeAnalysis.RefKind
        f_21010_14729_14746(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 14729, 14746);
            return return_v;
        }


        static int
        f_21010_14686_14747(Microsoft.CodeAnalysis.RefKind
        expected, Microsoft.CodeAnalysis.RefKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 14686, 14747);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_21010_14800_14814(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 14800, 14814);
            return return_v;
        }


        static int
        f_21010_14766_14815((Microsoft.CodeAnalysis.RefKind RefKind, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol> TypeVerifier)
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        obj)
        {
            this_param.TypeVerifier(obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 14766, 14815);
            return 0;
        }


        static Microsoft.CodeAnalysis.RefKind
        f_21010_14842_14859(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 14842, 14859);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_21010_15000_15028(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 15000, 15028);
            return return_v;
        }


        static int
        f_21010_14944_15030(bool
        condition)
        {
            Assert.True(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 14944, 15030);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_21010_15113_15141(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 15113, 15141);
            return return_v;
        }


        static int
        f_21010_15057_15143(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 15057, 15143);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_21010_15297_15325(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 15297, 15325);
            return return_v;
        }


        static int
        f_21010_15242_15327(bool
        condition)
        {
            Assert.True(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 15242, 15327);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_21010_15411_15439(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 15411, 15439);
            return return_v;
        }


        static int
        f_21010_15354_15441(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 15354, 15441);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_21010_15637_15665(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 15637, 15665);
            return return_v;
        }


        static int
        f_21010_15581_15667(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 15581, 15667);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_21010_15751_15779(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 15751, 15779);
            return return_v;
        }


        static int
        f_21010_15694_15781(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 15694, 15781);
            return 0;
        }


        static Microsoft.CodeAnalysis.RefKind
        f_21010_15927_15944(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 15927, 15944);
            return return_v;
        }


        static int
        f_21010_15872_15947(bool
        condition, string
        userMessage)
        {
            Assert.True(condition, userMessage);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 15872, 15947);
            return 0;
        }


        static void
        verifyPointerType(FunctionPointerTypeSymbol symbol)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 873, 2131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 969, 1027);

                f_21010_969_1026(SymbolKind.FunctionPointerType, f_21010_1014_1025(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1045, 1101);

                f_21010_1045_1100(TypeKind.FunctionPointer, f_21010_1084_1099(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1121, 1158);

                f_21010_1121_1157(f_21010_1134_1156(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1176, 1211);

                f_21010_1176_1210(f_21010_1189_1209(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1229, 1261);

                f_21010_1229_1260(f_21010_1242_1259(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1279, 1309);

                f_21010_1279_1308(f_21010_1292_1307(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1327, 1359);

                f_21010_1327_1358(f_21010_1340_1357(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1377, 1407);

                f_21010_1377_1406(f_21010_1390_1405(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1425, 1468);

                f_21010_1425_1467(f_21010_1438_1466(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1486, 1526);

                f_21010_1486_1525(f_21010_1498_1524(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1546, 1578);

                f_21010_1546_1577(f_21010_1558_1576(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1596, 1636);

                f_21010_1596_1635(f_21010_1608_1634(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1656, 1693);

                f_21010_1656_1692(f_21010_1668_1691(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1711, 1760);

                f_21010_1711_1759(f_21010_1723_1758(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1778, 1820);

                f_21010_1778_1819(f_21010_1790_1818(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1840, 1871);

                f_21010_1840_1870(f_21010_1853_1869(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1889, 1936);

                f_21010_1889_1935(f_21010_1902_1934(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1954, 1988);

                f_21010_1954_1987(f_21010_1967_1986(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2006, 2044);

                f_21010_2006_2043(f_21010_2019_2042(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2062, 2116);

                f_21010_2062_2115(f_21010_2075_2114(symbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 873, 2131);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 873, 2131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 873, 2131);
            }
        }



        static void
        verifySignature(MethodSymbol symbol)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 2147, 4702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2228, 2251);

                f_21010_2228_2250(symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2271, 2340);

                f_21010_2271_2339(MethodKind.FunctionPointerSignature, f_21010_2321_2338(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2358, 2398);

                f_21010_2358_2397(string.Empty, f_21010_2385_2396(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2416, 2446);

                f_21010_2416_2445(0, f_21010_2432_2444(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2464, 2519);

                f_21010_2464_2518(default, f_21010_2486_2517(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2537, 2609);

                f_21010_2537_2608(Accessibility.NotApplicable, f_21010_2579_2607(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2627, 2712);

                f_21010_2627_2711(FlowAnalysisAnnotations.None, f_21010_2670_2710(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2730, 2805);

                f_21010_2730_2804(FlowAnalysisAnnotations.None, f_21010_2773_2803(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2825, 2864);

                f_21010_2825_2863(f_21010_2838_2862(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2882, 2926);

                f_21010_2882_2925(f_21010_2895_2924(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2944, 2974);

                f_21010_2944_2973(f_21010_2957_2972(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2992, 3021);

                f_21010_2992_3020(f_21010_3005_3019(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3039, 3070);

                f_21010_3039_3069(f_21010_3052_3068(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3088, 3120);

                f_21010_3088_3119(f_21010_3101_3118(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3138, 3170);

                f_21010_3138_3169(f_21010_3151_3168(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3188, 3218);

                f_21010_3188_3217(f_21010_3201_3216(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3236, 3275);

                f_21010_3236_3274(f_21010_3249_3273(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3293, 3323);

                f_21010_3293_3322(f_21010_3306_3321(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3341, 3371);

                f_21010_3341_3370(f_21010_3354_3369(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3389, 3425);

                f_21010_3389_3424(f_21010_3402_3423(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3443, 3487);

                f_21010_3443_3486(f_21010_3456_3485(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3505, 3549);

                f_21010_3505_3548(f_21010_3518_3547(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3567, 3607);

                f_21010_3567_3606(f_21010_3580_3605(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3625, 3670);

                f_21010_3625_3669(f_21010_3638_3668(symbol, true));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3688, 3734);

                f_21010_3688_3733(f_21010_3701_3732(symbol, false));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3752, 3797);

                f_21010_3752_3796(f_21010_3765_3795(symbol, true));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3815, 3861);

                f_21010_3815_3860(f_21010_3828_3859(symbol, false));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3881, 3991);

                f_21010_3881_3990(f_21010_3894_3909(symbol), f_21010_3911_3989(f_21010_3911_3935(symbol), CallingConvention.ExtraArguments));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4011, 4052);

                f_21010_4011_4051(f_21010_4023_4050(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4072, 4109);

                f_21010_4072_4108(f_21010_4084_4107(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4127, 4164);

                f_21010_4127_4163(f_21010_4139_4162(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4182, 4236);

                f_21010_4182_4235(f_21010_4194_4234(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4256, 4292);

                f_21010_4256_4291(f_21010_4269_4290(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4310, 4364);

                f_21010_4310_4363(f_21010_4323_4362(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4382, 4413);

                f_21010_4382_4412(f_21010_4395_4411(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4431, 4478);

                f_21010_4431_4477(f_21010_4444_4476(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4496, 4546);

                f_21010_4496_4545(f_21010_4509_4544(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4564, 4616);

                f_21010_4564_4615(f_21010_4577_4614(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4634, 4687);

                f_21010_4634_4686(f_21010_4647_4685(symbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 2147, 4702);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 2147, 4702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 2147, 4702);
            }
        }



        static void
        verifyParameter(ParameterSymbol symbol, MethodSymbol containing)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 4718, 5961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4827, 4850);

                f_21010_4827_4849(symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4870, 4919);

                f_21010_4870_4918(f_21010_4882_4905(symbol), containing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4939, 4979);

                f_21010_4939_4978(string.Empty, f_21010_4966_4977(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4997, 5072);

                f_21010_4997_5071(FlowAnalysisAnnotations.None, f_21010_5040_5070(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5092, 5123);

                f_21010_5092_5122(f_21010_5105_5121(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5141, 5171);

                f_21010_5141_5170(f_21010_5154_5169(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5189, 5229);

                f_21010_5189_5228(f_21010_5202_5227(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5247, 5288);

                f_21010_5247_5287(f_21010_5260_5286(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5306, 5346);

                f_21010_5306_5345(f_21010_5319_5344(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5364, 5402);

                f_21010_5364_5401(f_21010_5377_5400(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5420, 5460);

                f_21010_5420_5459(f_21010_5433_5458(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5478, 5516);

                f_21010_5478_5515(f_21010_5491_5514(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5534, 5574);

                f_21010_5534_5573(f_21010_5547_5572(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5594, 5635);

                f_21010_5594_5634(f_21010_5606_5633(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5655, 5698);

                f_21010_5655_5697(f_21010_5667_5696(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5716, 5765);

                f_21010_5716_5764(f_21010_5728_5763(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5785, 5816);

                f_21010_5785_5815(f_21010_5798_5814(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5834, 5881);

                f_21010_5834_5880(f_21010_5847_5879(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5899, 5946);

                f_21010_5899_5945(f_21010_5912_5944(symbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 4718, 5961);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 4718, 5961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 4718, 5961);
            }
        }



        static void
        verifySymbolInfo(
                        string? expectedSymbol,
                        CandidateReason expectedReason,
                        string[]? expectedSymbolCandidates,
                        CompilationUtils.SemanticInfoSummary semanticInfo)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 9518, 10807);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 9791, 10792) || true) && (expectedSymbol is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 9791, 10792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 9861, 9905);

                    f_21010_9861_9904(semanticInfo.CandidateSymbols);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 9927, 10026);

                    f_21010_9927_10025(expectedSymbol, f_21010_9958_10024(semanticInfo.Symbol, includeNonNullable: false));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 10048, 10113);

                    f_21010_10048_10112(CandidateReason.None, semanticInfo.CandidateReason);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 9791, 10792);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 9791, 10792);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 10155, 10792) || true) && (expectedSymbolCandidates is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 10155, 10792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 10235, 10268);

                        f_21010_10235_10267(semanticInfo.Symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 10290, 10349);

                        f_21010_10290_10348(expectedReason, semanticInfo.CandidateReason);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 10371, 10505);

                        f_21010_10371_10504(expectedSymbolCandidates, semanticInfo.CandidateSymbols.Select(s => s.ToTestDisplayString(includeNonNullable: false)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 10155, 10792);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 10155, 10792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 10587, 10620);

                        f_21010_10587_10619(semanticInfo.Symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 10642, 10686);

                        f_21010_10642_10685(semanticInfo.CandidateSymbols);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 10708, 10773);

                        f_21010_10708_10772(CandidateReason.None, semanticInfo.CandidateReason);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 10155, 10792);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 9791, 10792);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 9518, 10807);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 9518, 10807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 9518, 10807);
            }
        }



        static void
        verifyNestedFunctionPointerSyntaxSemanticInfo(SemanticModel model, IFunctionPointerTypeSymbol ptrType, SeparatedSyntaxList<FunctionPointerParameterSyntax> paramSyntaxes)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 10823, 11748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 11201, 11235);

                var
                signature = f_21010_11217_11234(ptrType)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 11262, 11267);
                    for (int
    i = 0
    ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 11253, 11580) || true) && (i < paramSyntaxes.Count - 1)
    ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 11298, 11301)
    , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 11253, 11580))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 11253, 11580);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 11343, 11384);

                        var
                        paramSyntax = paramSyntaxes[i].Type!
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 11406, 11468);

                        ITypeSymbol
                        signatureParamType = f_21010_11439_11467(f_21010_11439_11459(signature)[i])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 11490, 11561);

                        f_21010_11490_11560(model, paramSyntax, signatureParamType);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21010, 1, 328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21010, 1, 328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 11600, 11641);

                var
                returnParam = paramSyntaxes[^1].Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 11659, 11733);

                f_21010_11659_11732(model, returnParam!, f_21010_11711_11731(signature));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 10823, 11748);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 10823, 11748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 10823, 11748);
            }
        }



        static void
        assertEqualSemanticInformation(SemanticModel model, TypeSyntax typeSyntax, ITypeSymbol signatureType)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 11764, 12879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 11910, 11970);

                var
                semanticInfo = f_21010_11929_11969(model, typeSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 11988, 12076);

                f_21010_11988_12075(signatureType, semanticInfo.Type, SymbolEqualityComparer.Default);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 12094, 12197);

                f_21010_12094_12196(semanticInfo.Type, semanticInfo.ConvertedType, SymbolEqualityComparer.IncludeNullability);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 12217, 12282);

                f_21010_12217_12281(CandidateReason.None, semanticInfo.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 12300, 12379);

                f_21010_12300_12378(signatureType, semanticInfo.Type, SymbolEqualityComparer.Default);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 12397, 12441);

                f_21010_12397_12440(semanticInfo.CandidateSymbols);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 12461, 12864) || true) && (typeSyntax is FunctionPointerTypeSyntax { ParameterList: { Parameters: var paramSyntaxes } })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 12461, 12864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 12599, 12665);

                    var
                    paramPtrType = (IFunctionPointerTypeSymbol)semanticInfo.Type!
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 12687, 12741);

                    f_21010_12687_12740(f_21010_12715_12739(paramPtrType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 12763, 12845);

                    f_21010_12763_12844(model, paramPtrType, paramSyntaxes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 12461, 12864);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 11764, 12879);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 11764, 12879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 11764, 12879);
            }
        }



        static Microsoft.CodeAnalysis.SymbolKind
        f_21010_1014_1025(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1014, 1025);
            return return_v;
        }


        static int
        f_21010_969_1026(Microsoft.CodeAnalysis.SymbolKind
        expected, Microsoft.CodeAnalysis.SymbolKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 969, 1026);
            return 0;
        }


        static Microsoft.CodeAnalysis.TypeKind
        f_21010_1084_1099(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.TypeKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1084, 1099);
            return return_v;
        }


        static int
        f_21010_1045_1100(Microsoft.CodeAnalysis.TypeKind
        expected, Microsoft.CodeAnalysis.TypeKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1045, 1100);
            return 0;
        }


        static bool
        f_21010_1134_1156(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsReferenceType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1134, 1156);
            return return_v;
        }


        static int
        f_21010_1121_1157(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1121, 1157);
            return 0;
        }


        static bool
        f_21010_1189_1209(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsRefLikeType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1189, 1209);
            return return_v;
        }


        static int
        f_21010_1176_1210(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1176, 1210);
            return 0;
        }


        static bool
        f_21010_1242_1259(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsReadOnly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1242, 1259);
            return return_v;
        }


        static int
        f_21010_1229_1260(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1229, 1260);
            return 0;
        }


        static bool
        f_21010_1292_1307(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1292, 1307);
            return return_v;
        }


        static int
        f_21010_1279_1308(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1279, 1308);
            return 0;
        }


        static bool
        f_21010_1340_1357(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsAbstract;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1340, 1357);
            return return_v;
        }


        static int
        f_21010_1327_1358(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1327, 1358);
            return 0;
        }


        static bool
        f_21010_1390_1405(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsSealed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1390, 1405);
            return return_v;
        }


        static int
        f_21010_1377_1406(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1377, 1406);
            return 0;
        }


        static bool
        f_21010_1438_1466(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.CanBeReferencedByName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1438, 1466);
            return return_v;
        }


        static int
        f_21010_1425_1467(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1425, 1467);
            return 0;
        }


        static bool
        f_21010_1498_1524(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        symbol)
        {
            var return_v = symbol.IsTypeOrTypeAlias();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1498, 1524);
            return return_v;
        }


        static int
        f_21010_1486_1525(bool
        condition)
        {
            Assert.True(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1486, 1525);
            return 0;
        }


        static bool
        f_21010_1558_1576(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsValueType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1558, 1576);
            return return_v;
        }


        static int
        f_21010_1546_1577(bool
        condition)
        {
            Assert.True(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1546, 1577);
            return 0;
        }


        static bool
        f_21010_1608_1634(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        type)
        {
            var return_v = type.CanBeAssignedNull();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1608, 1634);
            return return_v;
        }


        static int
        f_21010_1596_1635(bool
        condition)
        {
            Assert.True(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1596, 1635);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol?
        f_21010_1668_1691(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1668, 1691);
            return return_v;
        }


        static int
        f_21010_1656_1692(Microsoft.CodeAnalysis.CSharp.Symbol?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1656, 1692);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        f_21010_1723_1758(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1723, 1758);
            return return_v;
        }


        static int
        f_21010_1711_1759(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1711, 1759);
            return 0;
        }


        static Microsoft.CodeAnalysis.ObsoleteAttributeData?
        f_21010_1790_1818(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.ObsoleteAttributeData;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1790, 1818);
            return return_v;
        }


        static int
        f_21010_1778_1819(Microsoft.CodeAnalysis.ObsoleteAttributeData?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1778, 1819);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_21010_1853_1869(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1853, 1869);
            return return_v;
        }


        static int
        f_21010_1840_1870(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1840, 1870);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        f_21010_1902_1934(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.DeclaringSyntaxReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 1902, 1934);
            return return_v;
        }


        static int
        f_21010_1889_1935(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1889, 1935);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21010_1967_1986(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.GetMembers();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1967, 1986);
            return return_v;
        }


        static int
        f_21010_1954_1987(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1954, 1987);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        f_21010_2019_2042(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.GetTypeMembers();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2019, 2042);
            return return_v;
        }


        static int
        f_21010_2006_2043(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2006, 2043);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        f_21010_2075_2114(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.InterfacesNoUseSiteDiagnostics();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2075, 2114);
            return return_v;
        }


        static int
        f_21010_2062_2115(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2062, 2115);
            return 0;
        }


        static int
        f_21010_2228_2250(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        @object)
        {
            Assert.NotNull((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2228, 2250);
            return 0;
        }


        static Microsoft.CodeAnalysis.MethodKind
        f_21010_2321_2338(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.MethodKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 2321, 2338);
            return return_v;
        }


        static int
        f_21010_2271_2339(Microsoft.CodeAnalysis.MethodKind
        expected, Microsoft.CodeAnalysis.MethodKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2271, 2339);
            return 0;
        }


        static string
        f_21010_2385_2396(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 2385, 2396);
            return return_v;
        }


        static int
        f_21010_2358_2397(string
        expected, string
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2358, 2397);
            return 0;
        }


        static int
        f_21010_2432_2444(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Arity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 2432, 2444);
            return return_v;
        }


        static int
        f_21010_2416_2445(int
        expected, int
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2416, 2445);
            return 0;
        }


        static System.Reflection.MethodImplAttributes
        f_21010_2486_2517(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ImplementationAttributes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 2486, 2517);
            return return_v;
        }


        static int
        f_21010_2464_2518(System.Reflection.MethodImplAttributes
        expected, System.Reflection.MethodImplAttributes
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2464, 2518);
            return 0;
        }


        static Microsoft.CodeAnalysis.Accessibility
        f_21010_2579_2607(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.DeclaredAccessibility;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 2579, 2607);
            return return_v;
        }


        static int
        f_21010_2537_2608(Microsoft.CodeAnalysis.Accessibility
        expected, Microsoft.CodeAnalysis.Accessibility
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2537, 2608);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        f_21010_2670_2710(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnTypeFlowAnalysisAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 2670, 2710);
            return return_v;
        }


        static int
        f_21010_2627_2711(Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        expected, Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2627, 2711);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        f_21010_2773_2803(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.FlowAnalysisAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 2773, 2803);
            return return_v;
        }


        static int
        f_21010_2730_2804(Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        expected, Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2730, 2804);
            return 0;
        }


        static bool
        f_21010_2838_2862(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsExtensionMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 2838, 2862);
            return return_v;
        }


        static int
        f_21010_2825_2863(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2825, 2863);
            return 0;
        }


        static bool
        f_21010_2895_2924(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.HidesBaseMethodsByName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 2895, 2924);
            return return_v;
        }


        static int
        f_21010_2882_2925(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2882, 2925);
            return 0;
        }


        static bool
        f_21010_2957_2972(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 2957, 2972);
            return return_v;
        }


        static int
        f_21010_2944_2973(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2944, 2973);
            return 0;
        }


        static bool
        f_21010_3005_3019(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsAsync;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3005, 3019);
            return return_v;
        }


        static int
        f_21010_2992_3020(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2992, 3020);
            return 0;
        }


        static bool
        f_21010_3052_3068(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsVirtual;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3052, 3068);
            return return_v;
        }


        static int
        f_21010_3039_3069(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3039, 3069);
            return 0;
        }


        static bool
        f_21010_3101_3118(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsOverride;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3101, 3118);
            return return_v;
        }


        static int
        f_21010_3088_3119(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3088, 3119);
            return 0;
        }


        static bool
        f_21010_3151_3168(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsAbstract;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3151, 3168);
            return return_v;
        }


        static int
        f_21010_3138_3169(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3138, 3169);
            return 0;
        }


        static bool
        f_21010_3201_3216(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsExtern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3201, 3216);
            return return_v;
        }


        static int
        f_21010_3188_3217(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3188, 3217);
            return 0;
        }


        static bool
        f_21010_3249_3273(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsExtensionMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3249, 3273);
            return return_v;
        }


        static int
        f_21010_3236_3274(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3236, 3274);
            return 0;
        }


        static bool
        f_21010_3306_3321(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsSealed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3306, 3321);
            return return_v;
        }


        static int
        f_21010_3293_3322(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3293, 3322);
            return 0;
        }


        static bool
        f_21010_3354_3369(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsExtern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3354, 3369);
            return return_v;
        }


        static int
        f_21010_3341_3370(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3341, 3370);
            return 0;
        }


        static bool
        f_21010_3402_3423(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.HasSpecialName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3402, 3423);
            return return_v;
        }


        static int
        f_21010_3389_3424(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3389, 3424);
            return 0;
        }


        static bool
        f_21010_3456_3485(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.HasDeclarativeSecurity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3456, 3485);
            return return_v;
        }


        static int
        f_21010_3443_3486(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3443, 3486);
            return 0;
        }


        static bool
        f_21010_3518_3547(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.RequiresSecurityObject;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3518, 3547);
            return return_v;
        }


        static int
        f_21010_3505_3548(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3505, 3548);
            return 0;
        }


        static bool
        f_21010_3580_3605(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsDeclaredReadOnly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3580, 3605);
            return return_v;
        }


        static int
        f_21010_3567_3606(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3567, 3606);
            return 0;
        }


        static bool
        f_21010_3638_3668(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param, bool
        ignoreInterfaceImplementationChanges)
        {
            var return_v = this_param.IsMetadataNewSlot(ignoreInterfaceImplementationChanges);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3638, 3668);
            return return_v;
        }


        static int
        f_21010_3625_3669(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3625, 3669);
            return 0;
        }


        static bool
        f_21010_3701_3732(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param, bool
        ignoreInterfaceImplementationChanges)
        {
            var return_v = this_param.IsMetadataNewSlot(ignoreInterfaceImplementationChanges);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3701, 3732);
            return return_v;
        }


        static int
        f_21010_3688_3733(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3688, 3733);
            return 0;
        }


        static bool
        f_21010_3765_3795(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param, bool
        ignoreInterfaceImplementationChanges)
        {
            var return_v = this_param.IsMetadataVirtual(ignoreInterfaceImplementationChanges);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3765, 3795);
            return return_v;
        }


        static int
        f_21010_3752_3796(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3752, 3796);
            return 0;
        }


        static bool
        f_21010_3828_3859(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param, bool
        ignoreInterfaceImplementationChanges)
        {
            var return_v = this_param.IsMetadataVirtual(ignoreInterfaceImplementationChanges);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3828, 3859);
            return return_v;
        }


        static int
        f_21010_3815_3860(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3815, 3860);
            return 0;
        }


        static bool
        f_21010_3894_3909(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsVararg;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3894, 3909);
            return return_v;
        }


        static Microsoft.Cci.CallingConvention
        f_21010_3911_3935(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.CallingConvention;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 3911, 3935);
            return return_v;
        }


        static bool
        f_21010_3911_3989(Microsoft.Cci.CallingConvention
        original, Microsoft.Cci.CallingConvention
        compare)
        {
            var return_v = original.IsCallingConvention(compare);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3911, 3989);
            return return_v;
        }


        static int
        f_21010_3881_3990(bool
        expected, bool
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3881, 3990);
            return 0;
        }


        static bool
        f_21010_4023_4050(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsImplicitlyDeclared;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4023, 4050);
            return return_v;
        }


        static int
        f_21010_4011_4051(bool
        condition)
        {
            Assert.True(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4011, 4051);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21010_4084_4107(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4084, 4107);
            return return_v;
        }


        static int
        f_21010_4072_4108(Microsoft.CodeAnalysis.CSharp.Symbol
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4072, 4108);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21010_4139_4162(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.AssociatedSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4139, 4162);
            return return_v;
        }


        static int
        f_21010_4127_4163(Microsoft.CodeAnalysis.CSharp.Symbol
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4127, 4163);
            return 0;
        }


        static Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
        f_21010_4194_4234(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnValueMarshallingInformation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4194, 4234);
            return return_v;
        }


        static int
        f_21010_4182_4235(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4182, 4235);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_21010_4269_4290(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4269, 4290);
            return return_v;
        }


        static int
        f_21010_4256_4291(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4256, 4291);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_21010_4323_4362(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ExplicitInterfaceImplementations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4323, 4362);
            return return_v;
        }


        static int
        f_21010_4310_4363(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4310, 4363);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_21010_4395_4411(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4395, 4411);
            return return_v;
        }


        static int
        f_21010_4382_4412(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4382, 4412);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        f_21010_4444_4476(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.DeclaringSyntaxReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4444, 4476);
            return return_v;
        }


        static int
        f_21010_4431_4477(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4431, 4477);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_21010_4509_4544(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.TypeArgumentsWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4509, 4544);
            return return_v;
        }


        static int
        f_21010_4496_4545(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4496, 4545);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_21010_4577_4614(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.GetAppliedConditionalSymbols();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4577, 4614);
            return return_v;
        }


        static int
        f_21010_4564_4615(System.Collections.Immutable.ImmutableArray<string>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4564, 4615);
            return 0;
        }


        static System.Collections.Immutable.ImmutableHashSet<string>
        f_21010_4647_4685(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnNotNullIfParameterNotNull;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4647, 4685);
            return return_v;
        }


        static int
        f_21010_4634_4686(System.Collections.Immutable.ImmutableHashSet<string>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4634, 4686);
            return 0;
        }


        static int
        f_21010_4827_4849(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        @object)
        {
            Assert.NotNull((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4827, 4849);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21010_4882_4905(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4882, 4905);
            return return_v;
        }


        static int
        f_21010_4870_4918(Microsoft.CodeAnalysis.CSharp.Symbol
        expected, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        actual)
        {
            Assert.Same((object)expected, (object)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4870, 4918);
            return 0;
        }


        static string
        f_21010_4966_4977(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 4966, 4977);
            return return_v;
        }


        static int
        f_21010_4939_4978(string
        expected, string
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4939, 4978);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        f_21010_5040_5070(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.FlowAnalysisAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5040, 5070);
            return return_v;
        }


        static int
        f_21010_4997_5071(Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        expected, Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4997, 5071);
            return 0;
        }


        static bool
        f_21010_5105_5121(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsDiscard;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5105, 5121);
            return return_v;
        }


        static int
        f_21010_5092_5122(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5092, 5122);
            return 0;
        }


        static bool
        f_21010_5154_5169(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsParams;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5154, 5169);
            return return_v;
        }


        static int
        f_21010_5141_5170(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5141, 5170);
            return 0;
        }


        static bool
        f_21010_5202_5227(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsMetadataOptional;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5202, 5227);
            return return_v;
        }


        static int
        f_21010_5189_5228(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5189, 5228);
            return 0;
        }


        static bool
        f_21010_5260_5286(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsIDispatchConstant;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5260, 5286);
            return return_v;
        }


        static int
        f_21010_5247_5287(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5247, 5287);
            return 0;
        }


        static bool
        f_21010_5319_5344(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsIUnknownConstant;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5319, 5344);
            return return_v;
        }


        static int
        f_21010_5306_5345(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5306, 5345);
            return 0;
        }


        static bool
        f_21010_5377_5400(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsCallerFilePath;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5377, 5400);
            return return_v;
        }


        static int
        f_21010_5364_5401(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5364, 5401);
            return 0;
        }


        static bool
        f_21010_5433_5458(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsCallerLineNumber;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5433, 5458);
            return return_v;
        }


        static int
        f_21010_5420_5459(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5420, 5459);
            return 0;
        }


        static bool
        f_21010_5491_5514(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsCallerFilePath;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5491, 5514);
            return return_v;
        }


        static int
        f_21010_5478_5515(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5478, 5515);
            return 0;
        }


        static bool
        f_21010_5547_5572(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsCallerMemberName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5547, 5572);
            return return_v;
        }


        static int
        f_21010_5534_5573(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5534, 5573);
            return 0;
        }


        static bool
        f_21010_5606_5633(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsImplicitlyDeclared;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5606, 5633);
            return return_v;
        }


        static int
        f_21010_5594_5634(bool
        condition)
        {
            Assert.True(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5594, 5634);
            return 0;
        }


        static Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
        f_21010_5667_5696(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.MarshallingInformation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5667, 5696);
            return return_v;
        }


        static int
        f_21010_5655_5697(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5655, 5697);
            return 0;
        }


        static Microsoft.CodeAnalysis.ConstantValue?
        f_21010_5728_5763(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.ExplicitDefaultConstantValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5728, 5763);
            return return_v;
        }


        static int
        f_21010_5716_5764(Microsoft.CodeAnalysis.ConstantValue?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5716, 5764);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_21010_5798_5814(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5798, 5814);
            return return_v;
        }


        static int
        f_21010_5785_5815(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5785, 5815);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        f_21010_5847_5879(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.DeclaringSyntaxReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5847, 5879);
            return return_v;
        }


        static int
        f_21010_5834_5880(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5834, 5880);
            return 0;
        }


        static System.Collections.Immutable.ImmutableHashSet<string>
        f_21010_5912_5944(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.NotNullIfParameterNotNull;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 5912, 5944);
            return return_v;
        }


        static int
        f_21010_5899_5945(System.Collections.Immutable.ImmutableHashSet<string>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5899, 5945);
            return 0;
        }


        static int
        f_21010_9861_9904(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 9861, 9904);
            return 0;
        }


        static string
        f_21010_9958_10024(Microsoft.CodeAnalysis.ISymbol
        symbol, bool
        includeNonNullable)
        {
            var return_v = symbol.ToTestDisplayString(includeNonNullable: includeNonNullable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 9958, 10024);
            return return_v;
        }


        static int
        f_21010_9927_10025(string
        expected, string
        actual)
        {
            AssertEx.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 9927, 10025);
            return 0;
        }


        static int
        f_21010_10048_10112(Microsoft.CodeAnalysis.CandidateReason
        expected, Microsoft.CodeAnalysis.CandidateReason
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 10048, 10112);
            return 0;
        }


        static int
        f_21010_10235_10267(Microsoft.CodeAnalysis.ISymbol
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 10235, 10267);
            return 0;
        }


        static int
        f_21010_10290_10348(Microsoft.CodeAnalysis.CandidateReason
        expected, Microsoft.CodeAnalysis.CandidateReason
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 10290, 10348);
            return 0;
        }


        static int
        f_21010_10371_10504(string[]
        expected, System.Collections.Generic.IEnumerable<string>
        actual)
        {
            AssertEx.Equal((System.Collections.Generic.IEnumerable<string>)expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 10371, 10504);
            return 0;
        }


        static int
        f_21010_10587_10619(Microsoft.CodeAnalysis.ISymbol
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 10587, 10619);
            return 0;
        }


        static int
        f_21010_10642_10685(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 10642, 10685);
            return 0;
        }


        static int
        f_21010_10708_10772(Microsoft.CodeAnalysis.CandidateReason
        expected, Microsoft.CodeAnalysis.CandidateReason
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 10708, 10772);
            return 0;
        }


        static Microsoft.CodeAnalysis.IMethodSymbol
        f_21010_11217_11234(Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 11217, 11234);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
        f_21010_11439_11459(Microsoft.CodeAnalysis.IMethodSymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 11439, 11459);
            return return_v;
        }


        static Microsoft.CodeAnalysis.ITypeSymbol
        f_21010_11439_11467(Microsoft.CodeAnalysis.IParameterSymbol
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 11439, 11467);
            return return_v;
        }


        static int
        f_21010_11490_11560(Microsoft.CodeAnalysis.SemanticModel
        model, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        typeSyntax, Microsoft.CodeAnalysis.ITypeSymbol
        signatureType)
        {
            assertEqualSemanticInformation(model, typeSyntax, signatureType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 11490, 11560);
            return 0;
        }


        static Microsoft.CodeAnalysis.ITypeSymbol
        f_21010_11711_11731(Microsoft.CodeAnalysis.IMethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 11711, 11731);
            return return_v;
        }


        static int
        f_21010_11659_11732(Microsoft.CodeAnalysis.SemanticModel
        model, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        typeSyntax, Microsoft.CodeAnalysis.ITypeSymbol
        signatureType)
        {
            assertEqualSemanticInformation(model, typeSyntax, signatureType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 11659, 11732);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary
        f_21010_11929_11969(Microsoft.CodeAnalysis.SemanticModel
        semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        node)
        {
            var return_v = semanticModel.GetSemanticInfoSummary((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 11929, 11969);
            return return_v;
        }


        static int
        f_21010_11988_12075(Microsoft.CodeAnalysis.ITypeSymbol
        expected, Microsoft.CodeAnalysis.ITypeSymbol
        actual, Microsoft.CodeAnalysis.SymbolEqualityComparer
        comparer)
        {
            Assert.Equal<ISymbol>((Microsoft.CodeAnalysis.ISymbol)expected, (Microsoft.CodeAnalysis.ISymbol)actual, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.ISymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 11988, 12075);
            return 0;
        }


        static int
        f_21010_12094_12196(Microsoft.CodeAnalysis.ITypeSymbol
        expected, Microsoft.CodeAnalysis.ITypeSymbol
        actual, Microsoft.CodeAnalysis.SymbolEqualityComparer
        comparer)
        {
            Assert.Equal((Microsoft.CodeAnalysis.ISymbol)expected, (Microsoft.CodeAnalysis.ISymbol)actual, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.ISymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 12094, 12196);
            return 0;
        }


        static int
        f_21010_12217_12281(Microsoft.CodeAnalysis.CandidateReason
        expected, Microsoft.CodeAnalysis.CandidateReason
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 12217, 12281);
            return 0;
        }


        static int
        f_21010_12300_12378(Microsoft.CodeAnalysis.ITypeSymbol
        expected, Microsoft.CodeAnalysis.ITypeSymbol
        actual, Microsoft.CodeAnalysis.SymbolEqualityComparer
        comparer)
        {
            Assert.Equal((Microsoft.CodeAnalysis.ISymbol)expected, (Microsoft.CodeAnalysis.ISymbol)actual, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.ISymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 12300, 12378);
            return 0;
        }


        static int
        f_21010_12397_12440(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
        collection)
        {
            Assert.Empty((System.Collections.IEnumerable)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 12397, 12440);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol?
        f_21010_12715_12739(Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol
        symbol)
        {
            var return_v = symbol.GetSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 12715, 12739);
            return return_v;
        }


        static int
        f_21010_12687_12740(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        symbol)
        {
            CommonVerifyFunctionPointer(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 12687, 12740);
            return 0;
        }


        static int
        f_21010_12763_12844(Microsoft.CodeAnalysis.SemanticModel
        model, Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol
        ptrType, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax>
        paramSyntaxes)
        {
            verifyNestedFunctionPointerSyntaxSemanticInfo(model, ptrType, paramSyntaxes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 12763, 12844);
            return 0;
        }

    }
}
