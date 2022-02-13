// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class ConversionsBase
    {
        private UserDefinedConversionResult AnalyzeImplicitUserDefinedConversions(
                    BoundExpression sourceExpression,
                    TypeSymbol source,
                    TypeSymbol target,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 846, 5958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 1117, 1182);

                f_10850_1117_1181(sourceExpression != null || (DynAbs.Tracing.TraceSender.Expression_False(10850, 1130, 1180) || (object)source != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 1196, 1233);

                f_10850_1196_1232((object)target != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 4156, 4208);

                var
                d = f_10850_4164_4207()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 4222, 4309);

                f_10850_4222_4308(source, target, d, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 4425, 4496);

                var
                ubuild = f_10850_4438_4495()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 4510, 4629);

                f_10850_4510_4628(this, sourceExpression, source, target, d, ubuild, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 4643, 4652);

                f_10850_4643_4651(d);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 4666, 4744);

                ImmutableArray<UserDefinedConversionAnalysis>
                u = f_10850_4716_4743(ubuild)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 4858, 4984) || true) && (u.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 4858, 4984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 4909, 4969);

                    return UserDefinedConversionResult.NoApplicableOperators(u);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 4858, 4984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 5085, 5191);

                TypeSymbol
                sx = f_10850_5101_5190(this, u, source, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 5205, 5331) || true) && ((object)sx == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 5205, 5331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 5261, 5316);

                    return UserDefinedConversionResult.NoBestSourceType(u);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 5205, 5331);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 5432, 5538);

                TypeSymbol
                tx = f_10850_5448_5537(this, u, target, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 5552, 5678) || true) && ((object)tx == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 5552, 5678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 5608, 5663);

                    return UserDefinedConversionResult.NoBestTargetType(u);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 5552, 5678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 5694, 5748);

                int?
                best = f_10850_5706_5747(sx, tx, u)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 5762, 5875) || true) && (best == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 5762, 5875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 5812, 5860);

                    return UserDefinedConversionResult.Ambiguous(u);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 5762, 5875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 5891, 5947);

                return UserDefinedConversionResult.Valid(u, f_10850_5935_5945(best));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 846, 5958);

                int
                f_10850_1117_1181(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 1117, 1181);
                    return 0;
                }


                int
                f_10850_1196_1232(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 1196, 1232);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10850_4164_4207()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 4164, 4207);
                    return return_v;
                }


                int
                f_10850_4222_4308(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                s, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                d, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    ComputeUserDefinedImplicitConversionTypeSet(s, t, d, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 4222, 4308);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                f_10850_4438_4495()
                {
                    var return_v = ArrayBuilder<UserDefinedConversionAnalysis>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 4438, 4495);
                    return return_v;
                }


                int
                f_10850_4510_4628(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                d, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ComputeApplicableUserDefinedImplicitConversionSet(sourceExpression, source, target, d, u, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 4510, 4628);
                    return 0;
                }


                int
                f_10850_4643_4651(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 4643, 4651);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                f_10850_4716_4743(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 4716, 4743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_5101_5190(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostSpecificSourceTypeForImplicitUserDefinedConversion(u, source, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 5101, 5190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_5448_5537(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostSpecificTargetTypeForImplicitUserDefinedConversion(u, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 5448, 5537);
                    return return_v;
                }


                int?
                f_10850_5706_5747(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sx, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                tx, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u)
                {
                    var return_v = MostSpecificConversionOperator(sx, tx, u);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 5706, 5747);
                    return return_v;
                }


                int
                f_10850_5935_5945(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10850, 5935, 5945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 846, 5958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 846, 5958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ComputeUserDefinedImplicitConversionTypeSet(TypeSymbol s, TypeSymbol t, ArrayBuilder<NamedTypeSymbol> d, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10850, 5970, 6944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 6508, 6578);

                TypeSymbol
                s0 = f_10850_6524_6577(s, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 6592, 6662);

                TypeSymbol
                t0 = f_10850_6608_6661(t, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 6678, 6798);

                f_10850_6678_6797(d, s0, includeBaseTypes: true, useSiteDiagnostics: ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 6812, 6933);

                f_10850_6812_6932(d, t0, includeBaseTypes: false, useSiteDiagnostics: ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10850, 5970, 6944);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_6524_6577(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = GetUnderlyingEffectiveType(type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 6524, 6577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_6608_6661(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = GetUnderlyingEffectiveType(type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 6608, 6661);
                    return return_v;
                }


                int
                f_10850_6678_6797(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                includeBaseTypes, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    AddTypesParticipatingInUserDefinedConversion(result, type, includeBaseTypes: includeBaseTypes, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 6678, 6797);
                    return 0;
                }


                int
                f_10850_6812_6932(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                includeBaseTypes, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    AddTypesParticipatingInUserDefinedConversion(result, type, includeBaseTypes: includeBaseTypes, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 6812, 6932);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 5970, 6944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 5970, 6944);
            }
        }

        private void ComputeApplicableUserDefinedImplicitConversionSet(
                    BoundExpression sourceExpression,
                    TypeSymbol source,
                    TypeSymbol target,
                    ArrayBuilder<NamedTypeSymbol> d,
                    ArrayBuilder<UserDefinedConversionAnalysis> u,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    bool allowAnyTarget = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 7968, 19542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 8376, 8441);

                f_10850_8376_8440(sourceExpression != null || (DynAbs.Tracing.TraceSender.Expression_False(10850, 8389, 8439) || (object)source != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 8455, 8513);

                f_10850_8455_8512(((object)target != null) == !allowAnyTarget);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 8527, 8551);

                f_10850_8527_8550(d != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 8565, 8589);

                f_10850_8565_8588(u != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 14648, 14812) || true) && ((object)source != null && (DynAbs.Tracing.TraceSender.Expression_True(10850, 14652, 14702) && f_10850_14678_14702(source)) || (DynAbs.Tracing.TraceSender.Expression_False(10850, 14652, 14756) || (object)target != null && (DynAbs.Tracing.TraceSender.Expression_True(10850, 14706, 14756) && f_10850_14732_14756(target))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 14648, 14812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 14790, 14797);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 14648, 14812);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 14828, 19531);
                    foreach (NamedTypeSymbol declaringType in f_10850_14870_14871_I(d))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 14828, 19531);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 14905, 19516);
                            foreach (MethodSymbol op in f_10850_14933_15004_I(f_10850_14933_15004(declaringType, WellKnownMemberNames.ImplicitConversionName)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 14905, 19516);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 15149, 15275) || true) && (f_10850_15153_15167(op) || (DynAbs.Tracing.TraceSender.Expression_False(10850, 15153, 15193) || f_10850_15171_15188(op) != 1))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 15149, 15275);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 15243, 15252);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 15149, 15275);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 15299, 15348);

                                TypeSymbol
                                convertsFrom = f_10850_15325_15347(op, 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 15370, 15408);

                                TypeSymbol
                                convertsTo = f_10850_15394_15407(op)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 15430, 15553);

                                Conversion
                                fromConversion = f_10850_15458_15552(this, sourceExpression, source, convertsFrom, ref useSiteDiagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 15575, 15746);

                                Conversion
                                toConversion = (DynAbs.Tracing.TraceSender.Conditional_F1(10850, 15601, 15615) || ((allowAnyTarget && DynAbs.Tracing.TraceSender.Conditional_F2(10850, 15618, 15637)) || DynAbs.Tracing.TraceSender.Conditional_F3(10850, 15665, 15745))) ? Conversion.Identity : f_10850_15665_15745(this, null, convertsTo, target, ref useSiteDiagnostics)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 15770, 19497) || true) && (fromConversion.Exists && (DynAbs.Tracing.TraceSender.Expression_True(10850, 15774, 15818) && toConversion.Exists))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 15770, 19497);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 16624, 17041) || true) && ((object)target != null && (DynAbs.Tracing.TraceSender.Expression_True(10850, 16628, 16677) && f_10850_16654_16677(target)) && (DynAbs.Tracing.TraceSender.Expression_True(10850, 16628, 16716) && f_10850_16681_16716(convertsTo)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 16624, 17041);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 16774, 16816);

                                        convertsTo = f_10850_16787_16815(this, convertsTo);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 16846, 17014);

                                        toConversion = (DynAbs.Tracing.TraceSender.Conditional_F1(10850, 16861, 16875) || ((allowAnyTarget && DynAbs.Tracing.TraceSender.Conditional_F2(10850, 16878, 16897)) || DynAbs.Tracing.TraceSender.Conditional_F3(10850, 16933, 17013))) ? Conversion.Identity : f_10850_16933_17013(this, null, convertsTo, target, ref useSiteDiagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 16624, 17041);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 17069, 17173);

                                    f_10850_17069_17172(
                                                            u, f_10850_17075_17171(op, fromConversion, toConversion, convertsFrom, convertsTo));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 15770, 19497);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 15770, 19497);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 17223, 19497) || true) && ((object)source != null && (DynAbs.Tracing.TraceSender.Expression_True(10850, 17227, 17276) && f_10850_17253_17276(source)) && (DynAbs.Tracing.TraceSender.Expression_True(10850, 17227, 17317) && f_10850_17280_17317(convertsFrom)) && (DynAbs.Tracing.TraceSender.Expression_True(10850, 17227, 17392) && (allowAnyTarget || (DynAbs.Tracing.TraceSender.Expression_False(10850, 17347, 17391) || f_10850_17365_17391(target)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 17223, 19497);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 18608, 18665);

                                        TypeSymbol
                                        nullableFrom = f_10850_18634_18664(this, convertsFrom)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 18691, 18795);

                                        TypeSymbol
                                        nullableTo = (DynAbs.Tracing.TraceSender.Conditional_F1(10850, 18715, 18750) || ((f_10850_18715_18750(convertsTo) && DynAbs.Tracing.TraceSender.Conditional_F2(10850, 18753, 18781)) || DynAbs.Tracing.TraceSender.Conditional_F3(10850, 18784, 18794))) ? f_10850_18753_18781(this, convertsTo) : convertsTo
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 18821, 18950);

                                        Conversion
                                        liftedFromConversion = f_10850_18855_18949(this, sourceExpression, source, nullableFrom, ref useSiteDiagnostics)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 18976, 19187);

                                        Conversion
                                        liftedToConversion = (DynAbs.Tracing.TraceSender.Conditional_F1(10850, 19008, 19023) || ((!allowAnyTarget && DynAbs.Tracing.TraceSender.Conditional_F2(10850, 19055, 19135)) || DynAbs.Tracing.TraceSender.Conditional_F3(10850, 19167, 19186))) ? f_10850_19055_19135(this, null, nullableTo, target, ref useSiteDiagnostics) : Conversion.Identity
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 19213, 19474) || true) && (liftedFromConversion.Exists && (DynAbs.Tracing.TraceSender.Expression_True(10850, 19217, 19273) && liftedToConversion.Exists))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 19213, 19474);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 19331, 19447);

                                            f_10850_19331_19446(u, f_10850_19337_19445(op, liftedFromConversion, liftedToConversion, nullableFrom, nullableTo));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 19213, 19474);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 17223, 19497);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 15770, 19497);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 14905, 19516);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10850, 1, 4612);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10850, 1, 4612);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 14828, 19531);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10850, 1, 4704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10850, 1, 4704);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 7968, 19542);

                int
                f_10850_8376_8440(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 8376, 8440);
                    return 0;
                }


                int
                f_10850_8455_8512(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 8455, 8512);
                    return 0;
                }


                int
                f_10850_8527_8550(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 8527, 8550);
                    return 0;
                }


                int
                f_10850_8565_8588(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 8565, 8588);
                    return 0;
                }


                bool
                f_10850_14678_14702(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 14678, 14702);
                    return return_v;
                }


                bool
                f_10850_14732_14756(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 14732, 14756);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10850_14933_15004(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetOperators(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 14933, 15004);
                    return return_v;
                }


                bool
                f_10850_15153_15167(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10850, 15153, 15167);
                    return return_v;
                }


                int
                f_10850_15171_15188(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10850, 15171, 15188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_15325_15347(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 15325, 15347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_15394_15407(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10850, 15394, 15407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10850_15458_15552(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                aExpr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingImplicitConversion(aExpr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 15458, 15552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10850_15665_15745(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                aExpr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingImplicitConversion(aExpr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 15665, 15745);
                    return return_v;
                }


                bool
                f_10850_16654_16677(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 16654, 16677);
                    return return_v;
                }


                bool
                f_10850_16681_16716(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 16681, 16716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10850_16787_16815(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullableType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 16787, 16815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10850_16933_17013(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                aExpr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingImplicitConversion(aExpr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 16933, 17013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                f_10850_17075_17171(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                op, Microsoft.CodeAnalysis.CSharp.Conversion
                sourceConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                targetConversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = UserDefinedConversionAnalysis.Normal(op, sourceConversion, targetConversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 17075, 17171);
                    return return_v;
                }


                int
                f_10850_17069_17172(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                this_param, Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 17069, 17172);
                    return 0;
                }


                bool
                f_10850_17253_17276(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 17253, 17276);
                    return return_v;
                }


                bool
                f_10850_17280_17317(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 17280, 17317);
                    return return_v;
                }


                bool
                f_10850_17365_17391(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.CanBeAssignedNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 17365, 17391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10850_18634_18664(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullableType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 18634, 18664);
                    return return_v;
                }


                bool
                f_10850_18715_18750(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 18715, 18750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10850_18753_18781(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullableType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 18753, 18781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10850_18855_18949(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                aExpr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingImplicitConversion(aExpr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 18855, 18949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10850_19055_19135(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                aExpr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingImplicitConversion(aExpr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 19055, 19135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                f_10850_19337_19445(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                op, Microsoft.CodeAnalysis.CSharp.Conversion
                sourceConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                targetConversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = UserDefinedConversionAnalysis.Lifted(op, sourceConversion, targetConversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 19337, 19445);
                    return return_v;
                }


                int
                f_10850_19331_19446(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                this_param, Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 19331, 19446);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10850_14933_15004_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 14933, 15004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10850_14870_14871_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 14870, 14871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 7968, 19542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 7968, 19542);
            }
        }

        private TypeSymbol MostSpecificSourceTypeForImplicitUserDefinedConversion(ImmutableArray<UserDefinedConversionAnalysis> u, TypeSymbol source, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 19554, 20335);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 19848, 20094) || true) && ((object)source != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 19848, 20094);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 19908, 20079) || true) && (u.Any(conv => TypeSymbol.Equals(conv.FromType, source, TypeCompareKind.ConsiderEverything2)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 19908, 20079);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 20046, 20060);

                        return source;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 19908, 20079);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 19848, 20094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 20247, 20324);

                return f_10850_20254_20323(this, u, conv => conv.FromType, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 19554, 20335);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_20254_20323(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                extract, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostEncompassedType<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>(items, extract, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 20254, 20323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 19554, 20335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 19554, 20335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol MostSpecificTargetTypeForImplicitUserDefinedConversion(ImmutableArray<UserDefinedConversionAnalysis> u, TypeSymbol target, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 20347, 22113);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 21853, 22010) || true) && (u.Any(conv => TypeSymbol.Equals(conv.ToType, target, TypeCompareKind.ConsiderEverything2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 21853, 22010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 21981, 21995);

                    return target;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 21853, 22010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 22026, 22102);

                return f_10850_22033_22101(this, u, conv => conv.ToType, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 20347, 22113);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_22033_22101(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                extract, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostEncompassingType<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>(items, extract, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 22033, 22101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 20347, 22113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 20347, 22113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int LiftingCount(UserDefinedConversionAnalysis conv)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10850, 22125, 22628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 22217, 22231);

                int
                count = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 22245, 22414) || true) && (!f_10850_22250_22354(conv.FromType, f_10850_22283_22316(conv.Operator, 0), TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 22245, 22414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 22388, 22399);

                    count += 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 22245, 22414);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 22430, 22588) || true) && (!f_10850_22435_22528(conv.ToType, f_10850_22466_22490(conv.Operator), TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 22430, 22588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 22562, 22573);

                    count += 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 22430, 22588);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 22604, 22617);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10850, 22125, 22628);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_22283_22316(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 22283, 22316);
                    return return_v;
                }


                bool
                f_10850_22250_22354(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 22250, 22354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_22466_22490(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10850, 22466, 22490);
                    return return_v;
                }


                bool
                f_10850_22435_22528(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 22435, 22528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 22125, 22628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 22125, 22628);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int? MostSpecificConversionOperator(TypeSymbol sx, TypeSymbol tx, ImmutableArray<UserDefinedConversionAnalysis> u)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10850, 22640, 23004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 22794, 22993);

                return f_10850_22801_22992(conv => TypeSymbol.Equals(conv.FromType, sx, TypeCompareKind.ConsiderEverything2) && TypeSymbol.Equals(conv.ToType, tx, TypeCompareKind.ConsiderEverything2), u);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10850, 22640, 23004);

                int?
                f_10850_22801_22992(System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, bool>
                constraint, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u)
                {
                    var return_v = MostSpecificConversionOperator(constraint, u);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 22801, 22992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 22640, 23004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 22640, 23004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int? MostSpecificConversionOperator(Func<UserDefinedConversionAnalysis, bool> constraint, ImmutableArray<UserDefinedConversionAnalysis> u)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10850, 23181, 28885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 26195, 26339);

                BestIndex
                bestUnlifted = f_10850_26220_26338(u, conv =>
                                constraint(conv) &&
                                LiftingCount(conv) == 0)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 26355, 26834) || true) && (bestUnlifted.Kind == BestIndexKind.Best)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 26355, 26834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 26432, 26457);

                    return bestUnlifted.Best;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 26355, 26834);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 26355, 26834);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 26491, 26834) || true) && (bestUnlifted.Kind == BestIndexKind.Ambiguous)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 26491, 26834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 26807, 26819);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 26491, 26834);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 26355, 26834);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 27632, 27778);

                BestIndex
                bestHalfLifted = f_10850_27659_27777(u, conv =>
                                constraint(conv) &&
                                LiftingCount(conv) == 1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 27794, 28188) || true) && (bestHalfLifted.Kind == BestIndexKind.Best)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 27794, 28188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 27873, 27900);

                    return bestHalfLifted.Best;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 27794, 28188);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 27794, 28188);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 27934, 28188) || true) && (bestHalfLifted.Kind == BestIndexKind.Ambiguous)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 27934, 28188);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 28161, 28173);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 27934, 28188);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 27794, 28188);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 28286, 28433);

                BestIndex
                bestFullyLifted = f_10850_28314_28432(u, conv =>
                                constraint(conv) &&
                                LiftingCount(conv) == 2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 28449, 28846) || true) && (bestFullyLifted.Kind == BestIndexKind.Best)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 28449, 28846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 28529, 28557);

                    return bestFullyLifted.Best;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 28449, 28846);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 28449, 28846);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 28591, 28846) || true) && (bestFullyLifted.Kind == BestIndexKind.Ambiguous)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 28591, 28846);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 28819, 28831);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 28591, 28846);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 28449, 28846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 28862, 28874);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10850, 23181, 28885);

                Microsoft.CodeAnalysis.CSharp.BestIndex
                f_10850_26220_26338(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, bool>
                predicate)
                {
                    var return_v = UniqueIndex(items, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 26220, 26338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BestIndex
                f_10850_27659_27777(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, bool>
                predicate)
                {
                    var return_v = UniqueIndex(items, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 27659, 27777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BestIndex
                f_10850_28314_28432(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, bool>
                predicate)
                {
                    var return_v = UniqueIndex(items, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 28314, 28432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 23181, 28885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 23181, 28885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BestIndex UniqueIndex<T>(ImmutableArray<T> items, Func<T, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10850, 29029, 29840);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 29143, 29233) || true) && (items.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 29143, 29233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 29194, 29218);

                    return BestIndex.None();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 29143, 29233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 29249, 29268);

                int?
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 29291, 29296);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 29282, 29738) || true) && (i < items.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 29316, 29319)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 29282, 29738))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 29282, 29738);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 29353, 29723) || true) && (f_10850_29357_29376<T>(predicate, items[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 29353, 29723);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 29418, 29704) || true) && (result == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 29418, 29704);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 29486, 29497);

                                result = i;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 29418, 29704);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 29418, 29704);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 29635, 29681);

                                return BestIndex.IsAmbiguous(f_10850_29664_29676<T>(result), i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 29418, 29704);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 29353, 29723);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10850, 1, 457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10850, 1, 457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 29754, 29829);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10850, 29761, 29775) || ((result == null && DynAbs.Tracing.TraceSender.Conditional_F2(10850, 29778, 29794)) || DynAbs.Tracing.TraceSender.Conditional_F3(10850, 29797, 29828))) ? BestIndex.None() : BestIndex.HasBest(f_10850_29815_29827<T>(result));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10850, 29029, 29840);

                bool
                f_10850_29357_29376<T>(System.Func<T, bool>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 29357, 29376);
                    return return_v;
                }


                int
                f_10850_29664_29676<T>(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10850, 29664, 29676);
                    return return_v;
                }


                int
                f_10850_29815_29827<T>(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10850, 29815, 29827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 29029, 29840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 29029, 29840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsEncompassedBy(BoundExpression aExpr, TypeSymbol a, TypeSymbol b, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 29887, 30474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 30039, 30071);

                f_10850_30039_30070((object)a != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 30085, 30117);

                f_10850_30085_30116((object)b != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 30381, 30463);

                return f_10850_30388_30455(this, aExpr, a, b, ref useSiteDiagnostics).Exists;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 29887, 30474);

                int
                f_10850_30039_30070(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 30039, 30070);
                    return 0;
                }


                int
                f_10850_30085_30116(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 30085, 30116);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10850_30388_30455(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                aExpr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingImplicitConversion(aExpr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 30388, 30455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 29887, 30474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 29887, 30474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion EncompassingImplicitConversion(BoundExpression aExpr, TypeSymbol a, TypeSymbol b, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 30486, 31306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 30659, 30708);

                f_10850_30659_30707(aExpr != null || (DynAbs.Tracing.TraceSender.Expression_False(10850, 30672, 30706) || (object)a != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 30722, 30754);

                f_10850_30722_30753((object)b != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 31104, 31189);

                var
                result = f_10850_31117_31188(this, aExpr, a, b, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 31203, 31295);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10850, 31210, 31259) || ((f_10850_31210_31259(result.Kind) && DynAbs.Tracing.TraceSender.Conditional_F2(10850, 31262, 31268)) || DynAbs.Tracing.TraceSender.Conditional_F3(10850, 31271, 31294))) ? result : Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 30486, 31306);

                int
                f_10850_30659_30707(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 30659, 30707);
                    return 0;
                }


                int
                f_10850_30722_30753(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 30722, 30753);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10850_31117_31188(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyStandardImplicitConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 31117, 31188);
                    return return_v;
                }


                bool
                f_10850_31210_31259(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind)
                {
                    var return_v = IsEncompassingImplicitConversionKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 31210, 31259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 30486, 31306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 30486, 31306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsEncompassingImplicitConversionKind(ConversionKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10850, 31318, 34171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 31420, 34160);

                switch (kind)
                {

                    case ConversionKind.NoConversion:

                    // These are conversions from expression and do not apply.
                    // Specifically disallowed because there would be subtle consequences for the overload betterness rules.
                    case ConversionKind.ImplicitDynamic:
                    case ConversionKind.MethodGroup:
                    case ConversionKind.AnonymousFunction:
                    case ConversionKind.InterpolatedString:
                    case ConversionKind.SwitchExpression:
                    case ConversionKind.ConditionalExpression:
                    case ConversionKind.ImplicitEnumeration:
                    case ConversionKind.StackAllocToPointerType:
                    case ConversionKind.StackAllocToSpanType:

                    // Not "standard".
                    case ConversionKind.ImplicitUserDefined:
                    case ConversionKind.ExplicitUserDefined:

                    // Not implicit.
                    case ConversionKind.ExplicitNumeric:
                    case ConversionKind.ExplicitEnumeration:
                    case ConversionKind.ExplicitNullable:
                    case ConversionKind.ExplicitReference:
                    case ConversionKind.Unboxing:
                    case ConversionKind.ExplicitDynamic:
                    case ConversionKind.ExplicitPointerToPointer:
                    case ConversionKind.ExplicitPointerToInteger:
                    case ConversionKind.ExplicitIntegerToPointer:
                    case ConversionKind.IntPtr:
                    case ConversionKind.ExplicitTupleLiteral:
                    case ConversionKind.ExplicitTuple:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 31420, 34160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 33131, 33144);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 31420, 34160);

                    case ConversionKind.Identity:
                    case ConversionKind.ImplicitNumeric:
                    case ConversionKind.ImplicitNullable:
                    case ConversionKind.ImplicitReference:
                    case ConversionKind.Boxing:
                    case ConversionKind.ImplicitConstant:
                    case ConversionKind.ImplicitPointerToVoid:

                    // Added to spec in Roslyn timeframe.
                    case ConversionKind.NullLiteral:
                    case ConversionKind.ImplicitNullToPointer:

                    // Added for C# 7.
                    case ConversionKind.ImplicitTupleLiteral:
                    case ConversionKind.ImplicitTuple:
                    case ConversionKind.ImplicitThrow:

                    // Added for C# 7.1
                    case ConversionKind.DefaultLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 31420, 34160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 34036, 34048);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 31420, 34160);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 31420, 34160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 34098, 34145);

                        throw f_10850_34104_34144(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 31420, 34160);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10850, 31318, 34171);

                System.Exception
                f_10850_34104_34144(Microsoft.CodeAnalysis.CSharp.ConversionKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 34104, 34144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 31318, 34171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 31318, 34171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol MostEncompassedType<T>(
                    ImmutableArray<T> items,
                    Func<T, TypeSymbol> extract,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 34183, 34483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 34391, 34472);

                return f_10850_34398_34471<T>(this, items, x => true, extract, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 34183, 34483);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_34398_34471<T>(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<T>
                items, System.Func<T, bool>
                valid, System.Func<T, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                extract, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostEncompassedType<T>(items, valid, extract, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 34398, 34471);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 34183, 34483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 34183, 34483);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol MostEncompassedType<T>(
                    ImmutableArray<T> items,
                    Func<T, bool> valid,
                    Func<T, TypeSymbol> extract,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 34495, 37130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 36033, 36098);

                HashSet<DiagnosticInfo>
                _useSiteDiagnostics = useSiteDiagnostics
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 36112, 36992);

                int?
                best = f_10850_36124_36991<T>(items, valid, (left, right) =>
                                {
                                    TypeSymbol leftType = extract(left);
                                    TypeSymbol rightType = extract(right);
                                    if (TypeSymbol.Equals(leftType, rightType, TypeCompareKind.ConsiderEverything2))
                                    {
                                        return BetterResult.Equal;
                                    }

                                    bool leftWins = IsEncompassedBy(null, leftType, rightType, ref _useSiteDiagnostics);
                                    bool rightWins = IsEncompassedBy(null, rightType, leftType, ref _useSiteDiagnostics);
                                    if (leftWins == rightWins)
                                    {
                                        return BetterResult.Neither;
                                    }
                                    return leftWins ? BetterResult.Left : BetterResult.Right;
                                })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 37008, 37049);

                useSiteDiagnostics = _useSiteDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 37063, 37119);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10850, 37070, 37082) || ((best == null && DynAbs.Tracing.TraceSender.Conditional_F2(10850, 37085, 37089)) || DynAbs.Tracing.TraceSender.Conditional_F3(10850, 37092, 37118))) ? null : f_10850_37092_37118<T>(extract, items[f_10850_37106_37116<T>(best)]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 34495, 37130);

                int?
                f_10850_36124_36991<T>(System.Collections.Immutable.ImmutableArray<T>
                items, System.Func<T, bool>
                valid, System.Func<T, T, Microsoft.CodeAnalysis.CSharp.BetterResult>
                better)
                {
                    var return_v = UniqueBestValidIndex(items, valid, better);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 36124, 36991);
                    return return_v;
                }


                int
                f_10850_37106_37116<T>(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10850, 37106, 37116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_37092_37118<T>(System.Func<T, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 37092, 37118);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 34495, 37130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 34495, 37130);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol MostEncompassingType<T>(
                    ImmutableArray<T> items,
                    Func<T, TypeSymbol> extract,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 37142, 37444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 37351, 37433);

                return f_10850_37358_37432<T>(this, items, x => true, extract, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 37142, 37444);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_37358_37432<T>(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<T>
                items, System.Func<T, bool>
                valid, System.Func<T, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                extract, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostEncompassingType<T>(items, valid, extract, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 37358, 37432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 37142, 37444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 37142, 37444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol MostEncompassingType<T>(
                    ImmutableArray<T> items,
                    Func<T, bool> valid,
                    Func<T, TypeSymbol> extract,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 37456, 38832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 37735, 37800);

                HashSet<DiagnosticInfo>
                _useSiteDiagnostics = useSiteDiagnostics
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 37814, 38694);

                int?
                best = f_10850_37826_38693<T>(items, valid, (left, right) =>
                                {
                                    TypeSymbol leftType = extract(left);
                                    TypeSymbol rightType = extract(right);
                                    if (TypeSymbol.Equals(leftType, rightType, TypeCompareKind.ConsiderEverything2))
                                    {
                                        return BetterResult.Equal;
                                    }

                                    bool leftWins = IsEncompassedBy(null, rightType, leftType, ref _useSiteDiagnostics);
                                    bool rightWins = IsEncompassedBy(null, leftType, rightType, ref _useSiteDiagnostics);
                                    if (leftWins == rightWins)
                                    {
                                        return BetterResult.Neither;
                                    }
                                    return leftWins ? BetterResult.Left : BetterResult.Right;
                                })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 38710, 38751);

                useSiteDiagnostics = _useSiteDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 38765, 38821);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10850, 38772, 38784) || ((best == null && DynAbs.Tracing.TraceSender.Conditional_F2(10850, 38787, 38791)) || DynAbs.Tracing.TraceSender.Conditional_F3(10850, 38794, 38820))) ? null : f_10850_38794_38820<T>(extract, items[f_10850_38808_38818<T>(best)]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 37456, 38832);

                int?
                f_10850_37826_38693<T>(System.Collections.Immutable.ImmutableArray<T>
                items, System.Func<T, bool>
                valid, System.Func<T, T, Microsoft.CodeAnalysis.CSharp.BetterResult>
                better)
                {
                    var return_v = UniqueBestValidIndex(items, valid, better);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 37826, 38693);
                    return return_v;
                }


                int
                f_10850_38808_38818<T>(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10850, 38808, 38818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10850_38794_38820<T>(System.Func<T, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 38794, 38820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 37456, 38832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 37456, 38832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int? UniqueBestValidIndex<T>(ImmutableArray<T> items, Func<T, bool> valid, Func<T, T, BetterResult> better)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10850, 39754, 42778);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 39901, 39979) || true) && (items.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 39901, 39979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 39952, 39964);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 39901, 39979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 39995, 40022);

                int?
                candidateIndex = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40036, 40065);

                T
                candidateItem = default(T)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40090, 40106);

                    for (int
        currentIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40081, 41713) || true) && (currentIndex < items.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40137, 40151)
        , ++currentIndex, DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 40081, 41713))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 40081, 41713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40185, 40221);

                        T
                        currentItem = items[currentIndex]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40239, 40332) || true) && (!f_10850_40244_40262<T>(valid, currentItem))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 40239, 40332);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40304, 40313);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 40239, 40332);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40352, 40550) || true) && (candidateIndex == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 40352, 40550);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40420, 40450);

                            candidateIndex = currentIndex;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40472, 40500);

                            candidateItem = currentItem;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40522, 40531);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 40352, 40550);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40570, 40627);

                        BetterResult
                        result = f_10850_40592_40626<T>(better, candidateItem, currentItem)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40647, 41563) || true) && (result == BetterResult.Equal)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 40647, 41563);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40795, 40804);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 40647, 41563);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 40647, 41563);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 40846, 41563) || true) && (result == BetterResult.Neither)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 40846, 41563);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 41146, 41168);

                                candidateIndex = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 41190, 41217);

                                candidateItem = default(T);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 40846, 41563);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 40846, 41563);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 41259, 41563) || true) && (result == BetterResult.Right)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 41259, 41563);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 41464, 41494);

                                    candidateIndex = currentIndex;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 41516, 41544);

                                    candidateItem = currentItem;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 41259, 41563);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 40846, 41563);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 40647, 41563);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10850, 1, 1633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10850, 1, 1633);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 41729, 41816) || true) && (candidateIndex == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 41729, 41816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 41789, 41801);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 41729, 41816);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42015, 42031);

                    // We had a candidate that was better than everything that came *after* it.
                    // Now verify that it was better than everything that came before it.

                    for (int
        currentIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42006, 42649) || true) && (currentIndex < f_10850_42048_42068<T>(candidateIndex))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42070, 42084)
        , ++currentIndex, DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 42006, 42649))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 42006, 42649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42118, 42154);

                        T
                        currentItem = items[currentIndex]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42172, 42265) || true) && (!f_10850_42177_42195<T>(valid, currentItem))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 42172, 42265);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42237, 42246);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 42172, 42265);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42285, 42342);

                        BetterResult
                        result = f_10850_42307_42341<T>(better, candidateItem, currentItem)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42360, 42634) || true) && (result != BetterResult.Left && (DynAbs.Tracing.TraceSender.Expression_True(10850, 42364, 42423) && result != BetterResult.Equal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 42360, 42634);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42603, 42615);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 42360, 42634);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10850, 1, 644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10850, 1, 644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42745, 42767);

                return candidateIndex;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10850, 39754, 42778);

                bool
                f_10850_40244_40262<T>(System.Func<T, bool>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 40244, 40262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10850_40592_40626<T>(System.Func<T, T, Microsoft.CodeAnalysis.CSharp.BetterResult>
                this_param, T?
                arg1, T
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 40592, 40626);
                    return return_v;
                }


                int
                f_10850_42048_42068<T>(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10850, 42048, 42068);
                    return return_v;
                }


                bool
                f_10850_42177_42195<T>(System.Func<T, bool>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 42177, 42195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10850_42307_42341<T>(System.Func<T, T, Microsoft.CodeAnalysis.CSharp.BetterResult>
                this_param, T?
                arg1, T
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 42307, 42341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 39754, 42778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 39754, 42778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol MakeNullableType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 42790, 43014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42872, 42957);

                var
                nullable = f_10850_42887_42956(this.corLibrary, SpecialType.System_Nullable_T)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 42971, 43003);

                return f_10850_42978_43002(nullable, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 42790, 43014);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10850_42887_42956(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetDeclaredSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 42887, 42956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10850_42978_43002(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 42978, 43002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 42790, 43014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 42790, 43014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected UserDefinedConversionResult AnalyzeImplicitUserDefinedConversionForV6SwitchGoverningType(TypeSymbol source, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10850, 43160, 49848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 44316, 44353);

                f_10850_44316_44352((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 44367, 44420);

                f_10850_44367_44419(!f_10850_44381_44418(source));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 48547, 48599);

                var
                d = f_10850_48555_48598()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 48613, 48724);

                f_10850_48613_48723(source, t: null, d: d, useSiteDiagnostics: ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 49044, 49115);

                var
                ubuild = f_10850_49057_49114()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 49129, 49290);

                f_10850_49129_49289(this, null, source, target: null, d: d, u: ubuild, useSiteDiagnostics: ref useSiteDiagnostics, allowAnyTarget: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 49304, 49313);

                f_10850_49304_49312(d);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 49327, 49405);

                ImmutableArray<UserDefinedConversionAnalysis>
                u = f_10850_49377_49404(ubuild)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 49495, 49626);

                int?
                best = f_10850_49507_49625(conv => conv.ToType.IsValidV6SwitchGoverningType(isTargetTypeOfUserDefinedOp: true), u)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 49640, 49761) || true) && (best != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10850, 49640, 49761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 49690, 49746);

                    return UserDefinedConversionResult.Valid(u, f_10850_49734_49744(best));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10850, 49640, 49761);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10850, 49777, 49837);

                return UserDefinedConversionResult.NoApplicableOperators(u);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10850, 43160, 49848);

                int
                f_10850_44316_44352(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 44316, 44352);
                    return 0;
                }


                bool
                f_10850_44381_44418(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsValidV6SwitchGoverningType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 44381, 44418);
                    return return_v;
                }


                int
                f_10850_44367_44419(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 44367, 44419);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10850_48555_48598()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 48555, 48598);
                    return return_v;
                }


                int
                f_10850_48613_48723(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                s, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                d, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    ComputeUserDefinedImplicitConversionTypeSet(s, t: t, d: d, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 48613, 48723);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                f_10850_49057_49114()
                {
                    var return_v = ArrayBuilder<UserDefinedConversionAnalysis>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 49057, 49114);
                    return return_v;
                }


                int
                f_10850_49129_49289(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                d, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                allowAnyTarget)
                {
                    this_param.ComputeApplicableUserDefinedImplicitConversionSet(sourceExpression, source, target: target, d: d, u: u, useSiteDiagnostics: ref useSiteDiagnostics, allowAnyTarget: allowAnyTarget);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 49129, 49289);
                    return 0;
                }


                int
                f_10850_49304_49312(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 49304, 49312);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                f_10850_49377_49404(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 49377, 49404);
                    return return_v;
                }


                int?
                f_10850_49507_49625(System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, bool>
                constraint, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u)
                {
                    var return_v = MostSpecificConversionOperator(constraint, u);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10850, 49507, 49625);
                    return return_v;
                }


                int
                f_10850_49734_49744(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10850, 49734, 49744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10850, 43160, 49848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10850, 43160, 49848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
