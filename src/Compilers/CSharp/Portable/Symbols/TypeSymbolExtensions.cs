// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static partial class TypeSymbolExtensions
    {
        public static bool ImplementsInterface(this TypeSymbol subType, TypeSymbol superInterface, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 557, 1108);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 720, 1070);
                    foreach (NamedTypeSymbol @interface in f_10056_759_836_I(f_10056_759_836(subType, ref useSiteDiagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 720, 1070);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 870, 1055) || true) && (f_10056_874_896(@interface) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 874, 982) && f_10056_900_982(@interface, superInterface, TypeCompareKind.ConsiderEverything2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 870, 1055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 1024, 1036);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 870, 1055);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 720, 1070);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 1084, 1097);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 557, 1108);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10056_759_836(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 759, 836);
                    return return_v;
                }


                bool
                f_10056_874_896(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 874, 896);
                    return return_v;
                }


                bool
                f_10056_900_982(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 900, 982);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10056_759_836_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 759, 836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 557, 1108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 557, 1108);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CanBeAssignedNull(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 1120, 1304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 1203, 1293);

                return f_10056_1210_1230(type) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 1210, 1267) || f_10056_1234_1267(type)) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 1210, 1292) || f_10056_1271_1292(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 1120, 1304);

                bool
                f_10056_1210_1230(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 1210, 1230);
                    return return_v;
                }


                bool
                f_10056_1234_1267(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 1234, 1267);
                    return return_v;
                }


                bool
                f_10056_1271_1292(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 1271, 1292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 1120, 1304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 1120, 1304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CanContainNull(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 1316, 1576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 1500, 1565);

                return f_10056_1507_1524_M(!type.IsValueType) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 1507, 1564) || f_10056_1528_1564(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 1316, 1576);

                bool
                f_10056_1507_1524_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 1507, 1524);
                    return return_v;
                }


                bool
                f_10056_1528_1564(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableTypeOrTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 1528, 1564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 1316, 1576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 1316, 1576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CanBeConst(this TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 1588, 1878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 1670, 1717);

                f_10056_1670_1716((object)typeSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 1733, 1867);

                return f_10056_1740_1766(typeSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 1740, 1793) || f_10056_1770_1793(typeSymbol)) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 1740, 1832) || f_10056_1797_1832(f_10056_1797_1819(typeSymbol))) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 1740, 1866) || f_10056_1836_1866(typeSymbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 1588, 1878);

                int
                f_10056_1670_1716(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 1670, 1716);
                    return 0;
                }


                bool
                f_10056_1740_1766(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 1740, 1766);
                    return return_v;
                }


                bool
                f_10056_1770_1793(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 1770, 1793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10056_1797_1819(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 1797, 1819);
                    return return_v;
                }


                bool
                f_10056_1797_1832(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.CanBeConst();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 1797, 1832);
                    return return_v;
                }


                bool
                f_10056_1836_1866(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 1836, 1866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 1588, 1878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 1588, 1878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsTypeParameterDisallowingAnnotationInCSharp8(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 2393, 2988);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 2504, 2609) || true) && (f_10056_2508_2521(type) != TypeKind.TypeParameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 2504, 2609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 2581, 2594);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 2504, 2609);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 2623, 2669);

                var
                typeParameter = (TypeParameterSymbol)type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 2868, 2977);

                return f_10056_2875_2901_M(!typeParameter.IsValueType) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 2875, 2976) && !(f_10056_2907_2936(typeParameter) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 2907, 2975) && f_10056_2940_2967(typeParameter) == true)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 2393, 2988);

                Microsoft.CodeAnalysis.TypeKind
                f_10056_2508_2521(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 2508, 2521);
                    return return_v;
                }


                bool
                f_10056_2875_2901_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 2875, 2901);
                    return return_v;
                }


                bool
                f_10056_2907_2936(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 2907, 2936);
                    return return_v;
                }


                bool?
                f_10056_2940_2967(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsNotNullable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 2940, 2967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 2393, 2988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 2393, 2988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPossiblyNullableReferenceTypeTypeParameter(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 3344, 3545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 3454, 3534);

                return type is TypeParameterSymbol { IsValueType: false, IsNotNullable: false };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 3344, 3545);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 3344, 3545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 3344, 3545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNonNullableValueType(this TypeSymbol typeArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 3557, 3823);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 3653, 3744) || true) && (f_10056_3657_3682_M(!typeArgument.IsValueType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 3653, 3744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 3716, 3729);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 3653, 3744);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 3760, 3812);

                return !f_10056_3768_3811(typeArgument);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 3557, 3823);

                bool
                f_10056_3657_3682_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 3657, 3682);
                    return return_v;
                }


                bool
                f_10056_3768_3811(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableTypeOrTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 3768, 3811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 3557, 3823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 3557, 3823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsVoidType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 3835, 3973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 3911, 3962);

                return f_10056_3918_3934(type) == SpecialType.System_Void;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 3835, 3973);

                Microsoft.CodeAnalysis.SpecialType
                f_10056_3918_3934(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 3918, 3934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 3835, 3973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 3835, 3973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNullableTypeOrTypeParameter(this TypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 3985, 4705);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 4081, 4159) || true) && (type is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 4081, 4159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 4131, 4144);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 4081, 4159);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 4175, 4649) || true) && (f_10056_4179_4192(type) == TypeKind.TypeParameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 4175, 4649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 4252, 4338);

                    var
                    constraintTypes = f_10056_4274_4337(((TypeParameterSymbol)type))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 4356, 4603);
                        foreach (var constraintType in f_10056_4387_4402_I(constraintTypes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 4356, 4603);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 4444, 4584) || true) && (f_10056_4448_4499(constraintType.Type))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 4444, 4584);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 4549, 4561);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 4444, 4584);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 4356, 4603);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 248);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 248);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 4621, 4634);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 4175, 4649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 4665, 4694);

                return f_10056_4672_4693(type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 3985, 4705);

                Microsoft.CodeAnalysis.TypeKind
                f_10056_4179_4192(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 4179, 4192);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_4274_4337(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 4274, 4337);
                    return return_v;
                }


                bool
                f_10056_4448_4499(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableTypeOrTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 4448, 4499);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_4387_4402_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 4387, 4402);
                    return return_v;
                }


                bool
                f_10056_4672_4693(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 4672, 4693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 3985, 4705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 3985, 4705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNullableType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 5049, 5216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 5129, 5205);

                return f_10056_5136_5171(f_10056_5136_5159(type)) == SpecialType.System_Nullable_T;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 5049, 5216);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10056_5136_5159(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 5136, 5159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10056_5136_5171(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 5136, 5171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 5049, 5216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 5049, 5216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeSymbol GetNullableUnderlyingType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 5228, 5396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 5325, 5385);

                return f_10056_5332_5379(type).Type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 5228, 5396);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10056_5332_5379(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingTypeWithAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 5332, 5379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 5228, 5396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 5228, 5396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeWithAnnotations GetNullableUnderlyingTypeWithAnnotations(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 5408, 5844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 5529, 5570);

                f_10056_5529_5569((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 5584, 5625);

                f_10056_5584_5624(f_10056_5603_5623(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 5639, 5683);

                f_10056_5639_5682(type is NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 5750, 5833);

                return f_10056_5757_5829(((NamedTypeSymbol)type))[0];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 5408, 5844);

                int
                f_10056_5529_5569(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 5529, 5569);
                    return 0;
                }


                bool
                f_10056_5603_5623(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 5603, 5623);
                    return return_v;
                }


                int
                f_10056_5584_5624(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 5584, 5624);
                    return 0;
                }


                int
                f_10056_5639_5682(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 5639, 5682);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_5757_5829(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 5757, 5829);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 5408, 5844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 5408, 5844);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeSymbol StrippedType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 5856, 6022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 5940, 6011);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 5947, 5968) || ((f_10056_5947_5968(type) && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 5971, 6003)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 6006, 6010))) ? f_10056_5971_6003(type) : type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 5856, 6022);

                bool
                f_10056_5947_5968(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 5947, 5968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10056_5971_6003(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 5971, 6003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 5856, 6022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 5856, 6022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeSymbol EnumUnderlyingTypeOrSelf(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 6034, 6185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 6130, 6174);

                return f_10056_6137_6165(type) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?>(10056, 6137, 6173) ?? type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 6034, 6185);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10056_6137_6165(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 6137, 6165);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 6034, 6185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 6034, 6185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNativeIntegerOrNullableNativeIntegerType(this TypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 6197, 6434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 6329, 6423);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 6336, 6364) || (((f_10056_6342_6355(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(type, 10056, 6337, 6355), null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10056, 6337, 6363) ?? true)) && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 6367, 6372)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 6375, 6422))) ? false : f_10056_6375_6414(f_10056_6375_6394(type)) == true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 6197, 6434);

                bool?
                f_10056_6342_6355(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, object
                obj)
                {
                    var return_v = this_param?.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 6342, 6355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10056_6375_6394(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 6375, 6394);
                    return return_v;
                }


                bool
                f_10056_6375_6414(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 6375, 6414);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 6197, 6434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 6197, 6434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsObjectType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 6446, 6588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 6524, 6577);

                return f_10056_6531_6547(type) == SpecialType.System_Object;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 6446, 6588);

                Microsoft.CodeAnalysis.SpecialType
                f_10056_6531_6547(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 6531, 6547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 6446, 6588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 6446, 6588);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsStringType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 6600, 6742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 6678, 6731);

                return f_10056_6685_6701(type) == SpecialType.System_String;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 6600, 6742);

                Microsoft.CodeAnalysis.SpecialType
                f_10056_6685_6701(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 6685, 6701);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 6600, 6742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 6600, 6742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsCharType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 6754, 6892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 6830, 6881);

                return f_10056_6837_6853(type) == SpecialType.System_Char;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 6754, 6892);

                Microsoft.CodeAnalysis.SpecialType
                f_10056_6837_6853(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 6837, 6853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 6754, 6892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 6754, 6892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIntegralType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 6904, 7036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 6984, 7025);

                return f_10056_6991_7024(f_10056_6991_7007(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 6904, 7036);

                Microsoft.CodeAnalysis.SpecialType
                f_10056_6991_7007(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 6991, 7007);
                    return return_v;
                }


                bool
                f_10056_6991_7024(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsIntegralType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 6991, 7024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 6904, 7036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 6904, 7036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NamedTypeSymbol? GetEnumUnderlyingType(this TypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 7048, 7240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 7148, 7229);

                // LAFHIS
                if (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 7155, 7190) ||
                    (((type is NamedTypeSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 7193, 7221)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 7224, 7228))) 
                {
                    var namedType = type as NamedTypeSymbol;
                    return f_10056_7193_7221(namedType); 
                }
                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 7048, 7240);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_7193_7221(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 7193, 7221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 7048, 7240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 7048, 7240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsEnumType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 7252, 7432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 7328, 7369);

                f_10056_7328_7368((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 7383, 7421);

                return f_10056_7390_7403(type) == TypeKind.Enum;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 7252, 7432);

                int
                f_10056_7328_7368(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 7328, 7368);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_7390_7403(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 7390, 7403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 7252, 7432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 7252, 7432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValidEnumType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 7444, 7762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 7525, 7575);

                var
                underlyingType = f_10056_7546_7574(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 7665, 7751);

                return (underlyingType is object) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 7672, 7750) && (f_10056_7703_7729(underlyingType) != SpecialType.None));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 7444, 7762);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10056_7546_7574(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 7546, 7574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10056_7703_7729(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 7703, 7729);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 7444, 7762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 7444, 7762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValidAttributeParameterType(this TypeSymbol type, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 8050, 8279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 8176, 8268);

                return f_10056_8183_8240(type, compilation) != TypedConstantKind.Error;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 8050, 8279);

                Microsoft.CodeAnalysis.TypedConstantKind
                f_10056_8183_8240(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.GetAttributeParameterTypedConstantKind(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 8183, 8240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 8050, 8279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 8050, 8279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypedConstantKind GetAttributeParameterTypedConstantKind(this TypeSymbol type, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 8621, 11411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 9574, 9623);

                TypedConstantKind
                kind = TypedConstantKind.Error
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 9637, 9741) || true) && ((object)type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 9637, 9741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 9695, 9726);

                    return TypedConstantKind.Error;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 9637, 9741);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 9757, 10113) || true) && (f_10056_9761_9770(type) == SymbolKind.ArrayType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 9757, 10113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 9828, 9866);

                    var
                    arrayType = (ArrayTypeSymbol)type
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 9884, 10000) || true) && (f_10056_9888_9908_M(!arrayType.IsSZArray))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 9884, 10000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 9950, 9981);

                        return TypedConstantKind.Error;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 9884, 10000);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 10020, 10051);

                    kind = TypedConstantKind.Array;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 10069, 10098);

                    type = f_10056_10076_10097(arrayType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 9757, 10113);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 10160, 10711) || true) && (f_10056_10164_10181(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 10160, 10711);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 10421, 10639) || true) && (kind == TypedConstantKind.Error)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 10421, 10639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 10590, 10620);

                        kind = TypedConstantKind.Enum;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 10421, 10639);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 10659, 10696);

                    type = f_10056_10666_10694(type)!;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 10160, 10711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 10727, 10805);

                var
                typedConstantKind = TypedConstant.GetTypedConstantKind(type, compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 10819, 11400);

                switch (typedConstantKind)
                {

                    case TypedConstantKind.Array:
                    case TypedConstantKind.Enum:
                    case TypedConstantKind.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 10819, 11400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 11022, 11053);

                        return TypedConstantKind.Error;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 10819, 11400);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 10819, 11400);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 11103, 11336) || true) && (kind == TypedConstantKind.Array || (DynAbs.Tracing.TraceSender.Expression_False(10056, 11107, 11172) || kind == TypedConstantKind.Enum))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 11103, 11336);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 11301, 11313);

                            return kind;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 11103, 11336);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 11360, 11385);

                        return typedConstantKind;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 10819, 11400);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 8621, 11411);

                Microsoft.CodeAnalysis.SymbolKind
                f_10056_9761_9770(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 9761, 9770);
                    return return_v;
                }


                bool
                f_10056_9888_9908_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 9888, 9908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10056_10076_10097(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 10076, 10097);
                    return return_v;
                }


                bool
                f_10056_10164_10181(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 10164, 10181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10056_10666_10694(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 10666, 10694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 8621, 11411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 8621, 11411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValidExtensionParameterType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 11423, 11804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 11518, 11793);

                switch (f_10056_11526_11539(type))
                {

                    case TypeKind.Pointer:
                    case TypeKind.Dynamic:
                    case TypeKind.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 11518, 11793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 11705, 11718);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 11518, 11793);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 11518, 11793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 11766, 11778);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 11518, 11793);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 11423, 11804);

                Microsoft.CodeAnalysis.TypeKind
                f_10056_11526_11539(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 11526, 11539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 11423, 11804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 11423, 11804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsInterfaceType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 11816, 12043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 11897, 11938);

                f_10056_11897_11937((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 11952, 12032);

                return f_10056_11959_11968(type) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10056, 11959, 12031) && f_10056_11996_12031(((NamedTypeSymbol)type)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 11816, 12043);

                int
                f_10056_11897_11937(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 11897, 11937);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10056_11959_11968(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 11959, 11968);
                    return return_v;
                }


                bool
                f_10056_11996_12031(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 11996, 12031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 11816, 12043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 11816, 12043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsClassType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 12055, 12237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 12132, 12173);

                f_10056_12132_12172((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 12187, 12226);

                return f_10056_12194_12207(type) == TypeKind.Class;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 12055, 12237);

                int
                f_10056_12132_12172(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 12132, 12172);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_12194_12207(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 12194, 12207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 12055, 12237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 12055, 12237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsStructType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 12249, 12433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 12327, 12368);

                f_10056_12327_12367((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 12382, 12422);

                return f_10056_12389_12402(type) == TypeKind.Struct;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 12249, 12433);

                int
                f_10056_12327_12367(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 12327, 12367);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_12389_12402(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 12389, 12402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 12249, 12433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 12249, 12433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsErrorType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 12445, 12629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 12522, 12563);

                f_10056_12522_12562((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 12577, 12618);

                return f_10056_12584_12593(type) == SymbolKind.ErrorType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 12445, 12629);

                int
                f_10056_12522_12562(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 12522, 12562);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10056_12584_12593(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 12584, 12593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 12445, 12629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 12445, 12629);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsMethodTypeParameter(this TypeParameterSymbol p)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 12641, 12797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 12734, 12786);

                return f_10056_12741_12764(f_10056_12741_12759(p)) == SymbolKind.Method;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 12641, 12797);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10056_12741_12759(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 12741, 12759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10056_12741_12764(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 12741, 12764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 12641, 12797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 12641, 12797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsDynamic(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 12809, 12936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 12884, 12925);

                return f_10056_12891_12904(type) == TypeKind.Dynamic;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 12809, 12936);

                Microsoft.CodeAnalysis.TypeKind
                f_10056_12891_12904(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 12891, 12904);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 12809, 12936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 12809, 12936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsTypeParameter(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 12948, 13142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 13029, 13070);

                f_10056_13029_13069((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 13084, 13131);

                return f_10056_13091_13104(type) == TypeKind.TypeParameter;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 12948, 13142);

                int
                f_10056_13029_13069(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 13029, 13069);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_13091_13104(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 13091, 13104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 12948, 13142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 12948, 13142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsArray(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 13154, 13332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 13227, 13268);

                f_10056_13227_13267((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 13282, 13321);

                return f_10056_13289_13302(type) == TypeKind.Array;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 13154, 13332);

                int
                f_10056_13227_13267(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 13227, 13267);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_13289_13302(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 13289, 13302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 13154, 13332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 13154, 13332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsSZArray(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 13344, 13561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 13419, 13460);

                f_10056_13419_13459((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 13474, 13550);

                return f_10056_13481_13494(type) == TypeKind.Array && (DynAbs.Tracing.TraceSender.Expression_True(10056, 13481, 13549) && f_10056_13516_13549(((ArrayTypeSymbol)type)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 13344, 13561);

                int
                f_10056_13419_13459(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 13419, 13459);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_13481_13494(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 13481, 13494);
                    return return_v;
                }


                bool
                f_10056_13516_13549(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 13516, 13549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 13344, 13561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 13344, 13561);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsFunctionPointer(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 13573, 13716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 13656, 13705);

                return f_10056_13663_13676(type) == TypeKind.FunctionPointer;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 13573, 13716);

                Microsoft.CodeAnalysis.TypeKind
                f_10056_13663_13676(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 13663, 13676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 13573, 13716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 13573, 13716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPointerOrFunctionPointer(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 13728, 14068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 13820, 14057);

                switch (f_10056_13828_13841(type))
                {

                    case TypeKind.Pointer:
                    case TypeKind.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 13820, 14057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 13967, 13979);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 13820, 14057);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 13820, 14057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 14029, 14042);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 13820, 14057);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 13728, 14068);

                Microsoft.CodeAnalysis.TypeKind
                f_10056_13828_13841(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 13828, 13841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 13728, 14068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 13728, 14068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NamedTypeSymbol? GetDelegateType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 14282, 14678);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 14375, 14413) || true) && ((object)type == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 14375, 14413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 14401, 14413);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 14375, 14413);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 14427, 14591) || true) && (f_10056_14431_14454(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 14427, 14591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 14488, 14576);

                    type = f_10056_14495_14567(((NamedTypeSymbol)type))[0].Type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 14427, 14591);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 14607, 14667);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 14614, 14635) || ((f_10056_14614_14635(type) && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 14638, 14659)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 14662, 14666))) ? (NamedTypeSymbol)type : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 14282, 14678);

                bool
                f_10056_14431_14454(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                _type)
                {
                    var return_v = _type.IsExpressionTree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 14431, 14454);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_14495_14567(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 14495, 14567);
                    return return_v;
                }


                bool
                f_10056_14614_14635(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 14614, 14635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 14282, 14678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 14282, 14678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeSymbol? GetDelegateOrFunctionPointerType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 14690, 14885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 14795, 14874);

                return (TypeSymbol?)f_10056_14815_14836(type) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10056, 14802, 14873) ?? type as FunctionPointerTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 14690, 14885);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10056_14815_14836(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 14815, 14836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 14690, 14885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 14690, 14885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsExpressionTree(this TypeSymbol _type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 15038, 15391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 15121, 15380);

                return f_10056_15128_15152(_type) is NamedTypeSymbol type && (DynAbs.Tracing.TraceSender.Expression_True(10056, 15128, 15212) && f_10056_15197_15207(type) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 15128, 15248) && f_10056_15233_15248(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 15128, 15294) && f_10056_15269_15278(type) == "Expression") && (DynAbs.Tracing.TraceSender.Expression_True(10056, 15128, 15379) && f_10056_15315_15379(f_10056_15329_15350(type), s_expressionsNamespaceName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 15038, 15391);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10056_15128_15152(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 15128, 15152);
                    return return_v;
                }


                int
                f_10056_15197_15207(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 15197, 15207);
                    return return_v;
                }


                bool
                f_10056_15233_15248(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MangleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 15233, 15248);
                    return return_v;
                }


                string
                f_10056_15269_15278(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 15269, 15278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10056_15329_15350(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 15329, 15350);
                    return return_v;
                }


                bool
                f_10056_15315_15379(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, string[]
                names)
                {
                    var return_v = CheckFullName(symbol, names);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 15315, 15379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 15038, 15391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 15038, 15391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPossibleArrayGenericInterface(this TypeSymbol _type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 15582, 16362);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 15680, 15775) || true) && (!(_type is NamedTypeSymbol t))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 15680, 15775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 15747, 15760);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 15680, 15775);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 15791, 15816);

                t = f_10056_15795_15815(t);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 15832, 15863);

                SpecialType
                st = f_10056_15849_15862(t)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 15879, 16322) || true) && (st == SpecialType.System_Collections_Generic_IList_T || (DynAbs.Tracing.TraceSender.Expression_False(10056, 15883, 16014) || st == SpecialType.System_Collections_Generic_ICollection_T) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 15883, 16093) || st == SpecialType.System_Collections_Generic_IEnumerable_T) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 15883, 16174) || st == SpecialType.System_Collections_Generic_IReadOnlyList_T) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 15883, 16261) || st == SpecialType.System_Collections_Generic_IReadOnlyCollection_T))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 15879, 16322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16295, 16307);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 15879, 16322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16338, 16351);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 15582, 16362);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_15795_15815(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 15795, 15815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10056_15849_15862(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 15849, 15862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 15582, 16362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 15582, 16362);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly string[] s_expressionsNamespaceName;

        private static bool CheckFullName(Symbol symbol, string[] names)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 16508, 16841);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16606, 16611);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16597, 16802) || true) && (i < f_10056_16617_16629(names))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16631, 16634)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 16597, 16802))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 16597, 16802);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16668, 16736) || true) && ((object)symbol == null || (DynAbs.Tracing.TraceSender.Expression_False(10056, 16672, 16721) || f_10056_16698_16709(symbol) != names[i]))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 16668, 16736);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16723, 16736);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 16668, 16736);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16754, 16787);

                        symbol = f_10056_16763_16786(symbol);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16818, 16830);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 16508, 16841);

                int
                f_10056_16617_16629(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 16617, 16629);
                    return return_v;
                }


                string
                f_10056_16698_16709(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 16698, 16709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10056_16763_16786(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 16763, 16786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 16508, 16841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 16508, 16841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsDelegateType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 16853, 17041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16933, 16974);

                f_10056_16933_16973((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16988, 17030);

                return f_10056_16995_17008(type) == TypeKind.Delegate;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 16853, 17041);

                int
                f_10056_16933_16973(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 16933, 16973);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_16995_17008(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 16995, 17008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 16853, 17041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 16853, 17041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<ParameterSymbol> DelegateParameters(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 17053, 17410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 17164, 17211);

                var
                invokeMethod = f_10056_17183_17210(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 17225, 17354) || true) && ((object)invokeMethod == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 17225, 17354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 17291, 17339);

                    return default(ImmutableArray<ParameterSymbol>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 17225, 17354);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 17368, 17399);

                return f_10056_17375_17398(invokeMethod);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 17053, 17410);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10056_17183_17210(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.DelegateInvokeMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 17183, 17210);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10056_17375_17398(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 17375, 17398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 17053, 17410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 17053, 17410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<ParameterSymbol> DelegateOrFunctionPointerParameters(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 17422, 17927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 17550, 17623);

                f_10056_17550_17622(type is FunctionPointerTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10056, 17563, 17621) || f_10056_17600_17621(type)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 17637, 17916) || true) && (type is FunctionPointerTypeSymbol { Signature: { Parameters: var functionPointerParameters } })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 17637, 17916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 17769, 17802);

                    return functionPointerParameters;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 17637, 17916);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 17637, 17916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 17868, 17901);

                    return f_10056_17875_17900(type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 17637, 17916);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 17422, 17927);

                bool
                f_10056_17600_17621(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 17600, 17621);
                    return return_v;
                }


                int
                f_10056_17550_17622(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 17550, 17622);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10056_17875_17900(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.DelegateParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 17875, 17900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 17422, 17927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 17422, 17927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetElementTypesWithAnnotationsIfTupleType(this TypeSymbol type, out ImmutableArray<TypeWithAnnotations> elementTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 17939, 18423);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 18103, 18274) || true) && (f_10056_18107_18123(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 18103, 18274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 18157, 18229);

                    elementTypes = f_10056_18172_18228(((NamedTypeSymbol)type));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 18247, 18259);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 18103, 18274);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 18325, 18385);

                elementTypes = default(ImmutableArray<TypeWithAnnotations>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 18399, 18412);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 17939, 18423);

                bool
                f_10056_18107_18123(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 18107, 18123);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_18172_18228(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 18172, 18228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 17939, 18423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 17939, 18423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodSymbol DelegateInvokeMethod(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 18435, 18730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 18529, 18570);

                f_10056_18529_18569((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 18584, 18653);

                f_10056_18584_18652(f_10056_18603_18624(type) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 18603, 18651) || f_10056_18628_18651(type)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 18667, 18719);

                return f_10056_18674_18718(f_10056_18674_18696(type)!);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 18435, 18730);

                int
                f_10056_18529_18569(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 18529, 18569);
                    return 0;
                }


                bool
                f_10056_18603_18624(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 18603, 18624);
                    return return_v;
                }


                bool
                f_10056_18628_18651(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                _type)
                {
                    var return_v = _type.IsExpressionTree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 18628, 18651);
                    return return_v;
                }


                int
                f_10056_18584_18652(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 18584, 18652);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10056_18674_18696(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 18674, 18696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10056_18674_18718(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 18674, 18718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 18435, 18730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 18435, 18730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue? GetDefaultValue(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 18917, 20947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 19523, 19564);

                f_10056_19523_19563((object)type != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 19580, 19663) || true) && (f_10056_19584_19602(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 19580, 19663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 19636, 19648);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 19580, 19663);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 19679, 19778) || true) && (f_10056_19683_19703(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 19679, 19778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 19737, 19763);

                    return f_10056_19744_19762();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 19679, 19778);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 19794, 20908) || true) && (f_10056_19798_19814(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 19794, 20908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 19848, 19887);

                    type = f_10056_19855_19886(type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 19907, 20893);

                    switch (f_10056_19915_19931(type))
                    {

                        case SpecialType.System_SByte:
                        case SpecialType.System_Byte:
                        case SpecialType.System_Int16:
                        case SpecialType.System_UInt16:
                        case SpecialType.System_Int32:
                        case SpecialType.System_UInt32:
                        case SpecialType.System_Int64:
                        case SpecialType.System_UInt64:
                        case SpecialType.System_IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 20422, 20451) || true) && (f_10056_20427_20451(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 20422, 20451) || true)
                    :
                        case SpecialType.System_UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 20506, 20535) || true) && (f_10056_20511_20535(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 20506, 20535) || true)
                    :
                        case SpecialType.System_Char:
                        case SpecialType.System_Boolean:
                        case SpecialType.System_Single:
                        case SpecialType.System_Double:
                        case SpecialType.System_Decimal:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 19907, 20893);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 20827, 20874);

                            return f_10056_20834_20873(f_10056_20856_20872(type));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 19907, 20893);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 19794, 20908);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 20924, 20936);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 18917, 20947);

                int
                f_10056_19523_19563(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 19523, 19563);
                    return 0;
                }


                bool
                f_10056_19584_19602(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 19584, 19602);
                    return return_v;
                }


                bool
                f_10056_19683_19703(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 19683, 19703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10056_19744_19762()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 19744, 19762);
                    return return_v;
                }


                bool
                f_10056_19798_19814(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 19798, 19814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10056_19855_19886(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.EnumUnderlyingTypeOrSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 19855, 19886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10056_19915_19931(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 19915, 19931);
                    return return_v;
                }


                bool
                f_10056_20427_20451(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 20427, 20451);
                    return return_v;
                }


                bool
                f_10056_20511_20535(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 20511, 20535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10056_20856_20872(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 20856, 20872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10056_20834_20873(Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = ConstantValue.Default(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 20834, 20873);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 18917, 20947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 18917, 20947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SpecialType GetSpecialTypeSafe(this TypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 20959, 21122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 21051, 21111);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 21058, 21072) || ((type is object && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 21075, 21091)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 21094, 21110))) ? f_10056_21075_21091(type) : SpecialType.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 20959, 21122);

                Microsoft.CodeAnalysis.SpecialType
                f_10056_21075_21091(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 21075, 21091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 20959, 21122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 20959, 21122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAtLeastAsVisibleAs(this TypeSymbol type, Symbol sym, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 21134, 21697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 21281, 21351);

                HashSet<DiagnosticInfo>?
                localUseSiteDiagnostics = useSiteDiagnostics
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 21365, 21562);

                var
                result = f_10056_21378_21561(type, (type1, symbol, unused) => IsTypeLessVisibleThan(type1, symbol, ref localUseSiteDiagnostics), sym, canDigThroughNullable: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 21605, 21650);

                useSiteDiagnostics = localUseSiteDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 21664, 21686);

                return result is null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 21134, 21697);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10056_21378_21561(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbol, bool, bool>
                predicate, Microsoft.CodeAnalysis.CSharp.Symbol
                arg, bool
                canDigThroughNullable)
                {
                    var return_v = type.VisitType<Microsoft.CodeAnalysis.CSharp.Symbol>(predicate, arg, canDigThroughNullable: canDigThroughNullable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 21378, 21561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 21134, 21697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 21134, 21697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsTypeLessVisibleThan(TypeSymbol type, Symbol sym, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 21709, 22317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 21853, 22306);

                switch (f_10056_21861_21874(type))
                {

                    case TypeKind.Class:
                    case TypeKind.Struct:
                    case TypeKind.Interface:
                    case TypeKind.Enum:
                    case TypeKind.Delegate:
                    case TypeKind.Submission:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 21853, 22306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 22152, 22228);

                        return !f_10056_22160_22227(type, sym, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 21853, 22306);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 21853, 22306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 22278, 22291);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 21853, 22306);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 21709, 22317);

                Microsoft.CodeAnalysis.TypeKind
                f_10056_21861_21874(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 21861, 21874);
                    return return_v;
                }


                bool
                f_10056_22160_22227(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                s1, Microsoft.CodeAnalysis.CSharp.Symbol
                sym2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = IsAsRestrictive((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)s1, sym2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 22160, 22227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 21709, 22317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 21709, 22317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeSymbol? VisitType<T>(
                    this TypeSymbol type,
                    Func<TypeSymbol, T, bool, bool> predicate,
                    T arg,
                    bool canDigThroughNullable = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 22865, 23355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 23089, 23344);

                return VisitType(typeWithAnnotationsOpt: default, type: type, typeWithAnnotationsPredicate: null, typePredicate: predicate, arg, canDigThroughNullable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 22865, 23355);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 22865, 23355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 22865, 23355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeSymbol? VisitType<T>(
                    this TypeWithAnnotations typeWithAnnotationsOpt,
                    TypeSymbol? type,
                    Func<TypeWithAnnotations, T, bool, bool>? typeWithAnnotationsPredicate,
                    Func<TypeSymbol, T, bool, bool>? typePredicate,
                    T arg,
                    bool canDigThroughNullable = false,
                    bool useDefaultType = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 24243, 32780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 24657, 24726);

                f_10056_24657_24725<T>(typeWithAnnotationsOpt.HasType == (type is null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 24740, 24892);

                f_10056_24740_24891<T>(canDigThroughNullable == false || (DynAbs.Tracing.TraceSender.Expression_False(10056, 24759, 24816) || useDefaultType == false), "digging through nullable will cause early resolution of nullable types");
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 25139, 30306) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 25139, 30306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 25184, 25297);

                        TypeSymbol
                        current = type ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10056, 25205, 25296) ?? ((DynAbs.Tracing.TraceSender.Conditional_F1(10056, 25214, 25228) || ((useDefaultType && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 25231, 25265)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 25268, 25295))) ? typeWithAnnotationsOpt.DefaultType : typeWithAnnotationsOpt.Type))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 25315, 25346);

                        bool
                        isNestedNamedType = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 25440, 26580);

                        switch (f_10056_25448_25464<T>(current))
                        {

                            case TypeKind.Class:
                            case TypeKind.Struct:
                            case TypeKind.Interface:
                            case TypeKind.Enum:
                            case TypeKind.Delegate:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 25440, 26580);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 25758, 25802);

                                    var
                                    containingType = f_10056_25779_25801<T>(current)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 25832, 26336) || true) && ((object)containingType != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 25832, 26336);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 25932, 25957);

                                        isNestedNamedType = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 25991, 26128);

                                        var
                                        result = VisitType(default, containingType, typeWithAnnotationsPredicate, typePredicate, arg, canDigThroughNullable, useDefaultType)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 26162, 26305) || true) && (result is object)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 26162, 26305);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 26256, 26270);

                                            return result;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 26162, 26305);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 25832, 26336);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10056, 26389, 26395);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 25440, 26580);

                            case TypeKind.Submission:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 25440, 26580);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 26470, 26529);

                                f_10056_26470_26528<T>((object)f_10056_26497_26519<T>(current) == null);
                                DynAbs.Tracing.TraceSender.TraceBreak(10056, 26555, 26561);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 25440, 26580);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 26600, 27150) || true) && (typeWithAnnotationsOpt.HasType && (DynAbs.Tracing.TraceSender.Expression_True(10056, 26604, 26674) && typeWithAnnotationsPredicate != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 26600, 27150);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 26716, 26884) || true) && (f_10056_26720_26796<T>(typeWithAnnotationsPredicate, typeWithAnnotationsOpt, arg, isNestedNamedType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 26716, 26884);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 26846, 26861);

                                return current;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 26716, 26884);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 26600, 27150);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 26600, 27150);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 26926, 27150) || true) && (typePredicate != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 26926, 27150);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 26993, 27131) || true) && (f_10056_26997_27043<T>(typePredicate, current, arg, isNestedNamedType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 26993, 27131);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 27093, 27108);

                                    return current;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 26993, 27131);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 26926, 27150);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 26600, 27150);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 27170, 27195);

                        TypeWithAnnotations
                        next
                        = default(TypeWithAnnotations);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 27215, 30043);

                        switch (f_10056_27223_27239<T>(current))
                        {

                            case TypeKind.Dynamic:
                            case TypeKind.TypeParameter:
                            case TypeKind.Submission:
                            case TypeKind.Enum:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 27215, 30043);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 27467, 27479);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 27215, 30043);

                            case TypeKind.Error:
                            case TypeKind.Class:
                            case TypeKind.Struct:
                            case TypeKind.Interface:
                            case TypeKind.Delegate:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 27215, 30043);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 27725, 27821);

                                var
                                typeArguments = f_10056_27745_27820<T>(((NamedTypeSymbol)current))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 27847, 27969) || true) && (typeArguments.IsEmpty)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 27847, 27969);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 27930, 27942);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 27847, 27969);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 27997, 28003);

                                int
                                i
                                = default(int);
                                try
                                {
                                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 28034, 28039)
       , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 28029, 28981) || true) && (i < typeArguments.Length - 1)
       ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 28071, 28074)
       , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 28029, 28981))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 28029, 28981);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 28218, 28354);

                                        (TypeWithAnnotations nextTypeWithAnnotations, TypeSymbol? nextType) = f_10056_28288_28353<T>(typeArguments[i], canDigThroughNullable);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 28384, 28793);

                                        var
                                        result = VisitType(typeWithAnnotationsOpt: nextTypeWithAnnotations, type: nextType, typeWithAnnotationsPredicate, typePredicate, arg, canDigThroughNullable, useDefaultType)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 28823, 28954) || true) && (result is object)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 28823, 28954);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 28909, 28923);

                                            return result;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 28823, 28954);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 953);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 953);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 29009, 29033);

                                next = typeArguments[i];
                                DynAbs.Tracing.TraceSender.TraceBreak(10056, 29059, 29065);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 27215, 30043);

                            case TypeKind.Array:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 27215, 30043);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 29135, 29196);

                                next = f_10056_29142_29195<T>(((ArrayTypeSymbol)current));
                                DynAbs.Tracing.TraceSender.TraceBreak(10056, 29222, 29228);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 27215, 30043);

                            case TypeKind.Pointer:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 27215, 30043);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 29300, 29365);

                                next = f_10056_29307_29364<T>(((PointerTypeSymbol)current));
                                DynAbs.Tracing.TraceSender.TraceBreak(10056, 29391, 29397);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 27215, 30043);

                            case TypeKind.FunctionPointer:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 27215, 30043);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 29508, 29681);

                                    var
                                    result = f_10056_29521_29680(current, typeWithAnnotationsPredicate, typePredicate, arg, useDefaultType, canDigThroughNullable, out next)
                                    ;

                                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10056_29521_29680(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, T, bool, bool>?
                typeWithAnnotationsPredicate, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, T, bool, bool>?
                typePredicate, T
                arg, bool
                useDefaultType, bool
                canDigThroughNullable, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                next)
                                    {
                                        var return_v = visitFunctionPointerType((Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol)type, typeWithAnnotationsPredicate, typePredicate, arg, useDefaultType, canDigThroughNullable, out next);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 29521, 29680);
                                        return return_v;
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 29711, 29842) || true) && (result is object)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 29711, 29842);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 29797, 29811);

                                        return result;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 29711, 29842);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10056, 29874, 29880);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 27215, 30043);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 27215, 30043);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 29965, 30024);

                                throw f_10056_29971_30023<T>(f_10056_30006_30022<T>(current));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 27215, 30043);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 30137, 30201);

                        typeWithAnnotationsOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 30162, 30183) || ((canDigThroughNullable && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 30186, 30193)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 30196, 30200))) ? default : next;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 30219, 30291);

                        type = (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 30226, 30247) || ((canDigThroughNullable && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 30250, 30283)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 30286, 30290))) ? next.NullableUnderlyingTypeOrSelf : null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 25139, 30306);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 25139, 30306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 25139, 30306);
                }
                static (TypeWithAnnotations, TypeSymbol?) getNextIterationElements(TypeWithAnnotations type, bool canDigThroughNullable)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10056, 30460, 30567);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 30463, 30567);
                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 30463, 30484) || ((canDigThroughNullable && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 30487, 30552)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 30555, 30567))) ? (default(TypeWithAnnotations), type.NullableUnderlyingTypeOrSelf) : (type, null); DynAbs.Tracing.TraceSender.TraceExitMethod(10056, 30460, 30567);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 30460, 30567);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 30460, 30567);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static TypeSymbol? visitFunctionPointerType(FunctionPointerTypeSymbol type, Func<TypeWithAnnotations, T, bool, bool>? typeWithAnnotationsPredicate, Func<TypeSymbol, T, bool, bool>? typePredicate, T arg, bool useDefaultType, bool canDigThroughNullable, out TypeWithAnnotations next)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 30584, 32769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 30898, 30943);

                        MethodSymbol
                        currentPointer = f_10056_30928_30942(type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 30961, 31142) || true) && (f_10056_30965_30994(currentPointer) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 30961, 31142);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 31041, 31089);

                            next = f_10056_31048_31088(currentPointer);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 31111, 31123);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 30961, 31142);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 31162, 31630);

                        var
                        result = VisitType(typeWithAnnotationsOpt: (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 31231, 31252) || ((canDigThroughNullable && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 31255, 31262)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 31265, 31305))) ? default : f_10056_31265_31305(currentPointer), type: (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 31334, 31355) || ((canDigThroughNullable && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 31358, 31427)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 31430, 31434))) ? currentPointer.ReturnTypeWithAnnotations.NullableUnderlyingTypeOrSelf : null, typeWithAnnotationsPredicate, typePredicate, arg, canDigThroughNullable, useDefaultType)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 31648, 31780) || true) && (result is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 31648, 31780);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 31710, 31725);

                            next = default;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 31747, 31761);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 31648, 31780);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 31800, 31806);

                        int
                        i
                        = default(int);
                        try
                        {
                            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 31829, 31834)
       , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 31824, 32648) || true) && (i < f_10056_31840_31869(currentPointer) - 1)
       ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 31875, 31878)
       , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 31824, 32648))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 31824, 32648);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 31920, 32088);

                                (TypeWithAnnotations nextTypeWithAnnotations, TypeSymbol? nextType) = f_10056_31990_32087(f_10056_32015_32063(f_10056_32015_32040(currentPointer)[i]), canDigThroughNullable);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 32110, 32459);

                                result = VisitType(typeWithAnnotationsOpt: nextTypeWithAnnotations, type: nextType, typeWithAnnotationsPredicate, typePredicate, arg, canDigThroughNullable, useDefaultType);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 32481, 32629) || true) && (result is object)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 32481, 32629);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 32551, 32566);

                                    next = default;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 32592, 32606);

                                    return result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 32481, 32629);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 825);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 825);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 32668, 32724);

                        next = f_10056_32675_32723(f_10056_32675_32700(currentPointer)[i]);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 32742, 32754);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 30584, 32769);

                        Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                        f_10056_30928_30942(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Signature;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 30928, 30942);
                            return return_v;
                        }


                        int
                        f_10056_30965_30994(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ParameterCount;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 30965, 30994);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10056_31048_31088(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnTypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 31048, 31088);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10056_31265_31305(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnTypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 31265, 31305);
                            return return_v;
                        }


                        int
                        f_10056_31840_31869(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ParameterCount;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 31840, 31869);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10056_32015_32040(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 32015, 32040);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10056_32015_32063(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 32015, 32063);
                            return return_v;
                        }


                        (Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)
                        f_10056_31990_32087(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        type, bool
                        canDigThroughNullable)
                        {
                            var return_v = getNextIterationElements(type, canDigThroughNullable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 31990, 32087);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10056_32675_32700(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 32675, 32700);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10056_32675_32723(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 32675, 32723);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 30584, 32769);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 30584, 32769);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 24243, 32780);

                int
                f_10056_24657_24725<T>(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 24657, 24725);
                    return 0;
                }


                int
                f_10056_24740_24891<T>(bool
                b, string
                message)
                {
                    RoslynDebug.Assert(b, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 24740, 24891);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_25448_25464<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 25448, 25464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_25779_25801<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 25779, 25801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_26497_26519<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 26497, 26519);
                    return return_v;
                }


                int
                f_10056_26470_26528<T>(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 26470, 26528);
                    return 0;
                }


                bool
                f_10056_26720_26796<T>(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, T, bool, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                arg1, T?
                arg2, bool
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 26720, 26796);
                    return return_v;
                }


                bool
                f_10056_26997_27043<T>(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, T, bool, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                arg1, T?
                arg2, bool
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 26997, 27043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_27223_27239<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 27223, 27239);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_27745_27820<T>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 27745, 27820);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)
                f_10056_28288_28353<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, bool
                canDigThroughNullable)
                {
                    var return_v = getNextIterationElements(type, canDigThroughNullable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 28288, 28353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10056_29142_29195<T>(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 29142, 29195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10056_29307_29364<T>(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 29307, 29364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_30006_30022<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 30006, 30022);
                    return return_v;
                }


                System.Exception
                f_10056_29971_30023<T>(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 29971, 30023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 24243, 32780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 24243, 32780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsAsRestrictive(NamedTypeSymbol s1, Symbol sym2, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 32792, 42213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 32934, 32980);

                Accessibility
                acc1 = f_10056_32955_32979(s1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 32996, 33089) || true) && (acc1 == Accessibility.Public)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 32996, 33089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 33062, 33074);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 32996, 33089);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 33117, 33126);

                    for (Symbol
        s2 = sym2
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 33105, 42173) || true) && (f_10056_33128_33135(s2) != SymbolKind.Namespace)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 33161, 33185)
        , s2 = f_10056_33166_33185(s2), DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 33105, 42173))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 33105, 42173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 33219, 33265);

                        Accessibility
                        acc2 = f_10056_33240_33264(s2)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 33285, 42158);

                        switch (acc1)
                        {

                            case Accessibility.Internal:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 33285, 42158);
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 33609, 33901) || true) && ((acc2 == Accessibility.Private || (DynAbs.Tracing.TraceSender.Expression_False(10056, 33614, 33677) || acc2 == Accessibility.Internal) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 33614, 33723) || acc2 == Accessibility.ProtectedAndInternal)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 33613, 33792) && f_10056_33728_33792(f_10056_33728_33749(s2), f_10056_33770_33791(s1))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 33609, 33901);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 33858, 33870);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 33609, 33901);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10056, 33933, 33939);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 33285, 42158);

                            case Accessibility.ProtectedAndInternal:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 33285, 42158);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 34360, 34759) || true) && ((acc2 == Accessibility.Private || (DynAbs.Tracing.TraceSender.Expression_False(10056, 34365, 34428) || acc2 == Accessibility.Internal) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 34365, 34474) || acc2 == Accessibility.ProtectedAndInternal)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 34364, 34543) && f_10056_34479_34543(f_10056_34479_34500(s2), f_10056_34521_34542(s1))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 34360, 34759);

                                    goto case Accessibility.Protected;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 34360, 34759);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10056, 34787, 34793);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 33285, 42158);

                            case Accessibility.Protected:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 33285, 42158);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 34903, 34935);

                                    var
                                    parent1 = f_10056_34917_34934(s1)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 34967, 36587) || true) && ((object)parent1 == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 34967, 36587);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 34967, 36587);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 34967, 36587);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 35140, 36587) || true) && (acc2 == Accessibility.Private)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 35140, 36587);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 35453, 35480);
                                                // if s2 is private and within s1's parent or within a subclass of s1's parent,
                                                // then this is at least as restrictive as s1's protected.
                                                for (var
                parent2 = f_10056_35463_35480(s2)
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 35444, 35852) || true) && ((object)parent2 != null)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 35507, 35539)
                , parent2 = f_10056_35517_35539(parent2), DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 35444, 35852))

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 35444, 35852);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 35613, 35817) || true) && (f_10056_35617_35684(parent1, parent2, ref useSiteDiagnostics))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 35613, 35817);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 35766, 35778);

                                                        return true;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 35613, 35817);
                                                    }
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 409);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 409);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 35140, 36587);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 35140, 36587);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 35918, 36587) || true) && (acc2 == Accessibility.Protected || (DynAbs.Tracing.TraceSender.Expression_False(10056, 35922, 35999) || acc2 == Accessibility.ProtectedAndInternal))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 35918, 36587);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 36271, 36303);

                                                var
                                                parent2 = f_10056_36285_36302(s2)
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 36337, 36556) || true) && ((object)parent2 != null && (DynAbs.Tracing.TraceSender.Expression_True(10056, 36341, 36435) && f_10056_36368_36435(parent1, parent2, ref useSiteDiagnostics)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 36337, 36556);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 36509, 36521);

                                                    return true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 36337, 36556);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 35918, 36587);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 35140, 36587);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 34967, 36587);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10056, 36619, 36625);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 33285, 42158);

                            case Accessibility.ProtectedOrInternal:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 33285, 42158);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 36772, 36804);

                                    var
                                    parent1 = f_10056_36786_36803(s1)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 36836, 36966) || true) && ((object)parent1 == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 36836, 36966);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10056, 36929, 36935);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 36836, 36966);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 36998, 40758);

                                    switch (acc2)
                                    {

                                        case Accessibility.Private:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 36998, 40758);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 37415, 37616) || true) && (f_10056_37419_37483(f_10056_37419_37440(s2), f_10056_37461_37482(s1)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 37415, 37616);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 37565, 37577);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 37415, 37616);
                                            }
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 37665, 37692);

                                                for (var
            parent2 = f_10056_37675_37692(s2)
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 37656, 38088) || true) && ((object)parent2 != null)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 37719, 37751)
            , parent2 = f_10056_37729_37751(parent2), DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 37656, 38088))

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 37656, 38088);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 37833, 38049) || true) && (f_10056_37837_37904(parent1, parent2, ref useSiteDiagnostics))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 37833, 38049);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 37994, 38006);

                                                        return true;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 37833, 38049);
                                                    }
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 433);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 433);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(10056, 38128, 38134);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 36998, 40758);

                                        case Accessibility.Internal:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 36998, 40758);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 38413, 38614) || true) && (f_10056_38417_38481(f_10056_38417_38438(s2), f_10056_38459_38480(s1)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 38413, 38614);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 38563, 38575);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 38413, 38614);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(10056, 38654, 38660);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 36998, 40758);

                                        case Accessibility.Protected:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 36998, 40758);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 38986, 39200) || true) && (f_10056_38990_39067(parent1, f_10056_39025_39042(s2), ref useSiteDiagnostics))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 38986, 39200);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 39149, 39161);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 38986, 39200);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(10056, 39240, 39246);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 36998, 40758);

                                        case Accessibility.ProtectedAndInternal:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 36998, 40758);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 39617, 39940) || true) && (f_10056_39621_39685(f_10056_39621_39642(s2), f_10056_39663_39684(s1)) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 39621, 39807) || f_10056_39730_39807(parent1, f_10056_39765_39782(s2), ref useSiteDiagnostics)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 39617, 39940);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 39889, 39901);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 39617, 39940);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(10056, 39980, 39986);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 36998, 40758);

                                        case Accessibility.ProtectedOrInternal:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 36998, 40758);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 40358, 40681) || true) && (f_10056_40362_40426(f_10056_40362_40383(s2), f_10056_40404_40425(s1)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 40362, 40548) && f_10056_40471_40548(parent1, f_10056_40506_40523(s2), ref useSiteDiagnostics)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 40358, 40681);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 40630, 40642);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 40358, 40681);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(10056, 40721, 40727);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 36998, 40758);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10056, 40788, 40794);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 33285, 42158);

                            case Accessibility.Private:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 33285, 42158);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 40898, 42000) || true) && (acc2 == Accessibility.Private)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 40898, 42000);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 41155, 41199);

                                    NamedTypeSymbol
                                    parent1 = f_10056_41181_41198(s1)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 41231, 41361) || true) && ((object)parent1 == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 41231, 41361);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10056, 41324, 41330);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 41231, 41361);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 41393, 41452);

                                    var
                                    parent1OriginalDefinition = f_10056_41425_41451(parent1)
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 41491, 41518);
                                        for (var
            parent2 = f_10056_41501_41518(s2)
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 41482, 41973) || true) && ((object)parent2 != null)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 41545, 41577)
            , parent2 = f_10056_41555_41577(parent2), DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 41482, 41973))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 41482, 41973);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 41643, 41942) || true) && (f_10056_41647_41717(f_10056_41663_41689(parent2), parent1OriginalDefinition) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 41647, 41821) || f_10056_41721_41755(parent1OriginalDefinition) == TypeKind.Submission && (DynAbs.Tracing.TraceSender.Expression_True(10056, 41721, 41821) && f_10056_41782_41798(parent2) == TypeKind.Submission)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 41643, 41942);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 41895, 41907);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 41643, 41942);
                                            }
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 492);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 492);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 40898, 42000);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10056, 42028, 42034);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 33285, 42158);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 33285, 42158);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 42092, 42139);

                                throw f_10056_42098_42138(acc1);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 33285, 42158);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 9069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 9069);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 42189, 42202);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 32792, 42213);

                Microsoft.CodeAnalysis.Accessibility
                f_10056_32955_32979(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 32955, 32979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10056_33128_33135(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 33128, 33135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10056_33166_33185(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 33166, 33185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10056_33240_33264(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 33240, 33264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_33728_33749(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 33728, 33749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_33770_33791(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 33770, 33791);
                    return return_v;
                }


                bool
                f_10056_33728_33792(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 33728, 33792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_34479_34500(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 34479, 34500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_34521_34542(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 34521, 34542);
                    return return_v;
                }


                bool
                f_10056_34479_34543(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 34479, 34543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_34917_34934(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 34917, 34934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_35463_35480(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 35463, 35480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_35517_35539(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 35517, 35539);
                    return return_v;
                }


                bool
                f_10056_35617_35684(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                superType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                subType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = superType.IsAccessibleViaInheritance(subType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 35617, 35684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_36285_36302(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 36285, 36302);
                    return return_v;
                }


                bool
                f_10056_36368_36435(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                superType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                subType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = superType.IsAccessibleViaInheritance(subType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 36368, 36435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_36786_36803(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 36786, 36803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_37419_37440(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 37419, 37440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_37461_37482(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 37461, 37482);
                    return return_v;
                }


                bool
                f_10056_37419_37483(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 37419, 37483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_37675_37692(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 37675, 37692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_37729_37751(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 37729, 37751);
                    return return_v;
                }


                bool
                f_10056_37837_37904(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                superType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                subType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = superType.IsAccessibleViaInheritance(subType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 37837, 37904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_38417_38438(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 38417, 38438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_38459_38480(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 38459, 38480);
                    return return_v;
                }


                bool
                f_10056_38417_38481(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 38417, 38481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_39025_39042(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 39025, 39042);
                    return return_v;
                }


                bool
                f_10056_38990_39067(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                superType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                subType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = superType.IsAccessibleViaInheritance(subType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 38990, 39067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_39621_39642(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 39621, 39642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_39663_39684(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 39663, 39684);
                    return return_v;
                }


                bool
                f_10056_39621_39685(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 39621, 39685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_39765_39782(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 39765, 39782);
                    return return_v;
                }


                bool
                f_10056_39730_39807(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                superType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                subType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = superType.IsAccessibleViaInheritance(subType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 39730, 39807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_40362_40383(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 40362, 40383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_40404_40425(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 40404, 40425);
                    return return_v;
                }


                bool
                f_10056_40362_40426(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 40362, 40426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_40506_40523(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 40506, 40523);
                    return return_v;
                }


                bool
                f_10056_40471_40548(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                superType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                subType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = superType.IsAccessibleViaInheritance(subType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 40471, 40548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_41181_41198(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 41181, 41198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_41425_41451(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 41425, 41451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_41501_41518(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 41501, 41518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_41555_41577(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 41555, 41577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_41663_41689(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 41663, 41689);
                    return return_v;
                }


                bool
                f_10056_41647_41717(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 41647, 41717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_41721_41755(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 41721, 41755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_41782_41798(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 41782, 41798);
                    return return_v;
                }


                System.Exception
                f_10056_42098_42138(Microsoft.CodeAnalysis.Accessibility
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 42098, 42138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 32792, 42213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 32792, 42213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsUnboundGenericType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 42225, 42384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 42311, 42373);

                return type is NamedTypeSymbol { IsUnboundGenericType: true };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 42225, 42384);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 42225, 42384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 42225, 42384);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsTopLevelType(this NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 42396, 42535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 42481, 42524);

                return (object)f_10056_42496_42515(type) == null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 42396, 42535);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_42496_42515(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 42496, 42515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 42396, 42535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 42396, 42535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ContainsTypeParameter(this TypeSymbol type, TypeParameterSymbol? parameter = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 42948, 43196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 43074, 43147);

                var
                result = f_10056_43087_43146(type, s_containsTypeParameterPredicate, parameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 43161, 43185);

                return result is object;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 42948, 43196);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10056_43087_43146(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol?, bool, bool>
                predicate, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol?
                arg)
                {
                    var return_v = type.VisitType<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol?>(predicate, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 43087, 43146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 42948, 43196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 42948, 43196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Func<TypeSymbol, TypeParameterSymbol?, bool, bool> s_containsTypeParameterPredicate;

        public static bool ContainsTypeParameter(this TypeSymbol type, MethodSymbol parameterContainer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 43510, 43847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 43630, 43685);

                f_10056_43630_43684((object)parameterContainer != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 43701, 43798);

                var
                result = f_10056_43714_43797(type, s_isTypeParameterWithSpecificContainerPredicate, parameterContainer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 43812, 43836);

                return result is object;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 43510, 43847);

                int
                f_10056_43630_43684(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 43630, 43684);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10056_43714_43797(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbol, bool, bool>
                predicate, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                arg)
                {
                    var return_v = type.VisitType<Microsoft.CodeAnalysis.CSharp.Symbol>(predicate, (Microsoft.CodeAnalysis.CSharp.Symbol)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 43714, 43797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 43510, 43847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 43510, 43847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Func<TypeSymbol, Symbol, bool, bool> s_isTypeParameterWithSpecificContainerPredicate;

        public static bool ContainsTypeParameters(this TypeSymbol type, HashSet<TypeParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 44137, 44390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 44266, 44341);

                var
                result = f_10056_44279_44340(type, s_containsTypeParametersPredicate, parameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 44355, 44379);

                return result is object;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 44137, 44390);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10056_44279_44340(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>, bool, bool>
                predicate, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                arg)
                {
                    var return_v = type.VisitType<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>>(predicate, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 44279, 44340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 44137, 44390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 44137, 44390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Func<TypeSymbol, HashSet<TypeParameterSymbol>, bool, bool> s_containsTypeParametersPredicate;

        public static bool ContainsDynamic(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 44787, 45008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 44868, 44959);

                var
                result = f_10056_44881_44958(type, s_containsDynamicPredicate, null, canDigThroughNullable: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 44973, 44997);

                return result is object;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 44787, 45008);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10056_44881_44958(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, object?, bool, bool>
                predicate, object?
                arg, bool
                canDigThroughNullable)
                {
                    var return_v = type.VisitType<object?>(predicate, arg, canDigThroughNullable: canDigThroughNullable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 44881, 44958);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 44787, 45008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 44787, 45008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Func<TypeSymbol, object?, bool, bool> s_containsDynamicPredicate;

        internal static bool ContainsNativeInteger(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 45185, 45449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 45274, 45400);

                var
                result = f_10056_45287_45399(type, (type, unused1, unused2) => type.IsNativeIntegerType, null, canDigThroughNullable: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 45414, 45438);

                return result is object;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 45185, 45449);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10056_45287_45399(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, object, bool, bool>
                predicate, object?
                arg, bool
                canDigThroughNullable)
                {
                    var return_v = type.VisitType<object?>(predicate, arg, canDigThroughNullable: canDigThroughNullable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 45287, 45399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 45185, 45449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 45185, 45449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ContainsNativeInteger(this TypeWithAnnotations type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 45461, 45620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 45559, 45609);

                return f_10056_45576_45600(type.Type) == true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 45461, 45620);

                bool
                f_10056_45576_45600(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = (type?.ContainsNativeInteger()) ?? false;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 45576, 45600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 45461, 45620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 45461, 45620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ContainsErrorType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 45632, 45886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 45717, 45837);

                var
                result = f_10056_45730_45836(type, (type, unused1, unused2) => type.IsErrorType(), null, canDigThroughNullable: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 45851, 45875);

                return result is object;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 45632, 45886);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10056_45730_45836(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, object, bool, bool>
                predicate, object?
                arg, bool
                canDigThroughNullable)
                {
                    var return_v = type.VisitType<object?>(predicate, arg, canDigThroughNullable: canDigThroughNullable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 45730, 45836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 45632, 45886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 45632, 45886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ContainsTuple(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10056, 46060, 46160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 46076, 46160);
                return f_10056_46076_46150(type, (TypeSymbol t, object? _1, bool _2) => t.IsTupleType, null) is object; DynAbs.Tracing.TraceSender.TraceExitMethod(10056, 46060, 46160);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 46060, 46160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 46060, 46160);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            f_10056_46076_46150(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, object, bool, bool>
            predicate, object?
            arg)
            {
                var return_v = type.VisitType<object?>(predicate, arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 46076, 46150);
                return return_v;
            }

        }

        internal static bool ContainsTupleNames(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10056, 46359, 46476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 46375, 46476);
                return f_10056_46375_46466(type, (TypeSymbol t, object? _1, bool _2) => !t.TupleElementNames.IsDefault, null) is object; DynAbs.Tracing.TraceSender.TraceExitMethod(10056, 46359, 46476);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 46359, 46476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 46359, 46476);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            f_10056_46375_46466(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, object, bool, bool>
            predicate, object?
            arg)
            {
                var return_v = type.VisitType<object?>(predicate, arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 46375, 46466);
                return return_v;
            }

        }

        internal static bool ContainsFunctionPointer(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10056, 46677, 46783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 46693, 46783);
                return f_10056_46693_46773(type, (TypeSymbol t, object? _, bool _) => t.IsFunctionPointer(), null) is object; DynAbs.Tracing.TraceSender.TraceExitMethod(10056, 46677, 46783);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 46677, 46783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 46677, 46783);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            f_10056_46693_46773(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, object, bool, bool>
            predicate, object?
            arg)
            {
                var return_v = type.VisitType<object?>(predicate, arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 46693, 46773);
                return return_v;
            }

        }

        internal static TypeSymbol? GetNonErrorGuess(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 47624, 47900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 47715, 47778);

                var
                result = f_10056_47728_47777(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 47792, 47861);

                f_10056_47792_47860((object?)result == null || (DynAbs.Tracing.TraceSender.Expression_False(10056, 47811, 47859) || !f_10056_47839_47859(result)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 47875, 47889);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 47624, 47900);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10056_47728_47777(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                oldSymbol)
                {
                    var return_v = ExtendedErrorTypeSymbol.ExtractNonErrorType(oldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 47728, 47777);
                    return return_v;
                }


                bool
                f_10056_47839_47859(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 47839, 47859);
                    return return_v;
                }


                int
                f_10056_47792_47860(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 47792, 47860);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 47624, 47900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 47624, 47900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeKind GetNonErrorTypeKindGuess(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 48106, 48274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 48202, 48263);

                return f_10056_48209_48262(type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 48106, 48274);

                Microsoft.CodeAnalysis.TypeKind
                f_10056_48209_48262(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                oldSymbol)
                {
                    var return_v = ExtendedErrorTypeSymbol.ExtractNonErrorTypeKind(oldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 48209, 48262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 48106, 48274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 48106, 48274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidV6SwitchGoverningType(this TypeSymbol type, bool isTargetTypeOfUserDefinedOp = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 48635, 50846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 49610, 49651);

                f_10056_49610_49650((object)type != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 49665, 49779) || true) && (f_10056_49669_49690(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 49665, 49779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 49724, 49764);

                    type = f_10056_49731_49763(type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 49665, 49779);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 49888, 50008) || true) && (!isTargetTypeOfUserDefinedOp)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 49888, 50008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 49954, 49993);

                    type = f_10056_49961_49992(type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 49888, 50008);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 50024, 50806);

                switch (f_10056_50032_50048(type))
                {

                    case SpecialType.System_SByte:
                    case SpecialType.System_Byte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_Char:
                    case SpecialType.System_String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 50024, 50806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 50568, 50580);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 50024, 50806);

                    case SpecialType.System_Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 50024, 50806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 50755, 50791);

                        return !isTargetTypeOfUserDefinedOp;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 50024, 50806);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 50822, 50835);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 48635, 50846);

                int
                f_10056_49610_49650(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 49610, 49650);
                    return 0;
                }


                bool
                f_10056_49669_49690(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 49669, 49690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10056_49731_49763(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 49731, 49763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10056_49961_49992(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.EnumUnderlyingTypeOrSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 49961, 49992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10056_50032_50048(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 50032, 50048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 48635, 50846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 48635, 50846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsRestrictedType(this TypeSymbol type,
                                                        bool ignoreSpanLikeTypes = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 51296, 52004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 51552, 51593);

                f_10056_51552_51592((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 51607, 51871);

                switch (f_10056_51615_51631(type))
                {

                    case SpecialType.System_TypedReference:
                    case SpecialType.System_ArgIterator:
                    case SpecialType.System_RuntimeArgumentHandle:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 51607, 51871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 51844, 51856);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 51607, 51871);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 51887, 51993);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 51894, 51913) || ((ignoreSpanLikeTypes && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 51941, 51946)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 51974, 51992))) ? false : f_10056_51974_51992(type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 51296, 52004);

                int
                f_10056_51552_51592(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 51552, 51592);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10056_51615_51631(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 51615, 51631);
                    return return_v;
                }


                bool
                f_10056_51974_51992(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 51974, 51992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 51296, 52004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 51296, 52004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIntrinsicType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 52016, 53189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 52097, 53178);

                switch (f_10056_52105_52121(type))
                {

                    case SpecialType.System_Boolean:
                    case SpecialType.System_Char:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_Byte:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 52669, 52698) || true) && (f_10056_52674_52698(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 52669, 52698) || true)
                :
                    case SpecialType.System_UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 52749, 52778) || true) && (f_10056_52754_52778(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 52749, 52778) || true)
                :
                    case SpecialType.System_Single:
                    case SpecialType.System_Double:
                    // NOTE: VB treats System.DateTime as an intrinsic, while C# does not.
                    //case SpecialType.System_DateTime:
                    case SpecialType.System_Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 52097, 53178);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 53090, 53102);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 52097, 53178);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 52097, 53178);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 53150, 53163);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 52097, 53178);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 52016, 53189);

                Microsoft.CodeAnalysis.SpecialType
                f_10056_52105_52121(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 52105, 52121);
                    return return_v;
                }


                bool
                f_10056_52674_52698(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 52674, 52698);
                    return return_v;
                }


                bool
                f_10056_52754_52778(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 52754, 52778);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 52016, 53189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 52016, 53189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPartial(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 53201, 53344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 53276, 53333);

                return type is SourceNamedTypeSymbol { IsPartial: true };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 53201, 53344);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 53201, 53344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 53201, 53344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPointerType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 53356, 53479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 53435, 53468);

                return type is PointerTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 53356, 53479);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 53356, 53479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 53356, 53479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int FixedBufferElementSizeInBytes(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 53491, 53654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 53587, 53643);

                return f_10056_53594_53642(f_10056_53594_53610(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 53491, 53654);

                Microsoft.CodeAnalysis.SpecialType
                f_10056_53594_53610(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 53594, 53610);
                    return return_v;
                }


                int
                f_10056_53594_53642(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.FixedBufferElementSizeInBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 53594, 53642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 53491, 53654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 53491, 53654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidVolatileFieldType(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 53722, 54750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 53814, 54710);

                switch (f_10056_53822_53835(type))
                {

                    case TypeKind.Struct:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 53814, 54710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 53912, 53963);

                        return f_10056_53919_53962(f_10056_53919_53935(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 53814, 54710);

                    case TypeKind.Array:
                    case TypeKind.Class:
                    case TypeKind.Delegate:
                    case TypeKind.Dynamic:
                    case TypeKind.Error:
                    case TypeKind.Interface:
                    case TypeKind.Pointer:
                    case TypeKind.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 53814, 54710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 54312, 54324);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 53814, 54710);

                    case TypeKind.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 53814, 54710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 54385, 54474);

                        return f_10056_54392_54473(f_10056_54392_54446(f_10056_54392_54434(((NamedTypeSymbol)type))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 53814, 54710);

                    case TypeKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 53814, 54710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 54544, 54572);

                        return f_10056_54551_54571(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 53814, 54710);

                    case TypeKind.Submission:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 53814, 54710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 54639, 54695);

                        throw f_10056_54645_54694(f_10056_54680_54693(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 53814, 54710);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 54726, 54739);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 53722, 54750);

                Microsoft.CodeAnalysis.TypeKind
                f_10056_53822_53835(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 53822, 53835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10056_53919_53935(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 53919, 53935);
                    return return_v;
                }


                bool
                f_10056_53919_53962(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsValidVolatileFieldType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 53919, 53962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_54392_54434(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 54392, 54434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10056_54392_54446(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 54392, 54446);
                    return return_v;
                }


                bool
                f_10056_54392_54473(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsValidVolatileFieldType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 54392, 54473);
                    return return_v;
                }


                bool
                f_10056_54551_54571(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 54551, 54571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_54680_54693(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 54680, 54693);
                    return return_v;
                }


                System.Exception
                f_10056_54645_54694(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 54645, 54694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 53722, 54750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 53722, 54750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool MarkCheckedIfNecessary(this TypeSymbol type, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 54956, 55253);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 55082, 55196) || true) && (checkedTypes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 55082, 55196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 55140, 55181);

                    checkedTypes = f_10056_55155_55180();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 55082, 55196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 55212, 55242);

                return f_10056_55219_55241(checkedTypes, type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 54956, 55253);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10056_55155_55180()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 55155, 55180);
                    return return_v;
                }


                bool
                f_10056_55219_55241(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 55219, 55241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 54956, 55253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 54956, 55253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsUnsafe(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 55265, 56091);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 55341, 56080) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 55341, 56080);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 55386, 56065);

                        switch (f_10056_55394_55407(type))
                        {

                            case TypeKind.Pointer:
                            case TypeKind.FunctionPointer:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 55386, 56065);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 55549, 55561);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 55386, 56065);

                            case TypeKind.Array:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 55386, 56065);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 55629, 55672);

                                type = f_10056_55636_55671(((ArrayTypeSymbol)type));
                                DynAbs.Tracing.TraceSender.TraceBreak(10056, 55698, 55704);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 55386, 56065);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 55386, 56065);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 56033, 56046);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 55386, 56065);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 55341, 56080);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 55341, 56080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 55341, 56080);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 55265, 56091);

                Microsoft.CodeAnalysis.TypeKind
                f_10056_55394_55407(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 55394, 55407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10056_55636_55671(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 55636, 55671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 55265, 56091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 55265, 56091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsVoidPointer(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 56103, 56262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 56184, 56251);

                return type is PointerTypeSymbol p && (DynAbs.Tracing.TraceSender.Expression_True(10056, 56191, 56250) && f_10056_56222_56250(f_10056_56222_56237(p)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 56103, 56262);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10056_56222_56237(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 56222, 56237);
                    return return_v;
                }


                bool
                f_10056_56222_56250(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 56222, 56250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 56103, 56262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 56103, 56262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPrimitiveRecursiveStruct(this TypeSymbol t)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 56513, 56665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 56604, 56654);

                return f_10056_56611_56653(f_10056_56611_56624(t));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 56513, 56665);

                Microsoft.CodeAnalysis.SpecialType
                f_10056_56611_56624(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 56611, 56624);
                    return return_v;
                }


                bool
                f_10056_56611_56653(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsPrimitiveRecursiveStruct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 56611, 56653);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 56513, 56665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 56513, 56665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int ComputeHashCode(this NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 56892, 59752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 56979, 57109);

                f_10056_56979_57108(!f_10056_56999_57069(type, f_10056_57011_57034(type), TypeCompareKind.AllIgnoreOptions) || (DynAbs.Tracing.TraceSender.Expression_False(10056, 56998, 57107) || f_10056_57073_57107(type)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 57125, 57471) || true) && (f_10056_57129_57163(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 57125, 57471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 57411, 57456);

                    return f_10056_57418_57455(f_10056_57418_57441(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 57125, 57471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 57487, 57536);

                int
                code = f_10056_57498_57535(f_10056_57498_57521(type))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 57550, 57597);

                code = f_10056_57557_57596(f_10056_57570_57589(type), code);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 58307, 58574) || true) && ((object)f_10056_58319_58339(type) != (object)type)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 58307, 58574);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 58389, 58559);
                        foreach (var arg in f_10056_58409_58462_I(f_10056_58409_58462(type)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 58389, 58559);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 58504, 58540);

                            code = f_10056_58511_58539(arg.Type, code);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 58389, 58559);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 171);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 171);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 58307, 58574);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 58740, 58809) || true) && (code == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 58740, 58809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 58787, 58794);

                    code++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 58740, 58809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 58823, 58835);

                return code;

                static bool wasConstructedForAnnotations(NamedTypeSymbol type)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 58851, 59741);
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 58946, 59694);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 58989, 59063);

                                    var
                                    typeArguments = f_10056_59009_59062(type)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 59085, 59145);

                                    var
                                    typeParameters = f_10056_59106_59144(f_10056_59106_59129(type))
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 59178, 59183);

                                        for (int
                    i = 0
                    ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 59169, 59561) || true) && (i < typeArguments.Length)
                    ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 59211, 59214)
                    , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 59169, 59561))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 59169, 59561);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 59264, 59538) || true) && (!f_10056_59269_59440(typeParameters[i], f_10056_59329_59369(typeArguments[i].Type), TypeCompareKind.ConsiderEverything))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 59264, 59538);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 59498, 59511);

                                                return false;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 59264, 59538);
                                            }
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 393);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 393);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 59585, 59612);

                                    type = f_10056_59592_59611(type);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 58946, 59694);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 58946, 59694) || true) && (type is object && (DynAbs.Tracing.TraceSender.Expression_True(10056, 59656, 59692) && f_10056_59674_59692_M(!type.IsDefinition)))
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 58946, 59694);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 58946, 59694);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 59714, 59726);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 58851, 59741);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10056_59009_59062(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 59009, 59062);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10056_59106_59129(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 59106, 59129);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        f_10056_59106_59144(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeParameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 59106, 59144);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10056_59329_59369(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 59329, 59369);
                            return return_v;
                        }


                        bool
                        f_10056_59269_59440(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        t2, Microsoft.CodeAnalysis.TypeCompareKind
                        comparison)
                        {
                            var return_v = this_param.Equals(t2, comparison);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 59269, 59440);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10056_59592_59611(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 59592, 59611);
                            return return_v;
                        }


                        bool
                        f_10056_59674_59692_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 59674, 59692);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 58851, 59741);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 58851, 59741);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 56892, 59752);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_57011_57034(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 57011, 57034);
                    return return_v;
                }


                bool
                f_10056_56999_57069(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 56999, 57069);
                    return return_v;
                }


                bool
                f_10056_57073_57107(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = wasConstructedForAnnotations(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 57073, 57107);
                    return return_v;
                }


                int
                f_10056_56979_57108(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 56979, 57108);
                    return 0;
                }


                bool
                f_10056_57129_57163(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = wasConstructedForAnnotations(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 57129, 57163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_57418_57441(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 57418, 57441);
                    return return_v;
                }


                int
                f_10056_57418_57455(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 57418, 57455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_57498_57521(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 57498, 57521);
                    return return_v;
                }


                int
                f_10056_57498_57535(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 57498, 57535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_57570_57589(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 57570, 57589);
                    return return_v;
                }


                int
                f_10056_57557_57596(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 57557, 57596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_58319_58339(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 58319, 58339);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_58409_58462(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 58409, 58462);
                    return return_v;
                }


                int
                f_10056_58511_58539(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 58511, 58539);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_58409_58462_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 58409, 58462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 56892, 59752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 56892, 59752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeSymbol AsDynamicIfNoPia(this TypeSymbol type, NamedTypeSymbol containingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 60352, 60571);
                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol? result = default(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 60472, 60560);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 60479, 60543) || ((f_10056_60479_60543(type, containingType, out result) && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 60546, 60552)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 60555, 60559))) ? result : type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 60352, 60571);

                bool
                f_10056_60479_60543(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                result)
                {
                    var return_v = type.TryAsDynamicIfNoPia(containingType, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 60479, 60543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 60352, 60571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 60352, 60571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryAsDynamicIfNoPia(this TypeSymbol type, NamedTypeSymbol containingType, [NotNullWhen(true)] out TypeSymbol? result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 60583, 61238);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 60744, 61172) || true) && (f_10056_60748_60764(type) == SpecialType.System_Object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 60744, 61172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 60827, 60887);

                    AssemblySymbol
                    assembly = f_10056_60853_60886(containingType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 60905, 61157) || true) && ((object)assembly != null && (DynAbs.Tracing.TraceSender.Expression_True(10056, 60909, 60975) && f_10056_60958_60975(assembly)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 60909, 61026) && f_10056_61000_61026(containingType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 60905, 61157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 61068, 61104);

                        result = DynamicTypeSymbol.Instance;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 61126, 61138);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 60905, 61157);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 60744, 61172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 61186, 61200);

                result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 61214, 61227);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 60583, 61238);

                Microsoft.CodeAnalysis.SpecialType
                f_10056_60748_60764(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 60748, 60764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10056_60853_60886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 60853, 60886);
                    return return_v;
                }


                bool
                f_10056_60958_60975(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 60958, 60975);
                    return return_v;
                }


                bool
                f_10056_61000_61026(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsComImport;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 61000, 61026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 60583, 61238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 60583, 61238);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsVerifierReference(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 61379, 61548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 61466, 61537);

                return f_10056_61473_61493(type) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 61473, 61536) && f_10056_61497_61510(type) != TypeKind.TypeParameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 61379, 61548);

                bool
                f_10056_61473_61493(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 61473, 61493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_61497_61510(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 61497, 61510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 61379, 61548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 61379, 61548);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsVerifierValue(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 61685, 61846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 61768, 61835);

                return f_10056_61775_61791(type) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 61775, 61834) && f_10056_61795_61808(type) != TypeKind.TypeParameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 61685, 61846);

                bool
                f_10056_61775_61791(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 61775, 61791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_61795_61808(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 61795, 61808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 61685, 61846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 61685, 61846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void AddUseSiteDiagnostics(
                    this TypeSymbol type,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 61858, 62378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 62022, 62077);

                DiagnosticInfo
                errorInfo = f_10056_62049_62076(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 62093, 62367) || true) && ((object)errorInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 62093, 62367);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 62156, 62298) || true) && (useSiteDiagnostics == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 62156, 62298);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 62228, 62279);

                        useSiteDiagnostics = f_10056_62249_62278();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 62156, 62298);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 62318, 62352);

                    f_10056_62318_62351(
                                    useSiteDiagnostics, errorInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 62093, 62367);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 61858, 62378);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10056_62049_62076(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 62049, 62076);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10056_62249_62278()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 62249, 62278);
                    return return_v;
                }


                bool
                f_10056_62318_62351(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 62318, 62351);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 61858, 62378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 61858, 62378);
            }
        }

        internal static ImmutableArray<TypeParameterSymbol> GetAllTypeParameters(this NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 62567, 63057);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 62754, 62869) || true) && ((object)f_10056_62766_62785(type) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 62754, 62869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 62827, 62854);

                    return f_10056_62834_62853(type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 62754, 62869);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 62885, 62947);

                var
                builder = f_10056_62899_62946()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 62961, 62996);

                f_10056_62961_62995(type, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 63010, 63046);

                return f_10056_63017_63045(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 62567, 63057);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_62766_62785(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 62766, 62785);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10056_62834_62853(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 62834, 62853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10056_62899_62946()
                {
                    var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 62899, 62946);
                    return return_v;
                }


                int
                f_10056_62961_62995(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                result)
                {
                    type.GetAllTypeParameters(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 62961, 62995);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10056_63017_63045(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 63017, 63045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 62567, 63057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 62567, 63057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void GetAllTypeParameters(this NamedTypeSymbol type, ArrayBuilder<TypeParameterSymbol> result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 63246, 63627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 63381, 63422);

                var
                containingType = f_10056_63402_63421(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 63436, 63563) || true) && ((object)containingType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 63436, 63563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 63504, 63548);

                    f_10056_63504_63547(containingType, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 63436, 63563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 63579, 63616);

                f_10056_63579_63615(
                            result, f_10056_63595_63614(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 63246, 63627);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_63402_63421(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 63402, 63421);
                    return return_v;
                }


                int
                f_10056_63504_63547(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                result)
                {
                    type.GetAllTypeParameters(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 63504, 63547);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10056_63595_63614(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 63595, 63614);
                    return return_v;
                }


                int
                f_10056_63579_63615(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 63579, 63615);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 63246, 63627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 63246, 63627);
            }
        }

        internal static TypeParameterSymbol? FindEnclosingTypeParameter(this NamedTypeSymbol type, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 63802, 64456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 63930, 64002);

                var
                allTypeParameters = f_10056_63954_64001()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 64016, 64061);

                f_10056_64016_64060(type, allTypeParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 64077, 64112);

                TypeParameterSymbol?
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 64128, 64376);
                    foreach (TypeParameterSymbol tpEnclosing in f_10056_64172_64189_I(allTypeParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 64128, 64376);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 64223, 64361) || true) && (name == f_10056_64235_64251(tpEnclosing))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 64223, 64361);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 64293, 64314);

                            result = tpEnclosing;
                            DynAbs.Tracing.TraceSender.TraceBreak(10056, 64336, 64342);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 64223, 64361);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 64128, 64376);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 64392, 64417);

                f_10056_64392_64416(
                            allTypeParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 64431, 64445);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 63802, 64456);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10056_63954_64001()
                {
                    var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 63954, 64001);
                    return return_v;
                }


                int
                f_10056_64016_64060(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                result)
                {
                    type.GetAllTypeParameters(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 64016, 64060);
                    return 0;
                }


                string
                f_10056_64235_64251(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 64235, 64251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10056_64172_64189_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 64172, 64189);
                    return return_v;
                }


                int
                f_10056_64392_64416(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 64392, 64416);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 63802, 64456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 63802, 64456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeParameterSymbol? FindEnclosingTypeParameter(this Symbol methodOrType, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 64635, 65649);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 64762, 65612) || true) && (methodOrType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 64762, 65612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 64823, 65263);

                        switch (f_10056_64831_64848(methodOrType))
                        {

                            case SymbolKind.Method:
                            case SymbolKind.NamedType:
                            case SymbolKind.ErrorType:
                            case SymbolKind.Field:
                            case SymbolKind.Property:
                            case SymbolKind.Event:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 64823, 65263);
                                DynAbs.Tracing.TraceSender.TraceBreak(10056, 65170, 65176);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 64823, 65263);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 64823, 65263);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 65232, 65244);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 64823, 65263);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 65281, 65534);
                            foreach (var typeParameter in f_10056_65311_65349_I(f_10056_65311_65349(methodOrType)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 65281, 65534);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 65391, 65515) || true) && (f_10056_65395_65413(typeParameter) == name)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 65391, 65515);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 65471, 65492);

                                    return typeParameter;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 65391, 65515);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 65281, 65534);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 254);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 254);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 65552, 65597);

                        methodOrType = f_10056_65567_65596(methodOrType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 64762, 65612);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 64762, 65612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 64762, 65612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 65626, 65638);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 64635, 65649);

                Microsoft.CodeAnalysis.SymbolKind
                f_10056_64831_64848(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 64831, 64848);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10056_65311_65349(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberTypeParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 65311, 65349);
                    return return_v;
                }


                string
                f_10056_65395_65413(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 65395, 65413);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10056_65311_65349_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 65311, 65349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10056_65567_65596(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 65567, 65596);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 64635, 65649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 64635, 65649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasNameQualifier(this NamedTypeSymbol type, string qualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 65939, 66795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 66050, 66111);

                const StringComparison
                comparison = StringComparison.Ordinal
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 66127, 66165);

                var
                container = f_10056_66143_66164(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 66179, 66487) || true) && (f_10056_66183_66197(container) != SymbolKind.Namespace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 66179, 66487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 66352, 66472);

                    return f_10056_66359_66471(f_10056_66373_66443(container, SymbolDisplayFormat.QualifiedNameOnlyFormat), qualifiedName, comparison);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 66179, 66487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 66503, 66547);

                var
                @namespace = (NamespaceSymbol)container
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 66561, 66675) || true) && (f_10056_66565_66593(@namespace))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 66561, 66675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 66627, 66660);

                    return f_10056_66634_66654(qualifiedName) == 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 66561, 66675);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 66691, 66784);

                return f_10056_66698_66783(@namespace, qualifiedName, comparison, length: f_10056_66762_66782(qualifiedName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 65939, 66795);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10056_66143_66164(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 66143, 66164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10056_66183_66197(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 66183, 66197);
                    return return_v;
                }


                string
                f_10056_66373_66443(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 66373, 66443);
                    return return_v;
                }


                bool
                f_10056_66359_66471(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 66359, 66471);
                    return return_v;
                }


                bool
                f_10056_66565_66593(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 66565, 66593);
                    return return_v;
                }


                int
                f_10056_66634_66654(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 66634, 66654);
                    return return_v;
                }


                int
                f_10056_66762_66782(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 66762, 66782);
                    return return_v;
                }


                bool
                f_10056_66698_66783(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                @namespace, string
                namespaceName, System.StringComparison
                comparison, int
                length)
                {
                    var return_v = HasNamespaceName(@namespace, namespaceName, comparison, length: length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 66698, 66783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 65939, 66795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 65939, 66795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasNamespaceName(NamespaceSymbol @namespace, string namespaceName, StringComparison comparison, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 66807, 67957);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 66959, 67036) || true) && (length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 66959, 67036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67008, 67021);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 66959, 67036);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67052, 67099);

                var
                container = f_10056_67068_67098(@namespace)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67113, 67180);

                int
                separator = f_10056_67129_67179(namespaceName, '.', length - 1, length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67194, 67209);

                int
                offset = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67223, 67781) || true) && (separator >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 67223, 67781);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67275, 67380) || true) && (f_10056_67279_67306(container))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 67275, 67380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67348, 67361);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 67275, 67380);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67400, 67552) || true) && (!f_10056_67405_67478(container, namespaceName, comparison, length: separator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 67400, 67552);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67520, 67533);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 67400, 67552);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67572, 67594);

                    int
                    n = separator + 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67612, 67623);

                    offset = n;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67641, 67653);

                    length -= n;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 67223, 67781);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 67223, 67781);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67687, 67781) || true) && (f_10056_67691_67719_M(!container.IsGlobalNamespace))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 67687, 67781);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67753, 67766);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 67687, 67781);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 67223, 67781);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67797, 67824);

                var
                name = f_10056_67808_67823(@namespace)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 67838, 67946);

                return (f_10056_67846_67857(name) == length) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 67845, 67945) && (f_10056_67873_67939(name, 0, namespaceName, offset, length, comparison) == 0));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 66807, 67957);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10056_67068_67098(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 67068, 67098);
                    return return_v;
                }


                int
                f_10056_67129_67179(string
                this_param, char
                value, int
                startIndex, int
                count)
                {
                    var return_v = this_param.LastIndexOf(value, startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 67129, 67179);
                    return return_v;
                }


                bool
                f_10056_67279_67306(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 67279, 67306);
                    return return_v;
                }


                bool
                f_10056_67405_67478(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                @namespace, string
                namespaceName, System.StringComparison
                comparison, int
                length)
                {
                    var return_v = HasNamespaceName(@namespace, namespaceName, comparison, length: length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 67405, 67478);
                    return return_v;
                }


                bool
                f_10056_67691_67719_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 67691, 67719);
                    return return_v;
                }


                string
                f_10056_67808_67823(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 67808, 67823);
                    return return_v;
                }


                int
                f_10056_67846_67857(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 67846, 67857);
                    return return_v;
                }


                int
                f_10056_67873_67939(string
                strA, int
                indexA, string
                strB, int
                indexB, int
                length, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, indexA, strB, indexB, length, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 67873, 67939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 66807, 67957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 66807, 67957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNonGenericTaskType(this TypeSymbol type, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 67969, 68605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 68088, 68128);

                var
                namedType = type as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 68142, 68249) || true) && (namedType is null || (DynAbs.Tracing.TraceSender.Expression_False(10056, 68146, 68187) || f_10056_68167_68182(namedType) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 68142, 68249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 68221, 68234);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 68142, 68249);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 68263, 68420) || true) && ((object)namedType == f_10056_68288_68359(compilation, WellKnownType.System_Threading_Tasks_Task))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 68263, 68420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 68393, 68405);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 68263, 68420);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 68434, 68522) || true) && (f_10056_68438_68460(namedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 68434, 68522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 68494, 68507);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 68434, 68522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 68536, 68594);

                return f_10056_68543_68593(namedType, builderArgument: out _);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 67969, 68605);

                int
                f_10056_68167_68182(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 68167, 68182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_68288_68359(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 68288, 68359);
                    return return_v;
                }


                bool
                f_10056_68438_68460(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 68438, 68460);
                    return return_v;
                }


                bool
                f_10056_68543_68593(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, out object?
                builderArgument)
                {
                    var return_v = type.IsCustomTaskType(out builderArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 68543, 68593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 67969, 68605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 67969, 68605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsGenericTaskType(this TypeSymbol type, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 68617, 69120);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 68733, 68848) || true) && (!(type is NamedTypeSymbol { Arity: 1 } namedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 68733, 68848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 68820, 68833);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 68733, 68848);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 68862, 69037) || true) && ((object)f_10056_68874_68899(namedType) == f_10056_68903_68976(compilation, WellKnownType.System_Threading_Tasks_Task_T))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 68862, 69037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 69010, 69022);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 68862, 69037);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 69051, 69109);

                return f_10056_69058_69108(namedType, builderArgument: out _);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 68617, 69120);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_68874_68899(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 68874, 68899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_68903_68976(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 68903, 68976);
                    return return_v;
                }


                bool
                f_10056_69058_69108(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, out object?
                builderArgument)
                {
                    var return_v = type.IsCustomTaskType(out builderArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 69058, 69108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 68617, 69120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 68617, 69120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsIAsyncEnumerableType(this TypeSymbol type, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 69132, 69529);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 69253, 69368) || true) && (!(type is NamedTypeSymbol { Arity: 1 } namedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 69253, 69368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 69340, 69353);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 69253, 69368);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 69384, 69518);

                return (object)f_10056_69399_69424(namedType) == f_10056_69428_69517(compilation, WellKnownType.System_Collections_Generic_IAsyncEnumerable_T);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 69132, 69529);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_69399_69424(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 69399, 69424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_69428_69517(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 69428, 69517);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 69132, 69529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 69132, 69529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsIAsyncEnumeratorType(this TypeSymbol type, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 69541, 69938);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 69662, 69777) || true) && (!(type is NamedTypeSymbol { Arity: 1 } namedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 69662, 69777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 69749, 69762);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 69662, 69777);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 69793, 69927);

                return (object)f_10056_69808_69833(namedType) == f_10056_69837_69926(compilation, WellKnownType.System_Collections_Generic_IAsyncEnumerator_T);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 69541, 69938);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_69808_69833(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 69808, 69833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_69837_69926(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 69837, 69926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 69541, 69938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 69541, 69938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsCustomTaskType(this NamedTypeSymbol type, [NotNullWhen(true)] out object? builderArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 70590, 71543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 70728, 70769);

                f_10056_70728_70768((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 70785, 70808);

                var
                arity = f_10056_70797_70807(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 70822, 71466) || true) && (arity < 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 70822, 71466);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 70922, 71451);
                        foreach (var attr in f_10056_70943_70963_I(f_10056_70943_70963(type)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 70922, 71451);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 71005, 71432) || true) && (f_10056_71009_71087(attr, type, AttributeDescription.AsyncMethodBuilderAttribute) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 71009, 71159) && attr.CommonConstructorArguments.Length == 1
                            ) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 71009, 71253) && f_10056_71188_71219(attr)[0].Kind == TypedConstantKind.Type))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 71005, 71432);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 71303, 71371);

                                builderArgument = f_10056_71321_71352(attr)[0].ValueInternal!;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 71397, 71409);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 71005, 71432);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 70922, 71451);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 530);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 530);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 70822, 71466);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 71482, 71505);

                builderArgument = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 71519, 71532);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 70590, 71543);

                int
                f_10056_70728_70768(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 70728, 70768);
                    return 0;
                }


                int
                f_10056_70797_70807(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 70797, 70807);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10056_70943_70963(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 70943, 70963);
                    return return_v;
                }


                bool
                f_10056_71009_71087(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 71009, 71087);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10056_71188_71219(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 71188, 71219);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10056_71321_71352(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 71321, 71352);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10056_70943_70963_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 70943, 70963);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 70590, 71543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 70590, 71543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeSymbol NormalizeTaskTypes(this TypeSymbol type, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 71656, 71864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 71779, 71827);

                f_10056_71779_71826(compilation, ref type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 71841, 71853);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 71656, 71864);

                bool
                f_10056_71779_71826(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = NormalizeTaskTypesInType(compilation, ref type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 71779, 71826);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 71656, 71864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 71656, 71864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NormalizeTaskTypesInType(CSharpCompilation compilation, ref TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 72013, 73668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 72134, 73630);

                switch (f_10056_72142_72151(type))
                {

                    case SymbolKind.NamedType:
                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 72134, 73630);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 72304, 72342);

                            var
                            namedType = (NamedTypeSymbol)type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 72368, 72440);

                            var
                            changed = f_10056_72382_72439(compilation, ref namedType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 72466, 72483);

                            type = namedType;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 72509, 72524);

                            return changed;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 72134, 73630);

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 72134, 73630);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 72640, 72678);

                            var
                            arrayType = (ArrayTypeSymbol)type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 72704, 72772);

                            var
                            changed = f_10056_72718_72771(compilation, ref arrayType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 72798, 72815);

                            type = arrayType;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 72841, 72856);

                            return changed;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 72134, 73630);

                    case SymbolKind.PointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 72134, 73630);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 72974, 73016);

                            var
                            pointerType = (PointerTypeSymbol)type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 73042, 73114);

                            var
                            changed = f_10056_73056_73113(compilation, ref pointerType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 73140, 73159);

                            type = pointerType;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 73185, 73200);

                            return changed;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 72134, 73630);

                    case SymbolKind.FunctionPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 72134, 73630);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 73326, 73384);

                            var
                            functionPointerType = (FunctionPointerTypeSymbol)type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 73410, 73498);

                            var
                            changed = f_10056_73424_73497(compilation, ref functionPointerType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 73524, 73551);

                            type = functionPointerType;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 73577, 73592);

                            return changed;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 72134, 73630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 73644, 73657);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 72013, 73668);

                Microsoft.CodeAnalysis.SymbolKind
                f_10056_72142_72151(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 72142, 72151);
                    return return_v;
                }


                bool
                f_10056_72382_72439(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = NormalizeTaskTypesInNamedType(compilation, ref type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 72382, 72439);
                    return return_v;
                }


                bool
                f_10056_72718_72771(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType)
                {
                    var return_v = NormalizeTaskTypesInArray(compilation, ref arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 72718, 72771);
                    return return_v;
                }


                bool
                f_10056_73056_73113(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                pointerType)
                {
                    var return_v = NormalizeTaskTypesInPointer(compilation, ref pointerType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 73056, 73113);
                    return return_v;
                }


                bool
                f_10056_73424_73497(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                funcPtrType)
                {
                    var return_v = NormalizeTaskTypesInFunctionPointer(compilation, ref funcPtrType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 73424, 73497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 72013, 73668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 72013, 73668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NormalizeTaskTypesInType(CSharpCompilation compilation, ref TypeWithAnnotations typeWithAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 73680, 74152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 73825, 73861);

                var
                type = typeWithAnnotations.Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 73875, 74114) || true) && (f_10056_73879_73926(compilation, ref type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 73875, 74114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 73960, 74069);

                    typeWithAnnotations = TypeWithAnnotations.Create(type, customModifiers: typeWithAnnotations.CustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74087, 74099);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 73875, 74114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74128, 74141);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 73680, 74152);

                bool
                f_10056_73879_73926(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = NormalizeTaskTypesInType(compilation, ref type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 73879, 73926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 73680, 74152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 73680, 74152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NormalizeTaskTypesInNamedType(CSharpCompilation compilation, ref NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 74164, 76876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74295, 74319);

                bool
                hasChanged = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74335, 75912) || true) && (f_10056_74339_74357_M(!type.IsDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 74335, 75912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74391, 74430);

                    f_10056_74391_74429(f_10056_74410_74428(type));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74448, 74523);

                    var
                    typeArgumentsBuilder = f_10056_74475_74522()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74541, 74592);

                    HashSet<DiagnosticInfo>?
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74610, 74681);

                    f_10056_74610_74680(type, typeArgumentsBuilder, ref useSiteDiagnostics);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74708, 74713);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74699, 75343) || true) && (i < f_10056_74719_74745(typeArgumentsBuilder))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74747, 74750)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 74699, 75343))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 74699, 75343);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74792, 74839);

                            var
                            typeWithModifier = f_10056_74815_74838(typeArgumentsBuilder, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74861, 74907);

                            var
                            typeArgNormalized = typeWithModifier.Type
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 74929, 75324) || true) && (f_10056_74933_74993(compilation, ref typeArgNormalized))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 74929, 75324);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 75043, 75061);

                                hasChanged = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 75178, 75301);

                                typeArgumentsBuilder[i] = TypeWithAnnotations.Create(typeArgNormalized, customModifiers: typeWithModifier.CustomModifiers);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 74929, 75324);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 645);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 645);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 75361, 75851) || true) && (hasChanged)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 75361, 75851);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 75417, 75441);

                        var
                        originalType = type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 75463, 75520);

                        var
                        originalDefinition = f_10056_75488_75519(originalType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 75542, 75605);

                        var
                        typeParameters = f_10056_75563_75604(originalDefinition)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 75627, 75723);

                        var
                        typeMap = f_10056_75641_75722(typeParameters, f_10056_75669_75703(typeArgumentsBuilder), allowAlpha: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 75745, 75832);

                        type = f_10056_75752_75831(f_10056_75752_75799(typeMap, originalDefinition), originalType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 75361, 75851);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 75869, 75897);

                    f_10056_75869_75896(typeArgumentsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 74335, 75912);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 75928, 76831) || true) && (f_10056_75932_75996(f_10056_75932_75955(type), builderArgument: out _))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 75928, 76831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 76030, 76053);

                    int
                    arity = f_10056_76042_76052(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 76071, 76101);

                    f_10056_76071_76100(arity < 2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 76119, 76329);

                    var
                    taskType = f_10056_76134_76328(compilation, (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 76185, 76195) || ((arity == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 76219, 76260)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 76284, 76327))) ? WellKnownType.System_Threading_Tasks_Task : WellKnownType.System_Threading_Tasks_Task_T)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 76347, 76522) || true) && (f_10056_76351_76368(taskType) == TypeKind.Error)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 76347, 76522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 76490, 76503);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 76347, 76522);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 76540, 76780);

                    type = (DynAbs.Tracing.TraceSender.Conditional_F1(10056, 76547, 76557) || ((arity == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10056, 76581, 76589)) || DynAbs.Tracing.TraceSender.Conditional_F3(10056, 76613, 76779))) ? taskType : f_10056_76613_76779(taskType, f_10056_76658_76737(f_10056_76680_76733(type)[0]), unbound: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 76798, 76816);

                    hasChanged = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 75928, 76831);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 76847, 76865);

                return hasChanged;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 74164, 76876);

                bool
                f_10056_74339_74357_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 74339, 74357);
                    return return_v;
                }


                bool
                f_10056_74410_74428(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 74410, 74428);
                    return return_v;
                }


                int
                f_10056_74391_74429(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 74391, 74429);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_74475_74522()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 74475, 74522);
                    return return_v;
                }


                int
                f_10056_74610_74680(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 74610, 74680);
                    return 0;
                }


                int
                f_10056_74719_74745(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 74719, 74745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10056_74815_74838(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 74815, 74838);
                    return return_v;
                }


                bool
                f_10056_74933_74993(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = NormalizeTaskTypesInType(compilation, ref type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 74933, 74993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_75488_75519(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 75488, 75519);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10056_75563_75604(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.GetAllTypeParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 75563, 75604);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_75669_75703(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 75669, 75703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10056_75641_75722(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to, bool
                allowAlpha)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha: allowAlpha);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 75641, 75722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_75752_75799(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 75752, 75799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_75752_75831(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                original)
                {
                    var return_v = this_param.WithTupleDataFrom(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 75752, 75831);
                    return return_v;
                }


                int
                f_10056_75869_75896(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 75869, 75896);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_75932_75955(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 75932, 75955);
                    return return_v;
                }


                bool
                f_10056_75932_75996(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, out object?
                builderArgument)
                {
                    var return_v = type.IsCustomTaskType(out builderArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 75932, 75996);
                    return return_v;
                }


                int
                f_10056_76042_76052(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 76042, 76052);
                    return return_v;
                }


                int
                f_10056_76071_76100(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 76071, 76100);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_76134_76328(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 76134, 76328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10056_76351_76368(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 76351, 76368);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_76680_76733(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 76680, 76733);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_76658_76737(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 76658, 76737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_76613_76779(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.Construct(typeArguments, unbound: unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 76613, 76779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 74164, 76876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 74164, 76876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NormalizeTaskTypesInArray(CSharpCompilation compilation, ref ArrayTypeSymbol arrayType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 76888, 77312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 77020, 77075);

                var
                elementType = f_10056_77038_77074(arrayType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 77089, 77210) || true) && (!f_10056_77094_77148(compilation, ref elementType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 77089, 77210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 77182, 77195);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 77089, 77210);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 77224, 77275);

                arrayType = f_10056_77236_77274(arrayType, elementType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 77289, 77301);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 76888, 77312);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10056_77038_77074(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 77038, 77074);
                    return return_v;
                }


                bool
                f_10056_77094_77148(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = NormalizeTaskTypesInType(compilation, ref typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 77094, 77148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10056_77236_77274(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations)
                {
                    var return_v = this_param.WithElementType(elementTypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 77236, 77274);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 76888, 77312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 76888, 77312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NormalizeTaskTypesInPointer(CSharpCompilation compilation, ref PointerTypeSymbol pointerType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 77324, 77841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 77462, 77523);

                var
                pointedAtType = f_10056_77482_77522(pointerType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 77537, 77660) || true) && (!f_10056_77542_77598(compilation, ref pointedAtType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 77537, 77660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 77632, 77645);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 77537, 77660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 77753, 77804);

                pointerType = f_10056_77767_77803(pointedAtType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 77818, 77830);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 77324, 77841);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10056_77482_77522(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 77482, 77522);
                    return return_v;
                }


                bool
                f_10056_77542_77598(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = NormalizeTaskTypesInType(compilation, ref typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 77542, 77598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10056_77767_77803(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                pointedAtType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 77767, 77803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 77324, 77841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 77324, 77841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NormalizeTaskTypesInFunctionPointer(CSharpCompilation compilation, ref FunctionPointerTypeSymbol funcPtrType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 77853, 79529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78007, 78072);

                var
                returnType = f_10056_78024_78071(f_10056_78024_78045(funcPtrType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78086, 78158);

                var
                madeChanges = f_10056_78104_78157(compilation, ref returnType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78174, 78233);

                var
                paramTypes = ImmutableArray<TypeWithAnnotations>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78249, 79195) || true) && (f_10056_78253_78289(f_10056_78253_78274(funcPtrType)) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 78249, 79195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78327, 78431);

                    var
                    paramsBuilder = f_10056_78347_78430(f_10056_78393_78429(f_10056_78393_78414(funcPtrType)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78449, 78479);

                    bool
                    madeParamChanges = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78497, 78800);
                        foreach (var param in f_10056_78519_78551_I(f_10056_78519_78551(f_10056_78519_78540(funcPtrType))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 78497, 78800);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78593, 78635);

                            var
                            paramType = f_10056_78609_78634(param)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78657, 78730);

                            madeParamChanges |= f_10056_78677_78729(compilation, ref paramType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78752, 78781);

                            f_10056_78752_78780(paramsBuilder, paramType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 78497, 78800);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10056, 1, 304);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10056, 1, 304);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78820, 79180) || true) && (madeParamChanges)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 78820, 79180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78882, 78901);

                        madeChanges = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 78923, 78971);

                        paramTypes = f_10056_78936_78970(paramsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 78820, 79180);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 78820, 79180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 79053, 79118);

                        paramTypes = f_10056_79066_79117(f_10056_79066_79087(funcPtrType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 79140, 79161);

                        f_10056_79140_79160(paramsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 78820, 79180);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 78249, 79195);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 79211, 79518) || true) && (madeChanges)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 79211, 79518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 79260, 79394);

                    funcPtrType = f_10056_79274_79393(funcPtrType, returnType, paramTypes, refCustomModifiers: default, paramRefCustomModifiers: default);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 79412, 79424);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 79211, 79518);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 79211, 79518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 79490, 79503);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 79211, 79518);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 77853, 79529);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10056_78024_78045(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 78024, 78045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10056_78024_78071(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 78024, 78071);
                    return return_v;
                }


                bool
                f_10056_78104_78157(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = NormalizeTaskTypesInType(compilation, ref typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 78104, 78157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10056_78253_78274(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 78253, 78274);
                    return return_v;
                }


                int
                f_10056_78253_78289(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 78253, 78289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10056_78393_78414(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 78393, 78414);
                    return return_v;
                }


                int
                f_10056_78393_78429(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 78393, 78429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_78347_78430(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 78347, 78430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10056_78519_78540(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 78519, 78540);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10056_78519_78551(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 78519, 78551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10056_78609_78634(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 78609, 78634);
                    return return_v;
                }


                bool
                f_10056_78677_78729(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = NormalizeTaskTypesInType(compilation, ref typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 78677, 78729);
                    return return_v;
                }


                int
                f_10056_78752_78780(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 78752, 78780);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10056_78519_78551_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 78519, 78551);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_78936_78970(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 78936, 78970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10056_79066_79087(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 79066, 79087);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10056_79066_79117(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 79066, 79117);
                    return return_v;
                }


                int
                f_10056_79140_79160(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 79140, 79160);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10056_79274_79393(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                substitutedParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                paramRefCustomModifiers)
                {
                    var return_v = this_param.SubstituteTypeSymbol(substitutedReturnType, substitutedParameterTypes, refCustomModifiers: refCustomModifiers, paramRefCustomModifiers: paramRefCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 79274, 79393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 77853, 79529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 77853, 79529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Cci.TypeReferenceWithAttributes GetTypeRefWithAttributes(
                    this TypeWithAnnotations type,
                    Emit.PEModuleBuilder moduleBuilder,
                    Symbol declaringSymbol,
                    Cci.ITypeReference typeRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 79541, 81093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 79810, 79873);

                var
                builder = f_10056_79824_79872()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 79887, 79942);

                var
                compilation = f_10056_79905_79941(declaringSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 79958, 80984) || true) && (compilation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 79958, 80984);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 80015, 80186) || true) && (f_10056_80019_80049(type.Type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 80015, 80186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 80091, 80167);

                        f_10056_80091_80166(builder, f_10056_80113_80165(compilation, type.Type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 80015, 80186);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 80204, 80400) || true) && (f_10056_80208_80241(type.Type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 80204, 80400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 80283, 80381);

                        f_10056_80283_80380(builder, f_10056_80305_80379(moduleBuilder, declaringSymbol, type.Type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 80204, 80400);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 80418, 80682) || true) && (f_10056_80422_80479(compilation, declaringSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 80418, 80682);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 80521, 80663);

                        f_10056_80521_80662(builder, f_10056_80543_80661(moduleBuilder, declaringSymbol, f_10056_80613_80654(declaringSymbol), type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 80418, 80682);
                    }

                    
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 79958, 80984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 81000, 81082);

                return f_10056_81007_81081(typeRef, f_10056_81052_81080(builder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 79541, 81093);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ICustomAttribute>
                f_10056_79824_79872()
                {
                    var return_v = ArrayBuilder<Cci.ICustomAttribute>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 79824, 79872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10056_79905_79941(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 79905, 79941);
                    return return_v;
                }


                bool
                f_10056_80019_80049(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 80019, 80049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10056_80113_80165(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeTupleNamesAttribute(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 80113, 80165);
                    return return_v;
                }

                static void addIfNotNull(ArrayBuilder<Cci.ICustomAttribute> builder, SynthesizedAttributeData? attr)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 80702, 80969);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 80843, 80950) || true) && (attr != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 80843, 80950);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 80909, 80927);

                            f_10056_80909_80926(builder, attr);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 80843, 80950);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 80702, 80969);

                        int
                        f_10056_80909_80926(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ICustomAttribute>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                        item)
                        {
                            this_param.Add((Microsoft.Cci.ICustomAttribute)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 80909, 80926);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 80702, 80969);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 80702, 80969);
                    }
                }


                int
                f_10056_80091_80166(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ICustomAttribute>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attr)
                {
                    addIfNotNull(builder, attr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 80091, 80166);
                    return 0;
                }


                bool
                f_10056_80208_80241(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 80208, 80241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10056_80305_80379(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeNativeIntegerAttribute(symbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 80305, 80379);
                    return return_v;
                }


                int
                f_10056_80283_80380(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ICustomAttribute>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attr)
                {
                    addIfNotNull(builder, attr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 80283, 80380);
                    return 0;
                }


                bool
                f_10056_80422_80479(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 80422, 80479);
                    return return_v;
                }


                byte?
                f_10056_80613_80654(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 80613, 80654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10056_80543_80661(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, byte?
                nullableContextValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SynthesizeNullableAttributeIfNecessary(symbol, nullableContextValue, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 80543, 80661);
                    return return_v;
                }


                int
                f_10056_80521_80662(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ICustomAttribute>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attr)
                {
                    addIfNotNull(builder, attr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 80521, 80662);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomAttribute>
                f_10056_81052_81080(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ICustomAttribute>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 81052, 81080);
                    return return_v;
                }


                Microsoft.Cci.TypeReferenceWithAttributes
                f_10056_81007_81081(Microsoft.Cci.ITypeReference
                typeRef, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomAttribute>
                attributes)
                {
                    var return_v = new Microsoft.Cci.TypeReferenceWithAttributes(typeRef, attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 81007, 81081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 79541, 81093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 79541, 81093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsWellKnownTypeInAttribute(this TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10056, 81194, 81261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 81197, 81261);
                return f_10056_81197_81261(typeSymbol, "InAttribute"); DynAbs.Tracing.TraceSender.TraceExitMethod(10056, 81194, 81261);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 81194, 81261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 81194, 81261);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10056_81197_81261(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            typeSymbol, string
            name)
            {
                var return_v = typeSymbol.IsWellKnownInteropServicesTopLevelType(name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 81197, 81261);
                return return_v;
            }

        }

        internal static bool IsWellKnownTypeUnmanagedType(this TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10056, 81365, 81434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 81368, 81434);
                return f_10056_81368_81434(typeSymbol, "UnmanagedType"); DynAbs.Tracing.TraceSender.TraceExitMethod(10056, 81365, 81434);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 81365, 81434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 81365, 81434);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10056_81368_81434(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            typeSymbol, string
            name)
            {
                var return_v = typeSymbol.IsWellKnownInteropServicesTopLevelType(name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 81368, 81434);
                return return_v;
            }

        }

        internal static bool IsWellKnownTypeIsExternalInit(this TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10056, 81539, 81610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 81542, 81610);
                return f_10056_81542_81610(typeSymbol, "IsExternalInit"); DynAbs.Tracing.TraceSender.TraceExitMethod(10056, 81539, 81610);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 81539, 81610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 81539, 81610);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10056_81542_81610(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            typeSymbol, string
            name)
            {
                var return_v = typeSymbol.IsWellKnownCompilerServicesTopLevelType(name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 81542, 81610);
                return return_v;
            }

        }

        internal static bool IsWellKnownTypeOutAttribute(this TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10056, 81700, 81768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 81703, 81768);
                return f_10056_81703_81768(typeSymbol, "OutAttribute"); DynAbs.Tracing.TraceSender.TraceExitMethod(10056, 81700, 81768);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 81700, 81768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 81700, 81768);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10056_81703_81768(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            typeSymbol, string
            name)
            {
                var return_v = typeSymbol.IsWellKnownInteropServicesTopLevelType(name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 81703, 81768);
                return return_v;
            }

        }

        private static bool IsWellKnownInteropServicesTopLevelType(this TypeSymbol typeSymbol, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 81781, 82142);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 81905, 82033) || true) && (f_10056_81909_81924(typeSymbol) != name || (DynAbs.Tracing.TraceSender.Expression_False(10056, 81909, 81971) || f_10056_81936_81961(typeSymbol) is object))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 81905, 82033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 82005, 82018);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 81905, 82033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 82049, 82131);

                return f_10056_82056_82130(typeSymbol, "System", "Runtime", "InteropServices");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 81781, 82142);

                string
                f_10056_81909_81924(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 81909, 81924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10056_81936_81961(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 81936, 81961);
                    return return_v;
                }


                bool
                f_10056_82056_82130(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, string
                outerNS, string
                midNS, string
                innerNS)
                {
                    var return_v = typeSymbol.IsContainedInNamespace(outerNS, midNS, innerNS);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 82056, 82130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 81781, 82142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 81781, 82142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsWellKnownCompilerServicesTopLevelType(this TypeSymbol typeSymbol, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 82154, 82445);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 82279, 82368) || true) && (f_10056_82283_82298(typeSymbol) != name)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 82279, 82368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 82340, 82353);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 82279, 82368);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 82384, 82434);

                return f_10056_82391_82433(typeSymbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 82154, 82445);

                string
                f_10056_82283_82298(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 82283, 82298);
                    return return_v;
                }


                bool
                f_10056_82391_82433(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = typeSymbol.IsCompilerServicesTopLevelType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 82391, 82433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 82154, 82445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 82154, 82445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsCompilerServicesTopLevelType(this TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10056, 82550, 82665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 82553, 82665);
                return f_10056_82553_82578(typeSymbol) is null && (DynAbs.Tracing.TraceSender.Expression_True(10056, 82553, 82665) && f_10056_82590_82665(typeSymbol, "System", "Runtime", "CompilerServices")); DynAbs.Tracing.TraceSender.TraceExitMethod(10056, 82550, 82665);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 82550, 82665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 82550, 82665);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
            f_10056_82553_82578(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.ContainingType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 82553, 82578);
                return return_v;
            }


            bool
            f_10056_82590_82665(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            typeSymbol, string
            outerNS, string
            midNS, string
            innerNS)
            {
                var return_v = typeSymbol.IsContainedInNamespace(outerNS, midNS, innerNS);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 82590, 82665);
                return return_v;
            }

        }

        private static bool IsContainedInNamespace(this TypeSymbol typeSymbol, string outerNS, string midNS, string innerNS)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 82678, 83506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 82819, 82871);

                var
                innerNamespace = f_10056_82840_82870(typeSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 82885, 82982) || true) && (f_10056_82889_82909_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(innerNamespace, 10056, 82889, 82909)?.Name) != innerNS)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 82885, 82982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 82954, 82967);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 82885, 82982);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 82998, 83052);

                var
                midNamespace = f_10056_83017_83051(innerNamespace)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 83066, 83159) || true) && (f_10056_83070_83088_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(midNamespace, 10056, 83070, 83088)?.Name) != midNS)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 83066, 83159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 83131, 83144);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 83066, 83159);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 83175, 83229);

                var
                outerNamespace = f_10056_83196_83228(midNamespace)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 83243, 83340) || true) && (f_10056_83247_83267_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(outerNamespace, 10056, 83247, 83267)?.Name) != outerNS)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 83243, 83340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 83312, 83325);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 83243, 83340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 83356, 83413);

                var
                globalNamespace = f_10056_83378_83412(outerNamespace)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 83427, 83495);

                return globalNamespace != null && (DynAbs.Tracing.TraceSender.Expression_True(10056, 83434, 83494) && f_10056_83461_83494(globalNamespace));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 82678, 83506);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10056_82840_82870(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 82840, 82870);
                    return return_v;
                }


                string?
                f_10056_82889_82909_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 82889, 82909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10056_83017_83051(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 83017, 83051);
                    return return_v;
                }


                string?
                f_10056_83070_83088_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 83070, 83088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10056_83196_83228(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 83196, 83228);
                    return return_v;
                }


                string?
                f_10056_83247_83267_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 83247, 83267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10056_83378_83412(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 83378, 83412);
                    return return_v;
                }


                bool
                f_10056_83461_83494(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 83461, 83494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 82678, 83506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 82678, 83506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsBadAsyncReturn(this TypeSymbol returnType, CSharpCompilation declaringCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 83518, 84155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 83765, 84144);

                return !f_10056_83773_83797(returnType) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 83772, 83842) && !f_10056_83819_83842(returnType)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 83772, 83917) && !f_10056_83864_83917(returnType, declaringCompilation)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 83772, 83989) && !f_10056_83939_83989(returnType, declaringCompilation)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 83772, 84066) && !f_10056_84011_84066(returnType, declaringCompilation)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 83772, 84143) && !f_10056_84088_84143(returnType, declaringCompilation));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 83518, 84155);

                bool
                f_10056_83773_83797(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 83773, 83797);
                    return return_v;
                }


                bool
                f_10056_83819_83842(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 83819, 83842);
                    return return_v;
                }


                bool
                f_10056_83864_83917(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsNonGenericTaskType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 83864, 83917);
                    return return_v;
                }


                bool
                f_10056_83939_83989(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsGenericTaskType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 83939, 83989);
                    return return_v;
                }


                bool
                f_10056_84011_84066(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsIAsyncEnumerableType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 84011, 84066);
                    return return_v;
                }


                bool
                f_10056_84088_84143(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsIAsyncEnumeratorType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 84088, 84143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 83518, 84155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 83518, 84155);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int TypeToIndex(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10056, 84167, 87026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84245, 87015);

                switch (f_10056_84253_84278(type))
                {

                    case SpecialType.System_Object:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84344, 84353);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84403, 84412);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84463, 84472);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84520, 84529);

                        return 3;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84578, 84587);

                        return 4;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84636, 84645);

                        return 5;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84694, 84703);

                        return 6;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84752, 84761);

                        return 7;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84809, 84818);

                        return 8;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84868, 84877);

                        return 9;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84927, 84937);

                        return 10;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 84987, 84997);

                        return 11;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85046, 85075) || true) && (f_10056_85051_85075(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 85046, 85075) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85077, 85087);

                        return 12;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85137, 85166) || true) && (f_10056_85142_85166(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 85137, 85166) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85168, 85178);

                        return 13;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85228, 85238);

                        return 14;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85288, 85298);

                        return 15;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.System_Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85349, 85359);

                        return 16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    case SpecialType.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85423, 86887) || true) && ((object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10056, 85427, 85472) && f_10056_85451_85472(type)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85423, 86887);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85522, 85583);

                            TypeSymbol
                            underlyingType = f_10056_85550_85582(type)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85611, 86864);

                            switch (f_10056_85619_85654(underlyingType))
                            {

                                case SpecialType.System_Boolean:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85745, 85755);

                                    return 17;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_Char:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85815, 85825);

                                    return 18;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_SByte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85886, 85896);

                                    return 19;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_Int16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 85957, 85967);

                                    return 20;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86028, 86038);

                                    return 21;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86099, 86109);

                                    return 22;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86169, 86179);

                                    return 23;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86241, 86251);

                                    return 24;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86313, 86323);

                                    return 25;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86385, 86395);

                                    return 26;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86456, 86495) || true) && (f_10056_86461_86495(underlyingType)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 86456, 86495) || true)
                            :
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86497, 86507);

                                    return 27;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86569, 86608) || true) && (f_10056_86574_86608(underlyingType)) && (DynAbs.Tracing.TraceSender.Expression_True(10056, 86569, 86608) || true)
                            :
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86610, 86620);

                                    return 28;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_Single:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86682, 86692);

                                    return 29;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86754, 86764);

                                    return 30;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 85611, 86864);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86827, 86837);

                                    return 31;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85611, 86864);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 85423, 86887);
                        }

                        goto default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10056, 84245, 87015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 86990, 87000);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10056, 84245, 87015);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10056, 84167, 87026);

                Microsoft.CodeAnalysis.SpecialType
                f_10056_84253_84278(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 84253, 84278);
                    return return_v;
                }


                bool
                f_10056_85051_85075(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 85051, 85075);
                    return return_v;
                }


                bool
                f_10056_85142_85166(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 85142, 85166);
                    return return_v;
                }


                bool
                f_10056_85451_85472(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 85451, 85472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10056_85550_85582(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 85550, 85582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10056_85619_85654(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10056, 85619, 85654);
                    return return_v;
                }


                bool
                f_10056_86461_86495(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 86461, 86495);
                    return return_v;
                }


                bool
                f_10056_86574_86608(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10056, 86574, 86608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10056, 84167, 87026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 84167, 87026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeSymbolExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10056, 490, 87033);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 16407, 16495);
            s_expressionsNamespaceName = new string[] { "Expressions", "Linq", MetadataHelpers.SystemString, "" }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 43283, 43497);
            s_containsTypeParameterPredicate = (type, parameter, unused) => type.TypeKind == TypeKind.TypeParameter && (parameter is null || TypeSymbol.Equals(type, parameter, TypeCompareKind.ConsiderEverything2)); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 43920, 44124);
            s_isTypeParameterWithSpecificContainerPredicate = (type, parameterContainer, unused) => type.TypeKind == TypeKind.TypeParameter && (object)type.ContainingSymbol == (object)parameterContainer; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 44485, 44653);
            s_containsTypeParametersPredicate = (type, parameters, unused) => type.TypeKind == TypeKind.TypeParameter && parameters.Contains((TypeParameterSymbol)type); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10056, 45082, 45172);
            s_containsDynamicPredicate = (type, unused1, unused2) => type.TypeKind == TypeKind.Dynamic; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10056, 490, 87033);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10056, 490, 87033);
        }

    }
}
