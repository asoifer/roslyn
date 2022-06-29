// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal static class ReferenceDependencyWalker
    {
        public static void VisitReference(Cci.IReference reference, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(80, 884, 1671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 989, 1041);

                var
                typeReference = reference as Cci.ITypeReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1055, 1197) || true) && (typeReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 1055, 1197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1114, 1157);

                    f_80_1114_1156(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1175, 1182);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 1055, 1197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1213, 1269);

                var
                methodReference = reference as Cci.IMethodReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1283, 1431) || true) && (methodReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 1283, 1431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1344, 1391);

                    f_80_1344_1390(methodReference, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1409, 1416);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 1283, 1431);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1447, 1501);

                var
                fieldReference = reference as Cci.IFieldReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1515, 1660) || true) && (fieldReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 1515, 1660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1575, 1620);

                    f_80_1575_1619(fieldReference, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1638, 1645);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 1515, 1660);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(80, 884, 1671);

                int
                f_80_1114_1156(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 1114, 1156);
                    return 0;
                }


                int
                f_80_1344_1390(Microsoft.Cci.IMethodReference
                methodReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitMethodReference(methodReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 1344, 1390);
                    return 0;
                }


                int
                f_80_1575_1619(Microsoft.Cci.IFieldReference
                fieldReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitFieldReference(fieldReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 1575, 1619);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(80, 884, 1671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(80, 884, 1671);
            }
        }

        private static void VisitTypeReference(Cci.ITypeReference typeReference, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(80, 1683, 4052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1801, 1843);

                f_80_1801_1842(typeReference != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1859, 1937);

                Cci.IArrayTypeReference?
                arrayType = typeReference as Cci.IArrayTypeReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 1951, 2109) || true) && (arrayType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 1951, 2109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 2006, 2069);

                    f_80_2006_2068(f_80_2025_2058(arrayType, context), context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 2087, 2094);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 1951, 2109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 2125, 2209);

                Cci.IPointerTypeReference?
                pointerType = typeReference as Cci.IPointerTypeReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 2223, 2384) || true) && (pointerType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 2223, 2384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 2280, 2344);

                    f_80_2280_2343(f_80_2299_2333(pointerType, context), context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 2362, 2369);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 2223, 2384);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 2717, 2804);

                Cci.IModifiedTypeReference?
                modifiedType = typeReference as Cci.IModifiedTypeReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 2818, 3172) || true) && (modifiedType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 2818, 3172);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 2876, 3057);
                        foreach (var custModifier in f_80_2905_2933_I(f_80_2905_2933(modifiedType)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 2876, 3057);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 2975, 3038);

                            f_80_2975_3037(f_80_2994_3027(custModifier, context), context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(80, 2876, 3057);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(80, 1, 182);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(80, 1, 182);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 3075, 3132);

                    f_80_3075_3131(f_80_3094_3121(modifiedType), context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 3150, 3157);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 2818, 3172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 3226, 3301);

                Cci.INestedTypeReference?
                nestedType = f_80_3265_3300(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 3315, 3453) || true) && (nestedType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 3315, 3453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 3371, 3438);

                    f_80_3371_3437(f_80_3390_3427(nestedType, context), context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 3315, 3453);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 3509, 3607);

                Cci.IGenericTypeInstanceReference?
                genericInstance = f_80_3562_3606(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 3621, 3855) || true) && (genericInstance != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 3621, 3855);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 3682, 3840);
                        foreach (var arg in f_80_3702_3746_I(f_80_3702_3746(genericInstance, context)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 3682, 3840);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 3788, 3821);

                            f_80_3788_3820(arg, context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(80, 3682, 3840);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(80, 1, 159);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(80, 1, 159);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 3621, 3855);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 3871, 4041) || true) && (typeReference is Cci.IFunctionPointerTypeReference functionPointer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 3871, 4041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 3975, 4026);

                    f_80_3975_4025(f_80_3990_4015(functionPointer), context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 3871, 4041);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(80, 1683, 4052);

                int
                f_80_1801_1842(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 1801, 1842);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_80_2025_2058(Microsoft.Cci.IArrayTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetElementType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 2025, 2058);
                    return return_v;
                }


                int
                f_80_2006_2068(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 2006, 2068);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_80_2299_2333(Microsoft.Cci.IPointerTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetTargetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 2299, 2333);
                    return return_v;
                }


                int
                f_80_2280_2343(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 2280, 2343);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_80_2905_2933(Microsoft.Cci.IModifiedTypeReference
                this_param)
                {
                    var return_v = this_param.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 2905, 2933);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_80_2994_3027(Microsoft.Cci.ICustomModifier
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetModifier(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 2994, 3027);
                    return return_v;
                }


                int
                f_80_2975_3037(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 2975, 3037);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_80_2905_2933_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 2905, 2933);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_80_3094_3121(Microsoft.Cci.IModifiedTypeReference
                this_param)
                {
                    var return_v = this_param.UnmodifiedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 3094, 3121);
                    return return_v;
                }


                int
                f_80_3075_3131(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 3075, 3131);
                    return 0;
                }


                Microsoft.Cci.INestedTypeReference?
                f_80_3265_3300(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 3265, 3300);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_80_3390_3427(Microsoft.Cci.INestedTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 3390, 3427);
                    return return_v;
                }


                int
                f_80_3371_3437(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 3371, 3437);
                    return 0;
                }


                Microsoft.Cci.IGenericTypeInstanceReference?
                f_80_3562_3606(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsGenericTypeInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 3562, 3606);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                f_80_3702_3746(Microsoft.Cci.IGenericTypeInstanceReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericArguments(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 3702, 3746);
                    return return_v;
                }


                int
                f_80_3788_3820(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 3788, 3820);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                f_80_3702_3746_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 3702, 3746);
                    return return_v;
                }


                Microsoft.Cci.ISignature
                f_80_3990_4015(Microsoft.Cci.IFunctionPointerTypeReference
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 3990, 4015);
                    return return_v;
                }


                int
                f_80_3975_4025(Microsoft.Cci.ISignature
                signature, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitSignature(signature, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 3975, 4025);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(80, 1683, 4052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(80, 1683, 4052);
            }
        }

        private static void VisitMethodReference(Cci.IMethodReference methodReference, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(80, 4064, 5414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 4188, 4232);

                f_80_4188_4231(methodReference != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 4286, 4358);

                f_80_4286_4357(f_80_4305_4347(methodReference, context), context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 4421, 4525);

                Cci.IGenericMethodInstanceReference?
                genericInstance = f_80_4476_4524(methodReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 4539, 4851) || true) && (genericInstance != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 4539, 4851);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 4600, 4758);
                        foreach (var arg in f_80_4620_4664_I(f_80_4620_4664(genericInstance, context)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 4600, 4758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 4706, 4739);

                            f_80_4706_4738(arg, context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(80, 4600, 4758);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(80, 1, 159);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(80, 1, 159);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 4776, 4836);

                    methodReference = f_80_4794_4835(genericInstance, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 4539, 4851);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 4935, 5033);

                Cci.ISpecializedMethodReference?
                specializedMethod = f_80_4988_5032(methodReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 5047, 5182) || true) && (specializedMethod != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 5047, 5182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 5110, 5167);

                    methodReference = f_80_5128_5166(specializedMethod);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 5047, 5182);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 5198, 5239);

                f_80_5198_5238(methodReference, context);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 5255, 5403) || true) && (f_80_5259_5296(methodReference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 5255, 5403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 5330, 5388);

                    f_80_5330_5387(f_80_5346_5377(methodReference), context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 5255, 5403);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(80, 4064, 5414);

                int
                f_80_4188_4231(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 4188, 4231);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_80_4305_4347(Microsoft.Cci.IMethodReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 4305, 4347);
                    return return_v;
                }


                int
                f_80_4286_4357(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 4286, 4357);
                    return 0;
                }


                Microsoft.Cci.IGenericMethodInstanceReference?
                f_80_4476_4524(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsGenericMethodInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 4476, 4524);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeReference>
                f_80_4620_4664(Microsoft.Cci.IGenericMethodInstanceReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericArguments(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 4620, 4664);
                    return return_v;
                }


                int
                f_80_4706_4738(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 4706, 4738);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeReference>
                f_80_4620_4664_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 4620, 4664);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_80_4794_4835(Microsoft.Cci.IGenericMethodInstanceReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericMethod(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 4794, 4835);
                    return return_v;
                }


                Microsoft.Cci.ISpecializedMethodReference?
                f_80_4988_5032(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsSpecializedMethodReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 4988, 5032);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_80_5128_5166(Microsoft.Cci.ISpecializedMethodReference
                this_param)
                {
                    var return_v = this_param.UnspecializedVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 5128, 5166);
                    return return_v;
                }


                int
                f_80_5198_5238(Microsoft.Cci.IMethodReference
                signature, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitSignature((Microsoft.Cci.ISignature)signature, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 5198, 5238);
                    return 0;
                }


                bool
                f_80_5259_5296(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AcceptsExtraArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 5259, 5296);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_80_5346_5377(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.ExtraParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 5346, 5377);
                    return return_v;
                }


                int
                f_80_5330_5387(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                parameters, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitParameters(parameters, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 5330, 5387);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(80, 4064, 5414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(80, 4064, 5414);
            }
        }

        internal static void VisitSignature(Cci.ISignature signature, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(80, 5426, 6131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 5571, 5630);

                f_80_5571_5629(f_80_5587_5619(signature, context), context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 5686, 5742);

                f_80_5686_5741(f_80_5705_5731(signature, context), context);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 5758, 5927);
                    foreach (var typeModifier in f_80_5787_5815_I(f_80_5787_5815(signature)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 5758, 5927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 5849, 5912);

                        f_80_5849_5911(f_80_5868_5901(typeModifier, context), context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(80, 5758, 5927);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(80, 1, 170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(80, 1, 170);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 5943, 6120);
                    foreach (var typeModifier in f_80_5972_6008_I(f_80_5972_6008(signature)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 5943, 6120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 6042, 6105);

                        f_80_6042_6104(f_80_6061_6094(typeModifier, context), context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(80, 5943, 6120);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(80, 1, 178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(80, 1, 178);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(80, 5426, 6131);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_80_5587_5619(Microsoft.Cci.ISignature
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetParameters(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 5587, 5619);
                    return return_v;
                }


                int
                f_80_5571_5629(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                parameters, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitParameters(parameters, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 5571, 5629);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_80_5705_5731(Microsoft.Cci.ISignature
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 5705, 5731);
                    return return_v;
                }


                int
                f_80_5686_5741(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 5686, 5741);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_80_5787_5815(Microsoft.Cci.ISignature
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 5787, 5815);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_80_5868_5901(Microsoft.Cci.ICustomModifier
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetModifier(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 5868, 5901);
                    return return_v;
                }


                int
                f_80_5849_5911(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 5849, 5911);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_80_5787_5815_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 5787, 5815);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_80_5972_6008(Microsoft.Cci.ISignature
                this_param)
                {
                    var return_v = this_param.ReturnValueCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 5972, 6008);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_80_6061_6094(Microsoft.Cci.ICustomModifier
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetModifier(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6061, 6094);
                    return return_v;
                }


                int
                f_80_6042_6104(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6042, 6104);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_80_5972_6008_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 5972, 6008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(80, 5426, 6131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(80, 5426, 6131);
            }
        }

        private static void VisitParameters(ImmutableArray<Cci.IParameterTypeInformation> parameters, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(80, 6143, 6817);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 6282, 6806);
                    foreach (var param in f_80_6304_6314_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 6282, 6806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 6348, 6400);

                        f_80_6348_6399(f_80_6367_6389(param, context), context);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 6420, 6597);
                            foreach (var typeModifier in f_80_6449_6473_I(f_80_6449_6473(param)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 6420, 6597);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 6515, 6578);

                                f_80_6515_6577(f_80_6534_6567(typeModifier, context), context);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(80, 6420, 6597);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(80, 1, 178);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(80, 1, 178);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 6617, 6791);
                            foreach (var typeModifier in f_80_6646_6667_I(f_80_6646_6667(param)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 6617, 6791);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 6709, 6772);

                                f_80_6709_6771(f_80_6728_6761(typeModifier, context), context);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(80, 6617, 6791);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(80, 1, 175);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(80, 1, 175);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(80, 6282, 6806);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(80, 1, 525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(80, 1, 525);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(80, 6143, 6817);

                Microsoft.Cci.ITypeReference
                f_80_6367_6389(Microsoft.Cci.IParameterTypeInformation
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6367, 6389);
                    return return_v;
                }


                int
                f_80_6348_6399(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6348, 6399);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_80_6449_6473(Microsoft.Cci.IParameterTypeInformation
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 6449, 6473);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_80_6534_6567(Microsoft.Cci.ICustomModifier
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetModifier(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6534, 6567);
                    return return_v;
                }


                int
                f_80_6515_6577(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6515, 6577);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_80_6449_6473_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6449, 6473);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_80_6646_6667(Microsoft.Cci.IParameterTypeInformation
                this_param)
                {
                    var return_v = this_param.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 6646, 6667);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_80_6728_6761(Microsoft.Cci.ICustomModifier
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetModifier(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6728, 6761);
                    return return_v;
                }


                int
                f_80_6709_6771(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6709, 6771);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_80_6646_6667_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6646, 6667);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_80_6304_6314_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6304, 6314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(80, 6143, 6817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(80, 6143, 6817);
            }
        }

        private static void VisitFieldReference(Cci.IFieldReference fieldReference, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(80, 6829, 7562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 6950, 6993);

                f_80_6950_6992(fieldReference != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 7047, 7118);

                f_80_7047_7117(f_80_7066_7107(fieldReference, context), context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 7201, 7295);

                Cci.ISpecializedFieldReference?
                specializedField = f_80_7252_7294(fieldReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 7309, 7441) || true) && (specializedField != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(80, 7309, 7441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 7371, 7426);

                    fieldReference = f_80_7388_7425(specializedField);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(80, 7309, 7441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(80, 7490, 7551);

                f_80_7490_7550(f_80_7509_7540(fieldReference, context), context);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(80, 6829, 7562);

                int
                f_80_6950_6992(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 6950, 6992);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_80_7066_7107(Microsoft.Cci.IFieldReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 7066, 7107);
                    return return_v;
                }


                int
                f_80_7047_7117(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 7047, 7117);
                    return 0;
                }


                Microsoft.Cci.ISpecializedFieldReference?
                f_80_7252_7294(Microsoft.Cci.IFieldReference
                this_param)
                {
                    var return_v = this_param.AsSpecializedFieldReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 7252, 7294);
                    return return_v;
                }


                Microsoft.Cci.IFieldReference
                f_80_7388_7425(Microsoft.Cci.ISpecializedFieldReference
                this_param)
                {
                    var return_v = this_param.UnspecializedVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(80, 7388, 7425);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_80_7509_7540(Microsoft.Cci.IFieldReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 7509, 7540);
                    return return_v;
                }


                int
                f_80_7490_7550(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    VisitTypeReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(80, 7490, 7550);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(80, 6829, 7562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(80, 6829, 7562);
            }
        }

        static ReferenceDependencyWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(80, 820, 7569);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(80, 820, 7569);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(80, 820, 7569);
        }

    }
}
