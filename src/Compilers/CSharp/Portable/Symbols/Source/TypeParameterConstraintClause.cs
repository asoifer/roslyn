// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    [Flags]
    internal enum TypeParameterConstraintKind
    {
        None = 0x00,
        ReferenceType = 0x01,
        ValueType = 0x02,
        Constructor = 0x04,
        Unmanaged = 0x08,
        NullableReferenceType = ReferenceType | 0x10,
        NotNullableReferenceType = ReferenceType | 0x20,

        /// <summary>
        /// Type parameter has no type constraints, including `struct`, `class`, `unmanaged` and is declared in a context 
        /// where nullable annotations are disabled.
        /// Cannot be combined with <see cref="ReferenceType"/>, <see cref="ValueType"/> or <see cref="Unmanaged"/>.
        /// Note, presence of this flag suppresses generation of Nullable attribute on the corresponding type parameter.
        /// This imitates the shape of metadata produced by pre-nullable compilers. Metadata import is adjusted accordingly
        /// to distinguish between the two situations.
        /// </summary>
        ObliviousNullabilityIfReferenceType = 0x40,

        NotNull = 0x80,
        Default = 0x100,

        /// <summary>
        /// <see cref="TypeParameterConstraintKind"/> mismatch is detected during merging process for partial type declarations.
        /// </summary>
        PartialMismatch = 0x200,
        ValueTypeFromConstraintTypes = 0x400, // Not set if any flag from AllValueTypeKinds is set
        ReferenceTypeFromConstraintTypes = 0x800,

        /// <summary>
        /// All bits involved into describing various aspects of 'class' constraint. 
        /// </summary>
        AllReferenceTypeKinds = NullableReferenceType | NotNullableReferenceType,

        /// <summary>
        /// Any of these bits is equivalent to presence of 'struct' constraint. 
        /// </summary>
        AllValueTypeKinds = ValueType | Unmanaged,

        /// <summary>
        /// All bits except those that are involved into describilng various nullability aspects.
        /// </summary>
        AllNonNullableKinds = ReferenceType | ValueType | Constructor | Unmanaged,
    }
    internal sealed class TypeParameterConstraintClause
    {
        internal static readonly TypeParameterConstraintClause Empty;

        internal static readonly TypeParameterConstraintClause ObliviousNullabilityIfReferenceType;

        internal static TypeParameterConstraintClause Create(
                    TypeParameterConstraintKind constraints,
                    ImmutableArray<TypeWithAnnotations> constraintTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10283, 3340, 4086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 3538, 3579);

                f_10283_3538_3578(f_10283_3551_3577_M(!constraintTypes.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 3593, 3988) || true) && (constraintTypes.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 3593, 3988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 3654, 3973);

                    switch (constraints)
                    {

                        case TypeParameterConstraintKind.None:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 3654, 3973);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 3779, 3792);

                            return Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 3654, 3973);

                        case TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 3654, 3973);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 3911, 3954);

                            return ObliviousNullabilityIfReferenceType;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 3654, 3973);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 3593, 3988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 4004, 4075);

                return f_10283_4011_4074(constraints, constraintTypes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10283, 3340, 4086);

                bool
                f_10283_3551_3577_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10283, 3551, 3577);
                    return return_v;
                }


                int
                f_10283_3538_3578(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 3538, 3578);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                f_10283_4011_4074(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                constraints, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause(constraints, constraintTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 4011, 4074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10283, 3340, 4086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10283, 3340, 4086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeParameterConstraintClause(
                    TypeParameterConstraintKind constraints,
                    ImmutableArray<TypeWithAnnotations> constraintTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10283, 4098, 5479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 5535, 5546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 4292, 4838);

                switch (constraints & TypeParameterConstraintKind.AllReferenceTypeKinds)
                {

                    case TypeParameterConstraintKind.None:
                    case TypeParameterConstraintKind.ReferenceType:
                    case TypeParameterConstraintKind.NullableReferenceType:
                    case TypeParameterConstraintKind.NotNullableReferenceType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 4292, 4838);
                        DynAbs.Tracing.TraceSender.TraceBreak(10283, 4671, 4677);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 4292, 4838);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 4292, 4838);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 4725, 4773);

                        f_10283_4725_4772(constraints);
                        DynAbs.Tracing.TraceSender.TraceBreak(10283, 4817, 4823);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 4292, 4838);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 4854, 5361);

                f_10283_4854_5360((constraints & TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10283, 4867, 5359) || (constraints & ~(TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType | TypeParameterConstraintKind.Constructor | TypeParameterConstraintKind.Default |
                                                          TypeParameterConstraintKind.PartialMismatch | TypeParameterConstraintKind.ValueTypeFromConstraintTypes | TypeParameterConstraintKind.ReferenceTypeFromConstraintTypes)) == 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 5384, 5415);

                this.Constraints = constraints;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 5429, 5468);

                this.ConstraintTypes = constraintTypes;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10283, 4098, 5479);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10283, 4098, 5479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10283, 4098, 5479);
            }
        }

        public readonly TypeParameterConstraintKind Constraints;

        public readonly ImmutableArray<TypeWithAnnotations> ConstraintTypes;

        internal static SmallDictionary<TypeParameterSymbol, bool> BuildIsValueTypeMap(Symbol container, ImmutableArray<TypeParameterSymbol> typeParameters,
                                                                                               ImmutableArray<TypeParameterConstraintClause> constraintClauses)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10283, 5637, 8567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 5963, 6027);

                f_10283_5963_6026(constraintClauses.Length == typeParameters.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 6043, 6147);

                var
                isValueTypeMap = f_10283_6064_6146(ReferenceEqualityComparer.Instance)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 6163, 6371);
                    foreach (TypeParameterSymbol typeParameter in f_10283_6209_6223_I(typeParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 6163, 6371);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 6257, 6356);

                        f_10283_6257_6355(typeParameter, constraintClauses, isValueTypeMap, ConsList<TypeParameterSymbol>.Empty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 6163, 6371);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10283, 1, 209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10283, 1, 209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 6387, 6409);

                return isValueTypeMap;

                static bool isValueType(TypeParameterSymbol thisTypeParameter, ImmutableArray<TypeParameterConstraintClause> constraintClauses, SmallDictionary<TypeParameterSymbol, bool> isValueTypeMap, ConsList<TypeParameterSymbol> inProgress)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10283, 6425, 8556);
                        bool knownIsValueType = default(bool);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 6686, 6811) || true) && (f_10283_6690_6737(inProgress, thisTypeParameter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 6686, 6811);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 6779, 6792);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 6686, 6811);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 6831, 6992) || true) && (f_10283_6835_6907(isValueTypeMap, thisTypeParameter, out knownIsValueType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 6831, 6992);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 6949, 6973);

                            return knownIsValueType;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 6831, 6992);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 7012, 7106);

                        TypeParameterConstraintClause
                        constraintClause = constraintClauses[f_10283_7079_7104(thisTypeParameter)]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 7126, 7146);

                        bool
                        result = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 7166, 8443) || true) && ((constraintClause.Constraints & TypeParameterConstraintKind.AllValueTypeKinds) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 7166, 8443);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 7295, 7309);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 7166, 8443);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 7166, 8443);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 7391, 7445);

                            Symbol
                            container = f_10283_7410_7444(thisTypeParameter)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 7467, 7518);

                            inProgress = f_10283_7480_7517(inProgress, thisTypeParameter);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 7542, 8424);
                                foreach (TypeWithAnnotations constraintType in f_10283_7589_7621_I(constraintClause.ConstraintTypes))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 7542, 8424);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 7671, 7766);

                                    TypeSymbol
                                    type = (DynAbs.Tracing.TraceSender.Conditional_F1(10283, 7689, 7714) || ((constraintType.IsResolved && DynAbs.Tracing.TraceSender.Conditional_F2(10283, 7717, 7736)) || DynAbs.Tracing.TraceSender.Conditional_F3(10283, 7739, 7765))) ? constraintType.Type : constraintType.DefaultType
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 7794, 8401) || true) && (type is TypeParameterSymbol typeParameter && (DynAbs.Tracing.TraceSender.Expression_True(10283, 7798, 7902) && (object)f_10283_7851_7881(typeParameter) == (object)container))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 7794, 8401);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 7960, 8188) || true) && (f_10283_7964_8037(typeParameter, constraintClauses, isValueTypeMap, inProgress))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 7960, 8188);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 8103, 8117);

                                            result = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(10283, 8151, 8157);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 7960, 8188);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 7794, 8401);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 7794, 8401);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 8246, 8401) || true) && (f_10283_8250_8266(type))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 8246, 8401);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 8324, 8338);

                                            result = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(10283, 8368, 8374);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 8246, 8401);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 7794, 8401);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 7542, 8424);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10283, 1, 883);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10283, 1, 883);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 7166, 8443);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 8463, 8509);

                        f_10283_8463_8508(
                                        isValueTypeMap, thisTypeParameter, result);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 8527, 8541);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10283, 6425, 8556);

                        bool
                        f_10283_6690_6737(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        list, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        element)
                        {
                            var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(element);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 6690, 6737);
                            return return_v;
                        }


                        bool
                        f_10283_6835_6907(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        key, out bool
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 6835, 6907);
                            return return_v;
                        }


                        int
                        f_10283_7079_7104(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10283, 7079, 7104);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10283_7410_7444(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10283, 7410, 7444);
                            return return_v;
                        }


                        Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        f_10283_7480_7517(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        list, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        head)
                        {
                            var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(head);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 7480, 7517);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10283_7851_7881(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10283, 7851, 7881);
                            return return_v;
                        }


                        bool
                        f_10283_7964_8037(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        thisTypeParameter, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                        constraintClauses, Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                        isValueTypeMap, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        inProgress)
                        {
                            var return_v = isValueType(thisTypeParameter, constraintClauses, isValueTypeMap, inProgress);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 7964, 8037);
                            return return_v;
                        }


                        bool
                        f_10283_8250_8266(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsValueType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10283, 8250, 8266);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10283_7589_7621_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 7589, 7621);
                            return return_v;
                        }


                        int
                        f_10283_8463_8508(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        key, bool
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 8463, 8508);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10283, 6425, 8556);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10283, 6425, 8556);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10283, 5637, 8567);

                int
                f_10283_5963_6026(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 5963, 6026);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                f_10283_6064_6146(Roslyn.Utilities.ReferenceEqualityComparer
                comparer)
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 6064, 6146);
                    return return_v;
                }


                bool
                f_10283_6257_6355(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                thisTypeParameter, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                constraintClauses, Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                isValueTypeMap, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = isValueType(thisTypeParameter, constraintClauses, isValueTypeMap, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 6257, 6355);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10283_6209_6223_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 6209, 6223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10283, 5637, 8567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10283, 5637, 8567);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SmallDictionary<TypeParameterSymbol, bool> BuildIsReferenceTypeFromConstraintTypesMap(Symbol container, ImmutableArray<TypeParameterSymbol> typeParameters,
                                                                                                                      ImmutableArray<TypeParameterConstraintClause> constraintClauses)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10283, 8579, 11950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 8951, 9015);

                f_10283_8951_9014(constraintClauses.Length == typeParameters.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 9031, 9158);

                var
                isReferenceTypeFromConstraintTypesMap = f_10283_9075_9157(ReferenceEqualityComparer.Instance)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 9174, 9428);
                    foreach (TypeParameterSymbol typeParameter in f_10283_9220_9234_I(typeParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 9174, 9428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 9268, 9413);

                        f_10283_9268_9412(typeParameter, constraintClauses, isReferenceTypeFromConstraintTypesMap, ConsList<TypeParameterSymbol>.Empty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 9174, 9428);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10283, 1, 255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10283, 1, 255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 9444, 9489);

                return isReferenceTypeFromConstraintTypesMap;

                static bool isReferenceTypeFromConstraintTypes(TypeParameterSymbol thisTypeParameter, ImmutableArray<TypeParameterConstraintClause> constraintClauses,
                                                                           SmallDictionary<TypeParameterSymbol, bool> isReferenceTypeFromConstraintTypesMap, ConsList<TypeParameterSymbol> inProgress)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10283, 9505, 11939);
                        bool knownIsReferenceTypeFromConstraintTypes = default(bool);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 9872, 9997) || true) && (f_10283_9876_9923(inProgress, thisTypeParameter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 9872, 9997);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 9965, 9978);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 9872, 9997);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 10017, 10247) || true) && (f_10283_10021_10139(isReferenceTypeFromConstraintTypesMap, thisTypeParameter, out knownIsReferenceTypeFromConstraintTypes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 10017, 10247);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 10181, 10228);

                            return knownIsReferenceTypeFromConstraintTypes;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 10017, 10247);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 10267, 10361);

                        TypeParameterConstraintClause
                        constraintClause = constraintClauses[f_10283_10334_10359(thisTypeParameter)]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 10381, 10401);

                        bool
                        result = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 10421, 10475);

                        Symbol
                        container = f_10283_10440_10474(thisTypeParameter)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 10493, 10544);

                        inProgress = f_10283_10506_10543(inProgress, thisTypeParameter);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 10564, 11803);
                            foreach (TypeWithAnnotations constraintType in f_10283_10611_10643_I(constraintClause.ConstraintTypes))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 10564, 11803);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 10685, 10780);

                                TypeSymbol
                                type = (DynAbs.Tracing.TraceSender.Conditional_F1(10283, 10703, 10728) || ((constraintType.IsResolved && DynAbs.Tracing.TraceSender.Conditional_F2(10283, 10731, 10750)) || DynAbs.Tracing.TraceSender.Conditional_F3(10283, 10753, 10779))) ? constraintType.Type : constraintType.DefaultType
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 10804, 11784) || true) && (type is TypeParameterSymbol typeParameter)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 10804, 11784);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 10899, 11539) || true) && ((object)f_10283_10911_10941(typeParameter) == (object)container)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 10899, 11539);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 11020, 11294) || true) && (f_10283_11024_11143(typeParameter, constraintClauses, isReferenceTypeFromConstraintTypesMap, inProgress))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 11020, 11294);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 11209, 11223);

                                            result = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(10283, 11257, 11263);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 11020, 11294);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 10899, 11539);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 10899, 11539);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 11352, 11539) || true) && (f_10283_11356_11404(typeParameter))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 11352, 11539);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 11462, 11476);

                                            result = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(10283, 11506, 11512);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 11352, 11539);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 10899, 11539);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 10804, 11784);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 10804, 11784);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 11589, 11784) || true) && (f_10283_11593_11665(type))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10283, 11589, 11784);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 11715, 11729);

                                        result = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10283, 11755, 11761);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 11589, 11784);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 10804, 11784);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10283, 10564, 11803);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10283, 1, 1240);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10283, 1, 1240);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 11823, 11892);

                        f_10283_11823_11891(
                                        isReferenceTypeFromConstraintTypesMap, thisTypeParameter, result);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 11910, 11924);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10283, 9505, 11939);

                        bool
                        f_10283_9876_9923(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        list, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        element)
                        {
                            var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(element);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 9876, 9923);
                            return return_v;
                        }


                        bool
                        f_10283_10021_10139(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        key, out bool
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 10021, 10139);
                            return return_v;
                        }


                        int
                        f_10283_10334_10359(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10283, 10334, 10359);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10283_10440_10474(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10283, 10440, 10474);
                            return return_v;
                        }


                        Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        f_10283_10506_10543(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        list, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        head)
                        {
                            var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(head);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 10506, 10543);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10283_10911_10941(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10283, 10911, 10941);
                            return return_v;
                        }


                        bool
                        f_10283_11024_11143(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        thisTypeParameter, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                        constraintClauses, Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                        isReferenceTypeFromConstraintTypesMap, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        inProgress)
                        {
                            var return_v = isReferenceTypeFromConstraintTypes(thisTypeParameter, constraintClauses, isReferenceTypeFromConstraintTypesMap, inProgress);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 11024, 11143);
                            return return_v;
                        }


                        bool
                        f_10283_11356_11404(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.IsReferenceTypeFromConstraintTypes;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10283, 11356, 11404);
                            return return_v;
                        }


                        bool
                        f_10283_11593_11665(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        constraint)
                        {
                            var return_v = TypeParameterSymbol.NonTypeParameterConstraintImpliesReferenceType(constraint);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 11593, 11665);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10283_10611_10643_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 10611, 10643);
                            return return_v;
                        }


                        int
                        f_10283_11823_11891(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        key, bool
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 11823, 11891);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10283, 9505, 11939);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10283, 9505, 11939);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10283, 8579, 11950);

                int
                f_10283_8951_9014(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 8951, 9014);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                f_10283_9075_9157(Roslyn.Utilities.ReferenceEqualityComparer
                comparer)
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 9075, 9157);
                    return return_v;
                }


                bool
                f_10283_9268_9412(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                thisTypeParameter, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                constraintClauses, Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                isReferenceTypeFromConstraintTypesMap, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = isReferenceTypeFromConstraintTypes(thisTypeParameter, constraintClauses, isReferenceTypeFromConstraintTypesMap, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 9268, 9412);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10283_9220_9234_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 9220, 9234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10283, 8579, 11950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10283, 8579, 11950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeParameterConstraintClause()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10283, 2785, 11957);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 2908, 3053);
            Empty = f_10283_2916_3053(TypeParameterConstraintKind.None, ImmutableArray<TypeWithAnnotations>.Empty); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10283, 3121, 3327);
            ObliviousNullabilityIfReferenceType = f_10283_3159_3327(TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType, ImmutableArray<TypeWithAnnotations>.Empty); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10283, 2785, 11957);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10283, 2785, 11957);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10283, 2785, 11957);

        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
        f_10283_2916_3053(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
        constraints, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        constraintTypes)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause(constraints, constraintTypes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 2916, 3053);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
        f_10283_3159_3327(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
        constraints, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        constraintTypes)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause(constraints, constraintTypes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 3159, 3327);
            return return_v;
        }


        System.Exception
        f_10283_4725_4772(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
        o)
        {
            var return_v = ExceptionUtilities.UnexpectedValue((object)o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 4725, 4772);
            return return_v;
        }


        int
        f_10283_4854_5360(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10283, 4854, 5360);
            return 0;
        }

    }
}
