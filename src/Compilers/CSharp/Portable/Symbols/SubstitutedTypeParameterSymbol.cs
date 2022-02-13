// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

//#define DEBUG_ALPHA // turn on DEBUG_ALPHA to help diagnose issues around type parameter alpha-renaming

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class SubstitutedTypeParameterSymbol : WrappedTypeParameterSymbol
    {
        private readonly Symbol _container;

        private readonly TypeMap _map;

        private readonly int _ordinal;

        internal SubstitutedTypeParameterSymbol(Symbol newContainer, TypeMap map, TypeParameterSymbol substitutedFrom, int ordinal)
        : base(f_10162_1024_1039_C(substitutedFrom))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10162, 880, 1459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 660, 670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 706, 710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 742, 750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 1065, 1091);

                _container = newContainer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 1335, 1346);

                _map = map;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 1360, 1379);

                _ordinal = ordinal;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10162, 880, 1459);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10162, 880, 1459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 880, 1459);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10162, 1535, 1604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 1571, 1589);

                    return _container;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10162, 1535, 1604);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10162, 1471, 1615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 1471, 1615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeParameterSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10162, 1706, 2195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 1978, 2180);

                    return
                    (DynAbs.Tracing.TraceSender.Conditional_F1(10162, 2006, 2105) || ((f_10162_2006_2041(f_10162_2006_2022()) != f_10162_2045_2105(f_10162_2045_2086(_underlyingTypeParameter)) && DynAbs.Tracing.TraceSender.Conditional_F2(10162, 2108, 2112)) || DynAbs.Tracing.TraceSender.Conditional_F3(10162, 2136, 2179))) ? this : f_10162_2136_2179(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10162, 1706, 2195);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10162_2006_2022()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 2006, 2022);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10162_2006_2041(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 2006, 2041);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10162_2045_2086(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 2045, 2086);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10162_2045_2105(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 2045, 2105);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10162_2136_2179(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 2136, 2179);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10162, 1627, 2206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 1627, 2206);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeParameterSymbol ReducedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10162, 2290, 2716);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 2326, 2669) || true) && (f_10162_2330_2345(_container) == SymbolKind.Method)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 2326, 2669);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 2408, 2474);

                        MethodSymbol
                        reducedFrom = f_10162_2435_2473(((MethodSymbol)_container))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 2498, 2650) || true) && ((object)reducedFrom != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 2498, 2650);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 2579, 2627);

                            return f_10162_2586_2612(reducedFrom)[f_10162_2613_2625(this)];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 2498, 2650);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 2326, 2669);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 2689, 2701);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10162, 2290, 2716);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10162_2330_2345(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 2330, 2345);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10162_2435_2473(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReducedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 2435, 2473);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10162_2586_2612(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 2586, 2612);
                        return return_v;
                    }


                    int
                    f_10162_2613_2625(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 2613, 2625);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10162, 2218, 2727);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 2218, 2727);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10162, 2791, 2858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 2827, 2843);

                    return _ordinal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10162, 2791, 2858);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10162, 2739, 2869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 2739, 2869);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10162, 2933, 3089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 2969, 3074);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Name, 10162, 2976, 2985);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10162, 2933, 3089);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10162, 2881, 3100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 2881, 3100);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> GetConstraintTypes(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10162, 3112, 5547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 3251, 3321);

                var
                constraintTypes = f_10162_3273_3320()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 3335, 3496);

                f_10162_3335_3495(_map, _underlyingTypeParameter, f_10162_3416_3471(_underlyingTypeParameter, inProgress), constraintTypes, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 3512, 3563);

                TypeWithAnnotations
                bestObjectConstraint = default
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 3634, 3663);

                    // Strip all Object constraints.
                    for (int
        i = f_10162_3638_3659(constraintTypes) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 3625, 3950) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 3673, 3676)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 3625, 3950))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 3625, 3950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 3710, 3756);

                        TypeWithAnnotations
                        type = f_10162_3737_3755(constraintTypes, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 3774, 3935) || true) && (f_10162_3778_3846(type, ref bestObjectConstraint))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 3774, 3935);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 3888, 3916);

                            f_10162_3888_3915(constraintTypes, i);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 3774, 3935);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10162, 1, 326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10162, 1, 326);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 3966, 5476) || true) && (bestObjectConstraint.HasType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 3966, 5476);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 4167, 5461) || true) && (f_10162_4171_4288(f_10162_4219_4265(this), bestObjectConstraint))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 4167, 5461);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 4330, 4393);

                        f_10162_4330_4392(f_10162_4343_4364_M(!HasNotNullConstraint) && (DynAbs.Tracing.TraceSender.Expression_True(10162, 4343, 4391) && f_10162_4368_4391_M(!HasValueTypeConstraint)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 4415, 5265) || true) && (f_10162_4419_4440(constraintTypes) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 4415, 5265);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 4495, 4699) || true) && (f_10162_4499_4552(bestObjectConstraint.NullableAnnotation) && (DynAbs.Tracing.TraceSender.Expression_True(10162, 4499, 4583) && f_10162_4556_4583_M(!HasReferenceTypeConstraint)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 4495, 4699);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 4641, 4672);

                                bestObjectConstraint = default;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 4495, 4699);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 4415, 5265);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 4415, 5265);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 4797, 5242);
                                foreach (TypeWithAnnotations constraintType in f_10162_4844_4859_I(constraintTypes))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 4797, 5242);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 4917, 5215) || true) && (!f_10162_4922_5047(f_10162_4970_5024(constraintType, out _), bestObjectConstraint))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 4917, 5215);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 5113, 5144);

                                        bestObjectConstraint = default;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10162, 5178, 5184);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 4917, 5215);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 4797, 5242);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10162, 1, 446);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10162, 1, 446);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 4415, 5265);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 5289, 5442) || true) && (bestObjectConstraint.HasType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 5289, 5442);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 5371, 5419);

                            f_10162_5371_5418(constraintTypes, 0, bestObjectConstraint);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 5289, 5442);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 4167, 5461);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 3966, 5476);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 5492, 5536);

                return f_10162_5499_5535(constraintTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10162, 3112, 5547);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10162_3273_3320()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 3273, 3320);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10162_3416_3471(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetConstraintTypes(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 3416, 3471);
                    return return_v;
                }


                int
                f_10162_3335_3495(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                owner, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                original, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                result, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                ignoreTypesDependentOnTypeParametersOpt)
                {
                    this_param.SubstituteConstraintTypesDistinctWithoutModifiers(owner, original, result, ignoreTypesDependentOnTypeParametersOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 3335, 3495);
                    return 0;
                }


                int
                f_10162_3638_3659(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 3638, 3659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10162_3737_3755(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 3737, 3755);
                    return return_v;
                }


                bool
                f_10162_3778_3846(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                bestObjectConstraint)
                {
                    var return_v = ConstraintsHelper.IsObjectConstraint(type, ref bestObjectConstraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 3778, 3846);
                    return return_v;
                }


                int
                f_10162_3888_3915(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 3888, 3915);
                    return 0;
                }


                bool?
                f_10162_4219_4265(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.CalculateIsNotNullableFromNonTypeConstraints();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 4219, 4265);
                    return return_v;
                }


                bool
                f_10162_4171_4288(bool?
                isNotNullable, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                objectConstraint)
                {
                    var return_v = ConstraintsHelper.IsObjectConstraintSignificant(isNotNullable, objectConstraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 4171, 4288);
                    return return_v;
                }


                bool
                f_10162_4343_4364_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 4343, 4364);
                    return return_v;
                }


                bool
                f_10162_4368_4391_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 4368, 4391);
                    return return_v;
                }


                int
                f_10162_4330_4392(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 4330, 4392);
                    return 0;
                }


                int
                f_10162_4419_4440(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 4419, 4440);
                    return return_v;
                }


                bool
                f_10162_4499_4552(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 4499, 4552);
                    return return_v;
                }


                bool
                f_10162_4556_4583_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 4556, 4583);
                    return return_v;
                }


                bool?
                f_10162_4970_5024(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                constraintType, out bool
                isNonNullableValueType)
                {
                    var return_v = IsNotNullableFromConstraintType(constraintType, out isNonNullableValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 4970, 5024);
                    return return_v;
                }


                bool
                f_10162_4922_5047(bool?
                isNotNullable, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                objectConstraint)
                {
                    var return_v = ConstraintsHelper.IsObjectConstraintSignificant(isNotNullable, objectConstraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 4922, 5047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10162_4844_4859_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 4844, 4859);
                    return return_v;
                }


                int
                f_10162_5371_5418(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                index, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 5371, 5418);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10162_5499_5535(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 5499, 5535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10162, 3112, 5547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 3112, 5547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool? IsNotNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10162, 5621, 6448);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 5657, 6381) || true) && (_underlyingTypeParameter.ConstraintTypesNoUseSiteDiagnostics.IsEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 5657, 6381);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 5771, 5817);

                        return f_10162_5778_5816(_underlyingTypeParameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 5657, 6381);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 5657, 6381);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 5859, 6381) || true) && (f_10162_5863_5884_M(!HasNotNullConstraint) && (DynAbs.Tracing.TraceSender.Expression_True(10162, 5863, 5911) && f_10162_5888_5911_M(!HasValueTypeConstraint)) && (DynAbs.Tracing.TraceSender.Expression_True(10162, 5863, 5942) && f_10162_5915_5942_M(!HasReferenceTypeConstraint)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10162, 5859, 6381);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 5984, 6054);

                            var
                            constraintTypes = f_10162_6006_6053()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 6076, 6262);

                            f_10162_6076_6261(_map, _underlyingTypeParameter, f_10162_6157_6237(_underlyingTypeParameter, ConsList<TypeParameterSymbol>.Empty), constraintTypes, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 6284, 6362);

                            return f_10162_6291_6361(f_10162_6324_6360(constraintTypes));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 5859, 6381);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10162, 5657, 6381);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 6401, 6433);

                    return f_10162_6408_6432(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10162, 5621, 6448);

                    bool?
                    f_10162_5778_5816(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsNotNullable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 5778, 5816);
                        return return_v;
                    }


                    bool
                    f_10162_5863_5884_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 5863, 5884);
                        return return_v;
                    }


                    bool
                    f_10162_5888_5911_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 5888, 5911);
                        return return_v;
                    }


                    bool
                    f_10162_5915_5942_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10162, 5915, 5942);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10162_6006_6053()
                    {
                        var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 6006, 6053);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10162_6157_6237(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    inProgress)
                    {
                        var return_v = this_param.GetConstraintTypes(inProgress);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 6157, 6237);
                        return return_v;
                    }


                    int
                    f_10162_6076_6261(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    owner, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    original, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    result, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    ignoreTypesDependentOnTypeParametersOpt)
                    {
                        this_param.SubstituteConstraintTypesDistinctWithoutModifiers(owner, original, result, ignoreTypesDependentOnTypeParametersOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 6076, 6261);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10162_6324_6360(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 6324, 6360);
                        return return_v;
                    }


                    bool?
                    f_10162_6291_6361(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    constraintTypes)
                    {
                        var return_v = IsNotNullableFromConstraintTypes(constraintTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 6291, 6361);
                        return return_v;
                    }


                    bool?
                    f_10162_6408_6432(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.CalculateIsNotNullable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 6408, 6432);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10162, 5559, 6459);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 5559, 6459);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfaces(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10162, 6471, 6697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 6601, 6686);

                return f_10162_6608_6685(_map, f_10162_6634_6684(_underlyingTypeParameter, inProgress));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10162, 6471, 6697);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10162_6634_6684(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetInterfaces(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 6634, 6684);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10162_6608_6685(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                original)
                {
                    var return_v = this_param.SubstituteNamedTypes(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 6608, 6685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10162, 6471, 6697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 6471, 6697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetEffectiveBaseClass(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10162, 6709, 6934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 6831, 6923);

                return f_10162_6838_6922(_map, f_10162_6863_6921(_underlyingTypeParameter, inProgress));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10162, 6709, 6934);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10162_6863_6921(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetEffectiveBaseClass(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 6863, 6921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10162_6838_6922(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 6838, 6922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10162, 6709, 6934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 6709, 6934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol GetDeducedBaseType(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10162, 6946, 7174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10162, 7060, 7163);

                return f_10162_7067_7143(_map, f_10162_7087_7142(_underlyingTypeParameter, inProgress)).AsTypeSymbolOnly();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10162, 6946, 7174);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10162_7087_7142(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetDeducedBaseType(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 7087, 7142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10162_7067_7143(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10162, 7067, 7143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10162, 6946, 7174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 6946, 7174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SubstitutedTypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10162, 545, 7181);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10162, 545, 7181);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10162, 545, 7181);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10162, 545, 7181);

        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        f_10162_1024_1039_C(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10162, 880, 1459);
            return return_v;
        }

    }
}
