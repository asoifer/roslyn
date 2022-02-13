// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class ConversionsBase
    {
        private UserDefinedConversionResult AnalyzeExplicitUserDefinedConversions(
                   BoundExpression sourceExpression,
                   TypeSymbol source,
                   TypeSymbol target,
                   ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10849, 625, 3107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 892, 957);

                f_10849_892_956(sourceExpression != null || (DynAbs.Tracing.TraceSender.Expression_False(10849, 905, 955) || (object)source != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 971, 1008);

                f_10849_971_1007((object)target != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 1287, 1339);

                var
                d = f_10849_1295_1338()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 1353, 1440);

                f_10849_1353_1439(source, target, d, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 1556, 1627);

                var
                ubuild = f_10849_1569_1626()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 1641, 1760);

                f_10849_1641_1759(this, sourceExpression, source, target, d, ubuild, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 1774, 1783);

                f_10849_1774_1782(d);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 1797, 1875);

                ImmutableArray<UserDefinedConversionAnalysis>
                u = f_10849_1847_1874(ubuild)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 1989, 2115) || true) && (u.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 1989, 2115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 2040, 2100);

                    return UserDefinedConversionResult.NoApplicableOperators(u);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 1989, 2115);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 2216, 2340);

                TypeSymbol
                sx = f_10849_2232_2339(this, u, sourceExpression, source, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 2354, 2480) || true) && ((object)sx == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 2354, 2480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 2410, 2465);

                    return UserDefinedConversionResult.NoBestSourceType(u);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 2354, 2480);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 2581, 2687);

                TypeSymbol
                tx = f_10849_2597_2686(this, u, target, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 2701, 2827) || true) && ((object)tx == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 2701, 2827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 2757, 2812);

                    return UserDefinedConversionResult.NoBestTargetType(u);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 2701, 2827);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 2843, 2897);

                int?
                best = f_10849_2855_2896(sx, tx, u)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 2911, 3024) || true) && (best == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 2911, 3024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 2961, 3009);

                    return UserDefinedConversionResult.Ambiguous(u);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 2911, 3024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 3040, 3096);

                return UserDefinedConversionResult.Valid(u, f_10849_3084_3094(best));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10849, 625, 3107);

                int
                f_10849_892_956(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 892, 956);
                    return 0;
                }


                int
                f_10849_971_1007(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 971, 1007);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10849_1295_1338()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 1295, 1338);
                    return return_v;
                }


                int
                f_10849_1353_1439(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                d, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    ComputeUserDefinedExplicitConversionTypeSet(source, target, d, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 1353, 1439);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                f_10849_1569_1626()
                {
                    var return_v = ArrayBuilder<UserDefinedConversionAnalysis>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 1569, 1626);
                    return return_v;
                }


                int
                f_10849_1641_1759(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                d, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.ComputeApplicableUserDefinedExplicitConversionSet(sourceExpression, source, target, d, u, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 1641, 1759);
                    return 0;
                }


                int
                f_10849_1774_1782(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 1774, 1782);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                f_10849_1847_1874(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 1847, 1874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_2232_2339(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostSpecificSourceTypeForExplicitUserDefinedConversion(u, sourceExpression, source, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 2232, 2339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_2597_2686(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostSpecificTargetTypeForExplicitUserDefinedConversion(u, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 2597, 2686);
                    return return_v;
                }


                int?
                f_10849_2855_2896(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sx, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                tx, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u)
                {
                    var return_v = MostSpecificConversionOperator(sx, tx, u);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 2855, 2896);
                    return return_v;
                }


                int
                f_10849_3084_3094(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10849, 3084, 3094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10849, 625, 3107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10849, 625, 3107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ComputeUserDefinedExplicitConversionTypeSet(TypeSymbol source, TypeSymbol target, ArrayBuilder<NamedTypeSymbol> d, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10849, 3119, 4158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 3326, 3401);

                TypeSymbol
                s0 = f_10849_3342_3400(source, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 3415, 3490);

                TypeSymbol
                t0 = f_10849_3431_3489(target, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 3893, 4013);

                f_10849_3893_4012(d, s0, includeBaseTypes: true, useSiteDiagnostics: ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 4027, 4147);

                f_10849_4027_4146(d, t0, includeBaseTypes: true, useSiteDiagnostics: ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10849, 3119, 4158);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_3342_3400(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = GetUnderlyingEffectiveType(type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 3342, 3400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_3431_3489(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = GetUnderlyingEffectiveType(type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 3431, 3489);
                    return return_v;
                }


                int
                f_10849_3893_4012(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                includeBaseTypes, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    AddTypesParticipatingInUserDefinedConversion(result, type, includeBaseTypes: includeBaseTypes, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 3893, 4012);
                    return 0;
                }


                int
                f_10849_4027_4146(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                includeBaseTypes, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    AddTypesParticipatingInUserDefinedConversion(result, type, includeBaseTypes: includeBaseTypes, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 4027, 4146);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10849, 3119, 4158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10849, 3119, 4158);
            }
        }

        private void ComputeApplicableUserDefinedExplicitConversionSet(
                    BoundExpression sourceExpression,
                    TypeSymbol source,
                    TypeSymbol target,
                    ArrayBuilder<NamedTypeSymbol> d,
                    ArrayBuilder<UserDefinedConversionAnalysis> u,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10849, 4170, 5203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 4536, 4601);

                f_10849_4536_4600(sourceExpression != null || (DynAbs.Tracing.TraceSender.Expression_False(10849, 4549, 4599) || (object)source != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 4615, 4652);

                f_10849_4615_4651((object)target != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 4666, 4690);

                f_10849_4666_4689(d != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 4704, 4728);

                f_10849_4704_4727(u != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 4744, 5192);
                    foreach (NamedTypeSymbol declaringType in f_10849_4786_4787_I(d))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 4744, 5192);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 4821, 4990);

                        f_10849_4821_4989(this, sourceExpression, source, target, u, declaringType, WellKnownMemberNames.ExplicitConversionName, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 5008, 5177);

                        f_10849_5008_5176(this, sourceExpression, source, target, u, declaringType, WellKnownMemberNames.ImplicitConversionName, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 4744, 5192);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10849, 1, 449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10849, 1, 449);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10849, 4170, 5203);

                int
                f_10849_4536_4600(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 4536, 4600);
                    return 0;
                }


                int
                f_10849_4615_4651(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 4615, 4651);
                    return 0;
                }


                int
                f_10849_4666_4689(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 4666, 4689);
                    return 0;
                }


                int
                f_10849_4704_4727(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 4704, 4727);
                    return 0;
                }


                int
                f_10849_4821_4989(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                declaringType, string
                operatorName, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.AddUserDefinedConversionsToExplicitCandidateSet(sourceExpression, source, target, u, declaringType, operatorName, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 4821, 4989);
                    return 0;
                }


                int
                f_10849_5008_5176(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                u, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                declaringType, string
                operatorName, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.AddUserDefinedConversionsToExplicitCandidateSet(sourceExpression, source, target, u, declaringType, operatorName, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 5008, 5176);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10849_4786_4787_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 4786, 4787);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10849, 4170, 5203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10849, 4170, 5203);
            }
        }

        private void AddUserDefinedConversionsToExplicitCandidateSet(
                    BoundExpression sourceExpression,
                    TypeSymbol source,
                    TypeSymbol target,
                    ArrayBuilder<UserDefinedConversionAnalysis> u,
                    NamedTypeSymbol declaringType,
                    string operatorName,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10849, 5215, 16748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 5611, 5676);

                f_10849_5611_5675(sourceExpression != null || (DynAbs.Tracing.TraceSender.Expression_False(10849, 5624, 5674) || (object)source != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 5690, 5727);

                f_10849_5690_5726((object)target != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 5741, 5765);

                f_10849_5741_5764(u != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 5779, 5823);

                f_10849_5779_5822((object)declaringType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 5837, 5872);

                f_10849_5837_5871(operatorName != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 9709, 9847) || true) && ((object)source != null && (DynAbs.Tracing.TraceSender.Expression_True(10849, 9713, 9763) && f_10849_9739_9763(source)) || (DynAbs.Tracing.TraceSender.Expression_False(10849, 9713, 9791) || f_10849_9767_9791(target)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 9709, 9847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 9825, 9832);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 9709, 9847);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 9863, 16737);
                    foreach (MethodSymbol op in f_10849_9891_9931_I(f_10849_9891_9931(declaringType, operatorName)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 9863, 16737);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 10064, 10222) || true) && (f_10849_10068_10082(op) || (DynAbs.Tracing.TraceSender.Expression_False(10849, 10068, 10108) || f_10849_10086_10103(op) != 1) || (DynAbs.Tracing.TraceSender.Expression_False(10849, 10068, 10152) || f_10849_10112_10134(f_10849_10112_10125(op)) == TypeKind.Error))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 10064, 10222);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 10194, 10203);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 10064, 10222);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 10242, 10291);

                        TypeSymbol
                        convertsFrom = f_10849_10268_10290(op, 0)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 10309, 10347);

                        TypeSymbol
                        convertsTo = f_10849_10333_10346(op)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 10365, 10488);

                        Conversion
                        fromConversion = f_10849_10393_10487(this, sourceExpression, source, convertsFrom, ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 10506, 10613);

                        Conversion
                        toConversion = f_10849_10532_10612(this, null, convertsTo, target, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 10745, 11158) || true) && (f_10849_10749_10771_M(!fromConversion.Exists) && (DynAbs.Tracing.TraceSender.Expression_True(10849, 10749, 10818) && (object)source != null) && (DynAbs.Tracing.TraceSender.Expression_True(10849, 10749, 10866) && f_10849_10843_10866(source)) && (DynAbs.Tracing.TraceSender.Expression_True(10849, 10749, 11008) && f_10849_10891_11001(this, null, f_10849_10928_10962(source), convertsFrom, ref useSiteDiagnostics).Exists))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 10745, 11158);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 11050, 11139);

                            fromConversion = f_10849_11067_11138(this, source, convertsFrom, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 10745, 11158);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 11332, 11737) || true) && (f_10849_11336_11356_M(!toConversion.Exists) && (DynAbs.Tracing.TraceSender.Expression_True(10849, 11336, 11403) && (object)target != null) && (DynAbs.Tracing.TraceSender.Expression_True(10849, 11336, 11451) && f_10849_11428_11451(target)) && (DynAbs.Tracing.TraceSender.Expression_True(10849, 11336, 11591) && f_10849_11476_11584(this, null, convertsTo, f_10849_11525_11559(target), ref useSiteDiagnostics).Exists))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 11332, 11737);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 11633, 11718);

                            toConversion = f_10849_11648_11717(this, convertsTo, target, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 11332, 11737);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 13582, 16722) || true) && (fromConversion.Exists && (DynAbs.Tracing.TraceSender.Expression_True(10849, 13586, 13630) && toConversion.Exists))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 13582, 16722);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 13672, 16703) || true) && ((object)source != null && (DynAbs.Tracing.TraceSender.Expression_True(10849, 13676, 13725) && f_10849_13702_13725(source)) && (DynAbs.Tracing.TraceSender.Expression_True(10849, 13676, 13766) && f_10849_13729_13766(convertsFrom)) && (DynAbs.Tracing.TraceSender.Expression_True(10849, 13676, 13796) && f_10849_13770_13796(target)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 13672, 16703);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 13846, 13903);

                                TypeSymbol
                                nullableFrom = f_10849_13872_13902(this, convertsFrom)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 13929, 14033);

                                TypeSymbol
                                nullableTo = (DynAbs.Tracing.TraceSender.Conditional_F1(10849, 13953, 13988) || ((f_10849_13953_13988(convertsTo) && DynAbs.Tracing.TraceSender.Conditional_F2(10849, 13991, 14019)) || DynAbs.Tracing.TraceSender.Conditional_F3(10849, 14022, 14032))) ? f_10849_13991_14019(this, convertsTo) : convertsTo
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 14059, 14188);

                                Conversion
                                liftedFromConversion = f_10849_14093_14187(this, sourceExpression, source, nullableFrom, ref useSiteDiagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 14214, 14327);

                                Conversion
                                liftedToConversion = f_10849_14246_14326(this, null, nullableTo, target, ref useSiteDiagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 14353, 14395);

                                f_10849_14353_14394(liftedFromConversion.Exists);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 14421, 14461);

                                f_10849_14421_14460(liftedToConversion.Exists);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 14487, 14603);

                                f_10849_14487_14602(u, f_10849_14493_14601(op, liftedFromConversion, liftedToConversion, nullableFrom, nullableTo));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 13672, 16703);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 13672, 16703);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 15846, 16165) || true) && (f_10849_15850_15873(target) && (DynAbs.Tracing.TraceSender.Expression_True(10849, 15850, 15912) && f_10849_15877_15912(convertsTo)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 15846, 16165);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 15970, 16012);

                                    convertsTo = f_10849_15983_16011(this, convertsTo);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 16042, 16138);

                                    toConversion = f_10849_16057_16137(this, null, convertsTo, target, ref useSiteDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 15846, 16165);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 16193, 16548) || true) && ((object)source != null && (DynAbs.Tracing.TraceSender.Expression_True(10849, 16197, 16246) && f_10849_16223_16246(source)) && (DynAbs.Tracing.TraceSender.Expression_True(10849, 16197, 16287) && f_10849_16250_16287(convertsFrom)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 16193, 16548);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 16345, 16391);

                                    convertsFrom = f_10849_16360_16390(this, convertsFrom);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 16421, 16521);

                                    fromConversion = f_10849_16438_16520(this, null, convertsFrom, source, ref useSiteDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 16193, 16548);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 16576, 16680);

                                f_10849_16576_16679(
                                                        u, f_10849_16582_16678(op, fromConversion, toConversion, convertsFrom, convertsTo));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 13672, 16703);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 13582, 16722);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 9863, 16737);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10849, 1, 6875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10849, 1, 6875);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10849, 5215, 16748);

                int
                f_10849_5611_5675(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 5611, 5675);
                    return 0;
                }


                int
                f_10849_5690_5726(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 5690, 5726);
                    return 0;
                }


                int
                f_10849_5741_5764(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 5741, 5764);
                    return 0;
                }


                int
                f_10849_5779_5822(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 5779, 5822);
                    return 0;
                }


                int
                f_10849_5837_5871(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 5837, 5871);
                    return 0;
                }


                bool
                f_10849_9739_9763(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 9739, 9763);
                    return return_v;
                }


                bool
                f_10849_9767_9791(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 9767, 9791);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10849_9891_9931(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetOperators(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 9891, 9931);
                    return return_v;
                }


                bool
                f_10849_10068_10082(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10849, 10068, 10082);
                    return return_v;
                }


                int
                f_10849_10086_10103(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10849, 10086, 10103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_10112_10125(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10849, 10112, 10125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10849_10112_10134(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10849, 10112, 10134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_10268_10290(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 10268, 10290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_10333_10346(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10849, 10333, 10346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10849_10393_10487(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingExplicitConversion(expr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 10393, 10487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10849_10532_10612(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingExplicitConversion(expr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 10532, 10612);
                    return return_v;
                }


                bool
                f_10849_10749_10771_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10849, 10749, 10771);
                    return return_v;
                }


                bool
                f_10849_10843_10866(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 10843, 10866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_10928_10962(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 10928, 10962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10849_10891_11001(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingExplicitConversion(expr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 10891, 11001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10849_11067_11138(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyBuiltInConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 11067, 11138);
                    return return_v;
                }


                bool
                f_10849_11336_11356_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10849, 11336, 11356);
                    return return_v;
                }


                bool
                f_10849_11428_11451(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 11428, 11451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_11525_11559(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 11525, 11559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10849_11476_11584(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingExplicitConversion(expr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 11476, 11584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10849_11648_11717(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyBuiltInConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 11648, 11717);
                    return return_v;
                }


                bool
                f_10849_13702_13725(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 13702, 13725);
                    return return_v;
                }


                bool
                f_10849_13729_13766(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 13729, 13766);
                    return return_v;
                }


                bool
                f_10849_13770_13796(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.CanBeAssignedNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 13770, 13796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10849_13872_13902(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullableType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 13872, 13902);
                    return return_v;
                }


                bool
                f_10849_13953_13988(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 13953, 13988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10849_13991_14019(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullableType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 13991, 14019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10849_14093_14187(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingExplicitConversion(expr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 14093, 14187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10849_14246_14326(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingExplicitConversion(expr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 14246, 14326);
                    return return_v;
                }


                int
                f_10849_14353_14394(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 14353, 14394);
                    return 0;
                }


                int
                f_10849_14421_14460(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 14421, 14460);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                f_10849_14493_14601(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                op, Microsoft.CodeAnalysis.CSharp.Conversion
                sourceConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                targetConversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = UserDefinedConversionAnalysis.Lifted(op, sourceConversion, targetConversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 14493, 14601);
                    return return_v;
                }


                int
                f_10849_14487_14602(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                this_param, Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 14487, 14602);
                    return 0;
                }


                bool
                f_10849_15850_15873(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 15850, 15873);
                    return return_v;
                }


                bool
                f_10849_15877_15912(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 15877, 15912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10849_15983_16011(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullableType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 15983, 16011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10849_16057_16137(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingExplicitConversion(expr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 16057, 16137);
                    return return_v;
                }


                bool
                f_10849_16223_16246(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 16223, 16246);
                    return return_v;
                }


                bool
                f_10849_16250_16287(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 16250, 16287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10849_16360_16390(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullableType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 16360, 16390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10849_16438_16520(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EncompassingExplicitConversion(expr, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 16438, 16520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                f_10849_16582_16678(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                op, Microsoft.CodeAnalysis.CSharp.Conversion
                sourceConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                targetConversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = UserDefinedConversionAnalysis.Normal(op, sourceConversion, targetConversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 16582, 16678);
                    return return_v;
                }


                int
                f_10849_16576_16679(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                this_param, Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 16576, 16679);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10849_9891_9931_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 9891, 9931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10849, 5215, 16748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10849, 5215, 16748);
            }
        }

        private TypeSymbol MostSpecificSourceTypeForExplicitUserDefinedConversion(
                    ImmutableArray<UserDefinedConversionAnalysis> u,
                    BoundExpression sourceExpression,
                    TypeSymbol source,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10849, 16760, 19871);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 18916, 19764) || true) && ((object)source != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 18916, 19764);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 18976, 19147) || true) && (u.Any(conv => TypeSymbol.Equals(conv.FromType, source, TypeCompareKind.ConsiderEverything2)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 18976, 19147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 19114, 19128);

                        return source;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 18976, 19147);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 19167, 19232);

                    HashSet<DiagnosticInfo>
                    _useSiteDiagnostics = useSiteDiagnostics
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 19250, 19399);

                    System.Func<UserDefinedConversionAnalysis, bool>
                    isValid = conv => IsEncompassedBy(sourceExpression, source, conv.FromType, ref _useSiteDiagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 19417, 19688) || true) && (u.Any(isValid))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 19417, 19688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 19477, 19570);

                        var
                        result = f_10849_19490_19569(this, u, isValid, conv => conv.FromType, ref _useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 19592, 19633);

                        useSiteDiagnostics = _useSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 19655, 19669);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 19417, 19688);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 19708, 19749);

                    useSiteDiagnostics = _useSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 18916, 19764);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 19782, 19860);

                return f_10849_19789_19859(this, u, conv => conv.FromType, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10849, 16760, 19871);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_19490_19569(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, bool>
                valid, System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                extract, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostEncompassedType<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>(items, valid, extract, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 19490, 19569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_19789_19859(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                extract, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostEncompassingType<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>(items, extract, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 19789, 19859);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10849, 16760, 19871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10849, 16760, 19871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol MostSpecificTargetTypeForExplicitUserDefinedConversion(
                    ImmutableArray<UserDefinedConversionAnalysis> u,
                    TypeSymbol target,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10849, 19883, 22771);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 21963, 22120) || true) && (u.Any(conv => TypeSymbol.Equals(conv.ToType, target, TypeCompareKind.ConsiderEverything2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 21963, 22120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 22091, 22105);

                    return target;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 21963, 22120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 22136, 22201);

                HashSet<DiagnosticInfo>
                _useSiteDiagnostics = useSiteDiagnostics
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 22215, 22350);

                System.Func<UserDefinedConversionAnalysis, bool>
                isValid = conv => IsEncompassedBy(null, conv.ToType, target, ref _useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 22364, 22614) || true) && (u.Any(isValid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10849, 22364, 22614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 22416, 22508);

                    var
                    result = f_10849_22429_22507(this, u, isValid, conv => conv.ToType, ref _useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 22526, 22567);

                    useSiteDiagnostics = _useSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 22585, 22599);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10849, 22364, 22614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 22630, 22671);

                useSiteDiagnostics = _useSiteDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 22685, 22760);

                return f_10849_22692_22759(this, u, conv => conv.ToType, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10849, 19883, 22771);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_22429_22507(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, bool>
                valid, System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                extract, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostEncompassingType<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>(items, valid, extract, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 22429, 22507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10849_22692_22759(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                extract, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MostEncompassedType<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>(items, extract, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 22692, 22759);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10849, 19883, 22771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10849, 19883, 22771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion EncompassingExplicitConversion(BoundExpression expr, TypeSymbol a, TypeSymbol b, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10849, 22783, 23949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 22955, 23003);

                f_10849_22955_23002(expr != null || (DynAbs.Tracing.TraceSender.Expression_False(10849, 22968, 23001) || (object)a != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 23017, 23049);

                f_10849_23017_23048((object)b != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 23785, 23861);

                var
                result = f_10849_23798_23860(this, expr, a, b, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10849, 23875, 23938);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10849, 23882, 23902) || ((result.IsEnumeration && DynAbs.Tracing.TraceSender.Conditional_F2(10849, 23905, 23928)) || DynAbs.Tracing.TraceSender.Conditional_F3(10849, 23931, 23937))) ? Conversion.NoConversion : result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10849, 22783, 23949);

                int
                f_10849_22955_23002(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 22955, 23002);
                    return 0;
                }


                int
                f_10849_23017_23048(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 23017, 23048);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10849_23798_23860(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyStandardConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10849, 23798, 23860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10849, 22783, 23949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10849, 22783, 23949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
