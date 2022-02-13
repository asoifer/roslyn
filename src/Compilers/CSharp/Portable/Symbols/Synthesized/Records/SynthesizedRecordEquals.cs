// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordEquals : SynthesizedRecordOrdinaryMethod
    {
        private readonly PropertySymbol _equalityContract;

        public SynthesizedRecordEquals(SourceMemberContainerTypeSymbol containingType, PropertySymbol equalityContract, int memberOffset, DiagnosticBag diagnostics)
        : base(f_10725_1119_1133_C(containingType), WellKnownMemberNames.ObjectEquals, hasBody: true, memberOffset, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10725, 942, 1284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 912, 929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 1236, 1273);

                _equalityContract = equalityContract;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10725, 942, 1284);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10725, 942, 1284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10725, 942, 1284);
            }
        }

        protected override DeclarationModifiers MakeDeclarationModifiers(DeclarationModifiers allowedModifiers, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10725, 1296, 1697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 1451, 1596);

                DeclarationModifiers
                result = DeclarationModifiers.Public | ((DynAbs.Tracing.TraceSender.Conditional_F1(10725, 1512, 1535) || ((f_10725_1512_1535(f_10725_1512_1526()) && DynAbs.Tracing.TraceSender.Conditional_F2(10725, 1538, 1563)) || DynAbs.Tracing.TraceSender.Conditional_F3(10725, 1566, 1594))) ? DeclarationModifiers.None : DeclarationModifiers.Virtual)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 1610, 1658);

                f_10725_1610_1657((result & ~allowedModifiers) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 1672, 1686);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10725, 1296, 1697);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_1512_1526()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 1512, 1526);
                    return return_v;
                }


                bool
                f_10725_1512_1535(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 1512, 1535);
                    return return_v;
                }


                int
                f_10725_1610_1657(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 1610, 1657);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10725, 1296, 1697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10725, 1296, 1697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters, bool IsVararg, ImmutableArray<TypeParameterConstraintClause> DeclaredConstraintsForOverrideOrImplementation) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10725, 1709, 2837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 1997, 2036);

                var
                compilation = f_10725_2015_2035()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 2050, 2084);

                var
                location = f_10725_2065_2083()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 2098, 2826);

                return (ReturnType: TypeWithAnnotations.Create(f_10725_2145_2230(compilation, SpecialType.System_Boolean, location, diagnostics)),
                                    Parameters: f_10725_2266_2664(f_10725_2343_2663(owner: this, TypeWithAnnotations.Create(f_10725_2484_2498(), NullableAnnotation.Annotated), ordinal: 0, RefKind.None, "other", isDiscard: false, f_10725_2653_2662())),
                                    IsVararg: false,
                                    DeclaredConstraintsForOverrideOrImplementation: ImmutableArray<TypeParameterConstraintClause>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10725, 1709, 2837);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10725_2015_2035()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 2015, 2035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10725_2065_2083()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 2065, 2083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_2145_2230(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 2145, 2230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_2484_2498()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 2484, 2498);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10725_2653_2662()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 2653, 2662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                f_10725_2343_2663(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEquals
                owner, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, bool
                isDiscard, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol(owner: (Microsoft.CodeAnalysis.CSharp.Symbol)owner, parameterType, ordinal: ordinal, refKind, name, isDiscard: isDiscard, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 2343, 2663);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10725_2266_2664(Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<ParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 2266, 2664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10725, 1709, 2837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10725, 1709, 2837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10725, 2902, 2906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 2905, 2906);
                return 1; DynAbs.Tracing.TraceSender.TraceExitMethod(10725, 2902, 2906);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10725, 2902, 2906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10725, 2902, 2906);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10725, 2919, 8407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 3051, 3165);

                var
                F = f_10725_3059_3164(this, f_10725_3095_3132(f_10725_3095_3109()), compilationState, diagnostics)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 3217, 3256);

                    var
                    other = f_10725_3229_3255(F, f_10725_3241_3251()[0])
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 3274, 3299);

                    BoundExpression?
                    retExpr
                    = default(BoundExpression?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 3458, 6739) || true) && (f_10725_3462_3520(f_10725_3462_3505(f_10725_3462_3476())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10725, 3458, 6739);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 3562, 3832) || true) && (f_10725_3566_3593(_equalityContract) is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10725, 3562, 3832);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 3747, 3776);

                            f_10725_3747_3775(                        // The equality contract isn't usable, an error was reported elsewhere
                                                    F, f_10725_3761_3774(F));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 3802, 3809);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10725, 3562, 3832);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 3856, 4246) || true) && (f_10725_3860_3886(_equalityContract) || (DynAbs.Tracing.TraceSender.Expression_False(10725, 3860, 4020) || !f_10725_3891_4020(f_10725_3891_3913(_equalityContract), f_10725_3921_3985(f_10725_3921_3941(), WellKnownType.System_Type), TypeCompareKind.AllIgnoreOptions)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10725, 3856, 4246);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 4161, 4190);

                            f_10725_4161_4189(                        // There is a signature mismatch, an error was reported elsewhere
                                                    F, f_10725_4175_4188(F));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 4216, 4223);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10725, 3856, 4246);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 4717, 4758);

                        f_10725_4717_4757(!f_10725_4731_4756(f_10725_4731_4741(other)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 4780, 4864);

                        retExpr = f_10725_4790_4863(F, other, f_10725_4814_4862(F, f_10725_4821_4861(F, SpecialType.System_Object)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 4955, 5237);

                        var
                        contractsEqual = f_10725_4976_5236(F, receiver: null, f_10725_4999_5058(F, WellKnownMember.System_Type__op_Equality), f_10725_5109_5148(F, f_10725_5120_5128(F), _equalityContract), f_10725_5199_5235(F, other, _equalityContract))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 5261, 5309);

                        retExpr = f_10725_5271_5308(F, retExpr, contractsEqual);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10725, 3458, 6739);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10725, 3458, 6739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 5391, 5519);

                        MethodSymbol?
                        baseEquals = f_10725_5418_5518(f_10725_5418_5501(f_10725_5418_5454(f_10725_5418_5432()).OfType<SynthesizedRecordBaseEquals>()))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 5543, 6020) || true) && (baseEquals is null || (DynAbs.Tracing.TraceSender.Expression_False(10725, 5547, 5681) || !f_10725_5570_5681(f_10725_5570_5595(baseEquals), f_10725_5603_5646(f_10725_5603_5617()), TypeCompareKind.AllIgnoreOptions)) || (DynAbs.Tracing.TraceSender.Expression_False(10725, 5547, 5773) || f_10725_5710_5743(f_10725_5710_5731(baseEquals)) != SpecialType.System_Boolean))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10725, 5543, 6020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 5935, 5964);

                            f_10725_5935_5963(                        // There was a problem with overriding of base equals, an error was reported elsewhere
                                                    F, f_10725_5949_5962(F));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 5990, 5997);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10725, 5543, 6020);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 6531, 6720);

                        retExpr = f_10725_6541_6719(F, f_10725_6574_6607(F, f_10725_6581_6606(baseEquals)), baseEquals, f_10725_6671_6718(F, f_10725_6681_6710(f_10725_6681_6702(baseEquals)[0]), other));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10725, 3458, 6739);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 6835, 6888);

                    var
                    fields = f_10725_6848_6887()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 6906, 6933);

                    bool
                    foundBadField = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 6951, 7788);
                        foreach (var f in f_10725_6969_7001_I(f_10725_6969_7001(f_10725_6969_6983())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10725, 6951, 7788);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 7043, 7769) || true) && (f_10725_7047_7058_M(!f.IsStatic))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10725, 7043, 7769);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 7108, 7122);

                                f_10725_7108_7121(fields, f);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 7150, 7177);

                                var
                                parameterType = f_10725_7170_7176(f)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 7203, 7746) || true) && (f_10725_7207_7231(parameterType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10725, 7203, 7746);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 7289, 7383);

                                    f_10725_7289_7382(diagnostics, ErrorCode.ERR_BadFieldTypeInRecord, f.Locations.FirstOrNone(), parameterType);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 7413, 7434);

                                    foundBadField = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10725, 7203, 7746);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10725, 7203, 7746);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 7492, 7746) || true) && (f_10725_7496_7528(parameterType))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10725, 7492, 7746);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 7698, 7719);

                                        foundBadField = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10725, 7492, 7746);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10725, 7203, 7746);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10725, 7043, 7769);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10725, 6951, 7788);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10725, 1, 838);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10725, 1, 838);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 7806, 8085) || true) && (f_10725_7810_7822(fields) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10725, 7810, 7844) && !foundBadField))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10725, 7806, 8085);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 7886, 8066);

                        retExpr = f_10725_7896_8065(retExpr, other, fields, F);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10725, 7806, 8085);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 8105, 8119);

                    f_10725_8105_8118(
                                    fields);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 8139, 8181);

                    f_10725_8139_8180(
                                    F, f_10725_8153_8179(F, f_10725_8161_8178(F, retExpr)));
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10725, 8210, 8396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 8303, 8334);

                    f_10725_8303_8333(diagnostics, f_10725_8319_8332(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10725, 8352, 8381);

                    f_10725_8352_8380(F, f_10725_8366_8379(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10725, 8210, 8396);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10725, 2919, 8407);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_3095_3109()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 3095, 3109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10725_3095_3132(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 3095, 3132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10725_3059_3164(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEquals
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 3059, 3164);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10725_3241_3251()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 3241, 3251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10725_3229_3255(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 3229, 3255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_3462_3476()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 3462, 3476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_3462_3505(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 3462, 3505);
                    return return_v;
                }


                bool
                f_10725_3462_3520(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 3462, 3520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10725_3566_3593(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 3566, 3593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10725_3761_3774(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 3761, 3774);
                    return return_v;
                }


                int
                f_10725_3747_3775(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 3747, 3775);
                    return 0;
                }


                bool
                f_10725_3860_3886(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 3860, 3886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10725_3891_3913(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 3891, 3913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10725_3921_3941()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 3921, 3941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_3921_3985(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 3921, 3985);
                    return return_v;
                }


                bool
                f_10725_3891_4020(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 3891, 4020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10725_4175_4188(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 4175, 4188);
                    return return_v;
                }


                int
                f_10725_4161_4189(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 4161, 4189);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10725_4731_4741(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 4731, 4741);
                    return return_v;
                }


                bool
                f_10725_4731_4756(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 4731, 4756);
                    return return_v;
                }


                int
                f_10725_4717_4757(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 4717, 4757);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_4821_4861(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 4821, 4861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10725_4814_4862(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 4814, 4862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10725_4790_4863(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.ObjectNotEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 4790, 4863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10725_4999_5058(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 4999, 5058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10725_5120_5128(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 5120, 5128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10725_5109_5148(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = this_param.Property((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 5109, 5148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10725_5199_5235(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = this_param.Property((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 5199, 5235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10725_4976_5236(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg0, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg1)
                {
                    var return_v = this_param.Call(receiver: receiver, method, arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 4976, 5236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10725_5271_5308(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundCall
                right)
                {
                    var return_v = this_param.LogicalAnd(left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 5271, 5308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_5418_5432()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 5418, 5432);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10725_5418_5454(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 5418, 5454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordBaseEquals
                f_10725_5418_5501(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordBaseEquals>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordBaseEquals>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 5418, 5501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10725_5418_5518(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordBaseEquals
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 5418, 5518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_5570_5595(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 5570, 5595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_5603_5617()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 5603, 5617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_5603_5646(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 5603, 5646);
                    return return_v;
                }


                bool
                f_10725_5570_5681(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 5570, 5681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10725_5710_5731(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 5710, 5731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10725_5710_5743(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 5710, 5743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10725_5949_5962(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 5949, 5962);
                    return return_v;
                }


                int
                f_10725_5935_5963(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 5935, 5963);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_6581_6606(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 6581, 6606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                f_10725_6574_6607(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                baseType)
                {
                    var return_v = this_param.Base(baseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 6574, 6607);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10725_6681_6702(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 6681, 6702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10725_6681_6710(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 6681, 6710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10725_6671_6718(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundParameter
                arg)
                {
                    var return_v = this_param.Convert(type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 6671, 6718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10725_6541_6719(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg0)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 6541, 6719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10725_6848_6887()
                {
                    var return_v = ArrayBuilder<FieldSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 6848, 6887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10725_6969_6983()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 6969, 6983);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10725_6969_7001(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetFieldsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 6969, 7001);
                    return return_v;
                }


                bool
                f_10725_7047_7058_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 7047, 7058);
                    return return_v;
                }


                int
                f_10725_7108_7121(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 7108, 7121);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10725_7170_7176(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 7170, 7176);
                    return return_v;
                }


                bool
                f_10725_7207_7231(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsUnsafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 7207, 7231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10725_7289_7382(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 7289, 7382);
                    return return_v;
                }


                bool
                f_10725_7496_7528(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 7496, 7528);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10725_6969_7001_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 6969, 7001);
                    return return_v;
                }


                int
                f_10725_7810_7822(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 7810, 7822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10725_7896_8065(Microsoft.CodeAnalysis.CSharp.BoundExpression
                initialExpression, Microsoft.CodeAnalysis.CSharp.BoundParameter
                otherReceiver, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                fields, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F)
                {
                    var return_v = MethodBodySynthesizer.GenerateFieldEquals(initialExpression, (Microsoft.CodeAnalysis.CSharp.BoundExpression)otherReceiver, fields, F);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 7896, 8065);
                    return return_v;
                }


                int
                f_10725_8105_8118(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 8105, 8118);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10725_8161_8178(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Return(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 8161, 8178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10725_8153_8179(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 8153, 8179);
                    return return_v;
                }


                int
                f_10725_8139_8180(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 8139, 8180);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10725_8319_8332(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10725, 8319, 8332);
                    return return_v;
                }


                int
                f_10725_8303_8333(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 8303, 8333);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10725_8366_8379(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 8366, 8379);
                    return return_v;
                }


                int
                f_10725_8352_8380(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10725, 8352, 8380);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10725, 2919, 8407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10725, 2919, 8407);
            }
        }

        static SynthesizedRecordEquals()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10725, 784, 8414);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10725, 784, 8414);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10725, 784, 8414);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10725, 784, 8414);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10725_1119_1133_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10725, 942, 1284);
            return return_v;
        }

    }
}
