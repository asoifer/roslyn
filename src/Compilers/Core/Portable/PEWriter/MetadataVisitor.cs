// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using Roslyn.Utilities;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.CodeGen;

namespace Microsoft.Cci
{
    internal abstract class MetadataVisitor
    {
        public readonly EmitContext Context;

        public MetadataVisitor(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(498, 683, 785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 751, 774);

                this.Context = context;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(498, 683, 785);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 683, 785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 683, 785);
            }
        }

        public virtual void Visit(IArrayTypeReference arrayTypeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 797, 953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 887, 942);

                f_498_887_941(this, f_498_898_940(arrayTypeReference, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 797, 953);

                Microsoft.Cci.ITypeReference
                f_498_898_940(Microsoft.Cci.IArrayTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetElementType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 898, 940);
                    return return_v;
                }


                int
                f_498_887_941(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 887, 941);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 797, 953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 797, 953);
            }
        }

        public void Visit(IEnumerable<IAssemblyReference> assemblyReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 965, 1232);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 1059, 1221);
                    foreach (IAssemblyReference assemblyReference in f_498_1108_1126_I(assemblyReferences))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 1059, 1221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 1160, 1206);

                        f_498_1160_1205(this, assemblyReference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 1059, 1221);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 163);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 965, 1232);

                int
                f_498_1160_1205(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IAssemblyReference
                unitReference)
                {
                    this_param.Visit((Microsoft.Cci.IUnitReference)unitReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 1160, 1205);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IAssemblyReference>
                f_498_1108_1126_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IAssemblyReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 1108, 1126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 965, 1232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 965, 1232);
            }
        }

        public virtual void Visit(IAssemblyReference assemblyReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 1244, 1329);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 1244, 1329);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 1244, 1329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 1244, 1329);
            }
        }

        public void Visit(IEnumerable<ICustomAttribute> customAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 1341, 1580);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 1431, 1569);
                    foreach (ICustomAttribute customAttribute in f_498_1476_1492_I(customAttributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 1431, 1569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 1526, 1554);

                        f_498_1526_1553(this, customAttribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 1431, 1569);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 139);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 1341, 1580);

                int
                f_498_1526_1553(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ICustomAttribute
                customAttribute)
                {
                    this_param.Visit(customAttribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 1526, 1553);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_498_1476_1492_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 1476, 1492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 1341, 1580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 1341, 1580);
            }
        }

        public virtual void Visit(ICustomAttribute customAttribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 1592, 2047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 1676, 1770);

                IMethodReference
                constructor = f_498_1707_1769(customAttribute, Context, reportDiagnostics: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 1784, 1863) || true) && (constructor is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 1784, 1863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 1841, 1848);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 1784, 1863);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 1879, 1929);

                f_498_1879_1928(
                            this, f_498_1890_1927(customAttribute, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 1943, 1967);

                f_498_1943_1966(this, constructor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 1981, 2036);

                f_498_1981_2035(this, f_498_1992_2034(customAttribute, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 1592, 2047);

                Microsoft.Cci.IMethodReference
                f_498_1707_1769(Microsoft.Cci.ICustomAttribute
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context, bool
                reportDiagnostics)
                {
                    var return_v = this_param.Constructor(context, reportDiagnostics: reportDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 1707, 1769);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataExpression>
                f_498_1890_1927(Microsoft.Cci.ICustomAttribute
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetArguments(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 1890, 1927);
                    return return_v;
                }


                int
                f_498_1879_1928(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataExpression>
                expressions)
                {
                    this_param.Visit((System.Collections.Generic.IEnumerable<Microsoft.Cci.IMetadataExpression>)expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 1879, 1928);
                    return 0;
                }


                int
                f_498_1943_1966(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    this_param.Visit(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 1943, 1966);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataNamedArgument>
                f_498_1992_2034(Microsoft.Cci.ICustomAttribute
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetNamedArguments(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 1992, 2034);
                    return return_v;
                }


                int
                f_498_1981_2035(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataNamedArgument>
                namedArguments)
                {
                    this_param.Visit((System.Collections.Generic.IEnumerable<Microsoft.Cci.IMetadataNamedArgument>)namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 1981, 2035);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 1592, 2047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 1592, 2047);
            }
        }

        public void Visit(ImmutableArray<ICustomModifier> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 2059, 2295);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 2150, 2284);
                    foreach (ICustomModifier customModifier in f_498_2193_2208_I(customModifiers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 2150, 2284);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 2242, 2269);

                        f_498_2242_2268(this, customModifier);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 2150, 2284);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 135);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 2059, 2295);

                int
                f_498_2242_2268(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ICustomModifier
                customModifier)
                {
                    this_param.Visit(customModifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 2242, 2268);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_498_2193_2208_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 2193, 2208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 2059, 2295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 2059, 2295);
            }
        }

        public virtual void Visit(ICustomModifier customModifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 2307, 2448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 2389, 2437);

                f_498_2389_2436(this, f_498_2400_2435(customModifier, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 2307, 2448);

                Microsoft.Cci.ITypeReference
                f_498_2400_2435(Microsoft.Cci.ICustomModifier
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetModifier(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 2400, 2435);
                    return return_v;
                }


                int
                f_498_2389_2436(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 2389, 2436);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 2307, 2448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 2307, 2448);
            }
        }

        public void Visit(IEnumerable<IEventDefinition> events)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 2460, 2688);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 2540, 2677);
                    foreach (IEventDefinition eventDef in f_498_2578_2584_I(events))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 2540, 2677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 2618, 2662);

                        f_498_2618_2661(this, eventDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 2540, 2677);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 138);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 2460, 2688);

                int
                f_498_2618_2661(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IEventDefinition
                typeMember)
                {
                    this_param.Visit((Microsoft.Cci.ITypeDefinitionMember)typeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 2618, 2661);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
                f_498_2578_2584_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 2578, 2584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 2460, 2688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 2460, 2688);
            }
        }

        public virtual void Visit(IEventDefinition eventDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 2700, 2904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 2784, 2834);

                f_498_2784_2833(this, f_498_2795_2832(eventDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 2848, 2893);

                f_498_2848_2892(this, f_498_2859_2891(eventDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 2700, 2904);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                f_498_2795_2832(Microsoft.Cci.IEventDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAccessors(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 2795, 2832);
                    return return_v;
                }


                int
                f_498_2784_2833(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                methodReferences)
                {
                    this_param.Visit(methodReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 2784, 2833);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_498_2859_2891(Microsoft.Cci.IEventDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 2859, 2891);
                    return return_v;
                }


                int
                f_498_2848_2892(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 2848, 2892);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 2700, 2904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 2700, 2904);
            }
        }

        public void Visit(IEnumerable<IFieldDefinition> fields)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 2916, 3138);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 2996, 3127);
                    foreach (IFieldDefinition field in f_498_3031_3037_I(fields))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 2996, 3127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 3071, 3112);

                        f_498_3071_3111(this, field);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 2996, 3127);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 2916, 3138);

                int
                f_498_3071_3111(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IFieldDefinition
                typeMember)
                {
                    this_param.Visit((Microsoft.Cci.ITypeDefinitionMember)typeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 3071, 3111);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                f_498_3031_3037_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 3031, 3037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 2916, 3138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 2916, 3138);
            }
        }

        public virtual void Visit(IFieldDefinition fieldDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 3150, 4133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 3234, 3294);

                var
                constant = f_498_3249_3293(fieldDefinition, Context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 3308, 3365);

                var
                marshalling = f_498_3326_3364(fieldDefinition)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 3381, 3455);

                f_498_3381_3454((constant != null) == f_498_3416_3453(fieldDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 3469, 3606);

                f_498_3469_3605((marshalling != null || (DynAbs.Tracing.TraceSender.Expression_False(498, 3483, 3561) || f_498_3506_3561_M(!fieldDefinition.MarshallingDescriptor.IsDefaultOrEmpty))) == f_498_3566_3604(fieldDefinition));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 3622, 3733) || true) && (constant != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 3622, 3733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 3676, 3718);

                    f_498_3676_3717(this, constant);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 3622, 3733);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 3749, 4061) || true) && (marshalling != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 3749, 4061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 4022, 4046);

                    f_498_4022_4045(                // Note, we are not visiting MarshallingDescriptor. It is used only for 
                                                    // NoPia embedded/local types and VB Dev11 simply copies the bits without
                                                    // cracking them.
                                    this, marshalling);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 3749, 4061);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 4077, 4122);

                f_498_4077_4121(
                            this, f_498_4088_4120(fieldDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 3150, 4133);

                Microsoft.CodeAnalysis.CodeGen.MetadataConstant?
                f_498_3249_3293(Microsoft.Cci.IFieldDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetCompileTimeValue(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 3249, 3293);
                    return return_v;
                }


                Microsoft.Cci.IMarshallingInformation?
                f_498_3326_3364(Microsoft.Cci.IFieldDefinition
                this_param)
                {
                    var return_v = this_param.MarshallingInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 3326, 3364);
                    return return_v;
                }


                bool
                f_498_3416_3453(Microsoft.Cci.IFieldDefinition
                this_param)
                {
                    var return_v = this_param.IsCompileTimeConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 3416, 3453);
                    return return_v;
                }


                int
                f_498_3381_3454(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 3381, 3454);
                    return 0;
                }


                bool
                f_498_3506_3561_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 3506, 3561);
                    return return_v;
                }


                bool
                f_498_3566_3604(Microsoft.Cci.IFieldDefinition
                this_param)
                {
                    var return_v = this_param.IsMarshalledExplicitly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 3566, 3604);
                    return return_v;
                }


                int
                f_498_3469_3605(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 3469, 3605);
                    return 0;
                }


                int
                f_498_3676_3717(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                expression)
                {
                    this_param.Visit((Microsoft.Cci.IMetadataExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 3676, 3717);
                    return 0;
                }


                int
                f_498_4022_4045(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IMarshallingInformation
                marshallingInformation)
                {
                    this_param.Visit(marshallingInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 4022, 4045);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_498_4088_4120(Microsoft.Cci.IFieldDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 4088, 4120);
                    return return_v;
                }


                int
                f_498_4077_4121(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 4077, 4121);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 3150, 4133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 3150, 4133);
            }
        }

        public virtual void Visit(IFieldReference fieldReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 4145, 4287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 4227, 4276);

                f_498_4227_4275(this, fieldReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 4145, 4287);

                int
                f_498_4227_4275(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IFieldReference
                typeMemberReference)
                {
                    this_param.Visit((Microsoft.Cci.ITypeMemberReference)typeMemberReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 4227, 4275);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 4145, 4287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 4145, 4287);
            }
        }

        public void Visit(IEnumerable<IFileReference> fileReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 4299, 4526);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 4385, 4515);
                    foreach (IFileReference fileReference in f_498_4426_4440_I(fileReferences))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 4385, 4515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 4474, 4500);

                        f_498_4474_4499(this, fileReference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 4385, 4515);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 131);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 4299, 4526);

                int
                f_498_4474_4499(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IFileReference
                fileReference)
                {
                    this_param.Visit(fileReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 4474, 4499);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IFileReference>
                f_498_4426_4440_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IFileReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 4426, 4440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 4299, 4526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 4299, 4526);
            }
        }

        public virtual void Visit(IFileReference fileReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 4538, 4615);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 4538, 4615);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 4538, 4615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 4538, 4615);
            }
        }

        public virtual void Visit(IGenericMethodInstanceReference genericMethodInstanceReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 4627, 4738);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 4627, 4738);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 4627, 4738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 4627, 4738);
            }
        }

        public void Visit(IEnumerable<IGenericMethodParameter> genericParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 4750, 5026);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 4848, 5015);
                    foreach (IGenericMethodParameter genericParameter in f_498_4901_4918_I(genericParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 4848, 5015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 4952, 5000);

                        f_498_4952_4999(this, genericParameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 4848, 5015);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 168);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 4750, 5026);

                int
                f_498_4952_4999(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IGenericMethodParameter
                genericParameter)
                {
                    this_param.Visit((Microsoft.Cci.IGenericParameter)genericParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 4952, 4999);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
                f_498_4901_4918_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 4901, 4918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 4750, 5026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 4750, 5026);
            }
        }

        public virtual void Visit(IGenericMethodParameter genericMethodParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 5038, 5133);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 5038, 5133);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 5038, 5133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 5038, 5133);
            }
        }

        public virtual void Visit(IGenericMethodParameterReference genericMethodParameterReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 5145, 5258);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 5145, 5258);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 5145, 5258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 5145, 5258);
            }
        }

        public virtual void Visit(IGenericParameter genericParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 5270, 5534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 5356, 5408);

                f_498_5356_5407(this, f_498_5367_5406(genericParameter, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 5422, 5475);

                f_498_5422_5474(this, f_498_5433_5473(genericParameter, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 5491, 5523);

                f_498_5491_5522(
                            genericParameter, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 5270, 5534);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_498_5367_5406(Microsoft.Cci.IGenericParameter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAttributes(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 5367, 5406);
                    return return_v;
                }


                int
                f_498_5356_5407(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 5356, 5407);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                f_498_5433_5473(Microsoft.Cci.IGenericParameter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetConstraints(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 5433, 5473);
                    return return_v;
                }


                int
                f_498_5422_5474(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                typeRefsWithAttributes)
                {
                    this_param.Visit(typeRefsWithAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 5422, 5474);
                    return 0;
                }


                int
                f_498_5491_5522(Microsoft.Cci.IGenericParameter
                this_param, Microsoft.Cci.MetadataVisitor
                visitor)
                {
                    this_param.Dispatch(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 5491, 5522);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 5270, 5534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 5270, 5534);
            }
        }

        public abstract void Visit(IGenericTypeInstanceReference genericTypeInstanceReference);

        public void Visit(IEnumerable<IGenericParameter> genericParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 5645, 5913);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 5737, 5902);
                    foreach (IGenericTypeParameter genericParameter in f_498_5788_5805_I(genericParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 5737, 5902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 5839, 5887);

                        f_498_5839_5886(this, genericParameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 5737, 5902);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 166);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 166);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 5645, 5913);

                int
                f_498_5839_5886(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IGenericTypeParameter
                genericParameter)
                {
                    this_param.Visit((Microsoft.Cci.IGenericParameter)genericParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 5839, 5886);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericParameter>
                f_498_5788_5805_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 5788, 5805);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 5645, 5913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 5645, 5913);
            }
        }

        public virtual void Visit(IGenericTypeParameter genericTypeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 5925, 6016);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 5925, 6016);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 5925, 6016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 5925, 6016);
            }
        }

        public virtual void Visit(IGenericTypeParameterReference genericTypeParameterReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 6028, 6137);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 6028, 6137);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 6028, 6137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 6028, 6137);
            }
        }

        public virtual void Visit(IGlobalFieldDefinition globalFieldDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 6149, 6308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 6245, 6297);

                f_498_6245_6296(this, globalFieldDefinition);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 6149, 6308);

                int
                f_498_6245_6296(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IGlobalFieldDefinition
                fieldDefinition)
                {
                    this_param.Visit((Microsoft.Cci.IFieldDefinition)fieldDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 6245, 6296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 6149, 6308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 6149, 6308);
            }
        }

        public virtual void Visit(IGlobalMethodDefinition globalMethodDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 6320, 6483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 6418, 6472);

                f_498_6418_6471(this, globalMethodDefinition);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 6320, 6483);

                int
                f_498_6418_6471(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IGlobalMethodDefinition
                method)
                {
                    this_param.Visit((Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 6418, 6471);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 6320, 6483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 6320, 6483);
            }
        }

        public void Visit(ImmutableArray<ILocalDefinition> localDefinitions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 6495, 6737);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 6588, 6726);
                    foreach (ILocalDefinition localDefinition in f_498_6633_6649_I(localDefinitions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 6588, 6726);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 6683, 6711);

                        f_498_6683_6710(this, localDefinition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 6588, 6726);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 139);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 6495, 6737);

                int
                f_498_6683_6710(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ILocalDefinition
                localDefinition)
                {
                    this_param.Visit(localDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 6683, 6710);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_498_6633_6649_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 6633, 6649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 6495, 6737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 6495, 6737);
            }
        }

        public virtual void Visit(ILocalDefinition localDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 6749, 6935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 6833, 6877);

                f_498_6833_6876(this, f_498_6844_6875(localDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 6891, 6924);

                f_498_6891_6923(this, f_498_6902_6922(localDefinition));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 6749, 6935);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_498_6844_6875(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 6844, 6875);
                    return return_v;
                }


                int
                f_498_6833_6876(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 6833, 6876);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_498_6902_6922(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 6902, 6922);
                    return return_v;
                }


                int
                f_498_6891_6923(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 6891, 6923);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 6749, 6935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 6749, 6935);
            }
        }

        public virtual void Visit(IMarshallingInformation marshallingInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 6947, 7093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 7045, 7082);

                throw f_498_7051_7081();
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 6947, 7093);

                System.Exception
                f_498_7051_7081()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 7051, 7081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 6947, 7093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 6947, 7093);
            }
        }

        public virtual void Visit(MetadataConstant constant)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 7105, 7179);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 7105, 7179);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 7105, 7179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 7105, 7179);
            }
        }

        public virtual void Visit(MetadataCreateArray createArray)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 7191, 7368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 7274, 7310);

                f_498_7274_7309(this, f_498_7285_7308(createArray));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 7324, 7357);

                f_498_7324_7356(this, f_498_7335_7355(createArray));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 7191, 7368);

                Microsoft.Cci.ITypeReference
                f_498_7285_7308(Microsoft.CodeAnalysis.CodeGen.MetadataCreateArray
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 7285, 7308);
                    return return_v;
                }


                int
                f_498_7274_7309(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 7274, 7309);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataExpression>
                f_498_7335_7355(Microsoft.CodeAnalysis.CodeGen.MetadataCreateArray
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 7335, 7355);
                    return return_v;
                }


                int
                f_498_7324_7356(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMetadataExpression>
                expressions)
                {
                    this_param.Visit((System.Collections.Generic.IEnumerable<Microsoft.Cci.IMetadataExpression>)expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 7324, 7356);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 7191, 7368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 7191, 7368);
            }
        }

        public void Visit(IEnumerable<IMetadataExpression> expressions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 7380, 7605);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 7468, 7594);
                    foreach (IMetadataExpression expression in f_498_7511_7522_I(expressions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 7468, 7594);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 7556, 7579);

                        f_498_7556_7578(this, expression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 7468, 7594);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 127);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 7380, 7605);

                int
                f_498_7556_7578(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IMetadataExpression
                expression)
                {
                    this_param.Visit(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 7556, 7578);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMetadataExpression>
                f_498_7511_7522_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMetadataExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 7511, 7522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 7380, 7605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 7380, 7605);
            }
        }

        public virtual void Visit(IMetadataExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 7617, 7778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 7699, 7727);

                f_498_7699_7726(this, f_498_7710_7725(expression));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 7741, 7767);

                f_498_7741_7766(expression, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 7617, 7778);

                Microsoft.Cci.ITypeReference
                f_498_7710_7725(Microsoft.Cci.IMetadataExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 7710, 7725);
                    return return_v;
                }


                int
                f_498_7699_7726(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 7699, 7726);
                    return 0;
                }


                int
                f_498_7741_7766(Microsoft.Cci.IMetadataExpression
                this_param, Microsoft.Cci.MetadataVisitor
                visitor)
                {
                    this_param.Dispatch(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 7741, 7766);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 7617, 7778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 7617, 7778);
            }
        }

        public void Visit(IEnumerable<IMetadataNamedArgument> namedArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 7790, 8054);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 7884, 8043);
                    foreach (IMetadataNamedArgument namedArgument in f_498_7933_7947_I(namedArguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 7884, 8043);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 7981, 8028);

                        f_498_7981_8027(this, namedArgument);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 7884, 8043);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 160);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 7790, 8054);

                int
                f_498_7981_8027(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IMetadataNamedArgument
                expression)
                {
                    this_param.Visit((Microsoft.Cci.IMetadataExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 7981, 8027);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMetadataNamedArgument>
                f_498_7933_7947_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMetadataNamedArgument>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 7933, 7947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 7790, 8054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 7790, 8054);
            }
        }

        public virtual void Visit(IMetadataNamedArgument namedArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 8066, 8205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 8154, 8194);

                f_498_8154_8193(this, f_498_8165_8192(namedArgument));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 8066, 8205);

                Microsoft.Cci.IMetadataExpression
                f_498_8165_8192(Microsoft.Cci.IMetadataNamedArgument
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 8165, 8192);
                    return return_v;
                }


                int
                f_498_8154_8193(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IMetadataExpression
                expression)
                {
                    this_param.Visit(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 8154, 8193);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 8066, 8205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 8066, 8205);
            }
        }

        public virtual void Visit(MetadataTypeOf typeOf)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 8217, 8407);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 8290, 8396) || true) && (f_498_8294_8310(typeOf) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 8290, 8396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 8352, 8381);

                    f_498_8352_8380(this, f_498_8363_8379(typeOf));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 8290, 8396);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 8217, 8407);

                Microsoft.Cci.ITypeReference
                f_498_8294_8310(Microsoft.CodeAnalysis.CodeGen.MetadataTypeOf
                this_param)
                {
                    var return_v = this_param.TypeToGet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 8294, 8310);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_498_8363_8379(Microsoft.CodeAnalysis.CodeGen.MetadataTypeOf
                this_param)
                {
                    var return_v = this_param.TypeToGet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 8363, 8379);
                    return return_v;
                }


                int
                f_498_8352_8380(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 8352, 8380);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 8217, 8407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 8217, 8407);
            }
        }

        public virtual void Visit(IMethodBody methodBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 8419, 8857);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 8493, 8614);
                    foreach (var scope in f_498_8515_8537_I(f_498_8515_8537(methodBody)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 8493, 8614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 8571, 8599);

                        f_498_8571_8598(this, scope.Constants);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 8493, 8614);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 122);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 8630, 8668);

                f_498_8630_8667(
                            this, f_498_8641_8666(methodBody));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 8806, 8846);

                f_498_8806_8845(            //this.Visit(methodBody.Operations);    //in Roslyn we don't break out each instruction as it's own operation.
                            this, f_498_8817_8844(methodBody));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 8419, 8857);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                f_498_8515_8537(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.LocalScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 8515, 8537);
                    return return_v;
                }


                int
                f_498_8571_8598(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                localDefinitions)
                {
                    this_param.Visit(localDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 8571, 8598);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                f_498_8515_8537_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 8515, 8537);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_498_8641_8666(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.LocalVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 8641, 8666);
                    return return_v;
                }


                int
                f_498_8630_8667(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                localDefinitions)
                {
                    this_param.Visit(localDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 8630, 8667);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                f_498_8817_8844(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.ExceptionRegions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 8817, 8844);
                    return return_v;
                }


                int
                f_498_8806_8845(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                exceptionRegions)
                {
                    this_param.Visit(exceptionRegions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 8806, 8845);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 8419, 8857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 8419, 8857);
            }
        }

        public void Visit(IEnumerable<IMethodDefinition> methods)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 8869, 9097);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 8951, 9086);
                    foreach (IMethodDefinition method in f_498_8988_8995_I(methods))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 8951, 9086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9029, 9071);

                        f_498_9029_9070(this, method);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 8951, 9086);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 136);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 8869, 9097);

                int
                f_498_9029_9070(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IMethodDefinition
                typeMember)
                {
                    this_param.Visit((Microsoft.Cci.ITypeDefinitionMember)typeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 9029, 9070);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                f_498_8988_8995_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 8988, 8995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 8869, 9097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 8869, 9097);
            }
        }

        public virtual void Visit(IMethodDefinition method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 9109, 9843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9185, 9238);

                f_498_9185_9237(this, f_498_9196_9236(method, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9252, 9290);

                f_498_9252_9289(this, f_498_9263_9288(method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9304, 9350);

                f_498_9304_9349(this, f_498_9315_9348(method));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9366, 9486) || true) && (f_498_9370_9399(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 9366, 9486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9433, 9471);

                    f_498_9433_9470(this, f_498_9444_9469(method));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 9366, 9486);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9502, 9608) || true) && (f_498_9506_9522(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 9502, 9608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9556, 9593);

                    f_498_9556_9592(this, f_498_9567_9591(method));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 9502, 9608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9624, 9660);

                f_498_9624_9659(
                            this, f_498_9635_9658(method, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9674, 9704);

                f_498_9674_9703(this, f_498_9685_9702(method));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9718, 9832) || true) && (f_498_9722_9745(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 9718, 9832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9779, 9817);

                    f_498_9779_9816(this, f_498_9790_9815(method));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 9718, 9832);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 9109, 9843);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_498_9196_9236(Microsoft.Cci.IMethodDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetReturnValueAttributes(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 9196, 9236);
                    return return_v;
                }


                int
                f_498_9185_9237(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 9185, 9237);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_498_9263_9288(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 9263, 9288);
                    return return_v;
                }


                int
                f_498_9252_9289(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 9252, 9289);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_498_9315_9348(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.ReturnValueCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 9315, 9348);
                    return return_v;
                }


                int
                f_498_9304_9349(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 9304, 9349);
                    return 0;
                }


                bool
                f_498_9370_9399(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.HasDeclarativeSecurity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 9370, 9399);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_498_9444_9469(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.SecurityAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 9444, 9469);
                    return return_v;
                }


                int
                f_498_9433_9470(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                securityAttributes)
                {
                    this_param.Visit(securityAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 9433, 9470);
                    return 0;
                }


                bool
                f_498_9506_9522(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.IsGeneric;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 9506, 9522);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
                f_498_9567_9591(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.GenericParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 9567, 9591);
                    return return_v;
                }


                int
                f_498_9556_9592(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
                genericParameters)
                {
                    this_param.Visit(genericParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 9556, 9592);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_498_9635_9658(Microsoft.Cci.IMethodDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 9635, 9658);
                    return return_v;
                }


                int
                f_498_9624_9659(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 9624, 9659);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                f_498_9685_9702(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 9685, 9702);
                    return return_v;
                }


                int
                f_498_9674_9703(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                parameters)
                {
                    this_param.Visit(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 9674, 9703);
                    return 0;
                }


                bool
                f_498_9722_9745(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.IsPlatformInvoke;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 9722, 9745);
                    return return_v;
                }


                Microsoft.Cci.IPlatformInvokeInformation
                f_498_9790_9815(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.PlatformInvokeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 9790, 9815);
                    return return_v;
                }


                int
                f_498_9779_9816(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IPlatformInvokeInformation
                platformInvokeInformation)
                {
                    this_param.Visit(platformInvokeInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 9779, 9816);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 9109, 9843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 9109, 9843);
            }
        }

        public void Visit(IEnumerable<MethodImplementation> methodImplementations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 9855, 10122);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 9954, 10111);
                    foreach (MethodImplementation methodImplementation in f_498_10008_10029_I(methodImplementations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 9954, 10111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 10063, 10096);

                        f_498_10063_10095(this, methodImplementation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 9954, 10111);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 158);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 9855, 10122);

                int
                f_498_10063_10095(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.MethodImplementation
                methodImplementation)
                {
                    this_param.Visit(methodImplementation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 10063, 10095);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
                f_498_10008_10029_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 10008, 10029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 9855, 10122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 9855, 10122);
            }
        }

        public virtual void Visit(MethodImplementation methodImplementation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 10134, 10355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 10227, 10278);

                f_498_10227_10277(this, methodImplementation.ImplementedMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 10292, 10344);

                f_498_10292_10343(this, methodImplementation.ImplementingMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 10134, 10355);

                int
                f_498_10227_10277(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    this_param.Visit(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 10227, 10277);
                    return 0;
                }


                int
                f_498_10292_10343(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IMethodDefinition
                method)
                {
                    this_param.Visit(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 10292, 10343);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 10134, 10355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 10134, 10355);
            }
        }

        public void Visit(IEnumerable<IMethodReference> methodReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 10367, 10606);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 10457, 10595);
                    foreach (IMethodReference methodReference in f_498_10502_10518_I(methodReferences))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 10457, 10595);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 10552, 10580);

                        f_498_10552_10579(this, methodReference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 10457, 10595);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 139);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 10367, 10606);

                int
                f_498_10552_10579(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IMethodReference
                methodReference)
                {
                    this_param.Visit(methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 10552, 10579);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                f_498_10502_10518_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 10502, 10518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 10367, 10606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 10367, 10606);
            }
        }

        public virtual void Visit(IMethodReference methodReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 10618, 11092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 10702, 10817);

                IGenericMethodInstanceReference?
                genericMethodInstanceReference = f_498_10768_10816(methodReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 10831, 11081) || true) && (genericMethodInstanceReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 10831, 11081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 10907, 10950);

                    f_498_10907_10949(this, genericMethodInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 10831, 11081);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 10831, 11081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 11016, 11066);

                    f_498_11016_11065(this, methodReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 10831, 11081);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 10618, 11092);

                Microsoft.Cci.IGenericMethodInstanceReference?
                f_498_10768_10816(Microsoft.Cci.IMethodReference
                this_param)
                {
                    var return_v = this_param.AsGenericMethodInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 10768, 10816);
                    return return_v;
                }


                int
                f_498_10907_10949(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IGenericMethodInstanceReference
                genericMethodInstanceReference)
                {
                    this_param.Visit(genericMethodInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 10907, 10949);
                    return 0;
                }


                int
                f_498_11016_11065(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IMethodReference
                typeMemberReference)
                {
                    this_param.Visit((Microsoft.Cci.ITypeMemberReference)typeMemberReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 11016, 11065);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 10618, 11092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 10618, 11092);
            }
        }

        public virtual void Visit(IModifiedTypeReference modifiedTypeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 11104, 11324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 11200, 11250);

                f_498_11200_11249(this, f_498_11211_11248(modifiedTypeReference));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 11264, 11313);

                f_498_11264_11312(this, f_498_11275_11311(modifiedTypeReference));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 11104, 11324);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_498_11211_11248(Microsoft.Cci.IModifiedTypeReference
                this_param)
                {
                    var return_v = this_param.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 11211, 11248);
                    return return_v;
                }


                int
                f_498_11200_11249(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 11200, 11249);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_498_11275_11311(Microsoft.Cci.IModifiedTypeReference
                this_param)
                {
                    var return_v = this_param.UnmodifiedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 11275, 11311);
                    return return_v;
                }


                int
                f_498_11264_11312(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 11264, 11312);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 11104, 11324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 11104, 11324);
            }
        }

        public abstract void Visit(CommonPEModuleBuilder module);

        public void Visit(IEnumerable<IModuleReference> moduleReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 11405, 11660);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 11495, 11649);
                    foreach (IModuleReference moduleReference in f_498_11540_11556_I(moduleReferences))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 11495, 11649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 11590, 11634);

                        f_498_11590_11633(this, moduleReference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 11495, 11649);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 155);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 11405, 11660);

                int
                f_498_11590_11633(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IModuleReference
                unitReference)
                {
                    this_param.Visit((Microsoft.Cci.IUnitReference)unitReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 11590, 11633);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IModuleReference>
                f_498_11540_11556_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IModuleReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 11540, 11556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 11405, 11660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 11405, 11660);
            }
        }

        public virtual void Visit(IModuleReference moduleReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 11672, 11753);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 11672, 11753);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 11672, 11753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 11672, 11753);
            }
        }

        public void Visit(IEnumerable<INamedTypeDefinition> types)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 11765, 11968);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 11848, 11957);
                    foreach (INamedTypeDefinition type in f_498_11886_11891_I(types))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 11848, 11957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 11925, 11942);

                        f_498_11925_11941(this, type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 11848, 11957);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 110);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 11765, 11968);

                int
                f_498_11925_11941(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.INamedTypeDefinition
                typeDefinition)
                {
                    this_param.Visit((Microsoft.Cci.ITypeDefinition)typeDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 11925, 11941);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamedTypeDefinition>
                f_498_11886_11891_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.INamedTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 11886, 11891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 11765, 11968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 11765, 11968);
            }
        }

        public virtual void Visit(INamespaceTypeDefinition namespaceTypeDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 11980, 12077);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 11980, 12077);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 11980, 12077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 11980, 12077);
            }
        }

        public virtual void Visit(INamespaceTypeReference namespaceTypeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 12089, 12184);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 12089, 12184);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 12089, 12184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 12089, 12184);
            }
        }

        public void VisitNestedTypes(IEnumerable<INamedTypeDefinition> nestedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 12196, 12435);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 12296, 12424);
                    foreach (ITypeDefinitionMember nestedType in f_498_12341_12352_I(nestedTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 12296, 12424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 12386, 12409);

                        f_498_12386_12408(this, nestedType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 12296, 12424);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 129);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 12196, 12435);

                int
                f_498_12386_12408(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeDefinitionMember
                typeMember)
                {
                    this_param.Visit(typeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 12386, 12408);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamedTypeDefinition>
                f_498_12341_12352_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.INamedTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 12341, 12352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 12196, 12435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 12196, 12435);
            }
        }

        public virtual void Visit(INestedTypeDefinition nestedTypeDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 12447, 12538);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 12447, 12538);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 12447, 12538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 12447, 12538);
            }
        }

        public virtual void Visit(INestedTypeReference nestedTypeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 12550, 12712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 12642, 12701);

                f_498_12642_12700(this, f_498_12653_12699(nestedTypeReference, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 12550, 12712);

                Microsoft.Cci.ITypeReference
                f_498_12653_12699(Microsoft.Cci.INestedTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 12653, 12699);
                    return return_v;
                }


                int
                f_498_12642_12700(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 12642, 12700);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 12550, 12712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 12550, 12712);
            }
        }

        public void Visit(ImmutableArray<ExceptionHandlerRegion> exceptionRegions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 12724, 12960);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 12823, 12949);
                    foreach (ExceptionHandlerRegion region in f_498_12865_12881_I(exceptionRegions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 12823, 12949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 12915, 12934);

                        f_498_12915_12933(this, region);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 12823, 12949);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 127);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 12724, 12960);

                int
                f_498_12915_12933(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ExceptionHandlerRegion
                exceptionRegion)
                {
                    this_param.Visit(exceptionRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 12915, 12933);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                f_498_12865_12881_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 12865, 12881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 12724, 12960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 12724, 12960);
            }
        }

        public virtual void Visit(ExceptionHandlerRegion exceptionRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 12972, 13237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 13062, 13112);

                var
                exceptionType = f_498_13082_13111(exceptionRegion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 13126, 13226) || true) && (exceptionType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 13126, 13226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 13185, 13211);

                    f_498_13185_13210(this, exceptionType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 13126, 13226);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 12972, 13237);

                Microsoft.Cci.ITypeReference?
                f_498_13082_13111(Microsoft.Cci.ExceptionHandlerRegion
                this_param)
                {
                    var return_v = this_param.ExceptionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 13082, 13111);
                    return return_v;
                }


                int
                f_498_13185_13210(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 13185, 13210);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 12972, 13237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 12972, 13237);
            }
        }

        public void Visit(ImmutableArray<IParameterDefinition> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 13249, 13475);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 13340, 13464);
                    foreach (IParameterDefinition parameter in f_498_13383_13393_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 13340, 13464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 13427, 13449);

                        f_498_13427_13448(this, parameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 13340, 13464);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 125);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 125);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 13249, 13475);

                int
                f_498_13427_13448(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IParameterDefinition
                parameterDefinition)
                {
                    this_param.Visit(parameterDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 13427, 13448);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                f_498_13383_13393_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 13383, 13393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 13249, 13475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 13249, 13475);
            }
        }

        public virtual void Visit(IParameterDefinition parameterDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 13487, 14630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 13579, 13640);

                var
                marshalling = f_498_13597_13639(parameterDefinition)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 13656, 13801);

                f_498_13656_13800((marshalling != null || (DynAbs.Tracing.TraceSender.Expression_False(498, 13670, 13752) || f_498_13693_13752_M(!parameterDefinition.MarshallingDescriptor.IsDefaultOrEmpty))) == f_498_13757_13799(parameterDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 13817, 13872);

                f_498_13817_13871(
                            this, f_498_13828_13870(parameterDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 13886, 13937);

                f_498_13886_13936(this, f_498_13897_13935(parameterDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 13951, 13999);

                f_498_13951_13998(this, f_498_13962_13997(parameterDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 14015, 14093);

                MetadataConstant?
                defaultValue = f_498_14048_14092(parameterDefinition, Context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 14107, 14226) || true) && (defaultValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 14107, 14226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 14165, 14211);

                    f_498_14165_14210(this, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 14107, 14226);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 14242, 14554) || true) && (marshalling != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 14242, 14554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 14515, 14539);

                    f_498_14515_14538(                // Note, we are not visiting MarshallingDescriptor. It is used only for 
                                                      // NoPia embedded/local types and VB Dev11 simply copies the bits without
                                                      // cracking them.
                                    this, marshalling);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 14242, 14554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 14570, 14619);

                f_498_14570_14618(
                            this, f_498_14581_14617(parameterDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 13487, 14630);

                Microsoft.Cci.IMarshallingInformation?
                f_498_13597_13639(Microsoft.Cci.IParameterDefinition
                this_param)
                {
                    var return_v = this_param.MarshallingInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 13597, 13639);
                    return return_v;
                }


                bool
                f_498_13693_13752_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 13693, 13752);
                    return return_v;
                }


                bool
                f_498_13757_13799(Microsoft.Cci.IParameterDefinition
                this_param)
                {
                    var return_v = this_param.IsMarshalledExplicitly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 13757, 13799);
                    return return_v;
                }


                int
                f_498_13656_13800(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 13656, 13800);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_498_13828_13870(Microsoft.Cci.IParameterDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAttributes(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 13828, 13870);
                    return return_v;
                }


                int
                f_498_13817_13871(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 13817, 13871);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_498_13897_13935(Microsoft.Cci.IParameterDefinition
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 13897, 13935);
                    return return_v;
                }


                int
                f_498_13886_13936(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 13886, 13936);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_498_13962_13997(Microsoft.Cci.IParameterDefinition
                this_param)
                {
                    var return_v = this_param.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 13962, 13997);
                    return return_v;
                }


                int
                f_498_13951_13998(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 13951, 13998);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant?
                f_498_14048_14092(Microsoft.Cci.IParameterDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetDefaultValue(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 14048, 14092);
                    return return_v;
                }


                int
                f_498_14165_14210(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                expression)
                {
                    this_param.Visit((Microsoft.Cci.IMetadataExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 14165, 14210);
                    return 0;
                }


                int
                f_498_14515_14538(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IMarshallingInformation
                marshallingInformation)
                {
                    this_param.Visit(marshallingInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 14515, 14538);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_498_14581_14617(Microsoft.Cci.IParameterDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 14581, 14617);
                    return return_v;
                }


                int
                f_498_14570_14618(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 14570, 14618);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 13487, 14630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 13487, 14630);
            }
        }

        public void Visit(ImmutableArray<IParameterTypeInformation> parameterTypeInformations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 14642, 14938);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 14753, 14927);
                    foreach (IParameterTypeInformation parameterTypeInformation in f_498_14816_14841_I(parameterTypeInformations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 14753, 14927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 14875, 14912);

                        f_498_14875_14911(this, parameterTypeInformation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 14753, 14927);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 175);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 14642, 14938);

                int
                f_498_14875_14911(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IParameterTypeInformation
                parameterTypeInformation)
                {
                    this_param.Visit(parameterTypeInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 14875, 14911);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_498_14816_14841_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 14816, 14841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 14642, 14938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 14642, 14938);
            }
        }

        public virtual void Visit(IParameterTypeInformation parameterTypeInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 14950, 15254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 15052, 15108);

                f_498_15052_15107(this, f_498_15063_15106(parameterTypeInformation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 15122, 15175);

                f_498_15122_15174(this, f_498_15133_15173(parameterTypeInformation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 15189, 15243);

                f_498_15189_15242(this, f_498_15200_15241(parameterTypeInformation, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 14950, 15254);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_498_15063_15106(Microsoft.Cci.IParameterTypeInformation
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 15063, 15106);
                    return return_v;
                }


                int
                f_498_15052_15107(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15052, 15107);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_498_15133_15173(Microsoft.Cci.IParameterTypeInformation
                this_param)
                {
                    var return_v = this_param.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 15133, 15173);
                    return return_v;
                }


                int
                f_498_15122_15174(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15122, 15174);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_498_15200_15241(Microsoft.Cci.IParameterTypeInformation
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15200, 15241);
                    return return_v;
                }


                int
                f_498_15189_15242(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15189, 15242);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 14950, 15254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 14950, 15254);
            }
        }

        public virtual void Visit(IPlatformInvokeInformation platformInvokeInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 15266, 15367);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 15266, 15367);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 15266, 15367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 15266, 15367);
            }
        }

        public virtual void Visit(IPointerTypeReference pointerTypeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 15379, 15540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 15473, 15529);

                f_498_15473_15528(this, f_498_15484_15527(pointerTypeReference, Context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 15379, 15540);

                Microsoft.Cci.ITypeReference
                f_498_15484_15527(Microsoft.Cci.IPointerTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetTargetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15484, 15527);
                    return return_v;
                }


                int
                f_498_15473_15528(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15473, 15528);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 15379, 15540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 15379, 15540);
            }
        }

        public virtual void Visit(IFunctionPointerTypeReference functionPointerTypeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 15552, 16083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 15662, 15732);

                f_498_15662_15731(this, f_498_15673_15730(f_498_15673_15711(functionPointerTypeReference)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 15746, 15824);

                f_498_15746_15823(this, f_498_15757_15822(f_498_15757_15795(functionPointerTypeReference)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 15838, 15906);

                f_498_15838_15905(this, f_498_15849_15904(f_498_15849_15887(functionPointerTypeReference), Context));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 15922, 16072);
                    foreach (var param in f_498_15944_16005_I(f_498_15944_16005(f_498_15944_15982(functionPointerTypeReference), Context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 15922, 16072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 16039, 16057);

                        f_498_16039_16056(this, param);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 15922, 16072);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 151);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 15552, 16083);

                Microsoft.Cci.ISignature
                f_498_15673_15711(Microsoft.Cci.IFunctionPointerTypeReference
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 15673, 15711);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_498_15673_15730(Microsoft.Cci.ISignature
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 15673, 15730);
                    return return_v;
                }


                int
                f_498_15662_15731(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15662, 15731);
                    return 0;
                }


                Microsoft.Cci.ISignature
                f_498_15757_15795(Microsoft.Cci.IFunctionPointerTypeReference
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 15757, 15795);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_498_15757_15822(Microsoft.Cci.ISignature
                this_param)
                {
                    var return_v = this_param.ReturnValueCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 15757, 15822);
                    return return_v;
                }


                int
                f_498_15746_15823(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    this_param.Visit(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15746, 15823);
                    return 0;
                }


                Microsoft.Cci.ISignature
                f_498_15849_15887(Microsoft.Cci.IFunctionPointerTypeReference
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 15849, 15887);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_498_15849_15904(Microsoft.Cci.ISignature
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15849, 15904);
                    return return_v;
                }


                int
                f_498_15838_15905(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15838, 15905);
                    return 0;
                }


                Microsoft.Cci.ISignature
                f_498_15944_15982(Microsoft.Cci.IFunctionPointerTypeReference
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 15944, 15982);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_498_15944_16005(Microsoft.Cci.ISignature
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetParameters(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15944, 16005);
                    return return_v;
                }


                int
                f_498_16039_16056(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IParameterTypeInformation
                parameterTypeInformation)
                {
                    this_param.Visit(parameterTypeInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 16039, 16056);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_498_15944_16005_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 15944, 16005);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 15552, 16083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 15552, 16083);
            }
        }

        public void Visit(IEnumerable<IPropertyDefinition> properties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 16095, 16337);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 16182, 16326);
                    foreach (IPropertyDefinition property in f_498_16223_16233_I(properties))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 16182, 16326);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 16267, 16311);

                        f_498_16267_16310(this, property);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 16182, 16326);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 145);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 16095, 16337);

                int
                f_498_16267_16310(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IPropertyDefinition
                typeMember)
                {
                    this_param.Visit((Microsoft.Cci.ITypeDefinitionMember)typeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 16267, 16310);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
                f_498_16223_16233_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 16223, 16233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 16095, 16337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 16095, 16337);
            }
        }

        public virtual void Visit(IPropertyDefinition propertyDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 16349, 16559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 16439, 16492);

                f_498_16439_16491(this, f_498_16450_16490(propertyDefinition, Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 16506, 16548);

                f_498_16506_16547(this, f_498_16517_16546(propertyDefinition));
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 16349, 16559);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                f_498_16450_16490(Microsoft.Cci.IPropertyDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAccessors(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 16450, 16490);
                    return return_v;
                }


                int
                f_498_16439_16491(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                methodReferences)
                {
                    this_param.Visit(methodReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 16439, 16491);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                f_498_16517_16546(Microsoft.Cci.IPropertyDefinition
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 16517, 16546);
                    return return_v;
                }


                int
                f_498_16506_16547(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                parameters)
                {
                    this_param.Visit(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 16506, 16547);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 16349, 16559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 16349, 16559);
            }
        }

        public void Visit(IEnumerable<ManagedResource> resources)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 16571, 16768);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 16653, 16757);
                    foreach (var resource in f_498_16678_16687_I(resources))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 16653, 16757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 16721, 16742);

                        f_498_16721_16741(this, resource);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 16653, 16757);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 16571, 16768);

                int
                f_498_16721_16741(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ManagedResource
                resource)
                {
                    this_param.Visit(resource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 16721, 16741);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ManagedResource>
                f_498_16678_16687_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.ManagedResource>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 16678, 16687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 16571, 16768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 16571, 16768);
            }
        }

        public virtual void Visit(ManagedResource resource)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 16780, 16853);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 16780, 16853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 16780, 16853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 16780, 16853);
            }
        }

        public virtual void Visit(SecurityAttribute securityAttribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 16865, 17003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 16952, 16992);

                f_498_16952_16991(this, securityAttribute.Attribute);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 16865, 17003);

                int
                f_498_16952_16991(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ICustomAttribute
                customAttribute)
                {
                    this_param.Visit(customAttribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 16952, 16991);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 16865, 17003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 16865, 17003);
            }
        }

        public void Visit(IEnumerable<SecurityAttribute> securityAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 17015, 17264);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 17108, 17253);
                    foreach (SecurityAttribute securityAttribute in f_498_17156_17174_I(securityAttributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 17108, 17253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 17208, 17238);

                        f_498_17208_17237(this, securityAttribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 17108, 17253);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 146);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 17015, 17264);

                int
                f_498_17208_17237(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.SecurityAttribute
                securityAttribute)
                {
                    this_param.Visit(securityAttribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 17208, 17237);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_498_17156_17174_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 17156, 17174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 17015, 17264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 17015, 17264);
            }
        }

        public void Visit(IEnumerable<ITypeDefinitionMember> typeMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 17276, 17505);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 17366, 17494);
                    foreach (ITypeDefinitionMember typeMember in f_498_17411_17422_I(typeMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 17366, 17494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 17456, 17479);

                        f_498_17456_17478(this, typeMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 17366, 17494);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 129);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 17276, 17505);

                int
                f_498_17456_17478(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeDefinitionMember
                typeMember)
                {
                    this_param.Visit(typeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 17456, 17478);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeDefinitionMember>
                f_498_17411_17422_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeDefinitionMember>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 17411, 17422);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 17276, 17505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 17276, 17505);
            }
        }

        public void Visit(IEnumerable<ITypeDefinition> types)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 17517, 17710);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 17595, 17699);
                    foreach (ITypeDefinition type in f_498_17628_17633_I(types))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 17595, 17699);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 17667, 17684);

                        f_498_17667_17683(this, type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 17595, 17699);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 17517, 17710);

                int
                f_498_17667_17683(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeDefinition
                typeDefinition)
                {
                    this_param.Visit(typeDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 17667, 17683);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeDefinition>
                f_498_17628_17633_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 17628, 17633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 17517, 17710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 17517, 17710);
            }
        }

        public abstract void Visit(ITypeDefinition typeDefinition);

        public virtual void Visit(ITypeDefinitionMember typeMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 17793, 18220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 17877, 17943);

                ITypeDefinition?
                nestedType = typeMember as INestedTypeDefinition
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 17957, 18209) || true) && (nestedType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 17957, 18209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 18013, 18036);

                    f_498_18013_18035(this, nestedType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 17957, 18209);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 17957, 18209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 18102, 18148);

                    f_498_18102_18147(this, f_498_18113_18146(typeMember, Context));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 18168, 18194);

                    f_498_18168_18193(
                                    typeMember, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 17957, 18209);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 17793, 18220);

                int
                f_498_18013_18035(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeDefinition
                typeDefinition)
                {
                    this_param.Visit(typeDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 18013, 18035);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_498_18113_18146(Microsoft.Cci.ITypeDefinitionMember
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAttributes(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 18113, 18146);
                    return return_v;
                }


                int
                f_498_18102_18147(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 18102, 18147);
                    return 0;
                }


                int
                f_498_18168_18193(Microsoft.Cci.ITypeDefinitionMember
                this_param, Microsoft.Cci.MetadataVisitor
                visitor)
                {
                    this_param.Dispatch(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 18168, 18193);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 17793, 18220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 17793, 18220);
            }
        }

        public virtual void Visit(ITypeMemberReference typeMemberReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 18232, 18594);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 18324, 18583) || true) && (f_498_18328_18369(typeMemberReference, Context) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 18324, 18583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 18411, 18466);

                    f_498_18411_18465(this, f_498_18422_18464(typeMemberReference, Context));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 18324, 18583);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 18232, 18594);

                Microsoft.Cci.IDefinition?
                f_498_18328_18369(Microsoft.Cci.ITypeMemberReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.AsDefinition(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 18328, 18369);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_498_18422_18464(Microsoft.Cci.ITypeMemberReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAttributes(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 18422, 18464);
                    return return_v;
                }


                int
                f_498_18411_18465(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit(customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 18411, 18465);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 18232, 18594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 18232, 18594);
            }
        }

        public void Visit(IEnumerable<ITypeReference> typeReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 18606, 18833);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 18692, 18822);
                    foreach (ITypeReference typeReference in f_498_18733_18747_I(typeReferences))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 18692, 18822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 18781, 18807);

                        f_498_18781_18806(this, typeReference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 18692, 18822);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 131);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 18606, 18833);

                int
                f_498_18781_18806(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 18781, 18806);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeReference>
                f_498_18733_18747_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 18733, 18747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 18606, 18833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 18606, 18833);
            }
        }

        public void Visit(IEnumerable<TypeReferenceWithAttributes> typeRefsWithAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 18845, 19177);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 18952, 19166);
                    foreach (var typeRefWithAttributes in f_498_18990_19012_I(typeRefsWithAttributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 18952, 19166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 19046, 19088);

                        f_498_19046_19087(this, typeRefWithAttributes.TypeRef);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 19106, 19151);

                        f_498_19106_19150(this, typeRefWithAttributes.Attributes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 18952, 19166);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 215);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 18845, 19177);

                int
                f_498_19046_19087(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.Visit(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 19046, 19087);
                    return 0;
                }


                int
                f_498_19106_19150(Microsoft.Cci.MetadataVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomAttribute>
                customAttributes)
                {
                    this_param.Visit((System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>)customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 19106, 19150);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                f_498_18990_19012_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 18990, 19012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 18845, 19177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 18845, 19177);
            }
        }

        public virtual void Visit(ITypeReference typeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 19189, 19320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 19269, 19309);

                f_498_19269_19308(this, typeReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 19189, 19320);

                int
                f_498_19269_19308(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    this_param.DispatchAsReference(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 19269, 19308);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 19189, 19320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 19189, 19320);
            }
        }

        protected void DispatchAsReference(ITypeReference typeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 19860, 22400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 19949, 20038);

                INamespaceTypeReference?
                namespaceTypeReference = f_498_19999_20037(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20052, 20195) || true) && (namespaceTypeReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 20052, 20195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20120, 20155);

                    f_498_20120_20154(this, namespaceTypeReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20173, 20180);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 20052, 20195);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20211, 20318);

                IGenericTypeInstanceReference?
                genericTypeInstanceReference = f_498_20273_20317(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20332, 20487) || true) && (genericTypeInstanceReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 20332, 20487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20406, 20447);

                    f_498_20406_20446(this, genericTypeInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20465, 20472);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 20332, 20487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20503, 20583);

                INestedTypeReference?
                nestedTypeReference = f_498_20547_20582(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20597, 20734) || true) && (nestedTypeReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 20597, 20734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20662, 20694);

                    f_498_20662_20693(this, nestedTypeReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20712, 20719);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 20597, 20734);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20750, 20829);

                IArrayTypeReference?
                arrayTypeReference = typeReference as IArrayTypeReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20843, 20978) || true) && (arrayTypeReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 20843, 20978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20907, 20938);

                    f_498_20907_20937(this, arrayTypeReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20956, 20963);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 20843, 20978);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 20994, 21104);

                IGenericTypeParameterReference?
                genericTypeParameterReference = f_498_21058_21103(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21118, 21275) || true) && (genericTypeParameterReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 21118, 21275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21193, 21235);

                    f_498_21193_21234(this, genericTypeParameterReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21253, 21260);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 21118, 21275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21291, 21407);

                IGenericMethodParameterReference?
                genericMethodParameterReference = f_498_21359_21406(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21421, 21582) || true) && (genericMethodParameterReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 21421, 21582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21498, 21542);

                    f_498_21498_21541(this, genericMethodParameterReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21560, 21567);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 21421, 21582);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21598, 21683);

                IPointerTypeReference?
                pointerTypeReference = typeReference as IPointerTypeReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21697, 21836) || true) && (pointerTypeReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 21697, 21836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21763, 21796);

                    f_498_21763_21795(this, pointerTypeReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21814, 21821);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 21697, 21836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21852, 21961);

                IFunctionPointerTypeReference?
                functionPointerTypeReference = typeReference as IFunctionPointerTypeReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 21975, 22130) || true) && (functionPointerTypeReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 21975, 22130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 22049, 22090);

                    f_498_22049_22089(this, functionPointerTypeReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 22108, 22115);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 21975, 22130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 22146, 22234);

                IModifiedTypeReference?
                modifiedTypeReference = typeReference as IModifiedTypeReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 22248, 22389) || true) && (modifiedTypeReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 22248, 22389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 22315, 22349);

                    f_498_22315_22348(this, modifiedTypeReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 22367, 22374);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 22248, 22389);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 19860, 22400);

                Microsoft.Cci.INamespaceTypeReference?
                f_498_19999_20037(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNamespaceTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 19999, 20037);
                    return return_v;
                }


                int
                f_498_20120_20154(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.INamespaceTypeReference
                namespaceTypeReference)
                {
                    this_param.Visit(namespaceTypeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 20120, 20154);
                    return 0;
                }


                Microsoft.Cci.IGenericTypeInstanceReference?
                f_498_20273_20317(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsGenericTypeInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 20273, 20317);
                    return return_v;
                }


                int
                f_498_20406_20446(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IGenericTypeInstanceReference
                genericTypeInstanceReference)
                {
                    this_param.Visit(genericTypeInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 20406, 20446);
                    return 0;
                }


                Microsoft.Cci.INestedTypeReference?
                f_498_20547_20582(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 20547, 20582);
                    return return_v;
                }


                int
                f_498_20662_20693(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.INestedTypeReference
                nestedTypeReference)
                {
                    this_param.Visit(nestedTypeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 20662, 20693);
                    return 0;
                }


                int
                f_498_20907_20937(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IArrayTypeReference
                arrayTypeReference)
                {
                    this_param.Visit(arrayTypeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 20907, 20937);
                    return 0;
                }


                Microsoft.Cci.IGenericTypeParameterReference?
                f_498_21058_21103(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsGenericTypeParameterReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 21058, 21103);
                    return return_v;
                }


                int
                f_498_21193_21234(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IGenericTypeParameterReference
                genericTypeParameterReference)
                {
                    this_param.Visit(genericTypeParameterReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 21193, 21234);
                    return 0;
                }


                Microsoft.Cci.IGenericMethodParameterReference?
                f_498_21359_21406(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsGenericMethodParameterReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(498, 21359, 21406);
                    return return_v;
                }


                int
                f_498_21498_21541(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IGenericMethodParameterReference
                genericMethodParameterReference)
                {
                    this_param.Visit(genericMethodParameterReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 21498, 21541);
                    return 0;
                }


                int
                f_498_21763_21795(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IPointerTypeReference
                pointerTypeReference)
                {
                    this_param.Visit(pointerTypeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 21763, 21795);
                    return 0;
                }


                int
                f_498_22049_22089(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IFunctionPointerTypeReference
                functionPointerTypeReference)
                {
                    this_param.Visit(functionPointerTypeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 22049, 22089);
                    return 0;
                }


                int
                f_498_22315_22348(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IModifiedTypeReference
                modifiedTypeReference)
                {
                    this_param.Visit(modifiedTypeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 22315, 22348);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 19860, 22400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 19860, 22400);
            }
        }

        public void Visit(IEnumerable<IUnitReference> unitReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 22412, 22639);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 22498, 22628);
                    foreach (IUnitReference unitReference in f_498_22539_22553_I(unitReferences))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 22498, 22628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 22587, 22613);

                        f_498_22587_22612(this, unitReference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(498, 22498, 22628);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(498, 1, 131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(498, 1, 131);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 22412, 22639);

                int
                f_498_22587_22612(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IUnitReference
                unitReference)
                {
                    this_param.Visit(unitReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 22587, 22612);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IUnitReference>
                f_498_22539_22553_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IUnitReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 22539, 22553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 22412, 22639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 22412, 22639);
            }
        }

        public virtual void Visit(IUnitReference unitReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 22651, 22782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 22731, 22771);

                f_498_22731_22770(this, unitReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 22651, 22782);

                int
                f_498_22731_22770(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IUnitReference
                unitReference)
                {
                    this_param.DispatchAsReference(unitReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 22731, 22770);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 22651, 22782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 22651, 22782);
            }
        }

        private void DispatchAsReference(IUnitReference unitReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 23280, 23830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 23367, 23443);

                IAssemblyReference?
                assemblyReference = unitReference as IAssemblyReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 23457, 23590) || true) && (assemblyReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 23457, 23590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 23520, 23550);

                    f_498_23520_23549(this, assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 23568, 23575);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 23457, 23590);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 23606, 23676);

                IModuleReference?
                moduleReference = unitReference as IModuleReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 23690, 23819) || true) && (moduleReference != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(498, 23690, 23819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 23751, 23779);

                    f_498_23751_23778(this, moduleReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(498, 23797, 23804);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(498, 23690, 23819);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 23280, 23830);

                int
                f_498_23520_23549(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IAssemblyReference
                assemblyReference)
                {
                    this_param.Visit(assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 23520, 23549);
                    return 0;
                }


                int
                f_498_23751_23778(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.IModuleReference
                moduleReference)
                {
                    this_param.Visit(moduleReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(498, 23751, 23778);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 23280, 23830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 23280, 23830);
            }
        }

        public virtual void Visit(IWin32Resource win32Resource)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(498, 23842, 23919);
                DynAbs.Tracing.TraceSender.TraceExitMethod(498, 23842, 23919);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(498, 23842, 23919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 23842, 23919);
            }
        }

        static MetadataVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(498, 579, 23926);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(498, 579, 23926);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(498, 579, 23926);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(498, 579, 23926);
    }
}

