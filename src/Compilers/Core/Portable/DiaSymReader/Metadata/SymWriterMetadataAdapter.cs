// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;

namespace Microsoft.DiaSymReader
{
    internal sealed unsafe class SymWriterMetadataAdapter : MetadataAdapterBase
    {
        private readonly ISymWriterMetadataProvider _metadataProvider;

        public SymWriterMetadataAdapter(ISymWriterMetadataProvider metadataProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(742, 689, 891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 659, 676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 790, 829);

                f_742_790_828(metadataProvider != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 843, 880);

                _metadataProvider = metadataProvider;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(742, 689, 891);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(742, 689, 891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(742, 689, 891);
            }
        }

        public override int GetTokenFromSig(byte* voidPointerSig, int byteCountSig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(742, 903, 1251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 1222, 1240);

                return 0x11000000;
                DynAbs.Tracing.TraceSender.TraceExitMethod(742, 903, 1251);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(742, 903, 1251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(742, 903, 1251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetTypeDefProps(
                    int typeDef,
                    [Out] char* qualifiedName,
                    int qualifiedNameBufferLength,
                    [Out] int* qualifiedNameLength,
                    [Out] TypeAttributes* attributes,
                    [Out] int* baseType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(742, 1263, 2306);
                string namespaceName = default(string);
                string typeName = default(string);
                System.Reflection.TypeAttributes attrib = default(System.Reflection.TypeAttributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 1560, 1591);

                f_742_1560_1590(baseType == null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 1607, 1797) || true) && (!f_742_1612_1720(_metadataProvider, typeDef, out namespaceName, out typeName, out attrib))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(742, 1607, 1797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 1754, 1782);

                    return HResult.E_INVALIDARG;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(742, 1607, 1797);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 1813, 2151) || true) && (qualifiedNameLength != null || (DynAbs.Tracing.TraceSender.Expression_False(742, 1817, 1869) || qualifiedName != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(742, 1813, 2151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 1903, 2136);

                    f_742_1903_2135(qualifiedName, qualifiedNameBufferLength, qualifiedNameLength, namespaceName, typeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(742, 1813, 2151);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 2167, 2259) || true) && (attributes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(742, 2167, 2259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 2223, 2244);

                    *attributes = attrib;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(742, 2167, 2259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 2275, 2295);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(742, 1263, 2306);

                int
                f_742_1560_1590(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 1560, 1590);
                    return 0;
                }


                bool
                f_742_1612_1720(Microsoft.DiaSymReader.ISymWriterMetadataProvider
                this_param, int
                typeDefinitionToken, out string
                namespaceName, out string
                typeName, out System.Reflection.TypeAttributes
                attributes)
                {
                    var return_v = this_param.TryGetTypeDefinitionInfo(typeDefinitionToken, out namespaceName, out typeName, out attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 1612, 1720);
                    return return_v;
                }


                unsafe int
                f_742_1903_2135(char*
                qualifiedName, int
                qualifiedNameBufferLength, int*
                qualifiedNameLength, string
                namespaceStr, string
                nameStr)
                {
                    InteropUtilities.CopyQualifiedTypeName(qualifiedName, qualifiedNameBufferLength, qualifiedNameLength, namespaceStr, nameStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 1903, 2135);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(742, 1263, 2306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(742, 1263, 2306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetTypeRefProps(
                    int typeRef,
                    [Out] int* resolutionScope, // ModuleRef or AssemblyRef
                    [Out] char* qualifiedName,
                    int qualifiedNameBufferLength,
                    [Out] int* qualifiedNameLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(742, 2592, 2630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 2595, 2630);
                throw f_742_2601_2630(); DynAbs.Tracing.TraceSender.TraceExitMethod(742, 2592, 2630);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(742, 2592, 2630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(742, 2592, 2630);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.NotImplementedException
            f_742_2601_2630()
            {
                var return_v = new System.NotImplementedException();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 2601, 2630);
                return return_v;
            }

        }

        public override int GetNestedClassProps(int nestedClass, out int enclosingClass)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(742, 2643, 2869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 2748, 2858);

                // LAFHIS
                DynAbs.Tracing.TraceSender.Conditional_F1(742, 2755, 2825);
                return (((f_742_2755_2825(_metadataProvider, nestedClass, out enclosingClass) && 
                    DynAbs.Tracing.TraceSender.Conditional_F2(742, 2828, 2840)) || 
                    DynAbs.Tracing.TraceSender.Conditional_F3(742, 2843, 2857))) ? HResult.S_OK : HResult.E_FAIL;
                DynAbs.Tracing.TraceSender.TraceExitMethod(742, 2643, 2869);

                bool
                f_742_2755_2825(Microsoft.DiaSymReader.ISymWriterMetadataProvider
                this_param, int
                nestedTypeToken, out int
                enclosingTypeToken)
                {
                    var return_v = this_param.TryGetEnclosingType(nestedTypeToken, out enclosingTypeToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 2755, 2825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(742, 2643, 2869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(742, 2643, 2869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetMethodProps(
                    int methodDef,
                    [Out] int* declaringTypeDef,
                    [Out] char* name,
                    int nameBufferLength,
                    [Out] int* nameLength,
                    [Out] MethodAttributes* attributes,
                    [Out] byte** signature,
                    [Out] int* signatureLength,
                    [Out] int* relativeVirtualAddress,
                    [Out] MethodImplAttributes* implAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(742, 3240, 5205);
                string nameStr = default(string);
                int declaringTypeToken = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 3704, 3737);

                f_742_3704_3736(attributes == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 3751, 3783);

                f_742_3751_3782(signature == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 3797, 3835);

                f_742_3797_3834(signatureLength == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 3849, 3894);

                f_742_3849_3893(relativeVirtualAddress == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 3908, 3945);

                f_742_3908_3944(implAttributes == null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 3961, 4133) || true) && (!f_742_3966_4056(_metadataProvider, methodDef, out nameStr, out declaringTypeToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(742, 3961, 4133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4090, 4118);

                    return HResult.E_INVALIDARG;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(742, 3961, 4133);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4149, 5026) || true) && (name != null || (DynAbs.Tracing.TraceSender.Expression_False(742, 4153, 4187) || nameLength != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(742, 4149, 5026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4360, 4428);

                    int
                    adjustedLength = f_742_4381_4427(f_742_4390_4404(nameStr), nameBufferLength - 1)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4448, 4651) || true) && (nameLength != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(742, 4448, 4651);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4603, 4632);

                        *nameLength = adjustedLength;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(742, 4448, 4651);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4671, 5011) || true) && (name != null && (DynAbs.Tracing.TraceSender.Expression_True(742, 4675, 4711) && nameBufferLength > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(742, 4671, 5011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4753, 4770);

                        char*
                        dst = name
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4803, 4808);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4794, 4956) || true) && (i < adjustedLength)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4830, 4833)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(742, 4794, 4956))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(742, 4794, 4956);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4883, 4901);

                                *dst = f_742_4890_4900(nameStr, i);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4927, 4933);

                                dst++;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(742, 1, 163);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(742, 1, 163);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 4980, 4992);

                        *dst = '\0';
                        DynAbs.Tracing.TraceSender.TraceExitCondition(742, 4671, 5011);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(742, 4149, 5026);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 5042, 5158) || true) && (declaringTypeDef != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(742, 5042, 5158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 5104, 5143);

                    *declaringTypeDef = declaringTypeToken;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(742, 5042, 5158);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(742, 5174, 5194);

                return HResult.S_OK;
                DynAbs.Tracing.TraceSender.TraceExitMethod(742, 3240, 5205);

                int
                f_742_3704_3736(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 3704, 3736);
                    return 0;
                }


                int
                f_742_3751_3782(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 3751, 3782);
                    return 0;
                }


                int
                f_742_3797_3834(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 3797, 3834);
                    return 0;
                }


                int
                f_742_3849_3893(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 3849, 3893);
                    return 0;
                }


                int
                f_742_3908_3944(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 3908, 3944);
                    return 0;
                }


                bool
                f_742_3966_4056(Microsoft.DiaSymReader.ISymWriterMetadataProvider
                this_param, int
                methodDefinitionToken, out string
                methodName, out int
                declaringTypeToken)
                {
                    var return_v = this_param.TryGetMethodInfo(methodDefinitionToken, out methodName, out declaringTypeToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 3966, 4056);
                    return return_v;
                }


                int
                f_742_4390_4404(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(742, 4390, 4404);
                    return return_v;
                }


                int
                f_742_4381_4427(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 4381, 4427);
                    return return_v;
                }


                char
                f_742_4890_4900(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(742, 4890, 4900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(742, 3240, 5205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(742, 3240, 5205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymWriterMetadataAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(742, 523, 5212);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(742, 523, 5212);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(742, 523, 5212);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(742, 523, 5212);

        static int
        f_742_790_828(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(742, 790, 828);
            return 0;
        }

    }
}
