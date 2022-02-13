// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordClone : SynthesizedRecordOrdinaryMethod
    {
        public SynthesizedRecordClone(
                    SourceMemberContainerTypeSymbol containingType,
                    int memberOffset,
                    DiagnosticBag diagnostics)
        : base(f_10718_1459_1473_C(containingType), WellKnownMemberNames.CloneMethodName, hasBody: f_10718_1522_1548_M(!containingType.IsAbstract), memberOffset, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10718, 1276, 1598);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10718, 1276, 1598);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10718, 1276, 1598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10718, 1276, 1598);
            }
        }

        protected override DeclarationModifiers MakeDeclarationModifiers(DeclarationModifiers allowedModifiers, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10718, 1610, 3516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 1765, 1823);

                DeclarationModifiers
                result = DeclarationModifiers.Public
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 1839, 2121) || true) && (f_10718_1843_1863(this) is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 1839, 2121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 1907, 1947);

                    result |= DeclarationModifiers.Override;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 1839, 2121);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 1839, 2121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2013, 2106);

                    result |= (DynAbs.Tracing.TraceSender.Conditional_F1(10718, 2023, 2046) || ((f_10718_2023_2046(f_10718_2023_2037()) && DynAbs.Tracing.TraceSender.Conditional_F2(10718, 2049, 2074)) || DynAbs.Tracing.TraceSender.Conditional_F3(10718, 2077, 2105))) ? DeclarationModifiers.None : DeclarationModifiers.Virtual;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 1839, 2121);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2137, 2313) || true) && (f_10718_2141_2166(f_10718_2141_2155()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 2137, 2313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2200, 2240);

                    result &= ~DeclarationModifiers.Virtual;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2258, 2298);

                    result |= DeclarationModifiers.Abstract;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 2137, 2313);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2329, 2377);

                f_10718_2329_2376((result & ~allowedModifiers) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2402, 2442);

                f_10718_2402_2441(f_10718_2415_2440(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2465, 2479);

                return result;

                static bool modifiersAreValid(DeclarationModifiers modifiers)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10718, 2506, 3496);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2600, 2761) || true) && ((modifiers & DeclarationModifiers.AccessibilityMask) != DeclarationModifiers.Public)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 2600, 2761);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2729, 2742);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 2600, 2761);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2781, 2834);

                        modifiers &= ~DeclarationModifiers.AccessibilityMask;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2854, 3481);

                        switch (modifiers)
                        {

                            case DeclarationModifiers.None:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 2854, 3481);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 2970, 2982);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 2854, 3481);

                            case DeclarationModifiers.Abstract:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 2854, 3481);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 3065, 3077);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 2854, 3481);

                            case DeclarationModifiers.Override:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 2854, 3481);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 3160, 3172);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 2854, 3481);

                            case DeclarationModifiers.Abstract | DeclarationModifiers.Override:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 2854, 3481);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 3287, 3299);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 2854, 3481);

                            case DeclarationModifiers.Virtual:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 2854, 3481);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 3381, 3393);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 2854, 3481);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 2854, 3481);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 3449, 3462);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 2854, 3481);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10718, 2506, 3496);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10718, 2506, 3496);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10718, 2506, 3496);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10718, 1610, 3516);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10718_1843_1863(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordClone
                this_param)
                {
                    var return_v = this_param.VirtualCloneInBase();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 1843, 1863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10718_2023_2037()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 2023, 2037);
                    return return_v;
                }


                bool
                f_10718_2023_2046(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 2023, 2046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10718_2141_2155()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 2141, 2155);
                    return return_v;
                }


                bool
                f_10718_2141_2166(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 2141, 2166);
                    return return_v;
                }


                int
                f_10718_2329_2376(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 2329, 2376);
                    return 0;
                }


                bool
                f_10718_2415_2440(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers)
                {
                    var return_v = modifiersAreValid(modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 2415, 2440);
                    return return_v;
                }


                int
                f_10718_2402_2441(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 2402, 2441);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10718, 1610, 3516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10718, 1610, 3516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodSymbol? VirtualCloneInBase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10718, 3528, 3982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 3595, 3666);

                NamedTypeSymbol
                baseType = f_10718_3622_3665(f_10718_3622_3636())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 3682, 3943) || true) && (!f_10718_3687_3710(baseType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 3682, 3943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 3744, 3802);

                    HashSet<DiagnosticInfo>?
                    ignoredUseSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 3859, 3928);

                    return f_10718_3866_3927(baseType, ref ignoredUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 3682, 3943);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 3959, 3971);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10718, 3528, 3982);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10718_3622_3636()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 3622, 3636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10718_3622_3665(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 3622, 3665);
                    return return_v;
                }


                bool
                f_10718_3687_3710(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 3687, 3710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10718_3866_3927(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = FindValidCloneMethod((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)containingType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 3866, 3927);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10718, 3528, 3982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10718, 3528, 3982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters, bool IsVararg, ImmutableArray<TypeParameterConstraintClause> DeclaredConstraintsForOverrideOrImplementation) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10718, 3994, 4808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 4282, 4797);

                // LAFHIS
                DynAbs.Tracing.TraceSender.Conditional_F1(10718, 4302, 4339);
                var temp = f_10718_4302_4322(this);
                return (ReturnType: ((temp is { } baseClone && DynAbs.Tracing.TraceSender.Conditional_F2(10718, 4380, 4415)) || DynAbs.Tracing.TraceSender.Conditional_F3(10718, 4496, 4563)) ? f_10718_4380_4415(temp) : TypeWithAnnotations.Create(isNullableEnabled: true, f_10718_4548_4562()),
                                    Parameters: ImmutableArray<ParameterSymbol>.Empty,
                                    IsVararg: false,
                                    DeclaredConstraintsForOverrideOrImplementation: ImmutableArray<TypeParameterConstraintClause>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10718, 3994, 4808);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10718_4302_4322(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordClone
                this_param)
                {
                    var return_v = this_param.VirtualCloneInBase();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 4302, 4322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10718_4380_4415(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 4380, 4415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10718_4548_4562()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 4548, 4562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10718, 3994, 4808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10718, 3994, 4808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10718, 4873, 4877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 4876, 4877);
                return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10718, 4873, 4877);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10718, 4873, 4877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10718, 4873, 4877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10718, 4890, 6229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5022, 5048);

                f_10718_5022_5047(f_10718_5035_5046_M(!IsAbstract));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5064, 5178);

                var
                F = f_10718_5072_5177(this, f_10718_5108_5145(f_10718_5108_5122()), compilationState, diagnostics)
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5230, 5377) || true) && (f_10718_5234_5258(f_10718_5234_5244()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 5230, 5377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5300, 5329);

                        f_10718_5300_5328(F, f_10718_5314_5327(F));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5351, 5358);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 5230, 5377);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5397, 5447);

                    var
                    members = f_10718_5411_5446(f_10718_5411_5425())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5465, 5946);
                        foreach (var member in f_10718_5488_5495_I(members))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 5465, 5946);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5537, 5569);

                            var
                            ctor = (MethodSymbol)member
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5591, 5927) || true) && (f_10718_5595_5614(ctor) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10718, 5595, 5665) && f_10718_5623_5649(f_10718_5623_5638(ctor)[0]) == RefKind.None) && (DynAbs.Tracing.TraceSender.Expression_True(10718, 5595, 5774) && f_10718_5694_5774(f_10718_5694_5717(f_10718_5694_5709(ctor)[0]), f_10718_5725_5739(), TypeCompareKind.AllIgnoreOptions)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 5591, 5927);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5824, 5871);

                                f_10718_5824_5870(F, f_10718_5838_5869(F, f_10718_5847_5868(F, ctor, f_10718_5859_5867(F))));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5897, 5904);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 5591, 5927);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 5465, 5946);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10718, 1, 482);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10718, 1, 482);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 5966, 6003);

                    throw f_10718_5972_6002();
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10718, 6032, 6218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 6125, 6156);

                    f_10718_6125_6155(diagnostics, f_10718_6141_6154(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 6174, 6203);

                    f_10718_6174_6202(F, f_10718_6188_6201(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10718, 6032, 6218);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10718, 4890, 6229);

                bool
                f_10718_5035_5046_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5035, 5046);
                    return return_v;
                }


                int
                f_10718_5022_5047(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5022, 5047);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10718_5108_5122()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5108, 5122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10718_5108_5145(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5108, 5145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10718_5072_5177(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordClone
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5072, 5177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10718_5234_5244()
                {
                    var return_v = ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5234, 5244);
                    return return_v;
                }


                bool
                f_10718_5234_5258(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5234, 5258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10718_5314_5327(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5314, 5327);
                    return return_v;
                }


                int
                f_10718_5300_5328(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5300, 5328);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10718_5411_5425()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5411, 5425);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10718_5411_5446(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5411, 5446);
                    return return_v;
                }


                int
                f_10718_5595_5614(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5595, 5614);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10718_5623_5638(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5623, 5638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10718_5623_5649(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5623, 5649);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10718_5694_5709(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5694, 5709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10718_5694_5717(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5694, 5717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10718_5725_5739()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5725, 5739);
                    return return_v;
                }


                bool
                f_10718_5694_5774(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5694, 5774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10718_5859_5867(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5859, 5867);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10718_5847_5868(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.New(ctor, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5847, 5868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10718_5838_5869(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5838, 5869);
                    return return_v;
                }


                int
                f_10718_5824_5870(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5824, 5870);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10718_5488_5495_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 5488, 5495);
                    return return_v;
                }


                System.Exception
                f_10718_5972_6002()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 5972, 6002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10718_6141_6154(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 6141, 6154);
                    return return_v;
                }


                int
                f_10718_6125_6155(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 6125, 6155);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10718_6188_6201(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 6188, 6201);
                    return return_v;
                }


                int
                f_10718_6174_6202(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 6174, 6202);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10718, 4890, 6229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10718, 4890, 6229);
            }
        }

        internal static MethodSymbol? FindValidCloneMethod(TypeSymbol containingType, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10718, 6241, 8323);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 6392, 6547) || true) && (f_10718_6396_6425(containingType) || (DynAbs.Tracing.TraceSender.Expression_False(10718, 6396, 6486) || containingType is not NamedTypeSymbol containingNamedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 6392, 6547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 6520, 6532);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 6392, 6547);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 6957, 7076) || true) && (!f_10718_6962_7015(containingNamedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 6957, 7076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 7049, 7061);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 6957, 7076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 7092, 7123);

                MethodSymbol?
                candidate = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 7139, 7860);
                    foreach (var member in f_10718_7162_7225_I(f_10718_7162_7225(containingType, WellKnownMemberNames.CloneMethodName)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 7139, 7860);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 7259, 7845) || true) && (member is MethodSymbol
                            {
                                DeclaredAccessibility: Accessibility.Public,
                                IsStatic: false,
                                ParameterCount: 0,
                                Arity: 0
                            } method)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 7259, 7845);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 7570, 7783) || true) && (candidate is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 7570, 7783);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 7748, 7760);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 7570, 7783);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 7807, 7826);

                            candidate = method;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 7259, 7845);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 7139, 7860);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10718, 1, 722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10718, 1, 722);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 7876, 8279) || true) && (candidate is null || (DynAbs.Tracing.TraceSender.Expression_False(10718, 7880, 8015) || !(f_10718_7920_7943(containingType) || (DynAbs.Tracing.TraceSender.Expression_False(10718, 7920, 7967) || f_10718_7947_7967(candidate)) || (DynAbs.Tracing.TraceSender.Expression_False(10718, 7920, 7990) || f_10718_7971_7990(candidate)) || (DynAbs.Tracing.TraceSender.Expression_False(10718, 7920, 8014) || f_10718_7994_8014(candidate)))) || (DynAbs.Tracing.TraceSender.Expression_False(10718, 7880, 8218) || !f_10718_8037_8218(containingType, f_10718_8097_8117(candidate), TypeCompareKind.AllIgnoreOptions, ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10718, 7876, 8279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 8252, 8264);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10718, 7876, 8279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10718, 8295, 8312);

                return candidate;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10718, 6241, 8323);

                bool
                f_10718_6396_6425(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 6396, 6425);
                    return return_v;
                }


                bool
                f_10718_6962_7015(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.HasPossibleWellKnownCloneMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 6962, 7015);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10718_7162_7225(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 7162, 7225);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10718_7162_7225_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 7162, 7225);
                    return return_v;
                }


                bool
                f_10718_7920_7943(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 7920, 7943);
                    return return_v;
                }


                bool
                f_10718_7947_7967(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 7947, 7967);
                    return return_v;
                }


                bool
                f_10718_7971_7990(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 7971, 7990);
                    return return_v;
                }


                bool
                f_10718_7994_8014(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 7994, 8014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10718_8097_8117(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 8097, 8117);
                    return return_v;
                }


                bool
                f_10718_8037_8218(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsEqualToOrDerivedFrom(type, comparison, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10718, 8037, 8218);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10718, 6241, 8323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10718, 6241, 8323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedRecordClone()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10718, 1181, 8330);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10718, 1181, 8330);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10718, 1181, 8330);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10718, 1181, 8330);

        static bool
        f_10718_1522_1548_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10718, 1522, 1548);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10718_1459_1473_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10718, 1276, 1598);
            return return_v;
        }

    }
}
