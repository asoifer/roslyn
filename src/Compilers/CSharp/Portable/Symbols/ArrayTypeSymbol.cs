// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class ArrayTypeSymbol : TypeSymbol
    {
        private readonly TypeWithAnnotations _elementTypeWithAnnotations;

        private readonly NamedTypeSymbol _baseType;

        private ArrayTypeSymbol(
                    TypeWithAnnotations elementTypeWithAnnotations,
                    NamedTypeSymbol array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10089, 838, 1205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 3504, 3516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 816, 825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 984, 1033);

                f_10089_984_1032(elementTypeWithAnnotations.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 1047, 1089);

                f_10089_1047_1088((object)array != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 1105, 1162);

                _elementTypeWithAnnotations = elementTypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 1176, 1194);

                _baseType = array;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10089, 838, 1205);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 838, 1205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 838, 1205);
            }
        }

        internal static ArrayTypeSymbol CreateCSharpArray(
                    AssemblySymbol declaringAssembly,
                    TypeWithAnnotations elementTypeWithAnnotations,
                    int rank = 1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10089, 1217, 1718);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 1427, 1557) || true) && (rank == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 1427, 1557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 1474, 1542);

                    return f_10089_1481_1541(declaringAssembly, elementTypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 1427, 1557);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 1573, 1707);

                return f_10089_1580_1706(declaringAssembly, elementTypeWithAnnotations, rank, default(ImmutableArray<int>), default(ImmutableArray<int>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10089, 1217, 1718);

                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10089_1481_1541(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementType)
                {
                    var return_v = CreateSZArray(declaringAssembly, elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 1481, 1541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10089_1580_1706(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementType, int
                rank, System.Collections.Immutable.ImmutableArray<int>
                sizes, System.Collections.Immutable.ImmutableArray<int>
                lowerBounds)
                {
                    var return_v = CreateMDArray(declaringAssembly, elementType, rank, sizes, lowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 1580, 1706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 1217, 1718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 1217, 1718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ArrayTypeSymbol CreateMDArray(
                    TypeWithAnnotations elementTypeWithAnnotations,
                    int rank,
                    ImmutableArray<int> sizes,
                    ImmutableArray<int> lowerBounds,
                    NamedTypeSymbol array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10089, 1730, 2405);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 2105, 2280) || true) && (sizes.IsDefaultOrEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10089, 2109, 2156) && lowerBounds.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 2105, 2280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 2190, 2265);

                    return f_10089_2197_2264(elementTypeWithAnnotations, rank, array);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 2105, 2280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 2296, 2394);

                return f_10089_2303_2393(elementTypeWithAnnotations, rank, sizes, lowerBounds, array);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10089, 1730, 2405);

                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.MDArrayNoSizesOrBounds
                f_10089_2197_2264(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, int
                rank, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.MDArrayNoSizesOrBounds(elementTypeWithAnnotations, rank, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 2197, 2264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.MDArrayWithSizesAndBounds
                f_10089_2303_2393(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, int
                rank, System.Collections.Immutable.ImmutableArray<int>
                sizes, System.Collections.Immutable.ImmutableArray<int>
                lowerBounds, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.MDArrayWithSizesAndBounds(elementTypeWithAnnotations, rank, sizes, lowerBounds, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 2303, 2393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 1730, 2405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 1730, 2405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ArrayTypeSymbol CreateMDArray(
                    AssemblySymbol declaringAssembly,
                    TypeWithAnnotations elementType,
                    int rank,
                    ImmutableArray<int> sizes,
                    ImmutableArray<int> lowerBounds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10089, 2417, 2821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 2690, 2810);

                return f_10089_2697_2809(elementType, rank, sizes, lowerBounds, f_10089_2750_2808(declaringAssembly, SpecialType.System_Array));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10089, 2417, 2821);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10089_2750_2808(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 2750, 2808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10089_2697_2809(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, int
                rank, System.Collections.Immutable.ImmutableArray<int>
                sizes, System.Collections.Immutable.ImmutableArray<int>
                lowerBounds, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                array)
                {
                    var return_v = CreateMDArray(elementTypeWithAnnotations, rank, sizes, lowerBounds, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 2697, 2809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 2417, 2821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 2417, 2821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ArrayTypeSymbol CreateSZArray(
                    TypeWithAnnotations elementTypeWithAnnotations,
                    NamedTypeSymbol array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10089, 2833, 3142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 3001, 3131);

                return f_10089_3008_3130(elementTypeWithAnnotations, array, f_10089_3055_3129(elementTypeWithAnnotations, f_10089_3104_3128(array)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10089, 2833, 3142);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10089_3104_3128(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 3104, 3128);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10089_3055_3129(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly)
                {
                    var return_v = GetSZArrayInterfaces(elementTypeWithAnnotations, declaringAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 3055, 3129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.SZArray
                f_10089_3008_3130(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                array, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                constructedInterfaces)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.SZArray(elementTypeWithAnnotations, array, constructedInterfaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 3008, 3130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 2833, 3142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 2833, 3142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ArrayTypeSymbol CreateSZArray(
                    TypeWithAnnotations elementTypeWithAnnotations,
                    NamedTypeSymbol array,
                    ImmutableArray<NamedTypeSymbol> constructedInterfaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10089, 3154, 3478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 3390, 3467);

                return f_10089_3397_3466(elementTypeWithAnnotations, array, constructedInterfaces);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10089, 3154, 3478);

                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.SZArray
                f_10089_3397_3466(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                array, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                constructedInterfaces)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.SZArray(elementTypeWithAnnotations, array, constructedInterfaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 3397, 3466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 3154, 3478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 3154, 3478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ArrayTypeSymbol CreateSZArray(
                    AssemblySymbol declaringAssembly,
                    TypeWithAnnotations elementType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10089, 3490, 3813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 3654, 3802);

                return f_10089_3661_3801(elementType, f_10089_3688_3746(declaringAssembly, SpecialType.System_Array), f_10089_3748_3800(elementType, declaringAssembly));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10089, 3490, 3813);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10089_3688_3746(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 3688, 3746);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10089_3748_3800(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly)
                {
                    var return_v = GetSZArrayInterfaces(elementTypeWithAnnotations, declaringAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 3748, 3800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10089_3661_3801(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                array, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                constructedInterfaces)
                {
                    var return_v = CreateSZArray(elementTypeWithAnnotations, array, constructedInterfaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 3661, 3801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 3490, 3813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 3490, 3813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ArrayTypeSymbol WithElementType(TypeWithAnnotations elementTypeWithAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 3825, 4077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 3938, 4066);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10089, 3945, 4008) || ((f_10089_3945_3971().IsSameAs(elementTypeWithAnnotations) && DynAbs.Tracing.TraceSender.Conditional_F2(10089, 4011, 4015)) || DynAbs.Tracing.TraceSender.Conditional_F3(10089, 4018, 4065))) ? this : f_10089_4018_4065(this, elementTypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 3825, 4077);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10089_3945_3971()
                {
                    var return_v = ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 3945, 3971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10089_4018_4065(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations)
                {
                    var return_v = this_param.WithElementTypeCore(elementTypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 4018, 4065);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 3825, 4077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 3825, 4077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ArrayTypeSymbol WithElementTypeCore(TypeWithAnnotations elementTypeWithAnnotations);

        private static ImmutableArray<NamedTypeSymbol> GetSZArrayInterfaces(
                    TypeWithAnnotations elementTypeWithAnnotations,
                    AssemblySymbol declaringAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10089, 4204, 5377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 4405, 4477);

                var
                constructedInterfaces = f_10089_4433_4476()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 4640, 4736);

                var
                iListOfT = f_10089_4655_4735(declaringAssembly, SpecialType.System_Collections_Generic_IList_T)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 4750, 4945) || true) && (!f_10089_4755_4777(iListOfT))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 4750, 4945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 4811, 4930);

                    f_10089_4811_4929(constructedInterfaces, f_10089_4837_4928(iListOfT, f_10089_4878_4927(elementTypeWithAnnotations)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 4750, 4945);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 4961, 5073);

                var
                iReadOnlyListOfT = f_10089_4984_5072(declaringAssembly, SpecialType.System_Collections_Generic_IReadOnlyList_T)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 5089, 5300) || true) && (!f_10089_5094_5124(iReadOnlyListOfT))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 5089, 5300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 5158, 5285);

                    f_10089_5158_5284(constructedInterfaces, f_10089_5184_5283(iReadOnlyListOfT, f_10089_5233_5282(elementTypeWithAnnotations)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 5089, 5300);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 5316, 5366);

                return f_10089_5323_5365(constructedInterfaces);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10089, 4204, 5377);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10089_4433_4476()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 4433, 4476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10089_4655_4735(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 4655, 4735);
                    return return_v;
                }


                bool
                f_10089_4755_4777(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 4755, 4777);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10089_4878_4927(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 4878, 4927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedNamedTypeSymbol
                f_10089_4837_4928(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                constructedFrom, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedNamedTypeSymbol(constructedFrom, typeArgumentsWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 4837, 4928);
                    return return_v;
                }


                int
                f_10089_4811_4929(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedNamedTypeSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 4811, 4929);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10089_4984_5072(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 4984, 5072);
                    return return_v;
                }


                bool
                f_10089_5094_5124(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 5094, 5124);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10089_5233_5282(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 5233, 5282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedNamedTypeSymbol
                f_10089_5184_5283(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                constructedFrom, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedNamedTypeSymbol(constructedFrom, typeArgumentsWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 5184, 5283);
                    return return_v;
                }


                int
                f_10089_5158_5284(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedNamedTypeSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 5158, 5284);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10089_5323_5365(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 5323, 5365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 4204, 5377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 4204, 5377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract int Rank { get; }

        public abstract bool IsSZArray { get; }

        internal bool HasSameShapeAs(ArrayTypeSymbol other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 5821, 5966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 5897, 5955);

                return f_10089_5904_5908() == f_10089_5912_5922(other) && (DynAbs.Tracing.TraceSender.Expression_True(10089, 5904, 5954) && f_10089_5926_5935() == f_10089_5939_5954(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 5821, 5966);

                int
                f_10089_5904_5908()
                {
                    var return_v = Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 5904, 5908);
                    return return_v;
                }


                int
                f_10089_5912_5922(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 5912, 5922);
                    return return_v;
                }


                bool
                f_10089_5926_5935()
                {
                    var return_v = IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 5926, 5935);
                    return return_v;
                }


                bool
                f_10089_5939_5954(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 5939, 5954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 5821, 5966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 5821, 5966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual ImmutableArray<int> Sizes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 6392, 6476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 6428, 6461);

                    return ImmutableArray<int>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 6392, 6476);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 6327, 6487);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 6327, 6487);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual ImmutableArray<int> LowerBounds
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 6930, 7017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 6966, 7002);

                    return default(ImmutableArray<int>);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 6930, 7017);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 6859, 7028);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 6859, 7028);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasSameSizesAndLowerBoundsAs(ArrayTypeSymbol other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 7166, 7737);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 7256, 7697) || true) && (this.Sizes.SequenceEqual(f_10089_7285_7296(other)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 7256, 7697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 7331, 7370);

                    var
                    thisLowerBounds = f_10089_7353_7369(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 7390, 7515) || true) && (thisLowerBounds.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 7390, 7515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 7461, 7496);

                        return other.LowerBounds.IsDefault;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 7390, 7515);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 7535, 7576);

                    var
                    otherLowerBounds = f_10089_7558_7575(other)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 7596, 7682);

                    return f_10089_7603_7630_M(!otherLowerBounds.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10089, 7603, 7681) && thisLowerBounds.SequenceEqual(otherLowerBounds));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 7256, 7697);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 7713, 7726);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 7166, 7737);

                System.Collections.Immutable.ImmutableArray<int>
                f_10089_7285_7296(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Sizes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 7285, 7296);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10089_7353_7369(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.LowerBounds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 7353, 7369);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10089_7558_7575(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.LowerBounds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 7558, 7575);
                    return return_v;
                }


                bool
                f_10089_7603_7630_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 7603, 7630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 7166, 7737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 7166, 7737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract bool HasDefaultSizesAndLowerBounds { get; }

        public TypeWithAnnotations ElementTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 8281, 8367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 8317, 8352);

                    return _elementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 8281, 8367);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 8203, 8378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 8203, 8378);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeSymbol ElementType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 8555, 8646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 8591, 8631);

                    return _elementTypeWithAnnotations.Type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 8555, 8646);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 8501, 8657);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 8501, 8657);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 8732, 8744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 8735, 8744);
                    return _baseType; DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 8732, 8744);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 8732, 8744);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 8732, 8744);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 8818, 8881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 8854, 8866);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 8818, 8881);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 8757, 8892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 8757, 8892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 8961, 9025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 8997, 9010);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 8961, 9025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 8904, 9036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 8904, 9036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ManagedKind GetManagedKind(ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 9149, 9171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 9152, 9171);
                return ManagedKind.Managed; DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 9149, 9171);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 9149, 9171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 9149, 9171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsRefLikeType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 9250, 9314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 9286, 9299);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 9250, 9314);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 9184, 9325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 9184, 9325);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 9400, 9464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 9436, 9449);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 9400, 9464);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 9337, 9475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 9337, 9475);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 9581, 9601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 9587, 9599);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 9581, 9601);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 9487, 9612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 9487, 9612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 9624, 9747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 9700, 9736);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 9624, 9747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 9624, 9747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 9624, 9747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 9759, 9893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 9846, 9882);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 9759, 9893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 9759, 9893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 9759, 9893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 9905, 10050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 9994, 10039);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 9905, 10050);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 9905, 10050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 9905, 10050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 10062, 10218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 10162, 10207);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 10062, 10218);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 10062, 10218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 10062, 10218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 10230, 10397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 10341, 10386);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 10230, 10397);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 10230, 10397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 10230, 10397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 10465, 10544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 10501, 10529);

                    return SymbolKind.ArrayType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 10465, 10544);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 10409, 10555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 10409, 10555);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 10625, 10698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 10661, 10683);

                    return TypeKind.Array;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 10625, 10698);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 10567, 10709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 10567, 10709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 10786, 10849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 10822, 10834);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 10786, 10849);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 10721, 10860);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 10721, 10860);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 10947, 11036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 10983, 11021);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 10947, 11036);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 10872, 11047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 10872, 11047);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 11157, 11253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 11193, 11238);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 11157, 11253);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 11059, 11264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 11059, 11264);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 11276, 11479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 11422, 11468);

                return f_10089_11429_11467<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 11276, 11479);

                TResult
                f_10089_11429_11467<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitArrayType(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 11429, 11467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 11276, 11479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 11276, 11479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 11491, 11612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 11572, 11601);

                f_10089_11572_11600(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 11491, 11612);

                int
                f_10089_11572_11600(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                symbol)
                {
                    this_param.VisitArrayType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 11572, 11600);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 11491, 11612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 11491, 11612);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 11624, 11773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 11726, 11762);

                return f_10089_11733_11761<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 11624, 11773);

                TResult
                f_10089_11733_11761<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                symbol)
                {
                    var return_v = this_param.VisitArrayType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 11733, 11761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 11624, 11773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 11624, 11773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool Equals(TypeSymbol? t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 11785, 11948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 11883, 11937);

                return f_10089_11890_11936(this, t2 as ArrayTypeSymbol, comparison);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 11785, 11948);

                bool
                f_10089_11890_11936(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                other, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol?)other, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 11890, 11936);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 11785, 11948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 11785, 11948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool Equals(ArrayTypeSymbol? other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 11960, 12682);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 12056, 12149) || true) && (f_10089_12060_12088(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 12056, 12149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 12122, 12134);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 12056, 12149);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 12165, 12385) || true) && ((object?)other == null || (DynAbs.Tracing.TraceSender.Expression_False(10089, 12169, 12222) || !f_10089_12196_12222(other, this)) || (DynAbs.Tracing.TraceSender.Expression_False(10089, 12169, 12323) || !other.ElementTypeWithAnnotations.Equals(f_10089_12284_12310(), comparison)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 12165, 12385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 12357, 12370);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 12165, 12385);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 12448, 12643) || true) && ((comparison & TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10089, 12452, 12581) && !f_10089_12541_12581(this, other)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 12448, 12643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 12615, 12628);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 12448, 12643);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 12659, 12671);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 11960, 12682);

                bool
                f_10089_12060_12088(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 12060, 12088);
                    return return_v;
                }


                bool
                f_10089_12196_12222(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                other)
                {
                    var return_v = this_param.HasSameShapeAs(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 12196, 12222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10089_12284_12310()
                {
                    var return_v = ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 12284, 12310);
                    return return_v;
                }


                bool
                f_10089_12541_12581(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                other)
                {
                    var return_v = this_param.HasSameSizesAndLowerBoundsAs(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 12541, 12581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 11960, 12682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 11960, 12682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 12694, 13358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 13006, 13019);

                int
                hash = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 13033, 13059);

                TypeSymbol
                current = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 13073, 13296) || true) && (f_10089_13080_13096(current) == TypeKind.Array)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 13073, 13296);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 13148, 13183);

                        var
                        cur = (ArrayTypeSymbol)current
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 13201, 13237);

                        hash = f_10089_13208_13236(f_10089_13221_13229(cur), hash);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 13255, 13281);

                        current = f_10089_13265_13280(cur);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 13073, 13296);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10089, 13073, 13296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10089, 13073, 13296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 13312, 13347);

                return f_10089_13319_13346(current, hash);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 12694, 13358);

                Microsoft.CodeAnalysis.TypeKind
                f_10089_13080_13096(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 13080, 13096);
                    return return_v;
                }


                int
                f_10089_13221_13229(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 13221, 13229);
                    return return_v;
                }


                int
                f_10089_13208_13236(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 13208, 13236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10089_13265_13280(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 13265, 13280);
                    return return_v;
                }


                int
                f_10089_13319_13346(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 13319, 13346);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 12694, 13358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 12694, 13358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddNullableTransforms(ArrayBuilder<byte> transforms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 13370, 13542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 13470, 13531);

                f_10089_13470_13496().AddNullableTransforms(transforms);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 13370, 13542);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10089_13470_13496()
                {
                    var return_v = ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 13470, 13496);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 13370, 13542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 13370, 13542);
            }
        }

        internal override bool ApplyNullableTransforms(byte defaultTransformFlag, ImmutableArray<byte> transforms, ref int position, out TypeSymbol result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 13554, 14154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 13726, 13790);

                TypeWithAnnotations
                oldElementType = f_10089_13763_13789()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 13804, 13839);

                TypeWithAnnotations
                newElementType
                = default(TypeWithAnnotations);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 13855, 14060) || true) && (!oldElementType.ApplyNullableTransforms(defaultTransformFlag, transforms, ref position, out newElementType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 13855, 14060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 14000, 14014);

                    result = this;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 14032, 14045);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 13855, 14060);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 14076, 14117);

                result = f_10089_14085_14116(this, newElementType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 14131, 14143);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 13554, 14154);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10089_13763_13789()
                {
                    var return_v = ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 13763, 13789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10089_14085_14116(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations)
                {
                    var return_v = this_param.WithElementType(elementTypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 14085, 14116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 13554, 14154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 13554, 14154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol SetNullabilityForReferenceTypes(Func<TypeWithAnnotations, TypeWithAnnotations> transform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 14166, 14382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 14309, 14371);

                return f_10089_14316_14370(this, f_10089_14332_14369(transform, f_10089_14342_14368()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 14166, 14382);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10089_14342_14368()
                {
                    var return_v = ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 14342, 14368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10089_14332_14369(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 14332, 14369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10089_14316_14370(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations)
                {
                    var return_v = this_param.WithElementType(elementTypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 14316, 14370);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 14166, 14382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 14166, 14382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol MergeEquivalentTypes(TypeSymbol other, VarianceKind variance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 14394, 14865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 14509, 14645);

                f_10089_14509_14644(f_10089_14522_14643(this, other, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 14659, 14804);

                TypeWithAnnotations
                elementType = f_10089_14693_14719().MergeEquivalentTypes(f_10089_14741_14792(((ArrayTypeSymbol)other)), variance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 14818, 14854);

                return f_10089_14825_14853(this, elementType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 14394, 14865);

                bool
                f_10089_14522_14643(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals(t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 14522, 14643);
                    return return_v;
                }


                int
                f_10089_14509_14644(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 14509, 14644);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10089_14693_14719()
                {
                    var return_v = ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 14693, 14719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10089_14741_14792(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 14741, 14792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10089_14825_14853(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations)
                {
                    var return_v = this_param.WithElementType(elementTypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 14825, 14853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 14394, 14865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 14394, 14865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 14953, 15039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 14989, 15024);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 14953, 15039);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 14877, 15050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 14877, 15050);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 15116, 15180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 15152, 15165);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 15116, 15180);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 15062, 15191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 15062, 15191);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 15259, 15323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 15295, 15308);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 15259, 15323);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 15203, 15334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 15203, 15334);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 15400, 15464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 15436, 15449);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 15400, 15464);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 15346, 15475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 15346, 15475);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo? GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 15527, 15946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 15608, 15638);

                DiagnosticInfo?
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 15728, 15905) || true) && (f_10089_15732_15842(this, ref result, f_10089_15776_15807(this), AllowedRequiredModifierType.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10089, 15728, 15905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 15876, 15890);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10089, 15728, 15905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 15921, 15935);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 15527, 15946);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10089_15776_15807(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 15776, 15807);
                    return return_v;
                }


                bool
                f_10089_15732_15842(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromType(ref result, type, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 15732, 15842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 15527, 15946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 15527, 15946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 15958, 16531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 16125, 16520);

                return _elementTypeWithAnnotations.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10089, 16132, 16379) || ((object)_baseType != null && (DynAbs.Tracing.TraceSender.Expression_True(10089, 16262, 16378) && f_10089_16291_16378(_baseType, ref result, owner, ref checkedTypes)))) || (DynAbs.Tracing.TraceSender.Expression_False(10089, 16132, 16519) || f_10089_16403_16519(ref result, f_10089_16456_16493(this), owner, ref checkedTypes));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 15958, 16531);

                bool
                f_10089_16291_16378(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = this_param.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 16291, 16378);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10089_16456_16493(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 16456, 16493);
                    return return_v;
                }


                bool
                f_10089_16403_16519(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                types, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, types, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 16403, 16519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 15958, 16531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 15958, 16531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 16565, 16722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 16639, 16711);

                return f_10089_16646_16710(this, f_10089_16684_16709());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 16565, 16722);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10089_16684_16709()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 16684, 16709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ArrayTypeSymbol
                f_10089_16646_16710(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ArrayTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 16646, 16710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 16565, 16722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 16565, 16722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override ITypeSymbol CreateITypeSymbol(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 16734, 17018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 16866, 16928);

                f_10089_16866_16927(nullableAnnotation != f_10089_16901_16926());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 16942, 17007);

                return f_10089_16949_17006(this, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 16734, 17018);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10089_16901_16926()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 16901, 16926);
                    return return_v;
                }


                int
                f_10089_16866_16927(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 16866, 16927);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ArrayTypeSymbol
                f_10089_16949_17006(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ArrayTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 16949, 17006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 16734, 17018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 16734, 17018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 17062, 17070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 17065, 17070);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 17062, 17070);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 17062, 17070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 17062, 17070);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        private sealed class SZArray : ArrayTypeSymbol
        {
            private readonly ImmutableArray<NamedTypeSymbol> _interfaces;

            internal SZArray(
                            TypeWithAnnotations elementTypeWithAnnotations,
                            NamedTypeSymbol array,
                            ImmutableArray<NamedTypeSymbol> constructedInterfaces)
            : base(f_10089_17565_17591_C(elementTypeWithAnnotations), array)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10089, 17346, 17749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 17632, 17680);

                    f_10089_17632_17679(constructedInterfaces.Length <= 2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 17698, 17734);

                    _interfaces = constructedInterfaces;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10089, 17346, 17749);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 17346, 17749);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 17346, 17749);
                }
            }

            protected override ArrayTypeSymbol WithElementTypeCore(TypeWithAnnotations newElementType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 17765, 18113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 17888, 18000);

                    var
                    newInterfaces = _interfaces.SelectAsArray((i, t) => i.OriginalDefinition.Construct(t), newElementType.Type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 18018, 18098);

                    return f_10089_18025_18097(newElementType, f_10089_18053_18081(), newInterfaces);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 17765, 18113);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10089_18053_18081()
                    {
                        var return_v = BaseTypeNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 18053, 18081);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.SZArray
                    f_10089_18025_18097(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    elementTypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    array, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    constructedInterfaces)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.SZArray(elementTypeWithAnnotations, array, constructedInterfaces);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 18025, 18097);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 17765, 18113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 17765, 18113);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int Rank
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 18186, 18258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 18230, 18239);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 18186, 18258);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 18129, 18273);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 18129, 18273);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsSZArray
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 18810, 18885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 18854, 18866);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 18810, 18885);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 18747, 18900);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 18747, 18900);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol>? basesBeingResolved = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 18916, 19112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 19078, 19097);

                    return _interfaces;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 18916, 19112);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 18916, 19112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 18916, 19112);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool HasDefaultSizesAndLowerBounds
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 19213, 19288);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 19257, 19269);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 19213, 19288);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 19128, 19303);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 19128, 19303);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static SZArray()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10089, 17198, 19314);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10089, 17198, 19314);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 17198, 19314);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10089, 17198, 19314);

            int
            f_10089_17632_17679(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 17632, 17679);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10089_17565_17591_C(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10089, 17346, 17749);
                return return_v;
            }

        }
        private abstract class MDArray : ArrayTypeSymbol
        {
            private readonly int _rank;

            internal MDArray(
                            TypeWithAnnotations elementTypeWithAnnotations,
                            int rank,
                            NamedTypeSymbol array)
            : base(f_10089_19742_19768_C(elementTypeWithAnnotations), array)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10089, 19568, 19879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 19546, 19551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 19809, 19833);

                    f_10089_19809_19832(rank >= 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 19851, 19864);

                    _rank = rank;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10089, 19568, 19879);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 19568, 19879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 19568, 19879);
                }
            }

            public sealed override int Rank
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 19959, 20035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 20003, 20016);

                        return _rank;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 19959, 20035);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 19895, 20050);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 19895, 20050);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool IsSZArray
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 20136, 20212);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 20180, 20193);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 20136, 20212);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 20066, 20227);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 20066, 20227);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol>? basesBeingResolved = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 20243, 20472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 20412, 20457);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 20243, 20472);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 20243, 20472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 20243, 20472);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static MDArray()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10089, 19452, 20483);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10089, 19452, 20483);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 19452, 20483);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10089, 19452, 20483);

            int
            f_10089_19809_19832(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 19809, 19832);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10089_19742_19768_C(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10089, 19568, 19879);
                return return_v;
            }

        }
        private sealed class MDArrayNoSizesOrBounds : MDArray
        {
            internal MDArrayNoSizesOrBounds(
                            TypeWithAnnotations elementTypeWithAnnotations,
                            int rank,
                            NamedTypeSymbol array)
            : base(f_10089_20762_20788_C(elementTypeWithAnnotations), rank, array)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10089, 20573, 20832);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10089, 20573, 20832);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 20573, 20832);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 20573, 20832);
                }
            }

            protected override ArrayTypeSymbol WithElementTypeCore(TypeWithAnnotations elementTypeWithAnnotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 20848, 21096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 20983, 21081);

                    return f_10089_20990_21080(elementTypeWithAnnotations, f_10089_21045_21049(), f_10089_21051_21079());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 20848, 21096);

                    int
                    f_10089_21045_21049()
                    {
                        var return_v = Rank;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 21045, 21049);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10089_21051_21079()
                    {
                        var return_v = BaseTypeNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 21051, 21079);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.MDArrayNoSizesOrBounds
                    f_10089_20990_21080(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    elementTypeWithAnnotations, int
                    rank, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    array)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.MDArrayNoSizesOrBounds(elementTypeWithAnnotations, rank, array);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 20990, 21080);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 20848, 21096);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 20848, 21096);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool HasDefaultSizesAndLowerBounds
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 21197, 21272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 21241, 21253);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 21197, 21272);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 21112, 21287);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 21112, 21287);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static MDArrayNoSizesOrBounds()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10089, 20495, 21298);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10089, 20495, 21298);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 20495, 21298);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10089, 20495, 21298);

            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10089_20762_20788_C(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10089, 20573, 20832);
                return return_v;
            }

        }
        private sealed class MDArrayWithSizesAndBounds : MDArray
        {
            private readonly ImmutableArray<int> _sizes;

            private readonly ImmutableArray<int> _lowerBounds;

            internal MDArrayWithSizesAndBounds(
                            TypeWithAnnotations elementTypeWithAnnotations,
                            int rank,
                            ImmutableArray<int> sizes,
                            ImmutableArray<int> lowerBounds,
                            NamedTypeSymbol array)
            : base(f_10089_21801_21827_C(elementTypeWithAnnotations), rank, array)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10089, 21515, 22197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 21874, 21938);

                    f_10089_21874_21937(f_10089_21887_21910_M(!sizes.IsDefaultOrEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(10089, 21887, 21936) || f_10089_21914_21936_M(!lowerBounds.IsDefault)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 21956, 22090);

                    f_10089_21956_22089(lowerBounds.IsDefaultOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10089, 21969, 22088) || (f_10089_22002_22022_M(!lowerBounds.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10089, 22002, 22087) && (lowerBounds.Length != rank || (DynAbs.Tracing.TraceSender.Expression_False(10089, 22027, 22086) || !lowerBounds.All(b => b == 0)))))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 22108, 22137);

                    _sizes = sizes.NullToEmpty();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 22155, 22182);

                    _lowerBounds = lowerBounds;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10089, 21515, 22197);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 21515, 22197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 21515, 22197);
                }
            }

            protected override ArrayTypeSymbol WithElementTypeCore(TypeWithAnnotations elementTypeWithAnnotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 22213, 22486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 22348, 22471);

                    return f_10089_22355_22470(elementTypeWithAnnotations, f_10089_22413_22417(), _sizes, _lowerBounds, f_10089_22441_22469());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 22213, 22486);

                    int
                    f_10089_22413_22417()
                    {
                        var return_v = Rank;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 22413, 22417);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10089_22441_22469()
                    {
                        var return_v = BaseTypeNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 22441, 22469);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.MDArrayWithSizesAndBounds
                    f_10089_22355_22470(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    elementTypeWithAnnotations, int
                    rank, System.Collections.Immutable.ImmutableArray<int>
                    sizes, System.Collections.Immutable.ImmutableArray<int>
                    lowerBounds, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    array)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol.MDArrayWithSizesAndBounds(elementTypeWithAnnotations, rank, sizes, lowerBounds, array);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 22355, 22470);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 22213, 22486);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 22213, 22486);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<int> Sizes
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 22576, 22653);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 22620, 22634);

                        return _sizes;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 22576, 22653);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 22502, 22668);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 22502, 22668);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<int> LowerBounds
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 22764, 22847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 22808, 22828);

                        return _lowerBounds;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 22764, 22847);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 22684, 22862);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 22684, 22862);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool HasDefaultSizesAndLowerBounds
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10089, 22963, 23039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10089, 23007, 23020);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10089, 22963, 23039);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10089, 22878, 23054);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 22878, 23054);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static MDArrayWithSizesAndBounds()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10089, 21310, 23065);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10089, 21310, 23065);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10089, 21310, 23065);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10089, 21310, 23065);

            bool
            f_10089_21887_21910_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 21887, 21910);
                return return_v;
            }


            bool
            f_10089_21914_21936_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 21914, 21936);
                return return_v;
            }


            int
            f_10089_21874_21937(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 21874, 21937);
                return 0;
            }


            bool
            f_10089_22002_22022_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10089, 22002, 22022);
                return return_v;
            }


            int
            f_10089_21956_22089(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 21956, 22089);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10089_21801_21827_C(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10089, 21515, 22197);
                return return_v;
            }

        }

        int
        f_10089_984_1032(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 984, 1032);
            return 0;
        }


        int
        f_10089_1047_1088(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10089, 1047, 1088);
            return 0;
        }

    }
}
