// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using Microsoft.Cci;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordGetHashCode : SynthesizedRecordObjectMethod
    {
        private readonly PropertySymbol _equalityContract;

        public SynthesizedRecordGetHashCode(SourceMemberContainerTypeSymbol containingType, PropertySymbol equalityContract, int memberOffset, DiagnosticBag diagnostics)
        : base(f_10726_1009_1023_C(containingType), WellKnownMemberNames.ObjectGetHashCode, memberOffset, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10726, 827, 1164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 797, 814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 1116, 1153);

                _equalityContract = equalityContract;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10726, 827, 1164);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10726, 827, 1164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10726, 827, 1164);
            }
        }

        public override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10726, 1238, 1397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 1241, 1397);
                    return TypeWithAnnotations.Create(isNullableEnabled: true, f_10726_1320_1396(f_10726_1320_1355(f_10726_1320_1334()), SpecialType.System_Int32)); DynAbs.Tracing.TraceSender.TraceExitMethod(10726, 1238, 1397);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10726, 1238, 1397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10726, 1238, 1397);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters, bool IsVararg, ImmutableArray<TypeParameterConstraintClause> DeclaredConstraintsForOverrideOrImplementation) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10726, 1410, 2175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 1698, 1737);

                var
                compilation = f_10726_1716_1736()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 1751, 1785);

                var
                location = f_10726_1766_1784()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 1799, 2164);

                return (ReturnType: TypeWithAnnotations.Create(f_10726_1846_1929(compilation, SpecialType.System_Int32, location, diagnostics)),
                                    Parameters: ImmutableArray<ParameterSymbol>.Empty,
                                    IsVararg: false,
                                    DeclaredConstraintsForOverrideOrImplementation: ImmutableArray<TypeParameterConstraintClause>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10726, 1410, 2175);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10726_1716_1736()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 1716, 1736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10726_1766_1784()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 1766, 1784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10726_1846_1929(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 1846, 1929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10726, 1410, 2175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10726, 1410, 2175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10726, 2240, 2244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 2243, 2244);
                return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10726, 2240, 2244);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10726, 2240, 2244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10726, 2240, 2244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10726, 2257, 6091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 2389, 2481);

                var
                F = f_10726_2397_2480(this, f_10726_2433_2448(this), compilationState, diagnostics)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 2533, 2583);

                    MethodSymbol?
                    equalityComparer_GetHashCode = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 2601, 2651);

                    MethodSymbol?
                    equalityComparer_get_Default = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 2669, 2702);

                    BoundExpression
                    currentHashValue
                    = default(BoundExpression);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 2722, 4491) || true) && (f_10726_2726_2784(f_10726_2726_2769(f_10726_2726_2740())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10726, 2722, 4491);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 2826, 3096) || true) && (f_10726_2830_2857(_equalityContract) is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10726, 2826, 3096);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 3011, 3040);

                            f_10726_3011_3039(                        // The equality contract isn't usable, an error was reported elsewhere
                                                    F, f_10726_3025_3038(F));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 3066, 3073);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10726, 2826, 3096);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 3120, 3285) || true) && (f_10726_3124_3150(_equalityContract))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10726, 3120, 3285);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 3200, 3229);

                            f_10726_3200_3228(F, f_10726_3214_3227(F));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 3255, 3262);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10726, 3120, 3285);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 3477, 3578);

                        f_10726_3477_3577(F, ref equalityComparer_GetHashCode, ref equalityComparer_get_Default);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 3600, 3767);

                        currentHashValue = f_10726_3619_3766(equalityComparer_GetHashCode!, equalityComparer_get_Default!, f_10726_3723_3762(F, f_10726_3734_3742(F), _equalityContract), F);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10726, 2722, 4491);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10726, 2722, 4491);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 3998, 4032);

                        var
                        overridden = f_10726_4015_4031()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 4056, 4375) || true) && (overridden is null || (DynAbs.Tracing.TraceSender.Expression_False(10726, 4060, 4143) || f_10726_4082_4115(f_10726_4082_4103(overridden)) != SpecialType.System_Int32))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10726, 4056, 4375);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 4290, 4319);

                            f_10726_4290_4318(                        // There was a problem with overriding, an error was reported elsewhere
                                                    F, f_10726_4304_4317(F));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 4345, 4352);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10726, 4056, 4375);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 4399, 4472);

                        currentHashValue = f_10726_4418_4471(F, f_10726_4425_4458(F, f_10726_4432_4457(overridden)), overridden);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10726, 2722, 4491);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 4550, 4587);

                    BoundLiteral?
                    boundHashFactor = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 4607, 5292);
                        foreach (var f in f_10726_4625_4657_I(f_10726_4625_4657(f_10726_4625_4639())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10726, 4607, 5292);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 4699, 5273) || true) && (f_10726_4703_4714_M(!f.IsStatic))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10726, 4699, 5273);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 4764, 4865);

                                f_10726_4764_4864(F, ref equalityComparer_GetHashCode, ref equalityComparer_get_Default);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 4891, 5250);

                                currentHashValue = f_10726_4910_5249(currentHashValue, equalityComparer_GetHashCode!, equalityComparer_get_Default!, ref boundHashFactor, f_10726_5139_5159(F, f_10726_5147_5155(F), f), F);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10726, 4699, 5273);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10726, 4607, 5292);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10726, 1, 686);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10726, 1, 686);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 5312, 5363);

                    f_10726_5312_5362(
                                    F, f_10726_5326_5361(F, f_10726_5334_5360(F, currentHashValue)));
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10726, 5392, 5578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 5485, 5516);

                    f_10726_5485_5515(diagnostics, f_10726_5501_5514(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 5534, 5563);

                    f_10726_5534_5562(F, f_10726_5548_5561(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10726, 5392, 5578);
                }

                static void ensureEqualityComparerHelpers(SyntheticBoundNodeFactory F, ref MethodSymbol? equalityComparer_GetHashCode, ref MethodSymbol? equalityComparer_get_Default)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10726, 5594, 6080);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 5793, 5920);

                        if (equalityComparer_GetHashCode is null)
                            DynAbs.Tracing.TraceSender.TraceEnterExpression(10726, 5793, 5920);

                        equalityComparer_GetHashCode ??= f_10726_5826_5919(F, WellKnownMember.System_Collections_Generic_EqualityComparer_T__GetHashCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10726, 5938, 6065);

                        if (equalityComparer_get_Default is null)
                            DynAbs.Tracing.TraceSender.TraceEnterExpression(10726, 5938, 6065);

                        equalityComparer_get_Default ??= f_10726_5971_6064(F, WellKnownMember.System_Collections_Generic_EqualityComparer_T__get_Default);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10726, 5594, 6080);

                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10726_5826_5919(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.WellKnownMember
                        wm)
                        {
                            var return_v = this_param.WellKnownMethod(wm);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 5826, 5919);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10726_5971_6064(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param, Microsoft.CodeAnalysis.WellKnownMember
                        wm)
                        {
                            var return_v = this_param.WellKnownMethod(wm);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 5971, 6064);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10726, 5594, 6080);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10726, 5594, 6080);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10726, 2257, 6091);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10726_2433_2448(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordGetHashCode
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 2433, 2448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10726_2397_2480(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordGetHashCode
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 2397, 2480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10726_2726_2740()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 2726, 2740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10726_2726_2769(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 2726, 2769);
                    return return_v;
                }


                bool
                f_10726_2726_2784(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 2726, 2784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10726_2830_2857(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 2830, 2857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10726_3025_3038(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 3025, 3038);
                    return return_v;
                }


                int
                f_10726_3011_3039(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 3011, 3039);
                    return 0;
                }


                bool
                f_10726_3124_3150(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 3124, 3150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10726_3214_3227(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 3214, 3227);
                    return return_v;
                }


                int
                f_10726_3200_3228(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 3200, 3228);
                    return 0;
                }


                int
                f_10726_3477_3577(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                equalityComparer_GetHashCode, ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                equalityComparer_get_Default)
                {
                    ensureEqualityComparerHelpers(F, ref equalityComparer_GetHashCode, ref equalityComparer_get_Default);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 3477, 3577);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10726_3734_3742(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 3734, 3742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10726_3723_3762(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = this_param.Property((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 3723, 3762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10726_3619_3766(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                system_Collections_Generic_EqualityComparer_T__GetHashCode, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                system_Collections_Generic_EqualityComparer_T__get_Default, Microsoft.CodeAnalysis.CSharp.BoundExpression
                valueToHash, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F)
                {
                    var return_v = MethodBodySynthesizer.GenerateGetHashCode(system_Collections_Generic_EqualityComparer_T__GetHashCode, system_Collections_Generic_EqualityComparer_T__get_Default, valueToHash, F);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 3619, 3766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10726_4015_4031()
                {
                    var return_v = OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 4015, 4031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10726_4082_4103(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 4082, 4103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10726_4082_4115(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 4082, 4115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10726_4304_4317(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 4304, 4317);
                    return return_v;
                }


                int
                f_10726_4290_4318(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 4290, 4318);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10726_4432_4457(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 4432, 4457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                f_10726_4425_4458(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                baseType)
                {
                    var return_v = this_param.Base(baseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 4425, 4458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10726_4418_4471(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 4418, 4471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10726_4625_4639()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 4625, 4639);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10726_4625_4657(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetFieldsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 4625, 4657);
                    return return_v;
                }


                bool
                f_10726_4703_4714_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 4703, 4714);
                    return return_v;
                }


                int
                f_10726_4764_4864(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                equalityComparer_GetHashCode, ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                equalityComparer_get_Default)
                {
                    ensureEqualityComparerHelpers(F, ref equalityComparer_GetHashCode, ref equalityComparer_get_Default);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 4764, 4864);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10726_5147_5155(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 5147, 5155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10726_5139_5159(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 5139, 5159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10726_4910_5249(Microsoft.CodeAnalysis.CSharp.BoundExpression
                currentHashValue, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                system_Collections_Generic_EqualityComparer_T__GetHashCode, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                system_Collections_Generic_EqualityComparer_T__get_Default, ref Microsoft.CodeAnalysis.CSharp.BoundLiteral?
                boundHashFactor, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                valueToHash, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F)
                {
                    var return_v = MethodBodySynthesizer.GenerateHashCombine(currentHashValue, system_Collections_Generic_EqualityComparer_T__GetHashCode, system_Collections_Generic_EqualityComparer_T__get_Default, ref boundHashFactor, (Microsoft.CodeAnalysis.CSharp.BoundExpression)valueToHash, F);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 4910, 5249);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10726_4625_4657_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 4625, 4657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10726_5334_5360(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Return(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 5334, 5360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10726_5326_5361(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 5326, 5361);
                    return return_v;
                }


                int
                f_10726_5312_5362(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 5312, 5362);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10726_5501_5514(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 5501, 5514);
                    return return_v;
                }


                int
                f_10726_5485_5515(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 5485, 5515);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10726_5548_5561(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 5548, 5561);
                    return return_v;
                }


                int
                f_10726_5534_5562(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 5534, 5562);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10726, 2257, 6091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10726, 2257, 6091);
            }
        }

        static SynthesizedRecordGetHashCode()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10726, 666, 6098);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10726, 666, 6098);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10726, 666, 6098);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10726, 666, 6098);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10726_1009_1023_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10726, 827, 1164);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10726_1320_1334()
        {
            var return_v = ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 1320, 1334);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10726_1320_1355(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10726, 1320, 1355);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10726_1320_1396(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SpecialType
        specialType)
        {
            var return_v = this_param.GetSpecialType(specialType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10726, 1320, 1396);
            return return_v;
        }

    }
}
