// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Microsoft.DiaSymReader;

namespace Microsoft.Cci
{
    internal sealed class SymWriterMetadataProvider : ISymWriterMetadataProvider
    {
        private readonly MetadataWriter _writer;

        private int _lastTypeDef;

        private string _lastTypeDefName;

        private string _lastTypeDefNamespace;

        internal SymWriterMetadataProvider(MetadataWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(439, 649, 759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 503, 510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 535, 547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 573, 589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 615, 636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 731, 748);

                _writer = writer;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(439, 649, 759);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(439, 649, 759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(439, 649, 759);
            }
        }

        public bool TryGetTypeDefinitionInfo(int typeDefinitionToken, out string namespaceName, out string typeName, out TypeAttributes attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(439, 862, 2335);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1026, 1222) || true) && (typeDefinitionToken == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(439, 1026, 1222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1088, 1109);

                    namespaceName = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1127, 1143);

                    typeName = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1161, 1176);

                    attributes = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1194, 1207);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(439, 1026, 1222);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1298, 1365);

                ITypeDefinition
                t = f_439_1318_1364(_writer, typeDefinitionToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1379, 2207) || true) && (_lastTypeDef == typeDefinitionToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(439, 1379, 2207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1452, 1480);

                    typeName = _lastTypeDefName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1498, 1536);

                    namespaceName = _lastTypeDefNamespace;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(439, 1379, 2207);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(439, 1379, 2207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1602, 1667);

                    typeName = f_439_1613_1666(t);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1687, 1729);

                    INamespaceTypeDefinition
                    namespaceTypeDef
                    = default(INamespaceTypeDefinition);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1747, 2035) || true) && ((namespaceTypeDef = f_439_1771_1815(t, _writer.Context)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(439, 1747, 2035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1866, 1913);

                        namespaceName = f_439_1882_1912(namespaceTypeDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(439, 1747, 2035);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(439, 1747, 2035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 1995, 2016);

                        namespaceName = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(439, 1747, 2035);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 2055, 2090);

                    _lastTypeDef = typeDefinitionToken;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 2108, 2136);

                    _lastTypeDefName = typeName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 2154, 2192);

                    _lastTypeDefNamespace = namespaceName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(439, 1379, 2207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 2223, 2298);

                attributes = f_439_2236_2297(_writer, f_439_2262_2296(t, _writer.Context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 2312, 2324);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(439, 862, 2335);

                Microsoft.Cci.ITypeDefinition
                f_439_1318_1364(Microsoft.Cci.MetadataWriter
                this_param, int
                token)
                {
                    var return_v = this_param.GetTypeDefinition(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 1318, 1364);
                    return return_v;
                }


                string
                f_439_1613_1666(Microsoft.Cci.ITypeDefinition
                namedType)
                {
                    var return_v = MetadataWriter.GetMangledName((Microsoft.Cci.INamedTypeReference)namedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 1613, 1666);
                    return return_v;
                }


                Microsoft.Cci.INamespaceTypeDefinition?
                f_439_1771_1815(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.AsNamespaceTypeDefinition(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 1771, 1815);
                    return return_v;
                }


                string
                f_439_1882_1912(Microsoft.Cci.INamespaceTypeDefinition
                this_param)
                {
                    var return_v = this_param.NamespaceName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(439, 1882, 1912);
                    return return_v;
                }


                Microsoft.Cci.ITypeDefinition?
                f_439_2262_2296(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetResolvedType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 2262, 2296);
                    return return_v;
                }


                System.Reflection.TypeAttributes
                f_439_2236_2297(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeDefinition?
                typeDef)
                {
                    var return_v = this_param.GetTypeAttributes(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 2236, 2297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(439, 862, 2335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(439, 862, 2335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryGetMethodInfo(int methodDefinitionToken, out string methodName, out int declaringTypeToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(439, 2514, 2909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 2645, 2718);

                IMethodDefinition
                m = f_439_2667_2717(_writer, methodDefinitionToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 2732, 2752);

                methodName = f_439_2745_2751(m);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 2766, 2872);

                declaringTypeToken = f_439_2787_2871(f_439_2811_2870(_writer, f_439_2833_2869(m, _writer.Context)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 2886, 2898);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(439, 2514, 2909);

                Microsoft.Cci.IMethodDefinition
                f_439_2667_2717(Microsoft.Cci.MetadataWriter
                this_param, int
                token)
                {
                    var return_v = this_param.GetMethodDefinition(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 2667, 2717);
                    return return_v;
                }


                string?
                f_439_2745_2751(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(439, 2745, 2751);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_439_2833_2869(Microsoft.Cci.IMethodDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 2833, 2869);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_439_2811_2870(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.GetTypeHandle(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 2811, 2870);
                    return return_v;
                }


                int
                f_439_2787_2871(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = MetadataTokens.GetToken(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 2787, 2871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(439, 2514, 2909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(439, 2514, 2909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryGetEnclosingType(int nestedTypeToken, out int enclosingTypeToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(439, 2921, 3391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 3026, 3100);

                INestedTypeReference
                nt = f_439_3052_3099(_writer, nestedTypeToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 3114, 3231) || true) && (nt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(439, 3114, 3231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 3162, 3185);

                    enclosingTypeToken = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 3203, 3216);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(439, 3114, 3231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 3247, 3354);

                enclosingTypeToken = f_439_3268_3353(f_439_3292_3352(_writer, f_439_3314_3351(nt, _writer.Context)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(439, 3368, 3380);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(439, 2921, 3391);

                Microsoft.Cci.INestedTypeReference
                f_439_3052_3099(Microsoft.Cci.MetadataWriter
                this_param, int
                token)
                {
                    var return_v = this_param.GetNestedTypeReference(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 3052, 3099);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_439_3314_3351(Microsoft.Cci.INestedTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 3314, 3351);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_439_3292_3352(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.GetTypeHandle(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 3292, 3352);
                    return return_v;
                }


                int
                f_439_3268_3353(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = MetadataTokens.GetToken(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(439, 3268, 3353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(439, 2921, 3391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(439, 2921, 3391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymWriterMetadataProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(439, 378, 3398);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(439, 378, 3398);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(439, 378, 3398);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(439, 378, 3398);
    }
}
