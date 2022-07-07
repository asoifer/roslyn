// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.Cci
{
    internal abstract class ReferenceIndexerBase : MetadataVisitor
    {
        private readonly HashSet<IReferenceOrISignature> _alreadySeen;

        private readonly HashSet<IReferenceOrISignature> _alreadyHasToken;

        protected bool typeReferenceNeedsToken;

        internal ReferenceIndexerBase(EmitContext context)
        : base(f_509_834_841_C(context))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(509, 763, 864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 597, 617);
                this._alreadySeen = f_509_612_617();
                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IReferenceOrISignature>
f_509_612_617()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IReferenceOrISignature>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 612, 617);
                    return return_v;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 677, 701);
                this._alreadyHasToken = f_509_696_701();
                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IReferenceOrISignature>
f_509_696_701()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IReferenceOrISignature>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 696, 701);
                    return return_v;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 727, 750);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(509, 763, 864);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 763, 864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 763, 864);
            }
        }

        public override void Visit(IAssemblyReference assemblyReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 876, 1138);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 965, 1127) || true) && (assemblyReference != f_509_990_1035(Context.Module, Context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 965, 1127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 1069, 1112);

                    f_509_1069_1111(this, assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 965, 1127);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 876, 1138);

                Microsoft.Cci.IAssemblyReference
                f_509_990_1035(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingAssembly(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 990, 1035);
                    return return_v;
                }


                int
                f_509_1069_1111(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IAssemblyReference
                assemblyReference)
                {
                    this_param.RecordAssemblyReference(assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 1069, 1111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 876, 1138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 876, 1138);
            }
        }

        protected abstract void RecordAssemblyReference(IAssemblyReference assemblyReference);

        public override void Visit(ICustomModifier customModifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 1248, 1440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 1331, 1367);

                this.typeReferenceNeedsToken = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 1381, 1429);

                f_509_1381_1428(this, f_509_1392_1427(customModifier, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 1248, 1440);

                Microsoft.Cci.ITypeReference
                f_509_1392_1427(Microsoft.Cci.ICustomModifier
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetModifier(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 1392, 1427);
                    return return_v;
                }


                int
                f_509_1381_1428(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 1381, 1428);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 1248, 1440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 1248, 1440);
            }
        }

        public override void Visit(IEventDefinition eventDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 1452, 1701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 1537, 1573);

                this.typeReferenceNeedsToken = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 1587, 1632);

                f_509_1587_1631(this, f_509_1598_1630(eventDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 1646, 1690);

                f_509_1646_1689(!this.typeReferenceNeedsToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 1452, 1701);

                Microsoft.Cci.ITypeReference
                f_509_1598_1630(Microsoft.Cci.IEventDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 1598, 1630);
                    return return_v;
                }


                int
                f_509_1587_1631(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 1587, 1631);
                    return 0;
                }


                int
                f_509_1646_1689(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 1646, 1689);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 1452, 1701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 1452, 1701);
            }
        }

        public override void Visit(IFieldReference fieldReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 1713, 2380);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 1796, 1917) || true) && (!f_509_1801_1861(_alreadySeen, f_509_1818_1860(fieldReference)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 1796, 1917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 1895, 1902);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 1796, 1917);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 1933, 2055);

                IUnitReference
                definingUnit = f_509_1963_2054(f_509_2003_2044(fieldReference, Context), Context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 2069, 2198) || true) && (definingUnit != null && (DynAbs.Tracing.TraceSender.Expression_True(509, 2073, 2142) && f_509_2097_2142(definingUnit, Context.Module)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 2069, 2198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 2176, 2183);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 2069, 2198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 2214, 2263);

                f_509_2214_2262(
                            this, fieldReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 2277, 2321);

                f_509_2277_2320(this, f_509_2288_2319(fieldReference, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 2335, 2369);

                f_509_2335_2368(this, fieldReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 1713, 2380);

                Microsoft.CodeAnalysis.IReferenceOrISignature
                f_509_1818_1860(Microsoft.Cci.IFieldReference
                item)
                {
                    var return_v = new Microsoft.CodeAnalysis.IReferenceOrISignature((Microsoft.Cci.IReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 1818, 1860);
                    return return_v;
                }


                bool
                f_509_1801_1861(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IReferenceOrISignature>
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 1801, 1861);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_509_2003_2044(Microsoft.Cci.IFieldReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 2003, 2044);
                    return return_v;
                }


                Microsoft.Cci.IUnitReference
                f_509_1963_2054(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = MetadataWriter.GetDefiningUnitReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 1963, 2054);
                    return return_v;
                }


                bool
                f_509_2097_2142(Microsoft.Cci.IUnitReference
                objA, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 2097, 2142);
                    return return_v;
                }


                int
                f_509_2214_2262(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IFieldReference
                typeMemberReference)
                {
                    this_param.Visit((Microsoft.Cci.ITypeMemberReference)typeMemberReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 2214, 2262);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_509_2288_2319(Microsoft.Cci.IFieldReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 2288, 2319);
                    return return_v;
                }


                int
                f_509_2277_2320(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 2277, 2320);
                    return 0;
                }


                int
                f_509_2335_2368(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IFieldReference
                fieldReference)
                {
                    this_param.ReserveFieldToken(fieldReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 2335, 2368);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 1713, 2380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 1713, 2380);
            }
        }

        protected abstract void ReserveFieldToken(IFieldReference fieldReference);

        public override void Visit(IFileReference fileReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 2478, 2605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 2559, 2594);

                f_509_2559_2593(this, fileReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 2478, 2605);

                int
                f_509_2559_2593(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IFileReference
                fileReference)
                {
                    this_param.RecordFileReference(fileReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 2559, 2593);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 2478, 2605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 2478, 2605);
            }
        }

        protected abstract void RecordFileReference(IFileReference fileReference);

        public override void Visit(IGenericMethodInstanceReference genericMethodInstanceReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 2703, 2984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 2818, 2890);

                f_509_2818_2889(this, f_509_2829_2888(genericMethodInstanceReference, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 2904, 2973);

                f_509_2904_2972(this, f_509_2915_2971(genericMethodInstanceReference, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 2703, 2984);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeReference>
                f_509_2829_2888(Microsoft.Cci.IGenericMethodInstanceReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericArguments(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 2829, 2888);
                    return return_v;
                }


                int
                f_509_2818_2889(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeReference>
                typeReferences)
                {
                    this_param.Visit(typeReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 2818, 2889);
                    return 0;
                }


                Microsoft.Cci.IMethodReference
                f_509_2915_2971(Microsoft.Cci.IGenericMethodInstanceReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericMethod(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 2915, 2971);
                    return return_v;
                }


                int
                f_509_2904_2972(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    this_param.Visit(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 2904, 2972);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 2703, 2984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 2703, 2984);
            }
        }

        public override void Visit(IGenericParameter genericParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 2996, 3241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 3083, 3135);

                f_509_3083_3134(this, f_509_3094_3133(genericParameter, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 3149, 3230);

                f_509_3149_3229(this, f_509_3188_3228(genericParameter, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 2996, 3241);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_509_3094_3133(Microsoft.Cci.IGenericParameter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAttributes(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 3094, 3133);
                    return return_v;
                }


                int
                f_509_3083_3134(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 3083, 3134);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                f_509_3188_3228(Microsoft.Cci.IGenericParameter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetConstraints(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 3188, 3228);
                    return return_v;
                }


                int
                f_509_3149_3229(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                refsWithAttributes)
                {
                    this_param.VisitTypeReferencesThatNeedTokens(refsWithAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 3149, 3229);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 2996, 3241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 2996, 3241);
            }
        }

        public override void Visit(IGenericTypeInstanceReference genericTypeInstanceReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 3253, 4117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 3431, 3516);

                INestedTypeReference
                nestedType = f_509_3465_3515(genericTypeInstanceReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 3532, 3941) || true) && (nestedType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 3532, 3941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 3588, 3658);

                    ITypeReference
                    containingType = f_509_3620_3657(nestedType, Context)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 3678, 3926) || true) && (f_509_3682_3727(containingType) != null || (DynAbs.Tracing.TraceSender.Expression_False(509, 3682, 3815) || f_509_3760_3807(containingType) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 3678, 3926);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 3857, 3907);

                        f_509_3857_3906(this, f_509_3868_3905(nestedType, Context));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(509, 3678, 3926);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 3532, 3941);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 3957, 4022);

                f_509_3957_4021(
                            this, f_509_3968_4020(genericTypeInstanceReference, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 4036, 4106);

                f_509_4036_4105(this, f_509_4047_4104(genericTypeInstanceReference, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 3253, 4117);

                Microsoft.Cci.INestedTypeReference?
                f_509_3465_3515(Microsoft.Cci.IGenericTypeInstanceReference
                this_param)
                {
                    var return_v = this_param.AsNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 3465, 3515);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_509_3620_3657(Microsoft.Cci.INestedTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 3620, 3657);
                    return return_v;
                }


                Microsoft.Cci.IGenericTypeInstanceReference?
                f_509_3682_3727(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsGenericTypeInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 3682, 3727);
                    return return_v;
                }


                Microsoft.Cci.ISpecializedNestedTypeReference?
                f_509_3760_3807(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsSpecializedNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 3760, 3807);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_509_3868_3905(Microsoft.Cci.INestedTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 3868, 3905);
                    return return_v;
                }


                int
                f_509_3857_3906(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 3857, 3906);
                    return 0;
                }


                Microsoft.Cci.INamedTypeReference
                f_509_3968_4020(Microsoft.Cci.IGenericTypeInstanceReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 3968, 4020);
                    return return_v;
                }


                int
                f_509_3957_4021(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.INamedTypeReference
                typeReference)
                {
                    this_param.Visit((Microsoft.Cci.ITypeReference)typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 3957, 4021);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                f_509_4047_4104(Microsoft.Cci.IGenericTypeInstanceReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericArguments(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 4047, 4104);
                    return return_v;
                }


                int
                f_509_4036_4105(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                typeReferences)
                {
                    this_param.Visit((System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeReference>)typeReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 4036, 4105);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 3253, 4117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 3253, 4117);
            }
        }

        public override void Visit(IMarshallingInformation marshallingInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 4129, 4348);
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 4129, 4348);
                // The type references in the marshalling information do not end up in tables, but are serialized as strings.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 4129, 4348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 4129, 4348);
            }
        }

        public override void Visit(IMethodDefinition method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 4360, 4507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 4437, 4456);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(method), 509, 4437, 4455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 4470, 4496);

                f_509_4470_4495(this, method);
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 4360, 4507);

                int
                f_509_4470_4495(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IMethodDefinition
                method)
                {
                    this_param.ProcessMethodBody(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 4470, 4495);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 4360, 4507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 4360, 4507);
            }
        }

        protected abstract void ProcessMethodBody(IMethodDefinition method);

        public override void Visit(IMethodReference methodReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 4599, 6260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 4684, 4798);

                IGenericMethodInstanceReference
                genericMethodInstanceReference = f_509_4749_4797(methodReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 4812, 4971) || true) && (genericMethodInstanceReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 4812, 4971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 4888, 4931);

                    f_509_4888_4930(this, genericMethodInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 4949, 4956);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 4812, 4971);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 4987, 5109) || true) && (!f_509_4992_5053(_alreadySeen, f_509_5009_5052(methodReference)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 4987, 5109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 5087, 5094);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 4987, 5109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 5555, 5678);

                IUnitReference
                definingUnit = f_509_5585_5677(f_509_5625_5667(methodReference, Context), Context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 5692, 5863) || true) && (definingUnit != null && (DynAbs.Tracing.TraceSender.Expression_True(509, 5696, 5765) && f_509_5720_5765(definingUnit, Context.Module)) && (DynAbs.Tracing.TraceSender.Expression_True(509, 5696, 5807) && f_509_5769_5807_M(!methodReference.AcceptsExtraArguments)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 5692, 5863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 5841, 5848);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 5692, 5863);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 5879, 5929);

                f_509_5879_5928(
                            this, methodReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 5945, 6047);

                f_509_5945_6046(this, f_509_5960_6026_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_509_5960_6004(methodReference), 509, 5960, 6026)?.UnspecializedVersion) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.IMethodReference?>(509, 5960, 6045) ?? methodReference));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 6063, 6197) || true) && (f_509_6067_6104(methodReference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 6063, 6197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 6138, 6182);

                    f_509_6138_6181(this, f_509_6149_6180(methodReference));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 6063, 6197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 6213, 6249);

                f_509_6213_6248(this, methodReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 4599, 6260);

                Microsoft.Cci.IGenericMethodInstanceReference?
                f_509_4749_4797(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsGenericMethodInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 4749, 4797);
                    return return_v;
                }


                int
                f_509_4888_4930(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IGenericMethodInstanceReference
                genericMethodInstanceReference)
                {
                    this_param.Visit(genericMethodInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 4888, 4930);
                    return 0;
                }


                Microsoft.CodeAnalysis.IReferenceOrISignature
                f_509_5009_5052(Microsoft.Cci.IMethodReference
                item)
                {
                    var return_v = new Microsoft.CodeAnalysis.IReferenceOrISignature(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 5009, 5052);
                    return return_v;
                }


                bool
                f_509_4992_5053(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IReferenceOrISignature>
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 4992, 5053);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_509_5625_5667(Microsoft.Cci.IMethodReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 5625, 5667);
                    return return_v;
                }


                Microsoft.Cci.IUnitReference
                f_509_5585_5677(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = MetadataWriter.GetDefiningUnitReference(typeReference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 5585, 5677);
                    return return_v;
                }


                bool
                f_509_5720_5765(Microsoft.Cci.IUnitReference
                objA, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 5720, 5765);
                    return return_v;
                }


                bool
                f_509_5769_5807_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 5769, 5807);
                    return return_v;
                }


                int
                f_509_5879_5928(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IMethodReference
                typeMemberReference)
                {
                    this_param.Visit((Microsoft.Cci.ITypeMemberReference)typeMemberReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 5879, 5928);
                    return 0;
                }


                Microsoft.Cci.ISpecializedMethodReference?
                f_509_5960_6004(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsSpecializedMethodReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 5960, 6004);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference?
                f_509_5960_6026_M(Microsoft.Cci.IMethodReference?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 5960, 6026);
                    return return_v;
                }


                int
                f_509_5945_6046(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IMethodReference
                signature)
                {
                    this_param.VisitSignature((Microsoft.Cci.ISignature)signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 5945, 6046);
                    return 0;
                }


                bool
                f_509_6067_6104(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AcceptsExtraArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 6067, 6104);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_509_6149_6180(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.ExtraParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 6149, 6180);
                    return return_v;
                }


                int
                f_509_6138_6181(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                parameterTypeInformations)
                {
                    this_param.Visit(parameterTypeInformations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 6138, 6181);
                    return 0;
                }


                int
                f_509_6213_6248(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    this_param.ReserveMethodToken(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 6213, 6248);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 4599, 6260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 4599, 6260);
            }
        }

        public void VisitSignature(ISignature signature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 6272, 6572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 6345, 6384);

                f_509_6345_6383(this, f_509_6356_6382(signature, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 6398, 6443);

                f_509_6398_6442(this, f_509_6409_6441(signature, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 6457, 6498);

                f_509_6457_6497(this, f_509_6468_6496(signature));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 6512, 6561);

                f_509_6512_6560(this, f_509_6523_6559(signature));
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 6272, 6572);

                Microsoft.Cci.ITypeReference
                f_509_6356_6382(Microsoft.Cci.ISignature
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 6356, 6382);
                    return return_v;
                }


                int
                f_509_6345_6383(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 6345, 6383);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_509_6409_6441(Microsoft.Cci.ISignature
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetParameters(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 6409, 6441);
                    return return_v;
                }


                int
                f_509_6398_6442(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                parameterTypeInformations)
                {
                    this_param.Visit(parameterTypeInformations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 6398, 6442);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_509_6468_6496(Microsoft.Cci.ISignature
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 6468, 6496);
                    return return_v;
                }


                int
                f_509_6457_6497(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 6457, 6497);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_509_6523_6559(Microsoft.Cci.ISignature
                this_param)
                {
                    var return_v = this_param.ReturnValueCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 6523, 6559);
                    return return_v;
                }


                int
                f_509_6512_6560(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 6512, 6560);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 6272, 6572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 6272, 6572);
            }
        }

        protected abstract void ReserveMethodToken(IMethodReference methodReference);

        public abstract override void Visit(CommonPEModuleBuilder module);

        public override void Visit(IModuleReference moduleReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 6751, 6972);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 6836, 6961) || true) && (moduleReference != Context.Module)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 6836, 6961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 6907, 6946);

                    f_509_6907_6945(this, moduleReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 6836, 6961);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 6751, 6972);

                int
                f_509_6907_6945(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IModuleReference
                moduleReference)
                {
                    this_param.RecordModuleReference(moduleReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 6907, 6945);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 6751, 6972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 6751, 6972);
            }
        }

        protected abstract void RecordModuleReference(IModuleReference moduleReference);

        public abstract override void Visit(IPlatformInvokeInformation platformInvokeInformation);

        public override void Visit(INamespaceTypeReference namespaceTypeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 7178, 8561);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 7277, 7435) || true) && (!this.typeReferenceNeedsToken && (DynAbs.Tracing.TraceSender.Expression_True(509, 7281, 7379) && f_509_7314_7345(namespaceTypeReference) != PrimitiveTypeCode.NotPrimitive))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 7277, 7435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 7413, 7420);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 7277, 7435);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 7451, 7495);

                f_509_7451_7494(this, namespaceTypeReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 7511, 7562);

                var
                unit = f_509_7522_7561(namespaceTypeReference, Context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 7578, 7629);

                var
                assemblyReference = unit as IAssemblyReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 7643, 8550) || true) && (assemblyReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 7643, 8550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 7706, 7736);

                    f_509_7706_7735(this, assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 7643, 8550);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 7643, 8550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 7802, 7849);

                    var
                    moduleReference = unit as IModuleReference
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 7867, 8535) || true) && (moduleReference != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 7867, 8535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 8099, 8166);

                        assemblyReference = f_509_8119_8165(moduleReference, Context);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 8188, 8516) || true) && (assemblyReference != null && (DynAbs.Tracing.TraceSender.Expression_True(509, 8192, 8287) && assemblyReference != f_509_8242_8287(Context.Module, Context)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 8188, 8516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 8337, 8367);

                            f_509_8337_8366(this, assemblyReference);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(509, 8188, 8516);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 8188, 8516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 8465, 8493);

                            f_509_8465_8492(this, moduleReference);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(509, 8188, 8516);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(509, 7867, 8535);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 7643, 8550);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 7178, 8561);

                Microsoft.Cci.PrimitiveTypeCode
                f_509_7314_7345(Microsoft.Cci.INamespaceTypeReference
                this_param)
                {
                    var return_v = this_param.TypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 7314, 7345);
                    return return_v;
                }


                int
                f_509_7451_7494(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.INamespaceTypeReference
                typeReference)
                {
                    this_param.RecordTypeReference((Microsoft.Cci.ITypeReference)typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 7451, 7494);
                    return 0;
                }


                Microsoft.Cci.IUnitReference
                f_509_7522_7561(Microsoft.Cci.INamespaceTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetUnit(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 7522, 7561);
                    return return_v;
                }


                int
                f_509_7706_7735(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IAssemblyReference
                assemblyReference)
                {
                    this_param.Visit(assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 7706, 7735);
                    return 0;
                }


                Microsoft.Cci.IAssemblyReference
                f_509_8119_8165(Microsoft.Cci.IModuleReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingAssembly(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 8119, 8165);
                    return return_v;
                }


                Microsoft.Cci.IAssemblyReference
                f_509_8242_8287(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingAssembly(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 8242, 8287);
                    return return_v;
                }


                int
                f_509_8337_8366(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IAssemblyReference
                assemblyReference)
                {
                    this_param.Visit(assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 8337, 8366);
                    return 0;
                }


                int
                f_509_8465_8492(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IModuleReference
                moduleReference)
                {
                    this_param.Visit(moduleReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 8465, 8492);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 7178, 8561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 7178, 8561);
            }
        }

        protected abstract void RecordTypeReference(ITypeReference typeReference);

        public override void Visit(INestedTypeReference nestedTypeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 8659, 8973);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 8752, 8905) || true) && (!this.typeReferenceNeedsToken && (DynAbs.Tracing.TraceSender.Expression_True(509, 8756, 8849) && f_509_8789_8841(nestedTypeReference) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 8752, 8905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 8883, 8890);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 8752, 8905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 8921, 8962);

                f_509_8921_8961(this, nestedTypeReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 8659, 8973);

                Microsoft.Cci.ISpecializedNestedTypeReference?
                f_509_8789_8841(Microsoft.Cci.INestedTypeReference
                this_param)
                {
                    var return_v = this_param.AsSpecializedNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 8789, 8841);
                    return return_v;
                }


                int
                f_509_8921_8961(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.INestedTypeReference
                typeReference)
                {
                    this_param.RecordTypeReference((Microsoft.Cci.ITypeReference)typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 8921, 8961);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 8659, 8973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 8659, 8973);
            }
        }

        public override void Visit(IPropertyDefinition propertyDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 8985, 9129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9076, 9118);

                f_509_9076_9117(this, f_509_9087_9116(propertyDefinition));
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 8985, 9129);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                f_509_9087_9116(Microsoft.Cci.IPropertyDefinition
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 9087, 9116);
                    return return_v;
                }


                int
                f_509_9076_9117(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                parameters)
                {
                    this_param.Visit(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 9076, 9117);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 8985, 9129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 8985, 9129);
            }
        }

        public override void Visit(ManagedResource resourceReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 9141, 9444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9227, 9268);

                f_509_9227_9267(this, f_509_9238_9266(resourceReference));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9284, 9337);

                IFileReference
                file = f_509_9306_9336(resourceReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9351, 9433) || true) && (file != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 9351, 9433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9401, 9418);

                    f_509_9401_9417(this, file);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 9351, 9433);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 9141, 9444);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_509_9238_9266(Microsoft.Cci.ManagedResource
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 9238, 9266);
                    return return_v;
                }


                int
                f_509_9227_9267(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 9227, 9267);
                    return 0;
                }


                Microsoft.Cci.IFileReference?
                f_509_9306_9336(Microsoft.Cci.ManagedResource
                this_param)
                {
                    var return_v = this_param.ExternalFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 9306, 9336);
                    return return_v;
                }


                int
                f_509_9401_9417(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.IFileReference
                fileReference)
                {
                    this_param.Visit(fileReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 9401, 9417);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 9141, 9444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 9141, 9444);
            }
        }

        public override void Visit(SecurityAttribute securityAttribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 9456, 9595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9544, 9584);

                f_509_9544_9583(this, securityAttribute.Attribute);
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 9456, 9595);

                int
                f_509_9544_9583(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ICustomAttribute
                customAttribute)
                {
                    this_param.Visit(customAttribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 9544, 9583);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 9456, 9595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 9456, 9595);
            }
        }

        public void VisitTypeDefinitionNoMembers(ITypeDefinition typeDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 9607, 10519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9704, 9754);

                f_509_9704_9753(this, f_509_9715_9752(typeDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9770, 9822);

                var
                baseType = f_509_9785_9821(typeDefinition, Context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9836, 10042) || true) && (baseType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 9836, 10042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9890, 9926);

                    this.typeReferenceNeedsToken = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9944, 9965);

                    f_509_9944_9964(this, baseType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 9983, 10027);

                    f_509_9983_10026(!this.typeReferenceNeedsToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 9836, 10042);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10058, 10129);

                f_509_10058_10128(
                            this, f_509_10069_10127(typeDefinition, Context));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10143, 10279) || true) && (f_509_10147_10184(typeDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 10143, 10279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10218, 10264);

                    f_509_10218_10263(this, f_509_10229_10262(typeDefinition));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 10143, 10279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10295, 10370);

                f_509_10295_10369(
                            this, f_509_10334_10368(typeDefinition, Context));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10386, 10508) || true) && (f_509_10390_10414(typeDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 10386, 10508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10448, 10493);

                    f_509_10448_10492(this, f_509_10459_10491(typeDefinition));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 10386, 10508);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 9607, 10519);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_509_9715_9752(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAttributes(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 9715, 9752);
                    return return_v;
                }


                int
                f_509_9704_9753(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 9704, 9753);
                    return 0;
                }


                Microsoft.Cci.ITypeReference?
                f_509_9785_9821(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetBaseClass(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 9785, 9821);
                    return return_v;
                }


                int
                f_509_9944_9964(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 9944, 9964);
                    return 0;
                }


                int
                f_509_9983_10026(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 9983, 10026);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
                f_509_10069_10127(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetExplicitImplementationOverrides(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10069, 10127);
                    return return_v;
                }


                int
                f_509_10058_10128(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
                methodImplementations)
                {
                    this_param.Visit(methodImplementations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10058, 10128);
                    return 0;
                }


                bool
                f_509_10147_10184(Microsoft.Cci.ITypeDefinition
                this_param)
                {
                    var return_v = this_param.HasDeclarativeSecurity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 10147, 10184);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_509_10229_10262(Microsoft.Cci.ITypeDefinition
                this_param)
                {
                    var return_v = this_param.SecurityAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 10229, 10262);
                    return return_v;
                }


                int
                f_509_10218_10263(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                securityAttributes)
                {
                    this_param.Visit(securityAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10218, 10263);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                f_509_10334_10368(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.Interfaces(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10334, 10368);
                    return return_v;
                }


                int
                f_509_10295_10369(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                refsWithAttributes)
                {
                    this_param.VisitTypeReferencesThatNeedTokens(refsWithAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10295, 10369);
                    return 0;
                }


                bool
                f_509_10390_10414(Microsoft.Cci.ITypeDefinition
                this_param)
                {
                    var return_v = this_param.IsGeneric;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 10390, 10414);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericTypeParameter>
                f_509_10459_10491(Microsoft.Cci.ITypeDefinition
                this_param)
                {
                    var return_v = this_param.GenericParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 10459, 10491);
                    return return_v;
                }


                int
                f_509_10448_10492(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericTypeParameter>
                genericParameters)
                {
                    this_param.Visit((System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericParameter>)genericParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10448, 10492);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 9607, 10519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 9607, 10519);
            }
        }

        public override void Visit(ITypeDefinition typeDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 10531, 10993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10614, 10659);

                f_509_10614_10658(this, typeDefinition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10675, 10721);

                f_509_10675_10720(
                            this, f_509_10686_10719(typeDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10735, 10781);

                f_509_10735_10780(this, f_509_10746_10779(typeDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10795, 10842);

                f_509_10795_10841(this, f_509_10806_10840(typeDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10856, 10918);

                f_509_10856_10917(this, f_509_10878_10916(typeDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 10932, 10982);

                f_509_10932_10981(this, f_509_10943_10980(typeDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 10531, 10993);

                int
                f_509_10614_10658(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeDefinition
                typeDefinition)
                {
                    this_param.VisitTypeDefinitionNoMembers(typeDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10614, 10658);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
                f_509_10686_10719(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetEvents(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10686, 10719);
                    return return_v;
                }


                int
                f_509_10675_10720(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
                events)
                {
                    this_param.Visit(events);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10675, 10720);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                f_509_10746_10779(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetFields(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10746, 10779);
                    return return_v;
                }


                int
                f_509_10735_10780(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                fields)
                {
                    this_param.Visit(fields);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10735, 10780);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                f_509_10806_10840(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetMethods(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10806, 10840);
                    return return_v;
                }


                int
                f_509_10795_10841(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                methods)
                {
                    this_param.Visit(methods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10795, 10841);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>
                f_509_10878_10916(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetNestedTypes(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10878, 10916);
                    return return_v;
                }


                int
                f_509_10856_10917(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>
                nestedTypes)
                {
                    this_param.VisitNestedTypes((System.Collections.Generic.IEnumerable<Microsoft.Cci.INamedTypeDefinition>)nestedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10856, 10917);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
                f_509_10943_10980(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetProperties(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10943, 10980);
                    return return_v;
                }


                int
                f_509_10932_10981(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
                properties)
                {
                    this_param.Visit(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 10932, 10981);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 10531, 10993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 10531, 10993);
            }
        }

        public void VisitTypeReferencesThatNeedTokens(IEnumerable<TypeReferenceWithAttributes> refsWithAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 11005, 11368);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 11136, 11357);
                    foreach (var refWithAttributes in f_509_11170_11188_I(refsWithAttributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 11136, 11357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 11222, 11263);

                        f_509_11222_11262(this, refWithAttributes.Attributes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 11281, 11342);

                        f_509_11281_11341(this, refWithAttributes.TypeRef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(509, 11136, 11357);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(509, 1, 222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(509, 1, 222);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 11005, 11368);

                int
                f_509_11222_11262(Microsoft.Cci.ReferenceIndexerBase
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit((System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>)customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 11222, 11262);
                    return 0;
                }


                int
                f_509_11281_11341(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.VisitTypeReferencesThatNeedTokens(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 11281, 11341);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                f_509_11170_11188_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 11170, 11188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 11005, 11368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 11005, 11368);
            }
        }

        private void VisitTypeReferencesThatNeedTokens(ITypeReference typeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 11382, 11628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 11483, 11519);

                this.typeReferenceNeedsToken = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 11533, 11559);

                f_509_11533_11558(this, typeReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 11573, 11617);

                f_509_11573_11616(!this.typeReferenceNeedsToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 11382, 11628);

                int
                f_509_11533_11558(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 11533, 11558);
                    return 0;
                }


                int
                f_509_11573_11616(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 11573, 11616);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 11382, 11628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 11382, 11628);
            }
        }

        public override void Visit(ITypeMemberReference typeMemberReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 11640, 12506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 11733, 11780);

                f_509_11733_11779(this, typeMemberReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 12328, 12364);

                this.typeReferenceNeedsToken = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 12378, 12437);

                f_509_12378_12436(this, f_509_12389_12435(typeMemberReference, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 12451, 12495);

                f_509_12451_12494(!this.typeReferenceNeedsToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 11640, 12506);

                int
                f_509_11733_11779(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeMemberReference
                typeMemberReference)
                {
                    this_param.RecordTypeMemberReference(typeMemberReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 11733, 11779);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_509_12389_12435(Microsoft.Cci.ITypeMemberReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 12389, 12435);
                    return return_v;
                }


                int
                f_509_12378_12436(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 12378, 12436);
                    return 0;
                }


                int
                f_509_12451_12494(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 12451, 12494);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 11640, 12506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 11640, 12506);
            }
        }

        protected abstract void RecordTypeMemberReference(ITypeMemberReference typeMemberReference);

        public override void Visit(IArrayTypeReference arrayTypeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 12747, 13982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 12987, 13055);

                ITypeReference
                current = f_509_13012_13054(arrayTypeReference, Context)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 13069, 13971) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 13069, 13971);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 13114, 13167);

                        bool
                        mustVisitChildren = f_509_13139_13166(this, current)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 13185, 13956) || true) && (!mustVisitChildren)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 13185, 13956);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 13249, 13256);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(509, 13185, 13956);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 13185, 13956);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 13298, 13956) || true) && (current is IArrayTypeReference)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 13298, 13956);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 13533, 13598);

                                current = f_509_13543_13597(((IArrayTypeReference)current), Context);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 13620, 13629);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(509, 13298, 13956);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 13298, 13956);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 13879, 13908);

                                f_509_13879_13907(this, current);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 13930, 13937);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(509, 13298, 13956);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(509, 13185, 13956);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(509, 13069, 13971);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(509, 13069, 13971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(509, 13069, 13971);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 12747, 13982);

                Microsoft.Cci.ITypeReference
                f_509_13012_13054(Microsoft.Cci.IArrayTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetElementType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 13012, 13054);
                    return return_v;
                }


                bool
                f_509_13139_13166(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.VisitTypeReference(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 13139, 13166);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_509_13543_13597(Microsoft.Cci.IArrayTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetElementType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 13543, 13597);
                    return return_v;
                }


                int
                f_509_13879_13907(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.DispatchAsReference(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 13879, 13907);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 12747, 13982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 12747, 13982);
            }
        }

        public override void Visit(IPointerTypeReference pointerTypeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 14119, 15362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 14364, 14433);

                ITypeReference
                current = f_509_14389_14432(pointerTypeReference, Context)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 14447, 15351) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 14447, 15351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 14492, 14545);

                        bool
                        mustVisitChildren = f_509_14517_14544(this, current)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 14563, 15336) || true) && (!mustVisitChildren)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 14563, 15336);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 14627, 14634);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(509, 14563, 15336);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 14563, 15336);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 14676, 15336) || true) && (current is IPointerTypeReference)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 14676, 15336);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 14912, 14978);

                                current = f_509_14922_14977(((IPointerTypeReference)current), Context);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 15000, 15009);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(509, 14676, 15336);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 14676, 15336);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 15259, 15288);

                                f_509_15259_15287(this, current);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 15310, 15317);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(509, 14676, 15336);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(509, 14563, 15336);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(509, 14447, 15351);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(509, 14447, 15351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(509, 14447, 15351);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 14119, 15362);

                Microsoft.Cci.ITypeReference
                f_509_14389_14432(Microsoft.Cci.IPointerTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetTargetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 14389, 14432);
                    return return_v;
                }


                bool
                f_509_14517_14544(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.VisitTypeReference(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 14517, 14544);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_509_14922_14977(Microsoft.Cci.IPointerTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetTargetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 14922, 14977);
                    return return_v;
                }


                int
                f_509_15259_15287(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.DispatchAsReference(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 15259, 15287);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 14119, 15362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 14119, 15362);
            }
        }

        public override void Visit(ITypeReference typeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 15374, 15587);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 15455, 15576) || true) && (f_509_15459_15492(this, typeReference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 15455, 15576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 15526, 15561);

                    f_509_15526_15560(this, typeReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 15455, 15576);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 15374, 15587);

                bool
                f_509_15459_15492(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.VisitTypeReference(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 15459, 15492);
                    return return_v;
                }


                int
                f_509_15526_15560(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.DispatchAsReference(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 15526, 15560);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 15374, 15587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 15374, 15587);
            }
        }

        private bool VisitTypeReference(ITypeReference typeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(509, 15677, 18349);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 15763, 16288) || true) && (!f_509_15768_15827(_alreadySeen, f_509_15785_15826(typeReference)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 15763, 16288);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 15861, 15968) || true) && (!this.typeReferenceNeedsToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 15861, 15968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 15936, 15949);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(509, 15861, 15968);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 15988, 16025);

                    this.typeReferenceNeedsToken = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 16043, 16185) || true) && (!f_509_16048_16111(_alreadyHasToken, f_509_16069_16110(typeReference)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 16043, 16185);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 16153, 16166);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(509, 16043, 16185);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 16205, 16240);

                    f_509_16205_16239(this, typeReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 16260, 16273);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 15763, 16288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 16304, 16388);

                INestedTypeReference/*?*/
                nestedTypeReference = f_509_16352_16387(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 16402, 17737) || true) && (this.typeReferenceNeedsToken || (DynAbs.Tracing.TraceSender.Expression_False(509, 16406, 16465) || nestedTypeReference != null) || (DynAbs.Tracing.TraceSender.Expression_False(509, 16406, 16592) || (f_509_16485_16507(typeReference) == PrimitiveTypeCode.NotPrimitive && (DynAbs.Tracing.TraceSender.Expression_True(509, 16485, 16591) && f_509_16545_16583(typeReference) != null))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 16402, 17737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 16626, 16750);

                    ISpecializedNestedTypeReference/*?*/
                    specializedNestedTypeReference = f_509_16696_16749_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(nestedTypeReference, 509, 16696, 16749)?.AsSpecializedNestedTypeReference)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 16768, 17226) || true) && (specializedNestedTypeReference != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 16768, 17226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 16852, 16972);

                        INestedTypeReference
                        unspecializedNestedTypeReference = f_509_16908_16971(specializedNestedTypeReference, Context)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 16994, 17207) || true) && (f_509_16998_17080(_alreadyHasToken, f_509_17019_17079(unspecializedNestedTypeReference)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 16994, 17207);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 17130, 17184);

                            f_509_17130_17183(this, unspecializedNestedTypeReference);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(509, 16994, 17207);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(509, 16768, 17226);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 17246, 17441) || true) && (this.typeReferenceNeedsToken && (DynAbs.Tracing.TraceSender.Expression_True(509, 17250, 17345) && f_509_17282_17345(_alreadyHasToken, f_509_17303_17344(typeReference))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 17246, 17441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 17387, 17422);

                        f_509_17387_17421(this, typeReference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(509, 17246, 17441);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 17461, 17722) || true) && (nestedTypeReference != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(509, 17461, 17722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 17534, 17622);

                        this.typeReferenceNeedsToken = (f_509_17566_17612(typeReference) == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 17644, 17703);

                        f_509_17644_17702(this, f_509_17655_17701(nestedTypeReference, Context));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(509, 17461, 17722);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(509, 16402, 17737);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 18275, 18312);

                this.typeReferenceNeedsToken = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(509, 18326, 18338);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(509, 15677, 18349);

                Microsoft.CodeAnalysis.IReferenceOrISignature
                f_509_15785_15826(Microsoft.Cci.ITypeReference
                item)
                {
                    var return_v = new Microsoft.CodeAnalysis.IReferenceOrISignature((Microsoft.Cci.IReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 15785, 15826);
                    return return_v;
                }


                bool
                f_509_15768_15827(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IReferenceOrISignature>
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 15768, 15827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IReferenceOrISignature
                f_509_16069_16110(Microsoft.Cci.ITypeReference
                item)
                {
                    var return_v = new Microsoft.CodeAnalysis.IReferenceOrISignature((Microsoft.Cci.IReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 16069, 16110);
                    return return_v;
                }


                bool
                f_509_16048_16111(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IReferenceOrISignature>
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 16048, 16111);
                    return return_v;
                }


                int
                f_509_16205_16239(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.RecordTypeReference(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 16205, 16239);
                    return 0;
                }


                Microsoft.Cci.INestedTypeReference?
                f_509_16352_16387(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 16352, 16387);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_509_16485_16507(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.TypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 16485, 16507);
                    return return_v;
                }


                Microsoft.Cci.INamespaceTypeReference?
                f_509_16545_16583(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNamespaceTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 16545, 16583);
                    return return_v;
                }


                Microsoft.Cci.ISpecializedNestedTypeReference?
                f_509_16696_16749_M(Microsoft.Cci.ISpecializedNestedTypeReference?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 16696, 16749);
                    return return_v;
                }


                Microsoft.Cci.INestedTypeReference
                f_509_16908_16971(Microsoft.Cci.ISpecializedNestedTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetUnspecializedVersion(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 16908, 16971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IReferenceOrISignature
                f_509_17019_17079(Microsoft.Cci.INestedTypeReference
                item)
                {
                    var return_v = new Microsoft.CodeAnalysis.IReferenceOrISignature((Microsoft.Cci.IReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 17019, 17079);
                    return return_v;
                }


                bool
                f_509_16998_17080(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IReferenceOrISignature>
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 16998, 17080);
                    return return_v;
                }


                int
                f_509_17130_17183(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.INestedTypeReference
                typeReference)
                {
                    this_param.RecordTypeReference((Microsoft.Cci.ITypeReference)typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 17130, 17183);
                    return 0;
                }


                Microsoft.CodeAnalysis.IReferenceOrISignature
                f_509_17303_17344(Microsoft.Cci.ITypeReference
                item)
                {
                    var return_v = new Microsoft.CodeAnalysis.IReferenceOrISignature((Microsoft.Cci.IReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 17303, 17344);
                    return return_v;
                }


                bool
                f_509_17282_17345(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IReferenceOrISignature>
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 17282, 17345);
                    return return_v;
                }


                int
                f_509_17387_17421(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.RecordTypeReference(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 17387, 17421);
                    return 0;
                }


                Microsoft.Cci.ISpecializedNestedTypeReference?
                f_509_17566_17612(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsSpecializedNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(509, 17566, 17612);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_509_17655_17701(Microsoft.Cci.INestedTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 17655, 17701);
                    return return_v;
                }


                int
                f_509_17644_17702(Microsoft.Cci.ReferenceIndexerBase
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(509, 17644, 17702);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(509, 15677, 18349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 15677, 18349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ReferenceIndexerBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(509, 469, 18356);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(509, 469, 18356);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(509, 469, 18356);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(509, 469, 18356);

        static Microsoft.CodeAnalysis.Emit.EmitContext
        f_509_834_841_C(Microsoft.CodeAnalysis.Emit.EmitContext
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(509, 763, 864);
            return return_v;
        }

    }
}
