// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.Cci
{
    internal sealed class CustomDebugInfoWriter
    {
        private MethodDefinitionHandle _methodWithModuleInfo;

        private IMethodBody _methodBodyWithModuleInfo;

        private MethodDefinitionHandle _previousMethodWithUsingInfo;

        private IMethodBody _previousMethodBodyWithUsingInfo;

        private readonly PdbWriter _pdbWriter;

        public CustomDebugInfoWriter(PdbWriter pdbWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(480, 982, 1136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 759, 784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 887, 919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 959, 969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 1056, 1088);

                f_480_1056_1087(pdbWriter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 1102, 1125);

                _pdbWriter = pdbWriter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(480, 982, 1136);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(480, 982, 1136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(480, 982, 1136);
            }
        }

        public bool ShouldForwardNamespaceScopes(EmitContext context, IMethodBody methodBody, MethodDefinitionHandle methodHandle, out IMethodDefinition forwardToMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(480, 1493, 2503);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 1679, 2308) || true) && (f_480_1683_1746(this, context, methodBody))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 1679, 2308);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 1981, 2261) || true) && (f_480_1985_2027(context.Module))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 1981, 2261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 2069, 2137);

                        forwardToMethod = f_480_2087_2136(_previousMethodBodyWithUsingInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(480, 1981, 2261);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 1981, 2261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 2219, 2242);

                        forwardToMethod = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(480, 1981, 2261);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 2281, 2293);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 1679, 2308);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 2324, 2370);

                _previousMethodBodyWithUsingInfo = methodBody;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 2384, 2428);

                _previousMethodWithUsingInfo = methodHandle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 2442, 2465);

                forwardToMethod = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 2479, 2492);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(480, 1493, 2503);

                bool
                f_480_1683_1746(Microsoft.Cci.CustomDebugInfoWriter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context, Microsoft.Cci.IMethodBody
                methodBody)
                {
                    var return_v = this_param.ShouldForwardToPreviousMethodWithUsingInfo(context, methodBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 1683, 1746);
                    return return_v;
                }


                bool
                f_480_1985_2027(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GenerateVisualBasicStylePdb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 1985, 2027);
                    return return_v;
                }


                Microsoft.Cci.IMethodDefinition
                f_480_2087_2136(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.MethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 2087, 2136);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(480, 1493, 2503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(480, 1493, 2503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public byte[] SerializeMethodDebugInfo(EmitContext context, IMethodBody methodBody, MethodDefinitionHandle methodHandle, bool emitEncInfo, bool suppressNewCustomDebugInfo, out bool emitExternNamespaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(480, 2515, 4899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 2742, 2771);

                emitExternNamespaces = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 3011, 3763) || true) && (_methodBodyWithModuleInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 3011, 3763);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 3478, 3748) || true) && (f_480_3482_3533(context.Module, context).Any())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 3478, 3748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 3581, 3618);

                        _methodWithModuleInfo = methodHandle;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 3640, 3679);

                        _methodBodyWithModuleInfo = methodBody;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 3701, 3729);

                        emitExternNamespaces = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(480, 3478, 3748);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 3011, 3763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 3779, 3831);

                var
                pooledBuilder = f_480_3799_3830()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 3845, 3901);

                var
                encoder = f_480_3859_3900(pooledBuilder)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 3917, 4311) || true) && (f_480_3921_3952(methodBody) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 3917, 4311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 3994, 4059);

                    encoder.AddStateMachineTypeName(f_480_4026_4057(methodBody));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 3917, 4311);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 3917, 4311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 4125, 4191);

                    f_480_4125_4190(this, ref encoder, context, methodBody);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 4211, 4296);

                    encoder.AddStateMachineHoistedLocalScopes(f_480_4253_4294(methodBody));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 3917, 4311);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 4327, 4775) || true) && (!suppressNewCustomDebugInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 4327, 4775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 4392, 4443);

                    f_480_4392_4442(ref encoder, methodBody);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 4461, 4513);

                    f_480_4461_4512(ref encoder, methodBody);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 4533, 4760) || true) && (emitEncInfo)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 4533, 4760);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 4590, 4659);

                        var
                        encMethodInfo = f_480_4610_4658(methodBody)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 4681, 4741);

                        f_480_4681_4740(ref encoder, encMethodInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(480, 4533, 4760);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 4327, 4775);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 4791, 4825);

                byte[]
                result = encoder.ToArray()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 4839, 4860);

                f_480_4839_4859(pooledBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 4874, 4888);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(480, 2515, 4899);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                f_480_3482_3533(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAssemblyReferenceAliases(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 3482, 3533);
                    return return_v;
                }


                Microsoft.Cci.PooledBlobBuilder
                f_480_3799_3830()
                {
                    var return_v = PooledBlobBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 3799, 3830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Debugging.CustomDebugInfoEncoder
                f_480_3859_3900(Microsoft.Cci.PooledBlobBuilder
                builder)
                {
                    var return_v = new Microsoft.CodeAnalysis.Debugging.CustomDebugInfoEncoder((System.Reflection.Metadata.BlobBuilder)builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 3859, 3900);
                    return return_v;
                }


                string
                f_480_3921_3952(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.StateMachineTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 3921, 3952);
                    return return_v;
                }


                string
                f_480_4026_4057(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.StateMachineTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 4026, 4057);
                    return return_v;
                }


                int
                f_480_4125_4190(Microsoft.Cci.CustomDebugInfoWriter
                this_param, ref Microsoft.CodeAnalysis.Debugging.CustomDebugInfoEncoder
                encoder, Microsoft.CodeAnalysis.Emit.EmitContext
                context, Microsoft.Cci.IMethodBody
                methodBody)
                {
                    this_param.SerializeNamespaceScopeMetadata(ref encoder, context, methodBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 4125, 4190);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                f_480_4253_4294(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.StateMachineHoistedLocalScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 4253, 4294);
                    return return_v;
                }


                int
                f_480_4392_4442(ref Microsoft.CodeAnalysis.Debugging.CustomDebugInfoEncoder
                encoder, Microsoft.Cci.IMethodBody
                methodBody)
                {
                    SerializeDynamicLocalInfo(ref encoder, methodBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 4392, 4442);
                    return 0;
                }


                int
                f_480_4461_4512(ref Microsoft.CodeAnalysis.Debugging.CustomDebugInfoEncoder
                encoder, Microsoft.Cci.IMethodBody
                methodBody)
                {
                    SerializeTupleElementNames(ref encoder, methodBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 4461, 4512);
                    return 0;
                }


                Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation
                f_480_4610_4658(Microsoft.Cci.IMethodBody
                methodBody)
                {
                    var return_v = MetadataWriter.GetEncMethodDebugInfo(methodBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 4610, 4658);
                    return return_v;
                }


                int
                f_480_4681_4740(ref Microsoft.CodeAnalysis.Debugging.CustomDebugInfoEncoder
                encoder, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation
                debugInfo)
                {
                    SerializeCustomDebugInformation(ref encoder, debugInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 4681, 4740);
                    return 0;
                }


                int
                f_480_4839_4859(Microsoft.Cci.PooledBlobBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 4839, 4859);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(480, 2515, 4899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(480, 2515, 4899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SerializeCustomDebugInformation(ref CustomDebugInfoEncoder encoder, EditAndContinueMethodDebugInformation debugInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(480, 4944, 5960);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 5366, 5653) || true) && (f_480_5370_5408_M(!debugInfo.LocalSlots.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 5366, 5653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 5442, 5638);

                    encoder.AddRecord(CustomDebugInfoKind.EditAndContinueLocalSlotMap, debugInfo, (info, builder) => info.SerializeLocalSlots(builder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 5366, 5653);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 5669, 5949) || true) && (f_480_5673_5708_M(!debugInfo.Lambdas.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 5669, 5949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 5742, 5934);

                    encoder.AddRecord(CustomDebugInfoKind.EditAndContinueLambdaMap, debugInfo, (info, builder) => info.SerializeLambdaMap(builder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 5669, 5949);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(480, 4944, 5960);

                bool
                f_480_5370_5408_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 5370, 5408);
                    return return_v;
                }


                bool
                f_480_5673_5708_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 5673, 5708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(480, 4944, 5960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(480, 4944, 5960);
            }
        }

        private static ArrayBuilder<T> GetLocalInfoToSerialize<T>(
                    IMethodBody methodBody,
                    Func<ILocalDefinition, bool> filter,
                    Func<LocalScope, ILocalDefinition, T> getInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(480, 5972, 7377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 6202, 6233);

                ArrayBuilder<T>
                builder = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 6249, 7335);
                    foreach (var currentScope in f_480_6278_6300_I(f_480_6278_6300(methodBody)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 6249, 7335);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 6334, 6805);
                            foreach (var local in f_480_6356_6378_I(currentScope.Variables))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 6334, 6805);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 6420, 6455);

                                f_480_6420_6454(f_480_6433_6448(local) >= 0);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 6477, 6786) || true) && (f_480_6481_6494(filter, local))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 6477, 6786);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 6544, 6688) || true) && (builder == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 6544, 6688);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 6621, 6661);

                                        builder = f_480_6631_6660();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(480, 6544, 6688);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 6714, 6763);

                                    f_480_6714_6762(builder, f_480_6726_6761(getInfo, default(LocalScope), local));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 6477, 6786);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(480, 6334, 6805);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(480, 1, 472);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(480, 1, 472);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 6825, 7320);
                            foreach (var localConstant in f_480_6855_6877_I(currentScope.Constants))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 6825, 7320);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 6919, 6961);

                                f_480_6919_6960(f_480_6932_6955(localConstant) < 0);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 6983, 7301) || true) && (f_480_6987_7008(filter, localConstant))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 6983, 7301);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7058, 7202) || true) && (builder == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 7058, 7202);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7135, 7175);

                                        builder = f_480_7145_7174();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(480, 7058, 7202);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7228, 7278);

                                    f_480_7228_7277(builder, f_480_7240_7276(getInfo, currentScope, localConstant));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 6983, 7301);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(480, 6825, 7320);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(480, 1, 496);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(480, 1, 496);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(480, 6249, 7335);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(480, 1, 1087);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(480, 1, 1087);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7351, 7366);

                return builder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(480, 5972, 7377);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                f_480_6278_6300(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.LocalScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 6278, 6300);
                    return return_v;
                }


                int
                f_480_6433_6448(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.SlotIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 6433, 6448);
                    return return_v;
                }


                int
                f_480_6420_6454(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 6420, 6454);
                    return 0;
                }


                bool
                f_480_6481_6494(System.Func<Microsoft.Cci.ILocalDefinition, bool>
                this_param, Microsoft.Cci.ILocalDefinition
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 6481, 6494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_480_6631_6660()
                {
                    var return_v = ArrayBuilder<T>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 6631, 6660);
                    return return_v;
                }


                T
                f_480_6726_6761(System.Func<Microsoft.Cci.LocalScope, Microsoft.Cci.ILocalDefinition, T>
                this_param, Microsoft.Cci.LocalScope
                arg1, Microsoft.Cci.ILocalDefinition
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 6726, 6761);
                    return return_v;
                }


                int
                f_480_6714_6762(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 6714, 6762);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_480_6356_6378_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 6356, 6378);
                    return return_v;
                }


                int
                f_480_6932_6955(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.SlotIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 6932, 6955);
                    return return_v;
                }


                int
                f_480_6919_6960(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 6919, 6960);
                    return 0;
                }


                bool
                f_480_6987_7008(System.Func<Microsoft.Cci.ILocalDefinition, bool>
                this_param, Microsoft.Cci.ILocalDefinition
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 6987, 7008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_480_7145_7174()
                {
                    var return_v = ArrayBuilder<T>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 7145, 7174);
                    return return_v;
                }


                T
                f_480_7240_7276(System.Func<Microsoft.Cci.LocalScope, Microsoft.Cci.ILocalDefinition, T>
                this_param, Microsoft.Cci.LocalScope
                arg1, Microsoft.Cci.ILocalDefinition
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 7240, 7276);
                    return return_v;
                }


                int
                f_480_7228_7277(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 7228, 7277);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_480_6855_6877_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 6855, 6877);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                f_480_6278_6300_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 6278, 6300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(480, 5972, 7377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(480, 5972, 7377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void SerializeDynamicLocalInfo(ref CustomDebugInfoEncoder encoder, IMethodBody methodBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(480, 7389, 8980);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7519, 7615) || true) && (f_480_7523_7559_M(!methodBody.HasDynamicLocalVariables))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 7519, 7615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7593, 7600);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 7519, 7615);
                }

                byte[] GetDynamicFlags(ILocalDefinition local)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(480, 7631, 8144);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7710, 7766);

                        var
                        dynamicTransformFlags = f_480_7738_7765(local)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7784, 7850);

                        var
                        flags = new byte[CustomDebugInfoEncoder.DynamicAttributeSize]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7877, 7882);
                            for (int
            k = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7868, 8096) || true) && (k < dynamicTransformFlags.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7918, 7921)
            , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(480, 7868, 8096))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 7868, 8096);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 7963, 8077) || true) && (dynamicTransformFlags[k])
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 7963, 8077);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 8041, 8054);

                                    flags[k] = 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 7963, 8077);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(480, 1, 229);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(480, 1, 229);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 8116, 8129);

                        return flags;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(480, 7631, 8144);

                        System.Collections.Immutable.ImmutableArray<bool>
                        f_480_7738_7765(Microsoft.Cci.ILocalDefinition
                        this_param)
                        {
                            var return_v = this_param.DynamicTransformFlags;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 7738, 7765);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(480, 7631, 8144);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(480, 7631, 8144);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 8160, 8781);

                var
                dynamicLocals = f_480_8180_8780(methodBody, local =>
                                {
                                    var dynamicTransformFlags = local.DynamicTransformFlags;
                                    return !dynamicTransformFlags.IsEmpty &&
                                        dynamicTransformFlags.Length <= CustomDebugInfoEncoder.DynamicAttributeSize &&
                                        local.Name.Length < CustomDebugInfoEncoder.IdentifierSize;
                                }, (scope, local) => (local.Name, GetDynamicFlags(local), local.DynamicTransformFlags.Length, (local.SlotIndex < 0) ? 0 : local.SlotIndex))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 8797, 8878) || true) && (dynamicLocals == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 8797, 8878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 8856, 8863);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 8797, 8878);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 8894, 8934);

                encoder.AddDynamicLocals(dynamicLocals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 8948, 8969);

                f_480_8948_8968(dynamicLocals);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(480, 7389, 8980);

                bool
                f_480_7523_7559_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 7523, 7559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(string? Name, byte[], int Length, int)>
                f_480_8180_8780(Microsoft.Cci.IMethodBody
                methodBody, System.Func<Microsoft.Cci.ILocalDefinition, bool>
                filter, System.Func<Microsoft.Cci.LocalScope, Microsoft.Cci.ILocalDefinition, (string Name, byte[], int Length, int)>
                getInfo)
                {
                    var return_v = GetLocalInfoToSerialize(methodBody, filter, getInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 8180, 8780);
                    return return_v;
                }


                int
                f_480_8948_8968(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(string? Name, byte[], int Length, int)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 8948, 8968);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(480, 7389, 8980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(480, 7389, 8980);
            }
        }

        private static void SerializeTupleElementNames(ref CustomDebugInfoEncoder encoder, IMethodBody methodBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(480, 8992, 9561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 9123, 9377);

                var
                locals = f_480_9136_9376(methodBody, local => !local.TupleElementNames.IsEmpty, (scope, local) => (local.Name, local.SlotIndex, scope.StartOffset, scope.EndOffset, local.TupleElementNames))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 9393, 9467) || true) && (locals == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 9393, 9467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 9445, 9452);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 9393, 9467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 9483, 9520);

                encoder.AddTupleElementNames(locals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 9536, 9550);

                f_480_9536_9549(
                            locals);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(480, 8992, 9561);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(string? Name, int SlotIndex, int StartOffset, int EndOffset, System.Collections.Immutable.ImmutableArray<string> TupleElementNames)>
                f_480_9136_9376(Microsoft.Cci.IMethodBody
                methodBody, System.Func<Microsoft.Cci.ILocalDefinition, bool>
                filter, System.Func<Microsoft.Cci.LocalScope, Microsoft.Cci.ILocalDefinition, (string Name, int SlotIndex, int StartOffset, int EndOffset, System.Collections.Immutable.ImmutableArray<string> TupleElementNames)>
                getInfo)
                {
                    var return_v = GetLocalInfoToSerialize(methodBody, filter, getInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 9136, 9376);
                    return return_v;
                }


                int
                f_480_9536_9549(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(string? Name, int SlotIndex, int StartOffset, int EndOffset, System.Collections.Immutable.ImmutableArray<string> TupleElementNames)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 9536, 9549);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(480, 8992, 9561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(480, 8992, 9561);
            }
        }

        private void SerializeNamespaceScopeMetadata(ref CustomDebugInfoEncoder encoder, EmitContext context, IMethodBody methodBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(480, 9573, 10709);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 9723, 9825) || true) && (f_480_9727_9769(context.Module))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 9723, 9825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 9803, 9810);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 9723, 9825);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 9841, 10136) || true) && (f_480_9845_9908(this, context, methodBody))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 9841, 10136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 9942, 10019);

                    f_480_9942_10018(!f_480_9956_10017(_previousMethodBodyWithUsingInfo, methodBody));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10037, 10096);

                    encoder.AddForwardMethodInfo(_previousMethodWithUsingInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10114, 10121);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 9841, 10136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10152, 10202);

                var
                usingCounts = f_480_10170_10201()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10234, 10264);
                    for (IImportScope
        scope = f_480_10242_10264(methodBody)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10216, 10400) || true) && (scope != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10281, 10301)
        , scope = f_480_10289_10301(scope), DynAbs.Tracing.TraceSender.TraceExitCondition(480, 10216, 10400))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 10216, 10400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10335, 10385);

                        f_480_10335_10384(usingCounts, f_480_10351_10376(scope).Length);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(480, 1, 185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(480, 1, 185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10416, 10452);

                encoder.AddUsingGroups(usingCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10466, 10485);

                f_480_10466_10484(usingCounts);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10501, 10698) || true) && (_methodBodyWithModuleInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(480, 10505, 10597) && !f_480_10543_10597(_methodBodyWithModuleInfo, methodBody)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 10501, 10698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10631, 10683);

                    encoder.AddForwardModuleInfo(_methodWithModuleInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 10501, 10698);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(480, 9573, 10709);

                bool
                f_480_9727_9769(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GenerateVisualBasicStylePdb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 9727, 9769);
                    return return_v;
                }


                bool
                f_480_9845_9908(Microsoft.Cci.CustomDebugInfoWriter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context, Microsoft.Cci.IMethodBody
                methodBody)
                {
                    var return_v = this_param.ShouldForwardToPreviousMethodWithUsingInfo(context, methodBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 9845, 9908);
                    return return_v;
                }


                bool
                f_480_9956_10017(Microsoft.Cci.IMethodBody
                objA, Microsoft.Cci.IMethodBody
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 9956, 10017);
                    return return_v;
                }


                int
                f_480_9942_10018(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 9942, 10018);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_480_10170_10201()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 10170, 10201);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_480_10242_10264(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.ImportScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 10242, 10264);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_480_10289_10301(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 10289, 10301);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_480_10351_10376(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.GetUsedNamespaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 10351, 10376);
                    return return_v;
                }


                int
                f_480_10335_10384(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 10335, 10384);
                    return 0;
                }


                int
                f_480_10466_10484(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 10466, 10484);
                    return 0;
                }


                bool
                f_480_10543_10597(Microsoft.Cci.IMethodBody
                objA, Microsoft.Cci.IMethodBody
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 10543, 10597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(480, 9573, 10709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(480, 9573, 10709);
            }
        }

        private bool ShouldForwardToPreviousMethodWithUsingInfo(EmitContext context, IMethodBody methodBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(480, 10721, 12515);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 10846, 11034) || true) && (_previousMethodBodyWithUsingInfo == null || (DynAbs.Tracing.TraceSender.Expression_False(480, 10850, 10972) || f_480_10911_10972(_previousMethodBodyWithUsingInfo, methodBody)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 10846, 11034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 11006, 11019);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 10846, 11034);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 11116, 11524) || true) && (f_480_11120_11162(context.Module))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 11116, 11524);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 11196, 11509) || true) && (f_480_11200_11316(_pdbWriter, f_480_11246_11315(f_480_11246_11295(_previousMethodBodyWithUsingInfo))) !=
                    f_480_11341_11435(_pdbWriter, f_480_11387_11434(f_480_11387_11414(methodBody))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 11196, 11509);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 11477, 11490);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(480, 11196, 11509);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 11116, 11524);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 11540, 11606);

                var
                previousScopes = f_480_11561_11605(_previousMethodBodyWithUsingInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 11726, 11831) || true) && (f_480_11730_11752(methodBody) == previousScopes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 11726, 11831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 11804, 11816);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(480, 11726, 11831);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 12101, 12133);

                var
                s1 = f_480_12110_12132(methodBody)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 12147, 12171);

                var
                s2 = previousScopes
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 12185, 12472) || true) && (s1 != null && (DynAbs.Tracing.TraceSender.Expression_True(480, 12192, 12216) && s2 != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 12185, 12472);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 12250, 12389) || true) && (!f_480_12255_12277(s1).SequenceEqual(f_480_12292_12314(s2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(480, 12250, 12389);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 12357, 12370);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(480, 12250, 12389);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 12409, 12424);

                        s1 = f_480_12414_12423(s1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 12442, 12457);

                        s2 = f_480_12447_12456(s2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(480, 12185, 12472);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(480, 12185, 12472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(480, 12185, 12472);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(480, 12488, 12504);

                return s1 == s2;
                DynAbs.Tracing.TraceSender.TraceExitMethod(480, 10721, 12515);

                bool
                f_480_10911_10972(Microsoft.Cci.IMethodBody
                objA, Microsoft.Cci.IMethodBody
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 10911, 10972);
                    return return_v;
                }


                bool
                f_480_11120_11162(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GenerateVisualBasicStylePdb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 11120, 11162);
                    return return_v;
                }


                Microsoft.Cci.IMethodDefinition
                f_480_11246_11295(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.MethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 11246, 11295);
                    return return_v;
                }


                Microsoft.Cci.INamespace
                f_480_11246_11315(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 11246, 11315);
                    return return_v;
                }


                string
                f_480_11200_11316(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.INamespace
                @namespace)
                {
                    var return_v = this_param.GetOrCreateSerializedNamespaceName(@namespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 11200, 11316);
                    return return_v;
                }


                Microsoft.Cci.IMethodDefinition
                f_480_11387_11414(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.MethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 11387, 11414);
                    return return_v;
                }


                Microsoft.Cci.INamespace
                f_480_11387_11434(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 11387, 11434);
                    return return_v;
                }


                string
                f_480_11341_11435(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.INamespace
                @namespace)
                {
                    var return_v = this_param.GetOrCreateSerializedNamespaceName(@namespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 11341, 11435);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_480_11561_11605(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.ImportScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 11561, 11605);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_480_11730_11752(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.ImportScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 11730, 11752);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_480_12110_12132(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.ImportScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 12110, 12132);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_480_12255_12277(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.GetUsedNamespaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 12255, 12277);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_480_12292_12314(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.GetUsedNamespaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 12292, 12314);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_480_12414_12423(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 12414, 12423);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_480_12447_12456(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(480, 12447, 12456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(480, 10721, 12515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(480, 10721, 12515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CustomDebugInfoWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(480, 616, 12522);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(480, 616, 12522);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(480, 616, 12522);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(480, 616, 12522);

        static int
        f_480_1056_1087(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(480, 1056, 1087);
            return 0;
        }

    }
}
