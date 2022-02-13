// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SubstitutedParameterSymbol : WrappedParameterSymbol
    {
        private object _mapOrType;

        private readonly Symbol _containingSymbol;

        internal SubstitutedParameterSymbol(MethodSymbol containingSymbol, TypeMap map, ParameterSymbol originalParameter) : this(f_10160_776_800_C((Symbol)containingSymbol), map, originalParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10160, 641, 847);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10160, 641, 847);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10160, 641, 847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10160, 641, 847);
            }
        }

        internal SubstitutedParameterSymbol(PropertySymbol containingSymbol, TypeMap map, ParameterSymbol originalParameter) : this(f_10160_996_1020_C((Symbol)containingSymbol), map, originalParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10160, 859, 1067);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10160, 859, 1067);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10160, 859, 1067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10160, 859, 1067);
            }
        }

        private SubstitutedParameterSymbol(Symbol containingSymbol, TypeMap map, ParameterSymbol originalParameter) : base(f_10160_1207_1224_C(originalParameter))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10160, 1079, 1388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 564, 574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 611, 628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 1250, 1295);

                f_10160_1250_1294(f_10160_1263_1293(originalParameter));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 1309, 1346);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 1360, 1377);

                _mapOrType = map;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10160, 1079, 1388);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10160, 1079, 1388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10160, 1079, 1388);
            }
        }

        public override ParameterSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10160, 1475, 1530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 1481, 1528);

                    return f_10160_1488_1527(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10160, 1475, 1530);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10160_1488_1527(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10160, 1488, 1527);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10160, 1400, 1541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10160, 1400, 1541);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10160, 1617, 1650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 1623, 1648);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10160, 1617, 1650);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10160, 1553, 1661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10160, 1553, 1661);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10160, 1753, 2455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 1789, 1816);

                    var
                    mapOrType = _mapOrType
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 1834, 1948) || true) && (mapOrType is TypeWithAnnotations type)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10160, 1834, 1948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 1917, 1929);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10160, 1834, 1948);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 1968, 2085);

                    TypeWithAnnotations
                    substituted = f_10160_2002_2084(((TypeMap)mapOrType), f_10160_2038_2083(this._underlyingParameter))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 2105, 2401) || true) && (substituted.CustomModifiers.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10160, 2109, 2238) && this._underlyingParameter.TypeWithAnnotations.CustomModifiers.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10160, 2109, 2315) && this._underlyingParameter.RefCustomModifiers.IsEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10160, 2105, 2401);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 2357, 2382);

                        _mapOrType = substituted;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10160, 2105, 2401);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 2421, 2440);

                    return substituted;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10160, 1753, 2455);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10160_2038_2083(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10160, 2038, 2083);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10160_2002_2084(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    previous)
                    {
                        var return_v = this_param.SubstituteType(previous);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10160, 2002, 2084);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10160, 1673, 2466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10160, 1673, 2466);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10160, 2570, 2815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 2606, 2638);

                    var
                    map = _mapOrType as TypeMap
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 2656, 2800);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10160, 2663, 2674) || ((map != null && DynAbs.Tracing.TraceSender.Conditional_F2(10160, 2677, 2752)) || DynAbs.Tracing.TraceSender.Conditional_F3(10160, 2755, 2799))) ? f_10160_2677_2752(map, f_10160_2707_2751(this._underlyingParameter)) : f_10160_2755_2799(this._underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10160, 2570, 2815);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10160_2707_2751(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10160, 2707, 2751);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10160_2677_2752(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    customModifiers)
                    {
                        var return_v = this_param.SubstituteCustomModifiers(customModifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10160, 2677, 2752);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10160_2755_2799(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10160, 2755, 2799);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10160, 2480, 2826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10160, 2480, 2826);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10160, 2838, 3522);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 2938, 3022) || true) && ((object)this == obj)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10160, 2938, 3022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 2995, 3007);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10160, 2938, 3022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 3286, 3332);

                var
                other = obj as SubstitutedParameterSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 3346, 3511);

                return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10160, 3353, 3424) && f_10160_3395_3407(this) == f_10160_3411_3424(other)) && (DynAbs.Tracing.TraceSender.Expression_True(10160, 3353, 3510) && f_10160_3445_3510(f_10160_3445_3466(this), f_10160_3474_3496(other), compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10160, 2838, 3522);

                int
                f_10160_3395_3407(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10160, 3395, 3407);
                    return return_v;
                }


                int
                f_10160_3411_3424(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10160, 3411, 3424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10160_3445_3466(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10160, 3445, 3466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10160_3474_3496(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10160, 3474, 3496);
                    return return_v;
                }


                bool
                f_10160_3445_3510(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10160, 3445, 3510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10160, 2838, 3522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10160, 2838, 3522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10160, 3534, 3695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10160, 3599, 3684);

                return f_10160_3606_3683(f_10160_3636_3652(), f_10160_3654_3682(_underlyingParameter));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10160, 3534, 3695);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10160_3636_3652()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10160, 3636, 3652);
                    return return_v;
                }


                int
                f_10160_3654_3682(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10160, 3654, 3682);
                    return return_v;
                }


                int
                f_10160_3606_3683(Microsoft.CodeAnalysis.CSharp.Symbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Roslyn.Utilities.Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10160, 3606, 3683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10160, 3534, 3695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10160, 3534, 3695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SubstitutedParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10160, 351, 3702);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10160, 351, 3702);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10160, 351, 3702);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10160, 351, 3702);

        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10160_776_800_C(Microsoft.CodeAnalysis.CSharp.Symbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10160, 641, 847);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10160_996_1020_C(Microsoft.CodeAnalysis.CSharp.Symbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10160, 859, 1067);
            return return_v;
        }


        bool
        f_10160_1263_1293(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10160, 1263, 1293);
            return return_v;
        }


        int
        f_10160_1250_1294(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10160, 1250, 1294);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10160_1207_1224_C(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10160, 1079, 1388);
            return return_v;
        }

    }
}
