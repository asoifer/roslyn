// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.DiaSymReader;
using Roslyn.Utilities;

namespace Microsoft.Cci
{
    internal sealed class PdbWriter : IDisposable
    {
        internal const uint
        Age = 1
        ;

        private readonly HashAlgorithmName _hashAlgorithmNameOpt;

        private readonly string _fileName;

        private readonly Func<ISymWriterMetadataProvider, SymUnmanagedWriter> _symWriterFactory;

        private readonly Dictionary<DebugSourceDocument, int> _documentIndex;

        private MetadataWriter _metadataWriter;

        private SymUnmanagedWriter _symWriter;

        private SymUnmanagedSequencePointsWriter _sequencePointsWriter;

        private readonly Dictionary<object, string> _qualifiedNameCache;

        private bool IsDeterministic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 1472, 1509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 1475, 1509);
                    return _hashAlgorithmNameOpt.Name != null; DynAbs.Tracing.TraceSender.TraceExitMethod(438, 1472, 1509);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 1437, 1512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 1437, 1512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PdbWriter(string fileName, Func<ISymWriterMetadataProvider, SymUnmanagedWriter> symWriterFactory, HashAlgorithmName hashAlgorithmNameOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(438, 1526, 2014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 891, 900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 981, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 1063, 1077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 1111, 1126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 1164, 1174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 1226, 1247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 1367, 1386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 1695, 1716);

                _fileName = fileName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 1730, 1767);

                _symWriterFactory = symWriterFactory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 1781, 1826);

                _hashAlgorithmNameOpt = hashAlgorithmNameOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 1840, 1900);

                _documentIndex = f_438_1857_1899();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 1914, 2003);

                _qualifiedNameCache = f_438_1936_2002(ReferenceEqualityComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(438, 1526, 2014);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 1526, 2014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 1526, 2014);
            }
        }

        public void WriteTo(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 2026, 2123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 2085, 2112);

                f_438_2085_2111(_symWriter, stream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 2026, 2123);

                int
                f_438_2085_2111(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, System.IO.Stream
                stream)
                {
                    this_param.WriteTo(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 2085, 2111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 2026, 2123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 2026, 2123);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 2135, 2214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 2181, 2203);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_symWriter, 438, 2181, 2202)?.Dispose(), 438, 2192, 2202);
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 2135, 2214);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 2135, 2214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 2135, 2214);
            }
        }

        private CommonPEModuleBuilder Module
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 2263, 2280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 2266, 2280);
                    return f_438_2266_2273().Module; DynAbs.Tracing.TraceSender.TraceExitMethod(438, 2263, 2280);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 2263, 2280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 2263, 2280);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private EmitContext Context
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 2319, 2345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 2322, 2345);
                    return _metadataWriter.Context; DynAbs.Tracing.TraceSender.TraceExitMethod(438, 2319, 2345);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 2319, 2345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 2319, 2345);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void SerializeDebugInfo(IMethodBody methodBody, StandaloneSignatureHandle localSignatureHandleOpt, CustomDebugInfoWriter customDebugInfoWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 2358, 6628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 2533, 2571);

                f_438_2533_2570(_metadataWriter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 3155, 3218);

                bool
                isKickoffMethod = f_438_3178_3209(methodBody) != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 3232, 3422);

                bool
                emitDebugInfo = isKickoffMethod || (DynAbs.Tracing.TraceSender.Expression_False(438, 3253, 3306) || f_438_3272_3306_M(!methodBody.SequencePoints.IsEmpty)) || (DynAbs.Tracing.TraceSender.Expression_False(438, 3253, 3421) || f_438_3327_3354(methodBody) == (f_438_3359_3366().Module.DebugEntryPoint ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.IMethodReference>(438, 3359, 3420) ?? f_438_3393_3400().Module.PEEntryPoint)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 3438, 3512) || true) && (!emitDebugInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 3438, 3512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 3490, 3497);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 3438, 3512);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 3528, 3632);

                var
                methodHandle = (MethodDefinitionHandle)f_438_3571_3631(_metadataWriter, f_438_3603_3630(methodBody))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 3646, 3702);

                int
                methodToken = f_438_3664_3701(methodHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 3718, 3771);

                f_438_3718_3770(this, methodToken, f_438_3742_3769(methodBody));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 3787, 3828);

                var
                localScopes = f_438_3805_3827(methodBody)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 3953, 4092) || true) && (localScopes.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 3953, 4092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 4013, 4077);

                    f_438_4013_4076(this, localScopes[0], localSignatureHandleOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 3953, 4092);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 4108, 4860) || true) && (!isKickoffMethod && (DynAbs.Tracing.TraceSender.Expression_True(438, 4112, 4162) && f_438_4132_4154(methodBody) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 4108, 4860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 4196, 4230);

                    IMethodDefinition
                    forwardToMethod
                    = default(IMethodDefinition);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 4248, 4845) || true) && (f_438_4252_4358(customDebugInfoWriter, f_438_4303_4310(), methodBody, methodHandle, out forwardToMethod))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 4248, 4845);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 4400, 4625) || true) && (forwardToMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 4400, 4625);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 4477, 4602);

                            f_438_4477_4601(this, "@" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_438_4498_4571(f_438_4522_4570(_metadataWriter, forwardToMethod))).ToString(), 438, 4498, 4571), f_438_4573_4600(methodBody));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 4400, 4625);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 4248, 4845);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 4248, 4845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 4787, 4826);

                        f_438_4787_4825(this, methodBody);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 4248, 4845);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 4108, 4860);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 4876, 4932);

                f_438_4876_4931(this, localScopes, localSignatureHandleOpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 4946, 4992);

                f_438_4946_4991(this, f_438_4965_4990(methodBody));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 5008, 5491) || true) && (f_438_5012_5039(methodBody) is AsyncMoveNextBodyDebugInfo asyncMoveNextInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 5008, 5491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 5121, 5476);

                    f_438_5121_5475(_symWriter, methodToken, f_438_5201_5290(f_438_5225_5289(_metadataWriter, asyncMoveNextInfo.KickoffMethod)), asyncMoveNextInfo.CatchHandlerOffset, asyncMoveNextInfo.YieldOffsets.AsSpan(), asyncMoveNextInfo.ResumeOffsets.AsSpan());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 5008, 5491);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 5507, 5573);

                var
                compilationOptions = f_438_5532_5572(f_438_5532_5564(f_438_5532_5539().Module))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 5788, 5889);

                bool
                suppressNewCustomDebugInfo = f_438_5822_5851(compilationOptions) == OutputKind.WindowsRuntimeMetadata
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6015, 6109);

                bool
                emitEncInfo = f_438_6034_6074(compilationOptions) && (DynAbs.Tracing.TraceSender.Expression_True(438, 6034, 6108) && f_438_6078_6108(_metadataWriter))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6125, 6151);

                bool
                emitExternNamespaces
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6165, 6328);

                byte[]
                blob = f_438_6179_6327(customDebugInfoWriter, f_438_6226_6233(), methodBody, methodHandle, emitEncInfo, suppressNewCustomDebugInfo, out emitExternNamespaces)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6342, 6445) || true) && (blob != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 6342, 6445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6392, 6430);

                    f_438_6392_6429(_symWriter, blob);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 6342, 6445);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6461, 6567) || true) && (emitExternNamespaces)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 6461, 6567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6519, 6552);

                    f_438_6519_6551(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 6461, 6567);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6583, 6617);

                f_438_6583_6616(this, methodBody.IL.Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 2358, 6628);

                int
                f_438_2533_2570(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 2533, 2570);
                    return 0;
                }


                string
                f_438_3178_3209(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.StateMachineTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 3178, 3209);
                    return return_v;
                }


                bool
                f_438_3272_3306_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 3272, 3306);
                    return return_v;
                }


                Microsoft.Cci.IMethodDefinition
                f_438_3327_3354(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.MethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 3327, 3354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_438_3359_3366()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 3359, 3366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_438_3393_3400()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 3393, 3400);
                    return return_v;
                }


                Microsoft.Cci.IMethodDefinition
                f_438_3603_3630(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.MethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 3603, 3630);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_438_3571_3631(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodDefinition
                methodReference)
                {
                    var return_v = this_param.GetMethodHandle((Microsoft.Cci.IMethodReference)methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 3571, 3631);
                    return return_v;
                }


                int
                f_438_3664_3701(System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = MetadataTokens.GetToken((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 3664, 3701);
                    return return_v;
                }


                Microsoft.Cci.IMethodDefinition
                f_438_3742_3769(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.MethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 3742, 3769);
                    return return_v;
                }


                int
                f_438_3718_3770(Microsoft.Cci.PdbWriter
                this_param, int
                methodToken, Microsoft.Cci.IMethodDefinition
                method)
                {
                    this_param.OpenMethod(methodToken, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 3718, 3770);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                f_438_3805_3827(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.LocalScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 3805, 3827);
                    return return_v;
                }


                int
                f_438_4013_4076(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.LocalScope
                currentScope, System.Reflection.Metadata.StandaloneSignatureHandle
                localSignatureHandleOpt)
                {
                    this_param.DefineScopeLocals(currentScope, localSignatureHandleOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 4013, 4076);
                    return 0;
                }


                Microsoft.Cci.IImportScope
                f_438_4132_4154(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.ImportScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 4132, 4154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_438_4303_4310()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 4303, 4310);
                    return return_v;
                }


                bool
                f_438_4252_4358(Microsoft.Cci.CustomDebugInfoWriter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context, Microsoft.Cci.IMethodBody
                methodBody, System.Reflection.Metadata.MethodDefinitionHandle
                methodHandle, out Microsoft.Cci.IMethodDefinition
                forwardToMethod)
                {
                    var return_v = this_param.ShouldForwardNamespaceScopes(context, methodBody, methodHandle, out forwardToMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 4252, 4358);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_438_4522_4570(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodDefinition
                methodReference)
                {
                    var return_v = this_param.GetMethodHandle((Microsoft.Cci.IMethodReference)methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 4522, 4570);
                    return return_v;
                }


                int
                f_438_4498_4571(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = MetadataTokens.GetToken(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 4498, 4571);
                    return return_v;
                }


                Microsoft.Cci.IMethodDefinition
                f_438_4573_4600(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.MethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 4573, 4600);
                    return return_v;
                }


                int
                f_438_4477_4601(Microsoft.Cci.PdbWriter
                this_param, string
                fullName, Microsoft.Cci.IMethodDefinition
                errorEntity)
                {
                    this_param.UsingNamespace(fullName, (Microsoft.Cci.INamedEntity)errorEntity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 4477, 4601);
                    return 0;
                }


                int
                f_438_4787_4825(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.IMethodBody
                methodBody)
                {
                    this_param.DefineNamespaceScopes(methodBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 4787, 4825);
                    return 0;
                }


                int
                f_438_4876_4931(Microsoft.Cci.PdbWriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                scopes, System.Reflection.Metadata.StandaloneSignatureHandle
                localSignatureHandleOpt)
                {
                    this_param.DefineLocalScopes(scopes, localSignatureHandleOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 4876, 4931);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.SequencePoint>
                f_438_4965_4990(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.SequencePoints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 4965, 4990);
                    return return_v;
                }


                int
                f_438_4946_4991(Microsoft.Cci.PdbWriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.SequencePoint>
                sequencePoints)
                {
                    this_param.EmitSequencePoints(sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 4946, 4991);
                    return 0;
                }


                Microsoft.CodeAnalysis.Emit.StateMachineMoveNextBodyDebugInfo
                f_438_5012_5039(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.MoveNextBodyInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 5012, 5039);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_438_5225_5289(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodDefinition
                methodReference)
                {
                    var return_v = this_param.GetMethodHandle((Microsoft.Cci.IMethodReference)methodReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 5225, 5289);
                    return return_v;
                }


                int
                f_438_5201_5290(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = MetadataTokens.GetToken(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 5201, 5290);
                    return return_v;
                }


                int
                f_438_5121_5475(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, int
                moveNextMethodToken, int
                kickoffMethodToken, int
                catchHandlerOffset, System.ReadOnlySpan<int>
                yieldOffsets, System.ReadOnlySpan<int>
                resumeOffsets)
                {
                    this_param.SetAsyncInfo(moveNextMethodToken, kickoffMethodToken, catchHandlerOffset, yieldOffsets, resumeOffsets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 5121, 5475);
                    return 0;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_438_5532_5539()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 5532, 5539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_438_5532_5564(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 5532, 5564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_438_5532_5572(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 5532, 5572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_438_5822_5851(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 5822, 5851);
                    return return_v;
                }


                bool
                f_438_6034_6074(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.EnableEditAndContinue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 6034, 6074);
                    return return_v;
                }


                bool
                f_438_6078_6108(Microsoft.Cci.MetadataWriter
                this_param)
                {
                    var return_v = this_param.IsFullMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 6078, 6108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_438_6226_6233()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 6226, 6233);
                    return return_v;
                }


                byte[]
                f_438_6179_6327(Microsoft.Cci.CustomDebugInfoWriter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context, Microsoft.Cci.IMethodBody
                methodBody, System.Reflection.Metadata.MethodDefinitionHandle
                methodHandle, bool
                emitEncInfo, bool
                suppressNewCustomDebugInfo, out bool
                emitExternNamespaces)
                {
                    var return_v = this_param.SerializeMethodDebugInfo(context, methodBody, methodHandle, emitEncInfo, suppressNewCustomDebugInfo, out emitExternNamespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 6179, 6327);
                    return return_v;
                }


                int
                f_438_6392_6429(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, byte[]
                metadata)
                {
                    this_param.DefineCustomMetadata(metadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 6392, 6429);
                    return 0;
                }


                int
                f_438_6519_6551(Microsoft.Cci.PdbWriter
                this_param)
                {
                    this_param.DefineAssemblyReferenceAliases();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 6519, 6551);
                    return 0;
                }


                int
                f_438_6583_6616(Microsoft.Cci.PdbWriter
                this_param, int
                ilLength)
                {
                    this_param.CloseMethod(ilLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 6583, 6616);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 2358, 6628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 2358, 6628);
            }
        }

        private void DefineNamespaceScopes(IMethodBody methodBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 6640, 9719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6723, 6743);

                var
                module = f_438_6736_6742()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6757, 6813);

                bool
                isVisualBasic = f_438_6778_6812(module)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6829, 6884);

                IMethodDefinition
                method = f_438_6856_6883(methodBody)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6900, 6945);

                var
                namespaceScopes = f_438_6922_6944(methodBody)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 6961, 7016);

                PooledHashSet<string>
                lazyDeclaredExternAliases = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7030, 7926) || true) && (!isVisualBasic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 7030, 7926);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7091, 7114);
                        for (var
        scope = namespaceScopes
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7082, 7911) || true) && (scope != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7131, 7151)
        , scope = f_438_7139_7151(scope), DynAbs.Tracing.TraceSender.TraceExitCondition(438, 7082, 7911))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 7082, 7911);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7193, 7892);
                                foreach (var import in f_438_7216_7241_I(f_438_7216_7241(scope)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 7193, 7892);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7291, 7869) || true) && (import.TargetNamespaceOpt == null && (DynAbs.Tracing.TraceSender.Expression_True(438, 7295, 7360) && import.TargetTypeOpt == null))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 7291, 7869);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7418, 7456);

                                        f_438_7418_7455(import.AliasOpt != null);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7486, 7533);

                                        f_438_7486_7532(import.TargetAssemblyOpt == null);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7565, 7763) || true) && (lazyDeclaredExternAliases == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 7565, 7763);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7668, 7732);

                                            lazyDeclaredExternAliases = f_438_7696_7731();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 7565, 7763);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7795, 7842);

                                        f_438_7795_7841(
                                                                    lazyDeclaredExternAliases, import.AliasOpt);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 7291, 7869);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 7193, 7892);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 700);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 700);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 830);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 830);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 7030, 7926);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8001, 8024);

                    // file and namespace level
                    for (IImportScope
        scope = namespaceScopes
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 7983, 8484) || true) && (scope != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8041, 8061)
        , scope = f_438_8049_8061(scope), DynAbs.Tracing.TraceSender.TraceExitCondition(438, 7983, 8484))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 7983, 8484);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8095, 8469);
                            foreach (UsedNamespaceOrType import in f_438_8134_8159_I(f_438_8134_8159(scope)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 8095, 8469);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8201, 8294);

                                var
                                importString = f_438_8220_8293(this, import, lazyDeclaredExternAliases, isProjectLevel: false)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8316, 8450) || true) && (importString != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 8316, 8450);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8390, 8427);

                                    f_438_8390_8426(this, importString, method);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 8316, 8450);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(438, 8095, 8469);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 375);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 375);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 502);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8500, 8534);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(lazyDeclaredExternAliases, 438, 8500, 8533)?.Free(), 438, 8526, 8533);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8580, 9708) || true) && (isVisualBasic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 8580, 9708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8631, 8681);

                    string
                    defaultNamespace = f_438_8657_8680(module)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8701, 8929) || true) && (!f_438_8706_8744(defaultNamespace))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 8701, 8929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8863, 8910);

                        f_438_8863_8909(this, "*" + defaultNamespace, module);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 8701, 8929);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 8949, 9117);
                        foreach (string assemblyName in f_438_8981_9013_I(f_438_8981_9013(module)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 8949, 9117);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 9055, 9098);

                            f_438_9055_9097(this, "&" + assemblyName, module);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 8949, 9117);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 169);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 169);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 9137, 9483);
                        foreach (UsedNamespaceOrType import in f_438_9176_9195_I(f_438_9176_9195(module)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 9137, 9483);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 9237, 9308);

                            var
                            importString = f_438_9256_9307(this, import, null, isProjectLevel: true)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 9330, 9464) || true) && (importString != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 9330, 9464);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 9404, 9441);

                                f_438_9404_9440(this, importString, method);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(438, 9330, 9464);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 9137, 9483);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 347);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 347);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 9606, 9693);

                    f_438_9606_9692(this, f_438_9621_9683(this, f_438_9656_9682(method)), method);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 8580, 9708);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 6640, 9719);

                Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                f_438_6736_6742()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 6736, 6742);
                    return return_v;
                }


                bool
                f_438_6778_6812(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GenerateVisualBasicStylePdb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 6778, 6812);
                    return return_v;
                }


                Microsoft.Cci.IMethodDefinition
                f_438_6856_6883(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.MethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 6856, 6883);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_438_6922_6944(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.ImportScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 6922, 6944);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_438_7139_7151(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 7139, 7151);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_438_7216_7241(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.GetUsedNamespaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 7216, 7241);
                    return return_v;
                }


                int
                f_438_7418_7455(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 7418, 7455);
                    return 0;
                }


                int
                f_438_7486_7532(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 7486, 7532);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                f_438_7696_7731()
                {
                    var return_v = PooledHashSet<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 7696, 7731);
                    return return_v;
                }


                bool
                f_438_7795_7841(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 7795, 7841);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_438_7216_7241_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 7216, 7241);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_438_8049_8061(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 8049, 8061);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_438_8134_8159(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.GetUsedNamespaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 8134, 8159);
                    return return_v;
                }


                string
                f_438_8220_8293(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.UsedNamespaceOrType
                import, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>?
                declaredExternAliasesOpt, bool
                isProjectLevel)
                {
                    var return_v = this_param.TryEncodeImport(import, (System.Collections.Generic.HashSet<string>?)declaredExternAliasesOpt, isProjectLevel: isProjectLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 8220, 8293);
                    return return_v;
                }


                int
                f_438_8390_8426(Microsoft.Cci.PdbWriter
                this_param, string
                fullName, Microsoft.Cci.IMethodDefinition
                errorEntity)
                {
                    this_param.UsingNamespace(fullName, (Microsoft.Cci.INamedEntity)errorEntity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 8390, 8426);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_438_8134_8159_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 8134, 8159);
                    return return_v;
                }


                string
                f_438_8657_8680(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.DefaultNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 8657, 8680);
                    return return_v;
                }


                bool
                f_438_8706_8744(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 8706, 8744);
                    return return_v;
                }


                int
                f_438_8863_8909(Microsoft.Cci.PdbWriter
                this_param, string
                fullName, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                errorEntity)
                {
                    this_param.UsingNamespace(fullName, (Microsoft.Cci.INamedEntity)errorEntity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 8863, 8909);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_438_8981_9013(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.LinkedAssembliesDebugInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 8981, 9013);
                    return return_v;
                }


                int
                f_438_9055_9097(Microsoft.Cci.PdbWriter
                this_param, string
                fullName, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                errorEntity)
                {
                    this_param.UsingNamespace(fullName, (Microsoft.Cci.INamedEntity)errorEntity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 9055, 9097);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_438_8981_9013_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 8981, 9013);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_438_9176_9195(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetImports();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 9176, 9195);
                    return return_v;
                }


                string
                f_438_9256_9307(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.UsedNamespaceOrType
                import, System.Collections.Generic.HashSet<string>
                declaredExternAliasesOpt, bool
                isProjectLevel)
                {
                    var return_v = this_param.TryEncodeImport(import, declaredExternAliasesOpt, isProjectLevel: isProjectLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 9256, 9307);
                    return return_v;
                }


                int
                f_438_9404_9440(Microsoft.Cci.PdbWriter
                this_param, string
                fullName, Microsoft.Cci.IMethodDefinition
                errorEntity)
                {
                    this_param.UsingNamespace(fullName, (Microsoft.Cci.INamedEntity)errorEntity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 9404, 9440);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_438_9176_9195_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 9176, 9195);
                    return return_v;
                }


                Microsoft.Cci.INamespace
                f_438_9656_9682(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 9656, 9682);
                    return return_v;
                }


                string
                f_438_9621_9683(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.INamespace
                @namespace)
                {
                    var return_v = this_param.GetOrCreateSerializedNamespaceName(@namespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 9621, 9683);
                    return return_v;
                }


                int
                f_438_9606_9692(Microsoft.Cci.PdbWriter
                this_param, string
                fullName, Microsoft.Cci.IMethodDefinition
                errorEntity)
                {
                    this_param.UsingNamespace(fullName, (Microsoft.Cci.INamedEntity)errorEntity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 9606, 9692);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 6640, 9719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 6640, 9719);
            }
        }

        private void DefineAssemblyReferenceAliases()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 9731, 10035);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 9801, 10024);
                    foreach (AssemblyReferenceAlias alias in f_438_9842_9885_I(f_438_9842_9885(f_438_9842_9848(), f_438_9877_9884())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 9801, 10024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 9919, 10009);

                        f_438_9919_10008(this, "Z" + alias.Name + " " + f_438_9959_9999(f_438_9959_9982(alias.Assembly)), f_438_10001_10007());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 9801, 10024);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 224);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 9731, 10035);

                Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                f_438_9842_9848()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 9842, 9848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_438_9877_9884()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 9877, 9884);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                f_438_9842_9885(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAssemblyReferenceAliases(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 9842, 9885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_438_9959_9982(Microsoft.Cci.IAssemblyReference
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 9959, 9982);
                    return return_v;
                }


                string
                f_438_9959_9999(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 9959, 9999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                f_438_10001_10007()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 10001, 10007);
                    return return_v;
                }


                int
                f_438_9919_10008(Microsoft.Cci.PdbWriter
                this_param, string
                fullName, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                errorEntity)
                {
                    this_param.UsingNamespace(fullName, (Microsoft.Cci.INamedEntity)errorEntity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 9919, 10008);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                f_438_9842_9885_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 9842, 9885);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 9731, 10035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 9731, 10035);
            }
        }

        private string TryEncodeImport(UsedNamespaceOrType import, HashSet<string> declaredExternAliasesOpt, bool isProjectLevel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 10047, 13918);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 10377, 12357) || true) && (f_438_10381_10415(f_438_10381_10387()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 10377, 12357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 10503, 10550);

                    f_438_10503_10549(import.TargetAssemblyOpt == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 10568, 10615);

                    f_438_10568_10614(declaredExternAliasesOpt == null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 10635, 11535) || true) && (import.TargetTypeOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 10635, 11535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 10709, 10757);

                        f_438_10709_10756(import.TargetNamespaceOpt == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 10779, 10826);

                        f_438_10779_10825(import.TargetAssemblyOpt == null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 10939, 11070) || true) && (f_438_10943_10985(import.TargetTypeOpt))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 10939, 11070);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 11035, 11047);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 10939, 11070);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 11094, 11164);

                        string
                        typeName = f_438_11112_11163(this, import.TargetTypeOpt)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 11188, 11516) || true) && (import.AliasOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 11188, 11516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 11265, 11342);

                            return ((DynAbs.Tracing.TraceSender.Conditional_F1(438, 11273, 11287) || ((isProjectLevel && DynAbs.Tracing.TraceSender.Conditional_F2(438, 11290, 11296)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 11299, 11305))) ? "@PA:" : "@FA:") + import.AliasOpt + "=" + typeName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 11188, 11516);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 11188, 11516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 11440, 11493);

                            return ((DynAbs.Tracing.TraceSender.Conditional_F1(438, 11448, 11462) || ((isProjectLevel && DynAbs.Tracing.TraceSender.Conditional_F2(438, 11465, 11471)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 11474, 11480))) ? "@PT:" : "@FT:") + typeName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 11188, 11516);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 10635, 11535);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 11555, 12098) || true) && (import.TargetNamespaceOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 11555, 12098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 11634, 11719);

                        string
                        namespaceName = f_438_11657_11718(this, import.TargetNamespaceOpt)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 11743, 12079) || true) && (import.AliasOpt == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 11743, 12079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 11820, 11876);

                            return ((DynAbs.Tracing.TraceSender.Conditional_F1(438, 11828, 11842) || ((isProjectLevel && DynAbs.Tracing.TraceSender.Conditional_F2(438, 11845, 11850)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 11853, 11858))) ? "@P:" : "@F:") + namespaceName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 11743, 12079);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 11743, 12079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 11974, 12056);

                            return ((DynAbs.Tracing.TraceSender.Conditional_F1(438, 11982, 11996) || ((isProjectLevel && DynAbs.Tracing.TraceSender.Conditional_F2(438, 11999, 12005)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 12008, 12014))) ? "@PA:" : "@FA:") + import.AliasOpt + "=" + namespaceName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 11743, 12079);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 11555, 12098);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 12118, 12156);

                    f_438_12118_12155(import.AliasOpt != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 12174, 12225);

                    f_438_12174_12224(import.TargetXmlNamespaceOpt != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 12245, 12342);

                    return ((DynAbs.Tracing.TraceSender.Conditional_F1(438, 12253, 12267) || ((isProjectLevel && DynAbs.Tracing.TraceSender.Conditional_F2(438, 12270, 12276)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 12279, 12285))) ? "@PX:" : "@FX:") + import.AliasOpt + "=" + import.TargetXmlNamespaceOpt;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 10377, 12357);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 12373, 12424);

                f_438_12373_12423(import.TargetXmlNamespaceOpt == null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 12440, 12878) || true) && (import.TargetTypeOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 12440, 12878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 12506, 12554);

                    f_438_12506_12553(import.TargetNamespaceOpt == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 12572, 12619);

                    f_438_12572_12618(import.TargetAssemblyOpt == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 12639, 12709);

                    string
                    typeName = f_438_12657_12708(this, import.TargetTypeOpt)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 12729, 12863);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(438, 12736, 12761) || (((import.AliasOpt != null) && DynAbs.Tracing.TraceSender.Conditional_F2(438, 12785, 12824)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 12848, 12862))) ? "A" + import.AliasOpt + " T" + typeName : "T" + typeName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 12440, 12878);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 12894, 13749) || true) && (import.TargetNamespaceOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 12894, 13749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 12965, 13050);

                    string
                    namespaceName = f_438_12988_13049(this, import.TargetNamespaceOpt)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 13070, 13734) || true) && (import.AliasOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 13070, 13734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 13139, 13411);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(438, 13146, 13180) || (((import.TargetAssemblyOpt != null) && DynAbs.Tracing.TraceSender.Conditional_F2(438, 13208, 13338)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 13366, 13410))) ? "A" + import.AliasOpt + " E" + namespaceName + " " + f_438_13261_13338(this, import.TargetAssemblyOpt, declaredExternAliasesOpt) : "A" + import.AliasOpt + " U" + namespaceName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 13070, 13734);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 13070, 13734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 13493, 13715);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(438, 13500, 13534) || (((import.TargetAssemblyOpt != null) && DynAbs.Tracing.TraceSender.Conditional_F2(438, 13562, 13667)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 13695, 13714))) ? "E" + namespaceName + " " + f_438_13590_13667(this, import.TargetAssemblyOpt, declaredExternAliasesOpt) : "U" + namespaceName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 13070, 13734);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 12894, 13749);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 13765, 13803);

                f_438_13765_13802(import.AliasOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 13817, 13864);

                f_438_13817_13863(import.TargetAssemblyOpt == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 13878, 13907);

                return "X" + import.AliasOpt;
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 10047, 13918);

                Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                f_438_10381_10387()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 10381, 10387);
                    return return_v;
                }


                bool
                f_438_10381_10415(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GenerateVisualBasicStylePdb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 10381, 10415);
                    return return_v;
                }


                int
                f_438_10503_10549(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 10503, 10549);
                    return 0;
                }


                int
                f_438_10568_10614(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 10568, 10614);
                    return 0;
                }


                int
                f_438_10709_10756(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 10709, 10756);
                    return 0;
                }


                int
                f_438_10779_10825(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 10779, 10825);
                    return 0;
                }


                bool
                f_438_10943_10985(Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = typeReference.IsTypeSpecification();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 10943, 10985);
                    return return_v;
                }


                string
                f_438_11112_11163(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.GetOrCreateSerializedTypeName(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 11112, 11163);
                    return return_v;
                }


                string
                f_438_11657_11718(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.INamespace
                @namespace)
                {
                    var return_v = this_param.GetOrCreateSerializedNamespaceName(@namespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 11657, 11718);
                    return return_v;
                }


                int
                f_438_12118_12155(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 12118, 12155);
                    return 0;
                }


                int
                f_438_12174_12224(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 12174, 12224);
                    return 0;
                }


                int
                f_438_12373_12423(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 12373, 12423);
                    return 0;
                }


                int
                f_438_12506_12553(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 12506, 12553);
                    return 0;
                }


                int
                f_438_12572_12618(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 12572, 12618);
                    return 0;
                }


                string
                f_438_12657_12708(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.GetOrCreateSerializedTypeName(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 12657, 12708);
                    return return_v;
                }


                string
                f_438_12988_13049(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.INamespace
                @namespace)
                {
                    var return_v = this_param.GetOrCreateSerializedNamespaceName(@namespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 12988, 13049);
                    return return_v;
                }


                string
                f_438_13261_13338(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.IAssemblyReference
                assembly, System.Collections.Generic.HashSet<string>
                declaredExternAliases)
                {
                    var return_v = this_param.GetAssemblyReferenceAlias(assembly, declaredExternAliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 13261, 13338);
                    return return_v;
                }


                string
                f_438_13590_13667(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.IAssemblyReference
                assembly, System.Collections.Generic.HashSet<string>
                declaredExternAliases)
                {
                    var return_v = this_param.GetAssemblyReferenceAlias(assembly, declaredExternAliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 13590, 13667);
                    return return_v;
                }


                int
                f_438_13765_13802(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 13765, 13802);
                    return 0;
                }


                int
                f_438_13817_13863(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 13817, 13863);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 10047, 13918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 10047, 13918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetOrCreateSerializedNamespaceName(INamespace @namespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 13930, 14336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14028, 14042);

                string
                result
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14056, 14295) || true) && (!f_438_14061_14116(_qualifiedNameCache, @namespace, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 14056, 14295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14150, 14218);

                    result = f_438_14159_14217(@namespace);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14236, 14280);

                    f_438_14236_14279(_qualifiedNameCache, @namespace, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 14056, 14295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14311, 14325);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 13930, 14336);

                bool
                f_438_14061_14116(System.Collections.Generic.Dictionary<object, string>
                this_param, Microsoft.Cci.INamespace
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue((object)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 14061, 14116);
                    return return_v;
                }


                string
                f_438_14159_14217(Microsoft.Cci.INamespace
                @namespace)
                {
                    var return_v = TypeNameSerializer.BuildQualifiedNamespaceName(@namespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 14159, 14217);
                    return return_v;
                }


                int
                f_438_14236_14279(System.Collections.Generic.Dictionary<object, string>
                this_param, Microsoft.Cci.INamespace
                key, string
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 14236, 14279);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 13930, 14336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 13930, 14336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetOrCreateSerializedTypeName(ITypeReference typeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 14348, 14995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14448, 14462);

                string
                result
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14476, 14954) || true) && (!f_438_14481_14539(_qualifiedNameCache, typeReference, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 14476, 14954);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14573, 14872) || true) && (f_438_14577_14611(f_438_14577_14583()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 14573, 14872);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14653, 14717);

                        result = f_438_14662_14716(this, typeReference);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 14573, 14872);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 14573, 14872);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14799, 14853);

                        result = typeReference.GetSerializedTypeName(f_438_14844_14851());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 14573, 14872);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14892, 14939);

                    f_438_14892_14938(
                                    _qualifiedNameCache, typeReference, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 14476, 14954);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 14970, 14984);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 14348, 14995);

                bool
                f_438_14481_14539(System.Collections.Generic.Dictionary<object, string>
                this_param, Microsoft.Cci.ITypeReference
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue((object)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 14481, 14539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                f_438_14577_14583()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 14577, 14583);
                    return return_v;
                }


                bool
                f_438_14577_14611(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GenerateVisualBasicStylePdb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 14577, 14611);
                    return return_v;
                }


                string
                f_438_14662_14716(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.SerializeVisualBasicImportTypeReference(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 14662, 14716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_438_14844_14851()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 14844, 14851);
                    return return_v;
                }


                int
                f_438_14892_14938(System.Collections.Generic.Dictionary<object, string>
                this_param, Microsoft.Cci.ITypeReference
                key, string
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 14892, 14938);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 14348, 14995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 14348, 14995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string SerializeVisualBasicImportTypeReference(ITypeReference typeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 15007, 16911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15116, 15170);

                f_438_15116_15169(!(typeReference is IArrayTypeReference));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15184, 15240);

                f_438_15184_15239(!(typeReference is IPointerTypeReference));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15254, 15305);

                f_438_15254_15304(!f_438_15268_15303(typeReference));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15321, 15368);

                var
                result = f_438_15334_15367()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15382, 15423);

                ArrayBuilder<string>
                nestedNamesReversed
                = default(ArrayBuilder<string>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15439, 15509);

                INestedTypeReference
                nestedType = f_438_15473_15508(typeReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15523, 16054) || true) && (nestedType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 15523, 16054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15579, 15636);

                    nestedNamesReversed = f_438_15601_15635();
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15656, 15946) || true) && (nestedType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 15656, 15946);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15723, 15764);

                            f_438_15723_15763(nestedNamesReversed, f_438_15747_15762(nestedType));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15786, 15856);

                            typeReference = f_438_15802_15855(nestedType, _metadataWriter.Context);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 15878, 15927);

                            nestedType = f_438_15891_15926(typeReference);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 15656, 15946);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 15656, 15946);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(438, 15656, 15946);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 15523, 16054);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 15523, 16054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16012, 16039);

                    nestedNamesReversed = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 15523, 16054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16070, 16149);

                INamespaceTypeReference
                namespaceType = f_438_16110_16148(typeReference)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16163, 16199);

                f_438_16163_16198(namespaceType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16215, 16266);

                string
                namespaceName = f_438_16238_16265(namespaceType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16280, 16440) || true) && (f_438_16284_16304(namespaceName) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 16280, 16440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16343, 16380);

                    f_438_16343_16379(result.Builder, namespaceName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16398, 16425);

                    f_438_16398_16424(result.Builder, '.');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 16280, 16440);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16456, 16498);

                f_438_16456_16497(
                            result.Builder, f_438_16478_16496(namespaceType));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16514, 16852) || true) && (nestedNamesReversed != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 16514, 16852);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16588, 16621);
                        for (int
        i = f_438_16592_16617(nestedNamesReversed) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16579, 16790) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16631, 16634)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(438, 16579, 16790))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 16579, 16790);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16676, 16703);

                            f_438_16676_16702(result.Builder, '.');
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16725, 16771);

                            f_438_16725_16770(result.Builder, f_438_16747_16769(nestedNamesReversed, i));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 212);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 212);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16810, 16837);

                    f_438_16810_16836(
                                    nestedNamesReversed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 16514, 16852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 16868, 16900);

                return f_438_16875_16899(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 15007, 16911);

                int
                f_438_15116_15169(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 15116, 15169);
                    return 0;
                }


                int
                f_438_15184_15239(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 15184, 15239);
                    return 0;
                }


                bool
                f_438_15268_15303(Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = typeReference.IsTypeSpecification();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 15268, 15303);
                    return return_v;
                }


                int
                f_438_15254_15304(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 15254, 15304);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_438_15334_15367()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 15334, 15367);
                    return return_v;
                }


                Microsoft.Cci.INestedTypeReference?
                f_438_15473_15508(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 15473, 15508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_438_15601_15635()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 15601, 15635);
                    return return_v;
                }


                string?
                f_438_15747_15762(Microsoft.Cci.INestedTypeReference
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 15747, 15762);
                    return return_v;
                }


                int
                f_438_15723_15763(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 15723, 15763);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_438_15802_15855(Microsoft.Cci.INestedTypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetContainingType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 15802, 15855);
                    return return_v;
                }


                Microsoft.Cci.INestedTypeReference?
                f_438_15891_15926(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 15891, 15926);
                    return return_v;
                }


                Microsoft.Cci.INamespaceTypeReference?
                f_438_16110_16148(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNamespaceTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 16110, 16148);
                    return return_v;
                }


                int
                f_438_16163_16198(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 16163, 16198);
                    return 0;
                }


                string
                f_438_16238_16265(Microsoft.Cci.INamespaceTypeReference
                this_param)
                {
                    var return_v = this_param.NamespaceName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 16238, 16265);
                    return return_v;
                }


                int
                f_438_16284_16304(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 16284, 16304);
                    return return_v;
                }


                System.Text.StringBuilder
                f_438_16343_16379(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 16343, 16379);
                    return return_v;
                }


                System.Text.StringBuilder
                f_438_16398_16424(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 16398, 16424);
                    return return_v;
                }


                string?
                f_438_16478_16496(Microsoft.Cci.INamespaceTypeReference
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 16478, 16496);
                    return return_v;
                }


                System.Text.StringBuilder
                f_438_16456_16497(System.Text.StringBuilder
                this_param, string?
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 16456, 16497);
                    return return_v;
                }


                int
                f_438_16592_16617(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 16592, 16617);
                    return return_v;
                }


                System.Text.StringBuilder
                f_438_16676_16702(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 16676, 16702);
                    return return_v;
                }


                string
                f_438_16747_16769(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 16747, 16769);
                    return return_v;
                }


                System.Text.StringBuilder
                f_438_16725_16770(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 16725, 16770);
                    return return_v;
                }


                int
                f_438_16810_16836(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 16810, 16836);
                    return 0;
                }


                string
                f_438_16875_16899(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 16875, 16899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 15007, 16911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 15007, 16911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetAssemblyReferenceAlias(IAssemblyReference assembly, HashSet<string> declaredExternAliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 16923, 18532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 17133, 17177);

                f_438_17133_17176(declaredExternAliases != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 17193, 17294);

                var
                allAliases = f_438_17210_17293(_metadataWriter.Context.Module, _metadataWriter.Context)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 17308, 18386);
                    foreach (AssemblyReferenceAlias alias in f_438_17349_17359_I(allAliases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 17308, 18386);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 18216, 18371) || true) && (assembly == alias.Assembly && (DynAbs.Tracing.TraceSender.Expression_True(438, 18220, 18292) && f_438_18250_18292(declaredExternAliases, alias.Name)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 18216, 18371);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 18334, 18352);

                            return alias.Name;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 18216, 18371);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 17308, 18386);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 1079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 1079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 18484, 18521);

                throw f_438_18490_18520();
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 16923, 18532);

                int
                f_438_17133_17176(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 17133, 17176);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                f_438_17210_17293(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAssemblyReferenceAliases(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 17210, 17293);
                    return return_v;
                }


                bool
                f_438_18250_18292(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 18250, 18292);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                f_438_17349_17359_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 17349, 17359);
                    return return_v;
                }


                System.Exception
                f_438_18490_18520()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 18490, 18520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 16923, 18532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 16923, 18532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DefineLocalScopes(ImmutableArray<LocalScope> scopes, StandaloneSignatureHandle localSignatureHandleOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 18544, 20166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 18735, 18795);

                bool
                endInclusive = f_438_18755_18794(f_438_18755_18766(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 18902, 18958);

                var
                scopeStack = f_438_18919_18957()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 18983, 18988);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 18974, 19843) || true) && (i < scopes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19009, 19012)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(438, 18974, 19843))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 18974, 19843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19046, 19075);

                        var
                        currentScope = scopes[i]
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19152, 19602) || true) && (f_438_19159_19175(scopeStack) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 19152, 19602);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19221, 19261);

                                LocalScope
                                topScope = f_438_19243_19260(scopeStack)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19283, 19431) || true) && (currentScope.StartOffset < topScope.StartOffset + topScope.Length)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 19283, 19431);
                                    DynAbs.Tracing.TraceSender.TraceBreak(438, 19402, 19408);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 19283, 19431);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19455, 19479);

                                f_438_19455_19478(
                                                    scopeStack);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19501, 19583);

                                f_438_19501_19582(_symWriter, (DynAbs.Tracing.TraceSender.Conditional_F1(438, 19523, 19535) || ((endInclusive && DynAbs.Tracing.TraceSender.Conditional_F2(438, 19538, 19560)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 19563, 19581))) ? topScope.EndOffset - 1 : topScope.EndOffset);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(438, 19152, 19602);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 19152, 19602);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(438, 19152, 19602);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19659, 19688);

                        f_438_19659_19687(
                                        // Open this scope.
                                        scopeStack, currentScope);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19706, 19753);

                        f_438_19706_19752(_symWriter, currentScope.StartOffset);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19771, 19828);

                        f_438_19771_19827(this, currentScope, localSignatureHandleOpt);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 870);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 870);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19908, 19932);

                    // Close remaining scopes.
                    for (int
        i = f_438_19912_19928(scopeStack) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19899, 20121) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19942, 19945)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(438, 19899, 20121))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 19899, 20121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 19979, 20012);

                        LocalScope
                        scope = f_438_19998_20011(scopeStack, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 20030, 20106);

                        f_438_20030_20105(_symWriter, (DynAbs.Tracing.TraceSender.Conditional_F1(438, 20052, 20064) || ((endInclusive && DynAbs.Tracing.TraceSender.Conditional_F2(438, 20067, 20086)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 20089, 20104))) ? scope.EndOffset - 1 : scope.EndOffset);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 20137, 20155);

                f_438_20137_20154(
                            scopeStack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 18544, 20166);

                Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                f_438_18755_18766(Microsoft.Cci.PdbWriter
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 18755, 18766);
                    return return_v;
                }


                bool
                f_438_18755_18794(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GenerateVisualBasicStylePdb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 18755, 18794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                f_438_18919_18957()
                {
                    var return_v = ArrayBuilder<LocalScope>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 18919, 18957);
                    return return_v;
                }


                int
                f_438_19159_19175(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 19159, 19175);
                    return return_v;
                }


                Microsoft.Cci.LocalScope
                f_438_19243_19260(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                this_param)
                {
                    var return_v = this_param.Last();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 19243, 19260);
                    return return_v;
                }


                int
                f_438_19455_19478(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                this_param)
                {
                    this_param.RemoveLast();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 19455, 19478);
                    return 0;
                }


                int
                f_438_19501_19582(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, int
                endOffset)
                {
                    this_param.CloseScope(endOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 19501, 19582);
                    return 0;
                }


                int
                f_438_19659_19687(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                this_param, Microsoft.Cci.LocalScope
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 19659, 19687);
                    return 0;
                }


                int
                f_438_19706_19752(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, int
                startOffset)
                {
                    this_param.OpenScope(startOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 19706, 19752);
                    return 0;
                }


                int
                f_438_19771_19827(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.LocalScope
                currentScope, System.Reflection.Metadata.StandaloneSignatureHandle
                localSignatureHandleOpt)
                {
                    this_param.DefineScopeLocals(currentScope, localSignatureHandleOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 19771, 19827);
                    return 0;
                }


                int
                f_438_19912_19928(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 19912, 19928);
                    return return_v;
                }


                Microsoft.Cci.LocalScope
                f_438_19998_20011(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 19998, 20011);
                    return return_v;
                }


                int
                f_438_20030_20105(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, int
                endOffset)
                {
                    this_param.CloseScope(endOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 20030, 20105);
                    return 0;
                }


                int
                f_438_20137_20154(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 20137, 20154);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 18544, 20166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 18544, 20166);
            }
        }

        private void DefineScopeLocals(LocalScope currentScope, StandaloneSignatureHandle localSignatureHandleOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 20178, 21460);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 20309, 20858);
                    foreach (ILocalDefinition scopeConstant in f_438_20352_20374_I(currentScope.Constants))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 20309, 20858);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 20408, 20503);

                        var
                        signatureHandle = f_438_20430_20502(_metadataWriter, scopeConstant)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 20521, 20843) || true) && (!f_438_20526_20575(_metadataWriter, scopeConstant))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 20521, 20843);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 20617, 20824);

                            f_438_20617_20823(_symWriter, f_438_20674_20692(scopeConstant), f_438_20719_20755(f_438_20719_20749(scopeConstant)), f_438_20782_20822(signatureHandle));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 20521, 20843);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 20309, 20858);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 550);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 550);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 20874, 21449);
                    foreach (ILocalDefinition scopeLocal in f_438_20914_20936_I(currentScope.Variables))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 20874, 21449);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 20970, 21434) || true) && (!f_438_20975_21021(_metadataWriter, scopeLocal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 20970, 21434);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 21063, 21103);

                            f_438_21063_21102(f_438_21076_21096(scopeLocal) >= 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 21127, 21415);

                            f_438_21127_21414(
                                                _symWriter, f_438_21184_21204(scopeLocal), f_438_21231_21246(scopeLocal), f_438_21278_21302(scopeLocal), (DynAbs.Tracing.TraceSender.Conditional_F1(438, 21329, 21358) || ((localSignatureHandleOpt.IsNil && DynAbs.Tracing.TraceSender.Conditional_F2(438, 21361, 21362)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 21365, 21413))) ? 0 : f_438_21365_21413(localSignatureHandleOpt));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 20970, 21434);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 20874, 21449);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 576);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 576);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 20178, 21460);

                System.Reflection.Metadata.StandaloneSignatureHandle
                f_438_20430_20502(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ILocalDefinition
                localConstant)
                {
                    var return_v = this_param.SerializeLocalConstantStandAloneSignature(localConstant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 20430, 20502);
                    return return_v;
                }


                bool
                f_438_20526_20575(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ILocalDefinition
                localDefinition)
                {
                    var return_v = this_param.IsLocalNameTooLong(localDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 20526, 20575);
                    return return_v;
                }


                string?
                f_438_20674_20692(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 20674, 20692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_438_20719_20749(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.CompileTimeValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 20719, 20749);
                    return return_v;
                }


                object?
                f_438_20719_20755(Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 20719, 20755);
                    return return_v;
                }


                int
                f_438_20782_20822(System.Reflection.Metadata.StandaloneSignatureHandle
                handle)
                {
                    var return_v = MetadataTokens.GetToken((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 20782, 20822);
                    return return_v;
                }


                bool
                f_438_20617_20823(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, string?
                name, object?
                value, int
                constantSignatureToken)
                {
                    var return_v = this_param.DefineLocalConstant(name, value, constantSignatureToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 20617, 20823);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_438_20352_20374_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 20352, 20374);
                    return return_v;
                }


                bool
                f_438_20975_21021(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ILocalDefinition
                localDefinition)
                {
                    var return_v = this_param.IsLocalNameTooLong(localDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 20975, 21021);
                    return return_v;
                }


                int
                f_438_21076_21096(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.SlotIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 21076, 21096);
                    return return_v;
                }


                int
                f_438_21063_21102(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 21063, 21102);
                    return 0;
                }


                int
                f_438_21184_21204(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.SlotIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 21184, 21204);
                    return return_v;
                }


                string?
                f_438_21231_21246(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 21231, 21246);
                    return return_v;
                }


                System.Reflection.Metadata.LocalVariableAttributes
                f_438_21278_21302(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.PdbAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 21278, 21302);
                    return return_v;
                }


                int
                f_438_21365_21413(System.Reflection.Metadata.StandaloneSignatureHandle
                handle)
                {
                    var return_v = MetadataTokens.GetToken((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 21365, 21413);
                    return return_v;
                }


                int
                f_438_21127_21414(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, int
                index, string?
                name, System.Reflection.Metadata.LocalVariableAttributes
                attributes, int
                localSignatureToken)
                {
                    this_param.DefineLocalVariable(index, name, (int)attributes, localSignatureToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 21127, 21414);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_438_20914_20936_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 20914, 20936);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 20178, 21460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 20178, 21460);
            }
        }

        public void SetMetadataEmitter(MetadataWriter metadataWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 21472, 22970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 21671, 21897);

                var
                options =
                                ((DynAbs.Tracing.TraceSender.Conditional_F1(438, 21703, 21718) || ((f_438_21703_21718() && DynAbs.Tracing.TraceSender.Conditional_F2(438, 21721, 21768)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 21771, 21819))) ? SymUnmanagedWriterCreationOptions.Deterministic : SymUnmanagedWriterCreationOptions.UseComRegistry) |
                                SymUnmanagedWriterCreationOptions.UseAlternativeLoadPath
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 21913, 21982);

                var
                metadataProvider = f_438_21936_21981(metadataWriter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 21998, 22027);

                SymUnmanagedWriter
                symWriter
                = default(SymUnmanagedWriter);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 22077, 22223);

                    symWriter = (DynAbs.Tracing.TraceSender.Conditional_F1(438, 22089, 22116) || (((_symWriterFactory != null) && DynAbs.Tracing.TraceSender.Conditional_F2(438, 22119, 22154)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 22157, 22222))) ? f_438_22119_22154(this, metadataProvider) : f_438_22157_22222(metadataProvider, options);
                }
                catch (DllNotFoundException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(438, 22252, 22379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 22315, 22364);

                    throw f_438_22321_22363(f_438_22353_22362(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(438, 22252, 22379);
                }
                catch (SymUnmanagedWriterException e) when (f_438_22437_22453(e) is NotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(438, 22393, 22773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 22512, 22650);

                    var
                    message = (DynAbs.Tracing.TraceSender.Conditional_F1(438, 22526, 22541) || ((f_438_22526_22541() && DynAbs.Tracing.TraceSender.Conditional_F2(438, 22544, 22591)) || DynAbs.Tracing.TraceSender.Conditional_F3(438, 22594, 22649))) ? f_438_22544_22591() : f_438_22594_22649()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 22668, 22758);

                    throw f_438_22674_22757(f_438_22706_22756(message, f_438_22729_22755(e)));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(438, 22393, 22773);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 22789, 22822);

                _metadataWriter = metadataWriter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 22836, 22859);

                _symWriter = symWriter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 22873, 22959);

                _sequencePointsWriter = f_438_22897_22958(symWriter, capacity: 64);
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 21472, 22970);

                bool
                f_438_21703_21718()
                {
                    var return_v = IsDeterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 21703, 21718);
                    return return_v;
                }


                Microsoft.Cci.SymWriterMetadataProvider
                f_438_21936_21981(Microsoft.Cci.MetadataWriter
                writer)
                {
                    var return_v = new Microsoft.Cci.SymWriterMetadataProvider(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 21936, 21981);
                    return return_v;
                }


                Microsoft.DiaSymReader.SymUnmanagedWriter
                f_438_22119_22154(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.SymWriterMetadataProvider
                arg)
                {
                    var return_v = this_param._symWriterFactory((Microsoft.DiaSymReader.ISymWriterMetadataProvider)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 22119, 22154);
                    return return_v;
                }


                Microsoft.DiaSymReader.SymUnmanagedWriter
                f_438_22157_22222(Microsoft.Cci.SymWriterMetadataProvider
                metadataProvider, Microsoft.DiaSymReader.SymUnmanagedWriterCreationOptions
                options)
                {
                    var return_v = SymUnmanagedWriterFactory.CreateWriter((Microsoft.DiaSymReader.ISymWriterMetadataProvider)metadataProvider, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 22157, 22222);
                    return return_v;
                }


                string
                f_438_22353_22362(System.DllNotFoundException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 22353, 22362);
                    return return_v;
                }


                Microsoft.DiaSymReader.SymUnmanagedWriterException
                f_438_22321_22363(string
                message)
                {
                    var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 22321, 22363);
                    return return_v;
                }


                System.Exception?
                f_438_22437_22453(Microsoft.DiaSymReader.SymUnmanagedWriterException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 22437, 22453);
                    return return_v;
                }


                bool
                f_438_22526_22541()
                {
                    var return_v = IsDeterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 22526, 22541);
                    return return_v;
                }


                string
                f_438_22544_22591()
                {
                    var return_v = CodeAnalysisResources.SymWriterNotDeterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 22544, 22591);
                    return return_v;
                }


                string
                f_438_22594_22649()
                {
                    var return_v = CodeAnalysisResources.SymWriterOlderVersionThanRequired;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 22594, 22649);
                    return return_v;
                }


                string
                f_438_22729_22755(Microsoft.DiaSymReader.SymUnmanagedWriterException
                this_param)
                {
                    var return_v = this_param.ImplementationModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 22729, 22755);
                    return return_v;
                }


                string
                f_438_22706_22756(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 22706, 22756);
                    return return_v;
                }


                Microsoft.DiaSymReader.SymUnmanagedWriterException
                f_438_22674_22757(string
                message)
                {
                    var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 22674, 22757);
                    return return_v;
                }


                Microsoft.DiaSymReader.SymUnmanagedSequencePointsWriter
                f_438_22897_22958(Microsoft.DiaSymReader.SymUnmanagedWriter
                writer, int
                capacity)
                {
                    var return_v = new Microsoft.DiaSymReader.SymUnmanagedSequencePointsWriter(writer, capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 22897, 22958);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 21472, 22970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 21472, 22970);
            }
        }

        public BlobContentId GetContentId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 22982, 24083);
                System.Guid guid = default(System.Guid);
                uint stamp = default(uint);
                int age = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 23042, 23066);

                BlobContentId
                contentId
                = default(BlobContentId);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 23082, 23800) || true) && (f_438_23086_23101())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 23082, 23800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 23330, 23459);

                    contentId = BlobContentId.FromHash(f_438_23365_23457(_hashAlgorithmNameOpt, f_438_23426_23456(_symWriter)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 23479, 23547);

                    f_438_23479_23546(
                                    _symWriter, contentId.Guid, contentId.Stamp, age: 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 23082, 23800);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 23082, 23800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 23613, 23681);

                    f_438_23613_23680(_symWriter, out guid, out stamp, out age);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 23699, 23724);

                    f_438_23699_23723(age == Age);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 23742, 23785);

                    contentId = f_438_23754_23784(guid, stamp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 23082, 23800);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24018, 24039);

                f_438_24018_24038(
                            // Once we calculate the content id we shall not write more data to the writer.
                            // Note that the underlying stream is accessible for reading even after the writer is disposed.
                            _symWriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24055, 24072);

                return contentId;
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 22982, 24083);

                bool
                f_438_23086_23101()
                {
                    var return_v = IsDeterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 23086, 23101);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.ArraySegment<byte>>
                f_438_23426_23456(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param)
                {
                    var return_v = this_param.GetUnderlyingData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 23426, 23456);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_438_23365_23457(System.Security.Cryptography.HashAlgorithmName
                algorithmName, System.Collections.Generic.IEnumerable<System.ArraySegment<byte>>
                bytes)
                {
                    var return_v = CryptographicHashProvider.ComputeHash(algorithmName, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 23365, 23457);
                    return return_v;
                }


                int
                f_438_23479_23546(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, System.Guid
                guid, uint
                stamp, int
                age)
                {
                    this_param.UpdateSignature(guid, stamp, age: age);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 23479, 23546);
                    return 0;
                }


                int
                f_438_23613_23680(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, out System.Guid
                guid, out uint
                stamp, out int
                age)
                {
                    this_param.GetSignature(out guid, out stamp, out age);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 23613, 23680);
                    return 0;
                }


                int
                f_438_23699_23723(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 23699, 23723);
                    return 0;
                }


                System.Reflection.Metadata.BlobContentId
                f_438_23754_23784(System.Guid
                guid, uint
                stamp)
                {
                    var return_v = new System.Reflection.Metadata.BlobContentId(guid, stamp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 23754, 23784);
                    return return_v;
                }


                int
                f_438_24018_24038(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 24018, 24038);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 22982, 24083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 22982, 24083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void SetEntryPoint(int entryMethodToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 24095, 24221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24167, 24210);

                f_438_24167_24209(_symWriter, entryMethodToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 24095, 24221);

                int
                f_438_24167_24209(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, int
                entryMethodToken)
                {
                    this_param.SetEntryPoint(entryMethodToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 24167, 24209);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 24095, 24221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 24095, 24221);
            }
        }

        private int GetDocumentIndex(DebugSourceDocument document)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 24233, 24510);
                int documentIndex = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24316, 24449) || true) && (f_438_24320_24379(_documentIndex, document, out documentIndex))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 24316, 24449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24413, 24434);

                    return documentIndex;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 24316, 24449);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24465, 24499);

                return f_438_24472_24498(this, document);
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 24233, 24510);

                bool
                f_438_24320_24379(System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>
                this_param, Microsoft.Cci.DebugSourceDocument
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 24320, 24379);
                    return return_v;
                }


                int
                f_438_24472_24498(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.DebugSourceDocument
                document)
                {
                    var return_v = this_param.AddDocumentIndex(document);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 24472, 24498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 24233, 24510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 24233, 24510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int AddDocumentIndex(DebugSourceDocument document)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 24522, 25730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24605, 24622);

                Guid
                algorithmId
                = default(Guid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24636, 24664);

                ReadOnlySpan<byte>
                checksum
                = default(ReadOnlySpan<byte>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24678, 24712);

                ReadOnlySpan<byte>
                embeddedSource
                = default(ReadOnlySpan<byte>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24728, 24776);

                DebugSourceInfo
                info = f_438_24751_24775(document)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24790, 25080) || true) && (f_438_24794_24818_M(!info.Checksum.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 24790, 25080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24852, 24891);

                    algorithmId = info.ChecksumAlgorithmId;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 24909, 24943);

                    checksum = info.Checksum.AsSpan();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 24790, 25080);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 24790, 25080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 25009, 25031);

                    algorithmId = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 25049, 25065);

                    checksum = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 24790, 25080);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 25096, 25317) || true) && (f_438_25100_25132_M(!info.EmbeddedTextBlob.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 25096, 25317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 25166, 25214);

                    embeddedSource = info.EmbeddedTextBlob.AsSpan();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 25096, 25317);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 25096, 25317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 25280, 25302);

                    embeddedSource = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 25096, 25317);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 25333, 25624);

                int
                documentIndex = f_438_25353_25623(_symWriter, f_438_25397_25414(document), f_438_25433_25450(document), f_438_25469_25492(document), f_438_25511_25532(document), algorithmId, checksum, embeddedSource)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 25640, 25684);

                f_438_25640_25683(
                            _documentIndex, document, documentIndex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 25698, 25719);

                return documentIndex;
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 24522, 25730);

                Microsoft.Cci.DebugSourceInfo
                f_438_24751_24775(Microsoft.Cci.DebugSourceDocument
                this_param)
                {
                    var return_v = this_param.GetSourceInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 24751, 24775);
                    return return_v;
                }


                bool
                f_438_24794_24818_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 24794, 24818);
                    return return_v;
                }


                bool
                f_438_25100_25132_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 25100, 25132);
                    return return_v;
                }


                string
                f_438_25397_25414(Microsoft.Cci.DebugSourceDocument
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 25397, 25414);
                    return return_v;
                }


                System.Guid
                f_438_25433_25450(Microsoft.Cci.DebugSourceDocument
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 25433, 25450);
                    return return_v;
                }


                System.Guid
                f_438_25469_25492(Microsoft.Cci.DebugSourceDocument
                this_param)
                {
                    var return_v = this_param.LanguageVendor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 25469, 25492);
                    return return_v;
                }


                System.Guid
                f_438_25511_25532(Microsoft.Cci.DebugSourceDocument
                this_param)
                {
                    var return_v = this_param.DocumentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 25511, 25532);
                    return return_v;
                }


                int
                f_438_25353_25623(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, string
                name, System.Guid
                language, System.Guid
                vendor, System.Guid
                type, System.Guid
                algorithmId, System.ReadOnlySpan<byte>
                checksum, System.ReadOnlySpan<byte>
                source)
                {
                    var return_v = this_param.DefineDocument(name, language, vendor, type, algorithmId, checksum, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 25353, 25623);
                    return return_v;
                }


                int
                f_438_25640_25683(System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>
                this_param, Microsoft.Cci.DebugSourceDocument
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 25640, 25683);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 24522, 25730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 24522, 25730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void OpenMethod(int methodToken, IMethodDefinition method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 25742, 25970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 25833, 25868);

                f_438_25833_25867(_symWriter, methodToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 25922, 25959);

                f_438_25922_25958(
                            // open outermost scope:
                            _symWriter, startOffset: 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 25742, 25970);

                int
                f_438_25833_25867(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, int
                methodToken)
                {
                    this_param.OpenMethod(methodToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 25833, 25867);
                    return 0;
                }


                int
                f_438_25922_25958(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, int
                startOffset)
                {
                    this_param.OpenScope(startOffset: startOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 25922, 25958);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 25742, 25970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 25742, 25970);
            }
        }

        private void CloseMethod(int ilLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 25982, 26178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26083, 26126);

                f_438_26083_26125(            // close the root scope:
                            _symWriter, endOffset: ilLength);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26142, 26167);

                f_438_26142_26166(
                            _symWriter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 25982, 26178);

                int
                f_438_26083_26125(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, int
                endOffset)
                {
                    this_param.CloseScope(endOffset: endOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 26083, 26125);
                    return 0;
                }


                int
                f_438_26142_26166(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param)
                {
                    this_param.CloseMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 26142, 26166);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 25982, 26178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 25982, 26178);
            }
        }

        private void UsingNamespace(string fullName, INamedEntity errorEntity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 26190, 26445);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26285, 26434) || true) && (!f_438_26290_26349(_metadataWriter, fullName, errorEntity))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 26285, 26434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26383, 26419);

                    f_438_26383_26418(_symWriter, fullName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 26285, 26434);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 26190, 26445);

                bool
                f_438_26290_26349(Microsoft.Cci.MetadataWriter
                this_param, string
                usingString, Microsoft.Cci.INamedEntity
                errorEntity)
                {
                    var return_v = this_param.IsUsingStringTooLong(usingString, errorEntity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 26290, 26349);
                    return return_v;
                }


                int
                f_438_26383_26418(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, string
                importString)
                {
                    this_param.UsingNamespace(importString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 26383, 26418);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 26190, 26445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 26190, 26445);
            }
        }

        private void EmitSequencePoints(ImmutableArray<SequencePoint> sequencePoints)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 26457, 27593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26559, 26586);

                int
                lastDocumentIndex = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26600, 26640);

                DebugSourceDocument
                lastDocument = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26656, 27536);
                    foreach (var sequencePoint in f_438_26686_26700_I(sequencePoints))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 26656, 27536);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26734, 26779);

                        f_438_26734_26778(sequencePoint.Document != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26799, 26837);

                        var
                        document = sequencePoint.Document
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26857, 26875);

                        int
                        documentIndex
                        = default(int);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26893, 27211) || true) && (lastDocument == document)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 26893, 27211);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 26963, 26997);

                            documentIndex = lastDocumentIndex;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 26893, 27211);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 26893, 27211);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 27079, 27103);

                            lastDocument = document;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 27125, 27192);

                            documentIndex = lastDocumentIndex = f_438_27161_27191(this, lastDocument);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(438, 26893, 27211);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 27231, 27521);

                        f_438_27231_27520(
                                        _sequencePointsWriter, documentIndex, sequencePoint.Offset, sequencePoint.StartLine, sequencePoint.StartColumn, sequencePoint.EndLine, sequencePoint.EndColumn);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 26656, 27536);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 27552, 27582);

                f_438_27552_27581(
                            _sequencePointsWriter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 26457, 27593);

                int
                f_438_26734_26778(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 26734, 26778);
                    return 0;
                }


                int
                f_438_27161_27191(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.DebugSourceDocument
                document)
                {
                    var return_v = this_param.GetDocumentIndex(document);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 27161, 27191);
                    return return_v;
                }


                int
                f_438_27231_27520(Microsoft.DiaSymReader.SymUnmanagedSequencePointsWriter
                this_param, int
                documentIndex, int
                offset, int
                startLine, ushort
                startColumn, int
                endLine, ushort
                endColumn)
                {
                    this_param.Add(documentIndex, offset, startLine, (int)startColumn, endLine, (int)endColumn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 27231, 27520);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.SequencePoint>
                f_438_26686_26700_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.SequencePoint>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 26686, 26700);
                    return return_v;
                }


                int
                f_438_27552_27581(Microsoft.DiaSymReader.SymUnmanagedSequencePointsWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 27552, 27581);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 26457, 27593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 26457, 27593);
            }
        }

        [Conditional("DEBUG")]
        // Used to catch cases where file2definitions contain nonwritable definitions early
        // If left unfixed, such scenarios will lead to crashes if happen in winmdobj projects
        public void AssertAllDefinitionsHaveTokens(MultiDictionary<DebugSourceDocument, DefinitionWithLocation> file2definitions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 27605, 28296);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 27972, 28285);
                    foreach (var kvp in f_438_27992_28008_I(file2definitions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 27972, 28285);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 28042, 28270);
                            foreach (var definition in f_438_28069_28078_I(kvp.Value))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 28042, 28270);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 28120, 28201);

                                EntityHandle
                                handle = f_438_28142_28200(_metadataWriter, definition.Definition)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 28223, 28251);

                                f_438_28223_28250(f_438_28236_28249_M(!handle.IsNil));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(438, 28042, 28270);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 229);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 229);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 27972, 28285);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 314);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 27605, 28296);

                System.Reflection.Metadata.EntityHandle
                f_438_28142_28200(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IDefinition
                definition)
                {
                    var return_v = this_param.GetDefinitionHandle(definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 28142, 28200);
                    return return_v;
                }


                bool
                f_438_28236_28249_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 28236, 28249);
                    return return_v;
                }


                int
                f_438_28223_28250(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 28223, 28250);
                    return 0;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>.ValueSet
                f_438_28069_28078_I(Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 28069, 28078);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                f_438_27992_28008_I(Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 27992, 28008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 27605, 28296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 27605, 28296);
            }
        }

        public void WriteDefinitionLocations(MultiDictionary<DebugSourceDocument, DefinitionWithLocation> file2definitions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 28346, 29567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 28554, 28572);

                bool
                open = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 28588, 29442);
                    foreach (var kvp in f_438_28608_28624_I(file2definitions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 28588, 29442);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 28658, 29427);
                            foreach (var definition in f_438_28685_28694_I(kvp.Value))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 28658, 29427);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 28736, 28896) || true) && (!open)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 28736, 28896);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 28795, 28835);

                                    f_438_28795_28834(_symWriter);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 28861, 28873);

                                    open = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 28736, 28896);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 28920, 29016);

                                int
                                token = f_438_28932_29015(f_438_28956_29014(_metadataWriter, definition.Definition))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 29038, 29063);

                                f_438_29038_29062(token != 0);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 29087, 29408);

                                f_438_29087_29407(
                                                    _symWriter, token, f_438_29177_29202(this, kvp.Key), definition.StartLine + 1, definition.StartColumn + 1, definition.EndLine + 1, definition.EndColumn + 1);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(438, 28658, 29427);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 770);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 770);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 28588, 29442);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 855);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 29458, 29556) || true) && (open)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 29458, 29556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 29500, 29541);

                    f_438_29500_29540(_symWriter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(438, 29458, 29556);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 28346, 29567);

                int
                f_438_28795_28834(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param)
                {
                    this_param.OpenTokensToSourceSpansMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 28795, 28834);
                    return 0;
                }


                System.Reflection.Metadata.EntityHandle
                f_438_28956_29014(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IDefinition
                definition)
                {
                    var return_v = this_param.GetDefinitionHandle(definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 28956, 29014);
                    return return_v;
                }


                int
                f_438_28932_29015(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = MetadataTokens.GetToken(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 28932, 29015);
                    return return_v;
                }


                int
                f_438_29038_29062(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 29038, 29062);
                    return 0;
                }


                int
                f_438_29177_29202(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.DebugSourceDocument
                document)
                {
                    var return_v = this_param.GetDocumentIndex(document);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 29177, 29202);
                    return return_v;
                }


                int
                f_438_29087_29407(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, int
                token, int
                documentIndex, int
                startLine, int
                startColumn, int
                endLine, int
                endColumn)
                {
                    this_param.MapTokenToSourceSpan(token, documentIndex, startLine, startColumn, endLine, endColumn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 29087, 29407);
                    return 0;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>.ValueSet
                f_438_28685_28694_I(Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 28685, 28694);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                f_438_28608_28624_I(Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 28608, 28624);
                    return return_v;
                }


                int
                f_438_29500_29540(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param)
                {
                    this_param.CloseTokensToSourceSpansMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 29500, 29540);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 28346, 29567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 28346, 29567);
            }
        }

        public void EmbedSourceLink(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 29579, 30289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 29646, 29659);

                byte[]
                bytes
                = default(byte[]);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 29711, 29741);

                    bytes = f_438_29719_29740(stream);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(438, 29770, 29889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 29822, 29874);

                    throw f_438_29828_29873(f_438_29860_29869(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(438, 29770, 29889);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 29941, 29977);

                    f_438_29941_29976(_symWriter, bytes);
                }
                catch (SymUnmanagedWriterException e) when (f_438_30050_30066(e) is NotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(438, 30006, 30278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 30125, 30263);

                    throw f_438_30131_30262(f_438_30163_30261(f_438_30177_30232(), f_438_30234_30260(e)));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(438, 30006, 30278);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 29579, 30289);

                byte[]
                f_438_29719_29740(System.IO.Stream
                stream)
                {
                    var return_v = stream.ReadAllBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 29719, 29740);
                    return return_v;
                }


                string
                f_438_29860_29869(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 29860, 29869);
                    return return_v;
                }


                Microsoft.DiaSymReader.SymUnmanagedWriterException
                f_438_29828_29873(string
                message, System.Exception
                innerException)
                {
                    var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 29828, 29873);
                    return return_v;
                }


                int
                f_438_29941_29976(Microsoft.DiaSymReader.SymUnmanagedWriter
                this_param, byte[]
                data)
                {
                    this_param.SetSourceLinkData(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 29941, 29976);
                    return 0;
                }


                System.Exception?
                f_438_30050_30066(Microsoft.DiaSymReader.SymUnmanagedWriterException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 30050, 30066);
                    return return_v;
                }


                string
                f_438_30177_30232()
                {
                    var return_v = CodeAnalysisResources.SymWriterDoesNotSupportSourceLink;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 30177, 30232);
                    return return_v;
                }


                string
                f_438_30234_30260(Microsoft.DiaSymReader.SymUnmanagedWriterException
                this_param)
                {
                    var return_v = this_param.ImplementationModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 30234, 30260);
                    return return_v;
                }


                string
                f_438_30163_30261(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 30163, 30261);
                    return return_v;
                }


                Microsoft.DiaSymReader.SymUnmanagedWriterException
                f_438_30131_30262(string
                message)
                {
                    var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 30131, 30262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 29579, 30289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 29579, 30289);
            }
        }

        public void WriteRemainingDebugDocuments(IReadOnlyDictionary<string, DebugSourceDocument> documents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(438, 30656, 31011);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 30781, 31000);
                    foreach (var kvp in f_438_30801_30923_I(f_438_30801_30923(f_438_30801_30881(documents
                    , kvp => !_documentIndex.ContainsKey(kvp.Value)), kvp => kvp.Key)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(438, 30781, 31000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 30957, 30985);

                        f_438_30957_30984(this, kvp.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(438, 30781, 31000);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(438, 1, 220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(438, 1, 220);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(438, 30656, 31011);

                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>
                f_438_30801_30881(System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.DebugSourceDocument>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>, bool>
                predicate)
                {
                    var return_v = source.Where<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 30801, 30881);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>
                f_438_30801_30923(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>, string>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 30801, 30923);
                    return return_v;
                }


                int
                f_438_30957_30984(Microsoft.Cci.PdbWriter
                this_param, Microsoft.Cci.DebugSourceDocument
                document)
                {
                    var return_v = this_param.AddDocumentIndex(document);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 30957, 30984);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>
                f_438_30801_30923_I(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 30801, 30923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(438, 30656, 31011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 30656, 31011);
            }
        }

        static PdbWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(438, 698, 31018);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(438, 780, 787);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(438, 698, 31018);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(438, 698, 31018);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(438, 698, 31018);

        static System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>
        f_438_1857_1899()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 1857, 1899);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<object, string>
        f_438_1936_2002(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<object, string>((System.Collections.Generic.IEqualityComparer<object>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(438, 1936, 2002);
            return return_v;
        }


        Microsoft.CodeAnalysis.Emit.EmitContext
        f_438_2266_2273()
        {
            var return_v = Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(438, 2266, 2273);
            return return_v;
        }

    }
}
