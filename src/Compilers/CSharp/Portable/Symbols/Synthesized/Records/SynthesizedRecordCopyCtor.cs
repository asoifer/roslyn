// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordCopyCtor : SynthesizedInstanceConstructor
    {
        private readonly int _memberOffset;

        public SynthesizedRecordCopyCtor(
                    SourceMemberContainerTypeSymbol containingType,
                    int memberOffset)
        : base(f_10720_688_702_C(containingType))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10720, 542, 1094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 516, 529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 728, 757);

                _memberOffset = memberOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 771, 1083);

                Parameters = f_10720_784_1082(f_10720_806_1081(this, TypeWithAnnotations.Create(isNullableEnabled: true, f_10720_976_990()), ordinal: 0, RefKind.None, "original"));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10720, 542, 1094);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10720, 542, 1094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10720, 542, 1094);
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters { get; }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10720, 1237, 1313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 1240, 1313);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10720, 1240, 1263) || ((f_10720_1240_1263(f_10720_1240_1254()) && DynAbs.Tracing.TraceSender.Conditional_F2(10720, 1266, 1287)) || DynAbs.Tracing.TraceSender.Conditional_F3(10720, 1290, 1313))) ? Accessibility.Private : Accessibility.Protected; DynAbs.Tracing.TraceSender.TraceExitMethod(10720, 1237, 1313);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10720, 1237, 1313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10720, 1237, 1313);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LexicalSortKey GetLexicalSortKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10720, 1379, 1435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 1382, 1435);
                return LexicalSortKey.GetSynthesizedMemberKey(_memberOffset); DynAbs.Tracing.TraceSender.TraceExitMethod(10720, 1379, 1435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10720, 1379, 1435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10720, 1379, 1435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void GenerateMethodBodyStatements(SyntheticBoundNodeFactory F, ArrayBuilder<BoundStatement> statements, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10720, 1448, 2358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 2033, 2072);

                var
                param = f_10720_2045_2071(F, f_10720_2057_2067()[0])
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 2086, 2347);
                    foreach (var field in f_10720_2108_2140_I(f_10720_2108_2140(f_10720_2108_2122())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10720, 2086, 2347);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 2174, 2332) || true) && (f_10720_2178_2193_M(!field.IsStatic))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10720, 2174, 2332);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 2235, 2313);

                            f_10720_2235_2312(statements, f_10720_2250_2311(F, f_10720_2263_2287(F, f_10720_2271_2279(F), field), f_10720_2289_2310(F, param, field)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10720, 2174, 2332);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10720, 2086, 2347);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10720, 1, 262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10720, 1, 262);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10720, 1448, 2358);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10720_2057_2067()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 2057, 2067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10720_2045_2071(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 2045, 2071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10720_2108_2122()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 2108, 2122);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10720_2108_2140(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetFieldsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 2108, 2140);
                    return return_v;
                }


                bool
                f_10720_2178_2193_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 2178, 2193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10720_2271_2279(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 2271, 2279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10720_2263_2287(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 2263, 2287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10720_2289_2310(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 2289, 2310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10720_2250_2311(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 2250, 2311);
                    return return_v;
                }


                int
                f_10720_2235_2312(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 2235, 2312);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10720_2108_2140_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 2108, 2140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10720, 1448, 2358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10720, 1448, 2358);
            }
        }

        internal static MethodSymbol? FindCopyConstructor(NamedTypeSymbol containingType, NamedTypeSymbol within, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10720, 2370, 4137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 2548, 2583);

                MethodSymbol?
                bestCandidate = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 2597, 2629);

                int
                bestModifierCountSoFar = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 2685, 4089);
                    foreach (var member in f_10720_2708_2743_I(f_10720_2708_2743(containingType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10720, 2685, 4089);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 2777, 4074) || true) && (f_10720_2781_2816(member) && (DynAbs.Tracing.TraceSender.Expression_True(10720, 2781, 2871) && f_10720_2841_2871_M(!member.HasUnsupportedMetadata)) && (DynAbs.Tracing.TraceSender.Expression_True(10720, 2781, 2966) && f_10720_2896_2966(member, within, ref useSiteDiagnostics)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10720, 2777, 4074);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3154, 3340) || true) && (bestCandidate is null && (DynAbs.Tracing.TraceSender.Expression_True(10720, 3158, 3209) && bestModifierCountSoFar < 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10720, 3154, 3340);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3259, 3282);

                                bestCandidate = member;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3308, 3317);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10720, 3154, 3340);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3364, 3528) || true) && (bestModifierCountSoFar < 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10720, 3364, 3528);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3444, 3505);

                                bestModifierCountSoFar = f_10720_3469_3504(bestCandidate);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10720, 3364, 3528);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3552, 3602);

                            var
                            memberModCount = f_10720_3573_3601(member)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3624, 3749) || true) && (memberModCount > bestModifierCountSoFar)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10720, 3624, 3749);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3717, 3726);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10720, 3624, 3749);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3773, 3946) || true) && (memberModCount == bestModifierCountSoFar)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10720, 3773, 3946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3867, 3888);

                                bestCandidate = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3914, 3923);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10720, 3773, 3946);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 3970, 3993);

                            bestCandidate = member;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 4015, 4055);

                            bestModifierCountSoFar = memberModCount;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10720, 2777, 4074);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10720, 2685, 4089);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10720, 1, 1405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10720, 1, 1405);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 4105, 4126);

                return bestCandidate;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10720, 2370, 4137);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10720_2708_2743(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 2708, 2743);
                    return return_v;
                }


                bool
                f_10720_2781_2816(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = HasCopyConstructorSignature(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 2781, 2816);
                    return return_v;
                }


                bool
                f_10720_2841_2871_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 2841, 2871);
                    return return_v;
                }


                bool
                f_10720_2896_2966(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = AccessCheck.IsSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 2896, 2966);
                    return return_v;
                }


                int
                f_10720_3469_3504(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    var return_v = method.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 3469, 3504);
                    return return_v;
                }


                int
                f_10720_3573_3601(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 3573, 3601);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10720_2708_2743_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 2708, 2743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10720, 2370, 4137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10720, 2370, 4137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsCopyConstructor(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10720, 4149, 4431);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 4227, 4391) || true) && (member is MethodSymbol { MethodKind: MethodKind.Constructor } method)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10720, 4227, 4391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 4333, 4376);

                    return f_10720_4340_4375(method);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10720, 4227, 4391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 4407, 4420);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10720, 4149, 4431);

                bool
                f_10720_4340_4375(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = HasCopyConstructorSignature(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 4340, 4375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10720, 4149, 4431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10720, 4149, 4431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasCopyConstructorSignature(MethodSymbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10720, 4443, 4871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 4537, 4592);

                NamedTypeSymbol
                containingType = f_10720_4570_4591(member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10720, 4606, 4860);

                return member is MethodSymbol { IsStatic: false, ParameterCount: 1, Arity: 0 } method && (DynAbs.Tracing.TraceSender.Expression_True(10720, 4613, 4794) && f_10720_4712_4794(f_10720_4712_4737(f_10720_4712_4729(method)[0]), containingType, TypeCompareKind.AllIgnoreOptions)) && (DynAbs.Tracing.TraceSender.Expression_True(10720, 4613, 4859) && f_10720_4815_4843(f_10720_4815_4832(method)[0]) == RefKind.None);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10720, 4443, 4871);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10720_4570_4591(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 4570, 4591);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10720_4712_4729(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 4712, 4729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10720_4712_4737(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 4712, 4737);
                    return return_v;
                }


                bool
                f_10720_4712_4794(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 4712, 4794);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10720_4815_4832(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 4815, 4832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10720_4815_4843(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 4815, 4843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10720, 4443, 4871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10720, 4443, 4871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedRecordCopyCtor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10720, 398, 4878);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10720, 398, 4878);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10720, 398, 4878);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10720, 398, 4878);

        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10720_976_990()
        {
            var return_v = ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 976, 990);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10720_806_1081(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordCopyCtor
        container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        type, int
        ordinal, Microsoft.CodeAnalysis.RefKind
        refKind, string
        name)
        {
            var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal: ordinal, refKind, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 806, 1081);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10720_784_1082(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10720, 784, 1082);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10720_688_702_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10720, 542, 1094);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10720_1240_1254()
        {
            var return_v = ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 1240, 1254);
            return return_v;
        }


        bool
        f_10720_1240_1263(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsSealed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10720, 1240, 1263);
            return return_v;
        }

    }
}
