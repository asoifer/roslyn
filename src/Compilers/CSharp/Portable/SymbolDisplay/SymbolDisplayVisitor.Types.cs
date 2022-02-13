// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.SymbolDisplay;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class SymbolDisplayVisitor
    {
        public override void VisitArrayType(IArrayTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 605, 787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 690, 731);

                f_10957_690_730(this, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 745, 776);

                f_10957_745_775(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 605, 787);

                int
                f_10957_690_730(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IArrayTypeSymbol
                symbol)
                {
                    this_param.VisitArrayTypeWithoutNullability(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 690, 730);
                    return 0;
                }


                int
                f_10957_745_775(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IArrayTypeSymbol
                type)
                {
                    this_param.AddNullableAnnotations((Microsoft.CodeAnalysis.ITypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 745, 775);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 605, 787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 605, 787);
            }
        }

        private void VisitArrayTypeWithoutNullability(IArrayTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 799, 2605);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 894, 982) || true) && (f_10957_898_926(this, symbol, builder))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 894, 982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 960, 967);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 894, 982);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 1407, 1800) || true) && (f_10957_1411_1521(f_10957_1411_1441(format), SymbolDisplayCompilerInternalOptions.ReverseArrayRankSpecifiers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 1407, 1800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 1689, 1721);

                    f_10957_1689_1720(f_10957_1689_1707(symbol), this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 1739, 1760);

                    f_10957_1739_1759(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 1778, 1785);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 1407, 1800);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 1816, 1852);

                ITypeSymbol
                underlyingType = symbol
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 1866, 2094);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 1901, 1965);

                            underlyingType = f_10957_1918_1964(((IArrayTypeSymbol)underlyingType));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 1866, 2094);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 1866, 2094) || true) && (f_10957_2001_2020(underlyingType) == SymbolKind.ArrayType && (DynAbs.Tracing.TraceSender.Expression_True(10957, 2001, 2092) && !f_10957_2049_2092(this, underlyingType)))
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10957, 1866, 2094);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10957, 1866, 2094);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 2110, 2154);

                f_10957_2110_2153(
                            underlyingType, f_10957_2132_2152(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 2170, 2193);

                var
                arrayType = symbol
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 2207, 2594) || true) && (arrayType != null && (DynAbs.Tracing.TraceSender.Expression_True(10957, 2214, 2262) && arrayType != underlyingType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 2207, 2594);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 2296, 2463) || true) && (!this.isFirstSymbolVisited)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 2296, 2463);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 2368, 2444);

                            f_10957_2368_2443(this, f_10957_2397_2422(arrayType), leadingSpace: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 2296, 2463);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 2483, 2507);

                        f_10957_2483_2506(this, arrayType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 2525, 2579);

                        arrayType = f_10957_2537_2558(arrayType) as IArrayTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 2207, 2594);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10957, 2207, 2594);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10957, 2207, 2594);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 799, 2605);

                bool
                f_10957_898_926(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IArrayTypeSymbol
                symbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                builder)
                {
                    var return_v = this_param.TryAddAlias((Microsoft.CodeAnalysis.INamespaceOrTypeSymbol)symbol, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 898, 926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_10957_1411_1441(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 1411, 1441);
                    return return_v;
                }


                bool
                f_10957_1411_1521(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 1411, 1521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10957_1689_1707(Microsoft.CodeAnalysis.IArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 1689, 1707);
                    return return_v;
                }


                int
                f_10957_1689_1720(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 1689, 1720);
                    return 0;
                }


                int
                f_10957_1739_1759(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IArrayTypeSymbol
                symbol)
                {
                    this_param.AddArrayRank(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 1739, 1759);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10957_1918_1964(Microsoft.CodeAnalysis.IArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 1918, 1964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10957_2001_2020(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 2001, 2020);
                    return return_v;
                }


                bool
                f_10957_2049_2092(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                type)
                {
                    var return_v = this_param.ShouldAddNullableAnnotation(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 2049, 2092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10957_2132_2152(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 2132, 2152);
                    return return_v;
                }


                int
                f_10957_2110_2153(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 2110, 2153);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10957_2397_2422(Microsoft.CodeAnalysis.IArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 2397, 2422);
                    return return_v;
                }


                int
                f_10957_2368_2443(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, bool
                leadingSpace)
                {
                    this_param.AddCustomModifiersIfRequired(customModifiers, leadingSpace: leadingSpace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 2368, 2443);
                    return 0;
                }


                int
                f_10957_2483_2506(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IArrayTypeSymbol
                symbol)
                {
                    this_param.AddArrayRank(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 2483, 2506);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10957_2537_2558(Microsoft.CodeAnalysis.IArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 2537, 2558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 799, 2605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 799, 2605);
            }
        }

        private void AddNullableAnnotations(ITypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 2617, 2934);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 2695, 2923) || true) && (f_10957_2699_2732(this, type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 2695, 2923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 2766, 2908);

                    f_10957_2766_2907(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10957, 2781, 2849) || ((f_10957_2781_2804(type) == CodeAnalysis.NullableAnnotation.Annotated && DynAbs.Tracing.TraceSender.Conditional_F2(10957, 2852, 2876)) || DynAbs.Tracing.TraceSender.Conditional_F3(10957, 2879, 2906))) ? SyntaxKind.QuestionToken : SyntaxKind.ExclamationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 2695, 2923);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 2617, 2934);

                bool
                f_10957_2699_2732(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                type)
                {
                    var return_v = this_param.ShouldAddNullableAnnotation(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 2699, 2732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10957_2781_2804(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 2781, 2804);
                    return return_v;
                }


                int
                f_10957_2766_2907(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 2766, 2907);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 2617, 2934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 2617, 2934);
            }
        }

        private bool ShouldAddNullableAnnotation(ITypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 2946, 4157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 3029, 4117);

                switch (f_10957_3037_3060(type))
                {

                    case CodeAnalysis.NullableAnnotation.Annotated:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 3029, 4117);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 3163, 3456) || true) && (f_10957_3167_3281(f_10957_3167_3194(format), SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 3167, 3350) && !f_10957_3311_3350(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 3167, 3371) && f_10957_3354_3371_M(!type.IsValueType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 3163, 3456);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 3421, 3433);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 3163, 3456);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10957, 3478, 3484);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 3029, 4117);

                    case CodeAnalysis.NullableAnnotation.NotAnnotated:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 3029, 4117);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 3603, 4074) || true) && (f_10957_3607_3724(f_10957_3607_3634(format), SymbolDisplayMiscellaneousOptions.IncludeNotNullableReferenceTypeModifier) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 3607, 3770) && f_10957_3753_3770_M(!type.IsValueType)) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 3607, 3989) && ((type is not Symbols.PublicModel.TypeSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10957, 3800, 3988) || f_10957_3873_3980(f_10957_3873_3932(((Symbols.PublicModel.TypeSymbol)type))) != true))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 3603, 4074);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4039, 4051);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 3603, 4074);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10957, 4096, 4102);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 3029, 4117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4133, 4146);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 2946, 4157);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10957_3037_3060(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 3037, 3060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10957_3167_3194(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 3167, 3194);
                    return return_v;
                }


                bool
                f_10957_3167_3281(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 3167, 3281);
                    return return_v;
                }


                bool
                f_10957_3311_3350(Microsoft.CodeAnalysis.ITypeSymbol
                typeOpt)
                {
                    var return_v = ITypeSymbolHelpers.IsNullableType(typeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 3311, 3350);
                    return return_v;
                }


                bool
                f_10957_3354_3371_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 3354, 3371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10957_3607_3634(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 3607, 3634);
                    return return_v;
                }


                bool
                f_10957_3607_3724(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 3607, 3724);
                    return return_v;
                }


                bool
                f_10957_3753_3770_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 3753, 3770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10957_3873_3932(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeSymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 3873, 3932);
                    return return_v;
                }


                bool
                f_10957_3873_3980(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameterDisallowingAnnotationInCSharp8();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 3873, 3980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 2946, 4157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 2946, 4157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddArrayRank(IArrayTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 4169, 5293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4244, 4378);

                bool
                insertStars = f_10957_4263_4377(f_10957_4263_4290(format), SymbolDisplayMiscellaneousOptions.UseAsterisksInMultiDimensionalArrays)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4394, 4438);

                f_10957_4394_4437(this, SyntaxKind.OpenBracketToken);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4454, 4941) || true) && (f_10957_4458_4469(symbol) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 4454, 4941);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4507, 4624) || true) && (insertStars)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 4507, 4624);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4564, 4605);

                        f_10957_4564_4604(this, SyntaxKind.AsteriskToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 4507, 4624);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 4454, 4941);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 4454, 4941);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4690, 4926) || true) && (f_10957_4694_4711_M(!symbol.IsSZArray))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 4690, 4926);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4866, 4907);

                        f_10957_4866_4906(this, SyntaxKind.AsteriskToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 4690, 4926);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 4454, 4941);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4966, 4971);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4957, 5221) || true) && (i < f_10957_4977_4988(symbol) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 4994, 4997)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 4957, 5221))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 4957, 5221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 5031, 5069);

                        f_10957_5031_5068(this, SyntaxKind.CommaToken);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 5089, 5206) || true) && (insertStars)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 5089, 5206);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 5146, 5187);

                            f_10957_5146_5186(this, SyntaxKind.AsteriskToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 5089, 5206);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10957, 1, 265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10957, 1, 265);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 5237, 5282);

                f_10957_5237_5281(this, SyntaxKind.CloseBracketToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 4169, 5293);

                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10957_4263_4290(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 4263, 4290);
                    return return_v;
                }


                bool
                f_10957_4263_4377(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 4263, 4377);
                    return return_v;
                }


                int
                f_10957_4394_4437(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 4394, 4437);
                    return 0;
                }


                int
                f_10957_4458_4469(Microsoft.CodeAnalysis.IArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 4458, 4469);
                    return return_v;
                }


                int
                f_10957_4564_4604(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 4564, 4604);
                    return 0;
                }


                bool
                f_10957_4694_4711_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 4694, 4711);
                    return return_v;
                }


                int
                f_10957_4866_4906(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 4866, 4906);
                    return 0;
                }


                int
                f_10957_4977_4988(Microsoft.CodeAnalysis.IArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 4977, 4988);
                    return return_v;
                }


                int
                f_10957_5031_5068(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 5031, 5068);
                    return 0;
                }


                int
                f_10957_5146_5186(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 5146, 5186);
                    return 0;
                }


                int
                f_10957_5237_5281(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 5237, 5281);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 4169, 5293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 4169, 5293);
            }
        }

        public override void VisitPointerType(IPointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 5305, 5725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 5394, 5444);

                f_10957_5394_5443(f_10957_5394_5414(symbol), f_10957_5422_5442(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 5460, 5491);

                f_10957_5460_5490(this, symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 5507, 5659) || true) && (!this.isFirstSymbolVisited)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 5507, 5659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 5571, 5644);

                    f_10957_5571_5643(this, f_10957_5600_5622(symbol), leadingSpace: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 5507, 5659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 5673, 5714);

                f_10957_5673_5713(this, SyntaxKind.AsteriskToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 5305, 5725);

                Microsoft.CodeAnalysis.ITypeSymbol
                f_10957_5394_5414(Microsoft.CodeAnalysis.IPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 5394, 5414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10957_5422_5442(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 5422, 5442);
                    return return_v;
                }


                int
                f_10957_5394_5443(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 5394, 5443);
                    return 0;
                }


                int
                f_10957_5460_5490(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IPointerTypeSymbol
                type)
                {
                    this_param.AddNullableAnnotations((Microsoft.CodeAnalysis.ITypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 5460, 5490);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10957_5600_5622(Microsoft.CodeAnalysis.IPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 5600, 5622);
                    return return_v;
                }


                int
                f_10957_5571_5643(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, bool
                leadingSpace)
                {
                    this_param.AddCustomModifiersIfRequired(customModifiers, leadingSpace: leadingSpace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 5571, 5643);
                    return 0;
                }


                int
                f_10957_5673_5713(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 5673, 5713);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 5305, 5725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 5305, 5725);
            }
        }

        public override void VisitFunctionPointerType(IFunctionPointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 5737, 5883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 5842, 5872);

                f_10957_5842_5871(this, f_10957_5854_5870(symbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 5737, 5883);

                Microsoft.CodeAnalysis.IMethodSymbol
                f_10957_5854_5870(Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 5854, 5870);
                    return return_v;
                }


                int
                f_10957_5842_5871(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IMethodSymbol
                symbol)
                {
                    this_param.VisitMethod(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 5842, 5871);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 5737, 5883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 5737, 5883);
            }
        }

        public override void VisitTypeParameter(ITypeParameterSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 5895, 6348);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 5988, 6109) || true) && (this.isFirstSymbolVisited)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 5988, 6109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 6051, 6094);

                    f_10957_6051_6093(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 5988, 6109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 6204, 6290);

                f_10957_6204_6289(
                            //variance and constraints are handled by methods and named types
                            builder, f_10957_6216_6288(this, SymbolDisplayPartKind.TypeParameterName, symbol, f_10957_6276_6287(symbol)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 6306, 6337);

                f_10957_6306_6336(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 5895, 6348);

                int
                f_10957_6051_6093(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ITypeParameterSymbol
                symbol)
                {
                    this_param.AddTypeParameterVarianceIfRequired(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 6051, 6093);
                    return 0;
                }


                string
                f_10957_6276_6287(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 6276, 6287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_6216_6288(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ITypeParameterSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 6216, 6288);
                    return return_v;
                }


                int
                f_10957_6204_6289(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 6204, 6289);
                    return 0;
                }


                int
                f_10957_6306_6336(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ITypeParameterSymbol
                type)
                {
                    this_param.AddNullableAnnotations((Microsoft.CodeAnalysis.ITypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 6306, 6336);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 5895, 6348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 5895, 6348);
            }
        }

        public override void VisitDynamicType(IDynamicTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 6360, 6583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 6449, 6525);

                f_10957_6449_6524(builder, f_10957_6461_6523(this, SymbolDisplayPartKind.Keyword, symbol, f_10957_6511_6522(symbol)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 6541, 6572);

                f_10957_6541_6571(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 6360, 6583);

                string
                f_10957_6511_6522(Microsoft.CodeAnalysis.IDynamicTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 6511, 6522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_6461_6523(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IDynamicTypeSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 6461, 6523);
                    return return_v;
                }


                int
                f_10957_6449_6524(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 6449, 6524);
                    return 0;
                }


                int
                f_10957_6541_6571(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IDynamicTypeSymbol
                type)
                {
                    this_param.AddNullableAnnotations((Microsoft.CodeAnalysis.ITypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 6541, 6571);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 6360, 6583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 6360, 6583);
            }
        }

        public override void VisitNamedType(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 6595, 6777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 6680, 6721);

                f_10957_6680_6720(this, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 6735, 6766);

                f_10957_6735_6765(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 6595, 6777);

                int
                f_10957_6680_6720(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    this_param.VisitNamedTypeWithoutNullability(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 6680, 6720);
                    return 0;
                }


                int
                f_10957_6735_6765(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                type)
                {
                    this_param.AddNullableAnnotations((Microsoft.CodeAnalysis.ITypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 6735, 6765);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 6595, 6777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 6595, 6777);
            }
        }

        private void VisitNamedTypeWithoutNullability(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 6789, 11000);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 6884, 6993) || true) && (f_10957_6888_6905(this) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 6888, 6937) && f_10957_6909_6937(this, symbol, builder)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 6884, 6993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 6971, 6978);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 6884, 6993);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 7009, 7543) || true) && (f_10957_7013_7106(f_10957_7013_7040(format), SymbolDisplayMiscellaneousOptions.UseSpecialTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10957, 7013, 7274) || (f_10957_7128_7154(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 7128, 7273) && !f_10957_7159_7273(f_10957_7159_7189(format), SymbolDisplayCompilerInternalOptions.UseNativeIntegerUnderlyingType)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 7009, 7543);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 7308, 7528) || true) && (f_10957_7312_7341(this, symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 7308, 7528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 7502, 7509);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 7308, 7528);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 7009, 7543);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 7559, 8515) || true) && (!f_10957_7564_7656(f_10957_7564_7591(format), SymbolDisplayMiscellaneousOptions.ExpandNullable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 7559, 8515);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 7776, 8500) || true) && (f_10957_7780_7821(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 7780, 7845) && f_10957_7825_7845_M(!symbol.IsDefinition)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 7776, 8500);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 7945, 7983);

                        var
                        typeArg = f_10957_7959_7979(symbol)[0]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8005, 8481) || true) && (f_10957_8009_8025(typeArg) != TypeKind.Pointer)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 8005, 8481);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8095, 8132);

                            f_10957_8095_8131(typeArg, f_10957_8110_8130(this));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8158, 8271);

                            f_10957_8158_8270(this, f_10957_8187_8227(symbol, 0), leadingSpace: true, trailingSpace: false);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8299, 8340);

                            f_10957_8299_8339(this, SyntaxKind.QuestionToken);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8451, 8458);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 8005, 8481);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 7776, 8500);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 7559, 8515);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8531, 8713) || true) && (f_10957_8535_8552(this) || (DynAbs.Tracing.TraceSender.Expression_False(10957, 8535, 8614) || (f_10957_8557_8575(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 8557, 8613) && !f_10957_8580_8613(this, symbol)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 8531, 8713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8648, 8673);

                    f_10957_8648_8672(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8691, 8698);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 8531, 8713);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8729, 8749);

                f_10957_8729_8748(this, symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8765, 9672) || true) && (f_10957_8769_8801(this, symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 8765, 9672);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8835, 9657) || true) && (f_10957_8839_8859(format) == SymbolDisplayDelegateStyle.NameAndSignature)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 8835, 9657);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 8948, 8995);

                        var
                        invokeMethod = f_10957_8967_8994(symbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9017, 9302) || true) && (f_10957_9021_9046(invokeMethod))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 9017, 9302);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9096, 9115);

                            f_10957_9096_9114(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 9017, 9302);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 9017, 9302);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9165, 9302) || true) && (f_10957_9169_9202(invokeMethod))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 9165, 9302);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9252, 9279);

                                f_10957_9252_9278(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 9165, 9302);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 9017, 9302);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9326, 9603) || true) && (f_10957_9330_9354(invokeMethod))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 9326, 9603);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9404, 9439);

                            f_10957_9404_9438(this, SyntaxKind.VoidKeyword);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 9326, 9603);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 9326, 9603);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9537, 9580);

                            f_10957_9537_9579(this, f_10957_9551_9578(symbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 9326, 9603);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9627, 9638);

                        f_10957_9627_9637(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 8835, 9657);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 8765, 9672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9787, 9834);

                var
                containingSymbol = f_10957_9810_9833(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9848, 10366) || true) && (f_10957_9852_9890(this, containingSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 9848, 10366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9924, 9981);

                    var
                    namespaceSymbol = (INamespaceSymbol)containingSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 9999, 10087);

                    var
                    shouldSkip = f_10957_10016_10049(namespaceSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 10016, 10086) && f_10957_10053_10068(symbol) == TypeKind.Error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 10107, 10351) || true) && (!shouldSkip)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 10107, 10351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 10164, 10209);

                        f_10957_10164_10208(namespaceSymbol, f_10957_10187_10207(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 10231, 10332);

                        f_10957_10231_10331(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10957, 10246, 10279) || ((f_10957_10246_10279(namespaceSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10957, 10282, 10308)) || DynAbs.Tracing.TraceSender.Conditional_F3(10957, 10311, 10330))) ? SyntaxKind.ColonColonToken : SyntaxKind.DotToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 10107, 10351);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 9848, 10366);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 10447, 10929) || true) && (f_10957_10451_10480(format) == SymbolDisplayTypeQualificationStyle.NameAndContainingTypes || (DynAbs.Tracing.TraceSender.Expression_False(10957, 10451, 10667) || f_10957_10563_10592(format) == SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 10447, 10929);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 10701, 10914) || true) && (f_10957_10705_10744(this, f_10957_10722_10743(symbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 10701, 10914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 10786, 10837);

                        f_10957_10786_10836(f_10957_10786_10807(symbol), f_10957_10815_10835(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 10859, 10895);

                        f_10957_10859_10894(this, SyntaxKind.DotToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 10701, 10914);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 10447, 10929);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 10945, 10989);

                f_10957_10945_10988(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 6789, 11000);

                bool
                f_10957_6888_6905(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.IsMinimizing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 6888, 6905);
                    return return_v;
                }


                bool
                f_10957_6909_6937(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                builder)
                {
                    var return_v = this_param.TryAddAlias((Microsoft.CodeAnalysis.INamespaceOrTypeSymbol)symbol, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 6909, 6937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10957_7013_7040(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 7013, 7040);
                    return return_v;
                }


                bool
                f_10957_7013_7106(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 7013, 7106);
                    return return_v;
                }


                bool
                f_10957_7128_7154(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 7128, 7154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_10957_7159_7189(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 7159, 7189);
                    return return_v;
                }


                bool
                f_10957_7159_7273(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 7159, 7273);
                    return return_v;
                }


                bool
                f_10957_7312_7341(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.AddSpecialTypeKeyword(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 7312, 7341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10957_7564_7591(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 7564, 7591);
                    return return_v;
                }


                bool
                f_10957_7564_7656(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 7564, 7656);
                    return return_v;
                }


                bool
                f_10957_7780_7821(Microsoft.CodeAnalysis.INamedTypeSymbol
                typeOpt)
                {
                    var return_v = ITypeSymbolHelpers.IsNullableType((Microsoft.CodeAnalysis.ITypeSymbol)typeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 7780, 7821);
                    return return_v;
                }


                bool
                f_10957_7825_7845_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 7825, 7845);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_10957_7959_7979(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 7959, 7979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10957_8009_8025(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 8009, 8025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10957_8110_8130(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 8110, 8130);
                    return return_v;
                }


                int
                f_10957_8095_8131(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 8095, 8131);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10957_8187_8227(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param, int
                ordinal)
                {
                    var return_v = this_param.GetTypeArgumentCustomModifiers(ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 8187, 8227);
                    return return_v;
                }


                int
                f_10957_8158_8270(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, bool
                leadingSpace, bool
                trailingSpace)
                {
                    this_param.AddCustomModifiersIfRequired(customModifiers, leadingSpace: leadingSpace, trailingSpace: trailingSpace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 8158, 8270);
                    return 0;
                }


                int
                f_10957_8299_8339(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 8299, 8339);
                    return 0;
                }


                bool
                f_10957_8535_8552(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.IsMinimizing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 8535, 8552);
                    return return_v;
                }


                bool
                f_10957_8557_8575(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 8557, 8575);
                    return return_v;
                }


                bool
                f_10957_8580_8613(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.ShouldDisplayAsValueTuple(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 8580, 8613);
                    return return_v;
                }


                int
                f_10957_8648_8672(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    this_param.MinimallyQualify(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 8648, 8672);
                    return 0;
                }


                int
                f_10957_8729_8748(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    this_param.AddTypeKind(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 8729, 8748);
                    return 0;
                }


                bool
                f_10957_8769_8801(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.CanShowDelegateSignature(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 8769, 8801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_10957_8839_8859(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 8839, 8859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10957_8967_8994(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 8967, 8994);
                    return return_v;
                }


                bool
                f_10957_9021_9046(Microsoft.CodeAnalysis.IMethodSymbol?
                this_param)
                {
                    var return_v = this_param.ReturnsByRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 9021, 9046);
                    return return_v;
                }


                int
                f_10957_9096_9114(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddRefIfRequired();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 9096, 9114);
                    return 0;
                }


                bool
                f_10957_9169_9202(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsByRefReadonly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 9169, 9202);
                    return return_v;
                }


                int
                f_10957_9252_9278(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddRefReadonlyIfRequired();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 9252, 9278);
                    return 0;
                }


                bool
                f_10957_9330_9354(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 9330, 9354);
                    return return_v;
                }


                int
                f_10957_9404_9438(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 9404, 9438);
                    return 0;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10957_9551_9578(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 9551, 9578);
                    return return_v;
                }


                int
                f_10957_9537_9579(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IMethodSymbol?
                symbol)
                {
                    this_param.AddReturnType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 9537, 9579);
                    return 0;
                }


                int
                f_10957_9627_9637(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 9627, 9637);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10957_9810_9833(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 9810, 9833);
                    return return_v;
                }


                bool
                f_10957_9852_9890(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ISymbol
                containingSymbol)
                {
                    var return_v = this_param.ShouldVisitNamespace(containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 9852, 9890);
                    return return_v;
                }


                bool
                f_10957_10016_10049(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 10016, 10049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10957_10053_10068(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 10053, 10068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10957_10187_10207(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 10187, 10207);
                    return return_v;
                }


                int
                f_10957_10164_10208(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 10164, 10208);
                    return 0;
                }


                bool
                f_10957_10246_10279(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 10246, 10279);
                    return return_v;
                }


                int
                f_10957_10231_10331(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 10231, 10331);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_10957_10451_10480(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 10451, 10480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_10957_10563_10592(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 10563, 10592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10957_10722_10743(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 10722, 10743);
                    return return_v;
                }


                bool
                f_10957_10705_10744(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                namedType)
                {
                    var return_v = this_param.IncludeNamedType(namedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 10705, 10744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10957_10786_10807(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 10786, 10807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10957_10815_10835(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 10815, 10835);
                    return return_v;
                }


                int
                f_10957_10786_10836(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 10786, 10836);
                    return 0;
                }


                int
                f_10957_10859_10894(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 10859, 10894);
                    return 0;
                }


                int
                f_10957_10945_10988(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    this_param.AddNameAndTypeArgumentsOrParameters(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 10945, 10988);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 6789, 11000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 6789, 11000);
            }
        }

        private bool ShouldDisplayAsValueTuple(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 11012, 11372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11100, 11133);

                f_10957_11100_11132(f_10957_11113_11131(symbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11149, 11311) || true) && (f_10957_11153_11250(f_10957_11153_11183(format), SymbolDisplayCompilerInternalOptions.UseValueTuple))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 11149, 11311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11284, 11296);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 11149, 11311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11327, 11361);

                return !f_10957_11335_11360(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 11012, 11372);

                bool
                f_10957_11113_11131(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 11113, 11131);
                    return return_v;
                }


                int
                f_10957_11100_11132(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 11100, 11132);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_10957_11153_11183(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 11153, 11183);
                    return return_v;
                }


                bool
                f_10957_11153_11250(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 11153, 11250);
                    return return_v;
                }


                bool
                f_10957_11335_11360(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                tupleSymbol)
                {
                    var return_v = this_param.CanUseTupleSyntax(tupleSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 11335, 11360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 11012, 11372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 11012, 11372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddNameAndTypeArgumentsOrParameters(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 11384, 16502);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11482, 11789) || true) && (f_10957_11486_11508(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 11482, 11789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11542, 11571);

                    f_10957_11542_11570(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11589, 11596);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 11482, 11789);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 11482, 11789);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11630, 11789) || true) && (f_10957_11634_11652(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 11634, 11690) && !f_10957_11657_11690(this, symbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 11630, 11789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11724, 11749);

                        f_10957_11724_11748(this, symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11767, 11774);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 11630, 11789);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 11482, 11789);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11805, 11830);

                string
                symbolName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 11967, 12135);

                NamedTypeSymbol
                underlyingTypeSymbol = (DynAbs.Tracing.TraceSender.Conditional_F1(10957, 12006, 12053) || (((symbol is Symbols.PublicModel.NamedTypeSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10957, 12056, 12127)) || DynAbs.Tracing.TraceSender.Conditional_F3(10957, 12130, 12134))) ? f_10957_12056_12127(((Symbols.PublicModel.NamedTypeSymbol)symbol)) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 12149, 12252);

                var
                illegalGenericInstantiationSymbol = underlyingTypeSymbol as NoPiaIllegalGenericInstantiationSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 12268, 13174) || true) && ((object)illegalGenericInstantiationSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 12268, 13174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 12355, 12433);

                    symbol = f_10957_12364_12432(f_10957_12364_12414(illegalGenericInstantiationSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 12268, 13174);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 12268, 13174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 12499, 12592);

                    var
                    ambiguousCanonicalTypeSymbol = underlyingTypeSymbol as NoPiaAmbiguousCanonicalTypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 12612, 13159) || true) && ((object)ambiguousCanonicalTypeSymbol != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 12612, 13159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 12702, 12773);

                        symbol = f_10957_12711_12772(f_10957_12711_12754(ambiguousCanonicalTypeSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 12612, 13159);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 12612, 13159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 12855, 12944);

                        var
                        missingCanonicalTypeSymbol = underlyingTypeSymbol as NoPiaMissingCanonicalTypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 12968, 13140) || true) && ((object)missingCanonicalTypeSymbol != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 12968, 13140);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 13064, 13117);

                            symbolName = f_10957_13077_13116(missingCanonicalTypeSymbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 12968, 13140);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 12612, 13159);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 12268, 13174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 13190, 13225);

                var
                partKind = f_10957_13205_13224(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 13241, 13337) || true) && (symbolName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 13241, 13337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 13297, 13322);

                    symbolName = f_10957_13310_13321(symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 13241, 13337);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 13353, 13879) || true) && (f_10957_13357_13457(f_10957_13357_13384(format), SymbolDisplayMiscellaneousOptions.UseErrorTypeSymbolName) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 13357, 13525) && partKind == SymbolDisplayPartKind.ErrorTypeName) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 13357, 13578) && f_10957_13546_13578(symbolName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 13353, 13879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 13612, 13659);

                    f_10957_13612_13658(builder, f_10957_13624_13657(this, partKind, symbol, "?"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 13353, 13879);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 13353, 13879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 13725, 13792);

                    symbolName = f_10957_13738_13791(this, symbol, symbolName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 13810, 13864);

                    f_10957_13810_13863(builder, f_10957_13822_13862(this, partKind, symbol, symbolName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 13353, 13879);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 13895, 15820) || true) && (f_10957_13899_14006(f_10957_13899_13929(format), SymbolDisplayCompilerInternalOptions.UseArityForGenericTypes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 13895, 15820);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 14178, 14474) || true) && (f_10957_14182_14214_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(underlyingTypeSymbol, 10957, 14182, 14214)?.MangleName) == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 14178, 14474);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 14264, 14295);

                        f_10957_14264_14294(f_10957_14277_14289(symbol) > 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 14317, 14455);

                        f_10957_14317_14454(builder, f_10957_14329_14453(this, InternalSymbolDisplayPartKind.Arity, null, f_10957_14408_14452(f_10957_14439_14451(symbol))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 14178, 14474);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 13895, 15820);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 13895, 15820);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 14508, 15820) || true) && (f_10957_14512_14524(symbol) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10957, 14512, 14621) && f_10957_14532_14621(f_10957_14532_14554(format), SymbolDisplayGenericsOptions.IncludeTypeParameters)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 14508, 15820);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 14749, 15709) || true) && (underlyingTypeSymbol is UnsupportedMetadataTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10957, 14753, 14859) || underlyingTypeSymbol is MissingMetadataTypeSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10957, 14753, 14890) || f_10957_14863_14890(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 14749, 15709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 14932, 14973);

                            f_10957_14932_14972(this, SyntaxKind.LessThanToken);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 15004, 15009);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 14995, 15147) || true) && (i < f_10957_15015_15027(symbol) - 1)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 15033, 15036)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 14995, 15147))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 14995, 15147);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 15086, 15124);

                                    f_10957_15086_15123(this, SyntaxKind.CommaToken);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10957, 1, 153);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10957, 1, 153);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 15171, 15215);

                            f_10957_15171_15214(this, SyntaxKind.GreaterThanToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 14749, 15709);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 14749, 15709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 15297, 15404);

                            ImmutableArray<ImmutableArray<CustomModifier>>
                            modifiers = f_10957_15356_15403(this, underlyingTypeSymbol)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 15426, 15462);

                            f_10957_15426_15461(this, symbol, modifiers);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 15486, 15516);

                            f_10957_15486_15515(this, symbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 15640, 15690);

                            f_10957_15640_15689(this, f_10957_15668_15688(symbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 14749, 15709);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 14508, 15820);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 14508, 15820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 15775, 15805);

                        f_10957_15775_15804(this, symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 14508, 15820);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 13895, 15820);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 15970, 16491) || true) && (f_10957_15974_16014_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(underlyingTypeSymbol, 10957, 15974, 16014)?.OriginalDefinition) is MissingMetadataTypeSymbol && (DynAbs.Tracing.TraceSender.Expression_True(10957, 15974, 16172) && f_10957_16064_16172(f_10957_16064_16094(format), SymbolDisplayCompilerInternalOptions.FlagMissingMetadataTypes)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 15970, 16491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 16271, 16315);

                    f_10957_16271_16314(this, SyntaxKind.OpenBracketToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 16333, 16413);

                    f_10957_16333_16412(builder, f_10957_16345_16411(this, InternalSymbolDisplayPartKind.Other, symbol, "missing"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 16431, 16476);

                    f_10957_16431_16475(this, SyntaxKind.CloseBracketToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 15970, 16491);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 11384, 16502);

                bool
                f_10957_11486_11508(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 11486, 11508);
                    return return_v;
                }


                int
                f_10957_11542_11570(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    this_param.AddAnonymousTypeName(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 11542, 11570);
                    return 0;
                }


                bool
                f_10957_11634_11652(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 11634, 11652);
                    return return_v;
                }


                bool
                f_10957_11657_11690(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.ShouldDisplayAsValueTuple(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 11657, 11690);
                    return return_v;
                }


                int
                f_10957_11724_11748(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    this_param.AddTupleTypeName(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 11724, 11748);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10957_12056_12127(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 12056, 12127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10957_12364_12414(Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaIllegalGenericInstantiationSymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 12364, 12414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10957_12364_12432(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 12364, 12432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10957_12711_12754(Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaAmbiguousCanonicalTypeSymbol
                this_param)
                {
                    var return_v = this_param.FirstCandidate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 12711, 12754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10957_12711_12772(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 12711, 12772);
                    return return_v;
                }


                string
                f_10957_13077_13116(Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaMissingCanonicalTypeSymbol
                this_param)
                {
                    var return_v = this_param.FullTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 13077, 13116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPartKind
                f_10957_13205_13224(Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = GetPartKind(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 13205, 13224);
                    return return_v;
                }


                string
                f_10957_13310_13321(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 13310, 13321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10957_13357_13384(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 13357, 13384);
                    return return_v;
                }


                bool
                f_10957_13357_13457(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 13357, 13457);
                    return return_v;
                }


                bool
                f_10957_13546_13578(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 13546, 13578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_13624_13657(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 13624, 13657);
                    return return_v;
                }


                int
                f_10957_13612_13658(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 13612, 13658);
                    return 0;
                }


                string
                f_10957_13738_13791(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol, string
                symbolName)
                {
                    var return_v = this_param.RemoveAttributeSufficeIfNecessary(symbol, symbolName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 13738, 13791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_13822_13862(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 13822, 13862);
                    return return_v;
                }


                int
                f_10957_13810_13863(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 13810, 13863);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_10957_13899_13929(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 13899, 13929);
                    return return_v;
                }


                bool
                f_10957_13899_14006(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 13899, 14006);
                    return return_v;
                }


                bool?
                f_10957_14182_14214_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 14182, 14214);
                    return return_v;
                }


                int
                f_10957_14277_14289(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 14277, 14289);
                    return return_v;
                }


                int
                f_10957_14264_14294(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 14264, 14294);
                    return 0;
                }


                int
                f_10957_14439_14451(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 14439, 14451);
                    return return_v;
                }


                string
                f_10957_14408_14452(int
                arity)
                {
                    var return_v = MetadataHelpers.GetAritySuffix(arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 14408, 14452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_14329_14453(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 14329, 14453);
                    return return_v;
                }


                int
                f_10957_14317_14454(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 14317, 14454);
                    return 0;
                }


                int
                f_10957_14512_14524(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 14512, 14524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_10957_14532_14554(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 14532, 14554);
                    return return_v;
                }


                bool
                f_10957_14532_14621(Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 14532, 14621);
                    return return_v;
                }


                bool
                f_10957_14863_14890(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsUnboundGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 14863, 14890);
                    return return_v;
                }


                int
                f_10957_14932_14972(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 14932, 14972);
                    return 0;
                }


                int
                f_10957_15015_15027(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 15015, 15027);
                    return return_v;
                }


                int
                f_10957_15086_15123(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 15086, 15123);
                    return 0;
                }


                int
                f_10957_15171_15214(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 15171, 15214);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                f_10957_15356_15403(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                underlyingTypeSymbol)
                {
                    var return_v = this_param.GetTypeArgumentsModifiers(underlyingTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 15356, 15403);
                    return return_v;
                }


                int
                f_10957_15426_15461(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                owner, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                modifiers)
                {
                    this_param.AddTypeArguments((Microsoft.CodeAnalysis.ISymbol)owner, modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 15426, 15461);
                    return 0;
                }


                int
                f_10957_15486_15515(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    this_param.AddDelegateParameters(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 15486, 15515);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_10957_15668_15688(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 15668, 15688);
                    return return_v;
                }


                int
                f_10957_15640_15689(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                typeArguments)
                {
                    this_param.AddTypeParameterConstraints(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 15640, 15689);
                    return 0;
                }


                int
                f_10957_15775_15804(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    this_param.AddDelegateParameters(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 15775, 15804);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10957_15974_16014_M(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 15974, 16014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_10957_16064_16094(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 16064, 16094);
                    return return_v;
                }


                bool
                f_10957_16064_16172(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 16064, 16172);
                    return return_v;
                }


                int
                f_10957_16271_16314(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 16271, 16314);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_16345_16411(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 16345, 16411);
                    return return_v;
                }


                int
                f_10957_16333_16412(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 16333, 16412);
                    return 0;
                }


                int
                f_10957_16431_16475(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 16431, 16475);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 11384, 16502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 11384, 16502);
            }
        }

        private ImmutableArray<ImmutableArray<CustomModifier>> GetTypeArgumentsModifiers(NamedTypeSymbol underlyingTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 16514, 17079);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 16657, 17037) || true) && (f_10957_16661_16772(f_10957_16661_16696(this.format), SymbolDisplayCompilerInternalOptions.IncludeCustomModifiers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 16657, 17037);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 16806, 17022) || true) && ((object)underlyingTypeSymbol != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 16806, 17022);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 16888, 17003);

                        return underlyingTypeSymbol.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.SelectAsArray(a => a.CustomModifiers);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 16806, 17022);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 16657, 17037);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 17053, 17068);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 16514, 17079);

                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_10957_16661_16696(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 16661, 16696);
                    return return_v;
                }


                bool
                f_10957_16661_16772(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 16661, 16772);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 16514, 17079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 16514, 17079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddDelegateParameters(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 17091, 17796);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 17175, 17785) || true) && (f_10957_17179_17211(this, symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 17175, 17785);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 17245, 17770) || true) && (f_10957_17249_17269(format) == SymbolDisplayDelegateStyle.NameAndParameters || (DynAbs.Tracing.TraceSender.Expression_False(10957, 17249, 17409) || f_10957_17342_17362(format) == SymbolDisplayDelegateStyle.NameAndSignature))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 17245, 17770);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 17451, 17492);

                        var
                        method = f_10957_17464_17491(symbol)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 17514, 17556);

                        f_10957_17514_17555(this, SyntaxKind.OpenParenToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 17578, 17686);

                        f_10957_17578_17685(this, hasThisParameter: false, isVarargs: f_10957_17638_17653(method), parameters: f_10957_17667_17684(method));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 17708, 17751);

                        f_10957_17708_17750(this, SyntaxKind.CloseParenToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 17245, 17770);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 17175, 17785);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 17091, 17796);

                bool
                f_10957_17179_17211(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.CanShowDelegateSignature(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 17179, 17211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_10957_17249_17269(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 17249, 17269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_10957_17342_17362(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 17342, 17362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10957_17464_17491(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 17464, 17491);
                    return return_v;
                }


                int
                f_10957_17514_17555(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 17514, 17555);
                    return 0;
                }


                bool
                f_10957_17638_17653(Microsoft.CodeAnalysis.IMethodSymbol?
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 17638, 17653);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                f_10957_17667_17684(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 17667, 17684);
                    return return_v;
                }


                int
                f_10957_17578_17685(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, bool
                hasThisParameter, bool
                isVarargs, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                parameters)
                {
                    this_param.AddParametersIfRequired(hasThisParameter: hasThisParameter, isVarargs: isVarargs, parameters: parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 17578, 17685);
                    return 0;
                }


                int
                f_10957_17708_17750(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 17708, 17750);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 17091, 17796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 17091, 17796);
            }
        }

        private void AddAnonymousTypeName(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 17808, 18474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 17952, 18065);

                var
                members = f_10957_17966_18064(", ", f_10957_17984_18063(f_10957_17984_18003(symbol).OfType<IPropertySymbol>(), CreateAnonymousTypeMember))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 18081, 18463) || true) && (f_10957_18085_18099(members) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 18081, 18463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 18138, 18240);

                    f_10957_18138_18239(builder, f_10957_18150_18238(SymbolDisplayPartKind.ClassName, symbol, "<empty anonymous type>"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 18081, 18463);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 18081, 18463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 18306, 18348);

                    var
                    name = $"<anonymous type: {members}>"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 18366, 18448);

                    f_10957_18366_18447(builder, f_10957_18378_18446(SymbolDisplayPartKind.ClassName, symbol, name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 18081, 18463);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 17808, 18474);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10957_17984_18003(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 17984, 18003);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10957_17984_18063(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IPropertySymbol>
                source, System.Func<Microsoft.CodeAnalysis.IPropertySymbol, string>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.IPropertySymbol, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 17984, 18063);
                    return return_v;
                }


                string
                f_10957_17966_18064(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 17966, 18064);
                    return return_v;
                }


                int
                f_10957_18085_18099(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 18085, 18099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_18150_18238(Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol, string
                text)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayPart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 18150, 18238);
                    return return_v;
                }


                int
                f_10957_18138_18239(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 18138, 18239);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_18378_18446(Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol, string
                text)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayPart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 18378, 18446);
                    return return_v;
                }


                int
                f_10957_18366_18447(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 18366, 18447);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 17808, 18474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 17808, 18474);
            }
        }

        private bool CanUseTupleSyntax(INamedTypeSymbol tupleSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 18832, 20452);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 18917, 19010) || true) && (f_10957_18921_18948(tupleSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 18917, 19010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 18982, 18995);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 18917, 19010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 19026, 19105);

                INamedTypeSymbol
                currentUnderlying = f_10957_19063_19104(tupleSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 19119, 19213) || true) && (f_10957_19123_19146(currentUnderlying) <= 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 19119, 19213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 19185, 19198);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 19119, 19213);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 19229, 19848) || true) && (f_10957_19236_19259(currentUnderlying) == NamedTypeSymbol.ValueTupleRestPosition)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 19229, 19848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 19335, 19443);

                        tupleSymbol = (INamedTypeSymbol)f_10957_19367_19398(currentUnderlying)[NamedTypeSymbol.ValueTupleRestPosition - 1];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 19461, 19499);

                        f_10957_19461_19498(f_10957_19474_19497(tupleSymbol));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 19519, 19751) || true) && (f_10957_19523_19543(tupleSymbol) == TypeKind.Error || (DynAbs.Tracing.TraceSender.Expression_False(10957, 19523, 19625) || f_10957_19586_19625(tupleSymbol)) || (DynAbs.Tracing.TraceSender.Expression_False(10957, 19523, 19677) || f_10957_19650_19677(tupleSymbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 19519, 19751);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 19719, 19732);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 19519, 19751);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 19771, 19833);

                        currentUnderlying = f_10957_19791_19832(tupleSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 19229, 19848);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10957, 19229, 19848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10957, 19229, 19848);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 19864, 19876);

                return true;

                bool containsModopt(INamedTypeSymbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 19892, 20441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 19996, 20128);

                        NamedTypeSymbol
                        underlyingTypeSymbol = (DynAbs.Tracing.TraceSender.Conditional_F1(10957, 20035, 20087) || (((symbol is Symbols.PublicModel.NamedTypeSymbol temp) && DynAbs.Tracing.TraceSender.Conditional_F2(10957, 20090, 20120))
                        || DynAbs.Tracing.TraceSender.Conditional_F3(10957, 20123, 20127))) ? f_10957_20090_20120((Symbols.PublicModel.NamedTypeSymbol)symbol) : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 20146, 20253);

                        ImmutableArray<ImmutableArray<CustomModifier>>
                        modifiers = f_10957_20205_20252(this, underlyingTypeSymbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 20271, 20368) || true) && (modifiers.IsDefault)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 20271, 20368);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 20336, 20349);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 20271, 20368);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 20388, 20426);

                        return modifiers.Any(m => !m.IsEmpty);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 19892, 20441);

                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10957_20090_20120(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.UnderlyingNamedTypeSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 20090, 20120);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                        f_10957_20205_20252(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                        underlyingTypeSymbol)
                        {
                            var return_v = this_param.GetTypeArgumentsModifiers(underlyingTypeSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 20205, 20252);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 19892, 20441);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 19892, 20441);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 18832, 20452);

                bool
                f_10957_18921_18948(Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = containsModopt(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 18921, 18948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10957_19063_19104(Microsoft.CodeAnalysis.INamedTypeSymbol
                type)
                {
                    var return_v = GetTupleUnderlyingTypeOrSelf(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 19063, 19104);
                    return return_v;
                }


                int
                f_10957_19123_19146(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 19123, 19146);
                    return return_v;
                }


                int
                f_10957_19236_19259(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 19236, 19259);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_10957_19367_19398(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 19367, 19398);
                    return return_v;
                }


                bool
                f_10957_19474_19497(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 19474, 19497);
                    return return_v;
                }


                int
                f_10957_19461_19498(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 19461, 19498);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10957_19523_19543(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 19523, 19543);
                    return return_v;
                }


                bool
                f_10957_19586_19625(Microsoft.CodeAnalysis.INamedTypeSymbol
                tupleSymbol)
                {
                    var return_v = HasNonDefaultTupleElements(tupleSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 19586, 19625);
                    return return_v;
                }


                bool
                f_10957_19650_19677(Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = containsModopt(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 19650, 19677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10957_19791_19832(Microsoft.CodeAnalysis.INamedTypeSymbol
                type)
                {
                    var return_v = GetTupleUnderlyingTypeOrSelf(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 19791, 19832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 18832, 20452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 18832, 20452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static INamedTypeSymbol GetTupleUnderlyingTypeOrSelf(INamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10957, 20464, 20623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 20572, 20612);

                return f_10957_20579_20603(type) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.INamedTypeSymbol?>(10957, 20579, 20611) ?? type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10957, 20464, 20623);

                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10957_20579_20603(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 20579, 20603);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 20464, 20623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 20464, 20623);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasNonDefaultTupleElements(INamedTypeSymbol tupleSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10957, 20635, 20817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 20736, 20806);

                return tupleSymbol.TupleElements.Any(e => !e.IsDefaultTupleElement());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10957, 20635, 20817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 20635, 20817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 20635, 20817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddTupleTypeName(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 20829, 22206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 20908, 20941);

                f_10957_20908_20940(f_10957_20921_20939(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 20957, 21018);

                ImmutableArray<IFieldSymbol>
                elements = f_10957_20997_21017(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21034, 21076);

                f_10957_21034_21075(this, SyntaxKind.OpenParenToken);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21099, 21104);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21090, 21635) || true) && (i < elements.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21127, 21130)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 21090, 21635))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 21090, 21635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21164, 21190);

                        var
                        element = elements[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21210, 21352) || true) && (i != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 21210, 21352);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21262, 21300);

                            f_10957_21262_21299(this, SyntaxKind.CommaToken);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21322, 21333);

                            f_10957_21322_21332(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 21210, 21352);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21372, 21396);

                        f_10957_21372_21395(this, element);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21414, 21620) || true) && (f_10957_21418_21447_M(!element.IsImplicitlyDeclared))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 21414, 21620);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21489, 21500);

                            f_10957_21489_21499(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21522, 21601);

                            f_10957_21522_21600(builder, f_10957_21534_21599(this, SymbolDisplayPartKind.FieldName, symbol, f_10957_21586_21598(element)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 21414, 21620);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10957, 1, 546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10957, 1, 546);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21651, 21694);

                f_10957_21651_21693(this, SyntaxKind.CloseParenToken);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21710, 22195) || true) && (f_10957_21714_21729(symbol) == TypeKind.Error && (DynAbs.Tracing.TraceSender.Expression_True(10957, 21714, 21876) && f_10957_21768_21876(f_10957_21768_21798(format), SymbolDisplayCompilerInternalOptions.FlagMissingMetadataTypes)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 21710, 22195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 21975, 22019);

                    f_10957_21975_22018(this, SyntaxKind.OpenBracketToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 22037, 22117);

                    f_10957_22037_22116(builder, f_10957_22049_22115(this, InternalSymbolDisplayPartKind.Other, symbol, "missing"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 22135, 22180);

                    f_10957_22135_22179(this, SyntaxKind.CloseBracketToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 21710, 22195);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 20829, 22206);

                bool
                f_10957_20921_20939(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 20921, 20939);
                    return return_v;
                }


                int
                f_10957_20908_20940(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 20908, 20940);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IFieldSymbol>
                f_10957_20997_21017(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 20997, 21017);
                    return return_v;
                }


                int
                f_10957_21034_21075(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 21034, 21075);
                    return 0;
                }


                int
                f_10957_21262_21299(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 21262, 21299);
                    return 0;
                }


                int
                f_10957_21322_21332(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 21322, 21332);
                    return 0;
                }


                int
                f_10957_21372_21395(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IFieldSymbol
                symbol)
                {
                    this_param.VisitFieldType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 21372, 21395);
                    return 0;
                }


                bool
                f_10957_21418_21447_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 21418, 21447);
                    return return_v;
                }


                int
                f_10957_21489_21499(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 21489, 21499);
                    return 0;
                }


                string
                f_10957_21586_21598(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 21586, 21598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_21534_21599(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 21534, 21599);
                    return return_v;
                }


                int
                f_10957_21522_21600(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 21522, 21600);
                    return 0;
                }


                int
                f_10957_21651_21693(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 21651, 21693);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10957_21714_21729(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 21714, 21729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_10957_21768_21798(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 21768, 21798);
                    return return_v;
                }


                bool
                f_10957_21768_21876(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 21768, 21876);
                    return return_v;
                }


                int
                f_10957_21975_22018(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 21975, 22018);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_22049_22115(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 22049, 22115);
                    return return_v;
                }


                int
                f_10957_22037_22116(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 22037, 22116);
                    return 0;
                }


                int
                f_10957_22135_22179(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 22135, 22179);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 20829, 22206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 20829, 22206);
            }
        }

        private string CreateAnonymousTypeMember(IPropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 22218, 22387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 22309, 22376);

                return f_10957_22316_22353(f_10957_22316_22329(property), format) + " " + f_10957_22362_22375(property);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 22218, 22387);

                Microsoft.CodeAnalysis.ITypeSymbol
                f_10957_22316_22329(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 22316, 22329);
                    return return_v;
                }


                string
                f_10957_22316_22353(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 22316, 22353);
                    return return_v;
                }


                string
                f_10957_22362_22375(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 22362, 22375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 22218, 22387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 22218, 22387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CanShowDelegateSignature(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 22399, 22735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 22486, 22724);

                return
                                isFirstSymbolVisited && (DynAbs.Tracing.TraceSender.Expression_True(10957, 22510, 22587) && f_10957_22551_22566(symbol) == TypeKind.Delegate) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 22510, 22667) && f_10957_22608_22628(format) != SymbolDisplayDelegateStyle.NameOnly) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 22510, 22723) && f_10957_22688_22715(symbol) != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 22399, 22735);

                Microsoft.CodeAnalysis.TypeKind
                f_10957_22551_22566(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 22551, 22566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
                f_10957_22608_22628(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.DelegateStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 22608, 22628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10957_22688_22715(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 22688, 22715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 22399, 22735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 22399, 22735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SymbolDisplayPartKind GetPartKind(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10957, 22747, 23836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 22845, 23825);

                switch (f_10957_22853_22868(symbol))
                {

                    case TypeKind.Class when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 22922, 22942) || true) && (f_10957_22927_22942(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 22922, 22942) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 22845, 23825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 22965, 23010);

                        return SymbolDisplayPartKind.RecordClassName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 22845, 23825);

                    case TypeKind.Submission:
                    case TypeKind.Module:
                    case TypeKind.Class:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 22845, 23825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 23152, 23191);

                        return SymbolDisplayPartKind.ClassName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 22845, 23825);

                    case TypeKind.Delegate:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 22845, 23825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 23254, 23296);

                        return SymbolDisplayPartKind.DelegateName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 22845, 23825);

                    case TypeKind.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 22845, 23825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 23355, 23393);

                        return SymbolDisplayPartKind.EnumName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 22845, 23825);

                    case TypeKind.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 22845, 23825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 23453, 23496);

                        return SymbolDisplayPartKind.ErrorTypeName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 22845, 23825);

                    case TypeKind.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 22845, 23825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 23560, 23603);

                        return SymbolDisplayPartKind.InterfaceName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 22845, 23825);

                    case TypeKind.Struct:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 22845, 23825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 23664, 23704);

                        return SymbolDisplayPartKind.StructName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 22845, 23825);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 22845, 23825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 23752, 23810);

                        throw f_10957_23758_23809(f_10957_23793_23808(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 22845, 23825);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10957, 22747, 23836);

                Microsoft.CodeAnalysis.TypeKind
                f_10957_22853_22868(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 22853, 22868);
                    return return_v;
                }


                bool
                f_10957_22927_22942(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 22927, 22942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10957_23793_23808(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 23793, 23808);
                    return return_v;
                }


                System.Exception
                f_10957_23758_23809(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 23758, 23809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 22747, 23836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 22747, 23836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool AddSpecialTypeKeyword(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 23848, 24363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 23932, 23981);

                var
                specialTypeName = f_10957_23954_23980(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 23995, 24084) || true) && (specialTypeName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 23995, 24084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 24056, 24069);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 23995, 24084);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 24246, 24326);

                f_10957_24246_24325(
                            // cheat - skip escapeKeywordIdentifiers. not calling AddKeyword because someone
                            // else is working out the text for us
                            builder, f_10957_24258_24324(this, SymbolDisplayPartKind.Keyword, symbol, specialTypeName));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 24340, 24352);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 23848, 24363);

                string
                f_10957_23954_23980(Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = GetSpecialTypeName(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 23954, 23980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_24258_24324(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 24258, 24324);
                    return return_v;
                }


                int
                f_10957_24246_24325(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 24246, 24325);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 23848, 24363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 23848, 24363);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetSpecialTypeName(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10957, 24375, 26195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 24465, 26184);

                switch (f_10957_24473_24491(symbol))
                {

                    case SpecialType.System_Void:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 24576, 24590);

                        return "void";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 24660, 24675);

                        return "sbyte";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 24745, 24760);

                        return "short";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 24830, 24843);

                        return "int";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 24913, 24927);

                        return "long";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 24976, 25007) || true) && (f_10957_24981_25007(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 24976, 25007) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25030, 25044);

                        return "nint";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25094, 25125) || true) && (f_10957_25099_25125(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 25094, 25125) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25148, 25163);

                        return "nuint";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25232, 25246);

                        return "byte";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25317, 25333);

                        return "ushort";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25404, 25418);

                        return "uint";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25489, 25504);

                        return "ulong";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25575, 25590);

                        return "float";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25661, 25677);

                        return "double";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25749, 25766);

                        return "decimal";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25835, 25849);

                        return "char";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 25921, 25935);

                        return "bool";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 26006, 26022);

                        return "string";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    case SpecialType.System_Object:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 26093, 26109);

                        return "object";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 24465, 26184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 26157, 26169);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 24465, 26184);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10957, 24375, 26195);

                Microsoft.CodeAnalysis.SpecialType
                f_10957_24473_24491(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 24473, 24491);
                    return return_v;
                }


                bool
                f_10957_24981_25007(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 24981, 25007);
                    return return_v;
                }


                bool
                f_10957_25099_25125(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 25099, 25125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 24375, 26195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 24375, 26195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddTypeKind(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 26207, 28789);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 26281, 28778) || true) && (isFirstSymbolVisited && (DynAbs.Tracing.TraceSender.Expression_True(10957, 26285, 26387) && f_10957_26309_26387(f_10957_26309_26327(format), SymbolDisplayKindOptions.IncludeTypeKeyword)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 26281, 28778);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 26421, 28763) || true) && (f_10957_26425_26447(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 26421, 28763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 26489, 26593);

                        f_10957_26489_26592(builder, f_10957_26501_26591(SymbolDisplayPartKind.AnonymousTypeIndicator, null, "AnonymousType"));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 26615, 26626);

                        f_10957_26615_26625(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 26421, 28763);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 26421, 28763);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 26668, 28763) || true) && (f_10957_26672_26690(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 26672, 26728) && !f_10957_26695_26728(this, symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 26668, 28763);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 26770, 26866);

                            f_10957_26770_26865(builder, f_10957_26782_26864(SymbolDisplayPartKind.AnonymousTypeIndicator, null, "Tuple"));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 26888, 26899);

                            f_10957_26888_26898(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 26668, 28763);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 26668, 28763);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 26981, 28744);

                            switch (f_10957_26989_27004(symbol))
                            {

                                case TypeKind.Class when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 27074, 27094) || true) && (f_10957_27079_27094(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10957, 27074, 27094) || true)
                            :
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 26981, 28744);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 27125, 27162);

                                    f_10957_27125_27161(this, SyntaxKind.RecordKeyword);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 27192, 27203);

                                    f_10957_27192_27202(this);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10957, 27233, 27239);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 26981, 28744);

                                case TypeKind.Module:
                                case TypeKind.Class:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 26981, 28744);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 27364, 27400);

                                    f_10957_27364_27399(this, SyntaxKind.ClassKeyword);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 27430, 27441);

                                    f_10957_27430_27440(this);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10957, 27471, 27477);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 26981, 28744);

                                case TypeKind.Enum:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 26981, 28744);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 27554, 27589);

                                    f_10957_27554_27588(this, SyntaxKind.EnumKeyword);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 27619, 27630);

                                    f_10957_27619_27629(this);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10957, 27660, 27666);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 26981, 28744);

                                case TypeKind.Delegate:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 26981, 28744);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 27747, 27786);

                                    f_10957_27747_27785(this, SyntaxKind.DelegateKeyword);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 27816, 27827);

                                    f_10957_27816_27826(this);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10957, 27857, 27863);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 26981, 28744);

                                case TypeKind.Interface:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 26981, 28744);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 27945, 27985);

                                    f_10957_27945_27984(this, SyntaxKind.InterfaceKeyword);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 28015, 28026);

                                    f_10957_28015_28025(this);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10957, 28056, 28062);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 26981, 28744);

                                case TypeKind.Struct:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 26981, 28744);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 28141, 28343) || true) && (f_10957_28145_28162(symbol))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 28141, 28343);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 28228, 28267);

                                        f_10957_28228_28266(this, SyntaxKind.ReadOnlyKeyword);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 28301, 28312);

                                        f_10957_28301_28311(this);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 28141, 28343);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 28375, 28575) || true) && (f_10957_28379_28399(symbol))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 28375, 28575);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 28465, 28499);

                                        f_10957_28465_28498(this, SyntaxKind.RefKeyword);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 28533, 28544);

                                        f_10957_28533_28543(this);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 28375, 28575);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 28607, 28644);

                                    f_10957_28607_28643(this, SyntaxKind.StructKeyword);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 28674, 28685);

                                    f_10957_28674_28684(this);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10957, 28715, 28721);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 26981, 28744);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 26668, 28763);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 26421, 28763);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 26281, 28778);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 26207, 28789);

                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_10957_26309_26327(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 26309, 26327);
                    return return_v;
                }


                bool
                f_10957_26309_26387(Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 26309, 26387);
                    return return_v;
                }


                bool
                f_10957_26425_26447(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 26425, 26447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_26501_26591(Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol?
                symbol, string
                text)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayPart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 26501, 26591);
                    return return_v;
                }


                int
                f_10957_26489_26592(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 26489, 26592);
                    return 0;
                }


                int
                f_10957_26615_26625(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 26615, 26625);
                    return 0;
                }


                bool
                f_10957_26672_26690(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 26672, 26690);
                    return return_v;
                }


                bool
                f_10957_26695_26728(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.ShouldDisplayAsValueTuple(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 26695, 26728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_26782_26864(Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol?
                symbol, string
                text)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayPart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 26782, 26864);
                    return return_v;
                }


                int
                f_10957_26770_26865(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 26770, 26865);
                    return 0;
                }


                int
                f_10957_26888_26898(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 26888, 26898);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10957_26989_27004(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 26989, 27004);
                    return return_v;
                }


                bool
                f_10957_27079_27094(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 27079, 27094);
                    return return_v;
                }


                int
                f_10957_27125_27161(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 27125, 27161);
                    return 0;
                }


                int
                f_10957_27192_27202(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 27192, 27202);
                    return 0;
                }


                int
                f_10957_27364_27399(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 27364, 27399);
                    return 0;
                }


                int
                f_10957_27430_27440(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 27430, 27440);
                    return 0;
                }


                int
                f_10957_27554_27588(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 27554, 27588);
                    return 0;
                }


                int
                f_10957_27619_27629(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 27619, 27629);
                    return 0;
                }


                int
                f_10957_27747_27785(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 27747, 27785);
                    return 0;
                }


                int
                f_10957_27816_27826(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 27816, 27826);
                    return 0;
                }


                int
                f_10957_27945_27984(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 27945, 27984);
                    return 0;
                }


                int
                f_10957_28015_28025(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 28015, 28025);
                    return 0;
                }


                bool
                f_10957_28145_28162(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 28145, 28162);
                    return return_v;
                }


                int
                f_10957_28228_28266(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 28228, 28266);
                    return 0;
                }


                int
                f_10957_28301_28311(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 28301, 28311);
                    return 0;
                }


                bool
                f_10957_28379_28399(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 28379, 28399);
                    return return_v;
                }


                int
                f_10957_28465_28498(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 28465, 28498);
                    return 0;
                }


                int
                f_10957_28533_28543(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 28533, 28543);
                    return 0;
                }


                int
                f_10957_28607_28643(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 28607, 28643);
                    return 0;
                }


                int
                f_10957_28674_28684(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 28674, 28684);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 26207, 28789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 26207, 28789);
            }
        }

        private void AddTypeParameterVarianceIfRequired(ITypeParameterSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 28801, 29455);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 28902, 29444) || true) && (f_10957_28906_28989(f_10957_28906_28928(format), SymbolDisplayGenericsOptions.IncludeVariance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 28902, 29444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 29023, 29429);

                    switch (f_10957_29031_29046(symbol))
                    {

                        case VarianceKind.In:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 29023, 29429);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 29135, 29168);

                            f_10957_29135_29167(this, SyntaxKind.InKeyword);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 29194, 29205);

                            f_10957_29194_29204(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(10957, 29231, 29237);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 29023, 29429);

                        case VarianceKind.Out:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 29023, 29429);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 29307, 29341);

                            f_10957_29307_29340(this, SyntaxKind.OutKeyword);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 29367, 29378);

                            f_10957_29367_29377(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(10957, 29404, 29410);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 29023, 29429);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 28902, 29444);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 28801, 29455);

                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_10957_28906_28928(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 28906, 28928);
                    return return_v;
                }


                bool
                f_10957_28906_28989(Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 28906, 28989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10957_29031_29046(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 29031, 29046);
                    return return_v;
                }


                int
                f_10957_29135_29167(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 29135, 29167);
                    return 0;
                }


                int
                f_10957_29194_29204(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 29194, 29204);
                    return 0;
                }


                int
                f_10957_29307_29340(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 29307, 29340);
                    return 0;
                }


                int
                f_10957_29367_29377(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 29367, 29377);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 28801, 29455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 28801, 29455);
            }
        }

        private void AddTypeArguments(ISymbol owner, ImmutableArray<ImmutableArray<CustomModifier>> modifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 29516, 31451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 29643, 29685);

                ImmutableArray<ITypeSymbol>
                typeArguments
                = default(ImmutableArray<ITypeSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 29701, 29960) || true) && (f_10957_29705_29715(owner) == SymbolKind.Method)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 29701, 29960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 29770, 29823);

                    typeArguments = f_10957_29786_29822(((IMethodSymbol)owner));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 29701, 29960);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 29701, 29960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 29889, 29945);

                    typeArguments = f_10957_29905_29944(((INamedTypeSymbol)owner));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 29701, 29960);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 29976, 31440) || true) && (typeArguments.Length > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10957, 29980, 30097) && f_10957_30008_30097(f_10957_30008_30030(format), SymbolDisplayGenericsOptions.IncludeTypeParameters)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 29976, 31440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30131, 30172);

                    f_10957_30131_30171(this, SyntaxKind.LessThanToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30192, 30209);

                    var
                    first = true
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30236, 30241);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30227, 31361) || true) && (i < typeArguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30269, 30272)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 30227, 31361))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 30227, 31361);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30314, 30345);

                            var
                            typeArg = typeArguments[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30369, 30527) || true) && (!first)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 30369, 30527);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30429, 30467);

                                f_10957_30429_30466(this, SyntaxKind.CommaToken);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30493, 30504);

                                f_10957_30493_30503(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 30369, 30527);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30549, 30563);

                            first = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30587, 30624);

                            AbstractSymbolDisplayVisitor
                            visitor
                            = default(AbstractSymbolDisplayVisitor);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30648, 31088) || true) && (f_10957_30652_30664(typeArg) == SymbolKind.TypeParameter)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 30648, 31088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30742, 30788);

                                var
                                typeParam = (ITypeParameterSymbol)typeArg
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30816, 30862);

                                f_10957_30816_30861(this, typeParam);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 30890, 30921);

                                visitor = f_10957_30900_30920(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 30648, 31088);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 30648, 31088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 31019, 31065);

                                visitor = f_10957_31029_31064(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 30648, 31088);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 31112, 31136);

                            f_10957_31112_31135(
                                                typeArg, visitor);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 31160, 31342) || true) && (f_10957_31164_31184_M(!modifiers.IsDefault))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 31160, 31342);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 31234, 31319);

                                f_10957_31234_31318(this, modifiers[i], leadingSpace: true, trailingSpace: false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 31160, 31342);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10957, 1, 1135);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10957, 1, 1135);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 31381, 31425);

                    f_10957_31381_31424(this, SyntaxKind.GreaterThanToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 29976, 31440);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 29516, 31451);

                Microsoft.CodeAnalysis.SymbolKind
                f_10957_29705_29715(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 29705, 29715);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_10957_29786_29822(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 29786, 29822);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_10957_29905_29944(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 29905, 29944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_10957_30008_30030(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 30008, 30030);
                    return return_v;
                }


                bool
                f_10957_30008_30097(Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 30008, 30097);
                    return return_v;
                }


                int
                f_10957_30131_30171(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 30131, 30171);
                    return 0;
                }


                int
                f_10957_30429_30466(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 30429, 30466);
                    return 0;
                }


                int
                f_10957_30493_30503(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 30493, 30503);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10957_30652_30664(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 30652, 30664);
                    return return_v;
                }


                int
                f_10957_30816_30861(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ITypeParameterSymbol
                symbol)
                {
                    this_param.AddTypeParameterVarianceIfRequired(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 30816, 30861);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10957_30900_30920(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 30900, 30920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10957_31029_31064(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitorNamespaceOrType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 31029, 31064);
                    return return_v;
                }


                int
                f_10957_31112_31135(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 31112, 31135);
                    return 0;
                }


                bool
                f_10957_31164_31184_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 31164, 31184);
                    return return_v;
                }


                int
                f_10957_31234_31318(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, bool
                leadingSpace, bool
                trailingSpace)
                {
                    this_param.AddCustomModifiersIfRequired(customModifiers, leadingSpace: leadingSpace, trailingSpace: trailingSpace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 31234, 31318);
                    return 0;
                }


                int
                f_10957_31381_31424(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 31381, 31424);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 29516, 31451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 29516, 31451);
            }
        }

        private static bool TypeParameterHasConstraints(ITypeParameterSymbol typeParam)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10957, 31463, 31802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 31567, 31791);

                return f_10957_31574_31608_M(!typeParam.ConstraintTypes.IsEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(10957, 31574, 31646) || f_10957_31612_31646(typeParam)) || (DynAbs.Tracing.TraceSender.Expression_False(10957, 31574, 31703) || f_10957_31667_31703(typeParam)) || (DynAbs.Tracing.TraceSender.Expression_False(10957, 31574, 31739) || f_10957_31707_31739(typeParam)) || (DynAbs.Tracing.TraceSender.Expression_False(10957, 31574, 31790) || f_10957_31760_31790(typeParam));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10957, 31463, 31802);

                bool
                f_10957_31574_31608_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 31574, 31608);
                    return return_v;
                }


                bool
                f_10957_31612_31646(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasConstructorConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 31612, 31646);
                    return return_v;
                }


                bool
                f_10957_31667_31703(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 31667, 31703);
                    return return_v;
                }


                bool
                f_10957_31707_31739(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 31707, 31739);
                    return return_v;
                }


                bool
                f_10957_31760_31790(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasNotNullConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 31760, 31790);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 31463, 31802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 31463, 31802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddTypeParameterConstraints(ImmutableArray<ITypeSymbol> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10957, 31814, 36484);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 31922, 36473) || true) && (this.isFirstSymbolVisited && (DynAbs.Tracing.TraceSender.Expression_True(10957, 31926, 32045) && f_10957_31955_32045(f_10957_31955_31977(format), SymbolDisplayGenericsOptions.IncludeTypeConstraints)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 31922, 36473);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32079, 36458);
                        foreach (var typeArg in f_10957_32103_32116_I(typeArguments))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 32079, 36458);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32158, 36439) || true) && (f_10957_32162_32174(typeArg) == SymbolKind.TypeParameter)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 32158, 36439);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32252, 32298);

                                var
                                typeParam = (ITypeParameterSymbol)typeArg
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32326, 36416) || true) && (f_10957_32330_32368(typeParam))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 32326, 36416);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32426, 32437);

                                    f_10957_32426_32436(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32467, 32503);

                                    f_10957_32467_32502(this, SyntaxKind.WhereKeyword);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32533, 32544);

                                    f_10957_32533_32543(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32576, 32615);

                                    f_10957_32576_32614(
                                                                typeParam, f_10957_32593_32613(this));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32647, 32658);

                                    f_10957_32647_32657(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32688, 32726);

                                    f_10957_32688_32725(this, SyntaxKind.ColonToken);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32756, 32767);

                                    f_10957_32756_32766(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32799, 32822);

                                    bool
                                    needComma = false
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 32923, 35124) || true) && (f_10957_32927_32963(typeParam))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 32923, 35124);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 33029, 33065);

                                        f_10957_33029_33064(this, SyntaxKind.ClassKeyword);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 33101, 34176);

                                        switch (f_10957_33109_33160(typeParam))
                                        {

                                            case CodeAnalysis.NullableAnnotation.Annotated:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 33101, 34176);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 33323, 33615) || true) && (f_10957_33327_33441(f_10957_33327_33354(format), SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 33323, 33615);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 33531, 33572);

                                                    f_10957_33531_33571(this, SyntaxKind.QuestionToken);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 33323, 33615);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceBreak(10957, 33657, 33663);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 33101, 34176);

                                            case CodeAnalysis.NullableAnnotation.NotAnnotated:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 33101, 34176);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 33795, 34093) || true) && (f_10957_33799_33916(f_10957_33799_33826(format), SymbolDisplayMiscellaneousOptions.IncludeNotNullableReferenceTypeModifier))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 33795, 34093);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 34006, 34050);

                                                    f_10957_34006_34049(this, SyntaxKind.ExclamationToken);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 33795, 34093);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceBreak(10957, 34135, 34141);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 33101, 34176);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 34212, 34229);

                                        needComma = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 32923, 35124);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 32923, 35124);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 34295, 35124) || true) && (f_10957_34299_34335(typeParam))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 34295, 35124);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 34401, 34486);

                                            f_10957_34401_34485(builder, f_10957_34413_34484(SymbolDisplayPartKind.Keyword, null, "unmanaged"));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 34520, 34537);

                                            needComma = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 34295, 35124);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 34295, 35124);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 34603, 35124) || true) && (f_10957_34607_34639(typeParam))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 34603, 35124);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 34705, 34742);

                                                f_10957_34705_34741(this, SyntaxKind.StructKeyword);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 34776, 34793);

                                                needComma = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 34603, 35124);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 34603, 35124);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 34859, 35124) || true) && (f_10957_34863_34893(typeParam))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 34859, 35124);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 34959, 35042);

                                                    f_10957_34959_35041(builder, f_10957_34971_35040(SymbolDisplayPartKind.Keyword, null, "notnull"));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35076, 35093);

                                                    needComma = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 34859, 35124);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 34603, 35124);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 34295, 35124);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 32923, 35124);
                                    }
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35165, 35170);

                                        for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35156, 35730) || true) && (i < typeParam.ConstraintTypes.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35210, 35213)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 35156, 35730))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 35156, 35730);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35279, 35331);

                                            ITypeSymbol
                                            baseType = f_10957_35302_35327(typeParam)[i]
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35365, 35574) || true) && (needComma)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 35365, 35574);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35452, 35490);

                                                f_10957_35452_35489(this, SyntaxKind.CommaToken);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35528, 35539);

                                                f_10957_35528_35538(this);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 35365, 35574);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35610, 35648);

                                            f_10957_35610_35647(
                                                                            baseType, f_10957_35626_35646(this));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35682, 35699);

                                            needComma = true;
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10957, 1, 575);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10957, 1, 575);
                                    }
                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35822, 36389) || true) && (f_10957_35826_35860(typeParam))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 35822, 36389);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 35926, 36135) || true) && (needComma)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10957, 35926, 36135);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 36013, 36051);

                                            f_10957_36013_36050(this, SyntaxKind.CommaToken);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 36089, 36100);

                                            f_10957_36089_36099(this);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 35926, 36135);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 36171, 36205);

                                        f_10957_36171_36204(this, SyntaxKind.NewKeyword);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 36239, 36281);

                                        f_10957_36239_36280(this, SyntaxKind.OpenParenToken);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10957, 36315, 36358);

                                        f_10957_36315_36357(this, SyntaxKind.CloseParenToken);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 35822, 36389);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 32326, 36416);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 32158, 36439);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 32079, 36458);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10957, 1, 4380);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10957, 1, 4380);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10957, 31922, 36473);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10957, 31814, 36484);

                Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                f_10957_31955_31977(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GenericsOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 31955, 31977);
                    return return_v;
                }


                bool
                f_10957_31955_32045(Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 31955, 32045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10957_32162_32174(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 32162, 32174);
                    return return_v;
                }


                bool
                f_10957_32330_32368(Microsoft.CodeAnalysis.ITypeParameterSymbol
                typeParam)
                {
                    var return_v = TypeParameterHasConstraints(typeParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 32330, 32368);
                    return return_v;
                }


                int
                f_10957_32426_32436(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 32426, 32436);
                    return 0;
                }


                int
                f_10957_32467_32502(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 32467, 32502);
                    return 0;
                }


                int
                f_10957_32533_32543(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 32533, 32543);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10957_32593_32613(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 32593, 32613);
                    return return_v;
                }


                int
                f_10957_32576_32614(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 32576, 32614);
                    return 0;
                }


                int
                f_10957_32647_32657(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 32647, 32657);
                    return 0;
                }


                int
                f_10957_32688_32725(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 32688, 32725);
                    return 0;
                }


                int
                f_10957_32756_32766(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 32756, 32766);
                    return 0;
                }


                bool
                f_10957_32927_32963(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 32927, 32963);
                    return return_v;
                }


                int
                f_10957_33029_33064(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 33029, 33064);
                    return 0;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10957_33109_33160(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ReferenceTypeConstraintNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 33109, 33160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10957_33327_33354(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 33327, 33354);
                    return return_v;
                }


                bool
                f_10957_33327_33441(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 33327, 33441);
                    return return_v;
                }


                int
                f_10957_33531_33571(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 33531, 33571);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10957_33799_33826(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 33799, 33826);
                    return return_v;
                }


                bool
                f_10957_33799_33916(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 33799, 33916);
                    return return_v;
                }


                int
                f_10957_34006_34049(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 34006, 34049);
                    return 0;
                }


                bool
                f_10957_34299_34335(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasUnmanagedTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 34299, 34335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_34413_34484(Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol?
                symbol, string
                text)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayPart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 34413, 34484);
                    return return_v;
                }


                int
                f_10957_34401_34485(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 34401, 34485);
                    return 0;
                }


                bool
                f_10957_34607_34639(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 34607, 34639);
                    return return_v;
                }


                int
                f_10957_34705_34741(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 34705, 34741);
                    return 0;
                }


                bool
                f_10957_34863_34893(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasNotNullConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 34863, 34893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10957_34971_35040(Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol?
                symbol, string
                text)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayPart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 34971, 35040);
                    return return_v;
                }


                int
                f_10957_34959_35041(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 34959, 35041);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_10957_35302_35327(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 35302, 35327);
                    return return_v;
                }


                int
                f_10957_35452_35489(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 35452, 35489);
                    return 0;
                }


                int
                f_10957_35528_35538(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 35528, 35538);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10957_35626_35646(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 35626, 35646);
                    return return_v;
                }


                int
                f_10957_35610_35647(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 35610, 35647);
                    return 0;
                }


                bool
                f_10957_35826_35860(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasConstructorConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10957, 35826, 35860);
                    return return_v;
                }


                int
                f_10957_36013_36050(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 36013, 36050);
                    return 0;
                }


                int
                f_10957_36089_36099(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 36089, 36099);
                    return 0;
                }


                int
                f_10957_36171_36204(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 36171, 36204);
                    return 0;
                }


                int
                f_10957_36239_36280(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 36239, 36280);
                    return 0;
                }


                int
                f_10957_36315_36357(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 36315, 36357);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_10957_32103_32116_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10957, 32103, 32116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10957, 31814, 36484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10957, 31814, 36484);
            }
        }
    }
}
