// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordPrintMembers : SynthesizedRecordOrdinaryMethod
    {
        public SynthesizedRecordPrintMembers(
                    SourceMemberContainerTypeSymbol containingType,
                    int memberOffset,
                    DiagnosticBag diagnostics)
        : base(f_10731_1169_1183_C(containingType), WellKnownMemberNames.PrintMembersMethodName, hasBody: true, memberOffset, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10731, 979, 1293);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10731, 979, 1293);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10731, 979, 1293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 979, 1293);
            }
        }

        protected override DeclarationModifiers MakeDeclarationModifiers(DeclarationModifiers allowedModifiers, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10731, 1305, 3364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 1460, 1659);

                var
                result = (DynAbs.Tracing.TraceSender.Conditional_F1(10731, 1473, 1560) || (((f_10731_1474_1532(f_10731_1474_1517(f_10731_1474_1488())) && (DynAbs.Tracing.TraceSender.Expression_True(10731, 1474, 1559) && f_10731_1536_1559(f_10731_1536_1550()))) && DynAbs.Tracing.TraceSender.Conditional_F2(10731, 1580, 1608)) || DynAbs.Tracing.TraceSender.Conditional_F3(10731, 1628, 1658))) ? DeclarationModifiers.Private : DeclarationModifiers.Protected
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 1675, 1957) || true) && (f_10731_1679_1699() is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 1675, 1957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 1743, 1783);

                    result |= DeclarationModifiers.Override;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 1675, 1957);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 1675, 1957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 1849, 1942);

                    result |= (DynAbs.Tracing.TraceSender.Conditional_F1(10731, 1859, 1882) || ((f_10731_1859_1882(f_10731_1859_1873()) && DynAbs.Tracing.TraceSender.Conditional_F2(10731, 1885, 1910)) || DynAbs.Tracing.TraceSender.Conditional_F3(10731, 1913, 1941))) ? DeclarationModifiers.None : DeclarationModifiers.Virtual;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 1675, 1957);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 1973, 2021);

                f_10731_1973_2020((result & ~allowedModifiers) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 2046, 2086);

                f_10731_2046_2085(f_10731_2059_2084(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 2108, 2122);

                return result;

                MethodSymbol? virtualPrintInBase()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10731, 2138, 2514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 2205, 2276);

                        NamedTypeSymbol
                        baseType = f_10731_2232_2275(f_10731_2232_2246())
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 2296, 2467) || true) && (!f_10731_2301_2324(baseType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 2296, 2467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 2366, 2448);

                            return f_10731_2373_2447(baseType, f_10731_2411_2446(f_10731_2411_2425()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 2296, 2467);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 2487, 2499);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10731, 2138, 2514);

                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10731_2232_2246()
                        {
                            var return_v = ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 2232, 2246);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10731_2232_2275(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 2232, 2275);
                            return return_v;
                        }


                        bool
                        f_10731_2301_2324(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        type)
                        {
                            var return_v = type.IsObjectType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 2301, 2324);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10731_2411_2425()
                        {
                            var return_v = ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 2411, 2425);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10731_2411_2446(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.DeclaringCompilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 2411, 2446);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        f_10731_2373_2447(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        containingType, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation)
                        {
                            var return_v = FindValidPrintMembersMethod((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)containingType, compilation);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 2373, 2447);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10731, 2138, 2514);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 2138, 2514);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static bool modifiersAreValid(DeclarationModifiers modifiers)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10731, 2541, 3345);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 2635, 2908) || true) && ((modifiers & DeclarationModifiers.AccessibilityMask) != DeclarationModifiers.Private && (DynAbs.Tracing.TraceSender.Expression_True(10731, 2639, 2834) && (modifiers & DeclarationModifiers.AccessibilityMask) != DeclarationModifiers.Protected))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 2635, 2908);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 2876, 2889);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 2635, 2908);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 2928, 2981);

                        modifiers &= ~DeclarationModifiers.AccessibilityMask;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 3001, 3330);

                        switch (modifiers)
                        {

                            case DeclarationModifiers.None:
                            case DeclarationModifiers.Override:
                            case DeclarationModifiers.Virtual:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 3001, 3330);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 3230, 3242);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 3001, 3330);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 3001, 3330);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 3298, 3311);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 3001, 3330);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10731, 2541, 3345);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10731, 2541, 3345);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 2541, 3345);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10731, 1305, 3364);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_1474_1488()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 1474, 1488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_1474_1517(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 1474, 1517);
                    return return_v;
                }


                bool
                f_10731_1474_1532(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 1474, 1532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_1536_1550()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 1536, 1550);
                    return return_v;
                }


                bool
                f_10731_1536_1559(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 1536, 1559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10731_1679_1699()
                {
                    var return_v = virtualPrintInBase();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 1679, 1699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_1859_1873()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 1859, 1873);
                    return return_v;
                }


                bool
                f_10731_1859_1882(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 1859, 1882);
                    return return_v;
                }


                int
                f_10731_1973_2020(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 1973, 2020);
                    return 0;
                }


                bool
                f_10731_2059_2084(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers)
                {
                    var return_v = modifiersAreValid(modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 2059, 2084);
                    return return_v;
                }


                int
                f_10731_2046_2085(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 2046, 2085);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10731, 1305, 3364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 1305, 3364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters, bool IsVararg, ImmutableArray<TypeParameterConstraintClause> DeclaredConstraintsForOverrideOrImplementation) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10731, 3376, 4503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 3664, 3703);

                var
                compilation = f_10731_3682_3702()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 3717, 3751);

                var
                location = f_10731_3732_3750()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 3765, 4492);

                return (ReturnType: TypeWithAnnotations.Create(f_10731_3812_3897(compilation, SpecialType.System_Boolean, location, diagnostics)),
                                    Parameters: f_10731_3933_4330(f_10731_3998_4329(owner: this, TypeWithAnnotations.Create(f_10731_4099_4199(compilation, WellKnownType.System_Text_StringBuilder, diagnostics, location), NullableAnnotation.NotAnnotated), ordinal: 0, RefKind.None, "builder", isDiscard: false, f_10731_4319_4328())),
                                    IsVararg: false,
                                    DeclaredConstraintsForOverrideOrImplementation: ImmutableArray<TypeParameterConstraintClause>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10731, 3376, 4503);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10731_3682_3702()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 3682, 3702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10731_3732_3750()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 3732, 3750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_3812_3897(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 3812, 3897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_4099_4199(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.GetWellKnownType(compilation, type, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 4099, 4199);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10731_4319_4328()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 4319, 4328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                f_10731_3998_4329(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordPrintMembers
                owner, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, bool
                isDiscard, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol(owner: (Microsoft.CodeAnalysis.CSharp.Symbol)owner, parameterType, ordinal: ordinal, refKind, name, isDiscard: isDiscard, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 3998, 4329);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10731_3933_4330(Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<ParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 3933, 4330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10731, 3376, 4503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 3376, 4503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10731, 4568, 4572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 4571, 4572);
                return 1; DynAbs.Tracing.TraceSender.TraceExitMethod(10731, 4568, 4572);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10731, 4568, 4572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 4568, 4572);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10731, 4585, 10329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 4717, 4831);

                var
                F = f_10731_4725_4830(this, f_10731_4761_4798(f_10731_4761_4775()), compilationState, diagnostics)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 4881, 4985);

                    ImmutableArray<Symbol>
                    printableMembers = f_10731_4923_4950(f_10731_4923_4937()).WhereAsArray(m => isPrintable(m))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 5005, 5246) || true) && (f_10731_5009_5033(f_10731_5009_5019()) || (DynAbs.Tracing.TraceSender.Expression_False(10731, 5009, 5127) || printableMembers.Any(m => m.GetTypeOrReturnType().Type.IsErrorType())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 5005, 5246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 5169, 5198);

                        f_10731_5169_5197(F, f_10731_5183_5196(F));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 5220, 5227);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 5005, 5246);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 5266, 5381);

                    ArrayBuilder<BoundStatement>?
                    block = (DynAbs.Tracing.TraceSender.Conditional_F1(10731, 5304, 5328) || ((printableMembers.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10731, 5331, 5335)) || DynAbs.Tracing.TraceSender.Conditional_F3(10731, 5338, 5380))) ? null : f_10731_5338_5380()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 5399, 5456);

                    BoundParameter
                    builder = f_10731_5424_5455(F, f_10731_5436_5451(this)[0])
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 5474, 6921) || true) && (f_10731_5478_5536(f_10731_5478_5521(f_10731_5478_5492())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 5474, 6921);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 5578, 5796) || true) && (printableMembers.IsEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 5578, 5796);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 5698, 5740);

                            f_10731_5698_5739(                        // return false;
                                                    F, f_10731_5712_5738(F, f_10731_5721_5737(F, false)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 5766, 5773);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 5578, 5796);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 5474, 6921);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 5474, 6921);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 5878, 6001);

                        MethodSymbol?
                        printMethod = f_10731_5906_6000(f_10731_5934_5977(f_10731_5934_5948()), f_10731_5979_5999())
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 6023, 6229) || true) && (printMethod is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 6023, 6229);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 6096, 6125);

                            f_10731_6096_6124(F, f_10731_6110_6123(F));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 6199, 6206);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 6023, 6229);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 6253, 6365);

                        var
                        basePrintCall = f_10731_6273_6364(F, receiver: f_10731_6290_6341(F, f_10731_6297_6340(f_10731_6297_6311())), printMethod, builder)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 6387, 6902) || true) && (printableMembers.IsEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 6387, 6902);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 6528, 6567);

                            f_10731_6528_6566(                        // return base.PrintMembers(builder);
                                                    F, f_10731_6542_6565(F, basePrintCall));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 6593, 6600);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 6387, 6902);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 6387, 6902);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 6811, 6879);

                            f_10731_6811_6878(                        // if (base.PrintMembers(builder))
                                                                      //     builder.Append(", ")
                                                    block!, f_10731_6822_6877(F, basePrintCall, f_10731_6842_6876(F, builder, ", ")));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 6387, 6902);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 5474, 6921);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 6941, 7000);

                    f_10731_6941_6999(f_10731_6954_6979_M(!printableMembers.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10731, 6954, 6998) && block is object));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 7029, 7034);

                        for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 7020, 9004) || true) && (i < printableMembers.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 7065, 7068)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 7020, 9004))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 7020, 9004);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 7391, 7424);

                            var
                            member = printableMembers[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 7446, 7499);

                            f_10731_7446_7498(block, f_10731_7456_7497(F, builder, f_10731_7485_7496(member)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 7521, 7568);

                            f_10731_7521_7567(block, f_10731_7531_7566(F, builder, " = "));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 7592, 7932);

                            var
                            value = f_10731_7604_7615(member) switch
                            {
                                SymbolKind.Field when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 7671, 7729) && DynAbs.Tracing.TraceSender.Expression_True(10731, 7671, 7729))
=> f_10731_7691_7729(F, f_10731_7699_7707(F), member),
                                SymbolKind.Property when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 7756, 7823) && DynAbs.Tracing.TraceSender.Expression_True(10731, 7756, 7823))
=> f_10731_7779_7823(F, f_10731_7790_7798(F), member),
                                _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 7850, 7908) && DynAbs.Tracing.TraceSender.Expression_True(10731, 7850, 7908))
=> throw f_10731_7861_7908(f_10731_7896_7907(member))
                            }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 7956, 7993);

                            f_10731_7956_7992(f_10731_7969_7979(value) is not null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 8015, 8807) || true) && (f_10731_8019_8041(f_10731_8019_8029(value)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 8015, 8807);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 8091, 8394);

                                f_10731_8091_8393(block, f_10731_8101_8392(F, f_10731_8153_8391(F, receiver: builder, f_10731_8212_8286(F, WellKnownMember.System_Text_StringBuilder__AppendString), f_10731_8321_8390(F, value, f_10731_8335_8389(F, SpecialMember.System_Object__ToString)))));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 8015, 8807);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 8015, 8807);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 8492, 8784);

                                f_10731_8492_8783(block, f_10731_8502_8782(F, f_10731_8554_8781(F, receiver: builder, f_10731_8613_8687(F, WellKnownMember.System_Text_StringBuilder__AppendObject), f_10731_8722_8780(F, f_10731_8732_8772(F, SpecialType.System_Object), value))));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 8015, 8807);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 8831, 8985) || true) && (i < printableMembers.Length - 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 8831, 8985);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 8916, 8962);

                                f_10731_8916_8961(block, f_10731_8926_8960(F, builder, ", "));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 8831, 8985);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10731, 1, 1985);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10731, 1, 1985);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 9024, 9061);

                    f_10731_9024_9060(
                                    block, f_10731_9034_9059(F, f_10731_9043_9058(F, true)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 9081, 9132);

                    f_10731_9081_9131(
                                    F, f_10731_9095_9130(F, f_10731_9103_9129(block)));
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10731, 9161, 9347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 9254, 9285);

                    f_10731_9254_9284(diagnostics, f_10731_9270_9283(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 9303, 9332);

                    f_10731_9303_9331(F, f_10731_9317_9330(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10731, 9161, 9347);
                }

                static BoundStatement makeAppendString(SyntheticBoundNodeFactory F, BoundParameter builder, string value)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10731, 9363, 9672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 9501, 9657);

                        return f_10731_9508_9656(F, f_10731_9530_9655(F, receiver: builder, f_10731_9556_9630(F, WellKnownMember.System_Text_StringBuilder__AppendString), f_10731_9632_9654(F, value)));
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10731, 9363, 9672);

                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10731_9556_9630(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.WellKnownMember
                        wm)
                        {
                            var return_v = this_param.WellKnownMethod(wm);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9556, 9630);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundLiteral
                        f_10731_9632_9654(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, string
                        stringValue)
                        {
                            var return_v = this_param.StringLiteral(stringValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9632, 9654);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundCall
                        f_10731_9530_9655(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                        receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        method, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                        arg0)
                        {
                            var return_v = this_param.Call(receiver: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9530, 9655);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                        f_10731_9508_9656(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                        expr)
                        {
                            var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9508, 9656);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10731, 9363, 9672);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 9363, 9672);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static bool isPrintable(Symbol m)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10731, 9688, 10318);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 9754, 9893) || true) && (f_10731_9758_9781(m) != Accessibility.Public || (DynAbs.Tracing.TraceSender.Expression_False(10731, 9758, 9819) || f_10731_9809_9819(m)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 9754, 9893);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 9861, 9874);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 9754, 9893);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 9913, 10016) || true) && (f_10731_9917_9923(m) is SymbolKind.Field)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 9913, 10016);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 9985, 9997);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 9913, 10016);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 10036, 10270) || true) && (f_10731_10040_10046(m) is SymbolKind.Property)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 10036, 10270);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 10111, 10144);

                            var
                            property = (PropertySymbol)m
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 10166, 10251);

                            return f_10731_10173_10192_M(!property.IsIndexer) && (DynAbs.Tracing.TraceSender.Expression_True(10731, 10173, 10216) && f_10731_10196_10216_M(!property.IsOverride)) && (DynAbs.Tracing.TraceSender.Expression_True(10731, 10173, 10250) && f_10731_10220_10238(property) is not null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 10036, 10270);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 10290, 10303);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10731, 9688, 10318);

                        Microsoft.CodeAnalysis.Accessibility
                        f_10731_9758_9781(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.DeclaredAccessibility;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 9758, 9781);
                            return return_v;
                        }


                        bool
                        f_10731_9809_9819(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.IsStatic;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 9809, 9819);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10731_9917_9923(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 9917, 9923);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10731_10040_10046(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 10040, 10046);
                            return return_v;
                        }


                        bool
                        f_10731_10173_10192_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 10173, 10192);
                            return return_v;
                        }


                        bool
                        f_10731_10196_10216_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 10196, 10216);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        f_10731_10220_10238(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.GetMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 10220, 10238);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10731, 9688, 10318);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 9688, 10318);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10731, 4585, 10329);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_4761_4775()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 4761, 4775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10731_4761_4798(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 4761, 4798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10731_4725_4830(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordPrintMembers
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 4725, 4830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_4923_4937()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 4923, 4937);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10731_4923_4950(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 4923, 4950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10731_5009_5019()
                {
                    var return_v = ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 5009, 5019);
                    return return_v;
                }


                bool
                f_10731_5009_5033(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 5009, 5033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10731_5183_5196(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 5183, 5196);
                    return return_v;
                }


                int
                f_10731_5169_5197(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 5169, 5197);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10731_5338_5380()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 5338, 5380);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10731_5436_5451(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordPrintMembers
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 5436, 5451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10731_5424_5455(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 5424, 5455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_5478_5492()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 5478, 5492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_5478_5521(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 5478, 5521);
                    return return_v;
                }


                bool
                f_10731_5478_5536(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 5478, 5536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10731_5721_5737(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, bool
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 5721, 5737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10731_5712_5738(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 5712, 5738);
                    return return_v;
                }


                int
                f_10731_5698_5739(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 5698, 5739);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_5934_5948()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 5934, 5948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_5934_5977(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 5934, 5977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10731_5979_5999()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 5979, 5999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10731_5906_6000(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = FindValidPrintMembersMethod((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)containingType, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 5906, 6000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10731_6110_6123(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 6110, 6123);
                    return return_v;
                }


                int
                f_10731_6096_6124(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 6096, 6124);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_6297_6311()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 6297, 6311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_6297_6340(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 6297, 6340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                f_10731_6290_6341(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                baseType)
                {
                    var return_v = this_param.Base(baseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 6290, 6341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10731_6273_6364(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundParameter
                arg0)
                {
                    var return_v = this_param.Call(receiver: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 6273, 6364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10731_6542_6565(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 6542, 6565);
                    return return_v;
                }


                int
                f_10731_6528_6566(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 6528, 6566);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10731_6842_6876(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.BoundParameter
                builder, string
                value)
                {
                    var return_v = makeAppendString(F, builder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 6842, 6876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10731_6822_6877(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause)
                {
                    var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 6822, 6877);
                    return return_v;
                }


                int
                f_10731_6811_6878(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 6811, 6878);
                    return 0;
                }


                bool
                f_10731_6954_6979_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 6954, 6979);
                    return return_v;
                }


                int
                f_10731_6941_6999(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 6941, 6999);
                    return 0;
                }


                string
                f_10731_7485_7496(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 7485, 7496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10731_7456_7497(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.BoundParameter
                builder, string
                value)
                {
                    var return_v = makeAppendString(F, builder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 7456, 7497);
                    return return_v;
                }


                int
                f_10731_7446_7498(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 7446, 7498);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10731_7531_7566(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.BoundParameter
                builder, string
                value)
                {
                    var return_v = makeAppendString(F, builder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 7531, 7566);
                    return return_v;
                }


                int
                f_10731_7521_7567(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 7521, 7567);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10731_7604_7615(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 7604, 7615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10731_7699_7707(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 7699, 7707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10731_7691_7729(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 7691, 7729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10731_7790_7798(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 7790, 7798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10731_7779_7823(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbol
                property)
                {
                    var return_v = this_param.Property((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 7779, 7823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10731_7896_7907(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 7896, 7907);
                    return return_v;
                }


                System.Exception
                f_10731_7861_7908(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 7861, 7908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10731_7969_7979(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 7969, 7979);
                    return return_v;
                }


                int
                f_10731_7956_7992(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 7956, 7992);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10731_8019_8029(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 8019, 8029);
                    return return_v;
                }


                bool
                f_10731_8019_8041(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 8019, 8041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10731_8212_8286(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8212, 8286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10731_8335_8389(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMethod(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8335, 8389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10731_8321_8390(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call(receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8321, 8390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10731_8153_8391(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundCall
                arg0)
                {
                    var return_v = this_param.Call(receiver: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8153, 8391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10731_8101_8392(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8101, 8392);
                    return return_v;
                }


                int
                f_10731_8091_8393(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8091, 8393);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10731_8613_8687(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8613, 8687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_8732_8772(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8732, 8772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10731_8722_8780(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8722, 8780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10731_8554_8781(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg0)
                {
                    var return_v = this_param.Call(receiver: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8554, 8781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10731_8502_8782(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8502, 8782);
                    return return_v;
                }


                int
                f_10731_8492_8783(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8492, 8783);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10731_8926_8960(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.BoundParameter
                builder, string
                value)
                {
                    var return_v = makeAppendString(F, builder, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8926, 8960);
                    return return_v;
                }


                int
                f_10731_8916_8961(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 8916, 8961);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10731_9043_9058(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, bool
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9043, 9058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10731_9034_9059(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9034, 9059);
                    return return_v;
                }


                int
                f_10731_9024_9060(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9024, 9060);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10731_9103_9129(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9103, 9129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10731_9095_9130(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9095, 9130);
                    return return_v;
                }


                int
                f_10731_9081_9131(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9081, 9131);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10731_9270_9283(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 9270, 9283);
                    return return_v;
                }


                int
                f_10731_9254_9284(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9254, 9284);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10731_9317_9330(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9317, 9330);
                    return return_v;
                }


                int
                f_10731_9303_9331(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 9303, 9331);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10731, 4585, 10329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 4585, 10329);
            }
        }

        internal static MethodSymbol? FindValidPrintMembersMethod(TypeSymbol containingType, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10731, 10341, 11798);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 10481, 10575) || true) && (f_10731_10485_10514(containingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 10481, 10575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 10548, 10560);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 10481, 10575);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 10591, 10622);

                MethodSymbol?
                candidate = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 10636, 10754);

                var
                stringBuilder = TypeWithAnnotations.Create(f_10731_10683_10752(compilation, WellKnownType.System_Text_StringBuilder))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 10770, 11479);
                    foreach (var member in f_10731_10793_10863_I(f_10731_10793_10863(containingType, WellKnownMemberNames.PrintMembersMethodName)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 10770, 11479);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 10897, 11464) || true) && (member is MethodSymbol { DeclaredAccessibility: Accessibility.Protected, IsStatic: false, ParameterCount: 1, Arity: 0 } method && (DynAbs.Tracing.TraceSender.Expression_True(10731, 10901, 11147) && f_10731_11052_11088(method)[0].Equals(stringBuilder, TypeCompareKind.AllIgnoreOptions)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 10897, 11464);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 11189, 11402) || true) && (candidate is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 11189, 11402);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 11367, 11379);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 11189, 11402);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 11426, 11445);

                            candidate = method;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 10897, 11464);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 10770, 11479);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10731, 1, 710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10731, 1, 710);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 11495, 11754) || true) && (candidate is null || (DynAbs.Tracing.TraceSender.Expression_False(10731, 11499, 11610) || !(f_10731_11539_11562(containingType) || (DynAbs.Tracing.TraceSender.Expression_False(10731, 11539, 11586) || f_10731_11566_11586(candidate)) || (DynAbs.Tracing.TraceSender.Expression_False(10731, 11539, 11609) || f_10731_11590_11609(candidate)))) || (DynAbs.Tracing.TraceSender.Expression_False(10731, 11499, 11693) || f_10731_11631_11663(f_10731_11631_11651(candidate)) != SpecialType.System_Boolean))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 11495, 11754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 11727, 11739);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 11495, 11754);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 11770, 11787);

                return candidate;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10731, 10341, 11798);

                bool
                f_10731_10485_10514(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 10485, 10514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_10683_10752(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 10683, 10752);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10731_10793_10863(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 10793, 10863);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10731_11052_11088(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 11052, 11088);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10731_10793_10863_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 10793, 10863);
                    return return_v;
                }


                bool
                f_10731_11539_11562(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 11539, 11562);
                    return return_v;
                }


                bool
                f_10731_11566_11586(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 11566, 11586);
                    return return_v;
                }


                bool
                f_10731_11590_11609(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 11590, 11609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10731_11631_11651(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 11631, 11651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10731_11631_11663(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 11631, 11663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10731, 10341, 11798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 10341, 11798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void VerifyOverridesPrintMembersFromBase(MethodSymbol overriding, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10731, 11810, 12813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 11943, 12025);

                NamedTypeSymbol
                baseType = f_10731_11970_12024(f_10731_11970_11995(overriding))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 12039, 12122) || true) && (f_10731_12043_12066(baseType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 12039, 12122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 12100, 12107);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 12039, 12122);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 12138, 12165);

                bool
                reportAnError = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 12181, 12616) || true) && (f_10731_12185_12207_M(!overriding.IsOverride))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 12181, 12616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 12241, 12262);

                    reportAnError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 12181, 12616);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 12181, 12616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 12328, 12373);

                    var
                    overridden = f_10731_12345_12372(overriding)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 12393, 12601) || true) && (overridden is object && (DynAbs.Tracing.TraceSender.Expression_True(10731, 12397, 12519) && !f_10731_12443_12519(f_10731_12443_12468(overridden), baseType, TypeCompareKind.AllIgnoreOptions)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 12393, 12601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 12561, 12582);

                        reportAnError = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 12393, 12601);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 12181, 12616);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 12632, 12802) || true) && (reportAnError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10731, 12632, 12802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10731, 12683, 12787);

                    f_10731_12683_12786(diagnostics, ErrorCode.ERR_DoesNotOverrideBaseMethod, f_10731_12740_12760(overriding)[0], overriding, baseType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10731, 12632, 12802);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10731, 11810, 12813);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_11970_11995(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 11970, 11995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_11970_12024(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 11970, 12024);
                    return return_v;
                }


                bool
                f_10731_12043_12066(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 12043, 12066);
                    return return_v;
                }


                bool
                f_10731_12185_12207_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 12185, 12207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10731_12345_12372(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 12345, 12372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10731_12443_12468(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 12443, 12468);
                    return return_v;
                }


                bool
                f_10731_12443_12519(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 12443, 12519);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10731_12740_12760(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10731, 12740, 12760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10731_12683_12786(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10731, 12683, 12786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10731, 11810, 12813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 11810, 12813);
            }
        }

        static SynthesizedRecordPrintMembers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10731, 877, 12820);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10731, 877, 12820);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10731, 877, 12820);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10731, 877, 12820);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10731_1169_1183_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10731, 979, 1293);
            return return_v;
        }

    }
}
