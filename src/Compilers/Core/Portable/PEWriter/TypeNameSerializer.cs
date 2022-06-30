// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using System.Text;
using System.Diagnostics;

namespace Microsoft.Cci
{
    internal static class TypeNameSerializer
    {
        internal static string GetSerializedTypeName(this ITypeReference typeReference, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(518, 522, 782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 647, 679);

                bool
                isAssemblyQualified = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 693, 771);

                return f_518_700_770(typeReference, context, ref isAssemblyQualified);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(518, 522, 782);

                string
                f_518_700_770(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context, ref bool
                isAssemblyQualified)
                {
                    var return_v = typeReference.GetSerializedTypeName(context, ref isAssemblyQualified);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 700, 770);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(518, 522, 782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(518, 522, 782);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetSerializedTypeName(this ITypeReference typeReference, EmitContext context, ref bool isAssemblyQualified)
        {
            var pooled = PooledStringBuilder.GetInstance();
            StringBuilder sb = pooled.Builder;
            IArrayTypeReference arrType = typeReference as IArrayTypeReference;
            if (arrType != null)
            {
                typeReference = arrType.GetElementType(context);
                bool isAssemQual = false;
                AppendSerializedTypeName(sb, typeReference, ref isAssemQual, context);
                if (arrType.IsSZArray)
                {
                    sb.Append("[]");
                }
                else
                {
                    sb.Append('[');
                    if (arrType.Rank == 1)
                    {
                        sb.Append('*');
                    }

                    sb.Append(',', (int)arrType.Rank - 1);

                    sb.Append(']');
                }

                goto done;
            }

            IPointerTypeReference pointer = typeReference as IPointerTypeReference;
            if (pointer != null)
            {
                typeReference = pointer.GetTargetType(context);
                bool isAssemQual = false;
                AppendSerializedTypeName(sb, typeReference, ref isAssemQual, context);
                sb.Append('*');
                goto done;
            }

            INamespaceTypeReference namespaceType = typeReference.AsNamespaceTypeReference;
            if (namespaceType != null)
            {
                var name = namespaceType.NamespaceName;
                if (name.Length != 0)
                {
                    sb.Append(name);
                    sb.Append('.');
                }

                sb.Append(GetMangledAndEscapedName(namespaceType));
                goto done;
            }


            if (typeReference.IsTypeSpecification())
            {
                ITypeReference uninstantiatedTypeReference = typeReference.GetUninstantiatedGenericType(context);

                ArrayBuilder<ITypeReference> consolidatedTypeArguments = ArrayBuilder<ITypeReference>.GetInstance();
                typeReference.GetConsolidatedTypeArguments(consolidatedTypeArguments, context);

                bool uninstantiatedTypeIsAssemblyQualified = false;
                sb.Append(GetSerializedTypeName(uninstantiatedTypeReference, context, ref uninstantiatedTypeIsAssemblyQualified));
                sb.Append('[');
                bool first = true;
                foreach (ITypeReference argument in consolidatedTypeArguments)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        sb.Append(',');
                    }

                    bool isAssemQual = true;
                    AppendSerializedTypeName(sb, argument, ref isAssemQual, context);
                }
                consolidatedTypeArguments.Free();

                sb.Append(']');
                goto done;
            }

            INestedTypeReference nestedType = typeReference.AsNestedTypeReference;
            if (nestedType != null)
            {
                bool nestedTypeIsAssemblyQualified = false;
                sb.Append(GetSerializedTypeName(nestedType.GetContainingType(context), context, ref nestedTypeIsAssemblyQualified));
                sb.Append('+');
                sb.Append(GetMangledAndEscapedName(nestedType));
                goto done;
            }

// TODO: error
done:
            if (isAssemblyQualified)
            {
                AppendAssemblyQualifierIfNecessary(sb, UnwrapTypeReference(typeReference, context), out isAssemblyQualified, context);
            }

            return pooled.ToStringAndFree();
        }

        private static void AppendSerializedTypeName(StringBuilder sb, ITypeReference type, ref bool isAssemQualified, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(518, 4807, 5289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 4963, 5043);

                string
                argTypeName = f_518_4984_5042(type, context, ref isAssemQualified)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5057, 5141) || true) && (isAssemQualified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 5057, 5141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5111, 5126);

                    f_518_5111_5125(sb, '[');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(518, 5057, 5141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5157, 5180);

                f_518_5157_5179(
                            sb, argTypeName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5194, 5278) || true) && (isAssemQualified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 5194, 5278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5248, 5263);

                    f_518_5248_5262(sb, ']');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(518, 5194, 5278);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(518, 4807, 5289);

                string
                f_518_4984_5042(Microsoft.Cci.ITypeReference
                typeReference, Microsoft.CodeAnalysis.Emit.EmitContext
                context, ref bool
                isAssemblyQualified)
                {
                    var return_v = typeReference.GetSerializedTypeName(context, ref isAssemblyQualified);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 4984, 5042);
                    return return_v;
                }


                System.Text.StringBuilder
                f_518_5111_5125(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 5111, 5125);
                    return return_v;
                }


                System.Text.StringBuilder
                f_518_5157_5179(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 5157, 5179);
                    return return_v;
                }


                System.Text.StringBuilder
                f_518_5248_5262(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 5248, 5262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(518, 4807, 5289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(518, 4807, 5289);
            }
        }

        private static void AppendAssemblyQualifierIfNecessary(StringBuilder sb, ITypeReference typeReference, out bool isAssemQualified, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(518, 5301, 7509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5476, 5546);

                INestedTypeReference
                nestedType = f_518_5510_5545(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5560, 5765) || true) && (nestedType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 5560, 5765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5616, 5725);

                    f_518_5616_5724(sb, f_518_5655_5692(nestedType, context), out isAssemQualified, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5743, 5750);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(518, 5560, 5765);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5781, 5866);

                IGenericTypeInstanceReference
                genInst = f_518_5821_5865(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5880, 6076) || true) && (genInst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 5880, 6076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 5933, 6036);

                    f_518_5933_6035(sb, f_518_5972_6003(genInst, context), out isAssemQualified, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6054, 6061);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(518, 5880, 6076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6092, 6159);

                IArrayTypeReference
                arrType = typeReference as IArrayTypeReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6173, 6369) || true) && (arrType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 6173, 6369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6226, 6329);

                    f_518_6226_6328(sb, f_518_6265_6296(arrType, context), out isAssemQualified, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6347, 6354);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(518, 6173, 6369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6385, 6456);

                IPointerTypeReference
                pointer = typeReference as IPointerTypeReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6470, 6665) || true) && (pointer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 6470, 6665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6523, 6625);

                    f_518_6523_6624(sb, f_518_6562_6592(pointer, context), out isAssemQualified, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6643, 6650);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(518, 6470, 6665);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6681, 6706);

                isAssemQualified = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6720, 6765);

                IAssemblyReference
                referencedAssembly = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6779, 6858);

                INamespaceTypeReference
                namespaceType = f_518_6819_6857(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6872, 7020) || true) && (namespaceType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 6872, 7020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 6931, 7005);

                    referencedAssembly = f_518_6952_6982(namespaceType, context) as IAssemblyReference;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(518, 6872, 7020);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7036, 7498) || true) && (referencedAssembly != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 7036, 7498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7100, 7171);

                    var
                    containingAssembly = f_518_7125_7170(context.Module, context)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7191, 7483) || true) && (containingAssembly == null || (DynAbs.Tracing.TraceSender.Expression_False(518, 7195, 7281) || !f_518_7226_7281(referencedAssembly, containingAssembly)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 7191, 7483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7323, 7339);

                        f_518_7323_7338(sb, ", ");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7361, 7418);

                        f_518_7361_7417(sb, f_518_7371_7416(referencedAssembly));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7440, 7464);

                        isAssemQualified = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(518, 7191, 7483);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(518, 7036, 7498);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(518, 5301, 7509);

                Microsoft.Cci.INestedTypeReference?
                f_518_5510_5545(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 5510, 5545);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_518_5655_5692(Microsoft.Cci.INestedTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 5655, 5692);
                    return return_v;
                }


                int
                f_518_5616_5724(System.Text.StringBuilder
                sb, Microsoft.Cci.ITypeReference
                typeReference, out bool
                isAssemQualified, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    AppendAssemblyQualifierIfNecessary(sb, typeReference, out isAssemQualified, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 5616, 5724);
                    return 0;
                }


                Microsoft.Cci.IGenericTypeInstanceReference?
                f_518_5821_5865(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsGenericTypeInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 5821, 5865);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_518_5972_6003(Microsoft.Cci.IGenericTypeInstanceReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetGenericType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 5972, 6003);
                    return return_v;
                }


                int
                f_518_5933_6035(System.Text.StringBuilder
                sb, Microsoft.Cci.INamedTypeReference
                typeReference, out bool
                isAssemQualified, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    AppendAssemblyQualifierIfNecessary(sb, (Microsoft.Cci.ITypeReference)typeReference, out isAssemQualified, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 5933, 6035);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_518_6265_6296(Microsoft.Cci.IArrayTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetElementType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 6265, 6296);
                    return return_v;
                }


                int
                f_518_6226_6328(System.Text.StringBuilder
                sb, Microsoft.Cci.ITypeReference
                typeReference, out bool
                isAssemQualified, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    AppendAssemblyQualifierIfNecessary(sb, typeReference, out isAssemQualified, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 6226, 6328);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_518_6562_6592(Microsoft.Cci.IPointerTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetTargetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 6562, 6592);
                    return return_v;
                }


                int
                f_518_6523_6624(System.Text.StringBuilder
                sb, Microsoft.Cci.ITypeReference
                typeReference, out bool
                isAssemQualified, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    AppendAssemblyQualifierIfNecessary(sb, typeReference, out isAssemQualified, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 6523, 6624);
                    return 0;
                }


                Microsoft.Cci.INamespaceTypeReference?
                f_518_6819_6857(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNamespaceTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 6819, 6857);
                    return return_v;
                }


                Microsoft.Cci.IUnitReference
                f_518_6952_6982(Microsoft.Cci.INamespaceTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetUnit(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 6952, 6982);
                    return return_v;
                }


                Microsoft.Cci.IAssemblyReference
                f_518_7125_7170(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingAssembly(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 7125, 7170);
                    return return_v;
                }


                bool
                f_518_7226_7281(Microsoft.Cci.IAssemblyReference
                objA, Microsoft.Cci.IAssemblyReference
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 7226, 7281);
                    return return_v;
                }


                System.Text.StringBuilder
                f_518_7323_7338(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 7323, 7338);
                    return return_v;
                }


                string
                f_518_7371_7416(Microsoft.Cci.IAssemblyReference
                assemblyReference)
                {
                    var return_v = MetadataWriter.StrongName(assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 7371, 7416);
                    return return_v;
                }


                System.Text.StringBuilder
                f_518_7361_7417(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 7361, 7417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(518, 5301, 7509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(518, 5301, 7509);
            }
        }

        private static string GetMangledAndEscapedName(INamedTypeReference namedType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(518, 7521, 8315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7623, 7670);

                var
                pooled = f_518_7636_7669()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7684, 7727);

                StringBuilder
                mangledName = pooled.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7743, 7785);

                const string
                needsEscaping = "\\[]*.+,& "
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7799, 8044);
                    foreach (var ch in f_518_7818_7832_I(f_518_7818_7832(namedType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 7799, 8044);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7866, 7986) || true) && (f_518_7870_7895(needsEscaping, ch) >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 7866, 7986);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 7942, 7967);

                            f_518_7942_7966(mangledName, '\\');
                            DynAbs.Tracing.TraceSender.TraceExitCondition(518, 7866, 7986);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8006, 8029);

                        f_518_8006_8028(
                                        mangledName, ch);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(518, 7799, 8044);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(518, 1, 246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(518, 1, 246);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8060, 8256) || true) && (f_518_8064_8084(namedType) && (DynAbs.Tracing.TraceSender.Expression_True(518, 8064, 8123) && f_518_8088_8119(namedType) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 8060, 8256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8157, 8241);

                    f_518_8157_8240(mangledName, f_518_8176_8239(f_518_8207_8238(namedType)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(518, 8060, 8256);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8272, 8304);

                return f_518_8279_8303(pooled);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(518, 7521, 8315);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_518_7636_7669()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 7636, 7669);
                    return return_v;
                }


                string?
                f_518_7818_7832(Microsoft.Cci.INamedTypeReference
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 7818, 7832);
                    return return_v;
                }


                int
                f_518_7870_7895(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 7870, 7895);
                    return return_v;
                }


                System.Text.StringBuilder
                f_518_7942_7966(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 7942, 7966);
                    return return_v;
                }


                System.Text.StringBuilder
                f_518_8006_8028(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 8006, 8028);
                    return return_v;
                }


                string?
                f_518_7818_7832_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 7818, 7832);
                    return return_v;
                }


                bool
                f_518_8064_8084(Microsoft.Cci.INamedTypeReference
                this_param)
                {
                    var return_v = this_param.MangleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 8064, 8084);
                    return return_v;
                }


                ushort
                f_518_8088_8119(Microsoft.Cci.INamedTypeReference
                this_param)
                {
                    var return_v = this_param.GenericParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 8088, 8119);
                    return return_v;
                }


                ushort
                f_518_8207_8238(Microsoft.Cci.INamedTypeReference
                this_param)
                {
                    var return_v = this_param.GenericParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 8207, 8238);
                    return return_v;
                }


                string
                f_518_8176_8239(ushort
                arity)
                {
                    var return_v = MetadataHelpers.GetAritySuffix((int)arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 8176, 8239);
                    return return_v;
                }


                System.Text.StringBuilder
                f_518_8157_8240(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 8157, 8240);
                    return return_v;
                }


                string
                f_518_8279_8303(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 8279, 8303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(518, 7521, 8315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(518, 7521, 8315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ITypeReference UnwrapTypeReference(ITypeReference typeReference, EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(518, 8415, 9163);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8540, 9152) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 8540, 9152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8585, 8652);

                        IArrayTypeReference
                        arrType = typeReference as IArrayTypeReference
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8670, 8829) || true) && (arrType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 8670, 8829);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8731, 8779);

                            typeReference = f_518_8747_8778(arrType, context);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8801, 8810);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(518, 8670, 8829);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8849, 8920);

                        IPointerTypeReference
                        pointer = typeReference as IPointerTypeReference
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8938, 9096) || true) && (pointer != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 8938, 9096);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 8999, 9046);

                            typeReference = f_518_9015_9045(pointer, context);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9068, 9077);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(518, 8938, 9096);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9116, 9137);

                        return typeReference;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(518, 8540, 9152);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(518, 8540, 9152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(518, 8540, 9152);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(518, 8415, 9163);

                Microsoft.Cci.ITypeReference
                f_518_8747_8778(Microsoft.Cci.IArrayTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetElementType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 8747, 8778);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_518_9015_9045(Microsoft.Cci.IPointerTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetTargetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 9015, 9045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(518, 8415, 9163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(518, 8415, 9163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string BuildQualifiedNamespaceName(INamespace @namespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(518, 9290, 10372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9388, 9421);

                f_518_9388_9420(@namespace != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9437, 9551) || true) && (f_518_9441_9471(@namespace) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 9437, 9551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9513, 9536);

                    return f_518_9520_9535(@namespace);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(518, 9437, 9551);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9567, 9622);

                var
                namesReversed = f_518_9587_9621()
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 9636, 9944);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9671, 9701);

                            string
                            name = f_518_9685_9700(@namespace)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9719, 9824) || true) && (f_518_9723_9734(name) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 9719, 9824);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9781, 9805);

                                f_518_9781_9804(namesReversed, name);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(518, 9719, 9824);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9844, 9888);

                            @namespace = f_518_9857_9887(@namespace);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(518, 9636, 9944);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9636, 9944) || true) && (@namespace != null)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(518, 9636, 9944);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(518, 9636, 9944);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 9960, 10007);

                var
                result = f_518_9973_10006()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 10032, 10059);

                    for (int
        i = f_518_10036_10055(namesReversed) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 10023, 10278) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 10069, 10072)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(518, 10023, 10278))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 10023, 10278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 10106, 10146);

                        f_518_10106_10145(result.Builder, f_518_10128_10144(namesReversed, i));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 10166, 10263) || true) && (i > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(518, 10166, 10263);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 10217, 10244);

                            f_518_10217_10243(result.Builder, '.');
                            DynAbs.Tracing.TraceSender.TraceExitCondition(518, 10166, 10263);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(518, 1, 256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(518, 1, 256);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 10294, 10315);

                f_518_10294_10314(
                            namesReversed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(518, 10329, 10361);

                return f_518_10336_10360(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(518, 9290, 10372);

                int
                f_518_9388_9420(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 9388, 9420);
                    return 0;
                }


                Microsoft.Cci.INamespace
                f_518_9441_9471(Microsoft.Cci.INamespace
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 9441, 9471);
                    return return_v;
                }


                string?
                f_518_9520_9535(Microsoft.Cci.INamespace
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 9520, 9535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_518_9587_9621()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 9587, 9621);
                    return return_v;
                }


                string?
                f_518_9685_9700(Microsoft.Cci.INamespace
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 9685, 9700);
                    return return_v;
                }


                int
                f_518_9723_9734(string?
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 9723, 9734);
                    return return_v;
                }


                int
                f_518_9781_9804(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 9781, 9804);
                    return 0;
                }


                Microsoft.Cci.INamespace
                f_518_9857_9887(Microsoft.Cci.INamespace
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 9857, 9887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_518_9973_10006()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 9973, 10006);
                    return return_v;
                }


                int
                f_518_10036_10055(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 10036, 10055);
                    return return_v;
                }


                string
                f_518_10128_10144(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(518, 10128, 10144);
                    return return_v;
                }


                System.Text.StringBuilder
                f_518_10106_10145(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 10106, 10145);
                    return return_v;
                }


                System.Text.StringBuilder
                f_518_10217_10243(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 10217, 10243);
                    return return_v;
                }


                int
                f_518_10294_10314(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 10294, 10314);
                    return 0;
                }


                string
                f_518_10336_10360(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(518, 10336, 10360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(518, 9290, 10372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(518, 9290, 10372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeNameSerializer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(518, 465, 10379);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(518, 465, 10379);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(518, 465, 10379);
        }

    }
}
